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
        public async Task x04_01_predict_stub()
        {
            Engine.wake(new ScriptMethodReference(x04_01_predict));
        }

        [ScriptMethod(25, Lifecycle.Static)]
        public async Task x04_02a_predict_stub()
        {
            Engine.wake(new ScriptMethodReference(x04_02a_predict));
        }

        [ScriptMethod(26, Lifecycle.Static)]
        public async Task x04_02b_predict_stub()
        {
            Engine.wake(new ScriptMethodReference(x04_02b_predict));
        }

        [ScriptMethod(27, Lifecycle.Static)]
        public async Task x04_03b_predict_stub()
        {
            Engine.wake(new ScriptMethodReference(x04_03b_predict));
        }

        [ScriptMethod(28, Lifecycle.Static)]
        public async Task x04_04_predict_stub()
        {
            Engine.wake(new ScriptMethodReference(x04_04_predict));
        }

        [ScriptMethod(29, Lifecycle.Static)]
        public async Task x04_05_predict_stub()
        {
            Engine.wake(new ScriptMethodReference(x04_05_predict));
        }

        [ScriptMethod(30, Lifecycle.Static)]
        public async Task x04_06_predict_stub()
        {
            Engine.wake(new ScriptMethodReference(x04_06_predict));
        }

        [ScriptMethod(31, Lifecycle.Static)]
        public async Task x04_07_predict_stub()
        {
            Engine.wake(new ScriptMethodReference(x04_07_predict));
        }

        [ScriptMethod(32, Lifecycle.Static)]
        public async Task x04_08_predict_stub()
        {
            Engine.wake(new ScriptMethodReference(x04_08_predict));
        }

        [ScriptMethod(33, Lifecycle.Static)]
        public async Task x04_09_predict_stub()
        {
            Engine.wake(new ScriptMethodReference(x04_09_predict));
        }

        [ScriptMethod(34, Lifecycle.Static)]
        public async Task x04_10_predict_stub()
        {
            Engine.wake(new ScriptMethodReference(x04_10_predict));
        }

        [ScriptMethod(35, Lifecycle.Static)]
        public async Task _04_intro_01_predict_stub()
        {
            Engine.wake(new ScriptMethodReference(_04_intro_01_predict));
        }

        [ScriptMethod(36, Lifecycle.Static)]
        public async Task _04_intro_02a_predict_stub()
        {
            Engine.wake(new ScriptMethodReference(_04_intro_02a_predict));
        }

        [ScriptMethod(37, Lifecycle.Static)]
        public async Task _04_intro_02b_predict_stub()
        {
            Engine.wake(new ScriptMethodReference(_04_intro_02b_predict));
        }

        [ScriptMethod(38, Lifecycle.Static)]
        public async Task _04_intro_02c_predict_stub()
        {
            Engine.wake(new ScriptMethodReference(_04_intro_02c_predict));
        }

        [ScriptMethod(39, Lifecycle.Static)]
        public async Task _04_intro_02d_predict_stub()
        {
            Engine.wake(new ScriptMethodReference(_04_intro_02d_predict));
        }

        [ScriptMethod(40, Lifecycle.Static)]
        public async Task _04_intro_03_predict_stub()
        {
            Engine.wake(new ScriptMethodReference(_04_intro_03_predict));
        }

        [ScriptMethod(41, Lifecycle.Static)]
        public async Task _04_intro_05_predict_stub()
        {
            Engine.wake(new ScriptMethodReference(_04_intro_05_predict));
        }

        [ScriptMethod(42, Lifecycle.Static)]
        public async Task _04_intro_06b_predict_stub()
        {
            Engine.wake(new ScriptMethodReference(_04_intro_06b_predict));
        }

        [ScriptMethod(43, Lifecycle.Dormant)]
        public async Task x04_score_01()
        {
            await Engine.sleep(0);
            Engine.sound_impulse_start(Engine.GetTag<SoundTag>("sound\\cinematics\\04_alphagas\\x04\\music\\01_mus", 3826516638U), default(IGameObject), 1F);
            Engine.print("x04 score 01 start");
        }

        [ScriptMethod(44, Lifecycle.Dormant)]
        public async Task x04_foley_01()
        {
            await Engine.sleep(0);
            Engine.sound_impulse_start(Engine.GetTag<SoundTag>("sound\\cinematics\\04_alphagas\\x04\\foley\\x04_01_fol", 3826582175U), default(IGameObject), 1F);
            Engine.print("x04 foley 01 start");
        }

        [ScriptMethod(45, Lifecycle.Dormant)]
        public async Task x04_0010_bgr()
        {
            await Engine.sleep(483);
            Engine.sound_impulse_start(Engine.GetTag<SoundTag>("sound\\dialog\\levels\\04_gasgiant\\cinematic\\x04_0010_bgr", 3826647712U), brute_01.Entity, 1F);
            Engine.cinematic_subtitle("x04_0010_bgr", 5F);
        }

        [ScriptMethod(46, Lifecycle.Dormant)]
        public async Task x04_0020_bgl()
        {
            await Engine.sleep(633);
            Engine.sound_impulse_start(Engine.GetTag<SoundTag>("sound\\dialog\\levels\\04_gasgiant\\cinematic\\x04_0020_bgl", 3826713249U), brute_01.Entity, 1F);
            Engine.cinematic_subtitle("x04_0020_bgl", 2F);
        }

        [ScriptMethod(47, Lifecycle.Dormant)]
        public async Task x04_0040_jcr()
        {
            await Engine.sleep(693);
            Engine.sound_impulse_start(Engine.GetTag<SoundTag>("sound\\dialog\\levels\\04_gasgiant\\cinematic\\x04_0040_jcr", 3826778786U), jackal_01.Entity, 1F);
            Engine.cinematic_subtitle("x04_0040_jcr", 4F);
        }

        [ScriptMethod(48, Lifecycle.Dormant)]
        public async Task x04_0030_bgl()
        {
            await Engine.sleep(816);
            Engine.sound_impulse_start(Engine.GetTag<SoundTag>("sound\\dialog\\levels\\04_gasgiant\\cinematic\\x04_0030_bgl", 3826844323U), brute_01.Entity, 1F);
            Engine.cinematic_subtitle("x04_0030_bgl", 1.5F);
        }

        [ScriptMethod(49, Lifecycle.Dormant)]
        public async Task x04_0050_bgr()
        {
            await Engine.sleep(863);
            Engine.sound_impulse_start(Engine.GetTag<SoundTag>("sound\\dialog\\levels\\04_gasgiant\\cinematic\\x04_0050_bgr", 3826909860U), brute_02.Entity, 1F);
            Engine.cinematic_subtitle("x04_0050_bgr", 7.5F);
        }

        [ScriptMethod(50, Lifecycle.Dormant)]
        public async Task x04_cinematic_lighting_scene_01()
        {
            Engine.cinematic_lighting_set_primary_light(46F, 276F, 0.11F, 0.1F, 0.14F);
            Engine.cinematic_lighting_set_secondary_light(73F, 0F, 0.11F, 0.11F, 0.13F);
            Engine.cinematic_lighting_set_ambient_light(0.04F, 0.04F, 0.04F);
            Engine.rasterizer_bloom_override(true);
            Engine.rasterizer_bloom_override_threshold(0.3F);
            Engine.rasterizer_bloom_override_brightness(0.5F);
            Engine.object_uses_cinematic_lighting(dervish.Entity, true);
            Engine.object_uses_cinematic_lighting(tartarus.Entity, true);
            Engine.object_uses_cinematic_lighting(brute_01.Entity, true);
            Engine.object_uses_cinematic_lighting(brute_02.Entity, true);
            Engine.object_uses_cinematic_lighting(jackal_01.Entity, true);
            Engine.object_uses_cinematic_lighting(jackal_02.Entity, true);
            Engine.object_uses_cinematic_lighting(jackal_03.Entity, true);
            Engine.object_uses_cinematic_lighting(hammer.Entity, true);
        }

        [ScriptMethod(51, Lifecycle.Static)]
        public async Task x04_01_setup()
        {
            Engine.object_create_anew(dervish);
            Engine.object_create_anew(tartarus);
            Engine.object_create_anew(brute_01);
            Engine.object_create_anew(brute_02);
            Engine.object_create_anew(jackal_01);
            Engine.object_create_anew(jackal_02);
            Engine.object_create_anew(jackal_03);
            Engine.object_create_anew(hammer);
            Engine.object_cinematic_lod(dervish.Entity, true);
            Engine.object_cinematic_lod(tartarus.Entity, true);
            Engine.object_cinematic_lod(brute_01.Entity, true);
            Engine.object_cinematic_lod(brute_02.Entity, true);
            Engine.object_cinematic_lod(jackal_01.Entity, true);
            Engine.object_cinematic_lod(jackal_02.Entity, true);
            Engine.object_cinematic_lod(jackal_03.Entity, true);
            Engine.object_cinematic_lod(hammer.Entity, true);
            Engine.wake(new ScriptMethodReference(x04_0010_bgr));
            Engine.wake(new ScriptMethodReference(x04_0020_bgl));
            Engine.wake(new ScriptMethodReference(x04_0040_jcr));
            Engine.wake(new ScriptMethodReference(x04_0030_bgl));
            Engine.wake(new ScriptMethodReference(x04_0050_bgr));
            Engine.wake(new ScriptMethodReference(x04_score_01));
            Engine.wake(new ScriptMethodReference(x04_foley_01));
            Engine.wake(new ScriptMethodReference(x04_cinematic_lighting_scene_01));
        }

        [ScriptMethod(52, Lifecycle.Static)]
        public async Task x04_scene_01()
        {
            Engine.fade_out(0F, 0F, 0F, 0);
            Engine.camera_control(true);
            Engine.cinematic_start();
            this.cinematic_letterbox_style = 1;
            Engine.camera_set_field_of_view(60F, 0);
            Engine.cinematic_lightmap_shadow_enable();
            await this.x04_01_predict_stub();
            Engine.sound_impulse_predict(Engine.GetTag<SoundTag>("sound\\cinematics\\04_alphagas\\x04\\music\\01_mus", 3826516638U));
            Engine.sound_impulse_predict(Engine.GetTag<SoundTag>("sound\\cinematics\\04_alphagas\\x04\\foley\\x04_01_fol", 3826582175U));
            await Engine.sleep(this.prediction_offset);
            await this.x04_01_setup();
            Engine.camera_set_animation_relative(Engine.GetTag<AnimationGraphTag>("objects\\characters\\cinematic_camera\\x04\\x04", 3826975397U), "x04_01", default(IUnit), anchor_flag_x04a);
            Engine.custom_animation_relative(dervish.Entity, Engine.GetTag<AnimationGraphTag>("objects\\characters\\dervish\\x04\\x04", 3827040934U), "dervish_01", false, anchor_x04a.Entity);
            Engine.custom_animation_relative(tartarus.Entity, Engine.GetTag<AnimationGraphTag>("objects\\characters\\brute\\x04\\x04", 3827172008U), "tartarus_01", false, anchor_x04a.Entity);
            Engine.custom_animation_relative(brute_01.Entity, Engine.GetTag<AnimationGraphTag>("objects\\characters\\brute\\x04\\x04", 3827172008U), "brute01_01", false, anchor_x04a.Entity);
            Engine.custom_animation_relative(brute_02.Entity, Engine.GetTag<AnimationGraphTag>("objects\\characters\\brute\\x04\\x04", 3827172008U), "brute02_01", false, anchor_x04a.Entity);
            Engine.custom_animation_relative(jackal_01.Entity, Engine.GetTag<AnimationGraphTag>("objects\\characters\\jackal\\x04\\x04", 3827303082U), "jackal01_01", false, anchor_x04a.Entity);
            Engine.custom_animation_relative(jackal_02.Entity, Engine.GetTag<AnimationGraphTag>("objects\\characters\\jackal\\x04\\x04", 3827303082U), "jackal02_01", false, anchor_x04a.Entity);
            Engine.custom_animation_relative(jackal_03.Entity, Engine.GetTag<AnimationGraphTag>("objects\\characters\\jackal\\x04\\x04", 3827303082U), "jackal03_01", false, anchor_x04a.Entity);
            Engine.scenery_animation_start_relative(hammer.Entity, Engine.GetTag<AnimationGraphTag>("objects\\weapons\\melee\\gravity_hammer\\x04\\x04", 3827368619U), "hammer_01", anchor_x04a.Entity);
            Engine.interpolator_start("blurry_vision", 1F, 0.001F);
            await Engine.sleep(30);
            Engine.fade_in(0F, 0F, 0F, 30);
            await Engine.sleep(45);
            Engine.fade_out(0F, 0F, 0F, 30);
            await Engine.sleep(45);
            Engine.fade_in(0F, 0F, 0F, 20);
            Engine.interpolator_start("blurry_vision", 0F, 2F);
            await Engine.sleep(30);
            Engine.fade_out(0F, 0F, 0F, 20);
            await Engine.sleep(20);
            Engine.interpolator_start("blurry_vision", 1F, 0.001F);
            await Engine.sleep(25);
            Engine.fade_in(0F, 0F, 0F, 10);
            Engine.interpolator_start("blurry_vision", 0F, 2F);
            await Engine.sleep((short)((float)Engine.camera_time() - this.prediction_offset));
            await this.x04_02a_predict_stub();
            await Engine.sleep((short)((float)Engine.camera_time() - this.sound_offset));
            Engine.sound_impulse_predict(Engine.GetTag<SoundTag>("sound\\cinematics\\04_alphagas\\x04\\foley\\x04_02a_fol", 3827434156U));
            await Engine.sleep((short)Engine.camera_time());
        }

        [ScriptMethod(53, Lifecycle.Dormant)]
        public async Task x04_foley_02a()
        {
            await Engine.sleep(0);
            Engine.sound_impulse_start(Engine.GetTag<SoundTag>("sound\\cinematics\\04_alphagas\\x04\\foley\\x04_02a_fol", 3827434156U), default(IGameObject), 1F);
            Engine.print("x04 foley 02a start");
        }

        [ScriptMethod(54, Lifecycle.Dormant)]
        public async Task x04_0060_tar()
        {
            await Engine.sleep(173);
            Engine.sound_impulse_start(Engine.GetTag<SoundTag>("sound\\dialog\\levels\\04_gasgiant\\cinematic\\x04_0060_tar", 3827499693U), tartarus.Entity, 1F);
            Engine.cinematic_subtitle("x04_0060_tar", 4F);
        }

        [ScriptMethod(55, Lifecycle.Dormant)]
        public async Task x04_0070_tar()
        {
            await Engine.sleep(300);
            Engine.sound_impulse_start(Engine.GetTag<SoundTag>("sound\\dialog\\levels\\04_gasgiant\\cinematic\\x04_0070_tar", 3827565230U), tartarus.Entity, 1F);
            Engine.cinematic_subtitle("x04_0070_tar", 2F);
        }

        [ScriptMethod(56, Lifecycle.Dormant)]
        public async Task x04_0080_tar()
        {
            await Engine.sleep(370);
            Engine.sound_impulse_start(Engine.GetTag<SoundTag>("sound\\dialog\\levels\\04_gasgiant\\cinematic\\x04_0080_tar", 3827630767U), tartarus.Entity, 1F);
            Engine.cinematic_subtitle("x04_0080_tar", 3.5F);
            await Engine.sleep(15);
            Engine.unit_set_emotional_state(tartarus.Entity, "inquisitive", 0.75F, 90);
        }

        [ScriptMethod(57, Lifecycle.Dormant)]
        public async Task x04_button_delete()
        {
            await Engine.sleep(361);
            Engine.print("button_delete");
            Engine.object_destroy(x04_button.Entity);
        }

        [ScriptMethod(58, Lifecycle.Dormant)]
        public async Task x04_door_open()
        {
            await Engine.sleep(455);
            Engine.print("door open");
            Engine.device_set_position(x04_door_01.Entity, 1F);
        }

        [ScriptMethod(59, Lifecycle.Static)]
        public async Task x04_02a_setup()
        {
            Engine.object_create_anew(x04_button);
            Engine.wake(new ScriptMethodReference(x04_foley_02a));
            Engine.wake(new ScriptMethodReference(x04_0060_tar));
            Engine.wake(new ScriptMethodReference(x04_0070_tar));
            Engine.wake(new ScriptMethodReference(x04_0080_tar));
            Engine.wake(new ScriptMethodReference(x04_door_open));
            Engine.wake(new ScriptMethodReference(x04_button_delete));
        }

        [ScriptMethod(60, Lifecycle.Static)]
        public async Task x04_scene_02a()
        {
            await this.x04_02a_setup();
            Engine.camera_set_field_of_view(70F, 0);
            Engine.print("fov change: 60 -> 70 over 0 ticks");
            Engine.camera_set_animation_relative(Engine.GetTag<AnimationGraphTag>("objects\\characters\\cinematic_camera\\x04\\x04", 3826975397U), "x04_02a", default(IUnit), anchor_flag_x04a);
            Engine.custom_animation_relative(dervish.Entity, Engine.GetTag<AnimationGraphTag>("objects\\characters\\dervish\\x04\\x04", 3827040934U), "dervish_02a", false, anchor_x04a.Entity);
            Engine.custom_animation_relative(tartarus.Entity, Engine.GetTag<AnimationGraphTag>("objects\\characters\\brute\\x04\\x04", 3827172008U), "tartarus_02a", false, anchor_x04a.Entity);
            Engine.custom_animation_relative(brute_01.Entity, Engine.GetTag<AnimationGraphTag>("objects\\characters\\brute\\x04\\x04", 3827172008U), "brute01_02a", false, anchor_x04a.Entity);
            Engine.custom_animation_relative(brute_02.Entity, Engine.GetTag<AnimationGraphTag>("objects\\characters\\brute\\x04\\x04", 3827172008U), "brute02_02a", false, anchor_x04a.Entity);
            Engine.scenery_animation_start_relative(hammer.Entity, Engine.GetTag<AnimationGraphTag>("objects\\weapons\\melee\\gravity_hammer\\x04\\x04", 3827368619U), "hammer_02a", anchor_x04a.Entity);
            await Engine.sleep((short)((float)Engine.camera_time() - this.prediction_offset));
            await this.x04_02b_predict_stub();
            await Engine.sleep((short)((float)Engine.camera_time() - this.sound_offset));
            Engine.sound_impulse_predict(Engine.GetTag<SoundTag>("sound\\cinematics\\04_alphagas\\x04\\foley\\x04_02b_fol", 3827696304U));
            await Engine.sleep((short)((float)Engine.camera_time() - 15));
            Engine.fade_out(1F, 1F, 1F, 15);
            await Engine.sleep(15);
            Engine.object_destroy(x04_door_01.Entity);
        }

        [ScriptMethod(61, Lifecycle.Dormant)]
        public async Task x04_foley_2b()
        {
            await Engine.sleep(0);
            Engine.sound_impulse_start(Engine.GetTag<SoundTag>("sound\\cinematics\\04_alphagas\\x04\\foley\\x04_02b_fol", 3827696304U), default(IGameObject), 1F);
            Engine.print("x04 foley 02b start");
        }

        [ScriptMethod(62, Lifecycle.Dormant)]
        public async Task x04_02b_fov()
        {
            await Engine.sleep(140);
            Engine.camera_set_field_of_view(80F, 0);
            Engine.print("fov change: 70 -> 80 over 0 ticks");
        }

        [ScriptMethod(63, Lifecycle.Dormant)]
        public async Task x04_cinematic_lighting_02b()
        {
            Engine.cinematic_lighting_set_primary_light(68F, 336F, 0.25F, 0.24F, 0.36F);
            Engine.cinematic_lighting_set_secondary_light(0F, 24F, 0.18F, 0.13F, 0.2F);
            Engine.cinematic_lighting_set_ambient_light(0.03F, 0.03F, 0.03F);
        }

        [ScriptMethod(64, Lifecycle.Static)]
        public async Task x04_02b_setup()
        {
            Engine.object_create_anew(jail_ledge);
            Engine.object_uses_cinematic_lighting(jail_ledge.Entity, true);
            Engine.wake(new ScriptMethodReference(x04_foley_2b));
            Engine.wake(new ScriptMethodReference(x04_02b_fov));
            Engine.wake(new ScriptMethodReference(x04_cinematic_lighting_02b));
        }

        [ScriptMethod(65, Lifecycle.Static)]
        public async Task x04_02b_cleanup()
        {
            Engine.object_destroy(jail_ledge.Entity);
            Engine.object_destroy_containing("jackal");
        }

        [ScriptMethod(66, Lifecycle.Static)]
        public async Task x04_scene_02b()
        {
            Engine.cinematic_lightmap_shadow_disable();
            await this.x04_02b_setup();
            Engine.camera_set_animation_relative(Engine.GetTag<AnimationGraphTag>("objects\\characters\\cinematic_camera\\x04\\x04", 3826975397U), "x04_02b", default(IUnit), anchor_flag_x04a);
            Engine.custom_animation_relative(dervish.Entity, Engine.GetTag<AnimationGraphTag>("objects\\characters\\dervish\\x04\\x04", 3827040934U), "dervish_02b", false, anchor_x04a.Entity);
            Engine.custom_animation_relative(tartarus.Entity, Engine.GetTag<AnimationGraphTag>("objects\\characters\\brute\\x04\\x04", 3827172008U), "tartarus_02b", false, anchor_x04a.Entity);
            Engine.custom_animation_relative(brute_01.Entity, Engine.GetTag<AnimationGraphTag>("objects\\characters\\brute\\x04\\x04", 3827172008U), "brute01_02b", false, anchor_x04a.Entity);
            Engine.custom_animation_relative(brute_02.Entity, Engine.GetTag<AnimationGraphTag>("objects\\characters\\brute\\x04\\x04", 3827172008U), "brute02_02b", false, anchor_x04a.Entity);
            Engine.scenery_animation_start_relative(hammer.Entity, Engine.GetTag<AnimationGraphTag>("objects\\weapons\\melee\\gravity_hammer\\x04\\x04", 3827368619U), "hammer_02b", anchor_x04a.Entity);
            Engine.scenery_animation_start_relative(jail_ledge.Entity, Engine.GetTag<AnimationGraphTag>("scenarios\\objects\\solo\\highcharity\\high_jail_ledge\\x04\\x04", 3827761841U), "ledge_02b", anchor_x04a.Entity);
            Engine.fade_in(1F, 1F, 1F, 15);
            await Engine.sleep((short)((float)Engine.camera_time() - this.prediction_offset));
            await this.x04_03b_predict_stub();
            await Engine.sleep((short)((float)Engine.camera_time() - this.sound_offset));
            Engine.sound_impulse_predict(Engine.GetTag<SoundTag>("sound\\cinematics\\04_alphagas\\x04\\foley\\x04_03b_fol", 3827827378U));
            await Engine.sleep((short)Engine.camera_time());
        }

        [ScriptMethod(67, Lifecycle.Dormant)]
        public async Task x04_foley_03b()
        {
            await Engine.sleep(0);
            Engine.sound_impulse_start(Engine.GetTag<SoundTag>("sound\\cinematics\\04_alphagas\\x04\\foley\\x04_03b_fol", 3827827378U), default(IGameObject), 1F);
            Engine.print("x04 foley 03b start");
        }

        [ScriptMethod(68, Lifecycle.Dormant)]
        public async Task x04_03b_dof_1()
        {
            await Engine.sleep(91);
            Engine.cinematic_screen_effect_start(true);
            Engine.cinematic_screen_effect_set_depth_of_field(1F, 0.5F, 0.5F, 0.001F, 0F, 0F, 0.001F);
            Engine.print("rack focus");
            await Engine.sleep(138);
            Engine.cinematic_screen_effect_stop();
            Engine.print("rack focus stop");
        }

        [ScriptMethod(69, Lifecycle.Dormant)]
        public async Task x04_cinematic_lighting_03b()
        {
            Engine.cinematic_lighting_set_primary_light(65F, 0F, 0.24F, 0.24F, 0.31F);
            Engine.cinematic_lighting_set_secondary_light(0F, 26F, 0.21F, 0.18F, 0.15F);
            Engine.cinematic_lighting_set_ambient_light(0.05F, 0.05F, 0.05F);
            Engine.object_uses_cinematic_lighting(honor_guard_02.Entity, true);
            Engine.object_uses_cinematic_lighting(honor_guard_04.Entity, true);
            Engine.object_uses_cinematic_lighting(honor_guard_05.Entity, true);
            Engine.object_uses_cinematic_lighting(honor_guard_06.Entity, true);
            Engine.object_uses_cinematic_lighting(honor_guard_14.Entity, true);
            Engine.object_uses_cinematic_lighting(honor_guard_15.Entity, true);
            Engine.object_uses_cinematic_lighting(honor_guard_16.Entity, true);
            Engine.object_uses_cinematic_lighting(honor_guard_17.Entity, true);
            Engine.object_uses_cinematic_lighting(honor_guard_18.Entity, true);
            Engine.object_uses_cinematic_lighting(honor_guard_19.Entity, true);
            Engine.object_uses_cinematic_lighting(honor_guard_20.Entity, true);
            Engine.object_uses_cinematic_lighting(honor_guard_28.Entity, true);
            Engine.object_uses_cinematic_lighting(honor_guard_29.Entity, true);
            Engine.object_uses_cinematic_lighting(honor_guard_30.Entity, true);
        }

        [ScriptMethod(70, Lifecycle.Static)]
        public async Task x04_03b_setup()
        {
            Engine.object_create_anew_containing("honor_guard");
            Engine.wake(new ScriptMethodReference(x04_foley_03b));
            Engine.wake(new ScriptMethodReference(x04_cinematic_lighting_03b));
        }

        [ScriptMethod(71, Lifecycle.Static)]
        public async Task x04_scene_03b()
        {
            await this.x04_03b_setup();
            Engine.camera_set_field_of_view(60F, 0);
            Engine.print("fov change: 80 -> 60 over 0 ticks");
            Engine.camera_set_animation_relative(Engine.GetTag<AnimationGraphTag>("objects\\characters\\cinematic_camera\\x04\\x04", 3826975397U), "x04_03b", default(IUnit), anchor_flag_x04a);
            Engine.custom_animation_relative(dervish.Entity, Engine.GetTag<AnimationGraphTag>("objects\\characters\\dervish\\x04\\x04", 3827040934U), "dervish_03b", false, anchor_x04a.Entity);
            Engine.custom_animation_relative(tartarus.Entity, Engine.GetTag<AnimationGraphTag>("objects\\characters\\brute\\x04\\x04", 3827172008U), "tartarus_03b", false, anchor_x04a.Entity);
            Engine.custom_animation_relative(brute_01.Entity, Engine.GetTag<AnimationGraphTag>("objects\\characters\\brute\\x04\\x04", 3827172008U), "brute01_03b", false, anchor_x04a.Entity);
            Engine.custom_animation_relative(brute_02.Entity, Engine.GetTag<AnimationGraphTag>("objects\\characters\\brute\\x04\\x04", 3827172008U), "brute02_03b", false, anchor_x04a.Entity);
            Engine.scenery_animation_start_relative(hammer.Entity, Engine.GetTag<AnimationGraphTag>("objects\\weapons\\melee\\gravity_hammer\\x04\\x04", 3827368619U), "hammer_03b", anchor_x04a.Entity);
            await Engine.sleep((short)((float)Engine.camera_time() - this.prediction_offset));
            await this.x04_04_predict_stub();
            await Engine.sleep((short)((float)Engine.camera_time() - this.sound_offset));
            Engine.sound_impulse_predict(Engine.GetTag<SoundTag>("sound\\cinematics\\04_alphagas\\x04\\foley\\x04_04_fol", 3827892915U));
            await Engine.sleep((short)((float)Engine.camera_time() - 30));
            Engine.cinematic_screen_effect_start(true);
            await Engine.sleep((short)((float)Engine.camera_time() - 5));
            Engine.cinematic_screen_effect_set_crossfade(2F);
            Engine.print("crossfade");
            await Engine.sleep(5);
            Engine.object_destroy_containing("honor_guard");
        }

        [ScriptMethod(72, Lifecycle.Dormant)]
        public async Task x04_foley_04()
        {
            await Engine.sleep(0);
            Engine.sound_impulse_start(Engine.GetTag<SoundTag>("sound\\cinematics\\04_alphagas\\x04\\foley\\x04_04_fol", 3827892915U), default(IGameObject), 1F);
            Engine.print("x04 foley 04 start");
        }

        [ScriptMethod(73, Lifecycle.Dormant)]
        public async Task x04_cinematic_lighting_scene_04()
        {
            Engine.cinematic_lighting_set_primary_light(65F, 0F, 0.34F, 0.34F, 0.41F);
            Engine.cinematic_lighting_set_secondary_light(0F, 26F, 0.21F, 0.18F, 0.15F);
            Engine.cinematic_lighting_set_ambient_light(0.05F, 0.05F, 0.05F);
            Engine.object_uses_cinematic_lighting(truth.Entity, true);
            Engine.object_uses_cinematic_lighting(mercy.Entity, true);
            Engine.object_uses_cinematic_lighting(throne_truth.Entity, true);
            Engine.object_uses_cinematic_lighting(throne_mercy.Entity, true);
            Engine.object_uses_cinematic_lighting(sarcophagus.Entity, true);
        }

        [ScriptMethod(74, Lifecycle.Static)]
        public async Task x04_04_setup()
        {
            Engine.object_create_anew(truth);
            Engine.object_create_anew(mercy);
            Engine.object_create_anew_containing("throne");
            Engine.object_create_anew(sarcophagus);
            Engine.object_cinematic_lod(truth.Entity, true);
            Engine.object_cinematic_lod(mercy.Entity, true);
            Engine.object_cinematic_lod(throne_truth.Entity, true);
            Engine.object_cinematic_lod(throne_mercy.Entity, true);
            Engine.objects_attach(truth.Entity, "driver", throne_truth.Entity, "driver_cinematic");
            Engine.objects_attach(mercy.Entity, "driver", throne_mercy.Entity, "driver_cinematic");
            Engine.wake(new ScriptMethodReference(x04_foley_04));
            Engine.wake(new ScriptMethodReference(x04_cinematic_lighting_scene_04));
        }

        [ScriptMethod(75, Lifecycle.Static)]
        public async Task x04_scene_04()
        {
            await this.x04_04_setup();
            Engine.camera_set_animation_relative(Engine.GetTag<AnimationGraphTag>("objects\\characters\\cinematic_camera\\x04\\x04", 3826975397U), "x04_04", default(IUnit), anchor_flag_x04b);
            Engine.custom_animation_relative(dervish.Entity, Engine.GetTag<AnimationGraphTag>("objects\\characters\\dervish\\x04\\x04", 3827040934U), "dervish_04", false, anchor_x04b.Entity);
            Engine.custom_animation_relative(tartarus.Entity, Engine.GetTag<AnimationGraphTag>("objects\\characters\\brute\\x04\\x04", 3827172008U), "tartarus_04", false, anchor_x04b.Entity);
            Engine.custom_animation_relative(truth.Entity, Engine.GetTag<AnimationGraphTag>("objects\\characters\\prophet\\x04\\x04", 3827958452U), "truth_04", false, anchor_x04b.Entity);
            Engine.custom_animation_relative(mercy.Entity, Engine.GetTag<AnimationGraphTag>("objects\\characters\\prophet\\x04\\x04", 3827958452U), "mercy_04", false, anchor_x04b.Entity);
            Engine.custom_animation_relative(brute_01.Entity, Engine.GetTag<AnimationGraphTag>("objects\\characters\\brute\\x04\\x04", 3827172008U), "brute01_04", false, anchor_x04b.Entity);
            Engine.custom_animation_relative(brute_02.Entity, Engine.GetTag<AnimationGraphTag>("objects\\characters\\brute\\x04\\x04", 3827172008U), "brute02_04", false, anchor_x04b.Entity);
            Engine.scenery_animation_start_relative(hammer.Entity, Engine.GetTag<AnimationGraphTag>("objects\\weapons\\melee\\gravity_hammer\\x04\\x04", 3827368619U), "hammer_04", anchor_x04b.Entity);
            Engine.scenery_animation_start_relative(sarcophagus.Entity, Engine.GetTag<AnimationGraphTag>("scenarios\\objects\\solo\\alphagasgiant\\sarcophagus\\sarcophagus", 3828089526U), "x04_04", anchor_x04b.Entity);
            await Engine.sleep((short)((float)Engine.camera_time() - this.prediction_offset));
            await this.x04_05_predict_stub();
            await Engine.sleep((short)((float)Engine.camera_time() - this.sound_offset));
            Engine.sound_impulse_predict(Engine.GetTag<SoundTag>("sound\\cinematics\\04_alphagas\\x04\\foley\\x04_05_fol", 3828155063U));
            await Engine.sleep((short)Engine.camera_time());
        }

        [ScriptMethod(76, Lifecycle.Dormant)]
        public async Task x04_foley_05()
        {
            await Engine.sleep(0);
            Engine.sound_impulse_start(Engine.GetTag<SoundTag>("sound\\cinematics\\04_alphagas\\x04\\foley\\x04_05_fol", 3828155063U), default(IGameObject), 1F);
            Engine.print("x04 foley 05 start");
        }

        [ScriptMethod(77, Lifecycle.Dormant)]
        public async Task x04_0090_tar()
        {
            await Engine.sleep(0);
            Engine.sound_impulse_start(Engine.GetTag<SoundTag>("sound\\dialog\\levels\\04_gasgiant\\cinematic\\x04_0090_tar", 3828220600U), tartarus.Entity, 1F);
            Engine.cinematic_subtitle("x04_0090_tar", 5.5F);
        }

        [ScriptMethod(78, Lifecycle.Dormant)]
        public async Task x04_0100_pot()
        {
            await Engine.sleep(157);
            Engine.sound_impulse_start(Engine.GetTag<SoundTag>("sound\\dialog\\levels\\04_gasgiant\\cinematic\\x04_0100_pot", 3828286137U), truth.Entity, 1F);
            Engine.cinematic_subtitle("x04_0100_pot", 2F);
        }

        [ScriptMethod(79, Lifecycle.Dormant)]
        public async Task x04_0110_tar()
        {
            await Engine.sleep(205);
            Engine.sound_impulse_start(Engine.GetTag<SoundTag>("sound\\dialog\\levels\\04_gasgiant\\cinematic\\x04_0110_tar", 3828351674U), tartarus.Entity, 1F);
            Engine.cinematic_subtitle("x04_0110_tar", 2F);
        }

        [ScriptMethod(80, Lifecycle.Dormant)]
        public async Task x04_0120_pot()
        {
            await Engine.sleep(242);
            Engine.sound_impulse_start(Engine.GetTag<SoundTag>("sound\\dialog\\levels\\04_gasgiant\\cinematic\\x04_0120_pot", 3828417211U), truth.Entity, 1F);
            Engine.cinematic_subtitle("x04_0120_pot", 2F);
        }

        [ScriptMethod(81, Lifecycle.Dormant)]
        public async Task x04_0130_tar()
        {
            await Engine.sleep(385);
            Engine.sound_impulse_start(Engine.GetTag<SoundTag>("sound\\dialog\\levels\\04_gasgiant\\cinematic\\x04_0130_tar", 3828482748U), tartarus.Entity, 1F);
            Engine.cinematic_subtitle("x04_0130_tar", 1.5F);
        }

        [ScriptMethod(82, Lifecycle.Dormant)]
        public async Task x04_0140_pot()
        {
            await Engine.sleep(554);
            Engine.sound_impulse_start(Engine.GetTag<SoundTag>("sound\\dialog\\levels\\04_gasgiant\\cinematic\\x04_0140_pot", 3828548285U), truth.Entity, 1F);
            Engine.cinematic_subtitle("x04_0140_pot", 5F);
        }

        [ScriptMethod(83, Lifecycle.Dormant)]
        public async Task x04_0150_pot()
        {
            await Engine.sleep(731);
            Engine.sound_impulse_start(Engine.GetTag<SoundTag>("sound\\dialog\\levels\\04_gasgiant\\cinematic\\x04_0150_pot", 3828613822U), truth.Entity, 1F);
            Engine.cinematic_subtitle("x04_0150_pot", 4F);
        }

        [ScriptMethod(84, Lifecycle.Dormant)]
        public async Task x04_05_dof_1()
        {
            await Engine.sleep(708);
            Engine.cinematic_screen_effect_start(true);
            Engine.cinematic_screen_effect_set_depth_of_field(2F, 0F, 0F, 0.001F, 0.5F, 0.5F, 0.001F);
            Engine.print("rack focus");
        }

        [ScriptMethod(85, Lifecycle.Dormant)]
        public async Task x04_cinematic_lighting_scene_05()
        {
            Engine.cinematic_lighting_set_primary_light(-41F, 270F, 0.25F, 0.32F, 0.52F);
            Engine.cinematic_lighting_set_secondary_light(58F, 78F, 0.21F, 0.11F, 0.22F);
            Engine.cinematic_lighting_set_ambient_light(0.06F, 0.05F, 0.04F);
            Engine.rasterizer_bloom_override_threshold(0.25F);
            Engine.rasterizer_bloom_override_brightness(0.8F);
            Engine.print("new bloom .25 .8");
            Engine.render_lights_enable_cinematic_shadow(true, dervish.Entity, "head", 0.2F);
            Engine.render_lights_enable_cinematic_shadow(true, truth.Entity, "head", 0.2F);
            Engine.render_lights_enable_cinematic_shadow(true, mercy.Entity, "head", 0.2F);
            Engine.render_lights_enable_cinematic_shadow(true, tartarus.Entity, "head", 0.2F);
        }

        [ScriptMethod(86, Lifecycle.Static)]
        public async Task x04_05_setup()
        {
            Engine.wake(new ScriptMethodReference(x04_foley_05));
            Engine.wake(new ScriptMethodReference(x04_0090_tar));
            Engine.wake(new ScriptMethodReference(x04_0100_pot));
            Engine.wake(new ScriptMethodReference(x04_0110_tar));
            Engine.wake(new ScriptMethodReference(x04_0120_pot));
            Engine.wake(new ScriptMethodReference(x04_0130_tar));
            Engine.wake(new ScriptMethodReference(x04_0140_pot));
            Engine.wake(new ScriptMethodReference(x04_0150_pot));
            Engine.wake(new ScriptMethodReference(x04_cinematic_lighting_scene_05));
        }

        [ScriptMethod(87, Lifecycle.Static)]
        public async Task x04_05_cleanup()
        {
            Engine.object_destroy(tartarus.Entity);
            Engine.object_destroy(brute_01.Entity);
            Engine.object_destroy(brute_02.Entity);
            Engine.object_destroy(hammer.Entity);
        }

        [ScriptMethod(88, Lifecycle.Static)]
        public async Task x04_scene_05()
        {
            await this.x04_05_setup();
            Engine.cinematic_set_near_clip_distance(0.05F);
            Engine.print("setting near distance to .05");
            Engine.camera_set_animation_relative(Engine.GetTag<AnimationGraphTag>("objects\\characters\\cinematic_camera\\x04\\x04", 3826975397U), "x04_05", default(IUnit), anchor_flag_x04b);
            Engine.custom_animation_relative(dervish.Entity, Engine.GetTag<AnimationGraphTag>("objects\\characters\\dervish\\x04\\x04", 3827040934U), "dervish_05", false, anchor_x04b.Entity);
            Engine.custom_animation_relative(tartarus.Entity, Engine.GetTag<AnimationGraphTag>("objects\\characters\\brute\\x04\\x04", 3827172008U), "tartarus_05", false, anchor_x04b.Entity);
            Engine.custom_animation_relative(truth.Entity, Engine.GetTag<AnimationGraphTag>("objects\\characters\\prophet\\x04\\x04", 3827958452U), "truth_05", false, anchor_x04b.Entity);
            Engine.custom_animation_relative(brute_01.Entity, Engine.GetTag<AnimationGraphTag>("objects\\characters\\brute\\x04\\x04", 3827172008U), "brute01_05", false, anchor_x04b.Entity);
            Engine.custom_animation_relative(brute_02.Entity, Engine.GetTag<AnimationGraphTag>("objects\\characters\\brute\\x04\\x04", 3827172008U), "brute02_05", false, anchor_x04b.Entity);
            Engine.scenery_animation_start_relative(hammer.Entity, Engine.GetTag<AnimationGraphTag>("objects\\weapons\\melee\\gravity_hammer\\x04\\x04", 3827368619U), "hammer_05", anchor_x04b.Entity);
            Engine.scenery_animation_start_relative(sarcophagus.Entity, Engine.GetTag<AnimationGraphTag>("scenarios\\objects\\solo\\alphagasgiant\\sarcophagus\\sarcophagus", 3828089526U), "x04_05", anchor_x04b.Entity);
            await Engine.sleep((short)((float)Engine.camera_time() - this.prediction_offset));
            await this.x04_06_predict_stub();
            await Engine.sleep((short)((float)Engine.camera_time() - this.sound_offset));
            Engine.sound_impulse_predict(Engine.GetTag<SoundTag>("sound\\cinematics\\04_alphagas\\x04\\music\\06_mus", 3828679359U));
            Engine.sound_impulse_predict(Engine.GetTag<SoundTag>("sound\\cinematics\\04_alphagas\\x04\\foley\\x04_06_fol", 3828744896U));
            await Engine.sleep((short)Engine.camera_time());
            await this.x04_05_cleanup();
        }

        [ScriptMethod(89, Lifecycle.Dormant)]
        public async Task x04_score_06()
        {
            await Engine.sleep(0);
            Engine.sound_impulse_start(Engine.GetTag<SoundTag>("sound\\cinematics\\04_alphagas\\x04\\music\\06_mus", 3828679359U), default(IGameObject), 1F);
            Engine.print("x04 score 06 start");
        }

        [ScriptMethod(90, Lifecycle.Dormant)]
        public async Task x04_foley_06()
        {
            await Engine.sleep(0);
            Engine.sound_impulse_start(Engine.GetTag<SoundTag>("sound\\cinematics\\04_alphagas\\x04\\foley\\x04_06_fol", 3828744896U), default(IGameObject), 1F);
            Engine.print("x04 foley 06 start");
        }

        [ScriptMethod(91, Lifecycle.Dormant)]
        public async Task x04_0160_der()
        {
            await Engine.sleep(0);
            Engine.sound_impulse_start(Engine.GetTag<SoundTag>("sound\\dialog\\levels\\04_gasgiant\\cinematic\\x04_0160_der", 3828810433U), dervish.Entity, 1F);
            Engine.cinematic_subtitle("x04_0160_der", 2F);
        }

        [ScriptMethod(92, Lifecycle.Dormant)]
        public async Task x04_0170_pot()
        {
            await Engine.sleep(46);
            Engine.sound_impulse_start(Engine.GetTag<SoundTag>("sound\\dialog\\levels\\04_gasgiant\\cinematic\\x04_0170_pot", 3828875970U), truth.Entity, 1F);
            Engine.cinematic_subtitle("x04_0170_pot", 1.25F);
        }

        [ScriptMethod(93, Lifecycle.Dormant)]
        public async Task x04_0180_pot()
        {
            await Engine.sleep(104);
            Engine.sound_impulse_start(Engine.GetTag<SoundTag>("sound\\dialog\\levels\\04_gasgiant\\cinematic\\x04_0180_pot", 3828941507U), truth.Entity, 1F);
            Engine.cinematic_subtitle("x04_0180_pot", 2F);
        }

        [ScriptMethod(94, Lifecycle.Dormant)]
        public async Task x04_0190_der()
        {
            await Engine.sleep(152);
            Engine.sound_impulse_start(Engine.GetTag<SoundTag>("sound\\dialog\\levels\\04_gasgiant\\cinematic\\x04_0190_der", 3829007044U), dervish.Entity, 1F);
            Engine.cinematic_subtitle("x04_0190_der", 3F);
        }

        [ScriptMethod(95, Lifecycle.Dormant)]
        public async Task x04_0200_pot()
        {
            await Engine.sleep(237);
            Engine.sound_impulse_start(Engine.GetTag<SoundTag>("sound\\dialog\\levels\\04_gasgiant\\cinematic\\x04_0200_pot", 3829072581U), truth.Entity, 1F);
            Engine.cinematic_subtitle("x04_0200_pot", 1.25F);
        }

        [ScriptMethod(96, Lifecycle.Dormant)]
        public async Task x04_0210_pot()
        {
            await Engine.sleep(301);
            Engine.sound_impulse_start(Engine.GetTag<SoundTag>("sound\\dialog\\levels\\04_gasgiant\\cinematic\\x04_0210_pot", 3829138118U), truth.Entity, 1F);
            Engine.cinematic_subtitle("x04_0210_pot", 11F);
        }

        [ScriptMethod(97, Lifecycle.Dormant)]
        public async Task x04_0220_pom()
        {
            await Engine.sleep(624);
            Engine.sound_impulse_start(Engine.GetTag<SoundTag>("sound\\dialog\\levels\\04_gasgiant\\cinematic\\x04_0220_pom", 3829203655U), mercy.Entity, 1F);
            Engine.cinematic_subtitle("x04_0220_pom", 8.25F);
        }

        [ScriptMethod(98, Lifecycle.Dormant)]
        public async Task x04_0230_der()
        {
            await Engine.sleep(851);
            Engine.sound_impulse_start(Engine.GetTag<SoundTag>("sound\\dialog\\levels\\04_gasgiant\\cinematic\\x04_0230_der", 3829269192U), dervish.Entity, 1F);
            Engine.cinematic_subtitle("x04_0230_der", 3.5F);
        }

        [ScriptMethod(99, Lifecycle.Dormant)]
        public async Task x04_0240_pot()
        {
            await Engine.sleep(955);
            Engine.sound_impulse_start(Engine.GetTag<SoundTag>("sound\\dialog\\levels\\04_gasgiant\\cinematic\\x04_0240_pot", 3829334729U), truth.Entity, 1F);
            Engine.cinematic_subtitle("x04_0240_pot", 10F);
        }

        [ScriptMethod(100, Lifecycle.Dormant)]
        public async Task x04_06_dof_1()
        {
            await Engine.sleep(0);
            Engine.cinematic_screen_effect_stop();
            Engine.print("rack focus stop");
            await Engine.sleep(280);
            Engine.cinematic_screen_effect_start(true);
            Engine.cinematic_screen_effect_set_depth_of_field(2F, 0F, 0F, 0F, 0.5F, 0.5F, 0F);
            Engine.print("rack focus");
            await Engine.sleep(118);
            Engine.cinematic_screen_effect_start(true);
            Engine.cinematic_screen_effect_set_depth_of_field(2F, 0.5F, 0.5F, 1F, 0F, 0F, 1F);
            Engine.print("rack focus");
            await Engine.sleep(87);
            Engine.cinematic_screen_effect_set_depth_of_field(2F, 0F, 0F, 0.001F, 0F, 0F, 0.001F);
            Engine.print("rack focus");
            await Engine.sleep(230);
            Engine.cinematic_screen_effect_set_depth_of_field(2F, 0F, 0F, 0.001F, 0.5F, 0.5F, 0.001F);
            Engine.print("rack focus");
            await Engine.sleep(179);
            Engine.cinematic_screen_effect_stop();
            Engine.print("rack focus stop");
        }

        [ScriptMethod(101, Lifecycle.Static)]
        public async Task x04_06_setup()
        {
            Engine.object_destroy_containing("brute");
            Engine.wake(new ScriptMethodReference(x04_score_06));
            Engine.wake(new ScriptMethodReference(x04_foley_06));
            Engine.wake(new ScriptMethodReference(x04_0160_der));
            Engine.wake(new ScriptMethodReference(x04_0170_pot));
            Engine.wake(new ScriptMethodReference(x04_0180_pot));
            Engine.wake(new ScriptMethodReference(x04_0190_der));
            Engine.wake(new ScriptMethodReference(x04_0200_pot));
            Engine.wake(new ScriptMethodReference(x04_0210_pot));
            Engine.wake(new ScriptMethodReference(x04_0220_pom));
            Engine.wake(new ScriptMethodReference(x04_0230_der));
            Engine.wake(new ScriptMethodReference(x04_0240_pot));
        }

        [ScriptMethod(102, Lifecycle.Static)]
        public async Task x04_scene_06()
        {
            await this.x04_06_setup();
            Engine.cinematic_set_near_clip_distance(0.06F);
            Engine.print("resetting near distance to .06");
            Engine.camera_set_animation_relative(Engine.GetTag<AnimationGraphTag>("objects\\characters\\cinematic_camera\\x04\\x04", 3826975397U), "x04_06", default(IUnit), anchor_flag_x04b);
            Engine.custom_animation_relative(dervish.Entity, Engine.GetTag<AnimationGraphTag>("objects\\characters\\dervish\\x04\\x04", 3827040934U), "dervish_06", false, anchor_x04b.Entity);
            Engine.custom_animation_relative(truth.Entity, Engine.GetTag<AnimationGraphTag>("objects\\characters\\prophet\\x04\\x04", 3827958452U), "truth_06", false, anchor_x04b.Entity);
            Engine.custom_animation_relative(mercy.Entity, Engine.GetTag<AnimationGraphTag>("objects\\characters\\prophet\\x04\\x04", 3827958452U), "mercy_06", false, anchor_x04b.Entity);
            Engine.scenery_animation_start_relative(sarcophagus.Entity, Engine.GetTag<AnimationGraphTag>("scenarios\\objects\\solo\\alphagasgiant\\sarcophagus\\sarcophagus", 3828089526U), "x04_06", anchor_x04b.Entity);
            await Engine.sleep((short)((float)Engine.camera_time() - this.prediction_offset));
            await this.x04_07_predict_stub();
            await Engine.sleep((short)((float)Engine.camera_time() - this.sound_offset));
            Engine.sound_impulse_predict(Engine.GetTag<SoundTag>("sound\\cinematics\\04_alphagas\\x04\\foley\\x04_07_fol", 3829400266U));
            await Engine.sleep((short)Engine.camera_time());
        }

        [ScriptMethod(103, Lifecycle.Dormant)]
        public async Task x04_foley_07()
        {
            await Engine.sleep(0);
            Engine.sound_impulse_start(Engine.GetTag<SoundTag>("sound\\cinematics\\04_alphagas\\x04\\foley\\x04_07_fol", 3829400266U), default(IGameObject), 1F);
            Engine.print("x04 foley 07 start");
        }

        [ScriptMethod(104, Lifecycle.Dormant)]
        public async Task x04_0250_pot()
        {
            await Engine.sleep(172);
            Engine.sound_impulse_start(Engine.GetTag<SoundTag>("sound\\dialog\\levels\\04_gasgiant\\cinematic\\x04_0250_pot", 3829465803U), truth.Entity, 1F);
            Engine.cinematic_subtitle("x04_0250_pot", 8F);
        }

        [ScriptMethod(105, Lifecycle.Dormant)]
        public async Task x04_0260_hld()
        {
            await Engine.sleep(400);
            Engine.sound_impulse_start(Engine.GetTag<SoundTag>("sound\\dialog\\levels\\04_gasgiant\\cinematic\\x04_0260_her", 3829531340U), heretic_leader_holo_01.Entity, 1F);
            Engine.cinematic_subtitle("x04_0260_her", 10.5F);
        }

        [ScriptMethod(106, Lifecycle.Dormant)]
        public async Task x04_0270_pot()
        {
            await Engine.sleep(719);
            Engine.sound_impulse_start(Engine.GetTag<SoundTag>("sound\\dialog\\levels\\04_gasgiant\\cinematic\\x04_0270_pot", 3829596877U), truth.Entity, 1F);
            Engine.cinematic_subtitle("x04_0270_pot", 5F);
        }

        [ScriptMethod(107, Lifecycle.Dormant)]
        public async Task x04_0280_pom()
        {
            await Engine.sleep(872);
            Engine.sound_impulse_start(Engine.GetTag<SoundTag>("sound\\dialog\\levels\\04_gasgiant\\cinematic\\x04_0280_pom", 3829662414U), mercy.Entity, 1F);
            Engine.cinematic_subtitle("x04_0280_pom", 3.5F);
        }

        [ScriptMethod(108, Lifecycle.Static)]
        public async Task x04_07_setup()
        {
            Engine.object_create_anew(heretic_leader_holo_01);
            Engine.object_cinematic_lod(heretic_leader_holo_01.Entity, true);
            Engine.wake(new ScriptMethodReference(x04_foley_07));
            Engine.wake(new ScriptMethodReference(x04_0250_pot));
            Engine.wake(new ScriptMethodReference(x04_0260_hld));
            Engine.wake(new ScriptMethodReference(x04_0270_pot));
            Engine.wake(new ScriptMethodReference(x04_0280_pom));
        }

        [ScriptMethod(109, Lifecycle.Static)]
        public async Task x04_scene_07()
        {
            await this.x04_07_setup();
            Engine.camera_set_animation_relative(Engine.GetTag<AnimationGraphTag>("objects\\characters\\cinematic_camera\\x04\\x04", 3826975397U), "x04_07", default(IUnit), anchor_flag_x04b);
            Engine.custom_animation_relative(dervish.Entity, Engine.GetTag<AnimationGraphTag>("objects\\characters\\dervish\\x04\\x04", 3827040934U), "dervish_07", false, anchor_x04b.Entity);
            Engine.custom_animation_relative(truth.Entity, Engine.GetTag<AnimationGraphTag>("objects\\characters\\prophet\\x04\\x04", 3827958452U), "truth_07", false, anchor_x04b.Entity);
            Engine.custom_animation_relative(mercy.Entity, Engine.GetTag<AnimationGraphTag>("objects\\characters\\prophet\\x04\\x04", 3827958452U), "mercy_07", false, anchor_x04b.Entity);
            Engine.custom_animation_relative(heretic_leader_holo_01.Entity, Engine.GetTag<AnimationGraphTag>("objects\\characters\\heretic\\x04\\x04", 3829727951U), "heretic_07", false, anchor_x04b.Entity);
            Engine.scenery_animation_start_relative(sarcophagus.Entity, Engine.GetTag<AnimationGraphTag>("scenarios\\objects\\solo\\alphagasgiant\\sarcophagus\\sarcophagus", 3828089526U), "x04_07", anchor_x04b.Entity);
            await Engine.sleep((short)((float)Engine.camera_time() - this.prediction_offset));
            await this.x04_08_predict_stub();
            await Engine.sleep((short)((float)Engine.camera_time() - this.sound_offset));
            Engine.sound_impulse_predict(Engine.GetTag<SoundTag>("sound\\cinematics\\04_alphagas\\x04\\music\\08_mus", 3829859025U));
            Engine.sound_impulse_predict(Engine.GetTag<SoundTag>("sound\\cinematics\\04_alphagas\\x04\\foley\\x04_08_fol", 3829924562U));
            await Engine.sleep((short)Engine.camera_time());
            Engine.object_destroy(heretic_leader_holo_01.Entity);
        }

        [ScriptMethod(110, Lifecycle.Dormant)]
        public async Task x04_score_08()
        {
            await Engine.sleep(419);
            Engine.sound_impulse_start(Engine.GetTag<SoundTag>("sound\\cinematics\\04_alphagas\\x04\\music\\08_mus", 3829859025U), default(IGameObject), 1F);
            Engine.print("x04 score 08 start");
        }

        [ScriptMethod(111, Lifecycle.Dormant)]
        public async Task x04_foley_08()
        {
            await Engine.sleep(0);
            Engine.sound_impulse_start(Engine.GetTag<SoundTag>("sound\\cinematics\\04_alphagas\\x04\\foley\\x04_08_fol", 3829924562U), default(IGameObject), 1F);
            Engine.print("x04 foley 08 start");
        }

        [ScriptMethod(112, Lifecycle.Dormant)]
        public async Task x04_0290_der()
        {
            await Engine.sleep(0);
            Engine.sound_impulse_start(Engine.GetTag<SoundTag>("sound\\dialog\\levels\\04_gasgiant\\cinematic\\x04_0290_der", 3829990099U), dervish.Entity, 1F);
            Engine.cinematic_subtitle("x04_0290_der", 5F);
        }

        [ScriptMethod(113, Lifecycle.Dormant)]
        public async Task x04_0300_pot()
        {
            await Engine.sleep(157);
            Engine.sound_impulse_start(Engine.GetTag<SoundTag>("sound\\dialog\\levels\\04_gasgiant\\cinematic\\x04_0300_pot", 3830055636U), truth.Entity, 1F);
            Engine.cinematic_subtitle("x04_0300_pot", 5F);
        }

        [ScriptMethod(114, Lifecycle.Dormant)]
        public async Task x04_0310_pot()
        {
            await Engine.sleep(312);
            Engine.sound_impulse_start(Engine.GetTag<SoundTag>("sound\\dialog\\levels\\04_gasgiant\\cinematic\\x04_0310_pot", 3830121173U), truth.Entity, 1F);
            Engine.cinematic_subtitle("x04_0310_pot", 6F);
            Engine.unit_set_emotional_state(truth.Entity, "happy", 0.75F, 60);
        }

        [ScriptMethod(115, Lifecycle.Static)]
        public async Task x04_08_setup()
        {
            Engine.wake(new ScriptMethodReference(x04_score_08));
            Engine.wake(new ScriptMethodReference(x04_foley_08));
            Engine.wake(new ScriptMethodReference(x04_0290_der));
            Engine.wake(new ScriptMethodReference(x04_0300_pot));
            Engine.wake(new ScriptMethodReference(x04_0310_pot));
        }

        [ScriptMethod(116, Lifecycle.Static)]
        public async Task x04_scene_08()
        {
            Engine.cinematic_screen_effect_stop();
            await this.x04_08_setup();
            Engine.camera_set_animation_relative(Engine.GetTag<AnimationGraphTag>("objects\\characters\\cinematic_camera\\x04\\x04", 3826975397U), "x04_08", default(IUnit), anchor_flag_x04b);
            Engine.custom_animation_relative(dervish.Entity, Engine.GetTag<AnimationGraphTag>("objects\\characters\\dervish\\x04\\x04", 3827040934U), "dervish_08", false, anchor_x04b.Entity);
            Engine.custom_animation_relative(truth.Entity, Engine.GetTag<AnimationGraphTag>("objects\\characters\\prophet\\x04\\x04", 3827958452U), "truth_08", false, anchor_x04b.Entity);
            Engine.custom_animation_relative(mercy.Entity, Engine.GetTag<AnimationGraphTag>("objects\\characters\\prophet\\x04\\x04", 3827958452U), "mercy_08", false, anchor_x04b.Entity);
            Engine.scenery_animation_start_relative(sarcophagus.Entity, Engine.GetTag<AnimationGraphTag>("scenarios\\objects\\solo\\alphagasgiant\\sarcophagus\\sarcophagus", 3828089526U), "x04_08", anchor_x04b.Entity);
            await Engine.sleep((short)((float)Engine.camera_time() - this.prediction_offset));
            await this.x04_09_predict_stub();
            await Engine.sleep((short)((float)Engine.camera_time() - this.sound_offset));
            Engine.sound_impulse_predict(Engine.GetTag<SoundTag>("sound\\cinematics\\04_alphagas\\x04\\foley\\x04_09_fol", 3830186710U));
            await Engine.sleep((short)Engine.camera_time());
        }

        [ScriptMethod(117, Lifecycle.Dormant)]
        public async Task x04_foley_09()
        {
            await Engine.sleep(0);
            Engine.sound_impulse_start(Engine.GetTag<SoundTag>("sound\\cinematics\\04_alphagas\\x04\\foley\\x04_09_fol", 3830186710U), default(IGameObject), 1F);
            Engine.print("x04 foley 09 start");
        }

        [ScriptMethod(118, Lifecycle.Dormant)]
        public async Task x04_0320_der()
        {
            await Engine.sleep(63);
            Engine.sound_impulse_start(Engine.GetTag<SoundTag>("sound\\dialog\\levels\\04_gasgiant\\cinematic\\x04_0320_der", 3830252247U), dervish.Entity, 1F);
            Engine.cinematic_subtitle("x04_0320_der", 1.25F);
        }

        [ScriptMethod(119, Lifecycle.Dormant)]
        public async Task x04_0330_pom()
        {
            await Engine.sleep(100);
            Engine.sound_impulse_start(Engine.GetTag<SoundTag>("sound\\dialog\\levels\\04_gasgiant\\cinematic\\x04_0330_pom", 3830317784U), mercy.Entity, 1F);
            Engine.cinematic_subtitle("x04_0330_pom", 12F);
        }

        [ScriptMethod(120, Lifecycle.Static)]
        public async Task x04_09_setup()
        {
            Engine.wake(new ScriptMethodReference(x04_foley_09));
            Engine.wake(new ScriptMethodReference(x04_0320_der));
            Engine.wake(new ScriptMethodReference(x04_0330_pom));
        }

        [ScriptMethod(121, Lifecycle.Static)]
        public async Task x04_scene_09()
        {
            await this.x04_09_setup();
            Engine.camera_set_animation_relative(Engine.GetTag<AnimationGraphTag>("objects\\characters\\cinematic_camera\\x04\\x04", 3826975397U), "x04_09", default(IUnit), anchor_flag_x04b);
            Engine.custom_animation_relative(dervish.Entity, Engine.GetTag<AnimationGraphTag>("objects\\characters\\dervish\\x04\\x04", 3827040934U), "dervish_09", false, anchor_x04b.Entity);
            Engine.custom_animation_relative(truth.Entity, Engine.GetTag<AnimationGraphTag>("objects\\characters\\prophet\\x04\\x04", 3827958452U), "truth_09", false, anchor_x04b.Entity);
            Engine.custom_animation_relative(mercy.Entity, Engine.GetTag<AnimationGraphTag>("objects\\characters\\prophet\\x04\\x04", 3827958452U), "mercy_09", false, anchor_x04b.Entity);
            Engine.scenery_animation_start_relative(sarcophagus.Entity, Engine.GetTag<AnimationGraphTag>("scenarios\\objects\\solo\\alphagasgiant\\sarcophagus\\sarcophagus", 3828089526U), "x04_09", anchor_x04b.Entity);
            await Engine.sleep((short)((float)Engine.camera_time() - this.prediction_offset));
            await this.x04_10_predict_stub();
            await Engine.sleep((short)((float)Engine.camera_time() - this.sound_offset));
            Engine.sound_impulse_predict(Engine.GetTag<SoundTag>("sound\\cinematics\\04_alphagas\\x04\\music\\10_mus", 3830383321U));
            Engine.sound_impulse_predict(Engine.GetTag<SoundTag>("sound\\cinematics\\04_alphagas\\x04\\foley\\x04_10_fol", 3830448858U));
            await Engine.sleep((short)Engine.camera_time());
        }

        [ScriptMethod(122, Lifecycle.Dormant)]
        public async Task x04_score_10()
        {
            await Engine.sleep(538);
            Engine.sound_impulse_start(Engine.GetTag<SoundTag>("sound\\cinematics\\04_alphagas\\x04\\music\\10_mus", 3830383321U), default(IGameObject), 1F);
            Engine.print("x04 score 10 start");
        }

        [ScriptMethod(123, Lifecycle.Dormant)]
        public async Task x04_foley_10()
        {
            await Engine.sleep(0);
            Engine.sound_impulse_start(Engine.GetTag<SoundTag>("sound\\cinematics\\04_alphagas\\x04\\foley\\x04_10_fol", 3830448858U), default(IGameObject), 1F);
            Engine.print("x04 foley 10 start");
        }

        [ScriptMethod(124, Lifecycle.Dormant)]
        public async Task x04_0370_der()
        {
            await Engine.sleep(566);
            Engine.sound_impulse_start(Engine.GetTag<SoundTag>("sound\\dialog\\levels\\04_gasgiant\\cinematic\\x04_0340_der", 3830514395U), dervish.Entity, 1F);
            Engine.cinematic_subtitle("x04_0340_der", 3F);
        }

        [ScriptMethod(125, Lifecycle.Static)]
        public async Task x04_10_setup()
        {
            Engine.wake(new ScriptMethodReference(x04_score_10));
            Engine.wake(new ScriptMethodReference(x04_foley_10));
            Engine.wake(new ScriptMethodReference(x04_0370_der));
        }

        [ScriptMethod(126, Lifecycle.Static)]
        public async Task x04_10_cleanup()
        {
            Engine.object_destroy(dervish.Entity);
            Engine.object_destroy(truth.Entity);
            Engine.object_destroy(mercy.Entity);
            Engine.object_destroy_containing("throne");
            Engine.object_destroy(sarcophagus.Entity);
        }

        [ScriptMethod(127, Lifecycle.Static)]
        public async Task x04_scene_10()
        {
            await this.x04_10_setup();
            Engine.camera_set_animation_relative(Engine.GetTag<AnimationGraphTag>("objects\\characters\\cinematic_camera\\x04\\x04", 3826975397U), "x04_10", default(IUnit), anchor_flag_x04b);
            Engine.custom_animation_relative(dervish.Entity, Engine.GetTag<AnimationGraphTag>("objects\\characters\\dervish\\x04\\x04", 3827040934U), "dervish_10", false, anchor_x04b.Entity);
            Engine.custom_animation_relative(truth.Entity, Engine.GetTag<AnimationGraphTag>("objects\\characters\\prophet\\x04\\x04", 3827958452U), "truth_10", false, anchor_x04b.Entity);
            Engine.custom_animation_relative(mercy.Entity, Engine.GetTag<AnimationGraphTag>("objects\\characters\\prophet\\x04\\x04", 3827958452U), "mercy_10", false, anchor_x04b.Entity);
            Engine.scenery_animation_start_relative(sarcophagus.Entity, Engine.GetTag<AnimationGraphTag>("scenarios\\objects\\solo\\alphagasgiant\\sarcophagus\\sarcophagus", 3828089526U), "x04_10", anchor_x04b.Entity);
            await Engine.sleep((short)((float)Engine.camera_time() - 5));
            Engine.fade_out(0F, 0F, 0F, 5);
            await Engine.sleep(5);
            await this.x04_10_cleanup();
        }

        [ScriptMethod(128, Lifecycle.Static)]
        public async Task x04()
        {
            Engine.texture_cache_flush();
            Engine.geometry_cache_flush();
            Engine.switch_bsp_by_name(Engine.GetReference<IBsp>("high_4_cinematic"));
            await Engine.sleep(1);
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
            await Engine.sleep(30);
        }

        [ScriptMethod(129, Lifecycle.Dormant)]
        public async Task c04_intro_sound_scene1_01()
        {
            Engine.object_set_function_variable(phantom01.Entity, "engine_hack", 1F, 0F);
            Engine.object_set_function_variable(phantom02.Entity, "engine_hack", 1F, 0F);
            Engine.object_set_function_variable(phantom03.Entity, "engine_hack", 1F, 0F);
            Engine.object_set_function_variable(phantom01.Entity, "engine_audio", 1F, 0F);
            Engine.object_set_function_variable(phantom02.Entity, "engine_audio", 1F, 0F);
            Engine.object_set_function_variable(phantom03.Entity, "engine_audio", 1F, 0F);
            Engine.object_set_function_variable(phantom01.Entity, "hover_audio", 1F, 0F);
            Engine.object_set_function_variable(phantom02.Entity, "hover_audio", 1F, 0F);
            Engine.object_set_function_variable(phantom03.Entity, "hover_audio", 1F, 0F);
            Engine.sound_class_set_gain("vehicle", 0F, 0);
            Engine.sound_class_set_gain("vehicle", 1F, 90);
            Engine.object_set_velocity(phantom01.Entity, 30F);
            Engine.object_set_velocity(phantom02.Entity, 30F);
            Engine.object_set_velocity(phantom03.Entity, 30F);
            await Engine.sleep(105);
            Engine.sound_class_set_gain("vehicle", 0F, 150);
        }

        [ScriptMethod(130, Lifecycle.Dormant)]
        public async Task c04_intro_foley_01()
        {
            await Engine.sleep(0);
            Engine.sound_impulse_start(Engine.GetTag<SoundTag>("sound\\cinematics\\04_alphagas\\c04_intro\\foley\\c04_intro_01_fol", 3830579932U), default(IGameObject), 1F);
            Engine.print("c04_intro foley 01 start");
        }

        [ScriptMethod(131, Lifecycle.Dormant)]
        public async Task c04_1010_soc()
        {
            await Engine.sleep(95);
            Engine.sound_impulse_start(Engine.GetTag<SoundTag>("sound\\dialog\\levels\\04_gasgiant\\cinematic\\c04_1010_soc", 3830645469U), default(IGameObject), 1F);
            Engine.cinematic_subtitle("c04_1010_soc", 2F);
        }

        [ScriptMethod(132, Lifecycle.Dormant)]
        public async Task c04_1020_sec()
        {
            await Engine.sleep(167);
            Engine.sound_impulse_start(Engine.GetTag<SoundTag>("sound\\dialog\\levels\\04_gasgiant\\cinematic\\c04_1020_sec", 3830711006U), default(IGameObject), 1F);
            Engine.cinematic_subtitle("c04_1020_sec", 4F);
        }

        [ScriptMethod(133, Lifecycle.Dormant)]
        public async Task c04_1030_soc()
        {
            await Engine.sleep(279);
            Engine.sound_impulse_start(Engine.GetTag<SoundTag>("sound\\dialog\\levels\\04_gasgiant\\cinematic\\c04_1030_soc", 3830776543U), default(IGameObject), 1F);
            Engine.cinematic_subtitle("c04_1030_soc", 6F);
        }

        [ScriptMethod(134, Lifecycle.Dormant)]
        public async Task c04_intro_cinematic_lighting_01()
        {
            Engine.cinematic_lighting_set_primary_light(-64F, 276F, 0.427451F, 0.337255F, 0.337255F);
            Engine.cinematic_lighting_set_secondary_light(-73F, 160F, 0.117647F, 0.117647F, 0.176471F);
            Engine.cinematic_lighting_set_ambient_light(0.0156863F, 0.0156863F, 0.0156863F);
            Engine.rasterizer_bloom_override_threshold(0.6F);
            Engine.rasterizer_bloom_override_brightness(0.5F);
            Engine.object_uses_cinematic_lighting(phantom01.Entity, true);
            Engine.object_uses_cinematic_lighting(phantom02.Entity, true);
            Engine.object_uses_cinematic_lighting(phantom03.Entity, true);
        }

        [ScriptMethod(135, Lifecycle.Static)]
        public async Task c04_intro_01_problem_actors()
        {
            Engine.print("problem actors");
            Engine.object_create_anew(phantom01);
            Engine.object_create_anew(phantom02);
            Engine.object_create_anew(phantom03);
            Engine.object_create_anew(matte_high_charity);
            Engine.object_create_anew(matte_threshold);
            Engine.object_create_anew(matte_halo_01);
            Engine.object_create_anew(stardust_01);
            Engine.object_create_anew(stardust_02);
            Engine.object_cinematic_lod(phantom01.Entity, true);
            Engine.object_cinematic_lod(phantom02.Entity, true);
            Engine.object_cinematic_lod(phantom03.Entity, true);
        }

        [ScriptMethod(136, Lifecycle.Static)]
        public async Task c04_intro_02a_problem_actors()
        {
            Engine.print("problem actors");
            Engine.object_create_anew(dervish02);
            Engine.object_create_anew(commander);
            Engine.object_create_anew(elite01);
            Engine.object_create_anew(elite02);
            Engine.object_create_anew(elite03);
            Engine.object_create_anew(elite04);
            Engine.object_create_anew(elite05);
            Engine.object_create_anew(elite06);
            Engine.object_create_anew(elite07);
            Engine.object_create_anew(grunt01);
            Engine.object_create_anew(grunt02);
            Engine.object_create_anew(grunt03);
            Engine.object_create_anew(grunt04);
            Engine.object_create_anew(phantom_int);
            Engine.object_cinematic_lod(dervish02.Entity, true);
            Engine.object_cinematic_lod(commander.Entity, true);
            Engine.object_cinematic_lod(elite01.Entity, true);
            Engine.object_cinematic_lod(elite02.Entity, true);
            Engine.object_cinematic_lod(elite03.Entity, true);
            Engine.object_cinematic_lod(elite04.Entity, true);
            Engine.object_cinematic_lod(elite05.Entity, true);
            Engine.object_cinematic_lod(elite06.Entity, true);
            Engine.object_cinematic_lod(elite07.Entity, true);
            Engine.object_cinematic_lod(grunt01.Entity, true);
            Engine.object_cinematic_lod(grunt02.Entity, true);
            Engine.object_cinematic_lod(grunt03.Entity, true);
            Engine.object_cinematic_lod(grunt04.Entity, true);
            Engine.object_cinematic_lod(phantom_int.Entity, true);
        }

        [ScriptMethod(137, Lifecycle.Static)]
        public async Task c04_intro_01_setup()
        {
            Engine.wake(new ScriptMethodReference(c04_intro_foley_01));
            Engine.wake(new ScriptMethodReference(c04_1010_soc));
            Engine.wake(new ScriptMethodReference(c04_1020_sec));
            Engine.wake(new ScriptMethodReference(c04_1030_soc));
            Engine.wake(new ScriptMethodReference(c04_intro_sound_scene1_01));
            Engine.wake(new ScriptMethodReference(c04_intro_cinematic_lighting_01));
        }

        [ScriptMethod(138, Lifecycle.Static)]
        public async Task c04_intro_01_cleanup()
        {
            Engine.object_destroy(intro_fleet.Entity);
            Engine.object_destroy_containing("stardust");
            Engine.object_destroy_containing("matte");
        }

        [ScriptMethod(139, Lifecycle.Static)]
        public async Task c04_intro_01()
        {
            Engine.fade_out(0F, 0F, 0F, 0);
            Engine.object_create_anew(intro_fleet);
            Engine.camera_control(true);
            Engine.cinematic_start();
            this.cinematic_letterbox_style = 1;
            Engine.camera_set_field_of_view(60F, 0);
            await this._04_intro_01_predict_stub();
            Engine.sound_impulse_predict(Engine.GetTag<SoundTag>("sound\\cinematics\\03_earthcity\\c03_intro\\foley\\c03_intro_03_fol", 3830842080U));
            await this.c04_intro_01_problem_actors();
            await Engine.sleep(this.prediction_offset);
            await this.c04_intro_01_setup();
            Engine.camera_set_animation_relative(Engine.GetTag<AnimationGraphTag>("objects\\characters\\cinematic_camera\\04_intro\\04_intro", 3830907617U), "04intro_01", default(IUnit), cinematic_anchor03);
            Engine.custom_animation_relative(phantom01.Entity, Engine.GetTag<AnimationGraphTag>("objects\\vehicles\\phantom\\animations\\04_intro\\04_intro", 3830973154U), "phantom01_01", false, anchor03.Entity);
            Engine.custom_animation_relative(phantom02.Entity, Engine.GetTag<AnimationGraphTag>("objects\\vehicles\\phantom\\animations\\04_intro\\04_intro", 3830973154U), "phantom02_01", false, anchor03.Entity);
            Engine.custom_animation_relative(phantom03.Entity, Engine.GetTag<AnimationGraphTag>("objects\\vehicles\\phantom\\animations\\04_intro\\04_intro", 3830973154U), "phantom03_01", false, anchor03.Entity);
            Engine.scenery_animation_start_relative(matte_high_charity.Entity, Engine.GetTag<AnimationGraphTag>("objects\\cinematics\\matte_paintings\\high_charity_exterior\\04_intro\\04_intro", 3831038691U), "high_charity_exterior_01", anchor03.Entity);
            Engine.scenery_animation_start_relative(matte_threshold.Entity, Engine.GetTag<AnimationGraphTag>("objects\\cinematics\\matte_paintings\\threshold_space\\04_intro\\04_intro", 3831104228U), "threshold_01", anchor03.Entity);
            Engine.scenery_animation_start_relative(matte_halo_01.Entity, Engine.GetTag<AnimationGraphTag>("objects\\cinematics\\matte_paintings\\halo_destroyed_03\\04_intro\\04_intro", 3831169765U), "halo_destroyed03_01", anchor03.Entity);
            Engine.scenery_animation_start_relative(stardust_01.Entity, Engine.GetTag<AnimationGraphTag>("objects\\cinematics\\matte_paintings\\high_charity_stardust\\04_intro\\04_intro", 3831235302U), "stardust01_01", anchor03.Entity);
            Engine.scenery_animation_start_relative(stardust_02.Entity, Engine.GetTag<AnimationGraphTag>("objects\\cinematics\\matte_paintings\\high_charity_stardust\\04_intro\\04_intro", 3831235302U), "stardust01_02", anchor03.Entity);
            Engine.fade_in(0F, 0F, 0F, 30);
            await Engine.sleep((short)((float)Engine.camera_time() - this.prediction_offset));
            await this._04_intro_02a_predict_stub();
            await Engine.sleep((short)((float)Engine.camera_time() - 15));
            Engine.fade_out(1F, 1F, 1F, 15);
            await Engine.sleep(15);
            await this.c04_intro_01_cleanup();
        }

        [ScriptMethod(140, Lifecycle.Dormant)]
        public async Task c04_intro_sound_scene2a_01()
        {
            Engine.object_set_function_variable(phantom_int.Entity, "engine_hack", 1F, 0F);
            Engine.object_set_function_variable(phantom_int.Entity, "engine_audio", 1F, 0F);
            Engine.object_set_function_variable(phantom_int.Entity, "hover_audio", 1F, 0F);
            Engine.sound_class_set_gain("vehicle", 0.5F, 15);
        }

        [ScriptMethod(141, Lifecycle.Dormant)]
        public async Task c04_intro_sound_scene2a_02()
        {
            await Engine.sleep(720);
            Engine.sound_class_set_gain("vehicle", 0F, 15);
        }

        [ScriptMethod(142, Lifecycle.Dormant)]
        public async Task c04_1040_sec()
        {
            await Engine.sleep(169);
            Engine.sound_impulse_start(Engine.GetTag<SoundTag>("sound\\dialog\\levels\\04_gasgiant\\cinematic\\c04_1040_sec", 3832480505U), default(IGameObject), 1F);
            Engine.cinematic_subtitle("c04_1040_sec", 2F);
        }

        [ScriptMethod(143, Lifecycle.Dormant)]
        public async Task c04_1050_soc()
        {
            await Engine.sleep(239);
            Engine.sound_impulse_start(Engine.GetTag<SoundTag>("sound\\dialog\\levels\\04_gasgiant\\cinematic\\c04_1050_soc", 3832546042U), commander.Entity, 1F);
            Engine.cinematic_subtitle("c04_1050_soc", 6F);
        }

        [ScriptMethod(144, Lifecycle.Dormant)]
        public async Task c04_1060_soc()
        {
            await Engine.sleep(400);
            Engine.sound_impulse_start(Engine.GetTag<SoundTag>("sound\\dialog\\levels\\04_gasgiant\\cinematic\\c04_1060_soc", 3832611579U), commander.Entity, 1F);
            Engine.cinematic_subtitle("c04_1060_soc", 5F);
        }

        [ScriptMethod(145, Lifecycle.Dormant)]
        public async Task c04_1070_sog()
        {
            await Engine.sleep(552);
            Engine.sound_impulse_start(Engine.GetTag<SoundTag>("sound\\dialog\\levels\\04_gasgiant\\cinematic\\c04_1070_sog", 3832677116U), default(IGameObject), 1F);
            Engine.cinematic_subtitle("c04_1070_sog", 1F);
            Engine.print("which grunt is this?");
        }

        [ScriptMethod(146, Lifecycle.Dormant)]
        public async Task c04_intro_02a_fov()
        {
            await Engine.sleep(237);
            Engine.camera_set_field_of_view(60F, 0);
            Engine.print("fov change: 80 -> 60 over 0 ticks");
        }

        [ScriptMethod(147, Lifecycle.Dormant)]
        public async Task c04_intro_cinematic_light_02a()
        {
            Engine.cinematic_lighting_set_primary_light(-90F, 0F, 0.23F, 0.29F, 0.53F);
            Engine.cinematic_lighting_set_secondary_light(-90F, 192F, 0.16F, 0.1F, 0.19F);
            Engine.cinematic_lighting_set_ambient_light(0.07F, 0.05F, 0.08F);
            Engine.rasterizer_bloom_override_threshold(0.3F);
            Engine.rasterizer_bloom_override_brightness(0.5F);
            Engine.object_uses_cinematic_lighting(dervish02.Entity, true);
            Engine.object_uses_cinematic_lighting(commander.Entity, true);
            Engine.object_uses_cinematic_lighting(elite01.Entity, true);
            Engine.object_uses_cinematic_lighting(elite02.Entity, true);
            Engine.object_uses_cinematic_lighting(elite03.Entity, true);
            Engine.object_uses_cinematic_lighting(elite04.Entity, true);
            Engine.object_uses_cinematic_lighting(elite05.Entity, true);
            Engine.object_uses_cinematic_lighting(elite06.Entity, true);
            Engine.object_uses_cinematic_lighting(elite07.Entity, true);
            Engine.object_uses_cinematic_lighting(grunt01.Entity, true);
            Engine.object_uses_cinematic_lighting(grunt02.Entity, true);
            Engine.object_uses_cinematic_lighting(grunt03.Entity, true);
            Engine.object_uses_cinematic_lighting(grunt04.Entity, true);
            Engine.object_uses_cinematic_lighting(phantom_int.Entity, true);
        }

        [ScriptMethod(148, Lifecycle.Static)]
        public async Task c04_intro_02a_setup()
        {
            Engine.object_create_anew(dervish02);
            Engine.object_create_anew(commander);
            Engine.object_create_anew(elite01);
            Engine.object_create_anew(elite02);
            Engine.object_create_anew(elite03);
            Engine.object_create_anew(elite04);
            Engine.object_create_anew(elite05);
            Engine.object_create_anew(elite06);
            Engine.object_create_anew(elite07);
            Engine.object_create_anew(grunt01);
            Engine.object_create_anew(grunt02);
            Engine.object_create_anew(grunt03);
            Engine.object_create_anew(grunt04);
            Engine.object_create_anew(phantom_int);
            Engine.object_cinematic_lod(dervish02.Entity, true);
            Engine.object_cinematic_lod(commander.Entity, true);
            Engine.object_cinematic_lod(elite01.Entity, true);
            Engine.object_cinematic_lod(elite02.Entity, true);
            Engine.object_cinematic_lod(elite03.Entity, true);
            Engine.object_cinematic_lod(elite04.Entity, true);
            Engine.object_cinematic_lod(elite05.Entity, true);
            Engine.object_cinematic_lod(elite06.Entity, true);
            Engine.object_cinematic_lod(elite07.Entity, true);
            Engine.object_cinematic_lod(grunt01.Entity, true);
            Engine.object_cinematic_lod(grunt02.Entity, true);
            Engine.object_cinematic_lod(grunt03.Entity, true);
            Engine.object_cinematic_lod(grunt04.Entity, true);
            Engine.object_cinematic_lod(phantom_int.Entity, true);
            Engine.object_create_anew(beam_rifle01);
            Engine.object_create_anew(plasma_rifle01);
            Engine.object_create_anew(plasma_rifle02);
            Engine.object_create_anew(plasma_rifle03);
            Engine.object_create_anew(plasma_rifle04);
            Engine.object_create_anew(plasma_rifle05);
            Engine.object_create_anew(plasma_rifle06);
            Engine.object_create_anew(plasma_pistol01);
            Engine.object_create_anew(plasma_pistol02);
            Engine.object_create_anew(plasma_pistol03);
            Engine.object_create_anew(plasma_pistol04);
            Engine.objects_attach(elite05.Entity, "right_hand_elite", beam_rifle01.Entity, "");
            Engine.objects_attach(elite01.Entity, "right_hand_elite", plasma_rifle01.Entity, "");
            Engine.objects_attach(elite02.Entity, "right_hand_elite", plasma_rifle02.Entity, "");
            Engine.objects_attach(elite03.Entity, "right_hand_elite", plasma_rifle03.Entity, "");
            Engine.objects_attach(elite04.Entity, "right_hand_elite", plasma_rifle04.Entity, "");
            Engine.objects_attach(elite06.Entity, "right_hand_elite", plasma_rifle05.Entity, "");
            Engine.objects_attach(elite07.Entity, "right_hand_elite", plasma_rifle06.Entity, "");
            Engine.objects_attach(grunt01.Entity, "right_hand", plasma_pistol01.Entity, "");
            Engine.objects_attach(grunt01.Entity, "right_hand", plasma_pistol02.Entity, "");
            Engine.objects_attach(grunt01.Entity, "right_hand", plasma_pistol03.Entity, "");
            Engine.objects_attach(grunt01.Entity, "right_hand", plasma_pistol04.Entity, "");
            Engine.wake(new ScriptMethodReference(c04_intro_sound_scene2a_01));
            Engine.wake(new ScriptMethodReference(c04_intro_sound_scene2a_02));
            Engine.wake(new ScriptMethodReference(c04_1040_sec));
            Engine.wake(new ScriptMethodReference(c04_1050_soc));
            Engine.wake(new ScriptMethodReference(c04_1060_soc));
            Engine.wake(new ScriptMethodReference(c04_1070_sog));
            Engine.wake(new ScriptMethodReference(c04_intro_02a_fov));
            Engine.wake(new ScriptMethodReference(c04_intro_cinematic_light_02a));
            Engine.player_effect_set_max_rotation(0F, 1F, 1F);
            Engine.player_effect_start(0.25F, 0F);
        }

        [ScriptMethod(149, Lifecycle.Static)]
        public async Task c04_intro_02a_cleanup()
        {
            Engine.object_destroy(elite03.Entity);
            Engine.object_destroy(elite06.Entity);
            Engine.object_destroy(elite07.Entity);
        }

        [ScriptMethod(150, Lifecycle.Static)]
        public async Task c04_intro_02a()
        {
            await this._04_intro_02a_predict_stub();
            await this.c04_intro_02a_setup();
            Engine.camera_set_field_of_view(80F, 0);
            Engine.print("fov change: 60 -> 80 over 0 ticks");
            Engine.camera_set_animation_relative(Engine.GetTag<AnimationGraphTag>("objects\\characters\\cinematic_camera\\04_intro\\04_intro", 3830907617U), "04intro_02a", default(IUnit), cinematic_anchor03);
            Engine.custom_animation_relative(dervish02.Entity, Engine.GetTag<AnimationGraphTag>("objects\\characters\\dervish\\04_intro\\04_intro", 3832742653U), "dervish_02a", false, anchor03.Entity);
            Engine.custom_animation_relative(commander.Entity, Engine.GetTag<AnimationGraphTag>("objects\\characters\\elite\\04_intro\\04_intro", 3832808190U), "commander_02a", false, anchor03.Entity);
            Engine.custom_animation_relative(elite01.Entity, Engine.GetTag<AnimationGraphTag>("objects\\characters\\elite\\04_intro\\04_intro", 3832808190U), "elite01_02a", false, anchor03.Entity);
            Engine.custom_animation_relative(elite02.Entity, Engine.GetTag<AnimationGraphTag>("objects\\characters\\elite\\04_intro\\04_intro", 3832808190U), "elite02_02a", false, anchor03.Entity);
            Engine.custom_animation_relative(elite03.Entity, Engine.GetTag<AnimationGraphTag>("objects\\characters\\elite\\04_intro\\04_intro", 3832808190U), "elite03_02a", false, anchor03.Entity);
            Engine.custom_animation_relative(elite04.Entity, Engine.GetTag<AnimationGraphTag>("objects\\characters\\elite\\04_intro\\04_intro", 3832808190U), "elite04_02a", false, anchor03.Entity);
            Engine.custom_animation_relative(elite05.Entity, Engine.GetTag<AnimationGraphTag>("objects\\characters\\elite\\04_intro\\04_intro", 3832808190U), "elite05_02a", false, anchor03.Entity);
            Engine.custom_animation_relative(elite06.Entity, Engine.GetTag<AnimationGraphTag>("objects\\characters\\elite\\04_intro\\04_intro", 3832808190U), "elite06_02a", false, anchor03.Entity);
            Engine.custom_animation_relative(elite07.Entity, Engine.GetTag<AnimationGraphTag>("objects\\characters\\elite\\04_intro\\04_intro", 3832808190U), "elite07_02a", false, anchor03.Entity);
            Engine.custom_animation_relative(grunt01.Entity, Engine.GetTag<AnimationGraphTag>("objects\\characters\\grunt\\04_intro\\04_intro", 3832873727U), "grunt01_02a", false, anchor03.Entity);
            Engine.custom_animation_relative(grunt02.Entity, Engine.GetTag<AnimationGraphTag>("objects\\characters\\grunt\\04_intro\\04_intro", 3832873727U), "grunt02_02a", false, anchor03.Entity);
            Engine.custom_animation_relative(grunt03.Entity, Engine.GetTag<AnimationGraphTag>("objects\\characters\\grunt\\04_intro\\04_intro", 3832873727U), "grunt03_02a", false, anchor03.Entity);
            Engine.custom_animation_relative(grunt04.Entity, Engine.GetTag<AnimationGraphTag>("objects\\characters\\grunt\\04_intro\\04_intro", 3832873727U), "grunt04_02a", false, anchor03.Entity);
            Engine.scenery_animation_start_relative(phantom_int.Entity, Engine.GetTag<AnimationGraphTag>("objects\\vehicles\\phantom\\cinematics\\04_intro\\04_intro", 3832939264U), "phantom_int_02a", anchor03.Entity);
            await Engine.sleep(5);
            Engine.fade_in(1F, 1F, 1F, 15);
            await Engine.sleep((short)((float)Engine.camera_time() - this.prediction_offset));
            await this._04_intro_02b_predict_stub();
            await Engine.sleep((short)Engine.camera_time());
            await this.c04_intro_02a_cleanup();
        }

        [ScriptMethod(151, Lifecycle.Dormant)]
        public async Task c04_1080_sec()
        {
            await Engine.sleep(5);
            Engine.sound_impulse_start(Engine.GetTag<SoundTag>("sound\\dialog\\levels\\04_gasgiant\\cinematic\\c04_1080_sec", 3833004801U), default(IGameObject), 1F);
            Engine.cinematic_subtitle("c04_1080_sec", 3F);
        }

        [ScriptMethod(152, Lifecycle.Dormant)]
        public async Task c04_1090_soc()
        {
            await Engine.sleep(83);
            Engine.sound_impulse_start(Engine.GetTag<SoundTag>("sound\\dialog\\levels\\04_gasgiant\\cinematic\\c04_1090_soc", 3833070338U), commander.Entity, 1F);
            Engine.cinematic_subtitle("c04_1090_soc", 3F);
        }

        [ScriptMethod(153, Lifecycle.Static)]
        public async Task c04_intro_02b_setup()
        {
            Engine.wake(new ScriptMethodReference(c04_1080_sec));
            Engine.wake(new ScriptMethodReference(c04_1090_soc));
        }

        [ScriptMethod(154, Lifecycle.Static)]
        public async Task c04_intro_02b_cleanup()
        {
            Engine.object_hide(phantom_int.Entity, true);
            Engine.object_destroy(elite01.Entity);
            Engine.object_destroy(elite02.Entity);
            Engine.object_destroy(elite04.Entity);
            Engine.object_destroy(elite05.Entity);
            Engine.object_destroy(grunt01.Entity);
            Engine.object_destroy(grunt02.Entity);
            Engine.object_destroy(grunt03.Entity);
            Engine.object_destroy(grunt04.Entity);
        }

        [ScriptMethod(155, Lifecycle.Static)]
        public async Task c04_intro_02b()
        {
            await this.c04_intro_02b_setup();
            Engine.camera_set_animation_relative(Engine.GetTag<AnimationGraphTag>("objects\\characters\\cinematic_camera\\04_intro\\04_intro", 3830907617U), "04intro_02b", default(IUnit), cinematic_anchor03);
            Engine.custom_animation_relative(dervish02.Entity, Engine.GetTag<AnimationGraphTag>("objects\\characters\\dervish\\04_intro\\04_intro", 3832742653U), "dervish_02b", false, anchor03.Entity);
            Engine.custom_animation_relative(commander.Entity, Engine.GetTag<AnimationGraphTag>("objects\\characters\\elite\\04_intro\\04_intro", 3832808190U), "commander_02b", false, anchor03.Entity);
            Engine.custom_animation_relative(elite01.Entity, Engine.GetTag<AnimationGraphTag>("objects\\characters\\elite\\04_intro\\04_intro", 3832808190U), "elite01_02b", false, anchor03.Entity);
            Engine.custom_animation_relative(elite02.Entity, Engine.GetTag<AnimationGraphTag>("objects\\characters\\elite\\04_intro\\04_intro", 3832808190U), "elite02_02b", false, anchor03.Entity);
            Engine.custom_animation_relative(elite04.Entity, Engine.GetTag<AnimationGraphTag>("objects\\characters\\elite\\04_intro\\04_intro", 3832808190U), "elite04_02b", false, anchor03.Entity);
            Engine.custom_animation_relative(elite05.Entity, Engine.GetTag<AnimationGraphTag>("objects\\characters\\elite\\04_intro\\04_intro", 3832808190U), "elite05_02b", false, anchor03.Entity);
            Engine.custom_animation_relative(grunt01.Entity, Engine.GetTag<AnimationGraphTag>("objects\\characters\\grunt\\04_intro\\04_intro", 3832873727U), "grunt01_02b", false, anchor03.Entity);
            Engine.custom_animation_relative(grunt02.Entity, Engine.GetTag<AnimationGraphTag>("objects\\characters\\grunt\\04_intro\\04_intro", 3832873727U), "grunt02_02b", false, anchor03.Entity);
            Engine.custom_animation_relative(grunt03.Entity, Engine.GetTag<AnimationGraphTag>("objects\\characters\\grunt\\04_intro\\04_intro", 3832873727U), "grunt03_02b", false, anchor03.Entity);
            Engine.custom_animation_relative(grunt04.Entity, Engine.GetTag<AnimationGraphTag>("objects\\characters\\grunt\\04_intro\\04_intro", 3832873727U), "grunt04_02b", false, anchor03.Entity);
            Engine.scenery_animation_start_relative(phantom_int.Entity, Engine.GetTag<AnimationGraphTag>("objects\\vehicles\\phantom\\cinematics\\04_intro\\04_intro", 3832939264U), "phantom_int_02b", anchor03.Entity);
            await Engine.sleep((short)((float)Engine.camera_time() - this.prediction_offset));
            await this._04_intro_02c_predict_stub();
            await Engine.sleep((short)((float)Engine.camera_time() - this.sound_offset));
            Engine.sound_impulse_predict(Engine.GetTag<SoundTag>("sound\\cinematics\\04_alphagas\\c04_intro\\music\\c04_02c_mus", 3833135875U));
            Engine.sound_impulse_predict(Engine.GetTag<SoundTag>("sound\\cinematics\\04_alphagas\\c04_intro\\foley\\c04_intro_02c_fol", 3833201412U));
            await Engine.sleep((short)Engine.camera_time());
            await this.c04_intro_02b_cleanup();
        }

        [ScriptMethod(156, Lifecycle.Dormant)]
        public async Task c04_intro_sound_scene2c_01()
        {
            Engine.sound_class_set_gain("vehicle", 1F, 80);
        }

        [ScriptMethod(157, Lifecycle.Dormant)]
        public async Task c04_intro_sound_scene2c_02()
        {
            await Engine.sleep(90);
            Engine.sound_class_set_gain("vehicle", 0F, 10);
        }

        [ScriptMethod(158, Lifecycle.Dormant)]
        public async Task c04_intro_score_02c()
        {
            await Engine.sleep(101);
            Engine.sound_impulse_start(Engine.GetTag<SoundTag>("sound\\cinematics\\04_alphagas\\c04_intro\\music\\c04_02c_mus", 3833135875U), default(IGameObject), 1F);
            Engine.print("c04_intro score 02c start");
        }

        [ScriptMethod(159, Lifecycle.Dormant)]
        public async Task c04_intro_foley_02c()
        {
            await Engine.sleep(0);
            Engine.sound_impulse_start(Engine.GetTag<SoundTag>("sound\\cinematics\\04_alphagas\\c04_intro\\foley\\c04_intro_02c_fol", 3833201412U), default(IGameObject), 1F);
            Engine.print("c04_intro foley 02c start");
        }

        [ScriptMethod(160, Lifecycle.Dormant)]
        public async Task c04_intro_cinematic_light_02c()
        {
            Engine.cinematic_lighting_set_primary_light(24F, 294F, 0.35F, 0.39F, 0.24F);
            Engine.cinematic_lighting_set_secondary_light(19F, 22F, 0F, 0F, 0F);
            Engine.cinematic_lighting_set_ambient_light(0.18F, 0.14F, 0.14F);
            Engine.rasterizer_bloom_override_threshold(0.4F);
            Engine.rasterizer_bloom_override_brightness(0.5F);
            Engine.object_uses_cinematic_lighting(phantom01.Entity, true);
            Engine.object_uses_cinematic_lighting(phantom02.Entity, true);
            Engine.object_uses_cinematic_lighting(phantom03.Entity, true);
        }

        [ScriptMethod(161, Lifecycle.Static)]
        public async Task c04_intro_02c_setup()
        {
            Engine.player_effect_stop(0F);
            Engine.object_create_anew(matte_structure_top);
            Engine.wake(new ScriptMethodReference(c04_intro_sound_scene2c_01));
            Engine.wake(new ScriptMethodReference(c04_intro_sound_scene2c_02));
            Engine.wake(new ScriptMethodReference(c04_intro_score_02c));
            Engine.wake(new ScriptMethodReference(c04_intro_foley_02c));
            Engine.wake(new ScriptMethodReference(c04_intro_cinematic_light_02c));
        }

        [ScriptMethod(162, Lifecycle.Static)]
        public async Task c04_intro_02c()
        {
            await this.c04_intro_02c_setup();
            Engine.camera_set_animation_relative(Engine.GetTag<AnimationGraphTag>("objects\\characters\\cinematic_camera\\04_intro\\04_intro", 3830907617U), "04intro_02c", default(IUnit), cinematic_anchor03);
            Engine.custom_animation_relative(phantom01.Entity, Engine.GetTag<AnimationGraphTag>("objects\\vehicles\\phantom\\animations\\04_intro\\04_intro", 3830973154U), "phantom01_02c", false, anchor03.Entity);
            Engine.custom_animation_relative(phantom02.Entity, Engine.GetTag<AnimationGraphTag>("objects\\vehicles\\phantom\\animations\\04_intro\\04_intro", 3830973154U), "phantom02_02c", false, anchor03.Entity);
            Engine.custom_animation_relative(phantom03.Entity, Engine.GetTag<AnimationGraphTag>("objects\\vehicles\\phantom\\animations\\04_intro\\04_intro", 3830973154U), "phantom03_02c", false, anchor03.Entity);
            Engine.scenery_animation_start_relative(matte_structure_top.Entity, Engine.GetTag<AnimationGraphTag>("objects\\cinematics\\matte_paintings\\gas_giant_structure_top\\04_intro\\04_intro", 3833266949U), "gas_giant_structure_top_02c", anchor03.Entity);
            await Engine.sleep((short)((float)Engine.camera_time() - this.prediction_offset));
            await this._04_intro_02d_predict_stub();
            Engine.cinematic_screen_effect_start(true);
            await Engine.sleep((short)((float)Engine.camera_time() - this.sound_offset));
            Engine.sound_impulse_predict(Engine.GetTag<SoundTag>("sound\\cinematics\\04_alphagas\\c04_intro\\foley\\c04_intro_02d_fol", 3833332486U));
            await Engine.sleep((short)((float)Engine.camera_time() - 5));
            Engine.cinematic_screen_effect_set_crossfade(2F);
            await Engine.sleep(5);
            Engine.object_destroy(matte_structure_top.Entity);
        }

        [ScriptMethod(163, Lifecycle.Dormant)]
        public async Task c04_intro_sound_scene2d_01()
        {
            Engine.sound_class_set_gain("vehicle", 0.5F, 15);
        }

        [ScriptMethod(164, Lifecycle.Dormant)]
        public async Task c04_intro_foley_02d()
        {
            await Engine.sleep(0);
            Engine.sound_impulse_start(Engine.GetTag<SoundTag>("sound\\cinematics\\04_alphagas\\c04_intro\\foley\\c04_intro_02d_fol", 3833332486U), default(IGameObject), 1F);
            Engine.print("c04_intro foley 02d start");
        }

        [ScriptMethod(165, Lifecycle.Dormant)]
        public async Task c04_1100_soc()
        {
            await Engine.sleep(29);
            Engine.sound_impulse_start(Engine.GetTag<SoundTag>("sound\\dialog\\levels\\04_gasgiant\\cinematic\\c04_1100_soc", 3833398023U), commander.Entity, 1F);
            Engine.cinematic_subtitle("c04_1100_soc", 1F);
        }

        [ScriptMethod(166, Lifecycle.Dormant)]
        public async Task c04_1110_soc()
        {
            await Engine.sleep(76);
            Engine.sound_impulse_start(Engine.GetTag<SoundTag>("sound\\dialog\\levels\\04_gasgiant\\cinematic\\c04_1110_soc", 3833463560U), commander.Entity, 1F);
            Engine.cinematic_subtitle("c04_1110_soc", 2F);
        }

        [ScriptMethod(167, Lifecycle.Dormant)]
        public async Task c04_1120_der()
        {
            await Engine.sleep(127);
            Engine.sound_impulse_start(Engine.GetTag<SoundTag>("sound\\dialog\\levels\\04_gasgiant\\cinematic\\c04_1120_der", 3833529097U), dervish02.Entity, 1F);
            Engine.cinematic_subtitle("c04_1120_der", 1F);
        }

        [ScriptMethod(168, Lifecycle.Dormant)]
        public async Task c04_1130_soc()
        {
            await Engine.sleep(174);
            Engine.sound_impulse_start(Engine.GetTag<SoundTag>("sound\\dialog\\levels\\04_gasgiant\\cinematic\\c04_1130_soc", 3833594634U), commander.Entity, 1F);
            Engine.cinematic_subtitle("c04_1130_soc", 9F);
        }

        [ScriptMethod(169, Lifecycle.Dormant)]
        public async Task c04_1140_der()
        {
            await Engine.sleep(430);
            Engine.sound_impulse_start(Engine.GetTag<SoundTag>("sound\\dialog\\levels\\04_gasgiant\\cinematic\\c04_1140_der", 3833660171U), dervish02.Entity, 1F);
            Engine.cinematic_subtitle("c04_1140_der", 2F);
        }

        [ScriptMethod(170, Lifecycle.Dormant)]
        public async Task c04_1150_soc()
        {
            await Engine.sleep(494);
            Engine.sound_impulse_start(Engine.GetTag<SoundTag>("sound\\dialog\\levels\\04_gasgiant\\cinematic\\c04_1150_soc", 3833725708U), commander.Entity, 1F);
            Engine.cinematic_subtitle("c04_1150_soc", 1F);
        }

        [ScriptMethod(171, Lifecycle.Dormant)]
        public async Task c04_intro_cinematic_light_02d()
        {
            Engine.cinematic_lighting_set_primary_light(-90F, 0F, 0.23F, 0.29F, 0.53F);
            Engine.cinematic_lighting_set_secondary_light(-90F, 192F, 0.16F, 0.1F, 0.19F);
            Engine.cinematic_lighting_set_ambient_light(0.07F, 0.05F, 0.08F);
            Engine.rasterizer_bloom_override_threshold(0.3F);
            Engine.rasterizer_bloom_override_brightness(0.5F);
        }

        [ScriptMethod(172, Lifecycle.Static)]
        public async Task c04_intro_03_problem_actors()
        {
            Engine.print("problem actors");
            Engine.object_create_anew(matte_structure);
        }

        [ScriptMethod(173, Lifecycle.Static)]
        public async Task c04_intro_02d_setup()
        {
            Engine.object_hide(phantom_int.Entity, false);
            Engine.wake(new ScriptMethodReference(c04_intro_sound_scene2d_01));
            Engine.wake(new ScriptMethodReference(c04_intro_foley_02d));
            Engine.wake(new ScriptMethodReference(c04_1100_soc));
            Engine.wake(new ScriptMethodReference(c04_1110_soc));
            Engine.wake(new ScriptMethodReference(c04_1120_der));
            Engine.wake(new ScriptMethodReference(c04_1130_soc));
            Engine.wake(new ScriptMethodReference(c04_1140_der));
            Engine.wake(new ScriptMethodReference(c04_1150_soc));
            Engine.wake(new ScriptMethodReference(c04_intro_cinematic_light_02d));
            Engine.player_effect_set_max_rotation(0F, 1F, 1F);
            Engine.player_effect_start(0.25F, 0F);
        }

        [ScriptMethod(174, Lifecycle.Static)]
        public async Task c04_intro_02d()
        {
            await this.c04_intro_02d_setup();
            Engine.camera_set_animation_relative(Engine.GetTag<AnimationGraphTag>("objects\\characters\\cinematic_camera\\04_intro\\04_intro", 3830907617U), "04intro_02d", default(IUnit), cinematic_anchor03);
            Engine.custom_animation_relative(dervish02.Entity, Engine.GetTag<AnimationGraphTag>("objects\\characters\\dervish\\04_intro\\04_intro", 3832742653U), "dervish_02d", false, anchor03.Entity);
            Engine.custom_animation_relative(commander.Entity, Engine.GetTag<AnimationGraphTag>("objects\\characters\\elite\\04_intro\\04_intro", 3832808190U), "commander_02d", false, anchor03.Entity);
            Engine.scenery_animation_start_relative(phantom_int.Entity, Engine.GetTag<AnimationGraphTag>("objects\\vehicles\\phantom\\cinematics\\04_intro\\04_intro", 3832939264U), "phantom_int_02d", anchor03.Entity);
            await Engine.sleep((short)((float)Engine.camera_time() - this.prediction_offset));
            await this._04_intro_03_predict_stub();
            Engine.cinematic_screen_effect_stop();
            await Engine.sleep((short)((float)Engine.camera_time() - this.sound_offset));
            Engine.sound_impulse_predict(Engine.GetTag<SoundTag>("sound\\cinematics\\04_alphagas\\c04_intro\\foley\\c04_intro_03_fol", 3833791245U));
            await this.c04_intro_03_problem_actors();
            await Engine.sleep((short)Engine.camera_time());
            Engine.object_destroy(dervish02.Entity);
            Engine.object_destroy(commander.Entity);
            Engine.object_destroy(phantom_int.Entity);
        }

        [ScriptMethod(175, Lifecycle.Dormant)]
        public async Task c04_intro_sound_scene3_01()
        {
            Engine.sound_class_set_gain("vehicle", 0F, 15);
        }

        [ScriptMethod(176, Lifecycle.Dormant)]
        public async Task c04_intro_sound_scene3_02()
        {
            Engine.sound_class_set_gain("vehicle", 1F, 170);
        }

        [ScriptMethod(177, Lifecycle.Dormant)]
        public async Task c04_intro_sound_scene3_03()
        {
            await Engine.sleep(180);
            Engine.sound_class_set_gain("vehicle", 0F, 120);
        }

        [ScriptMethod(178, Lifecycle.Dormant)]
        public async Task c04_intro_foley_03()
        {
            await Engine.sleep(0);
            Engine.sound_impulse_start(Engine.GetTag<SoundTag>("sound\\cinematics\\04_alphagas\\c04_intro\\foley\\c04_intro_03_fol", 3833791245U), default(IGameObject), 1F);
            Engine.print("c04_intro foley 03 start");
        }

        [ScriptMethod(179, Lifecycle.Dormant)]
        public async Task c04_1170_elp()
        {
            await Engine.sleep(189);
            Engine.sound_impulse_start_effect(Engine.GetTag<SoundTag>("sound\\dialog\\levels\\04_gasgiant\\cinematic\\c04_1170_elp", 3833856782U), default(IGameObject), 1F, "radio_covy_in");
            Engine.cinematic_subtitle("c04_1170_elp", 1F);
        }

        [ScriptMethod(180, Lifecycle.Dormant)]
        public async Task c04_1180_ecp()
        {
            await Engine.sleep(212);
            Engine.sound_impulse_start_effect(Engine.GetTag<SoundTag>("sound\\dialog\\levels\\04_gasgiant\\cinematic\\c04_1180_elp", 3833922319U), default(IGameObject), 1F, "radio_covy_loop");
            Engine.cinematic_subtitle("c04_1180_elp", 3F);
        }

        [ScriptMethod(181, Lifecycle.Dormant)]
        public async Task c04_1190_soc()
        {
            await Engine.sleep(295);
            Engine.sound_impulse_start_effect(Engine.GetTag<SoundTag>("sound\\dialog\\levels\\04_gasgiant\\cinematic\\c04_1190_soc", 3833987856U), default(IGameObject), 1F, "radio_covy_out");
            Engine.cinematic_subtitle("c04_1190_soc", 2F);
        }

        [ScriptMethod(182, Lifecycle.Dormant)]
        public async Task c04_intro_cinematic_light_03()
        {
            Engine.cinematic_lighting_set_primary_light(-32F, 140F, 0.35F, 0.39F, 0.24F);
            Engine.cinematic_lighting_set_secondary_light(19F, 22F, 0F, 0F, 0F);
            Engine.cinematic_lighting_set_ambient_light(0.18F, 0.14F, 0.14F);
            Engine.rasterizer_bloom_override_threshold(0.4F);
            Engine.rasterizer_bloom_override_brightness(0.5F);
        }

        [ScriptMethod(183, Lifecycle.Dormant)]
        public async Task c04_intro_shake_03()
        {
            await Engine.sleep(173);
            Engine.print("shake");
            Engine.player_effect_set_max_rotation(0F, 1F, 1F);
            Engine.player_effect_start(0.25F, 0F);
            Engine.player_effect_stop(1.5F);
        }

        [ScriptMethod(184, Lifecycle.Static)]
        public async Task c04_intro_03_setup()
        {
            Engine.object_create_anew(matte_mine);
            Engine.wake(new ScriptMethodReference(c04_intro_sound_scene3_01));
            Engine.wake(new ScriptMethodReference(c04_intro_sound_scene3_02));
            Engine.wake(new ScriptMethodReference(c04_intro_sound_scene3_03));
            Engine.wake(new ScriptMethodReference(c04_intro_foley_03));
            Engine.wake(new ScriptMethodReference(c04_1170_elp));
            Engine.wake(new ScriptMethodReference(c04_1180_ecp));
            Engine.wake(new ScriptMethodReference(c04_1190_soc));
            Engine.wake(new ScriptMethodReference(c04_intro_shake_03));
            Engine.wake(new ScriptMethodReference(c04_intro_cinematic_light_03));
            Engine.player_effect_stop(0F);
        }

        [ScriptMethod(185, Lifecycle.Static)]
        public async Task c04_intro_03_cleanup()
        {
            Engine.object_destroy(phantom01.Entity);
            Engine.object_destroy(phantom02.Entity);
            Engine.object_destroy(phantom03.Entity);
            Engine.object_destroy_containing("matte");
        }

        [ScriptMethod(186, Lifecycle.Static)]
        public async Task c04_intro_03()
        {
            await this.c04_intro_03_setup();
            Engine.camera_set_animation_relative(Engine.GetTag<AnimationGraphTag>("objects\\characters\\cinematic_camera\\04_intro\\04_intro", 3830907617U), "04intro_03", default(IUnit), cinematic_anchor03);
            Engine.custom_animation_relative(phantom01.Entity, Engine.GetTag<AnimationGraphTag>("objects\\vehicles\\phantom\\animations\\04_intro\\04_intro", 3830973154U), "phantom01_3", false, anchor03.Entity);
            Engine.custom_animation_relative(phantom02.Entity, Engine.GetTag<AnimationGraphTag>("objects\\vehicles\\phantom\\animations\\04_intro\\04_intro", 3830973154U), "phantom02_3", false, anchor03.Entity);
            Engine.custom_animation_relative(phantom03.Entity, Engine.GetTag<AnimationGraphTag>("objects\\vehicles\\phantom\\animations\\04_intro\\04_intro", 3830973154U), "phantom03_3", false, anchor03.Entity);
            Engine.scenery_animation_start_relative(matte_mine.Entity, Engine.GetTag<AnimationGraphTag>("objects\\cinematics\\matte_paintings\\gas_giant_exterior\\04_intro\\04_intro", 3834053393U), "gas_giant_exterior_03", anchor03.Entity);
            Engine.scenery_animation_start_relative(matte_structure.Entity, Engine.GetTag<AnimationGraphTag>("objects\\cinematics\\matte_paintings\\gas_giant_structure\\04_intro\\04_intro", 3834118930U), "gas_giant_structure_03", anchor03.Entity);
            await Engine.sleep((short)((float)Engine.camera_time() - 15));
            Engine.fade_out(1F, 1F, 1F, 15);
            await Engine.sleep((short)Engine.camera_time());
            await this.c04_intro_03_cleanup();
        }

        [ScriptMethod(187, Lifecycle.Dormant)]
        public async Task c04_intro_sound_scene5_01()
        {
            Engine.object_set_function_variable(phantom_01.Entity, "engine_hack", 1F, 0F);
            Engine.object_set_function_variable(phantom_02.Entity, "engine_hack", 1F, 0F);
            Engine.object_set_function_variable(phantom_03.Entity, "engine_hack", 1F, 0F);
            Engine.object_set_function_variable(phantom_01.Entity, "engine_audio", 1F, 0F);
            Engine.object_set_function_variable(phantom_02.Entity, "engine_audio", 1F, 0F);
            Engine.object_set_function_variable(phantom_03.Entity, "engine_audio", 1F, 0F);
            Engine.object_set_function_variable(phantom_01.Entity, "hover_audio", 1F, 0F);
            Engine.object_set_function_variable(phantom_02.Entity, "hover_audio", 1F, 0F);
            Engine.object_set_function_variable(phantom_03.Entity, "hover_audio", 1F, 0F);
        }

        [ScriptMethod(188, Lifecycle.Dormant)]
        public async Task c04_intro_05_shake_1()
        {
            Engine.player_effect_set_max_rotation(0F, 1F, 1F);
            Engine.player_effect_start(0.15F, 0F);
            await Engine.sleep(401);
            Engine.player_effect_stop(0F);
        }

        [ScriptMethod(189, Lifecycle.Static)]
        public async Task c04_intro_05_setup()
        {
            Engine.object_create_anew(phantom_01);
            Engine.object_create_anew(phantom_02);
            Engine.object_create_anew(phantom_03);
            Engine.wake(new ScriptMethodReference(c04_intro_sound_scene5_01));
            Engine.wake(new ScriptMethodReference(c04_intro_05_shake_1));
        }

        [ScriptMethod(190, Lifecycle.Static)]
        public async Task c04_intro_05()
        {
            await this._04_intro_05_predict_stub();
            await this.c04_intro_05_setup();
            Engine.camera_set_animation_relative(Engine.GetTag<AnimationGraphTag>("objects\\characters\\cinematic_camera\\04_intro\\04_intro", 3830907617U), "04intro_05", default(IUnit), cinematic_anchor02);
            Engine.custom_animation_relative(phantom_01.Entity, Engine.GetTag<AnimationGraphTag>("objects\\vehicles\\phantom\\animations\\04_intro\\04_intro", 3830973154U), "phantom01_05", false, anchor02.Entity);
            Engine.custom_animation_relative(phantom_02.Entity, Engine.GetTag<AnimationGraphTag>("objects\\vehicles\\phantom\\animations\\04_intro\\04_intro", 3830973154U), "phantom02_05", false, anchor02.Entity);
            Engine.custom_animation_relative(phantom_03.Entity, Engine.GetTag<AnimationGraphTag>("objects\\vehicles\\phantom\\animations\\04_intro\\04_intro", 3830973154U), "phantom03_05", false, anchor02.Entity);
            await Engine.sleep(15);
            Engine.fade_in(1F, 1F, 1F, 15);
            await Engine.sleep((short)((float)Engine.camera_time() - this.prediction_offset));
            await this._04_intro_06b_predict_stub();
            await Engine.sleep((short)Engine.camera_time());
        }

        [ScriptMethod(191, Lifecycle.Dormant)]
        public async Task c04_intro_sound_scene6b_01()
        {
            Engine.sound_class_set_gain("vehicle", 1F, 30);
        }

        [ScriptMethod(192, Lifecycle.Dormant)]
        public async Task c04_intro_sound_scene6b_02()
        {
            Engine.object_set_function_variable(phantom_01.Entity, "engine_hack", 0F, 120F);
            Engine.object_set_function_variable(phantom_02.Entity, "engine_hack", 0F, 120F);
            Engine.object_set_function_variable(phantom_03.Entity, "engine_hack", 0F, 120F);
            Engine.object_set_function_variable(phantom_01.Entity, "engine_audio", 0F, 120F);
            Engine.object_set_function_variable(phantom_02.Entity, "engine_audio", 0F, 120F);
            Engine.object_set_function_variable(phantom_03.Entity, "engine_audio", 0F, 120F);
            Engine.object_set_function_variable(phantom_01.Entity, "hover_audio", 0F, 120F);
            Engine.object_set_function_variable(phantom_02.Entity, "hover_audio", 0F, 120F);
            Engine.object_set_function_variable(phantom_03.Entity, "hover_audio", 0F, 120F);
        }

        [ScriptMethod(193, Lifecycle.Dormant)]
        public async Task c04_intro_sound_scene6b_03()
        {
            await Engine.sleep(30);
            Engine.object_set_function_variable(phantom_01.Entity, "turn_absolute", 1F, 30F);
            Engine.object_set_function_variable(phantom_02.Entity, "turn_absolute", 1F, 30F);
            Engine.object_set_function_variable(phantom_03.Entity, "turn_absolute", 1F, 30F);
            Engine.object_set_function_variable(phantom_01.Entity, "banking_audio", 1F, 30F);
            Engine.object_set_function_variable(phantom_02.Entity, "banking_audio", 1F, 30F);
            Engine.object_set_function_variable(phantom_03.Entity, "banking_audio", 1F, 30F);
            Engine.object_set_function_variable(phantom_01.Entity, "engine_ducker", 1F, 60F);
            Engine.object_set_function_variable(phantom_02.Entity, "engine_ducker", 1F, 60F);
            Engine.object_set_function_variable(phantom_03.Entity, "engine_ducker", 1F, 60F);
        }

        [ScriptMethod(194, Lifecycle.Dormant)]
        public async Task c04_intro_sound_scene6b_04()
        {
            await Engine.sleep(60);
            Engine.object_set_function_variable(phantom_01.Entity, "turn_absolute", 0F, 30F);
            Engine.object_set_function_variable(phantom_02.Entity, "turn_absolute", 0F, 30F);
            Engine.object_set_function_variable(phantom_03.Entity, "turn_absolute", 0F, 30F);
            Engine.object_set_function_variable(phantom_01.Entity, "banking_audio", 0F, 30F);
            Engine.object_set_function_variable(phantom_02.Entity, "banking_audio", 0F, 30F);
            Engine.object_set_function_variable(phantom_03.Entity, "banking_audio", 0F, 30F);
        }

        [ScriptMethod(195, Lifecycle.Dormant)]
        public async Task c04_intro_sound_scene6b_05()
        {
            await Engine.sleep(210);
            Engine.object_set_function_variable(phantom_01.Entity, "engine_hack", 1F, 60F);
            Engine.object_set_function_variable(phantom_03.Entity, "engine_hack", 1F, 60F);
            Engine.object_set_function_variable(phantom_01.Entity, "engine_audio", 1F, 60F);
            Engine.object_set_function_variable(phantom_03.Entity, "engine_audio", 1F, 60F);
            Engine.object_set_function_variable(phantom_01.Entity, "hover_audio", 1F, 60F);
            Engine.object_set_function_variable(phantom_03.Entity, "hover_audio", 1F, 60F);
            Engine.object_set_function_variable(phantom_01.Entity, "engine_ducker", 0F, 60F);
            Engine.object_set_function_variable(phantom_03.Entity, "engine_ducker", 0F, 60F);
        }

        [ScriptMethod(196, Lifecycle.Dormant)]
        public async Task c04_intro_sound_scene6b_06()
        {
            await Engine.sleep(315);
            Engine.object_set_function_variable(phantom_02.Entity, "engine_hack", 1F, 60F);
            Engine.object_set_function_variable(phantom_02.Entity, "engine_audio", 1F, 60F);
            Engine.object_set_function_variable(phantom_02.Entity, "hover_audio", 1F, 60F);
            Engine.object_set_function_variable(phantom_02.Entity, "engine_ducker", 0F, 60F);
        }

        [ScriptMethod(197, Lifecycle.Dormant)]
        public async Task c04_intro_sound_scene6b_07()
        {
            await Engine.sleep(375);
            Engine.sound_class_set_gain("vehicle", 0F, 30);
        }

        [ScriptMethod(198, Lifecycle.Dormant)]
        public async Task c04_1200_soc()
        {
            await Engine.sleep(330);
            Engine.sound_impulse_start_effect(Engine.GetTag<SoundTag>("sound\\dialog\\levels\\04_gasgiant\\cinematic\\c04_1200_soc", 3834184467U), default(IGameObject), 1F, "radio_covy");
            Engine.cinematic_subtitle("c04_1200_soc", 2F);
        }

        [ScriptMethod(199, Lifecycle.Dormant)]
        public async Task c04_intro_06b_fov()
        {
            await Engine.sleep(117);
            Engine.camera_set_field_of_view(60F, 32);
        }

        [ScriptMethod(200, Lifecycle.Dormant)]
        public async Task c04_06b_shake_1()
        {
            Engine.player_effect_stop(0F);
            await Engine.sleep(30);
            Engine.player_effect_set_max_rotation(0F, 1F, 1F);
            Engine.player_effect_start(0.25F, 2F);
            await Engine.sleep(60);
            Engine.player_effect_stop(2F);
        }

        [ScriptMethod(201, Lifecycle.Dormant)]
        public async Task c04_intro_cinematic_light_06b()
        {
            Engine.cinematic_lighting_set_primary_light(3F, 234F, 0.4F, 0.44F, 0.27F);
            Engine.cinematic_lighting_set_secondary_light(19F, 118F, 0.25F, 0.23F, 0.15F);
            Engine.cinematic_lighting_set_ambient_light(0.07F, 0.06F, 0.06F);
            Engine.rasterizer_bloom_override_threshold(0.4F);
            Engine.rasterizer_bloom_override_brightness(0.5F);
            Engine.object_uses_cinematic_lighting(phantom_01.Entity, true);
            Engine.object_uses_cinematic_lighting(phantom_02.Entity, true);
            Engine.object_uses_cinematic_lighting(phantom_03.Entity, true);
        }

        [ScriptMethod(202, Lifecycle.Dormant)]
        public async Task grunt_insertion()
        {
            await Engine.sleep(173);
            Engine.object_create_anew(grunt01);
            Engine.object_create_anew(grunt02);
            Engine.object_create_anew(grunt03);
            Engine.object_create_anew(grunt04);
            Engine.object_cinematic_lod(grunt01.Entity, true);
            Engine.object_cinematic_lod(grunt02.Entity, true);
            Engine.object_cinematic_lod(grunt03.Entity, true);
            Engine.object_cinematic_lod(grunt04.Entity, true);
            Engine.object_create_anew(plasma_pistol01);
            Engine.object_create_anew(plasma_pistol02);
            Engine.object_create_anew(plasma_pistol03);
            Engine.object_create_anew(plasma_pistol04);
            Engine.objects_attach(grunt01.Entity, "right_hand", plasma_pistol01.Entity, "");
            Engine.objects_attach(grunt01.Entity, "right_hand", plasma_pistol02.Entity, "");
            Engine.objects_attach(grunt01.Entity, "right_hand", plasma_pistol03.Entity, "");
            Engine.objects_attach(grunt01.Entity, "right_hand", plasma_pistol04.Entity, "");
            Engine.object_uses_cinematic_lighting(grunt01.Entity, true);
            Engine.object_uses_cinematic_lighting(grunt02.Entity, true);
            Engine.object_uses_cinematic_lighting(grunt03.Entity, true);
            Engine.object_uses_cinematic_lighting(grunt04.Entity, true);
            Engine.custom_animation_relative(grunt01.Entity, Engine.GetTag<AnimationGraphTag>("objects\\characters\\grunt\\04_intro\\04_intro", 3832873727U), "grunt01_06b", false, anchor02.Entity);
            Engine.custom_animation_relative(grunt02.Entity, Engine.GetTag<AnimationGraphTag>("objects\\characters\\grunt\\04_intro\\04_intro", 3832873727U), "grunt02_06b", false, anchor02.Entity);
            Engine.custom_animation_relative(grunt03.Entity, Engine.GetTag<AnimationGraphTag>("objects\\characters\\grunt\\04_intro\\04_intro", 3832873727U), "grunt03_06b", false, anchor02.Entity);
            Engine.custom_animation_relative(grunt04.Entity, Engine.GetTag<AnimationGraphTag>("objects\\characters\\grunt\\04_intro\\04_intro", 3832873727U), "grunt04_06b", false, anchor02.Entity);
        }

        [ScriptMethod(203, Lifecycle.Dormant)]
        public async Task elite_insertion()
        {
            await Engine.sleep(179);
            Engine.object_create_anew(elite03);
            Engine.object_create_anew(elite04);
            Engine.object_cinematic_lod(elite03.Entity, true);
            Engine.object_cinematic_lod(elite04.Entity, true);
            Engine.object_create_anew(plasma_rifle03);
            Engine.object_create_anew(plasma_rifle04);
            Engine.objects_attach(elite03.Entity, "right_hand_elite", plasma_rifle03.Entity, "");
            Engine.objects_attach(elite04.Entity, "right_hand_elite", plasma_rifle04.Entity, "");
            Engine.object_uses_cinematic_lighting(elite03.Entity, true);
            Engine.object_uses_cinematic_lighting(elite04.Entity, true);
            Engine.custom_animation_relative(elite03.Entity, Engine.GetTag<AnimationGraphTag>("objects\\characters\\elite\\04_intro\\04_intro", 3832808190U), "elite03_06b", false, anchor02.Entity);
            Engine.custom_animation_relative(elite04.Entity, Engine.GetTag<AnimationGraphTag>("objects\\characters\\elite\\04_intro\\04_intro", 3832808190U), "elite04_06b", false, anchor02.Entity);
        }

        [ScriptMethod(204, Lifecycle.Dormant)]
        public async Task dervish_insertion()
        {
            await Engine.sleep(312);
            Engine.object_create_anew(dervish02);
            Engine.object_create_anew(energy_blade01);
            Engine.object_cinematic_lod(dervish02.Entity, true);
            Engine.objects_attach(dervish02.Entity, "right_hand_elite", energy_blade01.Entity, "");
            Engine.object_set_permutation(energy_blade01.Entity, "blade", "noblade");
            Engine.object_uses_cinematic_lighting(dervish02.Entity, true);
            Engine.custom_animation_relative(dervish02.Entity, Engine.GetTag<AnimationGraphTag>("objects\\characters\\dervish\\04_intro\\04_intro", 3832742653U), "dervish_06b", false, anchor02.Entity);
            await Engine.sleep(72);
            Engine.object_set_permutation(energy_blade01.Entity, "blade", "default");
            Engine.object_set_function_variable(energy_blade01.Entity, "turned_on", 1F, 0F);
            Engine.effect_new_on_object_marker(Engine.GetTag<EffectTag>("effects\\objects\\weapons\\melee\\energy_blade\\blade_activate_elite", 3834250004U), dervish02.Entity, "right_hand_elite");
            Engine.print("blade activate");
        }

        [ScriptMethod(205, Lifecycle.Static)]
        public async Task test()
        {
            Engine.print("no blade");
            Engine.object_set_permutation(energy_blade01.Entity, "blade", "noblade");
            await Engine.sleep(60);
            Engine.object_set_permutation(energy_blade01.Entity, "blade", "default");
            Engine.effect_new_on_object_marker(Engine.GetTag<EffectTag>("effects\\objects\\weapons\\melee\\energy_blade\\blade_activate", 3834381078U), energy_blade01.Entity, "ground_point");
            Engine.print("blade");
        }

        [ScriptMethod(206, Lifecycle.Dormant)]
        public async Task elite_01_insertion()
        {
            await Engine.sleep(281);
            Engine.object_create_anew(elite01);
            Engine.object_create_anew(plasma_rifle01);
            Engine.object_cinematic_lod(elite01.Entity, true);
            Engine.objects_attach(elite01.Entity, "right_hand_elite", plasma_rifle01.Entity, "");
            Engine.object_uses_cinematic_lighting(elite01.Entity, true);
            Engine.custom_animation_relative(elite01.Entity, Engine.GetTag<AnimationGraphTag>("objects\\characters\\elite\\04_intro\\04_intro", 3832808190U), "elite01_06b", false, anchor02.Entity);
        }

        [ScriptMethod(207, Lifecycle.Dormant)]
        public async Task elite_02_insertion()
        {
            await Engine.sleep(272);
            Engine.object_create_anew(elite02);
            Engine.object_create_anew(plasma_rifle02);
            Engine.object_cinematic_lod(elite02.Entity, true);
            Engine.objects_attach(elite02.Entity, "right_hand_elite", plasma_rifle02.Entity, "");
            Engine.object_uses_cinematic_lighting(elite02.Entity, true);
            Engine.custom_animation_relative(elite02.Entity, Engine.GetTag<AnimationGraphTag>("objects\\characters\\elite\\04_intro\\04_intro", 3832808190U), "elite02_06b", false, anchor02.Entity);
        }

        [ScriptMethod(208, Lifecycle.Static)]
        public async Task c04_intro_06b_setup()
        {
            Engine.wake(new ScriptMethodReference(c04_intro_sound_scene6b_01));
            Engine.wake(new ScriptMethodReference(c04_intro_sound_scene6b_02));
            Engine.wake(new ScriptMethodReference(c04_intro_sound_scene6b_03));
            Engine.wake(new ScriptMethodReference(c04_intro_sound_scene6b_04));
            Engine.wake(new ScriptMethodReference(c04_intro_sound_scene6b_05));
            Engine.wake(new ScriptMethodReference(c04_intro_sound_scene6b_06));
            Engine.wake(new ScriptMethodReference(c04_intro_sound_scene6b_07));
            Engine.wake(new ScriptMethodReference(c04_1200_soc));
            Engine.wake(new ScriptMethodReference(grunt_insertion));
            Engine.wake(new ScriptMethodReference(elite_insertion));
            Engine.wake(new ScriptMethodReference(dervish_insertion));
            Engine.wake(new ScriptMethodReference(elite_01_insertion));
            Engine.wake(new ScriptMethodReference(elite_02_insertion));
            Engine.wake(new ScriptMethodReference(c04_intro_06b_fov));
            Engine.wake(new ScriptMethodReference(c04_06b_shake_1));
            Engine.wake(new ScriptMethodReference(c04_intro_cinematic_light_06b));
        }

        [ScriptMethod(209, Lifecycle.Static)]
        public async Task c04_intro_06b_cleanup()
        {
            Engine.object_destroy(dervish02.Entity);
            Engine.object_destroy(commander.Entity);
            Engine.object_destroy(elite01.Entity);
            Engine.object_destroy(elite02.Entity);
            Engine.object_destroy(elite03.Entity);
            Engine.object_destroy(elite04.Entity);
            Engine.object_destroy(grunt01.Entity);
            Engine.object_destroy(grunt02.Entity);
            Engine.object_destroy(grunt03.Entity);
            Engine.object_destroy(grunt04.Entity);
            Engine.object_destroy(phantom_01.Entity);
            Engine.object_destroy(phantom_02.Entity);
            Engine.object_destroy(phantom_03.Entity);
        }

        [ScriptMethod(210, Lifecycle.Static)]
        public async Task c04_intro_06b()
        {
            await this.c04_intro_06b_setup();
            Engine.camera_set_field_of_view(27.5F, 0);
            Engine.camera_set_animation_relative(Engine.GetTag<AnimationGraphTag>("objects\\characters\\cinematic_camera\\04_intro\\04_intro", 3830907617U), "04intro_06b", default(IUnit), cinematic_anchor02);
            Engine.custom_animation_relative(phantom_01.Entity, Engine.GetTag<AnimationGraphTag>("objects\\vehicles\\phantom\\animations\\04_intro\\04_intro", 3830973154U), "phantom01_06b", false, anchor02.Entity);
            Engine.custom_animation_relative(phantom_02.Entity, Engine.GetTag<AnimationGraphTag>("objects\\vehicles\\phantom\\animations\\04_intro\\04_intro", 3830973154U), "phantom02_06b", false, anchor02.Entity);
            Engine.custom_animation_relative(phantom_03.Entity, Engine.GetTag<AnimationGraphTag>("objects\\vehicles\\phantom\\animations\\04_intro\\04_intro", 3830973154U), "phantom03_06b", false, anchor02.Entity);
            await Engine.sleep((short)((float)Engine.camera_time() - 15));
            Engine.fade_out(1F, 1F, 1F, 15);
            await Engine.sleep(15);
            await this.c04_intro_06b_cleanup();
            await Engine.sleep(30);
            Engine.cinematic_lightmap_shadow_disable();
        }

        [ScriptMethod(211, Lifecycle.Static)]
        public async Task c04_intro()
        {
            Engine.texture_cache_flush();
            Engine.geometry_cache_flush();
            Engine.switch_bsp_by_name(Engine.GetReference<IBsp>("ag_cinematic_bsp1"));
            await Engine.sleep(1);
            await this.c04_intro_01();
            Engine.switch_bsp_by_name(Engine.GetReference<IBsp>("ag_cinematic_bsp2"));
            await this.c04_intro_02a();
            await this.c04_intro_02b();
            await this.c04_intro_02c();
            await this.c04_intro_02d();
            await this.c04_intro_03();
            Engine.switch_bsp_by_name(Engine.GetReference<IBsp>("alphagasgiant"));
            await this.c04_intro_05();
            await this.c04_intro_06b();
            Engine.rasterizer_bloom_override(false);
        }

        [ScriptMethod(212, Lifecycle.Continuous)]
        public async Task active_camo_drop()
        {
            await Engine.sleep_until(async () => (short)Engine.ai_combat_status(rec_center_heretics) > this.ai_combat_status_uninspected || (short)Engine.ai_combat_status(hangar_heretics) > this.ai_combat_status_uninspected || (short)Engine.ai_combat_status(first_hall_heretics) > this.ai_combat_status_uninspected || (short)Engine.ai_combat_status(underhangar_heretics) > this.ai_combat_status_uninspected || (short)Engine.ai_combat_status(second_hall_heretics) > this.ai_combat_status_uninspected || (short)Engine.ai_combat_status(bottling_heretics) > this.ai_combat_status_uninspected);
            Engine.ai_set_active_camo(arm01_allies, false);
            Engine.ai_set_blind(all_enemies, false);
        }

        [ScriptMethod(213, Lifecycle.CommandScript)]
        public async Task abort()
        {
            Engine.cs_pause(0.1F);
        }

        [ScriptMethod(214, Lifecycle.CommandScript)]
        public async Task long_pause()
        {
            Engine.cs_abort_on_alert(true);
            Engine.sleep_forever();
        }

        [ScriptMethod(215, Lifecycle.CommandScript)]
        public async Task forever_pause()
        {
            Engine.cs_pause(-1F);
        }

        [ScriptMethod(216, Lifecycle.CommandScript)]
        public async Task snap_alert()
        {
            Engine.cs_force_combat_status(4);
            await Engine.sleep(5);
        }

        [ScriptMethod(217, Lifecycle.CommandScript)]
        public async Task stealth_comment_01()
        {
            Engine.cs_switch("ally");
            Engine.cs_abort_on_damage(true);
            Engine.cs_suppress_dialogue_global(true);
            Engine.print("spec-ops elite: 'quietly now!'");
            Engine.cs_play_line("1020");
        }

        [ScriptMethod(218, Lifecycle.CommandScript)]
        public async Task stealth_comment_02()
        {
            Engine.cs_switch("ally");
            Engine.cs_abort_on_damage(true);
            Engine.cs_suppress_dialogue_global(true);
            Engine.print("spec-ops elite: 'with stealth!'");
            Engine.cs_play_line("1030");
        }

        [ScriptMethod(219, Lifecycle.CommandScript)]
        public async Task stealth_comment_03()
        {
            Engine.cs_switch("ally");
            Engine.cs_abort_on_damage(true);
            Engine.cs_suppress_dialogue_global(true);
            Engine.print("spec-ops elite: 'camouflage engaged!'");
            Engine.cs_play_line("1040");
        }

        [ScriptMethod(220, Lifecycle.CommandScript)]
        public async Task stealth_comment_04()
        {
            Engine.cs_switch("ally");
            Engine.cs_abort_on_damage(true);
            Engine.cs_suppress_dialogue_global(true);
            Engine.print("spec-ops elite: 'an honorable ruse!'");
            Engine.cs_play_line("1050");
        }

        [ScriptMethod(221, Lifecycle.CommandScript)]
        public async Task stealth_comment_05()
        {
            Engine.cs_switch("ally");
            Engine.cs_abort_on_damage(true);
            Engine.cs_suppress_dialogue_global(true);
            Engine.print("spec-ops elite: 'they shall not see me coming!'");
            Engine.cs_play_line("1060");
        }

        [ScriptMethod(222, Lifecycle.CommandScript)]
        public async Task stealth_comment_06()
        {
            Engine.cs_switch("ally");
            Engine.cs_abort_on_damage(true);
            Engine.cs_suppress_dialogue_global(true);
            Engine.print("spec-ops elite: 'i'm invisible!'");
            Engine.cs_play_line("1070");
        }

        [ScriptMethod(223, Lifecycle.CommandScript)]
        public async Task stealth_comment_07()
        {
            Engine.cs_switch("ally");
            Engine.cs_abort_on_damage(true);
            Engine.cs_suppress_dialogue_global(true);
            Engine.print("spec-ops elite: 'no one see me now!'");
            Engine.cs_play_line("1080");
        }

        [ScriptMethod(224, Lifecycle.CommandScript)]
        public async Task stealth_comment_08()
        {
            Engine.cs_switch("ally");
            Engine.cs_abort_on_damage(true);
            Engine.cs_suppress_dialogue_global(true);
            Engine.print("spec-ops elite: 'tricky-tricky!'");
            Engine.cs_play_line("1090");
        }

        [ScriptMethod(225, Lifecycle.CommandScript)]
        public async Task stealth_comment_09()
        {
            Engine.cs_switch("ally");
            Engine.cs_abort_on_damage(true);
            Engine.cs_suppress_dialogue_global(true);
            Engine.print("spec-ops elite: 'where me gun go? oh, right! (laughs)'");
            Engine.cs_play_line("1100");
        }

        [ScriptMethod(226, Lifecycle.CommandScript)]
        public async Task stealth_comment_10()
        {
            Engine.cs_switch("ally");
            Engine.cs_abort_on_damage(true);
            Engine.cs_suppress_dialogue_global(true);
            Engine.print("spec-ops elite: '(a la elmer fudd) shhhh! me hunting he-wa-tics!'");
            Engine.cs_play_line("1110");
        }

        [ScriptMethod(227, Lifecycle.Static)]
        public async Task stealth_comment()
        {
            await Engine.sleep((short)Engine.random_range(10, 60));
            Engine.begin_random(async () =>
            {
                if (this.stealth_talk_gone == true)
                {
                    this.stealth_talk_gone = false;
                    Engine.ai_scene("stealth_comment_01_scene", stealth_comment_01, all_allies) // Couldn't generate cast from 'Boolean' to 'Void'
                    ;
                }
            }, 
                async () =>
            {
                if (this.stealth_talk_gone == true)
                {
                    this.stealth_talk_gone = false;
                    Engine.ai_scene("stealth_comment_02_scene", stealth_comment_02, all_allies) // Couldn't generate cast from 'Boolean' to 'Void'
                    ;
                }
            }, 
                async () =>
            {
                if (this.stealth_talk_gone == true)
                {
                    this.stealth_talk_gone = false;
                    Engine.ai_scene("stealth_comment_03_scene", stealth_comment_03, all_allies) // Couldn't generate cast from 'Boolean' to 'Void'
                    ;
                }
            }, 
                async () =>
            {
                if (this.stealth_talk_gone == true)
                {
                    this.stealth_talk_gone = false;
                    Engine.ai_scene("stealth_comment_04_scene", stealth_comment_04, all_allies) // Couldn't generate cast from 'Boolean' to 'Void'
                    ;
                }
            }, 
                async () =>
            {
                if (this.stealth_talk_gone == true)
                {
                    this.stealth_talk_gone = false;
                    Engine.ai_scene("stealth_comment_05_scene", stealth_comment_05, all_allies) // Couldn't generate cast from 'Boolean' to 'Void'
                    ;
                }
            }, 
                async () =>
            {
                if (this.stealth_talk_gone == true)
                {
                    this.stealth_talk_gone = false;
                    Engine.ai_scene("stealth_comment_06_scene", stealth_comment_06, all_allies) // Couldn't generate cast from 'Boolean' to 'Void'
                    ;
                }
            }, 
                async () =>
            {
                if (this.stealth_talk_gone == true)
                {
                    this.stealth_talk_gone = false;
                    Engine.ai_scene("stealth_comment_07_scene", stealth_comment_07, all_allies) // Couldn't generate cast from 'Boolean' to 'Void'
                    ;
                }
            }, 
                async () =>
            {
                if (this.stealth_talk_gone == true)
                {
                    this.stealth_talk_gone = false;
                    Engine.ai_scene("stealth_comment_08_scene", stealth_comment_08, all_allies) // Couldn't generate cast from 'Boolean' to 'Void'
                    ;
                }
            }, 
                async () =>
            {
                if (this.stealth_talk_gone == true)
                {
                    this.stealth_talk_gone = false;
                    Engine.ai_scene("stealth_comment_09_scene", stealth_comment_09, all_allies) // Couldn't generate cast from 'Boolean' to 'Void'
                    ;
                }
            }, 
                async () =>
            {
                if (this.stealth_talk_gone == true)
                {
                    this.stealth_talk_gone = false;
                    Engine.ai_scene("stealth_comment_10_scene", stealth_comment_10, all_allies) // Couldn't generate cast from 'Boolean' to 'Void'
                    ;
                }
            });
        }

        [ScriptMethod(228, Lifecycle.Dormant)]
        public async Task _04a_title0()
        {
            await this.cinematic_fade_from_white_bars();
            await Engine.sleep(30);
            Engine.cinematic_set_title(title_1);
            await Engine.sleep(150);
            Engine.hud_cinematic_fade(1F, 0.5F);
            Engine.cinematic_show_letterbox(false);
        }

        [ScriptMethod(229, Lifecycle.Dormant)]
        public async Task _04a_title1()
        {
            Engine.hud_cinematic_fade(0F, 0.5F);
            Engine.cinematic_show_letterbox(true);
            await Engine.sleep(30);
            Engine.cinematic_set_title(title_2);
            await Engine.sleep(150);
            Engine.hud_cinematic_fade(1F, 0.5F);
            Engine.cinematic_show_letterbox(false);
        }

        [ScriptMethod(230, Lifecycle.Dormant)]
        public async Task objective_hl_set()
        {
            await Engine.sleep(30);
            Engine.print("new objective set:");
            Engine.print("locate the heretic leader.");
            Engine.objectives_show_up_to(0);
        }

        [ScriptMethod(231, Lifecycle.Dormant)]
        public async Task objective_hl_clear()
        {
            Engine.print("objective complete:");
            Engine.print("locate the heretic leader.");
            Engine.objectives_finish_up_to(0);
        }

        [ScriptMethod(232, Lifecycle.Dormant)]
        public async Task objective_dogfight_set()
        {
            await Engine.sleep(30);
            Engine.print("new objective set:");
            Engine.print("pursue the heretic leader. neutralize enemy air units.");
            Engine.objectives_show_up_to(1);
        }

        [ScriptMethod(233, Lifecycle.Dormant)]
        public async Task objective_dogfight_clear()
        {
            Engine.print("objective complete:");
            Engine.print("pursue the heretic leader. neutralize enemy air units.");
            Engine.objectives_finish_up_to(1);
        }

        [ScriptMethod(234, Lifecycle.Dormant)]
        public async Task music_04a_01_start()
        {
            Engine.print("music 04a_01 start");
            Engine.sound_looping_start(Engine.GetTag<LoopingSoundTag>("scenarios\\solo\\04a_gasgiant\\04a_music\\04a_01", 4154266986U), default(IGameObject), 1F);
        }

        [ScriptMethod(235, Lifecycle.Dormant)]
        public async Task music_04a_01_stop()
        {
            Engine.print("music 04a_01 stop");
            Engine.sound_looping_stop(Engine.GetTag<LoopingSoundTag>("scenarios\\solo\\04a_gasgiant\\04a_music\\04a_01", 4154266986U));
        }

        [ScriptMethod(236, Lifecycle.Dormant)]
        public async Task music_04a_02_start()
        {
            Engine.print("music 04a_02 start");
            Engine.sound_looping_start(Engine.GetTag<LoopingSoundTag>("scenarios\\solo\\04a_gasgiant\\04a_music\\04a_02", 4154463597U), default(IGameObject), 1F);
        }

        [ScriptMethod(237, Lifecycle.Dormant)]
        public async Task music_04a_02_stop()
        {
            Engine.print("music 04a_02 stop");
            Engine.sound_looping_stop(Engine.GetTag<LoopingSoundTag>("scenarios\\solo\\04a_gasgiant\\04a_music\\04a_02", 4154463597U));
        }

        [ScriptMethod(238, Lifecycle.Dormant)]
        public async Task music_04a_03_start()
        {
            Engine.print("music 04a_03 start");
            Engine.sound_looping_start(Engine.GetTag<LoopingSoundTag>("scenarios\\solo\\04a_gasgiant\\04a_music\\04a_03", 4154725745U), default(IGameObject), 1F);
        }

        [ScriptMethod(239, Lifecycle.Dormant)]
        public async Task music_04a_04_start()
        {
            Engine.print("music 04a_04 start");
            Engine.sound_looping_start(Engine.GetTag<LoopingSoundTag>("scenarios\\solo\\04a_gasgiant\\04a_music\\04a_04", 4154922356U), default(IGameObject), 1F);
        }

        [ScriptMethod(240, Lifecycle.Dormant)]
        public async Task music_04a_04_stop()
        {
            await Engine.sleep_until(async () => Engine.volume_test_objects(vol_dog_obj_04, Engine.players()) == true || Engine.volume_test_objects(vol_dog_obj_07, Engine.players()) == true, 30, 8000);
            Engine.print("music 04a_04 stop");
            Engine.sound_looping_stop(Engine.GetTag<LoopingSoundTag>("scenarios\\solo\\04a_gasgiant\\04a_music\\04a_04", 4154922356U));
        }

        [ScriptMethod(241, Lifecycle.Dormant)]
        public async Task kill_volumes()
        {
            Engine.kill_volume_disable(kill_banshee_ledge);
            Engine.kill_volume_disable(kill_recycling_pit);
            Engine.kill_volume_disable(kill_recycling_left);
            Engine.kill_volume_disable(kill_recycling_right);
            Engine.kill_volume_disable(kill_hangar_pit_01);
            Engine.kill_volume_disable(kill_hangar_pit_02);
            Engine.kill_volume_disable(kill_hangar_pit_03);
            Engine.kill_volume_disable(kill_hangar_pit_04);
            Engine.kill_volume_disable(kill_underhangar_pit_01);
            Engine.kill_volume_disable(kill_underhangar_pit_02);
            Engine.kill_volume_disable(kill_bottling_pit_01);
            Engine.kill_volume_disable(kill_bottling_pit_02);
            await Engine.sleep_until(async () => (short)Engine.structure_bsp_index() == 3);
            Engine.kill_volume_disable(kill_lz_pit);
            await Engine.sleep_until(async () =>
            {
                await Engine.sleep_until(async () => (short)Engine.structure_bsp_index() == 3);
                Engine.kill_volume_enable(kill_recycling_pit);
                Engine.kill_volume_enable(kill_recycling_left);
                Engine.kill_volume_enable(kill_recycling_right);
                Engine.kill_volume_enable(kill_hangar_pit_01);
                Engine.kill_volume_enable(kill_hangar_pit_02);
                Engine.kill_volume_enable(kill_hangar_pit_03);
                Engine.kill_volume_enable(kill_hangar_pit_04);
                Engine.kill_volume_enable(kill_underhangar_pit_01);
                Engine.kill_volume_enable(kill_underhangar_pit_02);
                Engine.kill_volume_disable(kill_bottling_pit_01);
                Engine.kill_volume_disable(kill_bottling_pit_02);
                await Engine.sleep_until(async () => (short)Engine.structure_bsp_index() == 0);
                Engine.kill_volume_enable(kill_banshee_ledge);
                Engine.kill_volume_enable(kill_bottling_pit_01);
                Engine.kill_volume_enable(kill_bottling_pit_02);
                Engine.kill_volume_disable(kill_recycling_pit);
                Engine.kill_volume_disable(kill_recycling_left);
                Engine.kill_volume_disable(kill_recycling_right);
                Engine.kill_volume_disable(kill_hangar_pit_01);
                Engine.kill_volume_disable(kill_hangar_pit_02);
                Engine.kill_volume_disable(kill_hangar_pit_03);
                Engine.kill_volume_disable(kill_hangar_pit_04);
                Engine.kill_volume_disable(kill_underhangar_pit_01);
                Engine.kill_volume_disable(kill_underhangar_pit_02);
                return false;
            });
        }

        [ScriptMethod(242, Lifecycle.Static)]
        public async Task prep_return_from_intro()
        {
            Engine.ai_place(intro_phantom.Squad);
            Engine.object_teleport(await this.player0(), player0_start);
            Engine.object_teleport(await this.player1(), player1_start);
            Engine.ai_place(intro_elites.Squad);
            Engine.ai_place(allies_elites_01.Squad);
            Engine.ai_place(hacker.Squad);
            Engine.ai_place(allies_grunts_01.Squad);
        }

        [ScriptMethod(243, Lifecycle.Dormant)]
        public async Task wind()
        {
            await Engine.sleep_until(async () =>
            {
                Engine.sound_impulse_start(Engine.GetTag<SoundTag>("sound\\ambience\\sound_scenery\\gusty_wind\\details\\gusty_wind", 4155184504U), default(IGameObject), 1F);
                await Engine.sleep(30);
                Engine.player_effect_set_max_rotation((float)Engine.real_random_range(0.1F, 1F), (float)Engine.real_random_range(0.1F, 1F), 0F);
                Engine.player_effect_start((float)Engine.real_random_range(0.05F, 0.2F), (float)Engine.real_random_range(0.5F, 2F));
                Engine.player_effect_stop((float)Engine.real_random_range(3F, 5F));
                await Engine.sleep((short)Engine.random_range(300, 600));
                return (short)Engine.structure_bsp_index() == 3;
            });
        }

        [ScriptMethod(244, Lifecycle.Static)]
        public async Task windtoo()
        {
            await Engine.sleep_until(async () =>
            {
                Engine.sound_impulse_start(Engine.GetTag<SoundTag>("sound\\ambience\\sound_scenery\\gusty_wind\\details\\gusty_wind", 4155184504U), default(IGameObject), 1F);
                await Engine.sleep(30);
                Engine.player_effect_set_max_rotation((float)Engine.real_random_range(0.1F, 1F), (float)Engine.real_random_range(0.1F, 1F), 0F);
                Engine.player_effect_start((float)Engine.real_random_range(0.05F, 0.2F), (float)Engine.real_random_range(0.5F, 2F));
                Engine.player_effect_stop((float)Engine.real_random_range(3F, 5F));
                await Engine.sleep((short)Engine.random_range(300, 600));
                return (short)Engine.structure_bsp_index() == 3;
            });
        }

        [ScriptMethod(245, Lifecycle.CommandScript)]
        public async Task lz_phantom_01_away()
        {
            Engine.cs_enable_pathfinding_failsafe(true);
            Engine.cs_vehicle_boost(true);
            Engine.cs_fly_to(Engine.GetReference<ISpatialPoint>("airspace_lz/exit01"), 20F);
            Engine.ai_erase(this.ai_current_actor);
        }

        [ScriptMethod(246, Lifecycle.CommandScript)]
        public async Task lz_phantom_02_away()
        {
            Engine.cs_enable_pathfinding_failsafe(true);
            Engine.cs_vehicle_boost(true);
            Engine.cs_fly_to(Engine.GetReference<ISpatialPoint>("airspace_lz/exit02"), 20F);
            Engine.ai_erase(this.ai_current_actor);
        }

        [ScriptMethod(247, Lifecycle.CommandScript)]
        public async Task lz_phantom_03_away()
        {
            Engine.cs_enable_pathfinding_failsafe(true);
            Engine.cs_vehicle_boost(true);
            Engine.cs_fly_to(Engine.GetReference<ISpatialPoint>("airspace_lz/exit03"), 20F);
            Engine.ai_erase(this.ai_current_actor);
        }

        [ScriptMethod(248, Lifecycle.Dormant)]
        public async Task commander_entry_reminder()
        {
            await Engine.sleep_until(async () => Engine.volume_test_objects(vol_entering_facility, Engine.players()) == true, 30, 900);
            if (Engine.volume_test_objects(vol_entering_facility, Engine.players()) == false && await this.player_count() > 0)
            {
                Engine.ai_dialogue_enable(false);
                await Engine.sleep(60);
                Engine.print("spec-ops commander: 'my warriors are in position, arbiter. they wait for you to lead them!'");
                await Engine.sleep(Engine.ai_play_line_on_object(default(IGameObject), "0970"));
                await Engine.sleep(30);
                Engine.ai_dialogue_enable(true);
            }
        }

        [ScriptMethod(249, Lifecycle.Dormant)]
        public async Task commander_comment_03()
        {
            Engine.ai_dialogue_enable(false);
            await Engine.sleep(60);
            Engine.print("spec-ops commander: 'you may wish to do the same, arbiter.'");
            await Engine.sleep(Engine.ai_play_line_on_object(default(IGameObject), "1000"));
            await Engine.sleep(30);
            Engine.print("'but, take heed. your armor's system is not as�new as ours. your camouflage will not last forever.'");
            await Engine.sleep(Engine.ai_play_line_on_object(default(IGameObject), "1010"));
            this.stealth_hint_done = true;
            await Engine.sleep(30);
            Engine.ai_dialogue_enable(true);
        }

        [ScriptMethod(250, Lifecycle.CommandScript)]
        public async Task lz_active_camo_call()
        {
            this.first_airlock_go = true;
            Engine.cs_switch("ally");
            Engine.object_cannot_take_damage(Engine.ai_get_object(this.ai_current_actor));
            Engine.cs_suppress_dialogue_global(true);
            Engine.print("spec-ops elite: 'engage active camouflage! reveal yourselves only after the arbiter has joined battle with the enemy!'");
            Engine.cs_play_line("0980");
            await Engine.sleep(30);
            Engine.ai_set_orders(all_allies, allies_rec_hide);
            await Engine.sleep(60);
            Engine.wake(new ScriptMethodReference(commander_comment_03));
            Engine.object_can_take_damage(Engine.ai_get_object(this.ai_current_actor));
        }

        [ScriptMethod(251, Lifecycle.CommandScript)]
        public async Task inner_aim_elites()
        {
            Engine.cs_abort_on_damage(true);
            Engine.cs_enable_moving(true);
            Engine.cs_crouch(true);
            await Engine.sleep_until(async () => Engine.volume_test_object(vol_entering_facility, Engine.ai_get_object(this.ai_current_actor)) == true);
            Engine.cs_aim(true, Engine.GetReference<ISpatialPoint>("recycling_center/rec_center_inner"));
            Engine.cs_crouch(false);
            await Engine.sleep_until(async () => (short)Engine.structure_bsp_index() == 3);
            Engine.cs_enable_moving(false);
            await Engine.sleep_until(async () => Engine.device_get_position(rec_center_entry_int.Entity) > 0F);
            Engine.cs_aim(false, Engine.GetReference<ISpatialPoint>("recycling_center/rec_center_inner"));
        }

        [ScriptMethod(252, Lifecycle.CommandScript)]
        public async Task inner_aim_hacker()
        {
            Engine.cs_abort_on_damage(true);
            Engine.cs_enable_moving(true);
            await Engine.sleep_until(async () => Engine.volume_test_object(vol_entering_facility, Engine.ai_get_object(this.ai_current_actor)) == true);
            Engine.cs_aim(true, Engine.GetReference<ISpatialPoint>("recycling_center/rec_center_inner"));
            await Engine.sleep_until(async () => (short)Engine.structure_bsp_index() == 3);
            Engine.cs_enable_moving(false);
            await Engine.sleep_until(async () => Engine.device_get_position(rec_center_entry_int.Entity) > 0F);
            Engine.cs_aim(false, Engine.GetReference<ISpatialPoint>("recycling_center/rec_center_inner"));
        }

        [ScriptMethod(253, Lifecycle.CommandScript)]
        public async Task inner_aim_grunts()
        {
            Engine.cs_abort_on_damage(true);
            await Engine.sleep(60);
            Engine.cs_enable_moving(true);
            await Engine.sleep_until(async () => Engine.volume_test_object(vol_entering_facility, Engine.ai_get_object(this.ai_current_actor)) == true);
            Engine.cs_aim(true, Engine.GetReference<ISpatialPoint>("recycling_center/rec_center_inner"));
            await Engine.sleep_until(async () => (short)Engine.structure_bsp_index() == 3);
            Engine.cs_enable_moving(false);
            await Engine.sleep_until(async () => Engine.device_get_position(rec_center_entry_int.Entity) > 0F);
            Engine.cs_aim(false, Engine.GetReference<ISpatialPoint>("recycling_center/rec_center_inner"));
        }

        [ScriptMethod(254, Lifecycle.Dormant)]
        public async Task production_arm_bsp_swap()
        {
            Engine.device_operates_automatically_set(rec_center_entry_ext.Entity, true);
            Engine.cs_run_command_script(allies_elites_01.Squad, inner_aim_elites);
            Engine.cs_run_command_script(allies_grunts_01.Squad, inner_aim_grunts);
            Engine.ai_set_orders(allies_elites_01.Squad, allies_enter);
            Engine.ai_set_orders(allies_grunts_01.Squad, allies_enter);
            Engine.ai_set_orders(intro_elites.Squad, lz_linger);
            Engine.wake(new ScriptMethodReference(commander_entry_reminder));
            await Engine.sleep_until(async () => Engine.volume_test_objects_all(vol_entering_facility, Engine.players()) == true && await this.player_count() > 0);
            Engine.cs_run_command_script(hacker.Squad, inner_aim_hacker);
            Engine.ai_set_orders(hacker.Squad, allies_enter);
            Engine.sleep_forever(new ScriptMethodReference(wind));
            await Engine.sleep_until(async () => Engine.volume_test_objects_all(vol_entering_facility, Engine.players()) == true && await this.player_count() > 0 && Engine.device_get_position(rec_center_entry_ext.Entity) == 0F);
            Engine.device_operates_automatically_set(rec_center_entry_ext.Entity, false);
            await Engine.sleep(30);
            Engine.sound_class_set_gain("ambient_machinery", 0F, 2);
            Engine.begin_random(async () => Engine.object_create_anew(gas01), 
                async () => await Engine.sleep((short)Engine.random_range(5, 15)), 
                async () => Engine.object_create_anew(gas02), 
                async () => await Engine.sleep((short)Engine.random_range(5, 15)), 
                async () => Engine.object_create_anew(gas03), 
                async () => await Engine.sleep((short)Engine.random_range(5, 15)), 
                async () => Engine.object_create_anew(gas04), 
                async () => await Engine.sleep((short)Engine.random_range(5, 15)), 
                async () => Engine.object_create_anew(gas05), 
                async () => await Engine.sleep((short)Engine.random_range(5, 15)), 
                async () => Engine.object_create_anew(gas06), 
                async () => await Engine.sleep((short)Engine.random_range(5, 15)), 
                async () => Engine.object_create_anew(gas07), 
                async () => await Engine.sleep((short)Engine.random_range(5, 15)), 
                async () => Engine.object_create_anew(gas08), 
                async () => await Engine.sleep((short)Engine.random_range(5, 15)), 
                async () => Engine.object_create_anew(gas09), 
                async () => await Engine.sleep((short)Engine.random_range(5, 15)), 
                async () => Engine.object_create_anew(gas10), 
                async () => await Engine.sleep((short)Engine.random_range(5, 15)));
            Engine.switch_bsp(3);
            await Engine.sleep_until(async () => (short)Engine.structure_bsp_index() == 3);
            Engine.object_destroy(filthy_audio1.Entity);
            Engine.object_destroy(filthy_audio2.Entity);
            Engine.sound_class_set_gain("ambient_machinery", 1F, 2);
            await Engine.sleep_until(async () => Engine.ai_scene("lz_active_camo_scene", lz_active_camo_call, all_allies) || (short)Engine.ai_living_count(hacker.Squad) < 0 && (short)Engine.ai_living_count(allies_elites_01.Squad) < 1, 30, 150);
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
            Engine.player_training_activate_stealth();
            if (this.first_airlock_go == true)
            {
                await Engine.sleep_until(async () => this.stealth_hint_done == true, 30, 900);
            }

            Engine.device_operates_automatically_set(rec_center_entry_int.Entity, true);
        }

        [ScriptMethod(255, Lifecycle.Dormant)]
        public async Task commander_comment_01()
        {
            await Engine.sleep(60);
            Engine.ai_dialogue_enable(false);
            await Engine.sleep(60);
            Engine.print("spec-ops commander: 'we are the arm of the prophets, dervish, and you are the blade!'");
            await Engine.sleep(Engine.ai_play_line_on_object(default(IGameObject), "0210"));
            await Engine.sleep(30);
            Engine.print("'be silent and swift, and we will quell this heresy without incident!'");
            await Engine.sleep(Engine.ai_play_line_on_object(default(IGameObject), "0220"));
            await Engine.sleep(15);
            this.commander_done_yapping = true;
            await Engine.sleep(30);
        }

        [ScriptMethod(256, Lifecycle.Dormant)]
        public async Task commander_comment_02()
        {
            Engine.ai_dialogue_enable(false);
            await Engine.sleep(60);
            Engine.print("spec-ops commander: 'the storm has masked our approach.'");
            await Engine.sleep(Engine.ai_play_line_on_object(default(IGameObject), "0240"));
            await Engine.sleep(30);
            Engine.print("spec-ops commander: 'and it should have their local battle-net in disarray.'");
            await Engine.sleep(Engine.ai_play_line_on_object(default(IGameObject), "0250"));
            await Engine.sleep(30);
            Engine.print("spec-ops commander: 'we have the element of surprise.  for now.'");
            await Engine.sleep(Engine.ai_play_line_on_object(default(IGameObject), "0260"));
            Engine.unit_stop_custom_animation(Engine.unit(Engine.list_get(Engine.ai_actors(hacker.Squad), 0)));
            this.open_rec_center = true;
            await Engine.sleep(30);
            Engine.ai_dialogue_enable(true);
        }

        [ScriptMethod(257, Lifecycle.CommandScript)]
        public async Task lz_phantom_leaves()
        {
            Engine.cs_fly_by(Engine.GetReference<ISpatialPoint>("airspace_lz/p0"), 10F);
            Engine.cs_fly_by(Engine.GetReference<ISpatialPoint>("airspace_lz/p1"), 10F);
            Engine.cs_fly_by(Engine.GetReference<ISpatialPoint>("airspace_lz/p2"), 10F);
            Engine.cs_fly_by(Engine.GetReference<ISpatialPoint>("airspace_lz/p3"), 10F);
            Engine.cs_fly_by(Engine.GetReference<ISpatialPoint>("airspace_lz/p4"), 10F);
            Engine.cs_fly_by(Engine.GetReference<ISpatialPoint>("airspace_lz/p5"), 10F);
            Engine.cs_fly_to(Engine.GetReference<ISpatialPoint>("airspace_lz/p6"), 10F);
            Engine.ai_erase(intro_phantom.Squad);
        }

        [ScriptMethod(258, Lifecycle.CommandScript)]
        public async Task landing_zone_follow_01()
        {
            Engine.cs_abort_on_damage(true);
            Engine.cs_enable_pathfinding_failsafe(true);
            Engine.cs_go_to(Engine.GetReference<ISpatialPoint>("landing_zone/ramp01"));
            Engine.cs_face_player(true);
            await Engine.sleep_until(async () => Engine.volume_test_objects(vol_leaving_lz, Engine.players()) == true);
            Engine.cs_face_player(false);
        }

        [ScriptMethod(259, Lifecycle.CommandScript)]
        public async Task landing_zone_follow_02()
        {
            Engine.cs_abort_on_damage(true);
            Engine.cs_enable_pathfinding_failsafe(true);
            Engine.cs_go_to(Engine.GetReference<ISpatialPoint>("landing_zone/ramp02"));
            Engine.cs_face_player(true);
            await Engine.sleep_until(async () => Engine.volume_test_objects(vol_leaving_lz, Engine.players()) == true);
            Engine.cs_face_player(false);
            Engine.cs_suppress_dialogue_global(true);
            if (this.commander_done_yapping == true)
            {
                Engine.print("spec-ops elite: 'first lance in position!'");
                Engine.cs_play_line("0230");
            }
        }

        [ScriptMethod(260, Lifecycle.CommandScript)]
        public async Task swat_hack()
        {
            Engine.cs_abort_on_damage(true);
            Engine.cs_aim(true, Engine.GetReference<ISpatialPoint>("landing_zone/control"));
            await Engine.sleep_until(async () => Engine.device_get_position(rec_center_entry_ext.Entity) == 1F || Engine.volume_test_objects(vol_entering_facility, Engine.players()) == true);
            Engine.cs_aim(false, Engine.GetReference<ISpatialPoint>("landing_zone/control"));
        }

        [ScriptMethod(261, Lifecycle.CommandScript)]
        public async Task swat_aim()
        {
            Engine.cs_abort_on_damage(true);
            Engine.cs_aim(true, Engine.GetReference<ISpatialPoint>("landing_zone/entry"));
            await Engine.sleep_until(async () => Engine.device_get_position(rec_center_entry_ext.Entity) == 1F || Engine.volume_test_objects(vol_entering_facility, Engine.players()) == true);
            Engine.cs_aim(false, Engine.GetReference<ISpatialPoint>("landing_zone/entry"));
        }

        [ScriptMethod(262, Lifecycle.Dormant)]
        public async Task swat_deploy()
        {
            Engine.data_mine_set_mission_segment("04a_1_landing_zone");
            Engine.wake(new ScriptMethodReference(wind));
            Engine.wake(new ScriptMethodReference(commander_comment_01));
            Engine.cs_run_command_script(intro_elites._01, landing_zone_follow_01);
            Engine.cs_run_command_script(intro_elites._02, landing_zone_follow_02);
            Engine.custom_animation_loop(Engine.unit(Engine.list_get(Engine.ai_actors(hacker.Squad), 0)), Engine.GetTag<AnimationGraphTag>("objects\\characters\\elite\\elite", 3882747384U), "uplink_station", true);
            Engine.cs_run_command_script(hacker.Squad, swat_hack);
            Engine.cs_run_command_script(intro_phantom._01, lz_phantom_01_away);
            Engine.cs_run_command_script(intro_phantom._02, lz_phantom_02_away);
            Engine.cs_run_command_script(intro_phantom._03, lz_phantom_03_away);
            Engine.cs_run_command_script(allies_grunts_01.Squad, swat_aim);
            Engine.cs_run_command_script(allies_elites_01.Squad, swat_aim);
            await Engine.sleep_until(async () => Engine.volume_test_objects(vol_entry_landing, Engine.players()) == true);
            await Engine.sleep_until(async () => this.commander_done_yapping == true);
            Engine.wake(new ScriptMethodReference(commander_comment_02));
            await Engine.sleep_until(async () => this.open_rec_center == true || Engine.object_get_health(Engine.list_get(Engine.ai_actors(hacker.Squad), 0)) <= 0F, 30, 360);
            Engine.wake(new ScriptMethodReference(production_arm_bsp_swap));
            await Engine.sleep_until(async () => Engine.volume_test_objects_all(vol_phantom_kill, Engine.ai_actors(intro_phantom.Squad)) == true || Engine.volume_test_objects_all(vol_recycling_all, Engine.players()) == true && await this.player_count() > 0);
            Engine.ai_erase(intro_phantom.Squad);
            await Engine.sleep_until(async () => Engine.volume_test_objects_all(vol_recycling_all, Engine.players()) == true && await this.player_count() > 0);
            Engine.ai_erase(intro_elites.Squad);
        }

        [ScriptMethod(263, Lifecycle.Dormant)]
        public async Task recycling_can_spawner()
        {
            Engine.object_set_deleted_when_deactivated(rec_can_a_01.Entity);
            Engine.object_set_deleted_when_deactivated(rec_can_a_02.Entity);
            Engine.object_set_deleted_when_deactivated(rec_can_a_03.Entity);
            Engine.object_set_deleted_when_deactivated(rec_can_a_04.Entity);
            Engine.object_set_deleted_when_deactivated(rec_can_a_06.Entity);
            Engine.object_set_deleted_when_deactivated(rec_can_a_07.Entity);
            Engine.object_set_deleted_when_deactivated(rec_can_b_01.Entity);
            Engine.object_set_deleted_when_deactivated(rec_can_b_02.Entity);
            Engine.object_set_deleted_when_deactivated(rec_can_c_01.Entity);
            Engine.object_set_deleted_when_deactivated(rec_can_c_02.Entity);
            Engine.object_set_deleted_when_deactivated(rec_can_c_03.Entity);
            Engine.object_set_deleted_when_deactivated(rec_can_c_04.Entity);
            Engine.object_set_deleted_when_deactivated(rec_can_c_06.Entity);
            await Engine.sleep_until(async () => this.recycling_power_on == true);
            await Engine.sleep_until(async () =>
            {
                Engine.begin_random(async () =>
                {
                    if (Engine.list_count(Engine.volume_return_objects_by_type(vol_recycling_can_all, 2048)) < 20)
                    {
                        Engine.object_create_clone(recycling_can_a);
                        Engine.object_set_deleted_when_deactivated(recycling_can_a.Entity);
                    }
                }, 
                    async () => await Engine.sleep(this.recycling_time), 
                    async () =>
                {
                    if (Engine.list_count(Engine.volume_return_objects_by_type(vol_recycling_can_all, 2048)) < 20)
                    {
                        Engine.object_create_clone(recycling_can_b);
                        Engine.object_set_deleted_when_deactivated(recycling_can_b.Entity);
                    }
                }, 
                    async () => await Engine.sleep(this.recycling_time), 
                    async () =>
                {
                    if (Engine.list_count(Engine.volume_return_objects_by_type(vol_recycling_can_all, 2048)) < 20)
                    {
                        Engine.object_create_clone(recycling_can_c);
                        Engine.object_set_deleted_when_deactivated(recycling_can_c.Entity);
                    }
                }, 
                    async () => await Engine.sleep(this.recycling_time));
                return this.recycling_power_on == false;
            });
        }

        [ScriptMethod(264, Lifecycle.Dormant)]
        public async Task recycling_killer_new()
        {
            await Engine.sleep_until(async () => this.recycling_power_on == true);
            await Engine.sleep_until(async () =>
            {
                Engine.object_destroy(Engine.list_get(Engine.volume_return_objects(kill_recycling_pit), 0));
                await Engine.sleep(30);
                Engine.unit_kill_silent(Engine.unit(Engine.list_get(Engine.volume_return_objects_by_type(kill_recycling_pit, 1), 0)));
                await Engine.sleep(30);
                return this.recycling_power_on == false;
            });
        }

        [ScriptMethod(265, Lifecycle.CommandScript)]
        public async Task heretic_chat()
        {
            Engine.cs_switch("chat_her_02");
            Engine.cs_abort_on_alert(true);
            this.chatter_her_02 = Engine.ai_get_object(this.ai_current_actor);
            Engine.cs_enable_moving(true);
            Engine.cs_switch("chat_her_01");
            Engine.cs_abort_on_alert(true);
            this.chatter_her_01 = Engine.ai_get_object(this.ai_current_actor);
            Engine.cs_enable_pathfinding_failsafe(true);
            Engine.cs_go_to_and_face(Engine.GetReference<ISpatialPoint>("recycling_center/p0"), Engine.GetReference<ISpatialPoint>("recycling_center/p1"));
            Engine.cs_custom_animation(Engine.GetTag<AnimationGraphTag>("objects\\characters\\elite\\elite", 3882747384U), "uplink_station", 0F, true);
            Engine.custom_animation_loop(Engine.unit(Engine.ai_get_object(this.ai_current_actor)), Engine.GetTag<AnimationGraphTag>("objects\\characters\\elite\\elite", 3882747384U), "uplink_station", true);
            Engine.cs_switch("chat_her_02");
            Engine.cs_enable_pathfinding_failsafe(true);
            Engine.cs_approach(this.chatter_her_01, 2F, 20F, 20F);
            Engine.cs_suppress_dialogue_global(true);
            Engine.print("heretic_01: 'any word on our missing brothers?'");
            Engine.cs_play_line("0270");
            Engine.cs_switch("chat_her_01");
            Engine.unit_stop_custom_animation(Engine.unit(Engine.ai_get_object(this.ai_current_actor)));
            Engine.cs_face(false, Engine.GetReference<ISpatialPoint>("recycling_center/p1"));
            Engine.cs_approach(this.chatter_her_02, 1.5F, 20F, 20F);
            Engine.cs_suppress_dialogue_global(true);
            Engine.print("heretic_02: 'still nothing.'");
            Engine.cs_play_line("0280");
            await Engine.sleep(30);
            Engine.print("heretic_02: 'and given what sleeps here, i fear they are lost.'");
            Engine.cs_play_line("0290");
            await Engine.sleep(15);
            Engine.cs_switch("chat_her_02");
            Engine.cs_suppress_dialogue_global(true);
            Engine.print("heretic_01: 'surely the oracle will protect us?'");
            Engine.cs_play_line("0300");
            await Engine.sleep(15);
            Engine.cs_switch("chat_her_01");
            Engine.cs_suppress_dialogue_global(true);
            Engine.print("heretic_02: 'perhaps. but i fear its sentinels are too few.'");
            Engine.cs_play_line("0310");
            await Engine.sleep(15);
            Engine.print("heretic_02: 'better we protect ourselves.'");
            Engine.cs_play_line("0320");
            await Engine.sleep(30);
            Engine.cs_run_command_script(rec_center_heretic_02.Squad, abort);
            Engine.cs_approach_stop();
            await Engine.sleep(60);
            Engine.cs_enable_moving(true);
        }

        [ScriptMethod(266, Lifecycle.Dormant)]
        public async Task heretic_uplink_01()
        {
            Engine.custom_animation_loop(Engine.unit(Engine.list_get(Engine.ai_actors(rec_center_heretic_03.Squad), 0)), Engine.GetTag<AnimationGraphTag>("objects\\characters\\elite\\elite", 3882747384U), "uplink_station", true);
            await Engine.sleep_until(async () => (short)Engine.ai_combat_status(rec_center_heretic_03.Squad) > this.ai_combat_status_idle);
            Engine.unit_stop_custom_animation(Engine.unit(Engine.list_get(Engine.ai_actors(rec_center_heretic_03.Squad), 0)));
        }

        [ScriptMethod(267, Lifecycle.Dormant)]
        public async Task rec_center_reminder()
        {
            await Engine.sleep_until(async () => Engine.volume_test_objects(vol_leaving_rec_center, Engine.players()) == true, 30, 3600);
            if (Engine.volume_test_objects(vol_leaving_rec_center, Engine.players()) == false && await this.player_count() > 0)
            {
                Engine.ai_dialogue_enable(false);
                await Engine.sleep(60);
                Engine.print("spec-ops commander: 'there should be a hangar directly below you. find a way down!'");
                await Engine.sleep(Engine.ai_play_line_on_object(default(IGameObject), "1130"));
                await Engine.sleep(30);
                Engine.ai_dialogue_enable(true);
            }
        }

        [ScriptMethod(268, Lifecycle.CommandScript)]
        public async Task get_on_e1()
        {
            Engine.cs_enable_pathfinding_failsafe(true);
            Engine.cs_go_to(Engine.GetReference<ISpatialPoint>("recycling_center/e1"));
        }

        [ScriptMethod(269, Lifecycle.CommandScript)]
        public async Task get_on_e2()
        {
            Engine.cs_enable_pathfinding_failsafe(true);
            Engine.cs_go_to(Engine.GetReference<ISpatialPoint>("recycling_center/e2"));
        }

        [ScriptMethod(270, Lifecycle.CommandScript)]
        public async Task get_on_g1()
        {
            Engine.cs_enable_pathfinding_failsafe(true);
            Engine.cs_go_to(Engine.GetReference<ISpatialPoint>("recycling_center/g1"));
        }

        [ScriptMethod(271, Lifecycle.CommandScript)]
        public async Task get_on_g2()
        {
            Engine.cs_enable_pathfinding_failsafe(true);
            Engine.cs_go_to(Engine.GetReference<ISpatialPoint>("recycling_center/g2"));
        }

        [ScriptMethod(272, Lifecycle.CommandScript)]
        public async Task rec_center_turret()
        {
            Engine.cs_enable_pathfinding_failsafe(true);
            Engine.cs_go_to(Engine.GetReference<ISpatialPoint>("rec_cen_turret/go_here"));
            Engine.cs_deploy_turret(Engine.GetReference<ISpatialPoint>("rec_cen_turret/p1"));
            Engine.cs_enable_targeting(true);
            Engine.cs_shoot(true);
            Engine.cs_set_behavior(guard);
            Engine.sleep_forever();
        }

        [ScriptMethod(273, Lifecycle.Dormant)]
        public async Task recycling_center_start()
        {
            await Engine.sleep_until(async () => (short)Engine.structure_bsp_index() == 3);
            Engine.data_mine_set_mission_segment("04a_2_recycling_center");
            Engine.object_create_containing("rec_can_");
            Engine.wake(new ScriptMethodReference(recycling_can_spawner));
            Engine.wake(new ScriptMethodReference(recycling_killer_new));
            this.recycling_power_on = true;
            Engine.ai_place(rec_center_heretic_01.Squad, 1);
            Engine.ai_place(rec_center_heretic_02.Squad, 1);
            Engine.cs_run_command_script(rec_center_heretic_02.Squad, long_pause);
            Engine.ai_place(rec_center_grunts_01.Squad, 2);
            await Engine.sleep_until(async () => this.stealth_hint_done == true);
            Engine.game_save();
            await Engine.sleep_until(async () => Engine.device_get_position(rec_center_entry_int.Entity) > 0F);
            await Engine.sleep_until(async () => Engine.device_get_position(rec_center_entry_int.Entity) == 1F);
            Engine.ai_scene("heretic_chat_scene", heretic_chat, rec_center_h_entry) // Couldn't generate cast from 'Boolean' to 'Void'
            ;
            Engine.ai_set_orders(arm01_allies, allies_rec_center_all);
            await Engine.sleep_until(async () => Engine.volume_test_objects(vol_rec_slope_top, Engine.players()) == true || (short)Engine.ai_living_count(rec_center_heretics) < 2);
            Engine.game_save();
            Engine.ai_place(rec_center_grunts_02R.Squad, 2);
            Engine.ai_place(rec_center_grunts_02L.Squad, 2);
            if ((short)Engine.ai_combat_status(rec_center_heretics) > this.ai_combat_status_idle)
            {
                if (Engine.objects_can_see_object(Engine.players(), rec_cen_rein_01r.Entity, 45F))
                {
                    if ((short)Engine.ai_living_count(rec_center_heretics) < 8)
                    {
                        Engine.ai_place(rec_cen_rein_her_01R.Squad, 1);
                    }

                    Engine.cs_run_command_script(rec_cen_rein_her_01R.Squad, snap_alert);
                    if ((short)Engine.ai_living_count(rec_center_heretics) < 8)
                    {
                        Engine.ai_place(rec_cen_rein_grt_01R.Squad, (short)Engine.random_range(1, 3));
                    }

                    Engine.cs_run_command_script(rec_cen_rein_grt_01R.Squad, snap_alert);
                }

                if (Engine.objects_can_see_object(Engine.players(), rec_cen_rein_01l.Entity, 45F))
                {
                    if ((short)Engine.ai_living_count(rec_center_heretics) < 8)
                    {
                        Engine.ai_place(rec_cen_rein_her_01L.Squad, (short)(1 - (float)Engine.ai_living_count(rec_cen_rein_her_01R.Squad)));
                    }

                    Engine.cs_run_command_script(rec_cen_rein_her_01L.Squad, snap_alert);
                    if ((short)Engine.ai_living_count(rec_center_heretics) < 8)
                    {
                        Engine.ai_place(rec_cen_rein_grt_01L.Squad, (short)((float)Engine.random_range(1, 3) - (float)Engine.ai_living_count(rec_cen_rein_grt_01R.Squad)));
                    }

                    Engine.cs_run_command_script(rec_cen_rein_grt_01L.Squad, snap_alert);
                }
            }

            await Engine.sleep_until(async () => Engine.volume_test_objects(vol_recycling_mid_01, Engine.players()) == true || (short)Engine.ai_living_count(rec_center_heretics) < 3);
            Engine.game_save();
            Engine.cs_run_command_script(allies_grunts_01.grunt02, rec_center_turret);
            if ((short)Engine.ai_living_count(rec_center_heretics) < 8)
            {
                Engine.ai_place(rec_center_grunts_03.Squad, 3);
            }

            if ((short)Engine.ai_living_count(rec_center_heretics) < 8)
            {
                Engine.ai_place(rec_center_heretic_03.Squad, 2);
            }

            Engine.wake(new ScriptMethodReference(heretic_uplink_01));
            await Engine.sleep_until(async () => Engine.volume_test_objects(vol_recycling_mid_02, Engine.players()) == true || (short)Engine.ai_living_count(rec_center_heretics) < 3);
            Engine.game_save();
            if ((short)Engine.ai_living_count(rec_center_heretics) < 8)
            {
                Engine.ai_place(rec_center_heretic_04.Squad, (short)(1 - (float)Engine.ai_living_count(rec_center_heretic_03.Squad)));
            }

            if ((short)Engine.ai_living_count(rec_center_heretics) < 8)
            {
                Engine.ai_place(rec_center_grunts_04.Squad, (short)(3 - (float)Engine.ai_living_count(rec_center_grunts_03.Squad)));
            }

            Engine.wake(new ScriptMethodReference(rec_center_reminder));
            await Engine.sleep_until(async () => Engine.volume_test_objects(vol_leaving_rec_center, Engine.players()) == true || (short)Engine.ai_living_count(rec_center_heretics) == 0);
            Engine.device_set_position_immediate(elev_hangar.Entity, 0.25F);
            Engine.cs_run_command_script(allies_grunts_01.grunt02, abort);
            Engine.ai_vehicle_exit(allies_grunts_01.Squad);
            await Engine.sleep_until(async () => Engine.volume_test_objects(vol_leaving_rec_center, Engine.players()) == true);
            await Engine.sleep_until(async () => (short)Engine.ai_combat_status(all_enemies) < this.ai_combat_status_uninspected, 30, 150);
            this.stealth_talk_gone = true;
            Engine.ai_set_orders(arm01_allies, allies_rec_center_under);
            Engine.game_save();
            if ((short)Engine.ai_living_count(rec_center_heretics) < 8)
            {
                Engine.ai_place(rec_center_grunts_06.Squad, 4);
            }

            await Engine.sleep_until(async () => Engine.volume_test_objects(vol_hangar_lift_top, Engine.players()) == true || (short)Engine.ai_living_count(rec_center_heretics) < 3);
            Engine.game_save();
            if ((short)Engine.ai_living_count(rec_center_heretics) < 8)
            {
                Engine.ai_place(rec_center_heretic_06.Squad, 1);
            }

            if ((short)Engine.ai_living_count(rec_center_heretics) < 8)
            {
                Engine.ai_place(rec_center_grunts_07.Squad, 3);
            }

            Engine.device_set_position(elev_hangar.Entity, 0F);
            await Engine.sleep_until(async () => (short)Engine.ai_living_count(rec_center_heretics) < 1, 30, 1800);
            await Engine.sleep_until(async () => (bool)Engine.game_safe_to_save() == true);
            Engine.game_save();
            Engine.ai_set_orders(arm01_allies, get_on_hangar_elev);
            Engine.cs_run_command_script(hacker.Squad, get_on_e1);
            Engine.cs_run_command_script(allies_elites_01.Squad, get_on_e2);
            Engine.cs_run_command_script(allies_grunts_01.grunt01, get_on_g1);
            Engine.cs_run_command_script(allies_grunts_01.grunt02, get_on_g2);
        }

        [ScriptMethod(274, Lifecycle.Dormant)]
        public async Task hangar_extra_save()
        {
            await Engine.sleep_until(async () => Engine.device_get_position(elev_hangar.Entity) == 1F);
            await Engine.sleep_until(async () => (bool)Engine.game_safe_to_save());
            Engine.game_save();
        }

        [ScriptMethod(275, Lifecycle.Dormant)]
        public async Task hangar_can_spawner()
        {
            await Engine.sleep_until(async () => this.hangar_power_on == true);
            await Engine.sleep_until(async () =>
            {
                Engine.begin_random(async () =>
                {
                    if (Engine.list_count(Engine.volume_return_objects_by_type(vol_hangar_can_all, 2048)) < 15)
                    {
                        Engine.object_create_clone(hangar_can_a);
                    }
                }, 
                    async () => await Engine.sleep(this.recycling_time), 
                    async () =>
                {
                    if (Engine.list_count(Engine.volume_return_objects_by_type(vol_hangar_can_all, 2048)) < 15)
                    {
                        Engine.object_create_clone(hangar_can_b);
                    }
                }, 
                    async () => await Engine.sleep(this.recycling_time), 
                    async () =>
                {
                    if (Engine.list_count(Engine.volume_return_objects_by_type(vol_hangar_can_all, 2048)) < 15)
                    {
                        Engine.object_create_clone(hangar_can_c);
                    }
                }, 
                    async () => await Engine.sleep(this.recycling_time), 
                    async () =>
                {
                    if (Engine.list_count(Engine.volume_return_objects_by_type(vol_hangar_can_all, 2048)) < 15)
                    {
                        Engine.object_create_clone(hangar_can_d);
                    }
                }, 
                    async () => await Engine.sleep(this.recycling_time));
                return this.hangar_power_on == false;
            });
        }

        [ScriptMethod(276, Lifecycle.Dormant)]
        public async Task hangar_killer_new()
        {
            await Engine.sleep_until(async () => this.hangar_power_on == true);
            await Engine.sleep_until(async () =>
            {
                Engine.object_destroy(Engine.list_get(Engine.volume_return_objects(kill_hangar_pit_01), 0));
                await Engine.sleep(30);
                Engine.unit_kill_silent(Engine.unit(Engine.list_get(Engine.volume_return_objects_by_type(kill_hangar_pit_01, 1), 0)));
                await Engine.sleep(30);
                Engine.object_destroy(Engine.list_get(Engine.volume_return_objects(kill_hangar_pit_02), 0));
                await Engine.sleep(30);
                Engine.unit_kill_silent(Engine.unit(Engine.list_get(Engine.volume_return_objects_by_type(kill_hangar_pit_02, 1), 0)));
                await Engine.sleep(30);
                Engine.object_destroy(Engine.list_get(Engine.volume_return_objects(kill_hangar_pit_03), 0));
                await Engine.sleep(30);
                Engine.unit_kill_silent(Engine.unit(Engine.list_get(Engine.volume_return_objects_by_type(kill_hangar_pit_03, 1), 0)));
                await Engine.sleep(30);
                Engine.object_destroy(Engine.list_get(Engine.volume_return_objects(kill_hangar_pit_04), 0));
                await Engine.sleep(30);
                Engine.unit_kill_silent(Engine.unit(Engine.list_get(Engine.volume_return_objects_by_type(kill_hangar_pit_04, 1), 0)));
                await Engine.sleep(30);
                return this.hangar_power_on == false;
            });
        }

        [ScriptMethod(277, Lifecycle.CommandScript)]
        public async Task hangar_help_01()
        {
            Engine.cs_enable_pathfinding_failsafe(true);
            Engine.cs_vehicle_speed(0.5F);
            await Engine.sleep(120);
            Engine.objects_attach(Engine.list_get(Engine.ai_actors(hangar_helper_01.Squad), 0), "primary_trigger", help_can_01.Entity, "top");
            Engine.cs_fly_by(Engine.GetReference<ISpatialPoint>("hangar/p0"));
            Engine.cs_fly_by(Engine.GetReference<ISpatialPoint>("hangar/p9"));
            Engine.cs_fly_to(Engine.GetReference<ISpatialPoint>("hangar/p8"));
            Engine.objects_detach(Engine.list_get(Engine.ai_actors(hangar_helper_01.Squad), 0), help_can_01.Entity);
            Engine.object_destroy(help_can_01.Entity);
            Engine.ai_erase(hangar_helper_01.Squad);
        }

        [ScriptMethod(278, Lifecycle.CommandScript)]
        public async Task hangar_help_02()
        {
            Engine.cs_enable_pathfinding_failsafe(true);
            Engine.cs_vehicle_speed(0.5F);
            Engine.cs_fly_by(Engine.GetReference<ISpatialPoint>("hangar/p7"));
            Engine.cs_fly_to(Engine.GetReference<ISpatialPoint>("hangar/p10"));
            Engine.objects_attach(Engine.list_get(Engine.ai_actors(hangar_helper_02.Squad), 0), "primary_trigger", help_can_02.Entity, "top");
            Engine.cs_fly_by(Engine.GetReference<ISpatialPoint>("hangar/p0"));
            Engine.cs_fly_to(Engine.GetReference<ISpatialPoint>("hangar/p11"));
            Engine.objects_detach(Engine.list_get(Engine.ai_actors(hangar_helper_02.Squad), 0), help_can_02.Entity);
        }

        [ScriptMethod(279, Lifecycle.CommandScript)]
        public async Task hangar_help_03()
        {
            Engine.cs_enable_pathfinding_failsafe(true);
            Engine.cs_vehicle_speed(0.5F);
            await Engine.sleep_until(async () =>
            {
                Engine.begin_random(async () => Engine.cs_fly_to(Engine.GetReference<ISpatialPoint>("hangar/p3")), 
                    async () => Engine.cs_shoot_point(true, Engine.GetReference<ISpatialPoint>("hangar/weld1")), 
                    async () => await Engine.sleep(90), 
                    async () => Engine.cs_shoot_point(false, Engine.GetReference<ISpatialPoint>("hangar/weld1")), 
                    async () => Engine.cs_fly_to(Engine.GetReference<ISpatialPoint>("hangar/p4")), 
                    async () => Engine.cs_shoot_point(true, Engine.GetReference<ISpatialPoint>("hangar/weld2")), 
                    async () => await Engine.sleep(90), 
                    async () => Engine.cs_shoot_point(false, Engine.GetReference<ISpatialPoint>("hangar/weld2")), 
                    async () => Engine.cs_fly_to(Engine.GetReference<ISpatialPoint>("hangar/p5")), 
                    async () => Engine.cs_shoot_point(true, Engine.GetReference<ISpatialPoint>("hangar/weld3")), 
                    async () => await Engine.sleep(90), 
                    async () => Engine.cs_shoot_point(false, Engine.GetReference<ISpatialPoint>("hangar/weld3")), 
                    async () => Engine.cs_fly_to(Engine.GetReference<ISpatialPoint>("hangar/p6")), 
                    async () => Engine.cs_shoot_point(true, Engine.GetReference<ISpatialPoint>("hangar/weld4")), 
                    async () => await Engine.sleep(90), 
                    async () => Engine.cs_shoot_point(false, Engine.GetReference<ISpatialPoint>("hangar/weld4")));
                return false;
            });
        }

        [ScriptMethod(280, Lifecycle.CommandScript)]
        public async Task hangar_fly_out_l1()
        {
            Engine.cs_enable_pathfinding_failsafe(true);
            Engine.cs_vehicle_speed(0.5F);
            Engine.cs_fly_by(Engine.GetReference<ISpatialPoint>("hangar_too/l1_1"));
            Engine.cs_fly_to(Engine.GetReference<ISpatialPoint>("hangar_too/l1_0"));
        }

        [ScriptMethod(281, Lifecycle.CommandScript)]
        public async Task hangar_fly_out_l2()
        {
            Engine.cs_enable_pathfinding_failsafe(true);
            Engine.cs_vehicle_speed(0.5F);
            Engine.cs_fly_by(Engine.GetReference<ISpatialPoint>("hangar_too/l2_1"));
            Engine.cs_fly_to(Engine.GetReference<ISpatialPoint>("hangar_too/l2_0"));
        }

        [ScriptMethod(282, Lifecycle.CommandScript)]
        public async Task hangar_fly_out_r1()
        {
            Engine.cs_enable_pathfinding_failsafe(true);
            Engine.cs_vehicle_speed(0.5F);
            Engine.cs_fly_by(Engine.GetReference<ISpatialPoint>("hangar_too/r1_1"));
            Engine.cs_fly_to(Engine.GetReference<ISpatialPoint>("hangar_too/r1_0"));
        }

        [ScriptMethod(283, Lifecycle.CommandScript)]
        public async Task hangar_fly_out_r2()
        {
            Engine.cs_enable_pathfinding_failsafe(true);
            Engine.cs_vehicle_speed(0.5F);
            Engine.cs_fly_by(Engine.GetReference<ISpatialPoint>("hangar_too/r2_1"));
            Engine.cs_fly_to(Engine.GetReference<ISpatialPoint>("hangar_too/r2_0"));
        }

        [ScriptMethod(284, Lifecycle.CommandScript)]
        public async Task hangar_fly_out_c1()
        {
            Engine.cs_enable_pathfinding_failsafe(true);
            Engine.cs_vehicle_speed(0.5F);
            Engine.cs_fly_by(Engine.GetReference<ISpatialPoint>("hangar_too/c1_1"));
            Engine.cs_fly_to(Engine.GetReference<ISpatialPoint>("hangar_too/c1_0"));
        }

        [ScriptMethod(285, Lifecycle.CommandScript)]
        public async Task hangar_fly_out_c2()
        {
            Engine.cs_enable_pathfinding_failsafe(true);
            Engine.cs_vehicle_speed(0.5F);
            Engine.cs_fly_by(Engine.GetReference<ISpatialPoint>("hangar_too/c2_1"));
            Engine.cs_fly_to(Engine.GetReference<ISpatialPoint>("hangar_too/c2_0"));
        }

        [ScriptMethod(286, Lifecycle.CommandScript)]
        public async Task hangar_fly_l1()
        {
            Engine.cs_enable_pathfinding_failsafe(true);
            await Engine.sleep_until(async () => Engine.volume_test_objects(vol_hangar_center, this.ai_current_actor) == true);
            Engine.cs_vehicle_speed(0.5F);
            Engine.cs_fly_by(Engine.GetReference<ISpatialPoint>("hangar_too/l1_0"));
            Engine.cs_fly_by(Engine.GetReference<ISpatialPoint>("hangar_too/l1_1"));
            Engine.cs_fly_to(Engine.GetReference<ISpatialPoint>("hangar_too/l1_2"));
            Engine.ai_erase(this.ai_current_actor);
        }

        [ScriptMethod(287, Lifecycle.CommandScript)]
        public async Task hangar_fly_l2()
        {
            Engine.cs_enable_pathfinding_failsafe(true);
            await Engine.sleep_until(async () => Engine.volume_test_objects(vol_hangar_center, this.ai_current_actor) == true);
            Engine.cs_vehicle_speed(0.5F);
            Engine.cs_fly_by(Engine.GetReference<ISpatialPoint>("hangar_too/l2_0"));
            Engine.cs_fly_by(Engine.GetReference<ISpatialPoint>("hangar_too/l2_1"));
            Engine.cs_fly_to(Engine.GetReference<ISpatialPoint>("hangar_too/l2_2"));
            Engine.ai_erase(this.ai_current_actor);
        }

        [ScriptMethod(288, Lifecycle.CommandScript)]
        public async Task hangar_fly_r1()
        {
            Engine.cs_enable_pathfinding_failsafe(true);
            await Engine.sleep_until(async () => Engine.volume_test_objects(vol_hangar_center, this.ai_current_actor) == true);
            Engine.cs_vehicle_speed(0.5F);
            Engine.cs_fly_by(Engine.GetReference<ISpatialPoint>("hangar_too/r1_0"));
            Engine.cs_fly_by(Engine.GetReference<ISpatialPoint>("hangar_too/r1_1"));
            Engine.cs_fly_to(Engine.GetReference<ISpatialPoint>("hangar_too/r1_2"));
            Engine.ai_erase(this.ai_current_actor);
        }

        [ScriptMethod(289, Lifecycle.CommandScript)]
        public async Task hangar_fly_r2()
        {
            Engine.cs_enable_pathfinding_failsafe(true);
            await Engine.sleep_until(async () => Engine.volume_test_objects(vol_hangar_center, this.ai_current_actor) == true);
            Engine.cs_vehicle_speed(0.5F);
            Engine.cs_fly_by(Engine.GetReference<ISpatialPoint>("hangar_too/r2_0"));
            Engine.cs_fly_by(Engine.GetReference<ISpatialPoint>("hangar_too/r2_1"));
            Engine.cs_fly_to(Engine.GetReference<ISpatialPoint>("hangar_too/r2_2"));
            Engine.ai_erase(this.ai_current_actor);
        }

        [ScriptMethod(290, Lifecycle.CommandScript)]
        public async Task hangar_fly_c1()
        {
            Engine.cs_enable_pathfinding_failsafe(true);
            await Engine.sleep_until(async () => Engine.volume_test_objects(vol_hangar_center, this.ai_current_actor) == true);
            Engine.cs_vehicle_speed(0.5F);
            Engine.cs_fly_by(Engine.GetReference<ISpatialPoint>("hangar_too/c1_0"));
            Engine.cs_fly_by(Engine.GetReference<ISpatialPoint>("hangar_too/c1_1"));
            Engine.cs_fly_to(Engine.GetReference<ISpatialPoint>("hangar_too/c1_2"));
            Engine.ai_erase(this.ai_current_actor);
        }

        [ScriptMethod(291, Lifecycle.CommandScript)]
        public async Task hangar_fly_c2()
        {
            Engine.cs_enable_pathfinding_failsafe(true);
            await Engine.sleep_until(async () => Engine.volume_test_objects(vol_hangar_center, this.ai_current_actor) == true);
            Engine.cs_vehicle_speed(0.5F);
            Engine.cs_fly_by(Engine.GetReference<ISpatialPoint>("hangar_too/c2_0"));
            Engine.cs_fly_by(Engine.GetReference<ISpatialPoint>("hangar_too/c2_1"));
            Engine.cs_fly_to(Engine.GetReference<ISpatialPoint>("hangar_too/c2_2"));
            Engine.ai_erase(this.ai_current_actor);
        }

        [ScriptMethod(292, Lifecycle.Dormant)]
        public async Task hangar_sentinels_flitting()
        {
            await Engine.sleep_until(async () =>
            {
                Engine.begin_random(async () =>
                {
                    if ((short)Engine.ai_living_count(hangar_sentinels_flit.Squad) < 1)
                    {
                        Engine.ai_place(hangar_sentinels_flit.l1);
                        Engine.cs_run_command_script(hangar_sentinels_flit.l1, hangar_fly_out_l1);
                        this.hangar_sentinel_var = true;
                        Engine.begin_random(async () =>
                        {
                            if (this.hangar_sentinel_var == true)
                            {
                                Engine.cs_queue_command_script(hangar_sentinels_flit.l1, hangar_fly_l2);
                                this.hangar_sentinel_var = false;
                            }
                        }, 
                            async () =>
                        {
                            if (this.hangar_sentinel_var == true)
                            {
                                Engine.cs_queue_command_script(hangar_sentinels_flit.l1, hangar_fly_r1);
                                this.hangar_sentinel_var = false;
                            }
                        }, 
                            async () =>
                        {
                            if (this.hangar_sentinel_var == true)
                            {
                                Engine.cs_queue_command_script(hangar_sentinels_flit.l1, hangar_fly_r2);
                                this.hangar_sentinel_var = false;
                            }
                        });
                    }
                }, 
                    async () =>
                {
                    if ((short)Engine.ai_living_count(hangar_sentinels_flit.Squad) < 1)
                    {
                        Engine.ai_place(hangar_sentinels_flit.l2);
                        Engine.cs_run_command_script(hangar_sentinels_flit.l2, hangar_fly_out_l2);
                        this.hangar_sentinel_var = true;
                        Engine.begin_random(async () =>
                        {
                            if (this.hangar_sentinel_var == true)
                            {
                                Engine.cs_queue_command_script(hangar_sentinels_flit.l2, hangar_fly_l1);
                                this.hangar_sentinel_var = false;
                            }
                        }, 
                            async () =>
                        {
                            if (this.hangar_sentinel_var == true)
                            {
                                Engine.cs_queue_command_script(hangar_sentinels_flit.l2, hangar_fly_r1);
                                this.hangar_sentinel_var = false;
                            }
                        }, 
                            async () =>
                        {
                            if (this.hangar_sentinel_var == true)
                            {
                                Engine.cs_queue_command_script(hangar_sentinels_flit.l2, hangar_fly_r2);
                                this.hangar_sentinel_var = false;
                            }
                        });
                    }
                }, 
                    async () =>
                {
                    if ((short)Engine.ai_living_count(hangar_sentinels_flit.Squad) < 1)
                    {
                        Engine.ai_place(hangar_sentinels_flit.r1);
                        Engine.cs_run_command_script(hangar_sentinels_flit.r1, hangar_fly_out_r1);
                        this.hangar_sentinel_var = true;
                        Engine.begin_random(async () =>
                        {
                            if (this.hangar_sentinel_var == true)
                            {
                                Engine.cs_queue_command_script(hangar_sentinels_flit.r1, hangar_fly_l1);
                                this.hangar_sentinel_var = false;
                            }
                        }, 
                            async () =>
                        {
                            if (this.hangar_sentinel_var == true)
                            {
                                Engine.cs_queue_command_script(hangar_sentinels_flit.r1, hangar_fly_l2);
                                this.hangar_sentinel_var = false;
                            }
                        }, 
                            async () =>
                        {
                            if (this.hangar_sentinel_var == true)
                            {
                                Engine.cs_queue_command_script(hangar_sentinels_flit.r1, hangar_fly_r2);
                                this.hangar_sentinel_var = false;
                            }
                        });
                    }
                }, 
                    async () =>
                {
                    if ((short)Engine.ai_living_count(hangar_sentinels_flit.Squad) < 1)
                    {
                        Engine.ai_place(hangar_sentinels_flit.r2);
                        Engine.cs_run_command_script(hangar_sentinels_flit.r2, hangar_fly_out_r2);
                        this.hangar_sentinel_var = true;
                        Engine.begin_random(async () =>
                        {
                            if (this.hangar_sentinel_var == true)
                            {
                                Engine.cs_queue_command_script(hangar_sentinels_flit.r2, hangar_fly_l1);
                                this.hangar_sentinel_var = false;
                            }
                        }, 
                            async () =>
                        {
                            if (this.hangar_sentinel_var == true)
                            {
                                Engine.cs_queue_command_script(hangar_sentinels_flit.r2, hangar_fly_l2);
                                this.hangar_sentinel_var = false;
                            }
                        }, 
                            async () =>
                        {
                            if (this.hangar_sentinel_var == true)
                            {
                                Engine.cs_queue_command_script(hangar_sentinels_flit.r2, hangar_fly_r1);
                                this.hangar_sentinel_var = false;
                            }
                        });
                    }
                }, 
                    async () =>
                {
                    if ((short)Engine.ai_living_count(hangar_sentinels_flit.Squad) < 1)
                    {
                        Engine.ai_place(hangar_sentinels_flit.c1);
                        Engine.cs_run_command_script(hangar_sentinels_flit.c1, hangar_fly_out_c1);
                        this.hangar_sentinel_var = true;
                        Engine.begin_random(async () =>
                        {
                            if (this.hangar_sentinel_var == true)
                            {
                                Engine.cs_queue_command_script(hangar_sentinels_flit.c1, hangar_fly_l1);
                                this.hangar_sentinel_var = false;
                            }
                        }, 
                            async () =>
                        {
                            if (this.hangar_sentinel_var == true)
                            {
                                Engine.cs_queue_command_script(hangar_sentinels_flit.c1, hangar_fly_r1);
                                this.hangar_sentinel_var = false;
                            }
                        });
                    }
                });
                return (short)Engine.ai_combat_status(hangar_heretics) >= this.ai_combat_status_uninspected;
            });
        }

        [ScriptMethod(293, Lifecycle.CommandScript)]
        public async Task hangar_sentinel_comment()
        {
            Engine.cs_switch("elev_elite");
            Engine.cs_abort_on_damage(true);
            Engine.cs_suppress_dialogue_global(true);
            Engine.print("spec-ops elite: 'sentinels! the holy warriors of the sacred rings!'");
            Engine.cs_aim(true, Engine.GetReference<ISpatialPoint>("hangar_too/p0"));
            Engine.cs_play_line("0360");
            await Engine.sleep(30);
            Engine.print("'why have they sided with these heretics?'");
            Engine.cs_play_line("0370");
            Engine.cs_aim(false, Engine.GetReference<ISpatialPoint>("hangar_too/p0"));
        }

        [ScriptMethod(294, Lifecycle.Dormant)]
        public async Task hangar_helpers()
        {
            Engine.ai_place(hangar_helper_01.Squad);
            Engine.cs_run_command_script(hangar_helper_01.Squad, forever_pause);
            Engine.ai_place(hangar_helper_03.Squad);
            Engine.cs_run_command_script(hangar_helper_03.Squad, forever_pause);
            await Engine.sleep_until(async () => Engine.volume_test_objects(vol_trigger_helpers, Engine.players()) == true);
            Engine.cs_run_command_script(hangar_helper_03.Squad, hangar_help_03);
            Engine.cs_run_command_script(hangar_helper_01.Squad, hangar_help_01);
            Engine.ai_place(hangar_helper_02.Squad);
            Engine.cs_run_command_script(hangar_helper_02.Squad, hangar_help_02);
            Engine.cs_queue_command_script(hangar_helper_02.Squad, hangar_help_03);
            await Engine.sleep(90);
            Engine.ai_scene("sentinel_react_scene", hangar_sentinel_comment, arm01_allies) // Couldn't generate cast from 'Boolean' to 'Void'
            ;
            await Engine.sleep_until(async () => (short)Engine.ai_combat_status(hangar_heretics) > this.ai_combat_status_uninspected);
            Engine.unit_add_equipment(Engine.unit(Engine.list_get(Engine.ai_actors(hangar_helper_01.Squad), 0)), swap, true, true);
            Engine.unit_add_equipment(Engine.unit(Engine.list_get(Engine.ai_actors(hangar_helper_02.Squad), 0)), swap, true, true);
            Engine.unit_add_equipment(Engine.unit(Engine.list_get(Engine.ai_actors(hangar_helper_03.Squad), 0)), swap, true, true);
            Engine.objects_detach(Engine.list_get(Engine.ai_actors(hangar_helper_01.Squad), 0), help_can_01.Entity);
            Engine.objects_detach(Engine.list_get(Engine.ai_actors(hangar_helper_02.Squad), 0), help_can_02.Entity);
            Engine.cs_run_command_script(hangar_helper_01.Squad, abort);
            Engine.cs_run_command_script(hangar_helper_02.Squad, abort);
            Engine.cs_run_command_script(hangar_helper_03.Squad, abort);
            Engine.cs_queue_command_script(hangar_sentinels_flit.Squad, abort);
        }

        [ScriptMethod(295, Lifecycle.CommandScript)]
        public async Task hangar_phantom_arrives()
        {
            Engine.cs_enable_pathfinding_failsafe(true);
            Engine.cs_vehicle_speed(0.5F);
            Engine.cs_fly_by(Engine.GetReference<ISpatialPoint>("airspace_hangar/hangar_ph0"), 3F);
            Engine.cs_fly_by(Engine.GetReference<ISpatialPoint>("airspace_hangar/hangar_ph1"), 3F);
            Engine.cs_vehicle_speed(0.25F);
            Engine.cs_fly_to(Engine.GetReference<ISpatialPoint>("airspace_hangar/hangar_ph2"), 1F);
            Engine.ai_place(reinforce_elites_01.Squad, (short)Engine.max(1F, 2F - (float)Engine.ai_living_count(allies_elites)));
            Engine.ai_place(reinforce_grunts_01.Squad, (short)(2 - (float)Engine.ai_living_count(allies_grunts)));
            Engine.vehicle_load_magic(Engine.ai_vehicle_get_from_starting_location(hangar_phantom.pilot), "phantom_p", Engine.ai_actors(reinforce_elites_01.Squad));
            Engine.vehicle_load_magic(Engine.ai_vehicle_get_from_starting_location(hangar_phantom.pilot), "phantom_p", Engine.ai_actors(reinforce_grunts_01.Squad));
            await Engine.sleep(15);
            Engine.vehicle_unload(Engine.ai_vehicle_get_from_starting_location(hangar_phantom.pilot), "phantom_p_a01");
            await Engine.sleep(15);
            Engine.vehicle_unload(Engine.ai_vehicle_get_from_starting_location(hangar_phantom.pilot), "phantom_p_a02");
            await Engine.sleep(15);
            Engine.vehicle_unload(Engine.ai_vehicle_get_from_starting_location(hangar_phantom.pilot), "phantom_p_a03");
            await Engine.sleep(15);
            Engine.vehicle_unload(Engine.ai_vehicle_get_from_starting_location(hangar_phantom.pilot), "phantom_p_b01");
            await Engine.sleep(15);
            Engine.vehicle_unload(Engine.ai_vehicle_get_from_starting_location(hangar_phantom.pilot), "phantom_p_b02");
            await Engine.sleep(15);
            Engine.vehicle_unload(Engine.ai_vehicle_get_from_starting_location(hangar_phantom.pilot), "phantom_p_b03");
            await Engine.sleep(15);
            Engine.vehicle_unload(Engine.ai_vehicle_get_from_starting_location(hangar_phantom.pilot), "phantom_p_c01");
            await Engine.sleep(15);
            Engine.vehicle_unload(Engine.ai_vehicle_get_from_starting_location(hangar_phantom.pilot), "phantom_p_c02");
            await Engine.sleep(15);
            Engine.vehicle_unload(Engine.ai_vehicle_get_from_starting_location(hangar_phantom.pilot), "phantom_p_c03");
            await Engine.sleep_until(async () => (short)Engine.ai_living_count(hangar_phantom.Squad) < 2, 30, 900);
            this.hangar_phantom_cue = true;
            await Engine.sleep_until(async () => this.heavies_spawned > 0);
            await Engine.sleep_until(async () => (short)Engine.ai_combat_status(hangar_heretic_heavies_L.Squad) >= this.ai_combat_status_clear_los || (short)Engine.ai_combat_status(hangar_heretic_heavies_R.Squad) >= this.ai_combat_status_clear_los, 30, 300);
            Engine.wake(new ScriptMethodReference(music_04a_01_stop));
            Engine.cs_fly_to_and_face(Engine.GetReference<ISpatialPoint>("airspace_hangar/hangar_ph1"), Engine.GetReference<ISpatialPoint>("airspace_hangar/hangar_ph2"), 2F);
            Engine.cs_vehicle_speed(1F);
            Engine.cs_fly_by(Engine.GetReference<ISpatialPoint>("airspace_hangar/hangar_ph0"), 5F);
            Engine.cs_fly_to(Engine.GetReference<ISpatialPoint>("airspace_hangar/hangar_phx"), 5F);
            Engine.ai_erase(hangar_phantom.Squad);
        }

        [ScriptMethod(296, Lifecycle.Dormant)]
        public async Task hangar_allies_reinforce()
        {
            await Engine.sleep_until(async () =>
            {
                if (Engine.objects_distance_to_object(Engine.players(), Engine.list_get(Engine.ai_actors(all_allies), 3)) > 50F && Engine.objects_can_see_object(Engine.players(), Engine.list_get(Engine.ai_actors(all_allies), 3), 45F) == false)
                {
                    Engine.object_destroy(Engine.list_get(Engine.ai_actors(all_allies), 3));
                }

                if (Engine.objects_distance_to_object(Engine.players(), Engine.list_get(Engine.ai_actors(all_allies), 2)) > 50F && Engine.objects_can_see_object(Engine.players(), Engine.list_get(Engine.ai_actors(all_allies), 2), 45F) == false)
                {
                    Engine.object_destroy(Engine.list_get(Engine.ai_actors(all_allies), 2));
                }

                if (Engine.objects_distance_to_object(Engine.players(), Engine.list_get(Engine.ai_actors(all_allies), 1)) > 50F && Engine.objects_can_see_object(Engine.players(), Engine.list_get(Engine.ai_actors(all_allies), 1), 45F) == false)
                {
                    Engine.object_destroy(Engine.list_get(Engine.ai_actors(all_allies), 1));
                }

                if (Engine.objects_distance_to_object(Engine.players(), Engine.list_get(Engine.ai_actors(all_allies), 0)) > 50F && Engine.objects_can_see_object(Engine.players(), Engine.list_get(Engine.ai_actors(all_allies), 0), 45F) == false)
                {
                    Engine.object_destroy(Engine.list_get(Engine.ai_actors(all_allies), 0));
                }

                return false;
            }, 30, 150);
            Engine.ai_place(hangar_phantom.Squad);
            Engine.cs_run_command_script(hangar_phantom.Squad, hangar_phantom_arrives);
            await Engine.sleep(60);
            await Engine.sleep_until(async () => (short)Engine.ai_living_count(hangar_phantom.Squad) > 1);
            await Engine.sleep_until(async () => (short)Engine.ai_living_count(hangar_phantom.Squad) < 2);
            Engine.ai_set_orders(reinforce_elites_01.Squad, allies_hangar_bottom);
            Engine.ai_set_orders(reinforce_grunts_01.Squad, allies_hangar_bottom);
        }

        [ScriptMethod(297, Lifecycle.Static)]
        public async Task short_hangar_allies()
        {
            await Engine.sleep_until(async () =>
            {
                if (Engine.objects_distance_to_object(Engine.players(), Engine.list_get(Engine.ai_actors(all_allies), 2)) > 50F && Engine.objects_can_see_object(Engine.players(), Engine.list_get(Engine.ai_actors(all_allies), 2), 45F) == false)
                {
                    Engine.object_destroy(Engine.list_get(Engine.ai_actors(all_allies), 2));
                }

                if (Engine.objects_distance_to_object(Engine.players(), Engine.list_get(Engine.ai_actors(all_allies), 1)) > 50F && Engine.objects_can_see_object(Engine.players(), Engine.list_get(Engine.ai_actors(all_allies), 1), 45F) == false)
                {
                    Engine.object_destroy(Engine.list_get(Engine.ai_actors(all_allies), 1));
                }

                if (Engine.objects_distance_to_object(Engine.players(), Engine.list_get(Engine.ai_actors(all_allies), 0)) > 50F && Engine.objects_can_see_object(Engine.players(), Engine.list_get(Engine.ai_actors(all_allies), 0), 45F) == false)
                {
                    Engine.object_destroy(Engine.list_get(Engine.ai_actors(all_allies), 0));
                }

                return false;
            }, 30, 150);
            Engine.ai_place(hangar_phantom.Squad);
            Engine.cs_run_command_script(hangar_phantom.Squad, hangar_phantom_arrives);
            await Engine.sleep(60);
            Engine.ai_place(reinforce_elites_01.Squad, (short)(2 - (float)Engine.ai_living_count(allies_elites)));
            Engine.ai_place(reinforce_grunts_01.Squad, (short)(2 - (float)Engine.ai_living_count(allies_grunts)));
            Engine.vehicle_load_magic(Engine.ai_vehicle_get_from_starting_location(hangar_phantom.pilot), "phantom_p", Engine.ai_actors(reinforce_elites_01.Squad));
            Engine.vehicle_load_magic(Engine.ai_vehicle_get_from_starting_location(hangar_phantom.pilot), "phantom_p", Engine.ai_actors(reinforce_grunts_01.Squad));
            await Engine.sleep_until(async () => (short)Engine.ai_living_count(hangar_phantom.Squad) < 2);
            Engine.ai_set_orders(reinforce_elites_01.Squad, allies_hangar_bottom);
            Engine.ai_set_orders(reinforce_grunts_01.Squad, allies_hangar_bottom);
        }

        [ScriptMethod(298, Lifecycle.Dormant)]
        public async Task hangar_door_monitor()
        {
            await Engine.sleep_until(async () => Engine.device_get_position(hangar_door_cinematic.Entity) > 0F);
            Engine.wake(new ScriptMethodReference(hangar_allies_reinforce));
            Engine.ai_dialogue_enable(false);
            await Engine.sleep(60);
            Engine.print("phantom pilot: 'hold position! i am making my approach!'");
            await Engine.sleep(Engine.ai_play_line_on_object(default(IGameObject), "2030"));
            await Engine.sleep(30);
            Engine.ai_dialogue_enable(true);
        }

        [ScriptMethod(299, Lifecycle.Dormant)]
        public async Task hangar_objective()
        {
            Engine.ai_dialogue_enable(false);
            await Engine.sleep(60);
            Engine.print("phantom pilot: 'arbiter! clear the hangar, and open its door so i may drop the second lance!'");
            await Engine.sleep(Engine.ai_play_line_on_object(default(IGameObject), "2000"));
            await Engine.sleep(30);
            Engine.ai_dialogue_enable(true);
        }

        [ScriptMethod(300, Lifecycle.Dormant)]
        public async Task hangar_door_reminder()
        {
            await Engine.sleep_until(async () => Engine.device_get_position(hangar_door_cinematic.Entity) > 0F, 30, 4000);
            if (Engine.device_get_position(hangar_door_cinematic.Entity) <= 0F)
            {
                Engine.ai_dialogue_enable(false);
                await Engine.sleep(60);
                Engine.print("phantom pilot: 'find the controls to the hangar-doors, arbiter!'");
                await Engine.sleep(Engine.ai_play_line_on_object(default(IGameObject), "2010"));
                await Engine.sleep(30);
                Engine.ai_dialogue_enable(true);
            }

            await Engine.sleep_until(async () => Engine.device_get_position(hangar_door_cinematic.Entity) > 0F, 30, 2000);
            if (Engine.device_get_position(hangar_door_cinematic.Entity) <= 0F)
            {
                Engine.ai_dialogue_enable(false);
                await Engine.sleep(60);
                Engine.print("phantom pilot: 'the hangar-doors, arbiter! open them, and i will land your reinforcements!'");
                await Engine.sleep(Engine.ai_play_line_on_object(default(IGameObject), "2020"));
                await Engine.sleep(30);
                Engine.ai_dialogue_enable(true);
                if (Engine.volume_test_objects(vol_hangar_left, Engine.players()) == true)
                {
                    Engine.activate_team_nav_point_object(_default, player, hangar_door_switch_l.Entity, 0F);
                    await Engine.sleep_until(async () => Engine.device_get_position(hangar_door_cinematic.Entity) > 0F);
                    Engine.deactivate_team_nav_point_object(player, hangar_door_switch_l.Entity);
                }
                else
                {
                    Engine.activate_team_nav_point_object(_default, player, hangar_door_switch_r.Entity, 0F);
                    await Engine.sleep_until(async () => Engine.device_get_position(hangar_door_cinematic.Entity) > 0F);
                    Engine.deactivate_team_nav_point_object(player, hangar_door_switch_r.Entity);
                }
            }
        }

        [ScriptMethod(301, Lifecycle.CommandScript)]
        public async Task hangar_sentinel_call()
        {
            Engine.cs_switch("heretic");
            Engine.cs_suppress_dialogue_global(true);
            Engine.print("heretic: 'sentinels! defend us!'");
            Engine.cs_play_line("0380");
        }

        [ScriptMethod(302, Lifecycle.Dormant)]
        public async Task hangar_alerted_call()
        {
            await Engine.sleep_until(async () => (short)Engine.ai_combat_status(hangar_heretics) > this.ai_combat_status_uninspected);
            Engine.ai_scene("hangar_s_call_scene", hangar_sentinel_call, hangar_heretics) // Couldn't generate cast from 'Boolean' to 'Void'
            ;
        }

        [ScriptMethod(303, Lifecycle.Static)]
        public async Task sentinel_swarm_spawning()
        {
            this.hangar_sentinels_come = true;
            await Engine.sleep_until(async () =>
            {
                if ((short)Engine.ai_living_count(hangar_sentinels) < 3)
                {
                    Engine.ai_place(hangar_sentinel_swarm.Squad, 1);
                }

                await Engine.sleep((short)Engine.random_range(10, 30));
                return (short)Engine.ai_spawn_count(hangar_sentinel_swarm.Squad) > 4;
            });
        }

        [ScriptMethod(304, Lifecycle.Static)]
        public async Task heretic_heavy_spawning()
        {
            Engine.begin_random(async () =>
            {
                if (Engine.volume_test_objects(vol_hangar_spawn_02r, Engine.players()) == false && await this.player_count() > 0 && Engine.device_get_position(hang_02r.Entity) == 0F && this.heavies_spawned < 3)
                {
                    Engine.print("heavy_02r_a");
                    Engine.ai_place(hangar_heretic_heavies_R._02a);
                    Engine.cs_run_command_script(hangar_heretic_heavies_R.Squad, snap_alert);
                    this.heavies_spawned = (short)(this.heavies_spawned + 1);
                }
            }, 
                async () =>
            {
                if (Engine.volume_test_objects(vol_hangar_spawn_02r, Engine.players()) == false && await this.player_count() > 0 && Engine.device_get_position(hang_02r.Entity) == 0F && this.heavies_spawned < 3)
                {
                    Engine.print("heavy_02r_b");
                    Engine.ai_place(hangar_heretic_heavies_R._02b);
                    Engine.cs_run_command_script(hangar_heretic_heavies_R.Squad, snap_alert);
                    this.heavies_spawned = (short)(this.heavies_spawned + 1);
                }
            }, 
                async () =>
            {
                if (Engine.volume_test_objects(vol_hangar_spawn_03r, Engine.players()) == false && await this.player_count() > 0 && Engine.device_get_position(hang_03r.Entity) == 0F && this.heavies_spawned < 3)
                {
                    Engine.print("heavy_03r_a");
                    Engine.ai_place(hangar_heretic_heavies_R._03a);
                    Engine.cs_run_command_script(hangar_heretic_heavies_R.Squad, snap_alert);
                    this.heavies_spawned = (short)(this.heavies_spawned + 1);
                }
            }, 
                async () =>
            {
                if (Engine.volume_test_objects(vol_hangar_spawn_03r, Engine.players()) == false && await this.player_count() > 0 && Engine.device_get_position(hang_03r.Entity) == 0F && this.heavies_spawned < 3)
                {
                    Engine.print("heavy_03r_b");
                    Engine.ai_place(hangar_heretic_heavies_R._03b);
                    Engine.cs_run_command_script(hangar_heretic_heavies_R.Squad, snap_alert);
                    this.heavies_spawned = (short)(this.heavies_spawned + 1);
                }
            }, 
                async () =>
            {
                if (Engine.volume_test_objects(vol_hangar_spawn_02l, Engine.players()) == false && await this.player_count() > 0 && Engine.device_get_position(hang_02l.Entity) == 0F && this.heavies_spawned < 3)
                {
                    Engine.print("heavy_02l_a");
                    Engine.ai_place(hangar_heretic_heavies_L._02a);
                    Engine.cs_run_command_script(hangar_heretic_heavies_L.Squad, snap_alert);
                    this.heavies_spawned = (short)(this.heavies_spawned + 1);
                }
            }, 
                async () =>
            {
                if (Engine.volume_test_objects(vol_hangar_spawn_02l, Engine.players()) == false && await this.player_count() > 0 && Engine.device_get_position(hang_02l.Entity) == 0F && this.heavies_spawned < 3)
                {
                    Engine.print("heavy_02l_b");
                    Engine.ai_place(hangar_heretic_heavies_L._02b);
                    Engine.cs_run_command_script(hangar_heretic_heavies_L.Squad, snap_alert);
                    this.heavies_spawned = (short)(this.heavies_spawned + 1);
                }
            }, 
                async () =>
            {
                if (Engine.volume_test_objects(vol_hangar_spawn_03l, Engine.players()) == false && await this.player_count() > 0 && Engine.device_get_position(hang_03l.Entity) == 0F && this.heavies_spawned < 3)
                {
                    Engine.print("heavy_03l_a");
                    Engine.ai_place(hangar_heretic_heavies_L._03a);
                    Engine.cs_run_command_script(hangar_heretic_heavies_L.Squad, snap_alert);
                    this.heavies_spawned = (short)(this.heavies_spawned + 1);
                }
            }, 
                async () =>
            {
                if (Engine.volume_test_objects(vol_hangar_spawn_03l, Engine.players()) == false && await this.player_count() > 0 && Engine.device_get_position(hang_03l.Entity) == 0F && this.heavies_spawned < 3)
                {
                    Engine.print("heavy_03l_b");
                    Engine.ai_place(hangar_heretic_heavies_L._03b);
                    Engine.cs_run_command_script(hangar_heretic_heavies_L.Squad, snap_alert);
                    this.heavies_spawned = (short)(this.heavies_spawned + 1);
                }
            });
        }

        [ScriptMethod(305, Lifecycle.Static)]
        public async Task hangar_a50_clone()
        {
            Engine.begin_random(async () =>
            {
                if (Engine.volume_test_objects(vol_hangar_spawn_02r, Engine.players()) == false && await this.player_count() > 0 && Engine.device_get_position(hang_02r.Entity) == 0F)
                {
                    Engine.ai_place(hangar_a50_02r_high.Squad, (short)((float)Engine.random_range(0, 3) - (float)Engine.ai_living_count(a50_high)));
                    Engine.cs_run_command_script(hangar_a50_02r_high.Squad, snap_alert);
                }
            }, 
                async () =>
            {
                if (Engine.volume_test_objects(vol_hangar_spawn_02r, Engine.players()) == false && await this.player_count() > 0 && Engine.device_get_position(hang_02r.Entity) == 0F)
                {
                    Engine.ai_place(hangar_a50_02r_low.Squad, (short)((float)Engine.random_range(0, 3) - (float)Engine.ai_living_count(a50_low)));
                    Engine.cs_run_command_script(hangar_a50_02r_low.Squad, snap_alert);
                }
            }, 
                async () =>
            {
                if (Engine.volume_test_objects(vol_hangar_spawn_03r, Engine.players()) == false && await this.player_count() > 0 && Engine.device_get_position(hang_03r.Entity) == 0F)
                {
                    Engine.ai_place(hangar_a50_03r_high.Squad, (short)((float)Engine.random_range(0, 3) - (float)Engine.ai_living_count(a50_high)));
                    Engine.cs_run_command_script(hangar_a50_03r_high.Squad, snap_alert);
                }
            }, 
                async () =>
            {
                if (Engine.volume_test_objects(vol_hangar_spawn_03r, Engine.players()) == false && await this.player_count() > 0 && Engine.device_get_position(hang_03r.Entity) == 0F)
                {
                    Engine.ai_place(hangar_a50_03r_low.Squad, (short)((float)Engine.random_range(0, 3) - (float)Engine.ai_living_count(a50_low)));
                    Engine.cs_run_command_script(hangar_a50_03r_low.Squad, snap_alert);
                }
            }, 
                async () =>
            {
                if (Engine.volume_test_objects(vol_hangar_spawn_02l, Engine.players()) == false && await this.player_count() > 0 && Engine.device_get_position(hang_02l.Entity) == 0F)
                {
                    Engine.ai_place(hangar_a50_02l_high.Squad, (short)((float)Engine.random_range(0, 3) - (float)Engine.ai_living_count(a50_high)));
                    Engine.cs_run_command_script(hangar_a50_02l_high.Squad, snap_alert);
                }
            }, 
                async () =>
            {
                if (Engine.volume_test_objects(vol_hangar_spawn_02l, Engine.players()) == false && await this.player_count() > 0 && Engine.device_get_position(hang_02l.Entity) == 0F)
                {
                    Engine.ai_place(hangar_a50_02l_low.Squad, (short)((float)Engine.random_range(0, 3) - (float)Engine.ai_living_count(a50_low)));
                    Engine.cs_run_command_script(hangar_a50_02l_low.Squad, snap_alert);
                }
            }, 
                async () =>
            {
                if (Engine.volume_test_objects(vol_hangar_spawn_03l, Engine.players()) == false && await this.player_count() > 0 && Engine.device_get_position(hang_03l.Entity) == 0F)
                {
                    Engine.ai_place(hangar_a50_03l_high.Squad, (short)((float)Engine.random_range(0, 3) - (float)Engine.ai_living_count(a50_high)));
                    Engine.cs_run_command_script(hangar_a50_03l_high.Squad, snap_alert);
                }
            }, 
                async () =>
            {
                if (Engine.volume_test_objects(vol_hangar_spawn_03l, Engine.players()) == false && await this.player_count() > 0 && Engine.device_get_position(hang_03l.Entity) == 0F)
                {
                    Engine.ai_place(hangar_a50_03l_low.Squad, (short)((float)Engine.random_range(0, 3) - (float)Engine.ai_living_count(a50_low)));
                    Engine.cs_run_command_script(hangar_a50_03l_low.Squad, snap_alert);
                }
            });
            await Engine.sleep_until(async () => (short)Engine.ai_living_count(hangar_heretics) < 3, 30, 8000);
            await Engine.sleep_until(async () => (short)Engine.ai_living_count(hangar_heretics) < 1, 30, 1800);
            await Engine.sleep(150);
            Engine.game_save();
            Engine.begin_random(async () =>
            {
                if (Engine.volume_test_objects(vol_hangar_spawn_02r, Engine.players()) == false && await this.player_count() > 0 && Engine.device_get_position(hang_02r.Entity) == 0F)
                {
                    Engine.ai_place(hangar_a50_02r_high.Squad, (short)((float)Engine.random_range(0, 2) - (float)Engine.ai_living_count(a50_high)));
                    Engine.cs_run_command_script(hangar_a50_02r_high.Squad, snap_alert);
                }
            }, 
                async () =>
            {
                if (Engine.volume_test_objects(vol_hangar_spawn_02r, Engine.players()) == false && await this.player_count() > 0 && Engine.device_get_position(hang_02r.Entity) == 0F)
                {
                    Engine.ai_place(hangar_a50_02r_low.Squad, (short)((float)Engine.random_range(0, 4) - (float)Engine.ai_living_count(a50_low)));
                    Engine.cs_run_command_script(hangar_a50_02r_low.Squad, snap_alert);
                }
            }, 
                async () =>
            {
                if (Engine.volume_test_objects(vol_hangar_spawn_01r, Engine.players()) == false && await this.player_count() > 0 && Engine.device_get_position(hang_01r.Entity) == 0F)
                {
                    Engine.ai_place(hangar_a50_01r_high.Squad, (short)((float)Engine.random_range(0, 2) - (float)Engine.ai_living_count(a50_high)));
                    Engine.cs_run_command_script(hangar_a50_01r_high.Squad, snap_alert);
                }
            }, 
                async () =>
            {
                if (Engine.volume_test_objects(vol_hangar_spawn_01r, Engine.players()) == false && await this.player_count() > 0 && Engine.device_get_position(hang_01r.Entity) == 0F)
                {
                    Engine.ai_place(hangar_a50_01r_low.Squad, (short)((float)Engine.random_range(0, 4) - (float)Engine.ai_living_count(a50_low)));
                    Engine.cs_run_command_script(hangar_a50_01r_low.Squad, snap_alert);
                }
            }, 
                async () =>
            {
                if (Engine.volume_test_objects(vol_hangar_spawn_02l, Engine.players()) == false && await this.player_count() > 0 && Engine.device_get_position(hang_02l.Entity) == 0F)
                {
                    Engine.ai_place(hangar_a50_02l_high.Squad, (short)((float)Engine.random_range(0, 2) - (float)Engine.ai_living_count(a50_high)));
                    Engine.cs_run_command_script(hangar_a50_02l_high.Squad, snap_alert);
                }
            }, 
                async () =>
            {
                if (Engine.volume_test_objects(vol_hangar_spawn_02l, Engine.players()) == false && await this.player_count() > 0 && Engine.device_get_position(hang_02l.Entity) == 0F)
                {
                    Engine.ai_place(hangar_a50_02l_low.Squad, (short)((float)Engine.random_range(0, 4) - (float)Engine.ai_living_count(a50_low)));
                    Engine.cs_run_command_script(hangar_a50_02l_low.Squad, snap_alert);
                }
            }, 
                async () =>
            {
                if (Engine.volume_test_objects(vol_hangar_spawn_01l, Engine.players()) == false && await this.player_count() > 0 && Engine.device_get_position(hang_01l.Entity) == 0F)
                {
                    Engine.ai_place(hangar_a50_01l_high.Squad, (short)((float)Engine.random_range(0, 2) - (float)Engine.ai_living_count(a50_high)));
                    Engine.cs_run_command_script(hangar_a50_01l_high.Squad, snap_alert);
                }
            }, 
                async () =>
            {
                if (Engine.volume_test_objects(vol_hangar_spawn_01l, Engine.players()) == false && await this.player_count() > 0 && Engine.device_get_position(hang_01l.Entity) == 0F)
                {
                    Engine.ai_place(hangar_a50_01l_low.Squad, (short)((float)Engine.random_range(0, 4) - (float)Engine.ai_living_count(a50_low)));
                    Engine.cs_run_command_script(hangar_a50_01l_low.Squad, snap_alert);
                }
            });
        }

        [ScriptMethod(306, Lifecycle.CommandScript)]
        public async Task hangar_exit_comment()
        {
            Engine.cs_switch("ally");
            Engine.cs_abort_on_damage(true);
            Engine.cs_suppress_dialogue_global(true);
            Engine.print("spec-ops elite: 'more heretics!  in the passage below us!'");
            Engine.cs_play_line("1140");
        }

        [ScriptMethod(307, Lifecycle.Dormant)]
        public async Task hangar_exit_warn()
        {
            await Engine.sleep_until(async () => Engine.volume_test_objects(vol_hangar_center_exit, Engine.players()) == true, 30, 300);
            if (Engine.volume_test_objects(vol_hangar_center_exit, Engine.players()) == false && await this.player_count() > 0)
            {
                Engine.ai_scene("hangar_exit_scene", hangar_exit_comment, all_allies) // Couldn't generate cast from 'Boolean' to 'Void'
                ;
            }
        }

        [ScriptMethod(308, Lifecycle.Dormant)]
        public async Task hangar_reminder()
        {
            await Engine.sleep_until(async () => Engine.volume_test_objects(vol_leaving_hangar, Engine.players()) == true, 30, 3600);
            if (Engine.volume_test_objects(vol_leaving_hangar, Engine.players()) == false && await this.player_count() > 0)
            {
                Engine.ai_dialogue_enable(false);
                await Engine.sleep(60);
                Engine.print("spec-ops commander: 'keep heading down. find the leader of these heretics!'");
                await Engine.sleep(Engine.ai_play_line_on_object(default(IGameObject), "1150"));
                await Engine.sleep(30);
                Engine.ai_dialogue_enable(true);
            }

            await Engine.sleep_until(async () => Engine.volume_test_objects(vol_leaving_hangar, Engine.players()) == true, 30, 1800);
            if (Engine.volume_test_objects(vol_leaving_hangar, Engine.players()) == false && await this.player_count() > 0)
            {
                Engine.activate_team_nav_point_object(_default, player, hangar_exit.Entity, 0F);
                await Engine.sleep_until(async () => Engine.volume_test_objects(vol_leaving_hangar, Engine.players()) == true);
                Engine.deactivate_team_nav_point_object(player, hangar_exit.Entity);
            }
        }

        [ScriptMethod(309, Lifecycle.Dormant)]
        public async Task hangar_exterior_toggle()
        {
            Engine.object_create(alpha_gas_exterior);
            await Engine.sleep_until(async () =>
            {
                await Engine.sleep_until(async () => Engine.volume_test_objects(vol_first_hall_01, Engine.players()) == true);
                Engine.object_destroy(alpha_gas_exterior.Entity);
                await Engine.sleep_until(async () => Engine.volume_test_objects(vol_leaving_hangar, Engine.players()) == true);
                Engine.object_create(alpha_gas_exterior);
                return false;
            });
        }

        [ScriptMethod(310, Lifecycle.CommandScript)]
        public async Task deploy_hangar_right()
        {
            Engine.cs_force_combat_status(4);
            Engine.cs_enable_pathfinding_failsafe(true);
            Engine.cs_go_to(Engine.GetReference<ISpatialPoint>("hangar_turrets/deploy_r"));
            Engine.cs_deploy_turret(Engine.GetReference<ISpatialPoint>("hangar_turrets/right"));
            Engine.cs_enable_targeting(true);
            Engine.cs_shoot(true);
            Engine.cs_set_behavior(guard);
            Engine.sleep_forever();
        }

        [ScriptMethod(311, Lifecycle.CommandScript)]
        public async Task deploy_hangar_left()
        {
            Engine.cs_force_combat_status(4);
            Engine.cs_enable_pathfinding_failsafe(true);
            Engine.cs_go_to(Engine.GetReference<ISpatialPoint>("hangar_turrets/deploy_l"));
            Engine.cs_deploy_turret(Engine.GetReference<ISpatialPoint>("hangar_turrets/left"));
            Engine.cs_enable_targeting(true);
            Engine.cs_shoot(true);
            Engine.cs_set_behavior(guard);
            Engine.sleep_forever();
        }

        [ScriptMethod(312, Lifecycle.Static)]
        public async Task test_ass()
        {
            Engine.device_operates_automatically_set(hangar_exit.Entity, true);
            Engine.ai_place(hangar_heretic_06R.Squad, (short)Engine.random_range(0, 2));
            Engine.ai_place(hangar_heretic_06L.Squad, (short)(1 - (float)Engine.ai_living_count(hangar_heretic_06R.Squad)));
            Engine.ai_place(hangar_grunts_04R.Squad, 1);
            Engine.ai_place(hangar_grunts_04L.Squad, 1);
            Engine.cs_run_command_script(hangar_heretics, snap_alert);
            Engine.cs_queue_command_script(hangar_grunts_04R.Squad, deploy_hangar_right);
            Engine.cs_queue_command_script(hangar_grunts_04L.Squad, deploy_hangar_left);
        }

        [ScriptMethod(313, Lifecycle.Dormant)]
        public async Task hangar_firsttime_start()
        {
            Engine.data_mine_set_mission_segment("04a_3_hangar");
            Engine.object_create_containing("hang_can_");
            Engine.wake(new ScriptMethodReference(hangar_helpers));
            Engine.wake(new ScriptMethodReference(hangar_can_spawner));
            Engine.wake(new ScriptMethodReference(hangar_killer_new));
            Engine.wake(new ScriptMethodReference(hangar_sentinels_flitting));
            Engine.wake(new ScriptMethodReference(hangar_door_monitor));
            this.hangar_power_on = true;
            Engine.ai_renew(all_allies);
            Engine.ai_place(hangar_heretic_01R.Squad, (short)Engine.random_range(0, 2));
            Engine.ai_place(hangar_heretic_01L.Squad, (short)(1 - (float)Engine.ai_living_count(hangar_heretic_01R.Squad)));
            Engine.ai_place(hangar_heretic_02L.Squad, (short)Engine.random_range(0, 2));
            Engine.ai_place(hangar_heretic_02R.Squad, (short)(1 - (float)Engine.ai_living_count(hangar_heretic_02L.Squad)));
            Engine.ai_place(hangar_grunts_01R.Squad, (short)Engine.random_range(1, 3));
            Engine.ai_place(hangar_grunts_01L.Squad, (short)(2 - (float)Engine.ai_living_count(hangar_grunts_01R.Squad)));
            await Engine.sleep_until(async () => Engine.device_get_position(elev_hangar.Entity) > 0.1F);
            Engine.wake(new ScriptMethodReference(music_04a_01_start));
            Engine.cs_run_command_script(all_allies, abort);
            Engine.wake(new ScriptMethodReference(hangar_extra_save));
            await Engine.sleep_until(async () => Engine.device_get_position(elev_hangar.Entity) > 0.6F);
            this.stealth_talk_gone = true;
            Engine.ai_set_orders(arm01_allies, ride_hangar_elev);
            Engine.wake(new ScriptMethodReference(hangar_alerted_call));
            await Engine.sleep_until(async () => Engine.volume_test_objects(vol_hangar_mid_left, Engine.players()) == true || Engine.volume_test_objects(vol_hangar_mid_right, Engine.players()) == true || Engine.volume_test_objects(vol_hangar_end_left, Engine.players()) == true || Engine.volume_test_objects(vol_hangar_end_right, Engine.players()) == true || (short)Engine.ai_living_count(hangar_heretics) < 3);
            Engine.game_save();
            Engine.wake(new ScriptMethodReference(hangar_objective));
            Engine.wake(new ScriptMethodReference(hangar_door_reminder));
            if (Engine.volume_test_objects(vol_hangar_left, Engine.players()) == true)
            {
                Engine.ai_place(hangar_rein_her_02L.Squad, (short)(3 - (float)Engine.ai_living_count(hangar_grunts_01L.Squad)));
            }

            if (Engine.volume_test_objects(vol_hangar_right, Engine.players()) == true)
            {
                Engine.ai_place(hangar_rein_her_02R.Squad, (short)(3 - (float)Engine.ai_living_count(hangar_grunts_01R.Squad)));
            }

            await Engine.sleep_until(async () => Engine.volume_test_objects(vol_hangar_end_left, Engine.players()) == true || Engine.volume_test_objects(vol_hangar_end_right, Engine.players()) == true || (short)Engine.ai_living_count(hangar_heretics) < 3);
            Engine.game_save();
            if (Engine.volume_test_objects(vol_hangar_left, Engine.players()) == true)
            {
                Engine.ai_place(hangar_rein_her_03L.Squad, (short)(2 - (float)Engine.ai_living_count(hangar_heretic_01L.Squad) + (float)Engine.ai_living_count(hangar_heretic_01R.Squad) + (float)Engine.ai_living_count(hangar_heretic_02R.Squad) + (float)Engine.ai_living_count(hangar_heretic_02L.Squad)));
            }

            if (Engine.volume_test_objects(vol_hangar_right, Engine.players()) == true)
            {
                Engine.ai_place(hangar_rein_her_03R.Squad, (short)(2 - (float)Engine.ai_living_count(hangar_heretic_01L.Squad) + (float)Engine.ai_living_count(hangar_heretic_01R.Squad) + (float)Engine.ai_living_count(hangar_heretic_02R.Squad) + (float)Engine.ai_living_count(hangar_heretic_02L.Squad)));
            }

            Engine.ai_set_orders(hangar_heretics_init, defend_switch);
            await Engine.sleep_until(async () => Engine.device_get_position(hangar_door_cinematic.Entity) > 0F);
            Engine.wake(new ScriptMethodReference(hangar_exterior_toggle));
            Engine.game_save();
            await this.sentinel_swarm_spawning();
            await Engine.sleep_until(async () => (short)Engine.ai_living_count(hangar_sentinel_swarm.Squad) < 3, 30, 8000);
            await Engine.sleep_until(async () => (short)Engine.ai_living_count(hangar_sentinel_swarm.Squad) < 1, 30, 900);
            await Engine.sleep(150);
            Engine.game_save();
            await this.heretic_heavy_spawning();
            await Engine.sleep_until(async () => (short)Engine.ai_living_count(hangar_heretics) < 3, 30, 8000);
            await Engine.sleep_until(async () => (short)Engine.ai_living_count(hangar_heretics) < 1, 30, 900);
            await Engine.sleep(150);
            Engine.game_save();
            Engine.ai_place(hangar_a50_02r_high.Squad, (short)((float)Engine.random_range(0, 3) - (float)Engine.ai_living_count(a50_high)));
            Engine.cs_run_command_script(hangar_a50_02r_high.Squad, snap_alert);
            Engine.ai_place(hangar_a50_02l_high.Squad, (short)(2 - (float)Engine.ai_living_count(a50_high)));
            Engine.cs_run_command_script(hangar_a50_02l_high.Squad, snap_alert);
            Engine.ai_place(hangar_a50_02r_low.Squad, (short)((float)Engine.random_range(0, 3) - (float)Engine.ai_living_count(a50_low)));
            Engine.cs_run_command_script(hangar_a50_02r_low.Squad, snap_alert);
            Engine.ai_place(hangar_a50_02l_low.Squad, (short)(2 - (float)Engine.ai_living_count(a50_low)));
            Engine.cs_run_command_script(hangar_a50_02l_low.Squad, snap_alert);
            await Engine.sleep_until(async () => (short)Engine.ai_living_count(hangar_heretics) < 3 || Engine.volume_test_objects(vol_hangar_center_exit, Engine.players()) == true, 30, 3600);
            Engine.game_save();
            if (Engine.volume_test_objects(vol_hangar_center_exit, Engine.players()) == false && await this.player_count() > 0)
            {
                Engine.ai_place(hangar_a50_01r_high.Squad, (short)((float)Engine.random_range(0, 3) - (float)Engine.ai_living_count(a50_high)));
                Engine.cs_run_command_script(hangar_a50_01r_high.Squad, snap_alert);
                Engine.ai_place(hangar_a50_01l_high.Squad, (short)(2 - (float)Engine.ai_living_count(a50_high)));
                Engine.cs_run_command_script(hangar_a50_01l_high.Squad, snap_alert);
                Engine.ai_place(hangar_a50_01r_low.Squad, (short)((float)Engine.random_range(0, 3) - (float)Engine.ai_living_count(a50_low)));
                Engine.cs_run_command_script(hangar_a50_01r_low.Squad, snap_alert);
                Engine.ai_place(hangar_a50_01l_low.Squad, (short)(2 - (float)Engine.ai_living_count(a50_low)));
                Engine.cs_run_command_script(hangar_a50_01l_low.Squad, snap_alert);
            }

            await Engine.sleep_until(async () => (short)Engine.ai_living_count(hangar_heretics) < 3 || Engine.volume_test_objects(vol_hangar_center_exit, Engine.players()) == true, 30, 3600);
            Engine.game_save();
            Engine.device_operates_automatically_set(hangar_exit.Entity, true);
            Engine.ai_place(hangar_heretic_06R.Squad, (short)Engine.random_range(0, 2));
            Engine.ai_place(hangar_heretic_06L.Squad, (short)(1 - (float)Engine.ai_living_count(hangar_heretic_06R.Squad)));
            Engine.ai_place(hangar_grunts_04R.Squad, 1);
            Engine.ai_place(hangar_grunts_04L.Squad, 1);
            Engine.cs_run_command_script(hangar_heretics, snap_alert);
            Engine.cs_queue_command_script(hangar_grunts_04R.Squad, deploy_hangar_right);
            Engine.cs_queue_command_script(hangar_grunts_04L.Squad, deploy_hangar_left);
            Engine.wake(new ScriptMethodReference(hangar_exit_warn));
            Engine.wake(new ScriptMethodReference(hangar_reminder));
            await Engine.sleep_until(async () => Engine.volume_test_objects(vol_leaving_hangar, Engine.players()) == true, 30, 300);
            Engine.ai_place(hangar_heretic_06C.Squad, 1);
            Engine.cs_run_command_script(hangar_heretic_06C.Squad, snap_alert);
            await Engine.sleep_until(async () => (short)Engine.ai_living_count(hangar_heretics) < 1);
            Engine.game_save();
        }

        [ScriptMethod(314, Lifecycle.Dormant)]
        public async Task first_hall_reinforce()
        {
            await Engine.sleep_until(async () => (short)Engine.ai_combat_status(first_hall_heretics) > this.ai_combat_status_idle && (short)Engine.ai_living_count(first_hall_heretic_01.Squad) < 1 || (short)Engine.ai_living_count(first_hall_heretic_02.Squad) < 1);
            Engine.ai_place(first_hall_heretic_03.Squad, 2);
            Engine.cs_run_command_script(first_hall_heretic_03.Squad, snap_alert);
        }

        [ScriptMethod(315, Lifecycle.Dormant)]
        public async Task to_underhangar_firsttime()
        {
            await Engine.sleep_until(async () => Engine.volume_test_objects(vol_hangar_reenter, Engine.players()) == true);
            Engine.data_mine_set_mission_segment("04a_4_first_halls");
            Engine.game_save();
            Engine.ai_renew(all_allies);
            Engine.ai_migrate(hangar_heretics, chasers.Squad);
            Engine.ai_set_orders(chasers.Squad, chase01);
            Engine.ai_place(first_hall_heretic_01.Squad, 1);
            Engine.ai_place(first_hall_grunts_01.Squad, 2);
            Engine.ai_place(first_hall_heretic_02.Squad, 1);
            await Engine.sleep_until(async () => Engine.volume_test_objects(vol_hangar_reenter, Engine.players()) == true);
            Engine.wake(new ScriptMethodReference(first_hall_reinforce));
            this.stealth_talk_gone = true;
            Engine.ai_set_orders(arm01_allies, allies_first_hall);
            await Engine.sleep_until(async () => (short)Engine.ai_living_count(first_hall_heretics) < 1);
            Engine.game_save();
        }

        [ScriptMethod(316, Lifecycle.Dormant)]
        public async Task underhangar_can_spawner()
        {
            await Engine.sleep_until(async () => this.underhangar_power_on == true);
            await Engine.sleep_until(async () =>
            {
                Engine.begin_random(async () =>
                {
                    if (Engine.list_count(Engine.volume_return_objects_by_type(vol_underhangar_can_all, 2048)) < 15)
                    {
                        Engine.object_create_clone(underhangar_can_a);
                    }
                }, 
                    async () => await Engine.sleep(this.recycling_time), 
                    async () =>
                {
                    if (Engine.list_count(Engine.volume_return_objects_by_type(vol_underhangar_can_all, 2048)) < 15)
                    {
                        Engine.object_create_clone(underhangar_can_b);
                    }
                }, 
                    async () => await Engine.sleep(this.recycling_time));
                return this.underhangar_power_on == false;
            });
        }

        [ScriptMethod(317, Lifecycle.Dormant)]
        public async Task underhangar_killer_new()
        {
            await Engine.sleep_until(async () => this.underhangar_power_on == true);
            await Engine.sleep_until(async () =>
            {
                Engine.object_destroy(Engine.list_get(Engine.volume_return_objects(kill_underhangar_pit_01), 0));
                await Engine.sleep(45);
                Engine.unit_kill_silent(Engine.unit(Engine.list_get(Engine.volume_return_objects_by_type(kill_underhangar_pit_01, 1), 0)));
                await Engine.sleep(45);
                Engine.object_destroy(Engine.list_get(Engine.volume_return_objects(kill_underhangar_pit_02), 0));
                await Engine.sleep(45);
                Engine.unit_kill_silent(Engine.unit(Engine.list_get(Engine.volume_return_objects_by_type(kill_underhangar_pit_02, 1), 0)));
                await Engine.sleep(45);
                return this.underhangar_power_on == false;
            });
        }

        [ScriptMethod(318, Lifecycle.Dormant)]
        public async Task new_allies_02()
        {
            if (Engine.volume_test_objects(vol_hangar_can_all, Engine.players()) == false && await this.player_count() > 0)
            {
                await Engine.sleep_until(async () =>
                {
                    Engine.object_destroy(Engine.list_get(Engine.volume_return_objects_by_type(vol_hangar_can_all, 1), 0));
                    return Engine.list_count(Engine.volume_return_objects_by_type(vol_hangar_can_all, 1)) == 0;
                }, 10);
            }

            if (Engine.volume_test_objects(vol_underhangar_reinforce, Engine.players()) == false && await this.player_count() > 0 && (short)Engine.ai_living_count(arm01_allies) < 3)
            {
                Engine.ai_place(reinforce_elites_02.Squad, (short)(1 - (float)Engine.ai_living_count(allies_elites)));
                Engine.ai_place(reinforce_grunts_02.Squad, (short)(1 - (float)Engine.ai_living_count(allies_grunts)));
            }
        }

        [ScriptMethod(319, Lifecycle.Dormant)]
        public async Task underhangar_reinforce()
        {
            await Engine.sleep_until(async () => (short)Engine.ai_combat_status(underhangar_heretics) > this.ai_combat_status_idle);
            if (Engine.volume_test_objects(vol_underhangar_halfway, Engine.players()) == false && Engine.volume_test_objects(vol_underhangar_end, Engine.players()) == false && await this.player_count() > 0)
            {
                if ((short)Engine.ai_living_count(underhangar_heretics) < 8)
                {
                    Engine.ai_place(underhangar_rein_her_01.Squad, 2);
                }

                Engine.cs_run_command_script(underhangar_rein_her_01.Squad, snap_alert);
            }

            await Engine.sleep_until(async () => Engine.volume_test_objects(vol_underhangar_halfway, Engine.players()) == true || Engine.volume_test_objects(vol_underhangar_end, Engine.players()) == true);
            if (Engine.volume_test_objects(vol_underhangar_end, Engine.players()) == false && await this.player_count() > 0)
            {
                if ((short)Engine.ai_living_count(underhangar_heretics) < 8)
                {
                    Engine.ai_place(underhangar_rein_her_02.Squad, 2);
                }

                Engine.cs_run_command_script(underhangar_rein_her_02.Squad, snap_alert);
            }

            await Engine.sleep_until(async () => Engine.volume_test_objects(vol_underhangar_end, Engine.players()) == true);
            if ((short)Engine.ai_living_count(underhangar_heretics) < 8)
            {
                Engine.ai_place(underhangar_grunts_03.Squad, 4);
            }

            Engine.cs_run_command_script(underhangar_grunts_03.Squad, snap_alert);
        }

        [ScriptMethod(320, Lifecycle.CommandScript)]
        public async Task underhangar_comment()
        {
            Engine.cs_switch("ally");
            Engine.cs_abort_on_damage(true);
            Engine.cs_suppress_dialogue_global(true);
            Engine.print("spec-ops elite: 'shall we keep moving, arbiter? the heretic-leader cowers below!'");
            Engine.cs_play_line("1160");
        }

        [ScriptMethod(321, Lifecycle.Dormant)]
        public async Task underhangar_reminder()
        {
            await Engine.sleep_until(async () => Engine.volume_test_objects(vol_underhangar_from_bottom, Engine.players()) == true, 30, 900);
            if (Engine.volume_test_objects(vol_underhangar_from_bottom, Engine.players()) == false && await this.player_count() > 0)
            {
                Engine.ai_scene("underhangar_scene", underhangar_comment, all_allies) // Couldn't generate cast from 'Boolean' to 'Void'
                ;
            }
        }

        [ScriptMethod(322, Lifecycle.Dormant)]
        public async Task underhangar_firsttime_start()
        {
            Engine.data_mine_set_mission_segment("04a_5_underhangar");
            Engine.game_save();
            Engine.ai_renew(all_allies);
            Engine.object_create_containing("underhang_can_");
            if (Engine.volume_test_objects_all(vol_hangar_left, Engine.players()) == false && Engine.volume_test_objects_all(vol_hangar_right, Engine.players()) == false && Engine.device_get_position(hangar_exit.Entity) > 0F && await this.player_count() > 0)
            {
                Engine.pvs_set_object(hangar_door_cinematic.Entity);
                await Engine.sleep(2);
                Engine.device_set_position_immediate(hangar_door_cinematic.Entity, 0F);
                await Engine.sleep(2);
                Engine.pvs_clear();
            }

            Engine.wake(new ScriptMethodReference(underhangar_can_spawner));
            Engine.wake(new ScriptMethodReference(underhangar_killer_new));
            Engine.wake(new ScriptMethodReference(underhangar_reinforce));
            this.underhangar_power_on = true;
            Engine.ai_migrate(first_hall_heretics, chasers.Squad);
            Engine.ai_set_orders(chasers.Squad, chase01);
            Engine.ai_place(underhangar_heretic_01.Squad, 1);
            Engine.ai_place(underhangar_grunts_01.Squad, 3);
            this.stealth_talk_gone = true;
            Engine.ai_set_orders(arm01_allies, allies_underhangar);
            await Engine.sleep(5);
            Engine.wake(new ScriptMethodReference(music_04a_02_start));
            await Engine.sleep_until(async () => Engine.volume_test_objects(vol_underhangar_halfway, Engine.players()) == true || (short)Engine.ai_living_count(underhangar_heretics) < 1);
            Engine.game_save();
            Engine.wake(new ScriptMethodReference(new_allies_02));
            if ((short)Engine.ai_living_count(underhangar_heretics) < 8)
            {
                Engine.ai_place(underhangar_heretic_02.Squad, 1);
            }

            if ((short)Engine.ai_living_count(underhangar_heretics) < 8)
            {
                Engine.ai_place(underhangar_grunts_02.Squad, 2);
            }

            await Engine.sleep_until(async () => (short)Engine.ai_living_count(underhangar_heretics) < 1 || Engine.volume_test_objects(vol_underhangar_from_bottom, Engine.players()) == true);
            Engine.game_save();
            Engine.wake(new ScriptMethodReference(underhangar_reminder));
            Engine.wake(new ScriptMethodReference(music_04a_02_stop));
        }

        [ScriptMethod(323, Lifecycle.Dormant)]
        public async Task second_hall_reinforce_01()
        {
            await Engine.sleep_until(async () => (short)Engine.ai_combat_status(second_hall_grunts_01.Squad) > this.ai_combat_status_idle || (short)Engine.ai_combat_status(second_hall_heretic_01.Squad) > this.ai_combat_status_idle);
            Engine.ai_place(second_hall_heretic_02.Squad, 1);
            Engine.cs_run_command_script(second_hall_heretic_02.Squad, snap_alert);
        }

        [ScriptMethod(324, Lifecycle.Dormant)]
        public async Task second_hall_reinforce_02()
        {
            await Engine.sleep_until(async () => (short)Engine.ai_combat_status(second_hall_heretic_03.Squad) > this.ai_combat_status_idle);
            Engine.ai_place(second_hall_grunts_02._1);
            Engine.ai_place(second_hall_grunts_02._2);
            if (Engine.volume_test_objects(vol_2nd_hall_02, Engine.players()) == false && await this.player_count() > 0)
            {
                Engine.ai_place(second_hall_grunts_02._3);
                Engine.ai_place(second_hall_grunts_02._4);
            }

            Engine.cs_run_command_script(second_hall_grunts_02.Squad, snap_alert);
        }

        [ScriptMethod(325, Lifecycle.Dormant)]
        public async Task second_hall_reinforce_03()
        {
            await Engine.sleep_until(async () => (short)Engine.ai_combat_status(second_hall_grunts_03.Squad) > this.ai_combat_status_idle);
            Engine.ai_place(second_hall_heretic_04.Squad, 1);
            if (Engine.volume_test_objects(vol_2nd_hall_02, Engine.players()) == false && await this.player_count() > 0)
            {
                Engine.ai_place(second_hall_heretic_05.Squad, 1);
            }

            Engine.cs_run_command_script(second_hall_heretic_04.Squad, snap_alert);
            Engine.cs_run_command_script(second_hall_heretic_05.Squad, snap_alert);
        }

        [ScriptMethod(326, Lifecycle.Dormant)]
        public async Task to_bottling()
        {
            await Engine.sleep_until(async () => Engine.volume_test_objects(vol_underhangar_from_bottom, Engine.players()) == true);
            Engine.data_mine_set_mission_segment("04a_6_second_halls");
            Engine.game_save();
            Engine.ai_renew(all_allies);
            Engine.player_training_activate_stealth();
            if (Engine.device_get_position(hangar_door_cinematic.Entity) > 0F)
            {
                Engine.pvs_set_object(hangar_door_cinematic.Entity);
                await Engine.sleep(2);
                Engine.device_set_position_immediate(hangar_door_cinematic.Entity, 0F);
                await Engine.sleep(2);
                Engine.pvs_clear();
            }

            Engine.wake(new ScriptMethodReference(second_hall_reinforce_01));
            Engine.wake(new ScriptMethodReference(second_hall_reinforce_02));
            Engine.wake(new ScriptMethodReference(second_hall_reinforce_03));
            Engine.ai_migrate(underhangar_heretics, chasers.Squad);
            Engine.ai_set_orders(chasers.Squad, chase02);
            Engine.ai_place(second_hall_heretic_01.Squad, 1);
            Engine.ai_place(second_hall_grunts_01.Squad, 2);
            this.stealth_talk_gone = true;
            Engine.ai_set_orders(arm01_allies, allies_second_hall);
            await Engine.sleep_until(async () => Engine.volume_test_objects(vol_2nd_hall_01, Engine.players()) == true);
            Engine.game_save();
            Engine.ai_place(second_hall_heretic_03.Squad, 1);
            Engine.ai_place(second_hall_grunts_03.Squad, 4);
            if ((short)Engine.ai_combat_status(second_hall_heretics) < this.ai_combat_status_active)
            {
                Engine.ai_set_active_camo(arm01_allies, true);
                Engine.ai_suppress_combat(arm01_allies, true);
            }
        }

        [ScriptMethod(327, Lifecycle.Dormant)]
        public async Task bottling_can_spawner()
        {
            await Engine.sleep_until(async () => this.bottling_power_on == true);
            await Engine.sleep_until(async () =>
            {
                Engine.begin_random(async () =>
                {
                    if (Engine.list_count(Engine.volume_return_objects_by_type(vol_bottling_can_all, 2048)) < 10)
                    {
                        Engine.object_create_clone(bottling_can_a);
                        await Engine.sleep(this.recycling_time);
                    }
                }, 
                    async () => await Engine.sleep(this.recycling_time), 
                    async () =>
                {
                    if (Engine.list_count(Engine.volume_return_objects_by_type(vol_bottling_can_all, 2048)) < 10)
                    {
                        Engine.object_create_clone(bottling_can_b);
                        await Engine.sleep(this.recycling_time);
                    }
                }, 
                    async () => await Engine.sleep(this.recycling_time));
                return this.bottling_power_on == false;
            });
        }

        [ScriptMethod(328, Lifecycle.Dormant)]
        public async Task bottling_killer_new()
        {
            await Engine.sleep_until(async () => this.bottling_power_on == true);
            await Engine.sleep_until(async () =>
            {
                Engine.object_destroy(Engine.list_get(Engine.volume_return_objects(kill_bottling_pit_01), 0));
                await Engine.sleep(45);
                Engine.unit_kill_silent(Engine.unit(Engine.list_get(Engine.volume_return_objects_by_type(kill_bottling_pit_01, 1), 0)));
                await Engine.sleep(45);
                Engine.object_destroy(Engine.list_get(Engine.volume_return_objects(kill_bottling_pit_02), 0));
                await Engine.sleep(45);
                Engine.unit_kill_silent(Engine.unit(Engine.list_get(Engine.volume_return_objects_by_type(kill_bottling_pit_02, 1), 0)));
                await Engine.sleep(45);
                return this.bottling_power_on == false;
            });
        }

        [ScriptMethod(329, Lifecycle.CommandScript)]
        public async Task bottling_sentinel_call()
        {
            Engine.cs_switch("heretic");
            Engine.cs_abort_on_damage(true);
            Engine.cs_suppress_dialogue_global(true);
            Engine.print("heretic: 'we need sentinels!'");
            Engine.cs_play_line("0450");
        }

        [ScriptMethod(330, Lifecycle.Dormant)]
        public async Task new_allies_03()
        {
            if (Engine.volume_test_objects(vol_underhangar_can_all, Engine.players()) == false && await this.player_count() > 0)
            {
                await Engine.sleep_until(async () =>
                {
                    Engine.object_destroy(Engine.list_get(Engine.volume_return_objects_by_type(vol_underhangar_can_all, 1), 0));
                    return Engine.list_count(Engine.volume_return_objects_by_type(vol_underhangar_can_all, 1)) == 0;
                }, 10);
            }

            if (Engine.volume_test_objects(vol_bottling_reinforce, Engine.players()) == false && await this.player_count() > 0 && (short)Engine.ai_living_count(arm01_allies) < 3)
            {
                Engine.ai_place(reinforce_elites_03.Squad, (short)(1 - (float)Engine.ai_living_count(allies_elites)));
                Engine.ai_place(reinforce_grunts_03.Squad, (short)(1 - (float)Engine.ai_living_count(allies_grunts)));
            }
        }

        [ScriptMethod(331, Lifecycle.Dormant)]
        public async Task bottling_firsttime_start()
        {
            Engine.data_mine_set_mission_segment("04a_7_bottling_plant");
            Engine.game_save();
            Engine.object_create_containing("bott_can_");
            Engine.ai_renew(all_allies);
            this.stealth_talk_gone = true;
            Engine.ai_set_orders(arm01_allies, allies_bottling);
            Engine.wake(new ScriptMethodReference(bottling_can_spawner));
            Engine.wake(new ScriptMethodReference(bottling_killer_new));
            this.bottling_power_on = true;
            Engine.ai_migrate(second_hall_heretics, chasers.Squad);
            Engine.ai_set_orders(chasers.Squad, chase02);
            Engine.ai_place(bottling_heretics_01.Squad, 2);
            Engine.ai_place(bottling_grunts_01.Squad, 2);
            Engine.ai_place(bottling_sentinels_01.Squad, 2);
            await Engine.sleep_until(async () => Engine.volume_test_objects(vol_bottling_really_inside, Engine.players()) == true);
            Engine.wake(new ScriptMethodReference(new_allies_03));
            await Engine.sleep_until(async () => (short)Engine.ai_living_count(bottling_heretics) < 2 || Engine.volume_test_objects(vol_bottling_mid01, Engine.players()) == true || false);
            Engine.game_save();
            Engine.ai_place(bottling_heretics_02.Squad, (short)(1 - (float)Engine.ai_living_count(bottling_heretics_01.Squad)));
            Engine.ai_place(bottling_grunts_02.Squad, (short)(4 - (float)Engine.ai_living_count(bottling_grunts_01.Squad)));
            await Engine.sleep_until(async () => (short)Engine.ai_living_count(bottling_heretics) < 2 || Engine.volume_test_objects(vol_bottling_mid02, Engine.players()) == true || false);
            Engine.game_save();
            Engine.ai_place(bottling_heretics_03.Squad, (short)(2 - (float)Engine.ai_living_count(bottling_heretics_01.Squad) + (float)Engine.ai_living_count(bottling_heretics_02.Squad)));
            Engine.ai_place(bottling_grunts_03.Squad, (short)(3 - (float)Engine.ai_living_count(bottling_grunts_02.Squad) + (float)Engine.ai_living_count(bottling_grunts_01.Squad)));
            await Engine.sleep_until(async () => (short)Engine.ai_living_count(bottling_heretics) < 1 && (short)Engine.ai_living_count(bottling_sentinels) < 1);
            Engine.game_save();
        }

        [ScriptMethod(332, Lifecycle.CommandScript)]
        public async Task hl_retreat_01()
        {
            Engine.cs_switch("heretic_01");
            Engine.cs_force_combat_status(4);
            Engine.cs_face_player(true);
            Engine.cs_suppress_dialogue_global(true);
            Engine.print("heretic leader: 'there! the assassin!'");
            Engine.cs_custom_animation(Engine.GetTag<AnimationGraphTag>("objects\\characters\\elite\\elite", 3882747384U), "combat:rifle:warn", 1F, true);
            Engine.cs_face_player(false);
        }

        [ScriptMethod(333, Lifecycle.CommandScript)]
        public async Task hl_retreat_backup()
        {
            Engine.cs_enable_pathfinding_failsafe(true);
            Engine.cs_go_to(Engine.GetReference<ISpatialPoint>("bottling_plant/p1"));
            Engine.ai_erase(heretic_leader_02.Squad);
        }

        [ScriptMethod(334, Lifecycle.CommandScript)]
        public async Task sentinel_wingmen_a()
        {
            Engine.cs_enable_pathfinding_failsafe(true);
            Engine.cs_fly_to(Engine.GetReference<ISpatialPoint>("airspace_hl/sen_a_0"), 5F);
            Engine.cs_fly_to(Engine.GetReference<ISpatialPoint>("airspace_hl/sen_a_1"), 20F);
            Engine.ai_erase(bottling_sentinels_03.a);
        }

        [ScriptMethod(335, Lifecycle.CommandScript)]
        public async Task sentinel_wingmen_b()
        {
            Engine.cs_enable_pathfinding_failsafe(true);
            Engine.cs_fly_to(Engine.GetReference<ISpatialPoint>("airspace_hl/sen_b_0"), 5F);
            Engine.cs_fly_to(Engine.GetReference<ISpatialPoint>("airspace_hl/sen_b_1"), 20F);
            Engine.ai_erase(bottling_sentinels_03.b);
        }

        [ScriptMethod(336, Lifecycle.CommandScript)]
        public async Task hl_retreat_02()
        {
            Engine.cs_enable_pathfinding_failsafe(true);
            Engine.cs_force_combat_status(4);
            Engine.cs_approach(approach_here.Entity, 1F, 20F, 20F);
            Engine.cs_suppress_dialogue_global(true);
            Engine.print("heretic leader: 'deal with him, my brothers!'");
            Engine.cs_play_line("0470");
            await Engine.sleep(15);
            Engine.print("'i will defend the oracle!'");
            Engine.cs_play_line("0480");
            this.hl_done_yapping = true;
            Engine.ai_vehicle_reserve(Engine.ai_vehicle_get_from_starting_location(ledge_banshees_01.center), false);
            Engine.cs_approach_stop();
            Engine.cs_go_to_vehicle(Engine.ai_vehicle_get_from_starting_location(ledge_banshees_01.center));
            Engine.wake(new ScriptMethodReference(music_04a_03_start));
            Engine.cs_fly_to(Engine.GetReference<ISpatialPoint>("airspace_hl/hl0"), 5F);
            Engine.cs_vehicle_boost(true);
            Engine.cs_fly_to(Engine.GetReference<ISpatialPoint>("airspace_hl/hl1"), 20F);
            Engine.ai_erase(heretic_leader_03.Squad);
        }

        [ScriptMethod(337, Lifecycle.CommandScript)]
        public async Task hl_retreat_react()
        {
            Engine.cs_switch("heretic");
            Engine.cs_force_combat_status(4);
            Engine.cs_enable_moving(true);
            Engine.cs_suppress_dialogue_global(true);
            Engine.print("heretic: 'its truth must not be silenced!'");
            Engine.cs_play_line("0490");
        }

        [ScriptMethod(338, Lifecycle.Dormant)]
        public async Task bottling_overlook_reinforce()
        {
            Engine.ai_place(bottling_sentinels_02.Squad, 1);
            await Engine.sleep(120);
            Engine.ai_place(bottling_sentinels_02.Squad, 1);
            await Engine.sleep(120);
            Engine.ai_place(bottling_sentinels_02.Squad, 1);
        }

        [ScriptMethod(339, Lifecycle.CommandScript)]
        public async Task phantom_to_ledge()
        {
            Engine.cs_enable_pathfinding_failsafe(true);
            Engine.cs_vehicle_speed(0.75F);
            Engine.cs_fly_by(Engine.GetReference<ISpatialPoint>("airspace/ph0x"), 10F);
            Engine.cs_fly_to_and_face(Engine.GetReference<ISpatialPoint>("airspace/ph00"), Engine.GetReference<ISpatialPoint>("airspace/ph01"), 5F);
            Engine.sleep_forever();
        }

        [ScriptMethod(340, Lifecycle.CommandScript)]
        public async Task bottling_elites_secure()
        {
            Engine.cs_switch("elite");
            Engine.cs_abort_on_damage(true);
            Engine.cs_suppress_dialogue_global(true);
            Engine.print("spec-ops elite: 'onward, arbiter!  we will secure this section of the station!'");
            Engine.cs_play_line("1170");
        }

        [ScriptMethod(341, Lifecycle.CommandScript)]
        public async Task bottling_grunts_secure()
        {
            Engine.cs_switch("grunt");
            Engine.cs_abort_on_damage(true);
            Engine.cs_suppress_dialogue_global(true);
            Engine.print("spec-ops grunt: 'you go. we stay. grunt not allowed to fly.'");
            Engine.cs_play_line("1180");
        }

        [ScriptMethod(342, Lifecycle.Dormant)]
        public async Task bottling_allies_secure()
        {
            await Engine.sleep_until(async () => Engine.vehicle_test_seat(Engine.ai_vehicle_get_from_starting_location(ledge_banshees_01.left), "banshee_d", Engine.unit(await this.player0())) == true || Engine.vehicle_test_seat(Engine.ai_vehicle_get_from_starting_location(ledge_banshees_01.right), "banshee_d", Engine.unit(await this.player0())) == true || Engine.vehicle_test_seat(Engine.ai_vehicle_get_from_starting_location(ledge_banshees_01.left), "banshee_d", Engine.unit(await this.player1())) == true || Engine.vehicle_test_seat(Engine.ai_vehicle_get_from_starting_location(ledge_banshees_01.right), "banshee_d", Engine.unit(await this.player1())) == true, 30, 900);
            if (Engine.vehicle_test_seat(Engine.ai_vehicle_get_from_starting_location(ledge_banshees_01.left), "banshee_d", Engine.unit(await this.player0())) == false && Engine.vehicle_test_seat(Engine.ai_vehicle_get_from_starting_location(ledge_banshees_01.right), "banshee_d", Engine.unit(await this.player0())) == false && Engine.vehicle_test_seat(Engine.ai_vehicle_get_from_starting_location(ledge_banshees_01.left), "banshee_d", Engine.unit(await this.player1())) == false && Engine.vehicle_test_seat(Engine.ai_vehicle_get_from_starting_location(ledge_banshees_01.right), "banshee_d", Engine.unit(await this.player1())) == false)
            {
                if ((short)Engine.ai_living_count(allies_elites) > 0)
                {
                    Engine.ai_scene("bottling_elite_scene", bottling_elites_secure, allies_elites) // Couldn't generate cast from 'Boolean' to 'Void'
                    ;
                }
                else
                {
                    Engine.ai_scene("bottling_grunt_scene", bottling_grunts_secure, allies_grunts) // Couldn't generate cast from 'Boolean' to 'Void'
                    ;
                }
            }
        }

        [ScriptMethod(343, Lifecycle.Dormant)]
        public async Task big_filth_toggle()
        {
            await Engine.sleep_until(async () => Engine.volume_test_objects(vol_on_banshee_ledge, Engine.players()) == true);
            Engine.sound_class_set_gain("ambient_machinery", 0F, 2);
            Engine.object_create(big_filthy_audio1);
            Engine.sound_class_set_gain("ambient_machinery", 1F, 2);
            await Engine.sleep_until(async () =>
            {
                await Engine.sleep_until(async () => Engine.volume_test_objects(vol_bottling_back_top, Engine.players()) == true || Engine.volume_test_objects(vol_bottling_back, Engine.players()) == true || Engine.volume_test_objects(vol_bottling_exit_r, Engine.players()) == true || Engine.volume_test_objects(vol_bottling_exit_l, Engine.players()) == true);
                Engine.sound_class_set_gain("ambient_machinery", 0F, 2);
                Engine.object_destroy(big_filthy_audio1.Entity);
                Engine.sound_class_set_gain("ambient_machinery", 1F, 2);
                await Engine.sleep_until(async () => Engine.volume_test_objects(vol_on_banshee_ledge, Engine.players()) == true);
                Engine.sound_class_set_gain("ambient_machinery", 0F, 2);
                Engine.object_create(big_filthy_audio1);
                Engine.sound_class_set_gain("ambient_machinery", 1F, 2);
                return false;
            });
        }

        [ScriptMethod(344, Lifecycle.Dormant)]
        public async Task bring_in_da_phantom()
        {
            await Engine.sleep_until(async () => Engine.volume_test_objects(vol_bottling_exit_l, Engine.players()) == true || Engine.volume_test_objects(vol_bottling_exit_r, Engine.players()) == true || Engine.volume_test_objects(vol_on_banshee_ledge, Engine.players()) == true);
            Engine.game_save();
            Engine.wake(new ScriptMethodReference(_04a_title1));
            Engine.wake(new ScriptMethodReference(big_filth_toggle));
            Engine.ai_place(allied_phantom_01.Squad);
            Engine.object_cannot_take_damage(Engine.ai_vehicle_get_from_starting_location(allied_phantom_01.driver));
            Engine.cs_run_command_script(allied_phantom_01.driver, phantom_to_ledge);
            Engine.ai_dialogue_enable(false);
            await Engine.sleep(60);
            Engine.print("spec-ops commander: 'the heretics are mobilizing their air-forces, dervish!'");
            await Engine.sleep(Engine.ai_play_line_on_object(default(IGameObject), "0500"));
            await Engine.sleep(15);
            Engine.print("'get after their leader, but watch your back!'");
            await Engine.sleep(Engine.ai_play_line_on_object(default(IGameObject), "0510"));
            await Engine.sleep(15);
            Engine.print("'i'm sending one of our phantoms to support you!'");
            await Engine.sleep(Engine.ai_play_line_on_object(default(IGameObject), "0520"));
            await Engine.sleep(30);
            Engine.ai_dialogue_enable(true);
        }

        [ScriptMethod(345, Lifecycle.Dormant)]
        public async Task bottling_plant_end()
        {
            await Engine.sleep_until(async () => Engine.volume_test_objects(vol_bottling_back, Engine.players()) == true);
            Engine.data_mine_set_mission_segment("04a_8_bottling_back");
            Engine.game_save();
            Engine.ai_migrate(bottling_heretics_start, chasers.Squad);
            Engine.ai_set_orders(chasers.Squad, chase03);
            if ((short)Engine.ai_living_count(bottling_enemies) < 8)
            {
                Engine.ai_place(bottling_heretics_04.Squad, 2);
            }

            Engine.ai_place(dog_turrets_01.Squad);
            Engine.ai_place(ledge_banshees_01.Squad);
            Engine.ai_vehicle_reserve(Engine.ai_vehicle_get_from_starting_location(ledge_banshees_01.center), true);
            Engine.ai_vehicle_reserve(Engine.ai_vehicle_get_from_starting_location(ledge_banshees_01.left), true);
            Engine.ai_vehicle_reserve(Engine.ai_vehicle_get_from_starting_location(ledge_banshees_01.right), true);
            Engine.ai_place(bottling_heretics_05.Squad, 2);
            Engine.ai_place(heretic_leader_03.Squad);
            Engine.cs_run_command_script(heretic_leader_03.Squad, long_pause);
            Engine.object_cannot_take_damage(Engine.ai_actors(heretic_leader_03.Squad));
            this.left_bottling_firsthalf = true;
            await Engine.sleep_until(async () => Engine.volume_test_objects(vol_hl_delete_02, Engine.players()) == true, 30, 90);
            if (Engine.volume_test_objects(vol_hl_delete_02, Engine.players()) == false && await this.player_count() > 0 && (short)Engine.ai_living_count(bottling_enemies) < 8)
            {
                Engine.ai_place(bottling_grunts_04.Squad, 3);
            }

            await Engine.sleep_until(async () => Engine.volume_test_objects(vol_hl_delete_02, Engine.players()) == true);
            Engine.cs_run_command_script(heretic_leader_03.Squad, hl_retreat_02);
            await Engine.sleep_until(async () => this.hl_done_yapping == true, 30, 450);
            await Engine.sleep_until(async () => Engine.ai_scene("heretic_retreat_02_scene", hl_retreat_react, bottling_heretics_05.Squad), 30, 90);
            Engine.game_save();
            Engine.begin_random(async () =>
            {
                if (this.overlook_choose_side == false)
                {
                    this.overlook_choose_side = true;
                    Engine.ai_place(bottling_grunts_05.r1);
                    Engine.ai_place(bottling_grunts_05.r2);
                    Engine.ai_place(bottling_grunts_05.r3);
                    Engine.device_operates_automatically_set(viewroom_exit02.Entity, true);
                    Engine.object_create(blocker_l);
                }
            }, 
                async () =>
            {
                if (this.overlook_choose_side == false)
                {
                    this.overlook_choose_side = true;
                    Engine.ai_place(bottling_grunts_05.l1);
                    Engine.ai_place(bottling_grunts_05.l2);
                    Engine.ai_place(bottling_grunts_05.l3);
                    Engine.device_operates_automatically_set(viewroom_exit01.Entity, true);
                    Engine.object_create(blocker_r);
                }
            });
            Engine.ai_set_orders(bottling_heretics_05.Squad, bottling_h_wave_05_high);
            Engine.wake(new ScriptMethodReference(bring_in_da_phantom));
            await Engine.sleep_until(async () => (short)Engine.ai_living_count(bottling_heretics_05.Squad) < 1);
            Engine.game_save();
            Engine.wake(new ScriptMethodReference(bottling_overlook_reinforce));
            await Engine.sleep_until(async () => (short)Engine.ai_living_count(bottling_heretics) < 1 && (short)Engine.ai_living_count(bottling_sentinels) < 1);
            Engine.game_save();
            Engine.wake(new ScriptMethodReference(bottling_allies_secure));
        }

        [ScriptMethod(346, Lifecycle.CommandScript)]
        public async Task partytime()
        {
            Engine.cs_face(true, Engine.GetReference<ISpatialPoint>("arm02_lz/cake"));
            Engine.sleep_forever();
        }

        [ScriptMethod(347, Lifecycle.Dormant)]
        public async Task grunt_birthday_party()
        {
            await Engine.sleep_until(async () => Engine.volume_test_objects(vol_grunt_bday, Engine.players()) == true);
            Engine.object_create(bday_cake);
            Engine.ai_place(bday_party.Squad);
            Engine.cs_run_command_script(bday_party.Squad, partytime);
            Engine.custom_animation_loop(Engine.unit(Engine.list_get(Engine.ai_actors(bday_party.Squad), 0)), Engine.GetTag<AnimationGraphTag>("objects\\characters\\grunt\\grunt", 3942451591U), "combat:pistol:cheer", true);
            Engine.custom_animation_loop(Engine.unit(Engine.list_get(Engine.ai_actors(bday_party.Squad), 1)), Engine.GetTag<AnimationGraphTag>("objects\\characters\\grunt\\grunt", 3942451591U), "combat:pistol:cheer", true);
            Engine.custom_animation_loop(Engine.unit(Engine.list_get(Engine.ai_actors(bday_party.Squad), 2)), Engine.GetTag<AnimationGraphTag>("objects\\characters\\grunt\\grunt", 3942451591U), "combat:pistol:cheer", true);
            Engine.custom_animation_loop(Engine.unit(Engine.list_get(Engine.ai_actors(bday_party.Squad), 3)), Engine.GetTag<AnimationGraphTag>("objects\\characters\\grunt\\grunt", 3942451591U), "combat:pistol:cheer", true);
            Engine.custom_animation_loop(Engine.unit(Engine.list_get(Engine.ai_actors(bday_party.Squad), 4)), Engine.GetTag<AnimationGraphTag>("objects\\characters\\grunt\\grunt", 3942451591U), "combat:pistol:cheer", true);
            Engine.custom_animation_loop(Engine.unit(Engine.list_get(Engine.ai_actors(bday_party.Squad), 5)), Engine.GetTag<AnimationGraphTag>("objects\\characters\\grunt\\grunt", 3942451591U), "combat:pistol:cheer", true);
            await Engine.sleep_until(async () => Engine.unit_has_weapon(Engine.unit(await this.player0()), Engine.GetTag<BaseTag>("objects\\weapons\\multiplayer\\ball\\head_sp.weapon", 4059238355U)) || Engine.unit_has_weapon(Engine.unit(await this.player1()), Engine.GetTag<BaseTag>("objects\\weapons\\multiplayer\\ball\\head_sp.weapon", 4059238355U)));
            Engine.ice_cream_flavor_stock(1);
        }

        [ScriptMethod(348, Lifecycle.Dormant)]
        public async Task banshee_stuck_spawner_01()
        {
            await Engine.sleep_until(async () => Engine.unit_in_vehicle(await this.player0()) == true);
            await Engine.sleep_until(async () =>
            {
                await Engine.sleep_until(async () => Engine.unit_in_vehicle(await this.player0()) == false && Engine.volume_test_object(vol_arm_02_lz, await this.player0()) == false && await this.player_count() > 0);
                if (Engine.volume_test_object(vol_stuck_01, await this.player0()) == true && Engine.list_count_not_dead(Engine.volume_return_objects_by_type(vol_stuck_01, 2)) == 0)
                {
                    await Engine.sleep_until(async () =>
                    {
                        if (Engine.list_count_not_dead(Engine.volume_return_objects_by_type(vol_stuck_01, 2)) == 0 && Engine.objects_can_see_flag(Engine.players(), _01a, 45F) == false && Engine.objects_distance_to_flag(Engine.players(), _01a) > 2F)
                        {
                            Engine.object_create_clone(extra01a);
                        }

                        if (Engine.list_count_not_dead(Engine.volume_return_objects_by_type(vol_stuck_01, 2)) == 0 && Engine.objects_can_see_flag(Engine.players(), _01b, 45F) == false && Engine.objects_distance_to_flag(Engine.players(), _01b) > 2F)
                        {
                            Engine.object_create_clone(extra01b);
                        }

                        if (Engine.list_count_not_dead(Engine.volume_return_objects_by_type(vol_stuck_01, 2)) == 0 && Engine.objects_can_see_flag(Engine.players(), _01c, 45F) == false && Engine.objects_distance_to_flag(Engine.players(), _01c) > 2F)
                        {
                            Engine.object_create_clone(extra01c);
                        }

                        if (Engine.list_count_not_dead(Engine.volume_return_objects_by_type(vol_stuck_01, 2)) == 0 && Engine.objects_can_see_flag(Engine.players(), _01d, 45F) == false && Engine.objects_distance_to_flag(Engine.players(), _01d) > 2F)
                        {
                            Engine.object_create_clone(extra01d);
                        }

                        return Engine.unit_in_vehicle(await this.player0()) == true;
                    });
                }

                if (Engine.volume_test_object(vol_stuck_02, await this.player0()) == true && Engine.list_count_not_dead(Engine.volume_return_objects_by_type(vol_stuck_02, 2)) == 0)
                {
                    await Engine.sleep_until(async () =>
                    {
                        if (Engine.list_count_not_dead(Engine.volume_return_objects_by_type(vol_stuck_02, 2)) == 0 && Engine.objects_can_see_flag(Engine.players(), _02a, 45F) == false && Engine.objects_distance_to_flag(Engine.players(), _02a) > 2F)
                        {
                            Engine.object_create_clone(extra02a);
                        }

                        if (Engine.list_count_not_dead(Engine.volume_return_objects_by_type(vol_stuck_02, 2)) == 0 && Engine.objects_can_see_flag(Engine.players(), _02b, 45F) == false && Engine.objects_distance_to_flag(Engine.players(), _02b) > 2F)
                        {
                            Engine.object_create_clone(extra02b);
                        }

                        if (Engine.list_count_not_dead(Engine.volume_return_objects_by_type(vol_stuck_02, 2)) == 0 && Engine.objects_can_see_flag(Engine.players(), _02c, 45F) == false && Engine.objects_distance_to_flag(Engine.players(), _02c) > 2F)
                        {
                            Engine.object_create_clone(extra02c);
                        }

                        if (Engine.list_count_not_dead(Engine.volume_return_objects_by_type(vol_stuck_02, 2)) == 0 && Engine.objects_can_see_flag(Engine.players(), _02d, 45F) == false && Engine.objects_distance_to_flag(Engine.players(), _02d) > 2F)
                        {
                            Engine.object_create_clone(extra02d);
                        }

                        return Engine.unit_in_vehicle(await this.player0()) == true;
                    });
                }

                if (Engine.volume_test_object(vol_stuck_03, await this.player0()) == true && Engine.list_count_not_dead(Engine.volume_return_objects_by_type(vol_stuck_03, 2)) == 0)
                {
                    await Engine.sleep_until(async () =>
                    {
                        if (Engine.list_count_not_dead(Engine.volume_return_objects_by_type(vol_stuck_03, 2)) == 0 && Engine.objects_can_see_flag(Engine.players(), _03a, 45F) == false && Engine.objects_distance_to_flag(Engine.players(), _03a) > 2F)
                        {
                            Engine.object_create_clone(extra03a);
                        }

                        if (Engine.list_count_not_dead(Engine.volume_return_objects_by_type(vol_stuck_03, 2)) == 0 && Engine.objects_can_see_flag(Engine.players(), _03b, 45F) == false && Engine.objects_distance_to_flag(Engine.players(), _03b) > 2F)
                        {
                            Engine.object_create_clone(extra03b);
                        }

                        if (Engine.list_count_not_dead(Engine.volume_return_objects_by_type(vol_stuck_03, 2)) == 0 && Engine.objects_can_see_flag(Engine.players(), _03c, 45F) == false && Engine.objects_distance_to_flag(Engine.players(), _03c) > 2F)
                        {
                            Engine.object_create_clone(extra03c);
                        }

                        return Engine.unit_in_vehicle(await this.player0()) == true;
                    });
                }

                if (Engine.volume_test_object(vol_stuck_04, await this.player0()) == true && Engine.list_count_not_dead(Engine.volume_return_objects_by_type(vol_stuck_04, 2)) == 0)
                {
                    await Engine.sleep_until(async () =>
                    {
                        if (Engine.list_count_not_dead(Engine.volume_return_objects_by_type(vol_stuck_04, 2)) == 0 && Engine.objects_can_see_flag(Engine.players(), _04a, 45F) == false && Engine.objects_distance_to_flag(Engine.players(), _04a) > 2F)
                        {
                            Engine.object_create_clone(extra04a);
                        }

                        if (Engine.list_count_not_dead(Engine.volume_return_objects_by_type(vol_stuck_04, 2)) == 0 && Engine.objects_can_see_flag(Engine.players(), _04b, 45F) == false && Engine.objects_distance_to_flag(Engine.players(), _04b) > 2F)
                        {
                            Engine.object_create_clone(extra04b);
                        }

                        return Engine.unit_in_vehicle(await this.player0()) == true;
                    });
                }

                if (Engine.volume_test_object(vol_stuck_05, await this.player0()) == true && Engine.list_count_not_dead(Engine.volume_return_objects_by_type(vol_stuck_05, 2)) == 0)
                {
                    await Engine.sleep_until(async () =>
                    {
                        if (Engine.list_count_not_dead(Engine.volume_return_objects_by_type(vol_stuck_05, 2)) == 0 && Engine.objects_can_see_flag(Engine.players(), _05a, 45F) == false && Engine.objects_distance_to_flag(Engine.players(), _05a) > 2F)
                        {
                            Engine.object_create_clone(extra05a);
                        }

                        if (Engine.list_count_not_dead(Engine.volume_return_objects_by_type(vol_stuck_05, 2)) == 0 && Engine.objects_can_see_flag(Engine.players(), _05b, 45F) == false && Engine.objects_distance_to_flag(Engine.players(), _05b) > 2F)
                        {
                            Engine.object_create_clone(extra05b);
                        }

                        return Engine.unit_in_vehicle(await this.player0()) == true;
                    });
                }

                if (Engine.volume_test_object(vol_stuck_06, await this.player0()) == true && Engine.list_count_not_dead(Engine.volume_return_objects_by_type(vol_stuck_06, 2)) == 0)
                {
                    await Engine.sleep_until(async () =>
                    {
                        if (Engine.list_count_not_dead(Engine.volume_return_objects_by_type(vol_stuck_06, 2)) == 0 && Engine.objects_can_see_flag(Engine.players(), _06a, 45F) == false && Engine.objects_distance_to_flag(Engine.players(), _06a) > 2F)
                        {
                            Engine.object_create_clone(extra06a);
                        }

                        if (Engine.list_count_not_dead(Engine.volume_return_objects_by_type(vol_stuck_06, 2)) == 0 && Engine.objects_can_see_flag(Engine.players(), _06b, 45F) == false && Engine.objects_distance_to_flag(Engine.players(), _06b) > 2F)
                        {
                            Engine.object_create_clone(extra06b);
                        }

                        return Engine.unit_in_vehicle(await this.player0()) == true;
                    });
                }

                if (Engine.volume_test_object(vol_stuck_07, await this.player0()) == true && Engine.list_count_not_dead(Engine.volume_return_objects_by_type(vol_stuck_07, 2)) == 0)
                {
                    await Engine.sleep_until(async () =>
                    {
                        if (Engine.list_count_not_dead(Engine.volume_return_objects_by_type(vol_stuck_07, 2)) == 0 && Engine.objects_can_see_flag(Engine.players(), _07a, 45F) == false && Engine.objects_distance_to_flag(Engine.players(), _07a) > 2F)
                        {
                            Engine.object_create_clone(extra07a);
                        }

                        if (Engine.list_count_not_dead(Engine.volume_return_objects_by_type(vol_stuck_07, 2)) == 0 && Engine.objects_can_see_flag(Engine.players(), _07b, 45F) == false && Engine.objects_distance_to_flag(Engine.players(), _07b) > 2F)
                        {
                            Engine.object_create_clone(extra07b);
                        }

                        if (Engine.list_count_not_dead(Engine.volume_return_objects_by_type(vol_stuck_07, 2)) == 0 && Engine.objects_can_see_flag(Engine.players(), _07c, 45F) == false && Engine.objects_distance_to_flag(Engine.players(), _07c) > 2F)
                        {
                            Engine.object_create_clone(extra07c);
                        }

                        return Engine.unit_in_vehicle(await this.player0()) == true;
                    });
                }

                if (Engine.volume_test_object(vol_stuck_08, await this.player0()) == true && Engine.list_count_not_dead(Engine.volume_return_objects_by_type(vol_stuck_08, 2)) == 0)
                {
                    await Engine.sleep_until(async () =>
                    {
                        if (Engine.list_count_not_dead(Engine.volume_return_objects_by_type(vol_stuck_08, 2)) == 0 && Engine.objects_can_see_flag(Engine.players(), _08a, 45F) == false && Engine.objects_distance_to_flag(Engine.players(), _08a) > 2F)
                        {
                            Engine.object_create_clone(extra08a);
                        }

                        if (Engine.list_count_not_dead(Engine.volume_return_objects_by_type(vol_stuck_08, 2)) == 0 && Engine.objects_can_see_flag(Engine.players(), _08b, 45F) == false && Engine.objects_distance_to_flag(Engine.players(), _08b) > 2F)
                        {
                            Engine.object_create_clone(extra08b);
                        }

                        return Engine.unit_in_vehicle(await this.player0()) == true;
                    });
                }

                if (Engine.volume_test_object(vol_stuck_09, await this.player0()) == true && Engine.list_count_not_dead(Engine.volume_return_objects_by_type(vol_stuck_09, 2)) == 0)
                {
                    await Engine.sleep_until(async () =>
                    {
                        if (Engine.list_count_not_dead(Engine.volume_return_objects_by_type(vol_stuck_09, 2)) == 0 && Engine.objects_can_see_flag(Engine.players(), _09a, 45F) == false && Engine.objects_distance_to_flag(Engine.players(), _09a) > 2F)
                        {
                            Engine.object_create_clone(extra09a);
                        }

                        if (Engine.list_count_not_dead(Engine.volume_return_objects_by_type(vol_stuck_09, 2)) == 0 && Engine.objects_can_see_flag(Engine.players(), _09b, 45F) == false && Engine.objects_distance_to_flag(Engine.players(), _09b) > 2F)
                        {
                            Engine.object_create_clone(extra09b);
                        }

                        return Engine.unit_in_vehicle(await this.player0()) == true;
                    });
                }

                if (Engine.volume_test_object(vol_stuck_10, await this.player0()) == true && Engine.list_count_not_dead(Engine.volume_return_objects_by_type(vol_stuck_10, 2)) == 0)
                {
                    await Engine.sleep_until(async () =>
                    {
                        if (Engine.list_count_not_dead(Engine.volume_return_objects_by_type(vol_stuck_10, 2)) == 0 && Engine.objects_can_see_flag(Engine.players(), _10a, 45F) == false && Engine.objects_distance_to_flag(Engine.players(), _10a) > 2F)
                        {
                            Engine.object_create_clone(extra10a);
                        }

                        if (Engine.list_count_not_dead(Engine.volume_return_objects_by_type(vol_stuck_10, 2)) == 0 && Engine.objects_can_see_flag(Engine.players(), _10b, 45F) == false && Engine.objects_distance_to_flag(Engine.players(), _10b) > 2F)
                        {
                            Engine.object_create_clone(extra10b);
                        }

                        return Engine.unit_in_vehicle(await this.player0()) == true;
                    });
                }

                if (Engine.volume_test_object(vol_stuck_11, await this.player0()) == true && Engine.list_count_not_dead(Engine.volume_return_objects_by_type(vol_stuck_11, 2)) == 0)
                {
                    await Engine.sleep_until(async () =>
                    {
                        if (Engine.list_count_not_dead(Engine.volume_return_objects_by_type(vol_stuck_11, 2)) == 0 && Engine.objects_can_see_flag(Engine.players(), _11a, 45F) == false && Engine.objects_distance_to_flag(Engine.players(), _11a) > 2F)
                        {
                            Engine.object_create_clone(extra11a);
                        }

                        if (Engine.list_count_not_dead(Engine.volume_return_objects_by_type(vol_stuck_11, 2)) == 0 && Engine.objects_can_see_flag(Engine.players(), _11b, 45F) == false && Engine.objects_distance_to_flag(Engine.players(), _11b) > 2F)
                        {
                            Engine.object_create_clone(extra11b);
                        }

                        if (Engine.list_count_not_dead(Engine.volume_return_objects_by_type(vol_stuck_11, 2)) == 0 && Engine.objects_can_see_flag(Engine.players(), _11c, 45F) == false && Engine.objects_distance_to_flag(Engine.players(), _11c) > 2F)
                        {
                            Engine.object_create_clone(extra11c);
                        }

                        return Engine.unit_in_vehicle(await this.player0()) == true;
                    });
                }

                if (Engine.volume_test_object(vol_stuck_12, await this.player0()) == true && Engine.list_count_not_dead(Engine.volume_return_objects_by_type(vol_stuck_12, 2)) == 0)
                {
                    await Engine.sleep_until(async () =>
                    {
                        if (Engine.list_count_not_dead(Engine.volume_return_objects_by_type(vol_stuck_12, 2)) == 0 && Engine.objects_can_see_flag(Engine.players(), _12a, 45F) == false && Engine.objects_distance_to_flag(Engine.players(), _12a) > 2F)
                        {
                            Engine.object_create_clone(extra12a);
                        }

                        if (Engine.list_count_not_dead(Engine.volume_return_objects_by_type(vol_stuck_12, 2)) == 0 && Engine.objects_can_see_flag(Engine.players(), _12b, 45F) == false && Engine.objects_distance_to_flag(Engine.players(), _12b) > 2F)
                        {
                            Engine.object_create_clone(extra12b);
                        }

                        if (Engine.list_count_not_dead(Engine.volume_return_objects_by_type(vol_stuck_12, 2)) == 0 && Engine.objects_can_see_flag(Engine.players(), _12c, 45F) == false && Engine.objects_distance_to_flag(Engine.players(), _12c) > 2F)
                        {
                            Engine.object_create_clone(extra12c);
                        }

                        return Engine.unit_in_vehicle(await this.player0()) == true;
                    });
                }

                if (Engine.volume_test_object(vol_stuck_13, await this.player0()) == true && Engine.list_count_not_dead(Engine.volume_return_objects_by_type(vol_stuck_13, 2)) == 0)
                {
                    await Engine.sleep_until(async () =>
                    {
                        if (Engine.list_count_not_dead(Engine.volume_return_objects_by_type(vol_stuck_13, 2)) == 0 && Engine.objects_can_see_flag(Engine.players(), _13a, 45F) == false && Engine.objects_distance_to_flag(Engine.players(), _13a) > 2F)
                        {
                            Engine.object_create_clone(extra13a);
                        }

                        if (Engine.list_count_not_dead(Engine.volume_return_objects_by_type(vol_stuck_13, 2)) == 0 && Engine.objects_can_see_flag(Engine.players(), _13b, 45F) == false && Engine.objects_distance_to_flag(Engine.players(), _13b) > 2F)
                        {
                            Engine.object_create_clone(extra13b);
                        }

                        if (Engine.list_count_not_dead(Engine.volume_return_objects_by_type(vol_stuck_13, 2)) == 0 && Engine.objects_can_see_flag(Engine.players(), _13c, 45F) == false && Engine.objects_distance_to_flag(Engine.players(), _13c) > 2F)
                        {
                            Engine.object_create_clone(extra13c);
                        }

                        return Engine.unit_in_vehicle(await this.player0()) == true;
                    });
                }

                if (Engine.volume_test_object(vol_stuck_14, await this.player0()) == true && Engine.list_count_not_dead(Engine.volume_return_objects_by_type(vol_stuck_14, 2)) == 0)
                {
                    await Engine.sleep_until(async () =>
                    {
                        if (Engine.list_count_not_dead(Engine.volume_return_objects_by_type(vol_stuck_14, 2)) == 0 && Engine.objects_can_see_flag(Engine.players(), _14a, 45F) == false && Engine.objects_distance_to_flag(Engine.players(), _14a) > 2F)
                        {
                            Engine.object_create_clone(extra14a);
                        }

                        if (Engine.list_count_not_dead(Engine.volume_return_objects_by_type(vol_stuck_14, 2)) == 0 && Engine.objects_can_see_flag(Engine.players(), _14b, 45F) == false && Engine.objects_distance_to_flag(Engine.players(), _14b) > 2F)
                        {
                            Engine.object_create_clone(extra14b);
                        }

                        return Engine.unit_in_vehicle(await this.player0()) == true;
                    });
                }

                if (Engine.volume_test_object(vol_stuck_15, await this.player0()) == true && Engine.list_count_not_dead(Engine.volume_return_objects_by_type(vol_stuck_15, 2)) == 0)
                {
                    await Engine.sleep_until(async () =>
                    {
                        if (Engine.list_count_not_dead(Engine.volume_return_objects_by_type(vol_stuck_15, 2)) == 0 && Engine.objects_can_see_flag(Engine.players(), _15a, 45F) == false && Engine.objects_distance_to_flag(Engine.players(), _15a) > 2F)
                        {
                            Engine.object_create_clone(extra15a);
                        }

                        if (Engine.list_count_not_dead(Engine.volume_return_objects_by_type(vol_stuck_15, 2)) == 0 && Engine.objects_can_see_flag(Engine.players(), _15b, 45F) == false && Engine.objects_distance_to_flag(Engine.players(), _15b) > 2F)
                        {
                            Engine.object_create_clone(extra15b);
                        }

                        return Engine.unit_in_vehicle(await this.player0()) == true;
                    });
                }

                return false;
            });
        }

        [ScriptMethod(349, Lifecycle.Dormant)]
        public async Task banshee_stuck_spawner_02()
        {
            await Engine.sleep_until(async () => Engine.unit_in_vehicle(await this.player1()) == true);
            await Engine.sleep_until(async () =>
            {
                await Engine.sleep_until(async () => Engine.unit_in_vehicle(await this.player1()) == false && Engine.volume_test_object(vol_arm_02_lz, await this.player1()) == false && await this.player_count() > 0);
                if (Engine.volume_test_object(vol_stuck_01, await this.player1()) == true && Engine.list_count_not_dead(Engine.volume_return_objects_by_type(vol_stuck_01, 2)) == 0)
                {
                    await Engine.sleep_until(async () =>
                    {
                        if (Engine.list_count_not_dead(Engine.volume_return_objects_by_type(vol_stuck_01, 2)) == 0 && Engine.objects_can_see_flag(Engine.players(), _01a, 45F) == false && Engine.objects_distance_to_flag(Engine.players(), _01a) > 2F)
                        {
                            Engine.object_create_clone(extra01a);
                        }

                        if (Engine.list_count_not_dead(Engine.volume_return_objects_by_type(vol_stuck_01, 2)) == 0 && Engine.objects_can_see_flag(Engine.players(), _01b, 45F) == false && Engine.objects_distance_to_flag(Engine.players(), _01b) > 2F)
                        {
                            Engine.object_create_clone(extra01b);
                        }

                        if (Engine.list_count_not_dead(Engine.volume_return_objects_by_type(vol_stuck_01, 2)) == 0 && Engine.objects_can_see_flag(Engine.players(), _01c, 45F) == false && Engine.objects_distance_to_flag(Engine.players(), _01c) > 2F)
                        {
                            Engine.object_create_clone(extra01c);
                        }

                        if (Engine.list_count_not_dead(Engine.volume_return_objects_by_type(vol_stuck_01, 2)) == 0 && Engine.objects_can_see_flag(Engine.players(), _01d, 45F) == false && Engine.objects_distance_to_flag(Engine.players(), _01d) > 2F)
                        {
                            Engine.object_create_clone(extra01d);
                        }

                        return Engine.unit_in_vehicle(await this.player1()) == true;
                    });
                }

                if (Engine.volume_test_object(vol_stuck_02, await this.player1()) == true && Engine.list_count_not_dead(Engine.volume_return_objects_by_type(vol_stuck_02, 2)) == 0)
                {
                    await Engine.sleep_until(async () =>
                    {
                        if (Engine.list_count_not_dead(Engine.volume_return_objects_by_type(vol_stuck_02, 2)) == 0 && Engine.objects_can_see_flag(Engine.players(), _02a, 45F) == false && Engine.objects_distance_to_flag(Engine.players(), _02a) > 2F)
                        {
                            Engine.object_create_clone(extra02a);
                        }

                        if (Engine.list_count_not_dead(Engine.volume_return_objects_by_type(vol_stuck_02, 2)) == 0 && Engine.objects_can_see_flag(Engine.players(), _02b, 45F) == false && Engine.objects_distance_to_flag(Engine.players(), _02b) > 2F)
                        {
                            Engine.object_create_clone(extra02b);
                        }

                        if (Engine.list_count_not_dead(Engine.volume_return_objects_by_type(vol_stuck_02, 2)) == 0 && Engine.objects_can_see_flag(Engine.players(), _02c, 45F) == false && Engine.objects_distance_to_flag(Engine.players(), _02c) > 2F)
                        {
                            Engine.object_create_clone(extra02c);
                        }

                        if (Engine.list_count_not_dead(Engine.volume_return_objects_by_type(vol_stuck_02, 2)) == 0 && Engine.objects_can_see_flag(Engine.players(), _02d, 45F) == false && Engine.objects_distance_to_flag(Engine.players(), _02d) > 2F)
                        {
                            Engine.object_create_clone(extra02d);
                        }

                        return Engine.unit_in_vehicle(await this.player1()) == true;
                    });
                }

                if (Engine.volume_test_object(vol_stuck_03, await this.player1()) == true && Engine.list_count_not_dead(Engine.volume_return_objects_by_type(vol_stuck_03, 2)) == 0)
                {
                    await Engine.sleep_until(async () =>
                    {
                        if (Engine.list_count_not_dead(Engine.volume_return_objects_by_type(vol_stuck_03, 2)) == 0 && Engine.objects_can_see_flag(Engine.players(), _03a, 45F) == false && Engine.objects_distance_to_flag(Engine.players(), _03a) > 2F)
                        {
                            Engine.object_create_clone(extra03a);
                        }

                        if (Engine.list_count_not_dead(Engine.volume_return_objects_by_type(vol_stuck_03, 2)) == 0 && Engine.objects_can_see_flag(Engine.players(), _03b, 45F) == false && Engine.objects_distance_to_flag(Engine.players(), _03b) > 2F)
                        {
                            Engine.object_create_clone(extra03b);
                        }

                        if (Engine.list_count_not_dead(Engine.volume_return_objects_by_type(vol_stuck_03, 2)) == 0 && Engine.objects_can_see_flag(Engine.players(), _03c, 45F) == false && Engine.objects_distance_to_flag(Engine.players(), _03c) > 2F)
                        {
                            Engine.object_create_clone(extra03c);
                        }

                        return Engine.unit_in_vehicle(await this.player1()) == true;
                    });
                }

                if (Engine.volume_test_object(vol_stuck_04, await this.player1()) == true && Engine.list_count_not_dead(Engine.volume_return_objects_by_type(vol_stuck_04, 2)) == 0)
                {
                    await Engine.sleep_until(async () =>
                    {
                        if (Engine.list_count_not_dead(Engine.volume_return_objects_by_type(vol_stuck_04, 2)) == 0 && Engine.objects_can_see_flag(Engine.players(), _04a, 45F) == false && Engine.objects_distance_to_flag(Engine.players(), _04a) > 2F)
                        {
                            Engine.object_create_clone(extra04a);
                        }

                        if (Engine.list_count_not_dead(Engine.volume_return_objects_by_type(vol_stuck_04, 2)) == 0 && Engine.objects_can_see_flag(Engine.players(), _04b, 45F) == false && Engine.objects_distance_to_flag(Engine.players(), _04b) > 2F)
                        {
                            Engine.object_create_clone(extra04b);
                        }

                        return Engine.unit_in_vehicle(await this.player1()) == true;
                    });
                }

                if (Engine.volume_test_object(vol_stuck_05, await this.player1()) == true && Engine.list_count_not_dead(Engine.volume_return_objects_by_type(vol_stuck_05, 2)) == 0)
                {
                    await Engine.sleep_until(async () =>
                    {
                        if (Engine.list_count_not_dead(Engine.volume_return_objects_by_type(vol_stuck_05, 2)) == 0 && Engine.objects_can_see_flag(Engine.players(), _05a, 45F) == false && Engine.objects_distance_to_flag(Engine.players(), _05a) > 2F)
                        {
                            Engine.object_create_clone(extra05a);
                        }

                        if (Engine.list_count_not_dead(Engine.volume_return_objects_by_type(vol_stuck_05, 2)) == 0 && Engine.objects_can_see_flag(Engine.players(), _05b, 45F) == false && Engine.objects_distance_to_flag(Engine.players(), _05b) > 2F)
                        {
                            Engine.object_create_clone(extra05b);
                        }

                        return Engine.unit_in_vehicle(await this.player1()) == true;
                    });
                }

                if (Engine.volume_test_object(vol_stuck_06, await this.player1()) == true && Engine.list_count_not_dead(Engine.volume_return_objects_by_type(vol_stuck_06, 2)) == 0)
                {
                    await Engine.sleep_until(async () =>
                    {
                        if (Engine.list_count_not_dead(Engine.volume_return_objects_by_type(vol_stuck_06, 2)) == 0 && Engine.objects_can_see_flag(Engine.players(), _06a, 45F) == false && Engine.objects_distance_to_flag(Engine.players(), _06a) > 2F)
                        {
                            Engine.object_create_clone(extra06a);
                        }

                        if (Engine.list_count_not_dead(Engine.volume_return_objects_by_type(vol_stuck_06, 2)) == 0 && Engine.objects_can_see_flag(Engine.players(), _06b, 45F) == false && Engine.objects_distance_to_flag(Engine.players(), _06b) > 2F)
                        {
                            Engine.object_create_clone(extra06b);
                        }

                        return Engine.unit_in_vehicle(await this.player1()) == true;
                    });
                }

                if (Engine.volume_test_object(vol_stuck_07, await this.player1()) == true && Engine.list_count_not_dead(Engine.volume_return_objects_by_type(vol_stuck_07, 2)) == 0)
                {
                    await Engine.sleep_until(async () =>
                    {
                        if (Engine.list_count_not_dead(Engine.volume_return_objects_by_type(vol_stuck_07, 2)) == 0 && Engine.objects_can_see_flag(Engine.players(), _07a, 45F) == false && Engine.objects_distance_to_flag(Engine.players(), _07a) > 2F)
                        {
                            Engine.object_create_clone(extra07a);
                        }

                        if (Engine.list_count_not_dead(Engine.volume_return_objects_by_type(vol_stuck_07, 2)) == 0 && Engine.objects_can_see_flag(Engine.players(), _07b, 45F) == false && Engine.objects_distance_to_flag(Engine.players(), _07b) > 2F)
                        {
                            Engine.object_create_clone(extra07b);
                        }

                        if (Engine.list_count_not_dead(Engine.volume_return_objects_by_type(vol_stuck_07, 2)) == 0 && Engine.objects_can_see_flag(Engine.players(), _07c, 45F) == false && Engine.objects_distance_to_flag(Engine.players(), _07c) > 2F)
                        {
                            Engine.object_create_clone(extra07c);
                        }

                        return Engine.unit_in_vehicle(await this.player1()) == true;
                    });
                }

                if (Engine.volume_test_object(vol_stuck_08, await this.player1()) == true && Engine.list_count_not_dead(Engine.volume_return_objects_by_type(vol_stuck_08, 2)) == 0)
                {
                    await Engine.sleep_until(async () =>
                    {
                        if (Engine.list_count_not_dead(Engine.volume_return_objects_by_type(vol_stuck_08, 2)) == 0 && Engine.objects_can_see_flag(Engine.players(), _08a, 45F) == false && Engine.objects_distance_to_flag(Engine.players(), _08a) > 2F)
                        {
                            Engine.object_create_clone(extra08a);
                        }

                        if (Engine.list_count_not_dead(Engine.volume_return_objects_by_type(vol_stuck_08, 2)) == 0 && Engine.objects_can_see_flag(Engine.players(), _08b, 45F) == false && Engine.objects_distance_to_flag(Engine.players(), _08b) > 2F)
                        {
                            Engine.object_create_clone(extra08b);
                        }

                        return Engine.unit_in_vehicle(await this.player1()) == true;
                    });
                }

                if (Engine.volume_test_object(vol_stuck_09, await this.player1()) == true && Engine.list_count_not_dead(Engine.volume_return_objects_by_type(vol_stuck_09, 2)) == 0)
                {
                    await Engine.sleep_until(async () =>
                    {
                        if (Engine.list_count_not_dead(Engine.volume_return_objects_by_type(vol_stuck_09, 2)) == 0 && Engine.objects_can_see_flag(Engine.players(), _09a, 45F) == false && Engine.objects_distance_to_flag(Engine.players(), _09a) > 2F)
                        {
                            Engine.object_create_clone(extra09a);
                        }

                        if (Engine.list_count_not_dead(Engine.volume_return_objects_by_type(vol_stuck_09, 2)) == 0 && Engine.objects_can_see_flag(Engine.players(), _09b, 45F) == false && Engine.objects_distance_to_flag(Engine.players(), _09b) > 2F)
                        {
                            Engine.object_create_clone(extra09b);
                        }

                        return Engine.unit_in_vehicle(await this.player1()) == true;
                    });
                }

                if (Engine.volume_test_object(vol_stuck_10, await this.player1()) == true && Engine.list_count_not_dead(Engine.volume_return_objects_by_type(vol_stuck_10, 2)) == 0)
                {
                    await Engine.sleep_until(async () =>
                    {
                        if (Engine.list_count_not_dead(Engine.volume_return_objects_by_type(vol_stuck_10, 2)) == 0 && Engine.objects_can_see_flag(Engine.players(), _10a, 45F) == false && Engine.objects_distance_to_flag(Engine.players(), _10a) > 2F)
                        {
                            Engine.object_create_clone(extra10a);
                        }

                        if (Engine.list_count_not_dead(Engine.volume_return_objects_by_type(vol_stuck_10, 2)) == 0 && Engine.objects_can_see_flag(Engine.players(), _10b, 45F) == false && Engine.objects_distance_to_flag(Engine.players(), _10b) > 2F)
                        {
                            Engine.object_create_clone(extra10b);
                        }

                        return Engine.unit_in_vehicle(await this.player1()) == true;
                    });
                }

                if (Engine.volume_test_object(vol_stuck_11, await this.player1()) == true && Engine.list_count_not_dead(Engine.volume_return_objects_by_type(vol_stuck_11, 2)) == 0)
                {
                    await Engine.sleep_until(async () =>
                    {
                        if (Engine.list_count_not_dead(Engine.volume_return_objects_by_type(vol_stuck_11, 2)) == 0 && Engine.objects_can_see_flag(Engine.players(), _11a, 45F) == false && Engine.objects_distance_to_flag(Engine.players(), _11a) > 2F)
                        {
                            Engine.object_create_clone(extra11a);
                        }

                        if (Engine.list_count_not_dead(Engine.volume_return_objects_by_type(vol_stuck_11, 2)) == 0 && Engine.objects_can_see_flag(Engine.players(), _11b, 45F) == false && Engine.objects_distance_to_flag(Engine.players(), _11b) > 2F)
                        {
                            Engine.object_create_clone(extra11b);
                        }

                        if (Engine.list_count_not_dead(Engine.volume_return_objects_by_type(vol_stuck_11, 2)) == 0 && Engine.objects_can_see_flag(Engine.players(), _11c, 45F) == false && Engine.objects_distance_to_flag(Engine.players(), _11c) > 2F)
                        {
                            Engine.object_create_clone(extra11c);
                        }

                        return Engine.unit_in_vehicle(await this.player1()) == true;
                    });
                }

                if (Engine.volume_test_object(vol_stuck_12, await this.player1()) == true && Engine.list_count_not_dead(Engine.volume_return_objects_by_type(vol_stuck_12, 2)) == 0)
                {
                    await Engine.sleep_until(async () =>
                    {
                        if (Engine.list_count_not_dead(Engine.volume_return_objects_by_type(vol_stuck_12, 2)) == 0 && Engine.objects_can_see_flag(Engine.players(), _12a, 45F) == false && Engine.objects_distance_to_flag(Engine.players(), _12a) > 2F)
                        {
                            Engine.object_create_clone(extra12a);
                        }

                        if (Engine.list_count_not_dead(Engine.volume_return_objects_by_type(vol_stuck_12, 2)) == 0 && Engine.objects_can_see_flag(Engine.players(), _12b, 45F) == false && Engine.objects_distance_to_flag(Engine.players(), _12b) > 2F)
                        {
                            Engine.object_create_clone(extra12b);
                        }

                        if (Engine.list_count_not_dead(Engine.volume_return_objects_by_type(vol_stuck_12, 2)) == 0 && Engine.objects_can_see_flag(Engine.players(), _12c, 45F) == false && Engine.objects_distance_to_flag(Engine.players(), _12c) > 2F)
                        {
                            Engine.object_create_clone(extra12c);
                        }

                        return Engine.unit_in_vehicle(await this.player1()) == true;
                    });
                }

                if (Engine.volume_test_object(vol_stuck_13, await this.player1()) == true && Engine.list_count_not_dead(Engine.volume_return_objects_by_type(vol_stuck_13, 2)) == 0)
                {
                    await Engine.sleep_until(async () =>
                    {
                        if (Engine.list_count_not_dead(Engine.volume_return_objects_by_type(vol_stuck_13, 2)) == 0 && Engine.objects_can_see_flag(Engine.players(), _13a, 45F) == false && Engine.objects_distance_to_flag(Engine.players(), _13a) > 2F)
                        {
                            Engine.object_create_clone(extra13a);
                        }

                        if (Engine.list_count_not_dead(Engine.volume_return_objects_by_type(vol_stuck_13, 2)) == 0 && Engine.objects_can_see_flag(Engine.players(), _13b, 45F) == false && Engine.objects_distance_to_flag(Engine.players(), _13b) > 2F)
                        {
                            Engine.object_create_clone(extra13b);
                        }

                        if (Engine.list_count_not_dead(Engine.volume_return_objects_by_type(vol_stuck_13, 2)) == 0 && Engine.objects_can_see_flag(Engine.players(), _13c, 45F) == false && Engine.objects_distance_to_flag(Engine.players(), _13c) > 2F)
                        {
                            Engine.object_create_clone(extra13c);
                        }

                        return Engine.unit_in_vehicle(await this.player1()) == true;
                    });
                }

                if (Engine.volume_test_object(vol_stuck_14, await this.player1()) == true && Engine.list_count_not_dead(Engine.volume_return_objects_by_type(vol_stuck_14, 2)) == 0)
                {
                    await Engine.sleep_until(async () =>
                    {
                        if (Engine.list_count_not_dead(Engine.volume_return_objects_by_type(vol_stuck_14, 2)) == 0 && Engine.objects_can_see_flag(Engine.players(), _14a, 45F) == false && Engine.objects_distance_to_flag(Engine.players(), _14a) > 2F)
                        {
                            Engine.object_create_clone(extra14a);
                        }

                        if (Engine.list_count_not_dead(Engine.volume_return_objects_by_type(vol_stuck_14, 2)) == 0 && Engine.objects_can_see_flag(Engine.players(), _14b, 45F) == false && Engine.objects_distance_to_flag(Engine.players(), _14b) > 2F)
                        {
                            Engine.object_create_clone(extra14b);
                        }

                        return Engine.unit_in_vehicle(await this.player1()) == true;
                    });
                }

                if (Engine.volume_test_object(vol_stuck_15, await this.player1()) == true && Engine.list_count_not_dead(Engine.volume_return_objects_by_type(vol_stuck_15, 2)) == 0)
                {
                    await Engine.sleep_until(async () =>
                    {
                        if (Engine.list_count_not_dead(Engine.volume_return_objects_by_type(vol_stuck_15, 2)) == 0 && Engine.objects_can_see_flag(Engine.players(), _15a, 45F) == false && Engine.objects_distance_to_flag(Engine.players(), _15a) > 2F)
                        {
                            Engine.object_create_clone(extra15a);
                        }

                        if (Engine.list_count_not_dead(Engine.volume_return_objects_by_type(vol_stuck_15, 2)) == 0 && Engine.objects_can_see_flag(Engine.players(), _15b, 45F) == false && Engine.objects_distance_to_flag(Engine.players(), _15b) > 2F)
                        {
                            Engine.object_create_clone(extra15b);
                        }

                        return Engine.unit_in_vehicle(await this.player1()) == true;
                    });
                }

                return false;
            });
        }

        [ScriptMethod(350, Lifecycle.CommandScript)]
        public async Task phantom_path()
        {
            Engine.cs_enable_pathfinding_failsafe(true);
            Engine.cs_vehicle_speed(0.1F);
            Engine.cs_fly_by(Engine.GetReference<ISpatialPoint>("airspace/ph01"), 10F);
            this.phantom_course_pos = 1;
            Engine.cs_fly_by(Engine.GetReference<ISpatialPoint>("airspace/ph02"), 10F);
            this.phantom_course_pos = 2;
            Engine.cs_fly_by(Engine.GetReference<ISpatialPoint>("airspace/ph03"), 10F);
            this.phantom_course_pos = 3;
            Engine.cs_fly_by(Engine.GetReference<ISpatialPoint>("airspace/ph04"), 10F);
            this.phantom_course_pos = 4;
            Engine.cs_fly_by(Engine.GetReference<ISpatialPoint>("airspace/ph05"), 10F);
            this.phantom_course_pos = 5;
            Engine.cs_fly_by(Engine.GetReference<ISpatialPoint>("airspace/ph06"), 10F);
            this.phantom_course_pos = 6;
            Engine.cs_fly_by(Engine.GetReference<ISpatialPoint>("airspace/ph07"), 10F);
            this.phantom_course_pos = 7;
            Engine.cs_fly_by(Engine.GetReference<ISpatialPoint>("airspace/ph08"), 10F);
            this.phantom_course_pos = 8;
            Engine.cs_fly_by(Engine.GetReference<ISpatialPoint>("airspace/ph09"), 10F);
            this.phantom_course_pos = 9;
            Engine.cs_fly_by(Engine.GetReference<ISpatialPoint>("airspace/ph10"), 10F);
            this.phantom_course_pos = 10;
            Engine.cs_fly_by(Engine.GetReference<ISpatialPoint>("airspace/ph11"), 10F);
            this.phantom_course_pos = 11;
            Engine.cs_vehicle_speed(0.05F);
            Engine.cs_fly_by(Engine.GetReference<ISpatialPoint>("airspace/ph12"), 10F);
            this.phantom_course_pos = 12;
            Engine.cs_fly_to(Engine.GetReference<ISpatialPoint>("airspace/ph13"), 5F);
            this.phantom_course_pos = 13;
            Engine.cs_pause(-1F);
        }

        [ScriptMethod(351, Lifecycle.CommandScript)]
        public async Task arm02_swat_aim_00()
        {
            Engine.cs_abort_on_damage(true);
            Engine.cs_enable_pathfinding_failsafe(true);
            Engine.cs_go_to(Engine.GetReference<ISpatialPoint>("arm02_lz/p0"));
            Engine.cs_aim(true, Engine.GetReference<ISpatialPoint>("arm02_lz/door"));
            Engine.sleep_forever();
        }

        [ScriptMethod(352, Lifecycle.CommandScript)]
        public async Task arm02_swat_aim_01()
        {
            Engine.cs_abort_on_damage(true);
            Engine.cs_enable_pathfinding_failsafe(true);
            Engine.cs_go_to(Engine.GetReference<ISpatialPoint>("arm02_lz/p1"));
            Engine.cs_aim(true, Engine.GetReference<ISpatialPoint>("arm02_lz/door"));
            Engine.sleep_forever();
        }

        [ScriptMethod(353, Lifecycle.CommandScript)]
        public async Task arm02_swat_aim_02()
        {
            Engine.cs_abort_on_damage(true);
            Engine.cs_enable_pathfinding_failsafe(true);
            Engine.cs_go_to(Engine.GetReference<ISpatialPoint>("arm02_lz/p2"));
            Engine.cs_aim(true, Engine.GetReference<ISpatialPoint>("arm02_lz/door"));
            Engine.sleep_forever();
        }

        [ScriptMethod(354, Lifecycle.CommandScript)]
        public async Task arm02_swat_aim_03()
        {
            Engine.cs_abort_on_damage(true);
            Engine.cs_enable_pathfinding_failsafe(true);
            Engine.cs_go_to(Engine.GetReference<ISpatialPoint>("arm02_lz/p3"));
            Engine.cs_aim(true, Engine.GetReference<ISpatialPoint>("arm02_lz/door"));
            Engine.sleep_forever();
        }

        [ScriptMethod(355, Lifecycle.CommandScript)]
        public async Task arm02_final_approach()
        {
            Engine.cs_enable_pathfinding_failsafe(true);
            Engine.cs_vehicle_speed(0.5F);
            Engine.cs_fly_to(Engine.GetReference<ISpatialPoint>("airspace/ph13"), 2F);
            await Engine.sleep(60);
            Engine.vehicle_unload(Engine.ai_vehicle_get_from_starting_location(allied_phantom_01.driver), "phantom_p_a01");
            await Engine.sleep(30);
            Engine.vehicle_unload(Engine.ai_vehicle_get_from_starting_location(allied_phantom_01.driver), "phantom_p_a02");
            await Engine.sleep(30);
            Engine.vehicle_unload(Engine.ai_vehicle_get_from_starting_location(allied_phantom_01.driver), "phantom_p_a03");
            Engine.cs_run_command_script(allies_elites_03.elite01, arm02_swat_aim_00);
            Engine.cs_run_command_script(allies_elites_03.elite02, arm02_swat_aim_01);
            await Engine.sleep(30);
            Engine.vehicle_unload(Engine.ai_vehicle_get_from_starting_location(allied_phantom_01.driver), "phantom_p_b01");
            await Engine.sleep(30);
            Engine.vehicle_unload(Engine.ai_vehicle_get_from_starting_location(allied_phantom_01.driver), "phantom_p_b02");
            await Engine.sleep(30);
            Engine.vehicle_unload(Engine.ai_vehicle_get_from_starting_location(allied_phantom_01.driver), "phantom_p_b03");
            Engine.cs_run_command_script(allies_grunts_03.grunt01, arm02_swat_aim_02);
            Engine.cs_run_command_script(allies_grunts_03.grunt02, arm02_swat_aim_03);
            Engine.cs_pause(-1F);
        }

        [ScriptMethod(356, Lifecycle.Dormant)]
        public async Task dogfight_search_reminder()
        {
            Engine.ai_dialogue_enable(false);
            await Engine.sleep(60);
            Engine.print("spec-ops commander: 'no sign of the heretic-leader or his banshee. we must keep searching!'");
            await Engine.sleep(Engine.ai_play_line_on_object(default(IGameObject), "1210"));
            await Engine.sleep(30);
            Engine.ai_dialogue_enable(true);
        }

        [ScriptMethod(357, Lifecycle.Dormant)]
        public async Task dogfight_ph_pilot_talk()
        {
            Engine.begin_random(async () => await Engine.sleep_until(async () => this.dogfight_ph_pilot_go == true), 
                async () => this.dogfight_ph_pilot_go = false, 
                async () => Engine.ai_dialogue_enable(false), 
                async () => await Engine.sleep(60), 
                async () => Engine.print("phantom pilot: 'emplacement destroyed! heading to the next target!'"), 
                async () => await Engine.sleep(Engine.ai_play_line_on_object(default(IGameObject), "2050")), 
                async () => await Engine.sleep(30), 
                async () => Engine.ai_dialogue_enable(true), 
                async () => await Engine.sleep_until(async () => this.dogfight_ph_pilot_go == true), 
                async () => this.dogfight_ph_pilot_go = false, 
                async () => Engine.ai_dialogue_enable(false), 
                async () => await Engine.sleep(60), 
                async () => Engine.print("phantom pilot: 'all heretic forces have been eliminated! moving on!'"), 
                async () => await Engine.sleep(Engine.ai_play_line_on_object(default(IGameObject), "2060")), 
                async () => await Engine.sleep(30), 
                async () => Engine.ai_dialogue_enable(true), 
                async () => await Engine.sleep_until(async () => this.dogfight_ph_pilot_go == true), 
                async () => this.dogfight_ph_pilot_go = false, 
                async () => Engine.ai_dialogue_enable(false), 
                async () => await Engine.sleep(60), 
                async () => Engine.print("phantom pilot: 'this area is clear! let us continue!'"), 
                async () => await Engine.sleep(Engine.ai_play_line_on_object(default(IGameObject), "2070")), 
                async () => await Engine.sleep(30), 
                async () => Engine.ai_dialogue_enable(true), 
                async () => await Engine.sleep_until(async () => this.dogfight_ph_pilot_go == true), 
                async () => this.dogfight_ph_pilot_go = false, 
                async () => Engine.ai_dialogue_enable(false), 
                async () => await Engine.sleep(60), 
                async () => Engine.print("phantom pilot: 'that is the last of them! but there are more ahead!'"), 
                async () => await Engine.sleep(Engine.ai_play_line_on_object(default(IGameObject), "2080")), 
                async () => await Engine.sleep(30), 
                async () => Engine.ai_dialogue_enable(true), 
                async () => await Engine.sleep_until(async () => this.dogfight_ph_pilot_go == true), 
                async () => this.dogfight_ph_pilot_go = false, 
                async () => Engine.ai_dialogue_enable(false), 
                async () => await Engine.sleep(60), 
                async () => Engine.print("phantom pilot: 'these heretics are dead. onward!'"), 
                async () => await Engine.sleep(Engine.ai_play_line_on_object(default(IGameObject), "2090")), 
                async () => await Engine.sleep(30), 
                async () => Engine.ai_dialogue_enable(true), 
                async () => await Engine.sleep_until(async () => this.dogfight_ph_pilot_go == true), 
                async () => this.dogfight_ph_pilot_go = false, 
                async () => Engine.ai_dialogue_enable(false), 
                async () => await Engine.sleep(60), 
                async () => Engine.print("phantom pilot: 'follow me, arbiter! i have found another emplacement!'"), 
                async () => await Engine.sleep(Engine.ai_play_line_on_object(default(IGameObject), "2100")), 
                async () => await Engine.sleep(30), 
                async () => Engine.ai_dialogue_enable(true), 
                async () => await Engine.sleep_until(async () => this.dogfight_ph_pilot_go == true), 
                async () => this.dogfight_ph_pilot_go = false, 
                async () => Engine.ai_dialogue_enable(false), 
                async () => await Engine.sleep(60), 
                async () => Engine.print("phantom pilot: 'this way, arbiter! i see another heretic position!'"), 
                async () => await Engine.sleep(Engine.ai_play_line_on_object(default(IGameObject), "2110")), 
                async () => await Engine.sleep(30), 
                async () => Engine.ai_dialogue_enable(true), 
                async () => await Engine.sleep_until(async () => this.dogfight_ph_pilot_go == true), 
                async () => this.dogfight_ph_pilot_go = false, 
                async () => Engine.ai_dialogue_enable(false), 
                async () => await Engine.sleep(60), 
                async () => Engine.print("phantom pilot: 'do you see, arbiter? more heretics have gathered there!'"), 
                async () => await Engine.sleep(Engine.ai_play_line_on_object(default(IGameObject), "2120")), 
                async () => await Engine.sleep(30), 
                async () => Engine.ai_dialogue_enable(true));
        }

        [ScriptMethod(358, Lifecycle.CommandScript)]
        public async Task boost_test()
        {
            Engine.cs_vehicle_boost(true);
            Engine.cs_enable_targeting(true);
            Engine.cs_shoot(true);
            Engine.cs_enable_moving(true);
            await Engine.sleep_until(async () => Engine.objects_distance_to_object(Engine.players(), Engine.ai_get_object(this.ai_current_actor)) < 50F || Engine.objects_distance_to_object(Engine.ai_actors(allied_phantom_01.Squad), Engine.ai_get_object(this.ai_current_actor)) < 50F);
        }

        [ScriptMethod(359, Lifecycle.Dormant)]
        public async Task banshee_fight_saving()
        {
            await Engine.sleep_until(async () =>
            {
                await Engine.sleep_until(async () => this.try_to_save_now == true);
                await Engine.sleep_until(async () => Engine.unit_in_vehicle(Engine.unit(await this.player0())) && Engine.unit_in_vehicle(Engine.unit(await this.player1())) || (bool)Engine.game_is_cooperative() == false && (bool)Engine.game_safe_to_save());
                Engine.game_save_immediate();
                this.try_to_save_now = false;
                return this.dogfight_over == true;
            });
        }

        [ScriptMethod(360, Lifecycle.Dormant)]
        public async Task phantom_path_w_orders()
        {
            Engine.wake(new ScriptMethodReference(banshee_fight_saving));
            Engine.cs_run_command_script(allied_phantom_01.driver, abort);
            Engine.ai_set_orders(allied_phantom_01.Squad, dog_ph_obj_01);
            Engine.wake(new ScriptMethodReference(dogfight_ph_pilot_talk));
            await Engine.sleep(30);
            await Engine.sleep_until(async () => this.emplace_01_done == true, 30, 4000);
            await Engine.sleep_until(async () => (bool)Engine.ai_trigger_test("done_fighting", dog_obj_emplaced_01) == true, 30, 2000);
            Engine.print("cleared");
            await Engine.sleep(150);
            Engine.ai_set_orders(allied_phantom_01.Squad, dog_ph_obj_02);
            Engine.game_save_no_timeout();
            this.dogfighters_spawned = 0;
            await Engine.sleep_until(async () =>
            {
                if (Engine.objects_can_see_flag(Engine.players(), spawn_pt_03, 90F) == false && (short)Engine.ai_living_count(dogfighters_01) < 2)
                {
                    Engine.ai_place(dogfight_enemies.pt_03);
                    this.dogfighters_spawned = (short)(this.dogfighters_spawned + 1);
                    Engine.ai_set_orders(dogfight_enemies.Squad, dogfight01_cell_02);
                    await Engine.sleep(60);
                    Engine.ai_magically_see(dogfight_enemies.Squad, allied_phantom_01.Squad);
                    Engine.cs_run_command_script(dogfight_enemies.pt_03, boost_test);
                }

                if (Engine.objects_can_see_flag(Engine.players(), spawn_pt_01, 90F) == false && (short)Engine.ai_living_count(dogfighters_01) < 2)
                {
                    Engine.ai_place(dogfight_enemies.pt_01);
                    this.dogfighters_spawned = (short)(this.dogfighters_spawned + 1);
                    Engine.ai_set_orders(dogfight_enemies.Squad, dogfight01_cell_02);
                    await Engine.sleep(60);
                    Engine.ai_magically_see(dogfight_enemies.Squad, allied_phantom_01.Squad);
                    Engine.cs_run_command_script(dogfight_enemies.pt_01, boost_test);
                }

                if (Engine.objects_can_see_flag(Engine.players(), spawn_pt_02, 90F) == false && (short)Engine.ai_living_count(dogfighters_01) < 2)
                {
                    Engine.ai_place(dogfight_enemies.pt_02);
                    this.dogfighters_spawned = (short)(this.dogfighters_spawned + 1);
                    Engine.ai_set_orders(dogfight_enemies.Squad, dogfight01_cell_02);
                    await Engine.sleep(60);
                    Engine.ai_magically_see(dogfight_enemies.Squad, allied_phantom_01.Squad);
                    Engine.cs_run_command_script(dogfight_enemies.pt_02, boost_test);
                }

                await Engine.sleep_until(async () => Engine.volume_test_objects(vol_dog_obj_02, Engine.ai_actors(allied_phantom_01.Squad)) == true || (short)Engine.ai_living_count(dogfighters_01) < 2);
                return Engine.volume_test_objects(vol_dog_obj_02, Engine.ai_actors(allied_phantom_01.Squad)) == true || this.dogfighters_spawned > 3;
            }, 30, 4000);
            Engine.ai_set_orders(allied_phantom_01.Squad, dog_ph_obj_03);
            Engine.game_save_no_timeout();
            this.dogfighters_spawned = 0;
            await Engine.sleep_until(async () =>
            {
                if (Engine.objects_can_see_flag(Engine.players(), spawn_pt_05, 90F) == false && (short)Engine.ai_living_count(dogfighters_01) < 2)
                {
                    Engine.ai_place(dogfight_enemies.pt_05);
                    this.dogfighters_spawned = (short)(this.dogfighters_spawned + 1);
                    Engine.ai_set_orders(dogfight_enemies.Squad, dogfight01_cell_03);
                    await Engine.sleep(60);
                    Engine.ai_magically_see(dogfight_enemies.Squad, allied_phantom_01.Squad);
                    Engine.cs_run_command_script(dogfight_enemies.pt_05, boost_test);
                }

                if (Engine.objects_can_see_flag(Engine.players(), spawn_pt_03, 90F) == false && (short)Engine.ai_living_count(dogfighters_01) < 2)
                {
                    Engine.ai_place(dogfight_enemies.pt_03);
                    this.dogfighters_spawned = (short)(this.dogfighters_spawned + 1);
                    Engine.ai_set_orders(dogfight_enemies.Squad, dogfight01_cell_03);
                    await Engine.sleep(60);
                    Engine.ai_magically_see(dogfight_enemies.Squad, allied_phantom_01.Squad);
                    Engine.cs_run_command_script(dogfight_enemies.pt_03, boost_test);
                }

                if (Engine.objects_can_see_flag(Engine.players(), spawn_pt_04, 90F) == false && (short)Engine.ai_living_count(dogfighters_01) < 2)
                {
                    Engine.ai_place(dogfight_enemies.pt_04);
                    this.dogfighters_spawned = (short)(this.dogfighters_spawned + 1);
                    Engine.ai_set_orders(dogfight_enemies.Squad, dogfight01_cell_03);
                    await Engine.sleep(60);
                    Engine.ai_magically_see(dogfight_enemies.Squad, allied_phantom_01.Squad);
                    Engine.cs_run_command_script(dogfight_enemies.pt_04, boost_test);
                }

                await Engine.sleep_until(async () => Engine.volume_test_objects(vol_dog_obj_03, Engine.players()) == true || Engine.volume_test_objects(vol_dog_obj_03, Engine.ai_actors(allied_phantom_01.Squad)) == true || (short)Engine.ai_living_count(dogfighters_01) < 2);
                return Engine.volume_test_objects(vol_dog_obj_03, Engine.players()) == true || Engine.volume_test_objects(vol_dog_obj_03, Engine.ai_actors(allied_phantom_01.Squad)) == true || this.dogfighters_spawned > 3;
            }, 30, 4000);
            await Engine.sleep(30);
            await Engine.sleep_until(async () => this.emplace_03_done == true, 30, 1800);
            await Engine.sleep_until(async () => (bool)Engine.ai_trigger_test("done_fighting", dog_obj_emplaced_03) == true, 30, 1800);
            Engine.print("cleared");
            await Engine.sleep(30);
            if (Engine.volume_test_objects(vol_dog_obj_04, Engine.players()) == false)
            {
                this.dogfight_ph_pilot_go = true;
            }

            Engine.ai_set_orders(allied_phantom_01.Squad, dog_ph_obj_04);
            Engine.game_save_no_timeout();
            this.dogfighters_spawned = 0;
            await Engine.sleep_until(async () =>
            {
                if (Engine.objects_can_see_flag(Engine.players(), spawn_pt_05, 90F) == false && (short)Engine.ai_living_count(dogfighters_01) < 2)
                {
                    Engine.ai_place(dogfight_enemies.pt_05);
                    this.dogfighters_spawned = (short)(this.dogfighters_spawned + 1);
                    Engine.ai_set_orders(dogfight_enemies.Squad, dogfight01_cell_04);
                    await Engine.sleep(60);
                    Engine.ai_magically_see(dogfight_enemies.Squad, allied_phantom_01.Squad);
                    Engine.cs_run_command_script(dogfight_enemies.pt_05, boost_test);
                }

                if (Engine.objects_can_see_flag(Engine.players(), spawn_pt_06, 90F) == false && (short)Engine.ai_living_count(dogfighters_01) < 2)
                {
                    Engine.ai_place(dogfight_enemies.pt_06);
                    this.dogfighters_spawned = (short)(this.dogfighters_spawned + 1);
                    Engine.ai_set_orders(dogfight_enemies.Squad, dogfight01_cell_04);
                    await Engine.sleep(60);
                    Engine.ai_magically_see(dogfight_enemies.Squad, allied_phantom_01.Squad);
                    Engine.cs_run_command_script(dogfight_enemies.pt_06, boost_test);
                }

                if (Engine.objects_can_see_flag(Engine.players(), spawn_pt_04, 90F) == false && (short)Engine.ai_living_count(dogfighters_01) < 2)
                {
                    Engine.ai_place(dogfight_enemies.pt_04);
                    this.dogfighters_spawned = (short)(this.dogfighters_spawned + 1);
                    Engine.ai_set_orders(dogfight_enemies.Squad, dogfight01_cell_04);
                    await Engine.sleep(60);
                    Engine.ai_magically_see(dogfight_enemies.Squad, allied_phantom_01.Squad);
                    Engine.cs_run_command_script(dogfight_enemies.pt_04, boost_test);
                }

                await Engine.sleep_until(async () => Engine.volume_test_objects(vol_dog_obj_04, Engine.players()) == true || Engine.volume_test_objects(vol_dog_obj_04, Engine.ai_actors(allied_phantom_01.Squad)) == true || (short)Engine.ai_living_count(dogfighters_01) < 2);
                return Engine.volume_test_objects(vol_dog_obj_04, Engine.players()) == true || Engine.volume_test_objects(vol_dog_obj_04, Engine.ai_actors(allied_phantom_01.Squad)) == true || this.dogfighters_spawned > 3;
            }, 30, 4000);
            await Engine.sleep(30);
            await Engine.sleep_until(async () => this.emplace_04_done == true, 30, 1800);
            await Engine.sleep_until(async () => (bool)Engine.ai_trigger_test("done_fighting", dog_obj_emplaced_04) == true, 30, 1800);
            await Engine.sleep(60);
            Engine.wake(new ScriptMethodReference(dogfight_search_reminder));
            Engine.print("cleared");
            await Engine.sleep(30);
            Engine.ai_set_orders(allied_phantom_01.Squad, dog_ph_obj_06);
            Engine.game_save_no_timeout();
            this.dogfighters_spawned = 0;
            await Engine.sleep_until(async () =>
            {
                if (Engine.objects_can_see_flag(Engine.players(), spawn_pt_01, 90F) == false && (short)Engine.ai_living_count(dogfighters_01) < 2)
                {
                    Engine.ai_place(dogfight_enemies.pt_01);
                    this.dogfighters_spawned = (short)(this.dogfighters_spawned + 1);
                    Engine.ai_set_orders(dogfight_enemies.Squad, dogfight01_cell_06);
                    await Engine.sleep(60);
                    Engine.ai_magically_see(dogfight_enemies.Squad, allied_phantom_01.Squad);
                    Engine.cs_run_command_script(dogfight_enemies.pt_01, boost_test);
                }

                if (Engine.objects_can_see_flag(Engine.players(), spawn_pt_06, 90F) == false && (short)Engine.ai_living_count(dogfighters_01) < 2)
                {
                    Engine.ai_place(dogfight_enemies.pt_06);
                    this.dogfighters_spawned = (short)(this.dogfighters_spawned + 1);
                    Engine.ai_set_orders(dogfight_enemies.Squad, dogfight01_cell_06);
                    await Engine.sleep(60);
                    Engine.ai_magically_see(dogfight_enemies.Squad, allied_phantom_01.Squad);
                    Engine.cs_run_command_script(dogfight_enemies.pt_06, boost_test);
                }

                if (Engine.objects_can_see_flag(Engine.players(), spawn_pt_07, 90F) == false && (short)Engine.ai_living_count(dogfighters_01) < 2)
                {
                    Engine.ai_place(dogfight_enemies.pt_07);
                    this.dogfighters_spawned = (short)(this.dogfighters_spawned + 1);
                    Engine.ai_set_orders(dogfight_enemies.Squad, dogfight01_cell_06);
                    await Engine.sleep(60);
                    Engine.ai_magically_see(dogfight_enemies.Squad, allied_phantom_01.Squad);
                    Engine.cs_run_command_script(dogfight_enemies.pt_07, boost_test);
                }

                await Engine.sleep_until(async () => Engine.volume_test_objects(vol_dog_obj_06, Engine.players()) == true || Engine.volume_test_objects(vol_dog_obj_06, Engine.ai_actors(allied_phantom_01.Squad)) == true || (short)Engine.ai_living_count(dogfighters_01) < 2);
                return Engine.volume_test_objects(vol_dog_obj_06, Engine.players()) == true || Engine.volume_test_objects(vol_dog_obj_06, Engine.ai_actors(allied_phantom_01.Squad)) == true || this.dogfighters_spawned > 3;
            }, 30, 4000);
            await Engine.sleep(30);
            await Engine.sleep_until(async () => this.emplace_06_done == true, 30, 1800);
            await Engine.sleep_until(async () => (bool)Engine.ai_trigger_test("done_fighting", dog_obj_emplaced_06) == true, 30, 1800);
            Engine.print("cleared");
            await Engine.sleep(30);
            if (Engine.volume_test_objects(vol_dog_obj_07, Engine.players()) == false)
            {
                this.dogfight_ph_pilot_go = true;
            }

            Engine.ai_set_orders(allied_phantom_01.Squad, dog_ph_obj_07);
            Engine.game_save_no_timeout();
            this.dogfighters_spawned = 0;
            await Engine.sleep_until(async () =>
            {
                if (Engine.objects_can_see_flag(Engine.players(), spawn_pt_08, 90F) == false && (short)Engine.ai_living_count(dogfighters_01) < 2)
                {
                    Engine.ai_place(dogfight_enemies.pt_08);
                    this.dogfighters_spawned = (short)(this.dogfighters_spawned + 1);
                    Engine.ai_set_orders(dogfight_enemies.Squad, dogfight01_cell_07);
                    await Engine.sleep(60);
                    Engine.ai_magically_see(dogfight_enemies.Squad, allied_phantom_01.Squad);
                    Engine.cs_run_command_script(dogfight_enemies.pt_08, boost_test);
                }

                if (Engine.objects_can_see_flag(Engine.players(), spawn_pt_06, 90F) == false && (short)Engine.ai_living_count(dogfighters_01) < 2)
                {
                    Engine.ai_place(dogfight_enemies.pt_06);
                    this.dogfighters_spawned = (short)(this.dogfighters_spawned + 1);
                    Engine.ai_set_orders(dogfight_enemies.Squad, dogfight01_cell_07);
                    await Engine.sleep(60);
                    Engine.ai_magically_see(dogfight_enemies.Squad, allied_phantom_01.Squad);
                    Engine.cs_run_command_script(dogfight_enemies.pt_06, boost_test);
                }

                if (Engine.objects_can_see_flag(Engine.players(), spawn_pt_01, 90F) == false && (short)Engine.ai_living_count(dogfighters_01) < 2)
                {
                    Engine.ai_place(dogfight_enemies.pt_01);
                    this.dogfighters_spawned = (short)(this.dogfighters_spawned + 1);
                    Engine.ai_set_orders(dogfight_enemies.Squad, dogfight01_cell_07);
                    await Engine.sleep(60);
                    Engine.ai_magically_see(dogfight_enemies.Squad, allied_phantom_01.Squad);
                    Engine.cs_run_command_script(dogfight_enemies.pt_01, boost_test);
                }

                await Engine.sleep_until(async () => Engine.volume_test_objects(vol_dog_obj_07, Engine.players()) == true || Engine.volume_test_objects(vol_dog_obj_07, Engine.ai_actors(allied_phantom_01.Squad)) == true || (short)Engine.ai_living_count(dogfighters_01) < 2);
                return Engine.volume_test_objects(vol_dog_obj_07, Engine.players()) == true || Engine.volume_test_objects(vol_dog_obj_07, Engine.ai_actors(allied_phantom_01.Squad)) == true || this.dogfighters_spawned > 3;
            }, 30, 4000);
        }

        [ScriptMethod(361, Lifecycle.CommandScript)]
        public async Task goto_dog_turret_01l()
        {
            Engine.cs_force_combat_status(4);
            Engine.cs_enable_pathfinding_failsafe(true);
            Engine.cs_go_to_vehicle(Engine.ai_vehicle_get_from_starting_location(dog_turrets_01.left));
            Engine.ai_vehicle_reserve(Engine.ai_vehicle_get_from_starting_location(dog_turrets_01.left), true);
            Engine.cs_enable_targeting(true);
            Engine.cs_shoot(true);
            Engine.cs_set_behavior(guard);
            Engine.sleep_forever();
        }

        [ScriptMethod(362, Lifecycle.CommandScript)]
        public async Task goto_dog_turret_01r()
        {
            Engine.cs_force_combat_status(4);
            Engine.cs_enable_pathfinding_failsafe(true);
            Engine.cs_go_to_vehicle(Engine.ai_vehicle_get_from_starting_location(dog_turrets_01.right));
            Engine.ai_vehicle_reserve(Engine.ai_vehicle_get_from_starting_location(dog_turrets_01.right), true);
            Engine.cs_enable_targeting(true);
            Engine.cs_shoot(true);
            Engine.cs_set_behavior(guard);
            Engine.sleep_forever();
        }

        [ScriptMethod(363, Lifecycle.CommandScript)]
        public async Task goto_dog_turret_02l()
        {
            Engine.cs_force_combat_status(4);
            Engine.cs_enable_pathfinding_failsafe(true);
            Engine.cs_go_to_vehicle(Engine.ai_vehicle_get_from_starting_location(dog_turrets_02.left));
            Engine.ai_vehicle_reserve(Engine.ai_vehicle_get_from_starting_location(dog_turrets_02.left), true);
            Engine.cs_enable_targeting(true);
            Engine.cs_shoot(true);
            Engine.cs_set_behavior(guard);
            Engine.sleep_forever();
        }

        [ScriptMethod(364, Lifecycle.CommandScript)]
        public async Task goto_dog_turret_02r()
        {
            Engine.cs_force_combat_status(4);
            Engine.cs_enable_pathfinding_failsafe(true);
            Engine.cs_go_to_vehicle(Engine.ai_vehicle_get_from_starting_location(dog_turrets_02.right));
            Engine.ai_vehicle_reserve(Engine.ai_vehicle_get_from_starting_location(dog_turrets_02.right), true);
            Engine.cs_enable_targeting(true);
            Engine.cs_shoot(true);
            Engine.cs_set_behavior(guard);
            Engine.sleep_forever();
        }

        [ScriptMethod(365, Lifecycle.CommandScript)]
        public async Task goto_dog_turret_03l()
        {
            Engine.cs_force_combat_status(4);
            Engine.cs_enable_pathfinding_failsafe(true);
            Engine.cs_go_to_vehicle(Engine.ai_vehicle_get_from_starting_location(dog_turrets_03.left));
            Engine.ai_vehicle_reserve(Engine.ai_vehicle_get_from_starting_location(dog_turrets_03.left), true);
            Engine.cs_enable_targeting(true);
            Engine.cs_shoot(true);
            Engine.cs_set_behavior(guard);
            Engine.sleep_forever();
        }

        [ScriptMethod(366, Lifecycle.CommandScript)]
        public async Task goto_dog_turret_03r()
        {
            Engine.cs_force_combat_status(4);
            Engine.cs_enable_pathfinding_failsafe(true);
            Engine.cs_go_to_vehicle(Engine.ai_vehicle_get_from_starting_location(dog_turrets_03.right));
            Engine.ai_vehicle_reserve(Engine.ai_vehicle_get_from_starting_location(dog_turrets_03.right), true);
            Engine.cs_enable_targeting(true);
            Engine.cs_shoot(true);
            Engine.cs_set_behavior(guard);
            Engine.sleep_forever();
        }

        [ScriptMethod(367, Lifecycle.CommandScript)]
        public async Task goto_dog_turret_04l()
        {
            Engine.cs_force_combat_status(4);
            Engine.cs_enable_pathfinding_failsafe(true);
            Engine.cs_go_to_vehicle(Engine.ai_vehicle_get_from_starting_location(dog_turrets_04.left));
            Engine.ai_vehicle_reserve(Engine.ai_vehicle_get_from_starting_location(dog_turrets_04.left), true);
            Engine.cs_enable_targeting(true);
            Engine.cs_shoot(true);
            Engine.cs_set_behavior(guard);
            Engine.sleep_forever();
        }

        [ScriptMethod(368, Lifecycle.CommandScript)]
        public async Task goto_dog_turret_04r()
        {
            Engine.cs_force_combat_status(4);
            Engine.cs_enable_pathfinding_failsafe(true);
            Engine.cs_go_to_vehicle(Engine.ai_vehicle_get_from_starting_location(dog_turrets_04.right));
            Engine.ai_vehicle_reserve(Engine.ai_vehicle_get_from_starting_location(dog_turrets_04.right), true);
            Engine.cs_enable_targeting(true);
            Engine.cs_shoot(true);
            Engine.cs_set_behavior(guard);
            Engine.sleep_forever();
        }

        [ScriptMethod(369, Lifecycle.CommandScript)]
        public async Task goto_dog_turret_06l()
        {
            Engine.cs_force_combat_status(4);
            Engine.cs_enable_pathfinding_failsafe(true);
            Engine.cs_go_to_vehicle(Engine.ai_vehicle_get_from_starting_location(dog_turrets_06.left));
            Engine.ai_vehicle_reserve(Engine.ai_vehicle_get_from_starting_location(dog_turrets_06.left), true);
            Engine.cs_enable_targeting(true);
            Engine.cs_shoot(true);
            Engine.cs_set_behavior(guard);
            Engine.sleep_forever();
        }

        [ScriptMethod(370, Lifecycle.CommandScript)]
        public async Task goto_dog_turret_06r()
        {
            Engine.cs_force_combat_status(4);
            Engine.cs_enable_pathfinding_failsafe(true);
            Engine.cs_go_to_vehicle(Engine.ai_vehicle_get_from_starting_location(dog_turrets_06.right));
            Engine.ai_vehicle_reserve(Engine.ai_vehicle_get_from_starting_location(dog_turrets_06.right), true);
            Engine.cs_enable_targeting(true);
            Engine.cs_shoot(true);
            Engine.cs_set_behavior(guard);
            Engine.sleep_forever();
        }

        [ScriptMethod(371, Lifecycle.CommandScript)]
        public async Task lz_turret_01()
        {
            Engine.cs_force_combat_status(4);
            Engine.cs_enable_pathfinding_failsafe(true);
            Engine.cs_go_to_vehicle(Engine.ai_vehicle_get_from_starting_location(dog_turrets_07._01));
            Engine.ai_vehicle_reserve(Engine.ai_vehicle_get_from_starting_location(dog_turrets_07._01), true);
            Engine.cs_enable_targeting(true);
            Engine.cs_shoot(true);
            Engine.cs_set_behavior(guard);
            Engine.sleep_forever();
        }

        [ScriptMethod(372, Lifecycle.CommandScript)]
        public async Task lz_turret_02()
        {
            Engine.cs_force_combat_status(4);
            Engine.cs_enable_pathfinding_failsafe(true);
            Engine.cs_go_to_vehicle(Engine.ai_vehicle_get_from_starting_location(dog_turrets_07._02));
            Engine.ai_vehicle_reserve(Engine.ai_vehicle_get_from_starting_location(dog_turrets_07._02), true);
            Engine.cs_enable_targeting(true);
            Engine.cs_shoot(true);
            Engine.cs_set_behavior(guard);
            Engine.sleep_forever();
        }

        [ScriptMethod(373, Lifecycle.CommandScript)]
        public async Task lz_turret_03()
        {
            Engine.cs_force_combat_status(4);
            Engine.cs_enable_pathfinding_failsafe(true);
            Engine.cs_go_to_vehicle(Engine.ai_vehicle_get_from_starting_location(dog_turrets_07._03));
            Engine.ai_vehicle_reserve(Engine.ai_vehicle_get_from_starting_location(dog_turrets_07._03), true);
            Engine.cs_enable_targeting(true);
            Engine.cs_shoot(true);
            Engine.cs_set_behavior(guard);
            Engine.sleep_forever();
        }

        [ScriptMethod(374, Lifecycle.CommandScript)]
        public async Task lz_turret_04()
        {
            Engine.cs_force_combat_status(4);
            Engine.cs_enable_pathfinding_failsafe(true);
            Engine.cs_go_to_vehicle(Engine.ai_vehicle_get_from_starting_location(dog_turrets_07._04));
            Engine.ai_vehicle_reserve(Engine.ai_vehicle_get_from_starting_location(dog_turrets_07._04), true);
            Engine.cs_enable_targeting(true);
            Engine.cs_shoot(true);
            Engine.cs_set_behavior(guard);
            Engine.sleep_forever();
        }

        [ScriptMethod(375, Lifecycle.Dormant)]
        public async Task near_dog_obj_01()
        {
            Engine.ai_place(dog_turret_men_01.Squad);
            Engine.cs_run_command_script(dog_turret_men_01.left, goto_dog_turret_01l);
            Engine.cs_run_command_script(dog_turret_men_01.right, goto_dog_turret_01r);
            await Engine.sleep_until(async () =>
            {
                if (Engine.objects_can_see_flag(Engine.players(), spawn_pt_08, 60F) == false && (short)Engine.ai_living_count(dogfighters_01) < 2)
                {
                    Engine.ai_place(dogfight_enemies.pt_08);
                    Engine.ai_set_orders(dogfight_enemies.Squad, dogfight01_cell_01);
                    Engine.ai_magically_see(dogfight_enemies.Squad, allied_phantom_01.Squad);
                    Engine.cs_run_command_script(dogfight_enemies.pt_08, boost_test);
                }

                if (Engine.objects_can_see_flag(Engine.players(), spawn_pt_02, 60F) == false && (short)Engine.ai_living_count(dogfighters_01) < 2)
                {
                    Engine.ai_place(dogfight_enemies.pt_02);
                    Engine.ai_set_orders(dogfight_enemies.Squad, dogfight01_cell_01);
                    Engine.ai_magically_see(dogfight_enemies.Squad, allied_phantom_01.Squad);
                    Engine.cs_run_command_script(dogfight_enemies.pt_02, boost_test);
                }

                if (Engine.objects_can_see_flag(Engine.players(), spawn_pt_01, 60F) == false && (short)Engine.ai_living_count(dogfighters_01) < 2)
                {
                    Engine.ai_place(dogfight_enemies.pt_01);
                    Engine.ai_set_orders(dogfight_enemies.Squad, dogfight01_cell_01);
                    Engine.ai_magically_see(dogfight_enemies.Squad, allied_phantom_01.Squad);
                    Engine.cs_run_command_script(dogfight_enemies.pt_01, boost_test);
                }

                await Engine.sleep_until(async () => Engine.objects_distance_to_flag(Engine.players(), banshee_intro) > 75F || (short)Engine.ai_living_count(dogfighters_01) < 2 || (short)Engine.ai_spawn_count(dogfighters_01) > 2);
                return Engine.objects_distance_to_flag(Engine.players(), banshee_intro) > 75F || (short)Engine.ai_spawn_count(dogfighters_01) > 2;
            });
            await Engine.sleep_until(async () => (short)Engine.ai_living_count(dog_obj_emplaced_01) < 1 && (short)Engine.ai_living_count(dogfighters_01) < 1);
            this.emplace_01_done = true;
            Engine.game_save_no_timeout();
        }

        [ScriptMethod(376, Lifecycle.Dormant)]
        public async Task near_dog_obj_02()
        {
            await Engine.sleep_until(async () => Engine.volume_test_objects(vol_dog_obj_02, Engine.players()) == true || Engine.volume_test_objects(vol_dog_obj_02, Engine.ai_actors(allied_phantom_01.Squad)) == true);
            Engine.ai_place(dog_turret_men_02.Squad);
            Engine.cs_run_command_script(dog_turret_men_02.left, goto_dog_turret_02l);
            Engine.cs_run_command_script(dog_turret_men_02.right, goto_dog_turret_02r);
            await Engine.sleep_until(async () => (short)Engine.ai_living_count(dog_turret_men_02.Squad) < 2);
            Engine.ai_place(dog_flak_02.Squad, 2);
            await Engine.sleep_until(async () => (short)Engine.ai_living_count(dog_flak_02.Squad) < 2);
            Engine.ai_place(dog_flak_02.Squad, 2);
            await Engine.sleep_until(async () => (short)Engine.ai_living_count(dog_obj_emplaced_02) < 1);
            this.emplace_02_done = true;
            Engine.game_save_no_timeout();
        }

        [ScriptMethod(377, Lifecycle.Dormant)]
        public async Task near_dog_obj_03()
        {
            await Engine.sleep_until(async () => Engine.volume_test_objects(vol_dog_obj_03, Engine.players()) == true || Engine.volume_test_objects(vol_dog_obj_03, Engine.ai_actors(allied_phantom_01.Squad)) == true);
            Engine.ai_place(dog_turret_men_03.Squad);
            await Engine.sleep_until(async () =>
            {
                Engine.ai_place(dog_turret_men_03.Squad, 1);
                await Engine.sleep(60);
                await Engine.sleep_until(async () => (short)Engine.ai_living_count(dog_turret_men_03.Squad) < 2);
                return (short)Engine.ai_spawn_count(dog_turret_men_03.Squad) > 3;
            });
            await Engine.sleep_until(async () => (short)Engine.ai_living_count(dog_obj_emplaced_03) < 1);
            this.emplace_03_done = true;
            Engine.game_save_no_timeout();
        }

        [ScriptMethod(378, Lifecycle.Dormant)]
        public async Task near_dog_obj_04()
        {
            await Engine.sleep_until(async () => Engine.volume_test_objects(vol_dog_obj_04, Engine.players()) == true || Engine.volume_test_objects(vol_dog_obj_04, Engine.ai_actors(allied_phantom_01.Squad)) == true);
            Engine.ai_place(dog_flak_04.Squad);
            Engine.ai_place(dog_turret_men_04.Squad);
            Engine.cs_run_command_script(dog_turret_men_04.left, goto_dog_turret_04l);
            Engine.cs_run_command_script(dog_turret_men_04.right, goto_dog_turret_04r);
            await Engine.sleep_until(async () => (short)Engine.ai_living_count(dog_obj_emplaced_04) < 1);
            this.emplace_04_done = true;
            Engine.game_save_no_timeout();
        }

        [ScriptMethod(379, Lifecycle.Dormant)]
        public async Task near_dog_obj_05()
        {
            await Engine.sleep_until(async () => Engine.volume_test_objects(vol_dog_obj_05, Engine.players()) == true || Engine.volume_test_objects(vol_dog_obj_05, Engine.ai_actors(allied_phantom_01.Squad)) == true);
            await Engine.sleep_until(async () =>
            {
                Engine.ai_place(dog_sen_05.Squad, 1);
                await Engine.sleep(15);
                await Engine.sleep_until(async () => (short)Engine.ai_living_count(dog_sen_05.Squad) < 4);
                return (short)Engine.ai_spawn_count(dog_sen_05.Squad) == 8;
            });
            await Engine.sleep_until(async () => (short)Engine.ai_living_count(dog_obj_emplaced_05) < 1);
            this.emplace_05_done = true;
            Engine.game_save_no_timeout();
        }

        [ScriptMethod(380, Lifecycle.Dormant)]
        public async Task near_dog_obj_06()
        {
            await Engine.sleep_until(async () => Engine.volume_test_objects(vol_dog_obj_06, Engine.players()) == true || Engine.volume_test_objects(vol_dog_obj_06, Engine.ai_actors(allied_phantom_01.Squad)) == true);
            Engine.ai_place(dog_turret_men_06.Squad);
            await Engine.sleep_until(async () =>
            {
                Engine.ai_place(dog_turret_men_06.Squad, 1);
                await Engine.sleep(60);
                await Engine.sleep_until(async () => (short)Engine.ai_living_count(dog_turret_men_06.Squad) < 2);
                return (short)Engine.ai_spawn_count(dog_turret_men_06.Squad) > 3;
            });
            await Engine.sleep_until(async () => (short)Engine.ai_living_count(dog_obj_emplaced_06) < 1);
            this.emplace_06_done = true;
            Engine.game_save_no_timeout();
        }

        [ScriptMethod(381, Lifecycle.Dormant)]
        public async Task final_dogfight_reminder()
        {
            await Engine.sleep_until(async () => (short)Engine.ai_living_count(dog_turrets_07.Squad) > 0);
            await Engine.sleep_until(async () => (short)Engine.ai_living_count(dog_turrets_07.Squad) < 1, 30, 3600);
            if ((short)Engine.ai_living_count(dog_turrets_07.Squad) > 0)
            {
                Engine.ai_dialogue_enable(false);
                await Engine.sleep(60);
                Engine.print("spec-ops commander: 'take out those turrets, and get after the heretic-leader!'");
                await Engine.sleep(Engine.ai_play_line_on_object(default(IGameObject), "1220"));
                await Engine.sleep(30);
                Engine.ai_dialogue_enable(true);
            }
        }

        [ScriptMethod(382, Lifecycle.Dormant)]
        public async Task ally_final_run()
        {
            Engine.ai_set_orders(allied_phantom_01.Squad, dog_ph_obj_park);
            Engine.ai_place(allies_elites_03.Squad, 2);
            Engine.ai_place(allies_grunts_03.Squad, 2);
            await Engine.sleep(60);
            Engine.vehicle_load_magic(Engine.ai_vehicle_get_from_starting_location(allied_phantom_01.driver), "phantom_p_a", Engine.ai_actors(allies_elites_03.Squad));
            Engine.vehicle_load_magic(Engine.ai_vehicle_get_from_starting_location(allied_phantom_01.driver), "phantom_p_b", Engine.ai_actors(allies_grunts_03.Squad));
            await Engine.sleep_until(async () => Engine.volume_test_objects(vol_arm02_air, Engine.ai_actors(allied_phantom_01.Squad)) == true);
            Engine.cs_run_command_script(allied_phantom_01.driver, arm02_final_approach);
        }

        [ScriptMethod(383, Lifecycle.Dormant)]
        public async Task near_dog_obj_07()
        {
            await Engine.sleep_until(async () => Engine.volume_test_objects(vol_dog_obj_07, Engine.players()) == true || Engine.volume_test_objects(vol_dog_obj_07, Engine.ai_actors(allied_phantom_01.Squad)) == true);
            Engine.object_create(hl_banshee);
            Engine.ai_place(dog_turret_men_07.Squad);
            await Engine.sleep(2);
            Engine.ai_enter_squad_vehicles(dog_07_turrets);
            await Engine.sleep(2);
            Engine.ai_place(dog_flak_07.Squad);
            Engine.ai_dialogue_enable(false);
            await Engine.sleep(60);
            Engine.print("spec-ops commander: 'we've tracked the heretic leader to this part of the station.'");
            await Engine.sleep(Engine.ai_play_line_on_object(default(IGameObject), "0530"));
            await Engine.sleep(30);
            Engine.print("spec-ops commander: 'clear that landing-zone, and get inside!'");
            await Engine.sleep(Engine.ai_play_line_on_object(default(IGameObject), "0540"));
            await Engine.sleep(30);
            Engine.ai_dialogue_enable(true);
            Engine.wake(new ScriptMethodReference(final_dogfight_reminder));
            Engine.game_save_no_timeout();
            await Engine.sleep_until(async () => (short)Engine.ai_living_count(dog_obj_emplaced_07) < 3, 30, 4000);
            Engine.wake(new ScriptMethodReference(ally_final_run));
            if (Engine.volume_test_objects(vol_arm_02_lz, Engine.players()) == false && await this.player_count() > 0)
            {
                Engine.ai_place(arm02_final_heretics.Squad, 2);
                Engine.ai_place(arm02_final_grunts.Squad, 2);
            }

            await Engine.sleep_until(async () => (float)Engine.ai_living_count(arm02_final_heretics.Squad) + (float)Engine.ai_living_count(arm02_final_heretics.Squad) < 1F, 30, 3600);
            await Engine.sleep_until(async () => (bool)Engine.ai_trigger_test("done_fighting", dog_obj_emplaced_07) == true, 30, 1800);
            this.dogfight_over = true;
        }

        [ScriptMethod(384, Lifecycle.Dormant)]
        public async Task dogfight_flak_warn()
        {
            Engine.ai_dialogue_enable(false);
            await Engine.sleep(60);
            Engine.print("spec-ops commander: 'look sharp, arbiter! they're putting-up heavy flak!'");
            await Engine.sleep(Engine.ai_play_line_on_object(default(IGameObject), "1200"));
            await Engine.sleep(30);
            Engine.ai_dialogue_enable(true);
        }

        [ScriptMethod(385, Lifecycle.Dormant)]
        public async Task dogfight_objectives()
        {
            Engine.ai_dialogue_enable(false);
            await Engine.sleep(60);
            Engine.print("phantom pilot: 'the heretics have weapon-emplacements all over the facility, arbiter.'");
            Engine.print("'we'll take them out, one-by-one, until we find the heretic-leader!'");
            await Engine.sleep(Engine.ai_play_line_on_object(default(IGameObject), "2040"));
            await Engine.sleep(30);
            Engine.ai_dialogue_enable(true);
        }

        [ScriptMethod(386, Lifecycle.Dormant)]
        public async Task dogfight_nav_swap()
        {
            await Engine.sleep_until(async () => (short)Engine.ai_living_count(allied_phantom_01.Squad) < 1 || Engine.volume_test_objects(vol_dog_obj_07, Engine.players()) == true || Engine.volume_test_objects(vol_dog_obj_07, Engine.ai_actors(allied_phantom_01.Squad)) == true, 30, 24000);
            Engine.activate_team_nav_point_object(_default, player, arm_02_entry_ext.Entity, 0F);
        }

        [ScriptMethod(387, Lifecycle.Dormant)]
        public async Task always_get_banshee_01()
        {
            await Engine.sleep_until(async () =>
            {
                await Engine.sleep_until(async () => Engine.objects_distance_to_flag(Engine.players(), _01a) > 50F && Engine.objects_distance_to_flag(Engine.players(), _01b) > 50F && Engine.objects_can_see_flag(Engine.players(), _01a, 45F) == false && Engine.objects_can_see_flag(Engine.players(), _01b, 45F) == false && Engine.volume_test_object(vol_stuck_01, mid_banshee_01.Entity) == false || Engine.volume_test_object(vol_stuck_01, mid_banshee_02.Entity) == false);
                await Engine.sleep_until(async () =>
                {
                    Engine.object_destroy(Engine.list_get(Engine.volume_return_objects_by_type(vol_stuck_01, 2), 0));
                    return Engine.list_count_not_dead(Engine.volume_return_objects_by_type(vol_stuck_01, 2)) == 0;
                });
                Engine.object_create_clone(mid_banshee_01);
                Engine.object_create_clone(mid_banshee_02);
                return false;
            });
        }

        [ScriptMethod(388, Lifecycle.Dormant)]
        public async Task always_get_banshee_02()
        {
            await Engine.sleep_until(async () =>
            {
                await Engine.sleep_until(async () => Engine.objects_distance_to_flag(Engine.players(), _10a) > 50F && Engine.objects_distance_to_flag(Engine.players(), _10b) > 50F && Engine.objects_can_see_flag(Engine.players(), _10a, 45F) == false && Engine.objects_can_see_flag(Engine.players(), _10b, 45F) == false && Engine.volume_test_object(vol_stuck_10, Engine.ai_vehicle_get_from_starting_location(ledge_banshees_01.left)) == false || Engine.volume_test_object(vol_stuck_10, Engine.ai_vehicle_get_from_starting_location(ledge_banshees_01.right)) == false);
                await Engine.sleep_until(async () =>
                {
                    Engine.object_destroy(Engine.list_get(Engine.volume_return_objects_by_type(vol_stuck_10, 2), 0));
                    return Engine.list_count_not_dead(Engine.volume_return_objects_by_type(vol_stuck_10, 2)) == 0;
                });
                Engine.ai_place(ledge_banshees_01.left);
                Engine.ai_place(ledge_banshees_01.right);
                return false;
            });
        }

        [ScriptMethod(389, Lifecycle.Dormant)]
        public async Task dogfight_firsttime_start()
        {
            Engine.data_mine_set_mission_segment("04a_9_dogfight");
            Engine.game_save();
            if (await this.difficulty_legendary())
            {
                Engine.wake(new ScriptMethodReference(grunt_birthday_party));
            }

            Engine.kill_volume_disable(kill_banshee_ledge);
            Engine.wake(new ScriptMethodReference(banshee_stuck_spawner_01));
            if ((bool)Engine.game_is_cooperative() == true)
            {
                Engine.wake(new ScriptMethodReference(banshee_stuck_spawner_02));
            }

            Engine.activate_team_nav_point_object(_default, player, Engine.list_get(Engine.ai_actors(allied_phantom_01.Squad), 0), 3F);
            Engine.ai_place(dogfight_initial_enemies.Squad, 2);
            Engine.ai_place(dog_turrets_04.Squad);
            Engine.ai_place(dog_turrets_07.Squad);
            Engine.wake(new ScriptMethodReference(near_dog_obj_01));
            Engine.wake(new ScriptMethodReference(near_dog_obj_03));
            Engine.wake(new ScriptMethodReference(near_dog_obj_04));
            Engine.wake(new ScriptMethodReference(near_dog_obj_06));
            Engine.wake(new ScriptMethodReference(near_dog_obj_07));
            Engine.wake(new ScriptMethodReference(phantom_path_w_orders));
            Engine.wake(new ScriptMethodReference(dogfight_nav_swap));
            Engine.object_create_containing("mid_banshee_0");
            Engine.wake(new ScriptMethodReference(always_get_banshee_01));
            Engine.wake(new ScriptMethodReference(always_get_banshee_02));
            await Engine.sleep(5);
            Engine.wake(new ScriptMethodReference(music_04a_04_start));
            Engine.wake(new ScriptMethodReference(music_04a_04_stop));
            await Engine.sleep_until(async () => (short)Engine.ai_living_count(dogfight_initial_enemies.Squad) < 1 && this.emplace_01_done == true);
            await Engine.sleep(60);
            await Engine.sleep(30);
            Engine.wake(new ScriptMethodReference(dogfight_objectives));
        }

        [ScriptMethod(390, Lifecycle.Dormant)]
        public async Task arm_02_entry_win()
        {
            await Engine.sleep_until(async () => Engine.volume_test_objects(vol_04a_game_won, Engine.players()) == true || this.dogfight_over == true && Engine.volume_test_object(vol_real_win, await this.player0()) == true && Engine.unit_in_vehicle(await this.player0()) == false || this.dogfight_over == true && Engine.volume_test_object(vol_real_win, await this.player1()) == true && Engine.unit_in_vehicle(await this.player1()) == false);
            await this.playtest_mission();
            await Engine.sleep(30);
            Engine.sound_class_set_gain("", 0F, 15);
            await this.cinematic_fade_to_white();
            await Engine.sleep(30);
            Engine.game_won();
        }

        [ScriptMethod(391, Lifecycle.Static)]
        public async Task sleep_intro()
        {
            Engine.sleep_forever(new ScriptMethodReference(swat_deploy));
            Engine.sleep_forever(new ScriptMethodReference(commander_entry_reminder));
            Engine.sleep_forever(new ScriptMethodReference(wind));
        }

        [ScriptMethod(392, Lifecycle.Static)]
        public async Task sleep_rec_center()
        {
            Engine.sleep_forever(new ScriptMethodReference(production_arm_bsp_swap));
            Engine.sleep_forever(new ScriptMethodReference(recycling_center_start));
            Engine.sleep_forever(new ScriptMethodReference(recycling_can_spawner));
            Engine.sleep_forever(new ScriptMethodReference(recycling_killer_new));
            Engine.sleep_forever(new ScriptMethodReference(heretic_uplink_01));
            Engine.sleep_forever(new ScriptMethodReference(rec_center_reminder));
            Engine.ai_disposable(rec_center_heretics, true);
        }

        [ScriptMethod(393, Lifecycle.Static)]
        public async Task sleep_hangar()
        {
            Engine.sleep_forever(new ScriptMethodReference(hangar_firsttime_start));
            Engine.sleep_forever(new ScriptMethodReference(hangar_can_spawner));
            Engine.sleep_forever(new ScriptMethodReference(hangar_killer_new));
            Engine.sleep_forever(new ScriptMethodReference(hangar_allies_reinforce));
            Engine.sleep_forever(new ScriptMethodReference(hangar_helpers));
            Engine.sleep_forever(new ScriptMethodReference(hangar_sentinels_flitting));
            Engine.sleep_forever(new ScriptMethodReference(hangar_door_monitor));
            Engine.sleep_forever(new ScriptMethodReference(hangar_door_reminder));
            Engine.sleep_forever(new ScriptMethodReference(hangar_alerted_call));
            Engine.sleep_forever(new ScriptMethodReference(hangar_exit_warn));
            Engine.sleep_forever(new ScriptMethodReference(hangar_reminder));
            Engine.sleep_forever(new ScriptMethodReference(hangar_exterior_toggle));
        }

        [ScriptMethod(394, Lifecycle.Static)]
        public async Task sleep_first_halls()
        {
            Engine.sleep_forever(new ScriptMethodReference(to_underhangar_firsttime));
            Engine.sleep_forever(new ScriptMethodReference(first_hall_reinforce));
        }

        [ScriptMethod(395, Lifecycle.Static)]
        public async Task sleep_underhangar()
        {
            Engine.sleep_forever(new ScriptMethodReference(underhangar_firsttime_start));
            Engine.sleep_forever(new ScriptMethodReference(underhangar_can_spawner));
            Engine.sleep_forever(new ScriptMethodReference(underhangar_killer_new));
            Engine.sleep_forever(new ScriptMethodReference(new_allies_02));
            Engine.sleep_forever(new ScriptMethodReference(underhangar_reinforce));
            Engine.sleep_forever(new ScriptMethodReference(underhangar_reminder));
        }

        [ScriptMethod(396, Lifecycle.Static)]
        public async Task sleep_second_halls()
        {
            Engine.sleep_forever(new ScriptMethodReference(to_bottling));
            Engine.sleep_forever(new ScriptMethodReference(second_hall_reinforce_01));
            Engine.sleep_forever(new ScriptMethodReference(second_hall_reinforce_02));
            Engine.sleep_forever(new ScriptMethodReference(second_hall_reinforce_03));
        }

        [ScriptMethod(397, Lifecycle.Static)]
        public async Task sleep_bottling()
        {
            Engine.sleep_forever(new ScriptMethodReference(bottling_firsttime_start));
            Engine.sleep_forever(new ScriptMethodReference(bottling_can_spawner));
            Engine.sleep_forever(new ScriptMethodReference(bottling_killer_new));
            Engine.sleep_forever(new ScriptMethodReference(bottling_overlook_reinforce));
            Engine.sleep_forever(new ScriptMethodReference(active_camo_drop));
            Engine.sleep_forever(new ScriptMethodReference(new_allies_03));
            Engine.ai_disposable(hangar_heretics, true);
            Engine.ai_disposable(hangar_sentinels, true);
            Engine.ai_disposable(first_hall_heretics, true);
            Engine.ai_disposable(underhangar_heretics, true);
            Engine.ai_disposable(second_hall_heretics, true);
            Engine.ai_disposable(bottling_enemies, true);
        }

        [ScriptMethod(398, Lifecycle.Startup)]
        public async Task mission()
        {
            await this.cinematic_snap_to_white();
            if (Engine.volume_test_objects(vol_starting_locations, Engine.players()) == true)
            {
                Engine.sound_suppress_ambience_update_on_revert();
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

            await Engine.sleep(2);
            Engine.switch_bsp(0);
            await Engine.sleep(2);
            Engine.ai_allegiance(player, covenant);
            Engine.ai_allegiance(sentinel, heretic);
            Engine.ai_allegiance(heretic, sentinel);
            Engine.objectives_clear();
            Engine.game_save_immediate();
            await this.prep_return_from_intro();
            Engine.camera_control(false);
            await Engine.sleep(1);
            await Engine.cache_block_for_one_frame();
            await Engine.sleep(1);
            Engine.wake(new ScriptMethodReference(_04a_title0));
            Engine.wake(new ScriptMethodReference(objective_hl_set));
            Engine.wake(new ScriptMethodReference(swat_deploy));
            Engine.wake(new ScriptMethodReference(recycling_center_start));
            Engine.wake(new ScriptMethodReference(kill_volumes));
            await Engine.sleep_until(async () => Engine.volume_test_objects(vol_on_hangar_lift_top, Engine.players()) == true || Engine.volume_test_objects(vol_on_hangar_lift_top, Engine.ai_actors(all_allies)) == true);
            Engine.wake(new ScriptMethodReference(hangar_firsttime_start));
            Engine.wake(new ScriptMethodReference(to_underhangar_firsttime));
            await this.sleep_intro();
            Engine.device_one_sided_set(rec_center_entry_ext.Entity, true);
            Engine.device_one_sided_set(rec_center_entry_int.Entity, true);
            await Engine.sleep_until(async () => Engine.volume_test_objects(vol_underhangar_from_top, Engine.players()) == true);
            Engine.wake(new ScriptMethodReference(underhangar_firsttime_start));
            Engine.wake(new ScriptMethodReference(to_bottling));
            await this.sleep_rec_center();
            await this.sleep_hangar();
            this.recycling_power_on = false;
            this.hangar_power_on = false;
            Engine.device_one_sided_set(hangar_exit.Entity, true);
            await Engine.sleep_until(async () => (short)Engine.structure_bsp_index() == 0);
            Engine.wake(new ScriptMethodReference(bottling_firsttime_start));
            Engine.wake(new ScriptMethodReference(bottling_plant_end));
            await this.sleep_first_halls();
            await this.sleep_underhangar();
            this.underhangar_power_on = false;
            Engine.device_one_sided_set(underhangar_entry.Entity, true);
            Engine.device_one_sided_set(underhangar_exit.Entity, true);
            await Engine.sleep_until(async () => Engine.vehicle_test_seat(Engine.ai_vehicle_get_from_starting_location(ledge_banshees_01.left), "banshee_d", Engine.unit(await this.player0())) == true || Engine.vehicle_test_seat(Engine.ai_vehicle_get_from_starting_location(ledge_banshees_01.right), "banshee_d", Engine.unit(await this.player0())) == true || Engine.vehicle_test_seat(Engine.ai_vehicle_get_from_starting_location(ledge_banshees_01.left), "banshee_d", Engine.unit(await this.player1())) == true || Engine.vehicle_test_seat(Engine.ai_vehicle_get_from_starting_location(ledge_banshees_01.right), "banshee_d", Engine.unit(await this.player1())) == true);
            Engine.wake(new ScriptMethodReference(dogfight_firsttime_start));
            Engine.wake(new ScriptMethodReference(arm_02_entry_win));
            await this.sleep_second_halls();
            await this.sleep_bottling();
            this.bottling_power_on = false;
            Engine.device_operates_automatically_set(rec_center_entry_ext.Entity, false);
            Engine.device_one_sided_set(bottling_entry.Entity, true);
            Engine.device_one_sided_set(bottling_midway.Entity, true);
            Engine.device_one_sided_set(viewroom_entry.Entity, true);
            Engine.wake(new ScriptMethodReference(objective_hl_clear));
            Engine.wake(new ScriptMethodReference(objective_dogfight_set));
            await Engine.sleep_until(async () => Engine.unit_in_vehicle(await this.player0()) && Engine.unit_in_vehicle(await this.player1()) || Engine.unit_in_vehicle(await this.player0()) && (bool)Engine.game_is_cooperative() == false);
        }

        [ScriptMethod(399, Lifecycle.Dormant)]
        public async Task x04_01_predict()
        {
            await Engine.sleep(30);
            await Engine.sleep(1);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("scenarios\\skies\\solo\\alphagasgiant\\alphagasgiant", 3782934533U), 0);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("scenarios\\skies\\solo\\alphagasgiant\\alphagasgiant", 3782934533U), 1);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("scenarios\\skies\\solo\\alphagasgiant\\alphagasgiant", 3782934533U), 2);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("scenarios\\skies\\solo\\alphagasgiant\\alphagasgiant", 3782934533U), 3);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("scenarios\\skies\\solo\\alphagasgiant\\alphagasgiant", 3782934533U), 4);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("scenarios\\skies\\solo\\alphagasgiant\\alphagasgiant", 3782934533U), 5);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("scenarios\\skies\\solo\\alphagasgiant\\alphagasgiant", 3782934533U), 6);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("scenarios\\skies\\solo\\alphagasgiant\\alphagasgiant", 3782934533U), 7);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("scenarios\\skies\\solo\\alphagasgiant\\alphagasgiant", 3782934533U), 8);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("scenarios\\skies\\solo\\alphagasgiant\\alphagasgiant", 3782934533U), 9);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\07a_highcharity\\high_4_cinematic"), 38, false);
            await Engine.sleep(2);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\07a_highcharity\\high_4_cinematic"), 53, false);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\characters\\jackal\\jackal", 3834446615U), 8);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\characters\\brute\\brute", 3836871484U), 26);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\characters\\brute\\brute", 3836871484U), 28);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\characters\\brute\\brute", 3836871484U), 29);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\characters\\brute\\brute", 3836871484U), 40);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\characters\\brute\\brute", 3836871484U), 36);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\characters\\brute\\brute", 3836871484U), 37);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\characters\\brute\\brute", 3836871484U), 33);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\characters\\brute\\brute", 3836871484U), 35);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\characters\\brute\\brute", 3836871484U), 34);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\characters\\dervish\\dervish", 3839689575U), 11);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\characters\\dervish\\dervish", 3839689575U), 9);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\characters\\dervish\\dervish", 3839689575U), 13);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\weapons\\melee\\gravity_hammer\\gravity_hammer", 3841459074U), 0);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("scenarios\\objects\\cinematics\\cinematic_anchor\\cinematic_anchor", 3841917833U), 0);
            await Engine.sleep(101);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\07a_highcharity\\high_4_cinematic"), 65, false);
            await Engine.sleep(86);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\characters\\brute\\brute", 3836871484U), 35);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\characters\\brute\\brute", 3836871484U), 34);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\weapons\\melee\\gravity_hammer\\gravity_hammer", 3841459074U), 0);
            await Engine.sleep(51);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("scenarios\\objects\\solo\\highcharity\\jail_door\\jail_door", 3842245518U), 0);
            await Engine.sleep(3);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\characters\\jackal\\jackal", 3834446615U), 8);
            await Engine.sleep(2);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("scenarios\\objects\\solo\\highcharity\\high_door_grand\\high_door_grand", 3842769814U), 0);
            await Engine.sleep(33);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\characters\\brute\\brute", 3836871484U), 28);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\characters\\brute\\brute", 3836871484U), 40);
            await Engine.sleep(19);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\characters\\dervish\\dervish", 3839689575U), 11);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\characters\\dervish\\dervish", 3839689575U), 9);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\characters\\dervish\\dervish", 3839689575U), 13);
            await Engine.sleep(4);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\07a_highcharity\\high_4_cinematic"), 53, false);
            await Engine.sleep(141);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\characters\\jackal\\jackal", 3834446615U), 8);
            await Engine.sleep(6);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("scenarios\\objects\\solo\\highcharity\\high_door_grand\\high_door_grand", 3842769814U), 0);
            await Engine.sleep(350);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\07a_highcharity\\high_4_cinematic"), 53, false);
        }

        [ScriptMethod(400, Lifecycle.Dormant)]
        public async Task x04_02a_predict()
        {
            await Engine.sleep(30);
            await Engine.sleep(203);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("scenarios\\objects\\solo\\highcharity\\high_door_grand\\high_door_grand", 3842769814U), 0);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("scenarios\\objects\\covenant\\residential\\holo_switches\\holo_switch_a\\holo_switch_a", 3844080554U), 0);
            await Engine.sleep(91);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\07a_highcharity\\high_4_cinematic"), 53, false);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\characters\\dervish\\dervish", 3839689575U), 11);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\characters\\dervish\\dervish", 3839689575U), 9);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\characters\\dervish\\dervish", 3839689575U), 13);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\characters\\jackal\\jackal", 3834446615U), 8);
            await Engine.sleep(164);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\07a_highcharity\\high_4_cinematic"), 34, false);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\07a_highcharity\\high_4_cinematic"), 31, false);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\07a_highcharity\\high_4_cinematic"), 61, false);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\07a_highcharity\\high_4_cinematic"), 1, false);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\07a_highcharity\\high_4_cinematic"), 47, false);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\07a_highcharity\\high_4_cinematic"), 21, false);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\07a_highcharity\\high_4_cinematic"), 26, false);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\07a_highcharity\\high_4_cinematic"), 15, true);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\07a_highcharity\\high_4_cinematic"), 16, true);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\07a_highcharity\\high_4_cinematic"), 17, true);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\07a_highcharity\\high_4_cinematic"), 23, true);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\07a_highcharity\\high_4_cinematic"), 43, false);
            await Engine.sleep(41);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\07a_highcharity\\high_4_cinematic"), 63, false);
        }

        [ScriptMethod(401, Lifecycle.Dormant)]
        public async Task x04_02b_predict()
        {
            await Engine.sleep(30);
            await Engine.sleep(4);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\07a_highcharity\\high_4_cinematic"), 53, false);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\characters\\dervish\\dervish", 3839689575U), 11);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\characters\\dervish\\dervish", 3839689575U), 9);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\characters\\dervish\\dervish", 3839689575U), 13);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("scenarios\\objects\\solo\\highcharity\\high_jail_ledge\\high_jail_ledge", 3844539313U), 0);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\characters\\jackal\\jackal", 3834446615U), 8);
            await Engine.sleep(139);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\07a_highcharity\\high_4_cinematic"), 31, false);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\07a_highcharity\\high_4_cinematic"), 61, false);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\07a_highcharity\\high_4_cinematic"), 32, false);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\07a_highcharity\\high_4_cinematic"), 49, false);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\07a_highcharity\\high_4_cinematic"), 47, false);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\07a_highcharity\\high_4_cinematic"), 63, false);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\07a_highcharity\\high_4_cinematic"), 21, false);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\07a_highcharity\\high_4_cinematic"), 3, false);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\07a_highcharity\\high_4_cinematic"), 50, false);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\07a_highcharity\\high_4_cinematic"), 26, false);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\07a_highcharity\\high_4_cinematic"), 2, false);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\07a_highcharity\\high_4_cinematic"), 20, false);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\07a_highcharity\\high_4_cinematic"), 45, false);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\07a_highcharity\\high_4_cinematic"), 33, false);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\07a_highcharity\\high_4_cinematic"), 67, false);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\07a_highcharity\\high_4_cinematic"), 15, true);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\07a_highcharity\\high_4_cinematic"), 23, true);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\07a_highcharity\\high_4_cinematic"), 0, true);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\07a_highcharity\\high_4_cinematic"), 1, true);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\07a_highcharity\\high_4_cinematic"), 2, true);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\07a_highcharity\\high_4_cinematic"), 24, true);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\07a_highcharity\\high_4_cinematic"), 7, true);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\07a_highcharity\\high_4_cinematic"), 9, true);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\07a_highcharity\\high_4_cinematic"), 12, true);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\07a_highcharity\\high_4_cinematic"), 13, true);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\07a_highcharity\\high_4_cinematic"), 8, true);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\07a_highcharity\\high_4_cinematic"), 10, true);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\07a_highcharity\\high_4_cinematic"), 11, true);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\07a_highcharity\\high_4_cinematic"), 14, true);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("scenarios\\objects\\solo\\highcharity\\high_door_grand\\high_door_grand", 3842769814U), 0);
        }

        [ScriptMethod(402, Lifecycle.Dormant)]
        public async Task x04_03b_predict()
        {
            await Engine.sleep(30);
            await Engine.sleep(3);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\07a_highcharity\\high_4_cinematic"), 25, true);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("scenarios\\objects\\solo\\alphagasgiant\\honor_guard\\honor_guard", 3845850053U), 0);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("scenarios\\objects\\solo\\alphagasgiant\\honor_guard\\honor_guard", 3845850053U), 1);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("scenarios\\objects\\solo\\alphagasgiant\\honor_guard\\honor_guard", 3845850053U), 2);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("scenarios\\objects\\solo\\alphagasgiant\\honor_guard\\honor_guard", 3845850053U), 3);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("scenarios\\objects\\solo\\alphagasgiant\\honor_guard\\honor_guard", 3845850053U), 4);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("scenarios\\objects\\solo\\alphagasgiant\\honor_guard\\honor_guard", 3845850053U), 5);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("scenarios\\objects\\solo\\alphagasgiant\\honor_guard\\honor_guard", 3845850053U), 6);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("scenarios\\objects\\solo\\alphagasgiant\\honor_guard\\honor_guard", 3845850053U), 7);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("scenarios\\objects\\solo\\alphagasgiant\\honor_guard\\honor_guard", 3845850053U), 8);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("scenarios\\objects\\solo\\alphagasgiant\\honor_guard\\honor_guard", 3845850053U), 9);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("scenarios\\objects\\solo\\alphagasgiant\\honor_guard\\honor_guard", 3845850053U), 10);
            await Engine.sleep(89);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\07a_highcharity\\high_4_cinematic"), 21, false);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\07a_highcharity\\high_4_cinematic"), 61, false);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\07a_highcharity\\high_4_cinematic"), 20, false);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\07a_highcharity\\high_4_cinematic"), 25, true);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\07a_highcharity\\high_4_cinematic"), 10, true);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\07a_highcharity\\high_4_cinematic"), 8, true);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\07a_highcharity\\high_4_cinematic"), 11, true);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\weapons\\melee\\gravity_hammer\\gravity_hammer", 3841459074U), 0);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\characters\\brute\\brute", 3836871484U), 26);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\characters\\brute\\brute", 3836871484U), 28);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\characters\\brute\\brute", 3836871484U), 29);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\characters\\brute\\brute", 3836871484U), 40);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\characters\\brute\\brute", 3836871484U), 36);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\characters\\brute\\brute", 3836871484U), 37);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\characters\\brute\\brute", 3836871484U), 33);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\characters\\brute\\brute", 3836871484U), 35);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\characters\\brute\\brute", 3836871484U), 34);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\characters\\dervish\\dervish", 3839689575U), 11);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\characters\\dervish\\dervish", 3839689575U), 9);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\characters\\dervish\\dervish", 3839689575U), 13);
            await Engine.sleep(141);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\07a_highcharity\\high_4_cinematic"), 26, false);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\07a_highcharity\\high_4_cinematic"), 47, false);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\07a_highcharity\\high_4_cinematic"), 67, false);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("scenarios\\objects\\solo\\highcharity\\high_door_grand\\high_door_grand", 3842769814U), 0);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("scenarios\\objects\\cinematics\\cinematic_anchor\\cinematic_anchor", 3841917833U), 0);
        }

        [ScriptMethod(403, Lifecycle.Dormant)]
        public async Task x04_04_predict()
        {
            await Engine.sleep(30);
            await Engine.sleep(4);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\07a_highcharity\\high_4_cinematic"), 43, false);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\07a_highcharity\\high_4_cinematic"), 3, true);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\07a_highcharity\\high_4_cinematic"), 4, true);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\07a_highcharity\\high_4_cinematic"), 5, true);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\07a_highcharity\\high_4_cinematic"), 6, true);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\07a_highcharity\\high_4_cinematic"), 18, true);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\07a_highcharity\\high_4_cinematic"), 20, true);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("scenarios\\objects\\solo\\alphagasgiant\\sarcophagus\\sarcophagus", 3848209385U), 1);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("scenarios\\objects\\solo\\alphagasgiant\\sarcophagus\\sarcophagus", 3848209385U), 2);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\characters\\prophet\\prophet", 3850568717U), 0);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\characters\\prophet\\prophet", 3850568717U), 1);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\characters\\prophet\\prophet", 3850568717U), 2);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\characters\\prophet\\prophet", 3850568717U), 3);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\characters\\prophet\\prophet", 3850568717U), 4);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\vehicles\\gravity_throne\\gravity_throne", 3856401510U), 3);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\vehicles\\gravity_throne\\gravity_throne", 3856401510U), 2);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\weapons\\rifle\\smg\\smg", 3856991343U), 0);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\characters\\prophet\\prophet", 3850568717U), 11);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\characters\\prophet\\prophet", 3850568717U), 12);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\characters\\prophet\\prophet", 3850568717U), 10);
            await Engine.sleep(38);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\07a_highcharity\\high_4_cinematic"), 64, false);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\07a_highcharity\\high_4_cinematic"), 48, false);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\07a_highcharity\\high_4_cinematic"), 7, true);
            await Engine.sleep(10);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\07a_highcharity\\high_4_cinematic"), 19, true);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\07a_highcharity\\high_4_cinematic"), 21, true);
            await Engine.sleep(14);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("scenarios\\objects\\solo\\highcharity\\high_door_grand\\high_door_grand", 3842769814U), 0);
            await Engine.sleep(12);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\07a_highcharity\\high_4_cinematic"), 22, true);
        }

        [ScriptMethod(404, Lifecycle.Dormant)]
        public async Task x04_05_predict()
        {
            await Engine.sleep(30);
            await Engine.sleep(5);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\weapons\\rifle\\smg\\smg", 3856991343U), 2);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\weapons\\rifle\\smg\\smg", 3856991343U), 1);
            await Engine.sleep(151);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\07a_highcharity\\high_4_cinematic"), 64, false);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\07a_highcharity\\high_4_cinematic"), 21, true);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\weapons\\rifle\\smg\\smg", 3856991343U), 2);
            await Engine.sleep(50);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("scenarios\\objects\\solo\\highcharity\\high_door_grand\\high_door_grand", 3842769814U), 0);
            await Engine.sleep(252);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\weapons\\rifle\\smg\\smg", 3856991343U), 0);
            await Engine.sleep(31);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\07a_highcharity\\high_4_cinematic"), 64, false);
            await Engine.sleep(51);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\weapons\\rifle\\smg\\smg", 3856991343U), 1);
            await Engine.sleep(14);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\weapons\\rifle\\smg\\smg", 3856991343U), 2);
            await Engine.sleep(138);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("scenarios\\objects\\solo\\highcharity\\high_door_grand\\high_door_grand", 3842769814U), 0);
            await Engine.sleep(19);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\07a_highcharity\\high_4_cinematic"), 64, false);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\07a_highcharity\\high_4_cinematic"), 42, false);
        }

        [ScriptMethod(405, Lifecycle.Dormant)]
        public async Task x04_06_predict()
        {
            await Engine.sleep(30);
            await Engine.sleep(7);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\weapons\\rifle\\smg\\smg", 3856991343U), 0);
            await Engine.sleep(90);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\07a_highcharity\\high_4_cinematic"), 64, false);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\07a_highcharity\\high_4_cinematic"), 42, false);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\weapons\\rifle\\smg\\smg", 3856991343U), 2);
            await Engine.sleep(48);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\07a_highcharity\\high_4_cinematic"), 19, true);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\weapons\\rifle\\smg\\smg", 3856991343U), 1);
            await Engine.sleep(139);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\weapons\\rifle\\smg\\smg", 3856991343U), 2);
            await Engine.sleep(99);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\07a_highcharity\\high_4_cinematic"), 42, false);
            await Engine.sleep(91);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\07a_highcharity\\high_4_cinematic"), 46, false);
            await Engine.sleep(244);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\07a_highcharity\\high_4_cinematic"), 43, false);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\07a_highcharity\\high_4_cinematic"), 4, true);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\07a_highcharity\\high_4_cinematic"), 22, true);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\weapons\\rifle\\smg\\smg", 3856991343U), 1);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\weapons\\rifle\\smg\\smg", 3856991343U), 2);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("scenarios\\objects\\solo\\highcharity\\high_door_grand\\high_door_grand", 3842769814U), 0);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\07a_highcharity\\high_4_cinematic"), 5, true);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\07a_highcharity\\high_4_cinematic"), 6, true);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\07a_highcharity\\high_4_cinematic"), 18, true);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\07a_highcharity\\high_4_cinematic"), 20, true);
        }

        [ScriptMethod(406, Lifecycle.Dormant)]
        public async Task x04_07_predict()
        {
            await Engine.sleep(30);
            await Engine.sleep(5);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\07a_highcharity\\high_4_cinematic"), 64, false);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\characters\\heretic\\heretic", 3857581176U), 9);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\characters\\heretic\\heretic", 3857581176U), 10);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\characters\\heretic\\heretic", 3857581176U), 12);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("scenarios\\objects\\solo\\highcharity\\high_door_grand\\high_door_grand", 3842769814U), 0);
            await Engine.sleep(157);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\07a_highcharity\\high_4_cinematic"), 42, false);
            await Engine.sleep(560);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\07a_highcharity\\high_4_cinematic"), 64, false);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\07a_highcharity\\high_4_cinematic"), 22, true);
        }

        [ScriptMethod(407, Lifecycle.Dormant)]
        public async Task x04_08_predict()
        {
            await Engine.sleep(30);
            await Engine.sleep(5);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\weapons\\rifle\\smg\\smg", 3856991343U), 1);
            await Engine.sleep(204);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\07a_highcharity\\high_4_cinematic"), 64, false);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\07a_highcharity\\high_4_cinematic"), 42, false);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\weapons\\rifle\\smg\\smg", 3856991343U), 2);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("scenarios\\objects\\solo\\highcharity\\high_door_grand\\high_door_grand", 3842769814U), 0);
            await Engine.sleep(232);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\07a_highcharity\\high_4_cinematic"), 48, false);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\07a_highcharity\\high_4_cinematic"), 19, true);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\07a_highcharity\\high_4_cinematic"), 7, true);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\weapons\\rifle\\smg\\smg", 3856991343U), 0);
            await Engine.sleep(230);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("scenarios\\objects\\solo\\highcharity\\high_door_grand\\high_door_grand", 3842769814U), 0);
        }

        [ScriptMethod(408, Lifecycle.Dormant)]
        public async Task x04_09_predict()
        {
            await Engine.sleep(30);
            await Engine.sleep(3);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\weapons\\rifle\\smg\\smg", 3856991343U), 1);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\weapons\\rifle\\smg\\smg", 3856991343U), 2);
            await Engine.sleep(91);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\07a_highcharity\\high_4_cinematic"), 64, false);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\07a_highcharity\\high_4_cinematic"), 21, true);
        }

        [ScriptMethod(409, Lifecycle.Dormant)]
        public async Task x04_10_predict()
        {
            await Engine.sleep(30);
            await Engine.sleep(5);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\07a_highcharity\\high_4_cinematic"), 19, true);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\weapons\\rifle\\smg\\smg", 3856991343U), 1);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\weapons\\rifle\\smg\\smg", 3856991343U), 0);
            await Engine.sleep(185);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\07a_highcharity\\high_4_cinematic"), 42, false);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\07a_highcharity\\high_4_cinematic"), 46, false);
            await Engine.sleep(208);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("scenarios\\objects\\solo\\highcharity\\high_door_grand\\high_door_grand", 3842769814U), 0);
            await Engine.sleep(103);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\07a_highcharity\\high_4_cinematic"), 19, true);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\weapons\\rifle\\smg\\smg", 3856991343U), 1);
        }

        [ScriptMethod(410, Lifecycle.Dormant)]
        public async Task _04_intro_01_predict()
        {
            await Engine.sleep(30);
            await Engine.sleep(1);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("scenarios\\skies\\solo\\alphagasgiant\\alphagasgiant", 3782934533U), 0);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("scenarios\\skies\\solo\\alphagasgiant\\alphagasgiant", 3782934533U), 1);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("scenarios\\skies\\solo\\alphagasgiant\\alphagasgiant", 3782934533U), 2);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("scenarios\\skies\\solo\\alphagasgiant\\alphagasgiant", 3782934533U), 3);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("scenarios\\skies\\solo\\alphagasgiant\\alphagasgiant", 3782934533U), 4);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("scenarios\\skies\\solo\\alphagasgiant\\alphagasgiant", 3782934533U), 5);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("scenarios\\skies\\solo\\alphagasgiant\\alphagasgiant", 3782934533U), 6);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("scenarios\\skies\\solo\\alphagasgiant\\alphagasgiant", 3782934533U), 7);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("scenarios\\skies\\solo\\alphagasgiant\\alphagasgiant", 3782934533U), 8);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("scenarios\\skies\\solo\\alphagasgiant\\alphagasgiant", 3782934533U), 9);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\04a_gasgiant\\ag_cinematic_bsp1"), 0, false);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("scenarios\\skies\\generic\\space\\space", 3785424939U), 0);
            await Engine.sleep(1);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\vehicles\\phantom\\phantom", 3858105472U), 12);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\vehicles\\phantom\\phantom", 3858105472U), 13);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\vehicles\\phantom\\phantom", 3858105472U), 14);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\vehicles\\phantom\\phantom", 3858105472U), 15);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\vehicles\\phantom\\phantom", 3858105472U), 16);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\vehicles\\phantom\\phantom", 3858105472U), 19);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\cinematics\\matte_paintings\\high_charity_stardust\\high_charity_stardust", 3858957453U), 0);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\cinematics\\matte_paintings\\high_charity_exterior\\high_charity_exterior", 3859350675U), 0);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("scenarios\\objects\\special\\null_up\\null_up", 3859547286U), 0);
            await Engine.sleep(77);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\cinematics\\matte_paintings\\threshold_space\\threshold_space", 3831431913U), 0);
            await Engine.sleep(36);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\cinematics\\matte_paintings\\high_charity_stardust\\high_charity_stardust", 3858957453U), 0);
            await Engine.sleep(3);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\cinematics\\matte_paintings\\halo_destroyed_03\\halo_destroyed_03", 3831956209U), 0);
            await Engine.sleep(11);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("scenarios\\objects\\cinematics\\cinematic_anchor\\cinematic_anchor", 3841917833U), 0);
        }

        [ScriptMethod(411, Lifecycle.Dormant)]
        public async Task _04_intro_02a_predict()
        {
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\vehicles\\phantom\\cinematics\\cinematics", 3859678360U), 0);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\characters\\grunt\\grunt", 3860006045U), 20);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\characters\\grunt\\grunt", 3860006045U), 21);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\characters\\grunt\\grunt", 3860006045U), 22);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\characters\\grunt\\grunt", 3860006045U), 23);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\characters\\grunt\\grunt", 3860006045U), 24);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("incompetent\\default_object", 3861644470U), 0);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\characters\\elite\\elite", 3861710007U), 25);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\characters\\elite\\elite", 3861710007U), 30);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\characters\\elite\\elite", 3861710007U), 27);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\characters\\elite\\elite", 3861710007U), 32);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\weapons\\rifle\\plasma_rifle\\plasma_rifle", 3794469045U), 0);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\weapons\\rifle\\beam_rifle\\beam_rifle", 3863676117U), 1);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\weapons\\rifle\\plasma_rifle\\plasma_rifle", 3794469045U), 1);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\characters\\elite\\elite", 3861710007U), 26);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\characters\\dervish\\dervish", 3839689575U), 8);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\characters\\dervish\\dervish", 3839689575U), 10);
            await Engine.sleep(3);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("scenarios\\skies\\solo\\alphagasgiant\\no_structure\\no_structure", 3786604605U), 0);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("scenarios\\skies\\solo\\alphagasgiant\\no_structure\\no_structure", 3786604605U), 1);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("scenarios\\skies\\solo\\alphagasgiant\\no_structure\\no_structure", 3786604605U), 2);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("scenarios\\skies\\solo\\alphagasgiant\\no_structure\\no_structure", 3786604605U), 3);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("scenarios\\skies\\solo\\alphagasgiant\\no_structure\\no_structure", 3786604605U), 4);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("scenarios\\skies\\solo\\alphagasgiant\\no_structure\\no_structure", 3786604605U), 5);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("scenarios\\skies\\solo\\alphagasgiant\\no_structure\\no_structure", 3786604605U), 6);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("scenarios\\skies\\solo\\alphagasgiant\\no_structure\\no_structure", 3786604605U), 7);
            await Engine.sleep(7);
            await Engine.sleep(146);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\weapons\\rifle\\plasma_rifle\\plasma_rifle", 3794469045U), 2);
            await Engine.sleep(84);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\weapons\\rifle\\beam_rifle\\beam_rifle", 3863676117U), 2);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("scenarios\\objects\\cinematics\\cinematic_anchor\\cinematic_anchor", 3841917833U), 0);
            await Engine.sleep(69);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\weapons\\rifle\\plasma_rifle\\plasma_rifle", 3794469045U), 2);
            await Engine.sleep(91);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("incompetent\\default_object", 3861644470U), 0);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\weapons\\rifle\\plasma_rifle\\plasma_rifle", 3794469045U), 3);
            await Engine.sleep(135);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("scenarios\\objects\\cinematics\\cinematic_anchor\\cinematic_anchor", 3841917833U), 0);
        }

        [ScriptMethod(412, Lifecycle.Dormant)]
        public async Task _04_intro_02b_predict()
        {
            await Engine.sleep(30);
            await Engine.sleep(7);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("incompetent\\default_object", 3861644470U), 0);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\weapons\\rifle\\plasma_rifle\\plasma_rifle", 3794469045U), 0);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\weapons\\rifle\\plasma_rifle\\plasma_rifle", 3794469045U), 1);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\characters\\dervish\\dervish", 3839689575U), 8);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\characters\\dervish\\dervish", 3839689575U), 10);
            await Engine.sleep(1);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\weapons\\rifle\\plasma_rifle\\plasma_rifle", 3794469045U), 2);
        }

        [ScriptMethod(413, Lifecycle.Dormant)]
        public async Task _04_intro_02c_predict()
        {
            await Engine.sleep(2);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\vehicles\\phantom\\phantom", 3858105472U), 12);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\vehicles\\phantom\\phantom", 3858105472U), 13);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\vehicles\\phantom\\phantom", 3858105472U), 14);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\vehicles\\phantom\\phantom", 3858105472U), 15);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\vehicles\\phantom\\phantom", 3858105472U), 16);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\vehicles\\phantom\\phantom", 3858105472U), 19);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\characters\\dervish\\dervish", 3839689575U), 8);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\characters\\dervish\\dervish", 3839689575U), 10);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\cinematics\\matte_paintings\\gas_giant_structure_top\\gas_giant_structure_top", 3864790246U), 0);
        }

        [ScriptMethod(414, Lifecycle.Dormant)]
        public async Task _04_intro_02d_predict()
        {
            await Engine.sleep(2);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\characters\\elite\\elite", 3861710007U), 25);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\characters\\elite\\elite", 3861710007U), 26);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\characters\\elite\\elite", 3861710007U), 27);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\characters\\elite\\elite", 3861710007U), 32);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\characters\\dervish\\dervish", 3839689575U), 8);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\characters\\dervish\\dervish", 3839689575U), 10);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\vehicles\\phantom\\cinematics\\cinematics", 3859678360U), 0);
            await Engine.sleep(301);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\vehicles\\phantom\\phantom", 3858105472U), 12);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\vehicles\\phantom\\phantom", 3858105472U), 13);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\vehicles\\phantom\\phantom", 3858105472U), 14);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\vehicles\\phantom\\phantom", 3858105472U), 15);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\vehicles\\phantom\\phantom", 3858105472U), 16);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\vehicles\\phantom\\phantom", 3858105472U), 19);
            await Engine.sleep(208);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\cinematics\\matte_paintings\\gas_giant_structure\\gas_giant_structure", 3864986857U), 0);
        }

        [ScriptMethod(415, Lifecycle.Dormant)]
        public async Task _04_intro_03_predict()
        {
            await Engine.sleep(178);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\cinematics\\matte_paintings\\gas_giant_exterior\\gas_giant_exterior", 3865183468U), 0);
            await Engine.sleep(2);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("scenarios\\objects\\cinematics\\cinematic_anchor\\cinematic_anchor", 3841917833U), 0);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\vehicles\\phantom\\phantom", 3858105472U), 0);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\vehicles\\phantom\\phantom", 3858105472U), 1);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\vehicles\\phantom\\phantom", 3858105472U), 2);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\vehicles\\phantom\\phantom", 3858105472U), 3);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("scenarios\\objects\\solo\\alphagasgiant\\ext_structures\\ext_structures_vent_1\\ext_structures_vent_1", 3865380079U), 0);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("scenarios\\objects\\cinematics\\cinematic_anchor\\cinematic_anchor", 3841917833U), 0);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("scenarios\\objects\\forerunner\\industrial\\doors\\door_tron_lg\\door_tron_lg", 3866035449U), 0);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("scenarios\\objects\\forerunner\\industrial\\holo_panels\\holo_generic\\holo_generic", 3867149578U), 0);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("scenarios\\objects\\forerunner\\industrial\\doors\\door_cargo_hangar_scenery\\door_cargo_hangar_scenery", 3867477263U), 0);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("scenarios\\skies\\solo\\alphagasgiant\\alphagasgiant", 3782934533U), 0);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("scenarios\\skies\\solo\\alphagasgiant\\alphagasgiant", 3782934533U), 1);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("scenarios\\skies\\solo\\alphagasgiant\\alphagasgiant", 3782934533U), 2);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("scenarios\\skies\\solo\\alphagasgiant\\alphagasgiant", 3782934533U), 3);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("scenarios\\skies\\solo\\alphagasgiant\\alphagasgiant", 3782934533U), 4);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("scenarios\\skies\\solo\\alphagasgiant\\alphagasgiant", 3782934533U), 5);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("scenarios\\skies\\solo\\alphagasgiant\\alphagasgiant", 3782934533U), 6);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("scenarios\\skies\\solo\\alphagasgiant\\alphagasgiant", 3782934533U), 7);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("scenarios\\skies\\solo\\alphagasgiant\\alphagasgiant", 3782934533U), 8);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("scenarios\\skies\\solo\\alphagasgiant\\alphagasgiant", 3782934533U), 9);
        }

        [ScriptMethod(416, Lifecycle.Dormant)]
        public async Task _04_intro_05_predict()
        {
            await Engine.sleep(2);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\04a_gasgiant\\alphagasgiant"), 36, false);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\04a_gasgiant\\alphagasgiant"), 40, false);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\04a_gasgiant\\alphagasgiant"), 15, false);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\04a_gasgiant\\alphagasgiant"), 37, false);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\04a_gasgiant\\alphagasgiant"), 74, false);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\04a_gasgiant\\alphagasgiant"), 11, false);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\04a_gasgiant\\alphagasgiant"), 33, false);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\04a_gasgiant\\alphagasgiant"), 56, false);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\04a_gasgiant\\alphagasgiant"), 78, false);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\04a_gasgiant\\alphagasgiant"), 34, false);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\04a_gasgiant\\alphagasgiant"), 53, false);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\04a_gasgiant\\alphagasgiant"), 14, false);
            await Engine.sleep(4);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\04a_gasgiant\\alphagasgiant"), 5, true);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\04a_gasgiant\\alphagasgiant"), 0, true);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\04a_gasgiant\\alphagasgiant"), 3, true);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\04a_gasgiant\\alphagasgiant"), 8, true);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\04a_gasgiant\\alphagasgiant"), 9, true);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\04a_gasgiant\\alphagasgiant"), 59, true);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\04a_gasgiant\\alphagasgiant"), 6, true);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\04a_gasgiant\\alphagasgiant"), 60, true);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\04a_gasgiant\\alphagasgiant"), 7, true);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\04a_gasgiant\\alphagasgiant"), 4, true);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\04a_gasgiant\\alphagasgiant"), 2, true);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\04a_gasgiant\\alphagasgiant"), 15, true);
            await Engine.sleep(4);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\04a_gasgiant\\alphagasgiant"), 38, false);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\04a_gasgiant\\alphagasgiant"), 27, false);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\04a_gasgiant\\alphagasgiant"), 20, false);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\04a_gasgiant\\alphagasgiant"), 41, false);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\04a_gasgiant\\alphagasgiant"), 12, false);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\04a_gasgiant\\alphagasgiant"), 90, false);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\04a_gasgiant\\alphagasgiant"), 73, false);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\04a_gasgiant\\alphagasgiant"), 30, false);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\04a_gasgiant\\alphagasgiant"), 10, false);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\04a_gasgiant\\alphagasgiant"), 1, false);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\04a_gasgiant\\alphagasgiant"), 5, false);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\04a_gasgiant\\alphagasgiant"), 45, false);
            await Engine.sleep(4);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\04a_gasgiant\\alphagasgiant"), 77, false);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\04a_gasgiant\\alphagasgiant"), 22, false);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\04a_gasgiant\\alphagasgiant"), 0, false);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\04a_gasgiant\\alphagasgiant"), 80, false);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\04a_gasgiant\\alphagasgiant"), 29, false);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\04a_gasgiant\\alphagasgiant"), 16, false);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\04a_gasgiant\\alphagasgiant"), 32, false);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\04a_gasgiant\\alphagasgiant"), 3, false);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\04a_gasgiant\\alphagasgiant"), 31, false);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\04a_gasgiant\\alphagasgiant"), 72, false);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\04a_gasgiant\\alphagasgiant"), 93, false);
            await Engine.sleep(3);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\04a_gasgiant\\alphagasgiant"), 9, false);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\04a_gasgiant\\alphagasgiant"), 68, false);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\04a_gasgiant\\alphagasgiant"), 57, false);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\04a_gasgiant\\alphagasgiant"), 101, false);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\04a_gasgiant\\alphagasgiant"), 98, false);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\04a_gasgiant\\alphagasgiant"), 79, false);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\04a_gasgiant\\alphagasgiant"), 2, false);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\04a_gasgiant\\alphagasgiant"), 43, false);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\04a_gasgiant\\alphagasgiant"), 100, false);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\04a_gasgiant\\alphagasgiant"), 13, true);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\04a_gasgiant\\alphagasgiant"), 1, true);
            await Engine.sleep(5);
            await Engine.sleep(4);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\vehicles\\phantom\\phantom", 3858105472U), 0);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\vehicles\\phantom\\phantom", 3858105472U), 1);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\vehicles\\phantom\\phantom", 3858105472U), 2);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\vehicles\\phantom\\phantom", 3858105472U), 19);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\vehicles\\phantom\\phantom", 3858105472U), 3);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\vehicles\\phantom\\turrets\\chin_gun\\chin_gun", 3867804948U), 0);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\vehicles\\phantom\\turrets\\chin_gun\\chin_gun", 3867804948U), 1);
            await Engine.sleep(6);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\04a_gasgiant\\alphagasgiant"), 15, true);
            await Engine.sleep(10);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\04a_gasgiant\\alphagasgiant"), 15, true);
            await Engine.sleep(10);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\04a_gasgiant\\alphagasgiant"), 15, true);
            await Engine.sleep(62);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\04a_gasgiant\\alphagasgiant"), 4, false);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\characters\\dervish\\dervish", 3839689575U), 0);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\characters\\dervish\\dervish", 3839689575U), 1);
            await Engine.sleep(7);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\04a_gasgiant\\alphagasgiant"), 57, true);
        }

        [ScriptMethod(417, Lifecycle.Dormant)]
        public async Task _04_intro_06b_predict()
        {
            await Engine.sleep(2);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\vehicles\\phantom\\phantom", 3858105472U), 6);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\vehicles\\phantom\\phantom", 3858105472U), 7);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\vehicles\\phantom\\phantom", 3858105472U), 8);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\vehicles\\phantom\\phantom", 3858105472U), 9);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\vehicles\\phantom\\turrets\\chin_gun\\chin_gun", 3867804948U), 3);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\vehicles\\phantom\\turrets\\chin_gun\\chin_gun", 3867804948U), 4);
            await Engine.sleep(34);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\vehicles\\phantom\\phantom", 3858105472U), 12);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\vehicles\\phantom\\phantom", 3858105472U), 13);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\vehicles\\phantom\\phantom", 3858105472U), 14);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\vehicles\\phantom\\phantom", 3858105472U), 16);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\vehicles\\phantom\\turrets\\chin_gun\\chin_gun", 3867804948U), 6);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\vehicles\\phantom\\turrets\\chin_gun\\chin_gun", 3867804948U), 7);
            await Engine.sleep(54);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\04a_gasgiant\\alphagasgiant"), 30, false);
            await Engine.sleep(14);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("scenarios\\objects\\solo\\alphagasgiant\\ext_structures\\ext_structures_vent_1\\ext_structures_vent_1", 3865380079U), 0);
            await Engine.sleep(39);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("scenarios\\objects\\solo\\alphagasgiant\\ext_structures\\ext_structures_vent_1\\ext_structures_vent_1", 3865380079U), 0);
            await Engine.sleep(2);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\04a_gasgiant\\alphagasgiant"), 30, false);
            await Engine.sleep(2);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\vehicles\\phantom\\phantom", 3858105472U), 6);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\vehicles\\phantom\\phantom", 3858105472U), 7);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\vehicles\\phantom\\phantom", 3858105472U), 8);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\vehicles\\phantom\\phantom", 3858105472U), 9);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\vehicles\\phantom\\turrets\\chin_gun\\chin_gun", 3867804948U), 3);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\vehicles\\phantom\\turrets\\chin_gun\\chin_gun", 3867804948U), 4);
            await Engine.sleep(6);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\04a_gasgiant\\alphagasgiant"), 55, true);
            await Engine.sleep(1);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\04a_gasgiant\\alphagasgiant"), 10, false);
            await Engine.sleep(3);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\04a_gasgiant\\alphagasgiant"), 31, false);
            await Engine.sleep(1);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\04a_gasgiant\\alphagasgiant"), 2, false);
            await Engine.sleep(10);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\04a_gasgiant\\alphagasgiant"), 44, true);
            await Engine.sleep(7);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\04a_gasgiant\\alphagasgiant"), 29, false);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\04a_gasgiant\\alphagasgiant"), 79, false);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\04a_gasgiant\\alphagasgiant"), 72, false);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\04a_gasgiant\\alphagasgiant"), 59, true);
            await Engine.sleep(1);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\04a_gasgiant\\alphagasgiant"), 100, false);
            await Engine.sleep(5);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\characters\\grunt\\grunt", 3860006045U), 20);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\characters\\grunt\\grunt", 3860006045U), 21);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\characters\\grunt\\grunt", 3860006045U), 22);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\characters\\grunt\\grunt", 3860006045U), 23);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\characters\\grunt\\grunt", 3860006045U), 24);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("incompetent\\default_object", 3861644470U), 0);
            await Engine.sleep(3);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\04a_gasgiant\\alphagasgiant"), 68, false);
            await Engine.sleep(3);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\characters\\elite\\elite", 3861710007U), 25);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\characters\\elite\\elite", 3861710007U), 30);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\characters\\elite\\elite", 3861710007U), 27);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\characters\\elite\\elite", 3861710007U), 32);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\weapons\\rifle\\plasma_rifle\\plasma_rifle", 3794469045U), 0);
            await Engine.sleep(88);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\weapons\\rifle\\plasma_rifle\\plasma_rifle", 3794469045U), 1);
            await Engine.sleep(34);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\vehicles\\phantom\\phantom", 3858105472U), 12);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\vehicles\\phantom\\phantom", 3858105472U), 13);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\vehicles\\phantom\\phantom", 3858105472U), 14);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\vehicles\\phantom\\phantom", 3858105472U), 16);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\vehicles\\phantom\\turrets\\chin_gun\\chin_gun", 3867804948U), 6);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\vehicles\\phantom\\turrets\\chin_gun\\chin_gun", 3867804948U), 7);
            await Engine.sleep(11);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\characters\\dervish\\dervish", 3839689575U), 8);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\characters\\dervish\\dervish", 3839689575U), 10);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\weapons\\melee\\energy_blade\\energy_blade", 3786801216U), 6);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\weapons\\melee\\energy_blade\\energy_blade", 3786801216U), 1);
            await Engine.sleep(45);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\weapons\\melee\\energy_blade\\energy_blade", 3786801216U), 3);
            await Engine.sleep(22);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\weapons\\melee\\energy_blade\\energy_blade", 3786801216U), 2);
            await Engine.sleep(6);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\weapons\\melee\\energy_blade\\energy_blade", 3786801216U), 4);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\weapons\\melee\\energy_blade\\energy_blade", 3786801216U), 5);
            await Engine.sleep(34);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\vehicles\\phantom\\phantom", 3858105472U), 6);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\vehicles\\phantom\\phantom", 3858105472U), 7);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\vehicles\\phantom\\phantom", 3858105472U), 8);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\vehicles\\phantom\\phantom", 3858105472U), 9);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\vehicles\\phantom\\turrets\\chin_gun\\chin_gun", 3867804948U), 3);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\vehicles\\phantom\\turrets\\chin_gun\\chin_gun", 3867804948U), 4);
        }

        [ScriptMethod(418, Lifecycle.Static)]
        public async Task teleport_hangar()
        {
            Engine.ai_erase_all();
            Engine.ai_place(allies_elites_01.Squad);
            Engine.ai_place(allies_grunts_01.Squad, 1);
            Engine.ai_place(hacker.Squad);
            Engine.switch_bsp(3);
            Engine.object_teleport(await this.player0(), hangar_top_player0);
            Engine.object_teleport(await this.player1(), hangar_top_player1);
            Engine.object_teleport(Engine.list_get(Engine.ai_actors(allies_elites_01.Squad), 0), hangar_top_ally01);
            Engine.object_teleport(Engine.list_get(Engine.ai_actors(hacker.Squad), 0), hangar_top_ally02);
            Engine.object_teleport(Engine.list_get(Engine.ai_actors(allies_grunts_01.Squad), 0), hangar_top_ally03);
            Engine.device_set_position_immediate(elev_hangar.Entity, 0F);
            Engine.sleep_forever(new ScriptMethodReference(mission));
            await this.sleep_intro();
            await this.sleep_rec_center();
            Engine.ai_set_orders(arm01_allies, get_on_hangar_elev);
            await Engine.sleep_until(async () => Engine.volume_test_objects(vol_on_hangar_lift_top, Engine.players()) == true);
            Engine.game_save();
            Engine.wake(new ScriptMethodReference(hangar_firsttime_start));
            Engine.wake(new ScriptMethodReference(to_underhangar_firsttime));
            Engine.device_one_sided_set(rec_center_entry_ext.Entity, true);
            Engine.device_one_sided_set(rec_center_entry_int.Entity, true);
            await Engine.sleep_until(async () => Engine.volume_test_objects(vol_underhangar_from_top, Engine.players()) == true);
            Engine.wake(new ScriptMethodReference(underhangar_firsttime_start));
            Engine.wake(new ScriptMethodReference(to_bottling));
            await this.sleep_rec_center();
            await this.sleep_hangar();
            this.recycling_power_on = false;
            this.hangar_power_on = false;
            Engine.device_one_sided_set(hangar_exit.Entity, true);
            await Engine.sleep_until(async () => (short)Engine.structure_bsp_index() == 0);
            Engine.wake(new ScriptMethodReference(bottling_firsttime_start));
            Engine.wake(new ScriptMethodReference(bottling_plant_end));
            await this.sleep_first_halls();
            await this.sleep_underhangar();
            this.underhangar_power_on = false;
            Engine.device_one_sided_set(underhangar_entry.Entity, true);
            Engine.device_one_sided_set(underhangar_exit.Entity, true);
            await Engine.sleep_until(async () => Engine.vehicle_test_seat(Engine.ai_vehicle_get_from_starting_location(ledge_banshees_01.left), "banshee_d", Engine.unit(await this.player0())) == true || Engine.vehicle_test_seat(Engine.ai_vehicle_get_from_starting_location(ledge_banshees_01.right), "banshee_d", Engine.unit(await this.player0())) == true || Engine.vehicle_test_seat(Engine.ai_vehicle_get_from_starting_location(ledge_banshees_01.left), "banshee_d", Engine.unit(await this.player1())) == true || Engine.vehicle_test_seat(Engine.ai_vehicle_get_from_starting_location(ledge_banshees_01.right), "banshee_d", Engine.unit(await this.player1())) == true);
            Engine.wake(new ScriptMethodReference(dogfight_firsttime_start));
            Engine.wake(new ScriptMethodReference(arm_02_entry_win));
            await this.sleep_second_halls();
            await this.sleep_bottling();
            this.bottling_power_on = false;
            Engine.device_operates_automatically_set(rec_center_entry_ext.Entity, false);
            Engine.device_one_sided_set(bottling_entry.Entity, true);
            Engine.device_one_sided_set(bottling_midway.Entity, true);
            Engine.device_one_sided_set(viewroom_entry.Entity, true);
            await Engine.sleep_until(async () => Engine.unit_in_vehicle(await this.player0()) && Engine.unit_in_vehicle(await this.player1()) || Engine.unit_in_vehicle(await this.player0()) && (bool)Engine.game_is_cooperative() == false);
        }

        [ScriptMethod(419, Lifecycle.Static)]
        public async Task teleport_underhangar()
        {
            Engine.ai_erase_all();
            Engine.ai_place(allies_elites_01.Squad);
            Engine.ai_place(hacker.Squad);
            Engine.switch_bsp(3);
            Engine.object_teleport(await this.player0(), underhangar_player0);
            Engine.object_teleport(await this.player1(), underhangar_player1);
            Engine.object_teleport(Engine.list_get(Engine.ai_actors(allies_elites_01.Squad), 0), underhangar_ally01);
            Engine.object_teleport(Engine.list_get(Engine.ai_actors(hacker.Squad), 0), underhangar_ally02);
            Engine.sleep_forever(new ScriptMethodReference(mission));
            await this.sleep_intro();
            await this.sleep_rec_center();
            await this.sleep_first_halls();
            await this.sleep_hangar();
            Engine.device_one_sided_set(rec_center_entry_ext.Entity, true);
            Engine.device_one_sided_set(rec_center_entry_int.Entity, true);
            Engine.game_save();
            Engine.wake(new ScriptMethodReference(underhangar_firsttime_start));
            Engine.wake(new ScriptMethodReference(to_bottling));
            this.recycling_power_on = false;
            this.hangar_power_on = false;
            Engine.device_one_sided_set(hangar_exit.Entity, true);
            await Engine.sleep_until(async () => (short)Engine.structure_bsp_index() == 0);
            Engine.wake(new ScriptMethodReference(bottling_firsttime_start));
            Engine.wake(new ScriptMethodReference(bottling_plant_end));
            await this.sleep_first_halls();
            await this.sleep_underhangar();
            this.underhangar_power_on = false;
            Engine.device_one_sided_set(underhangar_entry.Entity, true);
            Engine.device_one_sided_set(underhangar_exit.Entity, true);
            await Engine.sleep_until(async () => Engine.vehicle_test_seat(Engine.ai_vehicle_get_from_starting_location(ledge_banshees_01.left), "banshee_d", Engine.unit(await this.player0())) == true || Engine.vehicle_test_seat(Engine.ai_vehicle_get_from_starting_location(ledge_banshees_01.right), "banshee_d", Engine.unit(await this.player0())) == true || Engine.vehicle_test_seat(Engine.ai_vehicle_get_from_starting_location(ledge_banshees_01.left), "banshee_d", Engine.unit(await this.player1())) == true || Engine.vehicle_test_seat(Engine.ai_vehicle_get_from_starting_location(ledge_banshees_01.right), "banshee_d", Engine.unit(await this.player1())) == true);
            Engine.wake(new ScriptMethodReference(dogfight_firsttime_start));
            Engine.wake(new ScriptMethodReference(arm_02_entry_win));
            await this.sleep_second_halls();
            await this.sleep_bottling();
            this.bottling_power_on = false;
            Engine.device_operates_automatically_set(rec_center_entry_ext.Entity, false);
            Engine.device_one_sided_set(bottling_entry.Entity, true);
            Engine.device_one_sided_set(bottling_midway.Entity, true);
            Engine.device_one_sided_set(viewroom_entry.Entity, true);
            await Engine.sleep_until(async () => Engine.unit_in_vehicle(await this.player0()) && Engine.unit_in_vehicle(await this.player1()) || Engine.unit_in_vehicle(await this.player0()) && (bool)Engine.game_is_cooperative() == false);
        }

        [ScriptMethod(420, Lifecycle.Static)]
        public async Task teleport_bottling()
        {
            Engine.ai_erase_all();
            Engine.ai_place(allies_elites_01.Squad);
            Engine.switch_bsp(0);
            Engine.object_teleport(await this.player0(), bottling_player0);
            Engine.object_teleport(await this.player1(), bottling_player1);
            Engine.object_teleport(Engine.list_get(Engine.ai_actors(allies_elites_01.Squad), 0), bottling_ally01);
            Engine.sleep_forever(new ScriptMethodReference(mission));
            await this.sleep_intro();
            await this.sleep_rec_center();
            await this.sleep_hangar();
            await this.sleep_first_halls();
            await this.sleep_underhangar();
            await this.sleep_second_halls();
            Engine.device_one_sided_set(rec_center_entry_ext.Entity, true);
            Engine.device_one_sided_set(rec_center_entry_int.Entity, true);
            Engine.device_one_sided_set(hangar_exit.Entity, true);
            Engine.game_save();
            Engine.wake(new ScriptMethodReference(bottling_firsttime_start));
            Engine.wake(new ScriptMethodReference(bottling_plant_end));
            await this.sleep_first_halls();
            await this.sleep_underhangar();
            this.underhangar_power_on = false;
            Engine.device_one_sided_set(underhangar_entry.Entity, true);
            Engine.device_one_sided_set(underhangar_exit.Entity, true);
            await Engine.sleep_until(async () => Engine.vehicle_test_seat(Engine.ai_vehicle_get_from_starting_location(ledge_banshees_01.left), "banshee_d", Engine.unit(await this.player0())) == true || Engine.vehicle_test_seat(Engine.ai_vehicle_get_from_starting_location(ledge_banshees_01.right), "banshee_d", Engine.unit(await this.player0())) == true || Engine.vehicle_test_seat(Engine.ai_vehicle_get_from_starting_location(ledge_banshees_01.left), "banshee_d", Engine.unit(await this.player1())) == true || Engine.vehicle_test_seat(Engine.ai_vehicle_get_from_starting_location(ledge_banshees_01.right), "banshee_d", Engine.unit(await this.player1())) == true);
            Engine.wake(new ScriptMethodReference(dogfight_firsttime_start));
            Engine.wake(new ScriptMethodReference(arm_02_entry_win));
            await this.sleep_second_halls();
            await this.sleep_bottling();
            this.bottling_power_on = false;
            Engine.device_operates_automatically_set(rec_center_entry_ext.Entity, false);
            Engine.device_one_sided_set(bottling_entry.Entity, true);
            Engine.device_one_sided_set(bottling_midway.Entity, true);
            Engine.device_one_sided_set(viewroom_entry.Entity, true);
            await Engine.sleep_until(async () => Engine.unit_in_vehicle(await this.player0()) && Engine.unit_in_vehicle(await this.player1()) || Engine.unit_in_vehicle(await this.player0()) && (bool)Engine.game_is_cooperative() == false);
        }

        [ScriptMethod(421, Lifecycle.Static)]
        public async Task teleport_banshee()
        {
            Engine.ai_erase_all();
            Engine.switch_bsp(0);
            Engine.ai_place(ledge_banshees_01.left);
            Engine.ai_place(ledge_banshees_01.right);
            Engine.ai_place(dog_turrets_01.Squad);
            Engine.object_teleport(await this.player0(), banshee_ledge_player0);
            Engine.object_teleport(await this.player1(), banshee_ledge_player1);
            Engine.wake(new ScriptMethodReference(bring_in_da_phantom));
            Engine.sleep_forever(new ScriptMethodReference(mission));
            await this.sleep_intro();
            await this.sleep_rec_center();
            await this.sleep_hangar();
            await this.sleep_first_halls();
            await this.sleep_underhangar();
            await this.sleep_second_halls();
            await this.sleep_bottling();
            Engine.device_one_sided_set(rec_center_entry_ext.Entity, true);
            Engine.device_one_sided_set(rec_center_entry_int.Entity, true);
            Engine.device_one_sided_set(hangar_exit.Entity, true);
            Engine.device_one_sided_set(underhangar_entry.Entity, true);
            Engine.device_one_sided_set(underhangar_exit.Entity, true);
            Engine.wake(new ScriptMethodReference(bring_in_da_phantom));
            Engine.game_save();
            await Engine.sleep_until(async () => Engine.vehicle_test_seat(Engine.ai_vehicle_get_from_starting_location(ledge_banshees_01.left), "banshee_d", Engine.unit(await this.player0())) == true || Engine.vehicle_test_seat(Engine.ai_vehicle_get_from_starting_location(ledge_banshees_01.right), "banshee_d", Engine.unit(await this.player0())) == true || Engine.vehicle_test_seat(Engine.ai_vehicle_get_from_starting_location(ledge_banshees_01.left), "banshee_d", Engine.unit(await this.player1())) == true || Engine.vehicle_test_seat(Engine.ai_vehicle_get_from_starting_location(ledge_banshees_01.right), "banshee_d", Engine.unit(await this.player1())) == true);
            Engine.wake(new ScriptMethodReference(dogfight_firsttime_start));
            Engine.wake(new ScriptMethodReference(arm_02_entry_win));
            await this.sleep_second_halls();
            await this.sleep_bottling();
            this.bottling_power_on = false;
            Engine.device_operates_automatically_set(rec_center_entry_ext.Entity, false);
            Engine.device_one_sided_set(bottling_entry.Entity, true);
            Engine.device_one_sided_set(bottling_midway.Entity, true);
            Engine.device_one_sided_set(viewroom_entry.Entity, true);
            await Engine.sleep_until(async () => Engine.unit_in_vehicle(await this.player0()) && Engine.unit_in_vehicle(await this.player1()) || Engine.unit_in_vehicle(await this.player0()) && (bool)Engine.game_is_cooperative() == false);
        }
    }
}