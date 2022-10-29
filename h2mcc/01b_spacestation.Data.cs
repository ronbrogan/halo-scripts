namespace OpenH2.Scripts.Generatedscenarios.solo
{
    using System;
    using System.Threading.Tasks;
    using OpenH2.Core.Architecture;
    using OpenH2.Core.Tags;
    using OpenH2.Core.Tags.Scenario;
    using OpenH2.Core.Scripting;
    using OpenH2.Core.GameObjects;

    public partial class scnr_01b_spacestation : ScenarioScriptBase
    {
        public ScenarioEntity<IScenery> pickle { get; set; }
        public ScenarioEntity<IScenery> iac { get; set; }
        public ScenarioEntity<IScenery> carrier_01 { get; set; }
        public ScenarioEntity<IScenery> carrier_02 { get; set; }
        public ScenarioEntity<IScenery> fighter_01 { get; set; }
        public ScenarioEntity<IScenery> fighter_02 { get; set; }
        public ScenarioEntity<IScenery> covenant_battery { get; set; }
        public ScenarioEntity<IScenery> pickle2 { get; set; }
        public ScenarioEntity<IScenery> carrier_1 { get; set; }
        public ScenarioEntity<IScenery> inamberclad { get; set; }
        public ScenarioEntity<IScenery> malta { get; set; }
        public ScenarioEntity<IScenery> athens { get; set; }
        public ScenarioEntity<IScenery> iac_bridge_outro_02 { get; set; }
        public ScenarioEntity<IScenery> hammer { get; set; }
        public ScenarioEntity<IScenery> fighter_x02_01 { get; set; }
        public ScenarioEntity<IScenery> fighter_x02_02 { get; set; }
        public ScenarioEntity<IScenery> fighter_x02_03 { get; set; }
        public ScenarioEntity<IScenery> fighter_x02_04 { get; set; }
        public ScenarioEntity<IScenery> poa_x02 { get; set; }
        public ScenarioEntity<IScenery> branding_iron_01 { get; set; }
        public ScenarioEntity<IScenery> branding_iron_02 { get; set; }
        public ScenarioEntity<IScenery> matte_africa { get; set; }
        public ScenarioEntity<IScenery> anchor_x02_02 { get; set; }
        public ScenarioEntity<IScenery> anchor_outro2 { get; set; }
        public ScenarioEntity<IScenery> anchor_outro1 { get; set; }
        public ScenarioEntity<IScenery> matte_africa_coast { get; set; }
        public ScenarioEntity<IBloc> outro_crate_1 { get; set; }
        public ScenarioEntity<IBloc> outro_crate_2 { get; set; }
        public ScenarioEntity<IBloc> outro_crate_3 { get; set; }
        public ScenarioEntity<IScenery> poa { get; set; }
        public ScenarioEntity<IScenery> cairo_bridge { get; set; }
        public ScenarioEntity<IScenery> iac_bridge_outro_01 { get; set; }
        public ScenarioEntity<IScenery> matte_carrier_core { get; set; }
        public ScenarioEntity<IScenery> matte_carrier_side { get; set; }
        public ScenarioEntity<IScenery> matte_carrier_hull { get; set; }
        public ScenarioEntity<IScenery> outro_cortana_stand { get; set; }
        public ScenarioEntity<IScenery> sparks_backward_01 { get; set; }
        public ScenarioEntity<IScenery> sparks_backward_02 { get; set; }
        public ScenarioEntity<IScenery> sparks_backward_03 { get; set; }
        public ScenarioEntity<IScenery> sparks_backward_04 { get; set; }
        public ScenarioEntity<IScenery> sparks_backward_05 { get; set; }
        public ScenarioEntity<IScenery> sparks_forward_01 { get; set; }
        public ScenarioEntity<IScenery> sparks_forward_02 { get; set; }
        public ScenarioEntity<IScenery> sparks_forward_03 { get; set; }
        public ScenarioEntity<IScenery> sparks_forward_04 { get; set; }
        public ScenarioEntity<IScenery> sparks_forward_05 { get; set; }
        public ScenarioEntity<IScenery> sparks_forward_06 { get; set; }
        public ScenarioEntity<IScenery> sparks_forward_07 { get; set; }
        public ScenarioEntity<IScenery> sparks_forward_08 { get; set; }
        public ScenarioEntity<IScenery> bay2_boarding_door { get; set; }
        public ScenarioEntity<IScenery> bay1_boarding_door { get; set; }
        public ScenarioEntity<IScenery> fighter_x02_06 { get; set; }
        public ScenarioEntity<IScenery> fighter_x02_05 { get; set; }
        public ScenarioEntity<IScenery> fighter_x02_08 { get; set; }
        public ScenarioEntity<IScenery> fighter_x02_07 { get; set; }
        public ScenarioEntity<IScenery> x02_unsc_logo { get; set; }
        public ScenarioEntity<IScenery> x02_tactical_display { get; set; }
        public ScenarioEntity<IScenery> x02_drone_01 { get; set; }
        public ScenarioEntity<IScenery> x02_drone_02 { get; set; }
        public ScenarioEntity<IScenery> johnson_hat { get; set; }
        public ScenarioEntity<IScenery> cov_crowd_02_01 { get; set; }
        public ScenarioEntity<IScenery> cov_crowd_02_02 { get; set; }
        public ScenarioEntity<IScenery> cov_crowd_02_03 { get; set; }
        public ScenarioEntity<IScenery> cov_crowd_02_04 { get; set; }
        public ScenarioEntity<IScenery> cov_crowd_02_05 { get; set; }
        public ScenarioEntity<IScenery> cov_crowd_02_06 { get; set; }
        public ScenarioEntity<IScenery> cov_crowd_02_07 { get; set; }
        public ScenarioEntity<IScenery> cov_crowd_02_08 { get; set; }
        public ScenarioEntity<IScenery> cov_crowd_02_09 { get; set; }
        public ScenarioEntity<IScenery> cov_crowd_02_10 { get; set; }
        public ScenarioEntity<IScenery> cov_crowd_02_11 { get; set; }
        public ScenarioEntity<IScenery> cov_crowd_02_12 { get; set; }
        public ScenarioEntity<IScenery> cov_crowd_02_13 { get; set; }
        public ScenarioEntity<IScenery> cov_crowd_02_14 { get; set; }
        public ScenarioEntity<IScenery> cov_crowd_02_15 { get; set; }
        public ScenarioEntity<IScenery> cov_crowd_02_16 { get; set; }
        public ScenarioEntity<IScenery> cov_crowd_02_17 { get; set; }
        public ScenarioEntity<IScenery> cov_crowd_02_18 { get; set; }
        public ScenarioEntity<IScenery> cov_crowd_02_19 { get; set; }
        public ScenarioEntity<IScenery> cov_crowd_01a_01 { get; set; }
        public ScenarioEntity<IScenery> cov_crowd_01a_02 { get; set; }
        public ScenarioEntity<IScenery> cov_crowd_01a_03 { get; set; }
        public ScenarioEntity<IScenery> cov_crowd_01a_04 { get; set; }
        public ScenarioEntity<IScenery> cov_crowd_01a_05 { get; set; }
        public ScenarioEntity<IScenery> cov_crowd_01a_06 { get; set; }
        public ScenarioEntity<IScenery> x02_column_01 { get; set; }
        public ScenarioEntity<IScenery> x02_column_02 { get; set; }
        public ScenarioEntity<IScenery> x02_column_03 { get; set; }
        public ScenarioEntity<IScenery> x02_column_04 { get; set; }
        public ScenarioEntity<IScenery> x02_column_05 { get; set; }
        public ScenarioEntity<IScenery> x02_column_06 { get; set; }
        public ScenarioEntity<IScenery> cov_crowd_01a_07 { get; set; }
        public ScenarioEntity<IScenery> cov_crowd_01a_08 { get; set; }
        public ScenarioEntity<IScenery> cov_crowd_01a_09 { get; set; }
        public ScenarioEntity<IScenery> cov_crowd_01a_10 { get; set; }
        public ScenarioEntity<IScenery> x02_marine_prop_01a_01 { get; set; }
        public ScenarioEntity<IScenery> x02_marine_prop_01b_02 { get; set; }
        public ScenarioEntity<IScenery> x02_marine_prop_01a_03 { get; set; }
        public ScenarioEntity<IScenery> x02_marine_prop_01b_04 { get; set; }
        public ScenarioEntity<IScenery> x02_marine_prop_01a_05 { get; set; }
        public ScenarioEntity<IScenery> x02_marine_prop_01a_06 { get; set; }
        public ScenarioEntity<IScenery> x02_marine_prop_01a_07 { get; set; }
        public ScenarioEntity<IScenery> x02_marine_prop_01b_08 { get; set; }
        public ScenarioEntity<IScenery> x02_marine_prop_01a_09 { get; set; }
        public ScenarioEntity<IScenery> x02_marine_prop_01b_10 { get; set; }
        public ScenarioEntity<IScenery> x02_marine_prop_01a_11 { get; set; }
        public ScenarioEntity<IScenery> x02_marine_prop_01b_12 { get; set; }
        public ScenarioEntity<IScenery> x02_marine_prop_01a_13 { get; set; }
        public ScenarioEntity<IScenery> x02_marine_prop_01b_14 { get; set; }
        public ScenarioEntity<IScenery> x02_marine_prop_01a_15 { get; set; }
        public ScenarioEntity<IScenery> x02_marine_prop_01b_16 { get; set; }
        public ScenarioEntity<IScenery> x02_marine_prop_02a_01 { get; set; }
        public ScenarioEntity<IScenery> x02_marine_prop_02b_02 { get; set; }
        public ScenarioEntity<IScenery> x02_marine_prop_02c_03 { get; set; }
        public ScenarioEntity<IScenery> x02_marine_prop_02a_05 { get; set; }
        public ScenarioEntity<IScenery> x02_marine_prop_02b_06 { get; set; }
        public ScenarioEntity<IScenery> x02_marine_prop_02c_07 { get; set; }
        public ScenarioEntity<IScenery> x02_marine_prop_02a_08 { get; set; }
        public ScenarioEntity<IScenery> x02_marine_prop_02b_09 { get; set; }
        public ScenarioEntity<IScenery> x02_marine_prop_02c_10 { get; set; }
        public ScenarioEntity<IScenery> x02_marine_prop_02a_11 { get; set; }
        public ScenarioEntity<IScenery> x02_marine_prop_02b_12 { get; set; }
        public ScenarioEntity<IScenery> x02_marine_prop_02c_13 { get; set; }
        public ScenarioEntity<IScenery> x02_marine_prop_02a_14 { get; set; }
        public ScenarioEntity<IScenery> x02_marine_prop_02b_16 { get; set; }
        public ScenarioEntity<IScenery> x02_marine_prop_02c_17 { get; set; }
        public ScenarioEntity<IScenery> x02_marine_prop_02a_18 { get; set; }
        public ScenarioEntity<IScenery> x02_marine_prop_02b_19 { get; set; }
        public ScenarioEntity<IScenery> x02_marine_prop_02c_20 { get; set; }
        public ScenarioEntity<IScenery> x02_marine_prop_02a_21 { get; set; }
        public ScenarioEntity<IScenery> x02_marine_prop_02b_22 { get; set; }
        public ScenarioEntity<IScenery> x02_marine_prop_02c_23 { get; set; }
        public ScenarioEntity<IScenery> x02_marine_prop_02a_24 { get; set; }
        public ScenarioEntity<IScenery> x02_marine_prop_02b_25 { get; set; }
        public ScenarioEntity<IScenery> x02_marine_prop_02c_26 { get; set; }
        public ScenarioEntity<IScenery> x02_marine_prop_02a_27 { get; set; }
        public ScenarioEntity<IScenery> x02_marine_prop_02b_28 { get; set; }
        public ScenarioEntity<IScenery> x02_marine_prop_02c_29 { get; set; }
        public ScenarioEntity<IScenery> x02_marine_prop_02a_30 { get; set; }
        public ScenarioEntity<IScenery> x02_marine_prop_02b_31 { get; set; }
        public ScenarioEntity<IScenery> x02_marine_prop_02c_32 { get; set; }
        public ScenarioEntity<IScenery> x02_cortana_stand { get; set; }
        public ScenarioEntity<IScenery> x02_medal_tray { get; set; }
        public ScenarioEntity<IScenery> x02_manacle_01 { get; set; }
        public ScenarioEntity<IScenery> x02_manacle_02 { get; set; }
        public ScenarioEntity<IScenery> x02_elite_helmet { get; set; }
        public ScenarioEntity<IScenery> dck_iac { get; set; }
        public ScenarioEntity<IScenery> cov_crowd_01a_11 { get; set; }
        public ScenarioEntity<IScenery> cov_crowd_01a_12 { get; set; }
        public ScenarioEntity<IScenery> cov_crowd_01a_13 { get; set; }
        public ScenarioEntity<IScenery> cov_crowd_01a_14 { get; set; }
        public ScenarioEntity<IScenery> cov_crowd_01a_15 { get; set; }
        public ScenarioEntity<IScenery> cov_crowd_01a_16 { get; set; }
        public ScenarioEntity<IScenery> cov_crowd_01a_17 { get; set; }
        public ScenarioEntity<IScenery> cov_crowd_01a_18 { get; set; }
        public ScenarioEntity<IScenery> cov_crowd_01a_20 { get; set; }
        public ScenarioEntity<IScenery> cov_crowd_01a_21 { get; set; }
        public ScenarioEntity<IScenery> cov_crowd_01a_22 { get; set; }
        public ScenarioEntity<IScenery> cov_crowd_01a_23 { get; set; }
        public ScenarioEntity<IScenery> cov_crowd_01a_24 { get; set; }
        public ScenarioEntity<IScenery> cov_crowd_01a_25 { get; set; }
        public ScenarioEntity<IScenery> cov_crowd_01a_26 { get; set; }
        public ScenarioEntity<IScenery> cov_crowd_01b_01 { get; set; }
        public ScenarioEntity<IScenery> cov_crowd_01b_16 { get; set; }
        public ScenarioEntity<IScenery> cov_crowd_01b_03 { get; set; }
        public ScenarioEntity<IScenery> cov_crowd_01b_04 { get; set; }
        public ScenarioEntity<IScenery> cov_crowd_01b_05 { get; set; }
        public ScenarioEntity<IScenery> cov_crowd_01b_06 { get; set; }
        public ScenarioEntity<IScenery> cov_crowd_01b_07 { get; set; }
        public ScenarioEntity<IScenery> cov_crowd_01b_08 { get; set; }
        public ScenarioEntity<IScenery> cov_crowd_01b_09 { get; set; }
        public ScenarioEntity<IScenery> cov_crowd_01b_10 { get; set; }
        public ScenarioEntity<IScenery> cov_crowd_01b_11 { get; set; }
        public ScenarioEntity<IScenery> cov_crowd_01b_12 { get; set; }
        public ScenarioEntity<IScenery> cov_crowd_01b_13 { get; set; }
        public ScenarioEntity<IScenery> cov_crowd_01b_14 { get; set; }
        public ScenarioEntity<IScenery> cov_crowd_01b_15 { get; set; }
        public ScenarioEntity<IScenery> medal_01 { get; set; }
        public ScenarioEntity<IScenery> medal_02 { get; set; }
        public ScenarioEntity<IScenery> medal_03 { get; set; }
        public ScenarioEntity<IScenery> anchor_x02_01 { get; set; }
        public ScenarioEntity<IScenery> cov_crowd_01a_27 { get; set; }
        public ScenarioEntity<IScenery> cov_crowd_01a_28 { get; set; }
        public ScenarioEntity<IScenery> cov_crowd_01a_29 { get; set; }
        public ScenarioEntity<IScenery> cov_crowd_01a_30 { get; set; }
        public ScenarioEntity<IScenery> cov_crowd_01a_31 { get; set; }
        public ScenarioEntity<IScenery> cov_crowd_01a_32 { get; set; }
        public ScenarioEntity<IScenery> cov_crowd_01a_33 { get; set; }
        public ScenarioEntity<IScenery> problem_guard { get; set; }
        public ScenarioEntity<IScenery> cov_crowd_01c_01 { get; set; }
        public ScenarioEntity<IScenery> cov_crowd_01c_02 { get; set; }
        public ScenarioEntity<IScenery> cov_crowd_01c_03 { get; set; }
        public ScenarioEntity<IScenery> cov_crowd_01c_04 { get; set; }
        public ScenarioEntity<IScenery> cov_crowd_01c_05 { get; set; }
        public ScenarioEntity<IScenery> cov_crowd_01d_01 { get; set; }
        public ScenarioEntity<IScenery> cov_crowd_01d_02 { get; set; }
        public ScenarioEntity<IScenery> cov_crowd_01d_03 { get; set; }
        public ScenarioEntity<IScenery> cov_crowd_01d_04 { get; set; }
        public ScenarioEntity<IScenery> cov_crowd_01d_05 { get; set; }
        public ScenarioEntity<IScenery> cov_crowd_01d_06 { get; set; }
        public ScenarioEntity<IScenery> cov_crowd_01d_07 { get; set; }
        public ScenarioEntity<IScenery> cov_crowd_01d_08 { get; set; }
        public ScenarioEntity<IScenery> cov_crowd_01d_09 { get; set; }
        public ScenarioEntity<IScenery> cov_crowd_01d_10 { get; set; }
        public ScenarioEntity<IScenery> cov_crowd_01d_11 { get; set; }
        public ScenarioEntity<IScenery> cov_crowd_01d_12 { get; set; }
        public ScenarioEntity<IScenery> cov_crowd_01d_13 { get; set; }
        public ScenarioEntity<IScenery> cov_crowd_01d_14 { get; set; }
        public ScenarioEntity<IScenery> cov_crowd_01d_15 { get; set; }
        public ScenarioEntity<IScenery> cov_crowd_01d_16 { get; set; }
        public ScenarioEntity<IScenery> cov_crowd_01d_17 { get; set; }
        public ScenarioEntity<IScenery> cov_crowd_01d_18 { get; set; }
        public ScenarioEntity<IScenery> cov_crowd_01d_19 { get; set; }
        public ScenarioEntity<IScenery> cov_crowd_01d_20 { get; set; }
        public ScenarioEntity<IScenery> cov_crowd_01d_21 { get; set; }
        public ScenarioEntity<IScenery> x02_marine_prop_03_01 { get; set; }
        public ScenarioEntity<IScenery> x02_marine_prop_03_02 { get; set; }
        public ScenarioEntity<IScenery> x02_marine_prop_03_03 { get; set; }
        public ScenarioEntity<IScenery> x02_marine_prop_03_04 { get; set; }
        public ScenarioEntity<IScenery> x02_marine_prop_03_05 { get; set; }
        public ScenarioEntity<IScenery> x02_marine_prop_03_06 { get; set; }
        public ScenarioEntity<IScenery> x02_marine_prop_03_07 { get; set; }
        public ScenarioEntity<IScenery> x02_marine_prop_03_08 { get; set; }
        public ScenarioEntity<IScenery> x02_marine_prop_03_09 { get; set; }
        public ScenarioEntity<IScenery> x02_marine_prop_03_10 { get; set; }
        public ScenarioEntity<IScenery> x02_marine_prop_03_11 { get; set; }
        public ScenarioEntity<IScenery> x02_marine_prop_03_12 { get; set; }
        public ScenarioEntity<IScenery> x02_marine_prop_03_13 { get; set; }
        public ScenarioEntity<IScenery> x02_marine_prop_03_14 { get; set; }
        public ScenarioEntity<IScenery> x02_marine_prop_03_15 { get; set; }
        public ScenarioEntity<IScenery> x02_marine_prop_03_16 { get; set; }
        public ScenarioEntity<IScenery> x02_marine_prop_03_17 { get; set; }
        public ScenarioEntity<IScenery> x02_marine_prop_03_18 { get; set; }
        public ScenarioEntity<IScenery> x02_marine_prop_03_19 { get; set; }
        public ScenarioEntity<IScenery> x02_marine_prop_03_20 { get; set; }
        public ScenarioEntity<IScenery> x02_marine_prop_03_21 { get; set; }
        public ScenarioEntity<IScenery> x02_marine_prop_03_22 { get; set; }
        public ScenarioEntity<IScenery> x02_marine_prop_03_23 { get; set; }
        public ScenarioEntity<IScenery> x02_marine_prop_03_24 { get; set; }
        public ScenarioEntity<IScenery> x02_marine_prop_03_25 { get; set; }
        public ScenarioEntity<IScenery> x02_marine_prop_03_26 { get; set; }
        public ScenarioEntity<IScenery> x02_marine_prop_03_27 { get; set; }
        public ScenarioEntity<IScenery> x02_marine_prop_03_28 { get; set; }
        public ScenarioEntity<IScenery> x02_marine_prop_03_29 { get; set; }
        public ScenarioEntity<IScenery> x02_marine_prop_03_30 { get; set; }
        public ScenarioEntity<IScenery> x02_marine_prop_03_31 { get; set; }
        public ScenarioEntity<IScenery> x02_marine_prop_03_32 { get; set; }
        public ScenarioEntity<IScenery> x02_marine_prop_03_33 { get; set; }
        public ScenarioEntity<IScenery> x02_marine_prop_03_34 { get; set; }
        public ScenarioEntity<IScenery> x02_marine_prop_03_35 { get; set; }
        public ScenarioEntity<IScenery> outro_elevator { get; set; }
        public ScenarioEntity<IScenery> beam_02 { get; set; }
        public ScenarioEntity<IScenery> beam_01 { get; set; }
        public ScenarioEntity<IScenery> _1st_door_blast { get; set; }
        public ScenarioEntity<IScenery> bloom_quad { get; set; }
        public ScenarioEntity<IScenery> airlock_debris_01 { get; set; }
        public ScenarioEntity<IScenery> x02_crowd_distant_01 { get; set; }
        public ScenarioEntity<IScenery> x02_crowd_distant_02 { get; set; }
        public ScenarioEntity<IScenery> x02_crowd_distant_03 { get; set; }
        public ScenarioEntity<IScenery> x02_crowd_distant_04 { get; set; }
        public ScenarioEntity<IScenery> x02_crowd_distant_05 { get; set; }
        public ScenarioEntity<IScenery> x02_crowd_distant_06 { get; set; }
        public ScenarioEntity<IScenery> x02_crowd_distant_07 { get; set; }
        public ScenarioEntity<IScenery> x02_crowd_distant_08 { get; set; }
        public ScenarioEntity<IScenery> x02_crowd_distant_09 { get; set; }
        public ScenarioEntity<IScenery> x02_crowd_distant_10 { get; set; }
        public ScenarioEntity<IScenery> x02_crowd_distant_11 { get; set; }
        public ScenarioEntity<IScenery> x02_crowd_distant_12 { get; set; }
        public ScenarioEntity<IScenery> x02_crowd_distant_13 { get; set; }
        public ScenarioEntity<IScenery> x02_crowd_distant_14 { get; set; }
        public ScenarioEntity<IScenery> x02_crowd_distant_15 { get; set; }
        public ScenarioEntity<IScenery> x02_crowd_distant_16 { get; set; }
        public ScenarioEntity<IScenery> x02_crowd_distant_17 { get; set; }
        public ScenarioEntity<IScenery> x02_crowd_distant_18 { get; set; }
        public ScenarioEntity<IScenery> x02_crowd_distant_19 { get; set; }
        public ScenarioEntity<IScenery> x02_crowd_distant_20 { get; set; }
        public ScenarioEntity<IScenery> x02_crowd_distant_21 { get; set; }
        public ScenarioEntity<IScenery> x02_crowd_distant_22 { get; set; }
        public ScenarioEntity<IScenery> x02_crowd_distant_23 { get; set; }
        public ScenarioEntity<IScenery> x02_crowd_distant_24 { get; set; }
        public ScenarioEntity<IScenery> x02_crowd_distant_25 { get; set; }
        public ScenarioEntity<IScenery> x02_crowd_distant_26 { get; set; }
        public ScenarioEntity<IScenery> x02_crowd_distant_27 { get; set; }
        public ScenarioEntity<IScenery> x02_crowd_distant_28 { get; set; }
        public ScenarioEntity<IScenery> x02_crowd_distant_29 { get; set; }
        public ScenarioEntity<IScenery> beam_start_01 { get; set; }
        public ScenarioEntity<IScenery> beam_start_02 { get; set; }
        public ScenarioEntity<IScenery> matte_earth { get; set; }
        public ScenarioEntity<IScenery> airlock_debris_02 { get; set; }
        public ScenarioEntity<IBloc> can_ice_cream { get; set; }
        public ScenarioEntity<IScenery> cov_crowd_01a_19 { get; set; }
        public ScenarioEntity<IScenery> outro_fighter_01 { get; set; }
        public ScenarioEntity<IScenery> outro_fighter_02 { get; set; }
        public ScenarioEntity<IScenery> outro_seraph { get; set; }
        public ScenarioEntity<IScenery> elevator_light_top { get; set; }
        public ScenarioEntity<IScenery> elevator_light_bottom { get; set; }
        public ScenarioEntity<IScenery> elevator_light_flash { get; set; }
        public ScenarioEntity<IScenery> gun_fleet { get; set; }
        public ScenarioEntity<IScenery> lvr_fleet { get; set; }
        public ScenarioEntity<IScenery> outro_fleet { get; set; }
        public ScenarioEntity<IScenery> offending_light { get; set; }
        public ScenarioEntity<IScenery> lvr_flyby_flag { get; set; }
        public ScenarioEntity<IScenery> blast_base { get; set; }
        public ScenarioEntity<IScenery> flyby { get; set; }
        public ScenarioEntity<IScenery> outro_cortana_base { get; set; }
        public ScenarioEntity<IUnit> chief { get; set; }
        public ScenarioEntity<IUnit> cortana { get; set; }
        public ScenarioEntity<IUnit> miranda { get; set; }
        public ScenarioEntity<IUnit> johnson { get; set; }
        public ScenarioEntity<IUnit> hood { get; set; }
        public ScenarioEntity<IUnit> hood_x02 { get; set; }
        public ScenarioEntity<IUnit> miranda_x02 { get; set; }
        public ScenarioEntity<IUnit> cortana_x02 { get; set; }
        public ScenarioEntity<IUnit> johnson_x02 { get; set; }
        public ScenarioEntity<IUnit> chief_x02 { get; set; }
        public ScenarioEntity<IUnit> tartarus { get; set; }
        public ScenarioEntity<IUnit> brute_01 { get; set; }
        public ScenarioEntity<IUnit> brute_02 { get; set; }
        public ScenarioEntity<IUnit> jackal_01 { get; set; }
        public ScenarioEntity<IUnit> jackal_02 { get; set; }
        public ScenarioEntity<IUnit> jackal_03 { get; set; }
        public ScenarioEntity<IUnit> grunt_01 { get; set; }
        public ScenarioEntity<IUnit> grunt_02 { get; set; }
        public ScenarioEntity<IUnit> grunt_03 { get; set; }
        public ScenarioEntity<IUnit> hunter_01 { get; set; }
        public ScenarioEntity<IUnit> hunter_02 { get; set; }
        public ScenarioEntity<IUnit> hunter_03 { get; set; }
        public ScenarioEntity<IUnit> dervish { get; set; }
        public ScenarioEntity<IUnit> marine_01 { get; set; }
        public ScenarioEntity<IUnit> marine_02 { get; set; }
        public ScenarioEntity<IUnit> marine_03 { get; set; }
        public ScenarioEntity<IUnit> marine_04 { get; set; }
        public ScenarioEntity<IUnit> marine_05 { get; set; }
        public ScenarioEntity<IUnit> marine_06 { get; set; }
        public ScenarioEntity<IUnit> marine_07 { get; set; }
        public ScenarioEntity<IUnit> marine_08 { get; set; }
        public ScenarioEntity<IUnit> johnson_x02_01 { get; set; }
        public ScenarioEntity<IUnit> chief_x02_01 { get; set; }
        public ScenarioEntity<IUnit> marine_x02_01 { get; set; }
        public ScenarioEntity<IUnit> marine_x02_02 { get; set; }
        public ScenarioEntity<IUnit> marine_x02_03 { get; set; }
        public ScenarioEntity<IUnit> marine_x02_04 { get; set; }
        public ScenarioEntity<IUnit> dervish_nude { get; set; }
        public ScenarioEntity<IUnit> marine_x02_05 { get; set; }
        public ScenarioEntity<IUnit> marine_x02_06 { get; set; }
        public ScenarioEntity<IUnit> marine_x02_07 { get; set; }
        public ScenarioEntity<IUnit> marine_x02_08 { get; set; }
        public ScenarioEntity<IUnit> marine_x02_12 { get; set; }
        public ScenarioEntity<IUnit> marine_x02_11 { get; set; }
        public ScenarioEntity<IUnit> marine_x02_10 { get; set; }
        public ScenarioEntity<IUnit> marine_x02_09 { get; set; }
        public ScenarioEntity<IUnit> marine_door_01 { get; set; }
        public ScenarioEntity<IUnit> marine_door_02 { get; set; }
        public ScenarioEntity<IUnit> marine_plant_01 { get; set; }
        public ScenarioEntity<IUnit> marine_plant_02 { get; set; }
        public ScenarioEntity<IUnit> marine_plant_03 { get; set; }
        public ScenarioEntity<IUnit> marine_plant_04 { get; set; }
        public ScenarioEntity<IUnit> marine_plant_05 { get; set; }
        public ScenarioEntity<IUnit> marine_plant_06 { get; set; }
        public ScenarioEntity<IUnit> marine_plant_07 { get; set; }
        public ScenarioEntity<IUnit> lvr_body_1 { get; set; }
        public ScenarioEntity<IUnit> lvr_body_2 { get; set; }
        public ScenarioEntity<IVehicle> dck_hog1 { get; set; }
        public ScenarioEntity<IWeapon> bigrack_bsp0a_5_smg_1 { get; set; }
        public ScenarioEntity<IWeapon> bigrack_bsp0a_5_smg_2 { get; set; }
        public ScenarioEntity<IWeapon> bigrack_bsp0a_5_smg_3 { get; set; }
        public ScenarioEntity<IWeapon> rack_bsp3_1_br_1 { get; set; }
        public ScenarioEntity<IWeapon> rack_bsp3_1_br_2 { get; set; }
        public ScenarioEntity<IWeapon> rack_bsp3_2_smg_1 { get; set; }
        public ScenarioEntity<IWeapon> rack_bsp3_2_smg_2 { get; set; }
        public ScenarioEntity<IWeapon> rack_bsp3_4_br_1 { get; set; }
        public ScenarioEntity<IWeapon> rack_bsp3_4_br_2 { get; set; }
        public ScenarioEntity<IWeapon> rack_bsp3_5_smg_1 { get; set; }
        public ScenarioEntity<IWeapon> rack_bsp0b_1_br_1 { get; set; }
        public ScenarioEntity<IWeapon> rack_bsp0b_1_br_2 { get; set; }
        public ScenarioEntity<IWeapon> rack_bsp0b_2_smg_1 { get; set; }
        public ScenarioEntity<IWeapon> rack_bsp0b_2_smg_2 { get; set; }
        public ScenarioEntity<IWeapon> bigrack_bsp0b_1_br_1 { get; set; }
        public ScenarioEntity<IWeapon> bigrack_bsp0b_1_br_2 { get; set; }
        public ScenarioEntity<IWeapon> bigrack_bsp0b_2_br_1 { get; set; }
        public ScenarioEntity<IWeapon> bigrack_bsp0b_3_br_1 { get; set; }
        public ScenarioEntity<IWeapon> bigrack_bsp0b_3_br_2 { get; set; }
        public ScenarioEntity<IWeapon> bigrack_bsp0b_4_br_1 { get; set; }
        public ScenarioEntity<IWeapon> bigrack_bsp0b_5_smg_1 { get; set; }
        public ScenarioEntity<IWeapon> bigrack_bsp0b_6_smg_1 { get; set; }
        public ScenarioEntity<IWeapon> bigrack_bsp0b_6_smg_2 { get; set; }
        public ScenarioEntity<IWeapon> bigrack_bsp0b_7_smg_1 { get; set; }
        public ScenarioEntity<IWeapon> bigrack_bsp0b_8_smg_1 { get; set; }
        public ScenarioEntity<IWeapon> rack_bsp2_1_smg_1 { get; set; }
        public ScenarioEntity<IWeapon> rack_bsp2_1_smg_2 { get; set; }
        public ScenarioEntity<IWeapon> rack_bsp2_1_smg_3 { get; set; }
        public ScenarioEntity<IWeapon> rack_bsp0a_1_smg_1 { get; set; }
        public ScenarioEntity<IWeapon> rack_bsp0a_1_smg_2 { get; set; }
        public ScenarioEntity<IWeapon> rack_bsp0a_3_smg_1 { get; set; }
        public ScenarioEntity<IWeapon> rack_bsp0a_3_smg_2 { get; set; }
        public ScenarioEntity<IWeapon> rack_bsp0a_4_br_1 { get; set; }
        public ScenarioEntity<IWeapon> rack_bsp0a_4_br_2 { get; set; }
        public ScenarioEntity<IWeapon> rack_bsp0a_2_br_1 { get; set; }
        public ScenarioEntity<IWeapon> rack_bsp0a_2_br_2 { get; set; }
        public ScenarioEntity<IWeapon> bigrack_bsp0a_6_smg_1 { get; set; }
        public ScenarioEntity<IWeapon> bigrack_bsp0a_6_smg_2 { get; set; }
        public ScenarioEntity<IWeapon> rack_bsp0a_5_smg_1 { get; set; }
        public ScenarioEntity<IWeapon> rack_bsp0a_5_smg_2 { get; set; }
        public ScenarioEntity<IWeapon> rack_bsp0a_5_smg_3 { get; set; }
        public ScenarioEntity<IWeapon> rack_bsp0a_6_br_1 { get; set; }
        public ScenarioEntity<IWeapon> rack_bsp0a_6_br_2 { get; set; }
        public ScenarioEntity<IWeapon> rack_bsp0a_6_br_3 { get; set; }
        public ScenarioEntity<IWeapon> yorick { get; set; }
        public ScenarioEntity<IDevice> tram { get; set; }
        public ScenarioEntity<IDevice> elv_elevator_control_2 { get; set; }
        public ScenarioEntity<IDevice> gun_elevator { get; set; }
        public ScenarioEntity<IDevice> capital_1 { get; set; }
        public ScenarioEntity<IDevice> macgun { get; set; }
        public ScenarioEntity<IDevice> elv_elevator { get; set; }
        public ScenarioEntity<IDevice> dck_hog_rail { get; set; }
        public ScenarioEntity<IDevice> bay2_door_exit_1 { get; set; }
        public ScenarioEntity<IDevice> bay2_door_exit_2 { get; set; }
        public ScenarioEntity<IDevice> atr2_door_re { get; set; }
        public ScenarioEntity<IDevice> bsp2_door_forward { get; set; }
        public ScenarioEntity<IDevice> bsp2_door_back { get; set; }
        public ScenarioEntity<IDevice> bsp3_door_forward { get; set; }
        public ScenarioEntity<IDevice> bsp3_door_backward { get; set; }
        public ScenarioEntity<IDevice> blam { get; set; }
        public ScenarioEntity<IDevice> bay1_door_exit { get; set; }
        public ScenarioEntity<IDevice> lvr_door_enter_1 { get; set; }
        public ScenarioEntity<IDevice> lvr_door_enter_2 { get; set; }
        public ScenarioEntity<IDevice> arm_door_exit { get; set; }
        public ScenarioEntity<IDevice> gun_elevator_door_top { get; set; }
        public ScenarioEntity<IDevice> outro_door_01 { get; set; }
        public ScenarioEntity<IDevice> outro_door_02 { get; set; }
        public ScenarioEntity<IDevice> outro_door_03 { get; set; }
        public ScenarioEntity<IDevice> outro_lever { get; set; }
        public ScenarioEntity<IDevice> elv_elevator_control_1 { get; set; }
        public ScenarioEntity<IDevice> bsp3_door_backward_2 { get; set; }
        public ScenarioEntity<IDevice> lvr_airlock_blower { get; set; }
        public ScenarioEntity<IDevice> capital_2 { get; set; }
        public ScenarioEntity<IDevice> _1st_door_enter { get; set; }
        public ScenarioEntity<IDevice> lvr_wall_enter { get; set; }
        public ScenarioEntity<IDevice> gun_wall_enter { get; set; }
        public ScenarioEntity<IDevice> dck_door_arm_2 { get; set; }
        public ScenarioEntity<IDevice> dck_door_arm_1 { get; set; }
        public ScenarioEntity<IDevice> dck_wall_enter { get; set; }
        public ScenarioEntity<IDevice> trm1_tram { get; set; }
        public ScenarioEntity<IDevice> rack_bsp3_2 { get; set; }
        public ScenarioEntity<IDevice> rack_bsp3_1 { get; set; }
        public ScenarioEntity<IDevice> arm_door_charger_1 { get; set; }
        public ScenarioEntity<IDevice> arm_door_charger_2 { get; set; }
        public ScenarioEntity<IDevice> rack_bsp3_4 { get; set; }
        public ScenarioEntity<IDevice> rack_bsp3_5 { get; set; }
        public ScenarioEntity<IDevice> rack_bsp0b_1 { get; set; }
        public ScenarioEntity<IDevice> rack_bsp0b_2 { get; set; }
        public ScenarioEntity<IDevice> bigrack_bsp0b_1 { get; set; }
        public ScenarioEntity<IDevice> bigrack_bsp0b_2 { get; set; }
        public ScenarioEntity<IDevice> bigrack_bsp0b_3 { get; set; }
        public ScenarioEntity<IDevice> bigrack_bsp0b_4 { get; set; }
        public ScenarioEntity<IDevice> bigrack_bsp0b_8 { get; set; }
        public ScenarioEntity<IDevice> bigrack_bsp0b_7 { get; set; }
        public ScenarioEntity<IDevice> bigrack_bsp0b_6 { get; set; }
        public ScenarioEntity<IDevice> bigrack_bsp0b_5 { get; set; }
        public ScenarioEntity<IDevice> rack_bsp2_1 { get; set; }
        public ScenarioEntity<IDevice> rack_bsp0a_1 { get; set; }
        public ScenarioEntity<IDevice> rack_bsp0a_2 { get; set; }
        public ScenarioEntity<IDevice> rack_bsp0a_3 { get; set; }
        public ScenarioEntity<IDevice> rack_bsp0a_4 { get; set; }
        public ScenarioEntity<IDevice> bigrack_bsp0a_5 { get; set; }
        public ScenarioEntity<IDevice> bigrack_bsp0a_6 { get; set; }
        public ScenarioEntity<IDevice> _1st_door_top { get; set; }
        public ScenarioEntity<IDevice> _1st_craft { get; set; }
        public ScenarioEntity<IDevice> rack_bsp0a_5 { get; set; }
        public ScenarioEntity<IDevice> rack_bsp0a_6 { get; set; }
        public ScenarioEntity<IDevice> _1st_door_tram { get; set; }
        public ScenarioEntity<IDevice> gun_loader { get; set; }
        public ScenarioEntity<IDevice> x02_door_02 { get; set; }
        public ScenarioEntity<IDevice> x02_dervish_lift { get; set; }
        public ScenarioEntity<IDevice> x02_bridge_door { get; set; }
        public ScenarioEntity<IDevice> bay2_wall_exit_2 { get; set; }
        public ScenarioEntity<IDevice> _1st_tram_wall_1 { get; set; }
        public ScenarioEntity<IDevice> _1st_tram_wall_2 { get; set; }
        public ScenarioEntity<IDevice> bay2_wall_exit_1 { get; set; }
        public ScenarioEntity<IDevice> atr1_elevator { get; set; }
        public ScenarioEntity<IDevice> trm1_door_exit { get; set; }
        public IAiActorDefinition _1st_hum => Scenario.AiSquadGroupDefinitions[0];
        public IAiActorDefinition _1st_hum_floor => Scenario.AiSquadGroupDefinitions[1];
        public IAiActorDefinition _1st_hum_balcony => Scenario.AiSquadGroupDefinitions[2];
        public IAiActorDefinition _1st_hum_stairs => Scenario.AiSquadGroupDefinitions[3];
        public IAiActorDefinition _1st_cov => Scenario.AiSquadGroupDefinitions[4];
        public IAiActorDefinition _1st_cov_wv1 => Scenario.AiSquadGroupDefinitions[5];
        public IAiActorDefinition _1st_cov_wv2 => Scenario.AiSquadGroupDefinitions[6];
        public IAiActorDefinition _1st_cov_wv3 => Scenario.AiSquadGroupDefinitions[7];
        public IAiActorDefinition _1st_cov_wv4 => Scenario.AiSquadGroupDefinitions[8];
        public IAiActorDefinition _1st_cov_wv5 => Scenario.AiSquadGroupDefinitions[9];
        public IAiActorDefinition _1st_cov_hall => Scenario.AiSquadGroupDefinitions[10];
        public IAiActorDefinition atr2_hum => Scenario.AiSquadGroupDefinitions[11];
        public IAiActorDefinition atr2_cov => Scenario.AiSquadGroupDefinitions[12];
        public IAiActorDefinition atr2_cov_lstair => Scenario.AiSquadGroupDefinitions[13];
        public IAiActorDefinition atr2_cov_re => Scenario.AiSquadGroupDefinitions[14];
        public IAiActorDefinition atr2_cov_fnl => Scenario.AiSquadGroupDefinitions[15];
        public IAiActorDefinition bay1_hum => Scenario.AiSquadGroupDefinitions[16];
        public IAiActorDefinition bay1_cov_catwalk => Scenario.AiSquadGroupDefinitions[17];
        public IAiActorDefinition bay1_cov => Scenario.AiSquadGroupDefinitions[18];
        public IAiActorDefinition bay1_cov_floor => Scenario.AiSquadGroupDefinitions[19];
        public IAiActorDefinition bay1_cov_wv2 => Scenario.AiSquadGroupDefinitions[20];
        public IAiActorDefinition bay1_cov_wv3 => Scenario.AiSquadGroupDefinitions[21];
        public IAiActorDefinition bay1_cov_wv4 => Scenario.AiSquadGroupDefinitions[22];
        public IAiActorDefinition bay1_cov_wv5 => Scenario.AiSquadGroupDefinitions[23];
        public IAiActorDefinition bay1_cov_fnl => Scenario.AiSquadGroupDefinitions[24];
        public IAiActorDefinition bay2_hum => Scenario.AiSquadGroupDefinitions[25];
        public IAiActorDefinition bay2_cov_catwalk => Scenario.AiSquadGroupDefinitions[26];
        public IAiActorDefinition bay2_cov => Scenario.AiSquadGroupDefinitions[27];
        public IAiActorDefinition bay2_cov_floor => Scenario.AiSquadGroupDefinitions[28];
        public IAiActorDefinition bay2_cov_wv2 => Scenario.AiSquadGroupDefinitions[29];
        public IAiActorDefinition bay2_cov_wv3 => Scenario.AiSquadGroupDefinitions[30];
        public IAiActorDefinition bay2_cov_wv4 => Scenario.AiSquadGroupDefinitions[31];
        public IAiActorDefinition bay2_cov_wv5 => Scenario.AiSquadGroupDefinitions[32];
        public IAiActorDefinition bay2_cov_fnl => Scenario.AiSquadGroupDefinitions[33];
        public IAiActorDefinition arm_cov => Scenario.AiSquadGroupDefinitions[34];
        public IAiActorDefinition atr1_cov => Scenario.AiSquadGroupDefinitions[35];
        public IAiActorDefinition atr1_cov_sec => Scenario.AiSquadGroupDefinitions[36];
        public IAiActorDefinition atr1_cov_sec_back => Scenario.AiSquadGroupDefinitions[37];
        public IAiActorDefinition atr1_cov_sec_front => Scenario.AiSquadGroupDefinitions[38];
        public IAiActorDefinition atr1_cov_stairs => Scenario.AiSquadGroupDefinitions[39];
        public IAiActorDefinition atr1_cov_stairs_front => Scenario.AiSquadGroupDefinitions[40];
        public IAiActorDefinition atr1_cov_stairs_back => Scenario.AiSquadGroupDefinitions[41];
        public IAiActorDefinition atr1_cov_fbalcony => Scenario.AiSquadGroupDefinitions[42];
        public IAiActorDefinition atr1_cov_bbalcony => Scenario.AiSquadGroupDefinitions[43];
        public IAiActorDefinition trm1_hum_alock => Scenario.AiSquadGroupDefinitions[44];
        public IAiActorDefinition trm1_hum_block => Scenario.AiSquadGroupDefinitions[45];
        public IAiActorDefinition trm1_cov_alock => Scenario.AiSquadGroupDefinitions[46];
        public IAiActorDefinition trm1_cov_block => Scenario.AiSquadGroupDefinitions[47];
        public IAiActorDefinition dck_cov => Scenario.AiSquadGroupDefinitions[48];
        public IAiActorDefinition dck_cov_arm1 => Scenario.AiSquadGroupDefinitions[49];
        public IAiActorDefinition dck_cov_arm2 => Scenario.AiSquadGroupDefinitions[50];
        public IAiActorDefinition elv_cov => Scenario.AiSquadGroupDefinitions[51];
        public IAiActorDefinition elv_cov_top => Scenario.AiSquadGroupDefinitions[52];
        public IAiActorDefinition elv_cov_elevator => Scenario.AiSquadGroupDefinitions[53];
        public IAiActorDefinition lvr_cov => Scenario.AiSquadGroupDefinitions[54];
        public IAiActorDefinition lvr_cov_wv1 => Scenario.AiSquadGroupDefinitions[55];
        public IAiActorDefinition lvr_cov_wv2 => Scenario.AiSquadGroupDefinitions[56];
        public IAiActorDefinition gun_cov => Scenario.AiSquadGroupDefinitions[57];
        public IAiActorDefinition gun_cortana => Scenario.AiSquadGroupDefinitions[58];
        public IAiActorDefinition atr2_cov_floor => Scenario.AiSquadGroupDefinitions[59];
        public IAiOrders _1st_hum_halla => Scenario.AiOrderDefinitions[0].GameObject;
        public IAiOrders _1st_hum_hallb => Scenario.AiOrderDefinitions[1].GameObject;
        public IAiOrders _1st_hum_balcony1 => Scenario.AiOrderDefinitions[2].GameObject;
        public IAiOrders _1st_hum_balcony_stairs => Scenario.AiOrderDefinitions[3].GameObject;
        public IAiOrders _1st_hum_floor1 => Scenario.AiOrderDefinitions[4].GameObject;
        public IAiOrders _1st_cov_wv11 => Scenario.AiOrderDefinitions[5].GameObject;
        public IAiOrders _1st_cov_wv1_advance => Scenario.AiOrderDefinitions[6].GameObject;
        public IAiOrders _1st_cov_wv21 => Scenario.AiOrderDefinitions[7].GameObject;
        public IAiOrders _1st_cov_wv2_advance => Scenario.AiOrderDefinitions[8].GameObject;
        public IAiOrders _1st_cov_wv31 => Scenario.AiOrderDefinitions[9].GameObject;
        public IAiOrders _1st_cov_wv3_advance => Scenario.AiOrderDefinitions[10].GameObject;
        public IAiOrders _1st_cov_wv41 => Scenario.AiOrderDefinitions[11].GameObject;
        public IAiOrders _1st_cov_wv4_rear => Scenario.AiOrderDefinitions[12].GameObject;
        public IAiOrders _1st_hum_hall => Scenario.AiOrderDefinitions[13].GameObject;
        public IAiOrders _1st_cov_hall1 => Scenario.AiOrderDefinitions[14].GameObject;
        public IAiOrders _1st_hum_hall_end => Scenario.AiOrderDefinitions[15].GameObject;
        public IAiOrders _1st_hum_stairs1 => Scenario.AiOrderDefinitions[16].GameObject;
        public IAiOrders atr2_hum_security_bunker => Scenario.AiOrderDefinitions[17].GameObject;
        public IAiOrders atr2_hum_lstair_top_assault => Scenario.AiOrderDefinitions[18].GameObject;
        public IAiOrders atr2_hum_floor => Scenario.AiOrderDefinitions[19].GameObject;
        public IAiOrders atr2_hum_stairs => Scenario.AiOrderDefinitions[20].GameObject;
        public IAiOrders atr2_hum_follow => Scenario.AiOrderDefinitions[21].GameObject;
        public IAiOrders atr2_hum_done => Scenario.AiOrderDefinitions[22].GameObject;
        public IAiOrders atr2_cov_floor_front_harrass => Scenario.AiOrderDefinitions[23].GameObject;
        public IAiOrders atr2_cov_fbalcony_harass => Scenario.AiOrderDefinitions[24].GameObject;
        public IAiOrders atr2_cov_lstair_assault => Scenario.AiOrderDefinitions[25].GameObject;
        public IAiOrders atr2_cov_lstair_back_guard => Scenario.AiOrderDefinitions[26].GameObject;
        public IAiOrders atr2_cov_floor_front_guard => Scenario.AiOrderDefinitions[27].GameObject;
        public IAiOrders atr2_cov_flbalcony_guard => Scenario.AiOrderDefinitions[28].GameObject;
        public IAiOrders atr2_cov_floor_guard => Scenario.AiOrderDefinitions[29].GameObject;
        public IAiOrders atr2_cov_bbalcony_guard => Scenario.AiOrderDefinitions[30].GameObject;
        public IAiOrders atr2_cov_re_floor_guard => Scenario.AiOrderDefinitions[31].GameObject;
        public IAiOrders atr2_cov_re_floor_back_bunker => Scenario.AiOrderDefinitions[32].GameObject;
        public IAiOrders bay1_hum_back => Scenario.AiOrderDefinitions[33].GameObject;
        public IAiOrders bay1_cov_floor_back => Scenario.AiOrderDefinitions[34].GameObject;
        public IAiOrders bay1_cov_floor1 => Scenario.AiOrderDefinitions[35].GameObject;
        public IAiOrders bay1_hum_catwalk => Scenario.AiOrderDefinitions[36].GameObject;
        public IAiOrders bay1_hum_catwalk1 => Scenario.AiOrderDefinitions[37].GameObject;
        public IAiOrders bay1_cov_fnl1 => Scenario.AiOrderDefinitions[38].GameObject;
        public IAiOrders bay2_hum_back => Scenario.AiOrderDefinitions[39].GameObject;
        public IAiOrders bay2_cov_floor_back => Scenario.AiOrderDefinitions[40].GameObject;
        public IAiOrders bay2_cov_floor1 => Scenario.AiOrderDefinitions[41].GameObject;
        public IAiOrders bay2_cov_catwalk1 => Scenario.AiOrderDefinitions[42].GameObject;
        public IAiOrders bay2_cov_fnl1 => Scenario.AiOrderDefinitions[43].GameObject;
        public IAiOrders arm_hum_table => Scenario.AiOrderDefinitions[44].GameObject;
        public IAiOrders arm1_cov_bot => Scenario.AiOrderDefinitions[45].GameObject;
        public IAiOrders arm1_cov_bot_stealth => Scenario.AiOrderDefinitions[46].GameObject;
        public IAiOrders arm1_cov_guns => Scenario.AiOrderDefinitions[47].GameObject;
        public IAiOrders atr1_cov_floor_front => Scenario.AiOrderDefinitions[48].GameObject;
        public IAiOrders atr1_cov_bbalcony1 => Scenario.AiOrderDefinitions[49].GameObject;
        public IAiOrders atr1_cov_fbalcony1 => Scenario.AiOrderDefinitions[50].GameObject;
        public IAiOrders atr1_cov_stairs_bot => Scenario.AiOrderDefinitions[51].GameObject;
        public IAiOrders atr1_cov_sec_back1 => Scenario.AiOrderDefinitions[52].GameObject;
        public IAiOrders atr1_cov_sec_back_rear => Scenario.AiOrderDefinitions[53].GameObject;
        public IAiOrders atr1_cov_sec_window => Scenario.AiOrderDefinitions[54].GameObject;
        public IAiOrders atr1_cov_stairs_bot1 => Scenario.AiOrderDefinitions[55].GameObject;
        public IAiOrders atr1_cov_stairs_bot_back => Scenario.AiOrderDefinitions[56].GameObject;
        public IAiOrders atr1_cov_stairs_back1 => Scenario.AiOrderDefinitions[57].GameObject;
        public IAiOrders atr1_cov_fbalcony_fat => Scenario.AiOrderDefinitions[58].GameObject;
        public IAiOrders atr1_cov_bbalcony_fat => Scenario.AiOrderDefinitions[59].GameObject;
        public IAiOrders atr1_cov_floor => Scenario.AiOrderDefinitions[60].GameObject;
        public IAiOrders atr1_cov_bfloor => Scenario.AiOrderDefinitions[61].GameObject;
        public IAiOrders trm1_hum_back => Scenario.AiOrderDefinitions[62].GameObject;
        public IAiOrders trm1_hum_alock1 => Scenario.AiOrderDefinitions[63].GameObject;
        public IAiOrders trm1_hum_alock_advance => Scenario.AiOrderDefinitions[64].GameObject;
        public IAiOrders trm1_hum_iac => Scenario.AiOrderDefinitions[65].GameObject;
        public IAiOrders trm1_cov_alock1 => Scenario.AiOrderDefinitions[66].GameObject;
        public IAiOrders trm1_cov_block1 => Scenario.AiOrderDefinitions[67].GameObject;
        public IAiOrders trm1_hum_block1 => Scenario.AiOrderDefinitions[68].GameObject;
        public IAiOrders trm1_hum_block_advance => Scenario.AiOrderDefinitions[69].GameObject;
        public IAiOrders elv_hum_back => Scenario.AiOrderDefinitions[70].GameObject;
        public IAiOrders elv_cov_floor => Scenario.AiOrderDefinitions[71].GameObject;
        public IAiOrders elv_cov_stairs_left => Scenario.AiOrderDefinitions[72].GameObject;
        public IAiOrders elv_cov_stairs_right => Scenario.AiOrderDefinitions[73].GameObject;
        public IAiOrders elv_cov_left_back => Scenario.AiOrderDefinitions[74].GameObject;
        public IAiOrders elv_cov_right_back => Scenario.AiOrderDefinitions[75].GameObject;
        public IAiOrders elv_cov_floor_back => Scenario.AiOrderDefinitions[76].GameObject;
        public IAiOrders elv_cov_fnl => Scenario.AiOrderDefinitions[77].GameObject;
        public IAiOrders elv_cov_elevator1 => Scenario.AiOrderDefinitions[78].GameObject;
        public IAiOrders elv_cov_elevator_back => Scenario.AiOrderDefinitions[79].GameObject;
        public IAiOrders lvr_cov_rise => Scenario.AiOrderDefinitions[80].GameObject;
        public IAiOrders lvr_cov_advance => Scenario.AiOrderDefinitions[81].GameObject;
        public IAiOrders lvr_cov_main => Scenario.AiOrderDefinitions[82].GameObject;
        public IAiOrders lvr_cov_back => Scenario.AiOrderDefinitions[83].GameObject;
        public IAiOrders lvr_cov_cmp => Scenario.AiOrderDefinitions[84].GameObject;
        public IAiOrders lvr_cov_air => Scenario.AiOrderDefinitions[85].GameObject;
        public IAiOrders lvr_cov_air_back => Scenario.AiOrderDefinitions[86].GameObject;
        public IAiOrders dck_cov_arm1_enter => Scenario.AiOrderDefinitions[87].GameObject;
        public IAiOrders dck_cov_arm1_windows => Scenario.AiOrderDefinitions[88].GameObject;
        public IAiOrders dck_cov_arm1_back => Scenario.AiOrderDefinitions[89].GameObject;
        public IAiOrders dck_cov_arm1_flight => Scenario.AiOrderDefinitions[90].GameObject;
        public IAiOrders dck_cov_arm11 => Scenario.AiOrderDefinitions[91].GameObject;
        public IAiOrders dck_cov_arm21 => Scenario.AiOrderDefinitions[92].GameObject;
        public IAiOrders dck_cov_back => Scenario.AiOrderDefinitions[93].GameObject;
        public IAiOrders dck_cov_retreat => Scenario.AiOrderDefinitions[94].GameObject;
        public IAiOrders gun_cov_chase => Scenario.AiOrderDefinitions[95].GameObject;
        public IAiOrders gun_cov_guard_a => Scenario.AiOrderDefinitions[96].GameObject;
        public IAiOrders gun_cov_guard_b => Scenario.AiOrderDefinitions[97].GameObject;
        public IAiOrders gun_cov_guard_c => Scenario.AiOrderDefinitions[98].GameObject;
        public IAiOrders gun_cov_guard_back => Scenario.AiOrderDefinitions[99].GameObject;
        public IAiOrders gun_hum_back => Scenario.AiOrderDefinitions[100].GameObject;
        public IAiOrders bay1_hum_post => Scenario.AiOrderDefinitions[101].GameObject;
        public IAiOrders bay2_hum_advance => Scenario.AiOrderDefinitions[102].GameObject;
        public ILocationFlag anchor_flag_outro1 => Scenario.LocationFlagDefinitions[0];
        public ILocationFlag anchor_flag_outro2 => Scenario.LocationFlagDefinitions[1];
        public ILocationFlag flag_cluster_04 => Scenario.LocationFlagDefinitions[2];
        public ILocationFlag flag_cluster_03 => Scenario.LocationFlagDefinitions[3];
        public ILocationFlag flag_cluster_02 => Scenario.LocationFlagDefinitions[4];
        public ILocationFlag flag_cluster_01 => Scenario.LocationFlagDefinitions[5];
        public ILocationFlag flag_interior_blast => Scenario.LocationFlagDefinitions[6];
        public ILocationFlag atr2_flag => Scenario.LocationFlagDefinitions[7];
        public ILocationFlag bay1_flag => Scenario.LocationFlagDefinitions[8];
        public ILocationFlag bay2_flag => Scenario.LocationFlagDefinitions[9];
        public ILocationFlag arm_flag => Scenario.LocationFlagDefinitions[10];
        public ILocationFlag atr1_flag => Scenario.LocationFlagDefinitions[11];
        public ILocationFlag trm1_flag => Scenario.LocationFlagDefinitions[12];
        public ILocationFlag elv_flag => Scenario.LocationFlagDefinitions[13];
        public ILocationFlag lvr_flag => Scenario.LocationFlagDefinitions[14];
        public ILocationFlag gun_flag => Scenario.LocationFlagDefinitions[15];
        public ILocationFlag anchor_flag_x02_02 => Scenario.LocationFlagDefinitions[16];
        public ILocationFlag anchor_flag_x02_01 => Scenario.LocationFlagDefinitions[17];
        public ILocationFlag bsp_0_2_safe => Scenario.LocationFlagDefinitions[18];
        public ILocationFlag bsp_2_0_safe => Scenario.LocationFlagDefinitions[19];
        public ILocationFlag bsp_0_3_safe => Scenario.LocationFlagDefinitions[20];
        public ILocationFlag macgun_flag => Scenario.LocationFlagDefinitions[21];
        public ILocationFlag dck_flag => Scenario.LocationFlagDefinitions[22];
        public ILocationFlag dck_enter_flag => Scenario.LocationFlagDefinitions[23];
        public ILocationFlag fbalcony_flag => Scenario.LocationFlagDefinitions[24];
        public ILocationFlag bbalcony_flag => Scenario.LocationFlagDefinitions[25];
        public ILocationFlag _1st_2nd_flag => Scenario.LocationFlagDefinitions[26];
        public ILocationFlag flag_cortana_effect_outro => Scenario.LocationFlagDefinitions[27];
        public ILocationFlag _1st_blast_flag_1 => Scenario.LocationFlagDefinitions[28];
        public ILocationFlag _1st_blast_flag_2 => Scenario.LocationFlagDefinitions[29];
        public ILocationFlag bay1_blast_flag_1 => Scenario.LocationFlagDefinitions[30];
        public ILocationFlag bay1_blast_flag_2 => Scenario.LocationFlagDefinitions[31];
        public ILocationFlag _1st_blast_flag_3 => Scenario.LocationFlagDefinitions[32];
        public ILocationFlag _1st_blast_flag_4 => Scenario.LocationFlagDefinitions[33];
        public ICinematicTitle title_1st1 => Scenario.CinematicTitleDefinitions[0].GameObject;
        public ICinematicTitle title_bay21 => Scenario.CinematicTitleDefinitions[1].GameObject;
        public ICinematicTitle title_dck1 => Scenario.CinematicTitleDefinitions[2].GameObject;
        public ICinematicTitle title_gun1 => Scenario.CinematicTitleDefinitions[3].GameObject;
        public ICinematicTitle title_gun_alt => Scenario.CinematicTitleDefinitions[4].GameObject;
        public ITriggerVolume bsp_0_2 => Scenario.TriggerVolumes[0].GameObject;
        public ITriggerVolume trans_0_2 => Scenario.TriggerVolumes[1].GameObject;
        public ITriggerVolume bsp_2_0 => Scenario.TriggerVolumes[2].GameObject;
        public ITriggerVolume trans_2_0 => Scenario.TriggerVolumes[3].GameObject;
        public ITriggerVolume bsp_0_3 => Scenario.TriggerVolumes[4].GameObject;
        public ITriggerVolume trans_0_3 => Scenario.TriggerVolumes[5].GameObject;
        public ITriggerVolume tv_atr2_rstair => Scenario.TriggerVolumes[6].GameObject;
        public ITriggerVolume tv_atr2_security_r => Scenario.TriggerVolumes[7].GameObject;
        public ITriggerVolume tv_atr2_lstair => Scenario.TriggerVolumes[8].GameObject;
        public ITriggerVolume tv_atr2_floor_front => Scenario.TriggerVolumes[9].GameObject;
        public ITriggerVolume tv_atr2_floor_mid => Scenario.TriggerVolumes[10].GameObject;
        public ITriggerVolume tv_atr2_floor_back => Scenario.TriggerVolumes[11].GameObject;
        public ITriggerVolume tv_1st_all => Scenario.TriggerVolumes[12].GameObject;
        public ITriggerVolume tv_1st_exit => Scenario.TriggerVolumes[13].GameObject;
        public ITriggerVolume tv_1st_board => Scenario.TriggerVolumes[14].GameObject;
        public ITriggerVolume tv_bay1_stairs => Scenario.TriggerVolumes[15].GameObject;
        public ITriggerVolume tv_bay2_hall => Scenario.TriggerVolumes[16].GameObject;
        public ITriggerVolume tv_atr1_floor => Scenario.TriggerVolumes[17].GameObject;
        public ITriggerVolume tv_trm1_floor => Scenario.TriggerVolumes[18].GameObject;
        public ITriggerVolume tv_trm1_alock => Scenario.TriggerVolumes[19].GameObject;
        public ITriggerVolume tv_trm1_block => Scenario.TriggerVolumes[20].GameObject;
        public ITriggerVolume tv_lvr_enter => Scenario.TriggerVolumes[21].GameObject;
        public ITriggerVolume tv_elv_enter => Scenario.TriggerVolumes[22].GameObject;
        public ITriggerVolume tv_elevator => Scenario.TriggerVolumes[23].GameObject;
        public ITriggerVolume tv_trm1_start => Scenario.TriggerVolumes[24].GameObject;
        public ITriggerVolume tv_mac_start => Scenario.TriggerVolumes[25].GameObject;
        public ITriggerVolume tv_gun_elevator => Scenario.TriggerVolumes[26].GameObject;
        public ITriggerVolume tv_1st_hallb => Scenario.TriggerVolumes[27].GameObject;
        public ITriggerVolume tv_1st_halla => Scenario.TriggerVolumes[28].GameObject;
        public ITriggerVolume tv_elv_start => Scenario.TriggerVolumes[29].GameObject;
        public ITriggerVolume tv_lvr_lever => Scenario.TriggerVolumes[30].GameObject;
        public ITriggerVolume tv_lvr_back => Scenario.TriggerVolumes[31].GameObject;
        public ITriggerVolume tv_dck_start => Scenario.TriggerVolumes[32].GameObject;
        public ITriggerVolume tv_dck_arm1_mid => Scenario.TriggerVolumes[33].GameObject;
        public ITriggerVolume tv_dck_arm1_back => Scenario.TriggerVolumes[34].GameObject;
        public ITriggerVolume tv_dck_mid => Scenario.TriggerVolumes[35].GameObject;
        public ITriggerVolume tv_dck_back => Scenario.TriggerVolumes[36].GameObject;
        public ITriggerVolume tv_dck_floor => Scenario.TriggerVolumes[37].GameObject;
        public ITriggerVolume tv_atr1_sec_back => Scenario.TriggerVolumes[38].GameObject;
        public ITriggerVolume tv_atr1_sec => Scenario.TriggerVolumes[39].GameObject;
        public ITriggerVolume tv_atr1_stairs => Scenario.TriggerVolumes[40].GameObject;
        public ITriggerVolume tv_atr1_mid => Scenario.TriggerVolumes[41].GameObject;
        public ITriggerVolume tv_arm_stairs => Scenario.TriggerVolumes[42].GameObject;
        public ITriggerVolume tv_arm_start => Scenario.TriggerVolumes[43].GameObject;
        public ITriggerVolume atr2_done => Scenario.TriggerVolumes[44].GameObject;
        public ITriggerVolume tv_bay1_boarding_tube => Scenario.TriggerVolumes[45].GameObject;
        public ITriggerVolume tv_bay2_boarding_tube => Scenario.TriggerVolumes[46].GameObject;
        public ITriggerVolume tv_arm_save => Scenario.TriggerVolumes[47].GameObject;
        public ITriggerVolume kill_elv => Scenario.TriggerVolumes[48].GameObject;
        public ITriggerVolume dont_kill_frogblast => Scenario.TriggerVolumes[49].GameObject;
        public ITriggerVolume dont_kill_exploration => Scenario.TriggerVolumes[50].GameObject;
        public ITriggerVolume tv_ice_cream => Scenario.TriggerVolumes[51].GameObject;
        public IStartingProfile player_starting_profile_0 => Scenario.StartingProfileDefinitions[0].GameObject;
        public IStartingProfile player_starting_profile_1 => Scenario.StartingProfileDefinitions[1].GameObject;
        public IDeviceGroup elv_elevator_position => Scenario.DeviceGroupDefinitions[0].GameObject;
        public IDeviceGroup outro_door_011 => Scenario.DeviceGroupDefinitions[1].GameObject;
        public IDeviceGroup outro_door_021 => Scenario.DeviceGroupDefinitions[2].GameObject;
        public IDeviceGroup outro_door_031 => Scenario.DeviceGroupDefinitions[3].GameObject;
        public IDeviceGroup outro_elevator1 => Scenario.DeviceGroupDefinitions[4].GameObject;
        public IDeviceGroup outro_lever1 => Scenario.DeviceGroupDefinitions[5].GameObject;
        public override void InitializeData(ScenarioTag scenarioTag, Scene scene)
        {
            this.Scenario = scenarioTag;
            pickle = new ScenarioEntity<IScenery>(0, scenarioTag.WellKnownItems[0]);
            iac = new ScenarioEntity<IScenery>(1, scenarioTag.WellKnownItems[1]);
            carrier_01 = new ScenarioEntity<IScenery>(2, scenarioTag.WellKnownItems[2]);
            carrier_02 = new ScenarioEntity<IScenery>(3, scenarioTag.WellKnownItems[3]);
            fighter_01 = new ScenarioEntity<IScenery>(4, scenarioTag.WellKnownItems[4]);
            fighter_02 = new ScenarioEntity<IScenery>(5, scenarioTag.WellKnownItems[5]);
            covenant_battery = new ScenarioEntity<IScenery>(6, scenarioTag.WellKnownItems[6]);
            pickle2 = new ScenarioEntity<IScenery>(7, scenarioTag.WellKnownItems[7]);
            carrier_1 = new ScenarioEntity<IScenery>(8, scenarioTag.WellKnownItems[8]);
            inamberclad = new ScenarioEntity<IScenery>(9, scenarioTag.WellKnownItems[9]);
            malta = new ScenarioEntity<IScenery>(10, scenarioTag.WellKnownItems[10]);
            athens = new ScenarioEntity<IScenery>(11, scenarioTag.WellKnownItems[11]);
            iac_bridge_outro_02 = new ScenarioEntity<IScenery>(12, scenarioTag.WellKnownItems[12]);
            hammer = new ScenarioEntity<IScenery>(13, scenarioTag.WellKnownItems[13]);
            fighter_x02_01 = new ScenarioEntity<IScenery>(14, scenarioTag.WellKnownItems[14]);
            fighter_x02_02 = new ScenarioEntity<IScenery>(15, scenarioTag.WellKnownItems[15]);
            fighter_x02_03 = new ScenarioEntity<IScenery>(16, scenarioTag.WellKnownItems[16]);
            fighter_x02_04 = new ScenarioEntity<IScenery>(17, scenarioTag.WellKnownItems[17]);
            poa_x02 = new ScenarioEntity<IScenery>(18, scenarioTag.WellKnownItems[18]);
            branding_iron_01 = new ScenarioEntity<IScenery>(19, scenarioTag.WellKnownItems[19]);
            branding_iron_02 = new ScenarioEntity<IScenery>(20, scenarioTag.WellKnownItems[20]);
            matte_africa = new ScenarioEntity<IScenery>(21, scenarioTag.WellKnownItems[21]);
            anchor_x02_02 = new ScenarioEntity<IScenery>(22, scenarioTag.WellKnownItems[22]);
            anchor_outro2 = new ScenarioEntity<IScenery>(23, scenarioTag.WellKnownItems[23]);
            anchor_outro1 = new ScenarioEntity<IScenery>(24, scenarioTag.WellKnownItems[24]);
            matte_africa_coast = new ScenarioEntity<IScenery>(25, scenarioTag.WellKnownItems[25]);
            outro_crate_1 = new ScenarioEntity<IBloc>(26, scenarioTag.WellKnownItems[26]);
            outro_crate_2 = new ScenarioEntity<IBloc>(27, scenarioTag.WellKnownItems[27]);
            outro_crate_3 = new ScenarioEntity<IBloc>(28, scenarioTag.WellKnownItems[28]);
            poa = new ScenarioEntity<IScenery>(29, scenarioTag.WellKnownItems[29]);
            cairo_bridge = new ScenarioEntity<IScenery>(30, scenarioTag.WellKnownItems[30]);
            iac_bridge_outro_01 = new ScenarioEntity<IScenery>(31, scenarioTag.WellKnownItems[31]);
            matte_carrier_core = new ScenarioEntity<IScenery>(32, scenarioTag.WellKnownItems[32]);
            matte_carrier_side = new ScenarioEntity<IScenery>(33, scenarioTag.WellKnownItems[33]);
            matte_carrier_hull = new ScenarioEntity<IScenery>(34, scenarioTag.WellKnownItems[34]);
            outro_cortana_stand = new ScenarioEntity<IScenery>(35, scenarioTag.WellKnownItems[35]);
            sparks_backward_01 = new ScenarioEntity<IScenery>(36, scenarioTag.WellKnownItems[36]);
            sparks_backward_02 = new ScenarioEntity<IScenery>(37, scenarioTag.WellKnownItems[37]);
            sparks_backward_03 = new ScenarioEntity<IScenery>(38, scenarioTag.WellKnownItems[38]);
            sparks_backward_04 = new ScenarioEntity<IScenery>(39, scenarioTag.WellKnownItems[39]);
            sparks_backward_05 = new ScenarioEntity<IScenery>(40, scenarioTag.WellKnownItems[40]);
            sparks_forward_01 = new ScenarioEntity<IScenery>(41, scenarioTag.WellKnownItems[41]);
            sparks_forward_02 = new ScenarioEntity<IScenery>(42, scenarioTag.WellKnownItems[42]);
            sparks_forward_03 = new ScenarioEntity<IScenery>(43, scenarioTag.WellKnownItems[43]);
            sparks_forward_04 = new ScenarioEntity<IScenery>(44, scenarioTag.WellKnownItems[44]);
            sparks_forward_05 = new ScenarioEntity<IScenery>(45, scenarioTag.WellKnownItems[45]);
            sparks_forward_06 = new ScenarioEntity<IScenery>(46, scenarioTag.WellKnownItems[46]);
            sparks_forward_07 = new ScenarioEntity<IScenery>(47, scenarioTag.WellKnownItems[47]);
            sparks_forward_08 = new ScenarioEntity<IScenery>(48, scenarioTag.WellKnownItems[48]);
            bay2_boarding_door = new ScenarioEntity<IScenery>(49, scenarioTag.WellKnownItems[49]);
            bay1_boarding_door = new ScenarioEntity<IScenery>(50, scenarioTag.WellKnownItems[50]);
            fighter_x02_06 = new ScenarioEntity<IScenery>(51, scenarioTag.WellKnownItems[51]);
            fighter_x02_05 = new ScenarioEntity<IScenery>(52, scenarioTag.WellKnownItems[52]);
            fighter_x02_08 = new ScenarioEntity<IScenery>(53, scenarioTag.WellKnownItems[53]);
            fighter_x02_07 = new ScenarioEntity<IScenery>(54, scenarioTag.WellKnownItems[54]);
            x02_unsc_logo = new ScenarioEntity<IScenery>(55, scenarioTag.WellKnownItems[55]);
            x02_tactical_display = new ScenarioEntity<IScenery>(56, scenarioTag.WellKnownItems[56]);
            x02_drone_01 = new ScenarioEntity<IScenery>(57, scenarioTag.WellKnownItems[57]);
            x02_drone_02 = new ScenarioEntity<IScenery>(58, scenarioTag.WellKnownItems[58]);
            johnson_hat = new ScenarioEntity<IScenery>(59, scenarioTag.WellKnownItems[59]);
            cov_crowd_02_01 = new ScenarioEntity<IScenery>(60, scenarioTag.WellKnownItems[60]);
            cov_crowd_02_02 = new ScenarioEntity<IScenery>(61, scenarioTag.WellKnownItems[61]);
            cov_crowd_02_03 = new ScenarioEntity<IScenery>(62, scenarioTag.WellKnownItems[62]);
            cov_crowd_02_04 = new ScenarioEntity<IScenery>(63, scenarioTag.WellKnownItems[63]);
            cov_crowd_02_05 = new ScenarioEntity<IScenery>(64, scenarioTag.WellKnownItems[64]);
            cov_crowd_02_06 = new ScenarioEntity<IScenery>(65, scenarioTag.WellKnownItems[65]);
            cov_crowd_02_07 = new ScenarioEntity<IScenery>(66, scenarioTag.WellKnownItems[66]);
            cov_crowd_02_08 = new ScenarioEntity<IScenery>(67, scenarioTag.WellKnownItems[67]);
            cov_crowd_02_09 = new ScenarioEntity<IScenery>(68, scenarioTag.WellKnownItems[68]);
            cov_crowd_02_10 = new ScenarioEntity<IScenery>(69, scenarioTag.WellKnownItems[69]);
            cov_crowd_02_11 = new ScenarioEntity<IScenery>(70, scenarioTag.WellKnownItems[70]);
            cov_crowd_02_12 = new ScenarioEntity<IScenery>(71, scenarioTag.WellKnownItems[71]);
            cov_crowd_02_13 = new ScenarioEntity<IScenery>(72, scenarioTag.WellKnownItems[72]);
            cov_crowd_02_14 = new ScenarioEntity<IScenery>(73, scenarioTag.WellKnownItems[73]);
            cov_crowd_02_15 = new ScenarioEntity<IScenery>(74, scenarioTag.WellKnownItems[74]);
            cov_crowd_02_16 = new ScenarioEntity<IScenery>(75, scenarioTag.WellKnownItems[75]);
            cov_crowd_02_17 = new ScenarioEntity<IScenery>(76, scenarioTag.WellKnownItems[76]);
            cov_crowd_02_18 = new ScenarioEntity<IScenery>(77, scenarioTag.WellKnownItems[77]);
            cov_crowd_02_19 = new ScenarioEntity<IScenery>(78, scenarioTag.WellKnownItems[78]);
            cov_crowd_01a_01 = new ScenarioEntity<IScenery>(79, scenarioTag.WellKnownItems[79]);
            cov_crowd_01a_02 = new ScenarioEntity<IScenery>(80, scenarioTag.WellKnownItems[80]);
            cov_crowd_01a_03 = new ScenarioEntity<IScenery>(81, scenarioTag.WellKnownItems[81]);
            cov_crowd_01a_04 = new ScenarioEntity<IScenery>(82, scenarioTag.WellKnownItems[82]);
            cov_crowd_01a_05 = new ScenarioEntity<IScenery>(83, scenarioTag.WellKnownItems[83]);
            cov_crowd_01a_06 = new ScenarioEntity<IScenery>(84, scenarioTag.WellKnownItems[84]);
            x02_column_01 = new ScenarioEntity<IScenery>(85, scenarioTag.WellKnownItems[85]);
            x02_column_02 = new ScenarioEntity<IScenery>(86, scenarioTag.WellKnownItems[86]);
            x02_column_03 = new ScenarioEntity<IScenery>(87, scenarioTag.WellKnownItems[87]);
            x02_column_04 = new ScenarioEntity<IScenery>(88, scenarioTag.WellKnownItems[88]);
            x02_column_05 = new ScenarioEntity<IScenery>(89, scenarioTag.WellKnownItems[89]);
            x02_column_06 = new ScenarioEntity<IScenery>(90, scenarioTag.WellKnownItems[90]);
            cov_crowd_01a_07 = new ScenarioEntity<IScenery>(91, scenarioTag.WellKnownItems[91]);
            cov_crowd_01a_08 = new ScenarioEntity<IScenery>(92, scenarioTag.WellKnownItems[92]);
            cov_crowd_01a_09 = new ScenarioEntity<IScenery>(93, scenarioTag.WellKnownItems[93]);
            cov_crowd_01a_10 = new ScenarioEntity<IScenery>(94, scenarioTag.WellKnownItems[94]);
            x02_marine_prop_01a_01 = new ScenarioEntity<IScenery>(95, scenarioTag.WellKnownItems[95]);
            x02_marine_prop_01b_02 = new ScenarioEntity<IScenery>(96, scenarioTag.WellKnownItems[96]);
            x02_marine_prop_01a_03 = new ScenarioEntity<IScenery>(97, scenarioTag.WellKnownItems[97]);
            x02_marine_prop_01b_04 = new ScenarioEntity<IScenery>(98, scenarioTag.WellKnownItems[98]);
            x02_marine_prop_01a_05 = new ScenarioEntity<IScenery>(99, scenarioTag.WellKnownItems[99]);
            x02_marine_prop_01a_06 = new ScenarioEntity<IScenery>(100, scenarioTag.WellKnownItems[100]);
            x02_marine_prop_01a_07 = new ScenarioEntity<IScenery>(101, scenarioTag.WellKnownItems[101]);
            x02_marine_prop_01b_08 = new ScenarioEntity<IScenery>(102, scenarioTag.WellKnownItems[102]);
            x02_marine_prop_01a_09 = new ScenarioEntity<IScenery>(103, scenarioTag.WellKnownItems[103]);
            x02_marine_prop_01b_10 = new ScenarioEntity<IScenery>(104, scenarioTag.WellKnownItems[104]);
            x02_marine_prop_01a_11 = new ScenarioEntity<IScenery>(105, scenarioTag.WellKnownItems[105]);
            x02_marine_prop_01b_12 = new ScenarioEntity<IScenery>(106, scenarioTag.WellKnownItems[106]);
            x02_marine_prop_01a_13 = new ScenarioEntity<IScenery>(107, scenarioTag.WellKnownItems[107]);
            x02_marine_prop_01b_14 = new ScenarioEntity<IScenery>(108, scenarioTag.WellKnownItems[108]);
            x02_marine_prop_01a_15 = new ScenarioEntity<IScenery>(109, scenarioTag.WellKnownItems[109]);
            x02_marine_prop_01b_16 = new ScenarioEntity<IScenery>(110, scenarioTag.WellKnownItems[110]);
            x02_marine_prop_02a_01 = new ScenarioEntity<IScenery>(111, scenarioTag.WellKnownItems[111]);
            x02_marine_prop_02b_02 = new ScenarioEntity<IScenery>(112, scenarioTag.WellKnownItems[112]);
            x02_marine_prop_02c_03 = new ScenarioEntity<IScenery>(113, scenarioTag.WellKnownItems[113]);
            x02_marine_prop_02a_05 = new ScenarioEntity<IScenery>(114, scenarioTag.WellKnownItems[114]);
            x02_marine_prop_02b_06 = new ScenarioEntity<IScenery>(115, scenarioTag.WellKnownItems[115]);
            x02_marine_prop_02c_07 = new ScenarioEntity<IScenery>(116, scenarioTag.WellKnownItems[116]);
            x02_marine_prop_02a_08 = new ScenarioEntity<IScenery>(117, scenarioTag.WellKnownItems[117]);
            x02_marine_prop_02b_09 = new ScenarioEntity<IScenery>(118, scenarioTag.WellKnownItems[118]);
            x02_marine_prop_02c_10 = new ScenarioEntity<IScenery>(119, scenarioTag.WellKnownItems[119]);
            x02_marine_prop_02a_11 = new ScenarioEntity<IScenery>(120, scenarioTag.WellKnownItems[120]);
            x02_marine_prop_02b_12 = new ScenarioEntity<IScenery>(121, scenarioTag.WellKnownItems[121]);
            x02_marine_prop_02c_13 = new ScenarioEntity<IScenery>(122, scenarioTag.WellKnownItems[122]);
            x02_marine_prop_02a_14 = new ScenarioEntity<IScenery>(123, scenarioTag.WellKnownItems[123]);
            x02_marine_prop_02b_16 = new ScenarioEntity<IScenery>(124, scenarioTag.WellKnownItems[124]);
            x02_marine_prop_02c_17 = new ScenarioEntity<IScenery>(125, scenarioTag.WellKnownItems[125]);
            x02_marine_prop_02a_18 = new ScenarioEntity<IScenery>(126, scenarioTag.WellKnownItems[126]);
            x02_marine_prop_02b_19 = new ScenarioEntity<IScenery>(127, scenarioTag.WellKnownItems[127]);
            x02_marine_prop_02c_20 = new ScenarioEntity<IScenery>(128, scenarioTag.WellKnownItems[128]);
            x02_marine_prop_02a_21 = new ScenarioEntity<IScenery>(129, scenarioTag.WellKnownItems[129]);
            x02_marine_prop_02b_22 = new ScenarioEntity<IScenery>(130, scenarioTag.WellKnownItems[130]);
            x02_marine_prop_02c_23 = new ScenarioEntity<IScenery>(131, scenarioTag.WellKnownItems[131]);
            x02_marine_prop_02a_24 = new ScenarioEntity<IScenery>(132, scenarioTag.WellKnownItems[132]);
            x02_marine_prop_02b_25 = new ScenarioEntity<IScenery>(133, scenarioTag.WellKnownItems[133]);
            x02_marine_prop_02c_26 = new ScenarioEntity<IScenery>(134, scenarioTag.WellKnownItems[134]);
            x02_marine_prop_02a_27 = new ScenarioEntity<IScenery>(135, scenarioTag.WellKnownItems[135]);
            x02_marine_prop_02b_28 = new ScenarioEntity<IScenery>(136, scenarioTag.WellKnownItems[136]);
            x02_marine_prop_02c_29 = new ScenarioEntity<IScenery>(137, scenarioTag.WellKnownItems[137]);
            x02_marine_prop_02a_30 = new ScenarioEntity<IScenery>(138, scenarioTag.WellKnownItems[138]);
            x02_marine_prop_02b_31 = new ScenarioEntity<IScenery>(139, scenarioTag.WellKnownItems[139]);
            x02_marine_prop_02c_32 = new ScenarioEntity<IScenery>(140, scenarioTag.WellKnownItems[140]);
            x02_cortana_stand = new ScenarioEntity<IScenery>(141, scenarioTag.WellKnownItems[141]);
            x02_medal_tray = new ScenarioEntity<IScenery>(142, scenarioTag.WellKnownItems[142]);
            x02_manacle_01 = new ScenarioEntity<IScenery>(143, scenarioTag.WellKnownItems[143]);
            x02_manacle_02 = new ScenarioEntity<IScenery>(144, scenarioTag.WellKnownItems[144]);
            x02_elite_helmet = new ScenarioEntity<IScenery>(145, scenarioTag.WellKnownItems[145]);
            dck_iac = new ScenarioEntity<IScenery>(146, scenarioTag.WellKnownItems[146]);
            cov_crowd_01a_11 = new ScenarioEntity<IScenery>(147, scenarioTag.WellKnownItems[147]);
            cov_crowd_01a_12 = new ScenarioEntity<IScenery>(148, scenarioTag.WellKnownItems[148]);
            cov_crowd_01a_13 = new ScenarioEntity<IScenery>(149, scenarioTag.WellKnownItems[149]);
            cov_crowd_01a_14 = new ScenarioEntity<IScenery>(150, scenarioTag.WellKnownItems[150]);
            cov_crowd_01a_15 = new ScenarioEntity<IScenery>(151, scenarioTag.WellKnownItems[151]);
            cov_crowd_01a_16 = new ScenarioEntity<IScenery>(152, scenarioTag.WellKnownItems[152]);
            cov_crowd_01a_17 = new ScenarioEntity<IScenery>(153, scenarioTag.WellKnownItems[153]);
            cov_crowd_01a_18 = new ScenarioEntity<IScenery>(154, scenarioTag.WellKnownItems[154]);
            cov_crowd_01a_20 = new ScenarioEntity<IScenery>(155, scenarioTag.WellKnownItems[155]);
            cov_crowd_01a_21 = new ScenarioEntity<IScenery>(156, scenarioTag.WellKnownItems[156]);
            cov_crowd_01a_22 = new ScenarioEntity<IScenery>(157, scenarioTag.WellKnownItems[157]);
            cov_crowd_01a_23 = new ScenarioEntity<IScenery>(158, scenarioTag.WellKnownItems[158]);
            cov_crowd_01a_24 = new ScenarioEntity<IScenery>(159, scenarioTag.WellKnownItems[159]);
            cov_crowd_01a_25 = new ScenarioEntity<IScenery>(160, scenarioTag.WellKnownItems[160]);
            cov_crowd_01a_26 = new ScenarioEntity<IScenery>(161, scenarioTag.WellKnownItems[161]);
            cov_crowd_01b_01 = new ScenarioEntity<IScenery>(162, scenarioTag.WellKnownItems[162]);
            cov_crowd_01b_16 = new ScenarioEntity<IScenery>(163, scenarioTag.WellKnownItems[163]);
            cov_crowd_01b_03 = new ScenarioEntity<IScenery>(164, scenarioTag.WellKnownItems[164]);
            cov_crowd_01b_04 = new ScenarioEntity<IScenery>(165, scenarioTag.WellKnownItems[165]);
            cov_crowd_01b_05 = new ScenarioEntity<IScenery>(166, scenarioTag.WellKnownItems[166]);
            cov_crowd_01b_06 = new ScenarioEntity<IScenery>(167, scenarioTag.WellKnownItems[167]);
            cov_crowd_01b_07 = new ScenarioEntity<IScenery>(168, scenarioTag.WellKnownItems[168]);
            cov_crowd_01b_08 = new ScenarioEntity<IScenery>(169, scenarioTag.WellKnownItems[169]);
            cov_crowd_01b_09 = new ScenarioEntity<IScenery>(170, scenarioTag.WellKnownItems[170]);
            cov_crowd_01b_10 = new ScenarioEntity<IScenery>(171, scenarioTag.WellKnownItems[171]);
            cov_crowd_01b_11 = new ScenarioEntity<IScenery>(172, scenarioTag.WellKnownItems[172]);
            cov_crowd_01b_12 = new ScenarioEntity<IScenery>(173, scenarioTag.WellKnownItems[173]);
            cov_crowd_01b_13 = new ScenarioEntity<IScenery>(174, scenarioTag.WellKnownItems[174]);
            cov_crowd_01b_14 = new ScenarioEntity<IScenery>(175, scenarioTag.WellKnownItems[175]);
            cov_crowd_01b_15 = new ScenarioEntity<IScenery>(176, scenarioTag.WellKnownItems[176]);
            medal_01 = new ScenarioEntity<IScenery>(177, scenarioTag.WellKnownItems[177]);
            medal_02 = new ScenarioEntity<IScenery>(178, scenarioTag.WellKnownItems[178]);
            medal_03 = new ScenarioEntity<IScenery>(179, scenarioTag.WellKnownItems[179]);
            anchor_x02_01 = new ScenarioEntity<IScenery>(180, scenarioTag.WellKnownItems[180]);
            cov_crowd_01a_27 = new ScenarioEntity<IScenery>(181, scenarioTag.WellKnownItems[181]);
            cov_crowd_01a_28 = new ScenarioEntity<IScenery>(182, scenarioTag.WellKnownItems[182]);
            cov_crowd_01a_29 = new ScenarioEntity<IScenery>(183, scenarioTag.WellKnownItems[183]);
            cov_crowd_01a_30 = new ScenarioEntity<IScenery>(184, scenarioTag.WellKnownItems[184]);
            cov_crowd_01a_31 = new ScenarioEntity<IScenery>(185, scenarioTag.WellKnownItems[185]);
            cov_crowd_01a_32 = new ScenarioEntity<IScenery>(186, scenarioTag.WellKnownItems[186]);
            cov_crowd_01a_33 = new ScenarioEntity<IScenery>(187, scenarioTag.WellKnownItems[187]);
            problem_guard = new ScenarioEntity<IScenery>(188, scenarioTag.WellKnownItems[188]);
            cov_crowd_01c_01 = new ScenarioEntity<IScenery>(189, scenarioTag.WellKnownItems[189]);
            cov_crowd_01c_02 = new ScenarioEntity<IScenery>(190, scenarioTag.WellKnownItems[190]);
            cov_crowd_01c_03 = new ScenarioEntity<IScenery>(191, scenarioTag.WellKnownItems[191]);
            cov_crowd_01c_04 = new ScenarioEntity<IScenery>(192, scenarioTag.WellKnownItems[192]);
            cov_crowd_01c_05 = new ScenarioEntity<IScenery>(193, scenarioTag.WellKnownItems[193]);
            cov_crowd_01d_01 = new ScenarioEntity<IScenery>(194, scenarioTag.WellKnownItems[194]);
            cov_crowd_01d_02 = new ScenarioEntity<IScenery>(195, scenarioTag.WellKnownItems[195]);
            cov_crowd_01d_03 = new ScenarioEntity<IScenery>(196, scenarioTag.WellKnownItems[196]);
            cov_crowd_01d_04 = new ScenarioEntity<IScenery>(197, scenarioTag.WellKnownItems[197]);
            cov_crowd_01d_05 = new ScenarioEntity<IScenery>(198, scenarioTag.WellKnownItems[198]);
            cov_crowd_01d_06 = new ScenarioEntity<IScenery>(199, scenarioTag.WellKnownItems[199]);
            cov_crowd_01d_07 = new ScenarioEntity<IScenery>(200, scenarioTag.WellKnownItems[200]);
            cov_crowd_01d_08 = new ScenarioEntity<IScenery>(201, scenarioTag.WellKnownItems[201]);
            cov_crowd_01d_09 = new ScenarioEntity<IScenery>(202, scenarioTag.WellKnownItems[202]);
            cov_crowd_01d_10 = new ScenarioEntity<IScenery>(203, scenarioTag.WellKnownItems[203]);
            cov_crowd_01d_11 = new ScenarioEntity<IScenery>(204, scenarioTag.WellKnownItems[204]);
            cov_crowd_01d_12 = new ScenarioEntity<IScenery>(205, scenarioTag.WellKnownItems[205]);
            cov_crowd_01d_13 = new ScenarioEntity<IScenery>(206, scenarioTag.WellKnownItems[206]);
            cov_crowd_01d_14 = new ScenarioEntity<IScenery>(207, scenarioTag.WellKnownItems[207]);
            cov_crowd_01d_15 = new ScenarioEntity<IScenery>(208, scenarioTag.WellKnownItems[208]);
            cov_crowd_01d_16 = new ScenarioEntity<IScenery>(209, scenarioTag.WellKnownItems[209]);
            cov_crowd_01d_17 = new ScenarioEntity<IScenery>(210, scenarioTag.WellKnownItems[210]);
            cov_crowd_01d_18 = new ScenarioEntity<IScenery>(211, scenarioTag.WellKnownItems[211]);
            cov_crowd_01d_19 = new ScenarioEntity<IScenery>(212, scenarioTag.WellKnownItems[212]);
            cov_crowd_01d_20 = new ScenarioEntity<IScenery>(213, scenarioTag.WellKnownItems[213]);
            cov_crowd_01d_21 = new ScenarioEntity<IScenery>(214, scenarioTag.WellKnownItems[214]);
            x02_marine_prop_03_01 = new ScenarioEntity<IScenery>(215, scenarioTag.WellKnownItems[215]);
            x02_marine_prop_03_02 = new ScenarioEntity<IScenery>(216, scenarioTag.WellKnownItems[216]);
            x02_marine_prop_03_03 = new ScenarioEntity<IScenery>(217, scenarioTag.WellKnownItems[217]);
            x02_marine_prop_03_04 = new ScenarioEntity<IScenery>(218, scenarioTag.WellKnownItems[218]);
            x02_marine_prop_03_05 = new ScenarioEntity<IScenery>(219, scenarioTag.WellKnownItems[219]);
            x02_marine_prop_03_06 = new ScenarioEntity<IScenery>(220, scenarioTag.WellKnownItems[220]);
            x02_marine_prop_03_07 = new ScenarioEntity<IScenery>(221, scenarioTag.WellKnownItems[221]);
            x02_marine_prop_03_08 = new ScenarioEntity<IScenery>(222, scenarioTag.WellKnownItems[222]);
            x02_marine_prop_03_09 = new ScenarioEntity<IScenery>(223, scenarioTag.WellKnownItems[223]);
            x02_marine_prop_03_10 = new ScenarioEntity<IScenery>(224, scenarioTag.WellKnownItems[224]);
            x02_marine_prop_03_11 = new ScenarioEntity<IScenery>(225, scenarioTag.WellKnownItems[225]);
            x02_marine_prop_03_12 = new ScenarioEntity<IScenery>(226, scenarioTag.WellKnownItems[226]);
            x02_marine_prop_03_13 = new ScenarioEntity<IScenery>(227, scenarioTag.WellKnownItems[227]);
            x02_marine_prop_03_14 = new ScenarioEntity<IScenery>(228, scenarioTag.WellKnownItems[228]);
            x02_marine_prop_03_15 = new ScenarioEntity<IScenery>(229, scenarioTag.WellKnownItems[229]);
            x02_marine_prop_03_16 = new ScenarioEntity<IScenery>(230, scenarioTag.WellKnownItems[230]);
            x02_marine_prop_03_17 = new ScenarioEntity<IScenery>(231, scenarioTag.WellKnownItems[231]);
            x02_marine_prop_03_18 = new ScenarioEntity<IScenery>(232, scenarioTag.WellKnownItems[232]);
            x02_marine_prop_03_19 = new ScenarioEntity<IScenery>(233, scenarioTag.WellKnownItems[233]);
            x02_marine_prop_03_20 = new ScenarioEntity<IScenery>(234, scenarioTag.WellKnownItems[234]);
            x02_marine_prop_03_21 = new ScenarioEntity<IScenery>(235, scenarioTag.WellKnownItems[235]);
            x02_marine_prop_03_22 = new ScenarioEntity<IScenery>(236, scenarioTag.WellKnownItems[236]);
            x02_marine_prop_03_23 = new ScenarioEntity<IScenery>(237, scenarioTag.WellKnownItems[237]);
            x02_marine_prop_03_24 = new ScenarioEntity<IScenery>(238, scenarioTag.WellKnownItems[238]);
            x02_marine_prop_03_25 = new ScenarioEntity<IScenery>(239, scenarioTag.WellKnownItems[239]);
            x02_marine_prop_03_26 = new ScenarioEntity<IScenery>(240, scenarioTag.WellKnownItems[240]);
            x02_marine_prop_03_27 = new ScenarioEntity<IScenery>(241, scenarioTag.WellKnownItems[241]);
            x02_marine_prop_03_28 = new ScenarioEntity<IScenery>(242, scenarioTag.WellKnownItems[242]);
            x02_marine_prop_03_29 = new ScenarioEntity<IScenery>(243, scenarioTag.WellKnownItems[243]);
            x02_marine_prop_03_30 = new ScenarioEntity<IScenery>(244, scenarioTag.WellKnownItems[244]);
            x02_marine_prop_03_31 = new ScenarioEntity<IScenery>(245, scenarioTag.WellKnownItems[245]);
            x02_marine_prop_03_32 = new ScenarioEntity<IScenery>(246, scenarioTag.WellKnownItems[246]);
            x02_marine_prop_03_33 = new ScenarioEntity<IScenery>(247, scenarioTag.WellKnownItems[247]);
            x02_marine_prop_03_34 = new ScenarioEntity<IScenery>(248, scenarioTag.WellKnownItems[248]);
            x02_marine_prop_03_35 = new ScenarioEntity<IScenery>(249, scenarioTag.WellKnownItems[249]);
            outro_elevator = new ScenarioEntity<IScenery>(250, scenarioTag.WellKnownItems[250]);
            beam_02 = new ScenarioEntity<IScenery>(251, scenarioTag.WellKnownItems[251]);
            beam_01 = new ScenarioEntity<IScenery>(252, scenarioTag.WellKnownItems[252]);
            _1st_door_blast = new ScenarioEntity<IScenery>(253, scenarioTag.WellKnownItems[253]);
            bloom_quad = new ScenarioEntity<IScenery>(254, scenarioTag.WellKnownItems[254]);
            airlock_debris_01 = new ScenarioEntity<IScenery>(255, scenarioTag.WellKnownItems[255]);
            x02_crowd_distant_01 = new ScenarioEntity<IScenery>(256, scenarioTag.WellKnownItems[256]);
            x02_crowd_distant_02 = new ScenarioEntity<IScenery>(257, scenarioTag.WellKnownItems[257]);
            x02_crowd_distant_03 = new ScenarioEntity<IScenery>(258, scenarioTag.WellKnownItems[258]);
            x02_crowd_distant_04 = new ScenarioEntity<IScenery>(259, scenarioTag.WellKnownItems[259]);
            x02_crowd_distant_05 = new ScenarioEntity<IScenery>(260, scenarioTag.WellKnownItems[260]);
            x02_crowd_distant_06 = new ScenarioEntity<IScenery>(261, scenarioTag.WellKnownItems[261]);
            x02_crowd_distant_07 = new ScenarioEntity<IScenery>(262, scenarioTag.WellKnownItems[262]);
            x02_crowd_distant_08 = new ScenarioEntity<IScenery>(263, scenarioTag.WellKnownItems[263]);
            x02_crowd_distant_09 = new ScenarioEntity<IScenery>(264, scenarioTag.WellKnownItems[264]);
            x02_crowd_distant_10 = new ScenarioEntity<IScenery>(265, scenarioTag.WellKnownItems[265]);
            x02_crowd_distant_11 = new ScenarioEntity<IScenery>(266, scenarioTag.WellKnownItems[266]);
            x02_crowd_distant_12 = new ScenarioEntity<IScenery>(267, scenarioTag.WellKnownItems[267]);
            x02_crowd_distant_13 = new ScenarioEntity<IScenery>(268, scenarioTag.WellKnownItems[268]);
            x02_crowd_distant_14 = new ScenarioEntity<IScenery>(269, scenarioTag.WellKnownItems[269]);
            x02_crowd_distant_15 = new ScenarioEntity<IScenery>(270, scenarioTag.WellKnownItems[270]);
            x02_crowd_distant_16 = new ScenarioEntity<IScenery>(271, scenarioTag.WellKnownItems[271]);
            x02_crowd_distant_17 = new ScenarioEntity<IScenery>(272, scenarioTag.WellKnownItems[272]);
            x02_crowd_distant_18 = new ScenarioEntity<IScenery>(273, scenarioTag.WellKnownItems[273]);
            x02_crowd_distant_19 = new ScenarioEntity<IScenery>(274, scenarioTag.WellKnownItems[274]);
            x02_crowd_distant_20 = new ScenarioEntity<IScenery>(275, scenarioTag.WellKnownItems[275]);
            x02_crowd_distant_21 = new ScenarioEntity<IScenery>(276, scenarioTag.WellKnownItems[276]);
            x02_crowd_distant_22 = new ScenarioEntity<IScenery>(277, scenarioTag.WellKnownItems[277]);
            x02_crowd_distant_23 = new ScenarioEntity<IScenery>(278, scenarioTag.WellKnownItems[278]);
            x02_crowd_distant_24 = new ScenarioEntity<IScenery>(279, scenarioTag.WellKnownItems[279]);
            x02_crowd_distant_25 = new ScenarioEntity<IScenery>(280, scenarioTag.WellKnownItems[280]);
            x02_crowd_distant_26 = new ScenarioEntity<IScenery>(281, scenarioTag.WellKnownItems[281]);
            x02_crowd_distant_27 = new ScenarioEntity<IScenery>(282, scenarioTag.WellKnownItems[282]);
            x02_crowd_distant_28 = new ScenarioEntity<IScenery>(283, scenarioTag.WellKnownItems[283]);
            x02_crowd_distant_29 = new ScenarioEntity<IScenery>(284, scenarioTag.WellKnownItems[284]);
            beam_start_01 = new ScenarioEntity<IScenery>(285, scenarioTag.WellKnownItems[285]);
            beam_start_02 = new ScenarioEntity<IScenery>(286, scenarioTag.WellKnownItems[286]);
            matte_earth = new ScenarioEntity<IScenery>(287, scenarioTag.WellKnownItems[287]);
            airlock_debris_02 = new ScenarioEntity<IScenery>(288, scenarioTag.WellKnownItems[288]);
            can_ice_cream = new ScenarioEntity<IBloc>(289, scenarioTag.WellKnownItems[289]);
            cov_crowd_01a_19 = new ScenarioEntity<IScenery>(290, scenarioTag.WellKnownItems[290]);
            outro_fighter_01 = new ScenarioEntity<IScenery>(291, scenarioTag.WellKnownItems[291]);
            outro_fighter_02 = new ScenarioEntity<IScenery>(292, scenarioTag.WellKnownItems[292]);
            outro_seraph = new ScenarioEntity<IScenery>(293, scenarioTag.WellKnownItems[293]);
            elevator_light_top = new ScenarioEntity<IScenery>(294, scenarioTag.WellKnownItems[294]);
            elevator_light_bottom = new ScenarioEntity<IScenery>(295, scenarioTag.WellKnownItems[295]);
            elevator_light_flash = new ScenarioEntity<IScenery>(296, scenarioTag.WellKnownItems[296]);
            gun_fleet = new ScenarioEntity<IScenery>(297, scenarioTag.WellKnownItems[297]);
            lvr_fleet = new ScenarioEntity<IScenery>(298, scenarioTag.WellKnownItems[298]);
            outro_fleet = new ScenarioEntity<IScenery>(299, scenarioTag.WellKnownItems[299]);
            offending_light = new ScenarioEntity<IScenery>(300, scenarioTag.WellKnownItems[300]);
            lvr_flyby_flag = new ScenarioEntity<IScenery>(301, scenarioTag.WellKnownItems[301]);
            blast_base = new ScenarioEntity<IScenery>(302, scenarioTag.WellKnownItems[302]);
            flyby = new ScenarioEntity<IScenery>(303, scenarioTag.WellKnownItems[303]);
            outro_cortana_base = new ScenarioEntity<IScenery>(304, scenarioTag.WellKnownItems[304]);
            chief = new ScenarioEntity<IUnit>(305, scenarioTag.WellKnownItems[305]);
            cortana = new ScenarioEntity<IUnit>(306, scenarioTag.WellKnownItems[306]);
            miranda = new ScenarioEntity<IUnit>(307, scenarioTag.WellKnownItems[307]);
            johnson = new ScenarioEntity<IUnit>(308, scenarioTag.WellKnownItems[308]);
            hood = new ScenarioEntity<IUnit>(309, scenarioTag.WellKnownItems[309]);
            hood_x02 = new ScenarioEntity<IUnit>(310, scenarioTag.WellKnownItems[310]);
            miranda_x02 = new ScenarioEntity<IUnit>(311, scenarioTag.WellKnownItems[311]);
            cortana_x02 = new ScenarioEntity<IUnit>(312, scenarioTag.WellKnownItems[312]);
            johnson_x02 = new ScenarioEntity<IUnit>(313, scenarioTag.WellKnownItems[313]);
            chief_x02 = new ScenarioEntity<IUnit>(314, scenarioTag.WellKnownItems[314]);
            tartarus = new ScenarioEntity<IUnit>(315, scenarioTag.WellKnownItems[315]);
            brute_01 = new ScenarioEntity<IUnit>(316, scenarioTag.WellKnownItems[316]);
            brute_02 = new ScenarioEntity<IUnit>(317, scenarioTag.WellKnownItems[317]);
            jackal_01 = new ScenarioEntity<IUnit>(318, scenarioTag.WellKnownItems[318]);
            jackal_02 = new ScenarioEntity<IUnit>(319, scenarioTag.WellKnownItems[319]);
            jackal_03 = new ScenarioEntity<IUnit>(320, scenarioTag.WellKnownItems[320]);
            grunt_01 = new ScenarioEntity<IUnit>(321, scenarioTag.WellKnownItems[321]);
            grunt_02 = new ScenarioEntity<IUnit>(322, scenarioTag.WellKnownItems[322]);
            grunt_03 = new ScenarioEntity<IUnit>(323, scenarioTag.WellKnownItems[323]);
            hunter_01 = new ScenarioEntity<IUnit>(324, scenarioTag.WellKnownItems[324]);
            hunter_02 = new ScenarioEntity<IUnit>(325, scenarioTag.WellKnownItems[325]);
            hunter_03 = new ScenarioEntity<IUnit>(326, scenarioTag.WellKnownItems[326]);
            dervish = new ScenarioEntity<IUnit>(327, scenarioTag.WellKnownItems[327]);
            marine_01 = new ScenarioEntity<IUnit>(328, scenarioTag.WellKnownItems[328]);
            marine_02 = new ScenarioEntity<IUnit>(329, scenarioTag.WellKnownItems[329]);
            marine_03 = new ScenarioEntity<IUnit>(330, scenarioTag.WellKnownItems[330]);
            marine_04 = new ScenarioEntity<IUnit>(331, scenarioTag.WellKnownItems[331]);
            marine_05 = new ScenarioEntity<IUnit>(332, scenarioTag.WellKnownItems[332]);
            marine_06 = new ScenarioEntity<IUnit>(333, scenarioTag.WellKnownItems[333]);
            marine_07 = new ScenarioEntity<IUnit>(334, scenarioTag.WellKnownItems[334]);
            marine_08 = new ScenarioEntity<IUnit>(335, scenarioTag.WellKnownItems[335]);
            johnson_x02_01 = new ScenarioEntity<IUnit>(336, scenarioTag.WellKnownItems[336]);
            chief_x02_01 = new ScenarioEntity<IUnit>(337, scenarioTag.WellKnownItems[337]);
            marine_x02_01 = new ScenarioEntity<IUnit>(338, scenarioTag.WellKnownItems[338]);
            marine_x02_02 = new ScenarioEntity<IUnit>(339, scenarioTag.WellKnownItems[339]);
            marine_x02_03 = new ScenarioEntity<IUnit>(340, scenarioTag.WellKnownItems[340]);
            marine_x02_04 = new ScenarioEntity<IUnit>(341, scenarioTag.WellKnownItems[341]);
            dervish_nude = new ScenarioEntity<IUnit>(342, scenarioTag.WellKnownItems[342]);
            marine_x02_05 = new ScenarioEntity<IUnit>(343, scenarioTag.WellKnownItems[343]);
            marine_x02_06 = new ScenarioEntity<IUnit>(344, scenarioTag.WellKnownItems[344]);
            marine_x02_07 = new ScenarioEntity<IUnit>(345, scenarioTag.WellKnownItems[345]);
            marine_x02_08 = new ScenarioEntity<IUnit>(346, scenarioTag.WellKnownItems[346]);
            marine_x02_12 = new ScenarioEntity<IUnit>(347, scenarioTag.WellKnownItems[347]);
            marine_x02_11 = new ScenarioEntity<IUnit>(348, scenarioTag.WellKnownItems[348]);
            marine_x02_10 = new ScenarioEntity<IUnit>(349, scenarioTag.WellKnownItems[349]);
            marine_x02_09 = new ScenarioEntity<IUnit>(350, scenarioTag.WellKnownItems[350]);
            marine_door_01 = new ScenarioEntity<IUnit>(351, scenarioTag.WellKnownItems[351]);
            marine_door_02 = new ScenarioEntity<IUnit>(352, scenarioTag.WellKnownItems[352]);
            marine_plant_01 = new ScenarioEntity<IUnit>(353, scenarioTag.WellKnownItems[353]);
            marine_plant_02 = new ScenarioEntity<IUnit>(354, scenarioTag.WellKnownItems[354]);
            marine_plant_03 = new ScenarioEntity<IUnit>(355, scenarioTag.WellKnownItems[355]);
            marine_plant_04 = new ScenarioEntity<IUnit>(356, scenarioTag.WellKnownItems[356]);
            marine_plant_05 = new ScenarioEntity<IUnit>(357, scenarioTag.WellKnownItems[357]);
            marine_plant_06 = new ScenarioEntity<IUnit>(358, scenarioTag.WellKnownItems[358]);
            marine_plant_07 = new ScenarioEntity<IUnit>(359, scenarioTag.WellKnownItems[359]);
            lvr_body_1 = new ScenarioEntity<IUnit>(360, scenarioTag.WellKnownItems[360]);
            lvr_body_2 = new ScenarioEntity<IUnit>(361, scenarioTag.WellKnownItems[361]);
            dck_hog1 = new ScenarioEntity<IVehicle>(362, scenarioTag.WellKnownItems[362]);
            bigrack_bsp0a_5_smg_1 = new ScenarioEntity<IWeapon>(363, scenarioTag.WellKnownItems[363]);
            bigrack_bsp0a_5_smg_2 = new ScenarioEntity<IWeapon>(364, scenarioTag.WellKnownItems[364]);
            bigrack_bsp0a_5_smg_3 = new ScenarioEntity<IWeapon>(365, scenarioTag.WellKnownItems[365]);
            rack_bsp3_1_br_1 = new ScenarioEntity<IWeapon>(366, scenarioTag.WellKnownItems[366]);
            rack_bsp3_1_br_2 = new ScenarioEntity<IWeapon>(367, scenarioTag.WellKnownItems[367]);
            rack_bsp3_2_smg_1 = new ScenarioEntity<IWeapon>(368, scenarioTag.WellKnownItems[368]);
            rack_bsp3_2_smg_2 = new ScenarioEntity<IWeapon>(369, scenarioTag.WellKnownItems[369]);
            rack_bsp3_4_br_1 = new ScenarioEntity<IWeapon>(370, scenarioTag.WellKnownItems[370]);
            rack_bsp3_4_br_2 = new ScenarioEntity<IWeapon>(371, scenarioTag.WellKnownItems[371]);
            rack_bsp3_5_smg_1 = new ScenarioEntity<IWeapon>(372, scenarioTag.WellKnownItems[372]);
            rack_bsp0b_1_br_1 = new ScenarioEntity<IWeapon>(373, scenarioTag.WellKnownItems[373]);
            rack_bsp0b_1_br_2 = new ScenarioEntity<IWeapon>(374, scenarioTag.WellKnownItems[374]);
            rack_bsp0b_2_smg_1 = new ScenarioEntity<IWeapon>(375, scenarioTag.WellKnownItems[375]);
            rack_bsp0b_2_smg_2 = new ScenarioEntity<IWeapon>(376, scenarioTag.WellKnownItems[376]);
            bigrack_bsp0b_1_br_1 = new ScenarioEntity<IWeapon>(377, scenarioTag.WellKnownItems[377]);
            bigrack_bsp0b_1_br_2 = new ScenarioEntity<IWeapon>(378, scenarioTag.WellKnownItems[378]);
            bigrack_bsp0b_2_br_1 = new ScenarioEntity<IWeapon>(379, scenarioTag.WellKnownItems[379]);
            bigrack_bsp0b_3_br_1 = new ScenarioEntity<IWeapon>(380, scenarioTag.WellKnownItems[380]);
            bigrack_bsp0b_3_br_2 = new ScenarioEntity<IWeapon>(381, scenarioTag.WellKnownItems[381]);
            bigrack_bsp0b_4_br_1 = new ScenarioEntity<IWeapon>(382, scenarioTag.WellKnownItems[382]);
            bigrack_bsp0b_5_smg_1 = new ScenarioEntity<IWeapon>(383, scenarioTag.WellKnownItems[383]);
            bigrack_bsp0b_6_smg_1 = new ScenarioEntity<IWeapon>(384, scenarioTag.WellKnownItems[384]);
            bigrack_bsp0b_6_smg_2 = new ScenarioEntity<IWeapon>(385, scenarioTag.WellKnownItems[385]);
            bigrack_bsp0b_7_smg_1 = new ScenarioEntity<IWeapon>(386, scenarioTag.WellKnownItems[386]);
            bigrack_bsp0b_8_smg_1 = new ScenarioEntity<IWeapon>(387, scenarioTag.WellKnownItems[387]);
            rack_bsp2_1_smg_1 = new ScenarioEntity<IWeapon>(388, scenarioTag.WellKnownItems[388]);
            rack_bsp2_1_smg_2 = new ScenarioEntity<IWeapon>(389, scenarioTag.WellKnownItems[389]);
            rack_bsp2_1_smg_3 = new ScenarioEntity<IWeapon>(390, scenarioTag.WellKnownItems[390]);
            rack_bsp0a_1_smg_1 = new ScenarioEntity<IWeapon>(391, scenarioTag.WellKnownItems[391]);
            rack_bsp0a_1_smg_2 = new ScenarioEntity<IWeapon>(392, scenarioTag.WellKnownItems[392]);
            rack_bsp0a_3_smg_1 = new ScenarioEntity<IWeapon>(393, scenarioTag.WellKnownItems[393]);
            rack_bsp0a_3_smg_2 = new ScenarioEntity<IWeapon>(394, scenarioTag.WellKnownItems[394]);
            rack_bsp0a_4_br_1 = new ScenarioEntity<IWeapon>(395, scenarioTag.WellKnownItems[395]);
            rack_bsp0a_4_br_2 = new ScenarioEntity<IWeapon>(396, scenarioTag.WellKnownItems[396]);
            rack_bsp0a_2_br_1 = new ScenarioEntity<IWeapon>(397, scenarioTag.WellKnownItems[397]);
            rack_bsp0a_2_br_2 = new ScenarioEntity<IWeapon>(398, scenarioTag.WellKnownItems[398]);
            bigrack_bsp0a_6_smg_1 = new ScenarioEntity<IWeapon>(399, scenarioTag.WellKnownItems[399]);
            bigrack_bsp0a_6_smg_2 = new ScenarioEntity<IWeapon>(400, scenarioTag.WellKnownItems[400]);
            rack_bsp0a_5_smg_1 = new ScenarioEntity<IWeapon>(401, scenarioTag.WellKnownItems[401]);
            rack_bsp0a_5_smg_2 = new ScenarioEntity<IWeapon>(402, scenarioTag.WellKnownItems[402]);
            rack_bsp0a_5_smg_3 = new ScenarioEntity<IWeapon>(403, scenarioTag.WellKnownItems[403]);
            rack_bsp0a_6_br_1 = new ScenarioEntity<IWeapon>(404, scenarioTag.WellKnownItems[404]);
            rack_bsp0a_6_br_2 = new ScenarioEntity<IWeapon>(405, scenarioTag.WellKnownItems[405]);
            rack_bsp0a_6_br_3 = new ScenarioEntity<IWeapon>(406, scenarioTag.WellKnownItems[406]);
            yorick = new ScenarioEntity<IWeapon>(407, scenarioTag.WellKnownItems[407]);
            tram = new ScenarioEntity<IDevice>(408, scenarioTag.WellKnownItems[408]);
            elv_elevator_control_2 = new ScenarioEntity<IDevice>(409, scenarioTag.WellKnownItems[409]);
            gun_elevator = new ScenarioEntity<IDevice>(410, scenarioTag.WellKnownItems[410]);
            capital_1 = new ScenarioEntity<IDevice>(411, scenarioTag.WellKnownItems[411]);
            macgun = new ScenarioEntity<IDevice>(412, scenarioTag.WellKnownItems[412]);
            elv_elevator = new ScenarioEntity<IDevice>(413, scenarioTag.WellKnownItems[413]);
            dck_hog_rail = new ScenarioEntity<IDevice>(414, scenarioTag.WellKnownItems[414]);
            bay2_door_exit_1 = new ScenarioEntity<IDevice>(415, scenarioTag.WellKnownItems[415]);
            bay2_door_exit_2 = new ScenarioEntity<IDevice>(416, scenarioTag.WellKnownItems[416]);
            atr2_door_re = new ScenarioEntity<IDevice>(417, scenarioTag.WellKnownItems[417]);
            bsp2_door_forward = new ScenarioEntity<IDevice>(418, scenarioTag.WellKnownItems[418]);
            bsp2_door_back = new ScenarioEntity<IDevice>(419, scenarioTag.WellKnownItems[419]);
            bsp3_door_forward = new ScenarioEntity<IDevice>(420, scenarioTag.WellKnownItems[420]);
            bsp3_door_backward = new ScenarioEntity<IDevice>(421, scenarioTag.WellKnownItems[421]);
            blam = new ScenarioEntity<IDevice>(422, scenarioTag.WellKnownItems[422]);
            bay1_door_exit = new ScenarioEntity<IDevice>(423, scenarioTag.WellKnownItems[423]);
            lvr_door_enter_1 = new ScenarioEntity<IDevice>(424, scenarioTag.WellKnownItems[424]);
            lvr_door_enter_2 = new ScenarioEntity<IDevice>(425, scenarioTag.WellKnownItems[425]);
            arm_door_exit = new ScenarioEntity<IDevice>(426, scenarioTag.WellKnownItems[426]);
            gun_elevator_door_top = new ScenarioEntity<IDevice>(427, scenarioTag.WellKnownItems[427]);
            outro_door_01 = new ScenarioEntity<IDevice>(428, scenarioTag.WellKnownItems[428]);
            outro_door_02 = new ScenarioEntity<IDevice>(429, scenarioTag.WellKnownItems[429]);
            outro_door_03 = new ScenarioEntity<IDevice>(430, scenarioTag.WellKnownItems[430]);
            outro_lever = new ScenarioEntity<IDevice>(431, scenarioTag.WellKnownItems[431]);
            elv_elevator_control_1 = new ScenarioEntity<IDevice>(432, scenarioTag.WellKnownItems[432]);
            bsp3_door_backward_2 = new ScenarioEntity<IDevice>(433, scenarioTag.WellKnownItems[433]);
            lvr_airlock_blower = new ScenarioEntity<IDevice>(434, scenarioTag.WellKnownItems[434]);
            capital_2 = new ScenarioEntity<IDevice>(435, scenarioTag.WellKnownItems[435]);
            _1st_door_enter = new ScenarioEntity<IDevice>(436, scenarioTag.WellKnownItems[436]);
            lvr_wall_enter = new ScenarioEntity<IDevice>(437, scenarioTag.WellKnownItems[437]);
            gun_wall_enter = new ScenarioEntity<IDevice>(438, scenarioTag.WellKnownItems[438]);
            dck_door_arm_2 = new ScenarioEntity<IDevice>(439, scenarioTag.WellKnownItems[439]);
            dck_door_arm_1 = new ScenarioEntity<IDevice>(440, scenarioTag.WellKnownItems[440]);
            dck_wall_enter = new ScenarioEntity<IDevice>(441, scenarioTag.WellKnownItems[441]);
            trm1_tram = new ScenarioEntity<IDevice>(442, scenarioTag.WellKnownItems[442]);
            rack_bsp3_2 = new ScenarioEntity<IDevice>(443, scenarioTag.WellKnownItems[443]);
            rack_bsp3_1 = new ScenarioEntity<IDevice>(444, scenarioTag.WellKnownItems[444]);
            arm_door_charger_1 = new ScenarioEntity<IDevice>(445, scenarioTag.WellKnownItems[445]);
            arm_door_charger_2 = new ScenarioEntity<IDevice>(446, scenarioTag.WellKnownItems[446]);
            rack_bsp3_4 = new ScenarioEntity<IDevice>(447, scenarioTag.WellKnownItems[447]);
            rack_bsp3_5 = new ScenarioEntity<IDevice>(448, scenarioTag.WellKnownItems[448]);
            rack_bsp0b_1 = new ScenarioEntity<IDevice>(449, scenarioTag.WellKnownItems[449]);
            rack_bsp0b_2 = new ScenarioEntity<IDevice>(450, scenarioTag.WellKnownItems[450]);
            bigrack_bsp0b_1 = new ScenarioEntity<IDevice>(451, scenarioTag.WellKnownItems[451]);
            bigrack_bsp0b_2 = new ScenarioEntity<IDevice>(452, scenarioTag.WellKnownItems[452]);
            bigrack_bsp0b_3 = new ScenarioEntity<IDevice>(453, scenarioTag.WellKnownItems[453]);
            bigrack_bsp0b_4 = new ScenarioEntity<IDevice>(454, scenarioTag.WellKnownItems[454]);
            bigrack_bsp0b_8 = new ScenarioEntity<IDevice>(455, scenarioTag.WellKnownItems[455]);
            bigrack_bsp0b_7 = new ScenarioEntity<IDevice>(456, scenarioTag.WellKnownItems[456]);
            bigrack_bsp0b_6 = new ScenarioEntity<IDevice>(457, scenarioTag.WellKnownItems[457]);
            bigrack_bsp0b_5 = new ScenarioEntity<IDevice>(458, scenarioTag.WellKnownItems[458]);
            rack_bsp2_1 = new ScenarioEntity<IDevice>(459, scenarioTag.WellKnownItems[459]);
            rack_bsp0a_1 = new ScenarioEntity<IDevice>(460, scenarioTag.WellKnownItems[460]);
            rack_bsp0a_2 = new ScenarioEntity<IDevice>(461, scenarioTag.WellKnownItems[461]);
            rack_bsp0a_3 = new ScenarioEntity<IDevice>(462, scenarioTag.WellKnownItems[462]);
            rack_bsp0a_4 = new ScenarioEntity<IDevice>(463, scenarioTag.WellKnownItems[463]);
            bigrack_bsp0a_5 = new ScenarioEntity<IDevice>(464, scenarioTag.WellKnownItems[464]);
            bigrack_bsp0a_6 = new ScenarioEntity<IDevice>(465, scenarioTag.WellKnownItems[465]);
            _1st_door_top = new ScenarioEntity<IDevice>(466, scenarioTag.WellKnownItems[466]);
            _1st_craft = new ScenarioEntity<IDevice>(467, scenarioTag.WellKnownItems[467]);
            rack_bsp0a_5 = new ScenarioEntity<IDevice>(468, scenarioTag.WellKnownItems[468]);
            rack_bsp0a_6 = new ScenarioEntity<IDevice>(469, scenarioTag.WellKnownItems[469]);
            _1st_door_tram = new ScenarioEntity<IDevice>(470, scenarioTag.WellKnownItems[470]);
            gun_loader = new ScenarioEntity<IDevice>(471, scenarioTag.WellKnownItems[471]);
            x02_door_02 = new ScenarioEntity<IDevice>(472, scenarioTag.WellKnownItems[472]);
            x02_dervish_lift = new ScenarioEntity<IDevice>(473, scenarioTag.WellKnownItems[473]);
            x02_bridge_door = new ScenarioEntity<IDevice>(474, scenarioTag.WellKnownItems[474]);
            bay2_wall_exit_2 = new ScenarioEntity<IDevice>(475, scenarioTag.WellKnownItems[475]);
            _1st_tram_wall_1 = new ScenarioEntity<IDevice>(476, scenarioTag.WellKnownItems[476]);
            _1st_tram_wall_2 = new ScenarioEntity<IDevice>(477, scenarioTag.WellKnownItems[477]);
            bay2_wall_exit_1 = new ScenarioEntity<IDevice>(478, scenarioTag.WellKnownItems[478]);
            atr1_elevator = new ScenarioEntity<IDevice>(479, scenarioTag.WellKnownItems[479]);
            trm1_door_exit = new ScenarioEntity<IDevice>(480, scenarioTag.WellKnownItems[480]);
            _1st_hum_johnson = new Squad__1st_hum_johnson(scenarioTag);
            _1st_hum_floor_mar = new Squad__1st_hum_floor_mar(scenarioTag);
            _1st_hum_balcony_mar = new Squad__1st_hum_balcony_mar(scenarioTag);
            _1st_hum_stairs_mar = new Squad__1st_hum_stairs_mar(scenarioTag);
            _1st_hum_stairs_hmp = new Squad__1st_hum_stairs_hmp(scenarioTag);
            _1st_hum_tram = new Squad__1st_hum_tram(scenarioTag);
            _1st_cov_wv1_grt = new Squad__1st_cov_wv1_grt(scenarioTag);
            _1st_cov_wv1_elt = new Squad__1st_cov_wv1_elt(scenarioTag);
            _1st_cov_wv2_grt = new Squad__1st_cov_wv2_grt(scenarioTag);
            _1st_cov_wv2_elt = new Squad__1st_cov_wv2_elt(scenarioTag);
            _1st_cov_wv3_grt = new Squad__1st_cov_wv3_grt(scenarioTag);
            _1st_cov_wv3_elt = new Squad__1st_cov_wv3_elt(scenarioTag);
            _1st_cov_wv3_cmp = new Squad__1st_cov_wv3_cmp(scenarioTag);
            _1st_cov_wv4_grt = new Squad__1st_cov_wv4_grt(scenarioTag);
            _1st_cov_wv4_cmp = new Squad__1st_cov_wv4_cmp(scenarioTag);
            _1st_cov_wv4_elt = new Squad__1st_cov_wv4_elt(scenarioTag);
            _1st_cov_hall_elt = new Squad__1st_cov_hall_elt(scenarioTag);
            _1st_cov_hall_grt = new Squad__1st_cov_hall_grt(scenarioTag);
            atr2_hum_security_mrn = new Squad_atr2_hum_security_mrn(scenarioTag);
            atr2_hum_security_hmp = new Squad_atr2_hum_security_hmp(scenarioTag);
            atr2_hum_floor_mar = new Squad_atr2_hum_floor_mar(scenarioTag);
            atr2_cov_floor_elt = new Squad_atr2_cov_floor_elt(scenarioTag);
            atr2_cov_floor_grt = new Squad_atr2_cov_floor_grt(scenarioTag);
            atr2_cov_fbalcony_elt = new Squad_atr2_cov_fbalcony_elt(scenarioTag);
            atr2_cov_fbalcony_grt = new Squad_atr2_cov_fbalcony_grt(scenarioTag);
            atr2_cov_lstair_elt = new Squad_atr2_cov_lstair_elt(scenarioTag);
            atr2_cov_lstair_grt = new Squad_atr2_cov_lstair_grt(scenarioTag);
            atr2_cov_lstair_rear_elt = new Squad_atr2_cov_lstair_rear_elt(scenarioTag);
            atr2_cov_lstair_rear_grt = new Squad_atr2_cov_lstair_rear_grt(scenarioTag);
            atr2_cov_bbalcony_grt = new Squad_atr2_cov_bbalcony_grt(scenarioTag);
            atr2_cov_re_floor_elt = new Squad_atr2_cov_re_floor_elt(scenarioTag);
            atr2_cov_re_floor_grt = new Squad_atr2_cov_re_floor_grt(scenarioTag);
            atr2_cov_fnl_grt = new Squad_atr2_cov_fnl_grt(scenarioTag);
            atr2_cov_fnl_elt = new Squad_atr2_cov_fnl_elt(scenarioTag);
            bay1_hum_floor_mar = new Squad_bay1_hum_floor_mar(scenarioTag);
            bay1_hum_catwalk_mar = new Squad_bay1_hum_catwalk_mar(scenarioTag);
            bay1_hum_catwalk_hmp = new Squad_bay1_hum_catwalk_hmp(scenarioTag);
            bay1_cov_floor_elt = new Squad_bay1_cov_floor_elt(scenarioTag);
            bay1_cov_floor_grt = new Squad_bay1_cov_floor_grt(scenarioTag);
            bay1_cov_wv2_elt = new Squad_bay1_cov_wv2_elt(scenarioTag);
            bay1_cov_wv2_grt = new Squad_bay1_cov_wv2_grt(scenarioTag);
            bay1_cov_wv3_elt = new Squad_bay1_cov_wv3_elt(scenarioTag);
            bay1_cov_wv3_grt = new Squad_bay1_cov_wv3_grt(scenarioTag);
            bay1_cov_wv4_elt = new Squad_bay1_cov_wv4_elt(scenarioTag);
            bay1_cov_wv4_grt = new Squad_bay1_cov_wv4_grt(scenarioTag);
            bay1_cov_fnl_elt = new Squad_bay1_cov_fnl_elt(scenarioTag);
            bay1_cov_fnl_grt = new Squad_bay1_cov_fnl_grt(scenarioTag);
            bay2_hum_mar = new Squad_bay2_hum_mar(scenarioTag);
            bay2_cov_floor_elt = new Squad_bay2_cov_floor_elt(scenarioTag);
            bay2_cov_floor_grt = new Squad_bay2_cov_floor_grt(scenarioTag);
            bay2_cov_catwalk_grt = new Squad_bay2_cov_catwalk_grt(scenarioTag);
            bay2_cov_catwalk_cmp = new Squad_bay2_cov_catwalk_cmp(scenarioTag);
            bay2_cov_wv2_elt = new Squad_bay2_cov_wv2_elt(scenarioTag);
            bay2_cov_wv2_grt = new Squad_bay2_cov_wv2_grt(scenarioTag);
            bay2_cov_wv3_elt = new Squad_bay2_cov_wv3_elt(scenarioTag);
            bay2_cov_wv3_grt = new Squad_bay2_cov_wv3_grt(scenarioTag);
            bay2_cov_wv4_elt = new Squad_bay2_cov_wv4_elt(scenarioTag);
            bay2_cov_wv4_grt = new Squad_bay2_cov_wv4_grt(scenarioTag);
            bay2_cov_fnl_grt = new Squad_bay2_cov_fnl_grt(scenarioTag);
            bay2_cov_fnl_elt = new Squad_bay2_cov_fnl_elt(scenarioTag);
            arm_cov_stl = new Squad_arm_cov_stl(scenarioTag);
            arm_hum_guns = new Squad_arm_hum_guns(scenarioTag);
            arm_cov_elt = new Squad_arm_cov_elt(scenarioTag);
            atr1_floor_grt = new Squad_atr1_floor_grt(scenarioTag);
            atr1_cov_fbalcony_cmp = new Squad_atr1_cov_fbalcony_cmp(scenarioTag);
            atr1_cov_fbalcony_elite = new Squad_atr1_cov_fbalcony_elite(scenarioTag);
            atr1_cov_bbalcony_cmp = new Squad_atr1_cov_bbalcony_cmp(scenarioTag);
            atr1_cov_bbalcony_elt = new Squad_atr1_cov_bbalcony_elt(scenarioTag);
            atr1_cov_sec_front_cmp = new Squad_atr1_cov_sec_front_cmp(scenarioTag);
            atr1_cov_stairs_front_cmp = new Squad_atr1_cov_stairs_front_cmp(scenarioTag);
            atr1_cov_stairs_front_grt = new Squad_atr1_cov_stairs_front_grt(scenarioTag);
            atr1_cov_stairs_front_elt = new Squad_atr1_cov_stairs_front_elt(scenarioTag);
            atr1_cov_stairs_back_elt = new Squad_atr1_cov_stairs_back_elt(scenarioTag);
            atr1_cov_sec_back_cmp = new Squad_atr1_cov_sec_back_cmp(scenarioTag);
            atr1_cov_sec_back_grt = new Squad_atr1_cov_sec_back_grt(scenarioTag);
            atr1_cov_sec_back_elt = new Squad_atr1_cov_sec_back_elt(scenarioTag);
            atr1_cov_bfloor_grt = new Squad_atr1_cov_bfloor_grt(scenarioTag);
            trm1_hum_johnson = new Squad_trm1_hum_johnson(scenarioTag);
            trm1_hum_miranda = new Squad_trm1_hum_miranda(scenarioTag);
            trm1_hum_alock_mar = new Squad_trm1_hum_alock_mar(scenarioTag);
            trm1_hum_block_mar = new Squad_trm1_hum_block_mar(scenarioTag);
            trm1_cov_alock_elt = new Squad_trm1_cov_alock_elt(scenarioTag);
            trm1_cov_alock_grt = new Squad_trm1_cov_alock_grt(scenarioTag);
            trm1_cov_block_elt = new Squad_trm1_cov_block_elt(scenarioTag);
            trm1_cov_block_grt = new Squad_trm1_cov_block_grt(scenarioTag);
            dck_cov_enter_elt = new Squad_dck_cov_enter_elt(scenarioTag);
            dck_cov_arm1_elt = new Squad_dck_cov_arm1_elt(scenarioTag);
            dck_cov_mid_elt = new Squad_dck_cov_mid_elt(scenarioTag);
            dck_cov_arm2_elt = new Squad_dck_cov_arm2_elt(scenarioTag);
            elv_cov_floor_bgr = new Squad_elv_cov_floor_bgr(scenarioTag);
            elv_cov_stairs_left_bgr = new Squad_elv_cov_stairs_left_bgr(scenarioTag);
            elv_cov_stairs_right_bgr = new Squad_elv_cov_stairs_right_bgr(scenarioTag);
            elv_cov_elevator_elt = new Squad_elv_cov_elevator_elt(scenarioTag);
            elv_cov_elevator_grt = new Squad_elv_cov_elevator_grt(scenarioTag);
            lvr_cov_wv1_cmp = new Squad_lvr_cov_wv1_cmp(scenarioTag);
            lvr_cov_wv1_elt = new Squad_lvr_cov_wv1_elt(scenarioTag);
            lvr_cov_wv2_elt = new Squad_lvr_cov_wv2_elt(scenarioTag);
            gun_cov_elt_a = new Squad_gun_cov_elt_a(scenarioTag);
            gun_cov_grt_a = new Squad_gun_cov_grt_a(scenarioTag);
            gun_cov_elt_b = new Squad_gun_cov_elt_b(scenarioTag);
            gun_cov_elt_c = new Squad_gun_cov_elt_c(scenarioTag);
            gun_cov_elt_d = new Squad_gun_cov_elt_d(scenarioTag);
            gun_hum_mar = new Squad_gun_hum_mar(scenarioTag);
            gun_cortana_1 = new Squad_gun_cortana_1(scenarioTag);
            gun_cortana_2 = new Squad_gun_cortana_2(scenarioTag);
            gun_cortana_3 = new Squad_gun_cortana_3(scenarioTag);
            gun_cortana_4 = new Squad_gun_cortana_4(scenarioTag);
            elv_hum_mar = new Squad_elv_hum_mar(scenarioTag);
            x02_panic_01 = new Squad_x02_panic_01(scenarioTag);
            x02_panic_02 = new Squad_x02_panic_02(scenarioTag);
            x02_panic_03 = new Squad_x02_panic_03(scenarioTag);
            x02_panic_04 = new Squad_x02_panic_04(scenarioTag);
            bay1_cov_wv5_grt = new Squad_bay1_cov_wv5_grt(scenarioTag);
            bay1_cov_wv5_elt = new Squad_bay1_cov_wv5_elt(scenarioTag);
            bay2_cov_wv5_grt = new Squad_bay2_cov_wv5_grt(scenarioTag);
            bay2_cov_wv5_elt = new Squad_bay2_cov_wv5_elt(scenarioTag);
            lvr_cov_air1 = new Squad_lvr_cov_air1(scenarioTag);
        }
    }
}