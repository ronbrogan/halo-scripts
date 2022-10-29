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
            this.stress = GetTag<EffectTag>("effects\\scenery\\sparks\\sparking_light", 4231141861U);
            this.boom = GetTag<EffectTag>("effects\\scenarios\\solo\\alphagasgiant\\wall_explosion", 4231338472U);
            this.gravity = 0F;
            this.cables_cuttable = true;
            this.in_cable_room = false;
            this.croom_sen_total = 0;
            this.croom_flood_total = 0;
            this.croom_flood_desired = 6;
            this.croom_sen_desired = 4;
            this.cable_var = 0;
            this.gasleak = GetTag<EffectTag>("effects\\scenarios\\solo\\alphagasgiant\\gas_leak", 3907454833U);
            this.big_boom = GetTag<EffectTag>("effects\\scenarios\\solo\\alphagasgiant\\wall_explosion", 4231338472U);
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
            this.holo_death = GetTag<EffectTag>("effects\\scenarios\\objects\\solo\\alphagasgiant\\holo_drone\\drone_death", 3920431159U);
            this.holo_drones_nuke = false;
            this.hl_times_dead = 0;
            this.hl_lives_total = 0;
            this.hl_drone_total = 2;
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
        public async Task _04_intra0_predict_stub()
        {
            wake(new ScriptMethodReference(_04_intra0_predict));
        }

        [ScriptMethod(25, Lifecycle.Static)]
        public async Task _04_intra1_01_predict_stub()
        {
            wake(new ScriptMethodReference(_04_intra1_01_predict));
        }

        [ScriptMethod(26, Lifecycle.Static)]
        public async Task _04_intra1_02_predict_stub()
        {
            wake(new ScriptMethodReference(_04_intra1_02_predict));
        }

        [ScriptMethod(27, Lifecycle.Static)]
        public async Task _04_outro1_01_predict_stub()
        {
            wake(new ScriptMethodReference(_04_outro1_01_predict));
        }

        [ScriptMethod(28, Lifecycle.Static)]
        public async Task _04_outro1_02_predict_stub()
        {
            wake(new ScriptMethodReference(_04_outro1_02_predict));
        }

        [ScriptMethod(29, Lifecycle.Stub)]
        public async Task _04_outro1_03_predict_stub()
        {
            print("predict 03");
        }

        [ScriptMethod(30, Lifecycle.Static)]
        public async Task _04_outro2_01_predict_stub()
        {
            wake(new ScriptMethodReference(_04_outro2_01_predict));
        }

        [ScriptMethod(31, Lifecycle.Static)]
        public async Task _04_outro2_02_predict_stub()
        {
            wake(new ScriptMethodReference(_04_outro2_02_predict));
        }

        [ScriptMethod(32, Lifecycle.Dormant)]
        public async Task c04_intra0_score_01()
        {
            await sleep(369);
            sound_impulse_start(GetTag<SoundTag>("sound\\cinematics\\04_alphagas\\c04_intra0\\music\\c04_intra0_01_mus", 3868919077U), default(IGameObject), 1F);
            print("c04_intra0 score 01 start");
        }

        [ScriptMethod(33, Lifecycle.Dormant)]
        public async Task c04_intra0_foley_01()
        {
            await sleep(0);
            sound_impulse_start(GetTag<SoundTag>("sound\\cinematics\\04_alphagas\\c04_intra0\\foley\\c04_intra0_01_fol", 3868984614U), default(IGameObject), 1F);
            print("c04_intra1 foley 01 start");
        }

        [ScriptMethod(34, Lifecycle.Dormant)]
        public async Task c04_1230_der()
        {
            await sleep(467);
            sound_impulse_start(GetTag<SoundTag>("sound\\dialog\\levels\\04_gasgiant\\cinematic\\c04_1230_der", 3869050151U), dervish_intra0.Entity, 1F);
            cinematic_subtitle("c04_1230_der", 1F);
        }

        [ScriptMethod(35, Lifecycle.Dormant)]
        public async Task c04_1240_soc()
        {
            await sleep(493);
            sound_impulse_start(GetTag<SoundTag>("sound\\dialog\\levels\\04_gasgiant\\cinematic\\c04_1240_soc", 3869115688U), commander_intra0.Entity, 1F);
            cinematic_subtitle("c04_1240_soc", 3F);
        }

        [ScriptMethod(36, Lifecycle.Dormant)]
        public async Task c04_intra0_cinematic_light_01()
        {
            cinematic_lighting_set_primary_light(55F, 138F, 0.26F, 0.24F, 0.15F);
            cinematic_lighting_set_secondary_light(-28F, 358F, 0.08F, 0.08F, 0.11F);
            cinematic_lighting_set_ambient_light(0.03F, 0.03F, 0.03F);
            object_uses_cinematic_lighting(dervish_intra0.Entity, true);
            object_uses_cinematic_lighting(commander_intra0.Entity, true);
            object_uses_cinematic_lighting(elite_intra0_01.Entity, true);
            object_uses_cinematic_lighting(elite_intra0_02.Entity, true);
            object_uses_cinematic_lighting(grunt_intra0_01.Entity, true);
            object_uses_cinematic_lighting(grunt_intra0_02.Entity, true);
            object_uses_cinematic_lighting(pr_intra0_der.Entity, true);
            object_uses_cinematic_lighting(eb_intra0_soc.Entity, true);
            object_uses_cinematic_lighting(pr_intra0_soe_01.Entity, true);
            object_uses_cinematic_lighting(pr_intra0_soe_02.Entity, true);
            object_uses_cinematic_lighting(pr_intra0_soe_03.Entity, true);
            object_uses_cinematic_lighting(pp_intra0_sog_01.Entity, true);
            object_uses_cinematic_lighting(pp_intra0_sog_02.Entity, true);
        }

        [ScriptMethod(37, Lifecycle.Dormant)]
        public async Task soc_blade_activate()
        {
            await sleep(5);
            object_set_permutation(eb_intra0_soc.Entity, "blade", "default");
            print("blade activate");
        }

        [ScriptMethod(38, Lifecycle.Static)]
        public async Task c04_intra0_setup()
        {
            object_create_anew(dervish_intra0);
            object_create_anew(commander_intra0);
            object_create_anew_containing("elite_intra0");
            object_create_anew_containing("grunt_intra0");
            object_create_anew(eb_intra0_soc);
            object_create_anew(pr_intra0_soe_01);
            object_create_anew(pr_intra0_soe_02);
            object_create_anew(pr_intra0_soe_03);
            object_create_anew(pp_intra0_sog_01);
            object_create_anew(pp_intra0_sog_02);
            object_cinematic_lod(dervish_intra0.Entity, true);
            object_cinematic_lod(commander_intra0.Entity, true);
            object_cinematic_lod(elite_intra0_01.Entity, true);
            object_cinematic_lod(elite_intra0_02.Entity, true);
            object_cinematic_lod(grunt_intra0_01.Entity, true);
            object_cinematic_lod(grunt_intra0_02.Entity, true);
            object_cinematic_lod(eb_intra0_soc.Entity, true);
            object_cinematic_lod(pr_intra0_soe_01.Entity, true);
            object_cinematic_lod(pr_intra0_soe_02.Entity, true);
            object_cinematic_lod(pr_intra0_soe_03.Entity, true);
            object_cinematic_lod(pp_intra0_sog_01.Entity, true);
            object_cinematic_lod(pp_intra0_sog_02.Entity, true);
            cinematic_clone_players_weapon(dervish_intra0.Entity, "right_hand_elite", "");
            objects_attach(commander_intra0.Entity, "right_hand_elite", eb_intra0_soc.Entity, "");
            objects_attach(elite_intra0_01.Entity, "right_hand_elite", pr_intra0_soe_01.Entity, "");
            objects_attach(elite_intra0_01.Entity, "left_hand_elite", pr_intra0_soe_02.Entity, "");
            objects_attach(elite_intra0_02.Entity, "right_hand_elite", pr_intra0_soe_03.Entity, "");
            objects_attach(grunt_intra0_01.Entity, "right_hand", pp_intra0_sog_01.Entity, "");
            objects_attach(grunt_intra0_02.Entity, "right_hand", pp_intra0_sog_02.Entity, "");
            wake(new ScriptMethodReference(c04_intra0_score_01));
            wake(new ScriptMethodReference(c04_intra0_foley_01));
            wake(new ScriptMethodReference(c04_1230_der));
            wake(new ScriptMethodReference(c04_1240_soc));
            wake(new ScriptMethodReference(soc_blade_activate));
            wake(new ScriptMethodReference(c04_intra0_cinematic_light_01));
        }

        [ScriptMethod(39, Lifecycle.Static)]
        public async Task c04_intra0()
        {
            texture_cache_flush();
            geometry_cache_flush();
            cinematic_enable_ambience_details(false);
            sound_class_set_gain("device", 0.2F, 0);
            switch_bsp_by_name(GetReference<IBsp>("alphagasgiant"));
            fade_out(1F, 1F, 1F, 0);
            camera_control(true);
            cinematic_start_movie("floodlab_intra0");
            cinematic_start();
            this.cinematic_letterbox_style = 1;
            camera_set_field_of_view(60F, 0);
            cinematic_lightmap_shadow_enable();
            await this._04_intra0_predict_stub();
            sound_impulse_predict(GetTag<SoundTag>("sound\\cinematics\\04_alphagas\\c04_intra0\\music\\c04_intra0_01_mus", 3868919077U));
            sound_impulse_predict(GetTag<SoundTag>("sound\\cinematics\\04_alphagas\\c04_intra0\\foley\\c04_intra0_01_fol", 3868984614U));
            await sleep(this.prediction_offset);
            await this.c04_intra0_setup();
            camera_set_animation_relative(GetTag<AnimationGraphTag>("objects\\characters\\cinematic_camera\\04_intra0\\04_intra0", 3869181225U), "04_intra0", default(IUnit), anchor_flag_intra0);
            custom_animation_relative(dervish_intra0.Entity, GetTag<AnimationGraphTag>("objects\\characters\\dervish\\04_intra0\\04_intra0", 3869246762U), "dervish", false, anchor_intra0.Entity);
            custom_animation_relative(commander_intra0.Entity, GetTag<AnimationGraphTag>("objects\\characters\\elite\\04_intra0\\04_intra0", 3869377836U), "commander", false, anchor_intra0.Entity);
            custom_animation_relative(elite_intra0_01.Entity, GetTag<AnimationGraphTag>("objects\\characters\\elite\\04_intra0\\04_intra0", 3869377836U), "elite01", false, anchor_intra0.Entity);
            custom_animation_relative(elite_intra0_02.Entity, GetTag<AnimationGraphTag>("objects\\characters\\elite\\04_intra0\\04_intra0", 3869377836U), "elite02", false, anchor_intra0.Entity);
            custom_animation_relative(grunt_intra0_01.Entity, GetTag<AnimationGraphTag>("objects\\characters\\grunt\\04_intra0\\04_intra0", 3869508910U), "grunt01", false, anchor_intra0.Entity);
            custom_animation_relative(grunt_intra0_02.Entity, GetTag<AnimationGraphTag>("objects\\characters\\grunt\\04_intra0\\04_intra0", 3869508910U), "grunt02", false, anchor_intra0.Entity);
            fade_in(1F, 1F, 1F, 15);
            device_set_power(arm_02_entry_ext.Entity, 0F);
            await sleep(30);
            device_set_power(arm_02_entry_ext.Entity, 1F);
            device_set_position(arm_02_entry_ext.Entity, 1F);
            await sleep(563);
            device_group_change_only_once_more_set(_04_intra0, false);
            device_set_position(arm_02_entry_ext.Entity, 0F);
            await sleep((short)((float)camera_time() - 15));
            fade_out(1F, 1F, 1F, 15);
            object_destroy_containing("intra0");
            sound_class_set_gain("device", 0F, 30);
            sound_class_set_gain("amb", 0F, 30);
            await sleep(30);
        }

        [ScriptMethod(40, Lifecycle.Dormant)]
        public async Task c04_intra1_foley_01()
        {
            await sleep(0);
            sound_impulse_start(GetTag<SoundTag>("sound\\cinematics\\04_alphagas\\c04_intra1\\foley\\c04_intra1_01_fol", 3869574447U), default(IGameObject), 1F);
            print("c04_intra1 foley 01 start");
        }

        [ScriptMethod(41, Lifecycle.Dormant)]
        public async Task c04_2010_her()
        {
            await sleep(45);
            sound_impulse_start(GetTag<SoundTag>("sound\\dialog\\levels\\04_gasgiant\\cinematic\\c04_2010_her", 3869639984U), heretic_leader1.Entity, 1F);
            cinematic_subtitle("c04_2010_her", 2.5F);
        }

        [ScriptMethod(42, Lifecycle.Dormant)]
        public async Task c04_2020_her()
        {
            await sleep(121);
            sound_impulse_start(GetTag<SoundTag>("sound\\dialog\\levels\\04_gasgiant\\cinematic\\c04_2020_her", 3869705521U), heretic_leader1.Entity, 1F);
            cinematic_subtitle("c04_2020_her", 2F);
        }

        [ScriptMethod(43, Lifecycle.Dormant)]
        public async Task c04_2030_soc()
        {
            await sleep(249);
            sound_impulse_start(GetTag<SoundTag>("sound\\dialog\\levels\\04_gasgiant\\cinematic\\c04_2030_soc", 3869771058U), default(IGameObject), 1F);
            cinematic_subtitle("c04_2030_soc", 1F);
        }

        [ScriptMethod(44, Lifecycle.Dormant)]
        public async Task scale_hologram()
        {
            await sleep(615);
            object_set_scale(gasmine_hologram.Entity, 0.525F, 0);
            print("scale hologram");
        }

        [ScriptMethod(45, Lifecycle.Dormant)]
        public async Task effect_shield_impact()
        {
            await sleep(185);
            print("effect - shield impact");
            effect_new(GetTag<EffectTag>("effects\\impact\\impact_bullet_medium\\energy_shield_thin_cov", 3832283894U), flag_shield_impact);
        }

        [ScriptMethod(46, Lifecycle.Dormant)]
        public async Task c04_intra1_cinematic_light_01()
        {
            cinematic_lighting_set_primary_light(55F, 138F, 0.26F, 0.24F, 0.15F);
            cinematic_lighting_set_secondary_light(-28F, 358F, 0.08F, 0.08F, 0.11F);
            cinematic_lighting_set_ambient_light(0.03F, 0.03F, 0.03F);
            object_uses_cinematic_lighting(dervish02.Entity, true);
            object_uses_cinematic_lighting(heretic_leader1.Entity, true);
        }

        [ScriptMethod(47, Lifecycle.Static)]
        public async Task c04_intra1_02_problem_actors()
        {
            print("problem actors");
            object_create_anew(dervish02b);
            object_create_anew(commander);
            object_create_anew(elite01);
            object_create_anew(elite02);
            object_create_anew(intra1_blade);
            object_create_anew(intra1_rifle_01);
            object_create_anew(intra1_rifle_02);
            object_cinematic_lod(dervish02b.Entity, true);
            object_cinematic_lod(commander.Entity, true);
            object_cinematic_lod(elite01.Entity, true);
            object_cinematic_lod(elite02.Entity, true);
            object_cinematic_lod(intra1_blade.Entity, true);
            object_cinematic_lod(intra1_rifle_01.Entity, true);
            object_cinematic_lod(intra1_rifle_02.Entity, true);
            cinematic_clone_players_weapon(dervish02b.Entity, "right_hand_elite", "");
            objects_attach(commander.Entity, "right_hand_elite", intra1_blade.Entity, "");
            objects_attach(elite01.Entity, "right_hand_elite", intra1_rifle_01.Entity, "");
            objects_attach(elite02.Entity, "right_hand_elite", intra1_rifle_02.Entity, "");
        }

        [ScriptMethod(48, Lifecycle.Static)]
        public async Task c04_intra1_01_setup()
        {
            object_create_anew(dervish02);
            object_create_anew(heretic_leader1);
            object_cinematic_lod(dervish02.Entity, true);
            object_cinematic_lod(heretic_leader1.Entity, true);
            cinematic_clone_players_weapon(dervish02.Entity, "left_hand_elite", "");
            wake(new ScriptMethodReference(c04_intra1_foley_01));
            wake(new ScriptMethodReference(c04_2010_her));
            wake(new ScriptMethodReference(c04_2020_her));
            wake(new ScriptMethodReference(c04_2030_soc));
            wake(new ScriptMethodReference(scale_hologram));
            wake(new ScriptMethodReference(effect_shield_impact));
            wake(new ScriptMethodReference(c04_intra1_cinematic_light_01));
        }

        [ScriptMethod(49, Lifecycle.Static)]
        public async Task c04_intra1_01()
        {
            fade_out(1F, 1F, 1F, 0);
            camera_control(true);
            cinematic_start_movie("floodlab_intra1");
            cinematic_start();
            this.cinematic_letterbox_style = 1;
            camera_set_field_of_view(70F, 0);
            cinematic_lightmap_shadow_enable();
            await this._04_intra1_01_predict_stub();
            sound_impulse_predict(GetTag<SoundTag>("sound\\cinematics\\04_alphagas\\c04_intra1\\foley\\c04_intra1_01_fol", 3869574447U));
            await sleep(this.prediction_offset);
            await this.c04_intra1_01_setup();
            camera_set_animation_relative(GetTag<AnimationGraphTag>("objects\\characters\\cinematic_camera\\04_intra1\\04_intra1", 3869836595U), "04_intra1_01", default(IUnit), cinematic_anchor02);
            custom_animation_relative(dervish02.Entity, GetTag<AnimationGraphTag>("objects\\characters\\dervish\\04_intra1\\04_intra1", 3869902132U), "dervish_01", false, anchor02.Entity);
            custom_animation_relative(heretic_leader1.Entity, GetTag<AnimationGraphTag>("objects\\characters\\heretic\\04_intra1\\04_intra1", 3869967669U), "heretic_01", false, anchor02.Entity);
            fade_in(1F, 1F, 1F, 15);
            await sleep(165);
            device_set_position(control_shield_door.Entity, 0F);
            await sleep((short)((float)camera_time() - this.prediction_offset));
            await this._04_intra1_02_predict_stub();
            await this.c04_intra1_02_problem_actors();
            await sleep((short)((float)camera_time() - this.sound_offset));
            sound_impulse_predict(GetTag<SoundTag>("sound\\cinematics\\04_alphagas\\c04_intra1\\foley\\c04_intra1_02_fol", 3870033206U));
            await sleep((short)camera_time());
            object_destroy(dervish02.Entity);
            object_set_scale(gasmine_hologram.Entity, 1F, 0);
            print("scale hologram");
        }

        [ScriptMethod(50, Lifecycle.Dormant)]
        public async Task c04_intra1_foley_02()
        {
            await sleep(0);
            sound_impulse_start(GetTag<SoundTag>("sound\\cinematics\\04_alphagas\\c04_intra1\\foley\\c04_intra1_02_fol", 3870033206U), default(IGameObject), 1F);
            print("c04_intra1 foley 02 start");
        }

        [ScriptMethod(51, Lifecycle.Dormant)]
        public async Task c04_2031_soc()
        {
            await sleep(0);
            sound_impulse_start(GetTag<SoundTag>("sound\\dialog\\levels\\04_gasgiant\\cinematic\\c04_2031_soc", 3870098743U), commander.Entity, 1F);
            cinematic_subtitle("c04_2031_soc", 1F);
        }

        [ScriptMethod(52, Lifecycle.Dormant)]
        public async Task c04_2040_soc()
        {
            await sleep(96);
            sound_impulse_start(GetTag<SoundTag>("sound\\dialog\\levels\\04_gasgiant\\cinematic\\c04_2040_soc", 3870164280U), commander.Entity, 1F);
            cinematic_subtitle("c04_2040_soc", 3F);
        }

        [ScriptMethod(53, Lifecycle.Dormant)]
        public async Task c04_2050_soc()
        {
            await sleep(178);
            sound_impulse_start(GetTag<SoundTag>("sound\\dialog\\levels\\04_gasgiant\\cinematic\\c04_2050_soc", 3870229817U), commander.Entity, 1F);
            cinematic_subtitle("c04_2050_soc", 1.5F);
        }

        [ScriptMethod(54, Lifecycle.Dormant)]
        public async Task c04_2060_der()
        {
            await sleep(229);
            sound_impulse_start(GetTag<SoundTag>("sound\\dialog\\levels\\04_gasgiant\\cinematic\\c04_2060_der", 3870295354U), dervish02b.Entity, 1F);
            cinematic_subtitle("c04_2060_der", 2F);
        }

        [ScriptMethod(55, Lifecycle.Dormant)]
        public async Task c04_2070_soc()
        {
            await sleep(292);
            sound_impulse_start(GetTag<SoundTag>("sound\\dialog\\levels\\04_gasgiant\\cinematic\\c04_2070_soc", 3870360891U), commander.Entity, 1F);
            cinematic_subtitle("c04_2070_soc", 1F);
        }

        [ScriptMethod(56, Lifecycle.Dormant)]
        public async Task c04_2080_der()
        {
            await sleep(335);
            sound_impulse_start(GetTag<SoundTag>("sound\\dialog\\levels\\04_gasgiant\\cinematic\\c04_2080_der", 3870426428U), dervish02b.Entity, 1F);
            cinematic_subtitle("c04_2080_der", 3.5F);
        }

        [ScriptMethod(57, Lifecycle.Dormant)]
        public async Task c04_2090_der()
        {
            await sleep(482);
            sound_impulse_start(GetTag<SoundTag>("sound\\dialog\\levels\\04_gasgiant\\cinematic\\c04_2090_der", 3870491965U), dervish02b.Entity, 1F);
            cinematic_subtitle("c04_2090_der", 2F);
        }

        [ScriptMethod(58, Lifecycle.Dormant)]
        public async Task c04_intra1_cinematic_light_02()
        {
            cinematic_lighting_set_primary_light(55F, 138F, 0.26F, 0.24F, 0.15F);
            cinematic_lighting_set_secondary_light(-28F, 358F, 0.08F, 0.08F, 0.11F);
            cinematic_lighting_set_ambient_light(0.03F, 0.03F, 0.03F);
            object_uses_cinematic_lighting(dervish02b.Entity, true);
            object_uses_cinematic_lighting(commander.Entity, true);
            object_uses_cinematic_lighting(elite01.Entity, true);
            object_uses_cinematic_lighting(elite02.Entity, true);
        }

        [ScriptMethod(59, Lifecycle.Static)]
        public async Task c04_intra1_02_setup()
        {
            wake(new ScriptMethodReference(c04_intra1_foley_02));
            wake(new ScriptMethodReference(c04_2031_soc));
            wake(new ScriptMethodReference(c04_2040_soc));
            wake(new ScriptMethodReference(c04_2050_soc));
            wake(new ScriptMethodReference(c04_2060_der));
            wake(new ScriptMethodReference(c04_2070_soc));
            wake(new ScriptMethodReference(c04_2080_der));
            wake(new ScriptMethodReference(c04_2090_der));
            wake(new ScriptMethodReference(c04_intra1_cinematic_light_02));
        }

        [ScriptMethod(60, Lifecycle.Static)]
        public async Task c04_intra1_02_cleanup()
        {
            object_destroy(dervish02b.Entity);
            object_destroy(commander.Entity);
            object_destroy(elite01.Entity);
            object_destroy(elite02.Entity);
            object_destroy_containing("intra1");
        }

        [ScriptMethod(61, Lifecycle.Static)]
        public async Task c04_intra1_02()
        {
            await this.c04_intra1_02_setup();
            camera_set_animation_relative(GetTag<AnimationGraphTag>("objects\\characters\\cinematic_camera\\04_intra1\\04_intra1", 3869836595U), "04_intra1_02", default(IUnit), cinematic_anchor02);
            custom_animation_relative(dervish02b.Entity, GetTag<AnimationGraphTag>("objects\\characters\\dervish\\04_intra1\\04_intra1", 3869902132U), "dervish_02", false, anchor02.Entity);
            custom_animation_relative(commander.Entity, GetTag<AnimationGraphTag>("objects\\characters\\elite\\04_intra1\\04_intra1", 3870557502U), "soc_02", false, anchor02.Entity);
            custom_animation_relative(elite01.Entity, GetTag<AnimationGraphTag>("objects\\characters\\elite\\04_intra1\\04_intra1", 3870557502U), "elite01_02", false, anchor02.Entity);
            custom_animation_relative(elite02.Entity, GetTag<AnimationGraphTag>("objects\\characters\\elite\\04_intra1\\04_intra1", 3870557502U), "elite02_02", false, anchor02.Entity);
            await sleep((short)((float)camera_time() - 15));
            fade_out(1F, 1F, 1F, 15);
            await sleep(15);
            sound_class_set_gain("amb", 0F, 15);
            await sleep(15);
            await this.c04_intra1_02_cleanup();
        }

        [ScriptMethod(62, Lifecycle.Static)]
        public async Task c04_intra1()
        {
            fade_out(1F, 1F, 1F, 0);
            geometry_cache_flush();
            texture_cache_flush();
            switch_bsp_by_name(GetReference<IBsp>("alphagasgiant"));
            await sleep(1);
            await this.c04_intra1_01();
            await this.c04_intra1_02();
            await sleep(30);
        }

        [ScriptMethod(63, Lifecycle.Dormant)]
        public async Task c04_outro1_score_01()
        {
            await sleep(0);
            sound_impulse_start(GetTag<SoundTag>("sound\\cinematics\\04_alphagas\\c04_outro1\\music\\c04_outro1_01_mus", 3870623039U), default(IGameObject), 1F);
            print("c04_outro1 score 01 start");
        }

        [ScriptMethod(64, Lifecycle.Dormant)]
        public async Task c04_outro1_foley_01()
        {
            await sleep(0);
            sound_impulse_start(GetTag<SoundTag>("sound\\cinematics\\04_alphagas\\c04_outro1\\foley\\c04_outro1_01_fol", 3870688576U), default(IGameObject), 1F);
            print("c04_outro1 foley 01 start");
        }

        [ScriptMethod(65, Lifecycle.Dormant)]
        public async Task c04_3010_der()
        {
            await sleep(118);
            sound_impulse_start(GetTag<SoundTag>("sound\\dialog\\levels\\04_gasgiant\\cinematic\\c04_3010_der", 3870754113U), dervish_03.Entity, 1F);
            cinematic_subtitle("c04_3010_der", 1.5F);
        }

        [ScriptMethod(66, Lifecycle.Dormant)]
        public async Task c04_3020_her()
        {
            await sleep(197);
            sound_impulse_start(GetTag<SoundTag>("sound\\dialog\\levels\\04_gasgiant\\cinematic\\c04_3020_her", 3870819650U), heretic_leader1.Entity, 1F);
            cinematic_subtitle("c04_3020_her", 1F);
        }

        [ScriptMethod(67, Lifecycle.Dormant)]
        public async Task c04_3030_her()
        {
            await sleep(243);
            sound_impulse_start(GetTag<SoundTag>("sound\\dialog\\levels\\04_gasgiant\\cinematic\\c04_3030_her", 3870885187U), heretic_leader1.Entity, 1F);
            cinematic_subtitle("c04_3030_her", 4.5F);
        }

        [ScriptMethod(68, Lifecycle.Dormant)]
        public async Task c04_3040_der()
        {
            await sleep(385);
            sound_impulse_start(GetTag<SoundTag>("sound\\dialog\\levels\\04_gasgiant\\cinematic\\c04_3040_der", 3870950724U), dervish_03.Entity, 1F);
            cinematic_subtitle("c04_3040_der", 2F);
        }

        [ScriptMethod(69, Lifecycle.Dormant)]
        public async Task c04_outro1_01_dof()
        {
            time_code_reset();
            await sleep(382);
            cinematic_screen_effect_start(true);
            cinematic_screen_effect_set_depth_of_field(1F, 1.5F, 1.5F, 0F, 0F, 0F, 0F);
            print("rack focus");
        }

        [ScriptMethod(70, Lifecycle.Dormant)]
        public async Task c04_outro1_cinematic_light_01()
        {
            cinematic_lighting_set_primary_light(55F, 138F, 0.26F, 0.24F, 0.15F);
            cinematic_lighting_set_secondary_light(-28F, 358F, 0.08F, 0.08F, 0.11F);
            cinematic_lighting_set_ambient_light(0.03F, 0.03F, 0.03F);
            object_uses_cinematic_lighting(dervish_03.Entity, true);
            object_uses_cinematic_lighting(heretic_leader1.Entity, true);
            object_uses_cinematic_lighting(outro_seraph.Entity, true);
        }

        [ScriptMethod(71, Lifecycle.Static)]
        public async Task c04_outro1_01_setup()
        {
            object_destroy(seraph.Entity);
            object_create(outro_seraph);
            object_create_anew(dervish_03);
            object_create_anew(heretic_leader1);
            object_cinematic_lod(dervish_03.Entity, true);
            object_cinematic_lod(heretic_leader1.Entity, true);
            cinematic_clone_players_weapon(dervish_03.Entity, "right_hand_elite", "");
            wake(new ScriptMethodReference(c04_outro1_score_01));
            wake(new ScriptMethodReference(c04_outro1_foley_01));
            wake(new ScriptMethodReference(c04_3010_der));
            wake(new ScriptMethodReference(c04_3020_her));
            wake(new ScriptMethodReference(c04_3030_her));
            wake(new ScriptMethodReference(c04_3040_der));
            wake(new ScriptMethodReference(c04_outro1_01_dof));
            wake(new ScriptMethodReference(c04_outro1_cinematic_light_01));
        }

        [ScriptMethod(72, Lifecycle.Static)]
        public async Task c04_outro1_01()
        {
            fade_out(1F, 1F, 1F, 0);
            camera_control(true);
            cinematic_start_movie("floodlab_outro1");
            cinematic_start();
            this.cinematic_letterbox_style = 1;
            camera_set_field_of_view(60F, 0);
            cinematic_lightmap_shadow_enable();
            await this._04_outro1_01_predict_stub();
            sound_impulse_predict(GetTag<SoundTag>("sound\\cinematics\\04_alphagas\\c04_outro1\\music\\c04_outro1_01_mus", 3870623039U));
            sound_impulse_predict(GetTag<SoundTag>("sound\\cinematics\\04_alphagas\\c04_outro1\\foley\\c04_outro1_01_fol", 3870688576U));
            await sleep(this.prediction_offset);
            await this.c04_outro1_01_setup();
            camera_set_animation_relative(GetTag<AnimationGraphTag>("objects\\characters\\cinematic_camera\\04_outro1\\04_outro1", 3871016261U), "04_outro1_01", default(IUnit), anchor_flag_seraph);
            custom_animation_relative(dervish_03.Entity, GetTag<AnimationGraphTag>("objects\\characters\\dervish\\04_outro1\\04_outro1", 3871081798U), "dervish_01", false, anchor02.Entity);
            custom_animation_relative(heretic_leader1.Entity, GetTag<AnimationGraphTag>("objects\\characters\\heretic\\04_outro1\\04_outro1", 3871147335U), "heretic_01", false, anchor02.Entity);
            scenery_animation_start_relative(outro_seraph.Entity, GetTag<AnimationGraphTag>("scenarios\\objects\\vehicles\\c_seraph\\c_seraph", 3871212872U), "04_outro1_01", anchor_seraph.Entity);
            fade_in(1F, 1F, 1F, 15);
            await sleep((short)((float)camera_time() - this.prediction_offset));
            await this._04_outro1_02_predict_stub();
            await sleep((short)((float)camera_time() - this.sound_offset));
            sound_impulse_predict(GetTag<SoundTag>("sound\\cinematics\\04_alphagas\\c04_outro1\\foley\\c04_outro1_02_fol", 3871278409U));
            await sleep((short)camera_time());
            cinematic_screen_effect_stop();
            print("rack focus stop");
        }

        [ScriptMethod(73, Lifecycle.Dormant)]
        public async Task c04_outro1_foley_02()
        {
            await sleep(0);
            sound_impulse_start(GetTag<SoundTag>("sound\\cinematics\\04_alphagas\\c04_outro1\\foley\\c04_outro1_02_fol", 3871278409U), default(IGameObject), 1F);
            print("c04_outro1 foley 02 start");
        }

        [ScriptMethod(74, Lifecycle.Dormant)]
        public async Task c04_3050_der()
        {
            await sleep(132);
            sound_impulse_start(GetTag<SoundTag>("sound\\dialog\\levels\\04_gasgiant\\cinematic\\c04_3050_der", 3871343946U), dervish_03.Entity, 1F);
            cinematic_subtitle("c04_3050_der", 1.5F);
        }

        [ScriptMethod(75, Lifecycle.Dormant)]
        public async Task c04_3060_gsp()
        {
            await sleep(190);
            sound_impulse_start(GetTag<SoundTag>("sound\\dialog\\levels\\04_gasgiant\\cinematic\\c04_3060_gsp", 3871409483U), monitor.Entity, 1F);
            cinematic_subtitle("c04_3060_gsp", 6F);
        }

        [ScriptMethod(76, Lifecycle.Dormant)]
        public async Task c04_3070_her()
        {
            await sleep(363);
            sound_impulse_start(GetTag<SoundTag>("sound\\dialog\\levels\\04_gasgiant\\cinematic\\c04_3070_her", 3871475020U), heretic_leader1.Entity, 1F);
            cinematic_subtitle("c04_3070_her", 5F);
        }

        [ScriptMethod(77, Lifecycle.Dormant)]
        public async Task c04_3080_gsp()
        {
            await sleep(516);
            sound_impulse_start(GetTag<SoundTag>("sound\\dialog\\levels\\04_gasgiant\\cinematic\\c04_3080_gsp", 3871540557U), monitor.Entity, 1F);
            cinematic_subtitle("c04_3080_gsp", 3.5F);
        }

        [ScriptMethod(78, Lifecycle.Dormant)]
        public async Task c04_outro1_cinematic_light_02()
        {
            cinematic_lighting_set_primary_light(55F, 138F, 0.26F, 0.24F, 0.15F);
            cinematic_lighting_set_secondary_light(-28F, 358F, 0.08F, 0.08F, 0.11F);
            cinematic_lighting_set_ambient_light(0.03F, 0.03F, 0.03F);
            object_uses_cinematic_lighting(monitor.Entity, true);
        }

        [ScriptMethod(79, Lifecycle.Dormant)]
        public async Task heretic_leader_fire_rifles()
        {
            object_create_anew(hl_rifle_01);
            object_create_anew(hl_rifle_02);
            await sleep(623);
            objects_attach(heretic_leader1.Entity, "right_hand_elite", hl_rifle_01.Entity, "");
            objects_attach(heretic_leader1.Entity, "left_hand_elite", hl_rifle_02.Entity, "");
            await sleep(1);
            weapon_hold_trigger(GetReference<IWeaponReference>("hl_rifle_01"), 0, true);
            weapon_hold_trigger(GetReference<IWeaponReference>("hl_rifle_02"), 0, true);
            print("heretic rifles fire");
            await sleep(85);
            weapon_hold_trigger(GetReference<IWeaponReference>("hl_rifle_01"), 0, false);
            weapon_hold_trigger(GetReference<IWeaponReference>("hl_rifle_02"), 0, false);
            print("heretic rifles stop");
        }

        [ScriptMethod(80, Lifecycle.Dormant)]
        public async Task effect_jetpack()
        {
            await sleep(735);
            print("jetpack on");
            object_set_function_variable(heretic_leader1.Entity, "vertical_thrust", 1F, 0F);
            await sleep(154);
            object_set_function_variable(heretic_leader1.Entity, "vertical_thrust", 0F, 0F);
        }

        [ScriptMethod(81, Lifecycle.Static)]
        public async Task c04_outro1_02_setup()
        {
            object_create_anew(monitor);
            object_cinematic_lod(monitor.Entity, true);
            wake(new ScriptMethodReference(c04_outro1_foley_02));
            wake(new ScriptMethodReference(c04_3050_der));
            wake(new ScriptMethodReference(c04_3060_gsp));
            wake(new ScriptMethodReference(c04_3070_her));
            wake(new ScriptMethodReference(c04_3080_gsp));
            wake(new ScriptMethodReference(heretic_leader_fire_rifles));
            wake(new ScriptMethodReference(effect_jetpack));
        }

        [ScriptMethod(82, Lifecycle.Static)]
        public async Task c04_outro1_02()
        {
            await this.c04_outro1_02_setup();
            camera_set_animation_relative(GetTag<AnimationGraphTag>("objects\\characters\\cinematic_camera\\04_outro1\\04_outro1", 3871016261U), "04_outro1_02", default(IUnit), anchor_flag_seraph);
            custom_animation_relative(dervish_03.Entity, GetTag<AnimationGraphTag>("objects\\characters\\dervish\\04_outro1\\04_outro1", 3871081798U), "dervish_02", false, anchor02.Entity);
            custom_animation_relative(monitor.Entity, GetTag<AnimationGraphTag>("objects\\characters\\monitor\\04_outro1\\04_outro1", 3871606094U), "monitor_02", false, anchor02.Entity);
            custom_animation_relative(heretic_leader1.Entity, GetTag<AnimationGraphTag>("objects\\characters\\heretic\\04_outro1\\04_outro1", 3871147335U), "heretic_02", false, anchor02.Entity);
            scenery_animation_start_relative(outro_seraph.Entity, GetTag<AnimationGraphTag>("scenarios\\objects\\vehicles\\c_seraph\\c_seraph", 3871212872U), "04_outro1_02", anchor_seraph.Entity);
            await sleep((short)((float)camera_time() - this.prediction_offset));
            await this._04_outro1_03_predict_stub();
            await sleep((short)((float)camera_time() - this.sound_offset));
            sound_impulse_predict(GetTag<SoundTag>("sound\\cinematics\\04_alphagas\\c04_outro1\\foley\\c04_outro1_03_fol", 3871671631U));
            await sleep((short)camera_time());
        }

        [ScriptMethod(83, Lifecycle.Dormant)]
        public async Task c04_outro1_foley_03()
        {
            await sleep(0);
            sound_impulse_start(GetTag<SoundTag>("sound\\cinematics\\04_alphagas\\c04_outro1\\foley\\c04_outro1_03_fol", 3871671631U), default(IGameObject), 1F);
            print("c04_outro1 foley 01 start");
        }

        [ScriptMethod(84, Lifecycle.Dormant)]
        public async Task c04_3090_her()
        {
            await sleep(29);
            sound_impulse_start(GetTag<SoundTag>("sound\\dialog\\levels\\04_gasgiant\\cinematic\\c04_3090_her", 3871737168U), heretic_leader1.Entity, 1F);
            cinematic_subtitle("c04_3090_her", 2F);
        }

        [ScriptMethod(85, Lifecycle.Dormant)]
        public async Task c04_3100_her()
        {
            await sleep(108);
            sound_impulse_start(GetTag<SoundTag>("sound\\dialog\\levels\\04_gasgiant\\cinematic\\c04_3100_her", 3871802705U), heretic_leader1.Entity, 1F);
            cinematic_subtitle("c04_3100_her", 2.5F);
        }

        [ScriptMethod(86, Lifecycle.Dormant)]
        public async Task effect_drone_activate()
        {
            await sleep(162);
            effect_new_on_object_marker(GetTag<EffectTag>("effects\\scenarios\\objects\\solo\\alphagasgiant\\holo_drone\\drone_activate", 3871868242U), holo_drone_1.Entity, "light");
            print("effect - drone 1");
            await sleep(13);
            effect_new_on_object_marker(GetTag<EffectTag>("effects\\scenarios\\objects\\solo\\alphagasgiant\\holo_drone\\drone_activate", 3871868242U), holo_drone_2.Entity, "light");
            print("effect - drone 2");
        }

        [ScriptMethod(87, Lifecycle.Dormant)]
        public async Task effect_holograms_appear()
        {
            await sleep(477);
            effect_new_on_object_marker(GetTag<EffectTag>("effects\\scenarios\\objects\\solo\\alphagasgiant\\holo_drone\\drone_holo_on_cinematic", 3872195927U), holo_base_1.Entity, "marker");
            print("effect - hologram 1");
            await sleep(18);
            effect_new_on_object_marker(GetTag<EffectTag>("effects\\scenarios\\objects\\solo\\alphagasgiant\\holo_drone\\drone_holo_on_cinematic", 3872195927U), holo_base_2.Entity, "marker");
            print("effect - hologram 2");
        }

        [ScriptMethod(88, Lifecycle.Dormant)]
        public async Task arm_holograms()
        {
            time_code_reset();
            await sleep(546);
            object_create_anew_containing("holo_rifle");
            objects_attach(hologram01.Entity, "right_hand_elite", holo_rifle_01.Entity, "");
            objects_attach(hologram01.Entity, "left_hand_elite", holo_rifle_02.Entity, "");
            objects_attach(hologram02.Entity, "right_hand_elite", holo_rifle_03.Entity, "");
            objects_attach(hologram02.Entity, "left_hand_elite", holo_rifle_04.Entity, "");
        }

        [ScriptMethod(89, Lifecycle.Static)]
        public async Task c04_outro1_03_setup()
        {
            object_create_anew(holo_base_1);
            object_create_anew(holo_base_2);
            object_create_anew(holo_drone_1);
            object_create_anew(holo_drone_2);
            object_cinematic_lod(holo_drone_1.Entity, true);
            object_cinematic_lod(holo_drone_2.Entity, true);
            object_destroy(hl_rifle_01.Entity);
            object_destroy(hl_rifle_02.Entity);
            wake(new ScriptMethodReference(c04_outro1_foley_03));
            wake(new ScriptMethodReference(c04_3090_her));
            wake(new ScriptMethodReference(c04_3100_her));
            wake(new ScriptMethodReference(arm_holograms));
            wake(new ScriptMethodReference(effect_drone_activate));
            wake(new ScriptMethodReference(effect_holograms_appear));
        }

        [ScriptMethod(90, Lifecycle.Static)]
        public async Task c04_outro1_03_cleanup()
        {
            object_destroy(dervish_03.Entity);
            object_destroy(heretic_leader1.Entity);
            object_destroy(monitor.Entity);
            object_destroy(hologram01.Entity);
            object_destroy(hologram02.Entity);
            object_destroy(holo_drone_1.Entity);
            object_destroy(holo_drone_2.Entity);
            object_destroy_containing("holo_rifle");
        }

        [ScriptMethod(91, Lifecycle.Dormant)]
        public async Task c04_outro1_03_holo1()
        {
            await sleep(478);
            object_create_anew(hologram01);
            object_cinematic_lod(hologram01.Entity, true);
            custom_animation_relative(hologram01.Entity, GetTag<AnimationGraphTag>("objects\\characters\\heretic\\04_outro1\\04_outro1", 3871147335U), "holo1_03", false, anchor02.Entity);
        }

        [ScriptMethod(92, Lifecycle.Dormant)]
        public async Task c04_outro1_03_holo2()
        {
            await sleep(490);
            object_create_anew(hologram02);
            object_cinematic_lod(hologram02.Entity, true);
            custom_animation_relative(hologram02.Entity, GetTag<AnimationGraphTag>("objects\\characters\\heretic\\04_outro1\\04_outro1", 3871147335U), "holo2_03", false, anchor02.Entity);
        }

        [ScriptMethod(93, Lifecycle.Static)]
        public async Task c04_outro1_03()
        {
            await this.c04_outro1_03_setup();
            camera_set_animation_relative(GetTag<AnimationGraphTag>("objects\\characters\\cinematic_camera\\04_outro1\\04_outro1", 3871016261U), "04_outro1_03", default(IUnit), anchor_flag_seraph);
            custom_animation_relative(dervish_03.Entity, GetTag<AnimationGraphTag>("objects\\characters\\dervish\\04_outro1\\04_outro1", 3871081798U), "dervish_03", false, anchor02.Entity);
            custom_animation_relative(heretic_leader1.Entity, GetTag<AnimationGraphTag>("objects\\characters\\heretic\\04_outro1\\04_outro1", 3871147335U), "heretic_03", false, anchor02.Entity);
            custom_animation_relative(monitor.Entity, GetTag<AnimationGraphTag>("objects\\characters\\monitor\\04_outro1\\04_outro1", 3871606094U), "monitor_03", false, anchor02.Entity);
            scenery_animation_start_relative(outro_seraph.Entity, GetTag<AnimationGraphTag>("scenarios\\objects\\vehicles\\c_seraph\\c_seraph", 3871212872U), "04_outro1_03", anchor_seraph.Entity);
            scenery_animation_start_relative(holo_drone_1.Entity, GetTag<AnimationGraphTag>("scenarios\\objects\\solo\\alphagasgiant\\holo_drone\\holo_drone", 3872589149U), "outro1_01", anchor02.Entity);
            scenery_animation_start_relative(holo_drone_2.Entity, GetTag<AnimationGraphTag>("scenarios\\objects\\solo\\alphagasgiant\\holo_drone\\holo_drone", 3872589149U), "outro1_02", anchor02.Entity);
            wake(new ScriptMethodReference(c04_outro1_03_holo1));
            wake(new ScriptMethodReference(c04_outro1_03_holo2));
            await sleep((short)((float)camera_time() - 15));
            fade_out(1F, 1F, 1F, 15);
            await sleep(15);
            await this.c04_outro1_03_cleanup();
            sound_class_set_gain("amb", 0F, 30);
            await sleep(30);
        }

        [ScriptMethod(94, Lifecycle.Static)]
        public async Task c04_outro1()
        {
            fade_out(1F, 1F, 1F, 0);
            geometry_cache_flush();
            texture_cache_flush();
            cinematic_enable_ambience_details(false);
            sound_class_set_gain("amb", 0.5F, 0);
            switch_bsp_by_name(GetReference<IBsp>("production_arm2"));
            await sleep(1);
            await this.c04_outro1_01();
            await this.c04_outro1_02();
            await this.c04_outro1_03();
        }

        [ScriptMethod(95, Lifecycle.Dormant)]
        public async Task c04_outro2_score_01()
        {
            await sleep(0);
            sound_impulse_start(GetTag<SoundTag>("sound\\cinematics\\04_alphagas\\c04_outro2\\music\\c04_outro2_01_mus", 3872654686U), default(IGameObject), 1F);
            print("c04_outro2 score 01 start");
        }

        [ScriptMethod(96, Lifecycle.Dormant)]
        public async Task c04_outro2_foley_01()
        {
            await sleep(0);
            sound_impulse_start(GetTag<SoundTag>("sound\\cinematics\\04_alphagas\\c04_outro2\\foley\\c04_outro2_01_fol", 3872720223U), default(IGameObject), 1F);
            print("c04_outro2 foley 01 start");
        }

        [ScriptMethod(97, Lifecycle.Dormant)]
        public async Task c04_9110_gsp()
        {
            await sleep(32);
            sound_impulse_start(GetTag<SoundTag>("sound\\dialog\\levels\\04_gasgiant\\cinematic\\c04_9110_gsp", 3872785760U), monitor.Entity, 1F);
            cinematic_subtitle("c04_9110_gsp", 3.5F);
        }

        [ScriptMethod(98, Lifecycle.Dormant)]
        public async Task c04_9120_der()
        {
            await sleep(133);
            sound_impulse_start(GetTag<SoundTag>("sound\\dialog\\levels\\04_gasgiant\\cinematic\\c04_9120_der", 3872851297U), dervish_03.Entity, 1F);
            cinematic_subtitle("c04_9120_der", 5F);
        }

        [ScriptMethod(99, Lifecycle.Dormant)]
        public async Task c04_9130_gsp()
        {
            await sleep(274);
            sound_impulse_start(GetTag<SoundTag>("sound\\dialog\\levels\\04_gasgiant\\cinematic\\c04_9130_gsp", 3872916834U), monitor.Entity, 1F);
            cinematic_subtitle("c04_9130_gsp", 5.5F);
            await sleep(150);
            unit_set_emotional_state(dervish_03.Entity, "shocked", 0.75F, 30);
        }

        [ScriptMethod(100, Lifecycle.Dormant)]
        public async Task effect_monitor_scramble()
        {
            await sleep(423);
            print("effect - monitor scramble");
            effect_new_on_object_marker(GetTag<EffectTag>("effects\\objects\\characters\\brute\\hammer_grappling", 3872982371U), monitor.Entity, "body");
            player_effect_set_max_rotation(0F, 1F, 1F);
            player_effect_start(0.25F, 0F);
            player_effect_stop(1.5F);
        }

        [ScriptMethod(101, Lifecycle.Dormant)]
        public async Task c04_outro2_cinematic_light_01()
        {
            cinematic_lighting_set_primary_light(55F, 138F, 0.26F, 0.24F, 0.15F);
            cinematic_lighting_set_secondary_light(-28F, 358F, 0.08F, 0.08F, 0.11F);
            cinematic_lighting_set_ambient_light(0.03F, 0.03F, 0.03F);
            object_uses_cinematic_lighting(dervish_03.Entity, true);
            object_uses_cinematic_lighting(heretic_leader1.Entity, true);
            object_uses_cinematic_lighting(monitor.Entity, true);
        }

        [ScriptMethod(102, Lifecycle.Static)]
        public async Task c04_outro2_01_setup()
        {
            object_destroy(hangar_door_ingame.Entity);
            object_create_anew(hangar_door_cinematic);
            device_set_position(hangar_door_cinematic.Entity, 1F);
            object_create_anew(dervish_03);
            object_create_anew(heretic_leader1);
            object_create_anew(monitor);
            object_cinematic_lod(dervish_03.Entity, true);
            object_cinematic_lod(heretic_leader1.Entity, true);
            object_cinematic_lod(monitor.Entity, true);
            object_set_function_variable(heretic_leader1.Entity, "alive", 0F, 0F);
            wake(new ScriptMethodReference(c04_outro2_score_01));
            wake(new ScriptMethodReference(c04_outro2_foley_01));
            wake(new ScriptMethodReference(c04_9110_gsp));
            wake(new ScriptMethodReference(c04_9120_der));
            wake(new ScriptMethodReference(c04_9130_gsp));
            wake(new ScriptMethodReference(effect_monitor_scramble));
            wake(new ScriptMethodReference(c04_outro2_cinematic_light_01));
        }

        [ScriptMethod(103, Lifecycle.Static)]
        public async Task c04_outro2_01()
        {
            fade_out(1F, 1F, 1F, 0);
            camera_control(true);
            cinematic_start_movie("floodlab_outro2");
            cinematic_start();
            cinematic_outro_start();
            this.cinematic_letterbox_style = 1;
            camera_set_field_of_view(70F, 0);
            cinematic_lightmap_shadow_enable();
            await this._04_outro2_01_predict_stub();
            sound_impulse_predict(GetTag<SoundTag>("sound\\cinematics\\04_alphagas\\c04_outro2\\music\\c04_outro2_01_mus", 3872654686U));
            sound_impulse_predict(GetTag<SoundTag>("sound\\cinematics\\04_alphagas\\c04_outro2\\foley\\c04_outro2_01_fol", 3872720223U));
            await sleep(this.prediction_offset);
            await this.c04_outro2_01_setup();
            camera_set_animation_relative(GetTag<AnimationGraphTag>("objects\\characters\\cinematic_camera\\04_outro2\\04_outro2", 3873310056U), "04_outro2_01", default(IUnit), cinematic_anchor02);
            custom_animation_relative(dervish_03.Entity, GetTag<AnimationGraphTag>("objects\\characters\\dervish\\04_outro2\\04_outro2", 3873375593U), "dervish_01", false, anchor02.Entity);
            custom_animation_relative(monitor.Entity, GetTag<AnimationGraphTag>("objects\\characters\\monitor\\04_outro2\\04_outro2", 3873441130U), "monitor_01", false, anchor02.Entity);
            custom_animation_relative(heretic_leader1.Entity, GetTag<AnimationGraphTag>("objects\\characters\\heretic\\04_outro2\\04_outro2", 3873506667U), "heretic_01", false, anchor02.Entity);
            fade_in(1F, 1F, 1F, 15);
            await sleep((short)((float)camera_time() - this.prediction_offset));
            await this._04_outro2_02_predict_stub();
            await sleep((short)((float)camera_time() - this.sound_offset));
            sound_impulse_predict(GetTag<SoundTag>("sound\\cinematics\\04_alphagas\\c04_outro2\\foley\\c04_outro2_02_fol", 3873572204U));
            await sleep((short)camera_time());
        }

        [ScriptMethod(104, Lifecycle.Dormant)]
        public async Task c04_outro2_foley_02()
        {
            await sleep(0);
            sound_impulse_start(GetTag<SoundTag>("sound\\cinematics\\04_alphagas\\c04_outro2\\foley\\c04_outro2_02_fol", 3873572204U), default(IGameObject), 1F);
            print("c04_outro2 foley 02 start");
        }

        [ScriptMethod(105, Lifecycle.Dormant)]
        public async Task c04_9140_gsp()
        {
            await sleep(0);
            sound_impulse_start(GetTag<SoundTag>("sound\\dialog\\levels\\04_gasgiant\\cinematic\\c04_9140_gsp", 3873637741U), monitor.Entity, 1F);
            cinematic_subtitle("c04_9140_gsp", 2F);
        }

        [ScriptMethod(106, Lifecycle.Dormant)]
        public async Task c04_9150_der()
        {
            await sleep(146);
            sound_impulse_start(GetTag<SoundTag>("sound\\dialog\\levels\\04_gasgiant\\cinematic\\c04_9150_der", 3873703278U), dervish_03.Entity, 1F);
            cinematic_subtitle("c04_9150_der", 2F);
            await sleep(127);
            unit_set_emotional_state(tartarus.Entity, "repulsed", 1F, 60);
        }

        [ScriptMethod(107, Lifecycle.Dormant)]
        public async Task c04_9160_tar()
        {
            await sleep(236);
            sound_impulse_start(GetTag<SoundTag>("sound\\dialog\\levels\\04_gasgiant\\cinematic\\c04_9160_tar", 3873768815U), tartarus.Entity, 1F);
            cinematic_subtitle("c04_9160_tar", 1F);
        }

        [ScriptMethod(108, Lifecycle.Dormant)]
        public async Task c04_9170_tar()
        {
            await sleep(300);
            sound_impulse_start(GetTag<SoundTag>("sound\\dialog\\levels\\04_gasgiant\\cinematic\\c04_9170_tar", 3873834352U), tartarus.Entity, 1F);
            cinematic_subtitle("c04_9170_tar", 2F);
            unit_set_emotional_state(tartarus.Entity, "annoyed", 1F, 60);
        }

        [ScriptMethod(109, Lifecycle.Dormant)]
        public async Task effect_monitor_yank()
        {
            time_code_reset();
            await sleep(190);
            print("effect - monitor yank");
            object_set_function_variable(monitor.Entity, "talking", 0F, 0F);
            effect_new_on_object_marker(GetTag<EffectTag>("effects\\objects\\characters\\monitor\\monitor_scrambled", 3873899889U), monitor.Entity, "body");
        }

        [ScriptMethod(110, Lifecycle.Dormant)]
        public async Task c04_outro2_cinematic_light_02()
        {
            cinematic_lighting_set_primary_light(55F, 138F, 0.26F, 0.24F, 0.15F);
            cinematic_lighting_set_secondary_light(-28F, 358F, 0.08F, 0.08F, 0.11F);
            cinematic_lighting_set_ambient_light(0.03F, 0.03F, 0.03F);
            object_uses_cinematic_lighting(tartarus.Entity, true);
            object_uses_cinematic_lighting(hammer.Entity, true);
        }

        [ScriptMethod(111, Lifecycle.Static)]
        public async Task c04_outro2_02_setup()
        {
            object_create_anew(tartarus);
            object_create_anew(hammer);
            object_create_anew(phantom_outro2);
            object_cinematic_lod(tartarus.Entity, true);
            object_cinematic_lod(hammer.Entity, true);
            object_cinematic_lod(phantom_outro2.Entity, true);
            unit_set_emotional_state(tartarus.Entity, "pensive", 1F, 0);
            wake(new ScriptMethodReference(c04_outro2_foley_02));
            wake(new ScriptMethodReference(c04_9140_gsp));
            wake(new ScriptMethodReference(c04_9150_der));
            wake(new ScriptMethodReference(c04_9160_tar));
            wake(new ScriptMethodReference(c04_9170_tar));
            wake(new ScriptMethodReference(effect_monitor_yank));
            wake(new ScriptMethodReference(c04_outro2_cinematic_light_02));
        }

        [ScriptMethod(112, Lifecycle.Static)]
        public async Task c04_outro2_02_cleanup()
        {
            object_destroy(dervish_03.Entity);
            object_destroy(heretic_leader1.Entity);
            object_destroy(monitor.Entity);
            object_destroy(tartarus.Entity);
            object_destroy(hammer.Entity);
            object_destroy(phantom_outro2.Entity);
            sound_class_set_gain("amb", 1F, 2);
        }

        [ScriptMethod(113, Lifecycle.Static)]
        public async Task c04_outro2_02()
        {
            await this.c04_outro2_02_setup();
            camera_set_animation_relative(GetTag<AnimationGraphTag>("objects\\characters\\cinematic_camera\\04_outro2\\04_outro2", 3873310056U), "04_outro2_02", default(IUnit), cinematic_anchor02);
            custom_animation_relative(dervish_03.Entity, GetTag<AnimationGraphTag>("objects\\characters\\dervish\\04_outro2\\04_outro2", 3873375593U), "dervish_02", false, anchor02.Entity);
            custom_animation_relative(monitor.Entity, GetTag<AnimationGraphTag>("objects\\characters\\monitor\\04_outro2\\04_outro2", 3873441130U), "monitor_02", false, anchor02.Entity);
            custom_animation_relative(heretic_leader1.Entity, GetTag<AnimationGraphTag>("objects\\characters\\heretic\\04_outro2\\04_outro2", 3873506667U), "heretic_02", false, anchor02.Entity);
            custom_animation_relative(tartarus.Entity, GetTag<AnimationGraphTag>("objects\\characters\\brute\\04_outro2\\04_outro2", 3873965426U), "tartarus_02", false, anchor02.Entity);
            scenery_animation_start_relative(hammer.Entity, GetTag<AnimationGraphTag>("objects\\weapons\\melee\\gravity_hammer\\04_outro2\\04_outro2", 3874096500U), "hammer_02", anchor02.Entity);
            custom_animation_relative(phantom_outro2.Entity, GetTag<AnimationGraphTag>("objects\\vehicles\\phantom\\animations\\04_outro2\\04_outro2", 3874162037U), "phantom_02", false, anchor02.Entity);
            await sleep((short)((float)camera_time() - 15));
            fade_out(0F, 0F, 0F, 15);
            await sleep(15);
            await this.c04_outro2_02_cleanup();
            sound_class_set_gain("amb", 0F, 30);
            await sleep(30);
        }

        [ScriptMethod(114, Lifecycle.Static)]
        public async Task c04_outro2()
        {
            fade_out(1F, 1F, 1F, 0);
            geometry_cache_flush();
            texture_cache_flush();
            cinematic_enable_ambience_details(false);
            sound_class_set_gain("amb", 0.5F, 0);
            switch_bsp_by_name(GetReference<IBsp>("production_arm2"));
            await sleep(1);
            await this.c04_outro2_01();
            await this.c04_outro2_02();
        }

        [ScriptMethod(115, Lifecycle.CommandScript)]
        public async Task abort()
        {
            cs_pause(0.1F);
        }

        [ScriptMethod(116, Lifecycle.CommandScript)]
        public async Task long_pause()
        {
            cs_abort_on_alert(true);
            sleep_forever();
        }

        [ScriptMethod(117, Lifecycle.CommandScript)]
        public async Task forever_pause()
        {
            cs_pause(-1F);
        }

        [ScriptMethod(118, Lifecycle.Dormant)]
        public async Task _04b_title0()
        {
            await this.cinematic_fade_from_white_bars();
            await sleep(30);
            cinematic_set_title(title_1);
            await sleep(150);
            hud_cinematic_fade(1F, 0.5F);
            cinematic_show_letterbox(false);
            game_save();
        }

        [ScriptMethod(119, Lifecycle.Dormant)]
        public async Task _04b_title1()
        {
            hud_cinematic_fade(0F, 0.5F);
            cinematic_show_letterbox(true);
            await sleep(30);
            cinematic_set_title(title_2);
            await sleep(150);
            hud_cinematic_fade(1F, 0.5F);
            cinematic_show_letterbox(false);
        }

        [ScriptMethod(120, Lifecycle.Dormant)]
        public async Task _04b_title2()
        {
            hud_cinematic_fade(0F, 0.5F);
            cinematic_show_letterbox(true);
            await sleep(30);
            cinematic_set_title(title_3);
            await sleep(150);
            hud_cinematic_fade(1F, 0.5F);
            cinematic_show_letterbox(false);
        }

        [ScriptMethod(121, Lifecycle.Dormant)]
        public async Task objective_labs_set()
        {
            await sleep(30);
            print("new objective set:");
            print("escape the infested labs.");
            objectives_show_up_to(0);
        }

        [ScriptMethod(122, Lifecycle.Dormant)]
        public async Task objective_labs_clear()
        {
            print("objective complete:");
            print("escape the infested labs.");
            objectives_finish_up_to(0);
        }

        [ScriptMethod(123, Lifecycle.Dormant)]
        public async Task objective_control_set()
        {
            await sleep(30);
            print("new objective set:");
            print("ascertain the heretic leader's whereabouts.");
            objectives_show_up_to(1);
        }

        [ScriptMethod(124, Lifecycle.Dormant)]
        public async Task objective_control_clear()
        {
            print("objective complete:");
            print("ascertain the heretic leader's whereabouts.");
            objectives_finish_up_to(1);
        }

        [ScriptMethod(125, Lifecycle.Dormant)]
        public async Task objective_cables_set()
        {
            await sleep(30);
            print("new objective set:");
            print("sever the tether holding the station aloft.");
            objectives_show_up_to(2);
        }

        [ScriptMethod(126, Lifecycle.Dormant)]
        public async Task objective_cables_clear()
        {
            print("objective complete:");
            print("sever the tether holding the station aloft.");
            objectives_finish_up_to(2);
        }

        [ScriptMethod(127, Lifecycle.Dormant)]
        public async Task objective_dogfight_set()
        {
            await sleep(30);
            print("new objective set:");
            print("pursue the heretic leader back to the hangar.");
            objectives_show_up_to(3);
        }

        [ScriptMethod(128, Lifecycle.Dormant)]
        public async Task objective_dogfight_clear()
        {
            print("objective complete:");
            print("pursue the heretic leader back to the hangar.");
            objectives_finish_up_to(3);
        }

        [ScriptMethod(129, Lifecycle.Dormant)]
        public async Task objective_hl_set()
        {
            await sleep(30);
            print("new objective set:");
            print("kill the heretic leader.");
            objectives_show_up_to(4);
        }

        [ScriptMethod(130, Lifecycle.Dormant)]
        public async Task objective_hl_clear()
        {
            print("objective complete:");
            print("kill the heretic leader.");
            objectives_finish_up_to(4);
        }

        [ScriptMethod(131, Lifecycle.Dormant)]
        public async Task music_04b_01_start()
        {
            print("music 04b_01 start");
            sound_looping_start(GetTag<LoopingSoundTag>("scenarios\\solo\\04b_floodlab\\04b_music\\04b_01", 4227602863U), default(IGameObject), 1F);
        }

        [ScriptMethod(132, Lifecycle.Dormant)]
        public async Task music_04b_01_stop()
        {
            print("music 04b_01 stop");
            sound_looping_stop(GetTag<LoopingSoundTag>("scenarios\\solo\\04b_floodlab\\04b_music\\04b_01", 4227602863U));
        }

        [ScriptMethod(133, Lifecycle.Dormant)]
        public async Task music_04b_02_start()
        {
            print("music 04b_02 start");
            sound_looping_start(GetTag<LoopingSoundTag>("scenarios\\solo\\04b_floodlab\\04b_music\\04b_02", 4227996085U), default(IGameObject), 1F);
        }

        [ScriptMethod(134, Lifecycle.Dormant)]
        public async Task music_04b_02_stop()
        {
            print("music 04b_02 stop");
            sound_looping_stop(GetTag<LoopingSoundTag>("scenarios\\solo\\04b_floodlab\\04b_music\\04b_02", 4227996085U));
        }

        [ScriptMethod(135, Lifecycle.Dormant)]
        public async Task music_04b_03_start()
        {
            print("music 04b_03 start");
            sound_looping_start(GetTag<LoopingSoundTag>("scenarios\\solo\\04b_floodlab\\04b_music\\04b_03", 4228389307U), default(IGameObject), 1F);
        }

        [ScriptMethod(136, Lifecycle.Static)]
        public async Task music_04b_03_start_alt()
        {
            print("music 04b_03 start alt");
            sound_looping_set_alternate(GetTag<LoopingSoundTag>("scenarios\\solo\\04b_floodlab\\04b_music\\04b_03", 4228389307U), true);
        }

        [ScriptMethod(137, Lifecycle.Static)]
        public async Task music_04b_03_stop_alt()
        {
            print("music 04b_03 stop alt");
            sound_looping_set_alternate(GetTag<LoopingSoundTag>("scenarios\\solo\\04b_floodlab\\04b_music\\04b_03", 4228389307U), false);
        }

        [ScriptMethod(138, Lifecycle.Dormant)]
        public async Task music_04b_03_stop()
        {
            print("music 04b_03 stop");
            sound_looping_stop(GetTag<LoopingSoundTag>("scenarios\\solo\\04b_floodlab\\04b_music\\04b_03", 4228389307U));
        }

        [ScriptMethod(139, Lifecycle.Dormant)]
        public async Task music_04b_04_start()
        {
            print("music 04b_04 start");
            sound_looping_start(GetTag<LoopingSoundTag>("scenarios\\solo\\04b_floodlab\\04b_music\\04b_04", 4228979140U), default(IGameObject), 1F);
        }

        [ScriptMethod(140, Lifecycle.Dormant)]
        public async Task music_04b_04_start_alt()
        {
            print("music 04b_04 start alt");
            sound_looping_set_alternate(GetTag<LoopingSoundTag>("scenarios\\solo\\04b_floodlab\\04b_music\\04b_04", 4228979140U), true);
        }

        [ScriptMethod(141, Lifecycle.Dormant)]
        public async Task music_04b_04_stop_alt()
        {
            print("music 04b_04 stop alt");
            sound_looping_set_alternate(GetTag<LoopingSoundTag>("scenarios\\solo\\04b_floodlab\\04b_music\\04b_04", 4228979140U), false);
        }

        [ScriptMethod(142, Lifecycle.Dormant)]
        public async Task music_04b_04_stop()
        {
            print("music 04b_04 stop");
            sound_looping_stop(GetTag<LoopingSoundTag>("scenarios\\solo\\04b_floodlab\\04b_music\\04b_04", 4228979140U));
        }

        [ScriptMethod(143, Lifecycle.Dormant)]
        public async Task music_04b_05_start()
        {
            print("music 04b_05 start");
            sound_looping_start(GetTag<LoopingSoundTag>("scenarios\\solo\\04b_floodlab\\04b_music\\04b_05", 4229175751U), default(IGameObject), 1F);
        }

        [ScriptMethod(144, Lifecycle.Dormant)]
        public async Task music_04b_06_start()
        {
            print("music 04b_06 start");
            sound_looping_start(GetTag<LoopingSoundTag>("scenarios\\solo\\04b_floodlab\\04b_music\\04b_06", 4229437899U), default(IGameObject), 1F);
        }

        [ScriptMethod(145, Lifecycle.Dormant)]
        public async Task music_04b_07_start()
        {
            print("music 04b_07 start");
            sound_looping_start(GetTag<LoopingSoundTag>("scenarios\\solo\\04b_floodlab\\04b_music\\04b_07", 4229831121U), default(IGameObject), 1F);
        }

        [ScriptMethod(146, Lifecycle.Dormant)]
        public async Task music_04b_08_start()
        {
            print("music 04b_08 start");
            sound_looping_start(GetTag<LoopingSoundTag>("scenarios\\solo\\04b_floodlab\\04b_music\\04b_08", 4230093269U), default(IGameObject), 1F);
        }

        [ScriptMethod(147, Lifecycle.Dormant)]
        public async Task music_04b_08_start_alt()
        {
            print("music 04b_08 start alt");
            sound_looping_set_alternate(GetTag<LoopingSoundTag>("scenarios\\solo\\04b_floodlab\\04b_music\\04b_08", 4230093269U), true);
        }

        [ScriptMethod(148, Lifecycle.Dormant)]
        public async Task music_04b_08_stop()
        {
            print("music 04b_08 stop");
            sound_looping_stop(GetTag<LoopingSoundTag>("scenarios\\solo\\04b_floodlab\\04b_music\\04b_08", 4230093269U));
        }

        [ScriptMethod(149, Lifecycle.Dormant)]
        public async Task kill_volumes()
        {
            kill_volume_disable(kill_hangar_pit_01);
            kill_volume_disable(kill_hangar_pit_02);
            kill_volume_disable(kill_hangar_pit_03);
            kill_volume_disable(kill_hangar_pit_04);
            kill_volume_disable(kill_underhangar_pit_01);
            kill_volume_disable(kill_underhangar_pit_02);
            kill_volume_disable(kill_bottling_pit_01);
            kill_volume_disable(kill_bottling_pit_02);
            await sleep_until(async () => (short)structure_bsp_index() == 0);
            kill_volume_disable(kill_silo_pit);
            await sleep_until(async () => (short)structure_bsp_index() == 2);
            kill_volume_disable(kill_wraparound);
            await sleep_until(async () => (short)structure_bsp_index() == 1);
            kill_volume_enable(kill_bottling_pit_01);
            kill_volume_enable(kill_bottling_pit_02);
            await sleep_until(async () =>
            {
                await sleep_until(async () => (short)structure_bsp_index() == 5);
                kill_volume_disable(kill_bottling_pit_01);
                kill_volume_disable(kill_bottling_pit_02);
                kill_volume_enable(kill_hangar_pit_01);
                kill_volume_enable(kill_hangar_pit_02);
                kill_volume_enable(kill_hangar_pit_03);
                kill_volume_enable(kill_hangar_pit_04);
                kill_volume_enable(kill_underhangar_pit_01);
                kill_volume_enable(kill_underhangar_pit_02);
                await sleep_until(async () => (short)structure_bsp_index() == 1);
                kill_volume_enable(kill_bottling_pit_01);
                kill_volume_enable(kill_bottling_pit_02);
                kill_volume_disable(kill_hangar_pit_01);
                kill_volume_disable(kill_hangar_pit_02);
                kill_volume_disable(kill_hangar_pit_03);
                kill_volume_disable(kill_hangar_pit_04);
                kill_volume_disable(kill_underhangar_pit_01);
                kill_volume_disable(kill_underhangar_pit_02);
                return false;
            });
        }

        [ScriptMethod(150, Lifecycle.Dormant)]
        public async Task cableroom_killer()
        {
            await sleep_until(async () =>
            {
                if (volume_test_object(vol_croom_kill_new, await this.player0()) == true || volume_test_object(vol_croom_kill_new_too, await this.player0()) == true)
                {
                    unit_kill(unit(await this.player0()));
                }

                if (volume_test_object(vol_croom_kill_new, await this.player1()) == true || volume_test_object(vol_croom_kill_new_too, await this.player1()) == true)
                {
                    unit_kill(unit(await this.player1()));
                }

                return (short)structure_bsp_index() == 1;
            });
        }

        [ScriptMethod(151, Lifecycle.Dormant)]
        public async Task cableroom_junk_killer()
        {
            await sleep_until(async () =>
            {
                await sleep(90);
                garbage_collect_now();
                return (short)structure_bsp_index() == 1;
            });
        }

        [ScriptMethod(152, Lifecycle.Static)]
        public async Task prep_return_from_intro()
        {
            data_mine_set_mission_segment("04b_1_entry");
            ai_place(disposal_commander.Squad, 1);
            ai_cannot_die(disposal_commander.Squad, true);
            ai_place(allies_elites_03a.Squad, 1);
            ai_place(allies_elites_03b.Squad, 1);
            ai_place(allies_grunts_03.Squad, 2);
            await sleep(30);
            object_teleport(await this.player0(), research_player0);
            object_teleport(await this.player1(), research_player1);
        }

        [ScriptMethod(153, Lifecycle.CommandScript)]
        public async Task juggernaut_gosh()
        {
            cs_switch("elite");
            cs_abort_on_damage(true);
            cs_enable_moving(true);
            print("spec-ops elite: 'by the rings! what is that?!'");
            cs_play_line("0550");
            await sleep(30);
            cs_switch("grunt");
            cs_abort_on_damage(true);
            cs_enable_moving(true);
            print("spec-ops grunt: (nervous grunts and whines)");
            cs_play_line("0560");
            await sleep(30);
            cs_switch("elite");
            print("spec-ops elite: 'quiet!'");
            cs_play_line("0570");
            cs_enable_moving(true);
            await sleep_until(async () => (short)ai_living_count(disposal_entry_flood.Squad) == 0, 30, 300);
            await sleep(60);
            print("spec-ops elite: 'it's moved on.'");
            cs_play_line("0580");
            await sleep(30);
            print("spec-ops elite: 'quickly, before it returns! let's find the heretic leader, and finish him off!'");
            cs_play_line("0590");
        }

        [ScriptMethod(154, Lifecycle.CommandScript)]
        public async Task disposal_juggernaut_exit()
        {
            cs_enable_pathfinding_failsafe(true);
            cs_go_to(GetReference<ISpatialPoint>("disposal_chamber/juggs"));
            ai_erase(this.ai_current_actor);
        }

        [ScriptMethod(155, Lifecycle.Dormant)]
        public async Task arm_02_entry_start()
        {
            await sleep_until(async () => volume_test_objects(vol_juggernaut_preview, players()) == true);
            ai_set_orders(all_allies, allies_disposal);
            sound_class_set_gain("unit_animation", 0.5F, 1);
            ai_place(disposal_entry_flood.Squad, 4);
            ai_cannot_die(disposal_entry_flood.Squad, true);
            ai_place(disposal_entry_heretics.Squad, 4);
            units_set_maximum_vitality(ai_actors(disposal_entry_heretics.Squad), 20F, 20F);
            units_set_current_vitality(ai_actors(disposal_entry_heretics.Squad), 20F, 20F);
            await sleep_until(async () => volume_test_objects(vol_juggernaut_preview, ai_actors(allies_elites)) == true && volume_test_objects(vol_juggernaut_preview, ai_actors(allies_grunts_03.Squad)) == true, 30, 450);
            await sleep_until(async () => ai_scene("juggernaut_gosh_scene", new ScriptMethodReference(juggernaut_gosh), all_allies), 30, 450);
            await sleep(90);
            wake(new ScriptMethodReference(music_04b_01_start));
            await sleep_until(async () => (short)ai_living_count(disposal_entry_heretics.Squad) == 0, 30, 300);
            ai_kill_silent(disposal_entry_heretics.Squad);
            cs_run_command_script(disposal_entry_flood.Squad, new ScriptMethodReference(disposal_juggernaut_exit));
            sound_class_set_gain("unit_animation", 1F, 1);
        }

        [ScriptMethod(156, Lifecycle.Dormant)]
        public async Task juggernaut_abort()
        {
            if (cs_command_script_running(all_allies, new ScriptMethodReference(juggernaut_gosh)))
            {
                cs_run_command_script(all_allies, new ScriptMethodReference(abort));
            }
            else
            {
                sound_class_set_gain("unit_animation", 1F, 1);
            }
        }

        [ScriptMethod(157, Lifecycle.CommandScript)]
        public async Task holo_drone_arrives()
        {
            cs_enable_pathfinding_failsafe(true);
            cs_shoot(false);
            cs_fly_by(GetReference<ISpatialPoint>("disposal_chamber/p0"));
            cs_fly_by(GetReference<ISpatialPoint>("disposal_chamber/p1"));
            cs_fly_by(GetReference<ISpatialPoint>("disposal_chamber/p2"));
            cs_fly_by(GetReference<ISpatialPoint>("disposal_chamber/p3"));
            cs_fly_by(GetReference<ISpatialPoint>("disposal_chamber/p4"));
            cs_fly_to(GetReference<ISpatialPoint>("disposal_chamber/p5"), 0.5F);
            this.holo_drone_arrived = true;
            sleep_forever();
        }

        [ScriptMethod(158, Lifecycle.CommandScript)]
        public async Task disposal_ally_comment_01()
        {
            cs_switch("so_elite");
            cs_enable_moving(true);
            cs_enable_targeting(true);
            print("spec-ops elite: 'what happened here?'");
            cs_play_line("0010");
            this.mess_react_01_done = true;
        }

        [ScriptMethod(159, Lifecycle.CommandScript)]
        public async Task disposal_ally_comment_02()
        {
            cs_switch("grunt_01");
            cs_enable_moving(true);
            cs_enable_targeting(true);
            print("spec-ops grunt: 'me have bad feeling 'bout this.'");
            cs_play_line("0600");
            cs_switch("grunt_02");
            cs_enable_moving(true);
            cs_enable_targeting(true);
            print("spec-ops grunt: 'you always have bad feeling!'");
            cs_play_line("0610");
            await sleep(10);
            print("spec-ops grunt: 'you had bad feeling about morning food-nipple!'");
            cs_play_line("0620");
            cs_switch("elite_01");
            cs_enable_moving(true);
            cs_enable_targeting(true);
            print("spec-ops elite: 'close your jaws, or i shall bind them shut!'");
            cs_play_line("0630");
            this.mess_react_02_done = true;
            cs_switch("grunt_02");
            cs_go_to_nearest(GetReference<ISpatialPoint>("disposal_grunts"));
            cs_switch("grunt_01");
            cs_go_to_nearest(GetReference<ISpatialPoint>("disposal_grunts"));
        }

        [ScriptMethod(160, Lifecycle.CommandScript)]
        public async Task hologram_face()
        {
            cs_start_approach(drone_spawn.Entity, 3F, 20F, 20F);
            cs_aim_object(true, list_get(ai_actors(hl_hologram.Squad), 0));
            cs_enable_moving(true);
            cs_enable_looking(true);
            await sleep_until(async () => (short)ai_living_count(hl_hologram.Squad) == 0, 30, 900);
            cs_aim_object(false, list_get(ai_actors(hl_hologram.Squad), 0));
        }

        [ScriptMethod(161, Lifecycle.CommandScript)]
        public async Task hologram_ally_01()
        {
            this.holo_ally_01_go = true;
            cs_switch("so_grunt");
            cs_aim_object(true, list_get(ai_actors(hl_hologram.Squad), 0));
            cs_enable_moving(true);
            cs_enable_targeting(true);
            cs_shoot(true, list_get(ai_actors(hl_hologram.Squad), 0));
            print("spec-ops grunt: 'see! heretic!'");
            cs_play_line("0020");
            await sleep(60);
            cs_switch("commander");
            print("spec-ops commander: 'hold your fire! hold your fire!'");
            cs_play_line("0030");
            cs_switch("so_grunt");
            cs_shoot(false);
            this.holo_ally_01_done = true;
        }

        [ScriptMethod(162, Lifecycle.CommandScript)]
        public async Task hologram_ally_02()
        {
            this.holo_ally_02_go = true;
            cs_switch("heretic_leader");
            cs_face_player(true);
            print("heretic leader: 'i wondered who the prophets would send to silence me. an arbiter. i'm flattered.'");
            cs_play_line("0040");
            this.holo_ally_02_done = true;
        }

        [ScriptMethod(163, Lifecycle.CommandScript)]
        public async Task hologram_ally_03()
        {
            this.holo_ally_03_go = true;
            cs_switch("commander");
            cs_start_approach(drone_spawn.Entity, 2F, 20F, 20F);
            cs_enable_moving(true);
            cs_enable_looking(true);
            print("spec-ops commander: 'he's using a holo-drone. he must be close!'");
            cs_play_line("0050");
            await sleep(30);
            print("spec-ops commander: 'come out. so we may kill you.'");
            cs_play_line("0060");
            cs_approach_stop();
            cs_switch("heretic_leader");
            cs_face_object(true, list_get(ai_actors(disposal_commander.Squad), 0));
            print("heretic leader: 'get in line.'");
            cs_play_line("0070");
            cs_switch("commander");
            this.holo_ally_03_done = true;
        }

        [ScriptMethod(164, Lifecycle.CommandScript)]
        public async Task hologram_ally_04()
        {
            cs_switch("so_elite");
            print("spec-ops elite: 'leader...'");
            cs_play_line("0080");
            cs_switch("commander");
            print("spec-ops commander: 'stand firm...the flood is upon us.'");
            cs_play_line("0090");
        }

        [ScriptMethod(165, Lifecycle.Dormant)]
        public async Task revive_aware()
        {
            await sleep_until(async () => (short)ai_nonswarm_count(disposal_infection) > 0);
            sound_impulse_start(GetTag<SoundTag>("sound\\dialog\\combat\\elite_loose\\02_danger\\warn_fldreanimate", 4231010787U), list_get(ai_actors(allies_elites_03a.Squad), 0), 1F);
            print("ally warns about reanimation");
        }

        [ScriptMethod(166, Lifecycle.CommandScript)]
        public async Task disposal_after_react()
        {
            cs_switch("ally");
            print("spec-ops elite: 'heretic fools! what have they done?!'");
            cs_play_line("0640");
        }

        [ScriptMethod(167, Lifecycle.CommandScript)]
        public async Task disposal_after_commander()
        {
            cs_switch("commander");
            cs_enable_pathfinding_failsafe(true);
            cs_enable_targeting(true);
            cs_shoot(true);
            cs_go_to(GetReference<ISpatialPoint>("disposal_chamber/doorman"));
            cs_aim_player(true);
            print("spec-ops commander: 'go, arbiter! i'll follow when our reinforcements arrive!'");
            cs_play_line("1500");
            cs_aim_player(false);
            cs_enable_dialogue(true);
            await sleep_until(async () =>
            {
                await sleep_until(async () => volume_test_objects(vol_soc_post, ai_actors(disposal_commander.Squad)) == false);
                cs_start_to(GetReference<ISpatialPoint>("disposal_chamber/doorman"));
                return false;
            });
        }

        [ScriptMethod(168, Lifecycle.Dormant)]
        public async Task spec_ops_reborn()
        {
            await sleep_until(async () =>
            {
                await sleep_until(async () => volume_test_objects(vol_soc_reborn, ai_actors(disposal_commander.Squad)) == true);
                effect_new_on_object_marker(GetTag<EffectTag>("effects\\gameplay\\coop_teleport", 4215871740U), list_get(ai_actors(disposal_commander.Squad), 0), "");
                await sleep(30);
                object_teleport(list_get(ai_actors(disposal_commander.Squad), 0), soc_reborn);
                return (short)structure_bsp_index() == 0;
            });
            ai_erase(disposal_commander.Squad);
        }

        [ScriptMethod(169, Lifecycle.Static)]
        public async Task disposal_infection_spawn()
        {
            await sleep_until(async () => (short)ai_swarm_count(disposal_infection) < 20, 30, 300);
            if ((short)ai_swarm_count(disposal_infection) < 20)
            {
                ai_place(disposal_infection_02.Squad, 1);
            }

            await sleep_until(async () => (short)ai_swarm_count(disposal_infection) < 20, 30, 300);
            if ((short)ai_swarm_count(disposal_infection) < 20)
            {
                ai_place(disposal_infection_02.Squad, 1);
            }

            await sleep_until(async () => (short)ai_swarm_count(disposal_infection) < 15, 30, 300);
            if ((short)ai_swarm_count(disposal_infection) < 20)
            {
                ai_place(disposal_infection_01.Squad, 1);
            }

            await sleep_until(async () => (short)ai_swarm_count(disposal_infection) < 15, 30, 300);
            if ((short)ai_swarm_count(disposal_infection) < 20)
            {
                ai_place(disposal_infection_01.Squad, 1);
            }

            await sleep_until(async () => (short)ai_swarm_count(disposal_infection) < 10, 30, 300);
            if ((short)ai_swarm_count(disposal_infection) < 20)
            {
                ai_place(disposal_infection_02.Squad, 1);
            }

            await sleep_until(async () => (short)ai_swarm_count(disposal_infection) < 10, 30, 300);
            if ((short)ai_swarm_count(disposal_infection) < 20)
            {
                ai_place(disposal_infection_02.Squad, 1);
            }

            await sleep_until(async () => (short)ai_swarm_count(disposal_infection) < 5, 30, 300);
            if ((short)ai_swarm_count(disposal_infection) < 20)
            {
                ai_place(disposal_infection_01.Squad, 1);
            }

            await sleep_until(async () => (short)ai_swarm_count(disposal_infection) < 5, 30, 300);
            if ((short)ai_swarm_count(disposal_infection) < 20)
            {
                ai_place(disposal_infection_01.Squad, 1);
            }
        }

        [ScriptMethod(170, Lifecycle.Dormant)]
        public async Task holo_cannot_die()
        {
            await sleep_until(async () => object_get_shield(holo_boy.Entity) < 1F, 1);
            object_set_shield_stun_infinite(holo_boy.Entity);
            object_set_shield(holo_boy.Entity, 0F);
            object_cannot_take_damage(holo_boy.Entity);
        }

        [ScriptMethod(171, Lifecycle.Dormant)]
        public async Task disposal_chamber_start()
        {
            data_mine_set_mission_segment("04b_2_disposal_chamber");
            game_save();
            ai_renew(all_allies);
            wake(new ScriptMethodReference(juggernaut_abort));
            wake(new ScriptMethodReference(music_04b_01_start));
            await sleep_until(async () => volume_test_objects_all(vol_disposal_bottom, players()) == true && await this.player_count() > 0);
            await sleep_until(async () => volume_test_objects_all(vol_disposal_all, ai_actors(all_allies)) == true && await this.player_count() > 0, 30, 300);
            device_set_position(disposal_entry_int.Entity, 0F);
            ai_set_active_camo(all_allies, false);
            await sleep(30);
            await sleep_until(async () => ai_scene("mess_react_01_scene", new ScriptMethodReference(disposal_ally_comment_01), allies_elites) || (short)ai_living_count(allies_elites) == 0, 30, 150);
            await sleep(5);
            if (this.mess_react_01_go == true)
            {
                await sleep_until(async () => this.mess_react_01_done == true || (short)ai_living_count(allies_elites) == 0, 30, 150);
            }

            await sleep(30);
            await sleep_until(async () => ai_scene("mess_react_02_scene", new ScriptMethodReference(disposal_ally_comment_02), all_allies) || (short)ai_living_count(allies_grunts_03.Squad) < 2, 30, 150);
            await sleep(90);
            ai_disregard(ai_actors(all_allies), true);
            device_set_position(tennis_ball.Entity, 1F);
            await sleep(60);
            effect_new_on_object_marker(GetTag<EffectTag>("effects\\scenarios\\objects\\solo\\alphagasgiant\\holo_drone\\drone_activate", 3871868242U), tennis_ball.Entity, "");
            await sleep_until(async () => device_get_position(tennis_ball.Entity) == 1F, 30, 450);
            effect_new_on_object_marker(GetTag<EffectTag>("effects\\scenarios\\objects\\solo\\alphagasgiant\\holo_drone\\drone_holo_on_cinematic", 3872195927U), tennis_ball.Entity, "light");
            ai_place(hl_hologram.Squad);
            unit_impervious(ai_actors(hl_hologram.Squad), true);
            ai_cannot_die(hl_hologram.Squad, true);
            cs_run_command_script(hl_hologram.Squad, new ScriptMethodReference(forever_pause));
            ai_disregard(ai_actors(all_allies), true);
            ai_disregard(ai_actors(hl_hologram.Squad), true);
            object_destroy(tennis_ball.Entity);
            object_dynamic_simulation_disable(list_get(ai_actors(hl_hologram.Squad), 0), true);
            cs_run_command_script(all_allies, new ScriptMethodReference(hologram_face));
            await sleep_until(async () => ai_scene("holo_grunt_react_scene", new ScriptMethodReference(hologram_ally_01), all_allies) || (short)ai_living_count(allies_grunts_03.Squad) == 0 || (short)ai_living_count(disposal_commander.Squad) == 0, 30, 150);
            await sleep(5);
            if (this.holo_ally_01_go == true)
            {
                await sleep_until(async () => this.holo_ally_01_done == true || (short)ai_living_count(allies_grunts_03.Squad) == 0 || (short)ai_living_count(disposal_commander.Squad) == 0, 30, 300);
            }

            await sleep_until(async () => ai_scene("holo_main_hl_scene", new ScriptMethodReference(hologram_ally_02), hl_hologram.Squad) || (short)ai_living_count(hl_hologram.Squad) == 0, 30, 150);
            await sleep(5);
            if (this.holo_ally_02_go == true)
            {
                await sleep_until(async () => this.holo_ally_02_done == true || (short)ai_living_count(hl_hologram.Squad) == 0, 30, 300);
            }

            await sleep_until(async () => ai_scene("holo_main_react_scene", new ScriptMethodReference(hologram_ally_03), disposal_commander.Squad, hl_hologram.Squad) || (short)ai_living_count(disposal_commander.Squad) == 0 || (short)ai_living_count(hl_hologram.Squad) == 0, 30, 150);
            await sleep(5);
            if (this.holo_ally_03_go == true)
            {
                await sleep_until(async () => this.holo_ally_03_done == true || (short)ai_living_count(disposal_commander.Squad) == 0, 30, 450);
            }

            unit_doesnt_drop_items(ai_actors(hl_hologram.Squad));
            ai_cannot_die(hl_hologram.Squad, false);
            ai_kill_silent(hl_hologram.Squad);
            ai_disregard(ai_actors(all_allies), false);
            game_save();
            await sleep(120);
            ai_place(disposal_infection_01.Squad, 1);
            await sleep(30);
            ai_place(disposal_infection_01.Squad, 1);
            await sleep(30);
            ai_place(disposal_infection_01.Squad, 1);
            await sleep(30);
            ai_place(disposal_infection_01.Squad, 1);
            await sleep_until(async () => ai_scene("holo_after_scene", new ScriptMethodReference(hologram_ally_04), all_allies) || (short)ai_living_count(disposal_commander.Squad) == 0 || (short)ai_living_count(allies_elites) == 0, 30, 150);
            wake(new ScriptMethodReference(revive_aware));
            await this.disposal_infection_spawn();
            await sleep_until(async () => (short)ai_swarm_count(disposal_infection) < 30 && (short)ai_nonswarm_count(disposal_infection) == 0, 30, 8000);
            device_operates_automatically_set(disposal_exit.Entity, true);
            await sleep_until(async () => ai_scene("disposal_post_scene", new ScriptMethodReference(disposal_after_react), all_allies) || (short)ai_living_count(allies_elites) == 0, 30, 150);
            await sleep(150);
            await sleep_until(async () => ai_scene("disposal_comm_pussy_scene", new ScriptMethodReference(disposal_after_commander), disposal_commander.Squad), 30, 300);
            wake(new ScriptMethodReference(spec_ops_reborn));
            await sleep(30);
            game_save();
        }

        [ScriptMethod(172, Lifecycle.CommandScript)]
        public async Task silo_ally_comment()
        {
            cs_switch("ally");
            print("spec-ops elite: 'this place...it is filled with the parasite!'");
            cs_play_line("0650");
            await sleep(30);
            print("spec-ops elite: 'not even heretics would have come here had they known this!'");
            cs_play_line("0660");
        }

        [ScriptMethod(173, Lifecycle.CommandScript)]
        public async Task silo_commander_whine()
        {
            cs_switch("commander");
            print("spec-ops commander: 'i do not wish to stay here any longer than we have to, arbiter!'");
            cs_play_line("1230");
        }

        [ScriptMethod(174, Lifecycle.Dormant)]
        public async Task silo_commander_reminder()
        {
            await sleep_until(async () => volume_test_objects(vol_leaving_silo, players()) == true || (short)ai_nonswarm_count(silo_flood) == 0);
            if (volume_test_objects(vol_leaving_silo, players()) == false && await this.player_count() > 0)
            {
                await sleep_until(async () => volume_test_objects(vol_leaving_silo, players()) == true, 30, 100);
                if (volume_test_objects(vol_leaving_silo, players()) == false && await this.player_count() > 0)
                {
                    ai_scene("silo_commander_scene", new ScriptMethodReference(silo_commander_whine), all_allies) // Couldn't generate cast from 'Boolean' to 'Void'
                    ;
                }
            }
        }

        [ScriptMethod(175, Lifecycle.Dormant)]
        public async Task silo_killer()
        {
            await sleep_until(async () =>
            {
                object_destroy(list_get(volume_return_objects(kill_silo_pit), 0));
                await sleep(15);
                return this.silo_killer_power == false;
            });
        }

        [ScriptMethod(176, Lifecycle.Static)]
        public async Task silo_crane_01()
        {
            device_set_overlay_track(elev_silo.Entity, "crane_left");
            device_animate_overlay(elev_silo.Entity, 1F, 30F, 1F, 1F);
            await sleep(360);
            object_destroy(stop_01.Entity);
            object_create_anew(dummy_can);
            objects_attach(elev_silo.Entity, "can_entry", dummy_can.Entity, "can_top");
            await sleep(285);
            object_destroy(dummy_can.Entity);
            await sleep(270);
        }

        [ScriptMethod(177, Lifecycle.Static)]
        public async Task silo_crane_02()
        {
            device_set_overlay_track(elev_silo.Entity, "crane_right");
            device_animate_overlay(elev_silo.Entity, 1F, 30F, 1F, 1F);
            await sleep(360);
            object_destroy(stop_02.Entity);
            object_create_anew(dummy_can);
            objects_attach(elev_silo.Entity, "can_entry", dummy_can.Entity, "can_top");
            await sleep(285);
            object_destroy(dummy_can.Entity);
            await sleep(270);
        }

        [ScriptMethod(178, Lifecycle.Static)]
        public async Task silo_crane_03()
        {
            device_set_overlay_track(elev_silo.Entity, "crane_right");
            device_animate_overlay(elev_silo.Entity, 1F, 30F, 1F, 1F);
            await sleep(360);
            object_destroy(stop_03.Entity);
            object_create_anew(dummy_can);
            objects_attach(elev_silo.Entity, "can_entry", dummy_can.Entity, "can_top");
            await sleep(285);
            object_destroy(dummy_can.Entity);
            await sleep(270);
        }

        [ScriptMethod(179, Lifecycle.Static)]
        public async Task silo_crane_04()
        {
            device_set_overlay_track(elev_silo.Entity, "crane_center");
            device_animate_overlay(elev_silo.Entity, 1F, 18F, 1F, 1F);
            await sleep(195);
            object_destroy(stop_04.Entity);
            object_create_anew(dummy_can);
            objects_attach(elev_silo.Entity, "can_entry", dummy_can.Entity, "can_top");
            await sleep(255);
            object_destroy(dummy_can.Entity);
            await sleep(60);
        }

        [ScriptMethod(180, Lifecycle.Static)]
        public async Task silo_crane_05()
        {
            device_set_overlay_track(elev_silo.Entity, "crane_left");
            device_animate_overlay(elev_silo.Entity, 1F, 30F, 1F, 1F);
            await sleep(360);
            object_destroy(stop_05.Entity);
            object_create_anew(dummy_can);
            objects_attach(elev_silo.Entity, "can_entry", dummy_can.Entity, "can_top");
            await sleep(285);
            object_destroy(dummy_can.Entity);
            await sleep(270);
        }

        [ScriptMethod(181, Lifecycle.Static)]
        public async Task silo_crane_06()
        {
            device_set_overlay_track(elev_silo.Entity, "crane_center");
            device_animate_overlay(elev_silo.Entity, 1F, 18F, 1F, 1F);
            await sleep(195);
            object_destroy(stop_06.Entity);
            object_create_anew(dummy_can);
            objects_attach(elev_silo.Entity, "can_entry", dummy_can.Entity, "can_top");
            await sleep(255);
            object_destroy(dummy_can.Entity);
            await sleep(60);
        }

        [ScriptMethod(182, Lifecycle.Static)]
        public async Task silo_down_200()
        {
            device_set_position_track(elev_silo.Entity, "down_200", 0F);
            device_animate_position(elev_silo.Entity, 1F, 5F, 1F, 1F, false);
        }

        [ScriptMethod(183, Lifecycle.Static)]
        public async Task silo_down_400()
        {
            device_set_position_track(elev_silo.Entity, "down_400", 0F);
            device_animate_position(elev_silo.Entity, 1F, 10F, 1F, 1F, false);
        }

        [ScriptMethod(184, Lifecycle.Static)]
        public async Task silo_down_600()
        {
            device_set_position_track(elev_silo.Entity, "down_600", 0F);
            device_animate_position(elev_silo.Entity, 1F, 15F, 1F, 1F, false);
        }

        [ScriptMethod(185, Lifecycle.Static)]
        public async Task silo_down_800()
        {
            device_set_position_track(elev_silo.Entity, "down_800", 0F);
            device_animate_position(elev_silo.Entity, 1F, 20F, 1F, 1F, false);
        }

        [ScriptMethod(186, Lifecycle.Static)]
        public async Task silo_rot_90_plus()
        {
            device_set_position_track(elev_silo.Entity, "rot_90_clockwise", 0F);
            device_animate_position(elev_silo.Entity, 1F, 5F, 1F, 1F, false);
        }

        [ScriptMethod(187, Lifecycle.Static)]
        public async Task silo_rot_90_minus()
        {
            device_set_position_track(elev_silo.Entity, "rot_90_counterclockwise", 0F);
            device_animate_position(elev_silo.Entity, 1F, 5F, 1F, 1F, false);
        }

        [ScriptMethod(188, Lifecycle.Static)]
        public async Task silo_rot_180_plus()
        {
            device_set_position_track(elev_silo.Entity, "rot_180_clockwise", 0F);
            device_animate_position(elev_silo.Entity, 1F, 10F, 1F, 1F, false);
        }

        [ScriptMethod(189, Lifecycle.Static)]
        public async Task silo_rot_180_minus()
        {
            device_set_position_track(elev_silo.Entity, "rot_180_counterclockwise", 0F);
            device_animate_position(elev_silo.Entity, 1F, 10F, 1F, 1F, false);
        }

        [ScriptMethod(190, Lifecycle.Static)]
        public async Task silo_tray01()
        {
            objects_attach(elev_silo.Entity, "tray01", tray01.Entity, "can_exit");
            object_create(can01);
            objects_attach(tray01.Entity, "can_exit", can01.Entity, "can_base");
            device_set_position(tray01.Entity, 1F);
            await sleep_until(async () => device_get_position(tray01.Entity) == 1F, 30, 900);
            objects_detach(tray01.Entity, can01.Entity);
            device_set_position_immediate(tray01.Entity, 0F);
            object_destroy(tray01.Entity);
        }

        [ScriptMethod(191, Lifecycle.Static)]
        public async Task silo_tray02()
        {
            objects_attach(elev_silo.Entity, "tray02", tray02.Entity, "can_exit");
            object_create(can02);
            objects_attach(tray02.Entity, "can_exit", can02.Entity, "can_base");
            device_set_position(tray02.Entity, 1F);
            await sleep_until(async () => device_get_position(tray02.Entity) == 1F, 30, 300);
            objects_detach(tray02.Entity, can02.Entity);
            device_set_position_immediate(tray02.Entity, 0F);
            object_destroy(tray02.Entity);
        }

        [ScriptMethod(192, Lifecycle.Static)]
        public async Task silo_tray03()
        {
            objects_attach(elev_silo.Entity, "tray03", tray03.Entity, "can_exit");
            object_create(can03);
            objects_attach(tray03.Entity, "can_exit", can03.Entity, "can_base");
            device_set_position(tray03.Entity, 1F);
            await sleep_until(async () => device_get_position(tray03.Entity) == 1F, 30, 300);
            objects_detach(tray03.Entity, can03.Entity);
            device_set_position_immediate(tray03.Entity, 0F);
            object_destroy(tray03.Entity);
        }

        [ScriptMethod(193, Lifecycle.Static)]
        public async Task silo_tray04()
        {
            objects_attach(elev_silo.Entity, "tray04", tray04.Entity, "can_exit");
            object_create(can04);
            objects_attach(tray04.Entity, "can_exit", can04.Entity, "can_base");
            device_set_position(tray04.Entity, 1F);
            await sleep_until(async () => device_get_position(tray04.Entity) == 1F, 30, 300);
            objects_detach(tray04.Entity, can04.Entity);
            device_set_position_immediate(tray04.Entity, 0F);
            object_destroy(tray04.Entity);
        }

        [ScriptMethod(194, Lifecycle.Static)]
        public async Task silo_tray05()
        {
            objects_attach(elev_silo.Entity, "tray05", tray05.Entity, "can_exit");
            object_create(can05);
            objects_attach(tray05.Entity, "can_exit", can05.Entity, "can_base");
            device_set_position(tray05.Entity, 1F);
            await sleep_until(async () => device_get_position(tray05.Entity) == 1F, 30, 300);
            objects_detach(tray05.Entity, can05.Entity);
            device_set_position_immediate(tray05.Entity, 0F);
            object_destroy(tray05.Entity);
        }

        [ScriptMethod(195, Lifecycle.Static)]
        public async Task silo_tray06()
        {
            objects_attach(elev_silo.Entity, "tray06", tray06.Entity, "can_exit");
            object_create(can06);
            objects_attach(tray06.Entity, "can_exit", can06.Entity, "can_base");
            device_set_position(tray06.Entity, 1F);
            await sleep_until(async () => device_get_position(tray06.Entity) == 1F, 30, 300);
            objects_detach(tray06.Entity, can06.Entity);
            device_set_position_immediate(tray06.Entity, 0F);
            object_destroy(tray06.Entity);
        }

        [ScriptMethod(196, Lifecycle.Dormant)]
        public async Task silo_covers_invincible()
        {
            object_cannot_take_damage(cap_01_1.Entity);
            object_cannot_take_damage(cap_01_2.Entity);
            object_cannot_take_damage(cap_01_3.Entity);
            object_cannot_take_damage(cap_01_4.Entity);
            object_cannot_take_damage(cap_01_5.Entity);
            object_cannot_take_damage(cap_01_6.Entity);
            object_cannot_take_damage(cap_01_7.Entity);
            object_cannot_take_damage(cap_01_8.Entity);
            object_cannot_take_damage(cap_01_9.Entity);
            object_cannot_take_damage(cap_01_10.Entity);
            object_cannot_take_damage(cap_01_11.Entity);
            object_cannot_take_damage(cap_01_12.Entity);
            object_cannot_take_damage(cap_02_1.Entity);
            object_cannot_take_damage(cap_02_2.Entity);
            object_cannot_take_damage(cap_02_3.Entity);
            object_cannot_take_damage(cap_02_4.Entity);
            object_cannot_take_damage(cap_02_5.Entity);
            object_cannot_take_damage(cap_02_6.Entity);
            object_cannot_take_damage(cap_02_7.Entity);
            object_cannot_take_damage(cap_02_8.Entity);
            object_cannot_take_damage(cap_02_9.Entity);
            object_cannot_take_damage(cap_02_10.Entity);
            object_cannot_take_damage(cap_02_11.Entity);
            object_cannot_take_damage(cap_03_1.Entity);
            object_cannot_take_damage(cap_03_2.Entity);
            object_cannot_take_damage(cap_03_3.Entity);
            object_cannot_take_damage(cap_03_4.Entity);
            object_cannot_take_damage(cap_03_5.Entity);
            object_cannot_take_damage(cap_03_6.Entity);
            object_cannot_take_damage(cap_03_7.Entity);
            object_cannot_take_damage(cap_03_8.Entity);
            object_cannot_take_damage(cap_04_1.Entity);
            object_cannot_take_damage(cap_04_2.Entity);
            object_cannot_take_damage(cap_04_3.Entity);
            object_cannot_take_damage(cap_04_4.Entity);
            object_cannot_take_damage(cap_04_5.Entity);
            object_cannot_take_damage(cap_04_6.Entity);
            object_cannot_take_damage(cap_04_7.Entity);
            object_cannot_take_damage(cap_04_8.Entity);
            object_cannot_take_damage(cap_04_9.Entity);
            object_cannot_take_damage(cap_04_10.Entity);
            object_cannot_take_damage(cap_04_11.Entity);
            object_cannot_take_damage(cap_04_12.Entity);
        }

        [ScriptMethod(197, Lifecycle.Dormant)]
        public async Task silo_sentinel_spawner()
        {
            await sleep_until(async () =>
            {
                begin_random(async () =>
                {
                    if ((short)ai_living_count(silo_sentinels_all) < 2 && this.silo_sentinels_total < 4)
                    {
                        ai_place(silo_sentinels_resupply._1);
                        this.silo_sentinels_total = (short)(this.silo_sentinels_total + 1);
                    }
                }, 
                    async () =>
                {
                    if ((short)ai_living_count(silo_sentinels_all) < 2 && this.silo_sentinels_total < 4)
                    {
                        ai_place(silo_sentinels_resupply._2);
                        this.silo_sentinels_total = (short)(this.silo_sentinels_total + 1);
                    }
                });
                await sleep_until(async () => volume_test_objects(vol_leaving_silo, players()) == true || (short)ai_living_count(silo_sentinels_all) < 2 || this.silo_sentinels_total > 3);
                return this.silo_sentinels_total > 3;
            }, 30, 4000);
            await sleep_until(async () => this.silo_sentinels_total == 0);
            await sleep_until(async () =>
            {
                begin_random(async () =>
                {
                    if ((short)ai_living_count(silo_sentinels_all) < 2 && this.silo_sentinels_total < 4)
                    {
                        ai_place(silo_sentinels_resupply._5);
                        this.silo_sentinels_total = (short)(this.silo_sentinels_total + 1);
                    }
                }, 
                    async () =>
                {
                    if ((short)ai_living_count(silo_sentinels_all) < 2 && this.silo_sentinels_total < 4)
                    {
                        ai_place(silo_sentinels_resupply._6);
                        this.silo_sentinels_total = (short)(this.silo_sentinels_total + 1);
                    }
                });
                await sleep_until(async () => volume_test_objects(vol_leaving_silo, players()) == true || (short)ai_living_count(silo_sentinels_all) < 2 || this.silo_sentinels_total > 3);
                return volume_test_objects(vol_leaving_silo, players()) == true || this.silo_sentinels_total > 3;
            }, 30, 4000);
        }

        [ScriptMethod(198, Lifecycle.Dormant)]
        public async Task silo_saving()
        {
            await sleep_until(async () =>
            {
                await sleep_until(async () => this.silo_try_save == true);
                await sleep_until(async () => (bool)game_safe_to_save() && volume_test_objects_all(vol_silo_save, players()) == true && await this.player_count() > 0);
                game_save_immediate();
                this.silo_try_save = false;
                return volume_test_objects(vol_leaving_silo, players()) == true;
            });
        }

        [ScriptMethod(199, Lifecycle.Dormant)]
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

            await sleep_until(async () =>
            {
                ai_place(silo_climbers_01.Squad, 1);
                ai_place(silo_climbers_02.Squad, 1);
                await sleep((short)random_range(30, 60));
                ai_place(silo_climbers_01.Squad, 1);
                ai_place(silo_climbers_02.Squad, 1);
                if (await this.difficulty_heroic())
                {
                    await sleep((short)random_range(30, 60));
                    begin_random(async () => ai_place(silo_climbers_01.Squad, (short)(1 - (float)ai_living_count(silo_climbers_02.Squad))), 
                        async () => ai_place(silo_climbers_02.Squad, (short)(1 - (float)ai_living_count(silo_climbers_01.Squad))));
                }

                if (await this.difficulty_legendary())
                {
                    await sleep((short)random_range(30, 60));
                    begin_random(async () => ai_place(silo_climbers_01.Squad, 1), 
                        async () => ai_place(silo_climbers_02.Squad, 1));
                }

                garbage_collect_now();
                this.silo_try_save = true;
                await sleep_until(async () => volume_test_objects(vol_leaving_silo, players()) == true || (float)ai_nonswarm_count(silo_flood) + (float)ai_nonswarm_count(silo_infection) <= this.silo_flood_total);
                return volume_test_objects(vol_leaving_silo, players()) == true || this.silo_almost_there == true;
            });
        }

        [ScriptMethod(200, Lifecycle.Dormant)]
        public async Task elev_go()
        {
            await this.silo_crane_01();
            await this.silo_tray01();
            await sleep(30);
            await sleep_until(async () => volume_test_objects_all(vol_specimen_storage, players()) == true && await this.player_count() > 0);
            print("down 400");
            wake(new ScriptMethodReference(silo_saving));
            wake(new ScriptMethodReference(music_04b_02_stop));
            await this.silo_down_400();
            await sleep(300);
            await this.silo_rot_90_plus();
            await sleep(150);
            await this.silo_crane_02();
            await this.silo_tray02();
            await sleep(30);
            await sleep_until(async () => volume_test_objects_all(vol_specimen_storage, players()) == true && await this.player_count() > 0, 30, 300);
            print("down 600");
            await this.silo_down_600();
            await sleep(450);
            await this.silo_rot_90_minus();
            await sleep(150);
            await this.silo_crane_03();
            await this.silo_tray03();
            await sleep(30);
            data_mine_set_mission_segment("04b_4_silo_mid");
            this.silo_try_save = true;
            await sleep_until(async () => volume_test_objects_all(vol_specimen_storage, players()) == true && await this.player_count() > 0, 30, 300);
            print("down 200");
            wake(new ScriptMethodReference(music_04b_01_stop));
            await this.silo_down_200();
            await sleep(150);
            ai_place(silo_sentinels_below.Squad, 4);
            await this.silo_rot_90_plus();
            await sleep(150);
            await this.silo_crane_04();
            await this.silo_tray04();
            await sleep(30);
            await sleep_until(async () => volume_test_objects_all(vol_specimen_storage, players()) == true && await this.player_count() > 0, 30, 300);
            print("down 800 - kill disabled");
            kill_volume_disable(kill_silo_toggle);
            await this.silo_down_800();
            await sleep(600);
            await this.silo_rot_180_minus();
            await sleep(300);
            await this.silo_crane_05();
            await this.silo_tray05();
            await sleep(30);
            await sleep_until(async () => volume_test_objects_all(vol_specimen_storage, players()) == true && await this.player_count() > 0, 30, 300);
            print("down 400");
            await this.silo_down_400();
            await sleep(300);
            await this.silo_rot_90_plus();
            await sleep(150);
            await this.silo_crane_06();
            await this.silo_tray06();
            await sleep(30);
            await sleep_until(async () => volume_test_objects_all(vol_specimen_storage, players()) == true && await this.player_count() > 0, 30, 300);
            this.silo_almost_there = true;
            print("down 600");
            await this.silo_down_600();
            await sleep(300);
            await sleep(150);
        }

        [ScriptMethod(201, Lifecycle.Dormant)]
        public async Task silo_hall_flood_spawner()
        {
            ai_place(silo_flood_halls.Squad, 2);
            await sleep_until(async () => volume_test_objects(vol_leaving_silo, players()) == true || (short)ai_nonswarm_count(silo_flood_halls.Squad) == 0);
            await sleep_until(async () => volume_test_objects(vol_leaving_silo, players()) == true, 30, 210);
            if (volume_test_objects(vol_leaving_silo, players()) == true)
            {
                sleep_forever();
            }

            if (volume_test_objects(vol_leaving_silo, players()) == false && await this.player_count() > 0)
            {
                ai_place(silo_flood_halls.Squad, 2);
            }

            await sleep_until(async () => volume_test_objects(vol_leaving_silo, players()) == true || (short)ai_nonswarm_count(silo_flood_halls.Squad) == 0);
            await sleep_until(async () => volume_test_objects(vol_leaving_silo, players()) == true, 30, 210);
            if (volume_test_objects(vol_leaving_silo, players()) == true)
            {
                sleep_forever();
            }

            await sleep_until(async () =>
            {
                if (volume_test_objects(vol_leaving_silo, players()) == false && await this.player_count() > 0 && (short)ai_living_count(silo_flood_halls.Squad) < 1)
                {
                    ai_place(silo_flood_halls.Squad, 1);
                }

                await sleep_until(async () => volume_test_objects(vol_leaving_silo, players()) == true, 30, 210);
                await sleep_until(async () => volume_test_objects(vol_leaving_silo, players()) == true || (short)ai_living_count(silo_flood_halls.Squad) < 1 || (short)ai_spawn_count(silo_flood_halls.Squad) > 7);
                return volume_test_objects(vol_leaving_silo, players()) == true || (short)ai_spawn_count(silo_flood_halls.Squad) > 7;
            });
        }

        [ScriptMethod(202, Lifecycle.Dormant)]
        public async Task silo_start()
        {
            await sleep_until(async () => volume_test_objects(vol_silo_enter, players()) == true);
            ai_disposable(disposal_flood, true);
            ai_disposable(disposal_infection, true);
            data_mine_set_mission_segment("04b_3_silo_start");
            game_save();
            kill_volume_enable(kill_silo_toggle);
            ai_renew(all_allies);
            ai_set_orders(arm02_allies, allies_silo);
            ai_place(silo_sentinels_initial.Squad, 2);
            ai_place(silo_flood_initial.Squad, 4);
            wake(new ScriptMethodReference(silo_killer));
            wake(new ScriptMethodReference(music_04b_02_start));
            await sleep_until(async () => volume_test_objects_all(vol_specimen_storage, players()) == true && await this.player_count() > 0);
            wake(new ScriptMethodReference(elev_go));
            wake(new ScriptMethodReference(silo_covers_invincible));
            wake(new ScriptMethodReference(silo_flood_spawner));
            wake(new ScriptMethodReference(silo_sentinel_spawner));
            ai_set_orders(arm02_allies, allies_silo_lift);
            await sleep_until(async () => (short)ai_nonswarm_count(silo_flood_initial.Squad) == 0 && (short)ai_nonswarm_count(silo_sentinels_initial.Squad) == 0, 30, 4000);
            ai_scene("silo_ally_scene", new ScriptMethodReference(silo_ally_comment), all_allies) // Couldn't generate cast from 'Boolean' to 'Void'
            ;
            await sleep_until(async () => this.silo_almost_there == true || volume_test_objects(vol_leaving_silo, players()) == true);
            data_mine_set_mission_segment("04b_5_silo_end");
            this.silo_try_save = true;
            wake(new ScriptMethodReference(silo_hall_flood_spawner));
            ai_set_orders(silo_flood, silo_all);
            ai_place(silo_sentinels_below.Squad, 3);
        }

        [ScriptMethod(203, Lifecycle.CommandScript)]
        public async Task halls2lab_ally_comment()
        {
            cs_switch("ally");
            print("spec-ops elite: 'we should have brought weapons to burn these bodies.'");
            cs_play_line("1240");
            await sleep(30);
            print("spec-ops elite: 'every one is a potential vessel for the flood!'");
            cs_play_line("1250");
        }

        [ScriptMethod(204, Lifecycle.Dormant)]
        public async Task to_flood_lab()
        {
            await sleep_until(async () => volume_test_objects(vol_hall_to_lab, players()) == true);
            ai_disposable(silo_flood, true);
            ai_disposable(silo_infection, true);
            ai_disposable(silo_sentinels_all, true);
            data_mine_set_mission_segment("04b_6_hall_to_lab");
            game_save_no_timeout();
            ai_renew(all_allies);
            ai_set_orders(arm02_allies, allies_lab_upper);
            await sleep_until(async () => volume_test_objects(vol_hall_to_lab, ai_actors(allies_elites)) == true || (short)ai_living_count(allies_elites) == 0);
            ai_scene("halls2lab_scene", new ScriptMethodReference(halls2lab_ally_comment), all_allies) // Couldn't generate cast from 'Boolean' to 'Void'
            ;
        }

        [ScriptMethod(205, Lifecycle.Dormant)]
        public async Task famine_flavor()
        {
            await sleep_until(async () => volume_test_objects(vol_famine_01, players()) == true || volume_test_objects(vol_famine_02, players()) == true);
            object_create(famine);
            ai_place(famine_cf.Squad);
            cs_run_command_script(famine_cf.Squad, new ScriptMethodReference(forever_pause));
            custom_animation_loop(unit(list_get(ai_actors(famine_cf.Squad), 0)), GetTag<AnimationGraphTag>("objects\\characters\\floodcombat_elite\\floodcombat_elite", 4013034938U), "combat:thrash_back:var0", true);
            custom_animation_loop(unit(list_get(ai_actors(famine_cf.Squad), 1)), GetTag<AnimationGraphTag>("objects\\characters\\floodcombat_elite\\floodcombat_elite", 4013034938U), "combat:thrash_back:var1", true);
            custom_animation_loop(unit(list_get(ai_actors(famine_cf.Squad), 2)), GetTag<AnimationGraphTag>("objects\\characters\\floodcombat_elite\\floodcombat_elite", 4013034938U), "combat:thrash_front:var0", true);
            custom_animation_loop(unit(list_get(ai_actors(famine_cf.Squad), 3)), GetTag<AnimationGraphTag>("objects\\characters\\floodcombat_elite\\floodcombat_elite", 4013034938U), "combat:thrash_front:var1", true);
            await sleep_until(async () => unit_has_weapon(unit(await this.player0()), GetTag<BaseTag>("objects\\weapons\\multiplayer\\ball\\head_sp.weapon", 4104262253U)) || unit_has_weapon(unit(await this.player1()), GetTag<BaseTag>("objects\\weapons\\multiplayer\\ball\\head_sp.weapon", 4104262253U)));
            ice_cream_flavor_stock(4);
        }

        [ScriptMethod(206, Lifecycle.CommandScript)]
        public async Task airlock_commander()
        {
            cs_switch("commander");
            print("spec-ops commander: 'bring the phantoms close to the mine! we are not leaving until the leader of these heretics is dead!'");
            cs_play_line("0110");
        }

        [ScriptMethod(207, Lifecycle.Dormant)]
        public async Task airlock_commander_talk()
        {
            ai_dialogue_enable(false);
            await sleep(60);
            print("phantom pilot: 'leader! the storm is about to hit! we cannot maintain our position!'");
            await sleep(ai_play_line_on_object(default(IGameObject), "0100"));
            print("spec-ops commander: 'bring the phantoms close to the mine! we are not leaving until the leader of these heretics is dead!'");
            await sleep(ai_play_line_on_object(default(IGameObject), "0110"));
            await sleep(30);
            ai_dialogue_enable(true);
        }

        [ScriptMethod(208, Lifecycle.Dormant)]
        public async Task research_arm_bsp_swap()
        {
            device_one_sided_set(lab_exit_int.Entity, true);
            device_set_never_appears_locked(lab_exit_int.Entity, true);
            await sleep_until(async () => volume_test_objects_all(vol_research_arm_swap, ai_actors(allies_elites)) == true && await this.player_count() > 0, 30, 300);
            await sleep_until(async () => volume_test_objects_all(vol_research_arm_swap, players()) == true && await this.player_count() > 0 && device_get_position(lab_exit_int.Entity) <= 0F);
            device_operates_automatically_set(lab_exit_int.Entity, false);
            device_set_never_appears_locked(lab_exit_int.Entity, false);
            await sleep_until(async () =>
            {
                if (volume_test_object(trans_3_0, list_get(ai_actors(all_allies), 4)) == false)
                {
                    object_destroy(list_get(ai_actors(all_allies), 4));
                }

                await sleep(2);
                if (volume_test_object(trans_3_0, list_get(ai_actors(all_allies), 3)) == false)
                {
                    object_destroy(list_get(ai_actors(all_allies), 3));
                }

                await sleep(2);
                if (volume_test_object(trans_3_0, list_get(ai_actors(all_allies), 2)) == false)
                {
                    object_destroy(list_get(ai_actors(all_allies), 2));
                }

                await sleep(2);
                if (volume_test_object(trans_3_0, list_get(ai_actors(all_allies), 1)) == false)
                {
                    object_destroy(list_get(ai_actors(all_allies), 1));
                }

                await sleep(2);
                if (volume_test_object(trans_3_0, list_get(ai_actors(all_allies), 0)) == false)
                {
                    object_destroy(list_get(ai_actors(all_allies), 0));
                }

                await sleep(2);
                return false;
            }, 30, 60);
            begin_random(async () => object_create(gas01), 
                async () => await sleep((short)random_range(5, 15)), 
                async () => object_create(gas02), 
                async () => await sleep((short)random_range(5, 15)), 
                async () => object_create(gas03), 
                async () => await sleep((short)random_range(5, 15)), 
                async () => object_create(gas04), 
                async () => await sleep((short)random_range(5, 15)), 
                async () => object_create(gas05), 
                async () => await sleep((short)random_range(5, 15)), 
                async () => object_create(gas06), 
                async () => await sleep((short)random_range(5, 15)), 
                async () => object_create(gas07), 
                async () => await sleep((short)random_range(5, 15)), 
                async () => object_create(gas08), 
                async () => await sleep((short)random_range(5, 15)), 
                async () => object_create(gas09), 
                async () => await sleep((short)random_range(5, 15)), 
                async () => object_create(gas10), 
                async () => await sleep((short)random_range(5, 15)));
            switch_bsp(0);
            ai_set_orders(all_allies, allies_wraparound);
            await sleep_until(async () => (short)structure_bsp_index() == 0);
            wake(new ScriptMethodReference(airlock_commander_talk));
            await sleep(30);
            begin_random(async () => object_destroy(gas01.Entity), 
                async () => await sleep((short)random_range(5, 15)), 
                async () => object_destroy(gas02.Entity), 
                async () => await sleep((short)random_range(5, 15)), 
                async () => object_destroy(gas03.Entity), 
                async () => await sleep((short)random_range(5, 15)), 
                async () => object_destroy(gas04.Entity), 
                async () => await sleep((short)random_range(5, 15)), 
                async () => object_destroy(gas05.Entity), 
                async () => await sleep((short)random_range(5, 15)), 
                async () => object_destroy(gas06.Entity), 
                async () => await sleep((short)random_range(5, 15)), 
                async () => object_destroy(gas07.Entity), 
                async () => await sleep((short)random_range(5, 15)), 
                async () => object_destroy(gas08.Entity), 
                async () => await sleep((short)random_range(5, 15)), 
                async () => object_destroy(gas09.Entity), 
                async () => await sleep((short)random_range(5, 15)), 
                async () => object_destroy(gas10.Entity), 
                async () => await sleep((short)random_range(5, 15)));
            await sleep(30);
            device_operates_automatically_set(lab_exit_ext.Entity, true);
        }

        [ScriptMethod(209, Lifecycle.Dormant)]
        public async Task lab_barricades()
        {
            await sleep_until(async () =>
            {
                begin_random(async () =>
                {
                    if ((short)ai_nonswarm_count(lab_flood) < 4)
                    {
                        ai_place(lab_carriers_01._1);
                    }
                }, 
                    async () =>
                {
                    if ((short)ai_nonswarm_count(lab_flood) < 4)
                    {
                        ai_place(lab_carriers_01._2);
                    }
                }, 
                    async () =>
                {
                    if ((short)ai_nonswarm_count(lab_flood) < 4)
                    {
                        ai_place(lab_carriers_01._3);
                    }
                }, 
                    async () =>
                {
                    if ((short)ai_nonswarm_count(lab_flood) < 4)
                    {
                        ai_place(lab_carriers_01._4);
                    }
                }, 
                    async () =>
                {
                    if ((short)ai_nonswarm_count(lab_flood) < 4)
                    {
                        ai_place(lab_carriers_01._5);
                    }
                }, 
                    async () =>
                {
                    if ((short)ai_nonswarm_count(lab_flood) < 4)
                    {
                        ai_place(lab_carriers_01._6);
                    }
                }, 
                    async () =>
                {
                    if ((short)ai_nonswarm_count(lab_flood) < 4)
                    {
                        ai_place(lab_combatforms_01.Squad, 1);
                    }
                }, 
                    async () =>
                {
                    if ((short)ai_nonswarm_count(lab_flood) < 4)
                    {
                        ai_place(lab_combatforms_01.Squad, 1);
                    }
                }, 
                    async () =>
                {
                    if ((short)ai_nonswarm_count(lab_flood) < 4)
                    {
                        ai_place(lab_combatforms_01.Squad, 1);
                    }
                });
                return (float)ai_strength(lab_heretics_01.Squad) < 0.5F || volume_test_objects(vol_lab_floor, players()) == true;
            });
            await sleep_until(async () =>
            {
                begin_random(async () =>
                {
                    if ((short)ai_nonswarm_count(lab_flood) < 4)
                    {
                        ai_place(lab_carriers_02.Squad, 1);
                    }
                }, 
                    async () =>
                {
                    if ((short)ai_nonswarm_count(lab_flood) < 4)
                    {
                        ai_place(lab_combatforms_02.Squad, 1);
                    }
                });
                return (short)ai_living_count(lab_heretics_01.Squad) == 0 || volume_test_objects(vol_lab_floor, players()) == true;
            });
        }

        [ScriptMethod(210, Lifecycle.CommandScript)]
        public async Task lab_heretics_ally()
        {
            cs_switch("ally");
            print("spec-ops elite: 'heretics!  above!'");
            cs_play_line("1270");
        }

        [ScriptMethod(211, Lifecycle.CommandScript)]
        public async Task lab_heretics_commander()
        {
            cs_switch("commander");
            print("spec-ops commander: 'heretics!  above!'");
            cs_play_line("1260");
        }

        [ScriptMethod(212, Lifecycle.CommandScript)]
        public async Task lab_juggernaut_ally()
        {
            cs_switch("ally");
            print("spec-ops elite: 'it comes!  prepare yourself, arbiter!'");
            cs_play_line("1290");
        }

        [ScriptMethod(213, Lifecycle.CommandScript)]
        public async Task lab_juggernaut_commander()
        {
            cs_switch("commander");
            print("spec-ops commander: 'it comes!  prepare yourself, arbiter!'");
            cs_play_line("1280");
        }

        [ScriptMethod(214, Lifecycle.CommandScript)]
        public async Task lab_jugg_hint1_ally()
        {
            cs_switch("ally");
            print("spec-ops elite: 'it shrugs off our every assault!  it must have a weak spot!'");
            cs_play_line("1290");
        }

        [ScriptMethod(215, Lifecycle.CommandScript)]
        public async Task lab_jugg_hint1_commander()
        {
            cs_switch("commander");
            print("spec-ops commander: 'it shrugs off our every assault!  it must have a weak spot!'");
            cs_play_line("1280");
        }

        [ScriptMethod(216, Lifecycle.CommandScript)]
        public async Task lab_jugg_hint2_ally()
        {
            cs_switch("ally");
            print("spec-ops elite: 'the eye, arbiter!  aim for its eye!'");
            cs_play_line("1290");
        }

        [ScriptMethod(217, Lifecycle.CommandScript)]
        public async Task lab_jugg_hint2_commander()
        {
            cs_switch("commander");
            print("spec-ops commander: 'the eye, arbiter!  aim for its eye!'");
            cs_play_line("1280");
        }

        [ScriptMethod(218, Lifecycle.CommandScript)]
        public async Task stay_shootin()
        {
            cs_enable_targeting(true);
            cs_shoot(true);
            cs_set_behavior(guard);
            sleep_forever();
        }

        [ScriptMethod(219, Lifecycle.CommandScript)]
        public async Task lab_turret_man_r()
        {
            cs_abort_on_damage(true);
            cs_enable_pathfinding_failsafe(true);
            cs_enable_targeting(true);
            cs_shoot(true);
            cs_go_to_vehicle(ai_vehicle_get_from_starting_location(lab_exit_turrets.r));
            await sleep_until(async () => unit_in_vehicle(unit(ai_get_object(this.ai_current_actor))) == true, 30, 450);
            if (unit_in_vehicle(unit(ai_get_object(this.ai_current_actor))) == true)
            {
                cs_set_behavior(guard);
                sleep_forever();
            }
        }

        [ScriptMethod(220, Lifecycle.CommandScript)]
        public async Task lab_turret_man_l()
        {
            cs_abort_on_damage(true);
            cs_enable_pathfinding_failsafe(true);
            cs_enable_targeting(true);
            cs_shoot(true);
            cs_go_to_vehicle(ai_vehicle_get_from_starting_location(lab_exit_turrets.l));
            await sleep_until(async () => unit_in_vehicle(unit(ai_get_object(this.ai_current_actor))) == true, 30, 450);
            if (unit_in_vehicle(unit(ai_get_object(this.ai_current_actor))) == true)
            {
                cs_set_behavior(guard);
                sleep_forever();
            }
        }

        [ScriptMethod(221, Lifecycle.Dormant)]
        public async Task fuck_this_turret_shit()
        {
            await sleep(120);
            ai_vehicle_enter(lab_grunts_02.Squad, ai_vehicle_get_from_starting_location(lab_exit_turrets.r));
            ai_vehicle_enter(lab_grunts_02.Squad, ai_vehicle_get_from_starting_location(lab_exit_turrets.l));
        }

        [ScriptMethod(222, Lifecycle.Dormant)]
        public async Task lab_wave_new_01()
        {
            await sleep_until(async () =>
            {
                if ((short)ai_nonswarm_count(lab_flood) < 4)
                {
                    ai_place(lab_carriers_02.Squad, 1);
                    this.lab_flood_count = (short)(this.lab_flood_count + 1);
                }

                return this.lab_flood_count > 5;
            }, 30, 8000);
        }

        [ScriptMethod(223, Lifecycle.Dormant)]
        public async Task lab_wave_new_02()
        {
            await sleep_until(async () =>
            {
                if ((short)ai_nonswarm_count(lab_flood) < 4)
                {
                    ai_place(lab_combatforms_02.Squad, 1);
                    this.lab_flood_count = (short)(this.lab_flood_count + 1);
                }

                return false;
            }, 30, 1800);
        }

        [ScriptMethod(224, Lifecycle.Dormant)]
        public async Task flood_lab_start()
        {
            await sleep_until(async () => volume_test_objects(vol_lab_enter, players()) == true);
            data_mine_set_mission_segment("04b_7_flood_lab_start");
            game_save_no_timeout();
            this.silo_killer_power = false;
            ai_place(lab_heretics_01.Squad, 1);
            ai_place(lab_turret_grunts_01.Squad, 2);
            ai_place(lab_exit_turrets.Squad, 2);
            ai_place(lab_carriers_01.init1);
            ai_place(lab_carriers_01.init2);
            ai_place(lab_carriers_01.init3);
            wake(new ScriptMethodReference(lab_barricades));
            if (await this.difficulty_legendary())
            {
                wake(new ScriptMethodReference(famine_flavor));
            }

            wake(new ScriptMethodReference(music_04b_03_start));
            await sleep_until(async () => volume_test_objects_all(vol_lab_floor, players()) == true && await this.player_count() > 0, 30, 900);
            if (volume_test_objects_all(vol_lab_floor, players()) == false && await this.player_count() > 0)
            {
                begin_random(async () => ai_place(lab_combatforms_02.r1), 
                    async () => await sleep((short)random_range(5, 45)), 
                    async () => ai_place(lab_combatforms_02.r2), 
                    async () => await sleep((short)random_range(5, 45)), 
                    async () => ai_place(lab_combatforms_02.r3), 
                    async () => await sleep((short)random_range(5, 45)), 
                    async () => ai_place(lab_combatforms_02.r4), 
                    async () => await sleep((short)random_range(5, 45)));
            }

            await sleep_until(async () => volume_test_objects_all(vol_lab_floor, players()) == true && await this.player_count() > 0);
            game_save_no_timeout();
            ai_set_orders(arm02_allies, allies_lab_lower);
            await sleep_until(async () => (short)ai_nonswarm_count(lab_flood) == 0 && (short)ai_living_count(lab_heretics) == 0 && volume_test_objects_all(vol_lab_floor, players()) == true && await this.player_count() > 0, 30, 8000);
            data_mine_set_mission_segment("04b_8_flood_lab_mid_01");
            game_save_no_timeout();
            ai_place(lab_heretics_above.Squad, 3);
            await sleep(15);
            ai_magically_see_object(lab_heretics_above.Squad, await this.player0());
            ai_magically_see_object(lab_heretics_above.Squad, await this.player1());
            await sleep_until(async () => objects_can_see_object(players(), list_get(ai_actors(lab_heretics_above.Squad), 0), 60F) == true, 30, 450);
            await sleep_until(async () => (short)ai_living_count(allies_elites) == 0 || ai_scene("lab_heretic_ally_scene", new ScriptMethodReference(lab_heretics_ally), all_allies), 30, 300);
            ai_place(lab_combatforms_02.r2);
            ai_place(lab_carriers_02.r4);
            ai_set_orders(lab_flood, lab_above);
            await sleep_until(async () =>
            {
                begin_random(async () =>
                {
                    if ((short)ai_nonswarm_count(lab_flood) < 4)
                    {
                        ai_place(lab_combatforms_02.r1);
                        await sleep((short)random_range(10, 40));
                    }
                }, 
                    async () =>
                {
                    if ((short)ai_nonswarm_count(lab_flood) < 4)
                    {
                        ai_place(lab_combatforms_02.r2);
                        await sleep((short)random_range(10, 40));
                    }
                }, 
                    async () =>
                {
                    if ((short)ai_nonswarm_count(lab_flood) < 4)
                    {
                        ai_place(lab_combatforms_02.r3);
                        await sleep((short)random_range(10, 40));
                    }
                }, 
                    async () =>
                {
                    if ((short)ai_nonswarm_count(lab_flood) < 4)
                    {
                        ai_place(lab_combatforms_02.r4);
                        await sleep((short)random_range(10, 40));
                    }
                }, 
                    async () =>
                {
                    if ((short)ai_nonswarm_count(lab_flood) < 4)
                    {
                        ai_place(lab_combatforms_02.r5);
                        await sleep((short)random_range(10, 40));
                    }
                }, 
                    async () =>
                {
                    if ((short)ai_nonswarm_count(lab_flood) < 4)
                    {
                        ai_place(lab_carriers_02.r1);
                        await sleep((short)random_range(10, 40));
                    }
                }, 
                    async () =>
                {
                    if ((short)ai_nonswarm_count(lab_flood) < 4)
                    {
                        ai_place(lab_carriers_02.r2);
                        await sleep((short)random_range(10, 40));
                    }
                }, 
                    async () =>
                {
                    if ((short)ai_nonswarm_count(lab_flood) < 4)
                    {
                        ai_place(lab_carriers_02.r3);
                        await sleep((short)random_range(10, 40));
                    }
                }, 
                    async () =>
                {
                    if ((short)ai_nonswarm_count(lab_flood) < 4)
                    {
                        ai_place(lab_carriers_02.r4);
                        await sleep((short)random_range(10, 40));
                    }
                }, 
                    async () =>
                {
                    if ((short)ai_nonswarm_count(lab_flood) < 4)
                    {
                        ai_place(lab_carriers_02.r5);
                        await sleep((short)random_range(10, 40));
                    }
                });
                return (short)ai_living_count(lab_heretics_above.Squad) < 1 || volume_test_objects_all(vol_lab_floor, ai_actors(lab_heretics_above.Squad)) == true && await this.player_count() > 0;
            }, 30, 4000);
            game_save_no_timeout();
            ai_set_orders(lab_heretics_above.Squad, lab_flood_all);
            ai_set_orders(lab_flood, lab_flood_all);
            ai_set_orders(arm02_allies, allies_lab_wagons);
            await sleep_until(async () => (short)ai_nonswarm_count(lab_flood) < 1 && (short)ai_living_count(lab_heretics_above.Squad) < 1, 30, 2000);
            game_save_no_timeout();
            await this.music_04b_03_start_alt();
            this.lab_flood_count = 0;
            wake(new ScriptMethodReference(lab_wave_new_02));
            await sleep(1800);
            await sleep_until(async () => (short)ai_nonswarm_count(lab_flood) < 1, 30, 3600);
            await sleep_until(async () => (bool)ai_trigger_test("done_fighting", lab_flood) == true, 30, 1800);
            data_mine_set_mission_segment("04b_9_flood_lab_mid_02");
            game_save_no_timeout();
            await this.music_04b_03_stop_alt();
            this.lab_flood_count = 0;
            wake(new ScriptMethodReference(lab_wave_new_01));
            data_mine_set_mission_segment("04b_10_flood_lab_end");
            await sleep(90);
            device_operates_automatically_set(lab_exit_int.Entity, true);
            ai_place(lab_heretics_02.Squad, 2);
            ai_place(lab_grunts_02.Squad, 3);
            ai_set_orders(arm02_allies, allies_lab_end);
            wake(new ScriptMethodReference(fuck_this_turret_shit));
            wake(new ScriptMethodReference(music_04b_03_stop));
            await sleep_until(async () => (short)ai_living_count(lab_heretics) == 0 || volume_test_objects_all(vol_research_arm_swap, players()) == true && await this.player_count() > 0);
            game_save_no_timeout();
            ai_set_orders(all_allies, allies_airlock);
            wake(new ScriptMethodReference(research_arm_bsp_swap));
        }

        [ScriptMethod(225, Lifecycle.Dormant)]
        public async Task wind()
        {
            await sleep_until(async () =>
            {
                await sleep_until(async () =>
                {
                    sound_impulse_start(GetTag<SoundTag>("sound\\ambience\\sound_scenery\\gusty_wind\\details\\gusty_wind", 4231076324U), default(IGameObject), 1F);
                    await sleep_until(async () => volume_test_objects(vol_control_enter, players()) == true || (short)structure_bsp_index() == 2, 5, 30);
                    player_effect_set_max_rotation((float)real_random_range(0.1F, 1F), (float)real_random_range(0.1F, 1F), 0F);
                    player_effect_start((float)real_random_range(0.05F, 0.2F), (float)real_random_range(0.5F, 2F));
                    player_effect_stop((float)real_random_range(3F, 5F));
                    await sleep_until(async () => volume_test_objects(vol_control_enter, players()) == true || (short)structure_bsp_index() == 2, 5, (int)random_range(150, 300));
                    return volume_test_objects(vol_control_enter, players()) == true || (short)structure_bsp_index() == 2;
                });
                await sleep_until(async () => volume_test_objects(vol_gusty, players()) == true || (short)structure_bsp_index() == 2, 5);
                return (short)structure_bsp_index() == 2;
            });
        }

        [ScriptMethod(226, Lifecycle.CommandScript)]
        public async Task bridge_phantom_arrives()
        {
            cs_enable_pathfinding_failsafe(true);
            cs_fly_by(GetReference<ISpatialPoint>("airspace_bridge/ph0"), 5F);
            cs_vehicle_speed(0.5F);
            cs_fly_by(GetReference<ISpatialPoint>("airspace_bridge/ph1"), 2F);
            object_set_phantom_power(ai_vehicle_get_from_starting_location(allied_phantom_02.pilot), true);
            await sleep(30);
            vehicle_unload(ai_vehicle_get_from_starting_location(allied_phantom_02.pilot), "phantom_p_a03");
            await sleep(30);
            vehicle_unload(ai_vehicle_get_from_starting_location(allied_phantom_02.pilot), "phantom_p_a02");
            await sleep(30);
            vehicle_unload(ai_vehicle_get_from_starting_location(allied_phantom_02.pilot), "phantom_p_a01");
            await sleep(30);
            vehicle_unload(ai_vehicle_get_from_starting_location(allied_phantom_02.pilot), "phantom_p_b01");
            vehicle_unload(ai_vehicle_get_from_starting_location(allied_phantom_02.pilot), "phantom_p");
            await sleep_until(async () => (short)ai_living_count(allied_phantom_02.Squad) < 2);
            await sleep(60);
            object_set_phantom_power(ai_vehicle_get_from_starting_location(allied_phantom_02.pilot), false);
            cs_fly_by(GetReference<ISpatialPoint>("airspace_bridge/ph2"), 5F);
            cs_fly_by(GetReference<ISpatialPoint>("airspace_bridge/ph3"), 5F);
            cs_fly_by(GetReference<ISpatialPoint>("airspace_bridge/ph4"), 5F);
            cs_fly_to(GetReference<ISpatialPoint>("airspace_bridge/phx"), 2F);
            ai_erase(allied_phantom_02.Squad);
        }

        [ScriptMethod(227, Lifecycle.Dormant)]
        public async Task bridge_phantom_go()
        {
            ai_place(allies_elites_04.Squad, (short)(2 - (float)ai_living_count(allies_elites)));
            ai_place(allies_grunts_04.Squad, (short)(2 - (float)ai_living_count(allies_grunts_03.Squad)));
            ai_place(allied_phantom_02.Squad);
            vehicle_load_magic(ai_vehicle_get_from_starting_location(allied_phantom_02.pilot), "phantom_p", ai_actors(allies_grunts_04.Squad));
            vehicle_load_magic(ai_vehicle_get_from_starting_location(allied_phantom_02.pilot), "phantom_p", ai_actors(allies_elites_04.Squad));
            ai_vehicle_reserve(ai_vehicle_get_from_starting_location(allied_phantom_02.pilot), true);
            cs_run_command_script(allied_phantom_02.pilot, new ScriptMethodReference(bridge_phantom_arrives));
        }

        [ScriptMethod(228, Lifecycle.CommandScript)]
        public async Task bridge_commander_comment()
        {
            cs_switch("commander");
            cs_start_approach_player(1F, 20F, 20F);
            print("spec-ops commander: 'arbiter, the flood has spread throughout the station!'");
            cs_play_line("0670");
            print("spec-ops commander: 'we don't have enough troops to manage such a large infestation!'");
            cs_play_line("0680");
            print("spec-ops commander: 'find the leader of these heretics! kill him now!'");
            cs_play_line("0672");
            cs_approach_stop();
        }

        [ScriptMethod(229, Lifecycle.CommandScript)]
        public async Task bridge_commander_reminder()
        {
            cs_switch("commander");
            cs_start_approach_player(1F, 20F, 20F);
            print("spec-ops commander: 'onward! to the core of the station!'");
            cs_play_line("1340");
            cs_approach_stop();
        }

        [ScriptMethod(230, Lifecycle.Dormant)]
        public async Task bridge_reminder()
        {
            await sleep_until(async () => volume_test_objects(vol_control_enter, players()) == true, 30, 8000);
            if (volume_test_objects(vol_control_enter, players()) == false && await this.player_count() > 0)
            {
                ai_dialogue_enable(false);
                await sleep(60);
                print("spec-ops commander: 'onward! to the core of the station!'");
                await sleep(ai_play_line_on_object(default(IGameObject), "1340"));
                await sleep(30);
                ai_dialogue_enable(true);
            }
        }

        [ScriptMethod(231, Lifecycle.Dormant)]
        public async Task wraparound_right()
        {
            await sleep_until(async () => this.bridge_final_gone == false && volume_test_objects(vol_wrap_right_01, players()) == true);
            if ((short)ai_nonswarm_count(bridge_enemies) < 8)
            {
                ai_place(bridge_heretics_R_02.Squad, 2);
            }

            if ((short)ai_nonswarm_count(bridge_enemies) < 8)
            {
                ai_place(bridge_h_grunts_R_03.Squad, (short)(4 - (float)ai_living_count(bridge_h_grunts_init.Squad) + (float)ai_living_count(bridge_runners.Squad)));
            }

            await sleep_until(async () => this.bridge_final_gone == false && volume_test_objects(vol_wrap_right_02, players()) == true);
            game_save();
            if ((short)ai_nonswarm_count(bridge_enemies) < 8)
            {
                ai_place(bridge_heretics_R_04.Squad, (short)(2 - (float)ai_living_count(bridge_heretics_R_02.Squad)));
            }

            await sleep_until(async () => this.bridge_final_gone == false && volume_test_objects(vol_wrap_right_03, players()) == true);
            if ((short)ai_nonswarm_count(bridge_enemies) < 8)
            {
                ai_place(bridge_sentinels_R_05.Squad, 3);
            }

            await sleep_until(async () => this.bridge_final_gone == false && volume_test_objects(vol_wrap_final, players()) == true);
            this.bridge_final_gone = true;
            if ((short)ai_nonswarm_count(bridge_enemies) < 8)
            {
                ai_place(bridge_heretics_final.Squad, (short)(2 - (float)ai_living_count(bridge_heretics_R_04.Squad) + (float)ai_living_count(bridge_heretics_L_04.Squad)));
            }

            if ((short)ai_nonswarm_count(bridge_enemies) < 8)
            {
                ai_place(bridge_h_grunts_final.Squad, 2);
            }
        }

        [ScriptMethod(232, Lifecycle.Dormant)]
        public async Task wraparound_left()
        {
            await sleep_until(async () => this.bridge_final_gone == false && volume_test_objects(vol_wrap_left_01, players()) == true);
            if ((short)ai_nonswarm_count(bridge_enemies) < 8)
            {
                ai_place(bridge_heretics_L_02.Squad, 2);
            }

            if ((short)ai_nonswarm_count(bridge_enemies) < 8)
            {
                ai_place(bridge_h_grunts_L_03.Squad, (short)(4 - (float)ai_living_count(bridge_h_grunts_init.Squad) + (float)ai_living_count(bridge_runners.Squad)));
            }

            await sleep_until(async () => this.bridge_final_gone == false && volume_test_objects(vol_wrap_left_02, players()) == true);
            game_save();
            if ((short)ai_nonswarm_count(bridge_enemies) < 8)
            {
                ai_place(bridge_heretics_L_04.Squad, (short)(2 - (float)ai_living_count(bridge_heretics_L_02.Squad)));
            }

            await sleep_until(async () => this.bridge_final_gone == false && volume_test_objects(vol_wrap_left_03, players()) == true);
            if ((short)ai_nonswarm_count(bridge_enemies) < 8)
            {
                ai_place(bridge_sentinels_L_05.Squad, 3);
            }

            await sleep_until(async () => this.bridge_final_gone == false && volume_test_objects(vol_wrap_final, players()) == true);
            this.bridge_final_gone = true;
            if ((short)ai_nonswarm_count(bridge_enemies) < 8)
            {
                ai_place(bridge_heretics_final.Squad, (short)(2 - (float)ai_living_count(bridge_heretics_R_04.Squad) + (float)ai_living_count(bridge_heretics_L_04.Squad)));
            }

            if ((short)ai_nonswarm_count(bridge_enemies) < 8)
            {
                ai_place(bridge_h_grunts_final.Squad, 2);
            }
        }

        [ScriptMethod(233, Lifecycle.Dormant)]
        public async Task bridge_start()
        {
            data_mine_set_mission_segment("04b_11_wraparound");
            ai_disposable(lab_flood, true);
            ai_disposable(lab_heretics, true);
            game_save();
            await sleep(60);
            ai_place(bridge_runners.Squad, 2);
            ai_place(bridge_h_grunts_init.Squad, 3);
            ai_place(bridge_infection.Squad, 3);
            ai_place(bridge_combatforms.Squad, 1);
            ai_place(bridge_carriers.Squad, 2);
            device_operates_automatically_set(control_room_ext.Entity, true);
            await sleep_until(async () => volume_test_objects(vol_on_bridge, players()) == true, 30, 150);
            game_save();
            wake(new ScriptMethodReference(wraparound_right));
            wake(new ScriptMethodReference(wraparound_left));
            ai_renew(all_allies);
            wake(new ScriptMethodReference(bridge_phantom_go));
            wake(new ScriptMethodReference(bridge_reminder));
            wake(new ScriptMethodReference(wind));
            await sleep_until(async () => (short)ai_living_count(allied_phantom_02.Squad) > 1);
            await sleep_until(async () => (short)ai_living_count(allied_phantom_02.Squad) < 2);
            ai_dialogue_enable(false);
            await sleep(60);
            print("spec-ops commander: 'arbiter, the flood has spread throughout the station!'");
            await sleep(ai_play_line_on_object(default(IGameObject), "0670"));
            print("spec-ops commander: 'we don't have enough troops to manage such a large infestation!'");
            await sleep(ai_play_line_on_object(default(IGameObject), "0671"));
            print("spec-ops commander: 'find the leader of these heretics! kill him now!'");
            await sleep(ai_play_line_on_object(default(IGameObject), "0672"));
            await sleep(30);
            ai_dialogue_enable(true);
            game_save_no_timeout();
        }

        [ScriptMethod(234, Lifecycle.Dormant)]
        public async Task hl_killer()
        {
            await sleep_until(async () =>
            {
                if (volume_test_object(vol_hl_killer, await this.player0()) == true)
                {
                    unit_kill(unit(await this.player0()));
                }

                if (volume_test_object(vol_hl_killer, await this.player1()) == true)
                {
                    unit_kill(unit(await this.player1()));
                }

                return (short)structure_bsp_index() == 2;
            }, 1);
        }

        [ScriptMethod(235, Lifecycle.Dormant)]
        public async Task hologram_toggle()
        {
            await sleep_until(async () =>
            {
                await sleep_until(async () => objects_distance_to_flag(players(), mine_holo) <= 5F);
                object_create_anew(gasmine_hologram);
                object_set_function_variable(gasmine_hologram.Entity, "holo_power", 0F, 0F);
                object_set_function_variable(gasmine_hologram.Entity, "holo_power", 1F, 30F);
                await sleep(30);
                await sleep_until(async () => objects_distance_to_flag(players(), mine_holo) > 5F);
                object_set_function_variable(gasmine_hologram.Entity, "holo_power", 1F, 0F);
                object_set_function_variable(gasmine_hologram.Entity, "holo_power", 0F, 30F);
                await sleep(30);
                object_destroy(gasmine_hologram.Entity);
                return false;
            });
        }

        [ScriptMethod(236, Lifecycle.Dormant)]
        public async Task control_commander_reminder()
        {
            await sleep_until(async () => device_get_position(elev_control_up.Entity) > 0F, 30, 3600);
            if (device_get_position(elev_control_up.Entity) <= 0F)
            {
                ai_dialogue_enable(false);
                await sleep(60);
                print("spec-ops commander: 'make your way up to the cable, arbiter.'");
                await sleep(ai_play_line_on_object(default(IGameObject), "1350"));
                print("spec-ops commander: 'there should be an elevator above you!'");
                await sleep(ai_play_line_on_object(default(IGameObject), "1360"));
                await sleep(30);
                ai_dialogue_enable(true);
            }
        }

        [ScriptMethod(237, Lifecycle.CommandScript)]
        public async Task control_grunt_comment()
        {
            cs_switch("grunt");
            print("spec-ops grunt: 'heretic boss! you see? you see?'");
            cs_play_line("0700");
        }

        [ScriptMethod(238, Lifecycle.CommandScript)]
        public async Task control_elite_comment()
        {
            cs_switch("elite");
            print("spec-ops elite: 'there! the heretic leader!'");
            cs_play_line("0680");
        }

        [ScriptMethod(239, Lifecycle.CommandScript)]
        public async Task heretic_leader_holes_up()
        {
            cs_enable_pathfinding_failsafe(true);
            cs_force_combat_status(4);
            cs_go_to(GetReference<ISpatialPoint>("control_room/p0"));
            cs_face_player(true);
            device_set_position_immediate(shield.Entity, 0F);
            sleep_forever();
        }

        [ScriptMethod(240, Lifecycle.CommandScript)]
        public async Task sog_bug_out_01()
        {
            cs_enable_pathfinding_failsafe(true);
            cs_enable_targeting(true);
            cs_shoot(true);
            cs_go_to(GetReference<ISpatialPoint>("bridge/p3"));
        }

        [ScriptMethod(241, Lifecycle.CommandScript)]
        public async Task sog_bug_out_02()
        {
            cs_enable_pathfinding_failsafe(true);
            cs_enable_targeting(true);
            cs_shoot(true);
            cs_go_to(GetReference<ISpatialPoint>("bridge/p4"));
        }

        [ScriptMethod(242, Lifecycle.CommandScript)]
        public async Task sog_bug_out_03()
        {
            cs_enable_pathfinding_failsafe(true);
            cs_enable_targeting(true);
            cs_shoot(true);
            cs_go_to(GetReference<ISpatialPoint>("bridge/p5"));
        }

        [ScriptMethod(243, Lifecycle.CommandScript)]
        public async Task sog_bug_out_04()
        {
            cs_enable_pathfinding_failsafe(true);
            cs_enable_targeting(true);
            cs_shoot(true);
            cs_go_to(GetReference<ISpatialPoint>("bridge/p6"));
        }

        [ScriptMethod(244, Lifecycle.CommandScript)]
        public async Task commander_farewell()
        {
            cs_switch("commander");
            print("spec-ops commander: 'warriors, return to the landing-zone! the arbiter will continue upward, cut this station loose, and scare the heretic from his hole!'");
            cs_play_line("0120");
            this.comm_farewell_done = true;
            await sleep_until(async () => this.soe_farewell_done == true || (short)ai_living_count(control_elites_cinematic.Squad) < 2);
            await sleep(30);
            cs_start_approach_player(2F, 20F, 20F);
            cs_enable_moving(true);
            cs_enable_looking(true);
            if (unit_has_weapon(unit(await this.player0()), GetTag<BaseTag>("objects\\weapons\\melee\\energy_blade\\energy_blade.weapon", 3786211383U)) || unit_has_weapon(unit(await this.player1()), GetTag<BaseTag>("objects\\weapons\\melee\\energy_blade\\energy_blade.weapon", 3786211383U)))
            {
                print("spec-ops commander: 'keep your blade handy - i doubt the cable can withstand its bite.'");
                cs_play_line("0140");
            }
            else
            {
                print("spec-ops commander: 'take my blade - i doubt the cable can withstand its bite.'");
                cs_play_line("0130");
                await sleep_until(async () => unit_has_weapon(unit(await this.player0()), GetTag<BaseTag>("objects\\weapons\\melee\\energy_blade\\energy_blade.weapon", 3786211383U)) || unit_has_weapon(unit(await this.player1()), GetTag<BaseTag>("objects\\weapons\\melee\\energy_blade\\energy_blade.weapon", 3786211383U)) || volume_test_objects(vol_control_middle, players()) == true, 30, 900);
            }
        }

        [ScriptMethod(245, Lifecycle.CommandScript)]
        public async Task spec_op_farewell()
        {
            cs_switch("ally01");
            await sleep_until(async () => this.comm_farewell_done == true);
            await sleep(30);
            print("spec-ops elite: 'may our lords guide your hand!'");
            cs_play_line("0150");
            cs_enable_moving(true);
            cs_switch("ally02");
            await sleep(30);
            print("spec-ops elite: 'we shall not forget your sacrifice!'");
            cs_play_line("0160");
            this.soe_farewell_done = true;
        }

        [ScriptMethod(246, Lifecycle.CommandScript)]
        public async Task soe_bug_out_01()
        {
            await sleep_until(async () => this.comm_farewell_done == true);
            await sleep(30);
            print("spec-ops elite: 'may our lords guide your hand!'");
            cs_play_line("0150");
        }

        [ScriptMethod(247, Lifecycle.CommandScript)]
        public async Task soe_bug_out_02()
        {
            await sleep_until(async () => this.comm_farewell_done == true);
            await sleep(120);
            print("spec-ops elite: 'we shall not forget your sacrifice!'");
            cs_play_line("0160");
            await sleep(15);
            this.soe_farewell_done = true;
        }

        [ScriptMethod(248, Lifecycle.CommandScript)]
        public async Task control_bug_out_flight()
        {
            cs_enable_pathfinding_failsafe(true);
            cs_fly_by(GetReference<ISpatialPoint>("airspace_bridge/ph1too"));
            cs_vehicle_speed(0.5F);
            cs_fly_by(GetReference<ISpatialPoint>("airspace_bridge/ph2too"));
            cs_fly_to_and_face(GetReference<ISpatialPoint>("airspace_bridge/ph3too"), GetReference<ISpatialPoint>("airspace_bridge/ph4too"));
            this.bug_out_phantom_here = true;
            object_create(phantom_vol);
            await sleep_until(async () => (short)ai_living_count(all_allies) < 1);
            cs_pause(1F);
            object_destroy(phantom_vol.Entity);
            cs_fly_by(GetReference<ISpatialPoint>("airspace_bridge/ph4too"));
            cs_vehicle_speed(1F);
            cs_fly_to(GetReference<ISpatialPoint>("airspace_bridge/phxtoo"));
            ai_erase(allied_phantom_03.Squad);
        }

        [ScriptMethod(249, Lifecycle.CommandScript)]
        public async Task bug_out_pussy()
        {
            cs_enable_pathfinding_failsafe(true);
            cs_go_to(GetReference<ISpatialPoint>("bridge/grav"));
            cs_jump(0F, 1F);
            await sleep_until(async () => volume_test_objects(vol_gusty, ai_get_object(this.ai_current_actor)) == false, 1);
            object_set_scale(ai_get_object(this.ai_current_actor), 0.1F, 15);
            await sleep(15);
            ai_erase(this.ai_current_actor);
        }

        [ScriptMethod(250, Lifecycle.Dormant)]
        public async Task control_bug_out()
        {
            ai_place(allied_phantom_03.Squad);
            cs_run_command_script(allied_phantom_03.Squad, new ScriptMethodReference(control_bug_out_flight));
            await sleep_until(async () => this.bug_out_phantom_here == true);
            cs_queue_command_script(control_commander_cinematic.Squad, new ScriptMethodReference(bug_out_pussy));
            await sleep_until(async () => (short)ai_living_count(control_commander_cinematic.Squad) < 1);
            cs_run_command_script(control_elites_cinematic.elite01, new ScriptMethodReference(bug_out_pussy));
            await sleep_until(async () => (short)ai_living_count(control_elites_cinematic.Squad) < 2);
            cs_run_command_script(control_elites_cinematic.elite02, new ScriptMethodReference(bug_out_pussy));
            await sleep_until(async () => (short)ai_living_count(control_elites_cinematic.Squad) < 1);
            cs_run_command_script(allies_grunts_03.Squad, new ScriptMethodReference(bug_out_pussy));
            await sleep_until(async () => (short)ai_living_count(allies_grunts_03.Squad) < 1);
            cs_run_command_script(allies_grunts_04.Squad, new ScriptMethodReference(bug_out_pussy));
            await sleep_until(async () => (short)ai_living_count(allies_grunts_04.Squad) < 1);
        }

        [ScriptMethod(251, Lifecycle.Dormant)]
        public async Task control_flood_spawn()
        {
            await sleep_until(async () =>
            {
                begin_random(async () =>
                {
                    if ((short)ai_nonswarm_count(control_flood) < 6 && volume_test_objects(vol_control_middle_spawnroom, players()) == false && volume_test_objects(vol_control_perimeter, players()) == false && await this.player_count() > 0)
                    {
                        ai_place(control_flood_wave_02_combat.Squad, 1);
                    }
                }, 
                    async () =>
                {
                    if ((short)ai_nonswarm_count(control_flood) < 6 && volume_test_objects(vol_control_middle_spawnroom, players()) == false && volume_test_objects(vol_control_perimeter, players()) == false && await this.player_count() > 0)
                    {
                        ai_place(control_flood_wave_02_combat.Squad, 1);
                    }
                }, 
                    async () =>
                {
                    if ((short)ai_nonswarm_count(control_flood) < 6 && volume_test_objects(vol_control_middle_spawnroom, players()) == false && volume_test_objects(vol_control_perimeter, players()) == false && await this.player_count() > 0)
                    {
                        ai_place(control_flood_wave_02_carriers.Squad, 1);
                    }
                }, 
                    async () =>
                {
                    if ((short)ai_nonswarm_count(control_flood) < 6 && volume_test_objects(vol_control_middle_spawnroom, players()) == false && volume_test_objects(vol_control_perimeter, players()) == false && await this.player_count() > 0)
                    {
                        ai_place(control_flood_wave_03_combat.Squad, 1);
                    }
                }, 
                    async () =>
                {
                    if ((short)ai_nonswarm_count(control_flood) < 6 && volume_test_objects(vol_control_middle_spawnroom, players()) == false && volume_test_objects(vol_control_perimeter, players()) == false && await this.player_count() > 0)
                    {
                        ai_place(control_flood_wave_03_combat.Squad, 1);
                    }
                }, 
                    async () =>
                {
                    if ((short)ai_nonswarm_count(control_flood) < 6 && volume_test_objects(vol_control_middle_spawnroom, players()) == false && volume_test_objects(vol_control_perimeter, players()) == false && await this.player_count() > 0)
                    {
                        ai_place(control_flood_wave_03_carriers.Squad, 1);
                    }
                });
                return volume_test_objects(vol_control_perimeter, players()) == true || (short)ai_spawn_count(control_flood) > 10;
            });
        }

        [ScriptMethod(252, Lifecycle.Dormant)]
        public async Task control_room_start()
        {
            await sleep_until(async () => volume_test_objects(vol_control_enter, players()) == true);
            wake(new ScriptMethodReference(hl_killer));
            ai_disposable(bridge_flood, true);
            ai_disposable(bridge_heretics, true);
            ai_disposable(bridge_sentinels, true);
            data_mine_set_mission_segment("04b_12_control_room_01");
            game_save();
            ai_migrate(allies_elites, allies_elites_04.Squad);
            device_set_power(control_up_switch_01.Entity, 0F);
            device_set_position_immediate(elev_control_up.Entity, 0.041F);
            device_set_position_immediate(shield.Entity, 1F);
            device_set_position_immediate(control_shield_door.Entity, 1F);
            ai_renew(all_allies);
            ai_set_orders(core_allies, allies_control);
            ai_place(heretic_leader_control.Squad);
            ai_cannot_die(heretic_leader_control.Squad, true);
            unit_impervious(ai_actors(heretic_leader_control.Squad), true);
            ai_set_blind(heretic_leader_control.Squad, true);
            ai_set_deaf(heretic_leader_control.Squad, true);
            cs_run_command_script(heretic_leader_control.Squad, new ScriptMethodReference(heretic_leader_holes_up));
            ai_disregard(ai_actors(heretic_leader_control.Squad), true);
            ai_place(control_flood_wave_01_combat.Squad, 4);
            ai_place(control_sentinels_wave_01.Squad, 3);
            wake(new ScriptMethodReference(music_04b_04_start));
            wake(new ScriptMethodReference(hologram_toggle));
            await sleep_until(async () => volume_test_objects(vol_control_enter, ai_actors(allies_grunts_03.Squad)) == true || volume_test_objects(vol_control_enter, ai_actors(allies_grunts_04.Squad)) == true || volume_test_objects(vol_control_enter, ai_actors(allies_elites_04.Squad)) == true, 30, 300);
            await sleep_until(async () => ai_scene("control_grunt_scene", new ScriptMethodReference(control_grunt_comment), all_allies) || ai_scene("control_elite_scene", new ScriptMethodReference(control_elite_comment), all_allies), 30, 300);
            await sleep_until(async () => (short)ai_nonswarm_count(control_flood_wave_01_combat.Squad) == 0 && (short)ai_living_count(control_sentinels_wave_01.Squad) == 0);
            await sleep(60);
            wake(new ScriptMethodReference(music_04b_04_start_alt));
            await this.cinematic_fade_to_white();
            ai_erase(heretic_leader_control.Squad);
            ai_erase(all_enemies);
            ai_erase(disposal_commander.Squad);
            ai_erase(allies_elites);
            ai_erase(allies_elites_04.Squad);
            object_teleport(await this.player0(), player0_hide);
            object_teleport(await this.player1(), player1_hide);
            sleep_forever(new ScriptMethodReference(hologram_toggle));
            object_create_anew(gasmine_hologram);
            object_set_function_variable(gasmine_hologram.Entity, "holo_power", 1F, 0F);
            if (await this.cinematic_skip_start())
            {
                await this.c04_intra1();
            }

            await this.cinematic_skip_stop();
            sound_suppress_ambience_update_on_revert();
            sound_class_set_gain("amb", 0F, 0);
            await sleep(1);
            sound_class_set_gain("amb", 1F, 15);
            await sleep(2);
            object_teleport(await this.player0(), player0_control);
            object_teleport(await this.player1(), player1_control);
            device_set_position_immediate(control_shield_door.Entity, 0F);
            device_set_position_immediate(shield.Entity, 0F);
            ai_place(control_elites_cinematic.Squad);
            ai_place(control_commander_cinematic.Squad);
            ai_cannot_die(control_commander_cinematic.Squad, true);
            ai_set_orders(all_allies, allies_pickup);
            device_set_power(control_up_switch_01.Entity, 1F);
            wake(new ScriptMethodReference(hologram_toggle));
            camera_control(false);
            await sleep(1);
            await cache_block_for_one_frame();
            await sleep(1);
            await this.cinematic_fade_from_white();
            wake(new ScriptMethodReference(music_04b_04_stop_alt));
            wake(new ScriptMethodReference(objective_control_clear));
            wake(new ScriptMethodReference(objective_cables_set));
            ai_scene("control_comm_scene", new ScriptMethodReference(commander_farewell), all_allies) // Couldn't generate cast from 'Boolean' to 'Void'
            ;
            cs_run_command_script(control_elites_cinematic.elite01, new ScriptMethodReference(soe_bug_out_01));
            cs_run_command_script(control_elites_cinematic.elite02, new ScriptMethodReference(soe_bug_out_02));
            data_mine_set_mission_segment("04b_13_control_room_02");
            game_save();
            wake(new ScriptMethodReference(control_commander_reminder));
            wake(new ScriptMethodReference(control_bug_out));
            await sleep_until(async () => volume_test_objects(vol_control_middle, players()) == true, 30, 1800);
            wake(new ScriptMethodReference(control_flood_spawn));
            await sleep_until(async () => (short)ai_combat_status(control_flood) >= this.ai_combat_status_visible || volume_test_objects(vol_control_middle, players()) == true || volume_test_objects(vol_control_perimeter, players()) == true || volume_test_objects(vol_control_top, ai_actors(control_flood)) == true);
            wake(new ScriptMethodReference(music_04b_05_start));
            await sleep_until(async () => volume_test_objects(vol_control_perimeter, players()) == true || volume_test_objects(vol_control_top, ai_actors(control_flood)) == true);
            device_set_position(elev_control_up.Entity, 0F);
            ai_place(control_sentinels_wave_03.Squad, 3);
            await sleep_until(async () => volume_test_objects(vol_control_return, players()) == true);
            wake(new ScriptMethodReference(music_04b_04_stop));
            objects_predict(cableroom.Entity);
        }

        [ScriptMethod(253, Lifecycle.Dormant)]
        public async Task strain()
        {
            await sleep_until(async () =>
            {
                begin_random(async () => effect_new(this.stress, croom01), 
                    async () => await sleep((short)random_range(5, 30)), 
                    async () => effect_new(this.stress, croom02), 
                    async () => await sleep((short)random_range(5, 30)), 
                    async () => effect_new(this.stress, croom03), 
                    async () => await sleep((short)random_range(5, 30)), 
                    async () => effect_new(this.stress, croom04), 
                    async () => await sleep((short)random_range(5, 30)), 
                    async () => effect_new(this.stress, croom05), 
                    async () => await sleep((short)random_range(5, 30)), 
                    async () => effect_new(this.stress, croom06), 
                    async () => await sleep((short)random_range(5, 30)), 
                    async () => effect_new(this.stress, croom07), 
                    async () => await sleep((short)random_range(5, 30)), 
                    async () => effect_new(this.stress, croom08), 
                    async () => await sleep((short)random_range(5, 30)), 
                    async () => effect_new(this.stress, croom09), 
                    async () => await sleep((short)random_range(5, 30)), 
                    async () => effect_new(this.stress, croom10), 
                    async () => await sleep((short)random_range(5, 30)), 
                    async () => effect_new(this.stress, croom11), 
                    async () => await sleep((short)random_range(5, 30)), 
                    async () => effect_new(this.stress, croom12), 
                    async () => await sleep((short)random_range(5, 30)));
                return (short)structure_bsp_index() == 4;
            });
        }

        [ScriptMethod(254, Lifecycle.Dormant)]
        public async Task rip()
        {
            begin_random(async () => effect_new(this.boom, tear01), 
                async () => await sleep((short)random_range(1, 5)), 
                async () => effect_new(this.boom, tear02), 
                async () => await sleep((short)random_range(1, 5)), 
                async () => effect_new(this.boom, tear03), 
                async () => await sleep((short)random_range(1, 5)), 
                async () => effect_new(this.boom, tear04), 
                async () => await sleep((short)random_range(1, 5)), 
                async () => effect_new(this.boom, tear05), 
                async () => await sleep((short)random_range(1, 5)), 
                async () => effect_new(this.boom, tear06), 
                async () => await sleep((short)random_range(1, 5)), 
                async () => effect_new(this.boom, tear07), 
                async () => await sleep((short)random_range(1, 5)), 
                async () => effect_new(this.boom, tear08), 
                async () => await sleep((short)random_range(1, 5)), 
                async () => effect_new(this.boom, tear09), 
                async () => await sleep((short)random_range(1, 5)), 
                async () => effect_new(this.boom, tear10), 
                async () => await sleep((short)random_range(1, 5)), 
                async () => effect_new(this.boom, tear11), 
                async () => await sleep((short)random_range(1, 5)), 
                async () => effect_new(this.boom, tear12), 
                async () => await sleep((short)random_range(1, 5)), 
                async () => effect_new(this.boom, tear13), 
                async () => await sleep((short)random_range(1, 5)), 
                async () => effect_new(this.boom, tear14), 
                async () => await sleep((short)random_range(1, 5)), 
                async () => effect_new(this.boom, tear15), 
                async () => await sleep((short)random_range(1, 5)), 
                async () => effect_new(this.boom, tear16), 
                async () => await sleep((short)random_range(1, 5)), 
                async () => effect_new(this.boom, tear17), 
                async () => await sleep((short)random_range(1, 5)), 
                async () => effect_new(this.boom, tear18), 
                async () => await sleep((short)random_range(1, 5)), 
                async () => effect_new(this.boom, tear19), 
                async () => await sleep((short)random_range(1, 5)));
        }

        [ScriptMethod(255, Lifecycle.CommandScript)]
        public async Task try_to_fix()
        {
            cs_ignore_obstacles(true);
            cs_approach(croom_center.Entity, 4F, 20F, 20F);
            unit_add_equipment(unit(ai_get_object(this.ai_current_actor)), swap, true, true);
            cs_shoot(true, croom_center.Entity);
        }

        [ScriptMethod(256, Lifecycle.Dormant)]
        public async Task grav_test()
        {
            this.gravity = 0F;
            physics_set_gravity(this.gravity);
            await sleep_until(async () =>
            {
                physics_set_gravity(this.gravity);
                this.gravity = this.gravity + 0.1F;
                return this.gravity > 0.9F;
            });
            this.gravity = 1F;
            physics_set_gravity(this.gravity);
        }

        [ScriptMethod(257, Lifecycle.Static)]
        public async Task cam_shake()
        {
            player_effect_set_max_rotation(0F, 2F, 2F);
            player_effect_start(0.5F, 0F);
            player_effect_stop(1.5F);
        }

        [ScriptMethod(258, Lifecycle.Static)]
        public async Task cam_roll()
        {
            player_effect_set_max_rotation(0.2F, 0.2F, 0.2F);
            player_effect_start(0.1F, 1F);
        }

        [ScriptMethod(259, Lifecycle.Dormant)]
        public async Task cam_shake_cont()
        {
            player_effect_set_max_rotation(0F, 2F, 2F);
            player_effect_start(0.5F, 0F);
            await sleep_until(async () => volume_test_objects(vol_going_down, players()) == true);
            player_effect_start(0.45F, 0F);
            await sleep(60);
            player_effect_start(0.4F, 0F);
            await sleep(60);
            player_effect_start(0.35F, 0F);
            await sleep(60);
            player_effect_start(0.3F, 0F);
            await sleep(60);
            player_effect_start(0.25F, 0F);
            await sleep(60);
            player_effect_start(0.2F, 0F);
            await sleep(60);
            player_effect_start(0.15F, 0F);
            await sleep(60);
            player_effect_start(0.1F, 0F);
            await sleep(60);
            player_effect_start(0.05F, 0F);
        }

        [ScriptMethod(260, Lifecycle.Dormant)]
        public async Task cable_invulnerable()
        {
            await sleep_until(async () => this.cables_cuttable == false, 1);
            object_cannot_take_damage(real_cable_a.Entity);
            object_cannot_take_damage(real_cable_b.Entity);
            object_cannot_take_damage(real_cable_c.Entity);
            await sleep_until(async () => device_get_position(cableroom.Entity) == 1F);
            ai_dialogue_enable(false);
            await sleep(60);
            print("spec-ops commander: 'that's one! by the prophets! look at the station list!'");
            await sleep(ai_play_line_on_object(default(IGameObject), "1380"));
            await sleep(30);
            ai_dialogue_enable(true);
            await sleep_until(async () => this.cables_cuttable == true && device_get_position(cableroom.Entity) == 1F, 1);
            object_can_take_damage(real_cable_a.Entity);
            object_can_take_damage(real_cable_b.Entity);
            object_can_take_damage(real_cable_c.Entity);
            await sleep(5);
            await sleep_until(async () => this.cables_cuttable == false, 1);
            object_cannot_take_damage(real_cable_a.Entity);
            object_cannot_take_damage(real_cable_b.Entity);
            object_cannot_take_damage(real_cable_c.Entity);
            await sleep_until(async () => device_get_position(cableroom.Entity) == 1F);
            ai_dialogue_enable(false);
            await sleep(60);
            print("spec-ops commander: 'one final cable arbiter�'");
            await sleep(ai_play_line_on_object(default(IGameObject), "1400"));
            await sleep(30);
            ai_dialogue_enable(true);
            await sleep(30);
            wake(new ScriptMethodReference(music_04b_06_start));
            await sleep_until(async () => this.cables_cuttable == true && device_get_position(cableroom.Entity) == 1F, 1);
            object_can_take_damage(real_cable_a.Entity);
            object_can_take_damage(real_cable_b.Entity);
            object_can_take_damage(real_cable_c.Entity);
        }

        [ScriptMethod(261, Lifecycle.Dormant)]
        public async Task cableroom_suck_killer()
        {
            await sleep_until(async () =>
            {
                object_destroy(list_get(volume_return_objects(vol_cableroom_suck_kill), 0));
                await sleep(5);
                unit_kill(unit(list_get(volume_return_objects_by_type(vol_cableroom_suck_kill, 1), 0)));
                await sleep(5);
                return this.in_cable_room == false;
            }, 5);
        }

        [ScriptMethod(262, Lifecycle.Dormant)]
        public async Task cableroom_junk_spawn()
        {
            await sleep_until(async () =>
            {
                begin_random(async () => object_create_anew(croom_junk_01), 
                    async () => await sleep((short)random_range(20, 60)), 
                    async () => object_create_anew(croom_junk_02), 
                    async () => await sleep((short)random_range(20, 60)), 
                    async () => object_create_anew(croom_junk_03), 
                    async () => await sleep((short)random_range(20, 60)), 
                    async () => object_create_anew(croom_junk_04), 
                    async () => await sleep((short)random_range(20, 60)), 
                    async () => object_create_anew(croom_junk_05), 
                    async () => await sleep((short)random_range(20, 60)), 
                    async () => object_create_anew(croom_junk_06), 
                    async () => await sleep((short)random_range(20, 60)), 
                    async () => object_create_anew(croom_junk_07), 
                    async () => await sleep((short)random_range(20, 60)), 
                    async () => object_create_anew(croom_junk_08), 
                    async () => await sleep((short)random_range(20, 60)), 
                    async () => object_create_anew(croom_junk_09), 
                    async () => await sleep((short)random_range(20, 60)), 
                    async () => object_create_anew(croom_junk_10), 
                    async () => await sleep((short)random_range(20, 60)), 
                    async () => object_create_anew(croom_junk_11), 
                    async () => await sleep((short)random_range(20, 60)), 
                    async () => object_create_anew(croom_junk_12), 
                    async () => await sleep((short)random_range(20, 60)), 
                    async () => object_create_anew(croom_junk_13), 
                    async () => await sleep((short)random_range(20, 60)), 
                    async () => object_create_anew(croom_junk_14), 
                    async () => await sleep((short)random_range(20, 60)), 
                    async () => object_create_anew(croom_junk_15), 
                    async () => await sleep((short)random_range(20, 60)), 
                    async () => object_create_anew(croom_junk_16), 
                    async () => await sleep((short)random_range(20, 60)), 
                    async () => object_create_anew(croom_junk_17), 
                    async () => await sleep((short)random_range(20, 60)));
                return this.in_cable_room == false;
            });
        }

        [ScriptMethod(263, Lifecycle.Dormant)]
        public async Task cable_nav_a()
        {
            activate_team_nav_point_object(_default, player, cable_target_a.Entity, 0F);
            await sleep_until(async () => object_get_health(real_cable_a.Entity) <= 0F);
            deactivate_team_nav_point_object(player, cable_target_a.Entity);
        }

        [ScriptMethod(264, Lifecycle.Dormant)]
        public async Task cable_nav_b()
        {
            activate_team_nav_point_object(_default, player, cable_target_b.Entity, 0F);
            await sleep_until(async () => object_get_health(real_cable_b.Entity) <= 0F);
            deactivate_team_nav_point_object(player, cable_target_b.Entity);
        }

        [ScriptMethod(265, Lifecycle.Dormant)]
        public async Task cable_nav_c()
        {
            activate_team_nav_point_object(_default, player, cable_target_c.Entity, 0F);
            await sleep_until(async () => object_get_health(real_cable_c.Entity) <= 0F);
            deactivate_team_nav_point_object(player, cable_target_c.Entity);
        }

        [ScriptMethod(266, Lifecycle.Dormant)]
        public async Task cableroom_commander_reminder()
        {
            await sleep_until(async () => object_get_health(real_cable_a.Entity) <= 0F || object_get_health(real_cable_b.Entity) <= 0F || object_get_health(real_cable_c.Entity) <= 0F, 30, 3600);
            if (object_get_health(real_cable_a.Entity) > 0F && object_get_health(real_cable_b.Entity) > 0F && object_get_health(real_cable_c.Entity) > 0F)
            {
                ai_dialogue_enable(false);
                await sleep(60);
                print("spec-ops commander: 'sever the cable at the points where it connect to the structure!'");
                await sleep(ai_play_line_on_object(default(IGameObject), "1370"));
                await sleep(30);
                wake(new ScriptMethodReference(cable_nav_a));
                wake(new ScriptMethodReference(cable_nav_b));
                wake(new ScriptMethodReference(cable_nav_c));
                await sleep(30);
                ai_dialogue_enable(true);
            }
        }

        [ScriptMethod(267, Lifecycle.CommandScript)]
        public async Task cable_look()
        {
            cs_face_object(true, cableroom.Entity);
            await sleep_until(async () => this.plummeting == true);
        }

        [ScriptMethod(268, Lifecycle.Dormant)]
        public async Task cable_a_health()
        {
            await sleep_until(async () => object_get_health(real_cable_a.Entity) <= 0F, 1);
            this.cables_cuttable = false;
            this.cable_var = (short)(this.cable_var + 1);
            object_create_anew(cable_nub_a);
            objects_attach(cableroom.Entity, "rot_a", cable_nub_a.Entity, "cable_destroyed");
            if (this.cable_var == 1)
            {
                await this.cam_shake();
                device_set_position(real_cable_a.Entity, 1F);
                sound_impulse_start(GetTag<SoundTag>("sound\\ambience\\alphagasgiant\\cable_snaps\\cable_snap_one", 4231600620U), default(IGameObject), 1F);
                sound_looping_start(GetTag<LoopingSoundTag>("sound_remastered\\visual_effects\\alphagas_cablelist\\alphacable_swtnr_01_quad", 4231731694U), default(IGameObject), 1F);
                device_set_position_track(cableroom.Entity, "cable_room_rot_5_bc", 0F);
                device_animate_position(cableroom.Entity, 1F, 10F, 1F, 4F, false);
                this.croom_flood_total = (short)ai_nonswarm_count(cable_flood);
                this.croom_sen_total = (short)ai_living_count(cable_sentinels);
                game_save();
            }

            if (this.cable_var == 2)
            {
                await this.cam_shake();
                device_set_position(real_cable_a.Entity, 1F);
                sound_impulse_start(GetTag<SoundTag>("sound\\ambience\\alphagasgiant\\cable_snaps\\cable_snap_one", 4231600620U), default(IGameObject), 1F);
                sound_looping_start(GetTag<LoopingSoundTag>("sound_remastered\\visual_effects\\alphagas_cablelist\\alphacable_swtnr_02_quad", 4231928305U), default(IGameObject), 1F);
                if (object_get_health(real_cable_b.Entity) <= 0F)
                {
                    device_set_position_track(cableroom.Entity, "cable_room_rot_ac2c", 0F);
                    device_animate_position(cableroom.Entity, 1F, 10F, 1F, 4F, false);
                    this.croom_flood_total = (short)ai_nonswarm_count(cable_flood);
                    this.croom_sen_total = (short)ai_living_count(cable_sentinels);
                }

                if (object_get_health(real_cable_c.Entity) <= 0F)
                {
                    device_set_position_track(cableroom.Entity, "cable_room_rot_ab2b", 0F);
                    device_animate_position(cableroom.Entity, 1F, 10F, 1F, 4F, false);
                    this.croom_flood_total = (short)ai_nonswarm_count(cable_flood);
                    this.croom_sen_total = (short)ai_living_count(cable_sentinels);
                }

                game_save();
            }

            if (this.cable_var == 3)
            {
                await this.cam_shake();
                device_set_position(real_cable_a.Entity, 1F);
                sound_impulse_start(GetTag<SoundTag>("sound\\ambience\\alphagasgiant\\cable_snaps\\cable_snap_two", 4232124916U), default(IGameObject), 1F);
                sound_looping_start(GetTag<LoopingSoundTag>("sound_remastered\\visual_effects\\alphagas_cablelist\\alphacable_swtnr_03_quad", 4232255990U), default(IGameObject), 1F);
                device_set_position_track(cableroom.Entity, "cable_room_rot_a_back", 0F);
                device_animate_position(cableroom.Entity, 1F, 2F, 0F, 0.5F, false);
                ai_set_orders(cable_sentinels, cable_room_sentinels_end);
                ai_set_blind(cable_sentinels, true);
                ai_set_blind(cable_flood, true);
                cs_run_command_script(cable_flood, new ScriptMethodReference(cable_look));
                wake(new ScriptMethodReference(music_04b_07_start));
                wake(new ScriptMethodReference(strain));
                await sleep(400);
                object_type_predict_high(GetTag<BaseTag>("scenarios\\objects\\solo\\alphagasgiant\\cable_room\\cable_room", 4113830655U));
                object_type_predict_high(GetTag<BaseTag>("scenarios\\objects\\solo\\alphagasgiant\\cable_room_top\\cable_room_top", 4119139152U));
                await sleep(20);
                objects_detach(cableroom.Entity, real_cable_a.Entity);
                objects_detach(cableroom.Entity, real_cable_b.Entity);
                objects_detach(cableroom.Entity, real_cable_c.Entity);
                objects_detach(cableroom.Entity, elev_control_up.Entity);
                objects_detach(cableroom.Entity, control_up_switch_02.Entity);
                objects_detach(cableroom.Entity, cable_nub_a.Entity);
                objects_detach(cableroom.Entity, cable_nub_b.Entity);
                objects_detach(cableroom.Entity, cable_nub_c.Entity);
                object_destroy(cableroom.Entity);
                switch_bsp(4);
                wake(new ScriptMethodReference(cam_shake_cont));
                physics_disable_character_ground_adhesion_forces(1F);
                objects_attach(cableroom_top.Entity, "rot_a", real_cable_a.Entity, "");
                objects_attach(cableroom_top.Entity, "rot_b", real_cable_b.Entity, "");
                objects_attach(cableroom_top.Entity, "rot_c", real_cable_c.Entity, "");
                objects_attach(cableroom2.Entity, "elevator", elev_control_up.Entity, "elev_top");
                objects_attach(cableroom2.Entity, "switch", control_up_switch_02.Entity, "");
                objects_attach(cableroom2.Entity, "anim", cable_nub_a.Entity, "torn02");
                objects_attach(cableroom2.Entity, "anim", cable_nub_b.Entity, "torn03");
                objects_attach(cableroom2.Entity, "anim", cable_nub_c.Entity, "");
                device_set_position_track(cableroom2.Entity, "cable_room_drop", 0F);
                device_animate_position(cableroom2.Entity, 1F, 1F, 0F, 0.5F, false);
                device_set_position(cableroom_top.Entity, 1F);
                wake(new ScriptMethodReference(cableroom_suck_killer));
                wake(new ScriptMethodReference(cableroom_junk_spawn));
                object_create(suction);
                wake(new ScriptMethodReference(grav_test));
                this.plummeting = true;
                await cache_block_for_one_frame();
                await sleep(150);
                object_destroy(cableroom_top.Entity);
            }

            await sleep(30);
            this.cables_cuttable = true;
        }

        [ScriptMethod(269, Lifecycle.Dormant)]
        public async Task cable_b_health()
        {
            await sleep_until(async () => object_get_health(real_cable_b.Entity) <= 0F, 1);
            this.cables_cuttable = false;
            this.cable_var = (short)(this.cable_var + 1);
            object_create_anew(cable_nub_b);
            objects_attach(cableroom.Entity, "rot_b", cable_nub_b.Entity, "cable_destroyed");
            if (this.cable_var == 1)
            {
                await this.cam_shake();
                device_set_position(real_cable_b.Entity, 1F);
                sound_impulse_start(GetTag<SoundTag>("sound\\ambience\\alphagasgiant\\cable_snaps\\cable_snap_one", 4231600620U), default(IGameObject), 1F);
                sound_looping_start(GetTag<LoopingSoundTag>("sound_remastered\\visual_effects\\alphagas_cablelist\\alphacable_swtnr_01_quad", 4231731694U), default(IGameObject), 1F);
                device_set_position_track(cableroom.Entity, "cable_room_rot_5_ac", 0F);
                device_animate_position(cableroom.Entity, 1F, 10F, 1F, 4F, false);
                this.croom_flood_total = (short)ai_nonswarm_count(cable_flood);
                this.croom_sen_total = (short)ai_living_count(cable_sentinels);
                game_save();
            }

            if (this.cable_var == 2)
            {
                await this.cam_shake();
                device_set_position(real_cable_b.Entity, 1F);
                sound_impulse_start(GetTag<SoundTag>("sound\\ambience\\alphagasgiant\\cable_snaps\\cable_snap_one", 4231600620U), default(IGameObject), 1F);
                sound_looping_start(GetTag<LoopingSoundTag>("sound_remastered\\visual_effects\\alphagas_cablelist\\alphacable_swtnr_02_quad", 4231928305U), default(IGameObject), 1F);
                if (object_get_health(real_cable_a.Entity) <= 0F)
                {
                    device_set_position_track(cableroom.Entity, "cable_room_rot_bc2c", 0F);
                    device_animate_position(cableroom.Entity, 1F, 10F, 1F, 4F, false);
                    this.croom_flood_total = (short)ai_nonswarm_count(cable_flood);
                    this.croom_sen_total = (short)ai_living_count(cable_sentinels);
                }

                if (object_get_health(real_cable_c.Entity) <= 0F)
                {
                    device_set_position_track(cableroom.Entity, "cable_room_rot_ab2a", 0F);
                    device_animate_position(cableroom.Entity, 1F, 10F, 1F, 4F, false);
                    this.croom_flood_total = (short)ai_nonswarm_count(cable_flood);
                    this.croom_sen_total = (short)ai_living_count(cable_sentinels);
                }

                game_save();
            }

            if (this.cable_var == 3)
            {
                await this.cam_shake();
                device_set_position(real_cable_b.Entity, 1F);
                sound_impulse_start(GetTag<SoundTag>("sound\\ambience\\alphagasgiant\\cable_snaps\\cable_snap_two", 4232124916U), default(IGameObject), 1F);
                sound_looping_start(GetTag<LoopingSoundTag>("sound_remastered\\visual_effects\\alphagas_cablelist\\alphacable_swtnr_03_quad", 4232255990U), default(IGameObject), 1F);
                device_set_position_track(cableroom.Entity, "cable_room_rot_b_back", 0F);
                device_animate_position(cableroom.Entity, 1F, 2F, 0F, 0.5F, false);
                cs_run_command_script(cable_room_sentinels.Squad, new ScriptMethodReference(try_to_fix));
                ai_set_orders(cable_sentinels, cable_room_sentinels_end);
                ai_set_blind(cable_sentinels, true);
                ai_set_blind(cable_flood, true);
                cs_run_command_script(cable_flood, new ScriptMethodReference(cable_look));
                wake(new ScriptMethodReference(music_04b_07_start));
                wake(new ScriptMethodReference(strain));
                await sleep(400);
                object_type_predict_high(GetTag<BaseTag>("scenarios\\objects\\solo\\alphagasgiant\\cable_room\\cable_room", 4113830655U));
                object_type_predict_high(GetTag<BaseTag>("scenarios\\objects\\solo\\alphagasgiant\\cable_room_top\\cable_room_top", 4119139152U));
                await sleep(20);
                objects_detach(cableroom.Entity, real_cable_a.Entity);
                objects_detach(cableroom.Entity, real_cable_b.Entity);
                objects_detach(cableroom.Entity, real_cable_c.Entity);
                objects_detach(cableroom.Entity, elev_control_up.Entity);
                objects_detach(cableroom.Entity, control_up_switch_02.Entity);
                objects_detach(cableroom.Entity, cable_nub_a.Entity);
                objects_detach(cableroom.Entity, cable_nub_b.Entity);
                objects_detach(cableroom.Entity, cable_nub_c.Entity);
                object_destroy(cableroom.Entity);
                switch_bsp(4);
                wake(new ScriptMethodReference(cam_shake_cont));
                physics_disable_character_ground_adhesion_forces(1F);
                objects_attach(cableroom_top.Entity, "rot_a", real_cable_a.Entity, "");
                objects_attach(cableroom_top.Entity, "rot_b", real_cable_b.Entity, "");
                objects_attach(cableroom_top.Entity, "rot_c", real_cable_c.Entity, "");
                objects_attach(cableroom2.Entity, "elevator", elev_control_up.Entity, "elev_top");
                objects_attach(cableroom2.Entity, "switch", control_up_switch_02.Entity, "");
                objects_attach(cableroom2.Entity, "anim", cable_nub_a.Entity, "torn02");
                objects_attach(cableroom2.Entity, "anim", cable_nub_b.Entity, "torn03");
                objects_attach(cableroom2.Entity, "anim", cable_nub_c.Entity, "");
                device_set_position_track(cableroom2.Entity, "cable_room_drop", 0F);
                device_animate_position(cableroom2.Entity, 1F, 1F, 0F, 0.5F, false);
                device_set_position(cableroom_top.Entity, 1F);
                wake(new ScriptMethodReference(cableroom_suck_killer));
                wake(new ScriptMethodReference(cableroom_junk_spawn));
                object_create(suction);
                wake(new ScriptMethodReference(grav_test));
                this.plummeting = true;
                await cache_block_for_one_frame();
                await sleep(150);
                object_destroy(cableroom_top.Entity);
            }

            await sleep(30);
            this.cables_cuttable = true;
        }

        [ScriptMethod(270, Lifecycle.Dormant)]
        public async Task cable_c_health()
        {
            await sleep_until(async () => object_get_health(real_cable_c.Entity) <= 0F, 1);
            this.cables_cuttable = false;
            this.cable_var = (short)(this.cable_var + 1);
            object_create_anew(cable_nub_c);
            objects_attach(cableroom.Entity, "rot_c", cable_nub_c.Entity, "cable_destroyed");
            if (this.cable_var == 1)
            {
                await this.cam_shake();
                device_set_position(real_cable_c.Entity, 1F);
                sound_impulse_start(GetTag<SoundTag>("sound\\ambience\\alphagasgiant\\cable_snaps\\cable_snap_one", 4231600620U), default(IGameObject), 1F);
                sound_looping_start(GetTag<LoopingSoundTag>("sound_remastered\\visual_effects\\alphagas_cablelist\\alphacable_swtnr_01_quad", 4231731694U), default(IGameObject), 1F);
                device_set_position_track(cableroom.Entity, "cable_room_rot_5_ab", 0F);
                device_animate_position(cableroom.Entity, 1F, 10F, 1F, 4F, false);
                this.croom_flood_total = (short)ai_nonswarm_count(cable_flood);
                this.croom_sen_total = (short)ai_living_count(cable_sentinels);
                game_save();
            }

            if (this.cable_var == 2)
            {
                await this.cam_shake();
                device_set_position(real_cable_c.Entity, 1F);
                sound_impulse_start(GetTag<SoundTag>("sound\\ambience\\alphagasgiant\\cable_snaps\\cable_snap_one", 4231600620U), default(IGameObject), 1F);
                sound_looping_start(GetTag<LoopingSoundTag>("sound_remastered\\visual_effects\\alphagas_cablelist\\alphacable_swtnr_02_quad", 4231928305U), default(IGameObject), 1F);
                if (object_get_health(real_cable_a.Entity) <= 0F)
                {
                    device_set_position_track(cableroom.Entity, "cable_room_rot_bc2b", 0F);
                    device_animate_position(cableroom.Entity, 1F, 10F, 1F, 4F, false);
                    this.croom_flood_total = (short)ai_nonswarm_count(cable_flood);
                    this.croom_sen_total = (short)ai_living_count(cable_sentinels);
                }

                if (object_get_health(real_cable_b.Entity) <= 0F)
                {
                    device_set_position_track(cableroom.Entity, "cable_room_rot_ac2a", 0F);
                    device_animate_position(cableroom.Entity, 1F, 10F, 1F, 4F, false);
                    this.croom_flood_total = (short)ai_nonswarm_count(cable_flood);
                    this.croom_sen_total = (short)ai_living_count(cable_sentinels);
                }

                game_save();
            }

            if (this.cable_var == 3)
            {
                await this.cam_shake();
                device_set_position(real_cable_c.Entity, 1F);
                sound_impulse_start(GetTag<SoundTag>("sound\\ambience\\alphagasgiant\\cable_snaps\\cable_snap_two", 4232124916U), default(IGameObject), 1F);
                sound_looping_start(GetTag<LoopingSoundTag>("sound_remastered\\visual_effects\\alphagas_cablelist\\alphacable_swtnr_03_quad", 4232255990U), default(IGameObject), 1F);
                device_set_position_track(cableroom.Entity, "cable_room_rot_c_back", 0F);
                device_animate_position(cableroom.Entity, 1F, 2F, 0F, 0.5F, false);
                cs_run_command_script(cable_room_sentinels.Squad, new ScriptMethodReference(try_to_fix));
                ai_set_orders(cable_sentinels, cable_room_sentinels_end);
                ai_set_blind(cable_sentinels, true);
                ai_set_blind(cable_flood, true);
                cs_run_command_script(cable_flood, new ScriptMethodReference(cable_look));
                wake(new ScriptMethodReference(music_04b_07_start));
                wake(new ScriptMethodReference(strain));
                await sleep(400);
                object_type_predict_high(GetTag<BaseTag>("scenarios\\objects\\solo\\alphagasgiant\\cable_room\\cable_room", 4113830655U));
                object_type_predict_high(GetTag<BaseTag>("scenarios\\objects\\solo\\alphagasgiant\\cable_room_top\\cable_room_top", 4119139152U));
                await sleep(20);
                objects_detach(cableroom.Entity, real_cable_a.Entity);
                objects_detach(cableroom.Entity, real_cable_b.Entity);
                objects_detach(cableroom.Entity, real_cable_c.Entity);
                objects_detach(cableroom.Entity, elev_control_up.Entity);
                objects_detach(cableroom.Entity, control_up_switch_02.Entity);
                objects_detach(cableroom.Entity, cable_nub_a.Entity);
                objects_detach(cableroom.Entity, cable_nub_b.Entity);
                objects_detach(cableroom.Entity, cable_nub_c.Entity);
                object_destroy(cableroom.Entity);
                switch_bsp(4);
                wake(new ScriptMethodReference(cam_shake_cont));
                physics_disable_character_ground_adhesion_forces(1F);
                objects_attach(cableroom_top.Entity, "rot_a", real_cable_a.Entity, "");
                objects_attach(cableroom_top.Entity, "rot_b", real_cable_b.Entity, "");
                objects_attach(cableroom_top.Entity, "rot_c", real_cable_c.Entity, "");
                objects_attach(cableroom2.Entity, "elevator", elev_control_up.Entity, "elev_top");
                objects_attach(cableroom2.Entity, "switch", control_up_switch_02.Entity, "");
                objects_attach(cableroom2.Entity, "anim", cable_nub_a.Entity, "torn02");
                objects_attach(cableroom2.Entity, "anim", cable_nub_b.Entity, "torn03");
                objects_attach(cableroom2.Entity, "anim", cable_nub_c.Entity, "");
                device_set_position_track(cableroom2.Entity, "cable_room_drop", 0F);
                device_animate_position(cableroom2.Entity, 1F, 1F, 0F, 0.5F, false);
                device_set_position(cableroom_top.Entity, 1F);
                wake(new ScriptMethodReference(cableroom_suck_killer));
                wake(new ScriptMethodReference(cableroom_junk_spawn));
                object_create(suction);
                wake(new ScriptMethodReference(grav_test));
                this.plummeting = true;
                await cache_block_for_one_frame();
                await sleep(150);
                object_destroy(cableroom_top.Entity);
            }

            await sleep(30);
            this.cables_cuttable = true;
        }

        [ScriptMethod(271, Lifecycle.Dormant)]
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

            await sleep_until(async () =>
            {
                await sleep_until(async () => this.croom_flood_total < this.croom_flood_desired && (short)ai_nonswarm_count(cable_flood) < (short)(this.croom_flood_desired / 2) || this.plummeting == true || this.cable_var > 0);
                if (this.plummeting == false && this.cable_var < 1)
                {
                    ai_place(cable_room_combatforms.Squad, 1);
                    this.croom_flood_total = (short)(this.croom_flood_total + 1);
                }

                return this.plummeting == true || this.cable_var > 0 || this.croom_flood_total >= this.croom_flood_desired;
            });
            await sleep_until(async () => this.cable_var > 0 || this.plummeting == true);
            if (this.plummeting == true)
            {
                sleep_forever();
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

            await sleep_until(async () =>
            {
                await sleep_until(async () => this.croom_flood_total < this.croom_flood_desired && (short)ai_nonswarm_count(cable_flood) < (short)(this.croom_flood_desired / 2) || this.plummeting == true || this.cable_var > 1);
                if (this.plummeting == false && this.cable_var < 2)
                {
                    ai_place(cable_room_combatforms.Squad, 1);
                    this.croom_flood_total = (short)(this.croom_flood_total + 1);
                }

                return this.plummeting == true || this.cable_var > 1 || this.croom_flood_total >= this.croom_flood_desired;
            });
            await sleep_until(async () => this.cable_var > 1 || this.plummeting == true);
            if (this.plummeting == true)
            {
                sleep_forever();
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

            await sleep_until(async () =>
            {
                await sleep_until(async () => this.croom_flood_total < this.croom_flood_desired && (short)ai_nonswarm_count(cable_flood) < (short)(this.croom_flood_desired / 2) || this.plummeting == true || this.cable_var > 2);
                if (this.plummeting == false && this.cable_var < 3)
                {
                    ai_place(cable_room_combatforms.Squad, 1);
                    this.croom_flood_total = (short)(this.croom_flood_total + 1);
                }

                return this.plummeting == true || this.cable_var > 2 || this.croom_flood_total >= this.croom_flood_desired;
            });
        }

        [ScriptMethod(272, Lifecycle.Dormant)]
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

            await sleep_until(async () =>
            {
                await sleep_until(async () => (short)ai_living_count(cable_sentinels) < (short)(this.croom_sen_desired / 2) && this.croom_sen_total < this.croom_sen_desired || this.plummeting == true || this.cable_var > 0);
                if (this.plummeting == false && this.cable_var < 1)
                {
                    ai_place(cable_room_sentinels.Squad, 1);
                    this.croom_sen_total = (short)(this.croom_sen_total + 1);
                }

                return this.plummeting == true || this.cable_var > 0 || this.croom_sen_total >= this.croom_sen_desired;
            });
            await sleep_until(async () => this.cable_var > 0 || this.plummeting == true);
            if (this.plummeting == true)
            {
                sleep_forever();
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

            await sleep_until(async () =>
            {
                await sleep_until(async () => (short)ai_living_count(cable_sentinels) < (short)(this.croom_sen_desired / 2) && this.croom_sen_total < this.croom_sen_desired || this.plummeting == true || this.cable_var > 1);
                if (this.plummeting == false && this.cable_var < 2)
                {
                    ai_place(cable_room_sentinels.Squad, 1);
                    this.croom_sen_total = (short)(this.croom_sen_total + 1);
                }

                return this.plummeting == true || this.cable_var > 1 || this.croom_sen_total >= this.croom_sen_desired;
            });
            await sleep_until(async () => this.cable_var > 1 || this.plummeting == true);
            if (this.plummeting == true)
            {
                sleep_forever();
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

            await sleep_until(async () =>
            {
                await sleep_until(async () => (short)ai_living_count(cable_sentinels) < (short)(this.croom_sen_desired / 2) && this.croom_sen_total < this.croom_sen_desired || this.plummeting == true || this.cable_var > 2);
                if (this.plummeting == false && this.cable_var < 3)
                {
                    ai_place(cable_room_sentinels.Squad, 1);
                    this.croom_sen_total = (short)(this.croom_sen_total + 1);
                }

                return this.plummeting == true || this.cable_var > 2 || this.croom_sen_total >= this.croom_sen_desired;
            });
        }

        [ScriptMethod(273, Lifecycle.Dormant)]
        public async Task croom_exit()
        {
            await sleep_until(async () => volume_test_objects(vol_going_down, players()) == true, 1);
            sleep_forever(new ScriptMethodReference(cableroom_killer));
            device_set_power(control_up_switch_01.Entity, 0F);
            device_set_power(control_up_switch_02.Entity, 0F);
            device_set_position(elev_control_up.Entity, 0.04195F);
            this.in_cable_room = false;
        }

        [ScriptMethod(274, Lifecycle.Dormant)]
        public async Task cable_room_start()
        {
            ai_disposable(control_flood, true);
            ai_disposable(control_sentinels, true);
            ai_erase_all();
            sleep_forever(new ScriptMethodReference(wind));
            data_mine_set_mission_segment("04b_14_cable_room");
            object_cannot_take_damage(await this.player0());
            object_cannot_take_damage(await this.player1());
            objects_attach(cableroom.Entity, "rot_a", real_cable_a.Entity, "");
            objects_attach(cableroom.Entity, "rot_b", real_cable_b.Entity, "");
            objects_attach(cableroom.Entity, "rot_c", real_cable_c.Entity, "");
            objects_attach(real_cable_a.Entity, "cut_here", cable_target_a.Entity, "");
            objects_attach(real_cable_b.Entity, "cut_here", cable_target_b.Entity, "");
            objects_attach(real_cable_c.Entity, "cut_here", cable_target_c.Entity, "");
            objects_attach(cableroom.Entity, "switch", control_up_switch_02.Entity, "");
            cinematic_lighting_set_primary_light(28F, 118F, 0.419608F, 0.313726F, 0.247059F);
            cinematic_lighting_set_secondary_light(-26F, 312F, 0.113725F, 0.0941177F, 0.0862745F);
            cinematic_lighting_set_ambient_light(0.0470588F, 0.0509804F, 0.054902F);
            object_uses_cinematic_lighting(real_cable_a.Entity, true);
            object_uses_cinematic_lighting(real_cable_b.Entity, true);
            object_uses_cinematic_lighting(real_cable_c.Entity, true);
            wake(new ScriptMethodReference(cable_a_health));
            wake(new ScriptMethodReference(cable_b_health));
            wake(new ScriptMethodReference(cable_c_health));
            wake(new ScriptMethodReference(cable_invulnerable));
            wake(new ScriptMethodReference(cable_flood_spawner));
            wake(new ScriptMethodReference(cable_sentinel_spawner));
            device_set_power(control_up_switch_02.Entity, 0F);
            this.in_cable_room = true;
            wake(new ScriptMethodReference(_04b_title1));
            ai_place(cableroom_sentinels_init.Squad, 3);
            ai_place(cableroom_flood_init.Squad, 6);
            await sleep_until(async () => device_get_position(elev_control_up.Entity) > 0.95F);
            object_can_take_damage(await this.player0());
            object_can_take_damage(await this.player1());
            wake(new ScriptMethodReference(cableroom_killer));
            wake(new ScriptMethodReference(cableroom_junk_killer));
            game_save_immediate();
            await sleep_until(async () => device_get_position(elev_control_up.Entity) == 1F);
            objects_attach(cableroom.Entity, "elevator", elev_control_up.Entity, "elev_top");
            ai_dialogue_enable(false);
            await sleep(60);
            print("spec-ops commander: 'all my phantoms are in the air, arbiter. go ahead - cut the cable!'");
            await sleep(ai_play_line_on_object(default(IGameObject), "0170"));
            await sleep(30);
            ai_dialogue_enable(true);
            wake(new ScriptMethodReference(cableroom_commander_reminder));
            await sleep_until(async () => this.plummeting == true);
            wake(new ScriptMethodReference(croom_exit));
            wake(new ScriptMethodReference(objective_cables_clear));
            await sleep(30);
            await sleep_until(async () => device_get_position(cableroom2.Entity) == 1F);
            objects_detach(cableroom2.Entity, elev_control_up.Entity);
            await sleep(2);
            device_set_position(elev_control_up.Entity, 0.99999F);
            await sleep(2);
            device_set_power(control_up_switch_02.Entity, 1F);
            await sleep(90);
            ai_dialogue_enable(false);
            await sleep(60);
            print("spec-ops commander: 'that did it! the station is in free-fall!'");
            await sleep(ai_play_line_on_object(default(IGameObject), "0180"));
            await sleep(30);
            ai_dialogue_enable(true);
            wake(new ScriptMethodReference(objective_dogfight_set));
            game_save();
            ai_set_blind(cable_flood, false);
            ai_set_orders(cable_flood, cable_room_after);
        }

        [ScriptMethod(275, Lifecycle.Dormant)]
        public async Task plummeting_control_commander()
        {
            ai_dialogue_enable(false);
            await sleep(60);
            print("spec-ops commander: 'the heretic leader is on the move! do not let him escape! we'll stay with you as long as we can! '");
            await sleep(ai_play_line_on_object(default(IGameObject), "0190"));
            await sleep(30);
            ai_dialogue_enable(true);
        }

        [ScriptMethod(276, Lifecycle.Dormant)]
        public async Task control_return_flood_spawn()
        {
            await sleep_until(async () =>
            {
                begin_random(async () =>
                {
                    if ((short)ai_nonswarm_count(control_return_flood) < 3 && device_get_position(control_middle_spawnroom.Entity) == 0F && volume_test_objects(vol_control_middle_spawnroom, players()) == false && await this.player_count() > 0)
                    {
                        ai_place(control_return_flood_02.mid01);
                    }
                }, 
                    async () =>
                {
                    if ((short)ai_nonswarm_count(control_return_flood) < 3 && device_get_position(control_middle_spawnroom.Entity) == 0F && volume_test_objects(vol_control_middle_spawnroom, players()) == false && await this.player_count() > 0)
                    {
                        ai_place(control_return_flood_02.mid02);
                    }
                }, 
                    async () =>
                {
                    if ((short)ai_nonswarm_count(control_return_flood) < 3 && device_get_position(control_middle_spawnroom.Entity) == 0F && volume_test_objects(vol_control_middle_spawnroom, players()) == false && await this.player_count() > 0)
                    {
                        ai_place(control_return_flood_02.mid03);
                    }
                }, 
                    async () =>
                {
                    if ((short)ai_nonswarm_count(control_return_flood) < 3 && device_get_position(control_middle_spawnroom.Entity) == 0F && volume_test_objects(vol_control_middle_spawnroom, players()) == false && await this.player_count() > 0)
                    {
                        ai_place(control_return_flood_02.mid04);
                    }
                }, 
                    async () =>
                {
                    if ((short)ai_nonswarm_count(control_return_flood) < 3 && device_get_position(control_middle_spawnroom.Entity) == 0F && volume_test_objects(vol_control_middle_spawnroom, players()) == false && await this.player_count() > 0)
                    {
                        ai_place(control_return_carriers_02.mid01);
                    }
                }, 
                    async () =>
                {
                    if ((short)ai_nonswarm_count(control_return_flood) < 3 && device_get_position(control_middle_spawnroom.Entity) == 0F && volume_test_objects(vol_control_middle_spawnroom, players()) == false && await this.player_count() > 0)
                    {
                        ai_place(control_return_carriers_02.mid02);
                    }
                }, 
                    async () =>
                {
                    if ((short)ai_nonswarm_count(control_return_flood) < 3 && device_get_position(control_peri_spawnroom.Entity) == 0F && volume_test_objects(vol_control_peri_spawnroom, players()) == false && await this.player_count() > 0)
                    {
                        ai_place(control_return_flood_02.peri01);
                    }
                }, 
                    async () =>
                {
                    if ((short)ai_nonswarm_count(control_return_flood) < 3 && device_get_position(control_peri_spawnroom.Entity) == 0F && volume_test_objects(vol_control_peri_spawnroom, players()) == false && await this.player_count() > 0)
                    {
                        ai_place(control_return_flood_02.peri02);
                    }
                }, 
                    async () =>
                {
                    if ((short)ai_nonswarm_count(control_return_flood) < 3 && device_get_position(control_peri_spawnroom.Entity) == 0F && volume_test_objects(vol_control_peri_spawnroom, players()) == false && await this.player_count() > 0)
                    {
                        ai_place(control_return_flood_02.peri03);
                    }
                }, 
                    async () =>
                {
                    if ((short)ai_nonswarm_count(control_return_flood) < 3 && device_get_position(control_peri_spawnroom.Entity) == 0F && volume_test_objects(vol_control_peri_spawnroom, players()) == false && await this.player_count() > 0)
                    {
                        ai_place(control_return_flood_02.peri04);
                    }
                }, 
                    async () =>
                {
                    if ((short)ai_nonswarm_count(control_return_flood) < 3 && device_get_position(control_peri_spawnroom.Entity) == 0F && volume_test_objects(vol_control_peri_spawnroom, players()) == false && await this.player_count() > 0)
                    {
                        ai_place(control_return_carriers_02.peri01);
                    }
                }, 
                    async () =>
                {
                    if ((short)ai_nonswarm_count(control_return_flood) < 3 && device_get_position(control_peri_spawnroom.Entity) == 0F && volume_test_objects(vol_control_peri_spawnroom, players()) == false && await this.player_count() > 0)
                    {
                        ai_place(control_return_carriers_02.peri02);
                    }
                });
                return (short)ai_living_count(control_return_heretics) == 0 || (short)ai_spawn_count(control_return_flood) > 10 || volume_test_objects(vol_control_return_perimeter, players()) == true;
            });
            await sleep_until(async () =>
            {
                begin_random(async () =>
                {
                    if ((short)ai_nonswarm_count(control_return_flood) < 3 && device_get_position(control_peri_spawnroom.Entity) == 0F && volume_test_objects(vol_control_peri_spawnroom, players()) == false && await this.player_count() > 0)
                    {
                        ai_place(control_return_flood_03.peri01);
                    }
                }, 
                    async () =>
                {
                    if ((short)ai_nonswarm_count(control_return_flood) < 3 && device_get_position(control_peri_spawnroom.Entity) == 0F && volume_test_objects(vol_control_peri_spawnroom, players()) == false && await this.player_count() > 0)
                    {
                        ai_place(control_return_flood_03.peri02);
                    }
                }, 
                    async () =>
                {
                    if ((short)ai_nonswarm_count(control_return_flood) < 3 && device_get_position(control_peri_spawnroom.Entity) == 0F && volume_test_objects(vol_control_peri_spawnroom, players()) == false && await this.player_count() > 0)
                    {
                        ai_place(control_return_flood_03.peri03);
                    }
                }, 
                    async () =>
                {
                    if ((short)ai_nonswarm_count(control_return_flood) < 3 && device_get_position(control_peri_spawnroom.Entity) == 0F && volume_test_objects(vol_control_peri_spawnroom, players()) == false && await this.player_count() > 0)
                    {
                        ai_place(control_return_flood_03.peri04);
                    }
                }, 
                    async () =>
                {
                    if ((short)ai_nonswarm_count(control_return_flood) < 3 && device_get_position(control_peri_spawnroom.Entity) == 0F && volume_test_objects(vol_control_peri_spawnroom, players()) == false && await this.player_count() > 0)
                    {
                        ai_place(control_return_carriers_03.peri01);
                    }
                }, 
                    async () =>
                {
                    if ((short)ai_nonswarm_count(control_return_flood) < 3 && device_get_position(control_peri_spawnroom.Entity) == 0F && volume_test_objects(vol_control_peri_spawnroom, players()) == false && await this.player_count() > 0)
                    {
                        ai_place(control_return_carriers_03.peri02);
                    }
                }, 
                    async () =>
                {
                    if ((short)ai_nonswarm_count(control_return_flood) < 3 && device_get_position(control_bottom_spawnroom.Entity) == 0F && volume_test_objects(vol_control_bottom_spawnroom, players()) == false && await this.player_count() > 0)
                    {
                        ai_place(control_return_flood_03.bott01);
                    }
                }, 
                    async () =>
                {
                    if ((short)ai_nonswarm_count(control_return_flood) < 3 && device_get_position(control_bottom_spawnroom.Entity) == 0F && volume_test_objects(vol_control_bottom_spawnroom, players()) == false && await this.player_count() > 0)
                    {
                        ai_place(control_return_flood_03.bott02);
                    }
                }, 
                    async () =>
                {
                    if ((short)ai_nonswarm_count(control_return_flood) < 3 && device_get_position(control_bottom_spawnroom.Entity) == 0F && volume_test_objects(vol_control_bottom_spawnroom, players()) == false && await this.player_count() > 0)
                    {
                        ai_place(control_return_flood_03.bott03);
                    }
                }, 
                    async () =>
                {
                    if ((short)ai_nonswarm_count(control_return_flood) < 3 && device_get_position(control_bottom_spawnroom.Entity) == 0F && volume_test_objects(vol_control_bottom_spawnroom, players()) == false && await this.player_count() > 0)
                    {
                        ai_place(control_return_flood_03.bott04);
                    }
                }, 
                    async () =>
                {
                    if ((short)ai_nonswarm_count(control_return_flood) < 3 && device_get_position(control_bottom_spawnroom.Entity) == 0F && volume_test_objects(vol_control_bottom_spawnroom, players()) == false && await this.player_count() > 0)
                    {
                        ai_place(control_return_carriers_03.bott01);
                    }
                }, 
                    async () =>
                {
                    if ((short)ai_nonswarm_count(control_return_flood) < 3 && device_get_position(control_bottom_spawnroom.Entity) == 0F && volume_test_objects(vol_control_bottom_spawnroom, players()) == false && await this.player_count() > 0)
                    {
                        ai_place(control_return_carriers_03.bott02);
                    }
                });
                return (short)ai_living_count(control_return_heretics) == 0 || (short)ai_spawn_count(control_return_flood) > 10 || volume_test_objects(vol_control_return_middle, players()) == true;
            });
            await sleep_until(async () =>
            {
                begin_random(async () =>
                {
                    if ((short)ai_nonswarm_count(control_return_flood) < 3 && device_get_position(control_bottom_spawnroom.Entity) == 0F && volume_test_objects(vol_control_bottom_spawnroom, players()) == false && await this.player_count() > 0)
                    {
                        ai_place(control_return_flood_04.bott01);
                    }
                }, 
                    async () =>
                {
                    if ((short)ai_nonswarm_count(control_return_flood) < 3 && device_get_position(control_bottom_spawnroom.Entity) == 0F && volume_test_objects(vol_control_bottom_spawnroom, players()) == false && await this.player_count() > 0)
                    {
                        ai_place(control_return_flood_04.bott02);
                    }
                }, 
                    async () =>
                {
                    if ((short)ai_nonswarm_count(control_return_flood) < 3 && device_get_position(control_bottom_spawnroom.Entity) == 0F && volume_test_objects(vol_control_bottom_spawnroom, players()) == false && await this.player_count() > 0)
                    {
                        ai_place(control_return_flood_04.bott03);
                    }
                }, 
                    async () =>
                {
                    if ((short)ai_nonswarm_count(control_return_flood) < 3 && device_get_position(control_bottom_spawnroom.Entity) == 0F && volume_test_objects(vol_control_bottom_spawnroom, players()) == false && await this.player_count() > 0)
                    {
                        ai_place(control_return_flood_04.bott04);
                    }
                }, 
                    async () =>
                {
                    if ((short)ai_nonswarm_count(control_return_flood) < 3 && device_get_position(control_bottom_spawnroom.Entity) == 0F && volume_test_objects(vol_control_bottom_spawnroom, players()) == false && await this.player_count() > 0)
                    {
                        ai_place(control_return_carriers_04.bott01);
                    }
                }, 
                    async () =>
                {
                    if ((short)ai_nonswarm_count(control_return_flood) < 3 && device_get_position(control_bottom_spawnroom.Entity) == 0F && volume_test_objects(vol_control_bottom_spawnroom, players()) == false && await this.player_count() > 0)
                    {
                        ai_place(control_return_carriers_04.bott02);
                    }
                }, 
                    async () =>
                {
                    if ((short)ai_nonswarm_count(control_return_flood) < 3 && device_get_position(control_entry_int.Entity) == 0F && volume_test_objects(vol_control_entry_int, players()) == false && await this.player_count() > 0)
                    {
                        ai_place(control_return_flood_04.entry01);
                    }
                }, 
                    async () =>
                {
                    if ((short)ai_nonswarm_count(control_return_flood) < 3 && device_get_position(control_entry_int.Entity) == 0F && volume_test_objects(vol_control_entry_int, players()) == false && await this.player_count() > 0)
                    {
                        ai_place(control_return_flood_04.entry02);
                    }
                }, 
                    async () =>
                {
                    if ((short)ai_nonswarm_count(control_return_flood) < 3 && device_get_position(control_entry_int.Entity) == 0F && volume_test_objects(vol_control_entry_int, players()) == false && await this.player_count() > 0)
                    {
                        ai_place(control_return_flood_04.entry03);
                    }
                }, 
                    async () =>
                {
                    if ((short)ai_nonswarm_count(control_return_flood) < 3 && device_get_position(control_entry_int.Entity) == 0F && volume_test_objects(vol_control_entry_int, players()) == false && await this.player_count() > 0)
                    {
                        ai_place(control_return_flood_04.entry04);
                    }
                }, 
                    async () =>
                {
                    if ((short)ai_nonswarm_count(control_return_flood) < 3 && device_get_position(control_entry_int.Entity) == 0F && volume_test_objects(vol_control_entry_int, players()) == false && await this.player_count() > 0)
                    {
                        ai_place(control_return_carriers_04.entry01);
                    }
                }, 
                    async () =>
                {
                    if ((short)ai_nonswarm_count(control_return_flood) < 3 && device_get_position(control_entry_int.Entity) == 0F && volume_test_objects(vol_control_entry_int, players()) == false && await this.player_count() > 0)
                    {
                        ai_place(control_return_carriers_04.entry02);
                    }
                });
                return (short)ai_living_count(control_return_heretics) == 0 || (short)ai_spawn_count(control_return_flood) > 10 || volume_test_objects(vol_power_core_enter, players()) == true;
            });
        }

        [ScriptMethod(277, Lifecycle.CommandScript)]
        public async Task control_return_heretic()
        {
            cs_switch("heretic_01");
            cs_enable_moving(true);
            cs_enable_targeting(true);
            cs_shoot(true);
            print("heretic elite 1: 'our lives for the truth!'");
            cs_play_line("0750");
            cs_switch("heretic_02");
            cs_enable_moving(true);
            cs_enable_targeting(true);
            cs_shoot(true);
            print("heretic elite 2: 'the truth and the covenant!'");
            cs_play_line("0760");
        }

        [ScriptMethod(278, Lifecycle.Dormant)]
        public async Task control_room_return()
        {
            ai_disposable(cable_flood, true);
            ai_disposable(cable_sentinels, true);
            ai_disposable(all_allies, true);
            ai_erase_all();
            device_set_position_immediate(control_shield_door.Entity, 1F);
            device_set_position_immediate(shield.Entity, 1F);
            device_operates_automatically_set(control_room_ext.Entity, false);
            device_operates_automatically_set(control_entry_int.Entity, false);
            data_mine_set_mission_segment("04b_15_control_return");
            await sleep_until(async () => device_get_position(elev_control_up.Entity) < 0.05F || volume_test_objects(vol_control_top, players()) == true);
            game_save_immediate();
            wake(new ScriptMethodReference(plummeting_control_commander));
            ai_place(control_return_sentinels_01.Squad, 2);
            ai_place(control_return_heretics_01.Squad, 1);
            ai_place(control_return_heretics_02.Squad, 2);
            ai_place(control_return_h_grunts_02.Squad, 2);
            await sleep(90);
            ai_place(control_return_flood_01.Squad, 2);
            ai_place(control_return_carriers_01.Squad, 2);
            wake(new ScriptMethodReference(control_return_flood_spawn));
            await sleep_until(async () => volume_test_objects(vol_control_return_middle, players()) == true || (short)ai_living_count(control_return_heretics) < 3);
            game_save();
            ai_place(control_return_heretics_03.Squad, (short)(2 - (float)ai_living_count(control_return_heretics_02.Squad)));
            ai_place(control_return_h_grunts_03.Squad, (short)(2 - (float)ai_living_count(control_return_h_grunts_02.Squad)));
            await sleep_until(async () => volume_test_objects(vol_near_shield, players()) == true);
            await sleep_until(async () => ai_scene("control_return_scene", new ScriptMethodReference(control_return_heretic), control_return_heretics) || (short)ai_living_count(control_return_heretics) == 0, 30, 150);
            await sleep_until(async () => (short)ai_living_count(control_return_heretics) == 0);
            game_save();
            ai_set_orders(control_return_flood, control_return_flood_win);
        }

        [ScriptMethod(279, Lifecycle.CommandScript)]
        public async Task power_core_heretic()
        {
            cs_switch("heretic_01");
            cs_enable_moving(true);
            cs_enable_targeting(true);
            cs_shoot(true);
            print("heretic elite: 'the oracle must be saved!'");
            cs_play_line("0740");
        }

        [ScriptMethod(280, Lifecycle.Dormant)]
        public async Task power_core_commander()
        {
            ai_dialogue_enable(false);
            await sleep(60);
            await sleep_until(async () => (bool)game_safe_to_save());
            print("spec-ops commander: 'are you still alive, arbiter?'");
            await sleep(ai_play_line_on_object(default(IGameObject), "0770"));
            print("spec-ops commander: 'we're keeping pace as best we can.'");
            await sleep(ai_play_line_on_object(default(IGameObject), "0780"));
            game_save();
            await sleep(30);
            ai_dialogue_enable(true);
        }

        [ScriptMethod(281, Lifecycle.CommandScript)]
        public async Task hl_retreat_x()
        {
            cs_enable_pathfinding_failsafe(true);
            cs_go_to(GetReference<ISpatialPoint>("fake_cinematics/p4"));
            ai_erase(heretic_leader_04.Squad);
        }

        [ScriptMethod(282, Lifecycle.Dormant)]
        public async Task power_core_start()
        {
            await sleep_until(async () => volume_test_objects(vol_power_core_enter, players()) == true);
            ai_disposable(control_return_flood, true);
            ai_disposable(control_return_sentinels, true);
            ai_disposable(control_return_heretics, true);
            device_operates_automatically_set(hl_ledge_ext.Entity, true);
            data_mine_set_mission_segment("04b_16_power_core");
            ai_set_orders(control_return_flood, power_core_flood_all);
            ai_place(power_core_combatforms.Squad, 2);
            ai_place(power_core_carriers.Squad, 1);
            ai_place(power_core_sentinels_01.Squad, 2);
            ai_place(power_core_heretics_01.Squad, 1);
            ai_place(power_core_h_grunts_01.Squad, 2);
            wake(new ScriptMethodReference(power_core_commander));
            await sleep_until(async () => volume_test_objects(vol_power_core_midway, players()) == true || (short)ai_living_count(power_core_heretics) < 2);
            object_create(player0_fake_banshee);
            object_create(player1_fake_banshee);
            object_create(hl_fake_banshee);
            object_cannot_take_damage(player0_fake_banshee.Entity);
            object_cannot_take_damage(player1_fake_banshee.Entity);
            object_cannot_take_damage(hl_fake_banshee.Entity);
            game_save();
            await sleep_until(async () => ai_scene("power_core_scene", new ScriptMethodReference(power_core_heretic), power_core_heretics) || volume_test_objects(vol_power_core_bottom, players()) == true);
            await sleep_until(async () => volume_test_objects(vol_power_core_bottom, players()) == true);
            if (await this.difficulty_normal() || await this.difficulty_heroic())
            {
                ai_place(power_core_swords.Squad, 1);
            }

            if (await this.difficulty_legendary())
            {
                ai_place(power_core_swords.Squad, 2);
            }
        }

        [ScriptMethod(283, Lifecycle.Dormant)]
        public async Task plummet_killer()
        {
            await sleep_until(async () =>
            {
                object_destroy(list_get(volume_return_objects(vol_cableroom_suck_kill), 0));
                this.plummet_junk_total = (short)(this.plummet_junk_total - 1);
                await sleep(5);
                return (short)structure_bsp_index() == 5;
            }, 5);
        }

        [ScriptMethod(284, Lifecycle.Dormant)]
        public async Task plummet_fl()
        {
            await sleep_until(async () =>
            {
                await sleep_until(async () => volume_test_objects(vol_plummet_fl, players()) == true);
                begin_random(async () => begin_random(async () =>
                {
                    if (this.plummet_junk_total < 50)
                    {
                        object_create_anew(fl01);
                        this.plummet_junk_total = (short)(this.plummet_junk_total + 1);
                        await sleep((short)random_range(5, 15));
                    }
                }, 
    async () =>
                {
                    if (this.plummet_junk_total < 50)
                    {
                        object_create_anew(fl02);
                        this.plummet_junk_total = (short)(this.plummet_junk_total + 1);
                        await sleep((short)random_range(5, 15));
                    }
                }, 
    async () =>
                {
                    if (this.plummet_junk_total < 50)
                    {
                        object_create_anew(fl03);
                        this.plummet_junk_total = (short)(this.plummet_junk_total + 1);
                        await sleep((short)random_range(5, 15));
                    }
                }, 
    async () =>
                {
                    if (this.plummet_junk_total < 50)
                    {
                        object_create_anew(fl04);
                        this.plummet_junk_total = (short)(this.plummet_junk_total + 1);
                        await sleep((short)random_range(5, 15));
                    }
                }, 
    async () =>
                {
                    if (this.plummet_junk_total < 50)
                    {
                        object_create_anew(fl05);
                        this.plummet_junk_total = (short)(this.plummet_junk_total + 1);
                        await sleep((short)random_range(5, 15));
                    }
                }, 
    async () =>
                {
                    if (this.plummet_junk_total < 50)
                    {
                        object_create_anew(fl06);
                        this.plummet_junk_total = (short)(this.plummet_junk_total + 1);
                        await sleep((short)random_range(5, 15));
                    }
                }), 
                    async () => begin_random(async () =>
                {
                    if (this.plummet_junk_total < 50)
                    {
                        object_create_anew(fl08);
                        this.plummet_junk_total = (short)(this.plummet_junk_total + 1);
                        await sleep((short)random_range(5, 15));
                    }
                }, 
    async () =>
                {
                    if (this.plummet_junk_total < 50)
                    {
                        object_create_anew(fl09);
                        this.plummet_junk_total = (short)(this.plummet_junk_total + 1);
                        await sleep((short)random_range(5, 15));
                    }
                }, 
    async () =>
                {
                    if (this.plummet_junk_total < 50)
                    {
                        object_create_anew(fl10);
                        this.plummet_junk_total = (short)(this.plummet_junk_total + 1);
                        await sleep((short)random_range(5, 15));
                    }
                }, 
    async () =>
                {
                    if (this.plummet_junk_total < 50)
                    {
                        object_create_anew(fl11);
                        this.plummet_junk_total = (short)(this.plummet_junk_total + 1);
                        await sleep((short)random_range(5, 15));
                    }
                }, 
    async () =>
                {
                    if (this.plummet_junk_total < 50)
                    {
                        object_create_anew(fl12);
                        this.plummet_junk_total = (short)(this.plummet_junk_total + 1);
                        await sleep((short)random_range(5, 15));
                    }
                }, 
    async () =>
                {
                    if (this.plummet_junk_total < 50)
                    {
                        object_create_anew(fl14);
                        this.plummet_junk_total = (short)(this.plummet_junk_total + 1);
                        await sleep((short)random_range(5, 15));
                    }
                }), 
                    async () => begin_random(async () =>
                {
                    if (this.plummet_junk_total < 50)
                    {
                        object_create_anew(fl15);
                        this.plummet_junk_total = (short)(this.plummet_junk_total + 1);
                        await sleep((short)random_range(5, 15));
                    }
                }, 
    async () =>
                {
                    if (this.plummet_junk_total < 50)
                    {
                        object_create_anew(fl16);
                        this.plummet_junk_total = (short)(this.plummet_junk_total + 1);
                        await sleep((short)random_range(5, 15));
                    }
                }, 
    async () =>
                {
                    if (this.plummet_junk_total < 50)
                    {
                        object_create_anew(fl17);
                        this.plummet_junk_total = (short)(this.plummet_junk_total + 1);
                        await sleep((short)random_range(5, 15));
                    }
                }, 
    async () =>
                {
                    if (this.plummet_junk_total < 50)
                    {
                        object_create_anew(fl18);
                        this.plummet_junk_total = (short)(this.plummet_junk_total + 1);
                        await sleep((short)random_range(5, 15));
                    }
                }, 
    async () =>
                {
                    if (this.plummet_junk_total < 50)
                    {
                        object_create_anew(fl19);
                        this.plummet_junk_total = (short)(this.plummet_junk_total + 1);
                        await sleep((short)random_range(5, 15));
                    }
                }, 
    async () =>
                {
                    if (this.plummet_junk_total < 50)
                    {
                        object_create_anew(fl20);
                        this.plummet_junk_total = (short)(this.plummet_junk_total + 1);
                        await sleep((short)random_range(5, 15));
                    }
                }), 
                    async () => begin_random(async () =>
                {
                    if (this.plummet_junk_total < 50)
                    {
                        object_create_anew(fl21);
                        this.plummet_junk_total = (short)(this.plummet_junk_total + 1);
                        await sleep((short)random_range(5, 15));
                    }
                }, 
    async () =>
                {
                    if (this.plummet_junk_total < 50)
                    {
                        object_create_anew(fl22);
                        this.plummet_junk_total = (short)(this.plummet_junk_total + 1);
                        await sleep((short)random_range(5, 15));
                    }
                }, 
    async () =>
                {
                    if (this.plummet_junk_total < 50)
                    {
                        object_create_anew(fl23);
                        this.plummet_junk_total = (short)(this.plummet_junk_total + 1);
                        await sleep((short)random_range(5, 15));
                    }
                }, 
    async () =>
                {
                    if (this.plummet_junk_total < 50)
                    {
                        object_create_anew(fl24);
                        this.plummet_junk_total = (short)(this.plummet_junk_total + 1);
                        await sleep((short)random_range(5, 15));
                    }
                }, 
    async () =>
                {
                    if (this.plummet_junk_total < 50)
                    {
                        object_create_anew(fl25);
                        this.plummet_junk_total = (short)(this.plummet_junk_total + 1);
                        await sleep((short)random_range(5, 15));
                    }
                }, 
    async () =>
                {
                    if (this.plummet_junk_total < 50)
                    {
                        object_create_anew(fl26);
                        this.plummet_junk_total = (short)(this.plummet_junk_total + 1);
                        await sleep((short)random_range(5, 15));
                    }
                }), 
                    async () => begin_random(async () =>
                {
                    if (this.plummet_junk_total < 50)
                    {
                        object_create_anew(fl27);
                        this.plummet_junk_total = (short)(this.plummet_junk_total + 1);
                        await sleep((short)random_range(5, 15));
                    }
                }, 
    async () =>
                {
                    if (this.plummet_junk_total < 50)
                    {
                        object_create_anew(fl28);
                        this.plummet_junk_total = (short)(this.plummet_junk_total + 1);
                        await sleep((short)random_range(5, 15));
                    }
                }, 
    async () =>
                {
                    if (this.plummet_junk_total < 50)
                    {
                        object_create_anew(fl29);
                        this.plummet_junk_total = (short)(this.plummet_junk_total + 1);
                        await sleep((short)random_range(5, 15));
                    }
                }, 
    async () =>
                {
                    if (this.plummet_junk_total < 50)
                    {
                        object_create_anew(fl30);
                        this.plummet_junk_total = (short)(this.plummet_junk_total + 1);
                        await sleep((short)random_range(5, 15));
                    }
                }, 
    async () =>
                {
                    if (this.plummet_junk_total < 50)
                    {
                        object_create_anew(fl31);
                        this.plummet_junk_total = (short)(this.plummet_junk_total + 1);
                        await sleep((short)random_range(5, 15));
                    }
                }, 
    async () =>
                {
                    if (this.plummet_junk_total < 50)
                    {
                        object_create_anew(fl32);
                        this.plummet_junk_total = (short)(this.plummet_junk_total + 1);
                        await sleep((short)random_range(5, 15));
                    }
                }));
                return volume_test_objects(vol_arm_01_return, players()) == true;
            });
        }

        [ScriptMethod(285, Lifecycle.Dormant)]
        public async Task plummet_fr()
        {
            await sleep_until(async () =>
            {
                await sleep_until(async () => volume_test_objects(vol_plummet_fr, players()) == true);
                begin_random(async () => begin_random(async () =>
                {
                    if (this.plummet_junk_total < 50)
                    {
                        object_create_anew(fr01);
                        this.plummet_junk_total = (short)(this.plummet_junk_total + 1);
                        await sleep((short)random_range(5, 15));
                    }
                }, 
    async () =>
                {
                    if (this.plummet_junk_total < 50)
                    {
                        object_create_anew(fr02);
                        this.plummet_junk_total = (short)(this.plummet_junk_total + 1);
                        await sleep((short)random_range(5, 15));
                    }
                }, 
    async () =>
                {
                    if (this.plummet_junk_total < 50)
                    {
                        object_create_anew(fr03);
                        this.plummet_junk_total = (short)(this.plummet_junk_total + 1);
                        await sleep((short)random_range(5, 15));
                    }
                }, 
    async () =>
                {
                    if (this.plummet_junk_total < 50)
                    {
                        object_create_anew(fr04);
                        this.plummet_junk_total = (short)(this.plummet_junk_total + 1);
                        await sleep((short)random_range(5, 15));
                    }
                }, 
    async () =>
                {
                    if (this.plummet_junk_total < 50)
                    {
                        object_create_anew(fr05);
                        this.plummet_junk_total = (short)(this.plummet_junk_total + 1);
                        await sleep((short)random_range(5, 15));
                    }
                }, 
    async () =>
                {
                    if (this.plummet_junk_total < 50)
                    {
                        object_create_anew(fr06);
                        this.plummet_junk_total = (short)(this.plummet_junk_total + 1);
                        await sleep((short)random_range(5, 15));
                    }
                }), 
                    async () => begin_random(async () =>
                {
                    if (this.plummet_junk_total < 50)
                    {
                        object_create_anew(fr08);
                        this.plummet_junk_total = (short)(this.plummet_junk_total + 1);
                        await sleep((short)random_range(5, 15));
                    }
                }, 
    async () =>
                {
                    if (this.plummet_junk_total < 50)
                    {
                        object_create_anew(fr09);
                        this.plummet_junk_total = (short)(this.plummet_junk_total + 1);
                        await sleep((short)random_range(5, 15));
                    }
                }, 
    async () =>
                {
                    if (this.plummet_junk_total < 50)
                    {
                        object_create_anew(fr10);
                        this.plummet_junk_total = (short)(this.plummet_junk_total + 1);
                        await sleep((short)random_range(5, 15));
                    }
                }, 
    async () =>
                {
                    if (this.plummet_junk_total < 50)
                    {
                        object_create_anew(fr11);
                        this.plummet_junk_total = (short)(this.plummet_junk_total + 1);
                        await sleep((short)random_range(5, 15));
                    }
                }, 
    async () =>
                {
                    if (this.plummet_junk_total < 50)
                    {
                        object_create_anew(fr12);
                        this.plummet_junk_total = (short)(this.plummet_junk_total + 1);
                        await sleep((short)random_range(5, 15));
                    }
                }, 
    async () =>
                {
                    if (this.plummet_junk_total < 50)
                    {
                        object_create_anew(fr14);
                        this.plummet_junk_total = (short)(this.plummet_junk_total + 1);
                        await sleep((short)random_range(5, 15));
                    }
                }), 
                    async () => begin_random(async () =>
                {
                    if (this.plummet_junk_total < 50)
                    {
                        object_create_anew(fr15);
                        this.plummet_junk_total = (short)(this.plummet_junk_total + 1);
                        await sleep((short)random_range(5, 15));
                    }
                }, 
    async () =>
                {
                    if (this.plummet_junk_total < 50)
                    {
                        object_create_anew(fr16);
                        this.plummet_junk_total = (short)(this.plummet_junk_total + 1);
                        await sleep((short)random_range(5, 15));
                    }
                }, 
    async () =>
                {
                    if (this.plummet_junk_total < 50)
                    {
                        object_create_anew(fr17);
                        this.plummet_junk_total = (short)(this.plummet_junk_total + 1);
                        await sleep((short)random_range(5, 15));
                    }
                }, 
    async () =>
                {
                    if (this.plummet_junk_total < 50)
                    {
                        object_create_anew(fr18);
                        this.plummet_junk_total = (short)(this.plummet_junk_total + 1);
                        await sleep((short)random_range(5, 15));
                    }
                }, 
    async () =>
                {
                    if (this.plummet_junk_total < 50)
                    {
                        object_create_anew(fr19);
                        this.plummet_junk_total = (short)(this.plummet_junk_total + 1);
                        await sleep((short)random_range(5, 15));
                    }
                }, 
    async () =>
                {
                    if (this.plummet_junk_total < 50)
                    {
                        object_create_anew(fr20);
                        this.plummet_junk_total = (short)(this.plummet_junk_total + 1);
                        await sleep((short)random_range(5, 15));
                    }
                }), 
                    async () => begin_random(async () =>
                {
                    if (this.plummet_junk_total < 50)
                    {
                        object_create_anew(fr21);
                        this.plummet_junk_total = (short)(this.plummet_junk_total + 1);
                        await sleep((short)random_range(5, 15));
                    }
                }, 
    async () =>
                {
                    if (this.plummet_junk_total < 50)
                    {
                        object_create_anew(fr22);
                        this.plummet_junk_total = (short)(this.plummet_junk_total + 1);
                        await sleep((short)random_range(5, 15));
                    }
                }, 
    async () =>
                {
                    if (this.plummet_junk_total < 50)
                    {
                        object_create_anew(fr23);
                        this.plummet_junk_total = (short)(this.plummet_junk_total + 1);
                        await sleep((short)random_range(5, 15));
                    }
                }, 
    async () =>
                {
                    if (this.plummet_junk_total < 50)
                    {
                        object_create_anew(fr24);
                        this.plummet_junk_total = (short)(this.plummet_junk_total + 1);
                        await sleep((short)random_range(5, 15));
                    }
                }, 
    async () =>
                {
                    if (this.plummet_junk_total < 50)
                    {
                        object_create_anew(fr25);
                        this.plummet_junk_total = (short)(this.plummet_junk_total + 1);
                        await sleep((short)random_range(5, 15));
                    }
                }, 
    async () =>
                {
                    if (this.plummet_junk_total < 50)
                    {
                        object_create_anew(fr26);
                        this.plummet_junk_total = (short)(this.plummet_junk_total + 1);
                        await sleep((short)random_range(5, 15));
                    }
                }), 
                    async () => begin_random(async () =>
                {
                    if (this.plummet_junk_total < 50)
                    {
                        object_create_anew(fr27);
                        this.plummet_junk_total = (short)(this.plummet_junk_total + 1);
                        await sleep((short)random_range(5, 15));
                    }
                }, 
    async () =>
                {
                    if (this.plummet_junk_total < 50)
                    {
                        object_create_anew(fr28);
                        this.plummet_junk_total = (short)(this.plummet_junk_total + 1);
                        await sleep((short)random_range(5, 15));
                    }
                }, 
    async () =>
                {
                    if (this.plummet_junk_total < 50)
                    {
                        object_create_anew(fr29);
                        this.plummet_junk_total = (short)(this.plummet_junk_total + 1);
                        await sleep((short)random_range(5, 15));
                    }
                }, 
    async () =>
                {
                    if (this.plummet_junk_total < 50)
                    {
                        object_create_anew(fr30);
                        this.plummet_junk_total = (short)(this.plummet_junk_total + 1);
                        await sleep((short)random_range(5, 15));
                    }
                }, 
    async () =>
                {
                    if (this.plummet_junk_total < 50)
                    {
                        object_create_anew(fr31);
                        this.plummet_junk_total = (short)(this.plummet_junk_total + 1);
                        await sleep((short)random_range(5, 15));
                    }
                }, 
    async () =>
                {
                    if (this.plummet_junk_total < 50)
                    {
                        object_create_anew(fr32);
                        this.plummet_junk_total = (short)(this.plummet_junk_total + 1);
                        await sleep((short)random_range(5, 15));
                    }
                }));
                return volume_test_objects(vol_arm_01_return, players()) == true;
            });
        }

        [ScriptMethod(286, Lifecycle.Dormant)]
        public async Task plummet_nr()
        {
            await sleep_until(async () =>
            {
                await sleep_until(async () => volume_test_objects(vol_plummet_nr, players()) == true);
                begin_random(async () => begin_random(async () =>
                {
                    if (this.plummet_junk_total < 50)
                    {
                        object_create_anew(nr01);
                        this.plummet_junk_total = (short)(this.plummet_junk_total + 1);
                        await sleep((short)random_range(5, 15));
                    }
                }, 
    async () =>
                {
                    if (this.plummet_junk_total < 50)
                    {
                        object_create_anew(nr02);
                        this.plummet_junk_total = (short)(this.plummet_junk_total + 1);
                        await sleep((short)random_range(5, 15));
                    }
                }, 
    async () =>
                {
                    if (this.plummet_junk_total < 50)
                    {
                        object_create_anew(nr03);
                        this.plummet_junk_total = (short)(this.plummet_junk_total + 1);
                        await sleep((short)random_range(5, 15));
                    }
                }, 
    async () =>
                {
                    if (this.plummet_junk_total < 50)
                    {
                        object_create_anew(nr04);
                        this.plummet_junk_total = (short)(this.plummet_junk_total + 1);
                        await sleep((short)random_range(5, 15));
                    }
                }, 
    async () =>
                {
                    if (this.plummet_junk_total < 50)
                    {
                        object_create_anew(nr05);
                        this.plummet_junk_total = (short)(this.plummet_junk_total + 1);
                        await sleep((short)random_range(5, 15));
                    }
                }, 
    async () =>
                {
                    if (this.plummet_junk_total < 50)
                    {
                        object_create_anew(nr06);
                        this.plummet_junk_total = (short)(this.plummet_junk_total + 1);
                        await sleep((short)random_range(5, 15));
                    }
                }), 
                    async () => begin_random(async () =>
                {
                    if (this.plummet_junk_total < 50)
                    {
                        object_create_anew(nr08);
                        this.plummet_junk_total = (short)(this.plummet_junk_total + 1);
                        await sleep((short)random_range(5, 15));
                    }
                }, 
    async () =>
                {
                    if (this.plummet_junk_total < 50)
                    {
                        object_create_anew(nr09);
                        this.plummet_junk_total = (short)(this.plummet_junk_total + 1);
                        await sleep((short)random_range(5, 15));
                    }
                }, 
    async () =>
                {
                    if (this.plummet_junk_total < 50)
                    {
                        object_create_anew(nr10);
                        this.plummet_junk_total = (short)(this.plummet_junk_total + 1);
                        await sleep((short)random_range(5, 15));
                    }
                }, 
    async () =>
                {
                    if (this.plummet_junk_total < 50)
                    {
                        object_create_anew(nr11);
                        this.plummet_junk_total = (short)(this.plummet_junk_total + 1);
                        await sleep((short)random_range(5, 15));
                    }
                }, 
    async () =>
                {
                    if (this.plummet_junk_total < 50)
                    {
                        object_create_anew(nr12);
                        this.plummet_junk_total = (short)(this.plummet_junk_total + 1);
                        await sleep((short)random_range(5, 15));
                    }
                }, 
    async () =>
                {
                    if (this.plummet_junk_total < 50)
                    {
                        object_create_anew(nr14);
                        this.plummet_junk_total = (short)(this.plummet_junk_total + 1);
                        await sleep((short)random_range(5, 15));
                    }
                }), 
                    async () => begin_random(async () =>
                {
                    if (this.plummet_junk_total < 50)
                    {
                        object_create_anew(nr15);
                        this.plummet_junk_total = (short)(this.plummet_junk_total + 1);
                        await sleep((short)random_range(5, 15));
                    }
                }, 
    async () =>
                {
                    if (this.plummet_junk_total < 50)
                    {
                        object_create_anew(nr16);
                        this.plummet_junk_total = (short)(this.plummet_junk_total + 1);
                        await sleep((short)random_range(5, 15));
                    }
                }, 
    async () =>
                {
                    if (this.plummet_junk_total < 50)
                    {
                        object_create_anew(nr17);
                        this.plummet_junk_total = (short)(this.plummet_junk_total + 1);
                        await sleep((short)random_range(5, 15));
                    }
                }, 
    async () =>
                {
                    if (this.plummet_junk_total < 50)
                    {
                        object_create_anew(nr18);
                        this.plummet_junk_total = (short)(this.plummet_junk_total + 1);
                        await sleep((short)random_range(5, 15));
                    }
                }, 
    async () =>
                {
                    if (this.plummet_junk_total < 50)
                    {
                        object_create_anew(nr19);
                        this.plummet_junk_total = (short)(this.plummet_junk_total + 1);
                        await sleep((short)random_range(5, 15));
                    }
                }, 
    async () =>
                {
                    if (this.plummet_junk_total < 50)
                    {
                        object_create_anew(nr20);
                        this.plummet_junk_total = (short)(this.plummet_junk_total + 1);
                        await sleep((short)random_range(5, 15));
                    }
                }), 
                    async () => begin_random(async () =>
                {
                    if (this.plummet_junk_total < 50)
                    {
                        object_create_anew(nr21);
                        this.plummet_junk_total = (short)(this.plummet_junk_total + 1);
                        await sleep((short)random_range(5, 15));
                    }
                }, 
    async () =>
                {
                    if (this.plummet_junk_total < 50)
                    {
                        object_create_anew(nr22);
                        this.plummet_junk_total = (short)(this.plummet_junk_total + 1);
                        await sleep((short)random_range(5, 15));
                    }
                }, 
    async () =>
                {
                    if (this.plummet_junk_total < 50)
                    {
                        object_create_anew(nr23);
                        this.plummet_junk_total = (short)(this.plummet_junk_total + 1);
                        await sleep((short)random_range(5, 15));
                    }
                }, 
    async () =>
                {
                    if (this.plummet_junk_total < 50)
                    {
                        object_create_anew(nr24);
                        this.plummet_junk_total = (short)(this.plummet_junk_total + 1);
                        await sleep((short)random_range(5, 15));
                    }
                }, 
    async () =>
                {
                    if (this.plummet_junk_total < 50)
                    {
                        object_create_anew(nr25);
                        this.plummet_junk_total = (short)(this.plummet_junk_total + 1);
                        await sleep((short)random_range(5, 15));
                    }
                }, 
    async () =>
                {
                    if (this.plummet_junk_total < 50)
                    {
                        object_create_anew(nr26);
                        this.plummet_junk_total = (short)(this.plummet_junk_total + 1);
                        await sleep((short)random_range(5, 15));
                    }
                }), 
                    async () => begin_random(async () =>
                {
                    if (this.plummet_junk_total < 50)
                    {
                        object_create_anew(nr27);
                        this.plummet_junk_total = (short)(this.plummet_junk_total + 1);
                        await sleep((short)random_range(5, 15));
                    }
                }, 
    async () =>
                {
                    if (this.plummet_junk_total < 50)
                    {
                        object_create_anew(nr28);
                        this.plummet_junk_total = (short)(this.plummet_junk_total + 1);
                        await sleep((short)random_range(5, 15));
                    }
                }, 
    async () =>
                {
                    if (this.plummet_junk_total < 50)
                    {
                        object_create_anew(nr29);
                        this.plummet_junk_total = (short)(this.plummet_junk_total + 1);
                        await sleep((short)random_range(5, 15));
                    }
                }, 
    async () =>
                {
                    if (this.plummet_junk_total < 50)
                    {
                        object_create_anew(nr30);
                        this.plummet_junk_total = (short)(this.plummet_junk_total + 1);
                        await sleep((short)random_range(5, 15));
                    }
                }, 
    async () =>
                {
                    if (this.plummet_junk_total < 50)
                    {
                        object_create_anew(nr31);
                        this.plummet_junk_total = (short)(this.plummet_junk_total + 1);
                        await sleep((short)random_range(5, 15));
                    }
                }, 
    async () =>
                {
                    if (this.plummet_junk_total < 50)
                    {
                        object_create_anew(nr32);
                        this.plummet_junk_total = (short)(this.plummet_junk_total + 1);
                        await sleep((short)random_range(5, 15));
                    }
                }));
                return volume_test_objects(vol_arm_01_return, players()) == true;
            });
        }

        [ScriptMethod(287, Lifecycle.Dormant)]
        public async Task plummet_nl()
        {
            await sleep_until(async () =>
            {
                await sleep_until(async () => volume_test_objects(vol_plummet_nl, players()) == true);
                begin_random(async () => begin_random(async () =>
                {
                    if (this.plummet_junk_total < 50)
                    {
                        object_create_anew(nl01);
                        this.plummet_junk_total = (short)(this.plummet_junk_total + 1);
                        await sleep((short)random_range(5, 15));
                    }
                }, 
    async () =>
                {
                    if (this.plummet_junk_total < 50)
                    {
                        object_create_anew(nl02);
                        this.plummet_junk_total = (short)(this.plummet_junk_total + 1);
                        await sleep((short)random_range(5, 15));
                    }
                }, 
    async () =>
                {
                    if (this.plummet_junk_total < 50)
                    {
                        object_create_anew(nl03);
                        this.plummet_junk_total = (short)(this.plummet_junk_total + 1);
                        await sleep((short)random_range(5, 15));
                    }
                }, 
    async () =>
                {
                    if (this.plummet_junk_total < 50)
                    {
                        object_create_anew(nl04);
                        this.plummet_junk_total = (short)(this.plummet_junk_total + 1);
                        await sleep((short)random_range(5, 15));
                    }
                }, 
    async () =>
                {
                    if (this.plummet_junk_total < 50)
                    {
                        object_create_anew(nl05);
                        this.plummet_junk_total = (short)(this.plummet_junk_total + 1);
                        await sleep((short)random_range(5, 15));
                    }
                }, 
    async () =>
                {
                    if (this.plummet_junk_total < 50)
                    {
                        object_create_anew(nl06);
                        this.plummet_junk_total = (short)(this.plummet_junk_total + 1);
                        await sleep((short)random_range(5, 15));
                    }
                }), 
                    async () => begin_random(async () =>
                {
                    if (this.plummet_junk_total < 50)
                    {
                        object_create_anew(nl08);
                        this.plummet_junk_total = (short)(this.plummet_junk_total + 1);
                        await sleep((short)random_range(5, 15));
                    }
                }, 
    async () =>
                {
                    if (this.plummet_junk_total < 50)
                    {
                        object_create_anew(nl09);
                        this.plummet_junk_total = (short)(this.plummet_junk_total + 1);
                        await sleep((short)random_range(5, 15));
                    }
                }, 
    async () =>
                {
                    if (this.plummet_junk_total < 50)
                    {
                        object_create_anew(nl10);
                        this.plummet_junk_total = (short)(this.plummet_junk_total + 1);
                        await sleep((short)random_range(5, 15));
                    }
                }, 
    async () =>
                {
                    if (this.plummet_junk_total < 50)
                    {
                        object_create_anew(nl11);
                        this.plummet_junk_total = (short)(this.plummet_junk_total + 1);
                        await sleep((short)random_range(5, 15));
                    }
                }, 
    async () =>
                {
                    if (this.plummet_junk_total < 50)
                    {
                        object_create_anew(nl12);
                        this.plummet_junk_total = (short)(this.plummet_junk_total + 1);
                        await sleep((short)random_range(5, 15));
                    }
                }, 
    async () =>
                {
                    if (this.plummet_junk_total < 50)
                    {
                        object_create_anew(nl14);
                        this.plummet_junk_total = (short)(this.plummet_junk_total + 1);
                        await sleep((short)random_range(5, 15));
                    }
                }), 
                    async () => begin_random(async () =>
                {
                    if (this.plummet_junk_total < 50)
                    {
                        object_create_anew(nl15);
                        this.plummet_junk_total = (short)(this.plummet_junk_total + 1);
                        await sleep((short)random_range(5, 15));
                    }
                }, 
    async () =>
                {
                    if (this.plummet_junk_total < 50)
                    {
                        object_create_anew(nl16);
                        this.plummet_junk_total = (short)(this.plummet_junk_total + 1);
                        await sleep((short)random_range(5, 15));
                    }
                }, 
    async () =>
                {
                    if (this.plummet_junk_total < 50)
                    {
                        object_create_anew(nl17);
                        this.plummet_junk_total = (short)(this.plummet_junk_total + 1);
                        await sleep((short)random_range(5, 15));
                    }
                }, 
    async () =>
                {
                    if (this.plummet_junk_total < 50)
                    {
                        object_create_anew(nl18);
                        this.plummet_junk_total = (short)(this.plummet_junk_total + 1);
                        await sleep((short)random_range(5, 15));
                    }
                }, 
    async () =>
                {
                    if (this.plummet_junk_total < 50)
                    {
                        object_create_anew(nl19);
                        this.plummet_junk_total = (short)(this.plummet_junk_total + 1);
                        await sleep((short)random_range(5, 15));
                    }
                }, 
    async () =>
                {
                    if (this.plummet_junk_total < 50)
                    {
                        object_create_anew(nl20);
                        this.plummet_junk_total = (short)(this.plummet_junk_total + 1);
                        await sleep((short)random_range(5, 15));
                    }
                }), 
                    async () => begin_random(async () =>
                {
                    if (this.plummet_junk_total < 50)
                    {
                        object_create_anew(nl21);
                        this.plummet_junk_total = (short)(this.plummet_junk_total + 1);
                        await sleep((short)random_range(5, 15));
                    }
                }, 
    async () =>
                {
                    if (this.plummet_junk_total < 50)
                    {
                        object_create_anew(nl22);
                        this.plummet_junk_total = (short)(this.plummet_junk_total + 1);
                        await sleep((short)random_range(5, 15));
                    }
                }, 
    async () =>
                {
                    if (this.plummet_junk_total < 50)
                    {
                        object_create_anew(nl23);
                        this.plummet_junk_total = (short)(this.plummet_junk_total + 1);
                        await sleep((short)random_range(5, 15));
                    }
                }, 
    async () =>
                {
                    if (this.plummet_junk_total < 50)
                    {
                        object_create_anew(nl24);
                        this.plummet_junk_total = (short)(this.plummet_junk_total + 1);
                        await sleep((short)random_range(5, 15));
                    }
                }, 
    async () =>
                {
                    if (this.plummet_junk_total < 50)
                    {
                        object_create_anew(nl25);
                        this.plummet_junk_total = (short)(this.plummet_junk_total + 1);
                        await sleep((short)random_range(5, 15));
                    }
                }, 
    async () =>
                {
                    if (this.plummet_junk_total < 50)
                    {
                        object_create_anew(nl26);
                        this.plummet_junk_total = (short)(this.plummet_junk_total + 1);
                        await sleep((short)random_range(5, 15));
                    }
                }), 
                    async () => begin_random(async () =>
                {
                    if (this.plummet_junk_total < 50)
                    {
                        object_create_anew(nl27);
                        this.plummet_junk_total = (short)(this.plummet_junk_total + 1);
                        await sleep((short)random_range(5, 15));
                    }
                }, 
    async () =>
                {
                    if (this.plummet_junk_total < 50)
                    {
                        object_create_anew(nl28);
                        this.plummet_junk_total = (short)(this.plummet_junk_total + 1);
                        await sleep((short)random_range(5, 15));
                    }
                }, 
    async () =>
                {
                    if (this.plummet_junk_total < 50)
                    {
                        object_create_anew(nl29);
                        this.plummet_junk_total = (short)(this.plummet_junk_total + 1);
                        await sleep((short)random_range(5, 15));
                    }
                }, 
    async () =>
                {
                    if (this.plummet_junk_total < 50)
                    {
                        object_create_anew(nl30);
                        this.plummet_junk_total = (short)(this.plummet_junk_total + 1);
                        await sleep((short)random_range(5, 15));
                    }
                }, 
    async () =>
                {
                    if (this.plummet_junk_total < 50)
                    {
                        object_create_anew(nl31);
                        this.plummet_junk_total = (short)(this.plummet_junk_total + 1);
                        await sleep((short)random_range(5, 15));
                    }
                }, 
    async () =>
                {
                    if (this.plummet_junk_total < 50)
                    {
                        object_create_anew(nl32);
                        this.plummet_junk_total = (short)(this.plummet_junk_total + 1);
                        await sleep((short)random_range(5, 15));
                    }
                }));
                return volume_test_objects(vol_arm_01_return, players()) == true;
            });
        }

        [ScriptMethod(288, Lifecycle.Dormant)]
        public async Task banshee_killer_00()
        {
            await sleep_until(async () => vehicle_test_seat(ai_vehicle_get_from_starting_location(ledge_banshees_02.right), "banshee_d", unit(await this.player0())) == false);
            unit_kill(unit(await this.player0()));
        }

        [ScriptMethod(289, Lifecycle.Dormant)]
        public async Task banshee_killer_01()
        {
            await sleep_until(async () => vehicle_test_seat(ai_vehicle_get_from_starting_location(ledge_banshees_02.left), "banshee_d", unit(await this.player1())) == false);
            unit_kill(unit(await this.player1()));
        }

        [ScriptMethod(290, Lifecycle.CommandScript)]
        public async Task dervish_chase_01()
        {
            cs_enable_pathfinding_failsafe(true);
            cs_go_to(GetReference<ISpatialPoint>("fake_cinematics/p1"));
            cs_shoot(true, list_get(ai_actors(heretic_leader_04.Squad), 0));
            await sleep(60);
            cs_shoot(false, list_get(ai_actors(heretic_leader_04.Squad), 0));
            cs_go_to(GetReference<ISpatialPoint>("fake_cinematics/p0"));
            cs_face(true, GetReference<ISpatialPoint>("fake_cinematics/p4"));
            cs_crouch(true);
            await sleep_until(async () => this.cinematic_shooting_done == true);
            cs_crouch(false);
            cs_face(false, GetReference<ISpatialPoint>("fake_cinematics/p1"));
            cs_go_to_vehicle(player0_fake_banshee.Entity);
            cs_fly_to(GetReference<ISpatialPoint>("airspace3/p1"), 1F);
        }

        [ScriptMethod(291, Lifecycle.CommandScript)]
        public async Task hl_retreat_04()
        {
            cs_enable_pathfinding_failsafe(true);
            cs_go_to_vehicle(hl_fake_banshee.Entity);
            cs_fly_to(GetReference<ISpatialPoint>("airspace3/p3"), 2F);
            cs_shoot(true, list_get(ai_actors(dervish_01.Squad), 0));
            cs_fly_to(GetReference<ISpatialPoint>("airspace3/p5"), 2F);
            cs_shoot(false, list_get(ai_actors(dervish_01.Squad), 0));
            cs_fly_by(GetReference<ISpatialPoint>("airspace3/p6"), 2F);
            cs_vehicle_speed(1F);
            cs_vehicle_boost(true);
            cs_fly_by(GetReference<ISpatialPoint>("airspace3/p8"), 5F);
            this.cinematic_shooting_done = true;
            cs_fly_by(GetReference<ISpatialPoint>("airspace3/p2"), 5F);
            cs_fly_to(GetReference<ISpatialPoint>("airspace3/p0"), 5F);
        }

        [ScriptMethod(292, Lifecycle.Static)]
        public async Task banshee_sin_01_weapon()
        {
            if (unit_has_weapon(unit(await this.player0()), GetTag<BaseTag>("objects\\weapons\\rifle\\plasma_rifle\\plasma_rifle.weapon", 3795321026U)) && this.banshee_sin_01_ready == false)
            {
                unit_add_equipment(unit(list_get(ai_actors(dervish_01.Squad), 0)), rifle, true, true);
                this.banshee_sin_01_ready = true;
            }

            if (unit_has_weapon(unit(await this.player0()), GetTag<BaseTag>("objects\\weapons\\rifle\\covenant_carbine\\covenant_carbine.weapon", 3828679359U)) && this.banshee_sin_01_ready == false)
            {
                unit_add_equipment(unit(list_get(ai_actors(dervish_01.Squad), 0)), carbine, true, true);
                this.banshee_sin_01_ready = true;
            }

            if (unit_has_weapon(unit(await this.player0()), GetTag<BaseTag>("objects\\weapons\\rifle\\beam_rifle\\beam_rifle.weapon", 3838772057U)) && this.banshee_sin_01_ready == false)
            {
                unit_add_equipment(unit(list_get(ai_actors(dervish_01.Squad), 0)), sniper, true, true);
                this.banshee_sin_01_ready = true;
            }

            if (unit_has_weapon(unit(await this.player0()), GetTag<BaseTag>("objects\\weapons\\pistol\\needler\\needler.weapon", 3847881700U)) && this.banshee_sin_01_ready == false)
            {
                unit_add_equipment(unit(list_get(ai_actors(dervish_01.Squad), 0)), needler, true, true);
                this.banshee_sin_01_ready = true;
            }

            if (unit_has_weapon(unit(await this.player0()), GetTag<BaseTag>("objects\\weapons\\pistol\\plasma_pistol\\plasma_pistol.weapon", 3815965181U)) && this.banshee_sin_01_ready == false)
            {
                unit_add_equipment(unit(list_get(ai_actors(dervish_01.Squad), 0)), pistol, true, true);
                this.banshee_sin_01_ready = true;
            }

            if (unit_has_weapon(unit(await this.player0()), GetTag<BaseTag>("objects\\weapons\\support_high\\flak_cannon\\flak_cannon.weapon", 3857187954U)) && this.banshee_sin_01_ready == false)
            {
                unit_add_equipment(unit(list_get(ai_actors(dervish_01.Squad), 0)), flak, true, true);
                this.banshee_sin_01_ready = true;
            }

            if (unit_has_weapon(unit(await this.player0()), GetTag<BaseTag>("objects\\characters\\sentinel_aggressor\\weapons\\beam\\sentinel_aggressor_beam.weapon", 3863217358U)) && this.banshee_sin_01_ready == false)
            {
                unit_add_equipment(unit(list_get(ai_actors(dervish_01.Squad), 0)), beam, true, true);
                this.banshee_sin_01_ready = true;
            }
        }

        [ScriptMethod(293, Lifecycle.Static)]
        public async Task banshee_sin_01()
        {
            camera_control(true);
            cinematic_start_movie("floodlab_banshee_1");
            cinematic_start();
            this.cinematic_letterbox_style = 1;
            camera_set_field_of_view(60F, 0);
            camera_set(cam00, 0);
            this.cinematic_shooting_done = false;
            ai_erase(heretic_leader_04.Squad);
            device_operates_automatically_set(hl_ledge_ext.Entity, true);
            device_set_position(hl_ledge_ext.Entity, 1F);
            object_create_anew(player0_fake_banshee);
            object_create_anew(player1_fake_banshee);
            object_create_anew(hl_fake_banshee);
            fade_in(1F, 1F, 1F, 15);
            ai_place(heretic_leader_04.Squad);
            cs_run_command_script(heretic_leader_04.Squad, new ScriptMethodReference(hl_retreat_04));
            camera_set(cam01, 150);
            await sleep(150);
            ai_place(dervish_01.Squad);
            await this.banshee_sin_01_weapon();
            cs_run_command_script(dervish_01.Squad, new ScriptMethodReference(dervish_chase_01));
            camera_set(cam05, 120);
            await sleep(120);
            camera_set(cam06, 60);
            await sleep(60);
            await sleep_until(async () => this.cinematic_shooting_done == true);
            camera_set(cam02, 0);
            camera_set(cam03, 90);
            await sleep_until(async () => unit_in_vehicle(unit(list_get(ai_actors(dervish_01.Squad), 0))) == true);
            camera_set(cam04, 120);
            await sleep(120);
            fade_out(1F, 1F, 1F, 30);
            await sleep(90);
            ai_erase(dervish_01.Squad);
            ai_erase(heretic_leader_04.Squad);
            device_operates_automatically_set(hl_ledge_ext.Entity, false);
            device_set_position_immediate(hl_ledge_ext.Entity, 0F);
            await sleep_until(async () => (short)ai_living_count(heretic_leader_04.Squad) == 0 && (short)ai_living_count(dervish_01.Squad) == 0);
        }

        [ScriptMethod(294, Lifecycle.Dormant)]
        public async Task dogfight2_commander()
        {
            ai_dialogue_enable(false);
            await sleep(60);
            print("spec-ops commander: 'what lunacy! he'll never escape this maelstrom in a banshee!'");
            await sleep(ai_play_line_on_object(default(IGameObject), "0790"));
            await sleep(30);
            print("spec-ops commander: 'wait! the hangar! there was a seraph fighter inside! arbiter, you know what to do!'");
            await sleep(ai_play_line_on_object(default(IGameObject), "1410"));
            await sleep(30);
            ai_dialogue_enable(true);
        }

        [ScriptMethod(295, Lifecycle.CommandScript)]
        public async Task boost_test()
        {
            cs_vehicle_boost(true);
            cs_enable_targeting(true);
            cs_shoot(true);
            cs_enable_moving(true);
            await sleep_until(async () => objects_distance_to_object(players(), ai_get_object(this.ai_current_actor)) < 20F);
        }

        [ScriptMethod(296, Lifecycle.Dormant)]
        public async Task dogfight_secondtime_start()
        {
            await sleep_until(async () => volume_test_objects(vol_power_core_ledge, players()) == true);
            ai_disposable(power_core_flood, true);
            ai_disposable(power_core_sentinels, true);
            ai_disposable(power_core_heretics, true);
            await this.cinematic_fade_to_white();
            ai_erase_all();
            object_teleport(await this.player0(), player0_hide);
            object_teleport(await this.player1(), player1_hide);
            if (await this.cinematic_skip_start())
            {
                await this.banshee_sin_01();
            }

            await this.cinematic_skip_stop();
            await sleep(2);
            wake(new ScriptMethodReference(plummet_killer));
            wake(new ScriptMethodReference(plummet_fl));
            wake(new ScriptMethodReference(plummet_nl));
            wake(new ScriptMethodReference(plummet_fr));
            wake(new ScriptMethodReference(plummet_nr));
            await sleep(5);
            if ((bool)game_is_cooperative())
            {
                object_destroy(player0_fake_banshee.Entity);
                object_destroy(player1_fake_banshee.Entity);
                object_destroy(hl_fake_banshee.Entity);
                object_teleport(await this.player0(), banshee_player0);
                object_teleport(await this.player1(), banshee_player1);
                ai_place(ledge_banshees_02.left);
                ai_place(ledge_banshees_02.right);
                vehicle_load_magic(ai_vehicle_get_from_starting_location(ledge_banshees_02.left), "banshee_d", await this.player1());
                vehicle_load_magic(ai_vehicle_get_from_starting_location(ledge_banshees_02.right), "banshee_d", await this.player0());
                physics_set_gravity(-4F);
                physics_set_velocity_frame(0F, 0F, 3F);
                wake(new ScriptMethodReference(banshee_killer_00));
                wake(new ScriptMethodReference(banshee_killer_01));
            }
            else
            {
                object_destroy(player0_fake_banshee.Entity);
                object_destroy(player1_fake_banshee.Entity);
                object_destroy(hl_fake_banshee.Entity);
                await sleep(2);
                object_teleport(await this.player0(), banshee_player0);
                await sleep(2);
                ai_place(ledge_banshees_02.right);
                await sleep(2);
                vehicle_load_magic(ai_vehicle_get_from_starting_location(ledge_banshees_02.right), "banshee_d", await this.player0());
                await sleep(2);
                physics_set_gravity(-4F);
                physics_set_velocity_frame(0F, 0F, 3F);
                wake(new ScriptMethodReference(banshee_killer_00));
            }

            device_operates_automatically_set(control_room_ext.Entity, false);
            device_operates_automatically_set(lab_exit_ext.Entity, false);
            device_operates_automatically_set(arm_02_entry_ext.Entity, false);
            ai_place(dogfighters_init.Squad, 2);
            activate_team_nav_point_flag(default_red, player, he_went_here, 0F);
            camera_control(false);
            await sleep(1);
            await cache_block_for_one_frame();
            await sleep(1);
            await this.cinematic_fade_from_white();
            data_mine_set_mission_segment("04b_17_dogfight");
            game_save_immediate();
            wake(new ScriptMethodReference(dogfight2_commander));
            await sleep_until(async () =>
            {
                begin_random(async () =>
                {
                    if ((short)ai_living_count(dogfighters) < 2 && objects_can_see_flag(players(), dogfight_1, 45F) == false)
                    {
                        ai_place(dogfighters_finale._1);
                    }
                }, 
                    async () =>
                {
                    if ((short)ai_living_count(dogfighters) < 2 && objects_can_see_flag(players(), dogfight_2, 45F) == false)
                    {
                        ai_place(dogfighters_finale._2);
                    }
                }, 
                    async () =>
                {
                    if ((short)ai_living_count(dogfighters) < 2 && objects_can_see_flag(players(), dogfight_3, 45F) == false)
                    {
                        ai_place(dogfighters_finale._3);
                    }
                }, 
                    async () =>
                {
                    if ((short)ai_living_count(dogfighters) < 2 && objects_can_see_flag(players(), dogfight_4, 45F) == false)
                    {
                        ai_place(dogfighters_finale._4);
                    }
                }, 
                    async () =>
                {
                    if ((short)ai_living_count(dogfighters) < 2 && objects_can_see_flag(players(), dogfight_5, 45F) == false)
                    {
                        ai_place(dogfighters_finale._5);
                    }
                }, 
                    async () =>
                {
                    if ((short)ai_living_count(dogfighters) < 2 && objects_can_see_flag(players(), dogfight_6, 45F) == false)
                    {
                        ai_place(dogfighters_finale._6);
                    }
                });
                return volume_test_objects(vol_arm_01_return, players()) == true || (short)ai_spawn_count(dogfighters_finale.Squad) > 3;
            });
        }

        [ScriptMethod(297, Lifecycle.CommandScript)]
        public async Task dervish_chase_02()
        {
            cs_enable_pathfinding_failsafe(true);
            cs_fly_to(GetReference<ISpatialPoint>("airspace3/p7"));
            await sleep(15);
            object_create_anew(player_fake_banshee);
            object_damage_damage_section(player_fake_banshee.Entity, "main", 2F);
            ai_erase(dervish_02.Squad);
        }

        [ScriptMethod(298, Lifecycle.CommandScript)]
        public async Task dervish_recovery()
        {
            cs_enable_pathfinding_failsafe(true);
            cs_custom_animation(GetTag<AnimationGraphTag>("objects\\characters\\elite\\elite", 3909748628U), "climb:unarmed:detach", 0F, true);
            await sleep(unit_get_custom_animation_time(unit(ai_get_object(this.ai_current_actor))));
            unit_stop_custom_animation(unit(ai_get_object(this.ai_current_actor)));
            cs_crouch(true);
            cs_move_in_direction(0F, 0.5F, 0F);
            cs_go_to(GetReference<ISpatialPoint>("fake_cinematics/p2"));
            cs_face(true, GetReference<ISpatialPoint>("fake_cinematics/p3"));
            cs_crouch(false);
            sleep_forever();
        }

        [ScriptMethod(299, Lifecycle.Static)]
        public async Task banshee_sin_02_weapon()
        {
            if (unit_has_weapon(unit(await this.player0()), GetTag<BaseTag>("objects\\weapons\\rifle\\plasma_rifle\\plasma_rifle.weapon", 3795321026U)) && this.banshee_sin_02_ready == false)
            {
                unit_add_equipment(unit(list_get(ai_actors(dervish_031.Squad), 0)), rifle, true, true);
                this.banshee_sin_02_ready = true;
            }

            if (unit_has_weapon(unit(await this.player0()), GetTag<BaseTag>("objects\\weapons\\rifle\\covenant_carbine\\covenant_carbine.weapon", 3828679359U)) && this.banshee_sin_02_ready == false)
            {
                unit_add_equipment(unit(list_get(ai_actors(dervish_031.Squad), 0)), carbine, true, true);
                this.banshee_sin_02_ready = true;
            }

            if (unit_has_weapon(unit(await this.player0()), GetTag<BaseTag>("objects\\weapons\\rifle\\beam_rifle\\beam_rifle.weapon", 3838772057U)) && this.banshee_sin_02_ready == false)
            {
                unit_add_equipment(unit(list_get(ai_actors(dervish_031.Squad), 0)), sniper, true, true);
                this.banshee_sin_02_ready = true;
            }

            if (unit_has_weapon(unit(await this.player0()), GetTag<BaseTag>("objects\\weapons\\pistol\\needler\\needler.weapon", 3847881700U)) && this.banshee_sin_02_ready == false)
            {
                unit_add_equipment(unit(list_get(ai_actors(dervish_031.Squad), 0)), needler, true, true);
                this.banshee_sin_02_ready = true;
            }

            if (unit_has_weapon(unit(await this.player0()), GetTag<BaseTag>("objects\\weapons\\pistol\\plasma_pistol\\plasma_pistol.weapon", 3815965181U)) && this.banshee_sin_02_ready == false)
            {
                unit_add_equipment(unit(list_get(ai_actors(dervish_031.Squad), 0)), pistol, true, true);
                this.banshee_sin_02_ready = true;
            }

            if (unit_has_weapon(unit(await this.player0()), GetTag<BaseTag>("objects\\weapons\\support_high\\flak_cannon\\flak_cannon.weapon", 3857187954U)) && this.banshee_sin_02_ready == false)
            {
                unit_add_equipment(unit(list_get(ai_actors(dervish_031.Squad), 0)), flak, true, true);
                this.banshee_sin_02_ready = true;
            }

            if (unit_has_weapon(unit(await this.player0()), GetTag<BaseTag>("objects\\characters\\sentinel_aggressor\\weapons\\beam\\sentinel_aggressor_beam.weapon", 3863217358U)) && this.banshee_sin_02_ready == false)
            {
                unit_add_equipment(unit(list_get(ai_actors(dervish_031.Squad), 0)), beam, true, true);
                this.banshee_sin_02_ready = true;
            }
        }

        [ScriptMethod(300, Lifecycle.Static)]
        public async Task banshee_sin_02()
        {
            camera_control(true);
            cinematic_start_movie("floodlab_banshee_2");
            cinematic_start();
            this.cinematic_letterbox_style = 1;
            camera_set_field_of_view(60F, 0);
            camera_set(end00, 0);
            device_set_position_immediate(banshee_ledge_access_01.Entity, 1F);
            object_create_containing("banshee_gas_0");
            ai_place(dervish_02.Squad);
            cs_run_command_script(dervish_02.Squad, new ScriptMethodReference(dervish_chase_02));
            fade_in(1F, 1F, 1F, 15);
            camera_set(end01, 120);
            await sleep_until(async () => (short)ai_living_count(dervish_02.Squad) == 0);
            await sleep(60);
            ai_place(dervish_031.Squad);
            await this.banshee_sin_02_weapon();
            object_hide(list_get(ai_actors(dervish_031.Squad), 0), true);
            object_teleport(list_get(ai_actors(dervish_031.Squad), 0), dervish_sticks_landing);
            cs_run_command_script(dervish_031.Squad, new ScriptMethodReference(dervish_recovery));
            await sleep(5);
            object_hide(list_get(ai_actors(dervish_031.Squad), 0), false);
            camera_set(end02, 60);
            await sleep(60);
            camera_set(end03, 60);
            await sleep(60);
            camera_set(end04, 60);
            await sleep(60);
            fade_out(1F, 1F, 1F, 15);
            await sleep(20);
            ai_erase(dervish_031.Squad);
            device_set_position_immediate(banshee_ledge_access_01.Entity, 0F);
        }

        [ScriptMethod(301, Lifecycle.Dormant)]
        public async Task bottling_return_s_respawner()
        {
            await sleep_until(async () => (short)ai_living_count(bottling_return_sentinels_03.Squad) < 2);
            if ((short)ai_living_count(bottling_plant_enemies) < 8)
            {
                ai_place(bottling_return_sentinels_03.Squad, 1);
            }

            await sleep((short)random_range(5, 45));
            await sleep_until(async () => (short)ai_living_count(bottling_return_sentinels_03.Squad) < 2);
            if ((short)ai_living_count(bottling_plant_enemies) < 8)
            {
                ai_place(bottling_return_sentinels_03.Squad, 1);
            }

            await sleep((short)random_range(5, 45));
            await sleep_until(async () => (short)ai_living_count(bottling_return_sentinels_03.Squad) < 2);
            if ((short)ai_living_count(bottling_plant_enemies) < 8)
            {
                ai_place(bottling_return_sentinels_03.Squad, 1);
            }
        }

        [ScriptMethod(302, Lifecycle.Dormant)]
        public async Task bottling_return_cf_respawner()
        {
            await sleep_until(async () => (short)ai_nonswarm_count(bottling_return_combatforms_03.Squad) < 2);
            if ((short)ai_living_count(bottling_plant_enemies) < 8)
            {
                ai_place(bottling_return_combatforms_04.Squad, 1);
            }

            await sleep((short)random_range(5, 45));
            await sleep_until(async () => (short)ai_nonswarm_count(bottling_return_combatforms_03.Squad) < 2);
            if ((short)ai_living_count(bottling_plant_enemies) < 8)
            {
                ai_place(bottling_return_combatforms_04.Squad, 1);
            }

            await sleep((short)random_range(5, 45));
            await sleep_until(async () => (short)ai_nonswarm_count(bottling_return_combatforms_03.Squad) < 2);
            if ((short)ai_living_count(bottling_plant_enemies) < 8)
            {
                ai_place(bottling_return_combatforms_04.Squad, 1);
            }
        }

        [ScriptMethod(303, Lifecycle.Dormant)]
        public async Task bottling_return_ca_respawner()
        {
            await sleep_until(async () => (short)ai_nonswarm_count(bottling_return_carriers_03.Squad) < 1);
            if ((short)ai_living_count(bottling_plant_enemies) < 8)
            {
                ai_place(bottling_return_carriers_04.Squad, 1);
            }

            await sleep((short)random_range(5, 45));
            await sleep_until(async () => (short)ai_nonswarm_count(bottling_return_carriers_03.Squad) < 1);
            if ((short)ai_living_count(bottling_plant_enemies) < 8)
            {
                ai_place(bottling_return_carriers_04.Squad, 1);
            }

            await sleep((short)random_range(5, 45));
            await sleep_until(async () => (short)ai_nonswarm_count(bottling_return_carriers_03.Squad) < 1);
            if ((short)ai_living_count(bottling_plant_enemies) < 8)
            {
                ai_place(bottling_return_carriers_04.Squad, 1);
            }
        }

        [ScriptMethod(304, Lifecycle.Dormant)]
        public async Task bottling_return_commander()
        {
            await sleep_until(async () => volume_test_objects(vol_bottling_enter, players()) == true, 30, 8000);
            if (volume_test_objects(vol_bottling_enter, players()) == false && await this.player_count() > 0)
            {
                ai_dialogue_enable(false);
                await sleep(60);
                print("spec-ops commander: 'the heretic-leader has already landed! up to the hangar, arbiter! quickly now!'");
                await sleep(ai_play_line_on_object(default(IGameObject), "1420"));
                await sleep(30);
                ai_dialogue_enable(true);
            }
        }

        [ScriptMethod(305, Lifecycle.Dormant)]
        public async Task bottling_fx_01()
        {
            await sleep_until(async () =>
            {
                await sleep_until(async () => objects_distance_to_flag(players(), _175) < 20F);
                begin_random(async () => effect_new(this.gasleak, _174), 
                    async () => await sleep((short)random_range(5, 30)), 
                    async () => effect_new(this.gasleak, _175), 
                    async () => await sleep((short)random_range(5, 30)), 
                    async () => effect_new(this.gasleak, _176), 
                    async () => await sleep((short)random_range(5, 30)), 
                    async () => effect_new(this.gasleak, _177), 
                    async () => await sleep((short)random_range(5, 30)), 
                    async () => effect_new(this.gasleak, _178), 
                    async () => await sleep((short)random_range(5, 30)), 
                    async () => effect_new(this.gasleak, _179), 
                    async () => await sleep((short)random_range(5, 30)), 
                    async () => effect_new(this.gasleak, _180), 
                    async () => await sleep((short)random_range(5, 30)), 
                    async () => effect_new(this.gasleak, _181), 
                    async () => await sleep((short)random_range(5, 30)), 
                    async () => effect_new(this.gasleak, _182), 
                    async () => await sleep((short)random_range(5, 30)), 
                    async () => effect_new(this.gasleak, _183), 
                    async () => await sleep((short)random_range(5, 30)), 
                    async () => effect_new(this.gasleak, _184), 
                    async () => await sleep((short)random_range(5, 30)), 
                    async () => effect_new(this.boom, _174), 
                    async () => await sleep((short)random_range(5, 30)), 
                    async () => effect_new(this.boom, _175), 
                    async () => await sleep((short)random_range(5, 30)), 
                    async () => effect_new(this.boom, _176), 
                    async () => await sleep((short)random_range(5, 30)), 
                    async () => effect_new(this.boom, _177), 
                    async () => await sleep((short)random_range(5, 30)), 
                    async () => effect_new(this.boom, _178), 
                    async () => await sleep((short)random_range(5, 30)), 
                    async () => effect_new(this.boom, _179), 
                    async () => await sleep((short)random_range(5, 30)), 
                    async () => effect_new(this.boom, _180), 
                    async () => await sleep((short)random_range(5, 30)), 
                    async () => effect_new(this.boom, _181), 
                    async () => await sleep((short)random_range(5, 30)), 
                    async () => effect_new(this.boom, _182), 
                    async () => await sleep((short)random_range(5, 30)), 
                    async () => effect_new(this.boom, _183), 
                    async () => await sleep((short)random_range(5, 30)), 
                    async () => effect_new(this.boom, _184), 
                    async () => await sleep((short)random_range(5, 30)));
                return false;
            });
        }

        [ScriptMethod(306, Lifecycle.Dormant)]
        public async Task bottling_fx_02()
        {
            await sleep_until(async () =>
            {
                await sleep_until(async () => objects_distance_to_flag(players(), _197) < 20F);
                begin_random(async () => effect_new(this.gasleak, _185), 
                    async () => await sleep((short)random_range(5, 30)), 
                    async () => effect_new(this.gasleak, _186), 
                    async () => await sleep((short)random_range(5, 30)), 
                    async () => effect_new(this.gasleak, _187), 
                    async () => await sleep((short)random_range(5, 30)), 
                    async () => effect_new(this.gasleak, _188), 
                    async () => await sleep((short)random_range(5, 30)), 
                    async () => effect_new(this.gasleak, _189), 
                    async () => await sleep((short)random_range(5, 30)), 
                    async () => effect_new(this.gasleak, _190), 
                    async () => await sleep((short)random_range(5, 30)), 
                    async () => effect_new(this.gasleak, _191), 
                    async () => await sleep((short)random_range(5, 30)), 
                    async () => effect_new(this.gasleak, _192), 
                    async () => await sleep((short)random_range(5, 30)), 
                    async () => effect_new(this.gasleak, _193), 
                    async () => await sleep((short)random_range(5, 30)), 
                    async () => effect_new(this.gasleak, _194), 
                    async () => await sleep((short)random_range(5, 30)), 
                    async () => effect_new(this.gasleak, _195), 
                    async () => await sleep((short)random_range(5, 30)), 
                    async () => effect_new(this.gasleak, _196), 
                    async () => await sleep((short)random_range(5, 30)), 
                    async () => effect_new(this.gasleak, _197), 
                    async () => await sleep((short)random_range(5, 30)), 
                    async () => effect_new(this.gasleak, _198), 
                    async () => await sleep((short)random_range(5, 30)), 
                    async () => effect_new(this.boom, _185), 
                    async () => await sleep((short)random_range(5, 30)), 
                    async () => effect_new(this.boom, _186), 
                    async () => await sleep((short)random_range(5, 30)), 
                    async () => effect_new(this.boom, _187), 
                    async () => await sleep((short)random_range(5, 30)), 
                    async () => effect_new(this.boom, _188), 
                    async () => await sleep((short)random_range(5, 30)), 
                    async () => effect_new(this.boom, _189), 
                    async () => await sleep((short)random_range(5, 30)), 
                    async () => effect_new(this.boom, _190), 
                    async () => await sleep((short)random_range(5, 30)), 
                    async () => effect_new(this.boom, _191), 
                    async () => await sleep((short)random_range(5, 30)), 
                    async () => effect_new(this.boom, _192), 
                    async () => await sleep((short)random_range(5, 30)), 
                    async () => effect_new(this.boom, _193), 
                    async () => await sleep((short)random_range(5, 30)), 
                    async () => effect_new(this.boom, _194), 
                    async () => await sleep((short)random_range(5, 30)), 
                    async () => effect_new(this.boom, _195), 
                    async () => await sleep((short)random_range(5, 30)), 
                    async () => effect_new(this.boom, _196), 
                    async () => await sleep((short)random_range(5, 30)), 
                    async () => effect_new(this.boom, _197), 
                    async () => await sleep((short)random_range(5, 30)), 
                    async () => effect_new(this.boom, _198), 
                    async () => await sleep((short)random_range(5, 30)));
                return false;
            });
        }

        [ScriptMethod(307, Lifecycle.Dormant)]
        public async Task bottling_fx_03()
        {
            await sleep_until(async () =>
            {
                await sleep_until(async () => objects_distance_to_flag(players(), _201) < 20F);
                begin_random(async () => effect_new(this.gasleak, _199), 
                    async () => await sleep((short)random_range(5, 30)), 
                    async () => effect_new(this.gasleak, _200), 
                    async () => await sleep((short)random_range(5, 30)), 
                    async () => effect_new(this.gasleak, _201), 
                    async () => await sleep((short)random_range(5, 30)), 
                    async () => effect_new(this.gasleak, _202), 
                    async () => await sleep((short)random_range(5, 30)), 
                    async () => effect_new(this.gasleak, _203), 
                    async () => await sleep((short)random_range(5, 30)), 
                    async () => effect_new(this.gasleak, _204), 
                    async () => await sleep((short)random_range(5, 30)), 
                    async () => effect_new(this.gasleak, _205), 
                    async () => await sleep((short)random_range(5, 30)), 
                    async () => effect_new(this.gasleak, _206), 
                    async () => await sleep((short)random_range(5, 30)), 
                    async () => effect_new(this.gasleak, _207), 
                    async () => await sleep((short)random_range(5, 30)), 
                    async () => effect_new(this.gasleak, _208), 
                    async () => await sleep((short)random_range(5, 30)), 
                    async () => effect_new(this.gasleak, _209), 
                    async () => await sleep((short)random_range(5, 30)), 
                    async () => effect_new(this.gasleak, _210), 
                    async () => await sleep((short)random_range(5, 30)), 
                    async () => effect_new(this.gasleak, _211), 
                    async () => await sleep((short)random_range(5, 30)), 
                    async () => effect_new(this.gasleak, _212), 
                    async () => await sleep((short)random_range(5, 30)), 
                    async () => effect_new(this.boom, _199), 
                    async () => await sleep((short)random_range(5, 30)), 
                    async () => effect_new(this.boom, _200), 
                    async () => await sleep((short)random_range(5, 30)), 
                    async () => effect_new(this.boom, _201), 
                    async () => await sleep((short)random_range(5, 30)), 
                    async () => effect_new(this.boom, _202), 
                    async () => await sleep((short)random_range(5, 30)), 
                    async () => effect_new(this.boom, _203), 
                    async () => await sleep((short)random_range(5, 30)), 
                    async () => effect_new(this.boom, _204), 
                    async () => await sleep((short)random_range(5, 30)), 
                    async () => effect_new(this.boom, _205), 
                    async () => await sleep((short)random_range(5, 30)), 
                    async () => effect_new(this.boom, _206), 
                    async () => await sleep((short)random_range(5, 30)), 
                    async () => effect_new(this.boom, _207), 
                    async () => await sleep((short)random_range(5, 30)), 
                    async () => effect_new(this.boom, _208), 
                    async () => await sleep((short)random_range(5, 30)), 
                    async () => effect_new(this.boom, _209), 
                    async () => await sleep((short)random_range(5, 30)), 
                    async () => effect_new(this.boom, _210), 
                    async () => await sleep((short)random_range(5, 30)), 
                    async () => effect_new(this.boom, _211), 
                    async () => await sleep((short)random_range(5, 30)), 
                    async () => effect_new(this.boom, _212), 
                    async () => await sleep((short)random_range(5, 30)));
                return false;
            });
        }

        [ScriptMethod(308, Lifecycle.Dormant)]
        public async Task bottling_fx_04()
        {
            await sleep_until(async () =>
            {
                await sleep_until(async () => objects_distance_to_flag(players(), _227) < 20F);
                begin_random(async () => effect_new(this.gasleak, _213), 
                    async () => await sleep((short)random_range(5, 30)), 
                    async () => effect_new(this.gasleak, _214), 
                    async () => await sleep((short)random_range(5, 30)), 
                    async () => effect_new(this.gasleak, _215), 
                    async () => await sleep((short)random_range(5, 30)), 
                    async () => effect_new(this.gasleak, _216), 
                    async () => await sleep((short)random_range(5, 30)), 
                    async () => effect_new(this.gasleak, _217), 
                    async () => await sleep((short)random_range(5, 30)), 
                    async () => effect_new(this.gasleak, _218), 
                    async () => await sleep((short)random_range(5, 30)), 
                    async () => effect_new(this.gasleak, _219), 
                    async () => await sleep((short)random_range(5, 30)), 
                    async () => effect_new(this.gasleak, _220), 
                    async () => await sleep((short)random_range(5, 30)), 
                    async () => effect_new(this.gasleak, _221), 
                    async () => await sleep((short)random_range(5, 30)), 
                    async () => effect_new(this.gasleak, _222), 
                    async () => await sleep((short)random_range(5, 30)), 
                    async () => effect_new(this.gasleak, _223), 
                    async () => await sleep((short)random_range(5, 30)), 
                    async () => effect_new(this.gasleak, _224), 
                    async () => await sleep((short)random_range(5, 30)), 
                    async () => effect_new(this.gasleak, _225), 
                    async () => await sleep((short)random_range(5, 30)), 
                    async () => effect_new(this.gasleak, _226), 
                    async () => await sleep((short)random_range(5, 30)), 
                    async () => effect_new(this.gasleak, _227), 
                    async () => await sleep((short)random_range(5, 30)), 
                    async () => effect_new(this.boom, _213), 
                    async () => await sleep((short)random_range(5, 30)), 
                    async () => effect_new(this.boom, _214), 
                    async () => await sleep((short)random_range(5, 30)), 
                    async () => effect_new(this.boom, _215), 
                    async () => await sleep((short)random_range(5, 30)), 
                    async () => effect_new(this.boom, _216), 
                    async () => await sleep((short)random_range(5, 30)), 
                    async () => effect_new(this.boom, _217), 
                    async () => await sleep((short)random_range(5, 30)), 
                    async () => effect_new(this.boom, _218), 
                    async () => await sleep((short)random_range(5, 30)), 
                    async () => effect_new(this.boom, _219), 
                    async () => await sleep((short)random_range(5, 30)), 
                    async () => effect_new(this.boom, _220), 
                    async () => await sleep((short)random_range(5, 30)), 
                    async () => effect_new(this.boom, _221), 
                    async () => await sleep((short)random_range(5, 30)), 
                    async () => effect_new(this.boom, _222), 
                    async () => await sleep((short)random_range(5, 30)), 
                    async () => effect_new(this.boom, _223), 
                    async () => await sleep((short)random_range(5, 30)), 
                    async () => effect_new(this.boom, _224), 
                    async () => await sleep((short)random_range(5, 30)), 
                    async () => effect_new(this.boom, _225), 
                    async () => await sleep((short)random_range(5, 30)), 
                    async () => effect_new(this.boom, _226), 
                    async () => await sleep((short)random_range(5, 30)), 
                    async () => effect_new(this.boom, _227), 
                    async () => await sleep((short)random_range(5, 30)));
                return false;
            });
        }

        [ScriptMethod(309, Lifecycle.Dormant)]
        public async Task bottling_fx_05()
        {
            await sleep_until(async () =>
            {
                await sleep_until(async () => objects_distance_to_flag(players(), _242) < 20F);
                begin_random(async () => effect_new(this.gasleak, _228), 
                    async () => await sleep((short)random_range(5, 30)), 
                    async () => effect_new(this.gasleak, _229), 
                    async () => await sleep((short)random_range(5, 30)), 
                    async () => effect_new(this.gasleak, _230), 
                    async () => await sleep((short)random_range(5, 30)), 
                    async () => effect_new(this.gasleak, _231), 
                    async () => await sleep((short)random_range(5, 30)), 
                    async () => effect_new(this.gasleak, _232), 
                    async () => await sleep((short)random_range(5, 30)), 
                    async () => effect_new(this.gasleak, _233), 
                    async () => await sleep((short)random_range(5, 30)), 
                    async () => effect_new(this.gasleak, _234), 
                    async () => await sleep((short)random_range(5, 30)), 
                    async () => effect_new(this.gasleak, _235), 
                    async () => await sleep((short)random_range(5, 30)), 
                    async () => effect_new(this.gasleak, _236), 
                    async () => await sleep((short)random_range(5, 30)), 
                    async () => effect_new(this.gasleak, _237), 
                    async () => await sleep((short)random_range(5, 30)), 
                    async () => effect_new(this.gasleak, _238), 
                    async () => await sleep((short)random_range(5, 30)), 
                    async () => effect_new(this.gasleak, _239), 
                    async () => await sleep((short)random_range(5, 30)), 
                    async () => effect_new(this.gasleak, _240), 
                    async () => await sleep((short)random_range(5, 30)), 
                    async () => effect_new(this.gasleak, _241), 
                    async () => await sleep((short)random_range(5, 30)), 
                    async () => effect_new(this.gasleak, _242), 
                    async () => await sleep((short)random_range(5, 30)), 
                    async () => effect_new(this.boom, _228), 
                    async () => await sleep((short)random_range(5, 30)), 
                    async () => effect_new(this.boom, _229), 
                    async () => await sleep((short)random_range(5, 30)), 
                    async () => effect_new(this.boom, _230), 
                    async () => await sleep((short)random_range(5, 30)), 
                    async () => effect_new(this.boom, _231), 
                    async () => await sleep((short)random_range(5, 30)), 
                    async () => effect_new(this.boom, _232), 
                    async () => await sleep((short)random_range(5, 30)), 
                    async () => effect_new(this.boom, _233), 
                    async () => await sleep((short)random_range(5, 30)), 
                    async () => effect_new(this.boom, _234), 
                    async () => await sleep((short)random_range(5, 30)), 
                    async () => effect_new(this.boom, _235), 
                    async () => await sleep((short)random_range(5, 30)), 
                    async () => effect_new(this.boom, _236), 
                    async () => await sleep((short)random_range(5, 30)), 
                    async () => effect_new(this.boom, _237), 
                    async () => await sleep((short)random_range(5, 30)), 
                    async () => effect_new(this.boom, _238), 
                    async () => await sleep((short)random_range(5, 30)), 
                    async () => effect_new(this.boom, _239), 
                    async () => await sleep((short)random_range(5, 30)), 
                    async () => effect_new(this.boom, _240), 
                    async () => await sleep((short)random_range(5, 30)), 
                    async () => effect_new(this.boom, _241), 
                    async () => await sleep((short)random_range(5, 30)), 
                    async () => effect_new(this.boom, _242), 
                    async () => await sleep((short)random_range(5, 30)));
                return false;
            });
        }

        [ScriptMethod(310, Lifecycle.CommandScript)]
        public async Task panic_bottling()
        {
            cs_ignore_obstacles(true);
            cs_enable_moving(true);
            cs_movement_mode(3);
            await sleep_until(async () => volume_test_object(vol_bottling_enter, ai_get_object(this.ai_current_actor)) == true);
        }

        [ScriptMethod(311, Lifecycle.Dormant)]
        public async Task bottling_secondtime_start()
        {
            ai_disposable(dogfighters, true);
            await this.cinematic_fade_to_white();
            ai_erase_all();
            if ((bool)game_is_cooperative())
            {
                sleep_forever(new ScriptMethodReference(banshee_killer_00));
                sleep_forever(new ScriptMethodReference(banshee_killer_01));
                physics_set_gravity(1F);
                physics_set_velocity_frame(0F, 0F, 0F);
                vehicle_unload(ai_vehicle_get_from_starting_location(ledge_banshees_02.right), "banshee_d");
                vehicle_unload(ai_vehicle_get_from_starting_location(ledge_banshees_02.left), "banshee_d");
                object_teleport(await this.player0(), player0_hide);
                object_teleport(await this.player1(), player1_hide);
                object_destroy(ai_vehicle_get_from_starting_location(ledge_banshees_02.right));
                object_destroy(ai_vehicle_get_from_starting_location(ledge_banshees_02.left));
            }
            else
            {
                sleep_forever(new ScriptMethodReference(banshee_killer_00));
                physics_set_gravity(1F);
                physics_set_velocity_frame(0F, 0F, 0F);
                vehicle_unload(ai_vehicle_get_from_starting_location(ledge_banshees_02.right), "banshee_d");
                object_teleport(await this.player0(), player0_hide);
                object_destroy(ai_vehicle_get_from_starting_location(ledge_banshees_02.right));
            }

            if (await this.cinematic_skip_start())
            {
                await this.banshee_sin_02();
            }

            await this.cinematic_skip_stop();
            await sleep(2);
            device_operates_automatically_set(banshee_ledge_access_01.Entity, false);
            device_set_position_immediate(banshee_ledge_access_01.Entity, 0F);
            deactivate_team_nav_point_flag(player, he_went_here);
            object_destroy_containing("banshee_gas_0");
            object_teleport(await this.player0(), bottling_return_player0);
            object_teleport(await this.player1(), bottling_return_player1);
            wake(new ScriptMethodReference(bottling_fx_01));
            wake(new ScriptMethodReference(bottling_fx_02));
            wake(new ScriptMethodReference(bottling_fx_03));
            wake(new ScriptMethodReference(bottling_fx_04));
            wake(new ScriptMethodReference(bottling_fx_05));
            camera_control(false);
            await sleep(1);
            await cache_block_for_one_frame();
            await sleep(1);
            await this.cinematic_fade_from_white();
            data_mine_set_mission_segment("04b_18_bottling_return_01");
            game_save_immediate();
            wake(new ScriptMethodReference(_04b_title2));
            ai_place(bottling_return_sentinels_01.Squad, 2);
            ai_place(bottling_return_flood_01.Squad, 4);
            wake(new ScriptMethodReference(bottling_return_commander));
            await sleep_until(async () => volume_test_objects(vol_bottling_return_01r, players()) == false && await this.player_count() > 0);
            ai_place(bait_bottling_01.Squad, 1);
            await sleep_until(async () => (short)ai_nonswarm_count(bottling_return_flood_01.Squad) < 2 || volume_test_objects(vol_bottling_return_02, players()) == true);
            game_save();
            if ((short)ai_living_count(bottling_plant_enemies) < 8)
            {
                ai_place(bottling_return_combatforms_02.Squad, (short)(3 - (float)ai_nonswarm_count(bottling_return_flood_01.Squad)));
            }

            if ((short)ai_living_count(bottling_plant_enemies) < 8)
            {
                ai_place(bottling_return_carriers_02.Squad, 3);
            }

            await sleep_until(async () => volume_test_objects(vol_bottling_mid03, players()) == true);
            data_mine_set_mission_segment("04b_19_bottling_return_02");
            game_save();
            if ((short)ai_living_count(bottling_plant_enemies) < 8)
            {
                ai_place(bottling_return_sentinels_02.Squad, 3);
            }

            if ((short)ai_living_count(bottling_plant_enemies) < 8)
            {
                ai_place(bottling_return_combatforms_03.Squad, 3);
            }

            if ((short)ai_living_count(bottling_plant_enemies) < 8)
            {
                ai_place(bottling_return_carriers_03.Squad, 2);
            }

            wake(new ScriptMethodReference(bottling_return_s_respawner));
            wake(new ScriptMethodReference(bottling_return_cf_respawner));
            wake(new ScriptMethodReference(bottling_return_ca_respawner));
            await sleep_until(async () => volume_test_objects(vol_bottling_mid02, players()) == true);
            if ((short)ai_living_count(bottling_plant_enemies) < 8)
            {
                ai_place(bait_bottling_02.Squad, 1);
            }

            await sleep_until(async () => (short)structure_bsp_index() == 5 || (short)ai_nonswarm_count(bottling_return_flood) == 0 && (short)ai_nonswarm_count(bottling_return_flood) == 0);
            game_save();
            await sleep_until(async () => (short)structure_bsp_index() == 5);
            sleep_forever(new ScriptMethodReference(bottling_return_s_respawner));
            sleep_forever(new ScriptMethodReference(bottling_return_cf_respawner));
            sleep_forever(new ScriptMethodReference(bottling_return_ca_respawner));
        }

        [ScriptMethod(312, Lifecycle.Dormant)]
        public async Task halls_up_01()
        {
            await sleep_until(async () =>
            {
                await sleep_until(async () => objects_distance_to_flag(players(), _7) < 20F);
                begin_random(async () => effect_new(this.gasleak, _1), 
                    async () => await sleep((short)random_range(5, 30)), 
                    async () => effect_new(this.gasleak, _2), 
                    async () => await sleep((short)random_range(5, 30)), 
                    async () => effect_new(this.gasleak, _3), 
                    async () => await sleep((short)random_range(5, 30)), 
                    async () => effect_new(this.gasleak, _4), 
                    async () => await sleep((short)random_range(5, 30)), 
                    async () => effect_new(this.gasleak, _5), 
                    async () => await sleep((short)random_range(5, 30)), 
                    async () => effect_new(this.gasleak, _6), 
                    async () => await sleep((short)random_range(5, 30)), 
                    async () => effect_new(this.gasleak, _7), 
                    async () => await sleep((short)random_range(5, 30)), 
                    async () => effect_new(this.gasleak, _8), 
                    async () => await sleep((short)random_range(5, 30)), 
                    async () => effect_new(this.gasleak, _9), 
                    async () => await sleep((short)random_range(5, 30)), 
                    async () => effect_new(this.boom, _1), 
                    async () => await sleep((short)random_range(5, 30)), 
                    async () => effect_new(this.boom, _2), 
                    async () => await sleep((short)random_range(5, 30)), 
                    async () => effect_new(this.boom, _3), 
                    async () => await sleep((short)random_range(5, 30)), 
                    async () => effect_new(this.boom, _4), 
                    async () => await sleep((short)random_range(5, 30)), 
                    async () => effect_new(this.boom, _5), 
                    async () => await sleep((short)random_range(5, 30)), 
                    async () => effect_new(this.boom, _6), 
                    async () => await sleep((short)random_range(5, 30)), 
                    async () => effect_new(this.boom, _7), 
                    async () => await sleep((short)random_range(5, 30)), 
                    async () => effect_new(this.boom, _8), 
                    async () => await sleep((short)random_range(5, 30)), 
                    async () => effect_new(this.boom, _9), 
                    async () => await sleep((short)random_range(5, 30)));
                return false;
            });
        }

        [ScriptMethod(313, Lifecycle.Dormant)]
        public async Task halls_up_02()
        {
            await sleep_until(async () =>
            {
                await sleep_until(async () => objects_distance_to_flag(players(), _19) < 20F);
                begin_random(async () => effect_new(this.gasleak, _10), 
                    async () => await sleep((short)random_range(5, 30)), 
                    async () => effect_new(this.gasleak, _11), 
                    async () => await sleep((short)random_range(5, 30)), 
                    async () => effect_new(this.gasleak, _12), 
                    async () => await sleep((short)random_range(5, 30)), 
                    async () => effect_new(this.gasleak, _13), 
                    async () => await sleep((short)random_range(5, 30)), 
                    async () => effect_new(this.gasleak, _14), 
                    async () => await sleep((short)random_range(5, 30)), 
                    async () => effect_new(this.gasleak, _15), 
                    async () => await sleep((short)random_range(5, 30)), 
                    async () => effect_new(this.gasleak, _16), 
                    async () => await sleep((short)random_range(5, 30)), 
                    async () => effect_new(this.gasleak, _17), 
                    async () => await sleep((short)random_range(5, 30)), 
                    async () => effect_new(this.gasleak, _18), 
                    async () => await sleep((short)random_range(5, 30)), 
                    async () => effect_new(this.gasleak, _19), 
                    async () => await sleep((short)random_range(5, 30)), 
                    async () => effect_new(this.gasleak, _20), 
                    async () => await sleep((short)random_range(5, 30)), 
                    async () => effect_new(this.gasleak, _21), 
                    async () => await sleep((short)random_range(5, 30)), 
                    async () => effect_new(this.gasleak, _22), 
                    async () => await sleep((short)random_range(5, 30)), 
                    async () => effect_new(this.gasleak, _23), 
                    async () => await sleep((short)random_range(5, 30)), 
                    async () => effect_new(this.boom, _10), 
                    async () => await sleep((short)random_range(5, 30)), 
                    async () => effect_new(this.boom, _11), 
                    async () => await sleep((short)random_range(5, 30)), 
                    async () => effect_new(this.boom, _12), 
                    async () => await sleep((short)random_range(5, 30)), 
                    async () => effect_new(this.boom, _13), 
                    async () => await sleep((short)random_range(5, 30)), 
                    async () => effect_new(this.boom, _14), 
                    async () => await sleep((short)random_range(5, 30)), 
                    async () => effect_new(this.boom, _15), 
                    async () => await sleep((short)random_range(5, 30)), 
                    async () => effect_new(this.boom, _16), 
                    async () => await sleep((short)random_range(5, 30)), 
                    async () => effect_new(this.boom, _17), 
                    async () => await sleep((short)random_range(5, 30)), 
                    async () => effect_new(this.boom, _18), 
                    async () => await sleep((short)random_range(5, 30)), 
                    async () => effect_new(this.boom, _19), 
                    async () => await sleep((short)random_range(5, 30)), 
                    async () => effect_new(this.boom, _20), 
                    async () => await sleep((short)random_range(5, 30)), 
                    async () => effect_new(this.boom, _21), 
                    async () => await sleep((short)random_range(5, 30)), 
                    async () => effect_new(this.boom, _22), 
                    async () => await sleep((short)random_range(5, 30)), 
                    async () => effect_new(this.boom, _23), 
                    async () => await sleep((short)random_range(5, 30)));
                return false;
            });
        }

        [ScriptMethod(314, Lifecycle.Dormant)]
        public async Task halls_up_03()
        {
            await sleep_until(async () =>
            {
                await sleep_until(async () => objects_distance_to_flag(players(), _24) < 20F);
                begin_random(async () => effect_new(this.gasleak, _24), 
                    async () => await sleep((short)random_range(5, 30)), 
                    async () => effect_new(this.gasleak, _25), 
                    async () => await sleep((short)random_range(5, 30)), 
                    async () => effect_new(this.gasleak, _26), 
                    async () => await sleep((short)random_range(5, 30)), 
                    async () => effect_new(this.gasleak, _27), 
                    async () => await sleep((short)random_range(5, 30)), 
                    async () => effect_new(this.gasleak, _28), 
                    async () => await sleep((short)random_range(5, 30)), 
                    async () => effect_new(this.gasleak, _29), 
                    async () => await sleep((short)random_range(5, 30)), 
                    async () => effect_new(this.gasleak, _30), 
                    async () => await sleep((short)random_range(5, 30)), 
                    async () => effect_new(this.gasleak, _31), 
                    async () => await sleep((short)random_range(5, 30)), 
                    async () => effect_new(this.gasleak, _32), 
                    async () => await sleep((short)random_range(5, 30)), 
                    async () => effect_new(this.gasleak, _33), 
                    async () => await sleep((short)random_range(5, 30)), 
                    async () => effect_new(this.gasleak, _34), 
                    async () => await sleep((short)random_range(5, 30)), 
                    async () => effect_new(this.gasleak, _35), 
                    async () => await sleep((short)random_range(5, 30)), 
                    async () => effect_new(this.gasleak, _36), 
                    async () => await sleep((short)random_range(5, 30)), 
                    async () => effect_new(this.gasleak, _37), 
                    async () => await sleep((short)random_range(5, 30)), 
                    async () => effect_new(this.gasleak, _38), 
                    async () => await sleep((short)random_range(5, 30)), 
                    async () => effect_new(this.boom, _24), 
                    async () => await sleep((short)random_range(5, 30)), 
                    async () => effect_new(this.boom, _25), 
                    async () => await sleep((short)random_range(5, 30)), 
                    async () => effect_new(this.boom, _26), 
                    async () => await sleep((short)random_range(5, 30)), 
                    async () => effect_new(this.boom, _27), 
                    async () => await sleep((short)random_range(5, 30)), 
                    async () => effect_new(this.boom, _28), 
                    async () => await sleep((short)random_range(5, 30)), 
                    async () => effect_new(this.boom, _29), 
                    async () => await sleep((short)random_range(5, 30)), 
                    async () => effect_new(this.boom, _30), 
                    async () => await sleep((short)random_range(5, 30)), 
                    async () => effect_new(this.boom, _31), 
                    async () => await sleep((short)random_range(5, 30)), 
                    async () => effect_new(this.boom, _32), 
                    async () => await sleep((short)random_range(5, 30)), 
                    async () => effect_new(this.boom, _33), 
                    async () => await sleep((short)random_range(5, 30)), 
                    async () => effect_new(this.boom, _34), 
                    async () => await sleep((short)random_range(5, 30)), 
                    async () => effect_new(this.boom, _35), 
                    async () => await sleep((short)random_range(5, 30)), 
                    async () => effect_new(this.boom, _36), 
                    async () => await sleep((short)random_range(5, 30)), 
                    async () => effect_new(this.boom, _37), 
                    async () => await sleep((short)random_range(5, 30)), 
                    async () => effect_new(this.boom, _38), 
                    async () => await sleep((short)random_range(5, 30)));
                return false;
            });
        }

        [ScriptMethod(315, Lifecycle.Dormant)]
        public async Task halls_up_04()
        {
            await sleep_until(async () =>
            {
                await sleep_until(async () => objects_distance_to_flag(players(), _47) < 20F);
                begin_random(async () => effect_new(this.gasleak, _39), 
                    async () => await sleep((short)random_range(5, 30)), 
                    async () => effect_new(this.gasleak, _40), 
                    async () => await sleep((short)random_range(5, 30)), 
                    async () => effect_new(this.gasleak, _41), 
                    async () => await sleep((short)random_range(5, 30)), 
                    async () => effect_new(this.gasleak, _42), 
                    async () => await sleep((short)random_range(5, 30)), 
                    async () => effect_new(this.gasleak, _43), 
                    async () => await sleep((short)random_range(5, 30)), 
                    async () => effect_new(this.gasleak, _44), 
                    async () => await sleep((short)random_range(5, 30)), 
                    async () => effect_new(this.gasleak, _45), 
                    async () => await sleep((short)random_range(5, 30)), 
                    async () => effect_new(this.gasleak, _46), 
                    async () => await sleep((short)random_range(5, 30)), 
                    async () => effect_new(this.gasleak, _47), 
                    async () => await sleep((short)random_range(5, 30)), 
                    async () => effect_new(this.gasleak, _48), 
                    async () => await sleep((short)random_range(5, 30)), 
                    async () => effect_new(this.gasleak, _49), 
                    async () => await sleep((short)random_range(5, 30)), 
                    async () => effect_new(this.gasleak, _50), 
                    async () => await sleep((short)random_range(5, 30)), 
                    async () => effect_new(this.gasleak, _51), 
                    async () => await sleep((short)random_range(5, 30)), 
                    async () => effect_new(this.gasleak, _52), 
                    async () => await sleep((short)random_range(5, 30)), 
                    async () => effect_new(this.gasleak, _53), 
                    async () => await sleep((short)random_range(5, 30)), 
                    async () => effect_new(this.boom, _39), 
                    async () => await sleep((short)random_range(5, 30)), 
                    async () => effect_new(this.boom, _40), 
                    async () => await sleep((short)random_range(5, 30)), 
                    async () => effect_new(this.boom, _41), 
                    async () => await sleep((short)random_range(5, 30)), 
                    async () => effect_new(this.boom, _42), 
                    async () => await sleep((short)random_range(5, 30)), 
                    async () => effect_new(this.boom, _43), 
                    async () => await sleep((short)random_range(5, 30)), 
                    async () => effect_new(this.boom, _44), 
                    async () => await sleep((short)random_range(5, 30)), 
                    async () => effect_new(this.boom, _45), 
                    async () => await sleep((short)random_range(5, 30)), 
                    async () => effect_new(this.boom, _46), 
                    async () => await sleep((short)random_range(5, 30)), 
                    async () => effect_new(this.boom, _47), 
                    async () => await sleep((short)random_range(5, 30)), 
                    async () => effect_new(this.boom, _48), 
                    async () => await sleep((short)random_range(5, 30)), 
                    async () => effect_new(this.boom, _49), 
                    async () => await sleep((short)random_range(5, 30)), 
                    async () => effect_new(this.boom, _50), 
                    async () => await sleep((short)random_range(5, 30)), 
                    async () => effect_new(this.boom, _51), 
                    async () => await sleep((short)random_range(5, 30)), 
                    async () => effect_new(this.boom, _52), 
                    async () => await sleep((short)random_range(5, 30)), 
                    async () => effect_new(this.boom, _53), 
                    async () => await sleep((short)random_range(5, 30)));
                return false;
            });
        }

        [ScriptMethod(316, Lifecycle.Dormant)]
        public async Task halls_up_05()
        {
            await sleep_until(async () =>
            {
                await sleep_until(async () => objects_distance_to_flag(players(), _58) < 20F);
                begin_random(async () => effect_new(this.gasleak, _54), 
                    async () => await sleep((short)random_range(5, 30)), 
                    async () => effect_new(this.gasleak, _55), 
                    async () => await sleep((short)random_range(5, 30)), 
                    async () => effect_new(this.gasleak, _56), 
                    async () => await sleep((short)random_range(5, 30)), 
                    async () => effect_new(this.gasleak, _57), 
                    async () => await sleep((short)random_range(5, 30)), 
                    async () => effect_new(this.gasleak, _58), 
                    async () => await sleep((short)random_range(5, 30)), 
                    async () => effect_new(this.gasleak, _59), 
                    async () => await sleep((short)random_range(5, 30)), 
                    async () => effect_new(this.gasleak, _60), 
                    async () => await sleep((short)random_range(5, 30)), 
                    async () => effect_new(this.gasleak, _61), 
                    async () => await sleep((short)random_range(5, 30)), 
                    async () => effect_new(this.gasleak, _62), 
                    async () => await sleep((short)random_range(5, 30)), 
                    async () => effect_new(this.gasleak, _63), 
                    async () => await sleep((short)random_range(5, 30)), 
                    async () => effect_new(this.gasleak, _64), 
                    async () => await sleep((short)random_range(5, 30)), 
                    async () => effect_new(this.gasleak, _65), 
                    async () => await sleep((short)random_range(5, 30)), 
                    async () => effect_new(this.gasleak, _66), 
                    async () => await sleep((short)random_range(5, 30)), 
                    async () => effect_new(this.gasleak, _67), 
                    async () => await sleep((short)random_range(5, 30)), 
                    async () => effect_new(this.gasleak, _68), 
                    async () => await sleep((short)random_range(5, 30)), 
                    async () => effect_new(this.boom, _54), 
                    async () => await sleep((short)random_range(5, 30)), 
                    async () => effect_new(this.boom, _55), 
                    async () => await sleep((short)random_range(5, 30)), 
                    async () => effect_new(this.boom, _56), 
                    async () => await sleep((short)random_range(5, 30)), 
                    async () => effect_new(this.boom, _57), 
                    async () => await sleep((short)random_range(5, 30)), 
                    async () => effect_new(this.boom, _58), 
                    async () => await sleep((short)random_range(5, 30)), 
                    async () => effect_new(this.boom, _59), 
                    async () => await sleep((short)random_range(5, 30)), 
                    async () => effect_new(this.boom, _60), 
                    async () => await sleep((short)random_range(5, 30)), 
                    async () => effect_new(this.boom, _61), 
                    async () => await sleep((short)random_range(5, 30)), 
                    async () => effect_new(this.boom, _62), 
                    async () => await sleep((short)random_range(5, 30)), 
                    async () => effect_new(this.boom, _63), 
                    async () => await sleep((short)random_range(5, 30)), 
                    async () => effect_new(this.boom, _64), 
                    async () => await sleep((short)random_range(5, 30)), 
                    async () => effect_new(this.boom, _65), 
                    async () => await sleep((short)random_range(5, 30)), 
                    async () => effect_new(this.boom, _66), 
                    async () => await sleep((short)random_range(5, 30)), 
                    async () => effect_new(this.boom, _67), 
                    async () => await sleep((short)random_range(5, 30)), 
                    async () => effect_new(this.boom, _68), 
                    async () => await sleep((short)random_range(5, 30)));
                return false;
            });
        }

        [ScriptMethod(317, Lifecycle.Dormant)]
        public async Task halls_up_06()
        {
            await sleep_until(async () =>
            {
                await sleep_until(async () => objects_distance_to_flag(players(), _69) < 20F);
                begin_random(async () => effect_new(this.gasleak, _69), 
                    async () => await sleep((short)random_range(5, 30)), 
                    async () => effect_new(this.gasleak, _70), 
                    async () => await sleep((short)random_range(5, 30)), 
                    async () => effect_new(this.gasleak, _72), 
                    async () => await sleep((short)random_range(5, 30)), 
                    async () => effect_new(this.gasleak, _73), 
                    async () => await sleep((short)random_range(5, 30)), 
                    async () => effect_new(this.gasleak, _74), 
                    async () => await sleep((short)random_range(5, 30)), 
                    async () => effect_new(this.gasleak, _75), 
                    async () => await sleep((short)random_range(5, 30)), 
                    async () => effect_new(this.gasleak, _76), 
                    async () => await sleep((short)random_range(5, 30)), 
                    async () => effect_new(this.gasleak, _77), 
                    async () => await sleep((short)random_range(5, 30)), 
                    async () => effect_new(this.gasleak, _78), 
                    async () => await sleep((short)random_range(5, 30)), 
                    async () => effect_new(this.gasleak, _79), 
                    async () => await sleep((short)random_range(5, 30)), 
                    async () => effect_new(this.gasleak, _80), 
                    async () => await sleep((short)random_range(5, 30)), 
                    async () => effect_new(this.gasleak, _81), 
                    async () => await sleep((short)random_range(5, 30)), 
                    async () => effect_new(this.gasleak, _82), 
                    async () => await sleep((short)random_range(5, 30)), 
                    async () => effect_new(this.gasleak, _83), 
                    async () => await sleep((short)random_range(5, 30)), 
                    async () => effect_new(this.boom, _69), 
                    async () => await sleep((short)random_range(5, 30)), 
                    async () => effect_new(this.boom, _70), 
                    async () => await sleep((short)random_range(5, 30)), 
                    async () => effect_new(this.boom, _71), 
                    async () => await sleep((short)random_range(5, 30)), 
                    async () => effect_new(this.boom, _72), 
                    async () => await sleep((short)random_range(5, 30)), 
                    async () => effect_new(this.boom, _73), 
                    async () => await sleep((short)random_range(5, 30)), 
                    async () => effect_new(this.boom, _74), 
                    async () => await sleep((short)random_range(5, 30)), 
                    async () => effect_new(this.boom, _75), 
                    async () => await sleep((short)random_range(5, 30)), 
                    async () => effect_new(this.boom, _76), 
                    async () => await sleep((short)random_range(5, 30)), 
                    async () => effect_new(this.boom, _77), 
                    async () => await sleep((short)random_range(5, 30)), 
                    async () => effect_new(this.boom, _78), 
                    async () => await sleep((short)random_range(5, 30)), 
                    async () => effect_new(this.boom, _79), 
                    async () => await sleep((short)random_range(5, 30)), 
                    async () => effect_new(this.boom, _80), 
                    async () => await sleep((short)random_range(5, 30)), 
                    async () => effect_new(this.boom, _81), 
                    async () => await sleep((short)random_range(5, 30)), 
                    async () => effect_new(this.boom, _82), 
                    async () => await sleep((short)random_range(5, 30)), 
                    async () => effect_new(this.boom, _83), 
                    async () => await sleep((short)random_range(5, 30)), 
                    async () => effect_new(this.boom, _84), 
                    async () => await sleep((short)random_range(5, 30)));
                return false;
            });
        }

        [ScriptMethod(318, Lifecycle.Dormant)]
        public async Task halls_up_07()
        {
            await sleep_until(async () =>
            {
                await sleep_until(async () => objects_distance_to_flag(players(), _85) < 20F);
                begin_random(async () => effect_new(this.gasleak, _85), 
                    async () => await sleep((short)random_range(5, 30)), 
                    async () => effect_new(this.gasleak, _86), 
                    async () => await sleep((short)random_range(5, 30)), 
                    async () => effect_new(this.gasleak, _87), 
                    async () => await sleep((short)random_range(5, 30)), 
                    async () => effect_new(this.gasleak, _88), 
                    async () => await sleep((short)random_range(5, 30)), 
                    async () => effect_new(this.gasleak, _89), 
                    async () => await sleep((short)random_range(5, 30)), 
                    async () => effect_new(this.gasleak, _90), 
                    async () => await sleep((short)random_range(5, 30)), 
                    async () => effect_new(this.gasleak, _92), 
                    async () => await sleep((short)random_range(5, 30)), 
                    async () => effect_new(this.gasleak, _93), 
                    async () => await sleep((short)random_range(5, 30)), 
                    async () => effect_new(this.gasleak, _94), 
                    async () => await sleep((short)random_range(5, 30)), 
                    async () => effect_new(this.gasleak, _95), 
                    async () => await sleep((short)random_range(5, 30)), 
                    async () => effect_new(this.gasleak, _96), 
                    async () => await sleep((short)random_range(5, 30)), 
                    async () => effect_new(this.gasleak, _98), 
                    async () => await sleep((short)random_range(5, 30)), 
                    async () => effect_new(this.gasleak, _99), 
                    async () => await sleep((short)random_range(5, 30)), 
                    async () => effect_new(this.gasleak, _100), 
                    async () => await sleep((short)random_range(5, 30)), 
                    async () => effect_new(this.boom, _85), 
                    async () => await sleep((short)random_range(5, 30)), 
                    async () => effect_new(this.boom, _86), 
                    async () => await sleep((short)random_range(5, 30)), 
                    async () => effect_new(this.boom, _87), 
                    async () => await sleep((short)random_range(5, 30)), 
                    async () => effect_new(this.boom, _88), 
                    async () => await sleep((short)random_range(5, 30)), 
                    async () => effect_new(this.boom, _89), 
                    async () => await sleep((short)random_range(5, 30)), 
                    async () => effect_new(this.boom, _90), 
                    async () => await sleep((short)random_range(5, 30)), 
                    async () => effect_new(this.boom, _91), 
                    async () => await sleep((short)random_range(5, 30)), 
                    async () => effect_new(this.boom, _92), 
                    async () => await sleep((short)random_range(5, 30)), 
                    async () => effect_new(this.boom, _93), 
                    async () => await sleep((short)random_range(5, 30)), 
                    async () => effect_new(this.boom, _94), 
                    async () => await sleep((short)random_range(5, 30)), 
                    async () => effect_new(this.boom, _95), 
                    async () => await sleep((short)random_range(5, 30)), 
                    async () => effect_new(this.boom, _96), 
                    async () => await sleep((short)random_range(5, 30)), 
                    async () => effect_new(this.boom, _97), 
                    async () => await sleep((short)random_range(5, 30)), 
                    async () => effect_new(this.boom, _98), 
                    async () => await sleep((short)random_range(5, 30)), 
                    async () => effect_new(this.boom, _99), 
                    async () => await sleep((short)random_range(5, 30)), 
                    async () => effect_new(this.boom, _100), 
                    async () => await sleep((short)random_range(5, 30)));
                return false;
            });
        }

        [ScriptMethod(319, Lifecycle.CommandScript)]
        public async Task panic_halls()
        {
            cs_enable_moving(true);
            cs_movement_mode(3);
            await sleep_until(async () => volume_test_object(vol_bottling_enter, ai_get_object(this.ai_current_actor)) == true);
        }

        [ScriptMethod(320, Lifecycle.Dormant)]
        public async Task to_underhangar_secondtime()
        {
            await sleep_until(async () => volume_test_objects(vol_bottling_enter, players()) == true);
            ai_disposable(bottling_return_flood, true);
            ai_disposable(bottling_return_sentinels, true);
            wake(new ScriptMethodReference(music_04b_08_start));
            wake(new ScriptMethodReference(halls_up_01));
            wake(new ScriptMethodReference(halls_up_02));
            wake(new ScriptMethodReference(halls_up_03));
            wake(new ScriptMethodReference(halls_up_04));
            wake(new ScriptMethodReference(halls_up_05));
            wake(new ScriptMethodReference(halls_up_06));
            wake(new ScriptMethodReference(halls_up_07));
            await sleep_until(async () => (short)structure_bsp_index() == 5);
            data_mine_set_mission_segment("04b_20_halls_to_under_01");
            game_save();
            ai_place(second_hall_infection_01.Squad, 4);
            ai_place(bait_hall_01.Squad, 1);
            await sleep_until(async () =>
            {
                await sleep_until(async () => volume_test_objects(vol_2nd_hall_02, players()) == true, 30, 150);
                if ((short)ai_nonswarm_count(second_hall_flood) < 2 && device_get_position(hall2_spawn_01.Entity) == 0F && volume_test_objects(vol_hall2_spawn_01, players()) == false && await this.player_count() > 0)
                {
                    ai_place(second_hall_flood_01.Squad, 1);
                }

                return volume_test_objects(vol_2nd_hall_02, players()) == true || (short)ai_spawn_count(second_hall_flood_01.Squad) == 4;
            });
            data_mine_set_mission_segment("04b_21_halls_to_under_02");
            game_save();
            ai_place(second_hall_carriers.Squad, 2);
            ai_place(bait_hall_02.Squad, 1);
            await sleep_until(async () =>
            {
                await sleep_until(async () => volume_test_objects(vol_2nd_hall_01, players()) == true, 30, 150);
                if ((short)ai_nonswarm_count(second_hall_flood) < 2 && device_get_position(hall2_spawn_02.Entity) == 0F && volume_test_objects(vol_hall2_spawn_02, players()) == false && await this.player_count() > 0)
                {
                    ai_place(second_hall_flood_02.Squad, 1);
                }

                return volume_test_objects(vol_2nd_hall_01, players()) == true || (short)ai_spawn_count(second_hall_flood_02.Squad) == 4;
            });
            await sleep_until(async () => volume_test_objects(vol_2nd_hall_01, players()) == true);
            wake(new ScriptMethodReference(music_04b_08_start_alt));
            data_mine_set_mission_segment("04b_22_halls_to_under_03");
            game_save();
            ai_place(bait_hall_03.Squad, 1);
            await sleep_until(async () =>
            {
                await sleep_until(async () => volume_test_objects(vol_underhangar_from_bottom, players()) == true, 30, 150);
                if ((short)ai_nonswarm_count(second_hall_flood) < 2 && device_get_position(hall2_spawn_03.Entity) == 0F && volume_test_objects(vol_hall2_spawn_03, players()) == false && await this.player_count() > 0)
                {
                    ai_place(second_hall_flood_03.Squad, 1);
                }

                return volume_test_objects(vol_underhangar_from_bottom, players()) == true || (short)ai_spawn_count(second_hall_flood_03.Squad) == 4;
            });
        }

        [ScriptMethod(321, Lifecycle.Dormant)]
        public async Task underhangar_fx_01()
        {
            await sleep_until(async () =>
            {
                await sleep_until(async () => objects_distance_to_flag(players(), _251) < 20F);
                begin_random(async () => effect_new(this.gasleak, _243), 
                    async () => await sleep((short)random_range(5, 30)), 
                    async () => effect_new(this.gasleak, _244), 
                    async () => await sleep((short)random_range(5, 30)), 
                    async () => effect_new(this.gasleak, _245), 
                    async () => await sleep((short)random_range(5, 30)), 
                    async () => effect_new(this.gasleak, _246), 
                    async () => await sleep((short)random_range(5, 30)), 
                    async () => effect_new(this.gasleak, _247), 
                    async () => await sleep((short)random_range(5, 30)), 
                    async () => effect_new(this.gasleak, _248), 
                    async () => await sleep((short)random_range(5, 30)), 
                    async () => effect_new(this.gasleak, _249), 
                    async () => await sleep((short)random_range(5, 30)), 
                    async () => effect_new(this.gasleak, _250), 
                    async () => await sleep((short)random_range(5, 30)), 
                    async () => effect_new(this.gasleak, _251), 
                    async () => await sleep((short)random_range(5, 30)), 
                    async () => effect_new(this.gasleak, _252), 
                    async () => await sleep((short)random_range(5, 30)), 
                    async () => effect_new(this.gasleak, _253), 
                    async () => await sleep((short)random_range(5, 30)), 
                    async () => effect_new(this.gasleak, _254), 
                    async () => await sleep((short)random_range(5, 30)), 
                    async () => effect_new(this.boom, _243), 
                    async () => await sleep((short)random_range(5, 30)), 
                    async () => effect_new(this.boom, _244), 
                    async () => await sleep((short)random_range(5, 30)), 
                    async () => effect_new(this.boom, _245), 
                    async () => await sleep((short)random_range(5, 30)), 
                    async () => effect_new(this.boom, _246), 
                    async () => await sleep((short)random_range(5, 30)), 
                    async () => effect_new(this.boom, _247), 
                    async () => await sleep((short)random_range(5, 30)), 
                    async () => effect_new(this.boom, _248), 
                    async () => await sleep((short)random_range(5, 30)), 
                    async () => effect_new(this.boom, _249), 
                    async () => await sleep((short)random_range(5, 30)), 
                    async () => effect_new(this.boom, _250), 
                    async () => await sleep((short)random_range(5, 30)), 
                    async () => effect_new(this.boom, _251), 
                    async () => await sleep((short)random_range(5, 30)), 
                    async () => effect_new(this.boom, _252), 
                    async () => await sleep((short)random_range(5, 30)), 
                    async () => effect_new(this.boom, _253), 
                    async () => await sleep((short)random_range(5, 30)), 
                    async () => effect_new(this.boom, _254), 
                    async () => await sleep((short)random_range(5, 30)));
                return false;
            });
        }

        [ScriptMethod(322, Lifecycle.Dormant)]
        public async Task underhangar_fx_02()
        {
            await sleep_until(async () =>
            {
                await sleep_until(async () => objects_distance_to_flag(players(), _255) < 20F);
                begin_random(async () => effect_new(this.gasleak, _255), 
                    async () => await sleep((short)random_range(5, 30)), 
                    async () => effect_new(this.gasleak, _256), 
                    async () => await sleep((short)random_range(5, 30)), 
                    async () => effect_new(this.gasleak, _257), 
                    async () => await sleep((short)random_range(5, 30)), 
                    async () => effect_new(this.gasleak, _258), 
                    async () => await sleep((short)random_range(5, 30)), 
                    async () => effect_new(this.gasleak, _259), 
                    async () => await sleep((short)random_range(5, 30)), 
                    async () => effect_new(this.gasleak, _260), 
                    async () => await sleep((short)random_range(5, 30)), 
                    async () => effect_new(this.gasleak, _261), 
                    async () => await sleep((short)random_range(5, 30)), 
                    async () => effect_new(this.gasleak, _262), 
                    async () => await sleep((short)random_range(5, 30)), 
                    async () => effect_new(this.gasleak, _263), 
                    async () => await sleep((short)random_range(5, 30)), 
                    async () => effect_new(this.gasleak, _264), 
                    async () => await sleep((short)random_range(5, 30)), 
                    async () => effect_new(this.gasleak, _265), 
                    async () => await sleep((short)random_range(5, 30)), 
                    async () => effect_new(this.gasleak, _266), 
                    async () => await sleep((short)random_range(5, 30)), 
                    async () => effect_new(this.gasleak, _267), 
                    async () => await sleep((short)random_range(5, 30)), 
                    async () => effect_new(this.gasleak, _268), 
                    async () => await sleep((short)random_range(5, 30)), 
                    async () => effect_new(this.gasleak, _269), 
                    async () => await sleep((short)random_range(5, 30)), 
                    async () => effect_new(this.boom, _255), 
                    async () => await sleep((short)random_range(5, 30)), 
                    async () => effect_new(this.boom, _256), 
                    async () => await sleep((short)random_range(5, 30)), 
                    async () => effect_new(this.boom, _257), 
                    async () => await sleep((short)random_range(5, 30)), 
                    async () => effect_new(this.boom, _258), 
                    async () => await sleep((short)random_range(5, 30)), 
                    async () => effect_new(this.boom, _259), 
                    async () => await sleep((short)random_range(5, 30)), 
                    async () => effect_new(this.boom, _260), 
                    async () => await sleep((short)random_range(5, 30)), 
                    async () => effect_new(this.boom, _261), 
                    async () => await sleep((short)random_range(5, 30)), 
                    async () => effect_new(this.boom, _262), 
                    async () => await sleep((short)random_range(5, 30)), 
                    async () => effect_new(this.boom, _263), 
                    async () => await sleep((short)random_range(5, 30)), 
                    async () => effect_new(this.boom, _264), 
                    async () => await sleep((short)random_range(5, 30)), 
                    async () => effect_new(this.boom, _265), 
                    async () => await sleep((short)random_range(5, 30)), 
                    async () => effect_new(this.boom, _266), 
                    async () => await sleep((short)random_range(5, 30)), 
                    async () => effect_new(this.boom, _267), 
                    async () => await sleep((short)random_range(5, 30)), 
                    async () => effect_new(this.boom, _268), 
                    async () => await sleep((short)random_range(5, 30)), 
                    async () => effect_new(this.boom, _269), 
                    async () => await sleep((short)random_range(5, 30)));
                return false;
            });
        }

        [ScriptMethod(323, Lifecycle.Dormant)]
        public async Task underhangar_return_commander()
        {
            await sleep_until(async () => volume_test_objects(vol_underhangar_from_top, players()) == true, 30, 8000);
            if (volume_test_objects(vol_underhangar_from_top, players()) == false && await this.player_count() > 0)
            {
                ai_dialogue_enable(false);
                await sleep(60);
                print("spec-ops commander: 'you're almost there!  keep going!'");
                await sleep(ai_play_line_on_object(default(IGameObject), "1430"));
                await sleep(30);
                ai_dialogue_enable(true);
            }
        }

        [ScriptMethod(324, Lifecycle.Dormant)]
        public async Task underhangar_secondtime_start()
        {
            await sleep_until(async () => volume_test_objects(vol_underhangar_from_bottom, players()) == true);
            ai_disposable(second_hall_flood, true);
            data_mine_set_mission_segment("04b_23_underhangar_return");
            game_save();
            wake(new ScriptMethodReference(underhangar_return_commander));
            wake(new ScriptMethodReference(underhangar_fx_01));
            wake(new ScriptMethodReference(underhangar_fx_02));
            ai_place(underhangar_heretics_01.Squad, 1);
            ai_place(underhangar_h_grunts_01.Squad, 2);
            ai_place(underhangar_heretics_02.Squad, 1);
            ai_place(underhangar_heretics_03.Squad, 1);
            ai_place(underhangar_carriers_02.Squad, 1);
            ai_place(underhangar_carriers_init.Squad, 1);
            ai_place(underhangar_combatforms_init.Squad, 2);
            await sleep_until(async () => volume_test_objects(vol_underhangar_music, players()) == true);
            wake(new ScriptMethodReference(music_04b_08_stop));
            await sleep_until(async () =>
            {
                if ((short)ai_nonswarm_count(underhangar_carriers_02.Squad) < 1 && device_get_position(underhangar_spawn_02.Entity) == 0F && volume_test_objects(vol_underhangar_spawn_02, players()) == false && await this.player_count() > 0)
                {
                    ai_place(underhangar_carriers_02.Squad, 1);
                }

                if ((short)ai_nonswarm_count(underhangar_return_flood) < 2 && device_get_position(underhangar_spawn_01.Entity) == 0F && volume_test_objects(vol_underhangar_spawn_01, players()) == false && await this.player_count() > 0)
                {
                    ai_place(underhangar_return_flood_01.Squad, 1);
                }

                if ((short)ai_nonswarm_count(underhangar_return_flood) < 2 && volume_test_objects(vol_underhangar_shaft_01, players()) == false && await this.player_count() > 0)
                {
                    ai_place(underhangar_return_flood_02.Squad, 1);
                }

                if ((short)ai_nonswarm_count(underhangar_return_flood) < 2 && volume_test_objects(vol_underhangar_shaft_02, players()) == false && await this.player_count() > 0)
                {
                    ai_place(underhangar_return_flood_03.Squad, 1);
                }

                return volume_test_objects(vol_underhangar_return_01, players()) == true || (float)ai_strength(underhangar_heretics_01.Squad) <= 0.25F || (short)ai_spawn_count(underhangar_return_flood) == 20;
            });
            game_save();
            ai_place(underhangar_h_grunts_02.Squad, (short)(2 - (float)ai_living_count(underhangar_h_grunts_01.Squad)));
            await sleep_until(async () =>
            {
                if ((short)ai_nonswarm_count(underhangar_return_flood) < 2 && device_get_position(underhangar_spawn_02.Entity) == 0F && volume_test_objects(vol_underhangar_spawn_02, players()) == false && await this.player_count() > 0)
                {
                    ai_place(underhangar_return_flood_04.Squad, 1);
                }

                return volume_test_objects(vol_underhangar_return_02, players()) == true || (short)ai_living_count(underhangar_heretics_02.Squad) == 0 || (short)ai_spawn_count(underhangar_return_flood_04.Squad) == 20;
            });
            game_save();
            ai_place(underhangar_heretics_03.Squad, (short)(2 - (float)ai_living_count(underhangar_return_heretics)));
            ai_place(underhangar_h_grunts_03.Squad, (short)(2 - (float)ai_living_count(underhangar_h_grunts_02.Squad)));
        }

        [ScriptMethod(325, Lifecycle.Dormant)]
        public async Task other_hall_fx()
        {
            await sleep_until(async () =>
            {
                await sleep_until(async () => objects_distance_to_flag(players(), _270) < 20F);
                begin_random(async () => effect_new(this.gasleak, _270), 
                    async () => await sleep((short)random_range(5, 30)), 
                    async () => effect_new(this.gasleak, _271), 
                    async () => await sleep((short)random_range(5, 30)), 
                    async () => effect_new(this.gasleak, _272), 
                    async () => await sleep((short)random_range(5, 30)), 
                    async () => effect_new(this.gasleak, _273), 
                    async () => await sleep((short)random_range(5, 30)), 
                    async () => effect_new(this.gasleak, _274), 
                    async () => await sleep((short)random_range(5, 30)), 
                    async () => effect_new(this.gasleak, _275), 
                    async () => await sleep((short)random_range(5, 30)), 
                    async () => effect_new(this.gasleak, _276), 
                    async () => await sleep((short)random_range(5, 30)), 
                    async () => effect_new(this.gasleak, _277), 
                    async () => await sleep((short)random_range(5, 30)), 
                    async () => effect_new(this.gasleak, _278), 
                    async () => await sleep((short)random_range(5, 30)), 
                    async () => effect_new(this.gasleak, _279), 
                    async () => await sleep((short)random_range(5, 30)), 
                    async () => effect_new(this.gasleak, _280), 
                    async () => await sleep((short)random_range(5, 30)), 
                    async () => effect_new(this.gasleak, _281), 
                    async () => await sleep((short)random_range(5, 30)), 
                    async () => effect_new(this.gasleak, _282), 
                    async () => await sleep((short)random_range(5, 30)), 
                    async () => effect_new(this.gasleak, _283), 
                    async () => await sleep((short)random_range(5, 30)), 
                    async () => effect_new(this.gasleak, _284), 
                    async () => await sleep((short)random_range(5, 30)), 
                    async () => effect_new(this.boom, _270), 
                    async () => await sleep((short)random_range(5, 30)), 
                    async () => effect_new(this.boom, _271), 
                    async () => await sleep((short)random_range(5, 30)), 
                    async () => effect_new(this.boom, _272), 
                    async () => await sleep((short)random_range(5, 30)), 
                    async () => effect_new(this.boom, _273), 
                    async () => await sleep((short)random_range(5, 30)), 
                    async () => effect_new(this.boom, _274), 
                    async () => await sleep((short)random_range(5, 30)), 
                    async () => effect_new(this.boom, _275), 
                    async () => await sleep((short)random_range(5, 30)), 
                    async () => effect_new(this.boom, _276), 
                    async () => await sleep((short)random_range(5, 30)), 
                    async () => effect_new(this.boom, _277), 
                    async () => await sleep((short)random_range(5, 30)), 
                    async () => effect_new(this.boom, _278), 
                    async () => await sleep((short)random_range(5, 30)), 
                    async () => effect_new(this.boom, _279), 
                    async () => await sleep((short)random_range(5, 30)), 
                    async () => effect_new(this.boom, _280), 
                    async () => await sleep((short)random_range(5, 30)), 
                    async () => effect_new(this.boom, _281), 
                    async () => await sleep((short)random_range(5, 30)), 
                    async () => effect_new(this.boom, _282), 
                    async () => await sleep((short)random_range(5, 30)), 
                    async () => effect_new(this.boom, _283), 
                    async () => await sleep((short)random_range(5, 30)), 
                    async () => effect_new(this.boom, _284), 
                    async () => await sleep((short)random_range(5, 30)));
                return false;
            });
        }

        [ScriptMethod(326, Lifecycle.Dormant)]
        public async Task to_hangar_secondtime()
        {
            await sleep_until(async () => volume_test_objects(vol_underhangar_from_top, players()) == true);
            ai_disposable(underhangar_return_flood, true);
            ai_disposable(underhangar_return_heretics, true);
            wake(new ScriptMethodReference(other_hall_fx));
        }

        [ScriptMethod(327, Lifecycle.Dormant)]
        public async Task hangar_fx()
        {
            await sleep_until(async () =>
            {
                begin_random(async () => begin_random(async () => effect_new(this.big_boom, _294), 
    async () => await sleep((short)random_range(5, 30)), 
    async () => effect_new(this.big_boom, _295), 
    async () => await sleep((short)random_range(5, 30)), 
    async () => effect_new(this.big_boom, _285), 
    async () => await sleep((short)random_range(5, 30)), 
    async () => effect_new(this.big_boom, _286), 
    async () => await sleep((short)random_range(5, 30)), 
    async () => effect_new(this.big_boom, _306), 
    async () => await sleep((short)random_range(5, 30)), 
    async () => effect_new(this.big_boom, _307), 
    async () => await sleep((short)random_range(5, 30)), 
    async () => effect_new(this.big_boom, _289), 
    async () => await sleep((short)random_range(5, 30)), 
    async () => effect_new(this.big_boom, _290), 
    async () => await sleep((short)random_range(5, 30)), 
    async () => effect_new(this.boom, _285), 
    async () => await sleep((short)random_range(5, 30)), 
    async () => effect_new(this.boom, _288), 
    async () => await sleep((short)random_range(5, 30)), 
    async () => effect_new(this.boom, _307), 
    async () => await sleep((short)random_range(5, 30)), 
    async () => effect_new(this.boom, _308), 
    async () => await sleep((short)random_range(5, 30))), 
                    async () => begin_random(async () => effect_new(this.big_boom, _291), 
    async () => await sleep((short)random_range(5, 30)), 
    async () => effect_new(this.big_boom, _292), 
    async () => await sleep((short)random_range(5, 30)), 
    async () => effect_new(this.big_boom, _293), 
    async () => await sleep((short)random_range(5, 30)), 
    async () => effect_new(this.boom, _303), 
    async () => await sleep((short)random_range(5, 30)), 
    async () => effect_new(this.boom, _304), 
    async () => await sleep((short)random_range(5, 30)), 
    async () => effect_new(this.big_boom, _294), 
    async () => await sleep((short)random_range(5, 30)), 
    async () => effect_new(this.big_boom, _295), 
    async () => await sleep((short)random_range(5, 30)), 
    async () => effect_new(this.big_boom, _296), 
    async () => await sleep((short)random_range(5, 30)), 
    async () => effect_new(this.boom, _291), 
    async () => await sleep((short)random_range(5, 30)), 
    async () => effect_new(this.boom, _292), 
    async () => await sleep((short)random_range(5, 30)), 
    async () => effect_new(this.boom, _293), 
    async () => await sleep((short)random_range(5, 30)), 
    async () => effect_new(this.boom, _294), 
    async () => await sleep((short)random_range(5, 30))), 
                    async () => begin_random(async () => effect_new(this.big_boom, _297), 
    async () => await sleep((short)random_range(5, 30)), 
    async () => effect_new(this.big_boom, _298), 
    async () => await sleep((short)random_range(5, 30)), 
    async () => effect_new(this.big_boom, _299), 
    async () => await sleep((short)random_range(5, 30)), 
    async () => effect_new(this.big_boom, _300), 
    async () => await sleep((short)random_range(5, 30)), 
    async () => effect_new(this.big_boom, _301), 
    async () => await sleep((short)random_range(5, 30)), 
    async () => effect_new(this.big_boom, _302), 
    async () => await sleep((short)random_range(5, 30)), 
    async () => effect_new(this.boom, _289), 
    async () => await sleep((short)random_range(5, 30)), 
    async () => effect_new(this.boom, _290), 
    async () => await sleep((short)random_range(5, 30)), 
    async () => effect_new(this.boom, _299), 
    async () => await sleep((short)random_range(5, 30)), 
    async () => effect_new(this.boom, _286), 
    async () => await sleep((short)random_range(5, 30)), 
    async () => effect_new(this.boom, _287), 
    async () => await sleep((short)random_range(5, 30)), 
    async () => effect_new(this.boom, _300), 
    async () => await sleep((short)random_range(5, 30))), 
                    async () => begin_random(async () => effect_new(this.big_boom, _303), 
    async () => await sleep((short)random_range(5, 30)), 
    async () => effect_new(this.big_boom, _304), 
    async () => await sleep((short)random_range(5, 30)), 
    async () => effect_new(this.big_boom, _305), 
    async () => await sleep((short)random_range(5, 30)), 
    async () => effect_new(this.boom, _297), 
    async () => await sleep((short)random_range(5, 30)), 
    async () => effect_new(this.boom, _298), 
    async () => await sleep((short)random_range(5, 30)), 
    async () => effect_new(this.big_boom, _308), 
    async () => await sleep((short)random_range(5, 30)), 
    async () => effect_new(this.big_boom, _287), 
    async () => await sleep((short)random_range(5, 30)), 
    async () => effect_new(this.big_boom, _288), 
    async () => await sleep((short)random_range(5, 30)), 
    async () => effect_new(this.boom, _303), 
    async () => await sleep((short)random_range(5, 30)), 
    async () => effect_new(this.boom, _304), 
    async () => await sleep((short)random_range(5, 30)), 
    async () => effect_new(this.boom, _305), 
    async () => await sleep((short)random_range(5, 30)), 
    async () => effect_new(this.boom, _306), 
    async () => await sleep((short)random_range(5, 30))));
                return false;
            });
        }

        [ScriptMethod(328, Lifecycle.CommandScript)]
        public async Task hack()
        {
            cs_enable_moving(true);
            cs_set_behavior(guard);
            sleep_forever();
        }

        [ScriptMethod(329, Lifecycle.CommandScript)]
        public async Task hl_boss_chat_01()
        {
            this.boss_done_talking = false;
            await sleep_until(async () => this.monitor_done_talking == true);
            cs_suppress_dialogue_global(true);
            await sleep(60);
            print("heretic leader: 'how did the prophets buy your loyalty, arbiter?'");
            cs_play_line("0800");
            await sleep(15);
            print("heretic leader: 'with a new command? a new fleet?'");
            cs_play_line("0810");
            await sleep(30);
            print("heretic leader: 'or was it the promise? their great journey!'");
            cs_play_line("0820");
            cs_suppress_dialogue_global(false);
            this.boss_done_talking = true;
        }

        [ScriptMethod(330, Lifecycle.CommandScript)]
        public async Task hl_boss_chat_02()
        {
            this.boss_done_talking = false;
            await sleep_until(async () => this.monitor_done_talking == true);
            cs_suppress_dialogue_global(true);
            await sleep(60);
            print("heretic leader: 'look around you, arbiter�'");
            cs_play_line("0830");
            await sleep(15);
            print("heretic leader: 'this facility, and dozens like it, devoted to the study of the parasite!'");
            cs_play_line("0840");
            await sleep(15);
            print("heretic leader: 'but where are the weapons, arbiter?  what was the result?'");
            cs_play_line("0850");
            await sleep(30);
            print("heretic leader: 'all that time and effort, and the best the forerunners could do was put these foul creatures on ice!'");
            cs_play_line("0860");
            cs_suppress_dialogue_global(false);
            this.boss_done_talking = true;
        }

        [ScriptMethod(331, Lifecycle.CommandScript)]
        public async Task hl_boss_chat_03()
        {
            this.boss_done_talking = false;
            await sleep_until(async () => this.monitor_done_talking == true);
            cs_suppress_dialogue_global(true);
            await sleep(60);
            print("heretic leader: 'and now, where are these gods the prophets would have us worship?'");
            cs_play_line("0870");
            await sleep(30);
            print("heretic leader: 'transcended? (laughs) hardly.'");
            cs_play_line("0880");
            await sleep(60);
            print("heretic leader: 'come, arbiter. let me show you where they went!'");
            cs_play_line("0890");
            cs_suppress_dialogue_global(false);
            this.boss_done_talking = true;
        }

        [ScriptMethod(332, Lifecycle.CommandScript)]
        public async Task monitor_chat_01()
        {
            this.monitor_available = false;
            this.monitor_done_talking = false;
            cs_suppress_dialogue_global(true);
            cs_switch("monitor");
            await sleep(60);
            cs_start_approach_player(3F, 50F, 50F);
            cs_enable_moving(true);
            cs_enable_looking(true);
            print("343 guilty spark: 'this mining-facility predates instalation alpha by several hundred years.'");
            cs_play_line("0900");
            print("343 guilty spark: 'it was retrofitted to research possible offensive and defensive measures against the flood.'");
            cs_play_line("0910");
            print("343 guilty spark: 'indeed, i designed and oversaw the construction of this facilitiy's various outbreak management systems.'");
            cs_play_line("0920");
            cs_approach_stop();
            cs_suppress_dialogue_global(false);
            this.monitor_done_talking = true;
            this.monitor_available = true;
        }

        [ScriptMethod(333, Lifecycle.CommandScript)]
        public async Task monitor_chat_02()
        {
            this.monitor_available = false;
            this.monitor_done_talking = false;
            cs_suppress_dialogue_global(true);
            cs_switch("monitor");
            await sleep(60);
            cs_start_approach_player(3F, 50F, 50F);
            cs_enable_moving(true);
            cs_enable_looking(true);
            print("343 guilty spark: 'the tether connecting the mine to the high-altitude suspension-grid was the primary failsafe.'");
            cs_play_line("0930");
            print("343 guilty spark: 'i'm glad that someone was aware of the necessary protocols and severed the tether locally.'");
            cs_play_line("0940");
            cs_approach_stop();
            cs_suppress_dialogue_global(false);
            this.monitor_done_talking = true;
            this.monitor_available = true;
        }

        [ScriptMethod(334, Lifecycle.CommandScript)]
        public async Task monitor_chat_03()
        {
            this.monitor_available = false;
            this.monitor_done_talking = false;
            cs_suppress_dialogue_global(true);
            cs_switch("monitor");
            await sleep(60);
            cs_start_approach_player(3F, 50F, 50F);
            cs_enable_moving(true);
            cs_enable_looking(true);
            print("343 guilty spark: 'the flood will not survive once this mine descends into the liquid hydrogen core of the planet.'");
            cs_play_line("0950");
            await sleep(15);
            print("343 guilty spark: 'then again, neither will we. what a pity.'");
            cs_play_line("0960");
            cs_approach_stop();
            cs_suppress_dialogue_global(false);
            this.monitor_done_talking = true;
            this.monitor_available = true;
        }

        [ScriptMethod(335, Lifecycle.Dormant)]
        public async Task monitor_chatting()
        {
            await sleep(1800);
            await sleep_until(async () => this.boss_done_talking == true);
            cs_run_command_script(monitor1.Squad, new ScriptMethodReference(monitor_chat_01));
            await sleep_until(async () => this.monitor_done_talking == true);
            await sleep(3600);
            await sleep_until(async () => this.boss_done_talking == true);
            cs_run_command_script(monitor1.Squad, new ScriptMethodReference(monitor_chat_02));
            await sleep_until(async () => this.monitor_done_talking == true);
            await sleep(3600);
            await sleep_until(async () => this.boss_done_talking == true);
            cs_run_command_script(monitor1.Squad, new ScriptMethodReference(monitor_chat_03));
        }

        [ScriptMethod(336, Lifecycle.CommandScript)]
        public async Task monitor_flit_01()
        {
            cs_fly_to(GetReference<ISpatialPoint>("monitor_wander/p0"));
            this.monitor_available = true;
        }

        [ScriptMethod(337, Lifecycle.CommandScript)]
        public async Task monitor_flit_02()
        {
            cs_fly_to(GetReference<ISpatialPoint>("monitor_wander/p1"));
            this.monitor_available = true;
        }

        [ScriptMethod(338, Lifecycle.CommandScript)]
        public async Task monitor_flit_03()
        {
            cs_fly_to(GetReference<ISpatialPoint>("monitor_wander/p2"));
            this.monitor_available = true;
        }

        [ScriptMethod(339, Lifecycle.CommandScript)]
        public async Task monitor_flit_04()
        {
            cs_fly_to(GetReference<ISpatialPoint>("monitor_wander/p3"));
            this.monitor_available = true;
        }

        [ScriptMethod(340, Lifecycle.CommandScript)]
        public async Task monitor_flit_05()
        {
            cs_fly_to(GetReference<ISpatialPoint>("monitor_wander/p4"));
            this.monitor_available = true;
        }

        [ScriptMethod(341, Lifecycle.CommandScript)]
        public async Task monitor_flit_06()
        {
            cs_fly_to(GetReference<ISpatialPoint>("monitor_wander/p5"));
            this.monitor_available = true;
        }

        [ScriptMethod(342, Lifecycle.CommandScript)]
        public async Task monitor_flit_07()
        {
            cs_fly_to(GetReference<ISpatialPoint>("monitor_wander/p6"));
            this.monitor_available = true;
        }

        [ScriptMethod(343, Lifecycle.CommandScript)]
        public async Task monitor_flit_08()
        {
            cs_fly_to(GetReference<ISpatialPoint>("monitor_wander/p7"));
            this.monitor_available = true;
        }

        [ScriptMethod(344, Lifecycle.CommandScript)]
        public async Task monitor_flit_09()
        {
            cs_fly_to(GetReference<ISpatialPoint>("monitor_wander/p8"));
            this.monitor_available = true;
        }

        [ScriptMethod(345, Lifecycle.CommandScript)]
        public async Task monitor_flit_10()
        {
            cs_fly_to(GetReference<ISpatialPoint>("monitor_wander/p9"));
            this.monitor_available = true;
        }

        [ScriptMethod(346, Lifecycle.CommandScript)]
        public async Task monitor_flit_11()
        {
            cs_fly_to(GetReference<ISpatialPoint>("monitor_wander/p10"));
            this.monitor_available = true;
        }

        [ScriptMethod(347, Lifecycle.CommandScript)]
        public async Task monitor_flit_12()
        {
            cs_fly_to(GetReference<ISpatialPoint>("monitor_wander/p11"));
            this.monitor_available = true;
        }

        [ScriptMethod(348, Lifecycle.CommandScript)]
        public async Task monitor_flit_13()
        {
            cs_fly_to(GetReference<ISpatialPoint>("monitor_wander/p12"));
            this.monitor_available = true;
        }

        [ScriptMethod(349, Lifecycle.CommandScript)]
        public async Task monitor_flit_14()
        {
            cs_fly_to(GetReference<ISpatialPoint>("monitor_wander/p13"));
            this.monitor_available = true;
        }

        [ScriptMethod(350, Lifecycle.CommandScript)]
        public async Task monitor_flit_15()
        {
            cs_fly_to(GetReference<ISpatialPoint>("monitor_wander/p14"));
            this.monitor_available = true;
        }

        [ScriptMethod(351, Lifecycle.CommandScript)]
        public async Task monitor_flit_16()
        {
            cs_fly_to(GetReference<ISpatialPoint>("monitor_wander/p15"));
            this.monitor_available = true;
        }

        [ScriptMethod(352, Lifecycle.CommandScript)]
        public async Task monitor_flit_17()
        {
            cs_fly_to(GetReference<ISpatialPoint>("monitor_wander/p16"));
            this.monitor_available = true;
        }

        [ScriptMethod(353, Lifecycle.CommandScript)]
        public async Task monitor_flit_18()
        {
            cs_fly_to(GetReference<ISpatialPoint>("monitor_wander/p17"));
            this.monitor_available = true;
        }

        [ScriptMethod(354, Lifecycle.CommandScript)]
        public async Task monitor_flit_19()
        {
            cs_fly_to(GetReference<ISpatialPoint>("monitor_wander/p18"));
            this.monitor_available = true;
        }

        [ScriptMethod(355, Lifecycle.CommandScript)]
        public async Task monitor_flit_20()
        {
            cs_fly_to(GetReference<ISpatialPoint>("monitor_wander/p19"));
            this.monitor_available = true;
        }

        [ScriptMethod(356, Lifecycle.Dormant)]
        public async Task monitor_flitting()
        {
            await sleep_until(async () =>
            {
                begin_random(async () =>
                {
                    if (this.monitor_available == true)
                    {
                        cs_run_command_script(monitor1.Squad, new ScriptMethodReference(monitor_flit_01));
                        await sleep(5);
                        await sleep_until(async () => this.monitor_available == true);
                    }
                }, 
                    async () =>
                {
                    if (this.monitor_available == true)
                    {
                        cs_run_command_script(monitor1.Squad, new ScriptMethodReference(monitor_flit_02));
                        await sleep(5);
                        await sleep_until(async () => this.monitor_available == true);
                    }
                }, 
                    async () =>
                {
                    if (this.monitor_available == true)
                    {
                        cs_run_command_script(monitor1.Squad, new ScriptMethodReference(monitor_flit_03));
                        await sleep(5);
                        await sleep_until(async () => this.monitor_available == true);
                    }
                }, 
                    async () =>
                {
                    if (this.monitor_available == true)
                    {
                        cs_run_command_script(monitor1.Squad, new ScriptMethodReference(monitor_flit_04));
                        await sleep(5);
                        await sleep_until(async () => this.monitor_available == true);
                    }
                }, 
                    async () =>
                {
                    if (this.monitor_available == true)
                    {
                        cs_run_command_script(monitor1.Squad, new ScriptMethodReference(monitor_flit_05));
                        await sleep(5);
                        await sleep_until(async () => this.monitor_available == true);
                    }
                }, 
                    async () =>
                {
                    if (this.monitor_available == true)
                    {
                        cs_run_command_script(monitor1.Squad, new ScriptMethodReference(monitor_flit_06));
                        await sleep(5);
                        await sleep_until(async () => this.monitor_available == true);
                    }
                }, 
                    async () =>
                {
                    if (this.monitor_available == true)
                    {
                        cs_run_command_script(monitor1.Squad, new ScriptMethodReference(monitor_flit_07));
                        await sleep(5);
                        await sleep_until(async () => this.monitor_available == true);
                    }
                }, 
                    async () =>
                {
                    if (this.monitor_available == true)
                    {
                        cs_run_command_script(monitor1.Squad, new ScriptMethodReference(monitor_flit_08));
                        await sleep(5);
                        await sleep_until(async () => this.monitor_available == true);
                    }
                }, 
                    async () =>
                {
                    if (this.monitor_available == true)
                    {
                        cs_run_command_script(monitor1.Squad, new ScriptMethodReference(monitor_flit_09));
                        await sleep(5);
                        await sleep_until(async () => this.monitor_available == true);
                    }
                }, 
                    async () =>
                {
                    if (this.monitor_available == true)
                    {
                        cs_run_command_script(monitor1.Squad, new ScriptMethodReference(monitor_flit_10));
                        await sleep(5);
                        await sleep_until(async () => this.monitor_available == true);
                    }
                }, 
                    async () =>
                {
                    if (this.monitor_available == true)
                    {
                        cs_run_command_script(monitor1.Squad, new ScriptMethodReference(monitor_flit_11));
                        await sleep(5);
                        await sleep_until(async () => this.monitor_available == true);
                    }
                }, 
                    async () =>
                {
                    if (this.monitor_available == true)
                    {
                        cs_run_command_script(monitor1.Squad, new ScriptMethodReference(monitor_flit_12));
                        await sleep(5);
                        await sleep_until(async () => this.monitor_available == true);
                    }
                }, 
                    async () =>
                {
                    if (this.monitor_available == true)
                    {
                        cs_run_command_script(monitor1.Squad, new ScriptMethodReference(monitor_flit_13));
                        await sleep(5);
                        await sleep_until(async () => this.monitor_available == true);
                    }
                }, 
                    async () =>
                {
                    if (this.monitor_available == true)
                    {
                        cs_run_command_script(monitor1.Squad, new ScriptMethodReference(monitor_flit_14));
                        await sleep(5);
                        await sleep_until(async () => this.monitor_available == true);
                    }
                }, 
                    async () =>
                {
                    if (this.monitor_available == true)
                    {
                        cs_run_command_script(monitor1.Squad, new ScriptMethodReference(monitor_flit_15));
                        await sleep(5);
                        await sleep_until(async () => this.monitor_available == true);
                    }
                }, 
                    async () =>
                {
                    if (this.monitor_available == true)
                    {
                        cs_run_command_script(monitor1.Squad, new ScriptMethodReference(monitor_flit_16));
                        await sleep(5);
                        await sleep_until(async () => this.monitor_available == true);
                    }
                }, 
                    async () =>
                {
                    if (this.monitor_available == true)
                    {
                        cs_run_command_script(monitor1.Squad, new ScriptMethodReference(monitor_flit_17));
                        await sleep(5);
                        await sleep_until(async () => this.monitor_available == true);
                    }
                }, 
                    async () =>
                {
                    if (this.monitor_available == true)
                    {
                        cs_run_command_script(monitor1.Squad, new ScriptMethodReference(monitor_flit_18));
                        await sleep(5);
                        await sleep_until(async () => this.monitor_available == true);
                    }
                }, 
                    async () =>
                {
                    if (this.monitor_available == true)
                    {
                        cs_run_command_script(monitor1.Squad, new ScriptMethodReference(monitor_flit_19));
                        await sleep(5);
                        await sleep_until(async () => this.monitor_available == true);
                    }
                }, 
                    async () =>
                {
                    if (this.monitor_available == true)
                    {
                        cs_run_command_script(monitor1.Squad, new ScriptMethodReference(monitor_flit_20));
                        await sleep(5);
                        await sleep_until(async () => this.monitor_available == true);
                    }
                });
                return false;
            });
        }

        [ScriptMethod(357, Lifecycle.Static)]
        public async Task boss_fight_deletion()
        {
            await sleep_until(async () => volume_test_objects(vol_boss_delete_r, ai_actors(hl_boss_random.Squad)) == true || volume_test_objects(vol_boss_delete_l, ai_actors(hl_boss_random.Squad)) == true || volume_test_objects(vol_boss_delete_c1, ai_actors(hl_boss_random.Squad)) == true || volume_test_objects(vol_boss_delete_c2, ai_actors(hl_boss_random.Squad)) == true, 30, 900);
            if (volume_test_objects(vol_boss_delete_r, ai_actors(hl_boss_random.Squad)) == false && volume_test_objects(vol_boss_delete_l, ai_actors(hl_boss_random.Squad)) == false && volume_test_objects(vol_boss_delete_c1, ai_actors(hl_boss_random.Squad)) == false && volume_test_objects(vol_boss_delete_c2, ai_actors(hl_boss_random.Squad)) == false)
            {
                effect_new_on_object_marker(GetTag<EffectTag>("effects\\scenarios\\objects\\solo\\alphagasgiant\\holo_drone\\drone_death", 3920431159U), list_get(ai_actors(hl_boss_random.Squad), 0), "");
                object_set_scale(list_get(ai_actors(hl_boss_random.Squad), 0), 0.1F, 30);
                await sleep(30);
            }

            ai_erase(hl_boss_random.Squad);
        }

        [ScriptMethod(358, Lifecycle.Dormant)]
        public async Task holo1_deleteme()
        {
            await sleep_until(async () =>
            {
                await sleep_until(async () => (short)ai_living_count(hl_boss_holo_random_01.Squad) == 0 || this.holo_drones_nuke == true);
                object_set_scale(this.holo1, 0.1F, 30);
                effect_new_on_object_marker(this.holo_death, this.holo1, "body");
                await sleep(15);
                object_destroy(this.holo1);
                return false;
            });
        }

        [ScriptMethod(359, Lifecycle.Dormant)]
        public async Task holo2_deleteme()
        {
            await sleep_until(async () => (short)ai_living_count(hl_boss_holo_random_01.Squad) == 1);
            object_set_scale(this.holo2, 0.1F, 30);
            effect_new_on_object_marker(this.holo_death, this.holo2, "body");
            await sleep(15);
            object_destroy(this.holo2);
        }

        [ScriptMethod(360, Lifecycle.Dormant)]
        public async Task holo3_deleteme()
        {
            await sleep_until(async () => (short)ai_living_count(hl_boss_holo_random_03.Squad) == 2);
            object_set_scale(this.holo3, 0.1F, 30);
            effect_new_on_object_marker(this.holo_death, this.holo3, "body");
            await sleep(15);
            object_destroy(this.holo3);
        }

        [ScriptMethod(361, Lifecycle.Dormant)]
        public async Task holo4_deleteme()
        {
            await sleep_until(async () => (short)ai_living_count(hl_boss_holo_random_01.Squad) == 3);
            object_set_scale(this.holo4, 0.1F, 30);
            effect_new_on_object_marker(this.holo_death, this.holo4, "body");
            await sleep(15);
            object_destroy(this.holo4);
        }

        [ScriptMethod(362, Lifecycle.Static)]
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

            await sleep_until(async () =>
            {
                await sleep_until(async () => object_get_shield(list_get(ai_actors(hl_boss_random.Squad), 0)) <= 0F);
                if (this.hl_times_dead < this.hl_lives_total)
                {
                    ai_set_orders(hl_boss_random.Squad, hole_up);
                    cs_run_command_script(hl_boss_random.Squad, new ScriptMethodReference(hack));
                    ai_kill(holo_drones);
                    await this.boss_fight_deletion();
                    this.hl_times_dead = (short)(this.hl_times_dead + 1);
                    ai_place(hl_boss_random.Squad, 1);
                    ai_cannot_die(hl_boss_random.Squad, true);
                    this.heretic_leader = list_get(ai_actors(hl_boss_random.Squad), 0);
                    if (this.hl_times_dead == this.hl_lives_total)
                    {
                        ai_cannot_die(boss_fight_heretic_leader.Squad, false);
                    }
                    else
                    {
                        ai_cannot_die(boss_fight_heretic_leader.Squad, true);
                    }

                    if (this.hl_times_dead == 1)
                    {
                        cs_run_command_script(hl_boss_random.Squad, new ScriptMethodReference(hl_boss_chat_01));
                    }

                    if (this.hl_times_dead == 2)
                    {
                        cs_run_command_script(hl_boss_random.Squad, new ScriptMethodReference(hl_boss_chat_02));
                    }

                    if (this.hl_times_dead == 3)
                    {
                        cs_run_command_script(hl_boss_random.Squad, new ScriptMethodReference(hl_boss_chat_03));
                    }

                    await sleep(60);
                    await sleep_until(async () => this.boss_done_talking == true);
                    game_save();
                    begin_random(async () =>
                    {
                        if ((short)ai_living_count(holo_drones) < this.hl_drone_total)
                        {
                            ai_place(hl_boss_holo_random_01.Squad, 1);
                        }
                    }, 
                        async () =>
                    {
                        if ((short)ai_living_count(holo_drones) < this.hl_drone_total)
                        {
                            ai_place(hl_boss_holo_random_02.Squad, 1);
                        }
                    }, 
                        async () =>
                    {
                        if ((short)ai_living_count(holo_drones) < this.hl_drone_total)
                        {
                            ai_place(hl_boss_holo_random_03.Squad, 1);
                        }
                    }, 
                        async () =>
                    {
                        if ((short)ai_living_count(holo_drones) < this.hl_drone_total)
                        {
                            ai_place(hl_boss_holo_random_04.Squad, 1);
                        }
                    });
                    this.hl_drone_total = (short)(this.hl_drone_total + 1);
                    ai_set_orders(hl_boss_random.Squad, boss_fight_hl_center);
                    ai_set_orders(hl_boss_holo_random_01.Squad, boss_fight_hl_center);
                    ai_set_orders(hl_boss_holo_random_02.Squad, boss_fight_hl_center);
                    ai_set_orders(hl_boss_holo_random_03.Squad, boss_fight_hl_center);
                    ai_set_orders(hl_boss_holo_random_04.Squad, boss_fight_hl_center);
                }

                return this.hl_times_dead == this.hl_lives_total;
            });
        }

        [ScriptMethod(363, Lifecycle.Dormant)]
        public async Task toys()
        {
            await sleep_until(async () =>
            {
                begin_random(async () => await sleep(600), 
                    async () => object_create_anew(toy01), 
                    async () => await sleep(600), 
                    async () => object_create_anew(toy02), 
                    async () => await sleep(600), 
                    async () => object_create_anew(toy03), 
                    async () => await sleep(600), 
                    async () => object_create_anew(toy04), 
                    async () => await sleep(600), 
                    async () => object_create_anew(toy05), 
                    async () => await sleep(600), 
                    async () => object_create_anew(toy06), 
                    async () => await sleep(600), 
                    async () => object_create_anew(toy07), 
                    async () => await sleep(600), 
                    async () => object_create_anew(toy08), 
                    async () => await sleep(600), 
                    async () => object_create_anew(toy09), 
                    async () => await sleep(600), 
                    async () => object_create_anew(toy10), 
                    async () => await sleep(600), 
                    async () => object_create_anew(toy11), 
                    async () => await sleep(600), 
                    async () => object_create_anew(toy12), 
                    async () => await sleep(600), 
                    async () => object_create_anew(toy13), 
                    async () => await sleep(600), 
                    async () => object_create_anew(toy14), 
                    async () => await sleep(600), 
                    async () => object_create_anew(toy15), 
                    async () => await sleep(600), 
                    async () => object_create_anew(toy16), 
                    async () => await sleep(600), 
                    async () => object_create_anew(toy17), 
                    async () => await sleep(600), 
                    async () => object_create_anew(toy18));
                return false;
            });
        }

        [ScriptMethod(364, Lifecycle.Dormant)]
        public async Task hangar_secondtime_start()
        {
            await sleep_until(async () => this.plummeting == true && volume_test_objects(vol_hangar_reenter, players()) == true);
            device_operates_automatically_set(hangar_exit.Entity, true);
            ai_place(heretic_leader_hangar.Squad);
            cs_run_command_script(heretic_leader_hangar.Squad, new ScriptMethodReference(long_pause));
            ai_cannot_die(heretic_leader_hangar.Squad, true);
            await sleep_until(async () => this.plummeting == true && volume_test_objects(vol_hangar_cutscene_start, players()) == true);
            await this.cinematic_fade_to_white();
            sleep_forever(new ScriptMethodReference(other_hall_fx));
            sleep_forever(new ScriptMethodReference(underhangar_fx_01));
            sleep_forever(new ScriptMethodReference(underhangar_fx_02));
            sleep_forever(new ScriptMethodReference(bottling_fx_01));
            sleep_forever(new ScriptMethodReference(bottling_fx_02));
            sleep_forever(new ScriptMethodReference(bottling_fx_03));
            sleep_forever(new ScriptMethodReference(bottling_fx_04));
            sleep_forever(new ScriptMethodReference(bottling_fx_05));
            sleep_forever(new ScriptMethodReference(halls_up_01));
            sleep_forever(new ScriptMethodReference(halls_up_02));
            sleep_forever(new ScriptMethodReference(halls_up_03));
            sleep_forever(new ScriptMethodReference(halls_up_04));
            sleep_forever(new ScriptMethodReference(halls_up_05));
            sleep_forever(new ScriptMethodReference(halls_up_06));
            sleep_forever(new ScriptMethodReference(halls_up_07));
            ai_erase_all();
            object_teleport(await this.player0(), player0_hide2);
            object_teleport(await this.player1(), player1_hide2);
            if (await this.cinematic_skip_start())
            {
                await this.c04_outro1();
            }

            await this.cinematic_skip_stop();
            sound_suppress_ambience_update_on_revert();
            sound_class_set_gain("amb", 0F, 0);
            await sleep(1);
            sound_class_set_gain("amb", 1F, 15);
            await sleep(2);
            object_teleport(await this.player0(), player0_hangar);
            object_teleport(await this.player1(), player1_hangar);
            wake(new ScriptMethodReference(hangar_fx));
            ai_place(monitor1.Squad);
            ai_place(boss_fight_heretic_leader.Squad);
            ai_migrate(boss_fight_heretic_leader.Squad, hl_boss_random.Squad);
            ai_cannot_die(hl_boss_random.Squad, true);
            ai_place(boss_fight_hl_hologram_01.Squad);
            ai_migrate(boss_fight_hl_hologram_01.Squad, hl_boss_holo_random_01.Squad);
            ai_place(boss_fight_hl_hologram_02.Squad);
            ai_migrate(boss_fight_hl_hologram_02.Squad, hl_boss_holo_random_02.Squad);
            device_operates_automatically_set(hangar_exit.Entity, false);
            wake(new ScriptMethodReference(toys));
            camera_control(false);
            await sleep(1);
            await cache_block_for_one_frame();
            await sleep(1);
            await this.cinematic_fade_from_white();
            wake(new ScriptMethodReference(objective_dogfight_clear));
            wake(new ScriptMethodReference(objective_hl_set));
            data_mine_set_mission_segment("04b_24_boss_fight_01");
            game_save_immediate();
            wake(new ScriptMethodReference(monitor_chatting));
            wake(new ScriptMethodReference(monitor_flitting));
            await this.hl_respawner();
            ai_cannot_die(hl_boss_random.Squad, false);
            await sleep_until(async () => (short)ai_living_count(hl_boss_random.Squad) == 0);
            this.final_hl_boss_dead = true;
            ai_kill_silent(holo_drones);
            this.holo_drones_nuke = true;
            await sleep(120);
            if (await this.player_count() <= 0)
            {
                sleep_forever();
            }

            await this.cinematic_fade_to_white();
            object_teleport(await this.player0(), player0_hide2);
            object_teleport(await this.player1(), player1_hide2);
            object_destroy(this.heretic_leader);
            ai_erase(monitor1.Squad);
            ai_kill_silent(all_enemies);
            if (await this.cinematic_skip_start())
            {
                await this.c04_outro2();
            }

            await this.cinematic_skip_stop();
            await sleep(2);
            await this.playtest_mission();
            await sleep(2);
            game_won();
        }

        [ScriptMethod(365, Lifecycle.Static)]
        public async Task sleep_intro()
        {
            sleep_forever(new ScriptMethodReference(arm_02_entry_start));
        }

        [ScriptMethod(366, Lifecycle.Static)]
        public async Task sleep_disposal()
        {
            sleep_forever(new ScriptMethodReference(disposal_chamber_start));
            sleep_forever(new ScriptMethodReference(disposal_infection_spawn));
            sleep_forever(new ScriptMethodReference(spec_ops_reborn));
        }

        [ScriptMethod(367, Lifecycle.Static)]
        public async Task sleep_silo()
        {
            sleep_forever(new ScriptMethodReference(silo_start));
            sleep_forever(new ScriptMethodReference(silo_hall_flood_spawner));
            sleep_forever(new ScriptMethodReference(elev_go));
            sleep_forever(new ScriptMethodReference(to_flood_lab));
            sleep_forever(new ScriptMethodReference(silo_commander_reminder));
            sleep_forever(new ScriptMethodReference(silo_killer));
            sleep_forever(new ScriptMethodReference(silo_sentinel_spawner));
            sleep_forever(new ScriptMethodReference(silo_flood_spawner));
            sleep_forever(new ScriptMethodReference(silo_saving));
        }

        [ScriptMethod(368, Lifecycle.Static)]
        public async Task sleep_lab()
        {
            sleep_forever(new ScriptMethodReference(to_flood_lab));
            sleep_forever(new ScriptMethodReference(flood_lab_start));
            sleep_forever(new ScriptMethodReference(lab_barricades));
            sleep_forever(new ScriptMethodReference(lab_wave_new_01));
            sleep_forever(new ScriptMethodReference(lab_wave_new_02));
            sleep_forever(new ScriptMethodReference(famine_flavor));
        }

        [ScriptMethod(369, Lifecycle.Static)]
        public async Task sleep_wraparound()
        {
            sleep_forever(new ScriptMethodReference(bridge_start));
            sleep_forever(new ScriptMethodReference(bridge_phantom_arrives));
            sleep_forever(new ScriptMethodReference(bridge_reminder));
            sleep_forever(new ScriptMethodReference(wraparound_right));
            sleep_forever(new ScriptMethodReference(wraparound_left));
            sleep_forever(new ScriptMethodReference(research_arm_bsp_swap));
        }

        [ScriptMethod(370, Lifecycle.Static)]
        public async Task sleep_control()
        {
            sleep_forever(new ScriptMethodReference(control_room_start));
            sleep_forever(new ScriptMethodReference(control_commander_reminder));
            sleep_forever(new ScriptMethodReference(control_bug_out));
            sleep_forever(new ScriptMethodReference(control_flood_spawn));
            sleep_forever(new ScriptMethodReference(wind));
            sleep_forever(new ScriptMethodReference(hologram_toggle));
            sleep_forever(new ScriptMethodReference(hl_killer));
        }

        [ScriptMethod(371, Lifecycle.Static)]
        public async Task sleep_cableroom()
        {
            sleep_forever(new ScriptMethodReference(cable_room_start));
            sleep_forever(new ScriptMethodReference(cable_a_health));
            sleep_forever(new ScriptMethodReference(cable_b_health));
            sleep_forever(new ScriptMethodReference(cable_c_health));
            sleep_forever(new ScriptMethodReference(cable_nav_a));
            sleep_forever(new ScriptMethodReference(cable_nav_b));
            sleep_forever(new ScriptMethodReference(cable_nav_c));
            sleep_forever(new ScriptMethodReference(cable_sentinel_spawner));
            sleep_forever(new ScriptMethodReference(cable_flood_spawner));
            sleep_forever(new ScriptMethodReference(grav_test));
            sleep_forever(new ScriptMethodReference(cable_invulnerable));
            sleep_forever(new ScriptMethodReference(cableroom_suck_killer));
            sleep_forever(new ScriptMethodReference(cableroom_junk_spawn));
            sleep_forever(new ScriptMethodReference(cableroom_commander_reminder));
            sleep_forever(new ScriptMethodReference(cableroom_killer));
            sleep_forever(new ScriptMethodReference(cableroom_junk_killer));
            sleep_forever(new ScriptMethodReference(croom_exit));
        }

        [ScriptMethod(372, Lifecycle.Static)]
        public async Task sleep_control_return()
        {
            sleep_forever(new ScriptMethodReference(control_room_return));
            sleep_forever(new ScriptMethodReference(control_return_flood_spawn));
        }

        [ScriptMethod(373, Lifecycle.Static)]
        public async Task sleep_powercore()
        {
            sleep_forever(new ScriptMethodReference(power_core_start));
        }

        [ScriptMethod(374, Lifecycle.Static)]
        public async Task sleep_dogfight()
        {
            sleep_forever(new ScriptMethodReference(dogfight_secondtime_start));
            sleep_forever(new ScriptMethodReference(banshee_killer_00));
            sleep_forever(new ScriptMethodReference(banshee_killer_01));
        }

        [ScriptMethod(375, Lifecycle.Static)]
        public async Task sleep_bottling_return()
        {
            sleep_forever(new ScriptMethodReference(bottling_secondtime_start));
            sleep_forever(new ScriptMethodReference(bottling_return_s_respawner));
            sleep_forever(new ScriptMethodReference(bottling_return_cf_respawner));
            sleep_forever(new ScriptMethodReference(bottling_return_ca_respawner));
            sleep_forever(new ScriptMethodReference(to_underhangar_secondtime));
            sleep_forever(new ScriptMethodReference(bottling_return_commander));
        }

        [ScriptMethod(376, Lifecycle.Static)]
        public async Task sleep_underhangar_return()
        {
            sleep_forever(new ScriptMethodReference(underhangar_secondtime_start));
            sleep_forever(new ScriptMethodReference(to_hangar_secondtime));
            sleep_forever(new ScriptMethodReference(underhangar_return_commander));
        }

        [ScriptMethod(377, Lifecycle.Startup)]
        public async Task mission()
        {
            await this.cinematic_snap_to_white();
            if (volume_test_objects(vol_arm_02_lz, players()) == true)
            {
                sound_suppress_ambience_update_on_revert();
                if (await this.cinematic_skip_start())
                {
                    await this.c04_intra0();
                }

                await this.cinematic_skip_stop();
            }

            await sleep(2);
            switch_bsp(3);
            await sleep(2);
            ai_allegiance(player, covenant);
            ai_allegiance(heretic, sentinel);
            ai_allegiance(player, prophet);
            ai_allegiance(heretic, prophet);
            ai_allegiance(sentinel, prophet);
            objectives_clear();
            await this.prep_return_from_intro();
            camera_control(false);
            await sleep(1);
            await cache_block_for_one_frame();
            await sleep(1);
            wake(new ScriptMethodReference(_04b_title0));
            wake(new ScriptMethodReference(objective_labs_set));
            wake(new ScriptMethodReference(kill_volumes));
            wake(new ScriptMethodReference(arm_02_entry_start));
            await sleep_until(async () => volume_test_objects(vol_disposal_enter, players()) == true);
            wake(new ScriptMethodReference(disposal_chamber_start));
            wake(new ScriptMethodReference(silo_start));
            wake(new ScriptMethodReference(to_flood_lab));
            wake(new ScriptMethodReference(flood_lab_start));
            await this.sleep_intro();
            await sleep_until(async () => (short)structure_bsp_index() == 0);
            wake(new ScriptMethodReference(bridge_start));
            wake(new ScriptMethodReference(control_room_start));
            await this.sleep_disposal();
            await this.sleep_silo();
            await this.sleep_lab();
            wake(new ScriptMethodReference(objective_labs_clear));
            wake(new ScriptMethodReference(objective_control_set));
            await sleep_until(async () => (short)structure_bsp_index() == 2);
            wake(new ScriptMethodReference(cable_room_start));
            await this.sleep_wraparound();
            await this.sleep_control();
            await sleep_until(async () => (short)structure_bsp_index() == 1);
            wake(new ScriptMethodReference(control_room_return));
            wake(new ScriptMethodReference(power_core_start));
            wake(new ScriptMethodReference(dogfight_secondtime_start));
            await this.sleep_cableroom();
            await sleep_until(async () => volume_test_objects(vol_arm_01_return, players()) == true, 1);
            wake(new ScriptMethodReference(bottling_secondtime_start));
            wake(new ScriptMethodReference(to_underhangar_secondtime));
            wake(new ScriptMethodReference(underhangar_secondtime_start));
            wake(new ScriptMethodReference(to_hangar_secondtime));
            wake(new ScriptMethodReference(hangar_secondtime_start));
            await this.sleep_control_return();
            await this.sleep_powercore();
            await this.sleep_dogfight();
        }

        [ScriptMethod(378, Lifecycle.Dormant)]
        public async Task _04_intra0_predict()
        {
            await sleep(1);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\04a_gasgiant\\alphagasgiant"), 62, false);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\04a_gasgiant\\alphagasgiant"), 63, false);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\04a_gasgiant\\alphagasgiant"), 51, true);
            predict_model_section(GetTag<RenderModelTag>("scenarios\\objects\\forerunner\\industrial\\doors\\door_tron_lg\\door_tron_lg", 3874227574U), 1);
            predict_model_section(GetTag<RenderModelTag>("scenarios\\objects\\cinematics\\cinematic_anchor\\cinematic_anchor", 3875603851U), 0);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\04a_gasgiant\\alphagasgiant"), 15, true);
            predict_model_section(GetTag<RenderModelTag>("scenarios\\skies\\solo\\alphagasgiant\\alphagasgiant", 3783000070U), 0);
            predict_model_section(GetTag<RenderModelTag>("scenarios\\skies\\solo\\alphagasgiant\\alphagasgiant", 3783000070U), 1);
            predict_model_section(GetTag<RenderModelTag>("scenarios\\skies\\solo\\alphagasgiant\\alphagasgiant", 3783000070U), 2);
            predict_model_section(GetTag<RenderModelTag>("scenarios\\skies\\solo\\alphagasgiant\\alphagasgiant", 3783000070U), 3);
            predict_model_section(GetTag<RenderModelTag>("scenarios\\skies\\solo\\alphagasgiant\\alphagasgiant", 3783000070U), 4);
            predict_model_section(GetTag<RenderModelTag>("scenarios\\skies\\solo\\alphagasgiant\\alphagasgiant", 3783000070U), 5);
            predict_model_section(GetTag<RenderModelTag>("scenarios\\skies\\solo\\alphagasgiant\\alphagasgiant", 3783000070U), 6);
            predict_model_section(GetTag<RenderModelTag>("scenarios\\skies\\solo\\alphagasgiant\\alphagasgiant", 3783000070U), 7);
            predict_model_section(GetTag<RenderModelTag>("scenarios\\skies\\solo\\alphagasgiant\\alphagasgiant", 3783000070U), 8);
            predict_model_section(GetTag<RenderModelTag>("scenarios\\skies\\solo\\alphagasgiant\\alphagasgiant", 3783000070U), 9);
            await sleep(9);
            predict_model_section(GetTag<RenderModelTag>("objects\\characters\\elite\\elite", 3876193684U), 25);
            predict_model_section(GetTag<RenderModelTag>("objects\\characters\\elite\\elite", 3876193684U), 30);
            predict_model_section(GetTag<RenderModelTag>("objects\\characters\\elite\\elite", 3876193684U), 27);
            predict_model_section(GetTag<RenderModelTag>("objects\\characters\\elite\\elite", 3876193684U), 32);
            predict_model_section(GetTag<RenderModelTag>("objects\\weapons\\rifle\\plasma_rifle\\plasma_rifle", 3795452100U), 3);
            await sleep(12);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\04a_gasgiant\\alphagasgiant"), 15, true);
            await sleep(4);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\04a_gasgiant\\alphagasgiant"), 15, true);
            await sleep(4);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\04a_gasgiant\\alphagasgiant"), 15, true);
            await sleep(2);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\04a_gasgiant\\alphagasgiant"), 61, false);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\04a_gasgiant\\alphagasgiant"), 38, false);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\04a_gasgiant\\alphagasgiant"), 12, true);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\04a_gasgiant\\alphagasgiant"), 14, true);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\04a_gasgiant\\alphagasgiant"), 15, true);
            predict_model_section(GetTag<RenderModelTag>("objects\\characters\\grunt\\grunt", 3880453589U), 20);
            predict_model_section(GetTag<RenderModelTag>("objects\\characters\\grunt\\grunt", 3880453589U), 21);
            predict_model_section(GetTag<RenderModelTag>("objects\\characters\\grunt\\grunt", 3880453589U), 22);
            predict_model_section(GetTag<RenderModelTag>("objects\\characters\\grunt\\grunt", 3880453589U), 23);
            predict_model_section(GetTag<RenderModelTag>("objects\\characters\\grunt\\grunt", 3880453589U), 24);
            predict_model_section(GetTag<RenderModelTag>("incompetent\\default_object", 3882223088U), 0);
            predict_model_section(GetTag<RenderModelTag>("objects\\characters\\elite\\elite", 3876193684U), 26);
            predict_model_section(GetTag<RenderModelTag>("objects\\weapons\\melee\\energy_blade\\energy_blade", 3786342457U), 4);
            predict_model_section(GetTag<RenderModelTag>("objects\\weapons\\melee\\energy_blade\\energy_blade", 3786342457U), 5);
            await sleep(145);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\04a_gasgiant\\alphagasgiant"), 51, true);
            await sleep(45);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\04a_gasgiant\\alphagasgiant"), 36, false);
            await sleep(1);
            predict_model_section(GetTag<RenderModelTag>("objects\\characters\\elite\\elite", 3876193684U), 26);
            predict_model_section(GetTag<RenderModelTag>("objects\\weapons\\melee\\energy_blade\\energy_blade", 3786342457U), 4);
            predict_model_section(GetTag<RenderModelTag>("objects\\weapons\\melee\\energy_blade\\energy_blade", 3786342457U), 5);
            await sleep(21);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\04a_gasgiant\\alphagasgiant"), 40, false);
            await sleep(14);
            predict_model_section(GetTag<RenderModelTag>("objects\\characters\\dervish\\dervish", 3882419699U), 8);
            predict_model_section(GetTag<RenderModelTag>("objects\\characters\\dervish\\dervish", 3882419699U), 10);
            await sleep(11);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\04a_gasgiant\\alphagasgiant"), 11, true);
            await sleep(2);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\04a_gasgiant\\alphagasgiant"), 60, false);
            await sleep(99);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\04a_gasgiant\\alphagasgiant"), 63, false);
            await sleep(31);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\04a_gasgiant\\alphagasgiant"), 51, true);
            await sleep(120);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\04a_gasgiant\\alphagasgiant"), 60, false);
        }

        [ScriptMethod(379, Lifecycle.Dormant)]
        public async Task _04_intra1_01_predict()
        {
            await sleep(1);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\04a_gasgiant\\alphagasgiant"), 63, false);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\04a_gasgiant\\alphagasgiant"), 67, false);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\04a_gasgiant\\alphagasgiant"), 51, true);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\04a_gasgiant\\alphagasgiant"), 54, true);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\04a_gasgiant\\alphagasgiant"), 15, true);
            predict_model_section(GetTag<RenderModelTag>("objects\\characters\\dervish\\fp\\fp", 3884254735U), 0);
            predict_model_section(GetTag<RenderModelTag>("objects\\characters\\dervish\\fp\\fp", 3884254735U), 1);
            predict_model_section(GetTag<RenderModelTag>("objects\\weapons\\melee\\energy_blade\\fp_energy_blade\\fp_energy_blade", 3794665656U), 0);
            predict_model_section(GetTag<RenderModelTag>("objects\\weapons\\melee\\energy_blade\\fp_energy_blade\\fp_energy_blade", 3794665656U), 1);
            predict_model_section(GetTag<RenderModelTag>("objects\\characters\\grunt\\grunt", 3880453589U), 15);
            predict_model_section(GetTag<RenderModelTag>("objects\\characters\\grunt\\grunt", 3880453589U), 16);
            predict_model_section(GetTag<RenderModelTag>("objects\\characters\\grunt\\grunt", 3880453589U), 17);
            predict_model_section(GetTag<RenderModelTag>("objects\\characters\\grunt\\grunt", 3880453589U), 18);
            predict_model_section(GetTag<RenderModelTag>("objects\\characters\\grunt\\grunt", 3880453589U), 19);
            predict_model_section(GetTag<RenderModelTag>("objects\\weapons\\pistol\\plasma_pistol\\plasma_pistol", 3816096255U), 0);
            predict_model_section(GetTag<RenderModelTag>("objects\\characters\\elite\\elite", 3876193684U), 16);
            predict_model_section(GetTag<RenderModelTag>("objects\\characters\\elite\\elite", 3876193684U), 21);
            predict_model_section(GetTag<RenderModelTag>("objects\\characters\\elite\\elite", 3876193684U), 18);
            predict_model_section(GetTag<RenderModelTag>("objects\\characters\\elite\\elite", 3876193684U), 23);
            predict_model_section(GetTag<RenderModelTag>("objects\\weapons\\rifle\\plasma_rifle\\plasma_rifle", 3795452100U), 0);
            predict_model_section(GetTag<RenderModelTag>("objects\\characters\\elite\\elite", 3876193684U), 17);
            predict_model_section(GetTag<RenderModelTag>("objects\\weapons\\melee\\energy_blade\\energy_blade", 3786342457U), 0);
            predict_model_section(GetTag<RenderModelTag>("objects\\weapons\\melee\\energy_blade\\energy_blade", 3786342457U), 1);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\04a_gasgiant\\alphagasgiant"), 45, true);
            await sleep(3);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\04a_gasgiant\\alphagasgiant"), 86, false);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\04a_gasgiant\\alphagasgiant"), 84, false);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\04a_gasgiant\\alphagasgiant"), 6, false);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\04a_gasgiant\\alphagasgiant"), 13, false);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\04a_gasgiant\\alphagasgiant"), 30, true);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\04a_gasgiant\\alphagasgiant"), 32, true);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\04a_gasgiant\\alphagasgiant"), 35, true);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\04a_gasgiant\\alphagasgiant"), 36, true);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\04a_gasgiant\\alphagasgiant"), 38, true);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\04a_gasgiant\\alphagasgiant"), 39, true);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\04a_gasgiant\\alphagasgiant"), 41, true);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\04a_gasgiant\\alphagasgiant"), 56, true);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\04a_gasgiant\\alphagasgiant"), 29, true);
            predict_model_section(GetTag<RenderModelTag>("scenarios\\objects\\forerunner\\industrial\\doors\\door_tron_lg_containment_shield\\door_tron_lg_containment_shield", 3884582420U), 0);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\04a_gasgiant\\alphagasgiant"), 64, false);
            predict_model_section(GetTag<RenderModelTag>("scenarios\\objects\\solo\\alphagasgiant\\central_chamber\\generator_a\\generator_a", 3885368864U), 0);
            predict_model_section(GetTag<RenderModelTag>("scenarios\\objects\\forerunner\\industrial\\wall_insertions\\channel_curcuit_a\\channel_curcuit_a", 3886941752U), 1);
            predict_model_section(GetTag<RenderModelTag>("scenarios\\objects\\forerunner\\industrial\\wall_insertions\\channel_curcuit_a\\channel_curcuit_a", 3886941752U), 2);
            predict_model_section(GetTag<RenderModelTag>("scenarios\\objects\\solo\\alphagasgiant\\gasgiant_hologram\\gasgiant_hologram", 3887203900U), 0);
            predict_model_section(GetTag<RenderModelTag>("scenarios\\objects\\forerunner\\industrial\\doors\\door_tron_sm\\door_tron_sm", 3887728196U), 0);
            predict_model_section(GetTag<RenderModelTag>("scenarios\\objects\\forerunner\\industrial\\doors\\door_tron_lg\\door_tron_lg", 3874227574U), 0);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\04a_gasgiant\\alphagasgiant"), 33, true);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\04a_gasgiant\\alphagasgiant"), 34, true);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\04a_gasgiant\\alphagasgiant"), 40, true);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\04a_gasgiant\\alphagasgiant"), 42, true);
            predict_model_section(GetTag<RenderModelTag>("scenarios\\objects\\forerunner\\industrial\\edge_trim\\platform_plates_a\\platform_plates_a", 3888055881U), 0);
            predict_model_section(GetTag<RenderModelTag>("scenarios\\objects\\solo\\alphagasgiant\\control_lift_up\\control_lift_up", 3888121418U), 0);
            predict_model_section(GetTag<RenderModelTag>("scenarios\\objects\\forerunner\\industrial\\controls\\temp_door_switch\\temp_door_switch", 3888186955U), 0);
            await sleep(3);
            predict_model_section(GetTag<RenderModelTag>("objects\\characters\\heretic\\heretic", 3888842325U), 9);
            predict_model_section(GetTag<RenderModelTag>("objects\\characters\\heretic\\heretic", 3888842325U), 10);
            predict_model_section(GetTag<RenderModelTag>("objects\\characters\\heretic\\heretic", 3888842325U), 12);
            predict_model_section(GetTag<RenderModelTag>("objects\\characters\\elite\\elite_jetpack\\elite_jetpack", 3889497695U), 2);
            predict_model_section(GetTag<RenderModelTag>("objects\\characters\\dervish\\dervish", 3882419699U), 8);
            predict_model_section(GetTag<RenderModelTag>("objects\\characters\\dervish\\dervish", 3882419699U), 10);
            predict_model_section(GetTag<RenderModelTag>("objects\\weapons\\rifle\\plasma_rifle\\plasma_rifle", 3795452100U), 0);
            await sleep(1);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\04a_gasgiant\\alphagasgiant"), 64, false);
            await sleep(3);
            predict_model_section(GetTag<RenderModelTag>("scenarios\\objects\\forerunner\\industrial\\holo_panels\\holo_generic\\holo_generic", 3890808435U), 0);
            await sleep(1);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\04a_gasgiant\\alphagasgiant"), 64, false);
            await sleep(2);
            predict_model_section(GetTag<RenderModelTag>("scenarios\\objects\\forerunner\\industrial\\holo_panels\\holo_small02\\holo_small02", 3891070583U), 0);
            await sleep(2);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\04a_gasgiant\\alphagasgiant"), 64, false);
            await sleep(8);
            predict_model_section(GetTag<RenderModelTag>("objects\\weapons\\rifle\\plasma_rifle\\plasma_rifle", 3795452100U), 1);
            await sleep(71);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\04a_gasgiant\\alphagasgiant"), 64, false);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\04a_gasgiant\\alphagasgiant"), 81, false);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\04a_gasgiant\\alphagasgiant"), 37, true);
            predict_model_section(GetTag<RenderModelTag>("objects\\weapons\\rifle\\plasma_rifle\\plasma_rifle", 3795452100U), 3);
        }

        [ScriptMethod(380, Lifecycle.Dormant)]
        public async Task _04_intra1_02_predict()
        {
            await sleep(2);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\04a_gasgiant\\alphagasgiant"), 6, false);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\04a_gasgiant\\alphagasgiant"), 13, false);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\04a_gasgiant\\alphagasgiant"), 30, true);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\04a_gasgiant\\alphagasgiant"), 35, true);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\04a_gasgiant\\alphagasgiant"), 36, true);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\04a_gasgiant\\alphagasgiant"), 38, true);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\04a_gasgiant\\alphagasgiant"), 39, true);
            predict_model_section(GetTag<RenderModelTag>("scenarios\\objects\\forerunner\\industrial\\wall_insertions\\channel_curcuit_a\\channel_curcuit_a", 3886941752U), 1);
            predict_model_section(GetTag<RenderModelTag>("scenarios\\objects\\solo\\alphagasgiant\\gasgiant_hologram\\gasgiant_hologram", 3887203900U), 1);
            await sleep(5);
            predict_model_section(GetTag<RenderModelTag>("objects\\characters\\elite\\elite", 3876193684U), 25);
            predict_model_section(GetTag<RenderModelTag>("objects\\characters\\elite\\elite", 3876193684U), 30);
            predict_model_section(GetTag<RenderModelTag>("objects\\characters\\elite\\elite", 3876193684U), 27);
            predict_model_section(GetTag<RenderModelTag>("objects\\characters\\elite\\elite", 3876193684U), 32);
            predict_model_section(GetTag<RenderModelTag>("objects\\weapons\\rifle\\plasma_rifle\\plasma_rifle", 3795452100U), 3);
            predict_model_section(GetTag<RenderModelTag>("objects\\characters\\elite\\elite", 3876193684U), 26);
            predict_model_section(GetTag<RenderModelTag>("objects\\weapons\\melee\\energy_blade\\energy_blade", 3786342457U), 4);
            predict_model_section(GetTag<RenderModelTag>("objects\\weapons\\melee\\energy_blade\\energy_blade", 3786342457U), 5);
            predict_model_section(GetTag<RenderModelTag>("objects\\characters\\dervish\\dervish", 3882419699U), 8);
            predict_model_section(GetTag<RenderModelTag>("objects\\characters\\dervish\\dervish", 3882419699U), 10);
            predict_model_section(GetTag<RenderModelTag>("objects\\weapons\\rifle\\plasma_rifle\\plasma_rifle", 3795452100U), 0);
            await sleep(3);
            predict_model_section(GetTag<RenderModelTag>("objects\\characters\\heretic\\heretic", 3888842325U), 9);
            predict_model_section(GetTag<RenderModelTag>("objects\\characters\\heretic\\heretic", 3888842325U), 10);
            predict_model_section(GetTag<RenderModelTag>("objects\\characters\\heretic\\heretic", 3888842325U), 12);
            predict_model_section(GetTag<RenderModelTag>("objects\\characters\\elite\\elite_jetpack\\elite_jetpack", 3889497695U), 2);
            await sleep(6);
            predict_model_section(GetTag<RenderModelTag>("objects\\characters\\elite\\elite_jetpack\\elite_jetpack", 3889497695U), 1);
            await sleep(36);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\04a_gasgiant\\alphagasgiant"), 13, false);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\04a_gasgiant\\alphagasgiant"), 32, true);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\04a_gasgiant\\alphagasgiant"), 40, true);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\04a_gasgiant\\alphagasgiant"), 41, true);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\04a_gasgiant\\alphagasgiant"), 56, true);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\04a_gasgiant\\alphagasgiant"), 29, true);
            predict_model_section(GetTag<RenderModelTag>("scenarios\\objects\\solo\\alphagasgiant\\central_chamber\\generator_a\\generator_a", 3885368864U), 0);
            predict_model_section(GetTag<RenderModelTag>("scenarios\\objects\\forerunner\\industrial\\doors\\door_tron_lg\\door_tron_lg", 3874227574U), 0);
            predict_model_section(GetTag<RenderModelTag>("scenarios\\objects\\forerunner\\industrial\\holo_panels\\holo_small02\\holo_small02", 3891070583U), 0);
            predict_model_section(GetTag<RenderModelTag>("scenarios\\objects\\forerunner\\industrial\\holo_panels\\holo_generic\\holo_generic", 3890808435U), 0);
            predict_model_section(GetTag<RenderModelTag>("scenarios\\objects\\solo\\alphagasgiant\\gasgiant_hologram\\gasgiant_hologram", 3887203900U), 1);
            predict_model_section(GetTag<RenderModelTag>("scenarios\\objects\\forerunner\\industrial\\doors\\door_tron_sm\\door_tron_sm", 3887728196U), 0);
            predict_model_section(GetTag<RenderModelTag>("scenarios\\objects\\solo\\alphagasgiant\\control_lift_up\\control_lift_up", 3888121418U), 0);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\04a_gasgiant\\alphagasgiant"), 33, true);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\04a_gasgiant\\alphagasgiant"), 34, true);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\04a_gasgiant\\alphagasgiant"), 42, true);
            predict_model_section(GetTag<RenderModelTag>("scenarios\\objects\\forerunner\\industrial\\edge_trim\\platform_plates_a\\platform_plates_a", 3888055881U), 0);
            predict_model_section(GetTag<RenderModelTag>("scenarios\\objects\\forerunner\\industrial\\controls\\temp_door_switch\\temp_door_switch", 3888186955U), 0);
            await sleep(42);
            predict_model_section(GetTag<RenderModelTag>("objects\\weapons\\rifle\\plasma_rifle\\plasma_rifle", 3795452100U), 2);
            await sleep(101);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\04a_gasgiant\\alphagasgiant"), 86, false);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\04a_gasgiant\\alphagasgiant"), 64, false);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\04a_gasgiant\\alphagasgiant"), 81, false);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\04a_gasgiant\\alphagasgiant"), 37, true);
            predict_model_section(GetTag<RenderModelTag>("objects\\characters\\heretic\\heretic", 3888842325U), 9);
            predict_model_section(GetTag<RenderModelTag>("objects\\characters\\heretic\\heretic", 3888842325U), 10);
            predict_model_section(GetTag<RenderModelTag>("objects\\characters\\heretic\\heretic", 3888842325U), 12);
            predict_model_section(GetTag<RenderModelTag>("objects\\characters\\elite\\elite_jetpack\\elite_jetpack", 3889497695U), 1);
            await sleep(144);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\04a_gasgiant\\alphagasgiant"), 6, false);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\04a_gasgiant\\alphagasgiant"), 35, true);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\04a_gasgiant\\alphagasgiant"), 38, true);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\04a_gasgiant\\alphagasgiant"), 40, true);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\04a_gasgiant\\alphagasgiant"), 56, true);
            predict_model_section(GetTag<RenderModelTag>("objects\\weapons\\rifle\\plasma_rifle\\plasma_rifle", 3795452100U), 0);
            predict_model_section(GetTag<RenderModelTag>("scenarios\\objects\\solo\\alphagasgiant\\gasgiant_hologram\\gasgiant_hologram", 3887203900U), 1);
            predict_model_section(GetTag<RenderModelTag>("scenarios\\objects\\forerunner\\industrial\\holo_panels\\holo_generic\\holo_generic", 3890808435U), 0);
            predict_model_section(GetTag<RenderModelTag>("scenarios\\objects\\forerunner\\industrial\\wall_insertions\\channel_curcuit_a\\channel_curcuit_a", 3886941752U), 2);
            await sleep(146);
            predict_model_section(GetTag<RenderModelTag>("objects\\weapons\\rifle\\plasma_rifle\\plasma_rifle", 3795452100U), 3);
        }

        [ScriptMethod(381, Lifecycle.Dormant)]
        public async Task _04_outro1_01_predict()
        {
            await sleep(5);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\04b_floodlab\\production_arm2"), 57, false);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\04b_floodlab\\production_arm2"), 1, false);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\04b_floodlab\\production_arm2"), 34, false);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\04b_floodlab\\production_arm2"), 31, false);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\04b_floodlab\\production_arm2"), 21, false);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\04b_floodlab\\production_arm2"), 27, false);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\04b_floodlab\\production_arm2"), 35, false);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\04b_floodlab\\production_arm2"), 0, true);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\04b_floodlab\\production_arm2"), 5, true);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\04b_floodlab\\production_arm2"), 6, true);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\04b_floodlab\\production_arm2"), 11, true);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\04b_floodlab\\production_arm2"), 12, true);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\04b_floodlab\\production_arm2"), 13, true);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\04b_floodlab\\production_arm2"), 19, true);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\04b_floodlab\\production_arm2"), 20, true);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\04b_floodlab\\production_arm2"), 21, true);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\04b_floodlab\\production_arm2"), 1, true);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\04b_floodlab\\production_arm2"), 4, true);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\04b_floodlab\\production_arm2"), 10, true);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\04b_floodlab\\production_arm2"), 14, true);
            predict_model_section(GetTag<RenderModelTag>("objects\\weapons\\grenade\\plasma_grenade\\plasma_grenade", 3891136120U), 0);
            predict_model_section(GetTag<RenderModelTag>("objects\\weapons\\pistol\\needler\\needler", 3848012774U), 0);
            predict_model_section(GetTag<RenderModelTag>("objects\\weapons\\pistol\\needler\\needler", 3848012774U), 1);
            predict_model_section(GetTag<RenderModelTag>("objects\\weapons\\rifle\\plasma_rifle\\plasma_rifle", 3795452100U), 0);
            predict_model_section(GetTag<RenderModelTag>("objects\\weapons\\support_low\\sentinel_gun\\sentinel_gun", 3863348432U), 0);
            predict_model_section(GetTag<RenderModelTag>("objects\\weapons\\rifle\\covenant_carbine\\covenant_carbine", 3828810433U), 0);
            predict_model_section(GetTag<RenderModelTag>("scenarios\\objects\\forerunner\\industrial\\controls\\temp_door_switch\\temp_door_switch", 3888186955U), 0);
            predict_model_section(GetTag<RenderModelTag>("scenarios\\objects\\forerunner\\industrial\\doors\\door_tron_sm\\door_tron_sm", 3887728196U), 0);
            predict_model_section(GetTag<RenderModelTag>("scenarios\\objects\\forerunner\\industrial\\doors\\door_tron_sm\\door_tron_sm", 3887728196U), 2);
            predict_model_section(GetTag<RenderModelTag>("scenarios\\objects\\forerunner\\industrial\\doors\\door_cargo_hangar_scenery\\door_cargo_hangar_scenery", 3891660416U), 0);
            predict_model_section(GetTag<RenderModelTag>("scenarios\\objects\\vehicles\\c_seraph\\c_seraph", 3891988101U), 0);
            predict_model_section(GetTag<RenderModelTag>("scenarios\\objects\\cinematics\\cinematic_anchor\\cinematic_anchor", 3875603851U), 0);
            predict_model_section(GetTag<RenderModelTag>("scenarios\\skies\\solo\\alphagasgiant\\gasgiant_rob", 3785621550U), 0);
            await sleep(2);
            predict_model_section(GetTag<RenderModelTag>("objects\\characters\\heretic\\heretic", 3888842325U), 9);
            predict_model_section(GetTag<RenderModelTag>("objects\\characters\\heretic\\heretic", 3888842325U), 10);
            predict_model_section(GetTag<RenderModelTag>("objects\\characters\\heretic\\heretic", 3888842325U), 12);
            predict_model_section(GetTag<RenderModelTag>("objects\\characters\\elite\\elite_jetpack\\elite_jetpack", 3889497695U), 0);
            predict_model_section(GetTag<RenderModelTag>("objects\\characters\\dervish\\dervish", 3882419699U), 8);
            predict_model_section(GetTag<RenderModelTag>("objects\\characters\\dervish\\dervish", 3882419699U), 10);
            predict_model_section(GetTag<RenderModelTag>("objects\\weapons\\rifle\\plasma_rifle\\plasma_rifle", 3795452100U), 2);
            await sleep(18);
            predict_model_section(GetTag<RenderModelTag>("objects\\weapons\\rifle\\plasma_rifle\\plasma_rifle", 3795452100U), 1);
            await sleep(5);
            predict_model_section(GetTag<RenderModelTag>("objects\\weapons\\rifle\\plasma_rifle\\plasma_rifle", 3795452100U), 2);
            await sleep(35);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\04b_floodlab\\production_arm2"), 21, false);
            await sleep(33);
            predict_model_section(GetTag<RenderModelTag>("objects\\characters\\elite\\elite_jetpack\\elite_jetpack", 3889497695U), 1);
            await sleep(16);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\04b_floodlab\\production_arm2"), 21, false);
            await sleep(2);
            predict_model_section(GetTag<RenderModelTag>("objects\\characters\\elite\\elite_jetpack\\elite_jetpack", 3889497695U), 2);
            await sleep(1);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\04b_floodlab\\production_arm2"), 2, false);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\04b_floodlab\\production_arm2"), 16, false);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\04b_floodlab\\production_arm2"), 3, false);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\04b_floodlab\\production_arm2"), 17, false);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\04b_floodlab\\production_arm2"), 8, true);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\04b_floodlab\\production_arm2"), 9, true);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\04b_floodlab\\production_arm2"), 14, true);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\04b_floodlab\\production_arm2"), 15, true);
            predict_model_section(GetTag<RenderModelTag>("objects\\weapons\\rifle\\plasma_rifle\\plasma_rifle", 3795452100U), 1);
            predict_model_section(GetTag<RenderModelTag>("scenarios\\objects\\forerunner\\industrial\\doors\\door_tron_sm\\door_tron_sm", 3887728196U), 2);
            predict_model_section(GetTag<RenderModelTag>("objects\\weapons\\rifle\\covenant_carbine\\covenant_carbine", 3828810433U), 0);
            predict_model_section(GetTag<RenderModelTag>("objects\\weapons\\support_low\\sentinel_gun\\sentinel_gun", 3863348432U), 0);
            predict_model_section(GetTag<RenderModelTag>("objects\\weapons\\melee\\energy_blade\\energy_blade", 3786342457U), 0);
            predict_model_section(GetTag<RenderModelTag>("objects\\weapons\\melee\\energy_blade\\energy_blade", 3786342457U), 1);
            await sleep(2);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\04b_floodlab\\production_arm2"), 7, true);
            await sleep(6);
            predict_model_section(GetTag<RenderModelTag>("objects\\weapons\\rifle\\plasma_rifle\\plasma_rifle", 3795452100U), 2);
            await sleep(32);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\04b_floodlab\\production_arm2"), 21, false);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\04b_floodlab\\production_arm2"), 22, false);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\04b_floodlab\\production_arm2"), 6, true);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\04b_floodlab\\production_arm2"), 21, true);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\04b_floodlab\\production_arm2"), 1, true);
            predict_model_section(GetTag<RenderModelTag>("scenarios\\objects\\forerunner\\industrial\\doors\\door_tron_sm\\door_tron_sm", 3887728196U), 0);
            await sleep(1);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\04b_floodlab\\production_arm2"), 42, false);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\04b_floodlab\\production_arm2"), 35, false);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\04b_floodlab\\production_arm2"), 27, false);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\04b_floodlab\\production_arm2"), 31, false);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\04b_floodlab\\production_arm2"), 34, false);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\04b_floodlab\\production_arm2"), 0, true);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\04b_floodlab\\production_arm2"), 4, true);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\04b_floodlab\\production_arm2"), 20, true);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\04b_floodlab\\production_arm2"), 13, true);
            predict_model_section(GetTag<RenderModelTag>("objects\\characters\\heretic\\heretic", 3888842325U), 9);
            predict_model_section(GetTag<RenderModelTag>("objects\\characters\\heretic\\heretic", 3888842325U), 10);
            predict_model_section(GetTag<RenderModelTag>("objects\\characters\\heretic\\heretic", 3888842325U), 12);
            predict_model_section(GetTag<RenderModelTag>("objects\\characters\\elite\\elite_jetpack\\elite_jetpack", 3889497695U), 2);
            predict_model_section(GetTag<RenderModelTag>("objects\\weapons\\pistol\\needler\\needler", 3848012774U), 0);
            predict_model_section(GetTag<RenderModelTag>("objects\\weapons\\pistol\\needler\\needler", 3848012774U), 1);
            predict_model_section(GetTag<RenderModelTag>("scenarios\\objects\\forerunner\\industrial\\doors\\door_cargo_hangar_scenery\\door_cargo_hangar_scenery", 3891660416U), 0);
            predict_model_section(GetTag<RenderModelTag>("objects\\weapons\\grenade\\plasma_grenade\\plasma_grenade", 3891136120U), 0);
            predict_model_section(GetTag<RenderModelTag>("objects\\weapons\\rifle\\covenant_carbine\\covenant_carbine", 3828810433U), 0);
            predict_model_section(GetTag<RenderModelTag>("scenarios\\objects\\forerunner\\industrial\\controls\\temp_door_switch\\temp_door_switch", 3888186955U), 0);
            await sleep(40);
            predict_model_section(GetTag<RenderModelTag>("objects\\weapons\\rifle\\covenant_carbine\\covenant_carbine", 3828810433U), 0);
            await sleep(38);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\04b_floodlab\\production_arm2"), 21, true);
            await sleep(6);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\04b_floodlab\\production_arm2"), 31, false);
            await sleep(1);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\04b_floodlab\\production_arm2"), 6, true);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\04b_floodlab\\production_arm2"), 19, true);
            await sleep(1);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\04b_floodlab\\production_arm2"), 8, false);
            predict_model_section(GetTag<RenderModelTag>("objects\\characters\\dervish\\dervish", 3882419699U), 8);
            predict_model_section(GetTag<RenderModelTag>("objects\\characters\\dervish\\dervish", 3882419699U), 10);
            predict_model_section(GetTag<RenderModelTag>("objects\\weapons\\rifle\\plasma_rifle\\plasma_rifle", 3795452100U), 2);
            predict_model_section(GetTag<RenderModelTag>("objects\\weapons\\rifle\\plasma_rifle\\plasma_rifle", 3795452100U), 0);
            predict_model_section(GetTag<RenderModelTag>("objects\\characters\\elite\\elite_jetpack\\elite_jetpack", 3889497695U), 1);
            await sleep(45);
            predict_model_section(GetTag<RenderModelTag>("objects\\characters\\elite\\elite_jetpack\\elite_jetpack", 3889497695U), 2);
            await sleep(40);
            predict_model_section(GetTag<RenderModelTag>("objects\\weapons\\rifle\\plasma_rifle\\plasma_rifle", 3795452100U), 3);
            await sleep(48);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\04b_floodlab\\production_arm2"), 21, false);
            await sleep(8);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\04b_floodlab\\production_arm2"), 2, false);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\04b_floodlab\\production_arm2"), 16, false);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\04b_floodlab\\production_arm2"), 3, false);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\04b_floodlab\\production_arm2"), 17, false);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\04b_floodlab\\production_arm2"), 8, true);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\04b_floodlab\\production_arm2"), 9, true);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\04b_floodlab\\production_arm2"), 15, true);
            predict_model_section(GetTag<RenderModelTag>("objects\\weapons\\rifle\\plasma_rifle\\plasma_rifle", 3795452100U), 1);
            predict_model_section(GetTag<RenderModelTag>("scenarios\\objects\\forerunner\\industrial\\doors\\door_tron_sm\\door_tron_sm", 3887728196U), 2);
            predict_model_section(GetTag<RenderModelTag>("objects\\weapons\\support_low\\sentinel_gun\\sentinel_gun", 3863348432U), 0);
            predict_model_section(GetTag<RenderModelTag>("objects\\weapons\\melee\\energy_blade\\energy_blade", 3786342457U), 0);
            predict_model_section(GetTag<RenderModelTag>("objects\\weapons\\melee\\energy_blade\\energy_blade", 3786342457U), 1);
        }

        [ScriptMethod(382, Lifecycle.Dormant)]
        public async Task _04_outro1_02_predict()
        {
            await sleep(3);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\04b_floodlab\\production_arm2"), 21, false);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\04b_floodlab\\production_arm2"), 6, true);
            predict_model_section(GetTag<RenderModelTag>("objects\\characters\\elite\\elite_jetpack\\elite_jetpack", 3889497695U), 0);
            predict_model_section(GetTag<RenderModelTag>("scenarios\\objects\\forerunner\\industrial\\doors\\door_tron_sm\\door_tron_sm", 3887728196U), 0);
            await sleep(4);
            predict_model_section(GetTag<RenderModelTag>("objects\\characters\\monitor\\monitor", 3892381323U), 2);
            await sleep(113);
            predict_model_section(GetTag<RenderModelTag>("objects\\characters\\elite\\elite_jetpack\\elite_jetpack", 3889497695U), 1);
            await sleep(9);
            predict_model_section(GetTag<RenderModelTag>("objects\\weapons\\rifle\\plasma_rifle\\plasma_rifle", 3795452100U), 3);
            await sleep(39);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\04b_floodlab\\production_arm2"), 1, false);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\04b_floodlab\\production_arm2"), 21, false);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\04b_floodlab\\production_arm2"), 5, true);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\04b_floodlab\\production_arm2"), 6, true);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\04b_floodlab\\production_arm2"), 1, true);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\04b_floodlab\\production_arm2"), 9, true);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\04b_floodlab\\production_arm2"), 10, true);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\04b_floodlab\\production_arm2"), 14, true);
            predict_model_section(GetTag<RenderModelTag>("objects\\characters\\heretic\\heretic", 3888842325U), 9);
            predict_model_section(GetTag<RenderModelTag>("objects\\characters\\heretic\\heretic", 3888842325U), 10);
            predict_model_section(GetTag<RenderModelTag>("objects\\characters\\heretic\\heretic", 3888842325U), 12);
            predict_model_section(GetTag<RenderModelTag>("objects\\characters\\elite\\elite_jetpack\\elite_jetpack", 3889497695U), 1);
            predict_model_section(GetTag<RenderModelTag>("objects\\characters\\monitor\\monitor", 3892381323U), 2);
            predict_model_section(GetTag<RenderModelTag>("objects\\weapons\\rifle\\plasma_rifle\\plasma_rifle", 3795452100U), 1);
            predict_model_section(GetTag<RenderModelTag>("objects\\weapons\\grenade\\plasma_grenade\\plasma_grenade", 3891136120U), 0);
            predict_model_section(GetTag<RenderModelTag>("objects\\weapons\\rifle\\covenant_carbine\\covenant_carbine", 3828810433U), 0);
            predict_model_section(GetTag<RenderModelTag>("objects\\weapons\\support_low\\sentinel_gun\\sentinel_gun", 3863348432U), 0);
            predict_model_section(GetTag<RenderModelTag>("scenarios\\objects\\forerunner\\industrial\\doors\\door_tron_sm\\door_tron_sm", 3887728196U), 0);
            await sleep(33);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\04b_floodlab\\production_arm2"), 22, false);
            await sleep(81);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\04b_floodlab\\production_arm2"), 34, false);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\04b_floodlab\\production_arm2"), 31, false);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\04b_floodlab\\production_arm2"), 27, false);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\04b_floodlab\\production_arm2"), 35, false);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\04b_floodlab\\production_arm2"), 0, true);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\04b_floodlab\\production_arm2"), 13, true);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\04b_floodlab\\production_arm2"), 20, true);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\04b_floodlab\\production_arm2"), 1, true);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\04b_floodlab\\production_arm2"), 4, true);
            predict_model_section(GetTag<RenderModelTag>("objects\\weapons\\rifle\\plasma_rifle\\plasma_rifle", 3795452100U), 0);
            predict_model_section(GetTag<RenderModelTag>("scenarios\\objects\\forerunner\\industrial\\controls\\temp_door_switch\\temp_door_switch", 3888186955U), 0);
            predict_model_section(GetTag<RenderModelTag>("scenarios\\objects\\forerunner\\industrial\\doors\\door_cargo_hangar_scenery\\door_cargo_hangar_scenery", 3891660416U), 0);
            predict_model_section(GetTag<RenderModelTag>("objects\\weapons\\pistol\\needler\\needler", 3848012774U), 0);
            predict_model_section(GetTag<RenderModelTag>("objects\\weapons\\pistol\\needler\\needler", 3848012774U), 1);
            await sleep(280);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\04b_floodlab\\production_arm2"), 16, false);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\04b_floodlab\\production_arm2"), 17, false);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\04b_floodlab\\production_arm2"), 9, true);
            predict_model_section(GetTag<RenderModelTag>("objects\\characters\\dervish\\dervish", 3882419699U), 8);
            predict_model_section(GetTag<RenderModelTag>("objects\\characters\\dervish\\dervish", 3882419699U), 10);
            predict_model_section(GetTag<RenderModelTag>("objects\\weapons\\rifle\\plasma_rifle\\plasma_rifle", 3795452100U), 3);
            await sleep(23);
            predict_model_section(GetTag<RenderModelTag>("scenarios\\objects\\forerunner\\industrial\\doors\\door_tron_sm\\door_tron_sm", 3887728196U), 1);
            await sleep(42);
            predict_model_section(GetTag<RenderModelTag>("objects\\characters\\heretic\\heretic", 3888842325U), 9);
            predict_model_section(GetTag<RenderModelTag>("objects\\characters\\heretic\\heretic", 3888842325U), 10);
            predict_model_section(GetTag<RenderModelTag>("objects\\characters\\heretic\\heretic", 3888842325U), 12);
            predict_model_section(GetTag<RenderModelTag>("objects\\weapons\\rifle\\plasma_rifle\\plasma_rifle", 3795452100U), 2);
            predict_model_section(GetTag<RenderModelTag>("objects\\characters\\elite\\elite_jetpack\\elite_jetpack", 3889497695U), 1);
            await sleep(5);
            predict_model_section(GetTag<RenderModelTag>("objects\\characters\\heretic\\heretic", 3888842325U), 9);
            predict_model_section(GetTag<RenderModelTag>("objects\\characters\\heretic\\heretic", 3888842325U), 10);
            predict_model_section(GetTag<RenderModelTag>("objects\\characters\\heretic\\heretic", 3888842325U), 12);
            predict_model_section(GetTag<RenderModelTag>("objects\\weapons\\rifle\\plasma_rifle\\plasma_rifle", 3795452100U), 2);
            predict_model_section(GetTag<RenderModelTag>("objects\\characters\\elite\\elite_jetpack\\elite_jetpack", 3889497695U), 1);
            await sleep(5);
            predict_model_section(GetTag<RenderModelTag>("objects\\characters\\heretic\\heretic", 3888842325U), 9);
            predict_model_section(GetTag<RenderModelTag>("objects\\characters\\heretic\\heretic", 3888842325U), 10);
            predict_model_section(GetTag<RenderModelTag>("objects\\characters\\heretic\\heretic", 3888842325U), 12);
            predict_model_section(GetTag<RenderModelTag>("objects\\weapons\\rifle\\plasma_rifle\\plasma_rifle", 3795452100U), 2);
            predict_model_section(GetTag<RenderModelTag>("objects\\characters\\elite\\elite_jetpack\\elite_jetpack", 3889497695U), 1);
            await sleep(4);
            predict_model_section(GetTag<RenderModelTag>("objects\\characters\\heretic\\heretic", 3888842325U), 9);
            predict_model_section(GetTag<RenderModelTag>("objects\\characters\\heretic\\heretic", 3888842325U), 10);
            predict_model_section(GetTag<RenderModelTag>("objects\\characters\\heretic\\heretic", 3888842325U), 12);
            predict_model_section(GetTag<RenderModelTag>("objects\\weapons\\rifle\\plasma_rifle\\plasma_rifle", 3795452100U), 2);
            predict_model_section(GetTag<RenderModelTag>("objects\\characters\\elite\\elite_jetpack\\elite_jetpack", 3889497695U), 1);
            await sleep(4);
            predict_model_section(GetTag<RenderModelTag>("objects\\characters\\heretic\\heretic", 3888842325U), 9);
            predict_model_section(GetTag<RenderModelTag>("objects\\characters\\heretic\\heretic", 3888842325U), 10);
            predict_model_section(GetTag<RenderModelTag>("objects\\characters\\heretic\\heretic", 3888842325U), 12);
            predict_model_section(GetTag<RenderModelTag>("objects\\weapons\\rifle\\plasma_rifle\\plasma_rifle", 3795452100U), 2);
            predict_model_section(GetTag<RenderModelTag>("objects\\characters\\elite\\elite_jetpack\\elite_jetpack", 3889497695U), 1);
            await sleep(4);
            predict_model_section(GetTag<RenderModelTag>("objects\\characters\\heretic\\heretic", 3888842325U), 9);
            predict_model_section(GetTag<RenderModelTag>("objects\\characters\\heretic\\heretic", 3888842325U), 10);
            predict_model_section(GetTag<RenderModelTag>("objects\\characters\\heretic\\heretic", 3888842325U), 12);
            predict_model_section(GetTag<RenderModelTag>("objects\\weapons\\rifle\\plasma_rifle\\plasma_rifle", 3795452100U), 2);
            predict_model_section(GetTag<RenderModelTag>("objects\\characters\\elite\\elite_jetpack\\elite_jetpack", 3889497695U), 1);
            await sleep(25);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\04b_floodlab\\production_arm2"), 31, false);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\04b_floodlab\\production_arm2"), 27, false);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\04b_floodlab\\production_arm2"), 0, true);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\04b_floodlab\\production_arm2"), 6, true);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\04b_floodlab\\production_arm2"), 13, true);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\04b_floodlab\\production_arm2"), 20, true);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\04b_floodlab\\production_arm2"), 4, true);
            predict_model_section(GetTag<RenderModelTag>("objects\\characters\\monitor\\monitor", 3892381323U), 2);
            predict_model_section(GetTag<RenderModelTag>("objects\\weapons\\pistol\\needler\\needler", 3848012774U), 0);
            predict_model_section(GetTag<RenderModelTag>("objects\\weapons\\pistol\\needler\\needler", 3848012774U), 1);
            predict_model_section(GetTag<RenderModelTag>("objects\\weapons\\rifle\\plasma_rifle\\plasma_rifle", 3795452100U), 0);
            predict_model_section(GetTag<RenderModelTag>("objects\\weapons\\support_low\\sentinel_gun\\sentinel_gun", 3863348432U), 0);
            predict_model_section(GetTag<RenderModelTag>("scenarios\\objects\\forerunner\\industrial\\controls\\temp_door_switch\\temp_door_switch", 3888186955U), 0);
            predict_model_section(GetTag<RenderModelTag>("scenarios\\objects\\forerunner\\industrial\\doors\\door_cargo_hangar_scenery\\door_cargo_hangar_scenery", 3891660416U), 0);
            await sleep(15);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\04b_floodlab\\production_arm2"), 34, false);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\04b_floodlab\\production_arm2"), 35, false);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\04b_floodlab\\production_arm2"), 19, true);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\04b_floodlab\\production_arm2"), 1, true);
            predict_model_section(GetTag<RenderModelTag>("objects\\characters\\dervish\\dervish", 3882419699U), 8);
            predict_model_section(GetTag<RenderModelTag>("objects\\characters\\dervish\\dervish", 3882419699U), 10);
            await sleep(8);
            predict_model_section(GetTag<RenderModelTag>("objects\\weapons\\rifle\\plasma_rifle\\plasma_rifle", 3795452100U), 3);
            await sleep(2);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\04b_floodlab\\production_arm2"), 21, false);
            await sleep(44);
            predict_model_section(GetTag<RenderModelTag>("objects\\weapons\\support_low\\sentinel_gun\\sentinel_gun", 3863348432U), 0);
            await sleep(3);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\04b_floodlab\\production_arm2"), 16, false);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\04b_floodlab\\production_arm2"), 17, false);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\04b_floodlab\\production_arm2"), 9, true);
            predict_model_section(GetTag<RenderModelTag>("scenarios\\objects\\forerunner\\industrial\\doors\\door_tron_sm\\door_tron_sm", 3887728196U), 1);
            predict_model_section(GetTag<RenderModelTag>("objects\\weapons\\melee\\energy_blade\\energy_blade", 3786342457U), 0);
            predict_model_section(GetTag<RenderModelTag>("objects\\weapons\\melee\\energy_blade\\energy_blade", 3786342457U), 1);
            await sleep(2);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\04b_floodlab\\production_arm2"), 15, true);
            await sleep(9);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\04b_floodlab\\production_arm2"), 7, true);
            predict_model_section(GetTag<RenderModelTag>("objects\\weapons\\rifle\\plasma_rifle\\plasma_rifle", 3795452100U), 2);
            await sleep(9);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\04b_floodlab\\production_arm2"), 8, false);
            await sleep(5);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\04b_floodlab\\production_arm2"), 8, true);
            await sleep(7);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\04b_floodlab\\production_arm2"), 20, false);
            predict_model_section(GetTag<RenderModelTag>("scenarios\\objects\\solo\\alphagasgiant\\hanger_lift\\hanger_lift", 3893036693U), 0);
            await sleep(8);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\04b_floodlab\\production_arm2"), 1, true);
            await sleep(5);
            predict_model_section(GetTag<RenderModelTag>("objects\\weapons\\rifle\\plasma_rifle\\plasma_rifle", 3795452100U), 1);
            await sleep(3);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\04b_floodlab\\production_arm2"), 3, false);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\04b_floodlab\\production_arm2"), 17, false);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\04b_floodlab\\production_arm2"), 2, false);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\04b_floodlab\\production_arm2"), 16, false);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\04b_floodlab\\production_arm2"), 6, true);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\04b_floodlab\\production_arm2"), 8, true);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\04b_floodlab\\production_arm2"), 9, true);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\04b_floodlab\\production_arm2"), 14, true);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\04b_floodlab\\production_arm2"), 15, true);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\04b_floodlab\\production_arm2"), 19, true);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\04b_floodlab\\production_arm2"), 5, true);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\04b_floodlab\\production_arm2"), 21, true);
            predict_model_section(GetTag<RenderModelTag>("objects\\weapons\\rifle\\plasma_rifle\\plasma_rifle", 3795452100U), 0);
            predict_model_section(GetTag<RenderModelTag>("objects\\weapons\\grenade\\plasma_grenade\\plasma_grenade", 3891136120U), 0);
            predict_model_section(GetTag<RenderModelTag>("objects\\weapons\\support_low\\sentinel_gun\\sentinel_gun", 3863348432U), 0);
            predict_model_section(GetTag<RenderModelTag>("objects\\weapons\\rifle\\covenant_carbine\\covenant_carbine", 3828810433U), 0);
            predict_model_section(GetTag<RenderModelTag>("scenarios\\objects\\forerunner\\industrial\\doors\\door_tron_sm\\door_tron_sm", 3887728196U), 0);
            predict_model_section(GetTag<RenderModelTag>("scenarios\\objects\\forerunner\\industrial\\doors\\door_cargo_hangar_scenery\\door_cargo_hangar_scenery", 3891660416U), 0);
            predict_model_section(GetTag<RenderModelTag>("objects\\weapons\\melee\\energy_blade\\energy_blade", 3786342457U), 0);
            predict_model_section(GetTag<RenderModelTag>("objects\\weapons\\melee\\energy_blade\\energy_blade", 3786342457U), 1);
            predict_model_section(GetTag<RenderModelTag>("objects\\characters\\monitor\\monitor", 3892381323U), 2);
            predict_model_section(GetTag<RenderModelTag>("objects\\characters\\dervish\\dervish", 3882419699U), 8);
            predict_model_section(GetTag<RenderModelTag>("objects\\characters\\dervish\\dervish", 3882419699U), 10);
            await sleep(1);
            predict_model_section(GetTag<RenderModelTag>("objects\\characters\\elite\\elite_jetpack\\elite_jetpack", 3889497695U), 0);
            await sleep(9);
            predict_model_section(GetTag<RenderModelTag>("objects\\characters\\elite\\elite_jetpack\\elite_jetpack", 3889497695U), 1);
            await sleep(52);
            predict_model_section(GetTag<RenderModelTag>("objects\\characters\\dervish\\dervish", 3882419699U), 8);
            predict_model_section(GetTag<RenderModelTag>("objects\\characters\\dervish\\dervish", 3882419699U), 10);
        }

        [ScriptMethod(383, Lifecycle.Dormant)]
        public async Task _04_outro1_03_predict()
        {
            await sleep(2);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\04b_floodlab\\production_arm2"), 21, false);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\04b_floodlab\\production_arm2"), 1, true);
            predict_model_section(GetTag<RenderModelTag>("objects\\weapons\\rifle\\plasma_rifle\\plasma_rifle", 3795452100U), 3);
            await sleep(92);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\04b_floodlab\\production_arm2"), 35, false);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\04b_floodlab\\production_arm2"), 31, false);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\04b_floodlab\\production_arm2"), 34, false);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\04b_floodlab\\production_arm2"), 30, false);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\04b_floodlab\\production_arm2"), 0, true);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\04b_floodlab\\production_arm2"), 4, true);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\04b_floodlab\\production_arm2"), 20, true);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\04b_floodlab\\production_arm2"), 13, true);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\04b_floodlab\\production_arm2"), 21, true);
            predict_model_section(GetTag<RenderModelTag>("objects\\characters\\heretic\\heretic", 3888842325U), 9);
            predict_model_section(GetTag<RenderModelTag>("objects\\characters\\heretic\\heretic", 3888842325U), 10);
            predict_model_section(GetTag<RenderModelTag>("objects\\characters\\heretic\\heretic", 3888842325U), 12);
            predict_model_section(GetTag<RenderModelTag>("objects\\characters\\elite\\elite_jetpack\\elite_jetpack", 3889497695U), 1);
            predict_model_section(GetTag<RenderModelTag>("objects\\weapons\\grenade\\plasma_grenade\\plasma_grenade", 3891136120U), 0);
            predict_model_section(GetTag<RenderModelTag>("objects\\weapons\\pistol\\needler\\needler", 3848012774U), 0);
            predict_model_section(GetTag<RenderModelTag>("objects\\weapons\\pistol\\needler\\needler", 3848012774U), 1);
            predict_model_section(GetTag<RenderModelTag>("objects\\weapons\\rifle\\covenant_carbine\\covenant_carbine", 3828810433U), 0);
            predict_model_section(GetTag<RenderModelTag>("scenarios\\objects\\forerunner\\industrial\\doors\\door_cargo_hangar_scenery\\door_cargo_hangar_scenery", 3891660416U), 0);
            predict_model_section(GetTag<RenderModelTag>("scenarios\\objects\\solo\\alphagasgiant\\holo_drone\\holo_drone", 3893102230U), 0);
            predict_model_section(GetTag<RenderModelTag>("scenarios\\objects\\vehicles\\c_seraph\\c_seraph", 3891988101U), 0);
            predict_model_section(GetTag<RenderModelTag>("objects\\weapons\\rifle\\plasma_rifle\\plasma_rifle", 3795452100U), 0);
            await sleep(90);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\04b_floodlab\\production_arm2"), 6, true);
            await sleep(12);
            predict_model_section(GetTag<RenderModelTag>("scenarios\\objects\\solo\\alphagasgiant\\holo_drone\\holo_drone", 3893102230U), 0);
            await sleep(32);
            predict_model_section(GetTag<RenderModelTag>("objects\\characters\\elite\\elite_jetpack\\elite_jetpack", 3889497695U), 2);
            await sleep(32);
            predict_model_section(GetTag<RenderModelTag>("objects\\weapons\\rifle\\plasma_rifle\\plasma_rifle", 3795452100U), 0);
            await sleep(12);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\04b_floodlab\\production_arm2"), 6, true);
            await sleep(8);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\04b_floodlab\\production_arm2"), 21, true);
            await sleep(14);
            predict_model_section(GetTag<RenderModelTag>("objects\\cinematics\\texture_camera\\texture_camera", 3893560989U), 0);
            await sleep(4);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\04b_floodlab\\production_arm2"), 19, true);
            await sleep(1);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\04b_floodlab\\production_arm2"), 5, true);
            await sleep(3);
            predict_model_section(GetTag<RenderModelTag>("objects\\characters\\monitor\\monitor", 3892381323U), 2);
            await sleep(4);
            predict_model_section(GetTag<RenderModelTag>("objects\\characters\\dervish\\dervish", 3882419699U), 8);
            predict_model_section(GetTag<RenderModelTag>("objects\\characters\\dervish\\dervish", 3882419699U), 10);
            await sleep(21);
            predict_model_section(GetTag<RenderModelTag>("objects\\weapons\\grenade\\plasma_grenade\\plasma_grenade", 3891136120U), 0);
            await sleep(2);
            predict_model_section(GetTag<RenderModelTag>("scenarios\\objects\\forerunner\\industrial\\doors\\door_tron_sm\\door_tron_sm", 3887728196U), 0);
            await sleep(8);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\04b_floodlab\\production_arm2"), 5, true);
            await sleep(59);
            predict_model_section(GetTag<RenderModelTag>("scenarios\\objects\\forerunner\\industrial\\doors\\door_tron_sm\\door_tron_sm", 3887728196U), 1);
            await sleep(4);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\04b_floodlab\\production_arm2"), 16, false);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\04b_floodlab\\production_arm2"), 17, false);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\04b_floodlab\\production_arm2"), 14, true);
            predict_model_section(GetTag<RenderModelTag>("objects\\weapons\\rifle\\plasma_rifle\\plasma_rifle", 3795452100U), 2);
            predict_model_section(GetTag<RenderModelTag>("objects\\weapons\\grenade\\plasma_grenade\\plasma_grenade", 3891136120U), 1);
            await sleep(4);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\04b_floodlab\\production_arm2"), 9, true);
            await sleep(3);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\04b_floodlab\\production_arm2"), 10, true);
            predict_model_section(GetTag<RenderModelTag>("objects\\weapons\\rifle\\covenant_carbine\\covenant_carbine", 3828810433U), 0);
            await sleep(5);
            predict_model_section(GetTag<RenderModelTag>("scenarios\\objects\\forerunner\\industrial\\doors\\door_tron_sm\\door_tron_sm", 3887728196U), 0);
            await sleep(17);
            predict_model_section(GetTag<RenderModelTag>("scenarios\\objects\\forerunner\\industrial\\doors\\door_tron_sm\\door_tron_sm", 3887728196U), 1);
            await sleep(10);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\04b_floodlab\\production_arm2"), 34, false);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\04b_floodlab\\production_arm2"), 31, false);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\04b_floodlab\\production_arm2"), 27, false);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\04b_floodlab\\production_arm2"), 35, false);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\04b_floodlab\\production_arm2"), 0, true);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\04b_floodlab\\production_arm2"), 6, true);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\04b_floodlab\\production_arm2"), 12, true);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\04b_floodlab\\production_arm2"), 13, true);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\04b_floodlab\\production_arm2"), 20, true);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\04b_floodlab\\production_arm2"), 21, true);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\04b_floodlab\\production_arm2"), 4, true);
            predict_model_section(GetTag<RenderModelTag>("objects\\characters\\monitor\\monitor", 3892381323U), 2);
            predict_model_section(GetTag<RenderModelTag>("objects\\weapons\\grenade\\plasma_grenade\\plasma_grenade", 3891136120U), 0);
            predict_model_section(GetTag<RenderModelTag>("objects\\weapons\\pistol\\needler\\needler", 3848012774U), 0);
            predict_model_section(GetTag<RenderModelTag>("objects\\weapons\\pistol\\needler\\needler", 3848012774U), 1);
            predict_model_section(GetTag<RenderModelTag>("objects\\weapons\\rifle\\plasma_rifle\\plasma_rifle", 3795452100U), 0);
            predict_model_section(GetTag<RenderModelTag>("objects\\weapons\\support_low\\sentinel_gun\\sentinel_gun", 3863348432U), 0);
            predict_model_section(GetTag<RenderModelTag>("scenarios\\objects\\forerunner\\industrial\\controls\\temp_door_switch\\temp_door_switch", 3888186955U), 0);
            predict_model_section(GetTag<RenderModelTag>("scenarios\\objects\\forerunner\\industrial\\doors\\door_cargo_hangar_scenery\\door_cargo_hangar_scenery", 3891660416U), 0);
            predict_model_section(GetTag<RenderModelTag>("scenarios\\objects\\solo\\alphagasgiant\\holo_drone\\holo_drone", 3893102230U), 0);
            predict_model_section(GetTag<RenderModelTag>("scenarios\\objects\\vehicles\\c_seraph\\c_seraph", 3891988101U), 0);
            predict_model_section(GetTag<RenderModelTag>("objects\\cinematics\\texture_camera\\texture_camera", 3893560989U), 0);
            predict_model_section(GetTag<RenderModelTag>("objects\\characters\\heretic\\heretic", 3888842325U), 9);
            predict_model_section(GetTag<RenderModelTag>("objects\\characters\\heretic\\heretic", 3888842325U), 10);
            predict_model_section(GetTag<RenderModelTag>("objects\\characters\\heretic\\heretic", 3888842325U), 12);
            predict_model_section(GetTag<RenderModelTag>("objects\\characters\\elite\\elite_jetpack\\elite_jetpack", 3889497695U), 0);
            await sleep(47);
            predict_model_section(GetTag<RenderModelTag>("objects\\characters\\elite\\elite_jetpack\\elite_jetpack", 3889497695U), 1);
            await sleep(7);
            predict_model_section(GetTag<RenderModelTag>("objects\\weapons\\rifle\\plasma_rifle\\plasma_rifle", 3795452100U), 3);
            await sleep(56);
            predict_model_section(GetTag<RenderModelTag>("objects\\weapons\\melee\\energy_blade\\energy_blade", 3786342457U), 0);
            predict_model_section(GetTag<RenderModelTag>("objects\\weapons\\melee\\energy_blade\\energy_blade", 3786342457U), 1);
            await sleep(44);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\04b_floodlab\\production_arm2"), 8, false);
            await sleep(174);
            predict_model_section(GetTag<RenderModelTag>("objects\\weapons\\rifle\\covenant_carbine\\covenant_carbine", 3828810433U), 0);
        }

        [ScriptMethod(384, Lifecycle.Dormant)]
        public async Task _04_outro2_01_predict()
        {
            await sleep(2);
            predict_model_section(GetTag<RenderModelTag>("scenarios\\objects\\forerunner\\industrial\\doors\\door_cargo_hangar\\door_cargo_hangar", 3893757600U), 0);
            await sleep(5);
            predict_model_section(GetTag<RenderModelTag>("objects\\characters\\monitor\\monitor", 3892381323U), 2);
            predict_model_section(GetTag<RenderModelTag>("objects\\characters\\heretic\\heretic", 3888842325U), 9);
            predict_model_section(GetTag<RenderModelTag>("objects\\characters\\heretic\\heretic", 3888842325U), 10);
            predict_model_section(GetTag<RenderModelTag>("objects\\characters\\heretic\\heretic", 3888842325U), 12);
            predict_model_section(GetTag<RenderModelTag>("objects\\characters\\elite\\elite_jetpack\\elite_jetpack", 3889497695U), 1);
            predict_model_section(GetTag<RenderModelTag>("objects\\characters\\dervish\\dervish", 3882419699U), 8);
            predict_model_section(GetTag<RenderModelTag>("objects\\characters\\dervish\\dervish", 3882419699U), 10);
            await sleep(54);
            predict_model_section(GetTag<RenderModelTag>("objects\\characters\\elite\\elite_jetpack\\elite_jetpack", 3889497695U), 2);
            await sleep(70);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\04b_floodlab\\production_arm2"), 32, false);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\04b_floodlab\\production_arm2"), 33, false);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\04b_floodlab\\production_arm2"), 0, true);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\04b_floodlab\\production_arm2"), 5, true);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\04b_floodlab\\production_arm2"), 11, true);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\04b_floodlab\\production_arm2"), 12, true);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\04b_floodlab\\production_arm2"), 13, true);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\04b_floodlab\\production_arm2"), 20, true);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\04b_floodlab\\production_arm2"), 14, true);
            predict_model_section(GetTag<RenderModelTag>("objects\\weapons\\grenade\\plasma_grenade\\plasma_grenade", 3891136120U), 0);
            predict_model_section(GetTag<RenderModelTag>("objects\\weapons\\support_low\\sentinel_gun\\sentinel_gun", 3863348432U), 3);
            predict_model_section(GetTag<RenderModelTag>("scenarios\\objects\\forerunner\\industrial\\controls\\temp_door_switch\\temp_door_switch", 3888186955U), 0);
            predict_model_section(GetTag<RenderModelTag>("scenarios\\objects\\forerunner\\industrial\\doors\\door_tron_sm\\door_tron_sm", 3887728196U), 0);
            predict_model_section(GetTag<RenderModelTag>("objects\\weapons\\melee\\energy_blade\\energy_blade", 3786342457U), 0);
            predict_model_section(GetTag<RenderModelTag>("objects\\weapons\\melee\\energy_blade\\energy_blade", 3786342457U), 1);
            await sleep(53);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\04b_floodlab\\production_arm2"), 27, false);
            await sleep(156);
            predict_model_section(GetTag<RenderModelTag>("objects\\characters\\heretic\\heretic", 3888842325U), 9);
            predict_model_section(GetTag<RenderModelTag>("objects\\characters\\heretic\\heretic", 3888842325U), 10);
            predict_model_section(GetTag<RenderModelTag>("objects\\characters\\heretic\\heretic", 3888842325U), 12);
            predict_model_section(GetTag<RenderModelTag>("objects\\characters\\elite\\elite_jetpack\\elite_jetpack", 3889497695U), 2);
            await sleep(89);
            predict_model_section(GetTag<RenderModelTag>("objects\\characters\\heretic\\heretic", 3888842325U), 9);
            predict_model_section(GetTag<RenderModelTag>("objects\\characters\\heretic\\heretic", 3888842325U), 10);
            predict_model_section(GetTag<RenderModelTag>("objects\\characters\\heretic\\heretic", 3888842325U), 12);
            predict_model_section(GetTag<RenderModelTag>("objects\\characters\\elite\\elite_jetpack\\elite_jetpack", 3889497695U), 2);
        }

        [ScriptMethod(385, Lifecycle.Dormant)]
        public async Task _04_outro2_02_predict()
        {
            await sleep(3);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\04b_floodlab\\production_arm2"), 31, false);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\04b_floodlab\\production_arm2"), 21, false);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\04b_floodlab\\production_arm2"), 29, false);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\04b_floodlab\\production_arm2"), 23, false);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\04b_floodlab\\production_arm2"), 2, false);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\04b_floodlab\\production_arm2"), 16, false);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\04b_floodlab\\production_arm2"), 8, false);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\04b_floodlab\\production_arm2"), 3, false);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\04b_floodlab\\production_arm2"), 17, false);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\04b_floodlab\\production_arm2"), 5, true);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\04b_floodlab\\production_arm2"), 6, true);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\04b_floodlab\\production_arm2"), 12, true);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\04b_floodlab\\production_arm2"), 19, true);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\04b_floodlab\\production_arm2"), 20, true);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\04b_floodlab\\production_arm2"), 21, true);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\04b_floodlab\\production_arm2"), 1, true);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\04b_floodlab\\production_arm2"), 7, true);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\04b_floodlab\\production_arm2"), 8, true);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\04b_floodlab\\production_arm2"), 9, true);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\04b_floodlab\\production_arm2"), 15, true);
            predict_model_section(GetTag<RenderModelTag>("objects\\characters\\heretic\\heretic", 3888842325U), 9);
            predict_model_section(GetTag<RenderModelTag>("objects\\characters\\heretic\\heretic", 3888842325U), 10);
            predict_model_section(GetTag<RenderModelTag>("objects\\characters\\heretic\\heretic", 3888842325U), 12);
            predict_model_section(GetTag<RenderModelTag>("objects\\characters\\elite\\elite_jetpack\\elite_jetpack", 3889497695U), 2);
            predict_model_section(GetTag<RenderModelTag>("objects\\weapons\\pistol\\needler\\needler", 3848012774U), 0);
            predict_model_section(GetTag<RenderModelTag>("objects\\weapons\\pistol\\needler\\needler", 3848012774U), 1);
            predict_model_section(GetTag<RenderModelTag>("objects\\weapons\\rifle\\plasma_rifle\\plasma_rifle", 3795452100U), 0);
            predict_model_section(GetTag<RenderModelTag>("objects\\weapons\\support_low\\sentinel_gun\\sentinel_gun", 3863348432U), 1);
            predict_model_section(GetTag<RenderModelTag>("scenarios\\objects\\vehicles\\c_seraph\\c_seraph", 3891988101U), 0);
            predict_model_section(GetTag<RenderModelTag>("objects\\cinematics\\texture_camera\\texture_camera", 3893560989U), 0);
            predict_model_section(GetTag<RenderModelTag>("objects\\weapons\\support_low\\sentinel_gun\\sentinel_gun", 3863348432U), 0);
            predict_model_section(GetTag<RenderModelTag>("objects\\weapons\\rifle\\covenant_carbine\\covenant_carbine", 3828810433U), 0);
            predict_model_section(GetTag<RenderModelTag>("objects\\weapons\\melee\\energy_blade\\energy_blade", 3786342457U), 0);
            predict_model_section(GetTag<RenderModelTag>("objects\\weapons\\melee\\energy_blade\\energy_blade", 3786342457U), 1);
            await sleep(2);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\04b_floodlab\\production_arm2"), 27, false);
            await sleep(9);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\04b_floodlab\\production_arm2"), 33, false);
            await sleep(8);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\04b_floodlab\\production_arm2"), 32, false);
            await sleep(4);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\04b_floodlab\\production_arm2"), 13, true);
            await sleep(10);
            predict_model_section(GetTag<RenderModelTag>("objects\\characters\\elite\\elite_jetpack\\elite_jetpack", 3889497695U), 0);
            await sleep(4);
            predict_model_section(GetTag<RenderModelTag>("objects\\vehicles\\phantom\\phantom", 3893954211U), 12);
            predict_model_section(GetTag<RenderModelTag>("objects\\vehicles\\phantom\\phantom", 3893954211U), 13);
            predict_model_section(GetTag<RenderModelTag>("objects\\vehicles\\phantom\\phantom", 3893954211U), 14);
            predict_model_section(GetTag<RenderModelTag>("objects\\vehicles\\phantom\\phantom", 3893954211U), 19);
            predict_model_section(GetTag<RenderModelTag>("objects\\vehicles\\phantom\\phantom", 3893954211U), 16);
            predict_model_section(GetTag<RenderModelTag>("objects\\vehicles\\phantom\\turrets\\chin_gun\\chin_gun", 3894544044U), 6);
            predict_model_section(GetTag<RenderModelTag>("objects\\vehicles\\phantom\\turrets\\chin_gun\\chin_gun", 3894544044U), 7);
            await sleep(17);
            predict_model_section(GetTag<RenderModelTag>("objects\\characters\\brute\\brute", 3894609581U), 26);
            predict_model_section(GetTag<RenderModelTag>("objects\\characters\\brute\\brute", 3894609581U), 29);
            predict_model_section(GetTag<RenderModelTag>("objects\\characters\\brute\\brute", 3894609581U), 35);
            predict_model_section(GetTag<RenderModelTag>("objects\\characters\\brute\\brute", 3894609581U), 36);
            predict_model_section(GetTag<RenderModelTag>("objects\\characters\\brute\\brute", 3894609581U), 37);
            predict_model_section(GetTag<RenderModelTag>("objects\\characters\\brute\\brute", 3894609581U), 33);
            predict_model_section(GetTag<RenderModelTag>("objects\\characters\\brute\\brute", 3894609581U), 34);
            predict_model_section(GetTag<RenderModelTag>("objects\\weapons\\melee\\gravity_hammer\\gravity_hammer", 3896706765U), 0);
            await sleep(90);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\04b_floodlab\\production_arm2"), 57, false);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\04b_floodlab\\production_arm2"), 1, false);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\04b_floodlab\\production_arm2"), 34, false);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\04b_floodlab\\production_arm2"), 31, false);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\04b_floodlab\\production_arm2"), 21, false);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\04b_floodlab\\production_arm2"), 16, false);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\04b_floodlab\\production_arm2"), 8, false);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\04b_floodlab\\production_arm2"), 35, false);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\04b_floodlab\\production_arm2"), 17, false);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\04b_floodlab\\production_arm2"), 0, true);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\04b_floodlab\\production_arm2"), 5, true);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\04b_floodlab\\production_arm2"), 6, true);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\04b_floodlab\\production_arm2"), 11, true);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\04b_floodlab\\production_arm2"), 12, true);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\04b_floodlab\\production_arm2"), 13, true);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\04b_floodlab\\production_arm2"), 19, true);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\04b_floodlab\\production_arm2"), 20, true);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\04b_floodlab\\production_arm2"), 21, true);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\04b_floodlab\\production_arm2"), 1, true);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\04b_floodlab\\production_arm2"), 4, true);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\04b_floodlab\\production_arm2"), 7, true);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\04b_floodlab\\production_arm2"), 9, true);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\04b_floodlab\\production_arm2"), 10, true);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\04b_floodlab\\production_arm2"), 14, true);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\04b_floodlab\\production_arm2"), 15, true);
            predict_model_section(GetTag<RenderModelTag>("objects\\characters\\heretic\\heretic", 3888842325U), 9);
            predict_model_section(GetTag<RenderModelTag>("objects\\characters\\heretic\\heretic", 3888842325U), 10);
            predict_model_section(GetTag<RenderModelTag>("objects\\characters\\heretic\\heretic", 3888842325U), 12);
            predict_model_section(GetTag<RenderModelTag>("objects\\characters\\elite\\elite_jetpack\\elite_jetpack", 3889497695U), 2);
            predict_model_section(GetTag<RenderModelTag>("objects\\characters\\dervish\\dervish", 3882419699U), 8);
            predict_model_section(GetTag<RenderModelTag>("objects\\characters\\dervish\\dervish", 3882419699U), 10);
            predict_model_section(GetTag<RenderModelTag>("objects\\weapons\\grenade\\plasma_grenade\\plasma_grenade", 3891136120U), 0);
            predict_model_section(GetTag<RenderModelTag>("objects\\weapons\\pistol\\needler\\needler", 3848012774U), 0);
            predict_model_section(GetTag<RenderModelTag>("objects\\weapons\\pistol\\needler\\needler", 3848012774U), 1);
            predict_model_section(GetTag<RenderModelTag>("objects\\weapons\\rifle\\plasma_rifle\\plasma_rifle", 3795452100U), 0);
            predict_model_section(GetTag<RenderModelTag>("objects\\weapons\\rifle\\covenant_carbine\\covenant_carbine", 3828810433U), 0);
            predict_model_section(GetTag<RenderModelTag>("scenarios\\objects\\forerunner\\industrial\\doors\\door_tron_sm\\door_tron_sm", 3887728196U), 0);
            predict_model_section(GetTag<RenderModelTag>("scenarios\\objects\\vehicles\\c_seraph\\c_seraph", 3891988101U), 0);
            predict_model_section(GetTag<RenderModelTag>("objects\\cinematics\\texture_camera\\texture_camera", 3893560989U), 0);
            predict_model_section(GetTag<RenderModelTag>("objects\\weapons\\support_low\\sentinel_gun\\sentinel_gun", 3863348432U), 0);
            predict_model_section(GetTag<RenderModelTag>("objects\\weapons\\melee\\energy_blade\\energy_blade", 3786342457U), 0);
            predict_model_section(GetTag<RenderModelTag>("objects\\weapons\\melee\\energy_blade\\energy_blade", 3786342457U), 1);
            await sleep(56);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\04b_floodlab\\production_arm2"), 27, false);
            predict_model_section(GetTag<RenderModelTag>("objects\\characters\\brute\\brute", 3894609581U), 26);
            predict_model_section(GetTag<RenderModelTag>("objects\\characters\\brute\\brute", 3894609581U), 29);
            predict_model_section(GetTag<RenderModelTag>("objects\\characters\\brute\\brute", 3894609581U), 35);
            predict_model_section(GetTag<RenderModelTag>("objects\\characters\\brute\\brute", 3894609581U), 36);
            predict_model_section(GetTag<RenderModelTag>("objects\\characters\\brute\\brute", 3894609581U), 37);
            predict_model_section(GetTag<RenderModelTag>("objects\\characters\\brute\\brute", 3894609581U), 33);
            predict_model_section(GetTag<RenderModelTag>("objects\\characters\\brute\\brute", 3894609581U), 34);
            predict_model_section(GetTag<RenderModelTag>("objects\\characters\\monitor\\monitor", 3892381323U), 2);
            predict_model_section(GetTag<RenderModelTag>("objects\\weapons\\melee\\gravity_hammer\\gravity_hammer", 3896706765U), 0);
            predict_model_section(GetTag<RenderModelTag>("objects\\vehicles\\phantom\\phantom", 3893954211U), 12);
            predict_model_section(GetTag<RenderModelTag>("objects\\vehicles\\phantom\\phantom", 3893954211U), 13);
            predict_model_section(GetTag<RenderModelTag>("objects\\vehicles\\phantom\\phantom", 3893954211U), 14);
            predict_model_section(GetTag<RenderModelTag>("objects\\vehicles\\phantom\\phantom", 3893954211U), 19);
            predict_model_section(GetTag<RenderModelTag>("objects\\vehicles\\phantom\\phantom", 3893954211U), 16);
            predict_model_section(GetTag<RenderModelTag>("objects\\vehicles\\phantom\\turrets\\chin_gun\\chin_gun", 3894544044U), 6);
            predict_model_section(GetTag<RenderModelTag>("objects\\vehicles\\phantom\\turrets\\chin_gun\\chin_gun", 3894544044U), 7);
        }

        [ScriptMethod(386, Lifecycle.Static)]
        public async Task teleport_silo()
        {
            switch_bsp(3);
            object_teleport(await this.player0(), silo_player0);
            object_teleport(await this.player1(), silo_player1);
            ai_place(allies_elites_03a.Squad, 1);
            ai_place(allies_elites_03b.Squad, 1);
            object_teleport(list_get(ai_actors(allies_elites_03a.Squad), 0), silo_ally01);
            object_teleport(list_get(ai_actors(allies_elites_03b.Squad), 0), silo_ally02);
            sleep_forever(new ScriptMethodReference(mission));
            await this.sleep_intro();
            await this.sleep_disposal();
            wake(new ScriptMethodReference(silo_start));
            wake(new ScriptMethodReference(to_flood_lab));
            wake(new ScriptMethodReference(flood_lab_start));
            await sleep_until(async () => (short)structure_bsp_index() == 0);
            wake(new ScriptMethodReference(bridge_start));
            wake(new ScriptMethodReference(control_room_start));
            await sleep_until(async () => (short)structure_bsp_index() == 2);
            wake(new ScriptMethodReference(cable_room_start));
            await sleep_until(async () => (short)structure_bsp_index() == 1);
            wake(new ScriptMethodReference(control_room_return));
            wake(new ScriptMethodReference(power_core_start));
            wake(new ScriptMethodReference(dogfight_secondtime_start));
            await sleep_until(async () => volume_test_objects(vol_arm_01_return, players()) == true);
            wake(new ScriptMethodReference(bottling_secondtime_start));
            wake(new ScriptMethodReference(to_underhangar_secondtime));
            wake(new ScriptMethodReference(underhangar_secondtime_start));
            wake(new ScriptMethodReference(to_hangar_secondtime));
            wake(new ScriptMethodReference(hangar_secondtime_start));
        }

        [ScriptMethod(387, Lifecycle.Static)]
        public async Task teleport_lab()
        {
            ai_erase_all();
            switch_bsp(3);
            object_teleport(await this.player0(), lab_player0);
            object_teleport(await this.player1(), lab_player1);
            ai_place(allies_elites_03a.Squad, 1);
            object_teleport(list_get(ai_actors(allies_elites_03a.Squad), 0), lab_ally01);
            sleep_forever(new ScriptMethodReference(mission));
            await this.sleep_intro();
            await this.sleep_disposal();
            await this.sleep_silo();
            wake(new ScriptMethodReference(to_flood_lab));
            wake(new ScriptMethodReference(flood_lab_start));
            await sleep_until(async () => (short)structure_bsp_index() == 0);
            wake(new ScriptMethodReference(bridge_start));
            wake(new ScriptMethodReference(control_room_start));
            await sleep_until(async () => (short)structure_bsp_index() == 2);
            wake(new ScriptMethodReference(cable_room_start));
            await sleep_until(async () => (short)structure_bsp_index() == 1);
            wake(new ScriptMethodReference(control_room_return));
            wake(new ScriptMethodReference(power_core_start));
            wake(new ScriptMethodReference(dogfight_secondtime_start));
            await sleep_until(async () => volume_test_objects(vol_arm_01_return, players()) == true);
            wake(new ScriptMethodReference(bottling_secondtime_start));
            wake(new ScriptMethodReference(to_underhangar_secondtime));
            wake(new ScriptMethodReference(underhangar_secondtime_start));
            wake(new ScriptMethodReference(to_hangar_secondtime));
            wake(new ScriptMethodReference(hangar_secondtime_start));
        }

        [ScriptMethod(388, Lifecycle.Static)]
        public async Task teleport_wraparound()
        {
            ai_erase_all();
            switch_bsp(0);
            await sleep(2);
            object_teleport(await this.player0(), wraparound_player0);
            object_teleport(await this.player1(), wraparound_player1);
            ai_place(allies_elites_03a.Squad, 1);
            object_teleport(list_get(ai_actors(allies_elites_03a.Squad), 0), wraparound_player1);
            sleep_forever(new ScriptMethodReference(mission));
            await this.sleep_intro();
            await this.sleep_disposal();
            await this.sleep_silo();
            await this.sleep_lab();
            wake(new ScriptMethodReference(bridge_start));
            wake(new ScriptMethodReference(control_room_start));
            await sleep_until(async () => (short)structure_bsp_index() == 2);
            wake(new ScriptMethodReference(cable_room_start));
            await sleep_until(async () => (short)structure_bsp_index() == 1);
            wake(new ScriptMethodReference(control_room_return));
            wake(new ScriptMethodReference(power_core_start));
            wake(new ScriptMethodReference(dogfight_secondtime_start));
            await sleep_until(async () => volume_test_objects(vol_arm_01_return, players()) == true);
            wake(new ScriptMethodReference(bottling_secondtime_start));
            wake(new ScriptMethodReference(to_underhangar_secondtime));
            wake(new ScriptMethodReference(underhangar_secondtime_start));
            wake(new ScriptMethodReference(to_hangar_secondtime));
            wake(new ScriptMethodReference(hangar_secondtime_start));
        }

        [ScriptMethod(389, Lifecycle.Static)]
        public async Task teleport_control()
        {
            ai_erase_all();
            switch_bsp(0);
            await sleep(2);
            object_teleport(await this.player0(), control_entry_player0);
            object_teleport(await this.player1(), control_entry_player1);
            ai_place(allies_elites_04.Squad, 1);
            ai_place(allies_grunts_04.Squad, 1);
            object_teleport(list_get(ai_actors(allies_elites_04.Squad), 0), control_ally01);
            object_teleport(list_get(ai_actors(allies_grunts_04.Squad), 0), control_ally02);
            sleep_forever(new ScriptMethodReference(mission));
            await this.sleep_intro();
            await this.sleep_disposal();
            await this.sleep_silo();
            await this.sleep_lab();
            await this.sleep_wraparound();
            wake(new ScriptMethodReference(control_room_start));
            await sleep_until(async () => (short)structure_bsp_index() == 2);
            wake(new ScriptMethodReference(cable_room_start));
            await sleep_until(async () => (short)structure_bsp_index() == 1);
            wake(new ScriptMethodReference(control_room_return));
            wake(new ScriptMethodReference(power_core_start));
            wake(new ScriptMethodReference(dogfight_secondtime_start));
            await sleep_until(async () => volume_test_objects(vol_arm_01_return, players()) == true);
            wake(new ScriptMethodReference(bottling_secondtime_start));
            wake(new ScriptMethodReference(to_underhangar_secondtime));
            wake(new ScriptMethodReference(underhangar_secondtime_start));
            wake(new ScriptMethodReference(to_hangar_secondtime));
            wake(new ScriptMethodReference(hangar_secondtime_start));
        }

        [ScriptMethod(390, Lifecycle.Static)]
        public async Task teleport_cableroom()
        {
            ai_erase_all();
            switch_bsp(2);
            await sleep(2);
            object_teleport(await this.player0(), cableroom_player0);
            object_teleport(await this.player1(), cableroom_player1);
            device_set_position_immediate(elev_control_up.Entity, 1F);
            device_set_power(control_up_switch_02.Entity, 0F);
            sleep_forever(new ScriptMethodReference(mission));
            await this.sleep_intro();
            await this.sleep_disposal();
            await this.sleep_silo();
            await this.sleep_lab();
            await this.sleep_wraparound();
            await this.sleep_control();
            wake(new ScriptMethodReference(cable_room_start));
            await sleep_until(async () => (short)structure_bsp_index() == 1);
            wake(new ScriptMethodReference(control_room_return));
            wake(new ScriptMethodReference(power_core_start));
            wake(new ScriptMethodReference(dogfight_secondtime_start));
            await sleep_until(async () => volume_test_objects(vol_arm_01_return, players()) == true);
            wake(new ScriptMethodReference(bottling_secondtime_start));
            wake(new ScriptMethodReference(to_underhangar_secondtime));
            wake(new ScriptMethodReference(underhangar_secondtime_start));
            wake(new ScriptMethodReference(to_hangar_secondtime));
            wake(new ScriptMethodReference(hangar_secondtime_start));
        }

        [ScriptMethod(391, Lifecycle.Static)]
        public async Task teleport_plummet()
        {
            ai_erase_all();
            this.plummeting = true;
            switch_bsp(1);
            await sleep(2);
            object_teleport(await this.player0(), after_plummet_player0);
            object_teleport(await this.player1(), after_plummet_player1);
            device_set_position_immediate(control_shield_door.Entity, 1F);
            device_set_position_immediate(shield.Entity, 1F);
            device_set_position_immediate(elev_control_up.Entity, 0F);
            device_set_power(control_up_switch_01.Entity, 0F);
            sleep_forever(new ScriptMethodReference(mission));
            await this.sleep_intro();
            await this.sleep_disposal();
            await this.sleep_silo();
            await this.sleep_lab();
            await this.sleep_wraparound();
            await this.sleep_control();
            await this.sleep_cableroom();
            wake(new ScriptMethodReference(control_room_return));
            wake(new ScriptMethodReference(power_core_start));
            wake(new ScriptMethodReference(dogfight_secondtime_start));
            await sleep_until(async () => volume_test_objects(vol_arm_01_return, players()) == true);
            wake(new ScriptMethodReference(bottling_secondtime_start));
            wake(new ScriptMethodReference(to_underhangar_secondtime));
            wake(new ScriptMethodReference(underhangar_secondtime_start));
            wake(new ScriptMethodReference(to_hangar_secondtime));
            wake(new ScriptMethodReference(hangar_secondtime_start));
        }

        [ScriptMethod(392, Lifecycle.Static)]
        public async Task teleport_powercore()
        {
            ai_erase_all();
            this.plummeting = true;
            switch_bsp(1);
            await sleep(2);
            object_teleport(await this.player0(), powercore_player0);
            object_teleport(await this.player1(), powercore_player1);
            sleep_forever(new ScriptMethodReference(mission));
            await this.sleep_intro();
            await this.sleep_disposal();
            await this.sleep_silo();
            await this.sleep_lab();
            await this.sleep_wraparound();
            await this.sleep_control();
            await this.sleep_cableroom();
            await this.sleep_control_return();
            wake(new ScriptMethodReference(power_core_start));
            wake(new ScriptMethodReference(dogfight_secondtime_start));
            await sleep_until(async () => volume_test_objects(vol_arm_01_return, players()) == true);
            wake(new ScriptMethodReference(bottling_secondtime_start));
            wake(new ScriptMethodReference(to_underhangar_secondtime));
            wake(new ScriptMethodReference(underhangar_secondtime_start));
            wake(new ScriptMethodReference(to_hangar_secondtime));
            wake(new ScriptMethodReference(hangar_secondtime_start));
        }

        [ScriptMethod(393, Lifecycle.Static)]
        public async Task teleport_banshee()
        {
            ai_erase_all();
            this.plummeting = true;
            switch_bsp(1);
            await sleep(2);
            object_teleport(await this.player0(), banshee_player0);
            object_teleport(await this.player1(), banshee_player1);
            sleep_forever(new ScriptMethodReference(mission));
            await this.sleep_intro();
            await this.sleep_disposal();
            await this.sleep_silo();
            await this.sleep_lab();
            await this.sleep_wraparound();
            await this.sleep_control();
            await this.sleep_cableroom();
            await this.sleep_control_return();
            await this.sleep_powercore();
            device_operates_automatically_set(hl_ledge_ext.Entity, true);
            object_create(player0_fake_banshee);
            object_create(player1_fake_banshee);
            object_create(hl_fake_banshee);
            object_cannot_take_damage(player0_fake_banshee.Entity);
            object_cannot_take_damage(player1_fake_banshee.Entity);
            object_cannot_take_damage(hl_fake_banshee.Entity);
            wake(new ScriptMethodReference(dogfight_secondtime_start));
            await sleep_until(async () => volume_test_objects(vol_arm_01_return, players()) == true);
            wake(new ScriptMethodReference(bottling_secondtime_start));
            wake(new ScriptMethodReference(to_underhangar_secondtime));
            wake(new ScriptMethodReference(underhangar_secondtime_start));
            wake(new ScriptMethodReference(to_hangar_secondtime));
            wake(new ScriptMethodReference(hangar_secondtime_start));
        }

        [ScriptMethod(394, Lifecycle.Static)]
        public async Task teleport_bottling_return()
        {
            ai_erase_all();
            this.plummeting = true;
            switch_bsp(1);
            await sleep(2);
            object_teleport(await this.player0(), bottling_return_player0);
            object_teleport(await this.player1(), bottling_return_player1);
            device_operates_automatically_set(viewroom_exit01_bsp0.Entity, true);
            sleep_forever(new ScriptMethodReference(mission));
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
            wake(new ScriptMethodReference(bottling_secondtime_start));
            wake(new ScriptMethodReference(to_underhangar_secondtime));
            wake(new ScriptMethodReference(underhangar_secondtime_start));
            wake(new ScriptMethodReference(to_hangar_secondtime));
            wake(new ScriptMethodReference(hangar_secondtime_start));
        }

        [ScriptMethod(395, Lifecycle.Static)]
        public async Task teleport_underhangar_return()
        {
            ai_erase_all();
            this.plummeting = true;
            switch_bsp(5);
            await sleep(2);
            object_teleport(await this.player0(), underhangar_return_player0);
            object_teleport(await this.player1(), underhangar_return_player1);
            sleep_forever(new ScriptMethodReference(mission));
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
            wake(new ScriptMethodReference(underhangar_secondtime_start));
            wake(new ScriptMethodReference(to_hangar_secondtime));
            wake(new ScriptMethodReference(hangar_secondtime_start));
        }

        [ScriptMethod(396, Lifecycle.Static)]
        public async Task teleport_boss()
        {
            ai_erase_all();
            this.plummeting = true;
            switch_bsp(5);
            await sleep(2);
            object_teleport(await this.player0(), boss_player0);
            object_teleport(await this.player1(), boss_player1);
            sleep_forever(new ScriptMethodReference(mission));
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
            wake(new ScriptMethodReference(hangar_secondtime_start));
        }
    }
}