namespace OpenH2.Scripts.Generatedscenarios.solo
{
    using System;
    using System.Threading.Tasks;
    using OpenH2.Core.Architecture;
    using OpenH2.Core.Tags;
    using OpenH2.Core.Tags.Scenario;
    using OpenH2.Core.Scripting;
    using OpenH2.Core.GameObjects;

    [OriginScenario("scenarios\\solo\\04a_gasgiant\\04a_gasgiant")]
    public partial class scnr_04a_gasgiant : ScenarioScriptBase
    {
#region Fields
        string data_mine_mission_segment;
        int sound_offset;
        int prediction_offset;
        bool stealth_talk_gone;
        bool stealth_hint_done;
        bool first_airlock_go;
        bool open_rec_center;
        bool commander_done_yapping;
        int recycling_time;
        bool recycling_power_on;
        IGameObject chatter_her_01;
        IGameObject chatter_her_02;
        bool hangar_power_on;
        bool hangar_sentinel_var;
        bool hangar_phantom_cue;
        bool hangar_sentinels_come;
        int heavies_spawned;
        int a50_spawn_go;
        bool underhangar_power_on;
        bool bottling_power_on;
        bool left_bottling_firsthalf;
        int bottling_sentinels_spawned;
        bool hl_done_yapping;
        bool overlook_choose_side;
        int phantom_course_pos;
        bool dogfight_ph_pilot_go;
        bool try_to_save_now;
        bool dogfight_over;
        bool emplace_01_done;
        bool emplace_02_done;
        bool emplace_03_done;
        bool emplace_04_done;
        bool emplace_05_done;
        bool emplace_06_done;
        int dogfighters_spawned;
        public scnr_04a_gasgiant(IScriptEngine scriptEngine)
        {
            this.Engine = scriptEngine;
            this.data_mine_mission_segment = "";
            this.sound_offset = 15;
            this.prediction_offset = 75;
            this.stealth_talk_gone = false;
            this.stealth_hint_done = false;
            this.first_airlock_go = false;
            this.open_rec_center = false;
            this.commander_done_yapping = false;
            this.recycling_time = 300;
            this.recycling_power_on = false;
            this.chatter_her_01 = default(IGameObject);
            this.chatter_her_02 = default(IGameObject);
            this.hangar_power_on = false;
            this.hangar_sentinel_var = true;
            this.hangar_phantom_cue = false;
            this.hangar_sentinels_come = false;
            this.heavies_spawned = 0;
            this.a50_spawn_go = 0;
            this.underhangar_power_on = false;
            this.bottling_power_on = false;
            this.left_bottling_firsthalf = false;
            this.bottling_sentinels_spawned = 0;
            this.hl_done_yapping = false;
            this.overlook_choose_side = false;
            this.phantom_course_pos = 0;
            this.dogfight_ph_pilot_go = false;
            this.try_to_save_now = false;
            this.dogfight_over = false;
            this.emplace_01_done = false;
            this.emplace_02_done = false;
            this.emplace_03_done = false;
            this.emplace_04_done = false;
            this.emplace_05_done = false;
            this.emplace_06_done = false;
            this.dogfighters_spawned = 0;
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
        public async Task x04_01_predict_stub()
        {
            wake(new ScriptMethodReference(x04_01_predict));
        }

        [ScriptMethod(25, Lifecycle.Static)]
        public async Task x04_02a_predict_stub()
        {
            wake(new ScriptMethodReference(x04_02a_predict));
        }

        [ScriptMethod(26, Lifecycle.Static)]
        public async Task x04_02b_predict_stub()
        {
            wake(new ScriptMethodReference(x04_02b_predict));
        }

        [ScriptMethod(27, Lifecycle.Static)]
        public async Task x04_03b_predict_stub()
        {
            wake(new ScriptMethodReference(x04_03b_predict));
        }

        [ScriptMethod(28, Lifecycle.Static)]
        public async Task x04_04_predict_stub()
        {
            wake(new ScriptMethodReference(x04_04_predict));
        }

        [ScriptMethod(29, Lifecycle.Static)]
        public async Task x04_05_predict_stub()
        {
            wake(new ScriptMethodReference(x04_05_predict));
        }

        [ScriptMethod(30, Lifecycle.Static)]
        public async Task x04_06_predict_stub()
        {
            wake(new ScriptMethodReference(x04_06_predict));
        }

        [ScriptMethod(31, Lifecycle.Static)]
        public async Task x04_07_predict_stub()
        {
            wake(new ScriptMethodReference(x04_07_predict));
        }

        [ScriptMethod(32, Lifecycle.Static)]
        public async Task x04_08_predict_stub()
        {
            wake(new ScriptMethodReference(x04_08_predict));
        }

        [ScriptMethod(33, Lifecycle.Static)]
        public async Task x04_09_predict_stub()
        {
            wake(new ScriptMethodReference(x04_09_predict));
        }

        [ScriptMethod(34, Lifecycle.Static)]
        public async Task x04_10_predict_stub()
        {
            wake(new ScriptMethodReference(x04_10_predict));
        }

        [ScriptMethod(35, Lifecycle.Static)]
        public async Task _04_intro_01_predict_stub()
        {
            wake(new ScriptMethodReference(_04_intro_01_predict));
        }

        [ScriptMethod(36, Lifecycle.Static)]
        public async Task _04_intro_02a_predict_stub()
        {
            wake(new ScriptMethodReference(_04_intro_02a_predict));
        }

        [ScriptMethod(37, Lifecycle.Static)]
        public async Task _04_intro_02b_predict_stub()
        {
            wake(new ScriptMethodReference(_04_intro_02b_predict));
        }

        [ScriptMethod(38, Lifecycle.Static)]
        public async Task _04_intro_02c_predict_stub()
        {
            wake(new ScriptMethodReference(_04_intro_02c_predict));
        }

        [ScriptMethod(39, Lifecycle.Static)]
        public async Task _04_intro_02d_predict_stub()
        {
            wake(new ScriptMethodReference(_04_intro_02d_predict));
        }

        [ScriptMethod(40, Lifecycle.Static)]
        public async Task _04_intro_03_predict_stub()
        {
            wake(new ScriptMethodReference(_04_intro_03_predict));
        }

        [ScriptMethod(41, Lifecycle.Static)]
        public async Task _04_intro_05_predict_stub()
        {
            wake(new ScriptMethodReference(_04_intro_05_predict));
        }

        [ScriptMethod(42, Lifecycle.Static)]
        public async Task _04_intro_06b_predict_stub()
        {
            wake(new ScriptMethodReference(_04_intro_06b_predict));
        }

        [ScriptMethod(43, Lifecycle.Dormant)]
        public async Task x04_score_01()
        {
            await sleep(0);
            sound_impulse_start(GetTag<SoundTag>("sound\\cinematics\\04_alphagas\\x04\\music\\01_mus", 3834577689U), default(IGameObject), 1F);
            print("x04 score 01 start");
        }

        [ScriptMethod(44, Lifecycle.Dormant)]
        public async Task x04_foley_01()
        {
            await sleep(0);
            sound_impulse_start(GetTag<SoundTag>("sound\\cinematics\\04_alphagas\\x04\\foley\\x04_01_fol", 3834643226U), default(IGameObject), 1F);
            print("x04 foley 01 start");
        }

        [ScriptMethod(45, Lifecycle.Dormant)]
        public async Task x04_0010_bgr()
        {
            await sleep(483);
            sound_impulse_start(GetTag<SoundTag>("sound\\dialog\\levels\\04_gasgiant\\cinematic\\x04_0010_bgr", 3834708763U), brute_01.Entity, 1F);
            cinematic_subtitle("x04_0010_bgr", 5F);
        }

        [ScriptMethod(46, Lifecycle.Dormant)]
        public async Task x04_0020_bgl()
        {
            await sleep(633);
            sound_impulse_start(GetTag<SoundTag>("sound\\dialog\\levels\\04_gasgiant\\cinematic\\x04_0020_bgl", 3834774300U), brute_01.Entity, 1F);
            cinematic_subtitle("x04_0020_bgl", 2F);
        }

        [ScriptMethod(47, Lifecycle.Dormant)]
        public async Task x04_0040_jcr()
        {
            await sleep(693);
            sound_impulse_start(GetTag<SoundTag>("sound\\dialog\\levels\\04_gasgiant\\cinematic\\x04_0040_jcr", 3834839837U), jackal_01.Entity, 1F);
            cinematic_subtitle("x04_0040_jcr", 4F);
        }

        [ScriptMethod(48, Lifecycle.Dormant)]
        public async Task x04_0030_bgl()
        {
            await sleep(816);
            sound_impulse_start(GetTag<SoundTag>("sound\\dialog\\levels\\04_gasgiant\\cinematic\\x04_0030_bgl", 3834905374U), brute_01.Entity, 1F);
            cinematic_subtitle("x04_0030_bgl", 1.5F);
        }

        [ScriptMethod(49, Lifecycle.Dormant)]
        public async Task x04_0050_bgr()
        {
            await sleep(863);
            sound_impulse_start(GetTag<SoundTag>("sound\\dialog\\levels\\04_gasgiant\\cinematic\\x04_0050_bgr", 3834970911U), brute_02.Entity, 1F);
            cinematic_subtitle("x04_0050_bgr", 7.5F);
        }

        [ScriptMethod(50, Lifecycle.Dormant)]
        public async Task x04_cinematic_lighting_scene_01()
        {
            cinematic_lighting_set_primary_light(46F, 276F, 0.11F, 0.1F, 0.14F);
            cinematic_lighting_set_secondary_light(73F, 0F, 0.11F, 0.11F, 0.13F);
            cinematic_lighting_set_ambient_light(0.04F, 0.04F, 0.04F);
            rasterizer_bloom_override(true);
            rasterizer_bloom_override_threshold(0.3F);
            rasterizer_bloom_override_brightness(0.5F);
            object_uses_cinematic_lighting(dervish.Entity, true);
            object_uses_cinematic_lighting(tartarus.Entity, true);
            object_uses_cinematic_lighting(brute_01.Entity, true);
            object_uses_cinematic_lighting(brute_02.Entity, true);
            object_uses_cinematic_lighting(jackal_01.Entity, true);
            object_uses_cinematic_lighting(jackal_02.Entity, true);
            object_uses_cinematic_lighting(jackal_03.Entity, true);
            object_uses_cinematic_lighting(hammer.Entity, true);
        }

        [ScriptMethod(51, Lifecycle.Static)]
        public async Task x04_01_setup()
        {
            object_create_anew(dervish);
            object_create_anew(tartarus);
            object_create_anew(brute_01);
            object_create_anew(brute_02);
            object_create_anew(jackal_01);
            object_create_anew(jackal_02);
            object_create_anew(jackal_03);
            object_create_anew(hammer);
            object_cinematic_lod(dervish.Entity, true);
            object_cinematic_lod(tartarus.Entity, true);
            object_cinematic_lod(brute_01.Entity, true);
            object_cinematic_lod(brute_02.Entity, true);
            object_cinematic_lod(jackal_01.Entity, true);
            object_cinematic_lod(jackal_02.Entity, true);
            object_cinematic_lod(jackal_03.Entity, true);
            object_cinematic_lod(hammer.Entity, true);
            wake(new ScriptMethodReference(x04_0010_bgr));
            wake(new ScriptMethodReference(x04_0020_bgl));
            wake(new ScriptMethodReference(x04_0040_jcr));
            wake(new ScriptMethodReference(x04_0030_bgl));
            wake(new ScriptMethodReference(x04_0050_bgr));
            wake(new ScriptMethodReference(x04_score_01));
            wake(new ScriptMethodReference(x04_foley_01));
            wake(new ScriptMethodReference(x04_cinematic_lighting_scene_01));
        }

        [ScriptMethod(52, Lifecycle.Static)]
        public async Task x04_scene_01()
        {
            fade_out(0F, 0F, 0F, 0);
            camera_control(true);
            cinematic_start_movie("gasgiant_1");
            cinematic_start();
            this.cinematic_letterbox_style = 1;
            camera_set_field_of_view(60F, 0);
            cinematic_lightmap_shadow_enable();
            await this.x04_01_predict_stub();
            sound_impulse_predict(GetTag<SoundTag>("sound\\cinematics\\04_alphagas\\x04\\music\\01_mus", 3834577689U));
            sound_impulse_predict(GetTag<SoundTag>("sound\\cinematics\\04_alphagas\\x04\\foley\\x04_01_fol", 3834643226U));
            await sleep(this.prediction_offset);
            await this.x04_01_setup();
            camera_set_animation_relative(GetTag<AnimationGraphTag>("objects\\characters\\cinematic_camera\\x04\\x04", 3835036448U), "x04_01", default(IUnit), anchor_flag_x04a);
            custom_animation_relative(dervish.Entity, GetTag<AnimationGraphTag>("objects\\characters\\dervish\\x04\\x04", 3835101985U), "dervish_01", false, anchor_x04a.Entity);
            custom_animation_relative(tartarus.Entity, GetTag<AnimationGraphTag>("objects\\characters\\brute\\x04\\x04", 3835233059U), "tartarus_01", false, anchor_x04a.Entity);
            custom_animation_relative(brute_01.Entity, GetTag<AnimationGraphTag>("objects\\characters\\brute\\x04\\x04", 3835233059U), "brute01_01", false, anchor_x04a.Entity);
            custom_animation_relative(brute_02.Entity, GetTag<AnimationGraphTag>("objects\\characters\\brute\\x04\\x04", 3835233059U), "brute02_01", false, anchor_x04a.Entity);
            custom_animation_relative(jackal_01.Entity, GetTag<AnimationGraphTag>("objects\\characters\\jackal\\x04\\x04", 3835364133U), "jackal01_01", false, anchor_x04a.Entity);
            custom_animation_relative(jackal_02.Entity, GetTag<AnimationGraphTag>("objects\\characters\\jackal\\x04\\x04", 3835364133U), "jackal02_01", false, anchor_x04a.Entity);
            custom_animation_relative(jackal_03.Entity, GetTag<AnimationGraphTag>("objects\\characters\\jackal\\x04\\x04", 3835364133U), "jackal03_01", false, anchor_x04a.Entity);
            scenery_animation_start_relative(hammer.Entity, GetTag<AnimationGraphTag>("objects\\weapons\\melee\\gravity_hammer\\x04\\x04", 3835429670U), "hammer_01", anchor_x04a.Entity);
            interpolator_start("blurry_vision", 1F, 0.001F);
            await sleep(30);
            fade_in(0F, 0F, 0F, 30);
            await sleep(45);
            fade_out(0F, 0F, 0F, 30);
            await sleep(45);
            fade_in(0F, 0F, 0F, 20);
            interpolator_start("blurry_vision", 0F, 2F);
            await sleep(30);
            fade_out(0F, 0F, 0F, 20);
            await sleep(20);
            interpolator_start("blurry_vision", 1F, 0.001F);
            await sleep(25);
            fade_in(0F, 0F, 0F, 10);
            interpolator_start("blurry_vision", 0F, 2F);
            await sleep((short)((float)camera_time() - this.prediction_offset));
            await this.x04_02a_predict_stub();
            await sleep((short)((float)camera_time() - this.sound_offset));
            sound_impulse_predict(GetTag<SoundTag>("sound\\cinematics\\04_alphagas\\x04\\foley\\x04_02a_fol", 3835495207U));
            await sleep((short)camera_time());
        }

        [ScriptMethod(53, Lifecycle.Dormant)]
        public async Task x04_foley_02a()
        {
            await sleep(0);
            sound_impulse_start(GetTag<SoundTag>("sound\\cinematics\\04_alphagas\\x04\\foley\\x04_02a_fol", 3835495207U), default(IGameObject), 1F);
            print("x04 foley 02a start");
        }

        [ScriptMethod(54, Lifecycle.Dormant)]
        public async Task x04_0060_tar()
        {
            await sleep(173);
            sound_impulse_start(GetTag<SoundTag>("sound\\dialog\\levels\\04_gasgiant\\cinematic\\x04_0060_tar", 3835560744U), tartarus.Entity, 1F);
            cinematic_subtitle("x04_0060_tar", 4F);
        }

        [ScriptMethod(55, Lifecycle.Dormant)]
        public async Task x04_0070_tar()
        {
            await sleep(300);
            sound_impulse_start(GetTag<SoundTag>("sound\\dialog\\levels\\04_gasgiant\\cinematic\\x04_0070_tar", 3835626281U), tartarus.Entity, 1F);
            cinematic_subtitle("x04_0070_tar", 2F);
        }

        [ScriptMethod(56, Lifecycle.Dormant)]
        public async Task x04_0080_tar()
        {
            await sleep(370);
            sound_impulse_start(GetTag<SoundTag>("sound\\dialog\\levels\\04_gasgiant\\cinematic\\x04_0080_tar", 3835691818U), tartarus.Entity, 1F);
            cinematic_subtitle("x04_0080_tar", 3.5F);
            await sleep(15);
            unit_set_emotional_state(tartarus.Entity, "inquisitive", 0.75F, 90);
        }

        [ScriptMethod(57, Lifecycle.Dormant)]
        public async Task x04_button_delete()
        {
            await sleep(361);
            print("button_delete");
            object_destroy(x04_button.Entity);
        }

        [ScriptMethod(58, Lifecycle.Dormant)]
        public async Task x04_door_open()
        {
            await sleep(455);
            print("door open");
            device_set_position(x04_door_01.Entity, 1F);
        }

        [ScriptMethod(59, Lifecycle.Static)]
        public async Task x04_02a_setup()
        {
            object_create_anew(x04_button);
            wake(new ScriptMethodReference(x04_foley_02a));
            wake(new ScriptMethodReference(x04_0060_tar));
            wake(new ScriptMethodReference(x04_0070_tar));
            wake(new ScriptMethodReference(x04_0080_tar));
            wake(new ScriptMethodReference(x04_door_open));
            wake(new ScriptMethodReference(x04_button_delete));
        }

        [ScriptMethod(60, Lifecycle.Static)]
        public async Task x04_scene_02a()
        {
            await this.x04_02a_setup();
            camera_set_field_of_view(70F, 0);
            print("fov change: 60 -> 70 over 0 ticks");
            camera_set_animation_relative(GetTag<AnimationGraphTag>("objects\\characters\\cinematic_camera\\x04\\x04", 3835036448U), "x04_02a", default(IUnit), anchor_flag_x04a);
            custom_animation_relative(dervish.Entity, GetTag<AnimationGraphTag>("objects\\characters\\dervish\\x04\\x04", 3835101985U), "dervish_02a", false, anchor_x04a.Entity);
            custom_animation_relative(tartarus.Entity, GetTag<AnimationGraphTag>("objects\\characters\\brute\\x04\\x04", 3835233059U), "tartarus_02a", false, anchor_x04a.Entity);
            custom_animation_relative(brute_01.Entity, GetTag<AnimationGraphTag>("objects\\characters\\brute\\x04\\x04", 3835233059U), "brute01_02a", false, anchor_x04a.Entity);
            custom_animation_relative(brute_02.Entity, GetTag<AnimationGraphTag>("objects\\characters\\brute\\x04\\x04", 3835233059U), "brute02_02a", false, anchor_x04a.Entity);
            scenery_animation_start_relative(hammer.Entity, GetTag<AnimationGraphTag>("objects\\weapons\\melee\\gravity_hammer\\x04\\x04", 3835429670U), "hammer_02a", anchor_x04a.Entity);
            await sleep((short)((float)camera_time() - this.prediction_offset));
            await this.x04_02b_predict_stub();
            await sleep((short)((float)camera_time() - this.sound_offset));
            sound_impulse_predict(GetTag<SoundTag>("sound\\cinematics\\04_alphagas\\x04\\foley\\x04_02b_fol", 3835757355U));
            await sleep((short)((float)camera_time() - 15));
            fade_out(1F, 1F, 1F, 15);
            await sleep(15);
            object_destroy(x04_door_01.Entity);
        }

        [ScriptMethod(61, Lifecycle.Dormant)]
        public async Task x04_foley_2b()
        {
            await sleep(0);
            sound_impulse_start(GetTag<SoundTag>("sound\\cinematics\\04_alphagas\\x04\\foley\\x04_02b_fol", 3835757355U), default(IGameObject), 1F);
            print("x04 foley 02b start");
        }

        [ScriptMethod(62, Lifecycle.Dormant)]
        public async Task x04_02b_fov()
        {
            await sleep(140);
            camera_set_field_of_view(80F, 0);
            print("fov change: 70 -> 80 over 0 ticks");
        }

        [ScriptMethod(63, Lifecycle.Dormant)]
        public async Task x04_cinematic_lighting_02b()
        {
            cinematic_lighting_set_primary_light(68F, 336F, 0.25F, 0.24F, 0.36F);
            cinematic_lighting_set_secondary_light(0F, 24F, 0.18F, 0.13F, 0.2F);
            cinematic_lighting_set_ambient_light(0.03F, 0.03F, 0.03F);
        }

        [ScriptMethod(64, Lifecycle.Static)]
        public async Task x04_02b_setup()
        {
            object_create_anew(jail_ledge);
            object_uses_cinematic_lighting(jail_ledge.Entity, true);
            wake(new ScriptMethodReference(x04_foley_2b));
            wake(new ScriptMethodReference(x04_02b_fov));
            wake(new ScriptMethodReference(x04_cinematic_lighting_02b));
        }

        [ScriptMethod(65, Lifecycle.Static)]
        public async Task x04_02b_cleanup()
        {
            object_destroy(jail_ledge.Entity);
            object_destroy_containing("jackal");
        }

        [ScriptMethod(66, Lifecycle.Static)]
        public async Task x04_scene_02b()
        {
            cinematic_lightmap_shadow_disable();
            await this.x04_02b_setup();
            camera_set_animation_relative(GetTag<AnimationGraphTag>("objects\\characters\\cinematic_camera\\x04\\x04", 3835036448U), "x04_02b", default(IUnit), anchor_flag_x04a);
            custom_animation_relative(dervish.Entity, GetTag<AnimationGraphTag>("objects\\characters\\dervish\\x04\\x04", 3835101985U), "dervish_02b", false, anchor_x04a.Entity);
            custom_animation_relative(tartarus.Entity, GetTag<AnimationGraphTag>("objects\\characters\\brute\\x04\\x04", 3835233059U), "tartarus_02b", false, anchor_x04a.Entity);
            custom_animation_relative(brute_01.Entity, GetTag<AnimationGraphTag>("objects\\characters\\brute\\x04\\x04", 3835233059U), "brute01_02b", false, anchor_x04a.Entity);
            custom_animation_relative(brute_02.Entity, GetTag<AnimationGraphTag>("objects\\characters\\brute\\x04\\x04", 3835233059U), "brute02_02b", false, anchor_x04a.Entity);
            scenery_animation_start_relative(hammer.Entity, GetTag<AnimationGraphTag>("objects\\weapons\\melee\\gravity_hammer\\x04\\x04", 3835429670U), "hammer_02b", anchor_x04a.Entity);
            scenery_animation_start_relative(jail_ledge.Entity, GetTag<AnimationGraphTag>("scenarios\\objects\\solo\\highcharity\\high_jail_ledge\\x04\\x04", 3835822892U), "ledge_02b", anchor_x04a.Entity);
            fade_in(1F, 1F, 1F, 15);
            await sleep((short)((float)camera_time() - this.prediction_offset));
            await this.x04_03b_predict_stub();
            await sleep((short)((float)camera_time() - this.sound_offset));
            sound_impulse_predict(GetTag<SoundTag>("sound\\cinematics\\04_alphagas\\x04\\foley\\x04_03b_fol", 3835888429U));
            await sleep((short)camera_time());
        }

        [ScriptMethod(67, Lifecycle.Dormant)]
        public async Task x04_foley_03b()
        {
            await sleep(0);
            sound_impulse_start(GetTag<SoundTag>("sound\\cinematics\\04_alphagas\\x04\\foley\\x04_03b_fol", 3835888429U), default(IGameObject), 1F);
            print("x04 foley 03b start");
        }

        [ScriptMethod(68, Lifecycle.Dormant)]
        public async Task x04_03b_dof_1()
        {
            await sleep(91);
            cinematic_screen_effect_start(true);
            cinematic_screen_effect_set_depth_of_field(1F, 0.5F, 0.5F, 0.001F, 0F, 0F, 0.001F);
            print("rack focus");
            await sleep(138);
            cinematic_screen_effect_stop();
            print("rack focus stop");
        }

        [ScriptMethod(69, Lifecycle.Dormant)]
        public async Task x04_cinematic_lighting_03b()
        {
            cinematic_lighting_set_primary_light(65F, 0F, 0.24F, 0.24F, 0.31F);
            cinematic_lighting_set_secondary_light(0F, 26F, 0.21F, 0.18F, 0.15F);
            cinematic_lighting_set_ambient_light(0.05F, 0.05F, 0.05F);
            object_uses_cinematic_lighting(honor_guard_02.Entity, true);
            object_uses_cinematic_lighting(honor_guard_04.Entity, true);
            object_uses_cinematic_lighting(honor_guard_05.Entity, true);
            object_uses_cinematic_lighting(honor_guard_06.Entity, true);
            object_uses_cinematic_lighting(honor_guard_14.Entity, true);
            object_uses_cinematic_lighting(honor_guard_15.Entity, true);
            object_uses_cinematic_lighting(honor_guard_16.Entity, true);
            object_uses_cinematic_lighting(honor_guard_17.Entity, true);
            object_uses_cinematic_lighting(honor_guard_18.Entity, true);
            object_uses_cinematic_lighting(honor_guard_19.Entity, true);
            object_uses_cinematic_lighting(honor_guard_20.Entity, true);
            object_uses_cinematic_lighting(honor_guard_28.Entity, true);
            object_uses_cinematic_lighting(honor_guard_29.Entity, true);
            object_uses_cinematic_lighting(honor_guard_30.Entity, true);
        }

        [ScriptMethod(70, Lifecycle.Static)]
        public async Task x04_03b_setup()
        {
            object_create_anew_containing("honor_guard");
            wake(new ScriptMethodReference(x04_foley_03b));
            wake(new ScriptMethodReference(x04_cinematic_lighting_03b));
        }

        [ScriptMethod(71, Lifecycle.Static)]
        public async Task x04_scene_03b()
        {
            await this.x04_03b_setup();
            camera_set_field_of_view(60F, 0);
            print("fov change: 80 -> 60 over 0 ticks");
            camera_set_animation_relative(GetTag<AnimationGraphTag>("objects\\characters\\cinematic_camera\\x04\\x04", 3835036448U), "x04_03b", default(IUnit), anchor_flag_x04a);
            custom_animation_relative(dervish.Entity, GetTag<AnimationGraphTag>("objects\\characters\\dervish\\x04\\x04", 3835101985U), "dervish_03b", false, anchor_x04a.Entity);
            custom_animation_relative(tartarus.Entity, GetTag<AnimationGraphTag>("objects\\characters\\brute\\x04\\x04", 3835233059U), "tartarus_03b", false, anchor_x04a.Entity);
            custom_animation_relative(brute_01.Entity, GetTag<AnimationGraphTag>("objects\\characters\\brute\\x04\\x04", 3835233059U), "brute01_03b", false, anchor_x04a.Entity);
            custom_animation_relative(brute_02.Entity, GetTag<AnimationGraphTag>("objects\\characters\\brute\\x04\\x04", 3835233059U), "brute02_03b", false, anchor_x04a.Entity);
            scenery_animation_start_relative(hammer.Entity, GetTag<AnimationGraphTag>("objects\\weapons\\melee\\gravity_hammer\\x04\\x04", 3835429670U), "hammer_03b", anchor_x04a.Entity);
            await sleep((short)((float)camera_time() - this.prediction_offset));
            await this.x04_04_predict_stub();
            await sleep((short)((float)camera_time() - this.sound_offset));
            sound_impulse_predict(GetTag<SoundTag>("sound\\cinematics\\04_alphagas\\x04\\foley\\x04_04_fol", 3835953966U));
            await sleep((short)((float)camera_time() - 30));
            cinematic_screen_effect_start(true);
            await sleep((short)((float)camera_time() - 5));
            cinematic_screen_effect_set_crossfade(2F);
            print("crossfade");
            await sleep(5);
            object_destroy_containing("honor_guard");
        }

        [ScriptMethod(72, Lifecycle.Dormant)]
        public async Task x04_foley_04()
        {
            await sleep(0);
            sound_impulse_start(GetTag<SoundTag>("sound\\cinematics\\04_alphagas\\x04\\foley\\x04_04_fol", 3835953966U), default(IGameObject), 1F);
            print("x04 foley 04 start");
        }

        [ScriptMethod(73, Lifecycle.Dormant)]
        public async Task x04_cinematic_lighting_scene_04()
        {
            cinematic_lighting_set_primary_light(65F, 0F, 0.24F, 0.24F, 0.31F);
            cinematic_lighting_set_secondary_light(0F, 26F, 0.21F, 0.18F, 0.15F);
            cinematic_lighting_set_ambient_light(0.05F, 0.05F, 0.05F);
            object_uses_cinematic_lighting(truth.Entity, true);
            object_uses_cinematic_lighting(mercy.Entity, true);
            object_uses_cinematic_lighting(throne_truth.Entity, true);
            object_uses_cinematic_lighting(throne_mercy.Entity, true);
            object_uses_cinematic_lighting(sarcophagus.Entity, true);
        }

        [ScriptMethod(74, Lifecycle.Static)]
        public async Task x04_04_setup()
        {
            object_create_anew(truth);
            object_create_anew(mercy);
            object_create_anew_containing("throne");
            object_create_anew(sarcophagus);
            object_cinematic_lod(truth.Entity, true);
            object_cinematic_lod(mercy.Entity, true);
            object_cinematic_lod(throne_truth.Entity, true);
            object_cinematic_lod(throne_mercy.Entity, true);
            objects_attach(truth.Entity, "driver", throne_truth.Entity, "driver_cinematic");
            objects_attach(mercy.Entity, "driver", throne_mercy.Entity, "driver_cinematic");
            wake(new ScriptMethodReference(x04_foley_04));
            wake(new ScriptMethodReference(x04_cinematic_lighting_scene_04));
        }

        [ScriptMethod(75, Lifecycle.Static)]
        public async Task x04_scene_04()
        {
            await this.x04_04_setup();
            camera_set_animation_relative(GetTag<AnimationGraphTag>("objects\\characters\\cinematic_camera\\x04\\x04", 3835036448U), "x04_04", default(IUnit), anchor_flag_x04b);
            custom_animation_relative(dervish.Entity, GetTag<AnimationGraphTag>("objects\\characters\\dervish\\x04\\x04", 3835101985U), "dervish_04", false, anchor_x04b.Entity);
            custom_animation_relative(tartarus.Entity, GetTag<AnimationGraphTag>("objects\\characters\\brute\\x04\\x04", 3835233059U), "tartarus_04", false, anchor_x04b.Entity);
            custom_animation_relative(truth.Entity, GetTag<AnimationGraphTag>("objects\\characters\\prophet\\x04\\x04", 3836019503U), "truth_04", false, anchor_x04b.Entity);
            custom_animation_relative(mercy.Entity, GetTag<AnimationGraphTag>("objects\\characters\\prophet\\x04\\x04", 3836019503U), "mercy_04", false, anchor_x04b.Entity);
            custom_animation_relative(brute_01.Entity, GetTag<AnimationGraphTag>("objects\\characters\\brute\\x04\\x04", 3835233059U), "brute01_04", false, anchor_x04b.Entity);
            custom_animation_relative(brute_02.Entity, GetTag<AnimationGraphTag>("objects\\characters\\brute\\x04\\x04", 3835233059U), "brute02_04", false, anchor_x04b.Entity);
            scenery_animation_start_relative(hammer.Entity, GetTag<AnimationGraphTag>("objects\\weapons\\melee\\gravity_hammer\\x04\\x04", 3835429670U), "hammer_04", anchor_x04b.Entity);
            scenery_animation_start_relative(sarcophagus.Entity, GetTag<AnimationGraphTag>("scenarios\\objects\\solo\\alphagasgiant\\sarcophagus\\sarcophagus", 3836150577U), "x04_04", anchor_x04b.Entity);
            await sleep((short)((float)camera_time() - this.prediction_offset));
            await this.x04_05_predict_stub();
            await sleep((short)((float)camera_time() - this.sound_offset));
            sound_impulse_predict(GetTag<SoundTag>("sound\\cinematics\\04_alphagas\\x04\\foley\\x04_05_fol", 3836216114U));
            await sleep((short)camera_time());
        }

        [ScriptMethod(76, Lifecycle.Dormant)]
        public async Task x04_foley_05()
        {
            await sleep(0);
            sound_impulse_start(GetTag<SoundTag>("sound\\cinematics\\04_alphagas\\x04\\foley\\x04_05_fol", 3836216114U), default(IGameObject), 1F);
            print("x04 foley 05 start");
        }

        [ScriptMethod(77, Lifecycle.Dormant)]
        public async Task x04_0090_tar()
        {
            await sleep(0);
            sound_impulse_start(GetTag<SoundTag>("sound\\dialog\\levels\\04_gasgiant\\cinematic\\x04_0090_tar", 3836281651U), tartarus.Entity, 1F);
            cinematic_subtitle("x04_0090_tar", 5.5F);
        }

        [ScriptMethod(78, Lifecycle.Dormant)]
        public async Task x04_0100_pot()
        {
            await sleep(157);
            sound_impulse_start(GetTag<SoundTag>("sound\\dialog\\levels\\04_gasgiant\\cinematic\\x04_0100_pot", 3836347188U), truth.Entity, 1F);
            cinematic_subtitle("x04_0100_pot", 2F);
        }

        [ScriptMethod(79, Lifecycle.Dormant)]
        public async Task x04_0110_tar()
        {
            await sleep(205);
            sound_impulse_start(GetTag<SoundTag>("sound\\dialog\\levels\\04_gasgiant\\cinematic\\x04_0110_tar", 3836412725U), tartarus.Entity, 1F);
            cinematic_subtitle("x04_0110_tar", 2F);
        }

        [ScriptMethod(80, Lifecycle.Dormant)]
        public async Task x04_0120_pot()
        {
            await sleep(242);
            sound_impulse_start(GetTag<SoundTag>("sound\\dialog\\levels\\04_gasgiant\\cinematic\\x04_0120_pot", 3836478262U), truth.Entity, 1F);
            cinematic_subtitle("x04_0120_pot", 2F);
        }

        [ScriptMethod(81, Lifecycle.Dormant)]
        public async Task x04_0130_tar()
        {
            await sleep(385);
            sound_impulse_start(GetTag<SoundTag>("sound\\dialog\\levels\\04_gasgiant\\cinematic\\x04_0130_tar", 3836543799U), tartarus.Entity, 1F);
            cinematic_subtitle("x04_0130_tar", 1.5F);
        }

        [ScriptMethod(82, Lifecycle.Dormant)]
        public async Task x04_0140_pot()
        {
            await sleep(554);
            sound_impulse_start(GetTag<SoundTag>("sound\\dialog\\levels\\04_gasgiant\\cinematic\\x04_0140_pot", 3836609336U), truth.Entity, 1F);
            cinematic_subtitle("x04_0140_pot", 5F);
        }

        [ScriptMethod(83, Lifecycle.Dormant)]
        public async Task x04_0150_pot()
        {
            await sleep(731);
            sound_impulse_start(GetTag<SoundTag>("sound\\dialog\\levels\\04_gasgiant\\cinematic\\x04_0150_pot", 3836674873U), truth.Entity, 1F);
            cinematic_subtitle("x04_0150_pot", 4F);
        }

        [ScriptMethod(84, Lifecycle.Dormant)]
        public async Task x04_05_dof_1()
        {
            await sleep(708);
            cinematic_screen_effect_start(true);
            cinematic_screen_effect_set_depth_of_field(2F, 0F, 0F, 0.001F, 0.5F, 0.5F, 0.001F);
            print("rack focus");
        }

        [ScriptMethod(85, Lifecycle.Dormant)]
        public async Task x04_cinematic_lighting_scene_05()
        {
            cinematic_lighting_set_primary_light(-41F, 270F, 0.25F, 0.32F, 0.52F);
            cinematic_lighting_set_secondary_light(58F, 78F, 0.21F, 0.11F, 0.22F);
            cinematic_lighting_set_ambient_light(0.06F, 0.05F, 0.04F);
            render_lights_enable_cinematic_shadow(true, dervish.Entity, "head", 0.2F);
            render_lights_enable_cinematic_shadow(true, truth.Entity, "head", 0.2F);
            render_lights_enable_cinematic_shadow(true, mercy.Entity, "head", 0.2F);
            render_lights_enable_cinematic_shadow(true, tartarus.Entity, "head", 0.2F);
        }

        [ScriptMethod(86, Lifecycle.Static)]
        public async Task x04_05_setup()
        {
            wake(new ScriptMethodReference(x04_foley_05));
            wake(new ScriptMethodReference(x04_0090_tar));
            wake(new ScriptMethodReference(x04_0100_pot));
            wake(new ScriptMethodReference(x04_0110_tar));
            wake(new ScriptMethodReference(x04_0120_pot));
            wake(new ScriptMethodReference(x04_0130_tar));
            wake(new ScriptMethodReference(x04_0140_pot));
            wake(new ScriptMethodReference(x04_0150_pot));
            wake(new ScriptMethodReference(x04_cinematic_lighting_scene_05));
        }

        [ScriptMethod(87, Lifecycle.Static)]
        public async Task x04_05_cleanup()
        {
            object_destroy(tartarus.Entity);
            object_destroy(brute_01.Entity);
            object_destroy(brute_02.Entity);
            object_destroy(hammer.Entity);
        }

        [ScriptMethod(88, Lifecycle.Static)]
        public async Task x04_scene_05()
        {
            await this.x04_05_setup();
            cinematic_set_near_clip_distance(0.05F);
            print("setting near distance to .05");
            camera_set_animation_relative(GetTag<AnimationGraphTag>("objects\\characters\\cinematic_camera\\x04\\x04", 3835036448U), "x04_05", default(IUnit), anchor_flag_x04b);
            custom_animation_relative(dervish.Entity, GetTag<AnimationGraphTag>("objects\\characters\\dervish\\x04\\x04", 3835101985U), "dervish_05", false, anchor_x04b.Entity);
            custom_animation_relative(tartarus.Entity, GetTag<AnimationGraphTag>("objects\\characters\\brute\\x04\\x04", 3835233059U), "tartarus_05", false, anchor_x04b.Entity);
            custom_animation_relative(truth.Entity, GetTag<AnimationGraphTag>("objects\\characters\\prophet\\x04\\x04", 3836019503U), "truth_05", false, anchor_x04b.Entity);
            custom_animation_relative(brute_01.Entity, GetTag<AnimationGraphTag>("objects\\characters\\brute\\x04\\x04", 3835233059U), "brute01_05", false, anchor_x04b.Entity);
            custom_animation_relative(brute_02.Entity, GetTag<AnimationGraphTag>("objects\\characters\\brute\\x04\\x04", 3835233059U), "brute02_05", false, anchor_x04b.Entity);
            scenery_animation_start_relative(hammer.Entity, GetTag<AnimationGraphTag>("objects\\weapons\\melee\\gravity_hammer\\x04\\x04", 3835429670U), "hammer_05", anchor_x04b.Entity);
            scenery_animation_start_relative(sarcophagus.Entity, GetTag<AnimationGraphTag>("scenarios\\objects\\solo\\alphagasgiant\\sarcophagus\\sarcophagus", 3836150577U), "x04_05", anchor_x04b.Entity);
            await sleep((short)((float)camera_time() - this.prediction_offset));
            await this.x04_06_predict_stub();
            await sleep((short)((float)camera_time() - this.sound_offset));
            sound_impulse_predict(GetTag<SoundTag>("sound\\cinematics\\04_alphagas\\x04\\music\\06_mus", 3836740410U));
            sound_impulse_predict(GetTag<SoundTag>("sound\\cinematics\\04_alphagas\\x04\\foley\\x04_06_fol", 3836805947U));
            await sleep((short)camera_time());
            await this.x04_05_cleanup();
        }

        [ScriptMethod(89, Lifecycle.Dormant)]
        public async Task x04_score_06()
        {
            await sleep(0);
            sound_impulse_start(GetTag<SoundTag>("sound\\cinematics\\04_alphagas\\x04\\music\\06_mus", 3836740410U), default(IGameObject), 1F);
            print("x04 score 06 start");
        }

        [ScriptMethod(90, Lifecycle.Dormant)]
        public async Task x04_foley_06()
        {
            await sleep(0);
            sound_impulse_start(GetTag<SoundTag>("sound\\cinematics\\04_alphagas\\x04\\foley\\x04_06_fol", 3836805947U), default(IGameObject), 1F);
            print("x04 foley 06 start");
        }

        [ScriptMethod(91, Lifecycle.Dormant)]
        public async Task x04_0160_der()
        {
            await sleep(0);
            sound_impulse_start(GetTag<SoundTag>("sound\\dialog\\levels\\04_gasgiant\\cinematic\\x04_0160_der", 3836871484U), dervish.Entity, 1F);
            cinematic_subtitle("x04_0160_der", 2F);
        }

        [ScriptMethod(92, Lifecycle.Dormant)]
        public async Task x04_0170_pot()
        {
            await sleep(46);
            sound_impulse_start(GetTag<SoundTag>("sound\\dialog\\levels\\04_gasgiant\\cinematic\\x04_0170_pot", 3836937021U), truth.Entity, 1F);
            cinematic_subtitle("x04_0170_pot", 1.25F);
        }

        [ScriptMethod(93, Lifecycle.Dormant)]
        public async Task x04_0180_pot()
        {
            await sleep(104);
            sound_impulse_start(GetTag<SoundTag>("sound\\dialog\\levels\\04_gasgiant\\cinematic\\x04_0180_pot", 3837002558U), truth.Entity, 1F);
            cinematic_subtitle("x04_0180_pot", 2F);
        }

        [ScriptMethod(94, Lifecycle.Dormant)]
        public async Task x04_0190_der()
        {
            await sleep(152);
            sound_impulse_start(GetTag<SoundTag>("sound\\dialog\\levels\\04_gasgiant\\cinematic\\x04_0190_der", 3837068095U), dervish.Entity, 1F);
            cinematic_subtitle("x04_0190_der", 3F);
        }

        [ScriptMethod(95, Lifecycle.Dormant)]
        public async Task x04_0200_pot()
        {
            await sleep(237);
            sound_impulse_start(GetTag<SoundTag>("sound\\dialog\\levels\\04_gasgiant\\cinematic\\x04_0200_pot", 3837133632U), truth.Entity, 1F);
            cinematic_subtitle("x04_0200_pot", 1.25F);
        }

        [ScriptMethod(96, Lifecycle.Dormant)]
        public async Task x04_0210_pot()
        {
            await sleep(301);
            sound_impulse_start(GetTag<SoundTag>("sound\\dialog\\levels\\04_gasgiant\\cinematic\\x04_0210_pot", 3837199169U), truth.Entity, 1F);
            cinematic_subtitle("x04_0210_pot", 11F);
        }

        [ScriptMethod(97, Lifecycle.Dormant)]
        public async Task x04_0220_pom()
        {
            await sleep(624);
            sound_impulse_start(GetTag<SoundTag>("sound\\dialog\\levels\\04_gasgiant\\cinematic\\x04_0220_pom", 3837264706U), mercy.Entity, 1F);
            cinematic_subtitle("x04_0220_pom", 8.25F);
        }

        [ScriptMethod(98, Lifecycle.Dormant)]
        public async Task x04_0230_der()
        {
            await sleep(851);
            sound_impulse_start(GetTag<SoundTag>("sound\\dialog\\levels\\04_gasgiant\\cinematic\\x04_0230_der", 3837330243U), dervish.Entity, 1F);
            cinematic_subtitle("x04_0230_der", 3.5F);
        }

        [ScriptMethod(99, Lifecycle.Dormant)]
        public async Task x04_0240_pot()
        {
            await sleep(955);
            sound_impulse_start(GetTag<SoundTag>("sound\\dialog\\levels\\04_gasgiant\\cinematic\\x04_0240_pot", 3837395780U), truth.Entity, 1F);
            cinematic_subtitle("x04_0240_pot", 10F);
        }

        [ScriptMethod(100, Lifecycle.Dormant)]
        public async Task x04_06_dof_1()
        {
            await sleep(0);
            cinematic_screen_effect_stop();
            print("rack focus stop");
            await sleep(280);
            cinematic_screen_effect_start(true);
            cinematic_screen_effect_set_depth_of_field(2F, 0F, 0F, 0F, 0.5F, 0.5F, 0F);
            print("rack focus");
            await sleep(118);
            cinematic_screen_effect_start(true);
            cinematic_screen_effect_set_depth_of_field(2F, 0.5F, 0.5F, 1F, 0F, 0F, 1F);
            print("rack focus");
            await sleep(87);
            cinematic_screen_effect_set_depth_of_field(2F, 0F, 0F, 0.001F, 0F, 0F, 0.001F);
            print("rack focus");
            await sleep(230);
            cinematic_screen_effect_set_depth_of_field(2F, 0F, 0F, 0.001F, 0.5F, 0.5F, 0.001F);
            print("rack focus");
            await sleep(179);
            cinematic_screen_effect_stop();
            print("rack focus stop");
        }

        [ScriptMethod(101, Lifecycle.Static)]
        public async Task x04_06_setup()
        {
            object_destroy_containing("brute");
            wake(new ScriptMethodReference(x04_score_06));
            wake(new ScriptMethodReference(x04_foley_06));
            wake(new ScriptMethodReference(x04_0160_der));
            wake(new ScriptMethodReference(x04_0170_pot));
            wake(new ScriptMethodReference(x04_0180_pot));
            wake(new ScriptMethodReference(x04_0190_der));
            wake(new ScriptMethodReference(x04_0200_pot));
            wake(new ScriptMethodReference(x04_0210_pot));
            wake(new ScriptMethodReference(x04_0220_pom));
            wake(new ScriptMethodReference(x04_0230_der));
            wake(new ScriptMethodReference(x04_0240_pot));
        }

        [ScriptMethod(102, Lifecycle.Static)]
        public async Task x04_scene_06()
        {
            await this.x04_06_setup();
            cinematic_set_near_clip_distance(0.06F);
            print("resetting near distance to .06");
            camera_set_animation_relative(GetTag<AnimationGraphTag>("objects\\characters\\cinematic_camera\\x04\\x04", 3835036448U), "x04_06", default(IUnit), anchor_flag_x04b);
            custom_animation_relative(dervish.Entity, GetTag<AnimationGraphTag>("objects\\characters\\dervish\\x04\\x04", 3835101985U), "dervish_06", false, anchor_x04b.Entity);
            custom_animation_relative(truth.Entity, GetTag<AnimationGraphTag>("objects\\characters\\prophet\\x04\\x04", 3836019503U), "truth_06", false, anchor_x04b.Entity);
            custom_animation_relative(mercy.Entity, GetTag<AnimationGraphTag>("objects\\characters\\prophet\\x04\\x04", 3836019503U), "mercy_06", false, anchor_x04b.Entity);
            scenery_animation_start_relative(sarcophagus.Entity, GetTag<AnimationGraphTag>("scenarios\\objects\\solo\\alphagasgiant\\sarcophagus\\sarcophagus", 3836150577U), "x04_06", anchor_x04b.Entity);
            await sleep((short)((float)camera_time() - this.prediction_offset));
            await this.x04_07_predict_stub();
            await sleep((short)((float)camera_time() - this.sound_offset));
            sound_impulse_predict(GetTag<SoundTag>("sound\\cinematics\\04_alphagas\\x04\\foley\\x04_07_fol", 3837461317U));
            await sleep((short)camera_time());
        }

        [ScriptMethod(103, Lifecycle.Dormant)]
        public async Task x04_foley_07()
        {
            await sleep(0);
            sound_impulse_start(GetTag<SoundTag>("sound\\cinematics\\04_alphagas\\x04\\foley\\x04_07_fol", 3837461317U), default(IGameObject), 1F);
            print("x04 foley 07 start");
        }

        [ScriptMethod(104, Lifecycle.Dormant)]
        public async Task x04_0250_pot()
        {
            await sleep(172);
            sound_impulse_start(GetTag<SoundTag>("sound\\dialog\\levels\\04_gasgiant\\cinematic\\x04_0250_pot", 3837526854U), truth.Entity, 1F);
            cinematic_subtitle("x04_0250_pot", 8F);
        }

        [ScriptMethod(105, Lifecycle.Dormant)]
        public async Task x04_0260_hld()
        {
            await sleep(400);
            sound_impulse_start(GetTag<SoundTag>("sound\\dialog\\levels\\04_gasgiant\\cinematic\\x04_0260_her", 3837592391U), heretic_leader_holo_01.Entity, 1F);
            cinematic_subtitle("x04_0260_her", 10.5F);
        }

        [ScriptMethod(106, Lifecycle.Dormant)]
        public async Task x04_0270_pot()
        {
            await sleep(719);
            sound_impulse_start(GetTag<SoundTag>("sound\\dialog\\levels\\04_gasgiant\\cinematic\\x04_0270_pot", 3837657928U), truth.Entity, 1F);
            cinematic_subtitle("x04_0270_pot", 5F);
        }

        [ScriptMethod(107, Lifecycle.Dormant)]
        public async Task x04_0280_pom()
        {
            await sleep(872);
            sound_impulse_start(GetTag<SoundTag>("sound\\dialog\\levels\\04_gasgiant\\cinematic\\x04_0280_pom", 3837723465U), mercy.Entity, 1F);
            cinematic_subtitle("x04_0280_pom", 3.5F);
        }

        [ScriptMethod(108, Lifecycle.Static)]
        public async Task x04_07_setup()
        {
            object_create_anew(heretic_leader_holo_01);
            object_cinematic_lod(heretic_leader_holo_01.Entity, true);
            wake(new ScriptMethodReference(x04_foley_07));
            wake(new ScriptMethodReference(x04_0250_pot));
            wake(new ScriptMethodReference(x04_0260_hld));
            wake(new ScriptMethodReference(x04_0270_pot));
            wake(new ScriptMethodReference(x04_0280_pom));
        }

        [ScriptMethod(109, Lifecycle.Static)]
        public async Task x04_scene_07()
        {
            await this.x04_07_setup();
            camera_set_animation_relative(GetTag<AnimationGraphTag>("objects\\characters\\cinematic_camera\\x04\\x04", 3835036448U), "x04_07", default(IUnit), anchor_flag_x04b);
            custom_animation_relative(dervish.Entity, GetTag<AnimationGraphTag>("objects\\characters\\dervish\\x04\\x04", 3835101985U), "dervish_07", false, anchor_x04b.Entity);
            custom_animation_relative(truth.Entity, GetTag<AnimationGraphTag>("objects\\characters\\prophet\\x04\\x04", 3836019503U), "truth_07", false, anchor_x04b.Entity);
            custom_animation_relative(mercy.Entity, GetTag<AnimationGraphTag>("objects\\characters\\prophet\\x04\\x04", 3836019503U), "mercy_07", false, anchor_x04b.Entity);
            custom_animation_relative(heretic_leader_holo_01.Entity, GetTag<AnimationGraphTag>("objects\\characters\\heretic\\x04\\x04", 3837789002U), "heretic_07", false, anchor_x04b.Entity);
            scenery_animation_start_relative(sarcophagus.Entity, GetTag<AnimationGraphTag>("scenarios\\objects\\solo\\alphagasgiant\\sarcophagus\\sarcophagus", 3836150577U), "x04_07", anchor_x04b.Entity);
            await sleep((short)((float)camera_time() - this.prediction_offset));
            await this.x04_08_predict_stub();
            await sleep((short)((float)camera_time() - this.sound_offset));
            sound_impulse_predict(GetTag<SoundTag>("sound\\cinematics\\04_alphagas\\x04\\music\\08_mus", 3837920076U));
            sound_impulse_predict(GetTag<SoundTag>("sound\\cinematics\\04_alphagas\\x04\\foley\\x04_08_fol", 3837985613U));
            await sleep((short)camera_time());
            object_destroy(heretic_leader_holo_01.Entity);
        }

        [ScriptMethod(110, Lifecycle.Dormant)]
        public async Task x04_score_08()
        {
            await sleep(419);
            sound_impulse_start(GetTag<SoundTag>("sound\\cinematics\\04_alphagas\\x04\\music\\08_mus", 3837920076U), default(IGameObject), 1F);
            print("x04 score 08 start");
        }

        [ScriptMethod(111, Lifecycle.Dormant)]
        public async Task x04_foley_08()
        {
            await sleep(0);
            sound_impulse_start(GetTag<SoundTag>("sound\\cinematics\\04_alphagas\\x04\\foley\\x04_08_fol", 3837985613U), default(IGameObject), 1F);
            print("x04 foley 08 start");
        }

        [ScriptMethod(112, Lifecycle.Dormant)]
        public async Task x04_0290_der()
        {
            await sleep(0);
            sound_impulse_start(GetTag<SoundTag>("sound\\dialog\\levels\\04_gasgiant\\cinematic\\x04_0290_der", 3838051150U), dervish.Entity, 1F);
            cinematic_subtitle("x04_0290_der", 5F);
        }

        [ScriptMethod(113, Lifecycle.Dormant)]
        public async Task x04_0300_pot()
        {
            await sleep(157);
            sound_impulse_start(GetTag<SoundTag>("sound\\dialog\\levels\\04_gasgiant\\cinematic\\x04_0300_pot", 3838116687U), truth.Entity, 1F);
            cinematic_subtitle("x04_0300_pot", 5F);
        }

        [ScriptMethod(114, Lifecycle.Dormant)]
        public async Task x04_0310_pot()
        {
            await sleep(312);
            sound_impulse_start(GetTag<SoundTag>("sound\\dialog\\levels\\04_gasgiant\\cinematic\\x04_0310_pot", 3838182224U), truth.Entity, 1F);
            cinematic_subtitle("x04_0310_pot", 6F);
            unit_set_emotional_state(truth.Entity, "happy", 0.75F, 60);
        }

        [ScriptMethod(115, Lifecycle.Static)]
        public async Task x04_08_setup()
        {
            wake(new ScriptMethodReference(x04_score_08));
            wake(new ScriptMethodReference(x04_foley_08));
            wake(new ScriptMethodReference(x04_0290_der));
            wake(new ScriptMethodReference(x04_0300_pot));
            wake(new ScriptMethodReference(x04_0310_pot));
        }

        [ScriptMethod(116, Lifecycle.Static)]
        public async Task x04_scene_08()
        {
            cinematic_screen_effect_stop();
            await this.x04_08_setup();
            camera_set_animation_relative(GetTag<AnimationGraphTag>("objects\\characters\\cinematic_camera\\x04\\x04", 3835036448U), "x04_08", default(IUnit), anchor_flag_x04b);
            custom_animation_relative(dervish.Entity, GetTag<AnimationGraphTag>("objects\\characters\\dervish\\x04\\x04", 3835101985U), "dervish_08", false, anchor_x04b.Entity);
            custom_animation_relative(truth.Entity, GetTag<AnimationGraphTag>("objects\\characters\\prophet\\x04\\x04", 3836019503U), "truth_08", false, anchor_x04b.Entity);
            custom_animation_relative(mercy.Entity, GetTag<AnimationGraphTag>("objects\\characters\\prophet\\x04\\x04", 3836019503U), "mercy_08", false, anchor_x04b.Entity);
            scenery_animation_start_relative(sarcophagus.Entity, GetTag<AnimationGraphTag>("scenarios\\objects\\solo\\alphagasgiant\\sarcophagus\\sarcophagus", 3836150577U), "x04_08", anchor_x04b.Entity);
            await sleep((short)((float)camera_time() - this.prediction_offset));
            await this.x04_09_predict_stub();
            await sleep((short)((float)camera_time() - this.sound_offset));
            sound_impulse_predict(GetTag<SoundTag>("sound\\cinematics\\04_alphagas\\x04\\foley\\x04_09_fol", 3838247761U));
            await sleep((short)camera_time());
        }

        [ScriptMethod(117, Lifecycle.Dormant)]
        public async Task x04_foley_09()
        {
            await sleep(0);
            sound_impulse_start(GetTag<SoundTag>("sound\\cinematics\\04_alphagas\\x04\\foley\\x04_09_fol", 3838247761U), default(IGameObject), 1F);
            print("x04 foley 09 start");
        }

        [ScriptMethod(118, Lifecycle.Dormant)]
        public async Task x04_0320_der()
        {
            await sleep(63);
            sound_impulse_start(GetTag<SoundTag>("sound\\dialog\\levels\\04_gasgiant\\cinematic\\x04_0320_der", 3838313298U), dervish.Entity, 1F);
            cinematic_subtitle("x04_0320_der", 1.25F);
        }

        [ScriptMethod(119, Lifecycle.Dormant)]
        public async Task x04_0330_pom()
        {
            await sleep(100);
            sound_impulse_start(GetTag<SoundTag>("sound\\dialog\\levels\\04_gasgiant\\cinematic\\x04_0330_pom", 3838378835U), mercy.Entity, 1F);
            cinematic_subtitle("x04_0330_pom", 12F);
        }

        [ScriptMethod(120, Lifecycle.Static)]
        public async Task x04_09_setup()
        {
            wake(new ScriptMethodReference(x04_foley_09));
            wake(new ScriptMethodReference(x04_0320_der));
            wake(new ScriptMethodReference(x04_0330_pom));
        }

        [ScriptMethod(121, Lifecycle.Static)]
        public async Task x04_scene_09()
        {
            await this.x04_09_setup();
            camera_set_animation_relative(GetTag<AnimationGraphTag>("objects\\characters\\cinematic_camera\\x04\\x04", 3835036448U), "x04_09", default(IUnit), anchor_flag_x04b);
            custom_animation_relative(dervish.Entity, GetTag<AnimationGraphTag>("objects\\characters\\dervish\\x04\\x04", 3835101985U), "dervish_09", false, anchor_x04b.Entity);
            custom_animation_relative(truth.Entity, GetTag<AnimationGraphTag>("objects\\characters\\prophet\\x04\\x04", 3836019503U), "truth_09", false, anchor_x04b.Entity);
            custom_animation_relative(mercy.Entity, GetTag<AnimationGraphTag>("objects\\characters\\prophet\\x04\\x04", 3836019503U), "mercy_09", false, anchor_x04b.Entity);
            scenery_animation_start_relative(sarcophagus.Entity, GetTag<AnimationGraphTag>("scenarios\\objects\\solo\\alphagasgiant\\sarcophagus\\sarcophagus", 3836150577U), "x04_09", anchor_x04b.Entity);
            await sleep((short)((float)camera_time() - this.prediction_offset));
            await this.x04_10_predict_stub();
            await sleep((short)((float)camera_time() - this.sound_offset));
            sound_impulse_predict(GetTag<SoundTag>("sound\\cinematics\\04_alphagas\\x04\\music\\10_mus", 3838444372U));
            sound_impulse_predict(GetTag<SoundTag>("sound\\cinematics\\04_alphagas\\x04\\foley\\x04_10_fol", 3838509909U));
            await sleep((short)camera_time());
        }

        [ScriptMethod(122, Lifecycle.Dormant)]
        public async Task x04_score_10()
        {
            await sleep(538);
            sound_impulse_start(GetTag<SoundTag>("sound\\cinematics\\04_alphagas\\x04\\music\\10_mus", 3838444372U), default(IGameObject), 1F);
            print("x04 score 10 start");
        }

        [ScriptMethod(123, Lifecycle.Dormant)]
        public async Task x04_foley_10()
        {
            await sleep(0);
            sound_impulse_start(GetTag<SoundTag>("sound\\cinematics\\04_alphagas\\x04\\foley\\x04_10_fol", 3838509909U), default(IGameObject), 1F);
            print("x04 foley 10 start");
        }

        [ScriptMethod(124, Lifecycle.Dormant)]
        public async Task x04_0370_der()
        {
            await sleep(566);
            sound_impulse_start(GetTag<SoundTag>("sound\\dialog\\levels\\04_gasgiant\\cinematic\\x04_0340_der", 3838575446U), dervish.Entity, 1F);
            cinematic_subtitle("x04_0340_der", 3F);
        }

        [ScriptMethod(125, Lifecycle.Static)]
        public async Task x04_10_setup()
        {
            wake(new ScriptMethodReference(x04_score_10));
            wake(new ScriptMethodReference(x04_foley_10));
            wake(new ScriptMethodReference(x04_0370_der));
        }

        [ScriptMethod(126, Lifecycle.Static)]
        public async Task x04_10_cleanup()
        {
            object_destroy(dervish.Entity);
            object_destroy(truth.Entity);
            object_destroy(mercy.Entity);
            object_destroy_containing("throne");
            object_destroy(sarcophagus.Entity);
        }

        [ScriptMethod(127, Lifecycle.Static)]
        public async Task x04_scene_10()
        {
            await this.x04_10_setup();
            camera_set_animation_relative(GetTag<AnimationGraphTag>("objects\\characters\\cinematic_camera\\x04\\x04", 3835036448U), "x04_10", default(IUnit), anchor_flag_x04b);
            custom_animation_relative(dervish.Entity, GetTag<AnimationGraphTag>("objects\\characters\\dervish\\x04\\x04", 3835101985U), "dervish_10", false, anchor_x04b.Entity);
            custom_animation_relative(truth.Entity, GetTag<AnimationGraphTag>("objects\\characters\\prophet\\x04\\x04", 3836019503U), "truth_10", false, anchor_x04b.Entity);
            custom_animation_relative(mercy.Entity, GetTag<AnimationGraphTag>("objects\\characters\\prophet\\x04\\x04", 3836019503U), "mercy_10", false, anchor_x04b.Entity);
            scenery_animation_start_relative(sarcophagus.Entity, GetTag<AnimationGraphTag>("scenarios\\objects\\solo\\alphagasgiant\\sarcophagus\\sarcophagus", 3836150577U), "x04_10", anchor_x04b.Entity);
            await sleep((short)((float)camera_time() - 5));
            fade_out(0F, 0F, 0F, 5);
            await sleep(5);
            await this.x04_10_cleanup();
        }

        [ScriptMethod(128, Lifecycle.Static)]
        public async Task x04()
        {
            texture_cache_flush();
            geometry_cache_flush();
            switch_bsp_by_name(GetReference<IBsp>("high_4_cinematic"));
            await sleep(1);
            await this.x04_scene_01();
            await this.x04_scene_02a();
            await this.x04_scene_02b();
            await this.x04_scene_03b();
            await this.x04_scene_04();
            await this.x04_scene_05();
            await this.x04_scene_06();
            await this.x04_scene_07();
            await this.x04_scene_08();
            await this.x04_scene_09();
            await this.x04_scene_10();
            await sleep(30);
        }

        [ScriptMethod(129, Lifecycle.Dormant)]
        public async Task c04_intro_sound_scene1_01()
        {
            object_set_function_variable(phantom01.Entity, "engine_hack", 1F, 0F);
            object_set_function_variable(phantom02.Entity, "engine_hack", 1F, 0F);
            object_set_function_variable(phantom03.Entity, "engine_hack", 1F, 0F);
            object_set_function_variable(phantom01.Entity, "engine_audio", 1F, 0F);
            object_set_function_variable(phantom02.Entity, "engine_audio", 1F, 0F);
            object_set_function_variable(phantom03.Entity, "engine_audio", 1F, 0F);
            object_set_function_variable(phantom01.Entity, "hover_audio", 1F, 0F);
            object_set_function_variable(phantom02.Entity, "hover_audio", 1F, 0F);
            object_set_function_variable(phantom03.Entity, "hover_audio", 1F, 0F);
            sound_class_set_gain("vehicle", 0F, 0);
            sound_class_set_gain("vehicle", 1F, 90);
            object_set_velocity(phantom01.Entity, 30F);
            object_set_velocity(phantom02.Entity, 30F);
            object_set_velocity(phantom03.Entity, 30F);
            await sleep(105);
            sound_class_set_gain("vehicle", 0F, 150);
        }

        [ScriptMethod(130, Lifecycle.Dormant)]
        public async Task c04_intro_foley_01()
        {
            await sleep(0);
            sound_impulse_start(GetTag<SoundTag>("sound\\cinematics\\04_alphagas\\c04_intro\\foley\\c04_intro_01_fol", 3838640983U), default(IGameObject), 1F);
            print("c04_intro foley 01 start");
        }

        [ScriptMethod(131, Lifecycle.Dormant)]
        public async Task c04_1010_soc()
        {
            await sleep(95);
            sound_impulse_start(GetTag<SoundTag>("sound\\dialog\\levels\\04_gasgiant\\cinematic\\c04_1010_soc", 3838706520U), default(IGameObject), 1F);
            cinematic_subtitle("c04_1010_soc", 2F);
        }

        [ScriptMethod(132, Lifecycle.Dormant)]
        public async Task c04_1020_sec()
        {
            await sleep(167);
            sound_impulse_start(GetTag<SoundTag>("sound\\dialog\\levels\\04_gasgiant\\cinematic\\c04_1020_sec", 3838772057U), default(IGameObject), 1F);
            cinematic_subtitle("c04_1020_sec", 4F);
        }

        [ScriptMethod(133, Lifecycle.Dormant)]
        public async Task c04_1030_soc()
        {
            await sleep(279);
            sound_impulse_start(GetTag<SoundTag>("sound\\dialog\\levels\\04_gasgiant\\cinematic\\c04_1030_soc", 3838837594U), default(IGameObject), 1F);
            cinematic_subtitle("c04_1030_soc", 6F);
        }

        [ScriptMethod(134, Lifecycle.Dormant)]
        public async Task c04_intro_cinematic_lighting_01()
        {
            cinematic_lighting_set_primary_light(-64F, 276F, 0.427451F, 0.337255F, 0.337255F);
            cinematic_lighting_set_secondary_light(-73F, 160F, 0.117647F, 0.117647F, 0.176471F);
            cinematic_lighting_set_ambient_light(0.0156863F, 0.0156863F, 0.0156863F);
            rasterizer_bloom_override_threshold(0.6F);
            rasterizer_bloom_override_brightness(0.5F);
            object_uses_cinematic_lighting(phantom01.Entity, true);
            object_uses_cinematic_lighting(phantom02.Entity, true);
            object_uses_cinematic_lighting(phantom03.Entity, true);
        }

        [ScriptMethod(135, Lifecycle.Static)]
        public async Task c04_intro_01_problem_actors()
        {
            print("problem actors");
            object_create_anew(phantom01);
            object_create_anew(phantom02);
            object_create_anew(phantom03);
            object_create_anew(matte_high_charity);
            object_create_anew(matte_threshold);
            object_create_anew(matte_halo_01);
            object_create_anew(stardust_01);
            object_create_anew(stardust_02);
            object_cinematic_lod(phantom01.Entity, true);
            object_cinematic_lod(phantom02.Entity, true);
            object_cinematic_lod(phantom03.Entity, true);
        }

        [ScriptMethod(136, Lifecycle.Static)]
        public async Task c04_intro_02a_problem_actors()
        {
            print("problem actors");
            object_create_anew(dervish02);
            object_create_anew(commander);
            object_create_anew(elite01);
            object_create_anew(elite02);
            object_create_anew(elite03);
            object_create_anew(elite04);
            object_create_anew(elite05);
            object_create_anew(elite06);
            object_create_anew(elite07);
            object_create_anew(grunt01);
            object_create_anew(grunt02);
            object_create_anew(grunt03);
            object_create_anew(grunt04);
            object_create_anew(phantom_int);
            object_cinematic_lod(dervish02.Entity, true);
            object_cinematic_lod(commander.Entity, true);
            object_cinematic_lod(elite01.Entity, true);
            object_cinematic_lod(elite02.Entity, true);
            object_cinematic_lod(elite03.Entity, true);
            object_cinematic_lod(elite04.Entity, true);
            object_cinematic_lod(elite05.Entity, true);
            object_cinematic_lod(elite06.Entity, true);
            object_cinematic_lod(elite07.Entity, true);
            object_cinematic_lod(grunt01.Entity, true);
            object_cinematic_lod(grunt02.Entity, true);
            object_cinematic_lod(grunt03.Entity, true);
            object_cinematic_lod(grunt04.Entity, true);
            object_cinematic_lod(phantom_int.Entity, true);
        }

        [ScriptMethod(137, Lifecycle.Static)]
        public async Task c04_intro_01_setup()
        {
            wake(new ScriptMethodReference(c04_intro_foley_01));
            wake(new ScriptMethodReference(c04_1010_soc));
            wake(new ScriptMethodReference(c04_1020_sec));
            wake(new ScriptMethodReference(c04_1030_soc));
            wake(new ScriptMethodReference(c04_intro_sound_scene1_01));
            wake(new ScriptMethodReference(c04_intro_cinematic_lighting_01));
        }

        [ScriptMethod(138, Lifecycle.Static)]
        public async Task c04_intro_01_cleanup()
        {
            object_destroy(intro_fleet.Entity);
            object_destroy_containing("stardust");
            object_destroy_containing("matte");
        }

        [ScriptMethod(139, Lifecycle.Static)]
        public async Task c04_intro_01()
        {
            fade_out(0F, 0F, 0F, 0);
            object_create_anew(intro_fleet);
            camera_control(true);
            cinematic_start_movie("gasgiant_intro");
            cinematic_start();
            this.cinematic_letterbox_style = 1;
            camera_set_field_of_view(60F, 0);
            await this._04_intro_01_predict_stub();
            sound_impulse_predict(GetTag<SoundTag>("sound\\cinematics\\03_earthcity\\c03_intro\\foley\\c03_intro_03_fol", 3838903131U));
            await this.c04_intro_01_problem_actors();
            await sleep(this.prediction_offset);
            await this.c04_intro_01_setup();
            camera_set_animation_relative(GetTag<AnimationGraphTag>("objects\\characters\\cinematic_camera\\04_intro\\04_intro", 3838968668U), "04intro_01", default(IUnit), cinematic_anchor03);
            custom_animation_relative(phantom01.Entity, GetTag<AnimationGraphTag>("objects\\vehicles\\phantom\\animations\\04_intro\\04_intro", 3839034205U), "phantom01_01", false, anchor03.Entity);
            custom_animation_relative(phantom02.Entity, GetTag<AnimationGraphTag>("objects\\vehicles\\phantom\\animations\\04_intro\\04_intro", 3839034205U), "phantom02_01", false, anchor03.Entity);
            custom_animation_relative(phantom03.Entity, GetTag<AnimationGraphTag>("objects\\vehicles\\phantom\\animations\\04_intro\\04_intro", 3839034205U), "phantom03_01", false, anchor03.Entity);
            scenery_animation_start_relative(matte_high_charity.Entity, GetTag<AnimationGraphTag>("objects\\cinematics\\matte_paintings\\high_charity_exterior\\04_intro\\04_intro", 3839099742U), "high_charity_exterior_01", anchor03.Entity);
            scenery_animation_start_relative(matte_threshold.Entity, GetTag<AnimationGraphTag>("objects\\cinematics\\matte_paintings\\threshold_space\\04_intro\\04_intro", 3839165279U), "threshold_01", anchor03.Entity);
            scenery_animation_start_relative(matte_halo_01.Entity, GetTag<AnimationGraphTag>("objects\\cinematics\\matte_paintings\\halo_destroyed_03\\04_intro\\04_intro", 3839230816U), "halo_destroyed03_01", anchor03.Entity);
            scenery_animation_start_relative(stardust_01.Entity, GetTag<AnimationGraphTag>("objects\\cinematics\\matte_paintings\\high_charity_stardust\\04_intro\\04_intro", 3839296353U), "stardust01_01", anchor03.Entity);
            scenery_animation_start_relative(stardust_02.Entity, GetTag<AnimationGraphTag>("objects\\cinematics\\matte_paintings\\high_charity_stardust\\04_intro\\04_intro", 3839296353U), "stardust01_02", anchor03.Entity);
            fade_in(0F, 0F, 0F, 30);
            await sleep((short)((float)camera_time() - this.prediction_offset));
            await this._04_intro_02a_predict_stub();
            await sleep((short)((float)camera_time() - 15));
            fade_out(1F, 1F, 1F, 15);
            await sleep(15);
            await this.c04_intro_01_cleanup();
        }

        [ScriptMethod(140, Lifecycle.Dormant)]
        public async Task c04_intro_sound_scene2a_01()
        {
            object_set_function_variable(phantom_int.Entity, "engine_hack", 1F, 0F);
            object_set_function_variable(phantom_int.Entity, "engine_audio", 1F, 0F);
            object_set_function_variable(phantom_int.Entity, "hover_audio", 1F, 0F);
            sound_class_set_gain("vehicle", 0.5F, 15);
        }

        [ScriptMethod(141, Lifecycle.Dormant)]
        public async Task c04_intro_sound_scene2a_02()
        {
            await sleep(720);
            sound_class_set_gain("vehicle", 0F, 15);
        }

        [ScriptMethod(142, Lifecycle.Dormant)]
        public async Task c04_1040_sec()
        {
            await sleep(169);
            sound_impulse_start(GetTag<SoundTag>("sound\\dialog\\levels\\04_gasgiant\\cinematic\\c04_1040_sec", 3840541556U), default(IGameObject), 1F);
            cinematic_subtitle("c04_1040_sec", 2F);
        }

        [ScriptMethod(143, Lifecycle.Dormant)]
        public async Task c04_1050_soc()
        {
            await sleep(239);
            sound_impulse_start(GetTag<SoundTag>("sound\\dialog\\levels\\04_gasgiant\\cinematic\\c04_1050_soc", 3840607093U), commander.Entity, 1F);
            cinematic_subtitle("c04_1050_soc", 6F);
        }

        [ScriptMethod(144, Lifecycle.Dormant)]
        public async Task c04_1060_soc()
        {
            await sleep(400);
            sound_impulse_start(GetTag<SoundTag>("sound\\dialog\\levels\\04_gasgiant\\cinematic\\c04_1060_soc", 3840672630U), commander.Entity, 1F);
            cinematic_subtitle("c04_1060_soc", 5F);
        }

        [ScriptMethod(145, Lifecycle.Dormant)]
        public async Task c04_1070_sog()
        {
            await sleep(552);
            sound_impulse_start(GetTag<SoundTag>("sound\\dialog\\levels\\04_gasgiant\\cinematic\\c04_1070_sog", 3840738167U), default(IGameObject), 1F);
            cinematic_subtitle("c04_1070_sog", 1F);
            print("which grunt is this?");
        }

        [ScriptMethod(146, Lifecycle.Dormant)]
        public async Task c04_intro_02a_fov()
        {
            await sleep(237);
            camera_set_field_of_view(60F, 0);
            print("fov change: 80 -> 60 over 0 ticks");
        }

        [ScriptMethod(147, Lifecycle.Dormant)]
        public async Task c04_intro_cinematic_light_02a()
        {
            cinematic_lighting_set_primary_light(-90F, 0F, 0.23F, 0.29F, 0.53F);
            cinematic_lighting_set_secondary_light(-90F, 192F, 0.16F, 0.1F, 0.19F);
            cinematic_lighting_set_ambient_light(0.07F, 0.05F, 0.08F);
            rasterizer_bloom_override_threshold(0.3F);
            rasterizer_bloom_override_brightness(0.5F);
            object_uses_cinematic_lighting(dervish02.Entity, true);
            object_uses_cinematic_lighting(commander.Entity, true);
            object_uses_cinematic_lighting(elite01.Entity, true);
            object_uses_cinematic_lighting(elite02.Entity, true);
            object_uses_cinematic_lighting(elite03.Entity, true);
            object_uses_cinematic_lighting(elite04.Entity, true);
            object_uses_cinematic_lighting(elite05.Entity, true);
            object_uses_cinematic_lighting(elite06.Entity, true);
            object_uses_cinematic_lighting(elite07.Entity, true);
            object_uses_cinematic_lighting(grunt01.Entity, true);
            object_uses_cinematic_lighting(grunt02.Entity, true);
            object_uses_cinematic_lighting(grunt03.Entity, true);
            object_uses_cinematic_lighting(grunt04.Entity, true);
            object_uses_cinematic_lighting(phantom_int.Entity, true);
        }

        [ScriptMethod(148, Lifecycle.Static)]
        public async Task c04_intro_02a_setup()
        {
            object_create_anew(dervish02);
            object_create_anew(commander);
            object_create_anew(elite01);
            object_create_anew(elite02);
            object_create_anew(elite03);
            object_create_anew(elite04);
            object_create_anew(elite05);
            object_create_anew(elite06);
            object_create_anew(elite07);
            object_create_anew(grunt01);
            object_create_anew(grunt02);
            object_create_anew(grunt03);
            object_create_anew(grunt04);
            object_create_anew(phantom_int);
            object_cinematic_lod(dervish02.Entity, true);
            object_cinematic_lod(commander.Entity, true);
            object_cinematic_lod(elite01.Entity, true);
            object_cinematic_lod(elite02.Entity, true);
            object_cinematic_lod(elite03.Entity, true);
            object_cinematic_lod(elite04.Entity, true);
            object_cinematic_lod(elite05.Entity, true);
            object_cinematic_lod(elite06.Entity, true);
            object_cinematic_lod(elite07.Entity, true);
            object_cinematic_lod(grunt01.Entity, true);
            object_cinematic_lod(grunt02.Entity, true);
            object_cinematic_lod(grunt03.Entity, true);
            object_cinematic_lod(grunt04.Entity, true);
            object_cinematic_lod(phantom_int.Entity, true);
            object_create_anew(beam_rifle01);
            object_create_anew(plasma_rifle01);
            object_create_anew(plasma_rifle02);
            object_create_anew(plasma_rifle03);
            object_create_anew(plasma_rifle04);
            object_create_anew(plasma_rifle05);
            object_create_anew(plasma_rifle06);
            object_create_anew(plasma_pistol01);
            object_create_anew(plasma_pistol02);
            object_create_anew(plasma_pistol03);
            object_create_anew(plasma_pistol04);
            objects_attach(elite05.Entity, "right_hand_elite", beam_rifle01.Entity, "");
            objects_attach(elite01.Entity, "right_hand_elite", plasma_rifle01.Entity, "");
            objects_attach(elite02.Entity, "right_hand_elite", plasma_rifle02.Entity, "");
            objects_attach(elite03.Entity, "right_hand_elite", plasma_rifle03.Entity, "");
            objects_attach(elite04.Entity, "right_hand_elite", plasma_rifle04.Entity, "");
            objects_attach(elite06.Entity, "right_hand_elite", plasma_rifle05.Entity, "");
            objects_attach(elite07.Entity, "right_hand_elite", plasma_rifle06.Entity, "");
            objects_attach(grunt01.Entity, "right_hand", plasma_pistol01.Entity, "");
            objects_attach(grunt01.Entity, "right_hand", plasma_pistol02.Entity, "");
            objects_attach(grunt01.Entity, "right_hand", plasma_pistol03.Entity, "");
            objects_attach(grunt01.Entity, "right_hand", plasma_pistol04.Entity, "");
            wake(new ScriptMethodReference(c04_intro_sound_scene2a_01));
            wake(new ScriptMethodReference(c04_intro_sound_scene2a_02));
            wake(new ScriptMethodReference(c04_1040_sec));
            wake(new ScriptMethodReference(c04_1050_soc));
            wake(new ScriptMethodReference(c04_1060_soc));
            wake(new ScriptMethodReference(c04_1070_sog));
            wake(new ScriptMethodReference(c04_intro_02a_fov));
            wake(new ScriptMethodReference(c04_intro_cinematic_light_02a));
            player_effect_set_max_rotation(0F, 1F, 1F);
            player_effect_start(0.25F, 0F);
        }

        [ScriptMethod(149, Lifecycle.Static)]
        public async Task c04_intro_02a_cleanup()
        {
            object_destroy(elite03.Entity);
            object_destroy(elite06.Entity);
            object_destroy(elite07.Entity);
        }

        [ScriptMethod(150, Lifecycle.Static)]
        public async Task c04_intro_02a()
        {
            await this._04_intro_02a_predict_stub();
            await this.c04_intro_02a_setup();
            camera_set_field_of_view(80F, 0);
            print("fov change: 60 -> 80 over 0 ticks");
            camera_set_animation_relative(GetTag<AnimationGraphTag>("objects\\characters\\cinematic_camera\\04_intro\\04_intro", 3838968668U), "04intro_02a", default(IUnit), cinematic_anchor03);
            custom_animation_relative(dervish02.Entity, GetTag<AnimationGraphTag>("objects\\characters\\dervish\\04_intro\\04_intro", 3840803704U), "dervish_02a", false, anchor03.Entity);
            custom_animation_relative(commander.Entity, GetTag<AnimationGraphTag>("objects\\characters\\elite\\04_intro\\04_intro", 3840869241U), "commander_02a", false, anchor03.Entity);
            custom_animation_relative(elite01.Entity, GetTag<AnimationGraphTag>("objects\\characters\\elite\\04_intro\\04_intro", 3840869241U), "elite01_02a", false, anchor03.Entity);
            custom_animation_relative(elite02.Entity, GetTag<AnimationGraphTag>("objects\\characters\\elite\\04_intro\\04_intro", 3840869241U), "elite02_02a", false, anchor03.Entity);
            custom_animation_relative(elite03.Entity, GetTag<AnimationGraphTag>("objects\\characters\\elite\\04_intro\\04_intro", 3840869241U), "elite03_02a", false, anchor03.Entity);
            custom_animation_relative(elite04.Entity, GetTag<AnimationGraphTag>("objects\\characters\\elite\\04_intro\\04_intro", 3840869241U), "elite04_02a", false, anchor03.Entity);
            custom_animation_relative(elite05.Entity, GetTag<AnimationGraphTag>("objects\\characters\\elite\\04_intro\\04_intro", 3840869241U), "elite05_02a", false, anchor03.Entity);
            custom_animation_relative(elite06.Entity, GetTag<AnimationGraphTag>("objects\\characters\\elite\\04_intro\\04_intro", 3840869241U), "elite06_02a", false, anchor03.Entity);
            custom_animation_relative(elite07.Entity, GetTag<AnimationGraphTag>("objects\\characters\\elite\\04_intro\\04_intro", 3840869241U), "elite07_02a", false, anchor03.Entity);
            custom_animation_relative(grunt01.Entity, GetTag<AnimationGraphTag>("objects\\characters\\grunt\\04_intro\\04_intro", 3840934778U), "grunt01_02a", false, anchor03.Entity);
            custom_animation_relative(grunt02.Entity, GetTag<AnimationGraphTag>("objects\\characters\\grunt\\04_intro\\04_intro", 3840934778U), "grunt02_02a", false, anchor03.Entity);
            custom_animation_relative(grunt03.Entity, GetTag<AnimationGraphTag>("objects\\characters\\grunt\\04_intro\\04_intro", 3840934778U), "grunt03_02a", false, anchor03.Entity);
            custom_animation_relative(grunt04.Entity, GetTag<AnimationGraphTag>("objects\\characters\\grunt\\04_intro\\04_intro", 3840934778U), "grunt04_02a", false, anchor03.Entity);
            scenery_animation_start_relative(phantom_int.Entity, GetTag<AnimationGraphTag>("objects\\vehicles\\phantom\\cinematics\\04_intro\\04_intro", 3841000315U), "phantom_int_02a", anchor03.Entity);
            await sleep(5);
            fade_in(1F, 1F, 1F, 15);
            await sleep((short)((float)camera_time() - this.prediction_offset));
            await this._04_intro_02b_predict_stub();
            await sleep((short)camera_time());
            await this.c04_intro_02a_cleanup();
        }

        [ScriptMethod(151, Lifecycle.Dormant)]
        public async Task c04_1080_sec()
        {
            await sleep(5);
            sound_impulse_start(GetTag<SoundTag>("sound\\dialog\\levels\\04_gasgiant\\cinematic\\c04_1080_sec", 3841065852U), default(IGameObject), 1F);
            cinematic_subtitle("c04_1080_sec", 3F);
        }

        [ScriptMethod(152, Lifecycle.Dormant)]
        public async Task c04_1090_soc()
        {
            await sleep(83);
            sound_impulse_start(GetTag<SoundTag>("sound\\dialog\\levels\\04_gasgiant\\cinematic\\c04_1090_soc", 3841131389U), commander.Entity, 1F);
            cinematic_subtitle("c04_1090_soc", 3F);
        }

        [ScriptMethod(153, Lifecycle.Static)]
        public async Task c04_intro_02b_setup()
        {
            wake(new ScriptMethodReference(c04_1080_sec));
            wake(new ScriptMethodReference(c04_1090_soc));
        }

        [ScriptMethod(154, Lifecycle.Static)]
        public async Task c04_intro_02b_cleanup()
        {
            object_hide(phantom_int.Entity, true);
            object_destroy(elite01.Entity);
            object_destroy(elite02.Entity);
            object_destroy(elite04.Entity);
            object_destroy(elite05.Entity);
            object_destroy(grunt01.Entity);
            object_destroy(grunt02.Entity);
            object_destroy(grunt03.Entity);
            object_destroy(grunt04.Entity);
        }

        [ScriptMethod(155, Lifecycle.Static)]
        public async Task c04_intro_02b()
        {
            await this.c04_intro_02b_setup();
            camera_set_animation_relative(GetTag<AnimationGraphTag>("objects\\characters\\cinematic_camera\\04_intro\\04_intro", 3838968668U), "04intro_02b", default(IUnit), cinematic_anchor03);
            custom_animation_relative(dervish02.Entity, GetTag<AnimationGraphTag>("objects\\characters\\dervish\\04_intro\\04_intro", 3840803704U), "dervish_02b", false, anchor03.Entity);
            custom_animation_relative(commander.Entity, GetTag<AnimationGraphTag>("objects\\characters\\elite\\04_intro\\04_intro", 3840869241U), "commander_02b", false, anchor03.Entity);
            custom_animation_relative(elite01.Entity, GetTag<AnimationGraphTag>("objects\\characters\\elite\\04_intro\\04_intro", 3840869241U), "elite01_02b", false, anchor03.Entity);
            custom_animation_relative(elite02.Entity, GetTag<AnimationGraphTag>("objects\\characters\\elite\\04_intro\\04_intro", 3840869241U), "elite02_02b", false, anchor03.Entity);
            custom_animation_relative(elite04.Entity, GetTag<AnimationGraphTag>("objects\\characters\\elite\\04_intro\\04_intro", 3840869241U), "elite04_02b", false, anchor03.Entity);
            custom_animation_relative(elite05.Entity, GetTag<AnimationGraphTag>("objects\\characters\\elite\\04_intro\\04_intro", 3840869241U), "elite05_02b", false, anchor03.Entity);
            custom_animation_relative(grunt01.Entity, GetTag<AnimationGraphTag>("objects\\characters\\grunt\\04_intro\\04_intro", 3840934778U), "grunt01_02b", false, anchor03.Entity);
            custom_animation_relative(grunt02.Entity, GetTag<AnimationGraphTag>("objects\\characters\\grunt\\04_intro\\04_intro", 3840934778U), "grunt02_02b", false, anchor03.Entity);
            custom_animation_relative(grunt03.Entity, GetTag<AnimationGraphTag>("objects\\characters\\grunt\\04_intro\\04_intro", 3840934778U), "grunt03_02b", false, anchor03.Entity);
            custom_animation_relative(grunt04.Entity, GetTag<AnimationGraphTag>("objects\\characters\\grunt\\04_intro\\04_intro", 3840934778U), "grunt04_02b", false, anchor03.Entity);
            scenery_animation_start_relative(phantom_int.Entity, GetTag<AnimationGraphTag>("objects\\vehicles\\phantom\\cinematics\\04_intro\\04_intro", 3841000315U), "phantom_int_02b", anchor03.Entity);
            await sleep((short)((float)camera_time() - this.prediction_offset));
            await this._04_intro_02c_predict_stub();
            await sleep((short)((float)camera_time() - this.sound_offset));
            sound_impulse_predict(GetTag<SoundTag>("sound\\cinematics\\04_alphagas\\c04_intro\\music\\c04_02c_mus", 3841196926U));
            sound_impulse_predict(GetTag<SoundTag>("sound\\cinematics\\04_alphagas\\c04_intro\\foley\\c04_intro_02c_fol", 3841262463U));
            await sleep((short)camera_time());
            await this.c04_intro_02b_cleanup();
        }

        [ScriptMethod(156, Lifecycle.Dormant)]
        public async Task c04_intro_sound_scene2c_01()
        {
            sound_class_set_gain("vehicle", 1F, 80);
        }

        [ScriptMethod(157, Lifecycle.Dormant)]
        public async Task c04_intro_sound_scene2c_02()
        {
            await sleep(90);
            sound_class_set_gain("vehicle", 0F, 10);
        }

        [ScriptMethod(158, Lifecycle.Dormant)]
        public async Task c04_intro_score_02c()
        {
            await sleep(101);
            sound_impulse_start(GetTag<SoundTag>("sound\\cinematics\\04_alphagas\\c04_intro\\music\\c04_02c_mus", 3841196926U), default(IGameObject), 1F);
            print("c04_intro score 02c start");
        }

        [ScriptMethod(159, Lifecycle.Dormant)]
        public async Task c04_intro_foley_02c()
        {
            await sleep(0);
            sound_impulse_start(GetTag<SoundTag>("sound\\cinematics\\04_alphagas\\c04_intro\\foley\\c04_intro_02c_fol", 3841262463U), default(IGameObject), 1F);
            print("c04_intro foley 02c start");
        }

        [ScriptMethod(160, Lifecycle.Dormant)]
        public async Task c04_intro_cinematic_light_02c()
        {
            cinematic_lighting_set_primary_light(24F, 294F, 0.35F, 0.39F, 0.24F);
            cinematic_lighting_set_secondary_light(19F, 22F, 0F, 0F, 0F);
            cinematic_lighting_set_ambient_light(0.18F, 0.14F, 0.14F);
            rasterizer_bloom_override_threshold(0.4F);
            rasterizer_bloom_override_brightness(0.5F);
            object_uses_cinematic_lighting(phantom01.Entity, true);
            object_uses_cinematic_lighting(phantom02.Entity, true);
            object_uses_cinematic_lighting(phantom03.Entity, true);
        }

        [ScriptMethod(161, Lifecycle.Static)]
        public async Task c04_intro_02c_setup()
        {
            player_effect_stop(0F);
            object_create_anew(matte_structure_top);
            wake(new ScriptMethodReference(c04_intro_sound_scene2c_01));
            wake(new ScriptMethodReference(c04_intro_sound_scene2c_02));
            wake(new ScriptMethodReference(c04_intro_score_02c));
            wake(new ScriptMethodReference(c04_intro_foley_02c));
            wake(new ScriptMethodReference(c04_intro_cinematic_light_02c));
        }

        [ScriptMethod(162, Lifecycle.Static)]
        public async Task c04_intro_02c()
        {
            await this.c04_intro_02c_setup();
            camera_set_animation_relative(GetTag<AnimationGraphTag>("objects\\characters\\cinematic_camera\\04_intro\\04_intro", 3838968668U), "04intro_02c", default(IUnit), cinematic_anchor03);
            custom_animation_relative(phantom01.Entity, GetTag<AnimationGraphTag>("objects\\vehicles\\phantom\\animations\\04_intro\\04_intro", 3839034205U), "phantom01_02c", false, anchor03.Entity);
            custom_animation_relative(phantom02.Entity, GetTag<AnimationGraphTag>("objects\\vehicles\\phantom\\animations\\04_intro\\04_intro", 3839034205U), "phantom02_02c", false, anchor03.Entity);
            custom_animation_relative(phantom03.Entity, GetTag<AnimationGraphTag>("objects\\vehicles\\phantom\\animations\\04_intro\\04_intro", 3839034205U), "phantom03_02c", false, anchor03.Entity);
            scenery_animation_start_relative(matte_structure_top.Entity, GetTag<AnimationGraphTag>("objects\\cinematics\\matte_paintings\\gas_giant_structure_top\\04_intro\\04_intro", 3841328000U), "gas_giant_structure_top_02c", anchor03.Entity);
            await sleep((short)((float)camera_time() - this.prediction_offset));
            await this._04_intro_02d_predict_stub();
            cinematic_screen_effect_start(true);
            await sleep((short)((float)camera_time() - this.sound_offset));
            sound_impulse_predict(GetTag<SoundTag>("sound\\cinematics\\04_alphagas\\c04_intro\\foley\\c04_intro_02d_fol", 3841393537U));
            await sleep((short)((float)camera_time() - 5));
            cinematic_screen_effect_set_crossfade(2F);
            await sleep(5);
            object_destroy(matte_structure_top.Entity);
        }

        [ScriptMethod(163, Lifecycle.Dormant)]
        public async Task c04_intro_sound_scene2d_01()
        {
            sound_class_set_gain("vehicle", 0.5F, 15);
        }

        [ScriptMethod(164, Lifecycle.Dormant)]
        public async Task c04_intro_foley_02d()
        {
            await sleep(0);
            sound_impulse_start(GetTag<SoundTag>("sound\\cinematics\\04_alphagas\\c04_intro\\foley\\c04_intro_02d_fol", 3841393537U), default(IGameObject), 1F);
            print("c04_intro foley 02d start");
        }

        [ScriptMethod(165, Lifecycle.Dormant)]
        public async Task c04_1100_soc()
        {
            await sleep(29);
            sound_impulse_start(GetTag<SoundTag>("sound\\dialog\\levels\\04_gasgiant\\cinematic\\c04_1100_soc", 3841459074U), commander.Entity, 1F);
            cinematic_subtitle("c04_1100_soc", 1F);
        }

        [ScriptMethod(166, Lifecycle.Dormant)]
        public async Task c04_1110_soc()
        {
            await sleep(76);
            sound_impulse_start(GetTag<SoundTag>("sound\\dialog\\levels\\04_gasgiant\\cinematic\\c04_1110_soc", 3841524611U), commander.Entity, 1F);
            cinematic_subtitle("c04_1110_soc", 2F);
        }

        [ScriptMethod(167, Lifecycle.Dormant)]
        public async Task c04_1120_der()
        {
            await sleep(127);
            sound_impulse_start(GetTag<SoundTag>("sound\\dialog\\levels\\04_gasgiant\\cinematic\\c04_1120_der", 3841590148U), dervish02.Entity, 1F);
            cinematic_subtitle("c04_1120_der", 1F);
        }

        [ScriptMethod(168, Lifecycle.Dormant)]
        public async Task c04_1130_soc()
        {
            await sleep(174);
            sound_impulse_start(GetTag<SoundTag>("sound\\dialog\\levels\\04_gasgiant\\cinematic\\c04_1130_soc", 3841655685U), commander.Entity, 1F);
            cinematic_subtitle("c04_1130_soc", 9F);
        }

        [ScriptMethod(169, Lifecycle.Dormant)]
        public async Task c04_1140_der()
        {
            await sleep(430);
            sound_impulse_start(GetTag<SoundTag>("sound\\dialog\\levels\\04_gasgiant\\cinematic\\c04_1140_der", 3841721222U), dervish02.Entity, 1F);
            cinematic_subtitle("c04_1140_der", 2F);
        }

        [ScriptMethod(170, Lifecycle.Dormant)]
        public async Task c04_1150_soc()
        {
            await sleep(494);
            sound_impulse_start(GetTag<SoundTag>("sound\\dialog\\levels\\04_gasgiant\\cinematic\\c04_1150_soc", 3841786759U), commander.Entity, 1F);
            cinematic_subtitle("c04_1150_soc", 1F);
        }

        [ScriptMethod(171, Lifecycle.Dormant)]
        public async Task c04_intro_cinematic_light_02d()
        {
            cinematic_lighting_set_primary_light(-90F, 0F, 0.23F, 0.29F, 0.53F);
            cinematic_lighting_set_secondary_light(-90F, 192F, 0.16F, 0.1F, 0.19F);
            cinematic_lighting_set_ambient_light(0.07F, 0.05F, 0.08F);
            rasterizer_bloom_override_threshold(0.3F);
            rasterizer_bloom_override_brightness(0.5F);
        }

        [ScriptMethod(172, Lifecycle.Static)]
        public async Task c04_intro_03_problem_actors()
        {
            print("problem actors");
            object_create_anew(matte_structure);
        }

        [ScriptMethod(173, Lifecycle.Static)]
        public async Task c04_intro_02d_setup()
        {
            object_hide(phantom_int.Entity, false);
            wake(new ScriptMethodReference(c04_intro_sound_scene2d_01));
            wake(new ScriptMethodReference(c04_intro_foley_02d));
            wake(new ScriptMethodReference(c04_1100_soc));
            wake(new ScriptMethodReference(c04_1110_soc));
            wake(new ScriptMethodReference(c04_1120_der));
            wake(new ScriptMethodReference(c04_1130_soc));
            wake(new ScriptMethodReference(c04_1140_der));
            wake(new ScriptMethodReference(c04_1150_soc));
            wake(new ScriptMethodReference(c04_intro_cinematic_light_02d));
            player_effect_set_max_rotation(0F, 1F, 1F);
            player_effect_start(0.25F, 0F);
        }

        [ScriptMethod(174, Lifecycle.Static)]
        public async Task c04_intro_02d()
        {
            await this.c04_intro_02d_setup();
            camera_set_animation_relative(GetTag<AnimationGraphTag>("objects\\characters\\cinematic_camera\\04_intro\\04_intro", 3838968668U), "04intro_02d", default(IUnit), cinematic_anchor03);
            custom_animation_relative(dervish02.Entity, GetTag<AnimationGraphTag>("objects\\characters\\dervish\\04_intro\\04_intro", 3840803704U), "dervish_02d", false, anchor03.Entity);
            custom_animation_relative(commander.Entity, GetTag<AnimationGraphTag>("objects\\characters\\elite\\04_intro\\04_intro", 3840869241U), "commander_02d", false, anchor03.Entity);
            scenery_animation_start_relative(phantom_int.Entity, GetTag<AnimationGraphTag>("objects\\vehicles\\phantom\\cinematics\\04_intro\\04_intro", 3841000315U), "phantom_int_02d", anchor03.Entity);
            await sleep((short)((float)camera_time() - this.prediction_offset));
            await this._04_intro_03_predict_stub();
            cinematic_screen_effect_stop();
            await sleep((short)((float)camera_time() - this.sound_offset));
            sound_impulse_predict(GetTag<SoundTag>("sound\\cinematics\\04_alphagas\\c04_intro\\foley\\c04_intro_03_fol", 3841852296U));
            await this.c04_intro_03_problem_actors();
            await sleep((short)camera_time());
            object_destroy(dervish02.Entity);
            object_destroy(commander.Entity);
            object_destroy(phantom_int.Entity);
        }

        [ScriptMethod(175, Lifecycle.Dormant)]
        public async Task c04_intro_sound_scene3_01()
        {
            sound_class_set_gain("vehicle", 0F, 15);
        }

        [ScriptMethod(176, Lifecycle.Dormant)]
        public async Task c04_intro_sound_scene3_02()
        {
            sound_class_set_gain("vehicle", 1F, 170);
        }

        [ScriptMethod(177, Lifecycle.Dormant)]
        public async Task c04_intro_sound_scene3_03()
        {
            await sleep(180);
            sound_class_set_gain("vehicle", 0F, 120);
        }

        [ScriptMethod(178, Lifecycle.Dormant)]
        public async Task c04_intro_foley_03()
        {
            await sleep(0);
            sound_impulse_start(GetTag<SoundTag>("sound\\cinematics\\04_alphagas\\c04_intro\\foley\\c04_intro_03_fol", 3841852296U), default(IGameObject), 1F);
            print("c04_intro foley 03 start");
        }

        [ScriptMethod(179, Lifecycle.Dormant)]
        public async Task c04_1170_elp()
        {
            await sleep(189);
            sound_impulse_start_effect(GetTag<SoundTag>("sound\\dialog\\levels\\04_gasgiant\\cinematic\\c04_1170_elp", 3841917833U), default(IGameObject), 1F, "radio_covy_in");
            cinematic_subtitle("c04_1170_elp", 1F);
        }

        [ScriptMethod(180, Lifecycle.Dormant)]
        public async Task c04_1180_ecp()
        {
            await sleep(212);
            sound_impulse_start_effect(GetTag<SoundTag>("sound\\dialog\\levels\\04_gasgiant\\cinematic\\c04_1180_elp", 3841983370U), default(IGameObject), 1F, "radio_covy_loop");
            cinematic_subtitle("c04_1180_elp", 3F);
        }

        [ScriptMethod(181, Lifecycle.Dormant)]
        public async Task c04_1190_soc()
        {
            await sleep(295);
            sound_impulse_start_effect(GetTag<SoundTag>("sound\\dialog\\levels\\04_gasgiant\\cinematic\\c04_1190_soc", 3842048907U), default(IGameObject), 1F, "radio_covy_out");
            cinematic_subtitle("c04_1190_soc", 2F);
        }

        [ScriptMethod(182, Lifecycle.Dormant)]
        public async Task c04_intro_cinematic_light_03()
        {
            cinematic_lighting_set_primary_light(-32F, 140F, 0.35F, 0.39F, 0.24F);
            cinematic_lighting_set_secondary_light(19F, 22F, 0F, 0F, 0F);
            cinematic_lighting_set_ambient_light(0.18F, 0.14F, 0.14F);
            rasterizer_bloom_override_threshold(0.4F);
            rasterizer_bloom_override_brightness(0.5F);
        }

        [ScriptMethod(183, Lifecycle.Dormant)]
        public async Task c04_intro_shake_03()
        {
            await sleep(173);
            print("shake");
            player_effect_set_max_rotation(0F, 1F, 1F);
            player_effect_start(0.25F, 0F);
            player_effect_stop(1.5F);
        }

        [ScriptMethod(184, Lifecycle.Static)]
        public async Task c04_intro_03_setup()
        {
            object_create_anew(matte_mine);
            wake(new ScriptMethodReference(c04_intro_sound_scene3_01));
            wake(new ScriptMethodReference(c04_intro_sound_scene3_02));
            wake(new ScriptMethodReference(c04_intro_sound_scene3_03));
            wake(new ScriptMethodReference(c04_intro_foley_03));
            wake(new ScriptMethodReference(c04_1170_elp));
            wake(new ScriptMethodReference(c04_1180_ecp));
            wake(new ScriptMethodReference(c04_1190_soc));
            wake(new ScriptMethodReference(c04_intro_shake_03));
            wake(new ScriptMethodReference(c04_intro_cinematic_light_03));
            player_effect_stop(0F);
        }

        [ScriptMethod(185, Lifecycle.Static)]
        public async Task c04_intro_03_cleanup()
        {
            object_destroy(phantom01.Entity);
            object_destroy(phantom02.Entity);
            object_destroy(phantom03.Entity);
            object_destroy_containing("matte");
        }

        [ScriptMethod(186, Lifecycle.Static)]
        public async Task c04_intro_03()
        {
            await this.c04_intro_03_setup();
            camera_set_animation_relative(GetTag<AnimationGraphTag>("objects\\characters\\cinematic_camera\\04_intro\\04_intro", 3838968668U), "04intro_03", default(IUnit), cinematic_anchor03);
            custom_animation_relative(phantom01.Entity, GetTag<AnimationGraphTag>("objects\\vehicles\\phantom\\animations\\04_intro\\04_intro", 3839034205U), "phantom01_3", false, anchor03.Entity);
            custom_animation_relative(phantom02.Entity, GetTag<AnimationGraphTag>("objects\\vehicles\\phantom\\animations\\04_intro\\04_intro", 3839034205U), "phantom02_3", false, anchor03.Entity);
            custom_animation_relative(phantom03.Entity, GetTag<AnimationGraphTag>("objects\\vehicles\\phantom\\animations\\04_intro\\04_intro", 3839034205U), "phantom03_3", false, anchor03.Entity);
            scenery_animation_start_relative(matte_mine.Entity, GetTag<AnimationGraphTag>("objects\\cinematics\\matte_paintings\\gas_giant_exterior\\04_intro\\04_intro", 3842114444U), "gas_giant_exterior_03", anchor03.Entity);
            scenery_animation_start_relative(matte_structure.Entity, GetTag<AnimationGraphTag>("objects\\cinematics\\matte_paintings\\gas_giant_structure\\04_intro\\04_intro", 3842179981U), "gas_giant_structure_03", anchor03.Entity);
            await sleep((short)((float)camera_time() - 15));
            fade_out(1F, 1F, 1F, 15);
            await sleep((short)camera_time());
            await this.c04_intro_03_cleanup();
        }

        [ScriptMethod(187, Lifecycle.Dormant)]
        public async Task c04_intro_sound_scene5_01()
        {
            object_set_function_variable(phantom_01.Entity, "engine_hack", 1F, 0F);
            object_set_function_variable(phantom_02.Entity, "engine_hack", 1F, 0F);
            object_set_function_variable(phantom_03.Entity, "engine_hack", 1F, 0F);
            object_set_function_variable(phantom_01.Entity, "engine_audio", 1F, 0F);
            object_set_function_variable(phantom_02.Entity, "engine_audio", 1F, 0F);
            object_set_function_variable(phantom_03.Entity, "engine_audio", 1F, 0F);
            object_set_function_variable(phantom_01.Entity, "hover_audio", 1F, 0F);
            object_set_function_variable(phantom_02.Entity, "hover_audio", 1F, 0F);
            object_set_function_variable(phantom_03.Entity, "hover_audio", 1F, 0F);
        }

        [ScriptMethod(188, Lifecycle.Dormant)]
        public async Task c04_intro_05_shake_1()
        {
            player_effect_set_max_rotation(0F, 1F, 1F);
            player_effect_start(0.15F, 0F);
            await sleep(401);
            player_effect_stop(0F);
        }

        [ScriptMethod(189, Lifecycle.Static)]
        public async Task c04_intro_05_setup()
        {
            object_create_anew(phantom_01);
            object_create_anew(phantom_02);
            object_create_anew(phantom_03);
            wake(new ScriptMethodReference(c04_intro_sound_scene5_01));
            wake(new ScriptMethodReference(c04_intro_05_shake_1));
        }

        [ScriptMethod(190, Lifecycle.Static)]
        public async Task c04_intro_05()
        {
            await this._04_intro_05_predict_stub();
            await this.c04_intro_05_setup();
            camera_set_animation_relative(GetTag<AnimationGraphTag>("objects\\characters\\cinematic_camera\\04_intro\\04_intro", 3838968668U), "04intro_05", default(IUnit), cinematic_anchor02);
            custom_animation_relative(phantom_01.Entity, GetTag<AnimationGraphTag>("objects\\vehicles\\phantom\\animations\\04_intro\\04_intro", 3839034205U), "phantom01_05", false, anchor02.Entity);
            custom_animation_relative(phantom_02.Entity, GetTag<AnimationGraphTag>("objects\\vehicles\\phantom\\animations\\04_intro\\04_intro", 3839034205U), "phantom02_05", false, anchor02.Entity);
            custom_animation_relative(phantom_03.Entity, GetTag<AnimationGraphTag>("objects\\vehicles\\phantom\\animations\\04_intro\\04_intro", 3839034205U), "phantom03_05", false, anchor02.Entity);
            await sleep(15);
            fade_in(1F, 1F, 1F, 15);
            await sleep((short)((float)camera_time() - this.prediction_offset));
            await this._04_intro_06b_predict_stub();
            await sleep((short)camera_time());
        }

        [ScriptMethod(191, Lifecycle.Dormant)]
        public async Task c04_intro_sound_scene6b_01()
        {
            sound_class_set_gain("vehicle", 1F, 30);
        }

        [ScriptMethod(192, Lifecycle.Dormant)]
        public async Task c04_intro_sound_scene6b_02()
        {
            object_set_function_variable(phantom_01.Entity, "engine_hack", 0F, 120F);
            object_set_function_variable(phantom_02.Entity, "engine_hack", 0F, 120F);
            object_set_function_variable(phantom_03.Entity, "engine_hack", 0F, 120F);
            object_set_function_variable(phantom_01.Entity, "engine_audio", 0F, 120F);
            object_set_function_variable(phantom_02.Entity, "engine_audio", 0F, 120F);
            object_set_function_variable(phantom_03.Entity, "engine_audio", 0F, 120F);
            object_set_function_variable(phantom_01.Entity, "hover_audio", 0F, 120F);
            object_set_function_variable(phantom_02.Entity, "hover_audio", 0F, 120F);
            object_set_function_variable(phantom_03.Entity, "hover_audio", 0F, 120F);
        }

        [ScriptMethod(193, Lifecycle.Dormant)]
        public async Task c04_intro_sound_scene6b_03()
        {
            await sleep(30);
            object_set_function_variable(phantom_01.Entity, "turn_absolute", 1F, 30F);
            object_set_function_variable(phantom_02.Entity, "turn_absolute", 1F, 30F);
            object_set_function_variable(phantom_03.Entity, "turn_absolute", 1F, 30F);
            object_set_function_variable(phantom_01.Entity, "banking_audio", 1F, 30F);
            object_set_function_variable(phantom_02.Entity, "banking_audio", 1F, 30F);
            object_set_function_variable(phantom_03.Entity, "banking_audio", 1F, 30F);
            object_set_function_variable(phantom_01.Entity, "engine_ducker", 1F, 60F);
            object_set_function_variable(phantom_02.Entity, "engine_ducker", 1F, 60F);
            object_set_function_variable(phantom_03.Entity, "engine_ducker", 1F, 60F);
        }

        [ScriptMethod(194, Lifecycle.Dormant)]
        public async Task c04_intro_sound_scene6b_04()
        {
            await sleep(60);
            object_set_function_variable(phantom_01.Entity, "turn_absolute", 0F, 30F);
            object_set_function_variable(phantom_02.Entity, "turn_absolute", 0F, 30F);
            object_set_function_variable(phantom_03.Entity, "turn_absolute", 0F, 30F);
            object_set_function_variable(phantom_01.Entity, "banking_audio", 0F, 30F);
            object_set_function_variable(phantom_02.Entity, "banking_audio", 0F, 30F);
            object_set_function_variable(phantom_03.Entity, "banking_audio", 0F, 30F);
        }

        [ScriptMethod(195, Lifecycle.Dormant)]
        public async Task c04_intro_sound_scene6b_05()
        {
            await sleep(210);
            object_set_function_variable(phantom_01.Entity, "engine_hack", 1F, 60F);
            object_set_function_variable(phantom_03.Entity, "engine_hack", 1F, 60F);
            object_set_function_variable(phantom_01.Entity, "engine_audio", 1F, 60F);
            object_set_function_variable(phantom_03.Entity, "engine_audio", 1F, 60F);
            object_set_function_variable(phantom_01.Entity, "hover_audio", 1F, 60F);
            object_set_function_variable(phantom_03.Entity, "hover_audio", 1F, 60F);
            object_set_function_variable(phantom_01.Entity, "engine_ducker", 0F, 60F);
            object_set_function_variable(phantom_03.Entity, "engine_ducker", 0F, 60F);
        }

        [ScriptMethod(196, Lifecycle.Dormant)]
        public async Task c04_intro_sound_scene6b_06()
        {
            await sleep(315);
            object_set_function_variable(phantom_02.Entity, "engine_hack", 1F, 60F);
            object_set_function_variable(phantom_02.Entity, "engine_audio", 1F, 60F);
            object_set_function_variable(phantom_02.Entity, "hover_audio", 1F, 60F);
            object_set_function_variable(phantom_02.Entity, "engine_ducker", 0F, 60F);
        }

        [ScriptMethod(197, Lifecycle.Dormant)]
        public async Task c04_intro_sound_scene6b_07()
        {
            await sleep(375);
            sound_class_set_gain("vehicle", 0F, 30);
        }

        [ScriptMethod(198, Lifecycle.Dormant)]
        public async Task c04_1200_soc()
        {
            await sleep(330);
            sound_impulse_start_effect(GetTag<SoundTag>("sound\\dialog\\levels\\04_gasgiant\\cinematic\\c04_1200_soc", 3842245518U), default(IGameObject), 1F, "radio_covy");
            cinematic_subtitle("c04_1200_soc", 2F);
        }

        [ScriptMethod(199, Lifecycle.Dormant)]
        public async Task c04_intro_06b_fov()
        {
            await sleep(117);
            camera_set_field_of_view(60F, 32);
        }

        [ScriptMethod(200, Lifecycle.Dormant)]
        public async Task c04_06b_shake_1()
        {
            player_effect_stop(0F);
            await sleep(30);
            player_effect_set_max_rotation(0F, 1F, 1F);
            player_effect_start(0.25F, 2F);
            await sleep(60);
            player_effect_stop(2F);
        }

        [ScriptMethod(201, Lifecycle.Dormant)]
        public async Task c04_intro_cinematic_light_06b()
        {
            cinematic_lighting_set_primary_light(3F, 234F, 0.4F, 0.44F, 0.27F);
            cinematic_lighting_set_secondary_light(19F, 118F, 0.25F, 0.23F, 0.15F);
            cinematic_lighting_set_ambient_light(0.07F, 0.06F, 0.06F);
            rasterizer_bloom_override_threshold(0.4F);
            rasterizer_bloom_override_brightness(0.5F);
            object_uses_cinematic_lighting(phantom_01.Entity, true);
            object_uses_cinematic_lighting(phantom_02.Entity, true);
            object_uses_cinematic_lighting(phantom_03.Entity, true);
        }

        [ScriptMethod(202, Lifecycle.Dormant)]
        public async Task grunt_insertion()
        {
            await sleep(173);
            object_create_anew(grunt01);
            object_create_anew(grunt02);
            object_create_anew(grunt03);
            object_create_anew(grunt04);
            object_cinematic_lod(grunt01.Entity, true);
            object_cinematic_lod(grunt02.Entity, true);
            object_cinematic_lod(grunt03.Entity, true);
            object_cinematic_lod(grunt04.Entity, true);
            object_create_anew(plasma_pistol01);
            object_create_anew(plasma_pistol02);
            object_create_anew(plasma_pistol03);
            object_create_anew(plasma_pistol04);
            objects_attach(grunt01.Entity, "right_hand", plasma_pistol01.Entity, "");
            objects_attach(grunt01.Entity, "right_hand", plasma_pistol02.Entity, "");
            objects_attach(grunt01.Entity, "right_hand", plasma_pistol03.Entity, "");
            objects_attach(grunt01.Entity, "right_hand", plasma_pistol04.Entity, "");
            object_uses_cinematic_lighting(grunt01.Entity, true);
            object_uses_cinematic_lighting(grunt02.Entity, true);
            object_uses_cinematic_lighting(grunt03.Entity, true);
            object_uses_cinematic_lighting(grunt04.Entity, true);
            custom_animation_relative(grunt01.Entity, GetTag<AnimationGraphTag>("objects\\characters\\grunt\\04_intro\\04_intro", 3840934778U), "grunt01_06b", false, anchor02.Entity);
            custom_animation_relative(grunt02.Entity, GetTag<AnimationGraphTag>("objects\\characters\\grunt\\04_intro\\04_intro", 3840934778U), "grunt02_06b", false, anchor02.Entity);
            custom_animation_relative(grunt03.Entity, GetTag<AnimationGraphTag>("objects\\characters\\grunt\\04_intro\\04_intro", 3840934778U), "grunt03_06b", false, anchor02.Entity);
            custom_animation_relative(grunt04.Entity, GetTag<AnimationGraphTag>("objects\\characters\\grunt\\04_intro\\04_intro", 3840934778U), "grunt04_06b", false, anchor02.Entity);
        }

        [ScriptMethod(203, Lifecycle.Dormant)]
        public async Task elite_insertion()
        {
            await sleep(179);
            object_create_anew(elite03);
            object_create_anew(elite04);
            object_cinematic_lod(elite03.Entity, true);
            object_cinematic_lod(elite04.Entity, true);
            object_create_anew(plasma_rifle03);
            object_create_anew(plasma_rifle04);
            objects_attach(elite03.Entity, "right_hand_elite", plasma_rifle03.Entity, "");
            objects_attach(elite04.Entity, "right_hand_elite", plasma_rifle04.Entity, "");
            object_uses_cinematic_lighting(elite03.Entity, true);
            object_uses_cinematic_lighting(elite04.Entity, true);
            custom_animation_relative(elite03.Entity, GetTag<AnimationGraphTag>("objects\\characters\\elite\\04_intro\\04_intro", 3840869241U), "elite03_06b", false, anchor02.Entity);
            custom_animation_relative(elite04.Entity, GetTag<AnimationGraphTag>("objects\\characters\\elite\\04_intro\\04_intro", 3840869241U), "elite04_06b", false, anchor02.Entity);
        }

        [ScriptMethod(204, Lifecycle.Dormant)]
        public async Task dervish_insertion()
        {
            await sleep(312);
            object_create_anew(dervish02);
            object_create_anew(energy_blade01);
            object_cinematic_lod(dervish02.Entity, true);
            objects_attach(dervish02.Entity, "right_hand_elite", energy_blade01.Entity, "");
            object_set_permutation(energy_blade01.Entity, "blade", "noblade");
            object_uses_cinematic_lighting(dervish02.Entity, true);
            custom_animation_relative(dervish02.Entity, GetTag<AnimationGraphTag>("objects\\characters\\dervish\\04_intro\\04_intro", 3840803704U), "dervish_06b", false, anchor02.Entity);
            await sleep(72);
            object_set_permutation(energy_blade01.Entity, "blade", "default");
            object_set_function_variable(energy_blade01.Entity, "turned_on", 1F, 0F);
            effect_new_on_object_marker(GetTag<EffectTag>("effects\\objects\\weapons\\melee\\energy_blade\\blade_activate_elite", 3842311055U), dervish02.Entity, "right_hand_elite");
            print("blade activate");
        }

        [ScriptMethod(205, Lifecycle.Static)]
        public async Task test()
        {
            print("no blade");
            object_set_permutation(energy_blade01.Entity, "blade", "noblade");
            await sleep(60);
            object_set_permutation(energy_blade01.Entity, "blade", "default");
            effect_new_on_object_marker(GetTag<EffectTag>("effects\\objects\\weapons\\melee\\energy_blade\\blade_activate", 3842442129U), energy_blade01.Entity, "ground_point");
            print("blade");
        }

        [ScriptMethod(206, Lifecycle.Dormant)]
        public async Task elite_01_insertion()
        {
            await sleep(281);
            object_create_anew(elite01);
            object_create_anew(plasma_rifle01);
            object_cinematic_lod(elite01.Entity, true);
            objects_attach(elite01.Entity, "right_hand_elite", plasma_rifle01.Entity, "");
            object_uses_cinematic_lighting(elite01.Entity, true);
            custom_animation_relative(elite01.Entity, GetTag<AnimationGraphTag>("objects\\characters\\elite\\04_intro\\04_intro", 3840869241U), "elite01_06b", false, anchor02.Entity);
        }

        [ScriptMethod(207, Lifecycle.Dormant)]
        public async Task elite_02_insertion()
        {
            await sleep(272);
            object_create_anew(elite02);
            object_create_anew(plasma_rifle02);
            object_cinematic_lod(elite02.Entity, true);
            objects_attach(elite02.Entity, "right_hand_elite", plasma_rifle02.Entity, "");
            object_uses_cinematic_lighting(elite02.Entity, true);
            custom_animation_relative(elite02.Entity, GetTag<AnimationGraphTag>("objects\\characters\\elite\\04_intro\\04_intro", 3840869241U), "elite02_06b", false, anchor02.Entity);
        }

        [ScriptMethod(208, Lifecycle.Static)]
        public async Task c04_intro_06b_setup()
        {
            wake(new ScriptMethodReference(c04_intro_sound_scene6b_01));
            wake(new ScriptMethodReference(c04_intro_sound_scene6b_02));
            wake(new ScriptMethodReference(c04_intro_sound_scene6b_03));
            wake(new ScriptMethodReference(c04_intro_sound_scene6b_04));
            wake(new ScriptMethodReference(c04_intro_sound_scene6b_05));
            wake(new ScriptMethodReference(c04_intro_sound_scene6b_06));
            wake(new ScriptMethodReference(c04_intro_sound_scene6b_07));
            wake(new ScriptMethodReference(c04_1200_soc));
            wake(new ScriptMethodReference(grunt_insertion));
            wake(new ScriptMethodReference(elite_insertion));
            wake(new ScriptMethodReference(dervish_insertion));
            wake(new ScriptMethodReference(elite_01_insertion));
            wake(new ScriptMethodReference(elite_02_insertion));
            wake(new ScriptMethodReference(c04_intro_06b_fov));
            wake(new ScriptMethodReference(c04_06b_shake_1));
            wake(new ScriptMethodReference(c04_intro_cinematic_light_06b));
        }

        [ScriptMethod(209, Lifecycle.Static)]
        public async Task c04_intro_06b_cleanup()
        {
            object_destroy(dervish02.Entity);
            object_destroy(commander.Entity);
            object_destroy(elite01.Entity);
            object_destroy(elite02.Entity);
            object_destroy(elite03.Entity);
            object_destroy(elite04.Entity);
            object_destroy(grunt01.Entity);
            object_destroy(grunt02.Entity);
            object_destroy(grunt03.Entity);
            object_destroy(grunt04.Entity);
            object_destroy(phantom_01.Entity);
            object_destroy(phantom_02.Entity);
            object_destroy(phantom_03.Entity);
        }

        [ScriptMethod(210, Lifecycle.Static)]
        public async Task c04_intro_06b()
        {
            await this.c04_intro_06b_setup();
            camera_set_field_of_view(27.5F, 0);
            camera_set_animation_relative(GetTag<AnimationGraphTag>("objects\\characters\\cinematic_camera\\04_intro\\04_intro", 3838968668U), "04intro_06b", default(IUnit), cinematic_anchor02);
            custom_animation_relative(phantom_01.Entity, GetTag<AnimationGraphTag>("objects\\vehicles\\phantom\\animations\\04_intro\\04_intro", 3839034205U), "phantom01_06b", false, anchor02.Entity);
            custom_animation_relative(phantom_02.Entity, GetTag<AnimationGraphTag>("objects\\vehicles\\phantom\\animations\\04_intro\\04_intro", 3839034205U), "phantom02_06b", false, anchor02.Entity);
            custom_animation_relative(phantom_03.Entity, GetTag<AnimationGraphTag>("objects\\vehicles\\phantom\\animations\\04_intro\\04_intro", 3839034205U), "phantom03_06b", false, anchor02.Entity);
            await sleep((short)((float)camera_time() - 15));
            fade_out(1F, 1F, 1F, 15);
            await sleep(15);
            await this.c04_intro_06b_cleanup();
            await sleep(30);
            cinematic_lightmap_shadow_disable();
        }

        [ScriptMethod(211, Lifecycle.Static)]
        public async Task c04_intro()
        {
            texture_cache_flush();
            geometry_cache_flush();
            switch_bsp_by_name(GetReference<IBsp>("ag_cinematic_bsp1"));
            await sleep(1);
            await this.c04_intro_01();
            switch_bsp_by_name(GetReference<IBsp>("ag_cinematic_bsp2"));
            await this.c04_intro_02a();
            await this.c04_intro_02b();
            await this.c04_intro_02c();
            await this.c04_intro_02d();
            await this.c04_intro_03();
            switch_bsp_by_name(GetReference<IBsp>("alphagasgiant"));
            await this.c04_intro_05();
            await this.c04_intro_06b();
            rasterizer_bloom_override(false);
        }

        [ScriptMethod(212, Lifecycle.Continuous)]
        public async Task active_camo_drop()
        {
            await sleep_until(async () => (short)ai_combat_status(rec_center_heretics) > this.ai_combat_status_uninspected || (short)ai_combat_status(hangar_heretics) > this.ai_combat_status_uninspected || (short)ai_combat_status(first_hall_heretics) > this.ai_combat_status_uninspected || (short)ai_combat_status(underhangar_heretics) > this.ai_combat_status_uninspected || (short)ai_combat_status(second_hall_heretics) > this.ai_combat_status_uninspected || (short)ai_combat_status(bottling_heretics) > this.ai_combat_status_uninspected);
            ai_set_active_camo(arm01_allies, false);
            ai_set_blind(all_enemies, false);
        }

        [ScriptMethod(213, Lifecycle.CommandScript)]
        public async Task abort()
        {
            cs_pause(0.1F);
        }

        [ScriptMethod(214, Lifecycle.CommandScript)]
        public async Task long_pause()
        {
            cs_abort_on_alert(true);
            sleep_forever();
        }

        [ScriptMethod(215, Lifecycle.CommandScript)]
        public async Task forever_pause()
        {
            cs_pause(-1F);
        }

        [ScriptMethod(216, Lifecycle.CommandScript)]
        public async Task snap_alert()
        {
            cs_force_combat_status(4);
            await sleep(5);
        }

        [ScriptMethod(217, Lifecycle.CommandScript)]
        public async Task stealth_comment_01()
        {
            cs_switch("ally");
            cs_abort_on_damage(true);
            cs_suppress_dialogue_global(true);
            print("spec-ops elite: 'quietly now!'");
            cs_play_line("1020");
        }

        [ScriptMethod(218, Lifecycle.CommandScript)]
        public async Task stealth_comment_02()
        {
            cs_switch("ally");
            cs_abort_on_damage(true);
            cs_suppress_dialogue_global(true);
            print("spec-ops elite: 'with stealth!'");
            cs_play_line("1030");
        }

        [ScriptMethod(219, Lifecycle.CommandScript)]
        public async Task stealth_comment_03()
        {
            cs_switch("ally");
            cs_abort_on_damage(true);
            cs_suppress_dialogue_global(true);
            print("spec-ops elite: 'camouflage engaged!'");
            cs_play_line("1040");
        }

        [ScriptMethod(220, Lifecycle.CommandScript)]
        public async Task stealth_comment_04()
        {
            cs_switch("ally");
            cs_abort_on_damage(true);
            cs_suppress_dialogue_global(true);
            print("spec-ops elite: 'an honorable ruse!'");
            cs_play_line("1050");
        }

        [ScriptMethod(221, Lifecycle.CommandScript)]
        public async Task stealth_comment_05()
        {
            cs_switch("ally");
            cs_abort_on_damage(true);
            cs_suppress_dialogue_global(true);
            print("spec-ops elite: 'they shall not see me coming!'");
            cs_play_line("1060");
        }

        [ScriptMethod(222, Lifecycle.CommandScript)]
        public async Task stealth_comment_06()
        {
            cs_switch("ally");
            cs_abort_on_damage(true);
            cs_suppress_dialogue_global(true);
            print("spec-ops elite: 'i'm invisible!'");
            cs_play_line("1070");
        }

        [ScriptMethod(223, Lifecycle.CommandScript)]
        public async Task stealth_comment_07()
        {
            cs_switch("ally");
            cs_abort_on_damage(true);
            cs_suppress_dialogue_global(true);
            print("spec-ops elite: 'no one see me now!'");
            cs_play_line("1080");
        }

        [ScriptMethod(224, Lifecycle.CommandScript)]
        public async Task stealth_comment_08()
        {
            cs_switch("ally");
            cs_abort_on_damage(true);
            cs_suppress_dialogue_global(true);
            print("spec-ops elite: 'tricky-tricky!'");
            cs_play_line("1090");
        }

        [ScriptMethod(225, Lifecycle.CommandScript)]
        public async Task stealth_comment_09()
        {
            cs_switch("ally");
            cs_abort_on_damage(true);
            cs_suppress_dialogue_global(true);
            print("spec-ops elite: 'where me gun go? oh, right! (laughs)'");
            cs_play_line("1100");
        }

        [ScriptMethod(226, Lifecycle.CommandScript)]
        public async Task stealth_comment_10()
        {
            cs_switch("ally");
            cs_abort_on_damage(true);
            cs_suppress_dialogue_global(true);
            print("spec-ops elite: '(a la elmer fudd) shhhh! me hunting he-wa-tics!'");
            cs_play_line("1110");
        }

        [ScriptMethod(227, Lifecycle.Static)]
        public async Task stealth_comment()
        {
            await sleep((short)random_range(10, 60));
            begin_random(async () =>
            {
                if (this.stealth_talk_gone == true)
                {
                    this.stealth_talk_gone = false;
                    ai_scene("stealth_comment_01_scene", new ScriptMethodReference(stealth_comment_01), all_allies) // Couldn't generate cast from 'Boolean' to 'Void'
                    ;
                }
            }, 
                async () =>
            {
                if (this.stealth_talk_gone == true)
                {
                    this.stealth_talk_gone = false;
                    ai_scene("stealth_comment_02_scene", new ScriptMethodReference(stealth_comment_02), all_allies) // Couldn't generate cast from 'Boolean' to 'Void'
                    ;
                }
            }, 
                async () =>
            {
                if (this.stealth_talk_gone == true)
                {
                    this.stealth_talk_gone = false;
                    ai_scene("stealth_comment_03_scene", new ScriptMethodReference(stealth_comment_03), all_allies) // Couldn't generate cast from 'Boolean' to 'Void'
                    ;
                }
            }, 
                async () =>
            {
                if (this.stealth_talk_gone == true)
                {
                    this.stealth_talk_gone = false;
                    ai_scene("stealth_comment_04_scene", new ScriptMethodReference(stealth_comment_04), all_allies) // Couldn't generate cast from 'Boolean' to 'Void'
                    ;
                }
            }, 
                async () =>
            {
                if (this.stealth_talk_gone == true)
                {
                    this.stealth_talk_gone = false;
                    ai_scene("stealth_comment_05_scene", new ScriptMethodReference(stealth_comment_05), all_allies) // Couldn't generate cast from 'Boolean' to 'Void'
                    ;
                }
            }, 
                async () =>
            {
                if (this.stealth_talk_gone == true)
                {
                    this.stealth_talk_gone = false;
                    ai_scene("stealth_comment_06_scene", new ScriptMethodReference(stealth_comment_06), all_allies) // Couldn't generate cast from 'Boolean' to 'Void'
                    ;
                }
            }, 
                async () =>
            {
                if (this.stealth_talk_gone == true)
                {
                    this.stealth_talk_gone = false;
                    ai_scene("stealth_comment_07_scene", new ScriptMethodReference(stealth_comment_07), all_allies) // Couldn't generate cast from 'Boolean' to 'Void'
                    ;
                }
            }, 
                async () =>
            {
                if (this.stealth_talk_gone == true)
                {
                    this.stealth_talk_gone = false;
                    ai_scene("stealth_comment_08_scene", new ScriptMethodReference(stealth_comment_08), all_allies) // Couldn't generate cast from 'Boolean' to 'Void'
                    ;
                }
            }, 
                async () =>
            {
                if (this.stealth_talk_gone == true)
                {
                    this.stealth_talk_gone = false;
                    ai_scene("stealth_comment_09_scene", new ScriptMethodReference(stealth_comment_09), all_allies) // Couldn't generate cast from 'Boolean' to 'Void'
                    ;
                }
            }, 
                async () =>
            {
                if (this.stealth_talk_gone == true)
                {
                    this.stealth_talk_gone = false;
                    ai_scene("stealth_comment_10_scene", new ScriptMethodReference(stealth_comment_10), all_allies) // Couldn't generate cast from 'Boolean' to 'Void'
                    ;
                }
            });
        }

        [ScriptMethod(228, Lifecycle.Dormant)]
        public async Task _04a_title0()
        {
            await this.cinematic_fade_from_white_bars();
            await sleep(30);
            cinematic_set_title(title_1);
            await sleep(150);
            hud_cinematic_fade(1F, 0.5F);
            cinematic_show_letterbox(false);
        }

        [ScriptMethod(229, Lifecycle.Dormant)]
        public async Task _04a_title1()
        {
            hud_cinematic_fade(0F, 0.5F);
            cinematic_show_letterbox(true);
            await sleep(30);
            cinematic_set_title(title_2);
            await sleep(150);
            hud_cinematic_fade(1F, 0.5F);
            cinematic_show_letterbox(false);
        }

        [ScriptMethod(230, Lifecycle.Dormant)]
        public async Task objective_hl_set()
        {
            await sleep(30);
            print("new objective set:");
            print("locate the heretic leader.");
            objectives_show_up_to(0);
        }

        [ScriptMethod(231, Lifecycle.Dormant)]
        public async Task objective_hl_clear()
        {
            print("objective complete:");
            print("locate the heretic leader.");
            objectives_finish_up_to(0);
        }

        [ScriptMethod(232, Lifecycle.Dormant)]
        public async Task objective_dogfight_set()
        {
            await sleep(30);
            print("new objective set:");
            print("pursue the heretic leader. neutralize enemy air units.");
            objectives_show_up_to(1);
        }

        [ScriptMethod(233, Lifecycle.Dormant)]
        public async Task objective_dogfight_clear()
        {
            print("objective complete:");
            print("pursue the heretic leader. neutralize enemy air units.");
            objectives_finish_up_to(1);
        }

        [ScriptMethod(234, Lifecycle.Dormant)]
        public async Task music_04a_01_start()
        {
            print("music 04a_01 start");
            sound_looping_start(GetTag<LoopingSoundTag>("scenarios\\solo\\04a_gasgiant\\04a_music\\04a_01", 4224915847U), default(IGameObject), 1F);
        }

        [ScriptMethod(235, Lifecycle.Dormant)]
        public async Task music_04a_01_stop()
        {
            print("music 04a_01 stop");
            sound_looping_stop(GetTag<LoopingSoundTag>("scenarios\\solo\\04a_gasgiant\\04a_music\\04a_01", 4224915847U));
        }

        [ScriptMethod(236, Lifecycle.Dormant)]
        public async Task music_04a_02_start()
        {
            print("music 04a_02 start");
            sound_looping_start(GetTag<LoopingSoundTag>("scenarios\\solo\\04a_gasgiant\\04a_music\\04a_02", 4225309069U), default(IGameObject), 1F);
        }

        [ScriptMethod(237, Lifecycle.Dormant)]
        public async Task music_04a_02_stop()
        {
            print("music 04a_02 stop");
            sound_looping_stop(GetTag<LoopingSoundTag>("scenarios\\solo\\04a_gasgiant\\04a_music\\04a_02", 4225309069U));
        }

        [ScriptMethod(238, Lifecycle.Dormant)]
        public async Task music_04a_03_start()
        {
            print("music 04a_03 start");
            sound_looping_start(GetTag<LoopingSoundTag>("scenarios\\solo\\04a_gasgiant\\04a_music\\04a_03", 4225833365U), default(IGameObject), 1F);
        }

        [ScriptMethod(239, Lifecycle.Dormant)]
        public async Task music_04a_04_start()
        {
            print("music 04a_04 start");
            sound_looping_start(GetTag<LoopingSoundTag>("scenarios\\solo\\04a_gasgiant\\04a_music\\04a_04", 4226226587U), default(IGameObject), 1F);
        }

        [ScriptMethod(240, Lifecycle.Dormant)]
        public async Task music_04a_04_stop()
        {
            await sleep_until(async () => volume_test_objects(vol_dog_obj_04, players()) == true || volume_test_objects(vol_dog_obj_07, players()) == true, 30, 8000);
            print("music 04a_04 stop");
            sound_looping_stop(GetTag<LoopingSoundTag>("scenarios\\solo\\04a_gasgiant\\04a_music\\04a_04", 4226226587U));
        }

        [ScriptMethod(241, Lifecycle.Dormant)]
        public async Task kill_volumes()
        {
            kill_volume_disable(kill_banshee_ledge);
            kill_volume_disable(kill_recycling_pit);
            kill_volume_disable(kill_recycling_left);
            kill_volume_disable(kill_recycling_right);
            kill_volume_disable(kill_hangar_pit_01);
            kill_volume_disable(kill_hangar_pit_02);
            kill_volume_disable(kill_hangar_pit_03);
            kill_volume_disable(kill_hangar_pit_04);
            kill_volume_disable(kill_underhangar_pit_01);
            kill_volume_disable(kill_underhangar_pit_02);
            kill_volume_disable(kill_bottling_pit_01);
            kill_volume_disable(kill_bottling_pit_02);
            await sleep_until(async () => (short)structure_bsp_index() == 3);
            kill_volume_disable(kill_lz_pit);
            await sleep_until(async () =>
            {
                await sleep_until(async () => (short)structure_bsp_index() == 3);
                kill_volume_enable(kill_recycling_pit);
                kill_volume_enable(kill_recycling_left);
                kill_volume_enable(kill_recycling_right);
                kill_volume_enable(kill_hangar_pit_01);
                kill_volume_enable(kill_hangar_pit_02);
                kill_volume_enable(kill_hangar_pit_03);
                kill_volume_enable(kill_hangar_pit_04);
                kill_volume_enable(kill_underhangar_pit_01);
                kill_volume_enable(kill_underhangar_pit_02);
                kill_volume_disable(kill_bottling_pit_01);
                kill_volume_disable(kill_bottling_pit_02);
                await sleep_until(async () => (short)structure_bsp_index() == 0);
                kill_volume_enable(kill_banshee_ledge);
                kill_volume_enable(kill_bottling_pit_01);
                kill_volume_enable(kill_bottling_pit_02);
                kill_volume_disable(kill_recycling_pit);
                kill_volume_disable(kill_recycling_left);
                kill_volume_disable(kill_recycling_right);
                kill_volume_disable(kill_hangar_pit_01);
                kill_volume_disable(kill_hangar_pit_02);
                kill_volume_disable(kill_hangar_pit_03);
                kill_volume_disable(kill_hangar_pit_04);
                kill_volume_disable(kill_underhangar_pit_01);
                kill_volume_disable(kill_underhangar_pit_02);
                return false;
            });
        }

        [ScriptMethod(242, Lifecycle.Static)]
        public async Task prep_return_from_intro()
        {
            ai_place(intro_phantom.Squad);
            object_teleport(await this.player0(), player0_start);
            object_teleport(await this.player1(), player1_start);
            ai_place(intro_elites.Squad);
            ai_place(allies_elites_01.Squad);
            ai_place(hacker.Squad);
            ai_place(allies_grunts_01.Squad);
        }

        [ScriptMethod(243, Lifecycle.Dormant)]
        public async Task wind()
        {
            await sleep_until(async () =>
            {
                sound_impulse_start(GetTag<SoundTag>("sound\\ambience\\sound_scenery\\gusty_wind\\details\\gusty_wind", 4226750883U), default(IGameObject), 1F);
                await sleep(30);
                player_effect_set_max_rotation((float)real_random_range(0.1F, 1F), (float)real_random_range(0.1F, 1F), 0F);
                player_effect_start((float)real_random_range(0.05F, 0.2F), (float)real_random_range(0.5F, 2F));
                player_effect_stop((float)real_random_range(3F, 5F));
                await sleep((short)random_range(300, 600));
                return (short)structure_bsp_index() == 3;
            });
        }

        [ScriptMethod(244, Lifecycle.Static)]
        public async Task windtoo()
        {
            await sleep_until(async () =>
            {
                sound_impulse_start(GetTag<SoundTag>("sound\\ambience\\sound_scenery\\gusty_wind\\details\\gusty_wind", 4226750883U), default(IGameObject), 1F);
                await sleep(30);
                player_effect_set_max_rotation((float)real_random_range(0.1F, 1F), (float)real_random_range(0.1F, 1F), 0F);
                player_effect_start((float)real_random_range(0.05F, 0.2F), (float)real_random_range(0.5F, 2F));
                player_effect_stop((float)real_random_range(3F, 5F));
                await sleep((short)random_range(300, 600));
                return (short)structure_bsp_index() == 3;
            });
        }

        [ScriptMethod(245, Lifecycle.CommandScript)]
        public async Task lz_phantom_01_away()
        {
            cs_enable_pathfinding_failsafe(true);
            cs_vehicle_boost(true);
            cs_fly_to(GetReference<ISpatialPoint>("airspace_lz/exit01"), 20F);
            ai_erase(this.ai_current_actor);
        }

        [ScriptMethod(246, Lifecycle.CommandScript)]
        public async Task lz_phantom_02_away()
        {
            cs_enable_pathfinding_failsafe(true);
            cs_vehicle_boost(true);
            cs_fly_to(GetReference<ISpatialPoint>("airspace_lz/exit02"), 20F);
            ai_erase(this.ai_current_actor);
        }

        [ScriptMethod(247, Lifecycle.CommandScript)]
        public async Task lz_phantom_03_away()
        {
            cs_enable_pathfinding_failsafe(true);
            cs_vehicle_boost(true);
            cs_fly_to(GetReference<ISpatialPoint>("airspace_lz/exit03"), 20F);
            ai_erase(this.ai_current_actor);
        }

        [ScriptMethod(248, Lifecycle.Dormant)]
        public async Task commander_entry_reminder()
        {
            await sleep_until(async () => volume_test_objects(vol_entering_facility, players()) == true, 30, 900);
            if (volume_test_objects(vol_entering_facility, players()) == false && await this.player_count() > 0)
            {
                ai_dialogue_enable(false);
                await sleep(60);
                print("spec-ops commander: 'my warriors are in position, arbiter. they wait for you to lead them!'");
                await sleep(ai_play_line_on_object(default(IGameObject), "0970"));
                await sleep(30);
                ai_dialogue_enable(true);
            }
        }

        [ScriptMethod(249, Lifecycle.Dormant)]
        public async Task commander_comment_03()
        {
            ai_dialogue_enable(false);
            await sleep(60);
            print("spec-ops commander: 'you may wish to do the same, arbiter.'");
            await sleep(ai_play_line_on_object(default(IGameObject), "1000"));
            await sleep(30);
            print("'but, take heed. your armor's system is not as�new as ours. your camouflage will not last forever.'");
            await sleep(ai_play_line_on_object(default(IGameObject), "1010"));
            this.stealth_hint_done = true;
            await sleep(30);
            ai_dialogue_enable(true);
        }

        [ScriptMethod(250, Lifecycle.CommandScript)]
        public async Task lz_active_camo_call()
        {
            this.first_airlock_go = true;
            cs_switch("ally");
            object_cannot_take_damage(ai_get_object(this.ai_current_actor));
            cs_suppress_dialogue_global(true);
            print("spec-ops elite: 'engage active camouflage! reveal yourselves only after the arbiter has joined battle with the enemy!'");
            cs_play_line("0980");
            await sleep(30);
            ai_set_orders(all_allies, allies_rec_hide);
            await sleep(60);
            wake(new ScriptMethodReference(commander_comment_03));
            object_can_take_damage(ai_get_object(this.ai_current_actor));
        }

        [ScriptMethod(251, Lifecycle.CommandScript)]
        public async Task inner_aim_elites()
        {
            cs_abort_on_damage(true);
            cs_enable_moving(true);
            cs_crouch(true);
            await sleep_until(async () => volume_test_object(vol_entering_facility, ai_get_object(this.ai_current_actor)) == true);
            cs_aim(true, GetReference<ISpatialPoint>("recycling_center/rec_center_inner"));
            cs_crouch(false);
            await sleep_until(async () => (short)structure_bsp_index() == 3);
            cs_enable_moving(false);
            await sleep_until(async () => device_get_position(rec_center_entry_int.Entity) > 0F);
            cs_aim(false, GetReference<ISpatialPoint>("recycling_center/rec_center_inner"));
        }

        [ScriptMethod(252, Lifecycle.CommandScript)]
        public async Task inner_aim_hacker()
        {
            cs_abort_on_damage(true);
            cs_enable_moving(true);
            await sleep_until(async () => volume_test_object(vol_entering_facility, ai_get_object(this.ai_current_actor)) == true);
            cs_aim(true, GetReference<ISpatialPoint>("recycling_center/rec_center_inner"));
            await sleep_until(async () => (short)structure_bsp_index() == 3);
            cs_enable_moving(false);
            await sleep_until(async () => device_get_position(rec_center_entry_int.Entity) > 0F);
            cs_aim(false, GetReference<ISpatialPoint>("recycling_center/rec_center_inner"));
        }

        [ScriptMethod(253, Lifecycle.CommandScript)]
        public async Task inner_aim_grunts()
        {
            cs_abort_on_damage(true);
            await sleep(60);
            cs_enable_moving(true);
            await sleep_until(async () => volume_test_object(vol_entering_facility, ai_get_object(this.ai_current_actor)) == true);
            cs_aim(true, GetReference<ISpatialPoint>("recycling_center/rec_center_inner"));
            await sleep_until(async () => (short)structure_bsp_index() == 3);
            cs_enable_moving(false);
            await sleep_until(async () => device_get_position(rec_center_entry_int.Entity) > 0F);
            cs_aim(false, GetReference<ISpatialPoint>("recycling_center/rec_center_inner"));
        }

        [ScriptMethod(254, Lifecycle.Dormant)]
        public async Task production_arm_bsp_swap()
        {
            device_operates_automatically_set(rec_center_entry_ext.Entity, true);
            cs_run_command_script(allies_elites_01.Squad, new ScriptMethodReference(inner_aim_elites));
            cs_run_command_script(allies_grunts_01.Squad, new ScriptMethodReference(inner_aim_grunts));
            ai_set_orders(allies_elites_01.Squad, allies_enter);
            ai_set_orders(allies_grunts_01.Squad, allies_enter);
            ai_set_orders(intro_elites.Squad, lz_linger);
            wake(new ScriptMethodReference(commander_entry_reminder));
            await sleep_until(async () => volume_test_objects_all(vol_entering_facility, players()) == true && await this.player_count() > 0);
            cs_run_command_script(hacker.Squad, new ScriptMethodReference(inner_aim_hacker));
            ai_set_orders(hacker.Squad, allies_enter);
            sleep_forever(new ScriptMethodReference(wind));
            await sleep_until(async () => volume_test_objects_all(vol_entering_facility, players()) == true && await this.player_count() > 0 && device_get_position(rec_center_entry_ext.Entity) == 0F);
            device_operates_automatically_set(rec_center_entry_ext.Entity, false);
            await sleep(30);
            sound_class_set_gain("ambient_machinery", 0F, 2);
            sound_impulse_start(GetTag<SoundTag>("sound_remastered\\visual_effects\\ss_airlock\\airlock", 4226816420U), default(IGameObject), 1F);
            begin_random(async () => object_create_anew(gas01), 
                async () => await sleep((short)random_range(5, 15)), 
                async () => object_create_anew(gas02), 
                async () => await sleep((short)random_range(5, 15)), 
                async () => object_create_anew(gas03), 
                async () => await sleep((short)random_range(5, 15)), 
                async () => object_create_anew(gas04), 
                async () => await sleep((short)random_range(5, 15)), 
                async () => object_create_anew(gas05), 
                async () => await sleep((short)random_range(5, 15)), 
                async () => object_create_anew(gas06), 
                async () => await sleep((short)random_range(5, 15)), 
                async () => object_create_anew(gas07), 
                async () => await sleep((short)random_range(5, 15)), 
                async () => object_create_anew(gas08), 
                async () => await sleep((short)random_range(5, 15)), 
                async () => object_create_anew(gas09), 
                async () => await sleep((short)random_range(5, 15)), 
                async () => object_create_anew(gas10), 
                async () => await sleep((short)random_range(5, 15)));
            switch_bsp(3);
            await sleep_until(async () => (short)structure_bsp_index() == 3);
            object_destroy(filthy_audio1.Entity);
            object_destroy(filthy_audio2.Entity);
            sound_class_set_gain("ambient_machinery", 1F, 2);
            await sleep_until(async () => ai_scene("lz_active_camo_scene", new ScriptMethodReference(lz_active_camo_call), all_allies) || (short)ai_living_count(hacker.Squad) < 0 && (short)ai_living_count(allies_elites_01.Squad) < 1, 30, 150);
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
            player_training_activate_stealth();
            if (this.first_airlock_go == true)
            {
                await sleep_until(async () => this.stealth_hint_done == true, 30, 900);
            }

            device_operates_automatically_set(rec_center_entry_int.Entity, true);
        }

        [ScriptMethod(255, Lifecycle.Dormant)]
        public async Task commander_comment_01()
        {
            await sleep(60);
            ai_dialogue_enable(false);
            await sleep(60);
            print("spec-ops commander: 'we are the arm of the prophets, dervish, and you are the blade!'");
            await sleep(ai_play_line_on_object(default(IGameObject), "0210"));
            await sleep(30);
            print("'be silent and swift, and we will quell this heresy without incident!'");
            await sleep(ai_play_line_on_object(default(IGameObject), "0220"));
            await sleep(15);
            this.commander_done_yapping = true;
            await sleep(30);
        }

        [ScriptMethod(256, Lifecycle.Dormant)]
        public async Task commander_comment_02()
        {
            ai_dialogue_enable(false);
            await sleep(60);
            print("spec-ops commander: 'the storm has masked our approach.'");
            await sleep(ai_play_line_on_object(default(IGameObject), "0240"));
            await sleep(30);
            print("spec-ops commander: 'and it should have their local battle-net in disarray.'");
            await sleep(ai_play_line_on_object(default(IGameObject), "0250"));
            await sleep(30);
            print("spec-ops commander: 'we have the element of surprise.  for now.'");
            await sleep(ai_play_line_on_object(default(IGameObject), "0260"));
            unit_stop_custom_animation(unit(list_get(ai_actors(hacker.Squad), 0)));
            this.open_rec_center = true;
            await sleep(30);
            ai_dialogue_enable(true);
        }

        [ScriptMethod(257, Lifecycle.CommandScript)]
        public async Task lz_phantom_leaves()
        {
            cs_fly_by(GetReference<ISpatialPoint>("airspace_lz/p0"), 10F);
            cs_fly_by(GetReference<ISpatialPoint>("airspace_lz/p1"), 10F);
            cs_fly_by(GetReference<ISpatialPoint>("airspace_lz/p2"), 10F);
            cs_fly_by(GetReference<ISpatialPoint>("airspace_lz/p3"), 10F);
            cs_fly_by(GetReference<ISpatialPoint>("airspace_lz/p4"), 10F);
            cs_fly_by(GetReference<ISpatialPoint>("airspace_lz/p5"), 10F);
            cs_fly_to(GetReference<ISpatialPoint>("airspace_lz/p6"), 10F);
            ai_erase(intro_phantom.Squad);
        }

        [ScriptMethod(258, Lifecycle.CommandScript)]
        public async Task landing_zone_follow_01()
        {
            cs_abort_on_damage(true);
            cs_enable_pathfinding_failsafe(true);
            cs_go_to(GetReference<ISpatialPoint>("landing_zone/ramp01"));
            cs_face_player(true);
            await sleep_until(async () => volume_test_objects(vol_leaving_lz, players()) == true);
            cs_face_player(false);
        }

        [ScriptMethod(259, Lifecycle.CommandScript)]
        public async Task landing_zone_follow_02()
        {
            cs_abort_on_damage(true);
            cs_enable_pathfinding_failsafe(true);
            cs_go_to(GetReference<ISpatialPoint>("landing_zone/ramp02"));
            cs_face_player(true);
            await sleep_until(async () => volume_test_objects(vol_leaving_lz, players()) == true);
            cs_face_player(false);
            cs_suppress_dialogue_global(true);
            if (this.commander_done_yapping == true)
            {
                print("spec-ops elite: 'first lance in position!'");
                cs_play_line("0230");
            }
        }

        [ScriptMethod(260, Lifecycle.CommandScript)]
        public async Task swat_hack()
        {
            cs_abort_on_damage(true);
            cs_aim(true, GetReference<ISpatialPoint>("landing_zone/control"));
            await sleep_until(async () => device_get_position(rec_center_entry_ext.Entity) == 1F || volume_test_objects(vol_entering_facility, players()) == true);
            cs_aim(false, GetReference<ISpatialPoint>("landing_zone/control"));
        }

        [ScriptMethod(261, Lifecycle.CommandScript)]
        public async Task swat_aim()
        {
            cs_abort_on_damage(true);
            cs_aim(true, GetReference<ISpatialPoint>("landing_zone/entry"));
            await sleep_until(async () => device_get_position(rec_center_entry_ext.Entity) == 1F || volume_test_objects(vol_entering_facility, players()) == true);
            cs_aim(false, GetReference<ISpatialPoint>("landing_zone/entry"));
        }

        [ScriptMethod(262, Lifecycle.Dormant)]
        public async Task swat_deploy()
        {
            data_mine_set_mission_segment("04a_1_landing_zone");
            wake(new ScriptMethodReference(wind));
            wake(new ScriptMethodReference(commander_comment_01));
            cs_run_command_script(intro_elites._01, new ScriptMethodReference(landing_zone_follow_01));
            cs_run_command_script(intro_elites._02, new ScriptMethodReference(landing_zone_follow_02));
            custom_animation_loop(unit(list_get(ai_actors(hacker.Squad), 0)), GetTag<AnimationGraphTag>("objects\\characters\\elite\\elite", 3891463805U), "uplink_station", true);
            cs_run_command_script(hacker.Squad, new ScriptMethodReference(swat_hack));
            cs_run_command_script(intro_phantom._01, new ScriptMethodReference(lz_phantom_01_away));
            cs_run_command_script(intro_phantom._02, new ScriptMethodReference(lz_phantom_02_away));
            cs_run_command_script(intro_phantom._03, new ScriptMethodReference(lz_phantom_03_away));
            cs_run_command_script(allies_grunts_01.Squad, new ScriptMethodReference(swat_aim));
            cs_run_command_script(allies_elites_01.Squad, new ScriptMethodReference(swat_aim));
            await sleep_until(async () => volume_test_objects(vol_entry_landing, players()) == true);
            await sleep_until(async () => this.commander_done_yapping == true);
            wake(new ScriptMethodReference(commander_comment_02));
            await sleep_until(async () => this.open_rec_center == true || object_get_health(list_get(ai_actors(hacker.Squad), 0)) <= 0F, 30, 360);
            wake(new ScriptMethodReference(production_arm_bsp_swap));
            await sleep_until(async () => volume_test_objects_all(vol_phantom_kill, ai_actors(intro_phantom.Squad)) == true || volume_test_objects_all(vol_recycling_all, players()) == true && await this.player_count() > 0);
            ai_erase(intro_phantom.Squad);
            await sleep_until(async () => volume_test_objects_all(vol_recycling_all, players()) == true && await this.player_count() > 0);
            ai_erase(intro_elites.Squad);
        }

        [ScriptMethod(263, Lifecycle.Dormant)]
        public async Task recycling_can_spawner()
        {
            object_set_deleted_when_deactivated(rec_can_a_01.Entity);
            object_set_deleted_when_deactivated(rec_can_a_02.Entity);
            object_set_deleted_when_deactivated(rec_can_a_03.Entity);
            object_set_deleted_when_deactivated(rec_can_a_04.Entity);
            object_set_deleted_when_deactivated(rec_can_a_06.Entity);
            object_set_deleted_when_deactivated(rec_can_a_07.Entity);
            object_set_deleted_when_deactivated(rec_can_b_01.Entity);
            object_set_deleted_when_deactivated(rec_can_b_02.Entity);
            object_set_deleted_when_deactivated(rec_can_c_01.Entity);
            object_set_deleted_when_deactivated(rec_can_c_02.Entity);
            object_set_deleted_when_deactivated(rec_can_c_03.Entity);
            object_set_deleted_when_deactivated(rec_can_c_04.Entity);
            object_set_deleted_when_deactivated(rec_can_c_06.Entity);
            await sleep_until(async () => this.recycling_power_on == true);
            await sleep_until(async () =>
            {
                begin_random(async () =>
                {
                    if (list_count(volume_return_objects_by_type(vol_recycling_can_all, 2048)) < 20)
                    {
                        object_create_clone(recycling_can_a);
                        object_set_deleted_when_deactivated(recycling_can_a.Entity);
                    }
                }, 
                    async () => await sleep(this.recycling_time), 
                    async () =>
                {
                    if (list_count(volume_return_objects_by_type(vol_recycling_can_all, 2048)) < 20)
                    {
                        object_create_clone(recycling_can_b);
                        object_set_deleted_when_deactivated(recycling_can_b.Entity);
                    }
                }, 
                    async () => await sleep(this.recycling_time), 
                    async () =>
                {
                    if (list_count(volume_return_objects_by_type(vol_recycling_can_all, 2048)) < 20)
                    {
                        object_create_clone(recycling_can_c);
                        object_set_deleted_when_deactivated(recycling_can_c.Entity);
                    }
                }, 
                    async () => await sleep(this.recycling_time));
                return this.recycling_power_on == false;
            });
        }

        [ScriptMethod(264, Lifecycle.Dormant)]
        public async Task recycling_killer_new()
        {
            await sleep_until(async () => this.recycling_power_on == true);
            await sleep_until(async () =>
            {
                object_destroy(list_get(volume_return_objects(kill_recycling_pit), 0));
                await sleep(30);
                unit_kill_silent(unit(list_get(volume_return_objects_by_type(kill_recycling_pit, 1), 0)));
                await sleep(30);
                return this.recycling_power_on == false;
            });
        }

        [ScriptMethod(265, Lifecycle.CommandScript)]
        public async Task heretic_chat()
        {
            cs_switch("chat_her_02");
            cs_abort_on_alert(true);
            this.chatter_her_02 = ai_get_object(this.ai_current_actor);
            cs_enable_moving(true);
            cs_switch("chat_her_01");
            cs_abort_on_alert(true);
            this.chatter_her_01 = ai_get_object(this.ai_current_actor);
            cs_enable_pathfinding_failsafe(true);
            cs_go_to_and_face(GetReference<ISpatialPoint>("recycling_center/p0"), GetReference<ISpatialPoint>("recycling_center/p1"));
            cs_custom_animation(GetTag<AnimationGraphTag>("objects\\characters\\elite\\elite", 3891463805U), "uplink_station", 0F, true);
            custom_animation_loop(unit(ai_get_object(this.ai_current_actor)), GetTag<AnimationGraphTag>("objects\\characters\\elite\\elite", 3891463805U), "uplink_station", true);
            cs_switch("chat_her_02");
            cs_enable_pathfinding_failsafe(true);
            cs_approach(this.chatter_her_01, 2F, 20F, 20F);
            cs_suppress_dialogue_global(true);
            print("heretic_01: 'any word on our missing brothers?'");
            cs_play_line("0270");
            cs_switch("chat_her_01");
            unit_stop_custom_animation(unit(ai_get_object(this.ai_current_actor)));
            cs_face(false, GetReference<ISpatialPoint>("recycling_center/p1"));
            cs_approach(this.chatter_her_02, 1.5F, 20F, 20F);
            cs_suppress_dialogue_global(true);
            print("heretic_02: 'still nothing.'");
            cs_play_line("0280");
            await sleep(30);
            print("heretic_02: 'and given what sleeps here, i fear they are lost.'");
            cs_play_line("0290");
            await sleep(15);
            cs_switch("chat_her_02");
            cs_suppress_dialogue_global(true);
            print("heretic_01: 'surely the oracle will protect us?'");
            cs_play_line("0300");
            await sleep(15);
            cs_switch("chat_her_01");
            cs_suppress_dialogue_global(true);
            print("heretic_02: 'perhaps. but i fear its sentinels are too few.'");
            cs_play_line("0310");
            await sleep(15);
            print("heretic_02: 'better we protect ourselves.'");
            cs_play_line("0320");
            await sleep(30);
            cs_run_command_script(rec_center_heretic_02.Squad, new ScriptMethodReference(abort));
            cs_approach_stop();
            await sleep(60);
            cs_enable_moving(true);
        }

        [ScriptMethod(266, Lifecycle.Dormant)]
        public async Task heretic_uplink_01()
        {
            custom_animation_loop(unit(list_get(ai_actors(rec_center_heretic_03.Squad), 0)), GetTag<AnimationGraphTag>("objects\\characters\\elite\\elite", 3891463805U), "uplink_station", true);
            await sleep_until(async () => (short)ai_combat_status(rec_center_heretic_03.Squad) > this.ai_combat_status_idle);
            unit_stop_custom_animation(unit(list_get(ai_actors(rec_center_heretic_03.Squad), 0)));
        }

        [ScriptMethod(267, Lifecycle.Dormant)]
        public async Task rec_center_reminder()
        {
            await sleep_until(async () => volume_test_objects(vol_leaving_rec_center, players()) == true, 30, 3600);
            if (volume_test_objects(vol_leaving_rec_center, players()) == false && await this.player_count() > 0)
            {
                ai_dialogue_enable(false);
                await sleep(60);
                print("spec-ops commander: 'there should be a hangar directly below you. find a way down!'");
                await sleep(ai_play_line_on_object(default(IGameObject), "1130"));
                await sleep(30);
                ai_dialogue_enable(true);
            }
        }

        [ScriptMethod(268, Lifecycle.CommandScript)]
        public async Task get_on_e1()
        {
            cs_enable_pathfinding_failsafe(true);
            cs_go_to(GetReference<ISpatialPoint>("recycling_center/e1"));
        }

        [ScriptMethod(269, Lifecycle.CommandScript)]
        public async Task get_on_e2()
        {
            cs_enable_pathfinding_failsafe(true);
            cs_go_to(GetReference<ISpatialPoint>("recycling_center/e2"));
        }

        [ScriptMethod(270, Lifecycle.CommandScript)]
        public async Task get_on_g1()
        {
            cs_enable_pathfinding_failsafe(true);
            cs_go_to(GetReference<ISpatialPoint>("recycling_center/g1"));
        }

        [ScriptMethod(271, Lifecycle.CommandScript)]
        public async Task get_on_g2()
        {
            cs_enable_pathfinding_failsafe(true);
            cs_go_to(GetReference<ISpatialPoint>("recycling_center/g2"));
        }

        [ScriptMethod(272, Lifecycle.CommandScript)]
        public async Task rec_center_turret()
        {
            cs_enable_pathfinding_failsafe(true);
            cs_go_to(GetReference<ISpatialPoint>("rec_cen_turret/go_here"));
            cs_deploy_turret(GetReference<ISpatialPoint>("rec_cen_turret/p1"));
            cs_enable_targeting(true);
            cs_shoot(true);
            cs_set_behavior(guard);
            sleep_forever();
        }

        [ScriptMethod(273, Lifecycle.Dormant)]
        public async Task recycling_center_start()
        {
            await sleep_until(async () => (short)structure_bsp_index() == 3);
            data_mine_set_mission_segment("04a_2_recycling_center");
            object_create_containing("rec_can_");
            wake(new ScriptMethodReference(recycling_can_spawner));
            wake(new ScriptMethodReference(recycling_killer_new));
            this.recycling_power_on = true;
            ai_place(rec_center_heretic_01.Squad, 1);
            ai_place(rec_center_heretic_02.Squad, 1);
            cs_run_command_script(rec_center_heretic_02.Squad, new ScriptMethodReference(long_pause));
            ai_place(rec_center_grunts_01.Squad, 2);
            await sleep_until(async () => this.stealth_hint_done == true);
            game_save();
            await sleep_until(async () => device_get_position(rec_center_entry_int.Entity) > 0F);
            await sleep_until(async () => device_get_position(rec_center_entry_int.Entity) == 1F);
            ai_scene("heretic_chat_scene", new ScriptMethodReference(heretic_chat), rec_center_h_entry) // Couldn't generate cast from 'Boolean' to 'Void'
            ;
            ai_set_orders(arm01_allies, allies_rec_center_all);
            await sleep_until(async () => volume_test_objects(vol_rec_slope_top, players()) == true || (short)ai_living_count(rec_center_heretics) < 2);
            game_save();
            ai_place(rec_center_grunts_02R.Squad, 2);
            ai_place(rec_center_grunts_02L.Squad, 2);
            if ((short)ai_combat_status(rec_center_heretics) > this.ai_combat_status_idle)
            {
                if (objects_can_see_object(players(), rec_cen_rein_01r.Entity, 45F))
                {
                    if ((short)ai_living_count(rec_center_heretics) < 8)
                    {
                        ai_place(rec_cen_rein_her_01R.Squad, 1);
                    }

                    cs_run_command_script(rec_cen_rein_her_01R.Squad, new ScriptMethodReference(snap_alert));
                    if ((short)ai_living_count(rec_center_heretics) < 8)
                    {
                        ai_place(rec_cen_rein_grt_01R.Squad, (short)random_range(1, 3));
                    }

                    cs_run_command_script(rec_cen_rein_grt_01R.Squad, new ScriptMethodReference(snap_alert));
                }

                if (objects_can_see_object(players(), rec_cen_rein_01l.Entity, 45F))
                {
                    if ((short)ai_living_count(rec_center_heretics) < 8)
                    {
                        ai_place(rec_cen_rein_her_01L.Squad, (short)(1 - (float)ai_living_count(rec_cen_rein_her_01R.Squad)));
                    }

                    cs_run_command_script(rec_cen_rein_her_01L.Squad, new ScriptMethodReference(snap_alert));
                    if ((short)ai_living_count(rec_center_heretics) < 8)
                    {
                        ai_place(rec_cen_rein_grt_01L.Squad, (short)((float)random_range(1, 3) - (float)ai_living_count(rec_cen_rein_grt_01R.Squad)));
                    }

                    cs_run_command_script(rec_cen_rein_grt_01L.Squad, new ScriptMethodReference(snap_alert));
                }
            }

            await sleep_until(async () => volume_test_objects(vol_recycling_mid_01, players()) == true || (short)ai_living_count(rec_center_heretics) < 3);
            game_save();
            cs_run_command_script(allies_grunts_01.grunt02, new ScriptMethodReference(rec_center_turret));
            if ((short)ai_living_count(rec_center_heretics) < 8)
            {
                ai_place(rec_center_grunts_03.Squad, 3);
            }

            if ((short)ai_living_count(rec_center_heretics) < 8)
            {
                ai_place(rec_center_heretic_03.Squad, 2);
            }

            wake(new ScriptMethodReference(heretic_uplink_01));
            await sleep_until(async () => volume_test_objects(vol_recycling_mid_02, players()) == true || (short)ai_living_count(rec_center_heretics) < 3);
            game_save();
            if ((short)ai_living_count(rec_center_heretics) < 8)
            {
                ai_place(rec_center_heretic_04.Squad, (short)(1 - (float)ai_living_count(rec_center_heretic_03.Squad)));
            }

            if ((short)ai_living_count(rec_center_heretics) < 8)
            {
                ai_place(rec_center_grunts_04.Squad, (short)(3 - (float)ai_living_count(rec_center_grunts_03.Squad)));
            }

            wake(new ScriptMethodReference(rec_center_reminder));
            await sleep_until(async () => volume_test_objects(vol_leaving_rec_center, players()) == true || (short)ai_living_count(rec_center_heretics) == 0);
            device_set_position_immediate(elev_hangar.Entity, 0.25F);
            cs_run_command_script(allies_grunts_01.grunt02, new ScriptMethodReference(abort));
            ai_vehicle_exit(allies_grunts_01.Squad);
            await sleep_until(async () => volume_test_objects(vol_leaving_rec_center, players()) == true);
            await sleep_until(async () => (short)ai_combat_status(all_enemies) < this.ai_combat_status_uninspected, 30, 150);
            this.stealth_talk_gone = true;
            ai_set_orders(arm01_allies, allies_rec_center_under);
            game_save();
            if ((short)ai_living_count(rec_center_heretics) < 8)
            {
                ai_place(rec_center_grunts_06.Squad, 4);
            }

            await sleep_until(async () => volume_test_objects(vol_hangar_lift_top, players()) == true || (short)ai_living_count(rec_center_heretics) < 3);
            game_save();
            if ((short)ai_living_count(rec_center_heretics) < 8)
            {
                ai_place(rec_center_heretic_06.Squad, 1);
            }

            if ((short)ai_living_count(rec_center_heretics) < 8)
            {
                ai_place(rec_center_grunts_07.Squad, 3);
            }

            device_set_position(elev_hangar.Entity, 0F);
            await sleep_until(async () => (short)ai_living_count(rec_center_heretics) < 1, 30, 1800);
            await sleep_until(async () => (bool)game_safe_to_save() == true);
            game_save();
            ai_set_orders(arm01_allies, get_on_hangar_elev);
            cs_run_command_script(hacker.Squad, new ScriptMethodReference(get_on_e1));
            cs_run_command_script(allies_elites_01.Squad, new ScriptMethodReference(get_on_e2));
            cs_run_command_script(allies_grunts_01.grunt01, new ScriptMethodReference(get_on_g1));
            cs_run_command_script(allies_grunts_01.grunt02, new ScriptMethodReference(get_on_g2));
        }

        [ScriptMethod(274, Lifecycle.Dormant)]
        public async Task hangar_extra_save()
        {
            await sleep_until(async () => device_get_position(elev_hangar.Entity) == 1F);
            await sleep_until(async () => (bool)game_safe_to_save());
            game_save();
        }

        [ScriptMethod(275, Lifecycle.Dormant)]
        public async Task hangar_can_spawner()
        {
            await sleep_until(async () => this.hangar_power_on == true);
            await sleep_until(async () =>
            {
                begin_random(async () =>
                {
                    if (list_count(volume_return_objects_by_type(vol_hangar_can_all, 2048)) < 15)
                    {
                        object_create_clone(hangar_can_a);
                    }
                }, 
                    async () => await sleep(this.recycling_time), 
                    async () =>
                {
                    if (list_count(volume_return_objects_by_type(vol_hangar_can_all, 2048)) < 15)
                    {
                        object_create_clone(hangar_can_b);
                    }
                }, 
                    async () => await sleep(this.recycling_time), 
                    async () =>
                {
                    if (list_count(volume_return_objects_by_type(vol_hangar_can_all, 2048)) < 15)
                    {
                        object_create_clone(hangar_can_c);
                    }
                }, 
                    async () => await sleep(this.recycling_time), 
                    async () =>
                {
                    if (list_count(volume_return_objects_by_type(vol_hangar_can_all, 2048)) < 15)
                    {
                        object_create_clone(hangar_can_d);
                    }
                }, 
                    async () => await sleep(this.recycling_time));
                return this.hangar_power_on == false;
            });
        }

        [ScriptMethod(276, Lifecycle.Dormant)]
        public async Task hangar_killer_new()
        {
            await sleep_until(async () => this.hangar_power_on == true);
            await sleep_until(async () =>
            {
                object_destroy(list_get(volume_return_objects(kill_hangar_pit_01), 0));
                await sleep(30);
                unit_kill_silent(unit(list_get(volume_return_objects_by_type(kill_hangar_pit_01, 1), 0)));
                await sleep(30);
                object_destroy(list_get(volume_return_objects(kill_hangar_pit_02), 0));
                await sleep(30);
                unit_kill_silent(unit(list_get(volume_return_objects_by_type(kill_hangar_pit_02, 1), 0)));
                await sleep(30);
                object_destroy(list_get(volume_return_objects(kill_hangar_pit_03), 0));
                await sleep(30);
                unit_kill_silent(unit(list_get(volume_return_objects_by_type(kill_hangar_pit_03, 1), 0)));
                await sleep(30);
                object_destroy(list_get(volume_return_objects(kill_hangar_pit_04), 0));
                await sleep(30);
                unit_kill_silent(unit(list_get(volume_return_objects_by_type(kill_hangar_pit_04, 1), 0)));
                await sleep(30);
                return this.hangar_power_on == false;
            });
        }

        [ScriptMethod(277, Lifecycle.CommandScript)]
        public async Task hangar_help_01()
        {
            cs_enable_pathfinding_failsafe(true);
            cs_vehicle_speed(0.5F);
            await sleep(120);
            objects_attach(list_get(ai_actors(hangar_helper_01.Squad), 0), "primary_trigger", help_can_01.Entity, "top");
            cs_fly_by(GetReference<ISpatialPoint>("hangar/p0"));
            cs_fly_by(GetReference<ISpatialPoint>("hangar/p9"));
            cs_fly_to(GetReference<ISpatialPoint>("hangar/p8"));
            objects_detach(list_get(ai_actors(hangar_helper_01.Squad), 0), help_can_01.Entity);
            object_destroy(help_can_01.Entity);
            ai_erase(hangar_helper_01.Squad);
        }

        [ScriptMethod(278, Lifecycle.CommandScript)]
        public async Task hangar_help_02()
        {
            cs_enable_pathfinding_failsafe(true);
            cs_vehicle_speed(0.5F);
            cs_fly_by(GetReference<ISpatialPoint>("hangar/p7"));
            cs_fly_to(GetReference<ISpatialPoint>("hangar/p10"));
            objects_attach(list_get(ai_actors(hangar_helper_02.Squad), 0), "primary_trigger", help_can_02.Entity, "top");
            cs_fly_by(GetReference<ISpatialPoint>("hangar/p0"));
            cs_fly_to(GetReference<ISpatialPoint>("hangar/p11"));
            objects_detach(list_get(ai_actors(hangar_helper_02.Squad), 0), help_can_02.Entity);
        }

        [ScriptMethod(279, Lifecycle.CommandScript)]
        public async Task hangar_help_03()
        {
            cs_enable_pathfinding_failsafe(true);
            cs_vehicle_speed(0.5F);
            await sleep_until(async () =>
            {
                begin_random(async () => cs_fly_to(GetReference<ISpatialPoint>("hangar/p3")), 
                    async () => cs_shoot_point(true, GetReference<ISpatialPoint>("hangar/weld1")), 
                    async () => await sleep(90), 
                    async () => cs_shoot_point(false, GetReference<ISpatialPoint>("hangar/weld1")), 
                    async () => cs_fly_to(GetReference<ISpatialPoint>("hangar/p4")), 
                    async () => cs_shoot_point(true, GetReference<ISpatialPoint>("hangar/weld2")), 
                    async () => await sleep(90), 
                    async () => cs_shoot_point(false, GetReference<ISpatialPoint>("hangar/weld2")), 
                    async () => cs_fly_to(GetReference<ISpatialPoint>("hangar/p5")), 
                    async () => cs_shoot_point(true, GetReference<ISpatialPoint>("hangar/weld3")), 
                    async () => await sleep(90), 
                    async () => cs_shoot_point(false, GetReference<ISpatialPoint>("hangar/weld3")), 
                    async () => cs_fly_to(GetReference<ISpatialPoint>("hangar/p6")), 
                    async () => cs_shoot_point(true, GetReference<ISpatialPoint>("hangar/weld4")), 
                    async () => await sleep(90), 
                    async () => cs_shoot_point(false, GetReference<ISpatialPoint>("hangar/weld4")));
                return false;
            });
        }

        [ScriptMethod(280, Lifecycle.CommandScript)]
        public async Task hangar_fly_out_l1()
        {
            cs_enable_pathfinding_failsafe(true);
            cs_vehicle_speed(0.5F);
            cs_fly_by(GetReference<ISpatialPoint>("hangar_too/l1_1"));
            cs_fly_to(GetReference<ISpatialPoint>("hangar_too/l1_0"));
        }

        [ScriptMethod(281, Lifecycle.CommandScript)]
        public async Task hangar_fly_out_l2()
        {
            cs_enable_pathfinding_failsafe(true);
            cs_vehicle_speed(0.5F);
            cs_fly_by(GetReference<ISpatialPoint>("hangar_too/l2_1"));
            cs_fly_to(GetReference<ISpatialPoint>("hangar_too/l2_0"));
        }

        [ScriptMethod(282, Lifecycle.CommandScript)]
        public async Task hangar_fly_out_r1()
        {
            cs_enable_pathfinding_failsafe(true);
            cs_vehicle_speed(0.5F);
            cs_fly_by(GetReference<ISpatialPoint>("hangar_too/r1_1"));
            cs_fly_to(GetReference<ISpatialPoint>("hangar_too/r1_0"));
        }

        [ScriptMethod(283, Lifecycle.CommandScript)]
        public async Task hangar_fly_out_r2()
        {
            cs_enable_pathfinding_failsafe(true);
            cs_vehicle_speed(0.5F);
            cs_fly_by(GetReference<ISpatialPoint>("hangar_too/r2_1"));
            cs_fly_to(GetReference<ISpatialPoint>("hangar_too/r2_0"));
        }

        [ScriptMethod(284, Lifecycle.CommandScript)]
        public async Task hangar_fly_out_c1()
        {
            cs_enable_pathfinding_failsafe(true);
            cs_vehicle_speed(0.5F);
            cs_fly_by(GetReference<ISpatialPoint>("hangar_too/c1_1"));
            cs_fly_to(GetReference<ISpatialPoint>("hangar_too/c1_0"));
        }

        [ScriptMethod(285, Lifecycle.CommandScript)]
        public async Task hangar_fly_out_c2()
        {
            cs_enable_pathfinding_failsafe(true);
            cs_vehicle_speed(0.5F);
            cs_fly_by(GetReference<ISpatialPoint>("hangar_too/c2_1"));
            cs_fly_to(GetReference<ISpatialPoint>("hangar_too/c2_0"));
        }

        [ScriptMethod(286, Lifecycle.CommandScript)]
        public async Task hangar_fly_l1()
        {
            cs_enable_pathfinding_failsafe(true);
            await sleep_until(async () => volume_test_objects(vol_hangar_center, this.ai_current_actor) == true);
            cs_vehicle_speed(0.5F);
            cs_fly_by(GetReference<ISpatialPoint>("hangar_too/l1_0"));
            cs_fly_by(GetReference<ISpatialPoint>("hangar_too/l1_1"));
            cs_fly_to(GetReference<ISpatialPoint>("hangar_too/l1_2"));
            ai_erase(this.ai_current_actor);
        }

        [ScriptMethod(287, Lifecycle.CommandScript)]
        public async Task hangar_fly_l2()
        {
            cs_enable_pathfinding_failsafe(true);
            await sleep_until(async () => volume_test_objects(vol_hangar_center, this.ai_current_actor) == true);
            cs_vehicle_speed(0.5F);
            cs_fly_by(GetReference<ISpatialPoint>("hangar_too/l2_0"));
            cs_fly_by(GetReference<ISpatialPoint>("hangar_too/l2_1"));
            cs_fly_to(GetReference<ISpatialPoint>("hangar_too/l2_2"));
            ai_erase(this.ai_current_actor);
        }

        [ScriptMethod(288, Lifecycle.CommandScript)]
        public async Task hangar_fly_r1()
        {
            cs_enable_pathfinding_failsafe(true);
            await sleep_until(async () => volume_test_objects(vol_hangar_center, this.ai_current_actor) == true);
            cs_vehicle_speed(0.5F);
            cs_fly_by(GetReference<ISpatialPoint>("hangar_too/r1_0"));
            cs_fly_by(GetReference<ISpatialPoint>("hangar_too/r1_1"));
            cs_fly_to(GetReference<ISpatialPoint>("hangar_too/r1_2"));
            ai_erase(this.ai_current_actor);
        }

        [ScriptMethod(289, Lifecycle.CommandScript)]
        public async Task hangar_fly_r2()
        {
            cs_enable_pathfinding_failsafe(true);
            await sleep_until(async () => volume_test_objects(vol_hangar_center, this.ai_current_actor) == true);
            cs_vehicle_speed(0.5F);
            cs_fly_by(GetReference<ISpatialPoint>("hangar_too/r2_0"));
            cs_fly_by(GetReference<ISpatialPoint>("hangar_too/r2_1"));
            cs_fly_to(GetReference<ISpatialPoint>("hangar_too/r2_2"));
            ai_erase(this.ai_current_actor);
        }

        [ScriptMethod(290, Lifecycle.CommandScript)]
        public async Task hangar_fly_c1()
        {
            cs_enable_pathfinding_failsafe(true);
            await sleep_until(async () => volume_test_objects(vol_hangar_center, this.ai_current_actor) == true);
            cs_vehicle_speed(0.5F);
            cs_fly_by(GetReference<ISpatialPoint>("hangar_too/c1_0"));
            cs_fly_by(GetReference<ISpatialPoint>("hangar_too/c1_1"));
            cs_fly_to(GetReference<ISpatialPoint>("hangar_too/c1_2"));
            ai_erase(this.ai_current_actor);
        }

        [ScriptMethod(291, Lifecycle.CommandScript)]
        public async Task hangar_fly_c2()
        {
            cs_enable_pathfinding_failsafe(true);
            await sleep_until(async () => volume_test_objects(vol_hangar_center, this.ai_current_actor) == true);
            cs_vehicle_speed(0.5F);
            cs_fly_by(GetReference<ISpatialPoint>("hangar_too/c2_0"));
            cs_fly_by(GetReference<ISpatialPoint>("hangar_too/c2_1"));
            cs_fly_to(GetReference<ISpatialPoint>("hangar_too/c2_2"));
            ai_erase(this.ai_current_actor);
        }

        [ScriptMethod(292, Lifecycle.Dormant)]
        public async Task hangar_sentinels_flitting()
        {
            await sleep_until(async () =>
            {
                begin_random(async () =>
                {
                    if ((short)ai_living_count(hangar_sentinels_flit.Squad) < 1)
                    {
                        ai_place(hangar_sentinels_flit.l1);
                        cs_run_command_script(hangar_sentinels_flit.l1, new ScriptMethodReference(hangar_fly_out_l1));
                        this.hangar_sentinel_var = true;
                        begin_random(async () =>
                        {
                            if (this.hangar_sentinel_var == true)
                            {
                                cs_queue_command_script(hangar_sentinels_flit.l1, new ScriptMethodReference(hangar_fly_l2));
                                this.hangar_sentinel_var = false;
                            }
                        }, 
                            async () =>
                        {
                            if (this.hangar_sentinel_var == true)
                            {
                                cs_queue_command_script(hangar_sentinels_flit.l1, new ScriptMethodReference(hangar_fly_r1));
                                this.hangar_sentinel_var = false;
                            }
                        }, 
                            async () =>
                        {
                            if (this.hangar_sentinel_var == true)
                            {
                                cs_queue_command_script(hangar_sentinels_flit.l1, new ScriptMethodReference(hangar_fly_r2));
                                this.hangar_sentinel_var = false;
                            }
                        });
                    }
                }, 
                    async () =>
                {
                    if ((short)ai_living_count(hangar_sentinels_flit.Squad) < 1)
                    {
                        ai_place(hangar_sentinels_flit.l2);
                        cs_run_command_script(hangar_sentinels_flit.l2, new ScriptMethodReference(hangar_fly_out_l2));
                        this.hangar_sentinel_var = true;
                        begin_random(async () =>
                        {
                            if (this.hangar_sentinel_var == true)
                            {
                                cs_queue_command_script(hangar_sentinels_flit.l2, new ScriptMethodReference(hangar_fly_l1));
                                this.hangar_sentinel_var = false;
                            }
                        }, 
                            async () =>
                        {
                            if (this.hangar_sentinel_var == true)
                            {
                                cs_queue_command_script(hangar_sentinels_flit.l2, new ScriptMethodReference(hangar_fly_r1));
                                this.hangar_sentinel_var = false;
                            }
                        }, 
                            async () =>
                        {
                            if (this.hangar_sentinel_var == true)
                            {
                                cs_queue_command_script(hangar_sentinels_flit.l2, new ScriptMethodReference(hangar_fly_r2));
                                this.hangar_sentinel_var = false;
                            }
                        });
                    }
                }, 
                    async () =>
                {
                    if ((short)ai_living_count(hangar_sentinels_flit.Squad) < 1)
                    {
                        ai_place(hangar_sentinels_flit.r1);
                        cs_run_command_script(hangar_sentinels_flit.r1, new ScriptMethodReference(hangar_fly_out_r1));
                        this.hangar_sentinel_var = true;
                        begin_random(async () =>
                        {
                            if (this.hangar_sentinel_var == true)
                            {
                                cs_queue_command_script(hangar_sentinels_flit.r1, new ScriptMethodReference(hangar_fly_l1));
                                this.hangar_sentinel_var = false;
                            }
                        }, 
                            async () =>
                        {
                            if (this.hangar_sentinel_var == true)
                            {
                                cs_queue_command_script(hangar_sentinels_flit.r1, new ScriptMethodReference(hangar_fly_l2));
                                this.hangar_sentinel_var = false;
                            }
                        }, 
                            async () =>
                        {
                            if (this.hangar_sentinel_var == true)
                            {
                                cs_queue_command_script(hangar_sentinels_flit.r1, new ScriptMethodReference(hangar_fly_r2));
                                this.hangar_sentinel_var = false;
                            }
                        });
                    }
                }, 
                    async () =>
                {
                    if ((short)ai_living_count(hangar_sentinels_flit.Squad) < 1)
                    {
                        ai_place(hangar_sentinels_flit.r2);
                        cs_run_command_script(hangar_sentinels_flit.r2, new ScriptMethodReference(hangar_fly_out_r2));
                        this.hangar_sentinel_var = true;
                        begin_random(async () =>
                        {
                            if (this.hangar_sentinel_var == true)
                            {
                                cs_queue_command_script(hangar_sentinels_flit.r2, new ScriptMethodReference(hangar_fly_l1));
                                this.hangar_sentinel_var = false;
                            }
                        }, 
                            async () =>
                        {
                            if (this.hangar_sentinel_var == true)
                            {
                                cs_queue_command_script(hangar_sentinels_flit.r2, new ScriptMethodReference(hangar_fly_l2));
                                this.hangar_sentinel_var = false;
                            }
                        }, 
                            async () =>
                        {
                            if (this.hangar_sentinel_var == true)
                            {
                                cs_queue_command_script(hangar_sentinels_flit.r2, new ScriptMethodReference(hangar_fly_r1));
                                this.hangar_sentinel_var = false;
                            }
                        });
                    }
                }, 
                    async () =>
                {
                    if ((short)ai_living_count(hangar_sentinels_flit.Squad) < 1)
                    {
                        ai_place(hangar_sentinels_flit.c1);
                        cs_run_command_script(hangar_sentinels_flit.c1, new ScriptMethodReference(hangar_fly_out_c1));
                        this.hangar_sentinel_var = true;
                        begin_random(async () =>
                        {
                            if (this.hangar_sentinel_var == true)
                            {
                                cs_queue_command_script(hangar_sentinels_flit.c1, new ScriptMethodReference(hangar_fly_l1));
                                this.hangar_sentinel_var = false;
                            }
                        }, 
                            async () =>
                        {
                            if (this.hangar_sentinel_var == true)
                            {
                                cs_queue_command_script(hangar_sentinels_flit.c1, new ScriptMethodReference(hangar_fly_r1));
                                this.hangar_sentinel_var = false;
                            }
                        });
                    }
                });
                return (short)ai_combat_status(hangar_heretics) >= this.ai_combat_status_uninspected;
            });
        }

        [ScriptMethod(293, Lifecycle.CommandScript)]
        public async Task hangar_sentinel_comment()
        {
            cs_switch("elev_elite");
            cs_abort_on_damage(true);
            cs_suppress_dialogue_global(true);
            print("spec-ops elite: 'sentinels! the holy warriors of the sacred rings!'");
            cs_aim(true, GetReference<ISpatialPoint>("hangar_too/p0"));
            cs_play_line("0360");
            await sleep(30);
            print("'why have they sided with these heretics?'");
            cs_play_line("0370");
            cs_aim(false, GetReference<ISpatialPoint>("hangar_too/p0"));
        }

        [ScriptMethod(294, Lifecycle.Dormant)]
        public async Task hangar_helpers()
        {
            ai_place(hangar_helper_01.Squad);
            cs_run_command_script(hangar_helper_01.Squad, new ScriptMethodReference(forever_pause));
            ai_place(hangar_helper_03.Squad);
            cs_run_command_script(hangar_helper_03.Squad, new ScriptMethodReference(forever_pause));
            await sleep_until(async () => volume_test_objects(vol_trigger_helpers, players()) == true);
            cs_run_command_script(hangar_helper_03.Squad, new ScriptMethodReference(hangar_help_03));
            cs_run_command_script(hangar_helper_01.Squad, new ScriptMethodReference(hangar_help_01));
            ai_place(hangar_helper_02.Squad);
            cs_run_command_script(hangar_helper_02.Squad, new ScriptMethodReference(hangar_help_02));
            cs_queue_command_script(hangar_helper_02.Squad, new ScriptMethodReference(hangar_help_03));
            await sleep(90);
            ai_scene("sentinel_react_scene", new ScriptMethodReference(hangar_sentinel_comment), arm01_allies) // Couldn't generate cast from 'Boolean' to 'Void'
            ;
            await sleep_until(async () => (short)ai_combat_status(hangar_heretics) > this.ai_combat_status_uninspected);
            unit_add_equipment(unit(list_get(ai_actors(hangar_helper_01.Squad), 0)), swap, true, true);
            unit_add_equipment(unit(list_get(ai_actors(hangar_helper_02.Squad), 0)), swap, true, true);
            unit_add_equipment(unit(list_get(ai_actors(hangar_helper_03.Squad), 0)), swap, true, true);
            objects_detach(list_get(ai_actors(hangar_helper_01.Squad), 0), help_can_01.Entity);
            objects_detach(list_get(ai_actors(hangar_helper_02.Squad), 0), help_can_02.Entity);
            cs_run_command_script(hangar_helper_01.Squad, new ScriptMethodReference(abort));
            cs_run_command_script(hangar_helper_02.Squad, new ScriptMethodReference(abort));
            cs_run_command_script(hangar_helper_03.Squad, new ScriptMethodReference(abort));
            cs_queue_command_script(hangar_sentinels_flit.Squad, new ScriptMethodReference(abort));
        }

        [ScriptMethod(295, Lifecycle.CommandScript)]
        public async Task hangar_phantom_arrives()
        {
            cs_enable_pathfinding_failsafe(true);
            cs_vehicle_speed(0.5F);
            cs_fly_by(GetReference<ISpatialPoint>("airspace_hangar/hangar_ph0"), 3F);
            cs_fly_by(GetReference<ISpatialPoint>("airspace_hangar/hangar_ph1"), 3F);
            cs_vehicle_speed(0.25F);
            cs_fly_to(GetReference<ISpatialPoint>("airspace_hangar/hangar_ph2"), 1F);
            ai_place(reinforce_elites_01.Squad, (short)max(1F, 2F - (float)ai_living_count(allies_elites)));
            ai_place(reinforce_grunts_01.Squad, (short)(2 - (float)ai_living_count(allies_grunts)));
            vehicle_load_magic(ai_vehicle_get_from_starting_location(hangar_phantom.pilot), "phantom_p", ai_actors(reinforce_elites_01.Squad));
            vehicle_load_magic(ai_vehicle_get_from_starting_location(hangar_phantom.pilot), "phantom_p", ai_actors(reinforce_grunts_01.Squad));
            await sleep(15);
            vehicle_unload(ai_vehicle_get_from_starting_location(hangar_phantom.pilot), "phantom_p_a01");
            await sleep(15);
            vehicle_unload(ai_vehicle_get_from_starting_location(hangar_phantom.pilot), "phantom_p_a02");
            await sleep(15);
            vehicle_unload(ai_vehicle_get_from_starting_location(hangar_phantom.pilot), "phantom_p_a03");
            await sleep(15);
            vehicle_unload(ai_vehicle_get_from_starting_location(hangar_phantom.pilot), "phantom_p_b01");
            await sleep(15);
            vehicle_unload(ai_vehicle_get_from_starting_location(hangar_phantom.pilot), "phantom_p_b02");
            await sleep(15);
            vehicle_unload(ai_vehicle_get_from_starting_location(hangar_phantom.pilot), "phantom_p_b03");
            await sleep(15);
            vehicle_unload(ai_vehicle_get_from_starting_location(hangar_phantom.pilot), "phantom_p_c01");
            await sleep(15);
            vehicle_unload(ai_vehicle_get_from_starting_location(hangar_phantom.pilot), "phantom_p_c02");
            await sleep(15);
            vehicle_unload(ai_vehicle_get_from_starting_location(hangar_phantom.pilot), "phantom_p_c03");
            await sleep_until(async () => (short)ai_living_count(hangar_phantom.Squad) < 2, 30, 900);
            this.hangar_phantom_cue = true;
            await sleep_until(async () => this.heavies_spawned > 0);
            await sleep_until(async () => (short)ai_combat_status(hangar_heretic_heavies_L.Squad) >= this.ai_combat_status_clear_los || (short)ai_combat_status(hangar_heretic_heavies_R.Squad) >= this.ai_combat_status_clear_los, 30, 300);
            wake(new ScriptMethodReference(music_04a_01_stop));
            cs_fly_to_and_face(GetReference<ISpatialPoint>("airspace_hangar/hangar_ph1"), GetReference<ISpatialPoint>("airspace_hangar/hangar_ph2"), 2F);
            cs_vehicle_speed(1F);
            cs_fly_by(GetReference<ISpatialPoint>("airspace_hangar/hangar_ph0"), 5F);
            cs_fly_to(GetReference<ISpatialPoint>("airspace_hangar/hangar_phx"), 5F);
            ai_erase(hangar_phantom.Squad);
        }

        [ScriptMethod(296, Lifecycle.Dormant)]
        public async Task hangar_allies_reinforce()
        {
            await sleep_until(async () =>
            {
                if (objects_distance_to_object(players(), list_get(ai_actors(all_allies), 3)) > 50F && objects_can_see_object(players(), list_get(ai_actors(all_allies), 3), 45F) == false)
                {
                    object_destroy(list_get(ai_actors(all_allies), 3));
                }

                if (objects_distance_to_object(players(), list_get(ai_actors(all_allies), 2)) > 50F && objects_can_see_object(players(), list_get(ai_actors(all_allies), 2), 45F) == false)
                {
                    object_destroy(list_get(ai_actors(all_allies), 2));
                }

                if (objects_distance_to_object(players(), list_get(ai_actors(all_allies), 1)) > 50F && objects_can_see_object(players(), list_get(ai_actors(all_allies), 1), 45F) == false)
                {
                    object_destroy(list_get(ai_actors(all_allies), 1));
                }

                if (objects_distance_to_object(players(), list_get(ai_actors(all_allies), 0)) > 50F && objects_can_see_object(players(), list_get(ai_actors(all_allies), 0), 45F) == false)
                {
                    object_destroy(list_get(ai_actors(all_allies), 0));
                }

                return false;
            }, 30, 150);
            ai_place(hangar_phantom.Squad);
            cs_run_command_script(hangar_phantom.Squad, new ScriptMethodReference(hangar_phantom_arrives));
            await sleep(60);
            await sleep_until(async () => (short)ai_living_count(hangar_phantom.Squad) > 1);
            await sleep_until(async () => (short)ai_living_count(hangar_phantom.Squad) < 2);
            ai_set_orders(reinforce_elites_01.Squad, allies_hangar_bottom);
            ai_set_orders(reinforce_grunts_01.Squad, allies_hangar_bottom);
        }

        [ScriptMethod(297, Lifecycle.Static)]
        public async Task short_hangar_allies()
        {
            await sleep_until(async () =>
            {
                if (objects_distance_to_object(players(), list_get(ai_actors(all_allies), 2)) > 50F && objects_can_see_object(players(), list_get(ai_actors(all_allies), 2), 45F) == false)
                {
                    object_destroy(list_get(ai_actors(all_allies), 2));
                }

                if (objects_distance_to_object(players(), list_get(ai_actors(all_allies), 1)) > 50F && objects_can_see_object(players(), list_get(ai_actors(all_allies), 1), 45F) == false)
                {
                    object_destroy(list_get(ai_actors(all_allies), 1));
                }

                if (objects_distance_to_object(players(), list_get(ai_actors(all_allies), 0)) > 50F && objects_can_see_object(players(), list_get(ai_actors(all_allies), 0), 45F) == false)
                {
                    object_destroy(list_get(ai_actors(all_allies), 0));
                }

                return false;
            }, 30, 150);
            ai_place(hangar_phantom.Squad);
            cs_run_command_script(hangar_phantom.Squad, new ScriptMethodReference(hangar_phantom_arrives));
            await sleep(60);
            ai_place(reinforce_elites_01.Squad, (short)(2 - (float)ai_living_count(allies_elites)));
            ai_place(reinforce_grunts_01.Squad, (short)(2 - (float)ai_living_count(allies_grunts)));
            vehicle_load_magic(ai_vehicle_get_from_starting_location(hangar_phantom.pilot), "phantom_p", ai_actors(reinforce_elites_01.Squad));
            vehicle_load_magic(ai_vehicle_get_from_starting_location(hangar_phantom.pilot), "phantom_p", ai_actors(reinforce_grunts_01.Squad));
            await sleep_until(async () => (short)ai_living_count(hangar_phantom.Squad) < 2);
            ai_set_orders(reinforce_elites_01.Squad, allies_hangar_bottom);
            ai_set_orders(reinforce_grunts_01.Squad, allies_hangar_bottom);
        }

        [ScriptMethod(298, Lifecycle.Dormant)]
        public async Task hangar_door_monitor()
        {
            await sleep_until(async () => device_get_position(hangar_door_cinematic.Entity) > 0F);
            wake(new ScriptMethodReference(hangar_allies_reinforce));
            ai_dialogue_enable(false);
            await sleep(60);
            print("phantom pilot: 'hold position! i am making my approach!'");
            await sleep(ai_play_line_on_object(default(IGameObject), "2030"));
            await sleep(30);
            ai_dialogue_enable(true);
        }

        [ScriptMethod(299, Lifecycle.Dormant)]
        public async Task hangar_objective()
        {
            ai_dialogue_enable(false);
            await sleep(60);
            print("phantom pilot: 'arbiter! clear the hangar, and open its door so i may drop the second lance!'");
            await sleep(ai_play_line_on_object(default(IGameObject), "2000"));
            await sleep(30);
            ai_dialogue_enable(true);
        }

        [ScriptMethod(300, Lifecycle.Dormant)]
        public async Task hangar_door_reminder()
        {
            await sleep_until(async () => device_get_position(hangar_door_cinematic.Entity) > 0F, 30, 4000);
            if (device_get_position(hangar_door_cinematic.Entity) <= 0F)
            {
                ai_dialogue_enable(false);
                await sleep(60);
                print("phantom pilot: 'find the controls to the hangar-doors, arbiter!'");
                await sleep(ai_play_line_on_object(default(IGameObject), "2010"));
                await sleep(30);
                ai_dialogue_enable(true);
            }

            await sleep_until(async () => device_get_position(hangar_door_cinematic.Entity) > 0F, 30, 2000);
            if (device_get_position(hangar_door_cinematic.Entity) <= 0F)
            {
                ai_dialogue_enable(false);
                await sleep(60);
                print("phantom pilot: 'the hangar-doors, arbiter! open them, and i will land your reinforcements!'");
                await sleep(ai_play_line_on_object(default(IGameObject), "2020"));
                await sleep(30);
                ai_dialogue_enable(true);
                if (volume_test_objects(vol_hangar_left, players()) == true)
                {
                    activate_team_nav_point_object(_default, player, hangar_door_switch_l.Entity, 0F);
                    await sleep_until(async () => device_get_position(hangar_door_cinematic.Entity) > 0F);
                    deactivate_team_nav_point_object(player, hangar_door_switch_l.Entity);
                }
                else
                {
                    activate_team_nav_point_object(_default, player, hangar_door_switch_r.Entity, 0F);
                    await sleep_until(async () => device_get_position(hangar_door_cinematic.Entity) > 0F);
                    deactivate_team_nav_point_object(player, hangar_door_switch_r.Entity);
                }
            }
        }

        [ScriptMethod(301, Lifecycle.CommandScript)]
        public async Task hangar_sentinel_call()
        {
            cs_switch("heretic");
            cs_suppress_dialogue_global(true);
            print("heretic: 'sentinels! defend us!'");
            cs_play_line("0380");
        }

        [ScriptMethod(302, Lifecycle.Dormant)]
        public async Task hangar_alerted_call()
        {
            await sleep_until(async () => (short)ai_combat_status(hangar_heretics) > this.ai_combat_status_uninspected);
            ai_scene("hangar_s_call_scene", new ScriptMethodReference(hangar_sentinel_call), hangar_heretics) // Couldn't generate cast from 'Boolean' to 'Void'
            ;
        }

        [ScriptMethod(303, Lifecycle.Static)]
        public async Task sentinel_swarm_spawning()
        {
            this.hangar_sentinels_come = true;
            await sleep_until(async () =>
            {
                if ((short)ai_living_count(hangar_sentinels) < 3)
                {
                    ai_place(hangar_sentinel_swarm.Squad, 1);
                }

                await sleep((short)random_range(10, 30));
                return (short)ai_spawn_count(hangar_sentinel_swarm.Squad) > 4;
            });
        }

        [ScriptMethod(304, Lifecycle.Static)]
        public async Task heretic_heavy_spawning()
        {
            begin_random(async () =>
            {
                if (volume_test_objects(vol_hangar_spawn_02r, players()) == false && await this.player_count() > 0 && device_get_position(hang_02r.Entity) == 0F && this.heavies_spawned < 3)
                {
                    print("heavy_02r_a");
                    ai_place(hangar_heretic_heavies_R._02a);
                    cs_run_command_script(hangar_heretic_heavies_R.Squad, new ScriptMethodReference(snap_alert));
                    this.heavies_spawned = (short)(this.heavies_spawned + 1);
                }
            }, 
                async () =>
            {
                if (volume_test_objects(vol_hangar_spawn_02r, players()) == false && await this.player_count() > 0 && device_get_position(hang_02r.Entity) == 0F && this.heavies_spawned < 3)
                {
                    print("heavy_02r_b");
                    ai_place(hangar_heretic_heavies_R._02b);
                    cs_run_command_script(hangar_heretic_heavies_R.Squad, new ScriptMethodReference(snap_alert));
                    this.heavies_spawned = (short)(this.heavies_spawned + 1);
                }
            }, 
                async () =>
            {
                if (volume_test_objects(vol_hangar_spawn_03r, players()) == false && await this.player_count() > 0 && device_get_position(hang_03r.Entity) == 0F && this.heavies_spawned < 3)
                {
                    print("heavy_03r_a");
                    ai_place(hangar_heretic_heavies_R._03a);
                    cs_run_command_script(hangar_heretic_heavies_R.Squad, new ScriptMethodReference(snap_alert));
                    this.heavies_spawned = (short)(this.heavies_spawned + 1);
                }
            }, 
                async () =>
            {
                if (volume_test_objects(vol_hangar_spawn_03r, players()) == false && await this.player_count() > 0 && device_get_position(hang_03r.Entity) == 0F && this.heavies_spawned < 3)
                {
                    print("heavy_03r_b");
                    ai_place(hangar_heretic_heavies_R._03b);
                    cs_run_command_script(hangar_heretic_heavies_R.Squad, new ScriptMethodReference(snap_alert));
                    this.heavies_spawned = (short)(this.heavies_spawned + 1);
                }
            }, 
                async () =>
            {
                if (volume_test_objects(vol_hangar_spawn_02l, players()) == false && await this.player_count() > 0 && device_get_position(hang_02l.Entity) == 0F && this.heavies_spawned < 3)
                {
                    print("heavy_02l_a");
                    ai_place(hangar_heretic_heavies_L._02a);
                    cs_run_command_script(hangar_heretic_heavies_L.Squad, new ScriptMethodReference(snap_alert));
                    this.heavies_spawned = (short)(this.heavies_spawned + 1);
                }
            }, 
                async () =>
            {
                if (volume_test_objects(vol_hangar_spawn_02l, players()) == false && await this.player_count() > 0 && device_get_position(hang_02l.Entity) == 0F && this.heavies_spawned < 3)
                {
                    print("heavy_02l_b");
                    ai_place(hangar_heretic_heavies_L._02b);
                    cs_run_command_script(hangar_heretic_heavies_L.Squad, new ScriptMethodReference(snap_alert));
                    this.heavies_spawned = (short)(this.heavies_spawned + 1);
                }
            }, 
                async () =>
            {
                if (volume_test_objects(vol_hangar_spawn_03l, players()) == false && await this.player_count() > 0 && device_get_position(hang_03l.Entity) == 0F && this.heavies_spawned < 3)
                {
                    print("heavy_03l_a");
                    ai_place(hangar_heretic_heavies_L._03a);
                    cs_run_command_script(hangar_heretic_heavies_L.Squad, new ScriptMethodReference(snap_alert));
                    this.heavies_spawned = (short)(this.heavies_spawned + 1);
                }
            }, 
                async () =>
            {
                if (volume_test_objects(vol_hangar_spawn_03l, players()) == false && await this.player_count() > 0 && device_get_position(hang_03l.Entity) == 0F && this.heavies_spawned < 3)
                {
                    print("heavy_03l_b");
                    ai_place(hangar_heretic_heavies_L._03b);
                    cs_run_command_script(hangar_heretic_heavies_L.Squad, new ScriptMethodReference(snap_alert));
                    this.heavies_spawned = (short)(this.heavies_spawned + 1);
                }
            });
        }

        [ScriptMethod(305, Lifecycle.Static)]
        public async Task hangar_a50_clone()
        {
            begin_random(async () =>
            {
                if (volume_test_objects(vol_hangar_spawn_02r, players()) == false && await this.player_count() > 0 && device_get_position(hang_02r.Entity) == 0F)
                {
                    ai_place(hangar_a50_02r_high.Squad, (short)((float)random_range(0, 3) - (float)ai_living_count(a50_high)));
                    cs_run_command_script(hangar_a50_02r_high.Squad, new ScriptMethodReference(snap_alert));
                }
            }, 
                async () =>
            {
                if (volume_test_objects(vol_hangar_spawn_02r, players()) == false && await this.player_count() > 0 && device_get_position(hang_02r.Entity) == 0F)
                {
                    ai_place(hangar_a50_02r_low.Squad, (short)((float)random_range(0, 3) - (float)ai_living_count(a50_low)));
                    cs_run_command_script(hangar_a50_02r_low.Squad, new ScriptMethodReference(snap_alert));
                }
            }, 
                async () =>
            {
                if (volume_test_objects(vol_hangar_spawn_03r, players()) == false && await this.player_count() > 0 && device_get_position(hang_03r.Entity) == 0F)
                {
                    ai_place(hangar_a50_03r_high.Squad, (short)((float)random_range(0, 3) - (float)ai_living_count(a50_high)));
                    cs_run_command_script(hangar_a50_03r_high.Squad, new ScriptMethodReference(snap_alert));
                }
            }, 
                async () =>
            {
                if (volume_test_objects(vol_hangar_spawn_03r, players()) == false && await this.player_count() > 0 && device_get_position(hang_03r.Entity) == 0F)
                {
                    ai_place(hangar_a50_03r_low.Squad, (short)((float)random_range(0, 3) - (float)ai_living_count(a50_low)));
                    cs_run_command_script(hangar_a50_03r_low.Squad, new ScriptMethodReference(snap_alert));
                }
            }, 
                async () =>
            {
                if (volume_test_objects(vol_hangar_spawn_02l, players()) == false && await this.player_count() > 0 && device_get_position(hang_02l.Entity) == 0F)
                {
                    ai_place(hangar_a50_02l_high.Squad, (short)((float)random_range(0, 3) - (float)ai_living_count(a50_high)));
                    cs_run_command_script(hangar_a50_02l_high.Squad, new ScriptMethodReference(snap_alert));
                }
            }, 
                async () =>
            {
                if (volume_test_objects(vol_hangar_spawn_02l, players()) == false && await this.player_count() > 0 && device_get_position(hang_02l.Entity) == 0F)
                {
                    ai_place(hangar_a50_02l_low.Squad, (short)((float)random_range(0, 3) - (float)ai_living_count(a50_low)));
                    cs_run_command_script(hangar_a50_02l_low.Squad, new ScriptMethodReference(snap_alert));
                }
            }, 
                async () =>
            {
                if (volume_test_objects(vol_hangar_spawn_03l, players()) == false && await this.player_count() > 0 && device_get_position(hang_03l.Entity) == 0F)
                {
                    ai_place(hangar_a50_03l_high.Squad, (short)((float)random_range(0, 3) - (float)ai_living_count(a50_high)));
                    cs_run_command_script(hangar_a50_03l_high.Squad, new ScriptMethodReference(snap_alert));
                }
            }, 
                async () =>
            {
                if (volume_test_objects(vol_hangar_spawn_03l, players()) == false && await this.player_count() > 0 && device_get_position(hang_03l.Entity) == 0F)
                {
                    ai_place(hangar_a50_03l_low.Squad, (short)((float)random_range(0, 3) - (float)ai_living_count(a50_low)));
                    cs_run_command_script(hangar_a50_03l_low.Squad, new ScriptMethodReference(snap_alert));
                }
            });
            await sleep_until(async () => (short)ai_living_count(hangar_heretics) < 3, 30, 8000);
            await sleep_until(async () => (short)ai_living_count(hangar_heretics) < 1, 30, 1800);
            await sleep(150);
            game_save();
            begin_random(async () =>
            {
                if (volume_test_objects(vol_hangar_spawn_02r, players()) == false && await this.player_count() > 0 && device_get_position(hang_02r.Entity) == 0F)
                {
                    ai_place(hangar_a50_02r_high.Squad, (short)((float)random_range(0, 2) - (float)ai_living_count(a50_high)));
                    cs_run_command_script(hangar_a50_02r_high.Squad, new ScriptMethodReference(snap_alert));
                }
            }, 
                async () =>
            {
                if (volume_test_objects(vol_hangar_spawn_02r, players()) == false && await this.player_count() > 0 && device_get_position(hang_02r.Entity) == 0F)
                {
                    ai_place(hangar_a50_02r_low.Squad, (short)((float)random_range(0, 4) - (float)ai_living_count(a50_low)));
                    cs_run_command_script(hangar_a50_02r_low.Squad, new ScriptMethodReference(snap_alert));
                }
            }, 
                async () =>
            {
                if (volume_test_objects(vol_hangar_spawn_01r, players()) == false && await this.player_count() > 0 && device_get_position(hang_01r.Entity) == 0F)
                {
                    ai_place(hangar_a50_01r_high.Squad, (short)((float)random_range(0, 2) - (float)ai_living_count(a50_high)));
                    cs_run_command_script(hangar_a50_01r_high.Squad, new ScriptMethodReference(snap_alert));
                }
            }, 
                async () =>
            {
                if (volume_test_objects(vol_hangar_spawn_01r, players()) == false && await this.player_count() > 0 && device_get_position(hang_01r.Entity) == 0F)
                {
                    ai_place(hangar_a50_01r_low.Squad, (short)((float)random_range(0, 4) - (float)ai_living_count(a50_low)));
                    cs_run_command_script(hangar_a50_01r_low.Squad, new ScriptMethodReference(snap_alert));
                }
            }, 
                async () =>
            {
                if (volume_test_objects(vol_hangar_spawn_02l, players()) == false && await this.player_count() > 0 && device_get_position(hang_02l.Entity) == 0F)
                {
                    ai_place(hangar_a50_02l_high.Squad, (short)((float)random_range(0, 2) - (float)ai_living_count(a50_high)));
                    cs_run_command_script(hangar_a50_02l_high.Squad, new ScriptMethodReference(snap_alert));
                }
            }, 
                async () =>
            {
                if (volume_test_objects(vol_hangar_spawn_02l, players()) == false && await this.player_count() > 0 && device_get_position(hang_02l.Entity) == 0F)
                {
                    ai_place(hangar_a50_02l_low.Squad, (short)((float)random_range(0, 4) - (float)ai_living_count(a50_low)));
                    cs_run_command_script(hangar_a50_02l_low.Squad, new ScriptMethodReference(snap_alert));
                }
            }, 
                async () =>
            {
                if (volume_test_objects(vol_hangar_spawn_01l, players()) == false && await this.player_count() > 0 && device_get_position(hang_01l.Entity) == 0F)
                {
                    ai_place(hangar_a50_01l_high.Squad, (short)((float)random_range(0, 2) - (float)ai_living_count(a50_high)));
                    cs_run_command_script(hangar_a50_01l_high.Squad, new ScriptMethodReference(snap_alert));
                }
            }, 
                async () =>
            {
                if (volume_test_objects(vol_hangar_spawn_01l, players()) == false && await this.player_count() > 0 && device_get_position(hang_01l.Entity) == 0F)
                {
                    ai_place(hangar_a50_01l_low.Squad, (short)((float)random_range(0, 4) - (float)ai_living_count(a50_low)));
                    cs_run_command_script(hangar_a50_01l_low.Squad, new ScriptMethodReference(snap_alert));
                }
            });
        }

        [ScriptMethod(306, Lifecycle.CommandScript)]
        public async Task hangar_exit_comment()
        {
            cs_switch("ally");
            cs_abort_on_damage(true);
            cs_suppress_dialogue_global(true);
            print("spec-ops elite: 'more heretics!  in the passage below us!'");
            cs_play_line("1140");
        }

        [ScriptMethod(307, Lifecycle.Dormant)]
        public async Task hangar_exit_warn()
        {
            await sleep_until(async () => volume_test_objects(vol_hangar_center_exit, players()) == true, 30, 300);
            if (volume_test_objects(vol_hangar_center_exit, players()) == false && await this.player_count() > 0)
            {
                ai_scene("hangar_exit_scene", new ScriptMethodReference(hangar_exit_comment), all_allies) // Couldn't generate cast from 'Boolean' to 'Void'
                ;
            }
        }

        [ScriptMethod(308, Lifecycle.Dormant)]
        public async Task hangar_reminder()
        {
            await sleep_until(async () => volume_test_objects(vol_leaving_hangar, players()) == true, 30, 3600);
            if (volume_test_objects(vol_leaving_hangar, players()) == false && await this.player_count() > 0)
            {
                ai_dialogue_enable(false);
                await sleep(60);
                print("spec-ops commander: 'keep heading down. find the leader of these heretics!'");
                await sleep(ai_play_line_on_object(default(IGameObject), "1150"));
                await sleep(30);
                ai_dialogue_enable(true);
            }

            await sleep_until(async () => volume_test_objects(vol_leaving_hangar, players()) == true, 30, 1800);
            if (volume_test_objects(vol_leaving_hangar, players()) == false && await this.player_count() > 0)
            {
                activate_team_nav_point_object(_default, player, hangar_exit.Entity, 0F);
                await sleep_until(async () => volume_test_objects(vol_leaving_hangar, players()) == true);
                deactivate_team_nav_point_object(player, hangar_exit.Entity);
            }
        }

        [ScriptMethod(309, Lifecycle.Dormant)]
        public async Task hangar_exterior_toggle()
        {
            object_create(alpha_gas_exterior);
            await sleep_until(async () =>
            {
                await sleep_until(async () => volume_test_objects(vol_first_hall_01, players()) == true);
                object_destroy(alpha_gas_exterior.Entity);
                await sleep_until(async () => volume_test_objects(vol_leaving_hangar, players()) == true);
                object_create(alpha_gas_exterior);
                return false;
            });
        }

        [ScriptMethod(310, Lifecycle.CommandScript)]
        public async Task deploy_hangar_right()
        {
            cs_force_combat_status(4);
            cs_enable_pathfinding_failsafe(true);
            cs_go_to(GetReference<ISpatialPoint>("hangar_turrets/deploy_r"));
            cs_deploy_turret(GetReference<ISpatialPoint>("hangar_turrets/right"));
            cs_enable_targeting(true);
            cs_shoot(true);
            cs_set_behavior(guard);
            sleep_forever();
        }

        [ScriptMethod(311, Lifecycle.CommandScript)]
        public async Task deploy_hangar_left()
        {
            cs_force_combat_status(4);
            cs_enable_pathfinding_failsafe(true);
            cs_go_to(GetReference<ISpatialPoint>("hangar_turrets/deploy_l"));
            cs_deploy_turret(GetReference<ISpatialPoint>("hangar_turrets/left"));
            cs_enable_targeting(true);
            cs_shoot(true);
            cs_set_behavior(guard);
            sleep_forever();
        }

        [ScriptMethod(312, Lifecycle.Static)]
        public async Task test_ass()
        {
            device_operates_automatically_set(hangar_exit.Entity, true);
            ai_place(hangar_heretic_06R.Squad, (short)random_range(0, 2));
            ai_place(hangar_heretic_06L.Squad, (short)(1 - (float)ai_living_count(hangar_heretic_06R.Squad)));
            ai_place(hangar_grunts_04R.Squad, 1);
            ai_place(hangar_grunts_04L.Squad, 1);
            cs_run_command_script(hangar_heretics, new ScriptMethodReference(snap_alert));
            cs_queue_command_script(hangar_grunts_04R.Squad, new ScriptMethodReference(deploy_hangar_right));
            cs_queue_command_script(hangar_grunts_04L.Squad, new ScriptMethodReference(deploy_hangar_left));
        }

        [ScriptMethod(313, Lifecycle.Dormant)]
        public async Task hangar_firsttime_start()
        {
            data_mine_set_mission_segment("04a_3_hangar");
            object_create_containing("hang_can_");
            wake(new ScriptMethodReference(hangar_helpers));
            wake(new ScriptMethodReference(hangar_can_spawner));
            wake(new ScriptMethodReference(hangar_killer_new));
            wake(new ScriptMethodReference(hangar_sentinels_flitting));
            wake(new ScriptMethodReference(hangar_door_monitor));
            this.hangar_power_on = true;
            ai_renew(all_allies);
            ai_place(hangar_heretic_01R.Squad, (short)random_range(0, 2));
            ai_place(hangar_heretic_01L.Squad, (short)(1 - (float)ai_living_count(hangar_heretic_01R.Squad)));
            ai_place(hangar_heretic_02L.Squad, (short)random_range(0, 2));
            ai_place(hangar_heretic_02R.Squad, (short)(1 - (float)ai_living_count(hangar_heretic_02L.Squad)));
            ai_place(hangar_grunts_01R.Squad, (short)random_range(1, 3));
            ai_place(hangar_grunts_01L.Squad, (short)(2 - (float)ai_living_count(hangar_grunts_01R.Squad)));
            await sleep_until(async () => device_get_position(elev_hangar.Entity) > 0.1F);
            wake(new ScriptMethodReference(music_04a_01_start));
            cs_run_command_script(all_allies, new ScriptMethodReference(abort));
            wake(new ScriptMethodReference(hangar_extra_save));
            await sleep_until(async () => device_get_position(elev_hangar.Entity) > 0.6F);
            this.stealth_talk_gone = true;
            ai_set_orders(arm01_allies, ride_hangar_elev);
            wake(new ScriptMethodReference(hangar_alerted_call));
            await sleep_until(async () => volume_test_objects(vol_hangar_mid_left, players()) == true || volume_test_objects(vol_hangar_mid_right, players()) == true || volume_test_objects(vol_hangar_end_left, players()) == true || volume_test_objects(vol_hangar_end_right, players()) == true || (short)ai_living_count(hangar_heretics) < 3);
            game_save();
            wake(new ScriptMethodReference(hangar_objective));
            wake(new ScriptMethodReference(hangar_door_reminder));
            if (volume_test_objects(vol_hangar_left, players()) == true)
            {
                ai_place(hangar_rein_her_02L.Squad, (short)(3 - (float)ai_living_count(hangar_grunts_01L.Squad)));
            }

            if (volume_test_objects(vol_hangar_right, players()) == true)
            {
                ai_place(hangar_rein_her_02R.Squad, (short)(3 - (float)ai_living_count(hangar_grunts_01R.Squad)));
            }

            await sleep_until(async () => volume_test_objects(vol_hangar_end_left, players()) == true || volume_test_objects(vol_hangar_end_right, players()) == true || (short)ai_living_count(hangar_heretics) < 3);
            game_save();
            if (volume_test_objects(vol_hangar_left, players()) == true)
            {
                ai_place(hangar_rein_her_03L.Squad, (short)(2 - (float)ai_living_count(hangar_heretic_01L.Squad) + (float)ai_living_count(hangar_heretic_01R.Squad) + (float)ai_living_count(hangar_heretic_02R.Squad) + (float)ai_living_count(hangar_heretic_02L.Squad)));
            }

            if (volume_test_objects(vol_hangar_right, players()) == true)
            {
                ai_place(hangar_rein_her_03R.Squad, (short)(2 - (float)ai_living_count(hangar_heretic_01L.Squad) + (float)ai_living_count(hangar_heretic_01R.Squad) + (float)ai_living_count(hangar_heretic_02R.Squad) + (float)ai_living_count(hangar_heretic_02L.Squad)));
            }

            ai_set_orders(hangar_heretics_init, defend_switch);
            await sleep_until(async () => device_get_position(hangar_door_cinematic.Entity) > 0F);
            wake(new ScriptMethodReference(hangar_exterior_toggle));
            game_save();
            await this.sentinel_swarm_spawning();
            await sleep_until(async () => (short)ai_living_count(hangar_sentinel_swarm.Squad) < 3, 30, 8000);
            await sleep_until(async () => (short)ai_living_count(hangar_sentinel_swarm.Squad) < 1, 30, 900);
            await sleep(150);
            game_save();
            await this.heretic_heavy_spawning();
            await sleep_until(async () => (short)ai_living_count(hangar_heretics) < 3, 30, 8000);
            await sleep_until(async () => (short)ai_living_count(hangar_heretics) < 1, 30, 900);
            await sleep(150);
            game_save();
            ai_place(hangar_a50_02r_high.Squad, (short)((float)random_range(0, 3) - (float)ai_living_count(a50_high)));
            cs_run_command_script(hangar_a50_02r_high.Squad, new ScriptMethodReference(snap_alert));
            ai_place(hangar_a50_02l_high.Squad, (short)(2 - (float)ai_living_count(a50_high)));
            cs_run_command_script(hangar_a50_02l_high.Squad, new ScriptMethodReference(snap_alert));
            ai_place(hangar_a50_02r_low.Squad, (short)((float)random_range(0, 3) - (float)ai_living_count(a50_low)));
            cs_run_command_script(hangar_a50_02r_low.Squad, new ScriptMethodReference(snap_alert));
            ai_place(hangar_a50_02l_low.Squad, (short)(2 - (float)ai_living_count(a50_low)));
            cs_run_command_script(hangar_a50_02l_low.Squad, new ScriptMethodReference(snap_alert));
            await sleep_until(async () => (short)ai_living_count(hangar_heretics) < 3 || volume_test_objects(vol_hangar_center_exit, players()) == true, 30, 3600);
            game_save();
            if (volume_test_objects(vol_hangar_center_exit, players()) == false && await this.player_count() > 0)
            {
                ai_place(hangar_a50_01r_high.Squad, (short)((float)random_range(0, 3) - (float)ai_living_count(a50_high)));
                cs_run_command_script(hangar_a50_01r_high.Squad, new ScriptMethodReference(snap_alert));
                ai_place(hangar_a50_01l_high.Squad, (short)(2 - (float)ai_living_count(a50_high)));
                cs_run_command_script(hangar_a50_01l_high.Squad, new ScriptMethodReference(snap_alert));
                ai_place(hangar_a50_01r_low.Squad, (short)((float)random_range(0, 3) - (float)ai_living_count(a50_low)));
                cs_run_command_script(hangar_a50_01r_low.Squad, new ScriptMethodReference(snap_alert));
                ai_place(hangar_a50_01l_low.Squad, (short)(2 - (float)ai_living_count(a50_low)));
                cs_run_command_script(hangar_a50_01l_low.Squad, new ScriptMethodReference(snap_alert));
            }

            await sleep_until(async () => (short)ai_living_count(hangar_heretics) < 3 || volume_test_objects(vol_hangar_center_exit, players()) == true, 30, 3600);
            game_save();
            device_operates_automatically_set(hangar_exit.Entity, true);
            ai_place(hangar_heretic_06R.Squad, (short)random_range(0, 2));
            ai_place(hangar_heretic_06L.Squad, (short)(1 - (float)ai_living_count(hangar_heretic_06R.Squad)));
            ai_place(hangar_grunts_04R.Squad, 1);
            ai_place(hangar_grunts_04L.Squad, 1);
            cs_run_command_script(hangar_heretics, new ScriptMethodReference(snap_alert));
            cs_queue_command_script(hangar_grunts_04R.Squad, new ScriptMethodReference(deploy_hangar_right));
            cs_queue_command_script(hangar_grunts_04L.Squad, new ScriptMethodReference(deploy_hangar_left));
            wake(new ScriptMethodReference(hangar_exit_warn));
            wake(new ScriptMethodReference(hangar_reminder));
            await sleep_until(async () => volume_test_objects(vol_leaving_hangar, players()) == true, 30, 300);
            ai_place(hangar_heretic_06C.Squad, 1);
            cs_run_command_script(hangar_heretic_06C.Squad, new ScriptMethodReference(snap_alert));
            await sleep_until(async () => (short)ai_living_count(hangar_heretics) < 1);
            game_save();
        }

        [ScriptMethod(314, Lifecycle.Dormant)]
        public async Task first_hall_reinforce()
        {
            await sleep_until(async () => (short)ai_combat_status(first_hall_heretics) > this.ai_combat_status_idle && (short)ai_living_count(first_hall_heretic_01.Squad) < 1 || (short)ai_living_count(first_hall_heretic_02.Squad) < 1);
            ai_place(first_hall_heretic_03.Squad, 2);
            cs_run_command_script(first_hall_heretic_03.Squad, new ScriptMethodReference(snap_alert));
        }

        [ScriptMethod(315, Lifecycle.Dormant)]
        public async Task to_underhangar_firsttime()
        {
            await sleep_until(async () => volume_test_objects(vol_hangar_reenter, players()) == true);
            data_mine_set_mission_segment("04a_4_first_halls");
            game_save();
            ai_renew(all_allies);
            ai_migrate(hangar_heretics, chasers.Squad);
            ai_set_orders(chasers.Squad, chase01);
            ai_place(first_hall_heretic_01.Squad, 1);
            ai_place(first_hall_grunts_01.Squad, 2);
            ai_place(first_hall_heretic_02.Squad, 1);
            await sleep_until(async () => volume_test_objects(vol_hangar_reenter, players()) == true);
            wake(new ScriptMethodReference(first_hall_reinforce));
            this.stealth_talk_gone = true;
            ai_set_orders(arm01_allies, allies_first_hall);
            await sleep_until(async () => (short)ai_living_count(first_hall_heretics) < 1);
            game_save();
        }

        [ScriptMethod(316, Lifecycle.Dormant)]
        public async Task underhangar_can_spawner()
        {
            await sleep_until(async () => this.underhangar_power_on == true);
            await sleep_until(async () =>
            {
                begin_random(async () =>
                {
                    if (list_count(volume_return_objects_by_type(vol_underhangar_can_all, 2048)) < 15)
                    {
                        object_create_clone(underhangar_can_a);
                    }
                }, 
                    async () => await sleep(this.recycling_time), 
                    async () =>
                {
                    if (list_count(volume_return_objects_by_type(vol_underhangar_can_all, 2048)) < 15)
                    {
                        object_create_clone(underhangar_can_b);
                    }
                }, 
                    async () => await sleep(this.recycling_time));
                return this.underhangar_power_on == false;
            });
        }

        [ScriptMethod(317, Lifecycle.Dormant)]
        public async Task underhangar_killer_new()
        {
            await sleep_until(async () => this.underhangar_power_on == true);
            await sleep_until(async () =>
            {
                object_destroy(list_get(volume_return_objects(kill_underhangar_pit_01), 0));
                await sleep(45);
                unit_kill_silent(unit(list_get(volume_return_objects_by_type(kill_underhangar_pit_01, 1), 0)));
                await sleep(45);
                object_destroy(list_get(volume_return_objects(kill_underhangar_pit_02), 0));
                await sleep(45);
                unit_kill_silent(unit(list_get(volume_return_objects_by_type(kill_underhangar_pit_02, 1), 0)));
                await sleep(45);
                return this.underhangar_power_on == false;
            });
        }

        [ScriptMethod(318, Lifecycle.Dormant)]
        public async Task new_allies_02()
        {
            if (volume_test_objects(vol_hangar_can_all, players()) == false && await this.player_count() > 0)
            {
                await sleep_until(async () =>
                {
                    object_destroy(list_get(volume_return_objects_by_type(vol_hangar_can_all, 1), 0));
                    return list_count(volume_return_objects_by_type(vol_hangar_can_all, 1)) == 0;
                }, 10);
            }

            if (volume_test_objects(vol_underhangar_reinforce, players()) == false && await this.player_count() > 0 && (short)ai_living_count(arm01_allies) < 3)
            {
                ai_place(reinforce_elites_02.Squad, (short)(1 - (float)ai_living_count(allies_elites)));
                ai_place(reinforce_grunts_02.Squad, (short)(1 - (float)ai_living_count(allies_grunts)));
            }
        }

        [ScriptMethod(319, Lifecycle.Dormant)]
        public async Task underhangar_reinforce()
        {
            await sleep_until(async () => (short)ai_combat_status(underhangar_heretics) > this.ai_combat_status_idle);
            if (volume_test_objects(vol_underhangar_halfway, players()) == false && volume_test_objects(vol_underhangar_end, players()) == false && await this.player_count() > 0)
            {
                if ((short)ai_living_count(underhangar_heretics) < 8)
                {
                    ai_place(underhangar_rein_her_01.Squad, 2);
                }

                cs_run_command_script(underhangar_rein_her_01.Squad, new ScriptMethodReference(snap_alert));
            }

            await sleep_until(async () => volume_test_objects(vol_underhangar_halfway, players()) == true || volume_test_objects(vol_underhangar_end, players()) == true);
            if (volume_test_objects(vol_underhangar_end, players()) == false && await this.player_count() > 0)
            {
                if ((short)ai_living_count(underhangar_heretics) < 8)
                {
                    ai_place(underhangar_rein_her_02.Squad, 2);
                }

                cs_run_command_script(underhangar_rein_her_02.Squad, new ScriptMethodReference(snap_alert));
            }

            await sleep_until(async () => volume_test_objects(vol_underhangar_end, players()) == true);
            if ((short)ai_living_count(underhangar_heretics) < 8)
            {
                ai_place(underhangar_grunts_03.Squad, 4);
            }

            cs_run_command_script(underhangar_grunts_03.Squad, new ScriptMethodReference(snap_alert));
        }

        [ScriptMethod(320, Lifecycle.CommandScript)]
        public async Task underhangar_comment()
        {
            cs_switch("ally");
            cs_abort_on_damage(true);
            cs_suppress_dialogue_global(true);
            print("spec-ops elite: 'shall we keep moving, arbiter? the heretic-leader cowers below!'");
            cs_play_line("1160");
        }

        [ScriptMethod(321, Lifecycle.Dormant)]
        public async Task underhangar_reminder()
        {
            await sleep_until(async () => volume_test_objects(vol_underhangar_from_bottom, players()) == true, 30, 900);
            if (volume_test_objects(vol_underhangar_from_bottom, players()) == false && await this.player_count() > 0)
            {
                ai_scene("underhangar_scene", new ScriptMethodReference(underhangar_comment), all_allies) // Couldn't generate cast from 'Boolean' to 'Void'
                ;
            }
        }

        [ScriptMethod(322, Lifecycle.Dormant)]
        public async Task underhangar_firsttime_start()
        {
            data_mine_set_mission_segment("04a_5_underhangar");
            game_save();
            ai_renew(all_allies);
            object_create_containing("underhang_can_");
            if (volume_test_objects_all(vol_hangar_left, players()) == false && volume_test_objects_all(vol_hangar_right, players()) == false && device_get_position(hangar_exit.Entity) > 0F && await this.player_count() > 0)
            {
                pvs_set_object(hangar_door_cinematic.Entity);
                await sleep(2);
                device_set_position_immediate(hangar_door_cinematic.Entity, 0F);
                await sleep(2);
                pvs_clear();
            }

            wake(new ScriptMethodReference(underhangar_can_spawner));
            wake(new ScriptMethodReference(underhangar_killer_new));
            wake(new ScriptMethodReference(underhangar_reinforce));
            this.underhangar_power_on = true;
            ai_migrate(first_hall_heretics, chasers.Squad);
            ai_set_orders(chasers.Squad, chase01);
            ai_place(underhangar_heretic_01.Squad, 1);
            ai_place(underhangar_grunts_01.Squad, 3);
            this.stealth_talk_gone = true;
            ai_set_orders(arm01_allies, allies_underhangar);
            await sleep(5);
            wake(new ScriptMethodReference(music_04a_02_start));
            await sleep_until(async () => volume_test_objects(vol_underhangar_halfway, players()) == true || (short)ai_living_count(underhangar_heretics) < 1);
            game_save();
            wake(new ScriptMethodReference(new_allies_02));
            if ((short)ai_living_count(underhangar_heretics) < 8)
            {
                ai_place(underhangar_heretic_02.Squad, 1);
            }

            if ((short)ai_living_count(underhangar_heretics) < 8)
            {
                ai_place(underhangar_grunts_02.Squad, 2);
            }

            await sleep_until(async () => (short)ai_living_count(underhangar_heretics) < 1 || volume_test_objects(vol_underhangar_from_bottom, players()) == true);
            game_save();
            wake(new ScriptMethodReference(underhangar_reminder));
            wake(new ScriptMethodReference(music_04a_02_stop));
        }

        [ScriptMethod(323, Lifecycle.Dormant)]
        public async Task second_hall_reinforce_01()
        {
            await sleep_until(async () => (short)ai_combat_status(second_hall_grunts_01.Squad) > this.ai_combat_status_idle || (short)ai_combat_status(second_hall_heretic_01.Squad) > this.ai_combat_status_idle);
            ai_place(second_hall_heretic_02.Squad, 1);
            cs_run_command_script(second_hall_heretic_02.Squad, new ScriptMethodReference(snap_alert));
        }

        [ScriptMethod(324, Lifecycle.Dormant)]
        public async Task second_hall_reinforce_02()
        {
            await sleep_until(async () => (short)ai_combat_status(second_hall_heretic_03.Squad) > this.ai_combat_status_idle);
            ai_place(second_hall_grunts_02._1);
            ai_place(second_hall_grunts_02._2);
            if (volume_test_objects(vol_2nd_hall_02, players()) == false && await this.player_count() > 0)
            {
                ai_place(second_hall_grunts_02._3);
                ai_place(second_hall_grunts_02._4);
            }

            cs_run_command_script(second_hall_grunts_02.Squad, new ScriptMethodReference(snap_alert));
        }

        [ScriptMethod(325, Lifecycle.Dormant)]
        public async Task second_hall_reinforce_03()
        {
            await sleep_until(async () => (short)ai_combat_status(second_hall_grunts_03.Squad) > this.ai_combat_status_idle);
            ai_place(second_hall_heretic_04.Squad, 1);
            if (volume_test_objects(vol_2nd_hall_02, players()) == false && await this.player_count() > 0)
            {
                ai_place(second_hall_heretic_05.Squad, 1);
            }

            cs_run_command_script(second_hall_heretic_04.Squad, new ScriptMethodReference(snap_alert));
            cs_run_command_script(second_hall_heretic_05.Squad, new ScriptMethodReference(snap_alert));
        }

        [ScriptMethod(326, Lifecycle.Dormant)]
        public async Task to_bottling()
        {
            await sleep_until(async () => volume_test_objects(vol_underhangar_from_bottom, players()) == true);
            data_mine_set_mission_segment("04a_6_second_halls");
            game_save();
            ai_renew(all_allies);
            player_training_activate_stealth();
            if (device_get_position(hangar_door_cinematic.Entity) > 0F)
            {
                pvs_set_object(hangar_door_cinematic.Entity);
                await sleep(2);
                device_set_position_immediate(hangar_door_cinematic.Entity, 0F);
                await sleep(2);
                pvs_clear();
            }

            wake(new ScriptMethodReference(second_hall_reinforce_01));
            wake(new ScriptMethodReference(second_hall_reinforce_02));
            wake(new ScriptMethodReference(second_hall_reinforce_03));
            ai_migrate(underhangar_heretics, chasers.Squad);
            ai_set_orders(chasers.Squad, chase02);
            ai_place(second_hall_heretic_01.Squad, 1);
            ai_place(second_hall_grunts_01.Squad, 2);
            this.stealth_talk_gone = true;
            ai_set_orders(arm01_allies, allies_second_hall);
            await sleep_until(async () => volume_test_objects(vol_2nd_hall_01, players()) == true);
            game_save();
            ai_place(second_hall_heretic_03.Squad, 1);
            ai_place(second_hall_grunts_03.Squad, 4);
            if ((short)ai_combat_status(second_hall_heretics) < this.ai_combat_status_active)
            {
                ai_set_active_camo(arm01_allies, true);
                ai_suppress_combat(arm01_allies, true);
            }
        }

        [ScriptMethod(327, Lifecycle.Dormant)]
        public async Task bottling_can_spawner()
        {
            await sleep_until(async () => this.bottling_power_on == true);
            await sleep_until(async () =>
            {
                begin_random(async () =>
                {
                    if (list_count(volume_return_objects_by_type(vol_bottling_can_all, 2048)) < 10)
                    {
                        object_create_clone(bottling_can_a);
                        await sleep(this.recycling_time);
                    }
                }, 
                    async () => await sleep(this.recycling_time), 
                    async () =>
                {
                    if (list_count(volume_return_objects_by_type(vol_bottling_can_all, 2048)) < 10)
                    {
                        object_create_clone(bottling_can_b);
                        await sleep(this.recycling_time);
                    }
                }, 
                    async () => await sleep(this.recycling_time));
                return this.bottling_power_on == false;
            });
        }

        [ScriptMethod(328, Lifecycle.Dormant)]
        public async Task bottling_killer_new()
        {
            await sleep_until(async () => this.bottling_power_on == true);
            await sleep_until(async () =>
            {
                object_destroy(list_get(volume_return_objects(kill_bottling_pit_01), 0));
                await sleep(45);
                unit_kill_silent(unit(list_get(volume_return_objects_by_type(kill_bottling_pit_01, 1), 0)));
                await sleep(45);
                object_destroy(list_get(volume_return_objects(kill_bottling_pit_02), 0));
                await sleep(45);
                unit_kill_silent(unit(list_get(volume_return_objects_by_type(kill_bottling_pit_02, 1), 0)));
                await sleep(45);
                return this.bottling_power_on == false;
            });
        }

        [ScriptMethod(329, Lifecycle.CommandScript)]
        public async Task bottling_sentinel_call()
        {
            cs_switch("heretic");
            cs_abort_on_damage(true);
            cs_suppress_dialogue_global(true);
            print("heretic: 'we need sentinels!'");
            cs_play_line("0450");
        }

        [ScriptMethod(330, Lifecycle.Dormant)]
        public async Task new_allies_03()
        {
            if (volume_test_objects(vol_underhangar_can_all, players()) == false && await this.player_count() > 0)
            {
                await sleep_until(async () =>
                {
                    object_destroy(list_get(volume_return_objects_by_type(vol_underhangar_can_all, 1), 0));
                    return list_count(volume_return_objects_by_type(vol_underhangar_can_all, 1)) == 0;
                }, 10);
            }

            if (volume_test_objects(vol_bottling_reinforce, players()) == false && await this.player_count() > 0 && (short)ai_living_count(arm01_allies) < 3)
            {
                ai_place(reinforce_elites_03.Squad, (short)(1 - (float)ai_living_count(allies_elites)));
                ai_place(reinforce_grunts_03.Squad, (short)(1 - (float)ai_living_count(allies_grunts)));
            }
        }

        [ScriptMethod(331, Lifecycle.Dormant)]
        public async Task bottling_firsttime_start()
        {
            data_mine_set_mission_segment("04a_7_bottling_plant");
            game_save();
            object_create_containing("bott_can_");
            ai_renew(all_allies);
            this.stealth_talk_gone = true;
            ai_set_orders(arm01_allies, allies_bottling);
            wake(new ScriptMethodReference(bottling_can_spawner));
            wake(new ScriptMethodReference(bottling_killer_new));
            this.bottling_power_on = true;
            ai_migrate(second_hall_heretics, chasers.Squad);
            ai_set_orders(chasers.Squad, chase02);
            ai_place(bottling_heretics_01.Squad, 2);
            ai_place(bottling_grunts_01.Squad, 2);
            ai_place(bottling_sentinels_01.Squad, 2);
            await sleep_until(async () => volume_test_objects(vol_bottling_really_inside, players()) == true);
            wake(new ScriptMethodReference(new_allies_03));
            await sleep_until(async () => (short)ai_living_count(bottling_heretics) < 2 || volume_test_objects(vol_bottling_mid01, players()) == true || false);
            game_save();
            ai_place(bottling_heretics_02.Squad, (short)(1 - (float)ai_living_count(bottling_heretics_01.Squad)));
            ai_place(bottling_grunts_02.Squad, (short)(4 - (float)ai_living_count(bottling_grunts_01.Squad)));
            await sleep_until(async () => (short)ai_living_count(bottling_heretics) < 2 || volume_test_objects(vol_bottling_mid02, players()) == true || false);
            game_save();
            ai_place(bottling_heretics_03.Squad, (short)(2 - (float)ai_living_count(bottling_heretics_01.Squad) + (float)ai_living_count(bottling_heretics_02.Squad)));
            ai_place(bottling_grunts_03.Squad, (short)(3 - (float)ai_living_count(bottling_grunts_02.Squad) + (float)ai_living_count(bottling_grunts_01.Squad)));
            await sleep_until(async () => (short)ai_living_count(bottling_heretics) < 1 && (short)ai_living_count(bottling_sentinels) < 1);
            game_save();
        }

        [ScriptMethod(332, Lifecycle.CommandScript)]
        public async Task hl_retreat_01()
        {
            cs_switch("heretic_01");
            cs_force_combat_status(4);
            cs_face_player(true);
            cs_suppress_dialogue_global(true);
            print("heretic leader: 'there! the assassin!'");
            cs_custom_animation(GetTag<AnimationGraphTag>("objects\\characters\\elite\\elite", 3891463805U), "combat:rifle:warn", 1F, true);
            cs_face_player(false);
        }

        [ScriptMethod(333, Lifecycle.CommandScript)]
        public async Task hl_retreat_backup()
        {
            cs_enable_pathfinding_failsafe(true);
            cs_go_to(GetReference<ISpatialPoint>("bottling_plant/p1"));
            ai_erase(heretic_leader_02.Squad);
        }

        [ScriptMethod(334, Lifecycle.CommandScript)]
        public async Task sentinel_wingmen_a()
        {
            cs_enable_pathfinding_failsafe(true);
            cs_fly_to(GetReference<ISpatialPoint>("airspace_hl/sen_a_0"), 5F);
            cs_fly_to(GetReference<ISpatialPoint>("airspace_hl/sen_a_1"), 20F);
            ai_erase(bottling_sentinels_03.a);
        }

        [ScriptMethod(335, Lifecycle.CommandScript)]
        public async Task sentinel_wingmen_b()
        {
            cs_enable_pathfinding_failsafe(true);
            cs_fly_to(GetReference<ISpatialPoint>("airspace_hl/sen_b_0"), 5F);
            cs_fly_to(GetReference<ISpatialPoint>("airspace_hl/sen_b_1"), 20F);
            ai_erase(bottling_sentinels_03.b);
        }

        [ScriptMethod(336, Lifecycle.CommandScript)]
        public async Task hl_retreat_02()
        {
            cs_enable_pathfinding_failsafe(true);
            cs_force_combat_status(4);
            cs_approach(approach_here.Entity, 1F, 20F, 20F);
            cs_suppress_dialogue_global(true);
            print("heretic leader: 'deal with him, my brothers!'");
            cs_play_line("0470");
            await sleep(15);
            print("'i will defend the oracle!'");
            cs_play_line("0480");
            this.hl_done_yapping = true;
            ai_vehicle_reserve(ai_vehicle_get_from_starting_location(ledge_banshees_01.center), false);
            cs_approach_stop();
            cs_go_to_vehicle(ai_vehicle_get_from_starting_location(ledge_banshees_01.center));
            wake(new ScriptMethodReference(music_04a_03_start));
            cs_fly_to(GetReference<ISpatialPoint>("airspace_hl/hl0"), 5F);
            cs_vehicle_boost(true);
            cs_fly_to(GetReference<ISpatialPoint>("airspace_hl/hl1"), 20F);
            ai_erase(heretic_leader_03.Squad);
        }

        [ScriptMethod(337, Lifecycle.CommandScript)]
        public async Task hl_retreat_react()
        {
            cs_switch("heretic");
            cs_force_combat_status(4);
            cs_enable_moving(true);
            cs_suppress_dialogue_global(true);
            print("heretic: 'its truth must not be silenced!'");
            cs_play_line("0490");
        }

        [ScriptMethod(338, Lifecycle.Dormant)]
        public async Task bottling_overlook_reinforce()
        {
            ai_place(bottling_sentinels_02.Squad, 1);
            await sleep(120);
            ai_place(bottling_sentinels_02.Squad, 1);
            await sleep(120);
            ai_place(bottling_sentinels_02.Squad, 1);
        }

        [ScriptMethod(339, Lifecycle.CommandScript)]
        public async Task phantom_to_ledge()
        {
            cs_enable_pathfinding_failsafe(true);
            cs_vehicle_speed(0.75F);
            cs_fly_by(GetReference<ISpatialPoint>("airspace/ph0x"), 10F);
            cs_fly_to_and_face(GetReference<ISpatialPoint>("airspace/ph00"), GetReference<ISpatialPoint>("airspace/ph01"), 5F);
            sleep_forever();
        }

        [ScriptMethod(340, Lifecycle.CommandScript)]
        public async Task bottling_elites_secure()
        {
            cs_switch("elite");
            cs_abort_on_damage(true);
            cs_suppress_dialogue_global(true);
            print("spec-ops elite: 'onward, arbiter!  we will secure this section of the station!'");
            cs_play_line("1170");
        }

        [ScriptMethod(341, Lifecycle.CommandScript)]
        public async Task bottling_grunts_secure()
        {
            cs_switch("grunt");
            cs_abort_on_damage(true);
            cs_suppress_dialogue_global(true);
            print("spec-ops grunt: 'you go. we stay. grunt not allowed to fly.'");
            cs_play_line("1180");
        }

        [ScriptMethod(342, Lifecycle.Dormant)]
        public async Task bottling_allies_secure()
        {
            await sleep_until(async () => vehicle_test_seat(ai_vehicle_get_from_starting_location(ledge_banshees_01.left), "banshee_d", unit(await this.player0())) == true || vehicle_test_seat(ai_vehicle_get_from_starting_location(ledge_banshees_01.right), "banshee_d", unit(await this.player0())) == true || vehicle_test_seat(ai_vehicle_get_from_starting_location(ledge_banshees_01.left), "banshee_d", unit(await this.player1())) == true || vehicle_test_seat(ai_vehicle_get_from_starting_location(ledge_banshees_01.right), "banshee_d", unit(await this.player1())) == true, 30, 900);
            if (vehicle_test_seat(ai_vehicle_get_from_starting_location(ledge_banshees_01.left), "banshee_d", unit(await this.player0())) == false && vehicle_test_seat(ai_vehicle_get_from_starting_location(ledge_banshees_01.right), "banshee_d", unit(await this.player0())) == false && vehicle_test_seat(ai_vehicle_get_from_starting_location(ledge_banshees_01.left), "banshee_d", unit(await this.player1())) == false && vehicle_test_seat(ai_vehicle_get_from_starting_location(ledge_banshees_01.right), "banshee_d", unit(await this.player1())) == false)
            {
                if ((short)ai_living_count(allies_elites) > 0)
                {
                    ai_scene("bottling_elite_scene", new ScriptMethodReference(bottling_elites_secure), allies_elites) // Couldn't generate cast from 'Boolean' to 'Void'
                    ;
                }
                else
                {
                    ai_scene("bottling_grunt_scene", new ScriptMethodReference(bottling_grunts_secure), allies_grunts) // Couldn't generate cast from 'Boolean' to 'Void'
                    ;
                }
            }
        }

        [ScriptMethod(343, Lifecycle.Dormant)]
        public async Task big_filth_toggle()
        {
            await sleep_until(async () => volume_test_objects(vol_on_banshee_ledge, players()) == true);
            sound_class_set_gain("ambient_machinery", 0F, 2);
            object_create(big_filthy_audio1);
            sound_class_set_gain("ambient_machinery", 1F, 2);
            await sleep_until(async () =>
            {
                await sleep_until(async () => volume_test_objects(vol_bottling_back_top, players()) == true || volume_test_objects(vol_bottling_back, players()) == true || volume_test_objects(vol_bottling_exit_r, players()) == true || volume_test_objects(vol_bottling_exit_l, players()) == true);
                sound_class_set_gain("ambient_machinery", 0F, 2);
                object_destroy(big_filthy_audio1.Entity);
                sound_class_set_gain("ambient_machinery", 1F, 2);
                await sleep_until(async () => volume_test_objects(vol_on_banshee_ledge, players()) == true);
                sound_class_set_gain("ambient_machinery", 0F, 2);
                object_create(big_filthy_audio1);
                sound_class_set_gain("ambient_machinery", 1F, 2);
                return false;
            });
        }

        [ScriptMethod(344, Lifecycle.Dormant)]
        public async Task bring_in_da_phantom()
        {
            await sleep_until(async () => volume_test_objects(vol_bottling_exit_l, players()) == true || volume_test_objects(vol_bottling_exit_r, players()) == true || volume_test_objects(vol_on_banshee_ledge, players()) == true);
            game_save();
            wake(new ScriptMethodReference(_04a_title1));
            wake(new ScriptMethodReference(big_filth_toggle));
            ai_place(allied_phantom_01.Squad);
            object_cannot_take_damage(ai_vehicle_get_from_starting_location(allied_phantom_01.driver));
            cs_run_command_script(allied_phantom_01.driver, new ScriptMethodReference(phantom_to_ledge));
            ai_dialogue_enable(false);
            await sleep(60);
            print("spec-ops commander: 'the heretics are mobilizing their air-forces, dervish!'");
            await sleep(ai_play_line_on_object(default(IGameObject), "0500"));
            await sleep(15);
            print("'get after their leader, but watch your back!'");
            await sleep(ai_play_line_on_object(default(IGameObject), "0510"));
            await sleep(15);
            print("'i'm sending one of our phantoms to support you!'");
            await sleep(ai_play_line_on_object(default(IGameObject), "0520"));
            await sleep(30);
            ai_dialogue_enable(true);
        }

        [ScriptMethod(345, Lifecycle.Dormant)]
        public async Task bottling_plant_end()
        {
            await sleep_until(async () => volume_test_objects(vol_bottling_back, players()) == true);
            data_mine_set_mission_segment("04a_8_bottling_back");
            game_save();
            ai_migrate(bottling_heretics_start, chasers.Squad);
            ai_set_orders(chasers.Squad, chase03);
            if ((short)ai_living_count(bottling_enemies) < 8)
            {
                ai_place(bottling_heretics_04.Squad, 2);
            }

            ai_place(dog_turrets_01.Squad);
            ai_place(ledge_banshees_01.Squad);
            ai_vehicle_reserve(ai_vehicle_get_from_starting_location(ledge_banshees_01.center), true);
            ai_vehicle_reserve(ai_vehicle_get_from_starting_location(ledge_banshees_01.left), true);
            ai_vehicle_reserve(ai_vehicle_get_from_starting_location(ledge_banshees_01.right), true);
            ai_place(bottling_heretics_05.Squad, 2);
            ai_place(heretic_leader_03.Squad);
            cs_run_command_script(heretic_leader_03.Squad, new ScriptMethodReference(long_pause));
            object_cannot_take_damage(ai_actors(heretic_leader_03.Squad));
            this.left_bottling_firsthalf = true;
            await sleep_until(async () => volume_test_objects(vol_hl_delete_02, players()) == true, 30, 90);
            if (volume_test_objects(vol_hl_delete_02, players()) == false && await this.player_count() > 0 && (short)ai_living_count(bottling_enemies) < 8)
            {
                ai_place(bottling_grunts_04.Squad, 3);
            }

            await sleep_until(async () => volume_test_objects(vol_hl_delete_02, players()) == true);
            cs_run_command_script(heretic_leader_03.Squad, new ScriptMethodReference(hl_retreat_02));
            await sleep_until(async () => this.hl_done_yapping == true, 30, 450);
            await sleep_until(async () => ai_scene("heretic_retreat_02_scene", new ScriptMethodReference(hl_retreat_react), bottling_heretics_05.Squad), 30, 90);
            game_save();
            begin_random(async () =>
            {
                if (this.overlook_choose_side == false)
                {
                    this.overlook_choose_side = true;
                    ai_place(bottling_grunts_05.r1);
                    ai_place(bottling_grunts_05.r2);
                    ai_place(bottling_grunts_05.r3);
                    device_operates_automatically_set(viewroom_exit02.Entity, true);
                    object_create(blocker_l);
                }
            }, 
                async () =>
            {
                if (this.overlook_choose_side == false)
                {
                    this.overlook_choose_side = true;
                    ai_place(bottling_grunts_05.l1);
                    ai_place(bottling_grunts_05.l2);
                    ai_place(bottling_grunts_05.l3);
                    device_operates_automatically_set(viewroom_exit01.Entity, true);
                    object_create(blocker_r);
                }
            });
            ai_set_orders(bottling_heretics_05.Squad, bottling_h_wave_05_high);
            wake(new ScriptMethodReference(bring_in_da_phantom));
            await sleep_until(async () => (short)ai_living_count(bottling_heretics_05.Squad) < 1);
            game_save();
            wake(new ScriptMethodReference(bottling_overlook_reinforce));
            await sleep_until(async () => (short)ai_living_count(bottling_heretics) < 1 && (short)ai_living_count(bottling_sentinels) < 1);
            game_save();
            wake(new ScriptMethodReference(bottling_allies_secure));
        }

        [ScriptMethod(346, Lifecycle.CommandScript)]
        public async Task partytime()
        {
            cs_face(true, GetReference<ISpatialPoint>("arm02_lz/cake"));
            sleep_forever();
        }

        [ScriptMethod(347, Lifecycle.Dormant)]
        public async Task grunt_birthday_party()
        {
            await sleep_until(async () => volume_test_objects(vol_grunt_bday, players()) == true);
            object_create(bday_cake);
            ai_place(bday_party.Squad);
            cs_run_command_script(bday_party.Squad, new ScriptMethodReference(partytime));
            custom_animation_loop(unit(list_get(ai_actors(bday_party.Squad), 0)), GetTag<AnimationGraphTag>("objects\\characters\\grunt\\grunt", 3965258466U), "combat:pistol:cheer", true);
            custom_animation_loop(unit(list_get(ai_actors(bday_party.Squad), 1)), GetTag<AnimationGraphTag>("objects\\characters\\grunt\\grunt", 3965258466U), "combat:pistol:cheer", true);
            custom_animation_loop(unit(list_get(ai_actors(bday_party.Squad), 2)), GetTag<AnimationGraphTag>("objects\\characters\\grunt\\grunt", 3965258466U), "combat:pistol:cheer", true);
            custom_animation_loop(unit(list_get(ai_actors(bday_party.Squad), 3)), GetTag<AnimationGraphTag>("objects\\characters\\grunt\\grunt", 3965258466U), "combat:pistol:cheer", true);
            custom_animation_loop(unit(list_get(ai_actors(bday_party.Squad), 4)), GetTag<AnimationGraphTag>("objects\\characters\\grunt\\grunt", 3965258466U), "combat:pistol:cheer", true);
            custom_animation_loop(unit(list_get(ai_actors(bday_party.Squad), 5)), GetTag<AnimationGraphTag>("objects\\characters\\grunt\\grunt", 3965258466U), "combat:pistol:cheer", true);
            await sleep_until(async () => unit_has_weapon(unit(await this.player0()), GetTag<BaseTag>("objects\\weapons\\multiplayer\\ball\\head_sp.weapon", 4112716527U)) || unit_has_weapon(unit(await this.player1()), GetTag<BaseTag>("objects\\weapons\\multiplayer\\ball\\head_sp.weapon", 4112716527U)));
            ice_cream_flavor_stock(1);
        }

        [ScriptMethod(348, Lifecycle.Dormant)]
        public async Task banshee_stuck_spawner_01()
        {
            await sleep_until(async () => unit_in_vehicle(await this.player0()) == true);
            await sleep_until(async () =>
            {
                await sleep_until(async () => unit_in_vehicle(await this.player0()) == false && volume_test_object(vol_arm_02_lz, await this.player0()) == false && await this.player_count() > 0);
                if (volume_test_object(vol_stuck_01, await this.player0()) == true && list_count_not_dead(volume_return_objects_by_type(vol_stuck_01, 2)) == 0)
                {
                    await sleep_until(async () =>
                    {
                        if (list_count_not_dead(volume_return_objects_by_type(vol_stuck_01, 2)) == 0 && objects_can_see_flag(players(), _01a, 45F) == false && objects_distance_to_flag(players(), _01a) > 2F)
                        {
                            object_create_clone(extra01a);
                        }

                        if (list_count_not_dead(volume_return_objects_by_type(vol_stuck_01, 2)) == 0 && objects_can_see_flag(players(), _01b, 45F) == false && objects_distance_to_flag(players(), _01b) > 2F)
                        {
                            object_create_clone(extra01b);
                        }

                        if (list_count_not_dead(volume_return_objects_by_type(vol_stuck_01, 2)) == 0 && objects_can_see_flag(players(), _01c, 45F) == false && objects_distance_to_flag(players(), _01c) > 2F)
                        {
                            object_create_clone(extra01c);
                        }

                        if (list_count_not_dead(volume_return_objects_by_type(vol_stuck_01, 2)) == 0 && objects_can_see_flag(players(), _01d, 45F) == false && objects_distance_to_flag(players(), _01d) > 2F)
                        {
                            object_create_clone(extra01d);
                        }

                        return unit_in_vehicle(await this.player0()) == true;
                    });
                }

                if (volume_test_object(vol_stuck_02, await this.player0()) == true && list_count_not_dead(volume_return_objects_by_type(vol_stuck_02, 2)) == 0)
                {
                    await sleep_until(async () =>
                    {
                        if (list_count_not_dead(volume_return_objects_by_type(vol_stuck_02, 2)) == 0 && objects_can_see_flag(players(), _02a, 45F) == false && objects_distance_to_flag(players(), _02a) > 2F)
                        {
                            object_create_clone(extra02a);
                        }

                        if (list_count_not_dead(volume_return_objects_by_type(vol_stuck_02, 2)) == 0 && objects_can_see_flag(players(), _02b, 45F) == false && objects_distance_to_flag(players(), _02b) > 2F)
                        {
                            object_create_clone(extra02b);
                        }

                        if (list_count_not_dead(volume_return_objects_by_type(vol_stuck_02, 2)) == 0 && objects_can_see_flag(players(), _02c, 45F) == false && objects_distance_to_flag(players(), _02c) > 2F)
                        {
                            object_create_clone(extra02c);
                        }

                        if (list_count_not_dead(volume_return_objects_by_type(vol_stuck_02, 2)) == 0 && objects_can_see_flag(players(), _02d, 45F) == false && objects_distance_to_flag(players(), _02d) > 2F)
                        {
                            object_create_clone(extra02d);
                        }

                        return unit_in_vehicle(await this.player0()) == true;
                    });
                }

                if (volume_test_object(vol_stuck_03, await this.player0()) == true && list_count_not_dead(volume_return_objects_by_type(vol_stuck_03, 2)) == 0)
                {
                    await sleep_until(async () =>
                    {
                        if (list_count_not_dead(volume_return_objects_by_type(vol_stuck_03, 2)) == 0 && objects_can_see_flag(players(), _03a, 45F) == false && objects_distance_to_flag(players(), _03a) > 2F)
                        {
                            object_create_clone(extra03a);
                        }

                        if (list_count_not_dead(volume_return_objects_by_type(vol_stuck_03, 2)) == 0 && objects_can_see_flag(players(), _03b, 45F) == false && objects_distance_to_flag(players(), _03b) > 2F)
                        {
                            object_create_clone(extra03b);
                        }

                        if (list_count_not_dead(volume_return_objects_by_type(vol_stuck_03, 2)) == 0 && objects_can_see_flag(players(), _03c, 45F) == false && objects_distance_to_flag(players(), _03c) > 2F)
                        {
                            object_create_clone(extra03c);
                        }

                        return unit_in_vehicle(await this.player0()) == true;
                    });
                }

                if (volume_test_object(vol_stuck_04, await this.player0()) == true && list_count_not_dead(volume_return_objects_by_type(vol_stuck_04, 2)) == 0)
                {
                    await sleep_until(async () =>
                    {
                        if (list_count_not_dead(volume_return_objects_by_type(vol_stuck_04, 2)) == 0 && objects_can_see_flag(players(), _04a, 45F) == false && objects_distance_to_flag(players(), _04a) > 2F)
                        {
                            object_create_clone(extra04a);
                        }

                        if (list_count_not_dead(volume_return_objects_by_type(vol_stuck_04, 2)) == 0 && objects_can_see_flag(players(), _04b, 45F) == false && objects_distance_to_flag(players(), _04b) > 2F)
                        {
                            object_create_clone(extra04b);
                        }

                        return unit_in_vehicle(await this.player0()) == true;
                    });
                }

                if (volume_test_object(vol_stuck_05, await this.player0()) == true && list_count_not_dead(volume_return_objects_by_type(vol_stuck_05, 2)) == 0)
                {
                    await sleep_until(async () =>
                    {
                        if (list_count_not_dead(volume_return_objects_by_type(vol_stuck_05, 2)) == 0 && objects_can_see_flag(players(), _05a, 45F) == false && objects_distance_to_flag(players(), _05a) > 2F)
                        {
                            object_create_clone(extra05a);
                        }

                        if (list_count_not_dead(volume_return_objects_by_type(vol_stuck_05, 2)) == 0 && objects_can_see_flag(players(), _05b, 45F) == false && objects_distance_to_flag(players(), _05b) > 2F)
                        {
                            object_create_clone(extra05b);
                        }

                        return unit_in_vehicle(await this.player0()) == true;
                    });
                }

                if (volume_test_object(vol_stuck_06, await this.player0()) == true && list_count_not_dead(volume_return_objects_by_type(vol_stuck_06, 2)) == 0)
                {
                    await sleep_until(async () =>
                    {
                        if (list_count_not_dead(volume_return_objects_by_type(vol_stuck_06, 2)) == 0 && objects_can_see_flag(players(), _06a, 45F) == false && objects_distance_to_flag(players(), _06a) > 2F)
                        {
                            object_create_clone(extra06a);
                        }

                        if (list_count_not_dead(volume_return_objects_by_type(vol_stuck_06, 2)) == 0 && objects_can_see_flag(players(), _06b, 45F) == false && objects_distance_to_flag(players(), _06b) > 2F)
                        {
                            object_create_clone(extra06b);
                        }

                        return unit_in_vehicle(await this.player0()) == true;
                    });
                }

                if (volume_test_object(vol_stuck_07, await this.player0()) == true && list_count_not_dead(volume_return_objects_by_type(vol_stuck_07, 2)) == 0)
                {
                    await sleep_until(async () =>
                    {
                        if (list_count_not_dead(volume_return_objects_by_type(vol_stuck_07, 2)) == 0 && objects_can_see_flag(players(), _07a, 45F) == false && objects_distance_to_flag(players(), _07a) > 2F)
                        {
                            object_create_clone(extra07a);
                        }

                        if (list_count_not_dead(volume_return_objects_by_type(vol_stuck_07, 2)) == 0 && objects_can_see_flag(players(), _07b, 45F) == false && objects_distance_to_flag(players(), _07b) > 2F)
                        {
                            object_create_clone(extra07b);
                        }

                        if (list_count_not_dead(volume_return_objects_by_type(vol_stuck_07, 2)) == 0 && objects_can_see_flag(players(), _07c, 45F) == false && objects_distance_to_flag(players(), _07c) > 2F)
                        {
                            object_create_clone(extra07c);
                        }

                        return unit_in_vehicle(await this.player0()) == true;
                    });
                }

                if (volume_test_object(vol_stuck_08, await this.player0()) == true && list_count_not_dead(volume_return_objects_by_type(vol_stuck_08, 2)) == 0)
                {
                    await sleep_until(async () =>
                    {
                        if (list_count_not_dead(volume_return_objects_by_type(vol_stuck_08, 2)) == 0 && objects_can_see_flag(players(), _08a, 45F) == false && objects_distance_to_flag(players(), _08a) > 2F)
                        {
                            object_create_clone(extra08a);
                        }

                        if (list_count_not_dead(volume_return_objects_by_type(vol_stuck_08, 2)) == 0 && objects_can_see_flag(players(), _08b, 45F) == false && objects_distance_to_flag(players(), _08b) > 2F)
                        {
                            object_create_clone(extra08b);
                        }

                        return unit_in_vehicle(await this.player0()) == true;
                    });
                }

                if (volume_test_object(vol_stuck_09, await this.player0()) == true && list_count_not_dead(volume_return_objects_by_type(vol_stuck_09, 2)) == 0)
                {
                    await sleep_until(async () =>
                    {
                        if (list_count_not_dead(volume_return_objects_by_type(vol_stuck_09, 2)) == 0 && objects_can_see_flag(players(), _09a, 45F) == false && objects_distance_to_flag(players(), _09a) > 2F)
                        {
                            object_create_clone(extra09a);
                        }

                        if (list_count_not_dead(volume_return_objects_by_type(vol_stuck_09, 2)) == 0 && objects_can_see_flag(players(), _09b, 45F) == false && objects_distance_to_flag(players(), _09b) > 2F)
                        {
                            object_create_clone(extra09b);
                        }

                        return unit_in_vehicle(await this.player0()) == true;
                    });
                }

                if (volume_test_object(vol_stuck_10, await this.player0()) == true && list_count_not_dead(volume_return_objects_by_type(vol_stuck_10, 2)) == 0)
                {
                    await sleep_until(async () =>
                    {
                        if (list_count_not_dead(volume_return_objects_by_type(vol_stuck_10, 2)) == 0 && objects_can_see_flag(players(), _10a, 45F) == false && objects_distance_to_flag(players(), _10a) > 2F)
                        {
                            object_create_clone(extra10a);
                        }

                        if (list_count_not_dead(volume_return_objects_by_type(vol_stuck_10, 2)) == 0 && objects_can_see_flag(players(), _10b, 45F) == false && objects_distance_to_flag(players(), _10b) > 2F)
                        {
                            object_create_clone(extra10b);
                        }

                        return unit_in_vehicle(await this.player0()) == true;
                    });
                }

                if (volume_test_object(vol_stuck_11, await this.player0()) == true && list_count_not_dead(volume_return_objects_by_type(vol_stuck_11, 2)) == 0)
                {
                    await sleep_until(async () =>
                    {
                        if (list_count_not_dead(volume_return_objects_by_type(vol_stuck_11, 2)) == 0 && objects_can_see_flag(players(), _11a, 45F) == false && objects_distance_to_flag(players(), _11a) > 2F)
                        {
                            object_create_clone(extra11a);
                        }

                        if (list_count_not_dead(volume_return_objects_by_type(vol_stuck_11, 2)) == 0 && objects_can_see_flag(players(), _11b, 45F) == false && objects_distance_to_flag(players(), _11b) > 2F)
                        {
                            object_create_clone(extra11b);
                        }

                        if (list_count_not_dead(volume_return_objects_by_type(vol_stuck_11, 2)) == 0 && objects_can_see_flag(players(), _11c, 45F) == false && objects_distance_to_flag(players(), _11c) > 2F)
                        {
                            object_create_clone(extra11c);
                        }

                        return unit_in_vehicle(await this.player0()) == true;
                    });
                }

                if (volume_test_object(vol_stuck_12, await this.player0()) == true && list_count_not_dead(volume_return_objects_by_type(vol_stuck_12, 2)) == 0)
                {
                    await sleep_until(async () =>
                    {
                        if (list_count_not_dead(volume_return_objects_by_type(vol_stuck_12, 2)) == 0 && objects_can_see_flag(players(), _12a, 45F) == false && objects_distance_to_flag(players(), _12a) > 2F)
                        {
                            object_create_clone(extra12a);
                        }

                        if (list_count_not_dead(volume_return_objects_by_type(vol_stuck_12, 2)) == 0 && objects_can_see_flag(players(), _12b, 45F) == false && objects_distance_to_flag(players(), _12b) > 2F)
                        {
                            object_create_clone(extra12b);
                        }

                        if (list_count_not_dead(volume_return_objects_by_type(vol_stuck_12, 2)) == 0 && objects_can_see_flag(players(), _12c, 45F) == false && objects_distance_to_flag(players(), _12c) > 2F)
                        {
                            object_create_clone(extra12c);
                        }

                        return unit_in_vehicle(await this.player0()) == true;
                    });
                }

                if (volume_test_object(vol_stuck_13, await this.player0()) == true && list_count_not_dead(volume_return_objects_by_type(vol_stuck_13, 2)) == 0)
                {
                    await sleep_until(async () =>
                    {
                        if (list_count_not_dead(volume_return_objects_by_type(vol_stuck_13, 2)) == 0 && objects_can_see_flag(players(), _13a, 45F) == false && objects_distance_to_flag(players(), _13a) > 2F)
                        {
                            object_create_clone(extra13a);
                        }

                        if (list_count_not_dead(volume_return_objects_by_type(vol_stuck_13, 2)) == 0 && objects_can_see_flag(players(), _13b, 45F) == false && objects_distance_to_flag(players(), _13b) > 2F)
                        {
                            object_create_clone(extra13b);
                        }

                        if (list_count_not_dead(volume_return_objects_by_type(vol_stuck_13, 2)) == 0 && objects_can_see_flag(players(), _13c, 45F) == false && objects_distance_to_flag(players(), _13c) > 2F)
                        {
                            object_create_clone(extra13c);
                        }

                        return unit_in_vehicle(await this.player0()) == true;
                    });
                }

                if (volume_test_object(vol_stuck_14, await this.player0()) == true && list_count_not_dead(volume_return_objects_by_type(vol_stuck_14, 2)) == 0)
                {
                    await sleep_until(async () =>
                    {
                        if (list_count_not_dead(volume_return_objects_by_type(vol_stuck_14, 2)) == 0 && objects_can_see_flag(players(), _14a, 45F) == false && objects_distance_to_flag(players(), _14a) > 2F)
                        {
                            object_create_clone(extra14a);
                        }

                        if (list_count_not_dead(volume_return_objects_by_type(vol_stuck_14, 2)) == 0 && objects_can_see_flag(players(), _14b, 45F) == false && objects_distance_to_flag(players(), _14b) > 2F)
                        {
                            object_create_clone(extra14b);
                        }

                        return unit_in_vehicle(await this.player0()) == true;
                    });
                }

                if (volume_test_object(vol_stuck_15, await this.player0()) == true && list_count_not_dead(volume_return_objects_by_type(vol_stuck_15, 2)) == 0)
                {
                    await sleep_until(async () =>
                    {
                        if (list_count_not_dead(volume_return_objects_by_type(vol_stuck_15, 2)) == 0 && objects_can_see_flag(players(), _15a, 45F) == false && objects_distance_to_flag(players(), _15a) > 2F)
                        {
                            object_create_clone(extra15a);
                        }

                        if (list_count_not_dead(volume_return_objects_by_type(vol_stuck_15, 2)) == 0 && objects_can_see_flag(players(), _15b, 45F) == false && objects_distance_to_flag(players(), _15b) > 2F)
                        {
                            object_create_clone(extra15b);
                        }

                        return unit_in_vehicle(await this.player0()) == true;
                    });
                }

                return false;
            });
        }

        [ScriptMethod(349, Lifecycle.Dormant)]
        public async Task banshee_stuck_spawner_02()
        {
            await sleep_until(async () => unit_in_vehicle(await this.player1()) == true);
            await sleep_until(async () =>
            {
                await sleep_until(async () => unit_in_vehicle(await this.player1()) == false && volume_test_object(vol_arm_02_lz, await this.player1()) == false && await this.player_count() > 0);
                if (volume_test_object(vol_stuck_01, await this.player1()) == true && list_count_not_dead(volume_return_objects_by_type(vol_stuck_01, 2)) == 0)
                {
                    await sleep_until(async () =>
                    {
                        if (list_count_not_dead(volume_return_objects_by_type(vol_stuck_01, 2)) == 0 && objects_can_see_flag(players(), _01a, 45F) == false && objects_distance_to_flag(players(), _01a) > 2F)
                        {
                            object_create_clone(extra01a);
                        }

                        if (list_count_not_dead(volume_return_objects_by_type(vol_stuck_01, 2)) == 0 && objects_can_see_flag(players(), _01b, 45F) == false && objects_distance_to_flag(players(), _01b) > 2F)
                        {
                            object_create_clone(extra01b);
                        }

                        if (list_count_not_dead(volume_return_objects_by_type(vol_stuck_01, 2)) == 0 && objects_can_see_flag(players(), _01c, 45F) == false && objects_distance_to_flag(players(), _01c) > 2F)
                        {
                            object_create_clone(extra01c);
                        }

                        if (list_count_not_dead(volume_return_objects_by_type(vol_stuck_01, 2)) == 0 && objects_can_see_flag(players(), _01d, 45F) == false && objects_distance_to_flag(players(), _01d) > 2F)
                        {
                            object_create_clone(extra01d);
                        }

                        return unit_in_vehicle(await this.player1()) == true;
                    });
                }

                if (volume_test_object(vol_stuck_02, await this.player1()) == true && list_count_not_dead(volume_return_objects_by_type(vol_stuck_02, 2)) == 0)
                {
                    await sleep_until(async () =>
                    {
                        if (list_count_not_dead(volume_return_objects_by_type(vol_stuck_02, 2)) == 0 && objects_can_see_flag(players(), _02a, 45F) == false && objects_distance_to_flag(players(), _02a) > 2F)
                        {
                            object_create_clone(extra02a);
                        }

                        if (list_count_not_dead(volume_return_objects_by_type(vol_stuck_02, 2)) == 0 && objects_can_see_flag(players(), _02b, 45F) == false && objects_distance_to_flag(players(), _02b) > 2F)
                        {
                            object_create_clone(extra02b);
                        }

                        if (list_count_not_dead(volume_return_objects_by_type(vol_stuck_02, 2)) == 0 && objects_can_see_flag(players(), _02c, 45F) == false && objects_distance_to_flag(players(), _02c) > 2F)
                        {
                            object_create_clone(extra02c);
                        }

                        if (list_count_not_dead(volume_return_objects_by_type(vol_stuck_02, 2)) == 0 && objects_can_see_flag(players(), _02d, 45F) == false && objects_distance_to_flag(players(), _02d) > 2F)
                        {
                            object_create_clone(extra02d);
                        }

                        return unit_in_vehicle(await this.player1()) == true;
                    });
                }

                if (volume_test_object(vol_stuck_03, await this.player1()) == true && list_count_not_dead(volume_return_objects_by_type(vol_stuck_03, 2)) == 0)
                {
                    await sleep_until(async () =>
                    {
                        if (list_count_not_dead(volume_return_objects_by_type(vol_stuck_03, 2)) == 0 && objects_can_see_flag(players(), _03a, 45F) == false && objects_distance_to_flag(players(), _03a) > 2F)
                        {
                            object_create_clone(extra03a);
                        }

                        if (list_count_not_dead(volume_return_objects_by_type(vol_stuck_03, 2)) == 0 && objects_can_see_flag(players(), _03b, 45F) == false && objects_distance_to_flag(players(), _03b) > 2F)
                        {
                            object_create_clone(extra03b);
                        }

                        if (list_count_not_dead(volume_return_objects_by_type(vol_stuck_03, 2)) == 0 && objects_can_see_flag(players(), _03c, 45F) == false && objects_distance_to_flag(players(), _03c) > 2F)
                        {
                            object_create_clone(extra03c);
                        }

                        return unit_in_vehicle(await this.player1()) == true;
                    });
                }

                if (volume_test_object(vol_stuck_04, await this.player1()) == true && list_count_not_dead(volume_return_objects_by_type(vol_stuck_04, 2)) == 0)
                {
                    await sleep_until(async () =>
                    {
                        if (list_count_not_dead(volume_return_objects_by_type(vol_stuck_04, 2)) == 0 && objects_can_see_flag(players(), _04a, 45F) == false && objects_distance_to_flag(players(), _04a) > 2F)
                        {
                            object_create_clone(extra04a);
                        }

                        if (list_count_not_dead(volume_return_objects_by_type(vol_stuck_04, 2)) == 0 && objects_can_see_flag(players(), _04b, 45F) == false && objects_distance_to_flag(players(), _04b) > 2F)
                        {
                            object_create_clone(extra04b);
                        }

                        return unit_in_vehicle(await this.player1()) == true;
                    });
                }

                if (volume_test_object(vol_stuck_05, await this.player1()) == true && list_count_not_dead(volume_return_objects_by_type(vol_stuck_05, 2)) == 0)
                {
                    await sleep_until(async () =>
                    {
                        if (list_count_not_dead(volume_return_objects_by_type(vol_stuck_05, 2)) == 0 && objects_can_see_flag(players(), _05a, 45F) == false && objects_distance_to_flag(players(), _05a) > 2F)
                        {
                            object_create_clone(extra05a);
                        }

                        if (list_count_not_dead(volume_return_objects_by_type(vol_stuck_05, 2)) == 0 && objects_can_see_flag(players(), _05b, 45F) == false && objects_distance_to_flag(players(), _05b) > 2F)
                        {
                            object_create_clone(extra05b);
                        }

                        return unit_in_vehicle(await this.player1()) == true;
                    });
                }

                if (volume_test_object(vol_stuck_06, await this.player1()) == true && list_count_not_dead(volume_return_objects_by_type(vol_stuck_06, 2)) == 0)
                {
                    await sleep_until(async () =>
                    {
                        if (list_count_not_dead(volume_return_objects_by_type(vol_stuck_06, 2)) == 0 && objects_can_see_flag(players(), _06a, 45F) == false && objects_distance_to_flag(players(), _06a) > 2F)
                        {
                            object_create_clone(extra06a);
                        }

                        if (list_count_not_dead(volume_return_objects_by_type(vol_stuck_06, 2)) == 0 && objects_can_see_flag(players(), _06b, 45F) == false && objects_distance_to_flag(players(), _06b) > 2F)
                        {
                            object_create_clone(extra06b);
                        }

                        return unit_in_vehicle(await this.player1()) == true;
                    });
                }

                if (volume_test_object(vol_stuck_07, await this.player1()) == true && list_count_not_dead(volume_return_objects_by_type(vol_stuck_07, 2)) == 0)
                {
                    await sleep_until(async () =>
                    {
                        if (list_count_not_dead(volume_return_objects_by_type(vol_stuck_07, 2)) == 0 && objects_can_see_flag(players(), _07a, 45F) == false && objects_distance_to_flag(players(), _07a) > 2F)
                        {
                            object_create_clone(extra07a);
                        }

                        if (list_count_not_dead(volume_return_objects_by_type(vol_stuck_07, 2)) == 0 && objects_can_see_flag(players(), _07b, 45F) == false && objects_distance_to_flag(players(), _07b) > 2F)
                        {
                            object_create_clone(extra07b);
                        }

                        if (list_count_not_dead(volume_return_objects_by_type(vol_stuck_07, 2)) == 0 && objects_can_see_flag(players(), _07c, 45F) == false && objects_distance_to_flag(players(), _07c) > 2F)
                        {
                            object_create_clone(extra07c);
                        }

                        return unit_in_vehicle(await this.player1()) == true;
                    });
                }

                if (volume_test_object(vol_stuck_08, await this.player1()) == true && list_count_not_dead(volume_return_objects_by_type(vol_stuck_08, 2)) == 0)
                {
                    await sleep_until(async () =>
                    {
                        if (list_count_not_dead(volume_return_objects_by_type(vol_stuck_08, 2)) == 0 && objects_can_see_flag(players(), _08a, 45F) == false && objects_distance_to_flag(players(), _08a) > 2F)
                        {
                            object_create_clone(extra08a);
                        }

                        if (list_count_not_dead(volume_return_objects_by_type(vol_stuck_08, 2)) == 0 && objects_can_see_flag(players(), _08b, 45F) == false && objects_distance_to_flag(players(), _08b) > 2F)
                        {
                            object_create_clone(extra08b);
                        }

                        return unit_in_vehicle(await this.player1()) == true;
                    });
                }

                if (volume_test_object(vol_stuck_09, await this.player1()) == true && list_count_not_dead(volume_return_objects_by_type(vol_stuck_09, 2)) == 0)
                {
                    await sleep_until(async () =>
                    {
                        if (list_count_not_dead(volume_return_objects_by_type(vol_stuck_09, 2)) == 0 && objects_can_see_flag(players(), _09a, 45F) == false && objects_distance_to_flag(players(), _09a) > 2F)
                        {
                            object_create_clone(extra09a);
                        }

                        if (list_count_not_dead(volume_return_objects_by_type(vol_stuck_09, 2)) == 0 && objects_can_see_flag(players(), _09b, 45F) == false && objects_distance_to_flag(players(), _09b) > 2F)
                        {
                            object_create_clone(extra09b);
                        }

                        return unit_in_vehicle(await this.player1()) == true;
                    });
                }

                if (volume_test_object(vol_stuck_10, await this.player1()) == true && list_count_not_dead(volume_return_objects_by_type(vol_stuck_10, 2)) == 0)
                {
                    await sleep_until(async () =>
                    {
                        if (list_count_not_dead(volume_return_objects_by_type(vol_stuck_10, 2)) == 0 && objects_can_see_flag(players(), _10a, 45F) == false && objects_distance_to_flag(players(), _10a) > 2F)
                        {
                            object_create_clone(extra10a);
                        }

                        if (list_count_not_dead(volume_return_objects_by_type(vol_stuck_10, 2)) == 0 && objects_can_see_flag(players(), _10b, 45F) == false && objects_distance_to_flag(players(), _10b) > 2F)
                        {
                            object_create_clone(extra10b);
                        }

                        return unit_in_vehicle(await this.player1()) == true;
                    });
                }

                if (volume_test_object(vol_stuck_11, await this.player1()) == true && list_count_not_dead(volume_return_objects_by_type(vol_stuck_11, 2)) == 0)
                {
                    await sleep_until(async () =>
                    {
                        if (list_count_not_dead(volume_return_objects_by_type(vol_stuck_11, 2)) == 0 && objects_can_see_flag(players(), _11a, 45F) == false && objects_distance_to_flag(players(), _11a) > 2F)
                        {
                            object_create_clone(extra11a);
                        }

                        if (list_count_not_dead(volume_return_objects_by_type(vol_stuck_11, 2)) == 0 && objects_can_see_flag(players(), _11b, 45F) == false && objects_distance_to_flag(players(), _11b) > 2F)
                        {
                            object_create_clone(extra11b);
                        }

                        if (list_count_not_dead(volume_return_objects_by_type(vol_stuck_11, 2)) == 0 && objects_can_see_flag(players(), _11c, 45F) == false && objects_distance_to_flag(players(), _11c) > 2F)
                        {
                            object_create_clone(extra11c);
                        }

                        return unit_in_vehicle(await this.player1()) == true;
                    });
                }

                if (volume_test_object(vol_stuck_12, await this.player1()) == true && list_count_not_dead(volume_return_objects_by_type(vol_stuck_12, 2)) == 0)
                {
                    await sleep_until(async () =>
                    {
                        if (list_count_not_dead(volume_return_objects_by_type(vol_stuck_12, 2)) == 0 && objects_can_see_flag(players(), _12a, 45F) == false && objects_distance_to_flag(players(), _12a) > 2F)
                        {
                            object_create_clone(extra12a);
                        }

                        if (list_count_not_dead(volume_return_objects_by_type(vol_stuck_12, 2)) == 0 && objects_can_see_flag(players(), _12b, 45F) == false && objects_distance_to_flag(players(), _12b) > 2F)
                        {
                            object_create_clone(extra12b);
                        }

                        if (list_count_not_dead(volume_return_objects_by_type(vol_stuck_12, 2)) == 0 && objects_can_see_flag(players(), _12c, 45F) == false && objects_distance_to_flag(players(), _12c) > 2F)
                        {
                            object_create_clone(extra12c);
                        }

                        return unit_in_vehicle(await this.player1()) == true;
                    });
                }

                if (volume_test_object(vol_stuck_13, await this.player1()) == true && list_count_not_dead(volume_return_objects_by_type(vol_stuck_13, 2)) == 0)
                {
                    await sleep_until(async () =>
                    {
                        if (list_count_not_dead(volume_return_objects_by_type(vol_stuck_13, 2)) == 0 && objects_can_see_flag(players(), _13a, 45F) == false && objects_distance_to_flag(players(), _13a) > 2F)
                        {
                            object_create_clone(extra13a);
                        }

                        if (list_count_not_dead(volume_return_objects_by_type(vol_stuck_13, 2)) == 0 && objects_can_see_flag(players(), _13b, 45F) == false && objects_distance_to_flag(players(), _13b) > 2F)
                        {
                            object_create_clone(extra13b);
                        }

                        if (list_count_not_dead(volume_return_objects_by_type(vol_stuck_13, 2)) == 0 && objects_can_see_flag(players(), _13c, 45F) == false && objects_distance_to_flag(players(), _13c) > 2F)
                        {
                            object_create_clone(extra13c);
                        }

                        return unit_in_vehicle(await this.player1()) == true;
                    });
                }

                if (volume_test_object(vol_stuck_14, await this.player1()) == true && list_count_not_dead(volume_return_objects_by_type(vol_stuck_14, 2)) == 0)
                {
                    await sleep_until(async () =>
                    {
                        if (list_count_not_dead(volume_return_objects_by_type(vol_stuck_14, 2)) == 0 && objects_can_see_flag(players(), _14a, 45F) == false && objects_distance_to_flag(players(), _14a) > 2F)
                        {
                            object_create_clone(extra14a);
                        }

                        if (list_count_not_dead(volume_return_objects_by_type(vol_stuck_14, 2)) == 0 && objects_can_see_flag(players(), _14b, 45F) == false && objects_distance_to_flag(players(), _14b) > 2F)
                        {
                            object_create_clone(extra14b);
                        }

                        return unit_in_vehicle(await this.player1()) == true;
                    });
                }

                if (volume_test_object(vol_stuck_15, await this.player1()) == true && list_count_not_dead(volume_return_objects_by_type(vol_stuck_15, 2)) == 0)
                {
                    await sleep_until(async () =>
                    {
                        if (list_count_not_dead(volume_return_objects_by_type(vol_stuck_15, 2)) == 0 && objects_can_see_flag(players(), _15a, 45F) == false && objects_distance_to_flag(players(), _15a) > 2F)
                        {
                            object_create_clone(extra15a);
                        }

                        if (list_count_not_dead(volume_return_objects_by_type(vol_stuck_15, 2)) == 0 && objects_can_see_flag(players(), _15b, 45F) == false && objects_distance_to_flag(players(), _15b) > 2F)
                        {
                            object_create_clone(extra15b);
                        }

                        return unit_in_vehicle(await this.player1()) == true;
                    });
                }

                return false;
            });
        }

        [ScriptMethod(350, Lifecycle.CommandScript)]
        public async Task phantom_path()
        {
            cs_enable_pathfinding_failsafe(true);
            cs_vehicle_speed(0.1F);
            cs_fly_by(GetReference<ISpatialPoint>("airspace/ph01"), 10F);
            this.phantom_course_pos = 1;
            cs_fly_by(GetReference<ISpatialPoint>("airspace/ph02"), 10F);
            this.phantom_course_pos = 2;
            cs_fly_by(GetReference<ISpatialPoint>("airspace/ph03"), 10F);
            this.phantom_course_pos = 3;
            cs_fly_by(GetReference<ISpatialPoint>("airspace/ph04"), 10F);
            this.phantom_course_pos = 4;
            cs_fly_by(GetReference<ISpatialPoint>("airspace/ph05"), 10F);
            this.phantom_course_pos = 5;
            cs_fly_by(GetReference<ISpatialPoint>("airspace/ph06"), 10F);
            this.phantom_course_pos = 6;
            cs_fly_by(GetReference<ISpatialPoint>("airspace/ph07"), 10F);
            this.phantom_course_pos = 7;
            cs_fly_by(GetReference<ISpatialPoint>("airspace/ph08"), 10F);
            this.phantom_course_pos = 8;
            cs_fly_by(GetReference<ISpatialPoint>("airspace/ph09"), 10F);
            this.phantom_course_pos = 9;
            cs_fly_by(GetReference<ISpatialPoint>("airspace/ph10"), 10F);
            this.phantom_course_pos = 10;
            cs_fly_by(GetReference<ISpatialPoint>("airspace/ph11"), 10F);
            this.phantom_course_pos = 11;
            cs_vehicle_speed(0.05F);
            cs_fly_by(GetReference<ISpatialPoint>("airspace/ph12"), 10F);
            this.phantom_course_pos = 12;
            cs_fly_to(GetReference<ISpatialPoint>("airspace/ph13"), 5F);
            this.phantom_course_pos = 13;
            cs_pause(-1F);
        }

        [ScriptMethod(351, Lifecycle.CommandScript)]
        public async Task arm02_swat_aim_00()
        {
            cs_abort_on_damage(true);
            cs_enable_pathfinding_failsafe(true);
            cs_go_to(GetReference<ISpatialPoint>("arm02_lz/p0"));
            cs_aim(true, GetReference<ISpatialPoint>("arm02_lz/door"));
            sleep_forever();
        }

        [ScriptMethod(352, Lifecycle.CommandScript)]
        public async Task arm02_swat_aim_01()
        {
            cs_abort_on_damage(true);
            cs_enable_pathfinding_failsafe(true);
            cs_go_to(GetReference<ISpatialPoint>("arm02_lz/p1"));
            cs_aim(true, GetReference<ISpatialPoint>("arm02_lz/door"));
            sleep_forever();
        }

        [ScriptMethod(353, Lifecycle.CommandScript)]
        public async Task arm02_swat_aim_02()
        {
            cs_abort_on_damage(true);
            cs_enable_pathfinding_failsafe(true);
            cs_go_to(GetReference<ISpatialPoint>("arm02_lz/p2"));
            cs_aim(true, GetReference<ISpatialPoint>("arm02_lz/door"));
            sleep_forever();
        }

        [ScriptMethod(354, Lifecycle.CommandScript)]
        public async Task arm02_swat_aim_03()
        {
            cs_abort_on_damage(true);
            cs_enable_pathfinding_failsafe(true);
            cs_go_to(GetReference<ISpatialPoint>("arm02_lz/p3"));
            cs_aim(true, GetReference<ISpatialPoint>("arm02_lz/door"));
            sleep_forever();
        }

        [ScriptMethod(355, Lifecycle.CommandScript)]
        public async Task arm02_final_approach()
        {
            cs_enable_pathfinding_failsafe(true);
            cs_vehicle_speed(0.5F);
            cs_fly_to(GetReference<ISpatialPoint>("airspace/ph13"), 2F);
            await sleep(60);
            vehicle_unload(ai_vehicle_get_from_starting_location(allied_phantom_01.driver), "phantom_p_a01");
            await sleep(30);
            vehicle_unload(ai_vehicle_get_from_starting_location(allied_phantom_01.driver), "phantom_p_a02");
            await sleep(30);
            vehicle_unload(ai_vehicle_get_from_starting_location(allied_phantom_01.driver), "phantom_p_a03");
            cs_run_command_script(allies_elites_03.elite01, new ScriptMethodReference(arm02_swat_aim_00));
            cs_run_command_script(allies_elites_03.elite02, new ScriptMethodReference(arm02_swat_aim_01));
            await sleep(30);
            vehicle_unload(ai_vehicle_get_from_starting_location(allied_phantom_01.driver), "phantom_p_b01");
            await sleep(30);
            vehicle_unload(ai_vehicle_get_from_starting_location(allied_phantom_01.driver), "phantom_p_b02");
            await sleep(30);
            vehicle_unload(ai_vehicle_get_from_starting_location(allied_phantom_01.driver), "phantom_p_b03");
            cs_run_command_script(allies_grunts_03.grunt01, new ScriptMethodReference(arm02_swat_aim_02));
            cs_run_command_script(allies_grunts_03.grunt02, new ScriptMethodReference(arm02_swat_aim_03));
            cs_pause(-1F);
        }

        [ScriptMethod(356, Lifecycle.Dormant)]
        public async Task dogfight_search_reminder()
        {
            ai_dialogue_enable(false);
            await sleep(60);
            print("spec-ops commander: 'no sign of the heretic-leader or his banshee. we must keep searching!'");
            await sleep(ai_play_line_on_object(default(IGameObject), "1210"));
            await sleep(30);
            ai_dialogue_enable(true);
        }

        [ScriptMethod(357, Lifecycle.Dormant)]
        public async Task dogfight_ph_pilot_talk()
        {
            begin_random(async () => await sleep_until(async () => this.dogfight_ph_pilot_go == true), 
                async () => this.dogfight_ph_pilot_go = false, 
                async () => ai_dialogue_enable(false), 
                async () => await sleep(60), 
                async () => print("phantom pilot: 'emplacement destroyed! heading to the next target!'"), 
                async () => await sleep(ai_play_line_on_object(default(IGameObject), "2050")), 
                async () => await sleep(30), 
                async () => ai_dialogue_enable(true), 
                async () => await sleep_until(async () => this.dogfight_ph_pilot_go == true), 
                async () => this.dogfight_ph_pilot_go = false, 
                async () => ai_dialogue_enable(false), 
                async () => await sleep(60), 
                async () => print("phantom pilot: 'all heretic forces have been eliminated! moving on!'"), 
                async () => await sleep(ai_play_line_on_object(default(IGameObject), "2060")), 
                async () => await sleep(30), 
                async () => ai_dialogue_enable(true), 
                async () => await sleep_until(async () => this.dogfight_ph_pilot_go == true), 
                async () => this.dogfight_ph_pilot_go = false, 
                async () => ai_dialogue_enable(false), 
                async () => await sleep(60), 
                async () => print("phantom pilot: 'this area is clear! let us continue!'"), 
                async () => await sleep(ai_play_line_on_object(default(IGameObject), "2070")), 
                async () => await sleep(30), 
                async () => ai_dialogue_enable(true), 
                async () => await sleep_until(async () => this.dogfight_ph_pilot_go == true), 
                async () => this.dogfight_ph_pilot_go = false, 
                async () => ai_dialogue_enable(false), 
                async () => await sleep(60), 
                async () => print("phantom pilot: 'that is the last of them! but there are more ahead!'"), 
                async () => await sleep(ai_play_line_on_object(default(IGameObject), "2080")), 
                async () => await sleep(30), 
                async () => ai_dialogue_enable(true), 
                async () => await sleep_until(async () => this.dogfight_ph_pilot_go == true), 
                async () => this.dogfight_ph_pilot_go = false, 
                async () => ai_dialogue_enable(false), 
                async () => await sleep(60), 
                async () => print("phantom pilot: 'these heretics are dead. onward!'"), 
                async () => await sleep(ai_play_line_on_object(default(IGameObject), "2090")), 
                async () => await sleep(30), 
                async () => ai_dialogue_enable(true), 
                async () => await sleep_until(async () => this.dogfight_ph_pilot_go == true), 
                async () => this.dogfight_ph_pilot_go = false, 
                async () => ai_dialogue_enable(false), 
                async () => await sleep(60), 
                async () => print("phantom pilot: 'follow me, arbiter! i have found another emplacement!'"), 
                async () => await sleep(ai_play_line_on_object(default(IGameObject), "2100")), 
                async () => await sleep(30), 
                async () => ai_dialogue_enable(true), 
                async () => await sleep_until(async () => this.dogfight_ph_pilot_go == true), 
                async () => this.dogfight_ph_pilot_go = false, 
                async () => ai_dialogue_enable(false), 
                async () => await sleep(60), 
                async () => print("phantom pilot: 'this way, arbiter! i see another heretic position!'"), 
                async () => await sleep(ai_play_line_on_object(default(IGameObject), "2110")), 
                async () => await sleep(30), 
                async () => ai_dialogue_enable(true), 
                async () => await sleep_until(async () => this.dogfight_ph_pilot_go == true), 
                async () => this.dogfight_ph_pilot_go = false, 
                async () => ai_dialogue_enable(false), 
                async () => await sleep(60), 
                async () => print("phantom pilot: 'do you see, arbiter? more heretics have gathered there!'"), 
                async () => await sleep(ai_play_line_on_object(default(IGameObject), "2120")), 
                async () => await sleep(30), 
                async () => ai_dialogue_enable(true));
        }

        [ScriptMethod(358, Lifecycle.CommandScript)]
        public async Task boost_test()
        {
            cs_vehicle_boost(true);
            cs_enable_targeting(true);
            cs_shoot(true);
            cs_enable_moving(true);
            await sleep_until(async () => objects_distance_to_object(players(), ai_get_object(this.ai_current_actor)) < 50F || objects_distance_to_object(ai_actors(allied_phantom_01.Squad), ai_get_object(this.ai_current_actor)) < 50F);
        }

        [ScriptMethod(359, Lifecycle.Dormant)]
        public async Task banshee_fight_saving()
        {
            await sleep_until(async () =>
            {
                await sleep_until(async () => this.try_to_save_now == true);
                await sleep_until(async () => unit_in_vehicle(unit(await this.player0())) && unit_in_vehicle(unit(await this.player1())) || (bool)game_is_cooperative() == false && (bool)game_safe_to_save());
                game_save_immediate();
                this.try_to_save_now = false;
                return this.dogfight_over == true;
            });
        }

        [ScriptMethod(360, Lifecycle.Dormant)]
        public async Task phantom_path_w_orders()
        {
            wake(new ScriptMethodReference(banshee_fight_saving));
            cs_run_command_script(allied_phantom_01.driver, new ScriptMethodReference(abort));
            ai_set_orders(allied_phantom_01.Squad, dog_ph_obj_01);
            wake(new ScriptMethodReference(dogfight_ph_pilot_talk));
            await sleep(30);
            await sleep_until(async () => this.emplace_01_done == true, 30, 4000);
            await sleep_until(async () => (bool)ai_trigger_test("done_fighting", dog_obj_emplaced_01) == true, 30, 2000);
            print("cleared");
            await sleep(150);
            ai_set_orders(allied_phantom_01.Squad, dog_ph_obj_02);
            game_save_no_timeout();
            this.dogfighters_spawned = 0;
            await sleep_until(async () =>
            {
                if (objects_can_see_flag(players(), spawn_pt_03, 90F) == false && (short)ai_living_count(dogfighters_01) < 2)
                {
                    ai_place(dogfight_enemies.pt_03);
                    this.dogfighters_spawned = (short)(this.dogfighters_spawned + 1);
                    ai_set_orders(dogfight_enemies.Squad, dogfight01_cell_02);
                    await sleep(60);
                    ai_magically_see(dogfight_enemies.Squad, allied_phantom_01.Squad);
                    cs_run_command_script(dogfight_enemies.pt_03, new ScriptMethodReference(boost_test));
                }

                if (objects_can_see_flag(players(), spawn_pt_01, 90F) == false && (short)ai_living_count(dogfighters_01) < 2)
                {
                    ai_place(dogfight_enemies.pt_01);
                    this.dogfighters_spawned = (short)(this.dogfighters_spawned + 1);
                    ai_set_orders(dogfight_enemies.Squad, dogfight01_cell_02);
                    await sleep(60);
                    ai_magically_see(dogfight_enemies.Squad, allied_phantom_01.Squad);
                    cs_run_command_script(dogfight_enemies.pt_01, new ScriptMethodReference(boost_test));
                }

                if (objects_can_see_flag(players(), spawn_pt_02, 90F) == false && (short)ai_living_count(dogfighters_01) < 2)
                {
                    ai_place(dogfight_enemies.pt_02);
                    this.dogfighters_spawned = (short)(this.dogfighters_spawned + 1);
                    ai_set_orders(dogfight_enemies.Squad, dogfight01_cell_02);
                    await sleep(60);
                    ai_magically_see(dogfight_enemies.Squad, allied_phantom_01.Squad);
                    cs_run_command_script(dogfight_enemies.pt_02, new ScriptMethodReference(boost_test));
                }

                await sleep_until(async () => volume_test_objects(vol_dog_obj_02, ai_actors(allied_phantom_01.Squad)) == true || (short)ai_living_count(dogfighters_01) < 2);
                return volume_test_objects(vol_dog_obj_02, ai_actors(allied_phantom_01.Squad)) == true || this.dogfighters_spawned > 3;
            }, 30, 4000);
            ai_set_orders(allied_phantom_01.Squad, dog_ph_obj_03);
            game_save_no_timeout();
            this.dogfighters_spawned = 0;
            await sleep_until(async () =>
            {
                if (objects_can_see_flag(players(), spawn_pt_05, 90F) == false && (short)ai_living_count(dogfighters_01) < 2)
                {
                    ai_place(dogfight_enemies.pt_05);
                    this.dogfighters_spawned = (short)(this.dogfighters_spawned + 1);
                    ai_set_orders(dogfight_enemies.Squad, dogfight01_cell_03);
                    await sleep(60);
                    ai_magically_see(dogfight_enemies.Squad, allied_phantom_01.Squad);
                    cs_run_command_script(dogfight_enemies.pt_05, new ScriptMethodReference(boost_test));
                }

                if (objects_can_see_flag(players(), spawn_pt_03, 90F) == false && (short)ai_living_count(dogfighters_01) < 2)
                {
                    ai_place(dogfight_enemies.pt_03);
                    this.dogfighters_spawned = (short)(this.dogfighters_spawned + 1);
                    ai_set_orders(dogfight_enemies.Squad, dogfight01_cell_03);
                    await sleep(60);
                    ai_magically_see(dogfight_enemies.Squad, allied_phantom_01.Squad);
                    cs_run_command_script(dogfight_enemies.pt_03, new ScriptMethodReference(boost_test));
                }

                if (objects_can_see_flag(players(), spawn_pt_04, 90F) == false && (short)ai_living_count(dogfighters_01) < 2)
                {
                    ai_place(dogfight_enemies.pt_04);
                    this.dogfighters_spawned = (short)(this.dogfighters_spawned + 1);
                    ai_set_orders(dogfight_enemies.Squad, dogfight01_cell_03);
                    await sleep(60);
                    ai_magically_see(dogfight_enemies.Squad, allied_phantom_01.Squad);
                    cs_run_command_script(dogfight_enemies.pt_04, new ScriptMethodReference(boost_test));
                }

                await sleep_until(async () => volume_test_objects(vol_dog_obj_03, players()) == true || volume_test_objects(vol_dog_obj_03, ai_actors(allied_phantom_01.Squad)) == true || (short)ai_living_count(dogfighters_01) < 2);
                return volume_test_objects(vol_dog_obj_03, players()) == true || volume_test_objects(vol_dog_obj_03, ai_actors(allied_phantom_01.Squad)) == true || this.dogfighters_spawned > 3;
            }, 30, 4000);
            await sleep(30);
            await sleep_until(async () => this.emplace_03_done == true, 30, 1800);
            await sleep_until(async () => (bool)ai_trigger_test("done_fighting", dog_obj_emplaced_03) == true, 30, 1800);
            print("cleared");
            await sleep(30);
            if (volume_test_objects(vol_dog_obj_04, players()) == false)
            {
                this.dogfight_ph_pilot_go = true;
            }

            ai_set_orders(allied_phantom_01.Squad, dog_ph_obj_04);
            game_save_no_timeout();
            this.dogfighters_spawned = 0;
            await sleep_until(async () =>
            {
                if (objects_can_see_flag(players(), spawn_pt_05, 90F) == false && (short)ai_living_count(dogfighters_01) < 2)
                {
                    ai_place(dogfight_enemies.pt_05);
                    this.dogfighters_spawned = (short)(this.dogfighters_spawned + 1);
                    ai_set_orders(dogfight_enemies.Squad, dogfight01_cell_04);
                    await sleep(60);
                    ai_magically_see(dogfight_enemies.Squad, allied_phantom_01.Squad);
                    cs_run_command_script(dogfight_enemies.pt_05, new ScriptMethodReference(boost_test));
                }

                if (objects_can_see_flag(players(), spawn_pt_06, 90F) == false && (short)ai_living_count(dogfighters_01) < 2)
                {
                    ai_place(dogfight_enemies.pt_06);
                    this.dogfighters_spawned = (short)(this.dogfighters_spawned + 1);
                    ai_set_orders(dogfight_enemies.Squad, dogfight01_cell_04);
                    await sleep(60);
                    ai_magically_see(dogfight_enemies.Squad, allied_phantom_01.Squad);
                    cs_run_command_script(dogfight_enemies.pt_06, new ScriptMethodReference(boost_test));
                }

                if (objects_can_see_flag(players(), spawn_pt_04, 90F) == false && (short)ai_living_count(dogfighters_01) < 2)
                {
                    ai_place(dogfight_enemies.pt_04);
                    this.dogfighters_spawned = (short)(this.dogfighters_spawned + 1);
                    ai_set_orders(dogfight_enemies.Squad, dogfight01_cell_04);
                    await sleep(60);
                    ai_magically_see(dogfight_enemies.Squad, allied_phantom_01.Squad);
                    cs_run_command_script(dogfight_enemies.pt_04, new ScriptMethodReference(boost_test));
                }

                await sleep_until(async () => volume_test_objects(vol_dog_obj_04, players()) == true || volume_test_objects(vol_dog_obj_04, ai_actors(allied_phantom_01.Squad)) == true || (short)ai_living_count(dogfighters_01) < 2);
                return volume_test_objects(vol_dog_obj_04, players()) == true || volume_test_objects(vol_dog_obj_04, ai_actors(allied_phantom_01.Squad)) == true || this.dogfighters_spawned > 3;
            }, 30, 4000);
            await sleep(30);
            await sleep_until(async () => this.emplace_04_done == true, 30, 1800);
            await sleep_until(async () => (bool)ai_trigger_test("done_fighting", dog_obj_emplaced_04) == true, 30, 1800);
            await sleep(60);
            wake(new ScriptMethodReference(dogfight_search_reminder));
            print("cleared");
            await sleep(30);
            ai_set_orders(allied_phantom_01.Squad, dog_ph_obj_06);
            game_save_no_timeout();
            this.dogfighters_spawned = 0;
            await sleep_until(async () =>
            {
                if (objects_can_see_flag(players(), spawn_pt_01, 90F) == false && (short)ai_living_count(dogfighters_01) < 2)
                {
                    ai_place(dogfight_enemies.pt_01);
                    this.dogfighters_spawned = (short)(this.dogfighters_spawned + 1);
                    ai_set_orders(dogfight_enemies.Squad, dogfight01_cell_06);
                    await sleep(60);
                    ai_magically_see(dogfight_enemies.Squad, allied_phantom_01.Squad);
                    cs_run_command_script(dogfight_enemies.pt_01, new ScriptMethodReference(boost_test));
                }

                if (objects_can_see_flag(players(), spawn_pt_06, 90F) == false && (short)ai_living_count(dogfighters_01) < 2)
                {
                    ai_place(dogfight_enemies.pt_06);
                    this.dogfighters_spawned = (short)(this.dogfighters_spawned + 1);
                    ai_set_orders(dogfight_enemies.Squad, dogfight01_cell_06);
                    await sleep(60);
                    ai_magically_see(dogfight_enemies.Squad, allied_phantom_01.Squad);
                    cs_run_command_script(dogfight_enemies.pt_06, new ScriptMethodReference(boost_test));
                }

                if (objects_can_see_flag(players(), spawn_pt_07, 90F) == false && (short)ai_living_count(dogfighters_01) < 2)
                {
                    ai_place(dogfight_enemies.pt_07);
                    this.dogfighters_spawned = (short)(this.dogfighters_spawned + 1);
                    ai_set_orders(dogfight_enemies.Squad, dogfight01_cell_06);
                    await sleep(60);
                    ai_magically_see(dogfight_enemies.Squad, allied_phantom_01.Squad);
                    cs_run_command_script(dogfight_enemies.pt_07, new ScriptMethodReference(boost_test));
                }

                await sleep_until(async () => volume_test_objects(vol_dog_obj_06, players()) == true || volume_test_objects(vol_dog_obj_06, ai_actors(allied_phantom_01.Squad)) == true || (short)ai_living_count(dogfighters_01) < 2);
                return volume_test_objects(vol_dog_obj_06, players()) == true || volume_test_objects(vol_dog_obj_06, ai_actors(allied_phantom_01.Squad)) == true || this.dogfighters_spawned > 3;
            }, 30, 4000);
            await sleep(30);
            await sleep_until(async () => this.emplace_06_done == true, 30, 1800);
            await sleep_until(async () => (bool)ai_trigger_test("done_fighting", dog_obj_emplaced_06) == true, 30, 1800);
            print("cleared");
            await sleep(30);
            if (volume_test_objects(vol_dog_obj_07, players()) == false)
            {
                this.dogfight_ph_pilot_go = true;
            }

            ai_set_orders(allied_phantom_01.Squad, dog_ph_obj_07);
            game_save_no_timeout();
            this.dogfighters_spawned = 0;
            await sleep_until(async () =>
            {
                if (objects_can_see_flag(players(), spawn_pt_08, 90F) == false && (short)ai_living_count(dogfighters_01) < 2)
                {
                    ai_place(dogfight_enemies.pt_08);
                    this.dogfighters_spawned = (short)(this.dogfighters_spawned + 1);
                    ai_set_orders(dogfight_enemies.Squad, dogfight01_cell_07);
                    await sleep(60);
                    ai_magically_see(dogfight_enemies.Squad, allied_phantom_01.Squad);
                    cs_run_command_script(dogfight_enemies.pt_08, new ScriptMethodReference(boost_test));
                }

                if (objects_can_see_flag(players(), spawn_pt_06, 90F) == false && (short)ai_living_count(dogfighters_01) < 2)
                {
                    ai_place(dogfight_enemies.pt_06);
                    this.dogfighters_spawned = (short)(this.dogfighters_spawned + 1);
                    ai_set_orders(dogfight_enemies.Squad, dogfight01_cell_07);
                    await sleep(60);
                    ai_magically_see(dogfight_enemies.Squad, allied_phantom_01.Squad);
                    cs_run_command_script(dogfight_enemies.pt_06, new ScriptMethodReference(boost_test));
                }

                if (objects_can_see_flag(players(), spawn_pt_01, 90F) == false && (short)ai_living_count(dogfighters_01) < 2)
                {
                    ai_place(dogfight_enemies.pt_01);
                    this.dogfighters_spawned = (short)(this.dogfighters_spawned + 1);
                    ai_set_orders(dogfight_enemies.Squad, dogfight01_cell_07);
                    await sleep(60);
                    ai_magically_see(dogfight_enemies.Squad, allied_phantom_01.Squad);
                    cs_run_command_script(dogfight_enemies.pt_01, new ScriptMethodReference(boost_test));
                }

                await sleep_until(async () => volume_test_objects(vol_dog_obj_07, players()) == true || volume_test_objects(vol_dog_obj_07, ai_actors(allied_phantom_01.Squad)) == true || (short)ai_living_count(dogfighters_01) < 2);
                return volume_test_objects(vol_dog_obj_07, players()) == true || volume_test_objects(vol_dog_obj_07, ai_actors(allied_phantom_01.Squad)) == true || this.dogfighters_spawned > 3;
            }, 30, 4000);
        }

        [ScriptMethod(361, Lifecycle.CommandScript)]
        public async Task goto_dog_turret_01l()
        {
            cs_force_combat_status(4);
            cs_enable_pathfinding_failsafe(true);
            cs_go_to_vehicle(ai_vehicle_get_from_starting_location(dog_turrets_01.left));
            ai_vehicle_reserve(ai_vehicle_get_from_starting_location(dog_turrets_01.left), true);
            cs_enable_targeting(true);
            cs_shoot(true);
            cs_set_behavior(guard);
            sleep_forever();
        }

        [ScriptMethod(362, Lifecycle.CommandScript)]
        public async Task goto_dog_turret_01r()
        {
            cs_force_combat_status(4);
            cs_enable_pathfinding_failsafe(true);
            cs_go_to_vehicle(ai_vehicle_get_from_starting_location(dog_turrets_01.right));
            ai_vehicle_reserve(ai_vehicle_get_from_starting_location(dog_turrets_01.right), true);
            cs_enable_targeting(true);
            cs_shoot(true);
            cs_set_behavior(guard);
            sleep_forever();
        }

        [ScriptMethod(363, Lifecycle.CommandScript)]
        public async Task goto_dog_turret_02l()
        {
            cs_force_combat_status(4);
            cs_enable_pathfinding_failsafe(true);
            cs_go_to_vehicle(ai_vehicle_get_from_starting_location(dog_turrets_02.left));
            ai_vehicle_reserve(ai_vehicle_get_from_starting_location(dog_turrets_02.left), true);
            cs_enable_targeting(true);
            cs_shoot(true);
            cs_set_behavior(guard);
            sleep_forever();
        }

        [ScriptMethod(364, Lifecycle.CommandScript)]
        public async Task goto_dog_turret_02r()
        {
            cs_force_combat_status(4);
            cs_enable_pathfinding_failsafe(true);
            cs_go_to_vehicle(ai_vehicle_get_from_starting_location(dog_turrets_02.right));
            ai_vehicle_reserve(ai_vehicle_get_from_starting_location(dog_turrets_02.right), true);
            cs_enable_targeting(true);
            cs_shoot(true);
            cs_set_behavior(guard);
            sleep_forever();
        }

        [ScriptMethod(365, Lifecycle.CommandScript)]
        public async Task goto_dog_turret_03l()
        {
            cs_force_combat_status(4);
            cs_enable_pathfinding_failsafe(true);
            cs_go_to_vehicle(ai_vehicle_get_from_starting_location(dog_turrets_03.left));
            ai_vehicle_reserve(ai_vehicle_get_from_starting_location(dog_turrets_03.left), true);
            cs_enable_targeting(true);
            cs_shoot(true);
            cs_set_behavior(guard);
            sleep_forever();
        }

        [ScriptMethod(366, Lifecycle.CommandScript)]
        public async Task goto_dog_turret_03r()
        {
            cs_force_combat_status(4);
            cs_enable_pathfinding_failsafe(true);
            cs_go_to_vehicle(ai_vehicle_get_from_starting_location(dog_turrets_03.right));
            ai_vehicle_reserve(ai_vehicle_get_from_starting_location(dog_turrets_03.right), true);
            cs_enable_targeting(true);
            cs_shoot(true);
            cs_set_behavior(guard);
            sleep_forever();
        }

        [ScriptMethod(367, Lifecycle.CommandScript)]
        public async Task goto_dog_turret_04l()
        {
            cs_force_combat_status(4);
            cs_enable_pathfinding_failsafe(true);
            cs_go_to_vehicle(ai_vehicle_get_from_starting_location(dog_turrets_04.left));
            ai_vehicle_reserve(ai_vehicle_get_from_starting_location(dog_turrets_04.left), true);
            cs_enable_targeting(true);
            cs_shoot(true);
            cs_set_behavior(guard);
            sleep_forever();
        }

        [ScriptMethod(368, Lifecycle.CommandScript)]
        public async Task goto_dog_turret_04r()
        {
            cs_force_combat_status(4);
            cs_enable_pathfinding_failsafe(true);
            cs_go_to_vehicle(ai_vehicle_get_from_starting_location(dog_turrets_04.right));
            ai_vehicle_reserve(ai_vehicle_get_from_starting_location(dog_turrets_04.right), true);
            cs_enable_targeting(true);
            cs_shoot(true);
            cs_set_behavior(guard);
            sleep_forever();
        }

        [ScriptMethod(369, Lifecycle.CommandScript)]
        public async Task goto_dog_turret_06l()
        {
            cs_force_combat_status(4);
            cs_enable_pathfinding_failsafe(true);
            cs_go_to_vehicle(ai_vehicle_get_from_starting_location(dog_turrets_06.left));
            ai_vehicle_reserve(ai_vehicle_get_from_starting_location(dog_turrets_06.left), true);
            cs_enable_targeting(true);
            cs_shoot(true);
            cs_set_behavior(guard);
            sleep_forever();
        }

        [ScriptMethod(370, Lifecycle.CommandScript)]
        public async Task goto_dog_turret_06r()
        {
            cs_force_combat_status(4);
            cs_enable_pathfinding_failsafe(true);
            cs_go_to_vehicle(ai_vehicle_get_from_starting_location(dog_turrets_06.right));
            ai_vehicle_reserve(ai_vehicle_get_from_starting_location(dog_turrets_06.right), true);
            cs_enable_targeting(true);
            cs_shoot(true);
            cs_set_behavior(guard);
            sleep_forever();
        }

        [ScriptMethod(371, Lifecycle.CommandScript)]
        public async Task lz_turret_01()
        {
            cs_force_combat_status(4);
            cs_enable_pathfinding_failsafe(true);
            cs_go_to_vehicle(ai_vehicle_get_from_starting_location(dog_turrets_07._01));
            ai_vehicle_reserve(ai_vehicle_get_from_starting_location(dog_turrets_07._01), true);
            cs_enable_targeting(true);
            cs_shoot(true);
            cs_set_behavior(guard);
            sleep_forever();
        }

        [ScriptMethod(372, Lifecycle.CommandScript)]
        public async Task lz_turret_02()
        {
            cs_force_combat_status(4);
            cs_enable_pathfinding_failsafe(true);
            cs_go_to_vehicle(ai_vehicle_get_from_starting_location(dog_turrets_07._02));
            ai_vehicle_reserve(ai_vehicle_get_from_starting_location(dog_turrets_07._02), true);
            cs_enable_targeting(true);
            cs_shoot(true);
            cs_set_behavior(guard);
            sleep_forever();
        }

        [ScriptMethod(373, Lifecycle.CommandScript)]
        public async Task lz_turret_03()
        {
            cs_force_combat_status(4);
            cs_enable_pathfinding_failsafe(true);
            cs_go_to_vehicle(ai_vehicle_get_from_starting_location(dog_turrets_07._03));
            ai_vehicle_reserve(ai_vehicle_get_from_starting_location(dog_turrets_07._03), true);
            cs_enable_targeting(true);
            cs_shoot(true);
            cs_set_behavior(guard);
            sleep_forever();
        }

        [ScriptMethod(374, Lifecycle.CommandScript)]
        public async Task lz_turret_04()
        {
            cs_force_combat_status(4);
            cs_enable_pathfinding_failsafe(true);
            cs_go_to_vehicle(ai_vehicle_get_from_starting_location(dog_turrets_07._04));
            ai_vehicle_reserve(ai_vehicle_get_from_starting_location(dog_turrets_07._04), true);
            cs_enable_targeting(true);
            cs_shoot(true);
            cs_set_behavior(guard);
            sleep_forever();
        }

        [ScriptMethod(375, Lifecycle.Dormant)]
        public async Task near_dog_obj_01()
        {
            ai_place(dog_turret_men_01.Squad);
            cs_run_command_script(dog_turret_men_01.left, new ScriptMethodReference(goto_dog_turret_01l));
            cs_run_command_script(dog_turret_men_01.right, new ScriptMethodReference(goto_dog_turret_01r));
            await sleep_until(async () =>
            {
                if (objects_can_see_flag(players(), spawn_pt_08, 60F) == false && (short)ai_living_count(dogfighters_01) < 2)
                {
                    ai_place(dogfight_enemies.pt_08);
                    ai_set_orders(dogfight_enemies.Squad, dogfight01_cell_01);
                    ai_magically_see(dogfight_enemies.Squad, allied_phantom_01.Squad);
                    cs_run_command_script(dogfight_enemies.pt_08, new ScriptMethodReference(boost_test));
                }

                if (objects_can_see_flag(players(), spawn_pt_02, 60F) == false && (short)ai_living_count(dogfighters_01) < 2)
                {
                    ai_place(dogfight_enemies.pt_02);
                    ai_set_orders(dogfight_enemies.Squad, dogfight01_cell_01);
                    ai_magically_see(dogfight_enemies.Squad, allied_phantom_01.Squad);
                    cs_run_command_script(dogfight_enemies.pt_02, new ScriptMethodReference(boost_test));
                }

                if (objects_can_see_flag(players(), spawn_pt_01, 60F) == false && (short)ai_living_count(dogfighters_01) < 2)
                {
                    ai_place(dogfight_enemies.pt_01);
                    ai_set_orders(dogfight_enemies.Squad, dogfight01_cell_01);
                    ai_magically_see(dogfight_enemies.Squad, allied_phantom_01.Squad);
                    cs_run_command_script(dogfight_enemies.pt_01, new ScriptMethodReference(boost_test));
                }

                await sleep_until(async () => objects_distance_to_flag(players(), banshee_intro) > 75F || (short)ai_living_count(dogfighters_01) < 2 || (short)ai_spawn_count(dogfighters_01) > 2);
                return objects_distance_to_flag(players(), banshee_intro) > 75F || (short)ai_spawn_count(dogfighters_01) > 2;
            });
            await sleep_until(async () => (short)ai_living_count(dog_obj_emplaced_01) < 1 && (short)ai_living_count(dogfighters_01) < 1);
            this.emplace_01_done = true;
            game_save_no_timeout();
        }

        [ScriptMethod(376, Lifecycle.Dormant)]
        public async Task near_dog_obj_02()
        {
            await sleep_until(async () => volume_test_objects(vol_dog_obj_02, players()) == true || volume_test_objects(vol_dog_obj_02, ai_actors(allied_phantom_01.Squad)) == true);
            ai_place(dog_turret_men_02.Squad);
            cs_run_command_script(dog_turret_men_02.left, new ScriptMethodReference(goto_dog_turret_02l));
            cs_run_command_script(dog_turret_men_02.right, new ScriptMethodReference(goto_dog_turret_02r));
            await sleep_until(async () => (short)ai_living_count(dog_turret_men_02.Squad) < 2);
            ai_place(dog_flak_02.Squad, 2);
            await sleep_until(async () => (short)ai_living_count(dog_flak_02.Squad) < 2);
            ai_place(dog_flak_02.Squad, 2);
            await sleep_until(async () => (short)ai_living_count(dog_obj_emplaced_02) < 1);
            this.emplace_02_done = true;
            game_save_no_timeout();
        }

        [ScriptMethod(377, Lifecycle.Dormant)]
        public async Task near_dog_obj_03()
        {
            await sleep_until(async () => volume_test_objects(vol_dog_obj_03, players()) == true || volume_test_objects(vol_dog_obj_03, ai_actors(allied_phantom_01.Squad)) == true);
            ai_place(dog_turret_men_03.Squad);
            await sleep_until(async () =>
            {
                ai_place(dog_turret_men_03.Squad, 1);
                await sleep(60);
                await sleep_until(async () => (short)ai_living_count(dog_turret_men_03.Squad) < 2);
                return (short)ai_spawn_count(dog_turret_men_03.Squad) > 3;
            });
            await sleep_until(async () => (short)ai_living_count(dog_obj_emplaced_03) < 1);
            this.emplace_03_done = true;
            game_save_no_timeout();
        }

        [ScriptMethod(378, Lifecycle.Dormant)]
        public async Task near_dog_obj_04()
        {
            await sleep_until(async () => volume_test_objects(vol_dog_obj_04, players()) == true || volume_test_objects(vol_dog_obj_04, ai_actors(allied_phantom_01.Squad)) == true);
            ai_place(dog_flak_04.Squad);
            ai_place(dog_turret_men_04.Squad);
            cs_run_command_script(dog_turret_men_04.left, new ScriptMethodReference(goto_dog_turret_04l));
            cs_run_command_script(dog_turret_men_04.right, new ScriptMethodReference(goto_dog_turret_04r));
            await sleep_until(async () => (short)ai_living_count(dog_obj_emplaced_04) < 1);
            this.emplace_04_done = true;
            game_save_no_timeout();
        }

        [ScriptMethod(379, Lifecycle.Dormant)]
        public async Task near_dog_obj_05()
        {
            await sleep_until(async () => volume_test_objects(vol_dog_obj_05, players()) == true || volume_test_objects(vol_dog_obj_05, ai_actors(allied_phantom_01.Squad)) == true);
            await sleep_until(async () =>
            {
                ai_place(dog_sen_05.Squad, 1);
                await sleep(15);
                await sleep_until(async () => (short)ai_living_count(dog_sen_05.Squad) < 4);
                return (short)ai_spawn_count(dog_sen_05.Squad) == 8;
            });
            await sleep_until(async () => (short)ai_living_count(dog_obj_emplaced_05) < 1);
            this.emplace_05_done = true;
            game_save_no_timeout();
        }

        [ScriptMethod(380, Lifecycle.Dormant)]
        public async Task near_dog_obj_06()
        {
            await sleep_until(async () => volume_test_objects(vol_dog_obj_06, players()) == true || volume_test_objects(vol_dog_obj_06, ai_actors(allied_phantom_01.Squad)) == true);
            ai_place(dog_turret_men_06.Squad);
            await sleep_until(async () =>
            {
                ai_place(dog_turret_men_06.Squad, 1);
                await sleep(60);
                await sleep_until(async () => (short)ai_living_count(dog_turret_men_06.Squad) < 2);
                return (short)ai_spawn_count(dog_turret_men_06.Squad) > 3;
            });
            await sleep_until(async () => (short)ai_living_count(dog_obj_emplaced_06) < 1);
            this.emplace_06_done = true;
            game_save_no_timeout();
        }

        [ScriptMethod(381, Lifecycle.Dormant)]
        public async Task final_dogfight_reminder()
        {
            await sleep_until(async () => (short)ai_living_count(dog_turrets_07.Squad) > 0);
            await sleep_until(async () => (short)ai_living_count(dog_turrets_07.Squad) < 1, 30, 3600);
            if ((short)ai_living_count(dog_turrets_07.Squad) > 0)
            {
                ai_dialogue_enable(false);
                await sleep(60);
                print("spec-ops commander: 'take out those turrets, and get after the heretic-leader!'");
                await sleep(ai_play_line_on_object(default(IGameObject), "1220"));
                await sleep(30);
                ai_dialogue_enable(true);
            }
        }

        [ScriptMethod(382, Lifecycle.Dormant)]
        public async Task ally_final_run()
        {
            ai_set_orders(allied_phantom_01.Squad, dog_ph_obj_park);
            ai_place(allies_elites_03.Squad, 2);
            ai_place(allies_grunts_03.Squad, 2);
            await sleep(60);
            vehicle_load_magic(ai_vehicle_get_from_starting_location(allied_phantom_01.driver), "phantom_p_a", ai_actors(allies_elites_03.Squad));
            vehicle_load_magic(ai_vehicle_get_from_starting_location(allied_phantom_01.driver), "phantom_p_b", ai_actors(allies_grunts_03.Squad));
            await sleep_until(async () => volume_test_objects(vol_arm02_air, ai_actors(allied_phantom_01.Squad)) == true);
            cs_run_command_script(allied_phantom_01.driver, new ScriptMethodReference(arm02_final_approach));
        }

        [ScriptMethod(383, Lifecycle.Dormant)]
        public async Task near_dog_obj_07()
        {
            await sleep_until(async () => volume_test_objects(vol_dog_obj_07, players()) == true || volume_test_objects(vol_dog_obj_07, ai_actors(allied_phantom_01.Squad)) == true);
            object_create(hl_banshee);
            ai_place(dog_turret_men_07.Squad);
            await sleep(2);
            ai_enter_squad_vehicles(dog_07_turrets);
            await sleep(2);
            ai_place(dog_flak_07.Squad);
            ai_dialogue_enable(false);
            await sleep(60);
            print("spec-ops commander: 'we've tracked the heretic leader to this part of the station.'");
            await sleep(ai_play_line_on_object(default(IGameObject), "0530"));
            await sleep(30);
            print("spec-ops commander: 'clear that landing-zone, and get inside!'");
            await sleep(ai_play_line_on_object(default(IGameObject), "0540"));
            await sleep(30);
            ai_dialogue_enable(true);
            wake(new ScriptMethodReference(final_dogfight_reminder));
            game_save_no_timeout();
            await sleep_until(async () => (short)ai_living_count(dog_obj_emplaced_07) < 3, 30, 4000);
            wake(new ScriptMethodReference(ally_final_run));
            if (volume_test_objects(vol_arm_02_lz, players()) == false && await this.player_count() > 0)
            {
                ai_place(arm02_final_heretics.Squad, 2);
                ai_place(arm02_final_grunts.Squad, 2);
            }

            await sleep_until(async () => (float)ai_living_count(arm02_final_heretics.Squad) + (float)ai_living_count(arm02_final_heretics.Squad) < 1F, 30, 3600);
            await sleep_until(async () => (bool)ai_trigger_test("done_fighting", dog_obj_emplaced_07) == true, 30, 1800);
            this.dogfight_over = true;
        }

        [ScriptMethod(384, Lifecycle.Dormant)]
        public async Task dogfight_flak_warn()
        {
            ai_dialogue_enable(false);
            await sleep(60);
            print("spec-ops commander: 'look sharp, arbiter! they're putting-up heavy flak!'");
            await sleep(ai_play_line_on_object(default(IGameObject), "1200"));
            await sleep(30);
            ai_dialogue_enable(true);
        }

        [ScriptMethod(385, Lifecycle.Dormant)]
        public async Task dogfight_objectives()
        {
            ai_dialogue_enable(false);
            await sleep(60);
            print("phantom pilot: 'the heretics have weapon-emplacements all over the facility, arbiter.'");
            print("'we'll take them out, one-by-one, until we find the heretic-leader!'");
            await sleep(ai_play_line_on_object(default(IGameObject), "2040"));
            await sleep(30);
            ai_dialogue_enable(true);
        }

        [ScriptMethod(386, Lifecycle.Dormant)]
        public async Task dogfight_nav_swap()
        {
            await sleep_until(async () => (short)ai_living_count(allied_phantom_01.Squad) < 1 || volume_test_objects(vol_dog_obj_07, players()) == true || volume_test_objects(vol_dog_obj_07, ai_actors(allied_phantom_01.Squad)) == true, 30, 24000);
            activate_team_nav_point_object(_default, player, arm_02_entry_ext.Entity, 0F);
        }

        [ScriptMethod(387, Lifecycle.Dormant)]
        public async Task always_get_banshee_01()
        {
            await sleep_until(async () =>
            {
                await sleep_until(async () => objects_distance_to_flag(players(), _01a) > 50F && objects_distance_to_flag(players(), _01b) > 50F && objects_can_see_flag(players(), _01a, 45F) == false && objects_can_see_flag(players(), _01b, 45F) == false && volume_test_object(vol_stuck_01, mid_banshee_01.Entity) == false || volume_test_object(vol_stuck_01, mid_banshee_02.Entity) == false);
                await sleep_until(async () =>
                {
                    object_destroy(list_get(volume_return_objects_by_type(vol_stuck_01, 2), 0));
                    return list_count_not_dead(volume_return_objects_by_type(vol_stuck_01, 2)) == 0;
                });
                object_create_clone(mid_banshee_01);
                object_create_clone(mid_banshee_02);
                return false;
            });
        }

        [ScriptMethod(388, Lifecycle.Dormant)]
        public async Task always_get_banshee_02()
        {
            await sleep_until(async () =>
            {
                await sleep_until(async () => objects_distance_to_flag(players(), _10a) > 50F && objects_distance_to_flag(players(), _10b) > 50F && objects_can_see_flag(players(), _10a, 45F) == false && objects_can_see_flag(players(), _10b, 45F) == false && volume_test_object(vol_stuck_10, ai_vehicle_get_from_starting_location(ledge_banshees_01.left)) == false || volume_test_object(vol_stuck_10, ai_vehicle_get_from_starting_location(ledge_banshees_01.right)) == false);
                await sleep_until(async () =>
                {
                    object_destroy(list_get(volume_return_objects_by_type(vol_stuck_10, 2), 0));
                    return list_count_not_dead(volume_return_objects_by_type(vol_stuck_10, 2)) == 0;
                });
                ai_place(ledge_banshees_01.left);
                ai_place(ledge_banshees_01.right);
                return false;
            });
        }

        [ScriptMethod(389, Lifecycle.Dormant)]
        public async Task dogfight_firsttime_start()
        {
            data_mine_set_mission_segment("04a_9_dogfight");
            sound_class_set_gain("ambient_machinery", 0.1F, 3);
            sound_class_set_gain("ambient_nature", 0.15F, 3);
            sound_class_set_gain("vehicle_engine", 0.8F, 3);
            sound_class_set_gain("weapon_fire", 0.8F, 3);
            sound_class_set_gain("weapon_fire_lod", 0.8F, 3);
            sound_class_set_gain("projectile_detonation", 0.8F, 3);
            game_save();
            if (await this.difficulty_legendary())
            {
                wake(new ScriptMethodReference(grunt_birthday_party));
            }

            kill_volume_disable(kill_banshee_ledge);
            wake(new ScriptMethodReference(banshee_stuck_spawner_01));
            if ((bool)game_is_cooperative() == true)
            {
                wake(new ScriptMethodReference(banshee_stuck_spawner_02));
            }

            activate_team_nav_point_object(_default, player, list_get(ai_actors(allied_phantom_01.Squad), 0), 3F);
            ai_place(dogfight_initial_enemies.Squad, 2);
            ai_place(dog_turrets_04.Squad);
            ai_place(dog_turrets_07.Squad);
            wake(new ScriptMethodReference(near_dog_obj_01));
            wake(new ScriptMethodReference(near_dog_obj_03));
            wake(new ScriptMethodReference(near_dog_obj_04));
            wake(new ScriptMethodReference(near_dog_obj_06));
            wake(new ScriptMethodReference(near_dog_obj_07));
            wake(new ScriptMethodReference(phantom_path_w_orders));
            wake(new ScriptMethodReference(dogfight_nav_swap));
            object_create_containing("mid_banshee_0");
            wake(new ScriptMethodReference(always_get_banshee_01));
            wake(new ScriptMethodReference(always_get_banshee_02));
            await sleep(5);
            wake(new ScriptMethodReference(music_04a_04_start));
            wake(new ScriptMethodReference(music_04a_04_stop));
            await sleep_until(async () => (short)ai_living_count(dogfight_initial_enemies.Squad) < 1 && this.emplace_01_done == true);
            await sleep(60);
            await sleep(30);
            wake(new ScriptMethodReference(dogfight_objectives));
        }

        [ScriptMethod(390, Lifecycle.Dormant)]
        public async Task arm_02_entry_win()
        {
            await sleep_until(async () => volume_test_objects(vol_04a_game_won, players()) == true || this.dogfight_over == true && volume_test_object(vol_real_win, await this.player0()) == true && unit_in_vehicle(await this.player0()) == false || this.dogfight_over == true && volume_test_object(vol_real_win, await this.player1()) == true && unit_in_vehicle(await this.player1()) == false);
            await this.playtest_mission();
            await sleep(30);
            sound_class_set_gain("", 0F, 15);
            await this.cinematic_fade_to_white();
            await sleep(30);
            game_won();
        }

        [ScriptMethod(391, Lifecycle.Static)]
        public async Task sleep_intro()
        {
            sleep_forever(new ScriptMethodReference(swat_deploy));
            sleep_forever(new ScriptMethodReference(commander_entry_reminder));
            sleep_forever(new ScriptMethodReference(wind));
        }

        [ScriptMethod(392, Lifecycle.Static)]
        public async Task sleep_rec_center()
        {
            sleep_forever(new ScriptMethodReference(production_arm_bsp_swap));
            sleep_forever(new ScriptMethodReference(recycling_center_start));
            sleep_forever(new ScriptMethodReference(recycling_can_spawner));
            sleep_forever(new ScriptMethodReference(recycling_killer_new));
            sleep_forever(new ScriptMethodReference(heretic_uplink_01));
            sleep_forever(new ScriptMethodReference(rec_center_reminder));
            ai_disposable(rec_center_heretics, true);
        }

        [ScriptMethod(393, Lifecycle.Static)]
        public async Task sleep_hangar()
        {
            sleep_forever(new ScriptMethodReference(hangar_firsttime_start));
            sleep_forever(new ScriptMethodReference(hangar_can_spawner));
            sleep_forever(new ScriptMethodReference(hangar_killer_new));
            sleep_forever(new ScriptMethodReference(hangar_allies_reinforce));
            sleep_forever(new ScriptMethodReference(hangar_helpers));
            sleep_forever(new ScriptMethodReference(hangar_sentinels_flitting));
            sleep_forever(new ScriptMethodReference(hangar_door_monitor));
            sleep_forever(new ScriptMethodReference(hangar_door_reminder));
            sleep_forever(new ScriptMethodReference(hangar_alerted_call));
            sleep_forever(new ScriptMethodReference(hangar_exit_warn));
            sleep_forever(new ScriptMethodReference(hangar_reminder));
            sleep_forever(new ScriptMethodReference(hangar_exterior_toggle));
        }

        [ScriptMethod(394, Lifecycle.Static)]
        public async Task sleep_first_halls()
        {
            sleep_forever(new ScriptMethodReference(to_underhangar_firsttime));
            sleep_forever(new ScriptMethodReference(first_hall_reinforce));
        }

        [ScriptMethod(395, Lifecycle.Static)]
        public async Task sleep_underhangar()
        {
            sleep_forever(new ScriptMethodReference(underhangar_firsttime_start));
            sleep_forever(new ScriptMethodReference(underhangar_can_spawner));
            sleep_forever(new ScriptMethodReference(underhangar_killer_new));
            sleep_forever(new ScriptMethodReference(new_allies_02));
            sleep_forever(new ScriptMethodReference(underhangar_reinforce));
            sleep_forever(new ScriptMethodReference(underhangar_reminder));
        }

        [ScriptMethod(396, Lifecycle.Static)]
        public async Task sleep_second_halls()
        {
            sleep_forever(new ScriptMethodReference(to_bottling));
            sleep_forever(new ScriptMethodReference(second_hall_reinforce_01));
            sleep_forever(new ScriptMethodReference(second_hall_reinforce_02));
            sleep_forever(new ScriptMethodReference(second_hall_reinforce_03));
        }

        [ScriptMethod(397, Lifecycle.Static)]
        public async Task sleep_bottling()
        {
            sleep_forever(new ScriptMethodReference(bottling_firsttime_start));
            sleep_forever(new ScriptMethodReference(bottling_can_spawner));
            sleep_forever(new ScriptMethodReference(bottling_killer_new));
            sleep_forever(new ScriptMethodReference(bottling_overlook_reinforce));
            sleep_forever(new ScriptMethodReference(active_camo_drop));
            sleep_forever(new ScriptMethodReference(new_allies_03));
            ai_disposable(hangar_heretics, true);
            ai_disposable(hangar_sentinels, true);
            ai_disposable(first_hall_heretics, true);
            ai_disposable(underhangar_heretics, true);
            ai_disposable(second_hall_heretics, true);
            ai_disposable(bottling_enemies, true);
        }

        [ScriptMethod(398, Lifecycle.Startup)]
        public async Task mission()
        {
            await this.cinematic_snap_to_white();
            if (volume_test_objects(vol_starting_locations, players()) == true)
            {
                sound_suppress_ambience_update_on_revert();
                if (await this.cinematic_skip_start())
                {
                    await this.x04();
                }

                await this.cinematic_skip_stop();
                if (await this.cinematic_skip_start())
                {
                    await this.c04_intro();
                }

                await this.cinematic_skip_stop();
            }

            await sleep(2);
            switch_bsp(0);
            await sleep(2);
            ai_allegiance(player, covenant);
            ai_allegiance(sentinel, heretic);
            ai_allegiance(heretic, sentinel);
            objectives_clear();
            game_save_immediate();
            await this.prep_return_from_intro();
            camera_control(false);
            await sleep(1);
            await cache_block_for_one_frame();
            await sleep(1);
            wake(new ScriptMethodReference(_04a_title0));
            wake(new ScriptMethodReference(objective_hl_set));
            wake(new ScriptMethodReference(swat_deploy));
            wake(new ScriptMethodReference(recycling_center_start));
            wake(new ScriptMethodReference(kill_volumes));
            await sleep_until(async () => volume_test_objects(vol_on_hangar_lift_top, players()) == true || volume_test_objects(vol_on_hangar_lift_top, ai_actors(all_allies)) == true);
            wake(new ScriptMethodReference(hangar_firsttime_start));
            wake(new ScriptMethodReference(to_underhangar_firsttime));
            await this.sleep_intro();
            device_one_sided_set(rec_center_entry_ext.Entity, true);
            device_one_sided_set(rec_center_entry_int.Entity, true);
            await sleep_until(async () => volume_test_objects(vol_underhangar_from_top, players()) == true);
            wake(new ScriptMethodReference(underhangar_firsttime_start));
            wake(new ScriptMethodReference(to_bottling));
            await this.sleep_rec_center();
            await this.sleep_hangar();
            this.recycling_power_on = false;
            this.hangar_power_on = false;
            device_one_sided_set(hangar_exit.Entity, true);
            await sleep_until(async () => (short)structure_bsp_index() == 0);
            wake(new ScriptMethodReference(bottling_firsttime_start));
            wake(new ScriptMethodReference(bottling_plant_end));
            await this.sleep_first_halls();
            await this.sleep_underhangar();
            this.underhangar_power_on = false;
            device_one_sided_set(underhangar_entry.Entity, true);
            device_one_sided_set(underhangar_exit.Entity, true);
            await sleep_until(async () => vehicle_test_seat(ai_vehicle_get_from_starting_location(ledge_banshees_01.left), "banshee_d", unit(await this.player0())) == true || vehicle_test_seat(ai_vehicle_get_from_starting_location(ledge_banshees_01.right), "banshee_d", unit(await this.player0())) == true || vehicle_test_seat(ai_vehicle_get_from_starting_location(ledge_banshees_01.left), "banshee_d", unit(await this.player1())) == true || vehicle_test_seat(ai_vehicle_get_from_starting_location(ledge_banshees_01.right), "banshee_d", unit(await this.player1())) == true);
            wake(new ScriptMethodReference(dogfight_firsttime_start));
            wake(new ScriptMethodReference(arm_02_entry_win));
            await this.sleep_second_halls();
            await this.sleep_bottling();
            this.bottling_power_on = false;
            device_operates_automatically_set(rec_center_entry_ext.Entity, false);
            device_one_sided_set(bottling_entry.Entity, true);
            device_one_sided_set(bottling_midway.Entity, true);
            device_one_sided_set(viewroom_entry.Entity, true);
            wake(new ScriptMethodReference(objective_hl_clear));
            wake(new ScriptMethodReference(objective_dogfight_set));
            await sleep_until(async () => unit_in_vehicle(await this.player0()) && unit_in_vehicle(await this.player1()) || unit_in_vehicle(await this.player0()) && (bool)game_is_cooperative() == false);
        }

        [ScriptMethod(399, Lifecycle.Dormant)]
        public async Task x04_01_predict()
        {
            await sleep(30);
            await sleep(1);
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
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\07a_highcharity\\high_4_cinematic"), 38, false);
            await sleep(2);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\07a_highcharity\\high_4_cinematic"), 53, false);
            predict_model_section(GetTag<RenderModelTag>("objects\\characters\\jackal\\jackal", 3842507666U), 8);
            predict_model_section(GetTag<RenderModelTag>("objects\\characters\\brute\\brute", 3845129146U), 26);
            predict_model_section(GetTag<RenderModelTag>("objects\\characters\\brute\\brute", 3845129146U), 28);
            predict_model_section(GetTag<RenderModelTag>("objects\\characters\\brute\\brute", 3845129146U), 29);
            predict_model_section(GetTag<RenderModelTag>("objects\\characters\\brute\\brute", 3845129146U), 40);
            predict_model_section(GetTag<RenderModelTag>("objects\\characters\\brute\\brute", 3845129146U), 36);
            predict_model_section(GetTag<RenderModelTag>("objects\\characters\\brute\\brute", 3845129146U), 37);
            predict_model_section(GetTag<RenderModelTag>("objects\\characters\\brute\\brute", 3845129146U), 33);
            predict_model_section(GetTag<RenderModelTag>("objects\\characters\\brute\\brute", 3845129146U), 35);
            predict_model_section(GetTag<RenderModelTag>("objects\\characters\\brute\\brute", 3845129146U), 34);
            predict_model_section(GetTag<RenderModelTag>("objects\\characters\\dervish\\dervish", 3847947237U), 11);
            predict_model_section(GetTag<RenderModelTag>("objects\\characters\\dervish\\dervish", 3847947237U), 9);
            predict_model_section(GetTag<RenderModelTag>("objects\\characters\\dervish\\dervish", 3847947237U), 13);
            predict_model_section(GetTag<RenderModelTag>("objects\\weapons\\melee\\gravity_hammer\\gravity_hammer", 3849716736U), 0);
            predict_model_section(GetTag<RenderModelTag>("scenarios\\objects\\cinematics\\cinematic_anchor\\cinematic_anchor", 3850175495U), 0);
            await sleep(101);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\07a_highcharity\\high_4_cinematic"), 65, false);
            await sleep(86);
            predict_model_section(GetTag<RenderModelTag>("objects\\characters\\brute\\brute", 3845129146U), 35);
            predict_model_section(GetTag<RenderModelTag>("objects\\characters\\brute\\brute", 3845129146U), 34);
            predict_model_section(GetTag<RenderModelTag>("objects\\weapons\\melee\\gravity_hammer\\gravity_hammer", 3849716736U), 0);
            await sleep(51);
            predict_model_section(GetTag<RenderModelTag>("scenarios\\objects\\solo\\highcharity\\jail_door\\jail_door", 3850568717U), 0);
            await sleep(3);
            predict_model_section(GetTag<RenderModelTag>("objects\\characters\\jackal\\jackal", 3842507666U), 8);
            await sleep(2);
            predict_model_section(GetTag<RenderModelTag>("scenarios\\objects\\solo\\highcharity\\high_door_grand\\high_door_grand", 3851093013U), 0);
            await sleep(33);
            predict_model_section(GetTag<RenderModelTag>("objects\\characters\\brute\\brute", 3845129146U), 28);
            predict_model_section(GetTag<RenderModelTag>("objects\\characters\\brute\\brute", 3845129146U), 40);
            await sleep(19);
            predict_model_section(GetTag<RenderModelTag>("objects\\characters\\dervish\\dervish", 3847947237U), 11);
            predict_model_section(GetTag<RenderModelTag>("objects\\characters\\dervish\\dervish", 3847947237U), 9);
            predict_model_section(GetTag<RenderModelTag>("objects\\characters\\dervish\\dervish", 3847947237U), 13);
            await sleep(4);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\07a_highcharity\\high_4_cinematic"), 53, false);
            await sleep(141);
            predict_model_section(GetTag<RenderModelTag>("objects\\characters\\jackal\\jackal", 3842507666U), 8);
            await sleep(6);
            predict_model_section(GetTag<RenderModelTag>("scenarios\\objects\\solo\\highcharity\\high_door_grand\\high_door_grand", 3851093013U), 0);
            await sleep(350);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\07a_highcharity\\high_4_cinematic"), 53, false);
        }

        [ScriptMethod(400, Lifecycle.Dormant)]
        public async Task x04_02a_predict()
        {
            await sleep(30);
            await sleep(203);
            predict_model_section(GetTag<RenderModelTag>("scenarios\\objects\\solo\\highcharity\\high_door_grand\\high_door_grand", 3851093013U), 0);
            predict_model_section(GetTag<RenderModelTag>("scenarios\\objects\\covenant\\residential\\holo_switches\\holo_switch_a\\holo_switch_a", 3852403753U), 0);
            await sleep(91);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\07a_highcharity\\high_4_cinematic"), 53, false);
            predict_model_section(GetTag<RenderModelTag>("objects\\characters\\dervish\\dervish", 3847947237U), 11);
            predict_model_section(GetTag<RenderModelTag>("objects\\characters\\dervish\\dervish", 3847947237U), 9);
            predict_model_section(GetTag<RenderModelTag>("objects\\characters\\dervish\\dervish", 3847947237U), 13);
            predict_model_section(GetTag<RenderModelTag>("objects\\characters\\jackal\\jackal", 3842507666U), 8);
            await sleep(164);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\07a_highcharity\\high_4_cinematic"), 34, false);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\07a_highcharity\\high_4_cinematic"), 31, false);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\07a_highcharity\\high_4_cinematic"), 61, false);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\07a_highcharity\\high_4_cinematic"), 1, false);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\07a_highcharity\\high_4_cinematic"), 47, false);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\07a_highcharity\\high_4_cinematic"), 21, false);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\07a_highcharity\\high_4_cinematic"), 26, false);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\07a_highcharity\\high_4_cinematic"), 15, true);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\07a_highcharity\\high_4_cinematic"), 16, true);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\07a_highcharity\\high_4_cinematic"), 17, true);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\07a_highcharity\\high_4_cinematic"), 23, true);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\07a_highcharity\\high_4_cinematic"), 43, false);
            await sleep(41);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\07a_highcharity\\high_4_cinematic"), 63, false);
        }

        [ScriptMethod(401, Lifecycle.Dormant)]
        public async Task x04_02b_predict()
        {
            await sleep(30);
            await sleep(4);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\07a_highcharity\\high_4_cinematic"), 53, false);
            predict_model_section(GetTag<RenderModelTag>("objects\\characters\\dervish\\dervish", 3847947237U), 11);
            predict_model_section(GetTag<RenderModelTag>("objects\\characters\\dervish\\dervish", 3847947237U), 9);
            predict_model_section(GetTag<RenderModelTag>("objects\\characters\\dervish\\dervish", 3847947237U), 13);
            predict_model_section(GetTag<RenderModelTag>("scenarios\\objects\\solo\\highcharity\\high_jail_ledge\\high_jail_ledge", 3852862512U), 0);
            predict_model_section(GetTag<RenderModelTag>("objects\\characters\\jackal\\jackal", 3842507666U), 8);
            await sleep(139);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\07a_highcharity\\high_4_cinematic"), 31, false);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\07a_highcharity\\high_4_cinematic"), 61, false);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\07a_highcharity\\high_4_cinematic"), 32, false);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\07a_highcharity\\high_4_cinematic"), 49, false);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\07a_highcharity\\high_4_cinematic"), 47, false);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\07a_highcharity\\high_4_cinematic"), 63, false);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\07a_highcharity\\high_4_cinematic"), 21, false);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\07a_highcharity\\high_4_cinematic"), 3, false);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\07a_highcharity\\high_4_cinematic"), 50, false);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\07a_highcharity\\high_4_cinematic"), 26, false);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\07a_highcharity\\high_4_cinematic"), 2, false);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\07a_highcharity\\high_4_cinematic"), 20, false);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\07a_highcharity\\high_4_cinematic"), 45, false);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\07a_highcharity\\high_4_cinematic"), 33, false);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\07a_highcharity\\high_4_cinematic"), 67, false);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\07a_highcharity\\high_4_cinematic"), 15, true);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\07a_highcharity\\high_4_cinematic"), 23, true);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\07a_highcharity\\high_4_cinematic"), 0, true);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\07a_highcharity\\high_4_cinematic"), 1, true);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\07a_highcharity\\high_4_cinematic"), 2, true);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\07a_highcharity\\high_4_cinematic"), 24, true);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\07a_highcharity\\high_4_cinematic"), 7, true);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\07a_highcharity\\high_4_cinematic"), 9, true);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\07a_highcharity\\high_4_cinematic"), 12, true);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\07a_highcharity\\high_4_cinematic"), 13, true);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\07a_highcharity\\high_4_cinematic"), 8, true);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\07a_highcharity\\high_4_cinematic"), 10, true);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\07a_highcharity\\high_4_cinematic"), 11, true);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\07a_highcharity\\high_4_cinematic"), 14, true);
            predict_model_section(GetTag<RenderModelTag>("scenarios\\objects\\solo\\highcharity\\high_door_grand\\high_door_grand", 3851093013U), 0);
        }

        [ScriptMethod(402, Lifecycle.Dormant)]
        public async Task x04_03b_predict()
        {
            await sleep(30);
            await sleep(3);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\07a_highcharity\\high_4_cinematic"), 25, true);
            predict_model_section(GetTag<RenderModelTag>("scenarios\\objects\\solo\\alphagasgiant\\honor_guard\\honor_guard", 3854173252U), 0);
            predict_model_section(GetTag<RenderModelTag>("scenarios\\objects\\solo\\alphagasgiant\\honor_guard\\honor_guard", 3854173252U), 1);
            predict_model_section(GetTag<RenderModelTag>("scenarios\\objects\\solo\\alphagasgiant\\honor_guard\\honor_guard", 3854173252U), 2);
            predict_model_section(GetTag<RenderModelTag>("scenarios\\objects\\solo\\alphagasgiant\\honor_guard\\honor_guard", 3854173252U), 3);
            predict_model_section(GetTag<RenderModelTag>("scenarios\\objects\\solo\\alphagasgiant\\honor_guard\\honor_guard", 3854173252U), 4);
            predict_model_section(GetTag<RenderModelTag>("scenarios\\objects\\solo\\alphagasgiant\\honor_guard\\honor_guard", 3854173252U), 5);
            predict_model_section(GetTag<RenderModelTag>("scenarios\\objects\\solo\\alphagasgiant\\honor_guard\\honor_guard", 3854173252U), 6);
            predict_model_section(GetTag<RenderModelTag>("scenarios\\objects\\solo\\alphagasgiant\\honor_guard\\honor_guard", 3854173252U), 7);
            predict_model_section(GetTag<RenderModelTag>("scenarios\\objects\\solo\\alphagasgiant\\honor_guard\\honor_guard", 3854173252U), 8);
            predict_model_section(GetTag<RenderModelTag>("scenarios\\objects\\solo\\alphagasgiant\\honor_guard\\honor_guard", 3854173252U), 9);
            predict_model_section(GetTag<RenderModelTag>("scenarios\\objects\\solo\\alphagasgiant\\honor_guard\\honor_guard", 3854173252U), 10);
            await sleep(89);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\07a_highcharity\\high_4_cinematic"), 21, false);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\07a_highcharity\\high_4_cinematic"), 61, false);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\07a_highcharity\\high_4_cinematic"), 20, false);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\07a_highcharity\\high_4_cinematic"), 25, true);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\07a_highcharity\\high_4_cinematic"), 10, true);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\07a_highcharity\\high_4_cinematic"), 8, true);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\07a_highcharity\\high_4_cinematic"), 11, true);
            predict_model_section(GetTag<RenderModelTag>("objects\\weapons\\melee\\gravity_hammer\\gravity_hammer", 3849716736U), 0);
            predict_model_section(GetTag<RenderModelTag>("objects\\characters\\brute\\brute", 3845129146U), 26);
            predict_model_section(GetTag<RenderModelTag>("objects\\characters\\brute\\brute", 3845129146U), 28);
            predict_model_section(GetTag<RenderModelTag>("objects\\characters\\brute\\brute", 3845129146U), 29);
            predict_model_section(GetTag<RenderModelTag>("objects\\characters\\brute\\brute", 3845129146U), 40);
            predict_model_section(GetTag<RenderModelTag>("objects\\characters\\brute\\brute", 3845129146U), 36);
            predict_model_section(GetTag<RenderModelTag>("objects\\characters\\brute\\brute", 3845129146U), 37);
            predict_model_section(GetTag<RenderModelTag>("objects\\characters\\brute\\brute", 3845129146U), 33);
            predict_model_section(GetTag<RenderModelTag>("objects\\characters\\brute\\brute", 3845129146U), 35);
            predict_model_section(GetTag<RenderModelTag>("objects\\characters\\brute\\brute", 3845129146U), 34);
            predict_model_section(GetTag<RenderModelTag>("objects\\characters\\dervish\\dervish", 3847947237U), 11);
            predict_model_section(GetTag<RenderModelTag>("objects\\characters\\dervish\\dervish", 3847947237U), 9);
            predict_model_section(GetTag<RenderModelTag>("objects\\characters\\dervish\\dervish", 3847947237U), 13);
            await sleep(141);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\07a_highcharity\\high_4_cinematic"), 26, false);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\07a_highcharity\\high_4_cinematic"), 47, false);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\07a_highcharity\\high_4_cinematic"), 67, false);
            predict_model_section(GetTag<RenderModelTag>("scenarios\\objects\\solo\\highcharity\\high_door_grand\\high_door_grand", 3851093013U), 0);
            predict_model_section(GetTag<RenderModelTag>("scenarios\\objects\\cinematics\\cinematic_anchor\\cinematic_anchor", 3850175495U), 0);
        }

        [ScriptMethod(403, Lifecycle.Dormant)]
        public async Task x04_04_predict()
        {
            await sleep(30);
            await sleep(4);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\07a_highcharity\\high_4_cinematic"), 43, false);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\07a_highcharity\\high_4_cinematic"), 3, true);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\07a_highcharity\\high_4_cinematic"), 4, true);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\07a_highcharity\\high_4_cinematic"), 5, true);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\07a_highcharity\\high_4_cinematic"), 6, true);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\07a_highcharity\\high_4_cinematic"), 18, true);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\07a_highcharity\\high_4_cinematic"), 20, true);
            predict_model_section(GetTag<RenderModelTag>("scenarios\\objects\\solo\\alphagasgiant\\sarcophagus\\sarcophagus", 3856532584U), 1);
            predict_model_section(GetTag<RenderModelTag>("scenarios\\objects\\solo\\alphagasgiant\\sarcophagus\\sarcophagus", 3856532584U), 2);
            predict_model_section(GetTag<RenderModelTag>("objects\\characters\\prophet\\prophet", 3859022990U), 0);
            predict_model_section(GetTag<RenderModelTag>("objects\\characters\\prophet\\prophet", 3859022990U), 1);
            predict_model_section(GetTag<RenderModelTag>("objects\\characters\\prophet\\prophet", 3859022990U), 2);
            predict_model_section(GetTag<RenderModelTag>("objects\\characters\\prophet\\prophet", 3859022990U), 3);
            predict_model_section(GetTag<RenderModelTag>("objects\\characters\\prophet\\prophet", 3859022990U), 4);
            predict_model_section(GetTag<RenderModelTag>("objects\\vehicles\\gravity_throne\\gravity_throne", 3864855783U), 3);
            predict_model_section(GetTag<RenderModelTag>("objects\\vehicles\\gravity_throne\\gravity_throne", 3864855783U), 2);
            predict_model_section(GetTag<RenderModelTag>("objects\\weapons\\rifle\\smg\\smg", 3865445616U), 0);
            predict_model_section(GetTag<RenderModelTag>("objects\\characters\\prophet\\prophet", 3859022990U), 11);
            predict_model_section(GetTag<RenderModelTag>("objects\\characters\\prophet\\prophet", 3859022990U), 12);
            predict_model_section(GetTag<RenderModelTag>("objects\\characters\\prophet\\prophet", 3859022990U), 10);
            await sleep(38);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\07a_highcharity\\high_4_cinematic"), 64, false);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\07a_highcharity\\high_4_cinematic"), 48, false);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\07a_highcharity\\high_4_cinematic"), 7, true);
            await sleep(10);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\07a_highcharity\\high_4_cinematic"), 19, true);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\07a_highcharity\\high_4_cinematic"), 21, true);
            await sleep(14);
            predict_model_section(GetTag<RenderModelTag>("scenarios\\objects\\solo\\highcharity\\high_door_grand\\high_door_grand", 3851093013U), 0);
            await sleep(12);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\07a_highcharity\\high_4_cinematic"), 22, true);
        }

        [ScriptMethod(404, Lifecycle.Dormant)]
        public async Task x04_05_predict()
        {
            await sleep(30);
            await sleep(5);
            predict_model_section(GetTag<RenderModelTag>("objects\\weapons\\rifle\\smg\\smg", 3865445616U), 2);
            predict_model_section(GetTag<RenderModelTag>("objects\\weapons\\rifle\\smg\\smg", 3865445616U), 1);
            await sleep(151);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\07a_highcharity\\high_4_cinematic"), 64, false);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\07a_highcharity\\high_4_cinematic"), 21, true);
            predict_model_section(GetTag<RenderModelTag>("objects\\weapons\\rifle\\smg\\smg", 3865445616U), 2);
            await sleep(50);
            predict_model_section(GetTag<RenderModelTag>("scenarios\\objects\\solo\\highcharity\\high_door_grand\\high_door_grand", 3851093013U), 0);
            await sleep(252);
            predict_model_section(GetTag<RenderModelTag>("objects\\weapons\\rifle\\smg\\smg", 3865445616U), 0);
            await sleep(31);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\07a_highcharity\\high_4_cinematic"), 64, false);
            await sleep(51);
            predict_model_section(GetTag<RenderModelTag>("objects\\weapons\\rifle\\smg\\smg", 3865445616U), 1);
            await sleep(14);
            predict_model_section(GetTag<RenderModelTag>("objects\\weapons\\rifle\\smg\\smg", 3865445616U), 2);
            await sleep(138);
            predict_model_section(GetTag<RenderModelTag>("scenarios\\objects\\solo\\highcharity\\high_door_grand\\high_door_grand", 3851093013U), 0);
            await sleep(19);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\07a_highcharity\\high_4_cinematic"), 64, false);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\07a_highcharity\\high_4_cinematic"), 42, false);
        }

        [ScriptMethod(405, Lifecycle.Dormant)]
        public async Task x04_06_predict()
        {
            await sleep(30);
            await sleep(7);
            predict_model_section(GetTag<RenderModelTag>("objects\\weapons\\rifle\\smg\\smg", 3865445616U), 0);
            await sleep(90);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\07a_highcharity\\high_4_cinematic"), 64, false);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\07a_highcharity\\high_4_cinematic"), 42, false);
            predict_model_section(GetTag<RenderModelTag>("objects\\weapons\\rifle\\smg\\smg", 3865445616U), 2);
            await sleep(48);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\07a_highcharity\\high_4_cinematic"), 19, true);
            predict_model_section(GetTag<RenderModelTag>("objects\\weapons\\rifle\\smg\\smg", 3865445616U), 1);
            await sleep(139);
            predict_model_section(GetTag<RenderModelTag>("objects\\weapons\\rifle\\smg\\smg", 3865445616U), 2);
            await sleep(99);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\07a_highcharity\\high_4_cinematic"), 42, false);
            await sleep(91);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\07a_highcharity\\high_4_cinematic"), 46, false);
            await sleep(244);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\07a_highcharity\\high_4_cinematic"), 43, false);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\07a_highcharity\\high_4_cinematic"), 4, true);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\07a_highcharity\\high_4_cinematic"), 22, true);
            predict_model_section(GetTag<RenderModelTag>("objects\\weapons\\rifle\\smg\\smg", 3865445616U), 1);
            predict_model_section(GetTag<RenderModelTag>("objects\\weapons\\rifle\\smg\\smg", 3865445616U), 2);
            predict_model_section(GetTag<RenderModelTag>("scenarios\\objects\\solo\\highcharity\\high_door_grand\\high_door_grand", 3851093013U), 0);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\07a_highcharity\\high_4_cinematic"), 5, true);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\07a_highcharity\\high_4_cinematic"), 6, true);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\07a_highcharity\\high_4_cinematic"), 18, true);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\07a_highcharity\\high_4_cinematic"), 20, true);
        }

        [ScriptMethod(406, Lifecycle.Dormant)]
        public async Task x04_07_predict()
        {
            await sleep(30);
            await sleep(5);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\07a_highcharity\\high_4_cinematic"), 64, false);
            predict_model_section(GetTag<RenderModelTag>("objects\\characters\\heretic\\heretic", 3866100986U), 9);
            predict_model_section(GetTag<RenderModelTag>("objects\\characters\\heretic\\heretic", 3866100986U), 10);
            predict_model_section(GetTag<RenderModelTag>("objects\\characters\\heretic\\heretic", 3866100986U), 12);
            predict_model_section(GetTag<RenderModelTag>("scenarios\\objects\\solo\\highcharity\\high_door_grand\\high_door_grand", 3851093013U), 0);
            await sleep(157);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\07a_highcharity\\high_4_cinematic"), 42, false);
            await sleep(560);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\07a_highcharity\\high_4_cinematic"), 64, false);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\07a_highcharity\\high_4_cinematic"), 22, true);
        }

        [ScriptMethod(407, Lifecycle.Dormant)]
        public async Task x04_08_predict()
        {
            await sleep(30);
            await sleep(5);
            predict_model_section(GetTag<RenderModelTag>("objects\\weapons\\rifle\\smg\\smg", 3865445616U), 1);
            await sleep(204);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\07a_highcharity\\high_4_cinematic"), 64, false);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\07a_highcharity\\high_4_cinematic"), 42, false);
            predict_model_section(GetTag<RenderModelTag>("objects\\weapons\\rifle\\smg\\smg", 3865445616U), 2);
            predict_model_section(GetTag<RenderModelTag>("scenarios\\objects\\solo\\highcharity\\high_door_grand\\high_door_grand", 3851093013U), 0);
            await sleep(232);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\07a_highcharity\\high_4_cinematic"), 48, false);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\07a_highcharity\\high_4_cinematic"), 19, true);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\07a_highcharity\\high_4_cinematic"), 7, true);
            predict_model_section(GetTag<RenderModelTag>("objects\\weapons\\rifle\\smg\\smg", 3865445616U), 0);
            await sleep(230);
            predict_model_section(GetTag<RenderModelTag>("scenarios\\objects\\solo\\highcharity\\high_door_grand\\high_door_grand", 3851093013U), 0);
        }

        [ScriptMethod(408, Lifecycle.Dormant)]
        public async Task x04_09_predict()
        {
            await sleep(30);
            await sleep(3);
            predict_model_section(GetTag<RenderModelTag>("objects\\weapons\\rifle\\smg\\smg", 3865445616U), 1);
            predict_model_section(GetTag<RenderModelTag>("objects\\weapons\\rifle\\smg\\smg", 3865445616U), 2);
            await sleep(91);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\07a_highcharity\\high_4_cinematic"), 64, false);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\07a_highcharity\\high_4_cinematic"), 21, true);
        }

        [ScriptMethod(409, Lifecycle.Dormant)]
        public async Task x04_10_predict()
        {
            await sleep(30);
            await sleep(5);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\07a_highcharity\\high_4_cinematic"), 19, true);
            predict_model_section(GetTag<RenderModelTag>("objects\\weapons\\rifle\\smg\\smg", 3865445616U), 1);
            predict_model_section(GetTag<RenderModelTag>("objects\\weapons\\rifle\\smg\\smg", 3865445616U), 0);
            await sleep(185);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\07a_highcharity\\high_4_cinematic"), 42, false);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\07a_highcharity\\high_4_cinematic"), 46, false);
            await sleep(208);
            predict_model_section(GetTag<RenderModelTag>("scenarios\\objects\\solo\\highcharity\\high_door_grand\\high_door_grand", 3851093013U), 0);
            await sleep(103);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\07a_highcharity\\high_4_cinematic"), 19, true);
            predict_model_section(GetTag<RenderModelTag>("objects\\weapons\\rifle\\smg\\smg", 3865445616U), 1);
        }

        [ScriptMethod(410, Lifecycle.Dormant)]
        public async Task _04_intro_01_predict()
        {
            await sleep(30);
            await sleep(1);
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
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\04a_gasgiant\\ag_cinematic_bsp1"), 0, false);
            predict_model_section(GetTag<RenderModelTag>("scenarios\\skies\\generic\\space\\space", 3785490476U), 0);
            await sleep(1);
            predict_model_section(GetTag<RenderModelTag>("objects\\vehicles\\phantom\\phantom", 3866625282U), 12);
            predict_model_section(GetTag<RenderModelTag>("objects\\vehicles\\phantom\\phantom", 3866625282U), 13);
            predict_model_section(GetTag<RenderModelTag>("objects\\vehicles\\phantom\\phantom", 3866625282U), 14);
            predict_model_section(GetTag<RenderModelTag>("objects\\vehicles\\phantom\\phantom", 3866625282U), 15);
            predict_model_section(GetTag<RenderModelTag>("objects\\vehicles\\phantom\\phantom", 3866625282U), 16);
            predict_model_section(GetTag<RenderModelTag>("objects\\vehicles\\phantom\\phantom", 3866625282U), 19);
            predict_model_section(GetTag<RenderModelTag>("objects\\cinematics\\matte_paintings\\high_charity_stardust\\high_charity_stardust", 3867477263U), 0);
            predict_model_section(GetTag<RenderModelTag>("objects\\cinematics\\matte_paintings\\high_charity_exterior\\high_charity_exterior", 3867870485U), 0);
            predict_model_section(GetTag<RenderModelTag>("scenarios\\objects\\special\\null_up\\null_up", 3868067096U), 0);
            await sleep(77);
            predict_model_section(GetTag<RenderModelTag>("objects\\cinematics\\matte_paintings\\threshold_space\\threshold_space", 3839492964U), 0);
            await sleep(36);
            predict_model_section(GetTag<RenderModelTag>("objects\\cinematics\\matte_paintings\\high_charity_stardust\\high_charity_stardust", 3867477263U), 0);
            await sleep(3);
            predict_model_section(GetTag<RenderModelTag>("objects\\cinematics\\matte_paintings\\halo_destroyed_03\\halo_destroyed_03", 3840017260U), 0);
            await sleep(11);
            predict_model_section(GetTag<RenderModelTag>("scenarios\\objects\\cinematics\\cinematic_anchor\\cinematic_anchor", 3850175495U), 0);
        }

        [ScriptMethod(411, Lifecycle.Dormant)]
        public async Task _04_intro_02a_predict()
        {
            predict_model_section(GetTag<RenderModelTag>("objects\\vehicles\\phantom\\cinematics\\cinematics", 3868198170U), 0);
            predict_model_section(GetTag<RenderModelTag>("objects\\characters\\grunt\\grunt", 3868525855U), 20);
            predict_model_section(GetTag<RenderModelTag>("objects\\characters\\grunt\\grunt", 3868525855U), 21);
            predict_model_section(GetTag<RenderModelTag>("objects\\characters\\grunt\\grunt", 3868525855U), 22);
            predict_model_section(GetTag<RenderModelTag>("objects\\characters\\grunt\\grunt", 3868525855U), 23);
            predict_model_section(GetTag<RenderModelTag>("objects\\characters\\grunt\\grunt", 3868525855U), 24);
            predict_model_section(GetTag<RenderModelTag>("incompetent\\default_object", 3870164280U), 0);
            predict_model_section(GetTag<RenderModelTag>("objects\\characters\\elite\\elite", 3870229817U), 25);
            predict_model_section(GetTag<RenderModelTag>("objects\\characters\\elite\\elite", 3870229817U), 30);
            predict_model_section(GetTag<RenderModelTag>("objects\\characters\\elite\\elite", 3870229817U), 27);
            predict_model_section(GetTag<RenderModelTag>("objects\\characters\\elite\\elite", 3870229817U), 32);
            predict_model_section(GetTag<RenderModelTag>("objects\\weapons\\rifle\\plasma_rifle\\plasma_rifle", 3795845322U), 0);
            predict_model_section(GetTag<RenderModelTag>("objects\\weapons\\rifle\\beam_rifle\\beam_rifle", 3872195927U), 1);
            predict_model_section(GetTag<RenderModelTag>("objects\\weapons\\rifle\\plasma_rifle\\plasma_rifle", 3795845322U), 1);
            predict_model_section(GetTag<RenderModelTag>("objects\\characters\\elite\\elite", 3870229817U), 26);
            predict_model_section(GetTag<RenderModelTag>("objects\\characters\\dervish\\dervish", 3847947237U), 8);
            predict_model_section(GetTag<RenderModelTag>("objects\\characters\\dervish\\dervish", 3847947237U), 10);
            await sleep(3);
            predict_model_section(GetTag<RenderModelTag>("scenarios\\skies\\solo\\alphagasgiant\\no_structure\\no_structure", 3786670142U), 0);
            predict_model_section(GetTag<RenderModelTag>("scenarios\\skies\\solo\\alphagasgiant\\no_structure\\no_structure", 3786670142U), 1);
            predict_model_section(GetTag<RenderModelTag>("scenarios\\skies\\solo\\alphagasgiant\\no_structure\\no_structure", 3786670142U), 2);
            predict_model_section(GetTag<RenderModelTag>("scenarios\\skies\\solo\\alphagasgiant\\no_structure\\no_structure", 3786670142U), 3);
            predict_model_section(GetTag<RenderModelTag>("scenarios\\skies\\solo\\alphagasgiant\\no_structure\\no_structure", 3786670142U), 4);
            predict_model_section(GetTag<RenderModelTag>("scenarios\\skies\\solo\\alphagasgiant\\no_structure\\no_structure", 3786670142U), 5);
            predict_model_section(GetTag<RenderModelTag>("scenarios\\skies\\solo\\alphagasgiant\\no_structure\\no_structure", 3786670142U), 6);
            predict_model_section(GetTag<RenderModelTag>("scenarios\\skies\\solo\\alphagasgiant\\no_structure\\no_structure", 3786670142U), 7);
            await sleep(7);
            await sleep(146);
            predict_model_section(GetTag<RenderModelTag>("objects\\weapons\\rifle\\plasma_rifle\\plasma_rifle", 3795845322U), 2);
            await sleep(84);
            predict_model_section(GetTag<RenderModelTag>("objects\\weapons\\rifle\\beam_rifle\\beam_rifle", 3872195927U), 2);
            predict_model_section(GetTag<RenderModelTag>("scenarios\\objects\\cinematics\\cinematic_anchor\\cinematic_anchor", 3850175495U), 0);
            await sleep(69);
            predict_model_section(GetTag<RenderModelTag>("objects\\weapons\\rifle\\plasma_rifle\\plasma_rifle", 3795845322U), 2);
            await sleep(91);
            predict_model_section(GetTag<RenderModelTag>("incompetent\\default_object", 3870164280U), 0);
            predict_model_section(GetTag<RenderModelTag>("objects\\weapons\\rifle\\plasma_rifle\\plasma_rifle", 3795845322U), 3);
            await sleep(135);
            predict_model_section(GetTag<RenderModelTag>("scenarios\\objects\\cinematics\\cinematic_anchor\\cinematic_anchor", 3850175495U), 0);
        }

        [ScriptMethod(412, Lifecycle.Dormant)]
        public async Task _04_intro_02b_predict()
        {
            await sleep(30);
            await sleep(7);
            predict_model_section(GetTag<RenderModelTag>("incompetent\\default_object", 3870164280U), 0);
            predict_model_section(GetTag<RenderModelTag>("objects\\weapons\\rifle\\plasma_rifle\\plasma_rifle", 3795845322U), 0);
            predict_model_section(GetTag<RenderModelTag>("objects\\weapons\\rifle\\plasma_rifle\\plasma_rifle", 3795845322U), 1);
            predict_model_section(GetTag<RenderModelTag>("objects\\characters\\dervish\\dervish", 3847947237U), 8);
            predict_model_section(GetTag<RenderModelTag>("objects\\characters\\dervish\\dervish", 3847947237U), 10);
            await sleep(1);
            predict_model_section(GetTag<RenderModelTag>("objects\\weapons\\rifle\\plasma_rifle\\plasma_rifle", 3795845322U), 2);
        }

        [ScriptMethod(413, Lifecycle.Dormant)]
        public async Task _04_intro_02c_predict()
        {
            await sleep(2);
            predict_model_section(GetTag<RenderModelTag>("objects\\vehicles\\phantom\\phantom", 3866625282U), 12);
            predict_model_section(GetTag<RenderModelTag>("objects\\vehicles\\phantom\\phantom", 3866625282U), 13);
            predict_model_section(GetTag<RenderModelTag>("objects\\vehicles\\phantom\\phantom", 3866625282U), 14);
            predict_model_section(GetTag<RenderModelTag>("objects\\vehicles\\phantom\\phantom", 3866625282U), 15);
            predict_model_section(GetTag<RenderModelTag>("objects\\vehicles\\phantom\\phantom", 3866625282U), 16);
            predict_model_section(GetTag<RenderModelTag>("objects\\vehicles\\phantom\\phantom", 3866625282U), 19);
            predict_model_section(GetTag<RenderModelTag>("objects\\characters\\dervish\\dervish", 3847947237U), 8);
            predict_model_section(GetTag<RenderModelTag>("objects\\characters\\dervish\\dervish", 3847947237U), 10);
            predict_model_section(GetTag<RenderModelTag>("objects\\cinematics\\matte_paintings\\gas_giant_structure_top\\gas_giant_structure_top", 3873310056U), 0);
        }

        [ScriptMethod(414, Lifecycle.Dormant)]
        public async Task _04_intro_02d_predict()
        {
            await sleep(2);
            predict_model_section(GetTag<RenderModelTag>("objects\\characters\\elite\\elite", 3870229817U), 25);
            predict_model_section(GetTag<RenderModelTag>("objects\\characters\\elite\\elite", 3870229817U), 26);
            predict_model_section(GetTag<RenderModelTag>("objects\\characters\\elite\\elite", 3870229817U), 27);
            predict_model_section(GetTag<RenderModelTag>("objects\\characters\\elite\\elite", 3870229817U), 32);
            predict_model_section(GetTag<RenderModelTag>("objects\\characters\\dervish\\dervish", 3847947237U), 8);
            predict_model_section(GetTag<RenderModelTag>("objects\\characters\\dervish\\dervish", 3847947237U), 10);
            predict_model_section(GetTag<RenderModelTag>("objects\\vehicles\\phantom\\cinematics\\cinematics", 3868198170U), 0);
            await sleep(301);
            predict_model_section(GetTag<RenderModelTag>("objects\\vehicles\\phantom\\phantom", 3866625282U), 12);
            predict_model_section(GetTag<RenderModelTag>("objects\\vehicles\\phantom\\phantom", 3866625282U), 13);
            predict_model_section(GetTag<RenderModelTag>("objects\\vehicles\\phantom\\phantom", 3866625282U), 14);
            predict_model_section(GetTag<RenderModelTag>("objects\\vehicles\\phantom\\phantom", 3866625282U), 15);
            predict_model_section(GetTag<RenderModelTag>("objects\\vehicles\\phantom\\phantom", 3866625282U), 16);
            predict_model_section(GetTag<RenderModelTag>("objects\\vehicles\\phantom\\phantom", 3866625282U), 19);
            await sleep(208);
            predict_model_section(GetTag<RenderModelTag>("objects\\cinematics\\matte_paintings\\gas_giant_structure\\gas_giant_structure", 3873506667U), 0);
        }

        [ScriptMethod(415, Lifecycle.Dormant)]
        public async Task _04_intro_03_predict()
        {
            await sleep(178);
            predict_model_section(GetTag<RenderModelTag>("objects\\cinematics\\matte_paintings\\gas_giant_exterior\\gas_giant_exterior", 3873703278U), 0);
            await sleep(2);
            predict_model_section(GetTag<RenderModelTag>("scenarios\\objects\\cinematics\\cinematic_anchor\\cinematic_anchor", 3850175495U), 0);
            predict_model_section(GetTag<RenderModelTag>("objects\\vehicles\\phantom\\phantom", 3866625282U), 0);
            predict_model_section(GetTag<RenderModelTag>("objects\\vehicles\\phantom\\phantom", 3866625282U), 1);
            predict_model_section(GetTag<RenderModelTag>("objects\\vehicles\\phantom\\phantom", 3866625282U), 2);
            predict_model_section(GetTag<RenderModelTag>("objects\\vehicles\\phantom\\phantom", 3866625282U), 3);
            predict_model_section(GetTag<RenderModelTag>("scenarios\\objects\\solo\\alphagasgiant\\ext_structures\\ext_structures_vent_1\\ext_structures_vent_1", 3873899889U), 0);
            predict_model_section(GetTag<RenderModelTag>("scenarios\\objects\\cinematics\\cinematic_anchor\\cinematic_anchor", 3850175495U), 0);
            predict_model_section(GetTag<RenderModelTag>("scenarios\\objects\\forerunner\\industrial\\doors\\door_tron_lg\\door_tron_lg", 3874424185U), 0);
            predict_model_section(GetTag<RenderModelTag>("scenarios\\objects\\forerunner\\industrial\\holo_panels\\holo_generic\\holo_generic", 3875538314U), 0);
            predict_model_section(GetTag<RenderModelTag>("scenarios\\objects\\forerunner\\industrial\\doors\\door_cargo_hangar_scenery\\door_cargo_hangar_scenery", 3875865999U), 0);
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
        }

        [ScriptMethod(416, Lifecycle.Dormant)]
        public async Task _04_intro_05_predict()
        {
            await sleep(2);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\04a_gasgiant\\alphagasgiant"), 36, false);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\04a_gasgiant\\alphagasgiant"), 40, false);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\04a_gasgiant\\alphagasgiant"), 15, false);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\04a_gasgiant\\alphagasgiant"), 37, false);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\04a_gasgiant\\alphagasgiant"), 74, false);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\04a_gasgiant\\alphagasgiant"), 11, false);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\04a_gasgiant\\alphagasgiant"), 33, false);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\04a_gasgiant\\alphagasgiant"), 56, false);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\04a_gasgiant\\alphagasgiant"), 78, false);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\04a_gasgiant\\alphagasgiant"), 34, false);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\04a_gasgiant\\alphagasgiant"), 53, false);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\04a_gasgiant\\alphagasgiant"), 14, false);
            await sleep(4);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\04a_gasgiant\\alphagasgiant"), 5, true);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\04a_gasgiant\\alphagasgiant"), 0, true);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\04a_gasgiant\\alphagasgiant"), 3, true);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\04a_gasgiant\\alphagasgiant"), 8, true);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\04a_gasgiant\\alphagasgiant"), 9, true);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\04a_gasgiant\\alphagasgiant"), 59, true);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\04a_gasgiant\\alphagasgiant"), 6, true);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\04a_gasgiant\\alphagasgiant"), 60, true);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\04a_gasgiant\\alphagasgiant"), 7, true);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\04a_gasgiant\\alphagasgiant"), 4, true);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\04a_gasgiant\\alphagasgiant"), 2, true);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\04a_gasgiant\\alphagasgiant"), 15, true);
            await sleep(4);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\04a_gasgiant\\alphagasgiant"), 38, false);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\04a_gasgiant\\alphagasgiant"), 27, false);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\04a_gasgiant\\alphagasgiant"), 20, false);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\04a_gasgiant\\alphagasgiant"), 41, false);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\04a_gasgiant\\alphagasgiant"), 12, false);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\04a_gasgiant\\alphagasgiant"), 90, false);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\04a_gasgiant\\alphagasgiant"), 73, false);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\04a_gasgiant\\alphagasgiant"), 30, false);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\04a_gasgiant\\alphagasgiant"), 10, false);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\04a_gasgiant\\alphagasgiant"), 1, false);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\04a_gasgiant\\alphagasgiant"), 5, false);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\04a_gasgiant\\alphagasgiant"), 45, false);
            await sleep(4);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\04a_gasgiant\\alphagasgiant"), 77, false);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\04a_gasgiant\\alphagasgiant"), 22, false);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\04a_gasgiant\\alphagasgiant"), 0, false);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\04a_gasgiant\\alphagasgiant"), 80, false);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\04a_gasgiant\\alphagasgiant"), 29, false);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\04a_gasgiant\\alphagasgiant"), 16, false);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\04a_gasgiant\\alphagasgiant"), 32, false);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\04a_gasgiant\\alphagasgiant"), 3, false);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\04a_gasgiant\\alphagasgiant"), 31, false);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\04a_gasgiant\\alphagasgiant"), 72, false);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\04a_gasgiant\\alphagasgiant"), 93, false);
            await sleep(3);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\04a_gasgiant\\alphagasgiant"), 9, false);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\04a_gasgiant\\alphagasgiant"), 68, false);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\04a_gasgiant\\alphagasgiant"), 57, false);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\04a_gasgiant\\alphagasgiant"), 101, false);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\04a_gasgiant\\alphagasgiant"), 98, false);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\04a_gasgiant\\alphagasgiant"), 79, false);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\04a_gasgiant\\alphagasgiant"), 2, false);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\04a_gasgiant\\alphagasgiant"), 43, false);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\04a_gasgiant\\alphagasgiant"), 100, false);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\04a_gasgiant\\alphagasgiant"), 13, true);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\04a_gasgiant\\alphagasgiant"), 1, true);
            await sleep(5);
            await sleep(4);
            predict_model_section(GetTag<RenderModelTag>("objects\\vehicles\\phantom\\phantom", 3866625282U), 0);
            predict_model_section(GetTag<RenderModelTag>("objects\\vehicles\\phantom\\phantom", 3866625282U), 1);
            predict_model_section(GetTag<RenderModelTag>("objects\\vehicles\\phantom\\phantom", 3866625282U), 2);
            predict_model_section(GetTag<RenderModelTag>("objects\\vehicles\\phantom\\phantom", 3866625282U), 19);
            predict_model_section(GetTag<RenderModelTag>("objects\\vehicles\\phantom\\phantom", 3866625282U), 3);
            predict_model_section(GetTag<RenderModelTag>("objects\\vehicles\\phantom\\turrets\\chin_gun\\chin_gun", 3876193684U), 0);
            predict_model_section(GetTag<RenderModelTag>("objects\\vehicles\\phantom\\turrets\\chin_gun\\chin_gun", 3876193684U), 1);
            await sleep(6);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\04a_gasgiant\\alphagasgiant"), 15, true);
            await sleep(10);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\04a_gasgiant\\alphagasgiant"), 15, true);
            await sleep(10);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\04a_gasgiant\\alphagasgiant"), 15, true);
            await sleep(62);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\04a_gasgiant\\alphagasgiant"), 4, false);
            predict_model_section(GetTag<RenderModelTag>("objects\\characters\\dervish\\dervish", 3847947237U), 0);
            predict_model_section(GetTag<RenderModelTag>("objects\\characters\\dervish\\dervish", 3847947237U), 1);
            await sleep(7);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\04a_gasgiant\\alphagasgiant"), 57, true);
        }

        [ScriptMethod(417, Lifecycle.Dormant)]
        public async Task _04_intro_06b_predict()
        {
            await sleep(2);
            predict_model_section(GetTag<RenderModelTag>("objects\\vehicles\\phantom\\phantom", 3866625282U), 6);
            predict_model_section(GetTag<RenderModelTag>("objects\\vehicles\\phantom\\phantom", 3866625282U), 7);
            predict_model_section(GetTag<RenderModelTag>("objects\\vehicles\\phantom\\phantom", 3866625282U), 8);
            predict_model_section(GetTag<RenderModelTag>("objects\\vehicles\\phantom\\phantom", 3866625282U), 9);
            predict_model_section(GetTag<RenderModelTag>("objects\\vehicles\\phantom\\turrets\\chin_gun\\chin_gun", 3876193684U), 3);
            predict_model_section(GetTag<RenderModelTag>("objects\\vehicles\\phantom\\turrets\\chin_gun\\chin_gun", 3876193684U), 4);
            await sleep(34);
            predict_model_section(GetTag<RenderModelTag>("objects\\vehicles\\phantom\\phantom", 3866625282U), 12);
            predict_model_section(GetTag<RenderModelTag>("objects\\vehicles\\phantom\\phantom", 3866625282U), 13);
            predict_model_section(GetTag<RenderModelTag>("objects\\vehicles\\phantom\\phantom", 3866625282U), 14);
            predict_model_section(GetTag<RenderModelTag>("objects\\vehicles\\phantom\\phantom", 3866625282U), 16);
            predict_model_section(GetTag<RenderModelTag>("objects\\vehicles\\phantom\\turrets\\chin_gun\\chin_gun", 3876193684U), 6);
            predict_model_section(GetTag<RenderModelTag>("objects\\vehicles\\phantom\\turrets\\chin_gun\\chin_gun", 3876193684U), 7);
            await sleep(54);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\04a_gasgiant\\alphagasgiant"), 30, false);
            await sleep(14);
            predict_model_section(GetTag<RenderModelTag>("scenarios\\objects\\solo\\alphagasgiant\\ext_structures\\ext_structures_vent_1\\ext_structures_vent_1", 3873899889U), 0);
            await sleep(39);
            predict_model_section(GetTag<RenderModelTag>("scenarios\\objects\\solo\\alphagasgiant\\ext_structures\\ext_structures_vent_1\\ext_structures_vent_1", 3873899889U), 0);
            await sleep(2);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\04a_gasgiant\\alphagasgiant"), 30, false);
            await sleep(2);
            predict_model_section(GetTag<RenderModelTag>("objects\\vehicles\\phantom\\phantom", 3866625282U), 6);
            predict_model_section(GetTag<RenderModelTag>("objects\\vehicles\\phantom\\phantom", 3866625282U), 7);
            predict_model_section(GetTag<RenderModelTag>("objects\\vehicles\\phantom\\phantom", 3866625282U), 8);
            predict_model_section(GetTag<RenderModelTag>("objects\\vehicles\\phantom\\phantom", 3866625282U), 9);
            predict_model_section(GetTag<RenderModelTag>("objects\\vehicles\\phantom\\turrets\\chin_gun\\chin_gun", 3876193684U), 3);
            predict_model_section(GetTag<RenderModelTag>("objects\\vehicles\\phantom\\turrets\\chin_gun\\chin_gun", 3876193684U), 4);
            await sleep(6);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\04a_gasgiant\\alphagasgiant"), 55, true);
            await sleep(1);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\04a_gasgiant\\alphagasgiant"), 10, false);
            await sleep(3);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\04a_gasgiant\\alphagasgiant"), 31, false);
            await sleep(1);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\04a_gasgiant\\alphagasgiant"), 2, false);
            await sleep(10);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\04a_gasgiant\\alphagasgiant"), 44, true);
            await sleep(7);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\04a_gasgiant\\alphagasgiant"), 29, false);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\04a_gasgiant\\alphagasgiant"), 79, false);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\04a_gasgiant\\alphagasgiant"), 72, false);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\04a_gasgiant\\alphagasgiant"), 59, true);
            await sleep(1);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\04a_gasgiant\\alphagasgiant"), 100, false);
            await sleep(5);
            predict_model_section(GetTag<RenderModelTag>("objects\\characters\\grunt\\grunt", 3868525855U), 20);
            predict_model_section(GetTag<RenderModelTag>("objects\\characters\\grunt\\grunt", 3868525855U), 21);
            predict_model_section(GetTag<RenderModelTag>("objects\\characters\\grunt\\grunt", 3868525855U), 22);
            predict_model_section(GetTag<RenderModelTag>("objects\\characters\\grunt\\grunt", 3868525855U), 23);
            predict_model_section(GetTag<RenderModelTag>("objects\\characters\\grunt\\grunt", 3868525855U), 24);
            predict_model_section(GetTag<RenderModelTag>("incompetent\\default_object", 3870164280U), 0);
            await sleep(3);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\04a_gasgiant\\alphagasgiant"), 68, false);
            await sleep(3);
            predict_model_section(GetTag<RenderModelTag>("objects\\characters\\elite\\elite", 3870229817U), 25);
            predict_model_section(GetTag<RenderModelTag>("objects\\characters\\elite\\elite", 3870229817U), 30);
            predict_model_section(GetTag<RenderModelTag>("objects\\characters\\elite\\elite", 3870229817U), 27);
            predict_model_section(GetTag<RenderModelTag>("objects\\characters\\elite\\elite", 3870229817U), 32);
            predict_model_section(GetTag<RenderModelTag>("objects\\weapons\\rifle\\plasma_rifle\\plasma_rifle", 3795845322U), 0);
            await sleep(88);
            predict_model_section(GetTag<RenderModelTag>("objects\\weapons\\rifle\\plasma_rifle\\plasma_rifle", 3795845322U), 1);
            await sleep(34);
            predict_model_section(GetTag<RenderModelTag>("objects\\vehicles\\phantom\\phantom", 3866625282U), 12);
            predict_model_section(GetTag<RenderModelTag>("objects\\vehicles\\phantom\\phantom", 3866625282U), 13);
            predict_model_section(GetTag<RenderModelTag>("objects\\vehicles\\phantom\\phantom", 3866625282U), 14);
            predict_model_section(GetTag<RenderModelTag>("objects\\vehicles\\phantom\\phantom", 3866625282U), 16);
            predict_model_section(GetTag<RenderModelTag>("objects\\vehicles\\phantom\\turrets\\chin_gun\\chin_gun", 3876193684U), 6);
            predict_model_section(GetTag<RenderModelTag>("objects\\vehicles\\phantom\\turrets\\chin_gun\\chin_gun", 3876193684U), 7);
            await sleep(11);
            predict_model_section(GetTag<RenderModelTag>("objects\\characters\\dervish\\dervish", 3847947237U), 8);
            predict_model_section(GetTag<RenderModelTag>("objects\\characters\\dervish\\dervish", 3847947237U), 10);
            predict_model_section(GetTag<RenderModelTag>("objects\\weapons\\melee\\energy_blade\\energy_blade", 3786866753U), 6);
            predict_model_section(GetTag<RenderModelTag>("objects\\weapons\\melee\\energy_blade\\energy_blade", 3786866753U), 1);
            await sleep(45);
            predict_model_section(GetTag<RenderModelTag>("objects\\weapons\\melee\\energy_blade\\energy_blade", 3786866753U), 3);
            await sleep(22);
            predict_model_section(GetTag<RenderModelTag>("objects\\weapons\\melee\\energy_blade\\energy_blade", 3786866753U), 2);
            await sleep(6);
            predict_model_section(GetTag<RenderModelTag>("objects\\weapons\\melee\\energy_blade\\energy_blade", 3786866753U), 4);
            predict_model_section(GetTag<RenderModelTag>("objects\\weapons\\melee\\energy_blade\\energy_blade", 3786866753U), 5);
            await sleep(34);
            predict_model_section(GetTag<RenderModelTag>("objects\\vehicles\\phantom\\phantom", 3866625282U), 6);
            predict_model_section(GetTag<RenderModelTag>("objects\\vehicles\\phantom\\phantom", 3866625282U), 7);
            predict_model_section(GetTag<RenderModelTag>("objects\\vehicles\\phantom\\phantom", 3866625282U), 8);
            predict_model_section(GetTag<RenderModelTag>("objects\\vehicles\\phantom\\phantom", 3866625282U), 9);
            predict_model_section(GetTag<RenderModelTag>("objects\\vehicles\\phantom\\turrets\\chin_gun\\chin_gun", 3876193684U), 3);
            predict_model_section(GetTag<RenderModelTag>("objects\\vehicles\\phantom\\turrets\\chin_gun\\chin_gun", 3876193684U), 4);
        }

        [ScriptMethod(418, Lifecycle.Static)]
        public async Task teleport_hangar()
        {
            ai_erase_all();
            ai_place(allies_elites_01.Squad);
            ai_place(allies_grunts_01.Squad, 1);
            ai_place(hacker.Squad);
            switch_bsp(3);
            object_teleport(await this.player0(), hangar_top_player0);
            object_teleport(await this.player1(), hangar_top_player1);
            object_teleport(list_get(ai_actors(allies_elites_01.Squad), 0), hangar_top_ally01);
            object_teleport(list_get(ai_actors(hacker.Squad), 0), hangar_top_ally02);
            object_teleport(list_get(ai_actors(allies_grunts_01.Squad), 0), hangar_top_ally03);
            device_set_position_immediate(elev_hangar.Entity, 0F);
            sleep_forever(new ScriptMethodReference(mission));
            await this.sleep_intro();
            await this.sleep_rec_center();
            ai_set_orders(arm01_allies, get_on_hangar_elev);
            await sleep_until(async () => volume_test_objects(vol_on_hangar_lift_top, players()) == true);
            game_save();
            wake(new ScriptMethodReference(hangar_firsttime_start));
            wake(new ScriptMethodReference(to_underhangar_firsttime));
            device_one_sided_set(rec_center_entry_ext.Entity, true);
            device_one_sided_set(rec_center_entry_int.Entity, true);
            await sleep_until(async () => volume_test_objects(vol_underhangar_from_top, players()) == true);
            wake(new ScriptMethodReference(underhangar_firsttime_start));
            wake(new ScriptMethodReference(to_bottling));
            await this.sleep_rec_center();
            await this.sleep_hangar();
            this.recycling_power_on = false;
            this.hangar_power_on = false;
            device_one_sided_set(hangar_exit.Entity, true);
            await sleep_until(async () => (short)structure_bsp_index() == 0);
            wake(new ScriptMethodReference(bottling_firsttime_start));
            wake(new ScriptMethodReference(bottling_plant_end));
            await this.sleep_first_halls();
            await this.sleep_underhangar();
            this.underhangar_power_on = false;
            device_one_sided_set(underhangar_entry.Entity, true);
            device_one_sided_set(underhangar_exit.Entity, true);
            await sleep_until(async () => vehicle_test_seat(ai_vehicle_get_from_starting_location(ledge_banshees_01.left), "banshee_d", unit(await this.player0())) == true || vehicle_test_seat(ai_vehicle_get_from_starting_location(ledge_banshees_01.right), "banshee_d", unit(await this.player0())) == true || vehicle_test_seat(ai_vehicle_get_from_starting_location(ledge_banshees_01.left), "banshee_d", unit(await this.player1())) == true || vehicle_test_seat(ai_vehicle_get_from_starting_location(ledge_banshees_01.right), "banshee_d", unit(await this.player1())) == true);
            wake(new ScriptMethodReference(dogfight_firsttime_start));
            wake(new ScriptMethodReference(arm_02_entry_win));
            await this.sleep_second_halls();
            await this.sleep_bottling();
            this.bottling_power_on = false;
            device_operates_automatically_set(rec_center_entry_ext.Entity, false);
            device_one_sided_set(bottling_entry.Entity, true);
            device_one_sided_set(bottling_midway.Entity, true);
            device_one_sided_set(viewroom_entry.Entity, true);
            await sleep_until(async () => unit_in_vehicle(await this.player0()) && unit_in_vehicle(await this.player1()) || unit_in_vehicle(await this.player0()) && (bool)game_is_cooperative() == false);
        }

        [ScriptMethod(419, Lifecycle.Static)]
        public async Task teleport_underhangar()
        {
            ai_erase_all();
            ai_place(allies_elites_01.Squad);
            ai_place(hacker.Squad);
            switch_bsp(3);
            object_teleport(await this.player0(), underhangar_player0);
            object_teleport(await this.player1(), underhangar_player1);
            object_teleport(list_get(ai_actors(allies_elites_01.Squad), 0), underhangar_ally01);
            object_teleport(list_get(ai_actors(hacker.Squad), 0), underhangar_ally02);
            sleep_forever(new ScriptMethodReference(mission));
            await this.sleep_intro();
            await this.sleep_rec_center();
            await this.sleep_first_halls();
            await this.sleep_hangar();
            device_one_sided_set(rec_center_entry_ext.Entity, true);
            device_one_sided_set(rec_center_entry_int.Entity, true);
            game_save();
            wake(new ScriptMethodReference(underhangar_firsttime_start));
            wake(new ScriptMethodReference(to_bottling));
            this.recycling_power_on = false;
            this.hangar_power_on = false;
            device_one_sided_set(hangar_exit.Entity, true);
            await sleep_until(async () => (short)structure_bsp_index() == 0);
            wake(new ScriptMethodReference(bottling_firsttime_start));
            wake(new ScriptMethodReference(bottling_plant_end));
            await this.sleep_first_halls();
            await this.sleep_underhangar();
            this.underhangar_power_on = false;
            device_one_sided_set(underhangar_entry.Entity, true);
            device_one_sided_set(underhangar_exit.Entity, true);
            await sleep_until(async () => vehicle_test_seat(ai_vehicle_get_from_starting_location(ledge_banshees_01.left), "banshee_d", unit(await this.player0())) == true || vehicle_test_seat(ai_vehicle_get_from_starting_location(ledge_banshees_01.right), "banshee_d", unit(await this.player0())) == true || vehicle_test_seat(ai_vehicle_get_from_starting_location(ledge_banshees_01.left), "banshee_d", unit(await this.player1())) == true || vehicle_test_seat(ai_vehicle_get_from_starting_location(ledge_banshees_01.right), "banshee_d", unit(await this.player1())) == true);
            wake(new ScriptMethodReference(dogfight_firsttime_start));
            wake(new ScriptMethodReference(arm_02_entry_win));
            await this.sleep_second_halls();
            await this.sleep_bottling();
            this.bottling_power_on = false;
            device_operates_automatically_set(rec_center_entry_ext.Entity, false);
            device_one_sided_set(bottling_entry.Entity, true);
            device_one_sided_set(bottling_midway.Entity, true);
            device_one_sided_set(viewroom_entry.Entity, true);
            await sleep_until(async () => unit_in_vehicle(await this.player0()) && unit_in_vehicle(await this.player1()) || unit_in_vehicle(await this.player0()) && (bool)game_is_cooperative() == false);
        }

        [ScriptMethod(420, Lifecycle.Static)]
        public async Task teleport_bottling()
        {
            ai_erase_all();
            ai_place(allies_elites_01.Squad);
            switch_bsp(0);
            object_teleport(await this.player0(), bottling_player0);
            object_teleport(await this.player1(), bottling_player1);
            object_teleport(list_get(ai_actors(allies_elites_01.Squad), 0), bottling_ally01);
            sleep_forever(new ScriptMethodReference(mission));
            await this.sleep_intro();
            await this.sleep_rec_center();
            await this.sleep_hangar();
            await this.sleep_first_halls();
            await this.sleep_underhangar();
            await this.sleep_second_halls();
            device_one_sided_set(rec_center_entry_ext.Entity, true);
            device_one_sided_set(rec_center_entry_int.Entity, true);
            device_one_sided_set(hangar_exit.Entity, true);
            game_save();
            wake(new ScriptMethodReference(bottling_firsttime_start));
            wake(new ScriptMethodReference(bottling_plant_end));
            await this.sleep_first_halls();
            await this.sleep_underhangar();
            this.underhangar_power_on = false;
            device_one_sided_set(underhangar_entry.Entity, true);
            device_one_sided_set(underhangar_exit.Entity, true);
            await sleep_until(async () => vehicle_test_seat(ai_vehicle_get_from_starting_location(ledge_banshees_01.left), "banshee_d", unit(await this.player0())) == true || vehicle_test_seat(ai_vehicle_get_from_starting_location(ledge_banshees_01.right), "banshee_d", unit(await this.player0())) == true || vehicle_test_seat(ai_vehicle_get_from_starting_location(ledge_banshees_01.left), "banshee_d", unit(await this.player1())) == true || vehicle_test_seat(ai_vehicle_get_from_starting_location(ledge_banshees_01.right), "banshee_d", unit(await this.player1())) == true);
            wake(new ScriptMethodReference(dogfight_firsttime_start));
            wake(new ScriptMethodReference(arm_02_entry_win));
            await this.sleep_second_halls();
            await this.sleep_bottling();
            this.bottling_power_on = false;
            device_operates_automatically_set(rec_center_entry_ext.Entity, false);
            device_one_sided_set(bottling_entry.Entity, true);
            device_one_sided_set(bottling_midway.Entity, true);
            device_one_sided_set(viewroom_entry.Entity, true);
            await sleep_until(async () => unit_in_vehicle(await this.player0()) && unit_in_vehicle(await this.player1()) || unit_in_vehicle(await this.player0()) && (bool)game_is_cooperative() == false);
        }

        [ScriptMethod(421, Lifecycle.Static)]
        public async Task teleport_banshee()
        {
            ai_erase_all();
            switch_bsp(0);
            ai_place(ledge_banshees_01.left);
            ai_place(ledge_banshees_01.right);
            ai_place(dog_turrets_01.Squad);
            object_teleport(await this.player0(), banshee_ledge_player0);
            object_teleport(await this.player1(), banshee_ledge_player1);
            wake(new ScriptMethodReference(bring_in_da_phantom));
            sleep_forever(new ScriptMethodReference(mission));
            await this.sleep_intro();
            await this.sleep_rec_center();
            await this.sleep_hangar();
            await this.sleep_first_halls();
            await this.sleep_underhangar();
            await this.sleep_second_halls();
            await this.sleep_bottling();
            device_one_sided_set(rec_center_entry_ext.Entity, true);
            device_one_sided_set(rec_center_entry_int.Entity, true);
            device_one_sided_set(hangar_exit.Entity, true);
            device_one_sided_set(underhangar_entry.Entity, true);
            device_one_sided_set(underhangar_exit.Entity, true);
            wake(new ScriptMethodReference(bring_in_da_phantom));
            game_save();
            await sleep_until(async () => vehicle_test_seat(ai_vehicle_get_from_starting_location(ledge_banshees_01.left), "banshee_d", unit(await this.player0())) == true || vehicle_test_seat(ai_vehicle_get_from_starting_location(ledge_banshees_01.right), "banshee_d", unit(await this.player0())) == true || vehicle_test_seat(ai_vehicle_get_from_starting_location(ledge_banshees_01.left), "banshee_d", unit(await this.player1())) == true || vehicle_test_seat(ai_vehicle_get_from_starting_location(ledge_banshees_01.right), "banshee_d", unit(await this.player1())) == true);
            wake(new ScriptMethodReference(dogfight_firsttime_start));
            wake(new ScriptMethodReference(arm_02_entry_win));
            await this.sleep_second_halls();
            await this.sleep_bottling();
            this.bottling_power_on = false;
            device_operates_automatically_set(rec_center_entry_ext.Entity, false);
            device_one_sided_set(bottling_entry.Entity, true);
            device_one_sided_set(bottling_midway.Entity, true);
            device_one_sided_set(viewroom_entry.Entity, true);
            await sleep_until(async () => unit_in_vehicle(await this.player0()) && unit_in_vehicle(await this.player1()) || unit_in_vehicle(await this.player0()) && (bool)game_is_cooperative() == false);
        }
    }
}