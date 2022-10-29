namespace OpenH2.Scripts.Generatedscenarios.solo
{
    using System;
    using System.Threading.Tasks;
    using OpenH2.Core.Architecture;
    using OpenH2.Core.Tags;
    using OpenH2.Core.Tags.Scenario;
    using OpenH2.Core.Scripting;
    using OpenH2.Core.GameObjects;

    public partial class scnr_04b_floodlab : ScenarioScriptBase
    {
        public ScenarioEntity<IScenery> outro_seraph { get; set; }
        public ScenarioEntity<IScenery> holo_drone_2 { get; set; }
        public ScenarioEntity<IScenery> holo_drone_1 { get; set; }
        public ScenarioEntity<IBloc> can01 { get; set; }
        public ScenarioEntity<IBloc> can02 { get; set; }
        public ScenarioEntity<IBloc> can03 { get; set; }
        public ScenarioEntity<IBloc> can04 { get; set; }
        public ScenarioEntity<IBloc> can05 { get; set; }
        public ScenarioEntity<IBloc> croom_junk_01 { get; set; }
        public ScenarioEntity<IBloc> croom_junk_02 { get; set; }
        public ScenarioEntity<IBloc> croom_junk_03 { get; set; }
        public ScenarioEntity<IBloc> croom_junk_04 { get; set; }
        public ScenarioEntity<IBloc> croom_junk_05 { get; set; }
        public ScenarioEntity<IBloc> croom_junk_06 { get; set; }
        public ScenarioEntity<IBloc> croom_junk_07 { get; set; }
        public ScenarioEntity<IBloc> croom_junk_08 { get; set; }
        public ScenarioEntity<IBloc> croom_junk_09 { get; set; }
        public ScenarioEntity<IBloc> croom_junk_10 { get; set; }
        public ScenarioEntity<IBloc> croom_junk_11 { get; set; }
        public ScenarioEntity<IBloc> croom_junk_12 { get; set; }
        public ScenarioEntity<IBloc> croom_junk_13 { get; set; }
        public ScenarioEntity<IBloc> croom_junk_14 { get; set; }
        public ScenarioEntity<IBloc> croom_junk_15 { get; set; }
        public ScenarioEntity<IBloc> croom_junk_16 { get; set; }
        public ScenarioEntity<IBloc> croom_junk_17 { get; set; }
        public ScenarioEntity<IScenery> anchor02 { get; set; }
        public ScenarioEntity<IScenery> hammer { get; set; }
        public ScenarioEntity<IBloc> dummy_can { get; set; }
        public ScenarioEntity<IBloc> can06 { get; set; }
        public ScenarioEntity<IScenery> cap_01_1 { get; set; }
        public ScenarioEntity<IScenery> cap_01_5 { get; set; }
        public ScenarioEntity<IScenery> cap_01_6 { get; set; }
        public ScenarioEntity<IScenery> cap_01_7 { get; set; }
        public ScenarioEntity<IScenery> cap_01_8 { get; set; }
        public ScenarioEntity<IScenery> cap_01_2 { get; set; }
        public ScenarioEntity<IScenery> cap_01_3 { get; set; }
        public ScenarioEntity<IScenery> cap_01_4 { get; set; }
        public ScenarioEntity<IScenery> cap_01_9 { get; set; }
        public ScenarioEntity<IScenery> cap_01_10 { get; set; }
        public ScenarioEntity<IScenery> cap_01_11 { get; set; }
        public ScenarioEntity<IScenery> cap_01_12 { get; set; }
        public ScenarioEntity<IScenery> cap_02_1 { get; set; }
        public ScenarioEntity<IScenery> cap_02_2 { get; set; }
        public ScenarioEntity<IScenery> cap_02_3 { get; set; }
        public ScenarioEntity<IScenery> stop_02 { get; set; }
        public ScenarioEntity<IScenery> cap_02_5 { get; set; }
        public ScenarioEntity<IScenery> cap_02_7 { get; set; }
        public ScenarioEntity<IScenery> cap_02_6 { get; set; }
        public ScenarioEntity<IScenery> cap_02_8 { get; set; }
        public ScenarioEntity<IScenery> cap_02_9 { get; set; }
        public ScenarioEntity<IScenery> cap_02_10 { get; set; }
        public ScenarioEntity<IScenery> cap_02_11 { get; set; }
        public ScenarioEntity<IScenery> cap_03_4 { get; set; }
        public ScenarioEntity<IScenery> cap_03_3 { get; set; }
        public ScenarioEntity<IScenery> cap_03_2 { get; set; }
        public ScenarioEntity<IScenery> cap_03_1 { get; set; }
        public ScenarioEntity<IScenery> cap_03_5 { get; set; }
        public ScenarioEntity<IScenery> cap_03_6 { get; set; }
        public ScenarioEntity<IScenery> cap_03_7 { get; set; }
        public ScenarioEntity<IScenery> cap_03_8 { get; set; }
        public ScenarioEntity<IScenery> cap_04_1 { get; set; }
        public ScenarioEntity<IScenery> cap_04_2 { get; set; }
        public ScenarioEntity<IScenery> cap_04_3 { get; set; }
        public ScenarioEntity<IScenery> cap_04_4 { get; set; }
        public ScenarioEntity<IScenery> cap_04_5 { get; set; }
        public ScenarioEntity<IScenery> cap_04_6 { get; set; }
        public ScenarioEntity<IScenery> cap_04_7 { get; set; }
        public ScenarioEntity<IScenery> cap_04_8 { get; set; }
        public ScenarioEntity<IScenery> cap_04_9 { get; set; }
        public ScenarioEntity<IScenery> cap_04_10 { get; set; }
        public ScenarioEntity<IScenery> cap_04_11 { get; set; }
        public ScenarioEntity<IScenery> cap_04_12 { get; set; }
        public ScenarioEntity<IScenery> stop_01 { get; set; }
        public ScenarioEntity<IScenery> cap_02_4 { get; set; }
        public ScenarioEntity<IScenery> stop_03 { get; set; }
        public ScenarioEntity<IScenery> stop_04 { get; set; }
        public ScenarioEntity<IScenery> stop_06 { get; set; }
        public ScenarioEntity<IScenery> stop_05 { get; set; }
        public ScenarioEntity<IScenery> anchor_intra0 { get; set; }
        public ScenarioEntity<IScenery> pr_intra0_der { get; set; }
        public ScenarioEntity<IScenery> eb_intra0_soc { get; set; }
        public ScenarioEntity<IScenery> pr_intra0_soe_01 { get; set; }
        public ScenarioEntity<IScenery> pr_intra0_soe_02 { get; set; }
        public ScenarioEntity<IScenery> pr_intra0_soe_03 { get; set; }
        public ScenarioEntity<IScenery> pp_intra0_sog_01 { get; set; }
        public ScenarioEntity<IScenery> pp_intra0_sog_02 { get; set; }
        public ScenarioEntity<IScenery> hangar_door_ingame { get; set; }
        public ScenarioEntity<IScenery> gasmine_hologram { get; set; }
        public ScenarioEntity<IScenery> intra1_blade { get; set; }
        public ScenarioEntity<IScenery> intra1_rifle_01 { get; set; }
        public ScenarioEntity<IScenery> intra1_rifle_02 { get; set; }
        public ScenarioEntity<IScenery> cable_target_a { get; set; }
        public ScenarioEntity<IScenery> cable_target_b { get; set; }
        public ScenarioEntity<IScenery> cable_target_c { get; set; }
        public ScenarioEntity<IScenery> gas01 { get; set; }
        public ScenarioEntity<IScenery> gas02 { get; set; }
        public ScenarioEntity<IScenery> gas03 { get; set; }
        public ScenarioEntity<IScenery> gas04 { get; set; }
        public ScenarioEntity<IScenery> gas05 { get; set; }
        public ScenarioEntity<IScenery> gas06 { get; set; }
        public ScenarioEntity<IScenery> gas07 { get; set; }
        public ScenarioEntity<IScenery> gas08 { get; set; }
        public ScenarioEntity<IScenery> gas09 { get; set; }
        public ScenarioEntity<IScenery> gas10 { get; set; }
        public ScenarioEntity<IScenery> holo_boy { get; set; }
        public ScenarioEntity<IBloc> nl01 { get; set; }
        public ScenarioEntity<IBloc> nl02 { get; set; }
        public ScenarioEntity<IBloc> nl03 { get; set; }
        public ScenarioEntity<IBloc> nl04 { get; set; }
        public ScenarioEntity<IBloc> nl05 { get; set; }
        public ScenarioEntity<IBloc> nl06 { get; set; }
        public ScenarioEntity<IBloc> nl07 { get; set; }
        public ScenarioEntity<IBloc> nl08 { get; set; }
        public ScenarioEntity<IBloc> nl09 { get; set; }
        public ScenarioEntity<IBloc> nl10 { get; set; }
        public ScenarioEntity<IBloc> nl11 { get; set; }
        public ScenarioEntity<IBloc> nl12 { get; set; }
        public ScenarioEntity<IBloc> nl13 { get; set; }
        public ScenarioEntity<IBloc> nl14 { get; set; }
        public ScenarioEntity<IBloc> nl15 { get; set; }
        public ScenarioEntity<IBloc> nl16 { get; set; }
        public ScenarioEntity<IBloc> nl17 { get; set; }
        public ScenarioEntity<IBloc> nl18 { get; set; }
        public ScenarioEntity<IBloc> nl19 { get; set; }
        public ScenarioEntity<IBloc> nl20 { get; set; }
        public ScenarioEntity<IBloc> nl21 { get; set; }
        public ScenarioEntity<IBloc> nl22 { get; set; }
        public ScenarioEntity<IBloc> nl23 { get; set; }
        public ScenarioEntity<IBloc> nl24 { get; set; }
        public ScenarioEntity<IBloc> nl25 { get; set; }
        public ScenarioEntity<IBloc> nl26 { get; set; }
        public ScenarioEntity<IBloc> nl27 { get; set; }
        public ScenarioEntity<IBloc> nl28 { get; set; }
        public ScenarioEntity<IBloc> nl29 { get; set; }
        public ScenarioEntity<IBloc> nl30 { get; set; }
        public ScenarioEntity<IBloc> nl31 { get; set; }
        public ScenarioEntity<IBloc> nl32 { get; set; }
        public ScenarioEntity<IBloc> nr01 { get; set; }
        public ScenarioEntity<IBloc> nr02 { get; set; }
        public ScenarioEntity<IBloc> nr03 { get; set; }
        public ScenarioEntity<IBloc> nr04 { get; set; }
        public ScenarioEntity<IBloc> nr05 { get; set; }
        public ScenarioEntity<IBloc> nr06 { get; set; }
        public ScenarioEntity<IBloc> nr07 { get; set; }
        public ScenarioEntity<IBloc> nr08 { get; set; }
        public ScenarioEntity<IBloc> nr09 { get; set; }
        public ScenarioEntity<IBloc> nr10 { get; set; }
        public ScenarioEntity<IBloc> nr11 { get; set; }
        public ScenarioEntity<IBloc> nr12 { get; set; }
        public ScenarioEntity<IBloc> nr13 { get; set; }
        public ScenarioEntity<IBloc> nr14 { get; set; }
        public ScenarioEntity<IBloc> nr15 { get; set; }
        public ScenarioEntity<IBloc> nr16 { get; set; }
        public ScenarioEntity<IBloc> nr17 { get; set; }
        public ScenarioEntity<IBloc> nr18 { get; set; }
        public ScenarioEntity<IBloc> nr19 { get; set; }
        public ScenarioEntity<IBloc> nr20 { get; set; }
        public ScenarioEntity<IBloc> nr21 { get; set; }
        public ScenarioEntity<IBloc> nr22 { get; set; }
        public ScenarioEntity<IBloc> nr23 { get; set; }
        public ScenarioEntity<IBloc> nr24 { get; set; }
        public ScenarioEntity<IBloc> fr01 { get; set; }
        public ScenarioEntity<IBloc> fr02 { get; set; }
        public ScenarioEntity<IBloc> fr03 { get; set; }
        public ScenarioEntity<IBloc> fr04 { get; set; }
        public ScenarioEntity<IBloc> fr05 { get; set; }
        public ScenarioEntity<IBloc> fr06 { get; set; }
        public ScenarioEntity<IBloc> fr07 { get; set; }
        public ScenarioEntity<IBloc> fr08 { get; set; }
        public ScenarioEntity<IBloc> fr09 { get; set; }
        public ScenarioEntity<IBloc> fr10 { get; set; }
        public ScenarioEntity<IBloc> fr11 { get; set; }
        public ScenarioEntity<IBloc> fr12 { get; set; }
        public ScenarioEntity<IBloc> fr13 { get; set; }
        public ScenarioEntity<IBloc> fr14 { get; set; }
        public ScenarioEntity<IBloc> fr15 { get; set; }
        public ScenarioEntity<IBloc> fr16 { get; set; }
        public ScenarioEntity<IBloc> fr17 { get; set; }
        public ScenarioEntity<IBloc> fr18 { get; set; }
        public ScenarioEntity<IBloc> fr19 { get; set; }
        public ScenarioEntity<IBloc> fr20 { get; set; }
        public ScenarioEntity<IBloc> fr21 { get; set; }
        public ScenarioEntity<IBloc> fr22 { get; set; }
        public ScenarioEntity<IBloc> fr23 { get; set; }
        public ScenarioEntity<IBloc> fr24 { get; set; }
        public ScenarioEntity<IBloc> fr25 { get; set; }
        public ScenarioEntity<IBloc> fr26 { get; set; }
        public ScenarioEntity<IBloc> fr27 { get; set; }
        public ScenarioEntity<IBloc> fr28 { get; set; }
        public ScenarioEntity<IBloc> fr29 { get; set; }
        public ScenarioEntity<IBloc> fr30 { get; set; }
        public ScenarioEntity<IBloc> fr31 { get; set; }
        public ScenarioEntity<IBloc> fr32 { get; set; }
        public ScenarioEntity<IBloc> fl01 { get; set; }
        public ScenarioEntity<IBloc> fl02 { get; set; }
        public ScenarioEntity<IBloc> fl03 { get; set; }
        public ScenarioEntity<IBloc> fl04 { get; set; }
        public ScenarioEntity<IBloc> fl05 { get; set; }
        public ScenarioEntity<IBloc> fl06 { get; set; }
        public ScenarioEntity<IBloc> fl07 { get; set; }
        public ScenarioEntity<IBloc> fl08 { get; set; }
        public ScenarioEntity<IBloc> fl09 { get; set; }
        public ScenarioEntity<IBloc> fl10 { get; set; }
        public ScenarioEntity<IBloc> fl11 { get; set; }
        public ScenarioEntity<IBloc> fl12 { get; set; }
        public ScenarioEntity<IBloc> fl13 { get; set; }
        public ScenarioEntity<IBloc> fl14 { get; set; }
        public ScenarioEntity<IBloc> fl15 { get; set; }
        public ScenarioEntity<IBloc> fl16 { get; set; }
        public ScenarioEntity<IBloc> fl17 { get; set; }
        public ScenarioEntity<IBloc> fl18 { get; set; }
        public ScenarioEntity<IBloc> fl19 { get; set; }
        public ScenarioEntity<IBloc> fl20 { get; set; }
        public ScenarioEntity<IBloc> fl21 { get; set; }
        public ScenarioEntity<IBloc> fl22 { get; set; }
        public ScenarioEntity<IBloc> fl23 { get; set; }
        public ScenarioEntity<IBloc> fl24 { get; set; }
        public ScenarioEntity<IBloc> fl25 { get; set; }
        public ScenarioEntity<IBloc> fl26 { get; set; }
        public ScenarioEntity<IBloc> fl27 { get; set; }
        public ScenarioEntity<IBloc> fl28 { get; set; }
        public ScenarioEntity<IBloc> fl29 { get; set; }
        public ScenarioEntity<IBloc> fl30 { get; set; }
        public ScenarioEntity<IBloc> fl31 { get; set; }
        public ScenarioEntity<IBloc> fl32 { get; set; }
        public ScenarioEntity<IBloc> nr25 { get; set; }
        public ScenarioEntity<IBloc> nr26 { get; set; }
        public ScenarioEntity<IBloc> nr27 { get; set; }
        public ScenarioEntity<IBloc> nr28 { get; set; }
        public ScenarioEntity<IBloc> nr29 { get; set; }
        public ScenarioEntity<IBloc> nr30 { get; set; }
        public ScenarioEntity<IBloc> nr31 { get; set; }
        public ScenarioEntity<IBloc> nr32 { get; set; }
        public ScenarioEntity<IScenery> banshee_gas_01 { get; set; }
        public ScenarioEntity<IScenery> banshee_gas_02 { get; set; }
        public ScenarioEntity<IScenery> banshee_gas_03 { get; set; }
        public ScenarioEntity<IScenery> banshee_gas_04 { get; set; }
        public ScenarioEntity<IScenery> banshee_gas_05 { get; set; }
        public ScenarioEntity<IScenery> anchor_seraph { get; set; }
        public ScenarioEntity<IScenery> holo_base_1 { get; set; }
        public ScenarioEntity<IScenery> holo_base_2 { get; set; }
        public ScenarioEntity<IScenery> drone_spawn { get; set; }
        public ScenarioEntity<IBloc> crap01 { get; set; }
        public ScenarioEntity<IBloc> crap02 { get; set; }
        public ScenarioEntity<IBloc> crap03 { get; set; }
        public ScenarioEntity<IBloc> crap04 { get; set; }
        public ScenarioEntity<IBloc> crap05 { get; set; }
        public ScenarioEntity<IBloc> crap06 { get; set; }
        public ScenarioEntity<IBloc> crap07 { get; set; }
        public ScenarioEntity<IBloc> crap08 { get; set; }
        public ScenarioEntity<IBloc> crap09 { get; set; }
        public ScenarioEntity<IBloc> crap10 { get; set; }
        public ScenarioEntity<IBloc> crap11 { get; set; }
        public ScenarioEntity<IBloc> crap12 { get; set; }
        public ScenarioEntity<IScenery> croom_center { get; set; }
        public ScenarioEntity<IScenery> cable_nub_a { get; set; }
        public ScenarioEntity<IScenery> cable_nub_b { get; set; }
        public ScenarioEntity<IScenery> cable_nub_c { get; set; }
        public ScenarioEntity<IScenery> holo_rifle_01 { get; set; }
        public ScenarioEntity<IScenery> holo_rifle_02 { get; set; }
        public ScenarioEntity<IScenery> holo_rifle_03 { get; set; }
        public ScenarioEntity<IScenery> holo_rifle_04 { get; set; }
        public ScenarioEntity<IUnit> corpse01 { get; set; }
        public ScenarioEntity<IUnit> corpse02 { get; set; }
        public ScenarioEntity<IUnit> corpse03 { get; set; }
        public ScenarioEntity<IUnit> corpse04 { get; set; }
        public ScenarioEntity<IUnit> corpse05 { get; set; }
        public ScenarioEntity<IUnit> corpse06 { get; set; }
        public ScenarioEntity<IUnit> corpse07 { get; set; }
        public ScenarioEntity<IUnit> corpse08 { get; set; }
        public ScenarioEntity<IUnit> dervish02 { get; set; }
        public ScenarioEntity<IUnit> heretic_leader1 { get; set; }
        public ScenarioEntity<IUnit> monitor { get; set; }
        public ScenarioEntity<IUnit> hologram01 { get; set; }
        public ScenarioEntity<IUnit> hologram02 { get; set; }
        public ScenarioEntity<IUnit> tartarus { get; set; }
        public ScenarioEntity<IUnit> dervish_intra0 { get; set; }
        public ScenarioEntity<IUnit> commander_intra0 { get; set; }
        public ScenarioEntity<IUnit> elite_intra0_01 { get; set; }
        public ScenarioEntity<IUnit> elite_intra0_02 { get; set; }
        public ScenarioEntity<IUnit> grunt_intra0_01 { get; set; }
        public ScenarioEntity<IUnit> grunt_intra0_02 { get; set; }
        public ScenarioEntity<IUnit> dervish_03 { get; set; }
        public ScenarioEntity<IUnit> commander { get; set; }
        public ScenarioEntity<IUnit> elite01 { get; set; }
        public ScenarioEntity<IUnit> elite02 { get; set; }
        public ScenarioEntity<IUnit> dervish02b { get; set; }
        public ScenarioEntity<IVehicle> phantom01 { get; set; }
        public ScenarioEntity<IVehicle> phantom02 { get; set; }
        public ScenarioEntity<IVehicle> phantom03 { get; set; }
        public ScenarioEntity<IVehicle> player_fake_banshee { get; set; }
        public ScenarioEntity<IVehicle> player0_fake_banshee { get; set; }
        public ScenarioEntity<IVehicle> hl_fake_banshee { get; set; }
        public ScenarioEntity<IVehicle> player1_fake_banshee { get; set; }
        public ScenarioEntity<IVehicle> hl_end_banshee { get; set; }
        public ScenarioEntity<IVehicle> phantom_outro2 { get; set; }
        public ScenarioEntity<IWeapon> hl_rifle_01 { get; set; }
        public ScenarioEntity<IWeapon> hl_rifle_02 { get; set; }
        public ScenarioEntity<IWeapon> famine { get; set; }
        public ScenarioEntity<IWeapon> toy01 { get; set; }
        public ScenarioEntity<IWeapon> toy02 { get; set; }
        public ScenarioEntity<IWeapon> toy03 { get; set; }
        public ScenarioEntity<IWeapon> toy04 { get; set; }
        public ScenarioEntity<IWeapon> toy05 { get; set; }
        public ScenarioEntity<IWeapon> toy06 { get; set; }
        public ScenarioEntity<IWeapon> toy07 { get; set; }
        public ScenarioEntity<IWeapon> toy08 { get; set; }
        public ScenarioEntity<IWeapon> toy09 { get; set; }
        public ScenarioEntity<IWeapon> toy10 { get; set; }
        public ScenarioEntity<IWeapon> toy11 { get; set; }
        public ScenarioEntity<IWeapon> toy12 { get; set; }
        public ScenarioEntity<IWeapon> toy13 { get; set; }
        public ScenarioEntity<IWeapon> toy14 { get; set; }
        public ScenarioEntity<IWeapon> toy15 { get; set; }
        public ScenarioEntity<IWeapon> toy16 { get; set; }
        public ScenarioEntity<IWeapon> toy17 { get; set; }
        public ScenarioEntity<IWeapon> toy18 { get; set; }
        public ScenarioEntity<ISound> closetocore { get; set; }
        public ScenarioEntity<ISound> core { get; set; }
        public ScenarioEntity<ISound> core2 { get; set; }
        public ScenarioEntity<ISound> closetocore2 { get; set; }
        public ScenarioEntity<IDevice> viewroom_entry_bsp0 { get; set; }
        public ScenarioEntity<IDevice> banshee_ledge_access_01 { get; set; }
        public ScenarioEntity<IDevice> bottling_spawnroom_bsp0 { get; set; }
        public ScenarioEntity<IDevice> lab_exit_ext { get; set; }
        public ScenarioEntity<IDevice> control_down_switch_01 { get; set; }
        public ScenarioEntity<IDevice> control_down_switch_02 { get; set; }
        public ScenarioEntity<IDevice> control_shield_door { get; set; }
        public ScenarioEntity<IDevice> control_up_switch_01 { get; set; }
        public ScenarioEntity<IDevice> control_up_switch_02 { get; set; }
        public ScenarioEntity<IDevice> tray01 { get; set; }
        public ScenarioEntity<IDevice> tray02 { get; set; }
        public ScenarioEntity<IDevice> tray03 { get; set; }
        public ScenarioEntity<IDevice> tray04 { get; set; }
        public ScenarioEntity<IDevice> tray05 { get; set; }
        public ScenarioEntity<IDevice> lab_exit_int { get; set; }
        public ScenarioEntity<IDevice> disposal_entry_int { get; set; }
        public ScenarioEntity<IDevice> arm02_entry_int { get; set; }
        public ScenarioEntity<IDevice> disposal_exit { get; set; }
        public ScenarioEntity<IDevice> elev_hangar { get; set; }
        public ScenarioEntity<IDevice> elev_control_up { get; set; }
        public ScenarioEntity<IDevice> elev_control_down { get; set; }
        public ScenarioEntity<IDevice> seraph { get; set; }
        public ScenarioEntity<IDevice> banshee_ledge_access_02 { get; set; }
        public ScenarioEntity<IDevice> arm_02_entry_ext { get; set; }
        public ScenarioEntity<IDevice> suction { get; set; }
        public ScenarioEntity<IDevice> real_cable_c { get; set; }
        public ScenarioEntity<IDevice> real_cable_b { get; set; }
        public ScenarioEntity<IDevice> real_cable_a { get; set; }
        public ScenarioEntity<IDevice> control_room_ext { get; set; }
        public ScenarioEntity<IDevice> hl_ledge_ext { get; set; }
        public ScenarioEntity<IDevice> viewroom_exit02_bsp0 { get; set; }
        public ScenarioEntity<IDevice> viewroom_exit01_bsp0 { get; set; }
        public ScenarioEntity<IDevice> elev_silo { get; set; }
        public ScenarioEntity<IDevice> tray06 { get; set; }
        public ScenarioEntity<IDevice> control_middle_spawnroom { get; set; }
        public ScenarioEntity<IDevice> control_entry_int { get; set; }
        public ScenarioEntity<IDevice> control_bottom_spawnroom { get; set; }
        public ScenarioEntity<IDevice> control_peri_spawnroom { get; set; }
        public ScenarioEntity<IDevice> rec_center_entry_ext { get; set; }
        public ScenarioEntity<IDevice> cableroom { get; set; }
        public ScenarioEntity<IDevice> cableroom2 { get; set; }
        public ScenarioEntity<IDevice> cableroom_top { get; set; }
        public ScenarioEntity<IDevice> shield { get; set; }
        public ScenarioEntity<IDevice> phantom_vol { get; set; }
        public ScenarioEntity<IDevice> hangar_door_cinematic { get; set; }
        public ScenarioEntity<IDevice> underhangar_spawn_02 { get; set; }
        public ScenarioEntity<IDevice> underhangar_spawn_01 { get; set; }
        public ScenarioEntity<IDevice> hall2_spawn_03 { get; set; }
        public ScenarioEntity<IDevice> hall2_spawn_02 { get; set; }
        public ScenarioEntity<IDevice> hall2_spawn_01 { get; set; }
        public ScenarioEntity<IDevice> hangar_exit { get; set; }
        public ScenarioEntity<IDevice> tennis_ball { get; set; }
        public ICameraPathTarget cam00 => Scenario.CameraPathTargets[0];
        public ICameraPathTarget cam01 => Scenario.CameraPathTargets[1];
        public ICameraPathTarget cam02 => Scenario.CameraPathTargets[2];
        public ICameraPathTarget cam03 => Scenario.CameraPathTargets[3];
        public ICameraPathTarget cam04 => Scenario.CameraPathTargets[4];
        public ICameraPathTarget cam05 => Scenario.CameraPathTargets[5];
        public ICameraPathTarget cam06 => Scenario.CameraPathTargets[6];
        public ICameraPathTarget cam07 => Scenario.CameraPathTargets[7];
        public ICameraPathTarget end00 => Scenario.CameraPathTargets[8];
        public ICameraPathTarget end01 => Scenario.CameraPathTargets[9];
        public ICameraPathTarget end02 => Scenario.CameraPathTargets[10];
        public ICameraPathTarget end03 => Scenario.CameraPathTargets[11];
        public ICameraPathTarget end04 => Scenario.CameraPathTargets[12];
        public IAiActorDefinition all_allies => Scenario.AiSquadGroupDefinitions[0];
        public IAiActorDefinition allies_elites => Scenario.AiSquadGroupDefinitions[1];
        public IAiActorDefinition all_enemies => Scenario.AiSquadGroupDefinitions[2];
        public IAiActorDefinition arm02_allies => Scenario.AiSquadGroupDefinitions[3];
        public IAiActorDefinition disposal_infection => Scenario.AiSquadGroupDefinitions[4];
        public IAiActorDefinition disposal_flood => Scenario.AiSquadGroupDefinitions[5];
        public IAiActorDefinition silo_sentinels_all => Scenario.AiSquadGroupDefinitions[6];
        public IAiActorDefinition silo_infection => Scenario.AiSquadGroupDefinitions[7];
        public IAiActorDefinition silo_flood => Scenario.AiSquadGroupDefinitions[8];
        public IAiActorDefinition lab_heretics => Scenario.AiSquadGroupDefinitions[9];
        public IAiActorDefinition lab_turrets => Scenario.AiSquadGroupDefinitions[10];
        public IAiActorDefinition lab_flood => Scenario.AiSquadGroupDefinitions[11];
        public IAiActorDefinition lab_carriers => Scenario.AiSquadGroupDefinitions[12];
        public IAiActorDefinition core_allies => Scenario.AiSquadGroupDefinitions[13];
        public IAiActorDefinition bridge_enemies => Scenario.AiSquadGroupDefinitions[14];
        public IAiActorDefinition bridge_flood => Scenario.AiSquadGroupDefinitions[15];
        public IAiActorDefinition bridge_heretics => Scenario.AiSquadGroupDefinitions[16];
        public IAiActorDefinition bridge_sentinels => Scenario.AiSquadGroupDefinitions[17];
        public IAiActorDefinition control_flood => Scenario.AiSquadGroupDefinitions[18];
        public IAiActorDefinition control_sentinels => Scenario.AiSquadGroupDefinitions[19];
        public IAiActorDefinition cable_sentinels => Scenario.AiSquadGroupDefinitions[20];
        public IAiActorDefinition cable_flood => Scenario.AiSquadGroupDefinitions[21];
        public IAiActorDefinition control_return_heretics => Scenario.AiSquadGroupDefinitions[22];
        public IAiActorDefinition control_return_flood => Scenario.AiSquadGroupDefinitions[23];
        public IAiActorDefinition control_return_sentinels => Scenario.AiSquadGroupDefinitions[24];
        public IAiActorDefinition power_core_heretics => Scenario.AiSquadGroupDefinitions[25];
        public IAiActorDefinition power_core_flood => Scenario.AiSquadGroupDefinitions[26];
        public IAiActorDefinition power_core_sentinels => Scenario.AiSquadGroupDefinitions[27];
        public IAiActorDefinition dogfighters => Scenario.AiSquadGroupDefinitions[28];
        public IAiActorDefinition bottling_plant_enemies => Scenario.AiSquadGroupDefinitions[29];
        public IAiActorDefinition bottling_return_flood => Scenario.AiSquadGroupDefinitions[30];
        public IAiActorDefinition bottling_return_sentinels => Scenario.AiSquadGroupDefinitions[31];
        public IAiActorDefinition second_hall_flood => Scenario.AiSquadGroupDefinitions[32];
        public IAiActorDefinition underhangar_return_flood => Scenario.AiSquadGroupDefinitions[33];
        public IAiActorDefinition underhangar_return_heretics => Scenario.AiSquadGroupDefinitions[34];
        public IAiActorDefinition hangar_return_flood => Scenario.AiSquadGroupDefinitions[35];
        public IAiActorDefinition hangar_return_sentinels => Scenario.AiSquadGroupDefinitions[36];
        public IAiActorDefinition holo_drones => Scenario.AiSquadGroupDefinitions[37];
        public IAiOrders allies_intro => Scenario.AiOrderDefinitions[0].GameObject;
        public IAiOrders jug_preview_attack => Scenario.AiOrderDefinitions[1].GameObject;
        public IAiOrders jug_preview_over => Scenario.AiOrderDefinitions[2].GameObject;
        public IAiOrders allies_disposal => Scenario.AiOrderDefinitions[3].GameObject;
        public IAiOrders disposal_enemies => Scenario.AiOrderDefinitions[4].GameObject;
        public IAiOrders allies_silo => Scenario.AiOrderDefinitions[5].GameObject;
        public IAiOrders allies_silo_lift => Scenario.AiOrderDefinitions[6].GameObject;
        public IAiOrders allies_silo_center => Scenario.AiOrderDefinitions[7].GameObject;
        public IAiOrders silo_elev_all => Scenario.AiOrderDefinitions[8].GameObject;
        public IAiOrders silo_all => Scenario.AiOrderDefinitions[9].GameObject;
        public IAiOrders silo_s_wave_01 => Scenario.AiOrderDefinitions[10].GameObject;
        public IAiOrders allies_lab_upper => Scenario.AiOrderDefinitions[11].GameObject;
        public IAiOrders allies_lab_lower => Scenario.AiOrderDefinitions[12].GameObject;
        public IAiOrders lab_heretic_stand_01 => Scenario.AiOrderDefinitions[13].GameObject;
        public IAiOrders lab_heretic_stand_02 => Scenario.AiOrderDefinitions[14].GameObject;
        public IAiOrders lab_flood_all => Scenario.AiOrderDefinitions[15].GameObject;
        public IAiOrders lab_barricade_breach_01 => Scenario.AiOrderDefinitions[16].GameObject;
        public IAiOrders lab_barricade_breach_02 => Scenario.AiOrderDefinitions[17].GameObject;
        public IAiOrders lab_above => Scenario.AiOrderDefinitions[18].GameObject;
        public IAiOrders lab_above_back => Scenario.AiOrderDefinitions[19].GameObject;
        public IAiOrders allies_lab_wagons => Scenario.AiOrderDefinitions[20].GameObject;
        public IAiOrders allies_lab_end => Scenario.AiOrderDefinitions[21].GameObject;
        public IAiOrders allies_airlock => Scenario.AiOrderDefinitions[22].GameObject;
        public IAiOrders allies_wraparound => Scenario.AiOrderDefinitions[23].GameObject;
        public IAiOrders bridge_strafe => Scenario.AiOrderDefinitions[24].GameObject;
        public IAiOrders bridge_sentinels1 => Scenario.AiOrderDefinitions[25].GameObject;
        public IAiOrders wrap_left_h_01 => Scenario.AiOrderDefinitions[26].GameObject;
        public IAiOrders wrap_left_h_02 => Scenario.AiOrderDefinitions[27].GameObject;
        public IAiOrders wrap_left_h_03 => Scenario.AiOrderDefinitions[28].GameObject;
        public IAiOrders wrap_left_h_04 => Scenario.AiOrderDefinitions[29].GameObject;
        public IAiOrders wrap_left_h_05 => Scenario.AiOrderDefinitions[30].GameObject;
        public IAiOrders wrap_s_L_05 => Scenario.AiOrderDefinitions[31].GameObject;
        public IAiOrders wrap_right_h_01 => Scenario.AiOrderDefinitions[32].GameObject;
        public IAiOrders wrap_right_h_02 => Scenario.AiOrderDefinitions[33].GameObject;
        public IAiOrders wrap_right_h_03 => Scenario.AiOrderDefinitions[34].GameObject;
        public IAiOrders wrap_right_h_04 => Scenario.AiOrderDefinitions[35].GameObject;
        public IAiOrders wrap_right_h_05 => Scenario.AiOrderDefinitions[36].GameObject;
        public IAiOrders wrap_s_R_05 => Scenario.AiOrderDefinitions[37].GameObject;
        public IAiOrders wraparound_final_h => Scenario.AiOrderDefinitions[38].GameObject;
        public IAiOrders wraparound_f_init => Scenario.AiOrderDefinitions[39].GameObject;
        public IAiOrders allies_control => Scenario.AiOrderDefinitions[40].GameObject;
        public IAiOrders control_room_floor => Scenario.AiOrderDefinitions[41].GameObject;
        public IAiOrders control_room_middle => Scenario.AiOrderDefinitions[42].GameObject;
        public IAiOrders control_room_top => Scenario.AiOrderDefinitions[43].GameObject;
        public IAiOrders control_sentinels_bottom => Scenario.AiOrderDefinitions[44].GameObject;
        public IAiOrders control_sentinels_top => Scenario.AiOrderDefinitions[45].GameObject;
        public IAiOrders hl_holed_up => Scenario.AiOrderDefinitions[46].GameObject;
        public IAiOrders allies_pickup => Scenario.AiOrderDefinitions[47].GameObject;
        public IAiOrders cable_room_all => Scenario.AiOrderDefinitions[48].GameObject;
        public IAiOrders cable_room_ab => Scenario.AiOrderDefinitions[49].GameObject;
        public IAiOrders cable_room_bc => Scenario.AiOrderDefinitions[50].GameObject;
        public IAiOrders cable_room_ac => Scenario.AiOrderDefinitions[51].GameObject;
        public IAiOrders cable_room_a => Scenario.AiOrderDefinitions[52].GameObject;
        public IAiOrders cable_room_b => Scenario.AiOrderDefinitions[53].GameObject;
        public IAiOrders cable_room_c => Scenario.AiOrderDefinitions[54].GameObject;
        public IAiOrders cable_room_after => Scenario.AiOrderDefinitions[55].GameObject;
        public IAiOrders cable_room_sentinels_all => Scenario.AiOrderDefinitions[56].GameObject;
        public IAiOrders cable_room_sentinels_ab => Scenario.AiOrderDefinitions[57].GameObject;
        public IAiOrders cable_room_sentinels_bc => Scenario.AiOrderDefinitions[58].GameObject;
        public IAiOrders cable_room_sentinels_ac => Scenario.AiOrderDefinitions[59].GameObject;
        public IAiOrders cable_room_sentinels_a => Scenario.AiOrderDefinitions[60].GameObject;
        public IAiOrders cable_room_sentinels_b => Scenario.AiOrderDefinitions[61].GameObject;
        public IAiOrders cable_room_sentinels_c => Scenario.AiOrderDefinitions[62].GameObject;
        public IAiOrders cable_room_sentinels_end => Scenario.AiOrderDefinitions[63].GameObject;
        public IAiOrders control_return_h_01 => Scenario.AiOrderDefinitions[64].GameObject;
        public IAiOrders control_return_h_02 => Scenario.AiOrderDefinitions[65].GameObject;
        public IAiOrders control_return_s_01 => Scenario.AiOrderDefinitions[66].GameObject;
        public IAiOrders control_return_s_02 => Scenario.AiOrderDefinitions[67].GameObject;
        public IAiOrders control_return_flood_all => Scenario.AiOrderDefinitions[68].GameObject;
        public IAiOrders control_return_flood_win => Scenario.AiOrderDefinitions[69].GameObject;
        public IAiOrders power_core_s_wave_01 => Scenario.AiOrderDefinitions[70].GameObject;
        public IAiOrders power_core_s_wave_02 => Scenario.AiOrderDefinitions[71].GameObject;
        public IAiOrders power_core_h_wave_01 => Scenario.AiOrderDefinitions[72].GameObject;
        public IAiOrders power_core_flood_all => Scenario.AiOrderDefinitions[73].GameObject;
        public IAiOrders dogfight_finale => Scenario.AiOrderDefinitions[74].GameObject;
        public IAiOrders bottling_return_s_01_low => Scenario.AiOrderDefinitions[75].GameObject;
        public IAiOrders bottling_return_s_01_top => Scenario.AiOrderDefinitions[76].GameObject;
        public IAiOrders bottling_return_f_01 => Scenario.AiOrderDefinitions[77].GameObject;
        public IAiOrders bottling_return_s_02 => Scenario.AiOrderDefinitions[78].GameObject;
        public IAiOrders bottling_return_f_02 => Scenario.AiOrderDefinitions[79].GameObject;
        public IAiOrders underhangar_h_01 => Scenario.AiOrderDefinitions[80].GameObject;
        public IAiOrders underhangar_h_02 => Scenario.AiOrderDefinitions[81].GameObject;
        public IAiOrders underhangar_h_03 => Scenario.AiOrderDefinitions[82].GameObject;
        public IAiOrders under_to_bottling_f_01 => Scenario.AiOrderDefinitions[83].GameObject;
        public IAiOrders underhangar_return_f_01 => Scenario.AiOrderDefinitions[84].GameObject;
        public IAiOrders underhangar_return_f_02 => Scenario.AiOrderDefinitions[85].GameObject;
        public IAiOrders underhangar_return_f_03 => Scenario.AiOrderDefinitions[86].GameObject;
        public IAiOrders under_to_hangar_f => Scenario.AiOrderDefinitions[87].GameObject;
        public IAiOrders boss_fight_cf => Scenario.AiOrderDefinitions[88].GameObject;
        public IAiOrders boss_fight_ca => Scenario.AiOrderDefinitions[89].GameObject;
        public IAiOrders boss_fight_s_low => Scenario.AiOrderDefinitions[90].GameObject;
        public IAiOrders boss_fight_s_top => Scenario.AiOrderDefinitions[91].GameObject;
        public IAiOrders boss_fight_hl_center => Scenario.AiOrderDefinitions[92].GameObject;
        public IAiOrders boss_fight_hl_left => Scenario.AiOrderDefinitions[93].GameObject;
        public IAiOrders boss_fight_hl_right => Scenario.AiOrderDefinitions[94].GameObject;
        public IAiOrders hangar_get_im => Scenario.AiOrderDefinitions[95].GameObject;
        public IAiOrders monitor_hangar => Scenario.AiOrderDefinitions[96].GameObject;
        public IAiOrders hole_up => Scenario.AiOrderDefinitions[97].GameObject;
        public IAiOrders bait_halls => Scenario.AiOrderDefinitions[98].GameObject;
        public IAiOrders bait_bottling => Scenario.AiOrderDefinitions[99].GameObject;
        public ILocationFlag cinematic_anchor => Scenario.LocationFlagDefinitions[0];
        public ILocationFlag cinematic_anchor02 => Scenario.LocationFlagDefinitions[1];
        public ILocationFlag cinematic_anchor03 => Scenario.LocationFlagDefinitions[2];
        public ILocationFlag player0_hide => Scenario.LocationFlagDefinitions[3];
        public ILocationFlag player1_hide => Scenario.LocationFlagDefinitions[4];
        public ILocationFlag research_player0 => Scenario.LocationFlagDefinitions[5];
        public ILocationFlag research_player1 => Scenario.LocationFlagDefinitions[6];
        public ILocationFlag silo_player0 => Scenario.LocationFlagDefinitions[7];
        public ILocationFlag silo_player1 => Scenario.LocationFlagDefinitions[8];
        public ILocationFlag silo_ally01 => Scenario.LocationFlagDefinitions[9];
        public ILocationFlag silo_ally02 => Scenario.LocationFlagDefinitions[10];
        public ILocationFlag lab_player0 => Scenario.LocationFlagDefinitions[11];
        public ILocationFlag lab_player1 => Scenario.LocationFlagDefinitions[12];
        public ILocationFlag lab_ally01 => Scenario.LocationFlagDefinitions[13];
        public ILocationFlag wraparound_player0 => Scenario.LocationFlagDefinitions[14];
        public ILocationFlag wraparound_player1 => Scenario.LocationFlagDefinitions[15];
        public ILocationFlag control_entry_player0 => Scenario.LocationFlagDefinitions[16];
        public ILocationFlag control_entry_player1 => Scenario.LocationFlagDefinitions[17];
        public ILocationFlag control_ally01 => Scenario.LocationFlagDefinitions[18];
        public ILocationFlag control_ally02 => Scenario.LocationFlagDefinitions[19];
        public ILocationFlag player0_control => Scenario.LocationFlagDefinitions[20];
        public ILocationFlag player1_control => Scenario.LocationFlagDefinitions[21];
        public ILocationFlag cableroom_player0 => Scenario.LocationFlagDefinitions[22];
        public ILocationFlag cableroom_player1 => Scenario.LocationFlagDefinitions[23];
        public ILocationFlag powercore_player0 => Scenario.LocationFlagDefinitions[24];
        public ILocationFlag powercore_player1 => Scenario.LocationFlagDefinitions[25];
        public ILocationFlag after_plummet_player0 => Scenario.LocationFlagDefinitions[26];
        public ILocationFlag after_plummet_player1 => Scenario.LocationFlagDefinitions[27];
        public ILocationFlag banshee_player0 => Scenario.LocationFlagDefinitions[28];
        public ILocationFlag banshee_player1 => Scenario.LocationFlagDefinitions[29];
        public ILocationFlag bottling_return_player0 => Scenario.LocationFlagDefinitions[30];
        public ILocationFlag bottling_return_player1 => Scenario.LocationFlagDefinitions[31];
        public ILocationFlag underhangar_return_player0 => Scenario.LocationFlagDefinitions[32];
        public ILocationFlag underhangar_return_player1 => Scenario.LocationFlagDefinitions[33];
        public ILocationFlag boss_player0 => Scenario.LocationFlagDefinitions[34];
        public ILocationFlag boss_player1 => Scenario.LocationFlagDefinitions[35];
        public ILocationFlag player0_hangar => Scenario.LocationFlagDefinitions[36];
        public ILocationFlag player1_hangar => Scenario.LocationFlagDefinitions[37];
        public ILocationFlag disposal_break_01 => Scenario.LocationFlagDefinitions[38];
        public ILocationFlag disposal_break_02 => Scenario.LocationFlagDefinitions[39];
        public ILocationFlag disposal_break_03 => Scenario.LocationFlagDefinitions[40];
        public ILocationFlag disposal_break_04 => Scenario.LocationFlagDefinitions[41];
        public ILocationFlag disposal_break_05 => Scenario.LocationFlagDefinitions[42];
        public ILocationFlag disposal_break_06 => Scenario.LocationFlagDefinitions[43];
        public ILocationFlag disposal_break_07 => Scenario.LocationFlagDefinitions[44];
        public ILocationFlag disposal_break_08 => Scenario.LocationFlagDefinitions[45];
        public ILocationFlag silo_boom_01_1 => Scenario.LocationFlagDefinitions[46];
        public ILocationFlag silo_boom_01_2 => Scenario.LocationFlagDefinitions[47];
        public ILocationFlag silo_boom_01_3 => Scenario.LocationFlagDefinitions[48];
        public ILocationFlag silo_boom_01_4 => Scenario.LocationFlagDefinitions[49];
        public ILocationFlag silo_boom_01_5 => Scenario.LocationFlagDefinitions[50];
        public ILocationFlag silo_boom_01_6 => Scenario.LocationFlagDefinitions[51];
        public ILocationFlag silo_boom_01_7 => Scenario.LocationFlagDefinitions[52];
        public ILocationFlag silo_boom_01_8 => Scenario.LocationFlagDefinitions[53];
        public ILocationFlag silo_boom_01_9 => Scenario.LocationFlagDefinitions[54];
        public ILocationFlag silo_boom_01_10 => Scenario.LocationFlagDefinitions[55];
        public ILocationFlag silo_boom_01_11 => Scenario.LocationFlagDefinitions[56];
        public ILocationFlag silo_boom_01_12 => Scenario.LocationFlagDefinitions[57];
        public ILocationFlag silo_boom_02_1 => Scenario.LocationFlagDefinitions[58];
        public ILocationFlag cutscene_flags_59 => Scenario.LocationFlagDefinitions[59];
        public ILocationFlag anchor_flag_intra0 => Scenario.LocationFlagDefinitions[60];
        public ILocationFlag evac_pt => Scenario.LocationFlagDefinitions[61];
        public ILocationFlag dogfight_1 => Scenario.LocationFlagDefinitions[62];
        public ILocationFlag dogfight_2 => Scenario.LocationFlagDefinitions[63];
        public ILocationFlag dogfight_3 => Scenario.LocationFlagDefinitions[64];
        public ILocationFlag dogfight_4 => Scenario.LocationFlagDefinitions[65];
        public ILocationFlag dogfight_5 => Scenario.LocationFlagDefinitions[66];
        public ILocationFlag dogfight_6 => Scenario.LocationFlagDefinitions[67];
        public ILocationFlag dervish_sticks_landing => Scenario.LocationFlagDefinitions[68];
        public ILocationFlag player0_hide2 => Scenario.LocationFlagDefinitions[69];
        public ILocationFlag player1_hide2 => Scenario.LocationFlagDefinitions[70];
        public ILocationFlag he_went_here => Scenario.LocationFlagDefinitions[71];
        public ILocationFlag bsp_0_2_safe => Scenario.LocationFlagDefinitions[72];
        public ILocationFlag soc_reborn => Scenario.LocationFlagDefinitions[73];
        public ILocationFlag _1 => Scenario.LocationFlagDefinitions[74];
        public ILocationFlag _2 => Scenario.LocationFlagDefinitions[75];
        public ILocationFlag _3 => Scenario.LocationFlagDefinitions[76];
        public ILocationFlag _4 => Scenario.LocationFlagDefinitions[77];
        public ILocationFlag _5 => Scenario.LocationFlagDefinitions[78];
        public ILocationFlag _6 => Scenario.LocationFlagDefinitions[79];
        public ILocationFlag _7 => Scenario.LocationFlagDefinitions[80];
        public ILocationFlag _8 => Scenario.LocationFlagDefinitions[81];
        public ILocationFlag _9 => Scenario.LocationFlagDefinitions[82];
        public ILocationFlag _10 => Scenario.LocationFlagDefinitions[83];
        public ILocationFlag _11 => Scenario.LocationFlagDefinitions[84];
        public ILocationFlag _12 => Scenario.LocationFlagDefinitions[85];
        public ILocationFlag _13 => Scenario.LocationFlagDefinitions[86];
        public ILocationFlag _14 => Scenario.LocationFlagDefinitions[87];
        public ILocationFlag _15 => Scenario.LocationFlagDefinitions[88];
        public ILocationFlag _16 => Scenario.LocationFlagDefinitions[89];
        public ILocationFlag _17 => Scenario.LocationFlagDefinitions[90];
        public ILocationFlag _18 => Scenario.LocationFlagDefinitions[91];
        public ILocationFlag _19 => Scenario.LocationFlagDefinitions[92];
        public ILocationFlag _20 => Scenario.LocationFlagDefinitions[93];
        public ILocationFlag _21 => Scenario.LocationFlagDefinitions[94];
        public ILocationFlag _22 => Scenario.LocationFlagDefinitions[95];
        public ILocationFlag _23 => Scenario.LocationFlagDefinitions[96];
        public ILocationFlag _25 => Scenario.LocationFlagDefinitions[97];
        public ILocationFlag _26 => Scenario.LocationFlagDefinitions[98];
        public ILocationFlag _27 => Scenario.LocationFlagDefinitions[99];
        public ILocationFlag _28 => Scenario.LocationFlagDefinitions[100];
        public ILocationFlag _24 => Scenario.LocationFlagDefinitions[101];
        public ILocationFlag _29 => Scenario.LocationFlagDefinitions[102];
        public ILocationFlag _30 => Scenario.LocationFlagDefinitions[103];
        public ILocationFlag _31 => Scenario.LocationFlagDefinitions[104];
        public ILocationFlag _32 => Scenario.LocationFlagDefinitions[105];
        public ILocationFlag _33 => Scenario.LocationFlagDefinitions[106];
        public ILocationFlag _34 => Scenario.LocationFlagDefinitions[107];
        public ILocationFlag _35 => Scenario.LocationFlagDefinitions[108];
        public ILocationFlag _36 => Scenario.LocationFlagDefinitions[109];
        public ILocationFlag _37 => Scenario.LocationFlagDefinitions[110];
        public ILocationFlag _39 => Scenario.LocationFlagDefinitions[111];
        public ILocationFlag _41 => Scenario.LocationFlagDefinitions[112];
        public ILocationFlag _40 => Scenario.LocationFlagDefinitions[113];
        public ILocationFlag _38 => Scenario.LocationFlagDefinitions[114];
        public ILocationFlag _42 => Scenario.LocationFlagDefinitions[115];
        public ILocationFlag _43 => Scenario.LocationFlagDefinitions[116];
        public ILocationFlag _44 => Scenario.LocationFlagDefinitions[117];
        public ILocationFlag _45 => Scenario.LocationFlagDefinitions[118];
        public ILocationFlag _46 => Scenario.LocationFlagDefinitions[119];
        public ILocationFlag _47 => Scenario.LocationFlagDefinitions[120];
        public ILocationFlag _48 => Scenario.LocationFlagDefinitions[121];
        public ILocationFlag _49 => Scenario.LocationFlagDefinitions[122];
        public ILocationFlag _50 => Scenario.LocationFlagDefinitions[123];
        public ILocationFlag _51 => Scenario.LocationFlagDefinitions[124];
        public ILocationFlag _52 => Scenario.LocationFlagDefinitions[125];
        public ILocationFlag _53 => Scenario.LocationFlagDefinitions[126];
        public ILocationFlag _54 => Scenario.LocationFlagDefinitions[127];
        public ILocationFlag _55 => Scenario.LocationFlagDefinitions[128];
        public ILocationFlag _56 => Scenario.LocationFlagDefinitions[129];
        public ILocationFlag _57 => Scenario.LocationFlagDefinitions[130];
        public ILocationFlag _58 => Scenario.LocationFlagDefinitions[131];
        public ILocationFlag _59 => Scenario.LocationFlagDefinitions[132];
        public ILocationFlag _60 => Scenario.LocationFlagDefinitions[133];
        public ILocationFlag _61 => Scenario.LocationFlagDefinitions[134];
        public ILocationFlag _62 => Scenario.LocationFlagDefinitions[135];
        public ILocationFlag _63 => Scenario.LocationFlagDefinitions[136];
        public ILocationFlag _64 => Scenario.LocationFlagDefinitions[137];
        public ILocationFlag _65 => Scenario.LocationFlagDefinitions[138];
        public ILocationFlag _66 => Scenario.LocationFlagDefinitions[139];
        public ILocationFlag _67 => Scenario.LocationFlagDefinitions[140];
        public ILocationFlag _68 => Scenario.LocationFlagDefinitions[141];
        public ILocationFlag _69 => Scenario.LocationFlagDefinitions[142];
        public ILocationFlag _70 => Scenario.LocationFlagDefinitions[143];
        public ILocationFlag _71 => Scenario.LocationFlagDefinitions[144];
        public ILocationFlag _72 => Scenario.LocationFlagDefinitions[145];
        public ILocationFlag _73 => Scenario.LocationFlagDefinitions[146];
        public ILocationFlag _74 => Scenario.LocationFlagDefinitions[147];
        public ILocationFlag _75 => Scenario.LocationFlagDefinitions[148];
        public ILocationFlag _76 => Scenario.LocationFlagDefinitions[149];
        public ILocationFlag _77 => Scenario.LocationFlagDefinitions[150];
        public ILocationFlag _78 => Scenario.LocationFlagDefinitions[151];
        public ILocationFlag _79 => Scenario.LocationFlagDefinitions[152];
        public ILocationFlag _80 => Scenario.LocationFlagDefinitions[153];
        public ILocationFlag _81 => Scenario.LocationFlagDefinitions[154];
        public ILocationFlag _82 => Scenario.LocationFlagDefinitions[155];
        public ILocationFlag _83 => Scenario.LocationFlagDefinitions[156];
        public ILocationFlag _84 => Scenario.LocationFlagDefinitions[157];
        public ILocationFlag _86 => Scenario.LocationFlagDefinitions[158];
        public ILocationFlag _85 => Scenario.LocationFlagDefinitions[159];
        public ILocationFlag _87 => Scenario.LocationFlagDefinitions[160];
        public ILocationFlag _88 => Scenario.LocationFlagDefinitions[161];
        public ILocationFlag _89 => Scenario.LocationFlagDefinitions[162];
        public ILocationFlag _90 => Scenario.LocationFlagDefinitions[163];
        public ILocationFlag _91 => Scenario.LocationFlagDefinitions[164];
        public ILocationFlag _92 => Scenario.LocationFlagDefinitions[165];
        public ILocationFlag _93 => Scenario.LocationFlagDefinitions[166];
        public ILocationFlag _94 => Scenario.LocationFlagDefinitions[167];
        public ILocationFlag _95 => Scenario.LocationFlagDefinitions[168];
        public ILocationFlag _96 => Scenario.LocationFlagDefinitions[169];
        public ILocationFlag _97 => Scenario.LocationFlagDefinitions[170];
        public ILocationFlag _98 => Scenario.LocationFlagDefinitions[171];
        public ILocationFlag _99 => Scenario.LocationFlagDefinitions[172];
        public ILocationFlag _100 => Scenario.LocationFlagDefinitions[173];
        public ILocationFlag _174 => Scenario.LocationFlagDefinitions[174];
        public ILocationFlag _175 => Scenario.LocationFlagDefinitions[175];
        public ILocationFlag _176 => Scenario.LocationFlagDefinitions[176];
        public ILocationFlag _177 => Scenario.LocationFlagDefinitions[177];
        public ILocationFlag _178 => Scenario.LocationFlagDefinitions[178];
        public ILocationFlag _179 => Scenario.LocationFlagDefinitions[179];
        public ILocationFlag _180 => Scenario.LocationFlagDefinitions[180];
        public ILocationFlag _181 => Scenario.LocationFlagDefinitions[181];
        public ILocationFlag _182 => Scenario.LocationFlagDefinitions[182];
        public ILocationFlag _183 => Scenario.LocationFlagDefinitions[183];
        public ILocationFlag _184 => Scenario.LocationFlagDefinitions[184];
        public ILocationFlag _185 => Scenario.LocationFlagDefinitions[185];
        public ILocationFlag _186 => Scenario.LocationFlagDefinitions[186];
        public ILocationFlag _187 => Scenario.LocationFlagDefinitions[187];
        public ILocationFlag _188 => Scenario.LocationFlagDefinitions[188];
        public ILocationFlag _189 => Scenario.LocationFlagDefinitions[189];
        public ILocationFlag _190 => Scenario.LocationFlagDefinitions[190];
        public ILocationFlag _191 => Scenario.LocationFlagDefinitions[191];
        public ILocationFlag _192 => Scenario.LocationFlagDefinitions[192];
        public ILocationFlag _193 => Scenario.LocationFlagDefinitions[193];
        public ILocationFlag _194 => Scenario.LocationFlagDefinitions[194];
        public ILocationFlag _195 => Scenario.LocationFlagDefinitions[195];
        public ILocationFlag _196 => Scenario.LocationFlagDefinitions[196];
        public ILocationFlag _197 => Scenario.LocationFlagDefinitions[197];
        public ILocationFlag _198 => Scenario.LocationFlagDefinitions[198];
        public ILocationFlag _199 => Scenario.LocationFlagDefinitions[199];
        public ILocationFlag _200 => Scenario.LocationFlagDefinitions[200];
        public ILocationFlag _201 => Scenario.LocationFlagDefinitions[201];
        public ILocationFlag _202 => Scenario.LocationFlagDefinitions[202];
        public ILocationFlag _203 => Scenario.LocationFlagDefinitions[203];
        public ILocationFlag _204 => Scenario.LocationFlagDefinitions[204];
        public ILocationFlag _205 => Scenario.LocationFlagDefinitions[205];
        public ILocationFlag _206 => Scenario.LocationFlagDefinitions[206];
        public ILocationFlag _207 => Scenario.LocationFlagDefinitions[207];
        public ILocationFlag _208 => Scenario.LocationFlagDefinitions[208];
        public ILocationFlag _209 => Scenario.LocationFlagDefinitions[209];
        public ILocationFlag _210 => Scenario.LocationFlagDefinitions[210];
        public ILocationFlag _211 => Scenario.LocationFlagDefinitions[211];
        public ILocationFlag _212 => Scenario.LocationFlagDefinitions[212];
        public ILocationFlag _213 => Scenario.LocationFlagDefinitions[213];
        public ILocationFlag _214 => Scenario.LocationFlagDefinitions[214];
        public ILocationFlag _215 => Scenario.LocationFlagDefinitions[215];
        public ILocationFlag _216 => Scenario.LocationFlagDefinitions[216];
        public ILocationFlag _217 => Scenario.LocationFlagDefinitions[217];
        public ILocationFlag _218 => Scenario.LocationFlagDefinitions[218];
        public ILocationFlag _219 => Scenario.LocationFlagDefinitions[219];
        public ILocationFlag _220 => Scenario.LocationFlagDefinitions[220];
        public ILocationFlag _221 => Scenario.LocationFlagDefinitions[221];
        public ILocationFlag _222 => Scenario.LocationFlagDefinitions[222];
        public ILocationFlag _223 => Scenario.LocationFlagDefinitions[223];
        public ILocationFlag _224 => Scenario.LocationFlagDefinitions[224];
        public ILocationFlag _225 => Scenario.LocationFlagDefinitions[225];
        public ILocationFlag _226 => Scenario.LocationFlagDefinitions[226];
        public ILocationFlag _227 => Scenario.LocationFlagDefinitions[227];
        public ILocationFlag _228 => Scenario.LocationFlagDefinitions[228];
        public ILocationFlag _229 => Scenario.LocationFlagDefinitions[229];
        public ILocationFlag _230 => Scenario.LocationFlagDefinitions[230];
        public ILocationFlag _231 => Scenario.LocationFlagDefinitions[231];
        public ILocationFlag _232 => Scenario.LocationFlagDefinitions[232];
        public ILocationFlag _233 => Scenario.LocationFlagDefinitions[233];
        public ILocationFlag _234 => Scenario.LocationFlagDefinitions[234];
        public ILocationFlag _235 => Scenario.LocationFlagDefinitions[235];
        public ILocationFlag _236 => Scenario.LocationFlagDefinitions[236];
        public ILocationFlag _237 => Scenario.LocationFlagDefinitions[237];
        public ILocationFlag _238 => Scenario.LocationFlagDefinitions[238];
        public ILocationFlag _239 => Scenario.LocationFlagDefinitions[239];
        public ILocationFlag _240 => Scenario.LocationFlagDefinitions[240];
        public ILocationFlag _241 => Scenario.LocationFlagDefinitions[241];
        public ILocationFlag _242 => Scenario.LocationFlagDefinitions[242];
        public ILocationFlag _243 => Scenario.LocationFlagDefinitions[243];
        public ILocationFlag _244 => Scenario.LocationFlagDefinitions[244];
        public ILocationFlag _245 => Scenario.LocationFlagDefinitions[245];
        public ILocationFlag _246 => Scenario.LocationFlagDefinitions[246];
        public ILocationFlag _247 => Scenario.LocationFlagDefinitions[247];
        public ILocationFlag _248 => Scenario.LocationFlagDefinitions[248];
        public ILocationFlag _249 => Scenario.LocationFlagDefinitions[249];
        public ILocationFlag _250 => Scenario.LocationFlagDefinitions[250];
        public ILocationFlag _251 => Scenario.LocationFlagDefinitions[251];
        public ILocationFlag _252 => Scenario.LocationFlagDefinitions[252];
        public ILocationFlag _253 => Scenario.LocationFlagDefinitions[253];
        public ILocationFlag _254 => Scenario.LocationFlagDefinitions[254];
        public ILocationFlag _255 => Scenario.LocationFlagDefinitions[255];
        public ILocationFlag _256 => Scenario.LocationFlagDefinitions[256];
        public ILocationFlag _257 => Scenario.LocationFlagDefinitions[257];
        public ILocationFlag _258 => Scenario.LocationFlagDefinitions[258];
        public ILocationFlag _259 => Scenario.LocationFlagDefinitions[259];
        public ILocationFlag _260 => Scenario.LocationFlagDefinitions[260];
        public ILocationFlag _261 => Scenario.LocationFlagDefinitions[261];
        public ILocationFlag _262 => Scenario.LocationFlagDefinitions[262];
        public ILocationFlag _263 => Scenario.LocationFlagDefinitions[263];
        public ILocationFlag _264 => Scenario.LocationFlagDefinitions[264];
        public ILocationFlag _265 => Scenario.LocationFlagDefinitions[265];
        public ILocationFlag _266 => Scenario.LocationFlagDefinitions[266];
        public ILocationFlag _267 => Scenario.LocationFlagDefinitions[267];
        public ILocationFlag _268 => Scenario.LocationFlagDefinitions[268];
        public ILocationFlag _269 => Scenario.LocationFlagDefinitions[269];
        public ILocationFlag _270 => Scenario.LocationFlagDefinitions[270];
        public ILocationFlag _271 => Scenario.LocationFlagDefinitions[271];
        public ILocationFlag _272 => Scenario.LocationFlagDefinitions[272];
        public ILocationFlag _273 => Scenario.LocationFlagDefinitions[273];
        public ILocationFlag _274 => Scenario.LocationFlagDefinitions[274];
        public ILocationFlag _275 => Scenario.LocationFlagDefinitions[275];
        public ILocationFlag _276 => Scenario.LocationFlagDefinitions[276];
        public ILocationFlag _277 => Scenario.LocationFlagDefinitions[277];
        public ILocationFlag _278 => Scenario.LocationFlagDefinitions[278];
        public ILocationFlag _279 => Scenario.LocationFlagDefinitions[279];
        public ILocationFlag _280 => Scenario.LocationFlagDefinitions[280];
        public ILocationFlag _281 => Scenario.LocationFlagDefinitions[281];
        public ILocationFlag _282 => Scenario.LocationFlagDefinitions[282];
        public ILocationFlag _283 => Scenario.LocationFlagDefinitions[283];
        public ILocationFlag _284 => Scenario.LocationFlagDefinitions[284];
        public ILocationFlag _285 => Scenario.LocationFlagDefinitions[285];
        public ILocationFlag _286 => Scenario.LocationFlagDefinitions[286];
        public ILocationFlag _287 => Scenario.LocationFlagDefinitions[287];
        public ILocationFlag _288 => Scenario.LocationFlagDefinitions[288];
        public ILocationFlag _289 => Scenario.LocationFlagDefinitions[289];
        public ILocationFlag _290 => Scenario.LocationFlagDefinitions[290];
        public ILocationFlag _291 => Scenario.LocationFlagDefinitions[291];
        public ILocationFlag _292 => Scenario.LocationFlagDefinitions[292];
        public ILocationFlag _293 => Scenario.LocationFlagDefinitions[293];
        public ILocationFlag _294 => Scenario.LocationFlagDefinitions[294];
        public ILocationFlag _295 => Scenario.LocationFlagDefinitions[295];
        public ILocationFlag _296 => Scenario.LocationFlagDefinitions[296];
        public ILocationFlag _297 => Scenario.LocationFlagDefinitions[297];
        public ILocationFlag _298 => Scenario.LocationFlagDefinitions[298];
        public ILocationFlag _299 => Scenario.LocationFlagDefinitions[299];
        public ILocationFlag _300 => Scenario.LocationFlagDefinitions[300];
        public ILocationFlag _301 => Scenario.LocationFlagDefinitions[301];
        public ILocationFlag _302 => Scenario.LocationFlagDefinitions[302];
        public ILocationFlag _303 => Scenario.LocationFlagDefinitions[303];
        public ILocationFlag _304 => Scenario.LocationFlagDefinitions[304];
        public ILocationFlag _305 => Scenario.LocationFlagDefinitions[305];
        public ILocationFlag _306 => Scenario.LocationFlagDefinitions[306];
        public ILocationFlag _307 => Scenario.LocationFlagDefinitions[307];
        public ILocationFlag _308 => Scenario.LocationFlagDefinitions[308];
        public ILocationFlag anchor_flag_seraph => Scenario.LocationFlagDefinitions[309];
        public ILocationFlag croom01 => Scenario.LocationFlagDefinitions[310];
        public ILocationFlag croom02 => Scenario.LocationFlagDefinitions[311];
        public ILocationFlag croom03 => Scenario.LocationFlagDefinitions[312];
        public ILocationFlag croom04 => Scenario.LocationFlagDefinitions[313];
        public ILocationFlag croom05 => Scenario.LocationFlagDefinitions[314];
        public ILocationFlag croom06 => Scenario.LocationFlagDefinitions[315];
        public ILocationFlag tear01 => Scenario.LocationFlagDefinitions[316];
        public ILocationFlag tear02 => Scenario.LocationFlagDefinitions[317];
        public ILocationFlag tear03 => Scenario.LocationFlagDefinitions[318];
        public ILocationFlag tear04 => Scenario.LocationFlagDefinitions[319];
        public ILocationFlag tear05 => Scenario.LocationFlagDefinitions[320];
        public ILocationFlag tear06 => Scenario.LocationFlagDefinitions[321];
        public ILocationFlag tear07 => Scenario.LocationFlagDefinitions[322];
        public ILocationFlag tear08 => Scenario.LocationFlagDefinitions[323];
        public ILocationFlag tear09 => Scenario.LocationFlagDefinitions[324];
        public ILocationFlag tear10 => Scenario.LocationFlagDefinitions[325];
        public ILocationFlag tear11 => Scenario.LocationFlagDefinitions[326];
        public ILocationFlag tear12 => Scenario.LocationFlagDefinitions[327];
        public ILocationFlag tear13 => Scenario.LocationFlagDefinitions[328];
        public ILocationFlag tear14 => Scenario.LocationFlagDefinitions[329];
        public ILocationFlag tear15 => Scenario.LocationFlagDefinitions[330];
        public ILocationFlag tear16 => Scenario.LocationFlagDefinitions[331];
        public ILocationFlag tear17 => Scenario.LocationFlagDefinitions[332];
        public ILocationFlag tear18 => Scenario.LocationFlagDefinitions[333];
        public ILocationFlag tear19 => Scenario.LocationFlagDefinitions[334];
        public ILocationFlag croom07 => Scenario.LocationFlagDefinitions[335];
        public ILocationFlag croom08 => Scenario.LocationFlagDefinitions[336];
        public ILocationFlag croom09 => Scenario.LocationFlagDefinitions[337];
        public ILocationFlag croom10 => Scenario.LocationFlagDefinitions[338];
        public ILocationFlag croom11 => Scenario.LocationFlagDefinitions[339];
        public ILocationFlag croom12 => Scenario.LocationFlagDefinitions[340];
        public ILocationFlag flag_shield_impact => Scenario.LocationFlagDefinitions[341];
        public ILocationFlag mine_holo => Scenario.LocationFlagDefinitions[342];
        public ICinematicTitle title_1 => Scenario.CinematicTitleDefinitions[0].GameObject;
        public ICinematicTitle title_2 => Scenario.CinematicTitleDefinitions[1].GameObject;
        public ICinematicTitle title_3 => Scenario.CinematicTitleDefinitions[2].GameObject;
        public ITriggerVolume trans_0_3 => Scenario.TriggerVolumes[0].GameObject;
        public ITriggerVolume trans_3_0 => Scenario.TriggerVolumes[1].GameObject;
        public ITriggerVolume bsp_0_2 => Scenario.TriggerVolumes[2].GameObject;
        public ITriggerVolume trans_0_2 => Scenario.TriggerVolumes[3].GameObject;
        public ITriggerVolume trans_2_4 => Scenario.TriggerVolumes[4].GameObject;
        public ITriggerVolume bsp_4_1 => Scenario.TriggerVolumes[5].GameObject;
        public ITriggerVolume trans_4_1 => Scenario.TriggerVolumes[6].GameObject;
        public ITriggerVolume bsp_1_5 => Scenario.TriggerVolumes[7].GameObject;
        public ITriggerVolume trans_1_5 => Scenario.TriggerVolumes[8].GameObject;
        public ITriggerVolume bsp_5_1 => Scenario.TriggerVolumes[9].GameObject;
        public ITriggerVolume trans_5_1 => Scenario.TriggerVolumes[10].GameObject;
        public ITriggerVolume vol_arm_02_lz => Scenario.TriggerVolumes[11].GameObject;
        public ITriggerVolume vol_juggernaut_preview => Scenario.TriggerVolumes[12].GameObject;
        public ITriggerVolume vol_disposal_enter => Scenario.TriggerVolumes[13].GameObject;
        public ITriggerVolume vol_disposal_bottom => Scenario.TriggerVolumes[14].GameObject;
        public ITriggerVolume vol_disposal_all => Scenario.TriggerVolumes[15].GameObject;
        public ITriggerVolume vol_silo_enter => Scenario.TriggerVolumes[16].GameObject;
        public ITriggerVolume vol_specimen_storage => Scenario.TriggerVolumes[17].GameObject;
        public ITriggerVolume vol_leaving_silo => Scenario.TriggerVolumes[18].GameObject;
        public ITriggerVolume vol_hall_to_lab => Scenario.TriggerVolumes[19].GameObject;
        public ITriggerVolume vol_lab_enter => Scenario.TriggerVolumes[20].GameObject;
        public ITriggerVolume vol_lab_floor => Scenario.TriggerVolumes[21].GameObject;
        public ITriggerVolume vol_research_arm_swap => Scenario.TriggerVolumes[22].GameObject;
        public ITriggerVolume vol_reach_bridge => Scenario.TriggerVolumes[23].GameObject;
        public ITriggerVolume vol_on_bridge => Scenario.TriggerVolumes[24].GameObject;
        public ITriggerVolume vol_wrap_left_01 => Scenario.TriggerVolumes[25].GameObject;
        public ITriggerVolume vol_wrap_right_01 => Scenario.TriggerVolumes[26].GameObject;
        public ITriggerVolume vol_wrap_left_02 => Scenario.TriggerVolumes[27].GameObject;
        public ITriggerVolume vol_wrap_left_03 => Scenario.TriggerVolumes[28].GameObject;
        public ITriggerVolume vol_wrap_right_02 => Scenario.TriggerVolumes[29].GameObject;
        public ITriggerVolume vol_wrap_right_03 => Scenario.TriggerVolumes[30].GameObject;
        public ITriggerVolume vol_wrap_final => Scenario.TriggerVolumes[31].GameObject;
        public ITriggerVolume vol_control_enter => Scenario.TriggerVolumes[32].GameObject;
        public ITriggerVolume vol_near_shield => Scenario.TriggerVolumes[33].GameObject;
        public ITriggerVolume vol_control_middle => Scenario.TriggerVolumes[34].GameObject;
        public ITriggerVolume vol_control_perimeter => Scenario.TriggerVolumes[35].GameObject;
        public ITriggerVolume vol_control_entry_int => Scenario.TriggerVolumes[36].GameObject;
        public ITriggerVolume vol_control_bottom_spawnroom => Scenario.TriggerVolumes[37].GameObject;
        public ITriggerVolume vol_control_peri_spawnroom => Scenario.TriggerVolumes[38].GameObject;
        public ITriggerVolume vol_control_middle_spawnroom => Scenario.TriggerVolumes[39].GameObject;
        public ITriggerVolume vol_going_down => Scenario.TriggerVolumes[40].GameObject;
        public ITriggerVolume vol_cableroom_center => Scenario.TriggerVolumes[41].GameObject;
        public ITriggerVolume vol_cable_room_01 => Scenario.TriggerVolumes[42].GameObject;
        public ITriggerVolume vol_cable_room_02 => Scenario.TriggerVolumes[43].GameObject;
        public ITriggerVolume vol_cable_room_03 => Scenario.TriggerVolumes[44].GameObject;
        public ITriggerVolume vol_cable_room_all => Scenario.TriggerVolumes[45].GameObject;
        public ITriggerVolume vol_control_return => Scenario.TriggerVolumes[46].GameObject;
        public ITriggerVolume vol_control_return_perimeter => Scenario.TriggerVolumes[47].GameObject;
        public ITriggerVolume vol_control_return_middle => Scenario.TriggerVolumes[48].GameObject;
        public ITriggerVolume vol_power_core_enter => Scenario.TriggerVolumes[49].GameObject;
        public ITriggerVolume vol_power_core_midway => Scenario.TriggerVolumes[50].GameObject;
        public ITriggerVolume vol_power_core_bottom => Scenario.TriggerVolumes[51].GameObject;
        public ITriggerVolume vol_power_core_exit => Scenario.TriggerVolumes[52].GameObject;
        public ITriggerVolume vol_power_core_ledge => Scenario.TriggerVolumes[53].GameObject;
        public ITriggerVolume vol_arm_01_return => Scenario.TriggerVolumes[54].GameObject;
        public ITriggerVolume vol_bottling_return_01r => Scenario.TriggerVolumes[55].GameObject;
        public ITriggerVolume vol_bottling_return_01l => Scenario.TriggerVolumes[56].GameObject;
        public ITriggerVolume vol_bottling_return_02 => Scenario.TriggerVolumes[57].GameObject;
        public ITriggerVolume vol_hl_delete_01 => Scenario.TriggerVolumes[58].GameObject;
        public ITriggerVolume vol_hl_retreat_02 => Scenario.TriggerVolumes[59].GameObject;
        public ITriggerVolume vol_bottling_back => Scenario.TriggerVolumes[60].GameObject;
        public ITriggerVolume vol_bottling_back_top => Scenario.TriggerVolumes[61].GameObject;
        public ITriggerVolume vol_hl_delete_02 => Scenario.TriggerVolumes[62].GameObject;
        public ITriggerVolume vol_bottling_enter => Scenario.TriggerVolumes[63].GameObject;
        public ITriggerVolume vol_bottling_mid01 => Scenario.TriggerVolumes[64].GameObject;
        public ITriggerVolume vol_bottling_mid02 => Scenario.TriggerVolumes[65].GameObject;
        public ITriggerVolume vol_bottling_mid03 => Scenario.TriggerVolumes[66].GameObject;
        public ITriggerVolume vol_2nd_hall_01 => Scenario.TriggerVolumes[67].GameObject;
        public ITriggerVolume vol_2nd_hall_02 => Scenario.TriggerVolumes[68].GameObject;
        public ITriggerVolume vol_2nd_hall_03 => Scenario.TriggerVolumes[69].GameObject;
        public ITriggerVolume vol_hall2_spawn_01 => Scenario.TriggerVolumes[70].GameObject;
        public ITriggerVolume vol_hall2_spawn_02 => Scenario.TriggerVolumes[71].GameObject;
        public ITriggerVolume vol_hall2_spawn_03 => Scenario.TriggerVolumes[72].GameObject;
        public ITriggerVolume vol_underhangar_return_01 => Scenario.TriggerVolumes[73].GameObject;
        public ITriggerVolume vol_underhangar_return_02 => Scenario.TriggerVolumes[74].GameObject;
        public ITriggerVolume vol_underhangar_from_top => Scenario.TriggerVolumes[75].GameObject;
        public ITriggerVolume vol_underhangar_from_bottom => Scenario.TriggerVolumes[76].GameObject;
        public ITriggerVolume vol_underhangar_music => Scenario.TriggerVolumes[77].GameObject;
        public ITriggerVolume vol_underhangar_spawn_01 => Scenario.TriggerVolumes[78].GameObject;
        public ITriggerVolume vol_underhangar_spawn_02 => Scenario.TriggerVolumes[79].GameObject;
        public ITriggerVolume vol_underhangar_shaft_02 => Scenario.TriggerVolumes[80].GameObject;
        public ITriggerVolume vol_underhangar_shaft_01 => Scenario.TriggerVolumes[81].GameObject;
        public ITriggerVolume vol_first_hall_01 => Scenario.TriggerVolumes[82].GameObject;
        public ITriggerVolume vol_hangar_cutscene_start => Scenario.TriggerVolumes[83].GameObject;
        public ITriggerVolume vol_hangar_left => Scenario.TriggerVolumes[84].GameObject;
        public ITriggerVolume vol_hangar_right => Scenario.TriggerVolumes[85].GameObject;
        public ITriggerVolume vol_hangar_top => Scenario.TriggerVolumes[86].GameObject;
        public ITriggerVolume vol_hangar_low => Scenario.TriggerVolumes[87].GameObject;
        public ITriggerVolume vol_hangar_center_end => Scenario.TriggerVolumes[88].GameObject;
        public ITriggerVolume vol_hangar_center_exit => Scenario.TriggerVolumes[89].GameObject;
        public ITriggerVolume vol_leaving_hangar => Scenario.TriggerVolumes[90].GameObject;
        public ITriggerVolume vol_hangar_reenter => Scenario.TriggerVolumes[91].GameObject;
        public ITriggerVolume kill_hangar_pit_01 => Scenario.TriggerVolumes[92].GameObject;
        public ITriggerVolume kill_hangar_pit_02 => Scenario.TriggerVolumes[93].GameObject;
        public ITriggerVolume kill_hangar_pit_03 => Scenario.TriggerVolumes[94].GameObject;
        public ITriggerVolume kill_hangar_pit_04 => Scenario.TriggerVolumes[95].GameObject;
        public ITriggerVolume kill_underhangar_pit_01 => Scenario.TriggerVolumes[96].GameObject;
        public ITriggerVolume kill_underhangar_pit_02 => Scenario.TriggerVolumes[97].GameObject;
        public ITriggerVolume kill_bottling_pit_01 => Scenario.TriggerVolumes[98].GameObject;
        public ITriggerVolume kill_bottling_pit_02 => Scenario.TriggerVolumes[99].GameObject;
        public ITriggerVolume vol_cableroom_pit_01 => Scenario.TriggerVolumes[100].GameObject;
        public ITriggerVolume vol_cableroom_pit_02 => Scenario.TriggerVolumes[101].GameObject;
        public ITriggerVolume vol_cableroom_pit_03 => Scenario.TriggerVolumes[102].GameObject;
        public ITriggerVolume kill_silo_pit => Scenario.TriggerVolumes[103].GameObject;
        public ITriggerVolume vol_cableroom_suck_kill => Scenario.TriggerVolumes[104].GameObject;
        public ITriggerVolume aquarium => Scenario.TriggerVolumes[105].GameObject;
        public ITriggerVolume vol_boss_delete_r => Scenario.TriggerVolumes[106].GameObject;
        public ITriggerVolume vol_boss_delete_l => Scenario.TriggerVolumes[107].GameObject;
        public ITriggerVolume vol_boss_delete_c1 => Scenario.TriggerVolumes[108].GameObject;
        public ITriggerVolume vol_boss_delete_c2 => Scenario.TriggerVolumes[109].GameObject;
        public ITriggerVolume kill_wraparound => Scenario.TriggerVolumes[110].GameObject;
        public ITriggerVolume vol_soc_reborn => Scenario.TriggerVolumes[111].GameObject;
        public ITriggerVolume vol_soc_post => Scenario.TriggerVolumes[112].GameObject;
        public ITriggerVolume kill_silo_toggle => Scenario.TriggerVolumes[113].GameObject;
        public ITriggerVolume vol_plummet_kill => Scenario.TriggerVolumes[114].GameObject;
        public ITriggerVolume vol_plummet_nr => Scenario.TriggerVolumes[115].GameObject;
        public ITriggerVolume vol_plummet_nl => Scenario.TriggerVolumes[116].GameObject;
        public ITriggerVolume vol_plummet_fl => Scenario.TriggerVolumes[117].GameObject;
        public ITriggerVolume vol_plummet_fr => Scenario.TriggerVolumes[118].GameObject;
        public ITriggerVolume vol_silo_save => Scenario.TriggerVolumes[119].GameObject;
        public ITriggerVolume vol_phantom_suck => Scenario.TriggerVolumes[120].GameObject;
        public ITriggerVolume vol_control_top => Scenario.TriggerVolumes[121].GameObject;
        public ITriggerVolume kill_power_core_01 => Scenario.TriggerVolumes[122].GameObject;
        public ITriggerVolume kill_power_core_02 => Scenario.TriggerVolumes[123].GameObject;
        public ITriggerVolume vol_famine_01 => Scenario.TriggerVolumes[124].GameObject;
        public ITriggerVolume vol_famine_02 => Scenario.TriggerVolumes[125].GameObject;
        public ITriggerVolume vol_gusty => Scenario.TriggerVolumes[126].GameObject;
        public ITriggerVolume vol_croom_kill_new => Scenario.TriggerVolumes[127].GameObject;
        public ITriggerVolume vol_croom_kill_new_too => Scenario.TriggerVolumes[128].GameObject;
        public ITriggerVolume vol_hl_killer => Scenario.TriggerVolumes[129].GameObject;
        public IStartingProfile player_starting_profile_0 => Scenario.StartingProfileDefinitions[0].GameObject;
        public IStartingProfile player_starting_profile_1 => Scenario.StartingProfileDefinitions[1].GameObject;
        public IStartingProfile rifle => Scenario.StartingProfileDefinitions[2].GameObject;
        public IStartingProfile carbine => Scenario.StartingProfileDefinitions[3].GameObject;
        public IStartingProfile sniper => Scenario.StartingProfileDefinitions[4].GameObject;
        public IStartingProfile needler => Scenario.StartingProfileDefinitions[5].GameObject;
        public IStartingProfile pistol => Scenario.StartingProfileDefinitions[6].GameObject;
        public IStartingProfile flak => Scenario.StartingProfileDefinitions[7].GameObject;
        public IStartingProfile beam => Scenario.StartingProfileDefinitions[8].GameObject;
        public IStartingProfile sword => Scenario.StartingProfileDefinitions[9].GameObject;
        public IStartingProfile swap => Scenario.StartingProfileDefinitions[10].GameObject;
        public IDeviceGroup elev_control_up1 => Scenario.DeviceGroupDefinitions[0].GameObject;
        public IDeviceGroup elev_control_down1 => Scenario.DeviceGroupDefinitions[1].GameObject;
        public IDeviceGroup _04_intra0 => Scenario.DeviceGroupDefinitions[2].GameObject;
        public override void InitializeData(ScenarioTag scenarioTag, Scene scene)
        {
            this.Scenario = scenarioTag;
            outro_seraph = new ScenarioEntity<IScenery>(0, scenarioTag.WellKnownItems[0]);
            holo_drone_2 = new ScenarioEntity<IScenery>(1, scenarioTag.WellKnownItems[1]);
            holo_drone_1 = new ScenarioEntity<IScenery>(2, scenarioTag.WellKnownItems[2]);
            can01 = new ScenarioEntity<IBloc>(3, scenarioTag.WellKnownItems[3]);
            can02 = new ScenarioEntity<IBloc>(4, scenarioTag.WellKnownItems[4]);
            can03 = new ScenarioEntity<IBloc>(5, scenarioTag.WellKnownItems[5]);
            can04 = new ScenarioEntity<IBloc>(6, scenarioTag.WellKnownItems[6]);
            can05 = new ScenarioEntity<IBloc>(7, scenarioTag.WellKnownItems[7]);
            croom_junk_01 = new ScenarioEntity<IBloc>(8, scenarioTag.WellKnownItems[8]);
            croom_junk_02 = new ScenarioEntity<IBloc>(9, scenarioTag.WellKnownItems[9]);
            croom_junk_03 = new ScenarioEntity<IBloc>(10, scenarioTag.WellKnownItems[10]);
            croom_junk_04 = new ScenarioEntity<IBloc>(11, scenarioTag.WellKnownItems[11]);
            croom_junk_05 = new ScenarioEntity<IBloc>(12, scenarioTag.WellKnownItems[12]);
            croom_junk_06 = new ScenarioEntity<IBloc>(13, scenarioTag.WellKnownItems[13]);
            croom_junk_07 = new ScenarioEntity<IBloc>(14, scenarioTag.WellKnownItems[14]);
            croom_junk_08 = new ScenarioEntity<IBloc>(15, scenarioTag.WellKnownItems[15]);
            croom_junk_09 = new ScenarioEntity<IBloc>(16, scenarioTag.WellKnownItems[16]);
            croom_junk_10 = new ScenarioEntity<IBloc>(17, scenarioTag.WellKnownItems[17]);
            croom_junk_11 = new ScenarioEntity<IBloc>(18, scenarioTag.WellKnownItems[18]);
            croom_junk_12 = new ScenarioEntity<IBloc>(19, scenarioTag.WellKnownItems[19]);
            croom_junk_13 = new ScenarioEntity<IBloc>(20, scenarioTag.WellKnownItems[20]);
            croom_junk_14 = new ScenarioEntity<IBloc>(21, scenarioTag.WellKnownItems[21]);
            croom_junk_15 = new ScenarioEntity<IBloc>(22, scenarioTag.WellKnownItems[22]);
            croom_junk_16 = new ScenarioEntity<IBloc>(23, scenarioTag.WellKnownItems[23]);
            croom_junk_17 = new ScenarioEntity<IBloc>(24, scenarioTag.WellKnownItems[24]);
            anchor02 = new ScenarioEntity<IScenery>(25, scenarioTag.WellKnownItems[25]);
            hammer = new ScenarioEntity<IScenery>(26, scenarioTag.WellKnownItems[26]);
            dummy_can = new ScenarioEntity<IBloc>(27, scenarioTag.WellKnownItems[27]);
            can06 = new ScenarioEntity<IBloc>(28, scenarioTag.WellKnownItems[28]);
            cap_01_1 = new ScenarioEntity<IScenery>(29, scenarioTag.WellKnownItems[29]);
            cap_01_5 = new ScenarioEntity<IScenery>(30, scenarioTag.WellKnownItems[30]);
            cap_01_6 = new ScenarioEntity<IScenery>(31, scenarioTag.WellKnownItems[31]);
            cap_01_7 = new ScenarioEntity<IScenery>(32, scenarioTag.WellKnownItems[32]);
            cap_01_8 = new ScenarioEntity<IScenery>(33, scenarioTag.WellKnownItems[33]);
            cap_01_2 = new ScenarioEntity<IScenery>(34, scenarioTag.WellKnownItems[34]);
            cap_01_3 = new ScenarioEntity<IScenery>(35, scenarioTag.WellKnownItems[35]);
            cap_01_4 = new ScenarioEntity<IScenery>(36, scenarioTag.WellKnownItems[36]);
            cap_01_9 = new ScenarioEntity<IScenery>(37, scenarioTag.WellKnownItems[37]);
            cap_01_10 = new ScenarioEntity<IScenery>(38, scenarioTag.WellKnownItems[38]);
            cap_01_11 = new ScenarioEntity<IScenery>(39, scenarioTag.WellKnownItems[39]);
            cap_01_12 = new ScenarioEntity<IScenery>(40, scenarioTag.WellKnownItems[40]);
            cap_02_1 = new ScenarioEntity<IScenery>(41, scenarioTag.WellKnownItems[41]);
            cap_02_2 = new ScenarioEntity<IScenery>(42, scenarioTag.WellKnownItems[42]);
            cap_02_3 = new ScenarioEntity<IScenery>(43, scenarioTag.WellKnownItems[43]);
            stop_02 = new ScenarioEntity<IScenery>(44, scenarioTag.WellKnownItems[44]);
            cap_02_5 = new ScenarioEntity<IScenery>(45, scenarioTag.WellKnownItems[45]);
            cap_02_7 = new ScenarioEntity<IScenery>(46, scenarioTag.WellKnownItems[46]);
            cap_02_6 = new ScenarioEntity<IScenery>(47, scenarioTag.WellKnownItems[47]);
            cap_02_8 = new ScenarioEntity<IScenery>(48, scenarioTag.WellKnownItems[48]);
            cap_02_9 = new ScenarioEntity<IScenery>(49, scenarioTag.WellKnownItems[49]);
            cap_02_10 = new ScenarioEntity<IScenery>(50, scenarioTag.WellKnownItems[50]);
            cap_02_11 = new ScenarioEntity<IScenery>(51, scenarioTag.WellKnownItems[51]);
            cap_03_4 = new ScenarioEntity<IScenery>(52, scenarioTag.WellKnownItems[52]);
            cap_03_3 = new ScenarioEntity<IScenery>(53, scenarioTag.WellKnownItems[53]);
            cap_03_2 = new ScenarioEntity<IScenery>(54, scenarioTag.WellKnownItems[54]);
            cap_03_1 = new ScenarioEntity<IScenery>(55, scenarioTag.WellKnownItems[55]);
            cap_03_5 = new ScenarioEntity<IScenery>(56, scenarioTag.WellKnownItems[56]);
            cap_03_6 = new ScenarioEntity<IScenery>(57, scenarioTag.WellKnownItems[57]);
            cap_03_7 = new ScenarioEntity<IScenery>(58, scenarioTag.WellKnownItems[58]);
            cap_03_8 = new ScenarioEntity<IScenery>(59, scenarioTag.WellKnownItems[59]);
            cap_04_1 = new ScenarioEntity<IScenery>(60, scenarioTag.WellKnownItems[60]);
            cap_04_2 = new ScenarioEntity<IScenery>(61, scenarioTag.WellKnownItems[61]);
            cap_04_3 = new ScenarioEntity<IScenery>(62, scenarioTag.WellKnownItems[62]);
            cap_04_4 = new ScenarioEntity<IScenery>(63, scenarioTag.WellKnownItems[63]);
            cap_04_5 = new ScenarioEntity<IScenery>(64, scenarioTag.WellKnownItems[64]);
            cap_04_6 = new ScenarioEntity<IScenery>(65, scenarioTag.WellKnownItems[65]);
            cap_04_7 = new ScenarioEntity<IScenery>(66, scenarioTag.WellKnownItems[66]);
            cap_04_8 = new ScenarioEntity<IScenery>(67, scenarioTag.WellKnownItems[67]);
            cap_04_9 = new ScenarioEntity<IScenery>(68, scenarioTag.WellKnownItems[68]);
            cap_04_10 = new ScenarioEntity<IScenery>(69, scenarioTag.WellKnownItems[69]);
            cap_04_11 = new ScenarioEntity<IScenery>(70, scenarioTag.WellKnownItems[70]);
            cap_04_12 = new ScenarioEntity<IScenery>(71, scenarioTag.WellKnownItems[71]);
            stop_01 = new ScenarioEntity<IScenery>(72, scenarioTag.WellKnownItems[72]);
            cap_02_4 = new ScenarioEntity<IScenery>(73, scenarioTag.WellKnownItems[73]);
            stop_03 = new ScenarioEntity<IScenery>(74, scenarioTag.WellKnownItems[74]);
            stop_04 = new ScenarioEntity<IScenery>(75, scenarioTag.WellKnownItems[75]);
            stop_06 = new ScenarioEntity<IScenery>(76, scenarioTag.WellKnownItems[76]);
            stop_05 = new ScenarioEntity<IScenery>(77, scenarioTag.WellKnownItems[77]);
            anchor_intra0 = new ScenarioEntity<IScenery>(78, scenarioTag.WellKnownItems[78]);
            pr_intra0_der = new ScenarioEntity<IScenery>(79, scenarioTag.WellKnownItems[79]);
            eb_intra0_soc = new ScenarioEntity<IScenery>(80, scenarioTag.WellKnownItems[80]);
            pr_intra0_soe_01 = new ScenarioEntity<IScenery>(81, scenarioTag.WellKnownItems[81]);
            pr_intra0_soe_02 = new ScenarioEntity<IScenery>(82, scenarioTag.WellKnownItems[82]);
            pr_intra0_soe_03 = new ScenarioEntity<IScenery>(83, scenarioTag.WellKnownItems[83]);
            pp_intra0_sog_01 = new ScenarioEntity<IScenery>(84, scenarioTag.WellKnownItems[84]);
            pp_intra0_sog_02 = new ScenarioEntity<IScenery>(85, scenarioTag.WellKnownItems[85]);
            hangar_door_ingame = new ScenarioEntity<IScenery>(86, scenarioTag.WellKnownItems[86]);
            gasmine_hologram = new ScenarioEntity<IScenery>(87, scenarioTag.WellKnownItems[87]);
            intra1_blade = new ScenarioEntity<IScenery>(88, scenarioTag.WellKnownItems[88]);
            intra1_rifle_01 = new ScenarioEntity<IScenery>(89, scenarioTag.WellKnownItems[89]);
            intra1_rifle_02 = new ScenarioEntity<IScenery>(90, scenarioTag.WellKnownItems[90]);
            cable_target_a = new ScenarioEntity<IScenery>(91, scenarioTag.WellKnownItems[91]);
            cable_target_b = new ScenarioEntity<IScenery>(92, scenarioTag.WellKnownItems[92]);
            cable_target_c = new ScenarioEntity<IScenery>(93, scenarioTag.WellKnownItems[93]);
            gas01 = new ScenarioEntity<IScenery>(94, scenarioTag.WellKnownItems[94]);
            gas02 = new ScenarioEntity<IScenery>(95, scenarioTag.WellKnownItems[95]);
            gas03 = new ScenarioEntity<IScenery>(96, scenarioTag.WellKnownItems[96]);
            gas04 = new ScenarioEntity<IScenery>(97, scenarioTag.WellKnownItems[97]);
            gas05 = new ScenarioEntity<IScenery>(98, scenarioTag.WellKnownItems[98]);
            gas06 = new ScenarioEntity<IScenery>(99, scenarioTag.WellKnownItems[99]);
            gas07 = new ScenarioEntity<IScenery>(100, scenarioTag.WellKnownItems[100]);
            gas08 = new ScenarioEntity<IScenery>(101, scenarioTag.WellKnownItems[101]);
            gas09 = new ScenarioEntity<IScenery>(102, scenarioTag.WellKnownItems[102]);
            gas10 = new ScenarioEntity<IScenery>(103, scenarioTag.WellKnownItems[103]);
            holo_boy = new ScenarioEntity<IScenery>(104, scenarioTag.WellKnownItems[104]);
            nl01 = new ScenarioEntity<IBloc>(105, scenarioTag.WellKnownItems[105]);
            nl02 = new ScenarioEntity<IBloc>(106, scenarioTag.WellKnownItems[106]);
            nl03 = new ScenarioEntity<IBloc>(107, scenarioTag.WellKnownItems[107]);
            nl04 = new ScenarioEntity<IBloc>(108, scenarioTag.WellKnownItems[108]);
            nl05 = new ScenarioEntity<IBloc>(109, scenarioTag.WellKnownItems[109]);
            nl06 = new ScenarioEntity<IBloc>(110, scenarioTag.WellKnownItems[110]);
            nl07 = new ScenarioEntity<IBloc>(111, scenarioTag.WellKnownItems[111]);
            nl08 = new ScenarioEntity<IBloc>(112, scenarioTag.WellKnownItems[112]);
            nl09 = new ScenarioEntity<IBloc>(113, scenarioTag.WellKnownItems[113]);
            nl10 = new ScenarioEntity<IBloc>(114, scenarioTag.WellKnownItems[114]);
            nl11 = new ScenarioEntity<IBloc>(115, scenarioTag.WellKnownItems[115]);
            nl12 = new ScenarioEntity<IBloc>(116, scenarioTag.WellKnownItems[116]);
            nl13 = new ScenarioEntity<IBloc>(117, scenarioTag.WellKnownItems[117]);
            nl14 = new ScenarioEntity<IBloc>(118, scenarioTag.WellKnownItems[118]);
            nl15 = new ScenarioEntity<IBloc>(119, scenarioTag.WellKnownItems[119]);
            nl16 = new ScenarioEntity<IBloc>(120, scenarioTag.WellKnownItems[120]);
            nl17 = new ScenarioEntity<IBloc>(121, scenarioTag.WellKnownItems[121]);
            nl18 = new ScenarioEntity<IBloc>(122, scenarioTag.WellKnownItems[122]);
            nl19 = new ScenarioEntity<IBloc>(123, scenarioTag.WellKnownItems[123]);
            nl20 = new ScenarioEntity<IBloc>(124, scenarioTag.WellKnownItems[124]);
            nl21 = new ScenarioEntity<IBloc>(125, scenarioTag.WellKnownItems[125]);
            nl22 = new ScenarioEntity<IBloc>(126, scenarioTag.WellKnownItems[126]);
            nl23 = new ScenarioEntity<IBloc>(127, scenarioTag.WellKnownItems[127]);
            nl24 = new ScenarioEntity<IBloc>(128, scenarioTag.WellKnownItems[128]);
            nl25 = new ScenarioEntity<IBloc>(129, scenarioTag.WellKnownItems[129]);
            nl26 = new ScenarioEntity<IBloc>(130, scenarioTag.WellKnownItems[130]);
            nl27 = new ScenarioEntity<IBloc>(131, scenarioTag.WellKnownItems[131]);
            nl28 = new ScenarioEntity<IBloc>(132, scenarioTag.WellKnownItems[132]);
            nl29 = new ScenarioEntity<IBloc>(133, scenarioTag.WellKnownItems[133]);
            nl30 = new ScenarioEntity<IBloc>(134, scenarioTag.WellKnownItems[134]);
            nl31 = new ScenarioEntity<IBloc>(135, scenarioTag.WellKnownItems[135]);
            nl32 = new ScenarioEntity<IBloc>(136, scenarioTag.WellKnownItems[136]);
            nr01 = new ScenarioEntity<IBloc>(137, scenarioTag.WellKnownItems[137]);
            nr02 = new ScenarioEntity<IBloc>(138, scenarioTag.WellKnownItems[138]);
            nr03 = new ScenarioEntity<IBloc>(139, scenarioTag.WellKnownItems[139]);
            nr04 = new ScenarioEntity<IBloc>(140, scenarioTag.WellKnownItems[140]);
            nr05 = new ScenarioEntity<IBloc>(141, scenarioTag.WellKnownItems[141]);
            nr06 = new ScenarioEntity<IBloc>(142, scenarioTag.WellKnownItems[142]);
            nr07 = new ScenarioEntity<IBloc>(143, scenarioTag.WellKnownItems[143]);
            nr08 = new ScenarioEntity<IBloc>(144, scenarioTag.WellKnownItems[144]);
            nr09 = new ScenarioEntity<IBloc>(145, scenarioTag.WellKnownItems[145]);
            nr10 = new ScenarioEntity<IBloc>(146, scenarioTag.WellKnownItems[146]);
            nr11 = new ScenarioEntity<IBloc>(147, scenarioTag.WellKnownItems[147]);
            nr12 = new ScenarioEntity<IBloc>(148, scenarioTag.WellKnownItems[148]);
            nr13 = new ScenarioEntity<IBloc>(149, scenarioTag.WellKnownItems[149]);
            nr14 = new ScenarioEntity<IBloc>(150, scenarioTag.WellKnownItems[150]);
            nr15 = new ScenarioEntity<IBloc>(151, scenarioTag.WellKnownItems[151]);
            nr16 = new ScenarioEntity<IBloc>(152, scenarioTag.WellKnownItems[152]);
            nr17 = new ScenarioEntity<IBloc>(153, scenarioTag.WellKnownItems[153]);
            nr18 = new ScenarioEntity<IBloc>(154, scenarioTag.WellKnownItems[154]);
            nr19 = new ScenarioEntity<IBloc>(155, scenarioTag.WellKnownItems[155]);
            nr20 = new ScenarioEntity<IBloc>(156, scenarioTag.WellKnownItems[156]);
            nr21 = new ScenarioEntity<IBloc>(157, scenarioTag.WellKnownItems[157]);
            nr22 = new ScenarioEntity<IBloc>(158, scenarioTag.WellKnownItems[158]);
            nr23 = new ScenarioEntity<IBloc>(159, scenarioTag.WellKnownItems[159]);
            nr24 = new ScenarioEntity<IBloc>(160, scenarioTag.WellKnownItems[160]);
            fr01 = new ScenarioEntity<IBloc>(161, scenarioTag.WellKnownItems[161]);
            fr02 = new ScenarioEntity<IBloc>(162, scenarioTag.WellKnownItems[162]);
            fr03 = new ScenarioEntity<IBloc>(163, scenarioTag.WellKnownItems[163]);
            fr04 = new ScenarioEntity<IBloc>(164, scenarioTag.WellKnownItems[164]);
            fr05 = new ScenarioEntity<IBloc>(165, scenarioTag.WellKnownItems[165]);
            fr06 = new ScenarioEntity<IBloc>(166, scenarioTag.WellKnownItems[166]);
            fr07 = new ScenarioEntity<IBloc>(167, scenarioTag.WellKnownItems[167]);
            fr08 = new ScenarioEntity<IBloc>(168, scenarioTag.WellKnownItems[168]);
            fr09 = new ScenarioEntity<IBloc>(169, scenarioTag.WellKnownItems[169]);
            fr10 = new ScenarioEntity<IBloc>(170, scenarioTag.WellKnownItems[170]);
            fr11 = new ScenarioEntity<IBloc>(171, scenarioTag.WellKnownItems[171]);
            fr12 = new ScenarioEntity<IBloc>(172, scenarioTag.WellKnownItems[172]);
            fr13 = new ScenarioEntity<IBloc>(173, scenarioTag.WellKnownItems[173]);
            fr14 = new ScenarioEntity<IBloc>(174, scenarioTag.WellKnownItems[174]);
            fr15 = new ScenarioEntity<IBloc>(175, scenarioTag.WellKnownItems[175]);
            fr16 = new ScenarioEntity<IBloc>(176, scenarioTag.WellKnownItems[176]);
            fr17 = new ScenarioEntity<IBloc>(177, scenarioTag.WellKnownItems[177]);
            fr18 = new ScenarioEntity<IBloc>(178, scenarioTag.WellKnownItems[178]);
            fr19 = new ScenarioEntity<IBloc>(179, scenarioTag.WellKnownItems[179]);
            fr20 = new ScenarioEntity<IBloc>(180, scenarioTag.WellKnownItems[180]);
            fr21 = new ScenarioEntity<IBloc>(181, scenarioTag.WellKnownItems[181]);
            fr22 = new ScenarioEntity<IBloc>(182, scenarioTag.WellKnownItems[182]);
            fr23 = new ScenarioEntity<IBloc>(183, scenarioTag.WellKnownItems[183]);
            fr24 = new ScenarioEntity<IBloc>(184, scenarioTag.WellKnownItems[184]);
            fr25 = new ScenarioEntity<IBloc>(185, scenarioTag.WellKnownItems[185]);
            fr26 = new ScenarioEntity<IBloc>(186, scenarioTag.WellKnownItems[186]);
            fr27 = new ScenarioEntity<IBloc>(187, scenarioTag.WellKnownItems[187]);
            fr28 = new ScenarioEntity<IBloc>(188, scenarioTag.WellKnownItems[188]);
            fr29 = new ScenarioEntity<IBloc>(189, scenarioTag.WellKnownItems[189]);
            fr30 = new ScenarioEntity<IBloc>(190, scenarioTag.WellKnownItems[190]);
            fr31 = new ScenarioEntity<IBloc>(191, scenarioTag.WellKnownItems[191]);
            fr32 = new ScenarioEntity<IBloc>(192, scenarioTag.WellKnownItems[192]);
            fl01 = new ScenarioEntity<IBloc>(193, scenarioTag.WellKnownItems[193]);
            fl02 = new ScenarioEntity<IBloc>(194, scenarioTag.WellKnownItems[194]);
            fl03 = new ScenarioEntity<IBloc>(195, scenarioTag.WellKnownItems[195]);
            fl04 = new ScenarioEntity<IBloc>(196, scenarioTag.WellKnownItems[196]);
            fl05 = new ScenarioEntity<IBloc>(197, scenarioTag.WellKnownItems[197]);
            fl06 = new ScenarioEntity<IBloc>(198, scenarioTag.WellKnownItems[198]);
            fl07 = new ScenarioEntity<IBloc>(199, scenarioTag.WellKnownItems[199]);
            fl08 = new ScenarioEntity<IBloc>(200, scenarioTag.WellKnownItems[200]);
            fl09 = new ScenarioEntity<IBloc>(201, scenarioTag.WellKnownItems[201]);
            fl10 = new ScenarioEntity<IBloc>(202, scenarioTag.WellKnownItems[202]);
            fl11 = new ScenarioEntity<IBloc>(203, scenarioTag.WellKnownItems[203]);
            fl12 = new ScenarioEntity<IBloc>(204, scenarioTag.WellKnownItems[204]);
            fl13 = new ScenarioEntity<IBloc>(205, scenarioTag.WellKnownItems[205]);
            fl14 = new ScenarioEntity<IBloc>(206, scenarioTag.WellKnownItems[206]);
            fl15 = new ScenarioEntity<IBloc>(207, scenarioTag.WellKnownItems[207]);
            fl16 = new ScenarioEntity<IBloc>(208, scenarioTag.WellKnownItems[208]);
            fl17 = new ScenarioEntity<IBloc>(209, scenarioTag.WellKnownItems[209]);
            fl18 = new ScenarioEntity<IBloc>(210, scenarioTag.WellKnownItems[210]);
            fl19 = new ScenarioEntity<IBloc>(211, scenarioTag.WellKnownItems[211]);
            fl20 = new ScenarioEntity<IBloc>(212, scenarioTag.WellKnownItems[212]);
            fl21 = new ScenarioEntity<IBloc>(213, scenarioTag.WellKnownItems[213]);
            fl22 = new ScenarioEntity<IBloc>(214, scenarioTag.WellKnownItems[214]);
            fl23 = new ScenarioEntity<IBloc>(215, scenarioTag.WellKnownItems[215]);
            fl24 = new ScenarioEntity<IBloc>(216, scenarioTag.WellKnownItems[216]);
            fl25 = new ScenarioEntity<IBloc>(217, scenarioTag.WellKnownItems[217]);
            fl26 = new ScenarioEntity<IBloc>(218, scenarioTag.WellKnownItems[218]);
            fl27 = new ScenarioEntity<IBloc>(219, scenarioTag.WellKnownItems[219]);
            fl28 = new ScenarioEntity<IBloc>(220, scenarioTag.WellKnownItems[220]);
            fl29 = new ScenarioEntity<IBloc>(221, scenarioTag.WellKnownItems[221]);
            fl30 = new ScenarioEntity<IBloc>(222, scenarioTag.WellKnownItems[222]);
            fl31 = new ScenarioEntity<IBloc>(223, scenarioTag.WellKnownItems[223]);
            fl32 = new ScenarioEntity<IBloc>(224, scenarioTag.WellKnownItems[224]);
            nr25 = new ScenarioEntity<IBloc>(225, scenarioTag.WellKnownItems[225]);
            nr26 = new ScenarioEntity<IBloc>(226, scenarioTag.WellKnownItems[226]);
            nr27 = new ScenarioEntity<IBloc>(227, scenarioTag.WellKnownItems[227]);
            nr28 = new ScenarioEntity<IBloc>(228, scenarioTag.WellKnownItems[228]);
            nr29 = new ScenarioEntity<IBloc>(229, scenarioTag.WellKnownItems[229]);
            nr30 = new ScenarioEntity<IBloc>(230, scenarioTag.WellKnownItems[230]);
            nr31 = new ScenarioEntity<IBloc>(231, scenarioTag.WellKnownItems[231]);
            nr32 = new ScenarioEntity<IBloc>(232, scenarioTag.WellKnownItems[232]);
            banshee_gas_01 = new ScenarioEntity<IScenery>(233, scenarioTag.WellKnownItems[233]);
            banshee_gas_02 = new ScenarioEntity<IScenery>(234, scenarioTag.WellKnownItems[234]);
            banshee_gas_03 = new ScenarioEntity<IScenery>(235, scenarioTag.WellKnownItems[235]);
            banshee_gas_04 = new ScenarioEntity<IScenery>(236, scenarioTag.WellKnownItems[236]);
            banshee_gas_05 = new ScenarioEntity<IScenery>(237, scenarioTag.WellKnownItems[237]);
            anchor_seraph = new ScenarioEntity<IScenery>(238, scenarioTag.WellKnownItems[238]);
            holo_base_1 = new ScenarioEntity<IScenery>(239, scenarioTag.WellKnownItems[239]);
            holo_base_2 = new ScenarioEntity<IScenery>(240, scenarioTag.WellKnownItems[240]);
            drone_spawn = new ScenarioEntity<IScenery>(241, scenarioTag.WellKnownItems[241]);
            crap01 = new ScenarioEntity<IBloc>(242, scenarioTag.WellKnownItems[242]);
            crap02 = new ScenarioEntity<IBloc>(243, scenarioTag.WellKnownItems[243]);
            crap03 = new ScenarioEntity<IBloc>(244, scenarioTag.WellKnownItems[244]);
            crap04 = new ScenarioEntity<IBloc>(245, scenarioTag.WellKnownItems[245]);
            crap05 = new ScenarioEntity<IBloc>(246, scenarioTag.WellKnownItems[246]);
            crap06 = new ScenarioEntity<IBloc>(247, scenarioTag.WellKnownItems[247]);
            crap07 = new ScenarioEntity<IBloc>(248, scenarioTag.WellKnownItems[248]);
            crap08 = new ScenarioEntity<IBloc>(249, scenarioTag.WellKnownItems[249]);
            crap09 = new ScenarioEntity<IBloc>(250, scenarioTag.WellKnownItems[250]);
            crap10 = new ScenarioEntity<IBloc>(251, scenarioTag.WellKnownItems[251]);
            crap11 = new ScenarioEntity<IBloc>(252, scenarioTag.WellKnownItems[252]);
            crap12 = new ScenarioEntity<IBloc>(253, scenarioTag.WellKnownItems[253]);
            croom_center = new ScenarioEntity<IScenery>(254, scenarioTag.WellKnownItems[254]);
            cable_nub_a = new ScenarioEntity<IScenery>(255, scenarioTag.WellKnownItems[255]);
            cable_nub_b = new ScenarioEntity<IScenery>(256, scenarioTag.WellKnownItems[256]);
            cable_nub_c = new ScenarioEntity<IScenery>(257, scenarioTag.WellKnownItems[257]);
            holo_rifle_01 = new ScenarioEntity<IScenery>(258, scenarioTag.WellKnownItems[258]);
            holo_rifle_02 = new ScenarioEntity<IScenery>(259, scenarioTag.WellKnownItems[259]);
            holo_rifle_03 = new ScenarioEntity<IScenery>(260, scenarioTag.WellKnownItems[260]);
            holo_rifle_04 = new ScenarioEntity<IScenery>(261, scenarioTag.WellKnownItems[261]);
            corpse01 = new ScenarioEntity<IUnit>(262, scenarioTag.WellKnownItems[262]);
            corpse02 = new ScenarioEntity<IUnit>(263, scenarioTag.WellKnownItems[263]);
            corpse03 = new ScenarioEntity<IUnit>(264, scenarioTag.WellKnownItems[264]);
            corpse04 = new ScenarioEntity<IUnit>(265, scenarioTag.WellKnownItems[265]);
            corpse05 = new ScenarioEntity<IUnit>(266, scenarioTag.WellKnownItems[266]);
            corpse06 = new ScenarioEntity<IUnit>(267, scenarioTag.WellKnownItems[267]);
            corpse07 = new ScenarioEntity<IUnit>(268, scenarioTag.WellKnownItems[268]);
            corpse08 = new ScenarioEntity<IUnit>(269, scenarioTag.WellKnownItems[269]);
            dervish02 = new ScenarioEntity<IUnit>(270, scenarioTag.WellKnownItems[270]);
            heretic_leader1 = new ScenarioEntity<IUnit>(271, scenarioTag.WellKnownItems[271]);
            monitor = new ScenarioEntity<IUnit>(272, scenarioTag.WellKnownItems[272]);
            hologram01 = new ScenarioEntity<IUnit>(273, scenarioTag.WellKnownItems[273]);
            hologram02 = new ScenarioEntity<IUnit>(274, scenarioTag.WellKnownItems[274]);
            tartarus = new ScenarioEntity<IUnit>(275, scenarioTag.WellKnownItems[275]);
            dervish_intra0 = new ScenarioEntity<IUnit>(276, scenarioTag.WellKnownItems[276]);
            commander_intra0 = new ScenarioEntity<IUnit>(277, scenarioTag.WellKnownItems[277]);
            elite_intra0_01 = new ScenarioEntity<IUnit>(278, scenarioTag.WellKnownItems[278]);
            elite_intra0_02 = new ScenarioEntity<IUnit>(279, scenarioTag.WellKnownItems[279]);
            grunt_intra0_01 = new ScenarioEntity<IUnit>(280, scenarioTag.WellKnownItems[280]);
            grunt_intra0_02 = new ScenarioEntity<IUnit>(281, scenarioTag.WellKnownItems[281]);
            dervish_03 = new ScenarioEntity<IUnit>(282, scenarioTag.WellKnownItems[282]);
            commander = new ScenarioEntity<IUnit>(283, scenarioTag.WellKnownItems[283]);
            elite01 = new ScenarioEntity<IUnit>(284, scenarioTag.WellKnownItems[284]);
            elite02 = new ScenarioEntity<IUnit>(285, scenarioTag.WellKnownItems[285]);
            dervish02b = new ScenarioEntity<IUnit>(286, scenarioTag.WellKnownItems[286]);
            phantom01 = new ScenarioEntity<IVehicle>(287, scenarioTag.WellKnownItems[287]);
            phantom02 = new ScenarioEntity<IVehicle>(288, scenarioTag.WellKnownItems[288]);
            phantom03 = new ScenarioEntity<IVehicle>(289, scenarioTag.WellKnownItems[289]);
            player_fake_banshee = new ScenarioEntity<IVehicle>(290, scenarioTag.WellKnownItems[290]);
            player0_fake_banshee = new ScenarioEntity<IVehicle>(291, scenarioTag.WellKnownItems[291]);
            hl_fake_banshee = new ScenarioEntity<IVehicle>(292, scenarioTag.WellKnownItems[292]);
            player1_fake_banshee = new ScenarioEntity<IVehicle>(293, scenarioTag.WellKnownItems[293]);
            hl_end_banshee = new ScenarioEntity<IVehicle>(294, scenarioTag.WellKnownItems[294]);
            phantom_outro2 = new ScenarioEntity<IVehicle>(295, scenarioTag.WellKnownItems[295]);
            hl_rifle_01 = new ScenarioEntity<IWeapon>(296, scenarioTag.WellKnownItems[296]);
            hl_rifle_02 = new ScenarioEntity<IWeapon>(297, scenarioTag.WellKnownItems[297]);
            famine = new ScenarioEntity<IWeapon>(298, scenarioTag.WellKnownItems[298]);
            toy01 = new ScenarioEntity<IWeapon>(299, scenarioTag.WellKnownItems[299]);
            toy02 = new ScenarioEntity<IWeapon>(300, scenarioTag.WellKnownItems[300]);
            toy03 = new ScenarioEntity<IWeapon>(301, scenarioTag.WellKnownItems[301]);
            toy04 = new ScenarioEntity<IWeapon>(302, scenarioTag.WellKnownItems[302]);
            toy05 = new ScenarioEntity<IWeapon>(303, scenarioTag.WellKnownItems[303]);
            toy06 = new ScenarioEntity<IWeapon>(304, scenarioTag.WellKnownItems[304]);
            toy07 = new ScenarioEntity<IWeapon>(305, scenarioTag.WellKnownItems[305]);
            toy08 = new ScenarioEntity<IWeapon>(306, scenarioTag.WellKnownItems[306]);
            toy09 = new ScenarioEntity<IWeapon>(307, scenarioTag.WellKnownItems[307]);
            toy10 = new ScenarioEntity<IWeapon>(308, scenarioTag.WellKnownItems[308]);
            toy11 = new ScenarioEntity<IWeapon>(309, scenarioTag.WellKnownItems[309]);
            toy12 = new ScenarioEntity<IWeapon>(310, scenarioTag.WellKnownItems[310]);
            toy13 = new ScenarioEntity<IWeapon>(311, scenarioTag.WellKnownItems[311]);
            toy14 = new ScenarioEntity<IWeapon>(312, scenarioTag.WellKnownItems[312]);
            toy15 = new ScenarioEntity<IWeapon>(313, scenarioTag.WellKnownItems[313]);
            toy16 = new ScenarioEntity<IWeapon>(314, scenarioTag.WellKnownItems[314]);
            toy17 = new ScenarioEntity<IWeapon>(315, scenarioTag.WellKnownItems[315]);
            toy18 = new ScenarioEntity<IWeapon>(316, scenarioTag.WellKnownItems[316]);
            closetocore = new ScenarioEntity<ISound>(317, scenarioTag.WellKnownItems[317]);
            core = new ScenarioEntity<ISound>(318, scenarioTag.WellKnownItems[318]);
            core2 = new ScenarioEntity<ISound>(319, scenarioTag.WellKnownItems[319]);
            closetocore2 = new ScenarioEntity<ISound>(320, scenarioTag.WellKnownItems[320]);
            viewroom_entry_bsp0 = new ScenarioEntity<IDevice>(353, scenarioTag.WellKnownItems[353]);
            banshee_ledge_access_01 = new ScenarioEntity<IDevice>(354, scenarioTag.WellKnownItems[354]);
            bottling_spawnroom_bsp0 = new ScenarioEntity<IDevice>(355, scenarioTag.WellKnownItems[355]);
            lab_exit_ext = new ScenarioEntity<IDevice>(356, scenarioTag.WellKnownItems[356]);
            control_down_switch_01 = new ScenarioEntity<IDevice>(357, scenarioTag.WellKnownItems[357]);
            control_down_switch_02 = new ScenarioEntity<IDevice>(358, scenarioTag.WellKnownItems[358]);
            control_shield_door = new ScenarioEntity<IDevice>(359, scenarioTag.WellKnownItems[359]);
            control_up_switch_01 = new ScenarioEntity<IDevice>(360, scenarioTag.WellKnownItems[360]);
            control_up_switch_02 = new ScenarioEntity<IDevice>(361, scenarioTag.WellKnownItems[361]);
            tray01 = new ScenarioEntity<IDevice>(362, scenarioTag.WellKnownItems[362]);
            tray02 = new ScenarioEntity<IDevice>(363, scenarioTag.WellKnownItems[363]);
            tray03 = new ScenarioEntity<IDevice>(364, scenarioTag.WellKnownItems[364]);
            tray04 = new ScenarioEntity<IDevice>(365, scenarioTag.WellKnownItems[365]);
            tray05 = new ScenarioEntity<IDevice>(366, scenarioTag.WellKnownItems[366]);
            lab_exit_int = new ScenarioEntity<IDevice>(367, scenarioTag.WellKnownItems[367]);
            disposal_entry_int = new ScenarioEntity<IDevice>(368, scenarioTag.WellKnownItems[368]);
            arm02_entry_int = new ScenarioEntity<IDevice>(369, scenarioTag.WellKnownItems[369]);
            disposal_exit = new ScenarioEntity<IDevice>(370, scenarioTag.WellKnownItems[370]);
            elev_hangar = new ScenarioEntity<IDevice>(371, scenarioTag.WellKnownItems[371]);
            elev_control_up = new ScenarioEntity<IDevice>(372, scenarioTag.WellKnownItems[372]);
            elev_control_down = new ScenarioEntity<IDevice>(373, scenarioTag.WellKnownItems[373]);
            seraph = new ScenarioEntity<IDevice>(374, scenarioTag.WellKnownItems[374]);
            banshee_ledge_access_02 = new ScenarioEntity<IDevice>(375, scenarioTag.WellKnownItems[375]);
            arm_02_entry_ext = new ScenarioEntity<IDevice>(376, scenarioTag.WellKnownItems[376]);
            suction = new ScenarioEntity<IDevice>(377, scenarioTag.WellKnownItems[377]);
            real_cable_c = new ScenarioEntity<IDevice>(378, scenarioTag.WellKnownItems[378]);
            real_cable_b = new ScenarioEntity<IDevice>(379, scenarioTag.WellKnownItems[379]);
            real_cable_a = new ScenarioEntity<IDevice>(380, scenarioTag.WellKnownItems[380]);
            control_room_ext = new ScenarioEntity<IDevice>(381, scenarioTag.WellKnownItems[381]);
            hl_ledge_ext = new ScenarioEntity<IDevice>(382, scenarioTag.WellKnownItems[382]);
            viewroom_exit02_bsp0 = new ScenarioEntity<IDevice>(383, scenarioTag.WellKnownItems[383]);
            viewroom_exit01_bsp0 = new ScenarioEntity<IDevice>(384, scenarioTag.WellKnownItems[384]);
            elev_silo = new ScenarioEntity<IDevice>(385, scenarioTag.WellKnownItems[385]);
            tray06 = new ScenarioEntity<IDevice>(386, scenarioTag.WellKnownItems[386]);
            control_middle_spawnroom = new ScenarioEntity<IDevice>(387, scenarioTag.WellKnownItems[387]);
            control_entry_int = new ScenarioEntity<IDevice>(388, scenarioTag.WellKnownItems[388]);
            control_bottom_spawnroom = new ScenarioEntity<IDevice>(389, scenarioTag.WellKnownItems[389]);
            control_peri_spawnroom = new ScenarioEntity<IDevice>(390, scenarioTag.WellKnownItems[390]);
            rec_center_entry_ext = new ScenarioEntity<IDevice>(391, scenarioTag.WellKnownItems[391]);
            cableroom = new ScenarioEntity<IDevice>(392, scenarioTag.WellKnownItems[392]);
            cableroom2 = new ScenarioEntity<IDevice>(393, scenarioTag.WellKnownItems[393]);
            cableroom_top = new ScenarioEntity<IDevice>(394, scenarioTag.WellKnownItems[394]);
            shield = new ScenarioEntity<IDevice>(395, scenarioTag.WellKnownItems[395]);
            phantom_vol = new ScenarioEntity<IDevice>(396, scenarioTag.WellKnownItems[396]);
            hangar_door_cinematic = new ScenarioEntity<IDevice>(397, scenarioTag.WellKnownItems[397]);
            underhangar_spawn_02 = new ScenarioEntity<IDevice>(398, scenarioTag.WellKnownItems[398]);
            underhangar_spawn_01 = new ScenarioEntity<IDevice>(399, scenarioTag.WellKnownItems[399]);
            hall2_spawn_03 = new ScenarioEntity<IDevice>(400, scenarioTag.WellKnownItems[400]);
            hall2_spawn_02 = new ScenarioEntity<IDevice>(401, scenarioTag.WellKnownItems[401]);
            hall2_spawn_01 = new ScenarioEntity<IDevice>(402, scenarioTag.WellKnownItems[402]);
            hangar_exit = new ScenarioEntity<IDevice>(403, scenarioTag.WellKnownItems[403]);
            tennis_ball = new ScenarioEntity<IDevice>(404, scenarioTag.WellKnownItems[404]);
            disposal_commander = new Squad_disposal_commander(scenarioTag);
            allies_elites_03a = new Squad_allies_elites_03a(scenarioTag);
            allies_elites_03b = new Squad_allies_elites_03b(scenarioTag);
            allies_grunts_03 = new Squad_allies_grunts_03(scenarioTag);
            disposal_entry_flood = new Squad_disposal_entry_flood(scenarioTag);
            disposal_entry_juggernaut = new Squad_disposal_entry_juggernaut(scenarioTag);
            disposal_entry_heretics = new Squad_disposal_entry_heretics(scenarioTag);
            holo_drone = new Squad_holo_drone(scenarioTag);
            hl_hologram = new Squad_hl_hologram(scenarioTag);
            disposal_infection_01 = new Squad_disposal_infection_01(scenarioTag);
            disposal_infection_02 = new Squad_disposal_infection_02(scenarioTag);
            silo_sentinels_initial = new Squad_silo_sentinels_initial(scenarioTag);
            silo_sentinels_resupply = new Squad_silo_sentinels_resupply(scenarioTag);
            silo_flood_initial = new Squad_silo_flood_initial(scenarioTag);
            silo_climbers_01 = new Squad_silo_climbers_01(scenarioTag);
            silo_climbers_02 = new Squad_silo_climbers_02(scenarioTag);
            silo_sentinels_below = new Squad_silo_sentinels_below(scenarioTag);
            silo_infection_01 = new Squad_silo_infection_01(scenarioTag);
            silo_infection_02 = new Squad_silo_infection_02(scenarioTag);
            silo_infection_03 = new Squad_silo_infection_03(scenarioTag);
            silo_infection_04 = new Squad_silo_infection_04(scenarioTag);
            silo_heretics = new Squad_silo_heretics(scenarioTag);
            silo_sentinels_end = new Squad_silo_sentinels_end(scenarioTag);
            silo_flood_halls = new Squad_silo_flood_halls(scenarioTag);
            lab_heretics_01 = new Squad_lab_heretics_01(scenarioTag);
            lab_turret_grunts_01 = new Squad_lab_turret_grunts_01(scenarioTag);
            lab_heretics_02 = new Squad_lab_heretics_02(scenarioTag);
            lab_grunts_02 = new Squad_lab_grunts_02(scenarioTag);
            lab_exit_turrets = new Squad_lab_exit_turrets(scenarioTag);
            lab_combatforms_01 = new Squad_lab_combatforms_01(scenarioTag);
            lab_combatforms_02 = new Squad_lab_combatforms_02(scenarioTag);
            lab_carriers_01 = new Squad_lab_carriers_01(scenarioTag);
            lab_carriers_02 = new Squad_lab_carriers_02(scenarioTag);
            lab_infection_01 = new Squad_lab_infection_01(scenarioTag);
            lab_infection_02 = new Squad_lab_infection_02(scenarioTag);
            lab_heretics_above = new Squad_lab_heretics_above(scenarioTag);
            lab_juggernaut_above = new Squad_lab_juggernaut_above(scenarioTag);
            bridge_strafer = new Squad_bridge_strafer(scenarioTag);
            allied_phantom_02 = new Squad_allied_phantom_02(scenarioTag);
            allies_grunts_04 = new Squad_allies_grunts_04(scenarioTag);
            allies_elites_04 = new Squad_allies_elites_04(scenarioTag);
            bridge_runners = new Squad_bridge_runners(scenarioTag);
            bridge_h_grunts_init = new Squad_bridge_h_grunts_init(scenarioTag);
            bridge_heretics_R_02 = new Squad_bridge_heretics_R_02(scenarioTag);
            bridge_h_grunts_R_03 = new Squad_bridge_h_grunts_R_03(scenarioTag);
            bridge_heretics_R_04 = new Squad_bridge_heretics_R_04(scenarioTag);
            bridge_sentinels_R_05 = new Squad_bridge_sentinels_R_05(scenarioTag);
            bridge_heretics_L_02 = new Squad_bridge_heretics_L_02(scenarioTag);
            bridge_h_grunts_L_03 = new Squad_bridge_h_grunts_L_03(scenarioTag);
            bridge_heretics_L_04 = new Squad_bridge_heretics_L_04(scenarioTag);
            bridge_sentinels_L_05 = new Squad_bridge_sentinels_L_05(scenarioTag);
            bridge_heretics_final = new Squad_bridge_heretics_final(scenarioTag);
            bridge_h_grunts_final = new Squad_bridge_h_grunts_final(scenarioTag);
            bridge_combatforms = new Squad_bridge_combatforms(scenarioTag);
            bridge_carriers = new Squad_bridge_carriers(scenarioTag);
            bridge_infection = new Squad_bridge_infection(scenarioTag);
            heretic_leader_control = new Squad_heretic_leader_control(scenarioTag);
            control_commander_cinematic = new Squad_control_commander_cinematic(scenarioTag);
            control_elites_cinematic = new Squad_control_elites_cinematic(scenarioTag);
            control_flood_wave_01_combat = new Squad_control_flood_wave_01_combat(scenarioTag);
            control_flood_wave_02_combat = new Squad_control_flood_wave_02_combat(scenarioTag);
            control_flood_wave_02_carriers = new Squad_control_flood_wave_02_carriers(scenarioTag);
            control_flood_wave_03_combat = new Squad_control_flood_wave_03_combat(scenarioTag);
            control_flood_wave_03_carriers = new Squad_control_flood_wave_03_carriers(scenarioTag);
            control_infection = new Squad_control_infection(scenarioTag);
            control_sentinels_wave_01 = new Squad_control_sentinels_wave_01(scenarioTag);
            control_sentinels_wave_03 = new Squad_control_sentinels_wave_03(scenarioTag);
            allied_phantom_03 = new Squad_allied_phantom_03(scenarioTag);
            cableroom_flood_init = new Squad_cableroom_flood_init(scenarioTag);
            cableroom_sentinels_init = new Squad_cableroom_sentinels_init(scenarioTag);
            cable_room_combatforms = new Squad_cable_room_combatforms(scenarioTag);
            cable_room_sentinels = new Squad_cable_room_sentinels(scenarioTag);
            control_return_heretics_01 = new Squad_control_return_heretics_01(scenarioTag);
            control_return_heretics_02 = new Squad_control_return_heretics_02(scenarioTag);
            control_return_h_grunts_02 = new Squad_control_return_h_grunts_02(scenarioTag);
            control_return_heretics_03 = new Squad_control_return_heretics_03(scenarioTag);
            control_return_h_grunts_03 = new Squad_control_return_h_grunts_03(scenarioTag);
            control_return_sentinels_01 = new Squad_control_return_sentinels_01(scenarioTag);
            control_return_flood_01 = new Squad_control_return_flood_01(scenarioTag);
            control_return_flood_02 = new Squad_control_return_flood_02(scenarioTag);
            control_return_flood_03 = new Squad_control_return_flood_03(scenarioTag);
            control_return_flood_04 = new Squad_control_return_flood_04(scenarioTag);
            control_return_carriers_01 = new Squad_control_return_carriers_01(scenarioTag);
            control_return_carriers_02 = new Squad_control_return_carriers_02(scenarioTag);
            control_return_carriers_03 = new Squad_control_return_carriers_03(scenarioTag);
            control_return_carriers_04 = new Squad_control_return_carriers_04(scenarioTag);
            power_core_heretics_01 = new Squad_power_core_heretics_01(scenarioTag);
            power_core_h_grunts_01 = new Squad_power_core_h_grunts_01(scenarioTag);
            power_core_sentinels_01 = new Squad_power_core_sentinels_01(scenarioTag);
            power_core_combatforms = new Squad_power_core_combatforms(scenarioTag);
            power_core_carriers = new Squad_power_core_carriers(scenarioTag);
            ledge_banshees_02 = new Squad_ledge_banshees_02(scenarioTag);
            heretic_leader_04 = new Squad_heretic_leader_04(scenarioTag);
            dervish_01 = new Squad_dervish_01(scenarioTag);
            dervish_02 = new Squad_dervish_02(scenarioTag);
            dervish_031 = new Squad_dervish_031(scenarioTag);
            dogfighters_init = new Squad_dogfighters_init(scenarioTag);
            dogfighters_finale = new Squad_dogfighters_finale(scenarioTag);
            bottling_return_sentinels_01 = new Squad_bottling_return_sentinels_01(scenarioTag);
            bottling_return_sentinels_02 = new Squad_bottling_return_sentinels_02(scenarioTag);
            bottling_return_sentinels_03 = new Squad_bottling_return_sentinels_03(scenarioTag);
            bottling_return_flood_01 = new Squad_bottling_return_flood_01(scenarioTag);
            bottling_return_combatforms_02 = new Squad_bottling_return_combatforms_02(scenarioTag);
            bottling_return_carriers_02 = new Squad_bottling_return_carriers_02(scenarioTag);
            bottling_return_combatforms_03 = new Squad_bottling_return_combatforms_03(scenarioTag);
            bottling_return_carriers_03 = new Squad_bottling_return_carriers_03(scenarioTag);
            bottling_return_combatforms_04 = new Squad_bottling_return_combatforms_04(scenarioTag);
            bottling_return_carriers_04 = new Squad_bottling_return_carriers_04(scenarioTag);
            second_hall_infection_01 = new Squad_second_hall_infection_01(scenarioTag);
            second_hall_flood_01 = new Squad_second_hall_flood_01(scenarioTag);
            second_hall_carriers = new Squad_second_hall_carriers(scenarioTag);
            second_hall_flood_02 = new Squad_second_hall_flood_02(scenarioTag);
            second_hall_infection_02 = new Squad_second_hall_infection_02(scenarioTag);
            second_hall_flood_03 = new Squad_second_hall_flood_03(scenarioTag);
            underhangar_heretics_01 = new Squad_underhangar_heretics_01(scenarioTag);
            underhangar_h_grunts_01 = new Squad_underhangar_h_grunts_01(scenarioTag);
            underhangar_heretics_02 = new Squad_underhangar_heretics_02(scenarioTag);
            underhangar_h_grunts_02 = new Squad_underhangar_h_grunts_02(scenarioTag);
            underhangar_heretics_03 = new Squad_underhangar_heretics_03(scenarioTag);
            underhangar_h_grunts_03 = new Squad_underhangar_h_grunts_03(scenarioTag);
            underhangar_combatforms_init = new Squad_underhangar_combatforms_init(scenarioTag);
            underhangar_carriers_init = new Squad_underhangar_carriers_init(scenarioTag);
            underhangar_carriers_02 = new Squad_underhangar_carriers_02(scenarioTag);
            underhangar_return_flood_01 = new Squad_underhangar_return_flood_01(scenarioTag);
            underhangar_return_flood_02 = new Squad_underhangar_return_flood_02(scenarioTag);
            underhangar_return_flood_03 = new Squad_underhangar_return_flood_03(scenarioTag);
            underhangar_return_flood_04 = new Squad_underhangar_return_flood_04(scenarioTag);
            first_hall_flood_01 = new Squad_first_hall_flood_01(scenarioTag);
            heretic_leader_hangar = new Squad_heretic_leader_hangar(scenarioTag);
            boss_fight_combatforms = new Squad_boss_fight_combatforms(scenarioTag);
            boss_fight_carriers = new Squad_boss_fight_carriers(scenarioTag);
            boss_fight_sentinels = new Squad_boss_fight_sentinels(scenarioTag);
            boss_fight_heretic_leader = new Squad_boss_fight_heretic_leader(scenarioTag);
            boss_fight_hl_hologram_01 = new Squad_boss_fight_hl_hologram_01(scenarioTag);
            boss_fight_hl_hologram_02 = new Squad_boss_fight_hl_hologram_02(scenarioTag);
            hl_boss_random = new Squad_hl_boss_random(scenarioTag);
            hl_boss_holo_random_01 = new Squad_hl_boss_holo_random_01(scenarioTag);
            hl_boss_holo_random_02 = new Squad_hl_boss_holo_random_02(scenarioTag);
            hl_boss_holo_random_03 = new Squad_hl_boss_holo_random_03(scenarioTag);
            hl_boss_last = new Squad_hl_boss_last(scenarioTag);
            monitor1 = new Squad_monitor1(scenarioTag);
            hl_boss_holo_random_04 = new Squad_hl_boss_holo_random_04(scenarioTag);
            bait_hall_01 = new Squad_bait_hall_01(scenarioTag);
            bait_hall_02 = new Squad_bait_hall_02(scenarioTag);
            bait_hall_03 = new Squad_bait_hall_03(scenarioTag);
            bait_bottling_02 = new Squad_bait_bottling_02(scenarioTag);
            bait_bottling_01 = new Squad_bait_bottling_01(scenarioTag);
            famine_cf = new Squad_famine_cf(scenarioTag);
            power_core_swords = new Squad_power_core_swords(scenarioTag);
        }
    }
}