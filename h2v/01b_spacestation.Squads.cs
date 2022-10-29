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
        public Squad__1st_hum_johnson _1st_hum_johnson { get; set; }
        public Squad__1st_hum_floor_mar _1st_hum_floor_mar { get; set; }
        public Squad__1st_hum_balcony_mar _1st_hum_balcony_mar { get; set; }
        public Squad__1st_hum_stairs_mar _1st_hum_stairs_mar { get; set; }
        public Squad__1st_hum_stairs_hmp _1st_hum_stairs_hmp { get; set; }
        public Squad__1st_hum_tram _1st_hum_tram { get; set; }
        public Squad__1st_cov_wv1_grt _1st_cov_wv1_grt { get; set; }
        public Squad__1st_cov_wv1_elt _1st_cov_wv1_elt { get; set; }
        public Squad__1st_cov_wv2_grt _1st_cov_wv2_grt { get; set; }
        public Squad__1st_cov_wv2_elt _1st_cov_wv2_elt { get; set; }
        public Squad__1st_cov_wv3_grt _1st_cov_wv3_grt { get; set; }
        public Squad__1st_cov_wv3_elt _1st_cov_wv3_elt { get; set; }
        public Squad__1st_cov_wv3_cmp _1st_cov_wv3_cmp { get; set; }
        public Squad__1st_cov_wv4_grt _1st_cov_wv4_grt { get; set; }
        public Squad__1st_cov_wv4_cmp _1st_cov_wv4_cmp { get; set; }
        public Squad__1st_cov_wv4_elt _1st_cov_wv4_elt { get; set; }
        public Squad__1st_cov_hall_elt _1st_cov_hall_elt { get; set; }
        public Squad__1st_cov_hall_grt _1st_cov_hall_grt { get; set; }
        public Squad_atr2_hum_security_mrn atr2_hum_security_mrn { get; set; }
        public Squad_atr2_hum_security_hmp atr2_hum_security_hmp { get; set; }
        public Squad_atr2_hum_floor_mar atr2_hum_floor_mar { get; set; }
        public Squad_atr2_cov_floor_elt atr2_cov_floor_elt { get; set; }
        public Squad_atr2_cov_floor_grt atr2_cov_floor_grt { get; set; }
        public Squad_atr2_cov_fbalcony_elt atr2_cov_fbalcony_elt { get; set; }
        public Squad_atr2_cov_fbalcony_grt atr2_cov_fbalcony_grt { get; set; }
        public Squad_atr2_cov_lstair_elt atr2_cov_lstair_elt { get; set; }
        public Squad_atr2_cov_lstair_grt atr2_cov_lstair_grt { get; set; }
        public Squad_atr2_cov_lstair_rear_elt atr2_cov_lstair_rear_elt { get; set; }
        public Squad_atr2_cov_lstair_rear_grt atr2_cov_lstair_rear_grt { get; set; }
        public Squad_atr2_cov_bbalcony_grt atr2_cov_bbalcony_grt { get; set; }
        public Squad_atr2_cov_re_floor_elt atr2_cov_re_floor_elt { get; set; }
        public Squad_atr2_cov_re_floor_grt atr2_cov_re_floor_grt { get; set; }
        public Squad_atr2_cov_fnl_grt atr2_cov_fnl_grt { get; set; }
        public Squad_atr2_cov_fnl_elt atr2_cov_fnl_elt { get; set; }
        public Squad_bay1_hum_floor_mar bay1_hum_floor_mar { get; set; }
        public Squad_bay1_hum_catwalk_mar bay1_hum_catwalk_mar { get; set; }
        public Squad_bay1_hum_catwalk_hmp bay1_hum_catwalk_hmp { get; set; }
        public Squad_bay1_cov_floor_elt bay1_cov_floor_elt { get; set; }
        public Squad_bay1_cov_floor_grt bay1_cov_floor_grt { get; set; }
        public Squad_bay1_cov_wv2_elt bay1_cov_wv2_elt { get; set; }
        public Squad_bay1_cov_wv2_grt bay1_cov_wv2_grt { get; set; }
        public Squad_bay1_cov_wv3_elt bay1_cov_wv3_elt { get; set; }
        public Squad_bay1_cov_wv3_grt bay1_cov_wv3_grt { get; set; }
        public Squad_bay1_cov_wv4_elt bay1_cov_wv4_elt { get; set; }
        public Squad_bay1_cov_wv4_grt bay1_cov_wv4_grt { get; set; }
        public Squad_bay1_cov_fnl_elt bay1_cov_fnl_elt { get; set; }
        public Squad_bay1_cov_fnl_grt bay1_cov_fnl_grt { get; set; }
        public Squad_bay2_hum_mar bay2_hum_mar { get; set; }
        public Squad_bay2_cov_floor_elt bay2_cov_floor_elt { get; set; }
        public Squad_bay2_cov_floor_grt bay2_cov_floor_grt { get; set; }
        public Squad_bay2_cov_catwalk_grt bay2_cov_catwalk_grt { get; set; }
        public Squad_bay2_cov_catwalk_cmp bay2_cov_catwalk_cmp { get; set; }
        public Squad_bay2_cov_wv2_elt bay2_cov_wv2_elt { get; set; }
        public Squad_bay2_cov_wv2_grt bay2_cov_wv2_grt { get; set; }
        public Squad_bay2_cov_wv3_elt bay2_cov_wv3_elt { get; set; }
        public Squad_bay2_cov_wv3_grt bay2_cov_wv3_grt { get; set; }
        public Squad_bay2_cov_wv4_elt bay2_cov_wv4_elt { get; set; }
        public Squad_bay2_cov_wv4_grt bay2_cov_wv4_grt { get; set; }
        public Squad_bay2_cov_fnl_grt bay2_cov_fnl_grt { get; set; }
        public Squad_bay2_cov_fnl_elt bay2_cov_fnl_elt { get; set; }
        public Squad_arm_cov_stl arm_cov_stl { get; set; }
        public Squad_arm_hum_guns arm_hum_guns { get; set; }
        public Squad_arm_cov_elt arm_cov_elt { get; set; }
        public Squad_atr1_floor_grt atr1_floor_grt { get; set; }
        public Squad_atr1_cov_fbalcony_cmp atr1_cov_fbalcony_cmp { get; set; }
        public Squad_atr1_cov_fbalcony_elite atr1_cov_fbalcony_elite { get; set; }
        public Squad_atr1_cov_bbalcony_cmp atr1_cov_bbalcony_cmp { get; set; }
        public Squad_atr1_cov_bbalcony_elt atr1_cov_bbalcony_elt { get; set; }
        public Squad_atr1_cov_sec_front_cmp atr1_cov_sec_front_cmp { get; set; }
        public Squad_atr1_cov_stairs_front_cmp atr1_cov_stairs_front_cmp { get; set; }
        public Squad_atr1_cov_stairs_front_grt atr1_cov_stairs_front_grt { get; set; }
        public Squad_atr1_cov_stairs_front_elt atr1_cov_stairs_front_elt { get; set; }
        public Squad_atr1_cov_stairs_back_elt atr1_cov_stairs_back_elt { get; set; }
        public Squad_atr1_cov_sec_back_cmp atr1_cov_sec_back_cmp { get; set; }
        public Squad_atr1_cov_sec_back_grt atr1_cov_sec_back_grt { get; set; }
        public Squad_atr1_cov_sec_back_elt atr1_cov_sec_back_elt { get; set; }
        public Squad_atr1_cov_bfloor_grt atr1_cov_bfloor_grt { get; set; }
        public Squad_trm1_hum_johnson trm1_hum_johnson { get; set; }
        public Squad_trm1_hum_miranda trm1_hum_miranda { get; set; }
        public Squad_trm1_hum_alock_mar trm1_hum_alock_mar { get; set; }
        public Squad_trm1_hum_block_mar trm1_hum_block_mar { get; set; }
        public Squad_trm1_cov_alock_elt trm1_cov_alock_elt { get; set; }
        public Squad_trm1_cov_alock_grt trm1_cov_alock_grt { get; set; }
        public Squad_trm1_cov_block_elt trm1_cov_block_elt { get; set; }
        public Squad_trm1_cov_block_grt trm1_cov_block_grt { get; set; }
        public Squad_dck_cov_enter_elt dck_cov_enter_elt { get; set; }
        public Squad_dck_cov_arm1_elt dck_cov_arm1_elt { get; set; }
        public Squad_dck_cov_mid_elt dck_cov_mid_elt { get; set; }
        public Squad_dck_cov_arm2_elt dck_cov_arm2_elt { get; set; }
        public Squad_elv_cov_floor_bgr elv_cov_floor_bgr { get; set; }
        public Squad_elv_cov_stairs_left_bgr elv_cov_stairs_left_bgr { get; set; }
        public Squad_elv_cov_stairs_right_bgr elv_cov_stairs_right_bgr { get; set; }
        public Squad_elv_cov_elevator_elt elv_cov_elevator_elt { get; set; }
        public Squad_elv_cov_elevator_grt elv_cov_elevator_grt { get; set; }
        public Squad_lvr_cov_wv1_cmp lvr_cov_wv1_cmp { get; set; }
        public Squad_lvr_cov_wv1_elt lvr_cov_wv1_elt { get; set; }
        public Squad_lvr_cov_wv2_elt lvr_cov_wv2_elt { get; set; }
        public Squad_gun_cov_elt_a gun_cov_elt_a { get; set; }
        public Squad_gun_cov_grt_a gun_cov_grt_a { get; set; }
        public Squad_gun_cov_elt_b gun_cov_elt_b { get; set; }
        public Squad_gun_cov_elt_c gun_cov_elt_c { get; set; }
        public Squad_gun_cov_elt_d gun_cov_elt_d { get; set; }
        public Squad_gun_hum_mar gun_hum_mar { get; set; }
        public Squad_gun_cortana_1 gun_cortana_1 { get; set; }
        public Squad_gun_cortana_2 gun_cortana_2 { get; set; }
        public Squad_gun_cortana_3 gun_cortana_3 { get; set; }
        public Squad_gun_cortana_4 gun_cortana_4 { get; set; }
        public Squad_elv_hum_mar elv_hum_mar { get; set; }
        public Squad_x02_panic_01 x02_panic_01 { get; set; }
        public Squad_x02_panic_02 x02_panic_02 { get; set; }
        public Squad_x02_panic_03 x02_panic_03 { get; set; }
        public Squad_x02_panic_04 x02_panic_04 { get; set; }
        public Squad_bay1_cov_wv5_grt bay1_cov_wv5_grt { get; set; }
        public Squad_bay1_cov_wv5_elt bay1_cov_wv5_elt { get; set; }
        public Squad_bay2_cov_wv5_grt bay2_cov_wv5_grt { get; set; }
        public Squad_bay2_cov_wv5_elt bay2_cov_wv5_elt { get; set; }
        public Squad_lvr_cov_air1 lvr_cov_air1 { get; set; }
        [SpawnCounts(1, 1)]
        public class Squad__1st_hum_johnson : SquadBase
        {
            public IAiActorDefinition johnson => Squad.StartingLocations[0];
            public Squad__1st_hum_johnson(ScenarioTag ScenarioTag) : base(ScenarioTag, 0, "_1st_hum_balcony")
            {
            }
        }

        [SpawnCounts(3, 2)]
        public class Squad__1st_hum_floor_mar : SquadBase
        {
            public IAiActorDefinition starting_locations_0 => Squad.StartingLocations[0];
            public IAiActorDefinition starting_locations_1 => Squad.StartingLocations[1];
            public IAiActorDefinition starting_locations_2 => Squad.StartingLocations[2];
            public Squad__1st_hum_floor_mar(ScenarioTag ScenarioTag) : base(ScenarioTag, 1, "_1st_hum_floor")
            {
            }
        }

        [SpawnCounts(1, 1)]
        public class Squad__1st_hum_balcony_mar : SquadBase
        {
            public IAiActorDefinition starting_locations_0 => Squad.StartingLocations[0];
            public IAiActorDefinition starting_locations_1 => Squad.StartingLocations[1];
            public IAiActorDefinition starting_locations_2 => Squad.StartingLocations[2];
            public Squad__1st_hum_balcony_mar(ScenarioTag ScenarioTag) : base(ScenarioTag, 2, "_1st_hum_balcony")
            {
            }
        }

        [SpawnCounts(0, 0)]
        public class Squad__1st_hum_stairs_mar : SquadBase
        {
            public IAiActorDefinition starting_locations_0 => Squad.StartingLocations[0];
            public Squad__1st_hum_stairs_mar(ScenarioTag ScenarioTag) : base(ScenarioTag, 3, "_1st_hum_stairs")
            {
            }
        }

        [SpawnCounts(1, 1)]
        public class Squad__1st_hum_stairs_hmp : SquadBase
        {
            public IAiActorDefinition starting_locations_0 => Squad.StartingLocations[0];
            public Squad__1st_hum_stairs_hmp(ScenarioTag ScenarioTag) : base(ScenarioTag, 4, "_1st_hum_stairs")
            {
            }
        }

        [SpawnCounts(3, 3)]
        public class Squad__1st_hum_tram : SquadBase
        {
            public IAiActorDefinition starting_locations_0 => Squad.StartingLocations[0];
            public IAiActorDefinition starting_locations_1 => Squad.StartingLocations[1];
            public IAiActorDefinition starting_locations_2 => Squad.StartingLocations[2];
            public Squad__1st_hum_tram(ScenarioTag ScenarioTag) : base(ScenarioTag, 5)
            {
            }
        }

        [SpawnCounts(3, 2)]
        public class Squad__1st_cov_wv1_grt : SquadBase
        {
            public IAiActorDefinition starting_locations_0 => Squad.StartingLocations[0];
            public IAiActorDefinition starting_locations_1 => Squad.StartingLocations[1];
            public IAiActorDefinition starting_locations_2 => Squad.StartingLocations[2];
            public IAiActorDefinition starting_locations_3 => Squad.StartingLocations[3];
            public IAiActorDefinition starting_locations_4 => Squad.StartingLocations[4];
            public Squad__1st_cov_wv1_grt(ScenarioTag ScenarioTag) : base(ScenarioTag, 6, "_1st_cov_wv1")
            {
            }
        }

        [SpawnCounts(1, 2)]
        public class Squad__1st_cov_wv1_elt : SquadBase
        {
            public IAiActorDefinition starting_locations_0 => Squad.StartingLocations[0];
            public IAiActorDefinition starting_locations_1 => Squad.StartingLocations[1];
            public Squad__1st_cov_wv1_elt(ScenarioTag ScenarioTag) : base(ScenarioTag, 7, "_1st_cov_wv1")
            {
            }
        }

        [SpawnCounts(4, 3)]
        public class Squad__1st_cov_wv2_grt : SquadBase
        {
            public IAiActorDefinition starting_locations_0 => Squad.StartingLocations[0];
            public IAiActorDefinition starting_locations_1 => Squad.StartingLocations[1];
            public IAiActorDefinition starting_locations_2 => Squad.StartingLocations[2];
            public IAiActorDefinition starting_locations_3 => Squad.StartingLocations[3];
            public IAiActorDefinition starting_locations_4 => Squad.StartingLocations[4];
            public IAiActorDefinition starting_locations_5 => Squad.StartingLocations[5];
            public Squad__1st_cov_wv2_grt(ScenarioTag ScenarioTag) : base(ScenarioTag, 8, "_1st_cov_wv2")
            {
            }
        }

        [SpawnCounts(1, 2)]
        public class Squad__1st_cov_wv2_elt : SquadBase
        {
            public IAiActorDefinition starting_locations_0 => Squad.StartingLocations[0];
            public IAiActorDefinition starting_locations_1 => Squad.StartingLocations[1];
            public Squad__1st_cov_wv2_elt(ScenarioTag ScenarioTag) : base(ScenarioTag, 9, "_1st_cov_wv2")
            {
            }
        }

        [SpawnCounts(0, 0)]
        public class Squad__1st_cov_wv3_grt : SquadBase
        {
            public IAiActorDefinition starting_locations_0 => Squad.StartingLocations[0];
            public IAiActorDefinition starting_locations_1 => Squad.StartingLocations[1];
            public IAiActorDefinition starting_locations_2 => Squad.StartingLocations[2];
            public IAiActorDefinition starting_locations_3 => Squad.StartingLocations[3];
            public IAiActorDefinition starting_locations_4 => Squad.StartingLocations[4];
            public Squad__1st_cov_wv3_grt(ScenarioTag ScenarioTag) : base(ScenarioTag, 10, "_1st_cov_wv3")
            {
            }
        }

        [SpawnCounts(2, 2)]
        public class Squad__1st_cov_wv3_elt : SquadBase
        {
            public IAiActorDefinition starting_locations_0 => Squad.StartingLocations[0];
            public IAiActorDefinition starting_locations_1 => Squad.StartingLocations[1];
            public IAiActorDefinition starting_locations_2 => Squad.StartingLocations[2];
            public Squad__1st_cov_wv3_elt(ScenarioTag ScenarioTag) : base(ScenarioTag, 11, "_1st_cov_wv3")
            {
            }
        }

        [SpawnCounts(0, 0)]
        public class Squad__1st_cov_wv3_cmp : SquadBase
        {
            public IAiActorDefinition starting_locations_1 => Squad.StartingLocations[0];
            public Squad__1st_cov_wv3_cmp(ScenarioTag ScenarioTag) : base(ScenarioTag, 12, "_1st_cov_wv3")
            {
            }
        }

        [SpawnCounts(3, 2)]
        public class Squad__1st_cov_wv4_grt : SquadBase
        {
            public IAiActorDefinition starting_locations_0 => Squad.StartingLocations[0];
            public IAiActorDefinition starting_locations_1 => Squad.StartingLocations[1];
            public IAiActorDefinition starting_locations_2 => Squad.StartingLocations[2];
            public IAiActorDefinition starting_locations_3 => Squad.StartingLocations[3];
            public IAiActorDefinition starting_locations_4 => Squad.StartingLocations[4];
            public IAiActorDefinition starting_locations_5 => Squad.StartingLocations[5];
            public Squad__1st_cov_wv4_grt(ScenarioTag ScenarioTag) : base(ScenarioTag, 13, "_1st_cov_wv4")
            {
            }
        }

        [SpawnCounts(0, 0)]
        public class Squad__1st_cov_wv4_cmp : SquadBase
        {
            public IAiActorDefinition starting_locations_0 => Squad.StartingLocations[0];
            public Squad__1st_cov_wv4_cmp(ScenarioTag ScenarioTag) : base(ScenarioTag, 14, "_1st_cov_wv4")
            {
            }
        }

        [SpawnCounts(1, 2)]
        public class Squad__1st_cov_wv4_elt : SquadBase
        {
            public IAiActorDefinition starting_locations_0 => Squad.StartingLocations[0];
            public IAiActorDefinition starting_locations_1 => Squad.StartingLocations[1];
            public Squad__1st_cov_wv4_elt(ScenarioTag ScenarioTag) : base(ScenarioTag, 15, "_1st_cov_wv4")
            {
            }
        }

        [SpawnCounts(2, 2)]
        public class Squad__1st_cov_hall_elt : SquadBase
        {
            public IAiActorDefinition starting_locations_0 => Squad.StartingLocations[0];
            public IAiActorDefinition starting_locations_1 => Squad.StartingLocations[1];
            public Squad__1st_cov_hall_elt(ScenarioTag ScenarioTag) : base(ScenarioTag, 16, "_1st_cov_hall")
            {
            }
        }

        [SpawnCounts(4, 4)]
        public class Squad__1st_cov_hall_grt : SquadBase
        {
            public IAiActorDefinition starting_locations_0 => Squad.StartingLocations[0];
            public IAiActorDefinition starting_locations_1 => Squad.StartingLocations[1];
            public IAiActorDefinition starting_locations_2 => Squad.StartingLocations[2];
            public IAiActorDefinition starting_locations_3 => Squad.StartingLocations[3];
            public Squad__1st_cov_hall_grt(ScenarioTag ScenarioTag) : base(ScenarioTag, 17, "_1st_cov_hall")
            {
            }
        }

        [SpawnCounts(0, 0)]
        public class Squad_atr2_hum_security_mrn : SquadBase
        {
            public IAiActorDefinition starting_locations_0 => Squad.StartingLocations[0];
            public IAiActorDefinition starting_locations_4 => Squad.StartingLocations[1];
            public Squad_atr2_hum_security_mrn(ScenarioTag ScenarioTag) : base(ScenarioTag, 18, "atr2_hum")
            {
            }
        }

        [SpawnCounts(0, 0)]
        public class Squad_atr2_hum_security_hmp : SquadBase
        {
            public IAiActorDefinition starting_locations_0 => Squad.StartingLocations[0];
            public Squad_atr2_hum_security_hmp(ScenarioTag ScenarioTag) : base(ScenarioTag, 19, "atr2_hum")
            {
            }
        }

        [SpawnCounts(2, 2)]
        public class Squad_atr2_hum_floor_mar : SquadBase
        {
            public IAiActorDefinition starting_locations_0 => Squad.StartingLocations[0];
            public IAiActorDefinition starting_locations_1 => Squad.StartingLocations[1];
            public Squad_atr2_hum_floor_mar(ScenarioTag ScenarioTag) : base(ScenarioTag, 20, "atr2_hum")
            {
            }
        }

        [SpawnCounts(1, 1)]
        public class Squad_atr2_cov_floor_elt : SquadBase
        {
            public IAiActorDefinition starting_locations_0 => Squad.StartingLocations[0];
            public IAiActorDefinition starting_locations_1 => Squad.StartingLocations[1];
            public IAiActorDefinition starting_locations_2 => Squad.StartingLocations[2];
            public Squad_atr2_cov_floor_elt(ScenarioTag ScenarioTag) : base(ScenarioTag, 21, "atr2_cov_floor")
            {
            }
        }

        [SpawnCounts(2, 2)]
        public class Squad_atr2_cov_floor_grt : SquadBase
        {
            public IAiActorDefinition starting_locations_0 => Squad.StartingLocations[0];
            public IAiActorDefinition starting_locations_1 => Squad.StartingLocations[1];
            public IAiActorDefinition starting_locations_2 => Squad.StartingLocations[2];
            public Squad_atr2_cov_floor_grt(ScenarioTag ScenarioTag) : base(ScenarioTag, 22, "atr2_cov_floor")
            {
            }
        }

        [SpawnCounts(1, 1)]
        public class Squad_atr2_cov_fbalcony_elt : SquadBase
        {
            public IAiActorDefinition starting_locations_0 => Squad.StartingLocations[0];
            public Squad_atr2_cov_fbalcony_elt(ScenarioTag ScenarioTag) : base(ScenarioTag, 23, "atr2_cov_floor")
            {
            }
        }

        [SpawnCounts(2, 2)]
        public class Squad_atr2_cov_fbalcony_grt : SquadBase
        {
            public IAiActorDefinition starting_locations_0 => Squad.StartingLocations[0];
            public IAiActorDefinition starting_locations_1 => Squad.StartingLocations[1];
            public Squad_atr2_cov_fbalcony_grt(ScenarioTag ScenarioTag) : base(ScenarioTag, 24, "atr2_cov_floor")
            {
            }
        }

        [SpawnCounts(1, 1)]
        public class Squad_atr2_cov_lstair_elt : SquadBase
        {
            public IAiActorDefinition starting_locations_1 => Squad.StartingLocations[0];
            public IAiActorDefinition starting_locations_11 => Squad.StartingLocations[1];
            public Squad_atr2_cov_lstair_elt(ScenarioTag ScenarioTag) : base(ScenarioTag, 25, "atr2_cov_lstair")
            {
            }
        }

        [SpawnCounts(1, 1)]
        public class Squad_atr2_cov_lstair_grt : SquadBase
        {
            public IAiActorDefinition starting_locations_0 => Squad.StartingLocations[0];
            public IAiActorDefinition starting_locations_1 => Squad.StartingLocations[1];
            public IAiActorDefinition starting_locations_2 => Squad.StartingLocations[2];
            public Squad_atr2_cov_lstair_grt(ScenarioTag ScenarioTag) : base(ScenarioTag, 26, "atr2_cov_lstair")
            {
            }
        }

        [SpawnCounts(1, 1)]
        public class Squad_atr2_cov_lstair_rear_elt : SquadBase
        {
            public IAiActorDefinition starting_locations_0 => Squad.StartingLocations[0];
            public IAiActorDefinition starting_locations_1 => Squad.StartingLocations[1];
            public Squad_atr2_cov_lstair_rear_elt(ScenarioTag ScenarioTag) : base(ScenarioTag, 27, "atr2_cov_lstair")
            {
            }
        }

        [SpawnCounts(0, 0)]
        public class Squad_atr2_cov_lstair_rear_grt : SquadBase
        {
            public IAiActorDefinition starting_locations_0 => Squad.StartingLocations[0];
            public IAiActorDefinition starting_locations_1 => Squad.StartingLocations[1];
            public IAiActorDefinition starting_locations_2 => Squad.StartingLocations[2];
            public Squad_atr2_cov_lstair_rear_grt(ScenarioTag ScenarioTag) : base(ScenarioTag, 28, "atr2_cov_lstair")
            {
            }
        }

        [SpawnCounts(3, 3)]
        public class Squad_atr2_cov_bbalcony_grt : SquadBase
        {
            public IAiActorDefinition starting_locations_0 => Squad.StartingLocations[0];
            public IAiActorDefinition starting_locations_1 => Squad.StartingLocations[1];
            public IAiActorDefinition starting_locations_2 => Squad.StartingLocations[2];
            public Squad_atr2_cov_bbalcony_grt(ScenarioTag ScenarioTag) : base(ScenarioTag, 29, "atr2_cov")
            {
            }
        }

        [SpawnCounts(1, 1)]
        public class Squad_atr2_cov_re_floor_elt : SquadBase
        {
            public IAiActorDefinition starting_locations_0 => Squad.StartingLocations[0];
            public Squad_atr2_cov_re_floor_elt(ScenarioTag ScenarioTag) : base(ScenarioTag, 30, "atr2_cov_re")
            {
            }
        }

        [SpawnCounts(2, 2)]
        public class Squad_atr2_cov_re_floor_grt : SquadBase
        {
            public IAiActorDefinition starting_locations_0 => Squad.StartingLocations[0];
            public IAiActorDefinition starting_locations_1 => Squad.StartingLocations[1];
            public IAiActorDefinition starting_locations_2 => Squad.StartingLocations[2];
            public Squad_atr2_cov_re_floor_grt(ScenarioTag ScenarioTag) : base(ScenarioTag, 31, "atr2_cov_re")
            {
            }
        }

        [SpawnCounts(2, 2)]
        public class Squad_atr2_cov_fnl_grt : SquadBase
        {
            public IAiActorDefinition starting_locations_0 => Squad.StartingLocations[0];
            public IAiActorDefinition starting_locations_1 => Squad.StartingLocations[1];
            public Squad_atr2_cov_fnl_grt(ScenarioTag ScenarioTag) : base(ScenarioTag, 32, "atr2_cov_fnl")
            {
            }
        }

        [SpawnCounts(1, 1)]
        public class Squad_atr2_cov_fnl_elt : SquadBase
        {
            public IAiActorDefinition starting_locations_0 => Squad.StartingLocations[0];
            public Squad_atr2_cov_fnl_elt(ScenarioTag ScenarioTag) : base(ScenarioTag, 33, "atr2_cov_fnl")
            {
            }
        }

        [SpawnCounts(2, 1)]
        public class Squad_bay1_hum_floor_mar : SquadBase
        {
            public IAiActorDefinition starting_locations_0 => Squad.StartingLocations[0];
            public IAiActorDefinition starting_locations_1 => Squad.StartingLocations[1];
            public IAiActorDefinition starting_locations_2 => Squad.StartingLocations[2];
            public IAiActorDefinition starting_locations_3 => Squad.StartingLocations[3];
            public IAiActorDefinition starting_locations_4 => Squad.StartingLocations[4];
            public Squad_bay1_hum_floor_mar(ScenarioTag ScenarioTag) : base(ScenarioTag, 34, "bay1_hum")
            {
            }
        }

        [SpawnCounts(1, 1)]
        public class Squad_bay1_hum_catwalk_mar : SquadBase
        {
            public IAiActorDefinition starting_locations_0 => Squad.StartingLocations[0];
            public IAiActorDefinition starting_locations_3 => Squad.StartingLocations[1];
            public Squad_bay1_hum_catwalk_mar(ScenarioTag ScenarioTag) : base(ScenarioTag, 35, "bay1_hum")
            {
            }
        }

        [SpawnCounts(1, 0)]
        public class Squad_bay1_hum_catwalk_hmp : SquadBase
        {
            public IAiActorDefinition starting_locations_0 => Squad.StartingLocations[0];
            public Squad_bay1_hum_catwalk_hmp(ScenarioTag ScenarioTag) : base(ScenarioTag, 36, "bay1_hum")
            {
            }
        }

        [SpawnCounts(1, 2)]
        public class Squad_bay1_cov_floor_elt : SquadBase
        {
            public IAiActorDefinition starting_locations_0 => Squad.StartingLocations[0];
            public IAiActorDefinition starting_locations_1 => Squad.StartingLocations[1];
            public Squad_bay1_cov_floor_elt(ScenarioTag ScenarioTag) : base(ScenarioTag, 37, "bay1_cov_floor")
            {
            }
        }

        [SpawnCounts(4, 3)]
        public class Squad_bay1_cov_floor_grt : SquadBase
        {
            public IAiActorDefinition starting_locations_0 => Squad.StartingLocations[0];
            public IAiActorDefinition starting_locations_1 => Squad.StartingLocations[1];
            public IAiActorDefinition starting_locations_2 => Squad.StartingLocations[2];
            public IAiActorDefinition starting_locations_3 => Squad.StartingLocations[3];
            public IAiActorDefinition starting_locations_4 => Squad.StartingLocations[4];
            public Squad_bay1_cov_floor_grt(ScenarioTag ScenarioTag) : base(ScenarioTag, 38, "bay1_cov_floor")
            {
            }
        }

        [SpawnCounts(1, 1)]
        public class Squad_bay1_cov_wv2_elt : SquadBase
        {
            public IAiActorDefinition starting_locations_0 => Squad.StartingLocations[0];
            public IAiActorDefinition starting_locations_1 => Squad.StartingLocations[1];
            public Squad_bay1_cov_wv2_elt(ScenarioTag ScenarioTag) : base(ScenarioTag, 39, "bay1_cov_wv2")
            {
            }
        }

        [SpawnCounts(3, 3)]
        public class Squad_bay1_cov_wv2_grt : SquadBase
        {
            public IAiActorDefinition starting_locations_0 => Squad.StartingLocations[0];
            public IAiActorDefinition starting_locations_1 => Squad.StartingLocations[1];
            public IAiActorDefinition starting_locations_2 => Squad.StartingLocations[2];
            public IAiActorDefinition starting_locations_3 => Squad.StartingLocations[3];
            public Squad_bay1_cov_wv2_grt(ScenarioTag ScenarioTag) : base(ScenarioTag, 40, "bay1_cov_wv2")
            {
            }
        }

        [SpawnCounts(1, 1)]
        public class Squad_bay1_cov_wv3_elt : SquadBase
        {
            public IAiActorDefinition starting_locations_0 => Squad.StartingLocations[0];
            public IAiActorDefinition starting_locations_1 => Squad.StartingLocations[1];
            public Squad_bay1_cov_wv3_elt(ScenarioTag ScenarioTag) : base(ScenarioTag, 41, "bay1_cov_wv3")
            {
            }
        }

        [SpawnCounts(3, 3)]
        public class Squad_bay1_cov_wv3_grt : SquadBase
        {
            public IAiActorDefinition starting_locations_0 => Squad.StartingLocations[0];
            public IAiActorDefinition starting_locations_1 => Squad.StartingLocations[1];
            public IAiActorDefinition starting_locations_2 => Squad.StartingLocations[2];
            public IAiActorDefinition starting_locations_3 => Squad.StartingLocations[3];
            public Squad_bay1_cov_wv3_grt(ScenarioTag ScenarioTag) : base(ScenarioTag, 42, "bay1_cov_wv3")
            {
            }
        }

        [SpawnCounts(1, 2)]
        public class Squad_bay1_cov_wv4_elt : SquadBase
        {
            public IAiActorDefinition starting_locations_0 => Squad.StartingLocations[0];
            public IAiActorDefinition starting_locations_1 => Squad.StartingLocations[1];
            public Squad_bay1_cov_wv4_elt(ScenarioTag ScenarioTag) : base(ScenarioTag, 43, "bay1_cov_wv4")
            {
            }
        }

        [SpawnCounts(3, 3)]
        public class Squad_bay1_cov_wv4_grt : SquadBase
        {
            public IAiActorDefinition starting_locations_0 => Squad.StartingLocations[0];
            public IAiActorDefinition starting_locations_1 => Squad.StartingLocations[1];
            public IAiActorDefinition starting_locations_2 => Squad.StartingLocations[2];
            public IAiActorDefinition starting_locations_3 => Squad.StartingLocations[3];
            public Squad_bay1_cov_wv4_grt(ScenarioTag ScenarioTag) : base(ScenarioTag, 44, "bay1_cov_wv4")
            {
            }
        }

        [SpawnCounts(2, 2)]
        public class Squad_bay1_cov_fnl_elt : SquadBase
        {
            public IAiActorDefinition starting_locations_0 => Squad.StartingLocations[0];
            public IAiActorDefinition starting_locations_1 => Squad.StartingLocations[1];
            public IAiActorDefinition starting_locations_2 => Squad.StartingLocations[2];
            public Squad_bay1_cov_fnl_elt(ScenarioTag ScenarioTag) : base(ScenarioTag, 45, "bay1_cov_fnl")
            {
            }
        }

        [SpawnCounts(3, 3)]
        public class Squad_bay1_cov_fnl_grt : SquadBase
        {
            public IAiActorDefinition starting_locations_0 => Squad.StartingLocations[0];
            public IAiActorDefinition starting_locations_1 => Squad.StartingLocations[1];
            public IAiActorDefinition starting_locations_2 => Squad.StartingLocations[2];
            public IAiActorDefinition starting_locations_3 => Squad.StartingLocations[3];
            public IAiActorDefinition starting_locations_4 => Squad.StartingLocations[4];
            public Squad_bay1_cov_fnl_grt(ScenarioTag ScenarioTag) : base(ScenarioTag, 46, "bay1_cov_fnl")
            {
            }
        }

        [SpawnCounts(3, 2)]
        public class Squad_bay2_hum_mar : SquadBase
        {
            public IAiActorDefinition starting_locations_5 => Squad.StartingLocations[0];
            public IAiActorDefinition starting_locations_6 => Squad.StartingLocations[1];
            public IAiActorDefinition starting_locations_7 => Squad.StartingLocations[2];
            public IAiActorDefinition starting_locations_8 => Squad.StartingLocations[3];
            public IAiActorDefinition starting_locations_9 => Squad.StartingLocations[4];
            public Squad_bay2_hum_mar(ScenarioTag ScenarioTag) : base(ScenarioTag, 47, "bay2_hum")
            {
            }
        }

        [SpawnCounts(1, 2)]
        public class Squad_bay2_cov_floor_elt : SquadBase
        {
            public IAiActorDefinition starting_locations_0 => Squad.StartingLocations[0];
            public IAiActorDefinition starting_locations_1 => Squad.StartingLocations[1];
            public IAiActorDefinition starting_locations_2 => Squad.StartingLocations[2];
            public Squad_bay2_cov_floor_elt(ScenarioTag ScenarioTag) : base(ScenarioTag, 48, "bay2_cov_floor")
            {
            }
        }

        [SpawnCounts(3, 2)]
        public class Squad_bay2_cov_floor_grt : SquadBase
        {
            public IAiActorDefinition starting_locations_5 => Squad.StartingLocations[0];
            public IAiActorDefinition starting_locations_6 => Squad.StartingLocations[1];
            public IAiActorDefinition starting_locations_7 => Squad.StartingLocations[2];
            public IAiActorDefinition starting_locations_8 => Squad.StartingLocations[3];
            public IAiActorDefinition starting_locations_9 => Squad.StartingLocations[4];
            public IAiActorDefinition starting_locations_10 => Squad.StartingLocations[5];
            public Squad_bay2_cov_floor_grt(ScenarioTag ScenarioTag) : base(ScenarioTag, 49, "bay2_cov_floor")
            {
            }
        }

        [SpawnCounts(0, 0)]
        public class Squad_bay2_cov_catwalk_grt : SquadBase
        {
            public IAiActorDefinition starting_locations_4 => Squad.StartingLocations[0];
            public IAiActorDefinition starting_locations_5 => Squad.StartingLocations[1];
            public IAiActorDefinition starting_locations_6 => Squad.StartingLocations[2];
            public IAiActorDefinition starting_locations_7 => Squad.StartingLocations[3];
            public IAiActorDefinition starting_locations_8 => Squad.StartingLocations[4];
            public Squad_bay2_cov_catwalk_grt(ScenarioTag ScenarioTag) : base(ScenarioTag, 50, "bay2_cov_catwalk")
            {
            }
        }

        [SpawnCounts(2, 2)]
        public class Squad_bay2_cov_catwalk_cmp : SquadBase
        {
            public IAiActorDefinition starting_locations_2 => Squad.StartingLocations[0];
            public IAiActorDefinition starting_locations_3 => Squad.StartingLocations[1];
            public Squad_bay2_cov_catwalk_cmp(ScenarioTag ScenarioTag) : base(ScenarioTag, 51, "bay2_cov_catwalk")
            {
            }
        }

        [SpawnCounts(1, 1)]
        public class Squad_bay2_cov_wv2_elt : SquadBase
        {
            public IAiActorDefinition starting_locations_2 => Squad.StartingLocations[0];
            public IAiActorDefinition starting_locations_3 => Squad.StartingLocations[1];
            public Squad_bay2_cov_wv2_elt(ScenarioTag ScenarioTag) : base(ScenarioTag, 52, "bay2_cov_wv2")
            {
            }
        }

        [SpawnCounts(3, 3)]
        public class Squad_bay2_cov_wv2_grt : SquadBase
        {
            public IAiActorDefinition starting_locations_4 => Squad.StartingLocations[0];
            public IAiActorDefinition starting_locations_5 => Squad.StartingLocations[1];
            public IAiActorDefinition starting_locations_6 => Squad.StartingLocations[2];
            public IAiActorDefinition starting_locations_7 => Squad.StartingLocations[3];
            public IAiActorDefinition starting_locations_8 => Squad.StartingLocations[4];
            public Squad_bay2_cov_wv2_grt(ScenarioTag ScenarioTag) : base(ScenarioTag, 53, "bay2_cov_wv2")
            {
            }
        }

        [SpawnCounts(1, 2)]
        public class Squad_bay2_cov_wv3_elt : SquadBase
        {
            public IAiActorDefinition starting_locations_2 => Squad.StartingLocations[0];
            public IAiActorDefinition starting_locations_3 => Squad.StartingLocations[1];
            public Squad_bay2_cov_wv3_elt(ScenarioTag ScenarioTag) : base(ScenarioTag, 54, "bay2_cov_wv3")
            {
            }
        }

        [SpawnCounts(4, 3)]
        public class Squad_bay2_cov_wv3_grt : SquadBase
        {
            public IAiActorDefinition starting_locations_4 => Squad.StartingLocations[0];
            public IAiActorDefinition starting_locations_5 => Squad.StartingLocations[1];
            public IAiActorDefinition starting_locations_6 => Squad.StartingLocations[2];
            public IAiActorDefinition starting_locations_7 => Squad.StartingLocations[3];
            public IAiActorDefinition starting_locations_8 => Squad.StartingLocations[4];
            public Squad_bay2_cov_wv3_grt(ScenarioTag ScenarioTag) : base(ScenarioTag, 55, "bay2_cov_wv3")
            {
            }
        }

        [SpawnCounts(2, 2)]
        public class Squad_bay2_cov_wv4_elt : SquadBase
        {
            public IAiActorDefinition starting_locations_2 => Squad.StartingLocations[0];
            public IAiActorDefinition starting_locations_3 => Squad.StartingLocations[1];
            public Squad_bay2_cov_wv4_elt(ScenarioTag ScenarioTag) : base(ScenarioTag, 56, "bay2_cov_wv4")
            {
            }
        }

        [SpawnCounts(2, 2)]
        public class Squad_bay2_cov_wv4_grt : SquadBase
        {
            public IAiActorDefinition starting_locations_4 => Squad.StartingLocations[0];
            public IAiActorDefinition starting_locations_5 => Squad.StartingLocations[1];
            public IAiActorDefinition starting_locations_6 => Squad.StartingLocations[2];
            public IAiActorDefinition starting_locations_7 => Squad.StartingLocations[3];
            public IAiActorDefinition starting_locations_8 => Squad.StartingLocations[4];
            public Squad_bay2_cov_wv4_grt(ScenarioTag ScenarioTag) : base(ScenarioTag, 57, "bay2_cov_wv4")
            {
            }
        }

        [SpawnCounts(4, 3)]
        public class Squad_bay2_cov_fnl_grt : SquadBase
        {
            public IAiActorDefinition starting_locations_0 => Squad.StartingLocations[0];
            public IAiActorDefinition starting_locations_1 => Squad.StartingLocations[1];
            public IAiActorDefinition starting_locations_2 => Squad.StartingLocations[2];
            public IAiActorDefinition starting_locations_3 => Squad.StartingLocations[3];
            public Squad_bay2_cov_fnl_grt(ScenarioTag ScenarioTag) : base(ScenarioTag, 58, "bay2_cov_fnl")
            {
            }
        }

        [SpawnCounts(1, 2)]
        public class Squad_bay2_cov_fnl_elt : SquadBase
        {
            public IAiActorDefinition starting_locations_0 => Squad.StartingLocations[0];
            public IAiActorDefinition starting_locations_1 => Squad.StartingLocations[1];
            public Squad_bay2_cov_fnl_elt(ScenarioTag ScenarioTag) : base(ScenarioTag, 59, "bay2_cov_fnl")
            {
            }
        }

        [SpawnCounts(2, 2)]
        public class Squad_arm_cov_stl : SquadBase
        {
            public IAiActorDefinition starting_locations_0 => Squad.StartingLocations[0];
            public IAiActorDefinition starting_locations_1 => Squad.StartingLocations[1];
            public Squad_arm_cov_stl(ScenarioTag ScenarioTag) : base(ScenarioTag, 60)
            {
            }
        }

        [SpawnCounts(1, 1)]
        public class Squad_arm_hum_guns : SquadBase
        {
            public IAiActorDefinition starting_locations_0 => Squad.StartingLocations[0];
            public Squad_arm_hum_guns(ScenarioTag ScenarioTag) : base(ScenarioTag, 61)
            {
            }
        }

        [SpawnCounts(2, 2)]
        public class Squad_arm_cov_elt : SquadBase
        {
            public IAiActorDefinition starting_locations_0 => Squad.StartingLocations[0];
            public IAiActorDefinition starting_locations_1 => Squad.StartingLocations[1];
            public Squad_arm_cov_elt(ScenarioTag ScenarioTag) : base(ScenarioTag, 62, "arm_cov")
            {
            }
        }

        [SpawnCounts(3, 2)]
        public class Squad_atr1_floor_grt : SquadBase
        {
            public IAiActorDefinition starting_locations_0 => Squad.StartingLocations[0];
            public IAiActorDefinition starting_locations_1 => Squad.StartingLocations[1];
            public IAiActorDefinition starting_locations_2 => Squad.StartingLocations[2];
            public IAiActorDefinition starting_locations_3 => Squad.StartingLocations[3];
            public Squad_atr1_floor_grt(ScenarioTag ScenarioTag) : base(ScenarioTag, 63, "atr1_cov_fbalcony")
            {
            }
        }

        [SpawnCounts(1, 1)]
        public class Squad_atr1_cov_fbalcony_cmp : SquadBase
        {
            public IAiActorDefinition starting_locations_0 => Squad.StartingLocations[0];
            public Squad_atr1_cov_fbalcony_cmp(ScenarioTag ScenarioTag) : base(ScenarioTag, 64, "atr1_cov_fbalcony")
            {
            }
        }

        [SpawnCounts(1, 1)]
        public class Squad_atr1_cov_fbalcony_elite : SquadBase
        {
            public IAiActorDefinition starting_locations_0 => Squad.StartingLocations[0];
            public Squad_atr1_cov_fbalcony_elite(ScenarioTag ScenarioTag) : base(ScenarioTag, 65, "atr1_cov_fbalcony")
            {
            }
        }

        [SpawnCounts(1, 1)]
        public class Squad_atr1_cov_bbalcony_cmp : SquadBase
        {
            public IAiActorDefinition starting_locations_0 => Squad.StartingLocations[0];
            public Squad_atr1_cov_bbalcony_cmp(ScenarioTag ScenarioTag) : base(ScenarioTag, 66, "atr1_cov_bbalcony")
            {
            }
        }

        [SpawnCounts(1, 1)]
        public class Squad_atr1_cov_bbalcony_elt : SquadBase
        {
            public IAiActorDefinition starting_locations_0 => Squad.StartingLocations[0];
            public Squad_atr1_cov_bbalcony_elt(ScenarioTag ScenarioTag) : base(ScenarioTag, 67, "atr1_cov_bbalcony")
            {
            }
        }

        [SpawnCounts(2, 2)]
        public class Squad_atr1_cov_sec_front_cmp : SquadBase
        {
            public IAiActorDefinition starting_locations_0 => Squad.StartingLocations[0];
            public IAiActorDefinition starting_locations_1 => Squad.StartingLocations[1];
            public Squad_atr1_cov_sec_front_cmp(ScenarioTag ScenarioTag) : base(ScenarioTag, 68, "atr1_cov_sec_front")
            {
            }
        }

        [SpawnCounts(1, 1)]
        public class Squad_atr1_cov_stairs_front_cmp : SquadBase
        {
            public IAiActorDefinition starting_locations_0 => Squad.StartingLocations[0];
            public Squad_atr1_cov_stairs_front_cmp(ScenarioTag ScenarioTag) : base(ScenarioTag, 69, "atr1_cov_stairs_front")
            {
            }
        }

        [SpawnCounts(4, 3)]
        public class Squad_atr1_cov_stairs_front_grt : SquadBase
        {
            public IAiActorDefinition starting_locations_0 => Squad.StartingLocations[0];
            public IAiActorDefinition starting_locations_1 => Squad.StartingLocations[1];
            public IAiActorDefinition starting_locations_2 => Squad.StartingLocations[2];
            public IAiActorDefinition starting_locations_3 => Squad.StartingLocations[3];
            public IAiActorDefinition starting_locations_4 => Squad.StartingLocations[4];
            public Squad_atr1_cov_stairs_front_grt(ScenarioTag ScenarioTag) : base(ScenarioTag, 70, "atr1_cov_stairs_front")
            {
            }
        }

        [SpawnCounts(0, 2)]
        public class Squad_atr1_cov_stairs_front_elt : SquadBase
        {
            public IAiActorDefinition starting_locations_0 => Squad.StartingLocations[0];
            public IAiActorDefinition starting_locations_1 => Squad.StartingLocations[1];
            public Squad_atr1_cov_stairs_front_elt(ScenarioTag ScenarioTag) : base(ScenarioTag, 71, "atr1_cov_stairs_front")
            {
            }
        }

        [SpawnCounts(0, 1)]
        public class Squad_atr1_cov_stairs_back_elt : SquadBase
        {
            public IAiActorDefinition starting_locations_0 => Squad.StartingLocations[0];
            public Squad_atr1_cov_stairs_back_elt(ScenarioTag ScenarioTag) : base(ScenarioTag, 72, "atr1_cov_stairs_back")
            {
            }
        }

        [SpawnCounts(0, 1)]
        public class Squad_atr1_cov_sec_back_cmp : SquadBase
        {
            public IAiActorDefinition starting_locations_0 => Squad.StartingLocations[0];
            public Squad_atr1_cov_sec_back_cmp(ScenarioTag ScenarioTag) : base(ScenarioTag, 73, "atr1_cov_sec_back")
            {
            }
        }

        [SpawnCounts(3, 2)]
        public class Squad_atr1_cov_sec_back_grt : SquadBase
        {
            public IAiActorDefinition starting_locations_0 => Squad.StartingLocations[0];
            public IAiActorDefinition starting_locations_2 => Squad.StartingLocations[1];
            public IAiActorDefinition starting_locations_3 => Squad.StartingLocations[2];
            public Squad_atr1_cov_sec_back_grt(ScenarioTag ScenarioTag) : base(ScenarioTag, 74, "atr1_cov_sec_back")
            {
            }
        }

        [SpawnCounts(1, 2)]
        public class Squad_atr1_cov_sec_back_elt : SquadBase
        {
            public IAiActorDefinition starting_locations_0 => Squad.StartingLocations[0];
            public Squad_atr1_cov_sec_back_elt(ScenarioTag ScenarioTag) : base(ScenarioTag, 75, "atr1_cov_sec_back")
            {
            }
        }

        [SpawnCounts(2, 2)]
        public class Squad_atr1_cov_bfloor_grt : SquadBase
        {
            public IAiActorDefinition starting_locations_0 => Squad.StartingLocations[0];
            public IAiActorDefinition starting_locations_1 => Squad.StartingLocations[1];
            public IAiActorDefinition starting_locations_2 => Squad.StartingLocations[2];
            public IAiActorDefinition starting_locations_3 => Squad.StartingLocations[3];
            public Squad_atr1_cov_bfloor_grt(ScenarioTag ScenarioTag) : base(ScenarioTag, 76, "atr1_cov_bbalcony")
            {
            }
        }

        [SpawnCounts(1, 1)]
        public class Squad_trm1_hum_johnson : SquadBase
        {
            public IAiActorDefinition johnson => Squad.StartingLocations[0];
            public Squad_trm1_hum_johnson(ScenarioTag ScenarioTag) : base(ScenarioTag, 77, "trm1_hum_alock")
            {
            }
        }

        [SpawnCounts(1, 1)]
        public class Squad_trm1_hum_miranda : SquadBase
        {
            public IAiActorDefinition miranda => Squad.StartingLocations[0];
            public Squad_trm1_hum_miranda(ScenarioTag ScenarioTag) : base(ScenarioTag, 78, "trm1_hum_alock")
            {
            }
        }

        [SpawnCounts(2, 2)]
        public class Squad_trm1_hum_alock_mar : SquadBase
        {
            public IAiActorDefinition starting_locations_0 => Squad.StartingLocations[0];
            public IAiActorDefinition starting_locations_1 => Squad.StartingLocations[1];
            public IAiActorDefinition starting_locations_2 => Squad.StartingLocations[2];
            public Squad_trm1_hum_alock_mar(ScenarioTag ScenarioTag) : base(ScenarioTag, 79, "trm1_hum_alock")
            {
            }
        }

        [SpawnCounts(0, 0)]
        public class Squad_trm1_hum_block_mar : SquadBase
        {
            public IAiActorDefinition starting_locations_0 => Squad.StartingLocations[0];
            public IAiActorDefinition starting_locations_1 => Squad.StartingLocations[1];
            public IAiActorDefinition starting_locations_2 => Squad.StartingLocations[2];
            public IAiActorDefinition starting_locations_3 => Squad.StartingLocations[3];
            public Squad_trm1_hum_block_mar(ScenarioTag ScenarioTag) : base(ScenarioTag, 80, "trm1_hum_block")
            {
            }
        }

        [SpawnCounts(1, 1)]
        public class Squad_trm1_cov_alock_elt : SquadBase
        {
            public IAiActorDefinition starting_locations_0 => Squad.StartingLocations[0];
            public IAiActorDefinition starting_locations_1 => Squad.StartingLocations[1];
            public Squad_trm1_cov_alock_elt(ScenarioTag ScenarioTag) : base(ScenarioTag, 81, "trm1_cov_alock")
            {
            }
        }

        [SpawnCounts(3, 3)]
        public class Squad_trm1_cov_alock_grt : SquadBase
        {
            public IAiActorDefinition starting_locations_0 => Squad.StartingLocations[0];
            public IAiActorDefinition starting_locations_1 => Squad.StartingLocations[1];
            public IAiActorDefinition starting_locations_2 => Squad.StartingLocations[2];
            public IAiActorDefinition starting_locations_3 => Squad.StartingLocations[3];
            public Squad_trm1_cov_alock_grt(ScenarioTag ScenarioTag) : base(ScenarioTag, 82, "trm1_cov_alock")
            {
            }
        }

        [SpawnCounts(1, 1)]
        public class Squad_trm1_cov_block_elt : SquadBase
        {
            public IAiActorDefinition starting_locations_0 => Squad.StartingLocations[0];
            public IAiActorDefinition starting_locations_1 => Squad.StartingLocations[1];
            public IAiActorDefinition starting_locations_2 => Squad.StartingLocations[2];
            public Squad_trm1_cov_block_elt(ScenarioTag ScenarioTag) : base(ScenarioTag, 83, "trm1_cov_block")
            {
            }
        }

        [SpawnCounts(3, 3)]
        public class Squad_trm1_cov_block_grt : SquadBase
        {
            public IAiActorDefinition starting_locations_0 => Squad.StartingLocations[0];
            public IAiActorDefinition starting_locations_1 => Squad.StartingLocations[1];
            public IAiActorDefinition starting_locations_2 => Squad.StartingLocations[2];
            public IAiActorDefinition starting_locations_3 => Squad.StartingLocations[3];
            public Squad_trm1_cov_block_grt(ScenarioTag ScenarioTag) : base(ScenarioTag, 84, "trm1_cov_block")
            {
            }
        }

        [SpawnCounts(2, 2)]
        public class Squad_dck_cov_enter_elt : SquadBase
        {
            public IAiActorDefinition starting_locations_0 => Squad.StartingLocations[0];
            public IAiActorDefinition starting_locations_1 => Squad.StartingLocations[1];
            public Squad_dck_cov_enter_elt(ScenarioTag ScenarioTag) : base(ScenarioTag, 85, "dck_cov_arm1")
            {
            }
        }

        [SpawnCounts(1, 1)]
        public class Squad_dck_cov_arm1_elt : SquadBase
        {
            public IAiActorDefinition starting_locations_0 => Squad.StartingLocations[0];
            public IAiActorDefinition starting_locations_1 => Squad.StartingLocations[1];
            public Squad_dck_cov_arm1_elt(ScenarioTag ScenarioTag) : base(ScenarioTag, 86, "dck_cov_arm1")
            {
            }
        }

        [SpawnCounts(1, 1)]
        public class Squad_dck_cov_mid_elt : SquadBase
        {
            public IAiActorDefinition starting_locations_0 => Squad.StartingLocations[0];
            public IAiActorDefinition starting_locations_1 => Squad.StartingLocations[1];
            public Squad_dck_cov_mid_elt(ScenarioTag ScenarioTag) : base(ScenarioTag, 87, "dck_cov_arm1")
            {
            }
        }

        [SpawnCounts(0, 2)]
        public class Squad_dck_cov_arm2_elt : SquadBase
        {
            public IAiActorDefinition starting_locations_0 => Squad.StartingLocations[0];
            public IAiActorDefinition starting_locations_1 => Squad.StartingLocations[1];
            public Squad_dck_cov_arm2_elt(ScenarioTag ScenarioTag) : base(ScenarioTag, 88, "dck_cov_arm2")
            {
            }
        }

        [SpawnCounts(3, 5)]
        public class Squad_elv_cov_floor_bgr : SquadBase
        {
            public IAiActorDefinition starting_locations_0 => Squad.StartingLocations[0];
            public IAiActorDefinition starting_locations_1 => Squad.StartingLocations[1];
            public IAiActorDefinition starting_locations_2 => Squad.StartingLocations[2];
            public IAiActorDefinition starting_locations_3 => Squad.StartingLocations[3];
            public IAiActorDefinition starting_locations_4 => Squad.StartingLocations[4];
            public Squad_elv_cov_floor_bgr(ScenarioTag ScenarioTag) : base(ScenarioTag, 89, "elv_cov_top")
            {
            }
        }

        [SpawnCounts(2, 2)]
        public class Squad_elv_cov_stairs_left_bgr : SquadBase
        {
            public IAiActorDefinition starting_locations_0 => Squad.StartingLocations[0];
            public IAiActorDefinition starting_locations_1 => Squad.StartingLocations[1];
            public IAiActorDefinition starting_locations_2 => Squad.StartingLocations[2];
            public IAiActorDefinition starting_locations_3 => Squad.StartingLocations[3];
            public IAiActorDefinition starting_locations_4 => Squad.StartingLocations[4];
            public Squad_elv_cov_stairs_left_bgr(ScenarioTag ScenarioTag) : base(ScenarioTag, 90, "elv_cov_top")
            {
            }
        }

        [SpawnCounts(2, 2)]
        public class Squad_elv_cov_stairs_right_bgr : SquadBase
        {
            public IAiActorDefinition starting_locations_0 => Squad.StartingLocations[0];
            public IAiActorDefinition starting_locations_1 => Squad.StartingLocations[1];
            public IAiActorDefinition starting_locations_2 => Squad.StartingLocations[2];
            public IAiActorDefinition starting_locations_3 => Squad.StartingLocations[3];
            public IAiActorDefinition starting_locations_4 => Squad.StartingLocations[4];
            public Squad_elv_cov_stairs_right_bgr(ScenarioTag ScenarioTag) : base(ScenarioTag, 91, "elv_cov_top")
            {
            }
        }

        [SpawnCounts(2, 2)]
        public class Squad_elv_cov_elevator_elt : SquadBase
        {
            public IAiActorDefinition starting_locations_0 => Squad.StartingLocations[0];
            public IAiActorDefinition starting_locations_2 => Squad.StartingLocations[1];
            public Squad_elv_cov_elevator_elt(ScenarioTag ScenarioTag) : base(ScenarioTag, 92, "elv_cov_elevator")
            {
            }
        }

        [SpawnCounts(4, 4)]
        public class Squad_elv_cov_elevator_grt : SquadBase
        {
            public IAiActorDefinition starting_locations_0 => Squad.StartingLocations[0];
            public IAiActorDefinition starting_locations_1 => Squad.StartingLocations[1];
            public IAiActorDefinition starting_locations_2 => Squad.StartingLocations[2];
            public IAiActorDefinition starting_locations_3 => Squad.StartingLocations[3];
            public Squad_elv_cov_elevator_grt(ScenarioTag ScenarioTag) : base(ScenarioTag, 93, "elv_cov_elevator")
            {
            }
        }

        [SpawnCounts(1, 1)]
        public class Squad_lvr_cov_wv1_cmp : SquadBase
        {
            public IAiActorDefinition starting_locations_1 => Squad.StartingLocations[0];
            public Squad_lvr_cov_wv1_cmp(ScenarioTag ScenarioTag) : base(ScenarioTag, 94, "lvr_cov_wv1")
            {
            }
        }

        [SpawnCounts(2, 2)]
        public class Squad_lvr_cov_wv1_elt : SquadBase
        {
            public IAiActorDefinition starting_locations_0 => Squad.StartingLocations[0];
            public IAiActorDefinition starting_locations_1 => Squad.StartingLocations[1];
            public IAiActorDefinition starting_locations_2 => Squad.StartingLocations[2];
            public Squad_lvr_cov_wv1_elt(ScenarioTag ScenarioTag) : base(ScenarioTag, 95, "lvr_cov_wv1")
            {
            }
        }

        [SpawnCounts(0, 2)]
        public class Squad_lvr_cov_wv2_elt : SquadBase
        {
            public IAiActorDefinition starting_locations_0 => Squad.StartingLocations[0];
            public IAiActorDefinition starting_locations_1 => Squad.StartingLocations[1];
            public IAiActorDefinition starting_locations_2 => Squad.StartingLocations[2];
            public Squad_lvr_cov_wv2_elt(ScenarioTag ScenarioTag) : base(ScenarioTag, 96, "lvr_cov_wv2")
            {
            }
        }

        [SpawnCounts(1, 1)]
        public class Squad_gun_cov_elt_a : SquadBase
        {
            public IAiActorDefinition starting_locations_1 => Squad.StartingLocations[0];
            public IAiActorDefinition starting_locations_2 => Squad.StartingLocations[1];
            public Squad_gun_cov_elt_a(ScenarioTag ScenarioTag) : base(ScenarioTag, 97, "gun_cov")
            {
            }
        }

        [SpawnCounts(2, 0)]
        public class Squad_gun_cov_grt_a : SquadBase
        {
            public IAiActorDefinition starting_locations_0 => Squad.StartingLocations[0];
            public IAiActorDefinition starting_locations_1 => Squad.StartingLocations[1];
            public IAiActorDefinition starting_locations_2 => Squad.StartingLocations[2];
            public IAiActorDefinition starting_locations_3 => Squad.StartingLocations[3];
            public Squad_gun_cov_grt_a(ScenarioTag ScenarioTag) : base(ScenarioTag, 98, "gun_cov")
            {
            }
        }

        [SpawnCounts(1, 2)]
        public class Squad_gun_cov_elt_b : SquadBase
        {
            public IAiActorDefinition starting_locations_0 => Squad.StartingLocations[0];
            public IAiActorDefinition starting_locations_1 => Squad.StartingLocations[1];
            public Squad_gun_cov_elt_b(ScenarioTag ScenarioTag) : base(ScenarioTag, 99, "gun_cov")
            {
            }
        }

        [SpawnCounts(1, 1)]
        public class Squad_gun_cov_elt_c : SquadBase
        {
            public IAiActorDefinition starting_locations_0 => Squad.StartingLocations[0];
            public IAiActorDefinition starting_locations_1 => Squad.StartingLocations[1];
            public Squad_gun_cov_elt_c(ScenarioTag ScenarioTag) : base(ScenarioTag, 100, "gun_cov")
            {
            }
        }

        [SpawnCounts(1, 2)]
        public class Squad_gun_cov_elt_d : SquadBase
        {
            public IAiActorDefinition starting_locations_0 => Squad.StartingLocations[0];
            public IAiActorDefinition starting_locations_1 => Squad.StartingLocations[1];
            public Squad_gun_cov_elt_d(ScenarioTag ScenarioTag) : base(ScenarioTag, 101, "gun_cov")
            {
            }
        }

        [SpawnCounts(1, 1)]
        public class Squad_gun_hum_mar : SquadBase
        {
            public IAiActorDefinition starting_locations_0 => Squad.StartingLocations[0];
            public IAiActorDefinition starting_locations_1 => Squad.StartingLocations[1];
            public Squad_gun_hum_mar(ScenarioTag ScenarioTag) : base(ScenarioTag, 102, "_1st_hum_balcony")
            {
            }
        }

        [SpawnCounts(1, 1)]
        public class Squad_gun_cortana_1 : SquadBase
        {
            public IAiActorDefinition starting_locations_0 => Squad.StartingLocations[0];
            public Squad_gun_cortana_1(ScenarioTag ScenarioTag) : base(ScenarioTag, 103, "gun_cortana")
            {
            }
        }

        [SpawnCounts(1, 1)]
        public class Squad_gun_cortana_2 : SquadBase
        {
            public IAiActorDefinition starting_locations_0 => Squad.StartingLocations[0];
            public Squad_gun_cortana_2(ScenarioTag ScenarioTag) : base(ScenarioTag, 104, "gun_cortana")
            {
            }
        }

        [SpawnCounts(1, 1)]
        public class Squad_gun_cortana_3 : SquadBase
        {
            public IAiActorDefinition starting_locations_0 => Squad.StartingLocations[0];
            public Squad_gun_cortana_3(ScenarioTag ScenarioTag) : base(ScenarioTag, 105, "gun_cortana")
            {
            }
        }

        [SpawnCounts(1, 1)]
        public class Squad_gun_cortana_4 : SquadBase
        {
            public IAiActorDefinition starting_locations_0 => Squad.StartingLocations[0];
            public Squad_gun_cortana_4(ScenarioTag ScenarioTag) : base(ScenarioTag, 106, "gun_cortana")
            {
            }
        }

        [SpawnCounts(2, 1)]
        public class Squad_elv_hum_mar : SquadBase
        {
            public IAiActorDefinition starting_locations_0 => Squad.StartingLocations[0];
            public IAiActorDefinition starting_locations_1 => Squad.StartingLocations[1];
            public Squad_elv_hum_mar(ScenarioTag ScenarioTag) : base(ScenarioTag, 107)
            {
            }
        }

        [SpawnCounts(1, 1)]
        public class Squad_x02_panic_01 : SquadBase
        {
            public IAiActorDefinition starting_locations_0 => Squad.StartingLocations[0];
            public Squad_x02_panic_01(ScenarioTag ScenarioTag) : base(ScenarioTag, 108)
            {
            }
        }

        [SpawnCounts(1, 1)]
        public class Squad_x02_panic_02 : SquadBase
        {
            public IAiActorDefinition starting_locations_0 => Squad.StartingLocations[0];
            public Squad_x02_panic_02(ScenarioTag ScenarioTag) : base(ScenarioTag, 109)
            {
            }
        }

        [SpawnCounts(1, 1)]
        public class Squad_x02_panic_03 : SquadBase
        {
            public IAiActorDefinition starting_locations_0 => Squad.StartingLocations[0];
            public Squad_x02_panic_03(ScenarioTag ScenarioTag) : base(ScenarioTag, 110)
            {
            }
        }

        [SpawnCounts(1, 1)]
        public class Squad_x02_panic_04 : SquadBase
        {
            public IAiActorDefinition starting_locations_0 => Squad.StartingLocations[0];
            public Squad_x02_panic_04(ScenarioTag ScenarioTag) : base(ScenarioTag, 111)
            {
            }
        }

        [SpawnCounts(2, 2)]
        public class Squad_bay1_cov_wv5_grt : SquadBase
        {
            public IAiActorDefinition starting_locations_0 => Squad.StartingLocations[0];
            public IAiActorDefinition starting_locations_1 => Squad.StartingLocations[1];
            public Squad_bay1_cov_wv5_grt(ScenarioTag ScenarioTag) : base(ScenarioTag, 112, "bay1_cov_wv5")
            {
            }
        }

        [SpawnCounts(1, 1)]
        public class Squad_bay1_cov_wv5_elt : SquadBase
        {
            public IAiActorDefinition starting_locations_0 => Squad.StartingLocations[0];
            public Squad_bay1_cov_wv5_elt(ScenarioTag ScenarioTag) : base(ScenarioTag, 113, "bay1_cov_wv5")
            {
            }
        }

        [SpawnCounts(2, 2)]
        public class Squad_bay2_cov_wv5_grt : SquadBase
        {
            public IAiActorDefinition starting_locations_0 => Squad.StartingLocations[0];
            public IAiActorDefinition starting_locations_1 => Squad.StartingLocations[1];
            public Squad_bay2_cov_wv5_grt(ScenarioTag ScenarioTag) : base(ScenarioTag, 114, "bay2_cov_wv5")
            {
            }
        }

        [SpawnCounts(1, 1)]
        public class Squad_bay2_cov_wv5_elt : SquadBase
        {
            public IAiActorDefinition starting_locations_0 => Squad.StartingLocations[0];
            public Squad_bay2_cov_wv5_elt(ScenarioTag ScenarioTag) : base(ScenarioTag, 115, "bay2_cov_wv5")
            {
            }
        }

        [SpawnCounts(0, 0)]
        public class Squad_lvr_cov_air1 : SquadBase
        {
            public IAiActorDefinition starting_locations_0 => Squad.StartingLocations[0];
            public IAiActorDefinition starting_locations_1 => Squad.StartingLocations[1];
            public Squad_lvr_cov_air1(ScenarioTag ScenarioTag) : base(ScenarioTag, 116, "lvr_cov")
            {
            }
        }
    }
}