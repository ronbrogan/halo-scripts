namespace OpenH2.Scripts.Generatedscenarios.solo
{
    using System;
    using System.Threading.Tasks;
    using OpenH2.Core.Architecture;
    using OpenH2.Core.Tags;
    using OpenH2.Core.Tags.Scenario;
    using OpenH2.Core.Scripting;
    using OpenH2.Core.GameObjects;

    public partial class scnr_07b_forerunnership : ScenarioScriptBase
    {
        public Squad_e1_pro_inf1 e1_pro_inf1 { get; set; }
        public Squad_e1_pro_inf2 e1_pro_inf2 { get; set; }
        public Squad_e1_pro_inf3 e1_pro_inf3 { get; set; }
        public Squad_e1_fld_inf1 e1_fld_inf1 { get; set; }
        public Squad_e1_fld_inf2 e1_fld_inf2 { get; set; }
        public Squad_e1_fld_inf3 e1_fld_inf3 { get; set; }
        public Squad_e1_fld_inf4 e1_fld_inf4 { get; set; }
        public Squad_e1_fld_inf4_z e1_fld_inf4_z { get; set; }
        public Squad_e1_fld_inf5 e1_fld_inf5 { get; set; }
        public Squad_e1_fld_gitem1 e1_fld_gitem1 { get; set; }
        public Squad_e1_fld_gitem2 e1_fld_gitem2 { get; set; }
        public Squad_e1_CS_pelican1 e1_CS_pelican1 { get; set; }
        public Squad_e1_CS_pelican2 e1_CS_pelican2 { get; set; }
        public Squad_e2_pro_inf1 e2_pro_inf1 { get; set; }
        public Squad_e3_pro_inf1 e3_pro_inf1 { get; set; }
        public Squad_e3_pro_inf1_a e3_pro_inf1_a { get; set; }
        public Squad_e3_pro_inf2 e3_pro_inf2 { get; set; }
        public Squad_e5_pro_inf11 e5_pro_inf11 { get; set; }
        public Squad_e5_pro_inf2 e5_pro_inf2 { get; set; }
        public Squad_e5_pro_bug1 e5_pro_bug1 { get; set; }
        public Squad_e5_pro_bug2_b e5_pro_bug2_b { get; set; }
        public Squad_e5_pro_bug2_c e5_pro_bug2_c { get; set; }
        public Squad_e5_fld_inf1 e5_fld_inf1 { get; set; }
        public Squad_e5_fld_inf2 e5_fld_inf2 { get; set; }
        public Squad_e5_fld_inf2_z e5_fld_inf2_z { get; set; }
        public Squad_e6_pro_inf2 e6_pro_inf2 { get; set; }
        public Squad_e6_pro_inf2_a e6_pro_inf2_a { get; set; }
        public Squad_e6_pro_inf3 e6_pro_inf3 { get; set; }
        public Squad_e6_pro_inf3_a e6_pro_inf3_a { get; set; }
        public Squad_e6_fld_inf1 e6_fld_inf1 { get; set; }
        public Squad_e6_fld_inf1_a e6_fld_inf1_a { get; set; }
        public Squad_e6_fld_inf2_z e6_fld_inf2_z { get; set; }
        public Squad_e6_fld_inf2_a e6_fld_inf2_a { get; set; }
        public Squad_e6_fld_inf2_b e6_fld_inf2_b { get; set; }
        public Squad_e6_fld_inf2_c e6_fld_inf2_c { get; set; }
        public Squad_e6_fld_inf2_d e6_fld_inf2_d { get; set; }
        public Squad_e6_fld_inf3 e6_fld_inf3 { get; set; }
        public Squad_e6_fld_inf4 e6_fld_inf4 { get; set; }
        public Squad_e6_fld_inf5 e6_fld_inf5 { get; set; }
        public Squad_e6_fld_swarm3 e6_fld_swarm3 { get; set; }
        public Squad_e8_pro_inf1 e8_pro_inf1 { get; set; }
        public Squad_e8_fld_inf1 e8_fld_inf1 { get; set; }
        public Squad_e8_fld_swarm1 e8_fld_swarm1 { get; set; }
        public Squad_e9_fld_swarm1 e9_fld_swarm1 { get; set; }
        public Squad_e9_fld_swarm2 e9_fld_swarm2 { get; set; }
        public Squad_e9_fld_inf11 e9_fld_inf11 { get; set; }
        public Squad_e9_fld_inf2 e9_fld_inf2 { get; set; }
        public Squad_e9_fld_inf3_a e9_fld_inf3_a { get; set; }
        public Squad_e9_fld_inf3_b e9_fld_inf3_b { get; set; }
        public Squad_e9_fld_inf3_c e9_fld_inf3_c { get; set; }
        public Squad_e9_fld_inf3_d e9_fld_inf3_d { get; set; }
        public Squad_e9_fld_inf3_e e9_fld_inf3_e { get; set; }
        public Squad_e9_fld_inf3_f e9_fld_inf3_f { get; set; }
        public Squad_e10_pro_inf1 e10_pro_inf1 { get; set; }
        public Squad_e10_pro_inf1_a e10_pro_inf1_a { get; set; }
        public Squad_e10_fld_inf1 e10_fld_inf1 { get; set; }
        public Squad_e10_cov_inf11 e10_cov_inf11 { get; set; }
        public Squad_e10_fld_swarm1 e10_fld_swarm1 { get; set; }
        public Squad_e11_pro_inf1 e11_pro_inf1 { get; set; }
        public Squad_e11_fld_inf1 e11_fld_inf1 { get; set; }
        public Squad_e12_cov_inf1 e12_cov_inf1 { get; set; }
        public Squad_e12_pro_inf2_left1 e12_pro_inf2_left1 { get; set; }
        public Squad_e12_pro_inf2_right1 e12_pro_inf2_right1 { get; set; }
        public Squad_e12_pro_inf3_end e12_pro_inf3_end { get; set; }
        public Squad_e12_pro_inf4_right1 e12_pro_inf4_right1 { get; set; }
        public Squad_e12_pro_inf4_left1 e12_pro_inf4_left1 { get; set; }
        public Squad_e12_fld_inf3_right e12_fld_inf3_right { get; set; }
        public Squad_e12_fld_inf2_right e12_fld_inf2_right { get; set; }
        public Squad_e12_fld_inf1_right e12_fld_inf1_right { get; set; }
        public Squad_e12_fld_inf3_left e12_fld_inf3_left { get; set; }
        public Squad_e12_fld_inf2_left e12_fld_inf2_left { get; set; }
        public Squad_e12_fld_inf1_left e12_fld_inf1_left { get; set; }
        public Squad_e12_fld_inf4 e12_fld_inf4 { get; set; }
        public Squad_e12_CS_pelican1 e12_CS_pelican1 { get; set; }
        public Squad_e12_CS_banshee1 e12_CS_banshee1 { get; set; }
        public Squad_cinematic_fld_inf0 cinematic_fld_inf0 { get; set; }
        public Squad_cinematic_fld_inf1 cinematic_fld_inf1 { get; set; }
        public Squad_cortana1 cortana1 { get; set; }
        [SpawnCounts(2, 2)]
        public class Squad_e1_pro_inf1 : SquadBase
        {
            public IAiActorDefinition starting_locations_0 => Squad.StartingLocations[0];
            public IAiActorDefinition starting_locations_1 => Squad.StartingLocations[1];
            public Squad_e1_pro_inf1(ScenarioTag ScenarioTag) : base(ScenarioTag, 0, "e1_prophets_ledge")
            {
            }
        }

        [SpawnCounts(4, 4)]
        public class Squad_e1_pro_inf2 : SquadBase
        {
            public IAiActorDefinition guy1 => Squad.StartingLocations[0];
            public IAiActorDefinition guy2 => Squad.StartingLocations[1];
            public IAiActorDefinition guy4 => Squad.StartingLocations[2];
            public IAiActorDefinition guy5 => Squad.StartingLocations[3];
            public Squad_e1_pro_inf2(ScenarioTag ScenarioTag) : base(ScenarioTag, 1, "e1_prophets_ledge")
            {
            }
        }

        [SpawnCounts(4, 4)]
        public class Squad_e1_pro_inf3 : SquadBase
        {
            public IAiActorDefinition starting_locations_0 => Squad.StartingLocations[0];
            public IAiActorDefinition starting_locations_1 => Squad.StartingLocations[1];
            public IAiActorDefinition starting_locations_2 => Squad.StartingLocations[2];
            public IAiActorDefinition starting_locations_3 => Squad.StartingLocations[3];
            public Squad_e1_pro_inf3(ScenarioTag ScenarioTag) : base(ScenarioTag, 2, "e1_prophets_master")
            {
            }
        }

        [SpawnCounts(7, 7)]
        public class Squad_e1_fld_inf1 : SquadBase
        {
            public IAiActorDefinition guy1 => Squad.StartingLocations[0];
            public IAiActorDefinition guy2 => Squad.StartingLocations[1];
            public IAiActorDefinition guy3 => Squad.StartingLocations[2];
            public IAiActorDefinition guy4 => Squad.StartingLocations[3];
            public IAiActorDefinition guy5 => Squad.StartingLocations[4];
            public IAiActorDefinition guy6 => Squad.StartingLocations[5];
            public IAiActorDefinition guy7 => Squad.StartingLocations[6];
            public Squad_e1_fld_inf1(ScenarioTag ScenarioTag) : base(ScenarioTag, 3, "e1_flood_group_1")
            {
            }
        }

        [SpawnCounts(6, 6)]
        public class Squad_e1_fld_inf2 : SquadBase
        {
            public IAiActorDefinition starting_locations_0 => Squad.StartingLocations[0];
            public IAiActorDefinition starting_locations_1 => Squad.StartingLocations[1];
            public IAiActorDefinition starting_locations_2 => Squad.StartingLocations[2];
            public IAiActorDefinition starting_locations_3 => Squad.StartingLocations[3];
            public IAiActorDefinition starting_locations_4 => Squad.StartingLocations[4];
            public IAiActorDefinition starting_locations_5 => Squad.StartingLocations[5];
            public Squad_e1_fld_inf2(ScenarioTag ScenarioTag) : base(ScenarioTag, 4, "e1_flood_group_2")
            {
            }
        }

        [SpawnCounts(3, 3)]
        public class Squad_e1_fld_inf3 : SquadBase
        {
            public IAiActorDefinition carrier0 => Squad.StartingLocations[0];
            public IAiActorDefinition carrier1 => Squad.StartingLocations[1];
            public IAiActorDefinition starting_locations_2 => Squad.StartingLocations[2];
            public Squad_e1_fld_inf3(ScenarioTag ScenarioTag) : base(ScenarioTag, 5, "e1_flood_group_2")
            {
            }
        }

        [SpawnCounts(6, 6)]
        public class Squad_e1_fld_inf4 : SquadBase
        {
            public IAiActorDefinition guy1 => Squad.StartingLocations[0];
            public IAiActorDefinition guy2 => Squad.StartingLocations[1];
            public IAiActorDefinition guy3 => Squad.StartingLocations[2];
            public IAiActorDefinition guy4 => Squad.StartingLocations[3];
            public IAiActorDefinition guy5 => Squad.StartingLocations[4];
            public IAiActorDefinition guy6 => Squad.StartingLocations[5];
            public Squad_e1_fld_inf4(ScenarioTag ScenarioTag) : base(ScenarioTag, 6, "e1_flood_group_1")
            {
            }
        }

        [SpawnCounts(6, 6)]
        public class Squad_e1_fld_inf4_z : SquadBase
        {
            public IAiActorDefinition starting_locations_0 => Squad.StartingLocations[0];
            public IAiActorDefinition starting_locations_1 => Squad.StartingLocations[1];
            public IAiActorDefinition starting_locations_2 => Squad.StartingLocations[2];
            public IAiActorDefinition starting_locations_3 => Squad.StartingLocations[3];
            public IAiActorDefinition starting_locations_4 => Squad.StartingLocations[4];
            public IAiActorDefinition starting_locations_5 => Squad.StartingLocations[5];
            public Squad_e1_fld_inf4_z(ScenarioTag ScenarioTag) : base(ScenarioTag, 7, "e1_flood_group_1")
            {
            }
        }

        [SpawnCounts(5, 5)]
        public class Squad_e1_fld_inf5 : SquadBase
        {
            public IAiActorDefinition starting_locations_0 => Squad.StartingLocations[0];
            public IAiActorDefinition starting_locations_1 => Squad.StartingLocations[1];
            public IAiActorDefinition starting_locations_2 => Squad.StartingLocations[2];
            public IAiActorDefinition starting_locations_3 => Squad.StartingLocations[3];
            public IAiActorDefinition starting_locations_4 => Squad.StartingLocations[4];
            public Squad_e1_fld_inf5(ScenarioTag ScenarioTag) : base(ScenarioTag, 8, "e1_flood_master")
            {
            }
        }

        [SpawnCounts(2, 2)]
        public class Squad_e1_fld_gitem1 : SquadBase
        {
            public IAiActorDefinition guy1 => Squad.StartingLocations[0];
            public IAiActorDefinition guy2 => Squad.StartingLocations[1];
            public Squad_e1_fld_gitem1(ScenarioTag ScenarioTag) : base(ScenarioTag, 9, "e1_flood_master")
            {
            }
        }

        [SpawnCounts(2, 2)]
        public class Squad_e1_fld_gitem2 : SquadBase
        {
            public IAiActorDefinition guy1 => Squad.StartingLocations[0];
            public IAiActorDefinition guy2 => Squad.StartingLocations[1];
            public Squad_e1_fld_gitem2(ScenarioTag ScenarioTag) : base(ScenarioTag, 10, "e1_flood_master")
            {
            }
        }

        [SpawnCounts(1, 1)]
        public class Squad_e1_CS_pelican1 : SquadBase
        {
            public IAiActorDefinition pilot => Squad.StartingLocations[0];
            public Squad_e1_CS_pelican1(ScenarioTag ScenarioTag) : base(ScenarioTag, 11)
            {
            }
        }

        [SpawnCounts(0, 0)]
        public class Squad_e1_CS_pelican2 : SquadBase
        {
            public IAiActorDefinition pilot => Squad.StartingLocations[0];
            public Squad_e1_CS_pelican2(ScenarioTag ScenarioTag) : base(ScenarioTag, 12)
            {
            }
        }

        [SpawnCounts(2, 2)]
        public class Squad_e2_pro_inf1 : SquadBase
        {
            public IAiActorDefinition guy1 => Squad.StartingLocations[0];
            public IAiActorDefinition guy2 => Squad.StartingLocations[1];
            public Squad_e2_pro_inf1(ScenarioTag ScenarioTag) : base(ScenarioTag, 13)
            {
            }
        }

        [SpawnCounts(2, 2)]
        public class Squad_e3_pro_inf1 : SquadBase
        {
            public IAiActorDefinition starting_locations_0 => Squad.StartingLocations[0];
            public IAiActorDefinition starting_locations_1 => Squad.StartingLocations[1];
            public Squad_e3_pro_inf1(ScenarioTag ScenarioTag) : base(ScenarioTag, 14)
            {
            }
        }

        [SpawnCounts(2, 2)]
        public class Squad_e3_pro_inf1_a : SquadBase
        {
            public IAiActorDefinition guy1 => Squad.StartingLocations[0];
            public IAiActorDefinition guy2 => Squad.StartingLocations[1];
            public IAiActorDefinition guy3 => Squad.StartingLocations[2];
            public IAiActorDefinition guy4 => Squad.StartingLocations[3];
            public Squad_e3_pro_inf1_a(ScenarioTag ScenarioTag) : base(ScenarioTag, 15)
            {
            }
        }

        [SpawnCounts(4, 4)]
        public class Squad_e3_pro_inf2 : SquadBase
        {
            public IAiActorDefinition starting_locations_0 => Squad.StartingLocations[0];
            public IAiActorDefinition starting_locations_2 => Squad.StartingLocations[1];
            public IAiActorDefinition starting_locations_3 => Squad.StartingLocations[2];
            public IAiActorDefinition starting_locations_4 => Squad.StartingLocations[3];
            public Squad_e3_pro_inf2(ScenarioTag ScenarioTag) : base(ScenarioTag, 16)
            {
            }
        }

        [SpawnCounts(1, 1)]
        public class Squad_e5_pro_inf11 : SquadBase
        {
            public IAiActorDefinition starting_locations_2 => Squad.StartingLocations[0];
            public Squad_e5_pro_inf11(ScenarioTag ScenarioTag) : base(ScenarioTag, 17)
            {
            }
        }

        [SpawnCounts(1, 1)]
        public class Squad_e5_pro_inf2 : SquadBase
        {
            public IAiActorDefinition starting_locations_0 => Squad.StartingLocations[0];
            public Squad_e5_pro_inf2(ScenarioTag ScenarioTag) : base(ScenarioTag, 18)
            {
            }
        }

        [SpawnCounts(10, 10)]
        public class Squad_e5_pro_bug1 : SquadBase
        {
            public IAiActorDefinition starting_locations_0 => Squad.StartingLocations[0];
            public IAiActorDefinition starting_locations_1 => Squad.StartingLocations[1];
            public IAiActorDefinition starting_locations_2 => Squad.StartingLocations[2];
            public IAiActorDefinition starting_locations_4 => Squad.StartingLocations[3];
            public IAiActorDefinition starting_locations_41 => Squad.StartingLocations[4];
            public IAiActorDefinition starting_locations_5 => Squad.StartingLocations[5];
            public IAiActorDefinition starting_locations_6 => Squad.StartingLocations[6];
            public IAiActorDefinition starting_locations_7 => Squad.StartingLocations[7];
            public IAiActorDefinition starting_locations_8 => Squad.StartingLocations[8];
            public IAiActorDefinition starting_locations_9 => Squad.StartingLocations[9];
            public Squad_e5_pro_bug1(ScenarioTag ScenarioTag) : base(ScenarioTag, 19, "e5_buggers")
            {
            }
        }

        [SpawnCounts(5, 5)]
        public class Squad_e5_pro_bug2_b : SquadBase
        {
            public IAiActorDefinition guy1 => Squad.StartingLocations[0];
            public IAiActorDefinition guy2 => Squad.StartingLocations[1];
            public IAiActorDefinition guy3 => Squad.StartingLocations[2];
            public IAiActorDefinition guy4 => Squad.StartingLocations[3];
            public Squad_e5_pro_bug2_b(ScenarioTag ScenarioTag) : base(ScenarioTag, 20, "e5_buggers")
            {
            }
        }

        [SpawnCounts(5, 5)]
        public class Squad_e5_pro_bug2_c : SquadBase
        {
            public IAiActorDefinition guy1 => Squad.StartingLocations[0];
            public IAiActorDefinition guy2 => Squad.StartingLocations[1];
            public IAiActorDefinition guy3 => Squad.StartingLocations[2];
            public IAiActorDefinition guy4 => Squad.StartingLocations[3];
            public IAiActorDefinition guy5 => Squad.StartingLocations[4];
            public Squad_e5_pro_bug2_c(ScenarioTag ScenarioTag) : base(ScenarioTag, 21, "e5_buggers")
            {
            }
        }

        [SpawnCounts(6, 6)]
        public class Squad_e5_fld_inf1 : SquadBase
        {
            public IAiActorDefinition starting_locations_0 => Squad.StartingLocations[0];
            public IAiActorDefinition starting_locations_1 => Squad.StartingLocations[1];
            public IAiActorDefinition starting_locations_2 => Squad.StartingLocations[2];
            public IAiActorDefinition starting_locations_3 => Squad.StartingLocations[3];
            public IAiActorDefinition starting_locations_4 => Squad.StartingLocations[4];
            public IAiActorDefinition starting_locations_5 => Squad.StartingLocations[5];
            public Squad_e5_fld_inf1(ScenarioTag ScenarioTag) : base(ScenarioTag, 22, "e5_flood_master")
            {
            }
        }

        [SpawnCounts(3, 3)]
        public class Squad_e5_fld_inf2 : SquadBase
        {
            public IAiActorDefinition starting_locations_0 => Squad.StartingLocations[0];
            public IAiActorDefinition starting_locations_1 => Squad.StartingLocations[1];
            public IAiActorDefinition starting_locations_2 => Squad.StartingLocations[2];
            public Squad_e5_fld_inf2(ScenarioTag ScenarioTag) : base(ScenarioTag, 23, "e5_flood_master")
            {
            }
        }

        [SpawnCounts(3, 3)]
        public class Squad_e5_fld_inf2_z : SquadBase
        {
            public IAiActorDefinition starting_locations_0 => Squad.StartingLocations[0];
            public IAiActorDefinition starting_locations_1 => Squad.StartingLocations[1];
            public IAiActorDefinition starting_locations_2 => Squad.StartingLocations[2];
            public Squad_e5_fld_inf2_z(ScenarioTag ScenarioTag) : base(ScenarioTag, 24, "e5_flood_master")
            {
            }
        }

        [SpawnCounts(4, 4)]
        public class Squad_e6_pro_inf2 : SquadBase
        {
            public IAiActorDefinition starting_locations_0 => Squad.StartingLocations[0];
            public IAiActorDefinition starting_locations_1 => Squad.StartingLocations[1];
            public IAiActorDefinition starting_locations_2 => Squad.StartingLocations[2];
            public IAiActorDefinition starting_locations_3 => Squad.StartingLocations[3];
            public Squad_e6_pro_inf2(ScenarioTag ScenarioTag) : base(ScenarioTag, 25, "e6_pro_hall_grp_2")
            {
            }
        }

        [SpawnCounts(8, 8)]
        public class Squad_e6_pro_inf2_a : SquadBase
        {
            public IAiActorDefinition starting_locations_0 => Squad.StartingLocations[0];
            public IAiActorDefinition starting_locations_1 => Squad.StartingLocations[1];
            public IAiActorDefinition starting_locations_2 => Squad.StartingLocations[2];
            public IAiActorDefinition starting_locations_3 => Squad.StartingLocations[3];
            public IAiActorDefinition starting_locations_4 => Squad.StartingLocations[4];
            public IAiActorDefinition starting_locations_5 => Squad.StartingLocations[5];
            public IAiActorDefinition starting_locations_6 => Squad.StartingLocations[6];
            public IAiActorDefinition starting_locations_7 => Squad.StartingLocations[7];
            public Squad_e6_pro_inf2_a(ScenarioTag ScenarioTag) : base(ScenarioTag, 26, "e6_pro_hall_grp_2")
            {
            }
        }

        [SpawnCounts(4, 4)]
        public class Squad_e6_pro_inf3 : SquadBase
        {
            public IAiActorDefinition guy1 => Squad.StartingLocations[0];
            public IAiActorDefinition guy2 => Squad.StartingLocations[1];
            public IAiActorDefinition guy3 => Squad.StartingLocations[2];
            public IAiActorDefinition guy4 => Squad.StartingLocations[3];
            public Squad_e6_pro_inf3(ScenarioTag ScenarioTag) : base(ScenarioTag, 27, "e6_pro_cave1")
            {
            }
        }

        [SpawnCounts(7, 7)]
        public class Squad_e6_pro_inf3_a : SquadBase
        {
            public IAiActorDefinition guy1 => Squad.StartingLocations[0];
            public IAiActorDefinition guy2 => Squad.StartingLocations[1];
            public IAiActorDefinition guy4 => Squad.StartingLocations[2];
            public IAiActorDefinition guy5 => Squad.StartingLocations[3];
            public IAiActorDefinition guy6 => Squad.StartingLocations[4];
            public IAiActorDefinition guy8 => Squad.StartingLocations[5];
            public Squad_e6_pro_inf3_a(ScenarioTag ScenarioTag) : base(ScenarioTag, 28, "e6_pro_cave1")
            {
            }
        }

        [SpawnCounts(12, 12)]
        public class Squad_e6_fld_inf1 : SquadBase
        {
            public IAiActorDefinition starting_locations_0 => Squad.StartingLocations[0];
            public IAiActorDefinition starting_locations_1 => Squad.StartingLocations[1];
            public IAiActorDefinition starting_locations_2 => Squad.StartingLocations[2];
            public IAiActorDefinition starting_locations_3 => Squad.StartingLocations[3];
            public IAiActorDefinition starting_locations_4 => Squad.StartingLocations[4];
            public IAiActorDefinition starting_locations_6 => Squad.StartingLocations[5];
            public IAiActorDefinition starting_locations_7 => Squad.StartingLocations[6];
            public IAiActorDefinition starting_locations_8 => Squad.StartingLocations[7];
            public IAiActorDefinition starting_locations_9 => Squad.StartingLocations[8];
            public IAiActorDefinition starting_locations_10 => Squad.StartingLocations[9];
            public IAiActorDefinition starting_locations_11 => Squad.StartingLocations[10];
            public IAiActorDefinition starting_locations_12 => Squad.StartingLocations[11];
            public Squad_e6_fld_inf1(ScenarioTag ScenarioTag) : base(ScenarioTag, 29, "e6_flood_group_1")
            {
            }
        }

        [SpawnCounts(4, 4)]
        public class Squad_e6_fld_inf1_a : SquadBase
        {
            public IAiActorDefinition guy1 => Squad.StartingLocations[0];
            public IAiActorDefinition guy2 => Squad.StartingLocations[1];
            public IAiActorDefinition guy3 => Squad.StartingLocations[2];
            public IAiActorDefinition guy4 => Squad.StartingLocations[3];
            public Squad_e6_fld_inf1_a(ScenarioTag ScenarioTag) : base(ScenarioTag, 30, "e6_flood_group_1")
            {
            }
        }

        [SpawnCounts(4, 4)]
        public class Squad_e6_fld_inf2_z : SquadBase
        {
            public IAiActorDefinition guy1 => Squad.StartingLocations[0];
            public IAiActorDefinition guy2 => Squad.StartingLocations[1];
            public IAiActorDefinition guy3 => Squad.StartingLocations[2];
            public IAiActorDefinition guy4 => Squad.StartingLocations[3];
            public Squad_e6_fld_inf2_z(ScenarioTag ScenarioTag) : base(ScenarioTag, 31, "e6_flood_group_2")
            {
            }
        }

        [SpawnCounts(2, 2)]
        public class Squad_e6_fld_inf2_a : SquadBase
        {
            public IAiActorDefinition guy1 => Squad.StartingLocations[0];
            public IAiActorDefinition guy2 => Squad.StartingLocations[1];
            public IAiActorDefinition guy3 => Squad.StartingLocations[2];
            public Squad_e6_fld_inf2_a(ScenarioTag ScenarioTag) : base(ScenarioTag, 32, "e6_flood_group_2")
            {
            }
        }

        [SpawnCounts(3, 3)]
        public class Squad_e6_fld_inf2_b : SquadBase
        {
            public IAiActorDefinition guy1 => Squad.StartingLocations[0];
            public IAiActorDefinition guy2 => Squad.StartingLocations[1];
            public IAiActorDefinition guy3 => Squad.StartingLocations[2];
            public Squad_e6_fld_inf2_b(ScenarioTag ScenarioTag) : base(ScenarioTag, 33, "e6_flood_group_2")
            {
            }
        }

        [SpawnCounts(2, 2)]
        public class Squad_e6_fld_inf2_c : SquadBase
        {
            public IAiActorDefinition guy1 => Squad.StartingLocations[0];
            public IAiActorDefinition guy2 => Squad.StartingLocations[1];
            public IAiActorDefinition guy3 => Squad.StartingLocations[2];
            public Squad_e6_fld_inf2_c(ScenarioTag ScenarioTag) : base(ScenarioTag, 34, "e6_flood_group_2")
            {
            }
        }

        [SpawnCounts(3, 3)]
        public class Squad_e6_fld_inf2_d : SquadBase
        {
            public IAiActorDefinition guy1 => Squad.StartingLocations[0];
            public IAiActorDefinition guy2 => Squad.StartingLocations[1];
            public IAiActorDefinition guy3 => Squad.StartingLocations[2];
            public Squad_e6_fld_inf2_d(ScenarioTag ScenarioTag) : base(ScenarioTag, 35, "e6_flood_group_2")
            {
            }
        }

        [SpawnCounts(2, 2)]
        public class Squad_e6_fld_inf3 : SquadBase
        {
            public IAiActorDefinition starting_locations_0 => Squad.StartingLocations[0];
            public IAiActorDefinition starting_locations_1 => Squad.StartingLocations[1];
            public Squad_e6_fld_inf3(ScenarioTag ScenarioTag) : base(ScenarioTag, 36, "e6_flood_group_3")
            {
            }
        }

        [SpawnCounts(8, 8)]
        public class Squad_e6_fld_inf4 : SquadBase
        {
            public IAiActorDefinition guy1 => Squad.StartingLocations[0];
            public IAiActorDefinition guy2 => Squad.StartingLocations[1];
            public IAiActorDefinition guy3 => Squad.StartingLocations[2];
            public IAiActorDefinition guy4 => Squad.StartingLocations[3];
            public IAiActorDefinition guy5 => Squad.StartingLocations[4];
            public IAiActorDefinition guy6 => Squad.StartingLocations[5];
            public IAiActorDefinition guy7 => Squad.StartingLocations[6];
            public IAiActorDefinition guy8 => Squad.StartingLocations[7];
            public IAiActorDefinition guy9 => Squad.StartingLocations[8];
            public IAiActorDefinition guy10 => Squad.StartingLocations[9];
            public Squad_e6_fld_inf4(ScenarioTag ScenarioTag) : base(ScenarioTag, 37, "e6_flood_storm")
            {
            }
        }

        [SpawnCounts(6, 6)]
        public class Squad_e6_fld_inf5 : SquadBase
        {
            public IAiActorDefinition guy1 => Squad.StartingLocations[0];
            public IAiActorDefinition guy2 => Squad.StartingLocations[1];
            public IAiActorDefinition guy3 => Squad.StartingLocations[2];
            public IAiActorDefinition guy4 => Squad.StartingLocations[3];
            public IAiActorDefinition guy5 => Squad.StartingLocations[4];
            public IAiActorDefinition guy6 => Squad.StartingLocations[5];
            public Squad_e6_fld_inf5(ScenarioTag ScenarioTag) : base(ScenarioTag, 38, "e6_flood_group_3")
            {
            }
        }

        [SpawnCounts(0, 0)]
        public class Squad_e6_fld_swarm3 : SquadBase
        {
            public IAiActorDefinition swarm1 => Squad.StartingLocations[0];
            public IAiActorDefinition swarm2 => Squad.StartingLocations[1];
            public Squad_e6_fld_swarm3(ScenarioTag ScenarioTag) : base(ScenarioTag, 39)
            {
            }
        }

        [SpawnCounts(6, 6)]
        public class Squad_e8_pro_inf1 : SquadBase
        {
            public IAiActorDefinition guy1 => Squad.StartingLocations[0];
            public IAiActorDefinition guy2 => Squad.StartingLocations[1];
            public IAiActorDefinition guy3 => Squad.StartingLocations[2];
            public IAiActorDefinition guy4 => Squad.StartingLocations[3];
            public IAiActorDefinition guy5 => Squad.StartingLocations[4];
            public IAiActorDefinition guy6 => Squad.StartingLocations[5];
            public Squad_e8_pro_inf1(ScenarioTag ScenarioTag) : base(ScenarioTag, 40)
            {
            }
        }

        [SpawnCounts(12, 12)]
        public class Squad_e8_fld_inf1 : SquadBase
        {
            public IAiActorDefinition guy1 => Squad.StartingLocations[0];
            public IAiActorDefinition guy2 => Squad.StartingLocations[1];
            public IAiActorDefinition guy3 => Squad.StartingLocations[2];
            public IAiActorDefinition guy4 => Squad.StartingLocations[3];
            public IAiActorDefinition guy5 => Squad.StartingLocations[4];
            public IAiActorDefinition guy6 => Squad.StartingLocations[5];
            public IAiActorDefinition guy7 => Squad.StartingLocations[6];
            public IAiActorDefinition guy8 => Squad.StartingLocations[7];
            public IAiActorDefinition guy9 => Squad.StartingLocations[8];
            public IAiActorDefinition guy10 => Squad.StartingLocations[9];
            public IAiActorDefinition guy11 => Squad.StartingLocations[10];
            public IAiActorDefinition guy12 => Squad.StartingLocations[11];
            public Squad_e8_fld_inf1(ScenarioTag ScenarioTag) : base(ScenarioTag, 41)
            {
            }
        }

        [SpawnCounts(2, 2)]
        public class Squad_e8_fld_swarm1 : SquadBase
        {
            public IAiActorDefinition swarm1 => Squad.StartingLocations[0];
            public IAiActorDefinition swarm2 => Squad.StartingLocations[1];
            public Squad_e8_fld_swarm1(ScenarioTag ScenarioTag) : base(ScenarioTag, 42)
            {
            }
        }

        [SpawnCounts(3, 3)]
        public class Squad_e9_fld_swarm1 : SquadBase
        {
            public IAiActorDefinition swarm1 => Squad.StartingLocations[0];
            public IAiActorDefinition swarm2 => Squad.StartingLocations[1];
            public IAiActorDefinition swarm3 => Squad.StartingLocations[2];
            public Squad_e9_fld_swarm1(ScenarioTag ScenarioTag) : base(ScenarioTag, 43)
            {
            }
        }

        [SpawnCounts(2, 2)]
        public class Squad_e9_fld_swarm2 : SquadBase
        {
            public IAiActorDefinition starting_locations_0 => Squad.StartingLocations[0];
            public IAiActorDefinition starting_locations_1 => Squad.StartingLocations[1];
            public Squad_e9_fld_swarm2(ScenarioTag ScenarioTag) : base(ScenarioTag, 44)
            {
            }
        }

        [SpawnCounts(3, 3)]
        public class Squad_e9_fld_inf11 : SquadBase
        {
            public IAiActorDefinition guy1 => Squad.StartingLocations[0];
            public IAiActorDefinition guy2 => Squad.StartingLocations[1];
            public IAiActorDefinition guy3 => Squad.StartingLocations[2];
            public Squad_e9_fld_inf11(ScenarioTag ScenarioTag) : base(ScenarioTag, 45)
            {
            }
        }

        [SpawnCounts(3, 3)]
        public class Squad_e9_fld_inf2 : SquadBase
        {
            public Squad_e9_fld_inf2(ScenarioTag ScenarioTag) : base(ScenarioTag, 46, "e9_flood_master")
            {
            }
        }

        [SpawnCounts(3, 3)]
        public class Squad_e9_fld_inf3_a : SquadBase
        {
            public IAiActorDefinition starting_locations_0 => Squad.StartingLocations[0];
            public IAiActorDefinition starting_locations_1 => Squad.StartingLocations[1];
            public IAiActorDefinition starting_locations_2 => Squad.StartingLocations[2];
            public Squad_e9_fld_inf3_a(ScenarioTag ScenarioTag) : base(ScenarioTag, 47, "e9_flood_master")
            {
            }
        }

        [SpawnCounts(3, 3)]
        public class Squad_e9_fld_inf3_b : SquadBase
        {
            public IAiActorDefinition starting_locations_0 => Squad.StartingLocations[0];
            public IAiActorDefinition starting_locations_1 => Squad.StartingLocations[1];
            public IAiActorDefinition starting_locations_2 => Squad.StartingLocations[2];
            public Squad_e9_fld_inf3_b(ScenarioTag ScenarioTag) : base(ScenarioTag, 48, "e9_flood_master")
            {
            }
        }

        [SpawnCounts(3, 3)]
        public class Squad_e9_fld_inf3_c : SquadBase
        {
            public IAiActorDefinition starting_locations_0 => Squad.StartingLocations[0];
            public IAiActorDefinition starting_locations_1 => Squad.StartingLocations[1];
            public IAiActorDefinition starting_locations_2 => Squad.StartingLocations[2];
            public Squad_e9_fld_inf3_c(ScenarioTag ScenarioTag) : base(ScenarioTag, 49, "e9_flood_master")
            {
            }
        }

        [SpawnCounts(2, 2)]
        public class Squad_e9_fld_inf3_d : SquadBase
        {
            public IAiActorDefinition starting_locations_0 => Squad.StartingLocations[0];
            public IAiActorDefinition starting_locations_1 => Squad.StartingLocations[1];
            public Squad_e9_fld_inf3_d(ScenarioTag ScenarioTag) : base(ScenarioTag, 50, "e9_flood_master")
            {
            }
        }

        [SpawnCounts(2, 2)]
        public class Squad_e9_fld_inf3_e : SquadBase
        {
            public IAiActorDefinition starting_locations_0 => Squad.StartingLocations[0];
            public IAiActorDefinition starting_locations_1 => Squad.StartingLocations[1];
            public Squad_e9_fld_inf3_e(ScenarioTag ScenarioTag) : base(ScenarioTag, 51, "e9_flood_master")
            {
            }
        }

        [SpawnCounts(2, 2)]
        public class Squad_e9_fld_inf3_f : SquadBase
        {
            public IAiActorDefinition starting_locations_0 => Squad.StartingLocations[0];
            public IAiActorDefinition starting_locations_1 => Squad.StartingLocations[1];
            public Squad_e9_fld_inf3_f(ScenarioTag ScenarioTag) : base(ScenarioTag, 52, "e9_flood_master")
            {
            }
        }

        [SpawnCounts(3, 3)]
        public class Squad_e10_pro_inf1 : SquadBase
        {
            public IAiActorDefinition starting_locations_0 => Squad.StartingLocations[0];
            public IAiActorDefinition starting_locations_1 => Squad.StartingLocations[1];
            public IAiActorDefinition starting_locations_2 => Squad.StartingLocations[2];
            public IAiActorDefinition starting_locations_3 => Squad.StartingLocations[3];
            public Squad_e10_pro_inf1(ScenarioTag ScenarioTag) : base(ScenarioTag, 53, "e10_pro_inner_sanctum")
            {
            }
        }

        [SpawnCounts(3, 3)]
        public class Squad_e10_pro_inf1_a : SquadBase
        {
            public IAiActorDefinition starting_locations_1 => Squad.StartingLocations[0];
            public IAiActorDefinition starting_locations_2 => Squad.StartingLocations[1];
            public IAiActorDefinition starting_locations_4 => Squad.StartingLocations[2];
            public IAiActorDefinition starting_locations_5 => Squad.StartingLocations[3];
            public IAiActorDefinition starting_locations_7 => Squad.StartingLocations[4];
            public Squad_e10_pro_inf1_a(ScenarioTag ScenarioTag) : base(ScenarioTag, 54, "e10_pro_inner_sanctum")
            {
            }
        }

        [SpawnCounts(12, 12)]
        public class Squad_e10_fld_inf1 : SquadBase
        {
            public IAiActorDefinition guy1 => Squad.StartingLocations[0];
            public IAiActorDefinition guy2 => Squad.StartingLocations[1];
            public IAiActorDefinition guy3 => Squad.StartingLocations[2];
            public IAiActorDefinition guy4 => Squad.StartingLocations[3];
            public IAiActorDefinition guy5 => Squad.StartingLocations[4];
            public IAiActorDefinition guy6 => Squad.StartingLocations[5];
            public IAiActorDefinition guy7 => Squad.StartingLocations[6];
            public IAiActorDefinition guy8 => Squad.StartingLocations[7];
            public IAiActorDefinition guy9 => Squad.StartingLocations[8];
            public IAiActorDefinition guy10 => Squad.StartingLocations[9];
            public IAiActorDefinition guy11 => Squad.StartingLocations[10];
            public IAiActorDefinition guy12 => Squad.StartingLocations[11];
            public Squad_e10_fld_inf1(ScenarioTag ScenarioTag) : base(ScenarioTag, 55, "e10_flood_storm")
            {
            }
        }

        [SpawnCounts(4, 4)]
        public class Squad_e10_cov_inf11 : SquadBase
        {
            public IAiActorDefinition starting_locations_0 => Squad.StartingLocations[0];
            public IAiActorDefinition starting_locations_1 => Squad.StartingLocations[1];
            public IAiActorDefinition starting_locations_2 => Squad.StartingLocations[2];
            public IAiActorDefinition starting_locations_3 => Squad.StartingLocations[3];
            public Squad_e10_cov_inf11(ScenarioTag ScenarioTag) : base(ScenarioTag, 56)
            {
            }
        }

        [SpawnCounts(2, 2)]
        public class Squad_e10_fld_swarm1 : SquadBase
        {
            public IAiActorDefinition swarm1 => Squad.StartingLocations[0];
            public IAiActorDefinition swarm2 => Squad.StartingLocations[1];
            public IAiActorDefinition swarm3 => Squad.StartingLocations[2];
            public IAiActorDefinition starting_locations_3 => Squad.StartingLocations[3];
            public Squad_e10_fld_swarm1(ScenarioTag ScenarioTag) : base(ScenarioTag, 57)
            {
            }
        }

        [SpawnCounts(1, 1)]
        public class Squad_e11_pro_inf1 : SquadBase
        {
            public IAiActorDefinition starting_locations_0 => Squad.StartingLocations[0];
            public Squad_e11_pro_inf1(ScenarioTag ScenarioTag) : base(ScenarioTag, 58)
            {
            }
        }

        [SpawnCounts(5, 5)]
        public class Squad_e11_fld_inf1 : SquadBase
        {
            public IAiActorDefinition guy1 => Squad.StartingLocations[0];
            public IAiActorDefinition guy2 => Squad.StartingLocations[1];
            public IAiActorDefinition guy3 => Squad.StartingLocations[2];
            public IAiActorDefinition guy4 => Squad.StartingLocations[3];
            public IAiActorDefinition guy5 => Squad.StartingLocations[4];
            public Squad_e11_fld_inf1(ScenarioTag ScenarioTag) : base(ScenarioTag, 59)
            {
            }
        }

        [SpawnCounts(3, 3)]
        public class Squad_e12_cov_inf1 : SquadBase
        {
            public IAiActorDefinition starting_locations_0 => Squad.StartingLocations[0];
            public IAiActorDefinition starting_locations_2 => Squad.StartingLocations[1];
            public IAiActorDefinition starting_locations_21 => Squad.StartingLocations[2];
            public Squad_e12_cov_inf1(ScenarioTag ScenarioTag) : base(ScenarioTag, 60, "e12_prophets_master")
            {
            }
        }

        [SpawnCounts(2, 2)]
        public class Squad_e12_pro_inf2_left1 : SquadBase
        {
            public IAiActorDefinition starting_locations_0 => Squad.StartingLocations[0];
            public IAiActorDefinition starting_locations_1 => Squad.StartingLocations[1];
            public Squad_e12_pro_inf2_left1(ScenarioTag ScenarioTag) : base(ScenarioTag, 61, "e12_prophets_master")
            {
            }
        }

        [SpawnCounts(2, 2)]
        public class Squad_e12_pro_inf2_right1 : SquadBase
        {
            public IAiActorDefinition starting_locations_0 => Squad.StartingLocations[0];
            public IAiActorDefinition starting_locations_2 => Squad.StartingLocations[1];
            public Squad_e12_pro_inf2_right1(ScenarioTag ScenarioTag) : base(ScenarioTag, 62, "e13_prophets_master")
            {
            }
        }

        [SpawnCounts(3, 3)]
        public class Squad_e12_pro_inf3_end : SquadBase
        {
            public IAiActorDefinition starting_locations_2 => Squad.StartingLocations[0];
            public IAiActorDefinition starting_locations_21 => Squad.StartingLocations[1];
            public IAiActorDefinition starting_locations_3 => Squad.StartingLocations[2];
            public Squad_e12_pro_inf3_end(ScenarioTag ScenarioTag) : base(ScenarioTag, 63, "e13_prophets_master")
            {
            }
        }

        [SpawnCounts(2, 2)]
        public class Squad_e12_pro_inf4_right1 : SquadBase
        {
            public IAiActorDefinition starting_locations_0 => Squad.StartingLocations[0];
            public IAiActorDefinition starting_locations_1 => Squad.StartingLocations[1];
            public Squad_e12_pro_inf4_right1(ScenarioTag ScenarioTag) : base(ScenarioTag, 64, "e12_prophets_master")
            {
            }
        }

        [SpawnCounts(2, 2)]
        public class Squad_e12_pro_inf4_left1 : SquadBase
        {
            public IAiActorDefinition starting_locations_0 => Squad.StartingLocations[0];
            public IAiActorDefinition starting_locations_1 => Squad.StartingLocations[1];
            public Squad_e12_pro_inf4_left1(ScenarioTag ScenarioTag) : base(ScenarioTag, 65, "e12_prophets_master")
            {
            }
        }

        [SpawnCounts(3, 3)]
        public class Squad_e12_fld_inf3_right : SquadBase
        {
            public IAiActorDefinition guy1 => Squad.StartingLocations[0];
            public IAiActorDefinition guy2 => Squad.StartingLocations[1];
            public IAiActorDefinition guy3 => Squad.StartingLocations[2];
            public Squad_e12_fld_inf3_right(ScenarioTag ScenarioTag) : base(ScenarioTag, 66, "e12_flood_rush")
            {
            }
        }

        [SpawnCounts(3, 3)]
        public class Squad_e12_fld_inf2_right : SquadBase
        {
            public IAiActorDefinition guy1 => Squad.StartingLocations[0];
            public IAiActorDefinition guy2 => Squad.StartingLocations[1];
            public IAiActorDefinition guy3 => Squad.StartingLocations[2];
            public Squad_e12_fld_inf2_right(ScenarioTag ScenarioTag) : base(ScenarioTag, 67, "e12_flood_rush")
            {
            }
        }

        [SpawnCounts(3, 3)]
        public class Squad_e12_fld_inf1_right : SquadBase
        {
            public IAiActorDefinition guy1 => Squad.StartingLocations[0];
            public IAiActorDefinition guy2 => Squad.StartingLocations[1];
            public IAiActorDefinition guy3 => Squad.StartingLocations[2];
            public Squad_e12_fld_inf1_right(ScenarioTag ScenarioTag) : base(ScenarioTag, 68, "e12_flood_rush")
            {
            }
        }

        [SpawnCounts(3, 3)]
        public class Squad_e12_fld_inf3_left : SquadBase
        {
            public IAiActorDefinition starting_locations_0 => Squad.StartingLocations[0];
            public IAiActorDefinition starting_locations_1 => Squad.StartingLocations[1];
            public IAiActorDefinition starting_locations_2 => Squad.StartingLocations[2];
            public Squad_e12_fld_inf3_left(ScenarioTag ScenarioTag) : base(ScenarioTag, 69, "e12_flood_rush")
            {
            }
        }

        [SpawnCounts(3, 3)]
        public class Squad_e12_fld_inf2_left : SquadBase
        {
            public IAiActorDefinition starting_locations_0 => Squad.StartingLocations[0];
            public IAiActorDefinition starting_locations_1 => Squad.StartingLocations[1];
            public IAiActorDefinition starting_locations_2 => Squad.StartingLocations[2];
            public Squad_e12_fld_inf2_left(ScenarioTag ScenarioTag) : base(ScenarioTag, 70, "e12_flood_rush")
            {
            }
        }

        [SpawnCounts(3, 3)]
        public class Squad_e12_fld_inf1_left : SquadBase
        {
            public IAiActorDefinition starting_locations_0 => Squad.StartingLocations[0];
            public IAiActorDefinition starting_locations_1 => Squad.StartingLocations[1];
            public IAiActorDefinition starting_locations_2 => Squad.StartingLocations[2];
            public Squad_e12_fld_inf1_left(ScenarioTag ScenarioTag) : base(ScenarioTag, 71, "e12_flood_rush")
            {
            }
        }

        [SpawnCounts(6, 6)]
        public class Squad_e12_fld_inf4 : SquadBase
        {
            public IAiActorDefinition guy1 => Squad.StartingLocations[0];
            public IAiActorDefinition guy2 => Squad.StartingLocations[1];
            public IAiActorDefinition guy3 => Squad.StartingLocations[2];
            public IAiActorDefinition guy4 => Squad.StartingLocations[3];
            public IAiActorDefinition guyz => Squad.StartingLocations[4];
            public IAiActorDefinition guya => Squad.StartingLocations[5];
            public Squad_e12_fld_inf4(ScenarioTag ScenarioTag) : base(ScenarioTag, 72)
            {
            }
        }

        [SpawnCounts(1, 1)]
        public class Squad_e12_CS_pelican1 : SquadBase
        {
            public IAiActorDefinition pilot => Squad.StartingLocations[0];
            public Squad_e12_CS_pelican1(ScenarioTag ScenarioTag) : base(ScenarioTag, 73)
            {
            }
        }

        [SpawnCounts(1, 1)]
        public class Squad_e12_CS_banshee1 : SquadBase
        {
            public IAiActorDefinition starting_locations_0 => Squad.StartingLocations[0];
            public Squad_e12_CS_banshee1(ScenarioTag ScenarioTag) : base(ScenarioTag, 74)
            {
            }
        }

        [SpawnCounts(0, 0)]
        public class Squad_cinematic_fld_inf0 : SquadBase
        {
            public IAiActorDefinition form0 => Squad.StartingLocations[0];
            public IAiActorDefinition form1 => Squad.StartingLocations[1];
            public Squad_cinematic_fld_inf0(ScenarioTag ScenarioTag) : base(ScenarioTag, 75, "e1_flood_group_1")
            {
            }
        }

        [SpawnCounts(0, 0)]
        public class Squad_cinematic_fld_inf1 : SquadBase
        {
            public IAiActorDefinition form0 => Squad.StartingLocations[0];
            public Squad_cinematic_fld_inf1(ScenarioTag ScenarioTag) : base(ScenarioTag, 76, "e1_flood_group_1")
            {
            }
        }

        [SpawnCounts(1, 1)]
        public class Squad_cortana1 : SquadBase
        {
            public IAiActorDefinition a => Squad.StartingLocations[0];
            public IAiActorDefinition b => Squad.StartingLocations[1];
            public Squad_cortana1(ScenarioTag ScenarioTag) : base(ScenarioTag, 77)
            {
            }
        }
    }
}