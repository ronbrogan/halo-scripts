namespace OpenH2.Scripts.Generatedscenarios.solo
{
    using System;
    using System.Threading.Tasks;
    using OpenH2.Core.Architecture;
    using OpenH2.Core.Tags;
    using OpenH2.Core.Tags.Scenario;
    using OpenH2.Core.Scripting;
    using OpenH2.Core.GameObjects;

    public partial class scnr_06b_floodzone : ScenarioScriptBase
    {
        public Squad_empty empty { get; set; }
        public Squad_qz_cov_def_spectre qz_cov_def_spectre { get; set; }
        public Squad_qz_cov_def_ghosts qz_cov_def_ghosts { get; set; }
        public Squad_veh_int_hog_ab veh_int_hog_ab { get; set; }
        public Squad_veh_int_ghost_ab veh_int_ghost_ab { get; set; }
        public Squad_______COVENANT_DEFENSE_____ ______COVENANT_DEFENSE_____ { get; set; }
        public Squad_qz_cov_def_phantom qz_cov_def_phantom { get; set; }
        public Squad_qz_cov_def_spec_ops1 qz_cov_def_spec_ops1 { get; set; }
        public Squad_qz_cov_def_enforcer_a qz_cov_def_enforcer_a { get; set; }
        public Squad_qz_cov_def_enforcer_b qz_cov_def_enforcer_b { get; set; }
        public Squad_qz_cov_def_sen_elim qz_cov_def_sen_elim { get; set; }
        public Squad_______VEHICLE_INTERIOR______ ______VEHICLE_INTERIOR______ { get; set; }
        public Squad_veh_int_enf_a1 veh_int_enf_a1 { get; set; }
        public Squad_veh_int_enf_b1 veh_int_enf_b1 { get; set; }
        public Squad_veh_int_enf_d veh_int_enf_d { get; set; }
        public Squad_veh_int_sen_elim_ini veh_int_sen_elim_ini { get; set; }
        public Squad_veh_int_sen_elim_lt veh_int_sen_elim_lt { get; set; }
        public Squad_veh_int_sen_elim_rt veh_int_sen_elim_rt { get; set; }
        public Squad_veh_int_scorpion1 veh_int_scorpion1 { get; set; }
        public Squad_veh_int_flood_ghosts_ini veh_int_flood_ghosts_ini { get; set; }
        public Squad_veh_int_flood_hog_bk veh_int_flood_hog_bk { get; set; }
        public Squad_veh_int_flood_ghosts_bk veh_int_flood_ghosts_bk { get; set; }
        public Squad_veh_int_flood_bk veh_int_flood_bk { get; set; }
        public Squad_veh_int_wraith1 veh_int_wraith1 { get; set; }
        public Squad_veh_int_turrets veh_int_turrets { get; set; }
        public Squad_________EXTERIOR_A________ ________EXTERIOR_A________ { get; set; }
        public Squad_qz_ext_a_phantom qz_ext_a_phantom { get; set; }
        public Squad_qz_ext_a_spec_ops1 qz_ext_a_spec_ops1 { get; set; }
        public Squad_qz_ext_a_ghosts1 qz_ext_a_ghosts1 { get; set; }
        public Squad_qz_ext_a_dam_human qz_ext_a_dam_human { get; set; }
        public Squad_qz_ext_a_dam_enf qz_ext_a_dam_enf { get; set; }
        public Squad_qz_ext_a_dam_enf_door qz_ext_a_dam_enf_door { get; set; }
        public Squad_qz_ext_a_dam_sen1 qz_ext_a_dam_sen1 { get; set; }
        public Squad_qz_ext_a_dam_sen_elim qz_ext_a_dam_sen_elim { get; set; }
        public Squad_qz_ext_a_dam_flood_ini1 qz_ext_a_dam_flood_ini1 { get; set; }
        public Squad_qz_ext_a_dam_flood_cliff_a qz_ext_a_dam_flood_cliff_a { get; set; }
        public Squad_qz_ext_a_dam_flood_cliff_b qz_ext_a_dam_flood_cliff_b { get; set; }
        public Squad_qz_ext_a_flood_wraith_fr1 qz_ext_a_flood_wraith_fr1 { get; set; }
        public Squad_qz_ext_a_flood_wraith_bk qz_ext_a_flood_wraith_bk { get; set; }
        public Squad_qz_ext_a_flood_wraith_ledge qz_ext_a_flood_wraith_ledge { get; set; }
        public Squad_qz_ext_a_flood_rocket qz_ext_a_flood_rocket { get; set; }
        public Squad_qz_ext_a_flood_c1 qz_ext_a_flood_c1 { get; set; }
        public Squad_qz_ext_a_flood_c21 qz_ext_a_flood_c21 { get; set; }
        public Squad_qz_ext_a_flood_d1 qz_ext_a_flood_d1 { get; set; }
        public Squad_qz_ext_a_flood_ghosts qz_ext_a_flood_ghosts { get; set; }
        public Squad_qz_ext_a_enf_a1 qz_ext_a_enf_a1 { get; set; }
        public Squad_qz_ext_a_enf_b qz_ext_a_enf_b { get; set; }
        public Squad_qz_ext_a_enf_bk1 qz_ext_a_enf_bk1 { get; set; }
        public Squad_ext_a_sen_elim_bk1 ext_a_sen_elim_bk1 { get; set; }
        public Squad_ext_a_flood_ghost_fr ext_a_flood_ghost_fr { get; set; }
        public Squad_squads_160 squads_160 { get; set; }
        public Squad_squads_161 squads_161 { get; set; }
        public Squad_squads_162 squads_162 { get; set; }
        public Squad_squads_163 squads_163 { get; set; }
        public Squad_squads_164 squads_164 { get; set; }
        public Squad_______CRASHED_FACTORY______ ______CRASHED_FACTORY______ { get; set; }
        public Squad_fact_ent_enf1 fact_ent_enf1 { get; set; }
        public Squad_fact_ent_sen1 fact_ent_sen1 { get; set; }
        public Squad_fact_ent_flood_turrets fact_ent_flood_turrets { get; set; }
        public Squad_fact_ent_flood_scorpion fact_ent_flood_scorpion { get; set; }
        public Squad_fact_ent_flood_wraith_a1 fact_ent_flood_wraith_a1 { get; set; }
        public Squad_fact_ent_flood_wraith_b1 fact_ent_flood_wraith_b1 { get; set; }
        public Squad_______FACTORY______ ______FACTORY______ { get; set; }
        public Squad_factory_1_flood_intro factory_1_flood_intro { get; set; }
        public Squad_factory_1_flood_initial_mid factory_1_flood_initial_mid { get; set; }
        public Squad_factory_1_flood_initial_end factory_1_flood_initial_end { get; set; }
        public Squad_factory_1_sentinels_intro factory_1_sentinels_intro { get; set; }
        public Squad_factory_1_sentinels_initial_mid factory_1_sentinels_initial_mid { get; set; }
        public Squad_factory_1_sentinels_initial_end factory_1_sentinels_initial_end { get; set; }
        public Squad_factory_1_major factory_1_major { get; set; }
        public Squad_factory_1_sentinels_01_low factory_1_sentinels_01_low { get; set; }
        public Squad_factory_1_sentinels_01_high factory_1_sentinels_01_high { get; set; }
        public Squad_factory_1_sentinels_02_low factory_1_sentinels_02_low { get; set; }
        public Squad_factory_1_sentinels_02_high factory_1_sentinels_02_high { get; set; }
        public Squad_factory_1_sentinels_03_low factory_1_sentinels_03_low { get; set; }
        public Squad_factory_1_sentinels_03_high factory_1_sentinels_03_high { get; set; }
        public Squad_factory_1_flood_end factory_1_flood_end { get; set; }
        public Squad_factory_1_flood_tubes_far factory_1_flood_tubes_far { get; set; }
        public Squad_factory_1_flood_tubes_near factory_1_flood_tubes_near { get; set; }
        public Squad_factory_1_flood_alcove factory_1_flood_alcove { get; set; }
        public Squad_gorge_jugg_a1 gorge_jugg_a1 { get; set; }
        public Squad_gorge_jugg_b1 gorge_jugg_b1 { get; set; }
        public Squad_gorge_enf1 gorge_enf1 { get; set; }
        public Squad_gorge_sen1 gorge_sen1 { get; set; }
        public Squad_gorge_flood_bk1 gorge_flood_bk1 { get; set; }
        public Squad_gorge_flood_ini1 gorge_flood_ini1 { get; set; }
        public Squad_gorge_flood_bk_cave gorge_flood_bk_cave { get; set; }
        public Squad_factory2_sen_dead factory2_sen_dead { get; set; }
        public Squad_factory2_flood_ini1 factory2_flood_ini1 { get; set; }
        public Squad_factory2_flood_mid1 factory2_flood_mid1 { get; set; }
        public Squad_factory2_flood_bk1 factory2_flood_bk1 { get; set; }
        public Squad_factory2_jugg1 factory2_jugg1 { get; set; }
        public Squad_factory2_flood_bk_tunnel factory2_flood_bk_tunnel { get; set; }
        public Squad_factory2_sen_bk_tunnel factory2_sen_bk_tunnel { get; set; }
        public Squad_______EXT_B______ ______EXT_B______ { get; set; }
        public Squad_qz_ext_b_fact_scorpion qz_ext_b_fact_scorpion { get; set; }
        public Squad_qz_ext_b_fact_humans qz_ext_b_fact_humans { get; set; }
        public Squad_qz_ext_b_fact_wraith1 qz_ext_b_fact_wraith1 { get; set; }
        public Squad_qz_ext_b_fact_ghosts1 qz_ext_b_fact_ghosts1 { get; set; }
        public Squad_qz_ext_b_fact_warthog qz_ext_b_fact_warthog { get; set; }
        public Squad_qz_ext_b_fact_ghost_bk qz_ext_b_fact_ghost_bk { get; set; }
        public Squad_qz_ext_b_fact_ghosts_spare1 qz_ext_b_fact_ghosts_spare1 { get; set; }
        public Squad_qz_ext_b_fact_flood1 qz_ext_b_fact_flood1 { get; set; }
        public Squad_qz_ext_b_cov_phantom qz_ext_b_cov_phantom { get; set; }
        public Squad_qz_ext_b_cov_ghosts qz_ext_b_cov_ghosts { get; set; }
        public Squad_qz_ext_b_cov_spectre qz_ext_b_cov_spectre { get; set; }
        public Squad_qz_ext_b_cov_spec_ops qz_ext_b_cov_spec_ops { get; set; }
        public Squad_qz_ext_b_wraith_a1 qz_ext_b_wraith_a1 { get; set; }
        public Squad_qz_ext_b_wraith_b1 qz_ext_b_wraith_b1 { get; set; }
        public Squad_qz_ext_b_ghosts_a qz_ext_b_ghosts_a { get; set; }
        public Squad_qz_ext_b_ghosts_b qz_ext_b_ghosts_b { get; set; }
        public Squad_qz_ext_b_warthog qz_ext_b_warthog { get; set; }
        public Squad_qz_ext_b_warthog_gauss qz_ext_b_warthog_gauss { get; set; }
        public Squad_qz_ext_b_enf_a1 qz_ext_b_enf_a1 { get; set; }
        public Squad_qz_ext_b_enf_b1 qz_ext_b_enf_b1 { get; set; }
        public Squad_qz_ext_b_ent_scorpion1 qz_ext_b_ent_scorpion1 { get; set; }
        public Squad_qz_ext_b_ent_wraith_a qz_ext_b_ent_wraith_a { get; set; }
        public Squad_qz_ext_b_ent_cov_phantom qz_ext_b_ent_cov_phantom { get; set; }
        public Squad_qz_ext_b_ent_turrets1 qz_ext_b_ent_turrets1 { get; set; }
        public Squad_qz_ext_b_ent_flood_bk qz_ext_b_ent_flood_bk { get; set; }
        public Squad_qz_ext_b_ent_ghost_bk qz_ext_b_ent_ghost_bk { get; set; }
        public Squad_qz_ext_b_ent_enf1 qz_ext_b_ent_enf1 { get; set; }
        public Squad_qz_ext_b_ent_flood_tube_a qz_ext_b_ent_flood_tube_a { get; set; }
        public Squad_qz_ext_b_ent_flood_tube_b qz_ext_b_ent_flood_tube_b { get; set; }
        public Squad_squads_156 squads_156 { get; set; }
        public Squad_squads_157 squads_157 { get; set; }
        public Squad_______KEY______ ______KEY______ { get; set; }
        public Squad_e20_cov_inf0 e20_cov_inf0 { get; set; }
        public Squad_e20_fld_combats0_0 e20_fld_combats0_0 { get; set; }
        public Squad_e20_fld_combats0_1 e20_fld_combats0_1 { get; set; }
        public Squad_e20_fld_combats1 e20_fld_combats1 { get; set; }
        public Squad_e21_cov_inf0_0 e21_cov_inf0_0 { get; set; }
        public Squad_e21_cov_inf0_1 e21_cov_inf0_1 { get; set; }
        public Squad_e21_fld_inf0_0 e21_fld_inf0_0 { get; set; }
        public Squad_e21_fld_inf0_1 e21_fld_inf0_1 { get; set; }
        public Squad_e21_fld_inf0_2 e21_fld_inf0_2 { get; set; }
        public Squad_e21_fld_carriers0 e21_fld_carriers0 { get; set; }
        public Squad_e21_fld_inf1_0 e21_fld_inf1_0 { get; set; }
        public Squad_e21_fld_inf1_1 e21_fld_inf1_1 { get; set; }
        public Squad_e21_fld_inf1_2 e21_fld_inf1_2 { get; set; }
        public Squad_e21_fld_carriers1 e21_fld_carriers1 { get; set; }
        public Squad_e22_cov_inf0 e22_cov_inf0 { get; set; }
        public Squad_e22_cov_inf1_0 e22_cov_inf1_0 { get; set; }
        public Squad_e22_cov_inf1_1 e22_cov_inf1_1 { get; set; }
        public Squad_e22_fld_inf0_0 e22_fld_inf0_0 { get; set; }
        public Squad_e22_fld_inf0_1 e22_fld_inf0_1 { get; set; }
        public Squad_e22_fld_inf1 e22_fld_inf1 { get; set; }
        public Squad_e23_cov_inf0 e23_cov_inf0 { get; set; }
        public Squad_e23_fld_inf0_0 e23_fld_inf0_0 { get; set; }
        public Squad_e23_fld_inf0_1 e23_fld_inf0_1 { get; set; }
        public Squad_e24_cov_inf0 e24_cov_inf0 { get; set; }
        public Squad_e24_fld_inf0 e24_fld_inf0 { get; set; }
        public Squad_e24_fld_inf1_0 e24_fld_inf1_0 { get; set; }
        public Squad_e24_fld_inf1_1 e24_fld_inf1_1 { get; set; }
        public Squad_e24_fld_inf2 e24_fld_inf2 { get; set; }
        public Squad_e25_cov_inf0 e25_cov_inf0 { get; set; }
        public Squad_e25_fld_inf0_0 e25_fld_inf0_0 { get; set; }
        public Squad_e25_fld_inf0_1 e25_fld_inf0_1 { get; set; }
        public Squad_e25_fld_inf0_2 e25_fld_inf0_2 { get; set; }
        public Squad_e25_fld_inf1_0 e25_fld_inf1_0 { get; set; }
        public Squad_e25_fld_inf1_1 e25_fld_inf1_1 { get; set; }
        public Squad_e25_fld_inf1_2 e25_fld_inf1_2 { get; set; }
        public Squad_e26_fld_infection_forms0 e26_fld_infection_forms0 { get; set; }
        public Squad_key_ride_tartarus key_ride_tartarus { get; set; }
        public Squad_silly silly { get; set; }
        public Squad_key_cov_dump key_cov_dump { get; set; }
        public Squad_squads_166 squads_166 { get; set; }
        public Squad_squads_167 squads_167 { get; set; }
        public Squad_squads_168 squads_168 { get; set; }
        public Squad_squads_169 squads_169 { get; set; }
        [SpawnCounts(0, 0)]
        public class Squad_empty : SquadBase
        {
            public Squad_empty(ScenarioTag ScenarioTag) : base(ScenarioTag, 0)
            {
            }
        }

        [SpawnCounts(1, 1)]
        public class Squad_qz_cov_def_spectre : SquadBase
        {
            public IAiActorDefinition spectre => Squad.StartingLocations[0];
            public Squad_qz_cov_def_spectre(ScenarioTag ScenarioTag) : base(ScenarioTag, 1, "covenant_vehicles")
            {
            }
        }

        [SpawnCounts(2, 2)]
        public class Squad_qz_cov_def_ghosts : SquadBase
        {
            public IAiActorDefinition a => Squad.StartingLocations[0];
            public IAiActorDefinition b => Squad.StartingLocations[1];
            public Squad_qz_cov_def_ghosts(ScenarioTag ScenarioTag) : base(ScenarioTag, 2, "covenant_infantry")
            {
            }
        }

        [SpawnCounts(1, 1)]
        public class Squad_veh_int_hog_ab : SquadBase
        {
            public IAiActorDefinition hog => Squad.StartingLocations[0];
            public Squad_veh_int_hog_ab(ScenarioTag ScenarioTag) : base(ScenarioTag, 3, "covenant_vehicles")
            {
            }
        }

        [SpawnCounts(1, 1)]
        public class Squad_veh_int_ghost_ab : SquadBase
        {
            public IAiActorDefinition a => Squad.StartingLocations[0];
            public IAiActorDefinition b => Squad.StartingLocations[1];
            public Squad_veh_int_ghost_ab(ScenarioTag ScenarioTag) : base(ScenarioTag, 4, "covenant_infantry")
            {
            }
        }

        [SpawnCounts(1, 1)]
        public class Squad_______COVENANT_DEFENSE_____ : SquadBase
        {
            public IAiActorDefinition starting_locations_0 => Squad.StartingLocations[0];
            public Squad_______COVENANT_DEFENSE_____(ScenarioTag ScenarioTag) : base(ScenarioTag, 5)
            {
            }
        }

        [SpawnCounts(1, 1)]
        public class Squad_qz_cov_def_phantom : SquadBase
        {
            public IAiActorDefinition driver => Squad.StartingLocations[0];
            public IAiActorDefinition gun_a => Squad.StartingLocations[1];
            public IAiActorDefinition gun_b => Squad.StartingLocations[2];
            public IAiActorDefinition gun_c => Squad.StartingLocations[3];
            public Squad_qz_cov_def_phantom(ScenarioTag ScenarioTag) : base(ScenarioTag, 6, "covenant_infantry")
            {
            }
        }

        [SpawnCounts(4, 4)]
        public class Squad_qz_cov_def_spec_ops1 : SquadBase
        {
            public IAiActorDefinition a => Squad.StartingLocations[0];
            public IAiActorDefinition b => Squad.StartingLocations[1];
            public IAiActorDefinition c => Squad.StartingLocations[2];
            public IAiActorDefinition d => Squad.StartingLocations[3];
            public Squad_qz_cov_def_spec_ops1(ScenarioTag ScenarioTag) : base(ScenarioTag, 7, "covenant_infantry")
            {
            }
        }

        [SpawnCounts(1, 1)]
        public class Squad_qz_cov_def_enforcer_a : SquadBase
        {
            public IAiActorDefinition starting_locations_0 => Squad.StartingLocations[0];
            public Squad_qz_cov_def_enforcer_a(ScenarioTag ScenarioTag) : base(ScenarioTag, 8, "cov_def_enf")
            {
            }
        }

        [SpawnCounts(1, 1)]
        public class Squad_qz_cov_def_enforcer_b : SquadBase
        {
            public IAiActorDefinition starting_locations_0 => Squad.StartingLocations[0];
            public Squad_qz_cov_def_enforcer_b(ScenarioTag ScenarioTag) : base(ScenarioTag, 9, "cov_def_enf")
            {
            }
        }

        [SpawnCounts(2, 4)]
        public class Squad_qz_cov_def_sen_elim : SquadBase
        {
            public IAiActorDefinition starting_locations_0 => Squad.StartingLocations[0];
            public IAiActorDefinition starting_locations_1 => Squad.StartingLocations[1];
            public IAiActorDefinition starting_locations_2 => Squad.StartingLocations[2];
            public IAiActorDefinition starting_locations_3 => Squad.StartingLocations[3];
            public IAiActorDefinition starting_locations_4 => Squad.StartingLocations[4];
            public IAiActorDefinition starting_locations_5 => Squad.StartingLocations[5];
            public IAiActorDefinition starting_locations_6 => Squad.StartingLocations[6];
            public IAiActorDefinition starting_locations_7 => Squad.StartingLocations[7];
            public Squad_qz_cov_def_sen_elim(ScenarioTag ScenarioTag) : base(ScenarioTag, 10, "cov_def_sentinels")
            {
            }
        }

        [SpawnCounts(0, 0)]
        public class Squad_______VEHICLE_INTERIOR______ : SquadBase
        {
            public Squad_______VEHICLE_INTERIOR______(ScenarioTag ScenarioTag) : base(ScenarioTag, 11)
            {
            }
        }

        [SpawnCounts(1, 1)]
        public class Squad_veh_int_enf_a1 : SquadBase
        {
            public IAiActorDefinition starting_locations_0 => Squad.StartingLocations[0];
            public IAiActorDefinition starting_locations_1 => Squad.StartingLocations[1];
            public Squad_veh_int_enf_a1(ScenarioTag ScenarioTag) : base(ScenarioTag, 12, "veh_int_sen_a")
            {
            }
        }

        [SpawnCounts(1, 1)]
        public class Squad_veh_int_enf_b1 : SquadBase
        {
            public IAiActorDefinition starting_locations_0 => Squad.StartingLocations[0];
            public Squad_veh_int_enf_b1(ScenarioTag ScenarioTag) : base(ScenarioTag, 13, "veh_int_sen_b")
            {
            }
        }

        [SpawnCounts(1, 1)]
        public class Squad_veh_int_enf_d : SquadBase
        {
            public IAiActorDefinition starting_locations_0 => Squad.StartingLocations[0];
            public Squad_veh_int_enf_d(ScenarioTag ScenarioTag) : base(ScenarioTag, 14, "veh_int_sen_d")
            {
            }
        }

        [SpawnCounts(2, 2)]
        public class Squad_veh_int_sen_elim_ini : SquadBase
        {
            public IAiActorDefinition starting_locations_0 => Squad.StartingLocations[0];
            public IAiActorDefinition starting_locations_1 => Squad.StartingLocations[1];
            public IAiActorDefinition starting_locations_2 => Squad.StartingLocations[2];
            public IAiActorDefinition starting_locations_3 => Squad.StartingLocations[3];
            public IAiActorDefinition starting_locations_4 => Squad.StartingLocations[4];
            public IAiActorDefinition starting_locations_5 => Squad.StartingLocations[5];
            public Squad_veh_int_sen_elim_ini(ScenarioTag ScenarioTag) : base(ScenarioTag, 15, "veh_int_sen_a")
            {
            }
        }

        [SpawnCounts(2, 2)]
        public class Squad_veh_int_sen_elim_lt : SquadBase
        {
            public IAiActorDefinition starting_locations_0 => Squad.StartingLocations[0];
            public IAiActorDefinition starting_locations_1 => Squad.StartingLocations[1];
            public IAiActorDefinition starting_locations_2 => Squad.StartingLocations[2];
            public IAiActorDefinition starting_locations_3 => Squad.StartingLocations[3];
            public IAiActorDefinition starting_locations_4 => Squad.StartingLocations[4];
            public IAiActorDefinition starting_locations_5 => Squad.StartingLocations[5];
            public IAiActorDefinition starting_locations_6 => Squad.StartingLocations[6];
            public IAiActorDefinition starting_locations_7 => Squad.StartingLocations[7];
            public Squad_veh_int_sen_elim_lt(ScenarioTag ScenarioTag) : base(ScenarioTag, 16, "veh_int_sen_c")
            {
            }
        }

        [SpawnCounts(2, 2)]
        public class Squad_veh_int_sen_elim_rt : SquadBase
        {
            public IAiActorDefinition starting_locations_0 => Squad.StartingLocations[0];
            public IAiActorDefinition starting_locations_1 => Squad.StartingLocations[1];
            public IAiActorDefinition starting_locations_2 => Squad.StartingLocations[2];
            public IAiActorDefinition starting_locations_3 => Squad.StartingLocations[3];
            public IAiActorDefinition starting_locations_4 => Squad.StartingLocations[4];
            public IAiActorDefinition starting_locations_5 => Squad.StartingLocations[5];
            public IAiActorDefinition starting_locations_6 => Squad.StartingLocations[6];
            public IAiActorDefinition starting_locations_7 => Squad.StartingLocations[7];
            public Squad_veh_int_sen_elim_rt(ScenarioTag ScenarioTag) : base(ScenarioTag, 17, "veh_int_sen_c")
            {
            }
        }

        [SpawnCounts(1, 1)]
        public class Squad_veh_int_scorpion1 : SquadBase
        {
            public IAiActorDefinition scorpion => Squad.StartingLocations[0];
            public Squad_veh_int_scorpion1(ScenarioTag ScenarioTag) : base(ScenarioTag, 18, "veh_int_flood_d")
            {
            }
        }

        [SpawnCounts(2, 2)]
        public class Squad_veh_int_flood_ghosts_ini : SquadBase
        {
            public IAiActorDefinition a => Squad.StartingLocations[0];
            public IAiActorDefinition b => Squad.StartingLocations[1];
            public Squad_veh_int_flood_ghosts_ini(ScenarioTag ScenarioTag) : base(ScenarioTag, 19, "veh_int_flood_a")
            {
            }
        }

        [SpawnCounts(2, 2)]
        public class Squad_veh_int_flood_hog_bk : SquadBase
        {
            public IAiActorDefinition warthog => Squad.StartingLocations[0];
            public IAiActorDefinition gunner => Squad.StartingLocations[1];
            public Squad_veh_int_flood_hog_bk(ScenarioTag ScenarioTag) : base(ScenarioTag, 20, "veh_int_flood_d")
            {
            }
        }

        [SpawnCounts(2, 2)]
        public class Squad_veh_int_flood_ghosts_bk : SquadBase
        {
            public IAiActorDefinition a => Squad.StartingLocations[0];
            public IAiActorDefinition b => Squad.StartingLocations[1];
            public IAiActorDefinition starting_locations_2 => Squad.StartingLocations[2];
            public Squad_veh_int_flood_ghosts_bk(ScenarioTag ScenarioTag) : base(ScenarioTag, 21, "veh_int_flood_d")
            {
            }
        }

        [SpawnCounts(1, 1)]
        public class Squad_veh_int_flood_bk : SquadBase
        {
            public IAiActorDefinition starting_locations_0 => Squad.StartingLocations[0];
            public IAiActorDefinition starting_locations_1 => Squad.StartingLocations[1];
            public IAiActorDefinition starting_locations_2 => Squad.StartingLocations[2];
            public IAiActorDefinition starting_locations_3 => Squad.StartingLocations[3];
            public IAiActorDefinition runner => Squad.StartingLocations[4];
            public IAiActorDefinition starting_locations_5 => Squad.StartingLocations[5];
            public Squad_veh_int_flood_bk(ScenarioTag ScenarioTag) : base(ScenarioTag, 22, "veh_int_flood_d")
            {
            }
        }

        [SpawnCounts(2, 2)]
        public class Squad_veh_int_wraith1 : SquadBase
        {
            public IAiActorDefinition wraith => Squad.StartingLocations[0];
            public IAiActorDefinition driver => Squad.StartingLocations[1];
            public Squad_veh_int_wraith1(ScenarioTag ScenarioTag) : base(ScenarioTag, 23, "veh_int_flood_a")
            {
            }
        }

        [SpawnCounts(2, 2)]
        public class Squad_veh_int_turrets : SquadBase
        {
            public IAiActorDefinition starting_locations_0 => Squad.StartingLocations[0];
            public IAiActorDefinition starting_locations_1 => Squad.StartingLocations[1];
            public IAiActorDefinition starting_locations_2 => Squad.StartingLocations[2];
            public Squad_veh_int_turrets(ScenarioTag ScenarioTag) : base(ScenarioTag, 24, "veh_int_flood_b")
            {
            }
        }

        [SpawnCounts(0, 0)]
        public class Squad_________EXTERIOR_A________ : SquadBase
        {
            public Squad_________EXTERIOR_A________(ScenarioTag ScenarioTag) : base(ScenarioTag, 25)
            {
            }
        }

        [SpawnCounts(1, 1)]
        public class Squad_qz_ext_a_phantom : SquadBase
        {
            public IAiActorDefinition phantom => Squad.StartingLocations[0];
            public Squad_qz_ext_a_phantom(ScenarioTag ScenarioTag) : base(ScenarioTag, 26, "covenant_infantry")
            {
            }
        }

        [SpawnCounts(3, 3)]
        public class Squad_qz_ext_a_spec_ops1 : SquadBase
        {
            public IAiActorDefinition starting_locations_0 => Squad.StartingLocations[0];
            public IAiActorDefinition starting_locations_1 => Squad.StartingLocations[1];
            public IAiActorDefinition starting_locations_2 => Squad.StartingLocations[2];
            public Squad_qz_ext_a_spec_ops1(ScenarioTag ScenarioTag) : base(ScenarioTag, 27, "covenant_infantry")
            {
            }
        }

        [SpawnCounts(2, 2)]
        public class Squad_qz_ext_a_ghosts1 : SquadBase
        {
            public IAiActorDefinition a => Squad.StartingLocations[0];
            public IAiActorDefinition b => Squad.StartingLocations[1];
            public Squad_qz_ext_a_ghosts1(ScenarioTag ScenarioTag) : base(ScenarioTag, 28, "covenant_infantry")
            {
            }
        }

        [SpawnCounts(5, 5)]
        public class Squad_qz_ext_a_dam_human : SquadBase
        {
            public IAiActorDefinition pelican => Squad.StartingLocations[0];
            public IAiActorDefinition scorpion => Squad.StartingLocations[1];
            public IAiActorDefinition starting_locations_2 => Squad.StartingLocations[2];
            public IAiActorDefinition starting_locations_3 => Squad.StartingLocations[3];
            public IAiActorDefinition starting_locations_4 => Squad.StartingLocations[4];
            public Squad_qz_ext_a_dam_human(ScenarioTag ScenarioTag) : base(ScenarioTag, 29)
            {
            }
        }

        [SpawnCounts(1, 1)]
        public class Squad_qz_ext_a_dam_enf : SquadBase
        {
            public IAiActorDefinition a => Squad.StartingLocations[0];
            public IAiActorDefinition starting_locations_1 => Squad.StartingLocations[1];
            public Squad_qz_ext_a_dam_enf(ScenarioTag ScenarioTag) : base(ScenarioTag, 30, "ext_a_sen_dam_b")
            {
            }
        }

        [SpawnCounts(1, 1)]
        public class Squad_qz_ext_a_dam_enf_door : SquadBase
        {
            public IAiActorDefinition b => Squad.StartingLocations[0];
            public IAiActorDefinition c => Squad.StartingLocations[1];
            public IAiActorDefinition d => Squad.StartingLocations[2];
            public Squad_qz_ext_a_dam_enf_door(ScenarioTag ScenarioTag) : base(ScenarioTag, 31, "ext_a_sen_dam_b")
            {
            }
        }

        [SpawnCounts(2, 2)]
        public class Squad_qz_ext_a_dam_sen1 : SquadBase
        {
            public IAiActorDefinition starting_locations_0 => Squad.StartingLocations[0];
            public IAiActorDefinition starting_locations_1 => Squad.StartingLocations[1];
            public IAiActorDefinition starting_locations_2 => Squad.StartingLocations[2];
            public IAiActorDefinition starting_locations_3 => Squad.StartingLocations[3];
            public Squad_qz_ext_a_dam_sen1(ScenarioTag ScenarioTag) : base(ScenarioTag, 32, "ext_a_sen_dam_a")
            {
            }
        }

        [SpawnCounts(2, 2)]
        public class Squad_qz_ext_a_dam_sen_elim : SquadBase
        {
            public IAiActorDefinition starting_locations_0 => Squad.StartingLocations[0];
            public IAiActorDefinition starting_locations_1 => Squad.StartingLocations[1];
            public Squad_qz_ext_a_dam_sen_elim(ScenarioTag ScenarioTag) : base(ScenarioTag, 33, "ext_a_sen_dam_a")
            {
            }
        }

        [SpawnCounts(3, 3)]
        public class Squad_qz_ext_a_dam_flood_ini1 : SquadBase
        {
            public IAiActorDefinition starting_locations_0 => Squad.StartingLocations[0];
            public IAiActorDefinition starting_locations_1 => Squad.StartingLocations[1];
            public IAiActorDefinition starting_locations_2 => Squad.StartingLocations[2];
            public IAiActorDefinition starting_locations_3 => Squad.StartingLocations[3];
            public IAiActorDefinition starting_locations_4 => Squad.StartingLocations[4];
            public IAiActorDefinition starting_locations_5 => Squad.StartingLocations[5];
            public IAiActorDefinition starting_locations_6 => Squad.StartingLocations[6];
            public IAiActorDefinition starting_locations_7 => Squad.StartingLocations[7];
            public IAiActorDefinition starting_locations_8 => Squad.StartingLocations[8];
            public Squad_qz_ext_a_dam_flood_ini1(ScenarioTag ScenarioTag) : base(ScenarioTag, 34, "ext_a_flood_dam_a")
            {
            }
        }

        [SpawnCounts(3, 3)]
        public class Squad_qz_ext_a_dam_flood_cliff_a : SquadBase
        {
            public IAiActorDefinition starting_locations_9 => Squad.StartingLocations[0];
            public IAiActorDefinition starting_locations_10 => Squad.StartingLocations[1];
            public IAiActorDefinition starting_locations_11 => Squad.StartingLocations[2];
            public IAiActorDefinition starting_locations_12 => Squad.StartingLocations[3];
            public IAiActorDefinition starting_locations_13 => Squad.StartingLocations[4];
            public IAiActorDefinition starting_locations_14 => Squad.StartingLocations[5];
            public IAiActorDefinition starting_locations_15 => Squad.StartingLocations[6];
            public IAiActorDefinition starting_locations_16 => Squad.StartingLocations[7];
            public IAiActorDefinition starting_locations_17 => Squad.StartingLocations[8];
            public Squad_qz_ext_a_dam_flood_cliff_a(ScenarioTag ScenarioTag) : base(ScenarioTag, 35, "ext_a_flood_dam_b")
            {
            }
        }

        [SpawnCounts(3, 3)]
        public class Squad_qz_ext_a_dam_flood_cliff_b : SquadBase
        {
            public IAiActorDefinition starting_locations_0 => Squad.StartingLocations[0];
            public IAiActorDefinition starting_locations_1 => Squad.StartingLocations[1];
            public IAiActorDefinition starting_locations_2 => Squad.StartingLocations[2];
            public IAiActorDefinition starting_locations_3 => Squad.StartingLocations[3];
            public IAiActorDefinition starting_locations_4 => Squad.StartingLocations[4];
            public IAiActorDefinition starting_locations_5 => Squad.StartingLocations[5];
            public IAiActorDefinition starting_locations_6 => Squad.StartingLocations[6];
            public IAiActorDefinition starting_locations_7 => Squad.StartingLocations[7];
            public IAiActorDefinition starting_locations_8 => Squad.StartingLocations[8];
            public Squad_qz_ext_a_dam_flood_cliff_b(ScenarioTag ScenarioTag) : base(ScenarioTag, 36, "ext_a_flood_dam_b")
            {
            }
        }

        [SpawnCounts(1, 1)]
        public class Squad_qz_ext_a_flood_wraith_fr1 : SquadBase
        {
            public IAiActorDefinition starting_locations_0 => Squad.StartingLocations[0];
            public Squad_qz_ext_a_flood_wraith_fr1(ScenarioTag ScenarioTag) : base(ScenarioTag, 37, "veh_int_flood_b")
            {
            }
        }

        [SpawnCounts(1, 1)]
        public class Squad_qz_ext_a_flood_wraith_bk : SquadBase
        {
            public IAiActorDefinition starting_locations_0 => Squad.StartingLocations[0];
            public Squad_qz_ext_a_flood_wraith_bk(ScenarioTag ScenarioTag) : base(ScenarioTag, 38, "ext_a_flood_e")
            {
            }
        }

        [SpawnCounts(1, 1)]
        public class Squad_qz_ext_a_flood_wraith_ledge : SquadBase
        {
            public IAiActorDefinition starting_locations_0 => Squad.StartingLocations[0];
            public Squad_qz_ext_a_flood_wraith_ledge(ScenarioTag ScenarioTag) : base(ScenarioTag, 39, "flood")
            {
            }
        }

        [SpawnCounts(2, 2)]
        public class Squad_qz_ext_a_flood_rocket : SquadBase
        {
            public IAiActorDefinition starting_locations_0 => Squad.StartingLocations[0];
            public IAiActorDefinition starting_locations_1 => Squad.StartingLocations[1];
            public Squad_qz_ext_a_flood_rocket(ScenarioTag ScenarioTag) : base(ScenarioTag, 40, "ext_a_flood_d")
            {
            }
        }

        [SpawnCounts(4, 4)]
        public class Squad_qz_ext_a_flood_c1 : SquadBase
        {
            public IAiActorDefinition starting_locations_0 => Squad.StartingLocations[0];
            public IAiActorDefinition starting_locations_1 => Squad.StartingLocations[1];
            public IAiActorDefinition starting_locations_2 => Squad.StartingLocations[2];
            public IAiActorDefinition starting_locations_3 => Squad.StartingLocations[3];
            public IAiActorDefinition starting_locations_4 => Squad.StartingLocations[4];
            public IAiActorDefinition starting_locations_5 => Squad.StartingLocations[5];
            public Squad_qz_ext_a_flood_c1(ScenarioTag ScenarioTag) : base(ScenarioTag, 41, "ext_a_flood_c")
            {
            }
        }

        [SpawnCounts(1, 1)]
        public class Squad_qz_ext_a_flood_c21 : SquadBase
        {
            public IAiActorDefinition starting_locations_0 => Squad.StartingLocations[0];
            public IAiActorDefinition starting_locations_1 => Squad.StartingLocations[1];
            public Squad_qz_ext_a_flood_c21(ScenarioTag ScenarioTag) : base(ScenarioTag, 42, "ext_a_flood_c")
            {
            }
        }

        [SpawnCounts(5, 5)]
        public class Squad_qz_ext_a_flood_d1 : SquadBase
        {
            public IAiActorDefinition starting_locations_0 => Squad.StartingLocations[0];
            public IAiActorDefinition starting_locations_1 => Squad.StartingLocations[1];
            public IAiActorDefinition starting_locations_2 => Squad.StartingLocations[2];
            public IAiActorDefinition starting_locations_3 => Squad.StartingLocations[3];
            public IAiActorDefinition starting_locations_4 => Squad.StartingLocations[4];
            public IAiActorDefinition starting_locations_5 => Squad.StartingLocations[5];
            public IAiActorDefinition starting_locations_6 => Squad.StartingLocations[6];
            public IAiActorDefinition starting_locations_7 => Squad.StartingLocations[7];
            public Squad_qz_ext_a_flood_d1(ScenarioTag ScenarioTag) : base(ScenarioTag, 43, "ext_a_flood_c")
            {
            }
        }

        [SpawnCounts(2, 2)]
        public class Squad_qz_ext_a_flood_ghosts : SquadBase
        {
            public IAiActorDefinition starting_locations_0 => Squad.StartingLocations[0];
            public IAiActorDefinition starting_locations_1 => Squad.StartingLocations[1];
            public Squad_qz_ext_a_flood_ghosts(ScenarioTag ScenarioTag) : base(ScenarioTag, 44, "flood")
            {
            }
        }

        [SpawnCounts(2, 2)]
        public class Squad_qz_ext_a_enf_a1 : SquadBase
        {
            public IAiActorDefinition starting_locations_0 => Squad.StartingLocations[0];
            public IAiActorDefinition starting_locations_1 => Squad.StartingLocations[1];
            public Squad_qz_ext_a_enf_a1(ScenarioTag ScenarioTag) : base(ScenarioTag, 45, "ext_a_sen_c")
            {
            }
        }

        [SpawnCounts(0, 0)]
        public class Squad_qz_ext_a_enf_b : SquadBase
        {
            public Squad_qz_ext_a_enf_b(ScenarioTag ScenarioTag) : base(ScenarioTag, 46)
            {
            }
        }

        [SpawnCounts(1, 1)]
        public class Squad_qz_ext_a_enf_bk1 : SquadBase
        {
            public IAiActorDefinition starting_locations_0 => Squad.StartingLocations[0];
            public Squad_qz_ext_a_enf_bk1(ScenarioTag ScenarioTag) : base(ScenarioTag, 47)
            {
            }
        }

        [SpawnCounts(4, 4)]
        public class Squad_ext_a_sen_elim_bk1 : SquadBase
        {
            public IAiActorDefinition starting_locations_0 => Squad.StartingLocations[0];
            public IAiActorDefinition starting_locations_1 => Squad.StartingLocations[1];
            public IAiActorDefinition starting_locations_2 => Squad.StartingLocations[2];
            public IAiActorDefinition starting_locations_3 => Squad.StartingLocations[3];
            public IAiActorDefinition starting_locations_4 => Squad.StartingLocations[4];
            public IAiActorDefinition starting_locations_5 => Squad.StartingLocations[5];
            public IAiActorDefinition starting_locations_6 => Squad.StartingLocations[6];
            public IAiActorDefinition starting_locations_7 => Squad.StartingLocations[7];
            public Squad_ext_a_sen_elim_bk1(ScenarioTag ScenarioTag) : base(ScenarioTag, 48, "ext_a_sen_e")
            {
            }
        }

        [SpawnCounts(2, 2)]
        public class Squad_ext_a_flood_ghost_fr : SquadBase
        {
            public IAiActorDefinition starting_locations_0 => Squad.StartingLocations[0];
            public IAiActorDefinition starting_locations_1 => Squad.StartingLocations[1];
            public Squad_ext_a_flood_ghost_fr(ScenarioTag ScenarioTag) : base(ScenarioTag, 49, "ext_a_flood_c")
            {
            }
        }

        [SpawnCounts(0, 0)]
        public class Squad_squads_160 : SquadBase
        {
            public Squad_squads_160(ScenarioTag ScenarioTag) : base(ScenarioTag, 50)
            {
            }
        }

        [SpawnCounts(0, 0)]
        public class Squad_squads_161 : SquadBase
        {
            public Squad_squads_161(ScenarioTag ScenarioTag) : base(ScenarioTag, 51)
            {
            }
        }

        [SpawnCounts(0, 0)]
        public class Squad_squads_162 : SquadBase
        {
            public Squad_squads_162(ScenarioTag ScenarioTag) : base(ScenarioTag, 52)
            {
            }
        }

        [SpawnCounts(0, 0)]
        public class Squad_squads_163 : SquadBase
        {
            public Squad_squads_163(ScenarioTag ScenarioTag) : base(ScenarioTag, 53)
            {
            }
        }

        [SpawnCounts(0, 0)]
        public class Squad_squads_164 : SquadBase
        {
            public Squad_squads_164(ScenarioTag ScenarioTag) : base(ScenarioTag, 54)
            {
            }
        }

        [SpawnCounts(0, 0)]
        public class Squad_______CRASHED_FACTORY______ : SquadBase
        {
            public Squad_______CRASHED_FACTORY______(ScenarioTag ScenarioTag) : base(ScenarioTag, 55)
            {
            }
        }

        [SpawnCounts(1, 1)]
        public class Squad_fact_ent_enf1 : SquadBase
        {
            public IAiActorDefinition starting_locations_0 => Squad.StartingLocations[0];
            public IAiActorDefinition starting_locations_1 => Squad.StartingLocations[1];
            public IAiActorDefinition starting_locations_2 => Squad.StartingLocations[2];
            public Squad_fact_ent_enf1(ScenarioTag ScenarioTag) : base(ScenarioTag, 56, "fact_ent_sentinels")
            {
            }
        }

        [SpawnCounts(2, 2)]
        public class Squad_fact_ent_sen1 : SquadBase
        {
            public IAiActorDefinition starting_locations_0 => Squad.StartingLocations[0];
            public IAiActorDefinition starting_locations_1 => Squad.StartingLocations[1];
            public IAiActorDefinition starting_locations_2 => Squad.StartingLocations[2];
            public IAiActorDefinition starting_locations_3 => Squad.StartingLocations[3];
            public IAiActorDefinition starting_locations_4 => Squad.StartingLocations[4];
            public IAiActorDefinition starting_locations_5 => Squad.StartingLocations[5];
            public IAiActorDefinition starting_locations_6 => Squad.StartingLocations[6];
            public IAiActorDefinition starting_locations_7 => Squad.StartingLocations[7];
            public IAiActorDefinition starting_locations_8 => Squad.StartingLocations[8];
            public Squad_fact_ent_sen1(ScenarioTag ScenarioTag) : base(ScenarioTag, 57, "fact_ent_sentinels")
            {
            }
        }

        [SpawnCounts(2, 2)]
        public class Squad_fact_ent_flood_turrets : SquadBase
        {
            public IAiActorDefinition starting_locations_0 => Squad.StartingLocations[0];
            public IAiActorDefinition starting_locations_1 => Squad.StartingLocations[1];
            public Squad_fact_ent_flood_turrets(ScenarioTag ScenarioTag) : base(ScenarioTag, 58, "fact_ent_flood")
            {
            }
        }

        [SpawnCounts(1, 1)]
        public class Squad_fact_ent_flood_scorpion : SquadBase
        {
            public IAiActorDefinition starting_locations_0 => Squad.StartingLocations[0];
            public Squad_fact_ent_flood_scorpion(ScenarioTag ScenarioTag) : base(ScenarioTag, 59, "fact_ent_flood")
            {
            }
        }

        [SpawnCounts(1, 1)]
        public class Squad_fact_ent_flood_wraith_a1 : SquadBase
        {
            public IAiActorDefinition starting_locations_0 => Squad.StartingLocations[0];
            public Squad_fact_ent_flood_wraith_a1(ScenarioTag ScenarioTag) : base(ScenarioTag, 60, "fact_ent_flood")
            {
            }
        }

        [SpawnCounts(1, 1)]
        public class Squad_fact_ent_flood_wraith_b1 : SquadBase
        {
            public IAiActorDefinition starting_locations_0 => Squad.StartingLocations[0];
            public Squad_fact_ent_flood_wraith_b1(ScenarioTag ScenarioTag) : base(ScenarioTag, 61, "fact_ent_flood")
            {
            }
        }

        [SpawnCounts(5, 5)]
        public class Squad_______FACTORY______ : SquadBase
        {
            public Squad_______FACTORY______(ScenarioTag ScenarioTag) : base(ScenarioTag, 62, "e20_cov")
            {
            }
        }

        [SpawnCounts(2, 2)]
        public class Squad_factory_1_flood_intro : SquadBase
        {
            public IAiActorDefinition starting_locations_0 => Squad.StartingLocations[0];
            public IAiActorDefinition starting_locations_1 => Squad.StartingLocations[1];
            public Squad_factory_1_flood_intro(ScenarioTag ScenarioTag) : base(ScenarioTag, 63, "factory1_flood")
            {
            }
        }

        [SpawnCounts(1, 1)]
        public class Squad_factory_1_flood_initial_mid : SquadBase
        {
            public IAiActorDefinition starting_locations_0 => Squad.StartingLocations[0];
            public Squad_factory_1_flood_initial_mid(ScenarioTag ScenarioTag) : base(ScenarioTag, 64, "factory1_flood")
            {
            }
        }

        [SpawnCounts(2, 2)]
        public class Squad_factory_1_flood_initial_end : SquadBase
        {
            public IAiActorDefinition starting_locations_0 => Squad.StartingLocations[0];
            public IAiActorDefinition starting_locations_1 => Squad.StartingLocations[1];
            public Squad_factory_1_flood_initial_end(ScenarioTag ScenarioTag) : base(ScenarioTag, 65, "factory1_flood")
            {
            }
        }

        [SpawnCounts(3, 3)]
        public class Squad_factory_1_sentinels_intro : SquadBase
        {
            public IAiActorDefinition starting_locations_0 => Squad.StartingLocations[0];
            public IAiActorDefinition starting_locations_1 => Squad.StartingLocations[1];
            public IAiActorDefinition starting_locations_2 => Squad.StartingLocations[2];
            public Squad_factory_1_sentinels_intro(ScenarioTag ScenarioTag) : base(ScenarioTag, 66, "factory1_sentinels")
            {
            }
        }

        [SpawnCounts(3, 3)]
        public class Squad_factory_1_sentinels_initial_mid : SquadBase
        {
            public IAiActorDefinition starting_locations_0 => Squad.StartingLocations[0];
            public IAiActorDefinition starting_locations_1 => Squad.StartingLocations[1];
            public IAiActorDefinition starting_locations_2 => Squad.StartingLocations[2];
            public Squad_factory_1_sentinels_initial_mid(ScenarioTag ScenarioTag) : base(ScenarioTag, 67, "factory1_sentinels")
            {
            }
        }

        [SpawnCounts(3, 3)]
        public class Squad_factory_1_sentinels_initial_end : SquadBase
        {
            public IAiActorDefinition starting_locations_0 => Squad.StartingLocations[0];
            public IAiActorDefinition starting_locations_1 => Squad.StartingLocations[1];
            public IAiActorDefinition starting_locations_2 => Squad.StartingLocations[2];
            public Squad_factory_1_sentinels_initial_end(ScenarioTag ScenarioTag) : base(ScenarioTag, 68, "factory1_sentinels")
            {
            }
        }

        [SpawnCounts(1, 1)]
        public class Squad_factory_1_major : SquadBase
        {
            public IAiActorDefinition starting_locations_0 => Squad.StartingLocations[0];
            public Squad_factory_1_major(ScenarioTag ScenarioTag) : base(ScenarioTag, 69, "factory1_sentinels")
            {
            }
        }

        [SpawnCounts(4, 4)]
        public class Squad_factory_1_sentinels_01_low : SquadBase
        {
            public IAiActorDefinition starting_locations_0 => Squad.StartingLocations[0];
            public IAiActorDefinition starting_locations_1 => Squad.StartingLocations[1];
            public IAiActorDefinition starting_locations_2 => Squad.StartingLocations[2];
            public IAiActorDefinition starting_locations_3 => Squad.StartingLocations[3];
            public Squad_factory_1_sentinels_01_low(ScenarioTag ScenarioTag) : base(ScenarioTag, 70, "factory1_sentinels")
            {
            }
        }

        [SpawnCounts(4, 4)]
        public class Squad_factory_1_sentinels_01_high : SquadBase
        {
            public IAiActorDefinition starting_locations_2 => Squad.StartingLocations[0];
            public IAiActorDefinition starting_locations_3 => Squad.StartingLocations[1];
            public IAiActorDefinition starting_locations_4 => Squad.StartingLocations[2];
            public IAiActorDefinition starting_locations_5 => Squad.StartingLocations[3];
            public Squad_factory_1_sentinels_01_high(ScenarioTag ScenarioTag) : base(ScenarioTag, 71, "factory1_sentinels")
            {
            }
        }

        [SpawnCounts(4, 4)]
        public class Squad_factory_1_sentinels_02_low : SquadBase
        {
            public IAiActorDefinition starting_locations_0 => Squad.StartingLocations[0];
            public IAiActorDefinition starting_locations_1 => Squad.StartingLocations[1];
            public IAiActorDefinition starting_locations_2 => Squad.StartingLocations[2];
            public IAiActorDefinition starting_locations_3 => Squad.StartingLocations[3];
            public Squad_factory_1_sentinels_02_low(ScenarioTag ScenarioTag) : base(ScenarioTag, 72, "factory1_sentinels")
            {
            }
        }

        [SpawnCounts(4, 4)]
        public class Squad_factory_1_sentinels_02_high : SquadBase
        {
            public IAiActorDefinition starting_locations_0 => Squad.StartingLocations[0];
            public IAiActorDefinition starting_locations_1 => Squad.StartingLocations[1];
            public IAiActorDefinition starting_locations_2 => Squad.StartingLocations[2];
            public IAiActorDefinition starting_locations_3 => Squad.StartingLocations[3];
            public Squad_factory_1_sentinels_02_high(ScenarioTag ScenarioTag) : base(ScenarioTag, 73, "factory1_sentinels")
            {
            }
        }

        [SpawnCounts(4, 4)]
        public class Squad_factory_1_sentinels_03_low : SquadBase
        {
            public IAiActorDefinition starting_locations_0 => Squad.StartingLocations[0];
            public IAiActorDefinition starting_locations_3 => Squad.StartingLocations[1];
            public IAiActorDefinition starting_locations_4 => Squad.StartingLocations[2];
            public IAiActorDefinition starting_locations_5 => Squad.StartingLocations[3];
            public Squad_factory_1_sentinels_03_low(ScenarioTag ScenarioTag) : base(ScenarioTag, 74, "factory1_sentinels")
            {
            }
        }

        [SpawnCounts(4, 4)]
        public class Squad_factory_1_sentinels_03_high : SquadBase
        {
            public IAiActorDefinition starting_locations_0 => Squad.StartingLocations[0];
            public IAiActorDefinition starting_locations_1 => Squad.StartingLocations[1];
            public IAiActorDefinition starting_locations_2 => Squad.StartingLocations[2];
            public IAiActorDefinition starting_locations_5 => Squad.StartingLocations[3];
            public Squad_factory_1_sentinels_03_high(ScenarioTag ScenarioTag) : base(ScenarioTag, 75, "factory1_sentinels")
            {
            }
        }

        [SpawnCounts(6, 6)]
        public class Squad_factory_1_flood_end : SquadBase
        {
            public IAiActorDefinition starting_locations_0 => Squad.StartingLocations[0];
            public IAiActorDefinition starting_locations_1 => Squad.StartingLocations[1];
            public IAiActorDefinition starting_locations_2 => Squad.StartingLocations[2];
            public IAiActorDefinition starting_locations_3 => Squad.StartingLocations[3];
            public IAiActorDefinition starting_locations_4 => Squad.StartingLocations[4];
            public IAiActorDefinition starting_locations_5 => Squad.StartingLocations[5];
            public Squad_factory_1_flood_end(ScenarioTag ScenarioTag) : base(ScenarioTag, 76, "factory1_flood")
            {
            }
        }

        [SpawnCounts(2, 2)]
        public class Squad_factory_1_flood_tubes_far : SquadBase
        {
            public IAiActorDefinition starting_locations_0 => Squad.StartingLocations[0];
            public IAiActorDefinition starting_locations_3 => Squad.StartingLocations[1];
            public Squad_factory_1_flood_tubes_far(ScenarioTag ScenarioTag) : base(ScenarioTag, 77, "factory1_flood")
            {
            }
        }

        [SpawnCounts(2, 2)]
        public class Squad_factory_1_flood_tubes_near : SquadBase
        {
            public IAiActorDefinition starting_locations_0 => Squad.StartingLocations[0];
            public IAiActorDefinition starting_locations_1 => Squad.StartingLocations[1];
            public Squad_factory_1_flood_tubes_near(ScenarioTag ScenarioTag) : base(ScenarioTag, 78, "factory1_flood")
            {
            }
        }

        [SpawnCounts(4, 4)]
        public class Squad_factory_1_flood_alcove : SquadBase
        {
            public IAiActorDefinition starting_locations_0 => Squad.StartingLocations[0];
            public IAiActorDefinition starting_locations_1 => Squad.StartingLocations[1];
            public IAiActorDefinition starting_locations_2 => Squad.StartingLocations[2];
            public IAiActorDefinition starting_locations_3 => Squad.StartingLocations[3];
            public Squad_factory_1_flood_alcove(ScenarioTag ScenarioTag) : base(ScenarioTag, 79, "factory1_flood")
            {
            }
        }

        [SpawnCounts(1, 1)]
        public class Squad_gorge_jugg_a1 : SquadBase
        {
            public IAiActorDefinition starting_locations_0 => Squad.StartingLocations[0];
            public Squad_gorge_jugg_a1(ScenarioTag ScenarioTag) : base(ScenarioTag, 80, "gorge_flood")
            {
            }
        }

        [SpawnCounts(1, 1)]
        public class Squad_gorge_jugg_b1 : SquadBase
        {
            public IAiActorDefinition starting_locations_0 => Squad.StartingLocations[0];
            public Squad_gorge_jugg_b1(ScenarioTag ScenarioTag) : base(ScenarioTag, 81, "gorge_flood")
            {
            }
        }

        [SpawnCounts(3, 3)]
        public class Squad_gorge_enf1 : SquadBase
        {
            public IAiActorDefinition starting_locations_0 => Squad.StartingLocations[0];
            public IAiActorDefinition starting_locations_1 => Squad.StartingLocations[1];
            public IAiActorDefinition starting_locations_2 => Squad.StartingLocations[2];
            public Squad_gorge_enf1(ScenarioTag ScenarioTag) : base(ScenarioTag, 82, "gorge_sentinels")
            {
            }
        }

        [SpawnCounts(2, 2)]
        public class Squad_gorge_sen1 : SquadBase
        {
            public IAiActorDefinition starting_locations_0 => Squad.StartingLocations[0];
            public IAiActorDefinition starting_locations_1 => Squad.StartingLocations[1];
            public IAiActorDefinition starting_locations_2 => Squad.StartingLocations[2];
            public IAiActorDefinition starting_locations_3 => Squad.StartingLocations[3];
            public IAiActorDefinition starting_locations_4 => Squad.StartingLocations[4];
            public IAiActorDefinition starting_locations_5 => Squad.StartingLocations[5];
            public IAiActorDefinition starting_locations_6 => Squad.StartingLocations[6];
            public IAiActorDefinition starting_locations_7 => Squad.StartingLocations[7];
            public IAiActorDefinition starting_locations_8 => Squad.StartingLocations[8];
            public IAiActorDefinition starting_locations_9 => Squad.StartingLocations[9];
            public IAiActorDefinition starting_locations_10 => Squad.StartingLocations[10];
            public IAiActorDefinition starting_locations_11 => Squad.StartingLocations[11];
            public IAiActorDefinition starting_locations_12 => Squad.StartingLocations[12];
            public IAiActorDefinition starting_locations_13 => Squad.StartingLocations[13];
            public IAiActorDefinition starting_locations_14 => Squad.StartingLocations[14];
            public IAiActorDefinition starting_locations_15 => Squad.StartingLocations[15];
            public IAiActorDefinition starting_locations_16 => Squad.StartingLocations[16];
            public IAiActorDefinition starting_locations_17 => Squad.StartingLocations[17];
            public Squad_gorge_sen1(ScenarioTag ScenarioTag) : base(ScenarioTag, 83, "gorge_sentinels")
            {
            }
        }

        [SpawnCounts(6, 6)]
        public class Squad_gorge_flood_bk1 : SquadBase
        {
            public IAiActorDefinition starting_locations_0 => Squad.StartingLocations[0];
            public IAiActorDefinition starting_locations_1 => Squad.StartingLocations[1];
            public IAiActorDefinition starting_locations_2 => Squad.StartingLocations[2];
            public IAiActorDefinition starting_locations_3 => Squad.StartingLocations[3];
            public IAiActorDefinition starting_locations_4 => Squad.StartingLocations[4];
            public IAiActorDefinition starting_locations_5 => Squad.StartingLocations[5];
            public IAiActorDefinition starting_locations_6 => Squad.StartingLocations[6];
            public IAiActorDefinition starting_locations_7 => Squad.StartingLocations[7];
            public IAiActorDefinition starting_locations_8 => Squad.StartingLocations[8];
            public IAiActorDefinition starting_locations_9 => Squad.StartingLocations[9];
            public IAiActorDefinition starting_locations_10 => Squad.StartingLocations[10];
            public IAiActorDefinition starting_locations_11 => Squad.StartingLocations[11];
            public Squad_gorge_flood_bk1(ScenarioTag ScenarioTag) : base(ScenarioTag, 84, "gorge_flood")
            {
            }
        }

        [SpawnCounts(7, 7)]
        public class Squad_gorge_flood_ini1 : SquadBase
        {
            public IAiActorDefinition starting_locations_0 => Squad.StartingLocations[0];
            public IAiActorDefinition starting_locations_1 => Squad.StartingLocations[1];
            public IAiActorDefinition starting_locations_2 => Squad.StartingLocations[2];
            public IAiActorDefinition starting_locations_3 => Squad.StartingLocations[3];
            public IAiActorDefinition starting_locations_4 => Squad.StartingLocations[4];
            public IAiActorDefinition starting_locations_5 => Squad.StartingLocations[5];
            public IAiActorDefinition starting_locations_6 => Squad.StartingLocations[6];
            public IAiActorDefinition starting_locations_7 => Squad.StartingLocations[7];
            public IAiActorDefinition starting_locations_8 => Squad.StartingLocations[8];
            public IAiActorDefinition starting_locations_9 => Squad.StartingLocations[9];
            public IAiActorDefinition starting_locations_10 => Squad.StartingLocations[10];
            public Squad_gorge_flood_ini1(ScenarioTag ScenarioTag) : base(ScenarioTag, 85, "gorge_flood")
            {
            }
        }

        [SpawnCounts(5, 5)]
        public class Squad_gorge_flood_bk_cave : SquadBase
        {
            public IAiActorDefinition starting_locations_0 => Squad.StartingLocations[0];
            public IAiActorDefinition starting_locations_1 => Squad.StartingLocations[1];
            public IAiActorDefinition starting_locations_2 => Squad.StartingLocations[2];
            public IAiActorDefinition starting_locations_3 => Squad.StartingLocations[3];
            public IAiActorDefinition starting_locations_4 => Squad.StartingLocations[4];
            public IAiActorDefinition starting_locations_5 => Squad.StartingLocations[5];
            public IAiActorDefinition starting_locations_6 => Squad.StartingLocations[6];
            public Squad_gorge_flood_bk_cave(ScenarioTag ScenarioTag) : base(ScenarioTag, 86, "gorge_flood")
            {
            }
        }

        [SpawnCounts(10, 10)]
        public class Squad_factory2_sen_dead : SquadBase
        {
            public IAiActorDefinition starting_locations_0 => Squad.StartingLocations[0];
            public IAiActorDefinition starting_locations_1 => Squad.StartingLocations[1];
            public IAiActorDefinition starting_locations_2 => Squad.StartingLocations[2];
            public IAiActorDefinition starting_locations_3 => Squad.StartingLocations[3];
            public IAiActorDefinition starting_locations_4 => Squad.StartingLocations[4];
            public IAiActorDefinition starting_locations_5 => Squad.StartingLocations[5];
            public IAiActorDefinition starting_locations_6 => Squad.StartingLocations[6];
            public IAiActorDefinition starting_locations_7 => Squad.StartingLocations[7];
            public IAiActorDefinition starting_locations_8 => Squad.StartingLocations[8];
            public IAiActorDefinition starting_locations_9 => Squad.StartingLocations[9];
            public Squad_factory2_sen_dead(ScenarioTag ScenarioTag) : base(ScenarioTag, 87, "factory2_sentinels")
            {
            }
        }

        [SpawnCounts(6, 6)]
        public class Squad_factory2_flood_ini1 : SquadBase
        {
            public IAiActorDefinition starting_locations_0 => Squad.StartingLocations[0];
            public IAiActorDefinition starting_locations_1 => Squad.StartingLocations[1];
            public IAiActorDefinition starting_locations_2 => Squad.StartingLocations[2];
            public IAiActorDefinition starting_locations_3 => Squad.StartingLocations[3];
            public IAiActorDefinition starting_locations_4 => Squad.StartingLocations[4];
            public IAiActorDefinition starting_locations_5 => Squad.StartingLocations[5];
            public IAiActorDefinition starting_locations_6 => Squad.StartingLocations[6];
            public IAiActorDefinition starting_locations_7 => Squad.StartingLocations[7];
            public IAiActorDefinition starting_locations_8 => Squad.StartingLocations[8];
            public IAiActorDefinition starting_locations_9 => Squad.StartingLocations[9];
            public IAiActorDefinition starting_locations_10 => Squad.StartingLocations[10];
            public IAiActorDefinition starting_locations_11 => Squad.StartingLocations[11];
            public Squad_factory2_flood_ini1(ScenarioTag ScenarioTag) : base(ScenarioTag, 88, "factory2_flood")
            {
            }
        }

        [SpawnCounts(2, 2)]
        public class Squad_factory2_flood_mid1 : SquadBase
        {
            public IAiActorDefinition starting_locations_0 => Squad.StartingLocations[0];
            public IAiActorDefinition starting_locations_1 => Squad.StartingLocations[1];
            public IAiActorDefinition starting_locations_2 => Squad.StartingLocations[2];
            public IAiActorDefinition starting_locations_3 => Squad.StartingLocations[3];
            public IAiActorDefinition starting_locations_4 => Squad.StartingLocations[4];
            public IAiActorDefinition starting_locations_5 => Squad.StartingLocations[5];
            public IAiActorDefinition starting_locations_7 => Squad.StartingLocations[6];
            public IAiActorDefinition starting_locations_8 => Squad.StartingLocations[7];
            public Squad_factory2_flood_mid1(ScenarioTag ScenarioTag) : base(ScenarioTag, 89, "factory2_flood")
            {
            }
        }

        [SpawnCounts(2, 2)]
        public class Squad_factory2_flood_bk1 : SquadBase
        {
            public IAiActorDefinition starting_locations_3 => Squad.StartingLocations[0];
            public IAiActorDefinition starting_locations_1 => Squad.StartingLocations[1];
            public IAiActorDefinition starting_locations_2 => Squad.StartingLocations[2];
            public IAiActorDefinition starting_locations_31 => Squad.StartingLocations[3];
            public Squad_factory2_flood_bk1(ScenarioTag ScenarioTag) : base(ScenarioTag, 90, "factory2_flood")
            {
            }
        }

        [SpawnCounts(1, 1)]
        public class Squad_factory2_jugg1 : SquadBase
        {
            public IAiActorDefinition starting_locations_0 => Squad.StartingLocations[0];
            public Squad_factory2_jugg1(ScenarioTag ScenarioTag) : base(ScenarioTag, 91, "factory2_flood")
            {
            }
        }

        [SpawnCounts(4, 4)]
        public class Squad_factory2_flood_bk_tunnel : SquadBase
        {
            public IAiActorDefinition starting_locations_0 => Squad.StartingLocations[0];
            public IAiActorDefinition starting_locations_1 => Squad.StartingLocations[1];
            public IAiActorDefinition starting_locations_2 => Squad.StartingLocations[2];
            public IAiActorDefinition starting_locations_3 => Squad.StartingLocations[3];
            public IAiActorDefinition starting_locations_4 => Squad.StartingLocations[4];
            public IAiActorDefinition starting_locations_5 => Squad.StartingLocations[5];
            public Squad_factory2_flood_bk_tunnel(ScenarioTag ScenarioTag) : base(ScenarioTag, 92, "factory2_flood")
            {
            }
        }

        [SpawnCounts(3, 3)]
        public class Squad_factory2_sen_bk_tunnel : SquadBase
        {
            public IAiActorDefinition starting_locations_0 => Squad.StartingLocations[0];
            public IAiActorDefinition starting_locations_1 => Squad.StartingLocations[1];
            public IAiActorDefinition starting_locations_2 => Squad.StartingLocations[2];
            public IAiActorDefinition starting_locations_3 => Squad.StartingLocations[3];
            public IAiActorDefinition starting_locations_4 => Squad.StartingLocations[4];
            public IAiActorDefinition starting_locations_5 => Squad.StartingLocations[5];
            public Squad_factory2_sen_bk_tunnel(ScenarioTag ScenarioTag) : base(ScenarioTag, 93, "factory2_sentinels")
            {
            }
        }

        [SpawnCounts(0, 0)]
        public class Squad_______EXT_B______ : SquadBase
        {
            public Squad_______EXT_B______(ScenarioTag ScenarioTag) : base(ScenarioTag, 94)
            {
            }
        }

        [SpawnCounts(1, 1)]
        public class Squad_qz_ext_b_fact_scorpion : SquadBase
        {
            public IAiActorDefinition scorpion => Squad.StartingLocations[0];
            public Squad_qz_ext_b_fact_scorpion(ScenarioTag ScenarioTag) : base(ScenarioTag, 95, "covenant_infantry")
            {
            }
        }

        [SpawnCounts(3, 3)]
        public class Squad_qz_ext_b_fact_humans : SquadBase
        {
            public IAiActorDefinition starting_locations_0 => Squad.StartingLocations[0];
            public IAiActorDefinition starting_locations_1 => Squad.StartingLocations[1];
            public IAiActorDefinition starting_locations_2 => Squad.StartingLocations[2];
            public Squad_qz_ext_b_fact_humans(ScenarioTag ScenarioTag) : base(ScenarioTag, 96, "humans")
            {
            }
        }

        [SpawnCounts(1, 1)]
        public class Squad_qz_ext_b_fact_wraith1 : SquadBase
        {
            public IAiActorDefinition starting_locations_0 => Squad.StartingLocations[0];
            public Squad_qz_ext_b_fact_wraith1(ScenarioTag ScenarioTag) : base(ScenarioTag, 97, "ext_b_flood_a")
            {
            }
        }

        [SpawnCounts(1, 1)]
        public class Squad_qz_ext_b_fact_ghosts1 : SquadBase
        {
            public IAiActorDefinition starting_locations_0 => Squad.StartingLocations[0];
            public IAiActorDefinition starting_locations_1 => Squad.StartingLocations[1];
            public Squad_qz_ext_b_fact_ghosts1(ScenarioTag ScenarioTag) : base(ScenarioTag, 98, "ext_b_flood_a")
            {
            }
        }

        [SpawnCounts(2, 2)]
        public class Squad_qz_ext_b_fact_warthog : SquadBase
        {
            public IAiActorDefinition warthog => Squad.StartingLocations[0];
            public IAiActorDefinition starting_locations_1 => Squad.StartingLocations[1];
            public Squad_qz_ext_b_fact_warthog(ScenarioTag ScenarioTag) : base(ScenarioTag, 99, "ext_b_flood_a")
            {
            }
        }

        [SpawnCounts(2, 2)]
        public class Squad_qz_ext_b_fact_ghost_bk : SquadBase
        {
            public IAiActorDefinition starting_locations_0 => Squad.StartingLocations[0];
            public IAiActorDefinition starting_locations_1 => Squad.StartingLocations[1];
            public Squad_qz_ext_b_fact_ghost_bk(ScenarioTag ScenarioTag) : base(ScenarioTag, 100, "ext_b_flood_a")
            {
            }
        }

        [SpawnCounts(2, 2)]
        public class Squad_qz_ext_b_fact_ghosts_spare1 : SquadBase
        {
            public IAiActorDefinition a => Squad.StartingLocations[0];
            public IAiActorDefinition b => Squad.StartingLocations[1];
            public Squad_qz_ext_b_fact_ghosts_spare1(ScenarioTag ScenarioTag) : base(ScenarioTag, 101, "covenant_infantry")
            {
            }
        }

        [SpawnCounts(5, 5)]
        public class Squad_qz_ext_b_fact_flood1 : SquadBase
        {
            public IAiActorDefinition starting_locations_0 => Squad.StartingLocations[0];
            public IAiActorDefinition starting_locations_1 => Squad.StartingLocations[1];
            public IAiActorDefinition starting_locations_2 => Squad.StartingLocations[2];
            public IAiActorDefinition starting_locations_3 => Squad.StartingLocations[3];
            public IAiActorDefinition starting_locations_4 => Squad.StartingLocations[4];
            public IAiActorDefinition starting_locations_5 => Squad.StartingLocations[5];
            public IAiActorDefinition starting_locations_6 => Squad.StartingLocations[6];
            public IAiActorDefinition starting_locations_7 => Squad.StartingLocations[7];
            public IAiActorDefinition starting_locations_8 => Squad.StartingLocations[8];
            public IAiActorDefinition starting_locations_9 => Squad.StartingLocations[9];
            public IAiActorDefinition starting_locations_10 => Squad.StartingLocations[10];
            public IAiActorDefinition starting_locations_11 => Squad.StartingLocations[11];
            public IAiActorDefinition starting_locations_12 => Squad.StartingLocations[12];
            public IAiActorDefinition starting_locations_13 => Squad.StartingLocations[13];
            public IAiActorDefinition starting_locations_14 => Squad.StartingLocations[14];
            public IAiActorDefinition starting_locations_15 => Squad.StartingLocations[15];
            public Squad_qz_ext_b_fact_flood1(ScenarioTag ScenarioTag) : base(ScenarioTag, 102, "ext_b_flood_a")
            {
            }
        }

        [SpawnCounts(1, 1)]
        public class Squad_qz_ext_b_cov_phantom : SquadBase
        {
            public IAiActorDefinition phantom => Squad.StartingLocations[0];
            public Squad_qz_ext_b_cov_phantom(ScenarioTag ScenarioTag) : base(ScenarioTag, 103, "covenant_infantry")
            {
            }
        }

        [SpawnCounts(2, 2)]
        public class Squad_qz_ext_b_cov_ghosts : SquadBase
        {
            public IAiActorDefinition a => Squad.StartingLocations[0];
            public IAiActorDefinition b => Squad.StartingLocations[1];
            public Squad_qz_ext_b_cov_ghosts(ScenarioTag ScenarioTag) : base(ScenarioTag, 104, "covenant1")
            {
            }
        }

        [SpawnCounts(1, 1)]
        public class Squad_qz_ext_b_cov_spectre : SquadBase
        {
            public IAiActorDefinition spectre => Squad.StartingLocations[0];
            public Squad_qz_ext_b_cov_spectre(ScenarioTag ScenarioTag) : base(ScenarioTag, 105, "covenant_vehicles")
            {
            }
        }

        [SpawnCounts(2, 2)]
        public class Squad_qz_ext_b_cov_spec_ops : SquadBase
        {
            public IAiActorDefinition soc => Squad.StartingLocations[0];
            public IAiActorDefinition starting_locations_1 => Squad.StartingLocations[1];
            public IAiActorDefinition starting_locations_2 => Squad.StartingLocations[2];
            public IAiActorDefinition starting_locations_3 => Squad.StartingLocations[3];
            public Squad_qz_ext_b_cov_spec_ops(ScenarioTag ScenarioTag) : base(ScenarioTag, 106, "covenant_infantry")
            {
            }
        }

        [SpawnCounts(1, 1)]
        public class Squad_qz_ext_b_wraith_a1 : SquadBase
        {
            public IAiActorDefinition starting_locations_0 => Squad.StartingLocations[0];
            public Squad_qz_ext_b_wraith_a1(ScenarioTag ScenarioTag) : base(ScenarioTag, 107, "ext_b_flood_b")
            {
            }
        }

        [SpawnCounts(1, 1)]
        public class Squad_qz_ext_b_wraith_b1 : SquadBase
        {
            public IAiActorDefinition starting_locations_0 => Squad.StartingLocations[0];
            public Squad_qz_ext_b_wraith_b1(ScenarioTag ScenarioTag) : base(ScenarioTag, 108, "ext_b_flood_b")
            {
            }
        }

        [SpawnCounts(2, 2)]
        public class Squad_qz_ext_b_ghosts_a : SquadBase
        {
            public IAiActorDefinition starting_locations_0 => Squad.StartingLocations[0];
            public IAiActorDefinition starting_locations_1 => Squad.StartingLocations[1];
            public Squad_qz_ext_b_ghosts_a(ScenarioTag ScenarioTag) : base(ScenarioTag, 109, "ext_b_flood_b")
            {
            }
        }

        [SpawnCounts(2, 2)]
        public class Squad_qz_ext_b_ghosts_b : SquadBase
        {
            public IAiActorDefinition starting_locations_0 => Squad.StartingLocations[0];
            public IAiActorDefinition starting_locations_1 => Squad.StartingLocations[1];
            public Squad_qz_ext_b_ghosts_b(ScenarioTag ScenarioTag) : base(ScenarioTag, 110, "ext_b_flood_b")
            {
            }
        }

        [SpawnCounts(2, 2)]
        public class Squad_qz_ext_b_warthog : SquadBase
        {
            public IAiActorDefinition warthog => Squad.StartingLocations[0];
            public IAiActorDefinition starting_locations_2 => Squad.StartingLocations[1];
            public Squad_qz_ext_b_warthog(ScenarioTag ScenarioTag) : base(ScenarioTag, 111, "ext_b_flood_b")
            {
            }
        }

        [SpawnCounts(2, 2)]
        public class Squad_qz_ext_b_warthog_gauss : SquadBase
        {
            public IAiActorDefinition warthog => Squad.StartingLocations[0];
            public IAiActorDefinition starting_locations_2 => Squad.StartingLocations[1];
            public Squad_qz_ext_b_warthog_gauss(ScenarioTag ScenarioTag) : base(ScenarioTag, 112, "ext_b_flood_b")
            {
            }
        }

        [SpawnCounts(1, 1)]
        public class Squad_qz_ext_b_enf_a1 : SquadBase
        {
            public IAiActorDefinition starting_locations_0 => Squad.StartingLocations[0];
            public Squad_qz_ext_b_enf_a1(ScenarioTag ScenarioTag) : base(ScenarioTag, 113, "ext_b_sentinels_b")
            {
            }
        }

        [SpawnCounts(1, 1)]
        public class Squad_qz_ext_b_enf_b1 : SquadBase
        {
            public IAiActorDefinition starting_locations_0 => Squad.StartingLocations[0];
            public Squad_qz_ext_b_enf_b1(ScenarioTag ScenarioTag) : base(ScenarioTag, 114, "ext_b_sentinels_b")
            {
            }
        }

        [SpawnCounts(1, 1)]
        public class Squad_qz_ext_b_ent_scorpion1 : SquadBase
        {
            public IAiActorDefinition starting_locations_0 => Squad.StartingLocations[0];
            public Squad_qz_ext_b_ent_scorpion1(ScenarioTag ScenarioTag) : base(ScenarioTag, 115, "ext_b_flood_c")
            {
            }
        }

        [SpawnCounts(1, 1)]
        public class Squad_qz_ext_b_ent_wraith_a : SquadBase
        {
            public IAiActorDefinition starting_locations_0 => Squad.StartingLocations[0];
            public Squad_qz_ext_b_ent_wraith_a(ScenarioTag ScenarioTag) : base(ScenarioTag, 116, "ext_b_flood_c")
            {
            }
        }

        [SpawnCounts(1, 1)]
        public class Squad_qz_ext_b_ent_cov_phantom : SquadBase
        {
            public IAiActorDefinition starting_locations_0 => Squad.StartingLocations[0];
            public Squad_qz_ext_b_ent_cov_phantom(ScenarioTag ScenarioTag) : base(ScenarioTag, 117, "covenant_infantry")
            {
            }
        }

        [SpawnCounts(3, 3)]
        public class Squad_qz_ext_b_ent_turrets1 : SquadBase
        {
            public IAiActorDefinition mp_a => Squad.StartingLocations[0];
            public IAiActorDefinition mp_b => Squad.StartingLocations[1];
            public IAiActorDefinition mp_c => Squad.StartingLocations[2];
            public IAiActorDefinition mp_d => Squad.StartingLocations[3];
            public IAiActorDefinition ap_a => Squad.StartingLocations[4];
            public IAiActorDefinition ap_b => Squad.StartingLocations[5];
            public IAiActorDefinition ap_c => Squad.StartingLocations[6];
            public Squad_qz_ext_b_ent_turrets1(ScenarioTag ScenarioTag) : base(ScenarioTag, 118, "flood")
            {
            }
        }

        [SpawnCounts(6, 6)]
        public class Squad_qz_ext_b_ent_flood_bk : SquadBase
        {
            public IAiActorDefinition starting_locations_0 => Squad.StartingLocations[0];
            public IAiActorDefinition starting_locations_1 => Squad.StartingLocations[1];
            public IAiActorDefinition starting_locations_2 => Squad.StartingLocations[2];
            public IAiActorDefinition starting_locations_3 => Squad.StartingLocations[3];
            public IAiActorDefinition starting_locations_4 => Squad.StartingLocations[4];
            public IAiActorDefinition starting_locations_5 => Squad.StartingLocations[5];
            public IAiActorDefinition starting_locations_6 => Squad.StartingLocations[6];
            public IAiActorDefinition starting_locations_7 => Squad.StartingLocations[7];
            public Squad_qz_ext_b_ent_flood_bk(ScenarioTag ScenarioTag) : base(ScenarioTag, 119, "ext_b_flood_d")
            {
            }
        }

        [SpawnCounts(2, 2)]
        public class Squad_qz_ext_b_ent_ghost_bk : SquadBase
        {
            public IAiActorDefinition starting_locations_0 => Squad.StartingLocations[0];
            public IAiActorDefinition starting_locations_1 => Squad.StartingLocations[1];
            public Squad_qz_ext_b_ent_ghost_bk(ScenarioTag ScenarioTag) : base(ScenarioTag, 120, "ext_b_flood_d")
            {
            }
        }

        [SpawnCounts(2, 2)]
        public class Squad_qz_ext_b_ent_enf1 : SquadBase
        {
            public IAiActorDefinition starting_locations_0 => Squad.StartingLocations[0];
            public IAiActorDefinition starting_locations_1 => Squad.StartingLocations[1];
            public Squad_qz_ext_b_ent_enf1(ScenarioTag ScenarioTag) : base(ScenarioTag, 121, "ext_b_sentinels_c")
            {
            }
        }

        [SpawnCounts(4, 4)]
        public class Squad_qz_ext_b_ent_flood_tube_a : SquadBase
        {
            public IAiActorDefinition starting_locations_0 => Squad.StartingLocations[0];
            public IAiActorDefinition starting_locations_2 => Squad.StartingLocations[1];
            public IAiActorDefinition starting_locations_4 => Squad.StartingLocations[2];
            public IAiActorDefinition starting_locations_6 => Squad.StartingLocations[3];
            public IAiActorDefinition starting_locations_8 => Squad.StartingLocations[4];
            public Squad_qz_ext_b_ent_flood_tube_a(ScenarioTag ScenarioTag) : base(ScenarioTag, 122, "ext_b_flood_d")
            {
            }
        }

        [SpawnCounts(4, 4)]
        public class Squad_qz_ext_b_ent_flood_tube_b : SquadBase
        {
            public IAiActorDefinition starting_locations_0 => Squad.StartingLocations[0];
            public IAiActorDefinition starting_locations_2 => Squad.StartingLocations[1];
            public IAiActorDefinition starting_locations_4 => Squad.StartingLocations[2];
            public IAiActorDefinition starting_locations_6 => Squad.StartingLocations[3];
            public IAiActorDefinition starting_locations_8 => Squad.StartingLocations[4];
            public Squad_qz_ext_b_ent_flood_tube_b(ScenarioTag ScenarioTag) : base(ScenarioTag, 123, "ext_b_flood_d")
            {
            }
        }

        [SpawnCounts(0, 0)]
        public class Squad_squads_156 : SquadBase
        {
            public Squad_squads_156(ScenarioTag ScenarioTag) : base(ScenarioTag, 124)
            {
            }
        }

        [SpawnCounts(0, 0)]
        public class Squad_squads_157 : SquadBase
        {
            public Squad_squads_157(ScenarioTag ScenarioTag) : base(ScenarioTag, 125)
            {
            }
        }

        [SpawnCounts(5, 5)]
        public class Squad_______KEY______ : SquadBase
        {
            public Squad_______KEY______(ScenarioTag ScenarioTag) : base(ScenarioTag, 126, "e20_cov")
            {
            }
        }

        [SpawnCounts(5, 5)]
        public class Squad_e20_cov_inf0 : SquadBase
        {
            public IAiActorDefinition starting_locations_0 => Squad.StartingLocations[0];
            public IAiActorDefinition starting_locations_1 => Squad.StartingLocations[1];
            public IAiActorDefinition starting_locations_2 => Squad.StartingLocations[2];
            public IAiActorDefinition starting_locations_3 => Squad.StartingLocations[3];
            public IAiActorDefinition starting_locations_4 => Squad.StartingLocations[4];
            public Squad_e20_cov_inf0(ScenarioTag ScenarioTag) : base(ScenarioTag, 127, "e20_cov")
            {
            }
        }

        [SpawnCounts(6, 6)]
        public class Squad_e20_fld_combats0_0 : SquadBase
        {
            public IAiActorDefinition infs0 => Squad.StartingLocations[0];
            public IAiActorDefinition starting_locations_1 => Squad.StartingLocations[1];
            public IAiActorDefinition starting_locations_2 => Squad.StartingLocations[2];
            public IAiActorDefinition starting_locations_3 => Squad.StartingLocations[3];
            public IAiActorDefinition starting_locations_4 => Squad.StartingLocations[4];
            public IAiActorDefinition starting_locations_5 => Squad.StartingLocations[5];
            public Squad_e20_fld_combats0_0(ScenarioTag ScenarioTag) : base(ScenarioTag, 128, "e20_fld_combats0")
            {
            }
        }

        [SpawnCounts(8, 8)]
        public class Squad_e20_fld_combats0_1 : SquadBase
        {
            public IAiActorDefinition _0 => Squad.StartingLocations[0];
            public IAiActorDefinition _1 => Squad.StartingLocations[1];
            public IAiActorDefinition _2 => Squad.StartingLocations[2];
            public IAiActorDefinition _3 => Squad.StartingLocations[3];
            public IAiActorDefinition _4 => Squad.StartingLocations[4];
            public IAiActorDefinition _5 => Squad.StartingLocations[5];
            public IAiActorDefinition _6 => Squad.StartingLocations[6];
            public IAiActorDefinition _7 => Squad.StartingLocations[7];
            public Squad_e20_fld_combats0_1(ScenarioTag ScenarioTag) : base(ScenarioTag, 129, "e20_fld_combats0")
            {
            }
        }

        [SpawnCounts(4, 4)]
        public class Squad_e20_fld_combats1 : SquadBase
        {
            public Squad_e20_fld_combats1(ScenarioTag ScenarioTag) : base(ScenarioTag, 130, "e20_fld")
            {
            }
        }

        [SpawnCounts(2, 2)]
        public class Squad_e21_cov_inf0_0 : SquadBase
        {
            public IAiActorDefinition starting_locations_1 => Squad.StartingLocations[0];
            public IAiActorDefinition starting_locations_2 => Squad.StartingLocations[1];
            public Squad_e21_cov_inf0_0(ScenarioTag ScenarioTag) : base(ScenarioTag, 131, "e21_cov_inf0")
            {
            }
        }

        [SpawnCounts(2, 2)]
        public class Squad_e21_cov_inf0_1 : SquadBase
        {
            public IAiActorDefinition starting_locations_0 => Squad.StartingLocations[0];
            public IAiActorDefinition starting_locations_1 => Squad.StartingLocations[1];
            public Squad_e21_cov_inf0_1(ScenarioTag ScenarioTag) : base(ScenarioTag, 132, "e21_cov_inf0")
            {
            }
        }

        [SpawnCounts(6, 6)]
        public class Squad_e21_fld_inf0_0 : SquadBase
        {
            public IAiActorDefinition starting_locations_0 => Squad.StartingLocations[0];
            public IAiActorDefinition starting_locations_1 => Squad.StartingLocations[1];
            public IAiActorDefinition starting_locations_2 => Squad.StartingLocations[2];
            public IAiActorDefinition starting_locations_3 => Squad.StartingLocations[3];
            public IAiActorDefinition starting_locations_4 => Squad.StartingLocations[4];
            public IAiActorDefinition starting_locations_5 => Squad.StartingLocations[5];
            public Squad_e21_fld_inf0_0(ScenarioTag ScenarioTag) : base(ScenarioTag, 133, "e21_fld_inf0")
            {
            }
        }

        [SpawnCounts(1, 1)]
        public class Squad_e21_fld_inf0_1 : SquadBase
        {
            public IAiActorDefinition starting_locations_0 => Squad.StartingLocations[0];
            public IAiActorDefinition starting_locations_1 => Squad.StartingLocations[1];
            public IAiActorDefinition starting_locations_2 => Squad.StartingLocations[2];
            public IAiActorDefinition starting_locations_3 => Squad.StartingLocations[3];
            public IAiActorDefinition starting_locations_4 => Squad.StartingLocations[4];
            public IAiActorDefinition starting_locations_5 => Squad.StartingLocations[5];
            public IAiActorDefinition starting_locations_6 => Squad.StartingLocations[6];
            public IAiActorDefinition starting_locations_7 => Squad.StartingLocations[7];
            public IAiActorDefinition starting_locations_8 => Squad.StartingLocations[8];
            public IAiActorDefinition starting_locations_9 => Squad.StartingLocations[9];
            public IAiActorDefinition starting_locations_10 => Squad.StartingLocations[10];
            public Squad_e21_fld_inf0_1(ScenarioTag ScenarioTag) : base(ScenarioTag, 134, "e21_fld_inf0")
            {
            }
        }

        [SpawnCounts(1, 1)]
        public class Squad_e21_fld_inf0_2 : SquadBase
        {
            public IAiActorDefinition starting_locations_0 => Squad.StartingLocations[0];
            public IAiActorDefinition starting_locations_1 => Squad.StartingLocations[1];
            public IAiActorDefinition starting_locations_2 => Squad.StartingLocations[2];
            public IAiActorDefinition starting_locations_3 => Squad.StartingLocations[3];
            public IAiActorDefinition starting_locations_4 => Squad.StartingLocations[4];
            public Squad_e21_fld_inf0_2(ScenarioTag ScenarioTag) : base(ScenarioTag, 135, "e21_fld_inf0")
            {
            }
        }

        [SpawnCounts(1, 1)]
        public class Squad_e21_fld_carriers0 : SquadBase
        {
            public IAiActorDefinition starting_locations_0 => Squad.StartingLocations[0];
            public Squad_e21_fld_carriers0(ScenarioTag ScenarioTag) : base(ScenarioTag, 136, "e21_fld")
            {
            }
        }

        [SpawnCounts(0, 0)]
        public class Squad_e21_fld_inf1_0 : SquadBase
        {
            public Squad_e21_fld_inf1_0(ScenarioTag ScenarioTag) : base(ScenarioTag, 137, "e21_fld_inf1")
            {
            }
        }

        [SpawnCounts(1, 1)]
        public class Squad_e21_fld_inf1_1 : SquadBase
        {
            public IAiActorDefinition starting_locations_0 => Squad.StartingLocations[0];
            public IAiActorDefinition starting_locations_1 => Squad.StartingLocations[1];
            public IAiActorDefinition starting_locations_2 => Squad.StartingLocations[2];
            public IAiActorDefinition starting_locations_3 => Squad.StartingLocations[3];
            public IAiActorDefinition starting_locations_4 => Squad.StartingLocations[4];
            public IAiActorDefinition starting_locations_5 => Squad.StartingLocations[5];
            public IAiActorDefinition starting_locations_6 => Squad.StartingLocations[6];
            public IAiActorDefinition starting_locations_7 => Squad.StartingLocations[7];
            public IAiActorDefinition starting_locations_8 => Squad.StartingLocations[8];
            public IAiActorDefinition starting_locations_9 => Squad.StartingLocations[9];
            public Squad_e21_fld_inf1_1(ScenarioTag ScenarioTag) : base(ScenarioTag, 138, "e21_fld_inf1")
            {
            }
        }

        [SpawnCounts(1, 1)]
        public class Squad_e21_fld_inf1_2 : SquadBase
        {
            public IAiActorDefinition starting_locations_0 => Squad.StartingLocations[0];
            public IAiActorDefinition starting_locations_1 => Squad.StartingLocations[1];
            public IAiActorDefinition starting_locations_2 => Squad.StartingLocations[2];
            public IAiActorDefinition starting_locations_3 => Squad.StartingLocations[3];
            public IAiActorDefinition starting_locations_4 => Squad.StartingLocations[4];
            public IAiActorDefinition starting_locations_5 => Squad.StartingLocations[5];
            public Squad_e21_fld_inf1_2(ScenarioTag ScenarioTag) : base(ScenarioTag, 139, "e21_fld_inf1")
            {
            }
        }

        [SpawnCounts(1, 1)]
        public class Squad_e21_fld_carriers1 : SquadBase
        {
            public IAiActorDefinition starting_locations_0 => Squad.StartingLocations[0];
            public Squad_e21_fld_carriers1(ScenarioTag ScenarioTag) : base(ScenarioTag, 140, "e21_fld")
            {
            }
        }

        [SpawnCounts(4, 4)]
        public class Squad_e22_cov_inf0 : SquadBase
        {
            public IAiActorDefinition starting_locations_0 => Squad.StartingLocations[0];
            public IAiActorDefinition starting_locations_1 => Squad.StartingLocations[1];
            public IAiActorDefinition starting_locations_2 => Squad.StartingLocations[2];
            public IAiActorDefinition starting_locations_3 => Squad.StartingLocations[3];
            public Squad_e22_cov_inf0(ScenarioTag ScenarioTag) : base(ScenarioTag, 141, "e22_cov")
            {
            }
        }

        [SpawnCounts(0, 0)]
        public class Squad_e22_cov_inf1_0 : SquadBase
        {
            public Squad_e22_cov_inf1_0(ScenarioTag ScenarioTag) : base(ScenarioTag, 142, "e22_cov_inf1")
            {
            }
        }

        [SpawnCounts(0, 0)]
        public class Squad_e22_cov_inf1_1 : SquadBase
        {
            public Squad_e22_cov_inf1_1(ScenarioTag ScenarioTag) : base(ScenarioTag, 143, "e22_cov_inf1")
            {
            }
        }

        [SpawnCounts(5, 5)]
        public class Squad_e22_fld_inf0_0 : SquadBase
        {
            public IAiActorDefinition starting_locations_0 => Squad.StartingLocations[0];
            public IAiActorDefinition starting_locations_1 => Squad.StartingLocations[1];
            public IAiActorDefinition starting_locations_2 => Squad.StartingLocations[2];
            public IAiActorDefinition starting_locations_3 => Squad.StartingLocations[3];
            public IAiActorDefinition starting_locations_4 => Squad.StartingLocations[4];
            public Squad_e22_fld_inf0_0(ScenarioTag ScenarioTag) : base(ScenarioTag, 144, "e22_fld_inf0")
            {
            }
        }

        [SpawnCounts(0, 0)]
        public class Squad_e22_fld_inf0_1 : SquadBase
        {
            public IAiActorDefinition starting_locations_0 => Squad.StartingLocations[0];
            public IAiActorDefinition starting_locations_1 => Squad.StartingLocations[1];
            public IAiActorDefinition starting_locations_2 => Squad.StartingLocations[2];
            public IAiActorDefinition starting_locations_3 => Squad.StartingLocations[3];
            public IAiActorDefinition starting_locations_4 => Squad.StartingLocations[4];
            public Squad_e22_fld_inf0_1(ScenarioTag ScenarioTag) : base(ScenarioTag, 145, "e22_fld_inf0")
            {
            }
        }

        [SpawnCounts(1, 1)]
        public class Squad_e22_fld_inf1 : SquadBase
        {
            public Squad_e22_fld_inf1(ScenarioTag ScenarioTag) : base(ScenarioTag, 146, "e22_fld")
            {
            }
        }

        [SpawnCounts(4, 4)]
        public class Squad_e23_cov_inf0 : SquadBase
        {
            public Squad_e23_cov_inf0(ScenarioTag ScenarioTag) : base(ScenarioTag, 147, "e23_cov")
            {
            }
        }

        [SpawnCounts(6, 6)]
        public class Squad_e23_fld_inf0_0 : SquadBase
        {
            public IAiActorDefinition starting_locations_0 => Squad.StartingLocations[0];
            public IAiActorDefinition starting_locations_1 => Squad.StartingLocations[1];
            public IAiActorDefinition starting_locations_2 => Squad.StartingLocations[2];
            public IAiActorDefinition starting_locations_3 => Squad.StartingLocations[3];
            public IAiActorDefinition starting_locations_4 => Squad.StartingLocations[4];
            public IAiActorDefinition starting_locations_5 => Squad.StartingLocations[5];
            public Squad_e23_fld_inf0_0(ScenarioTag ScenarioTag) : base(ScenarioTag, 148, "e23_fld_inf0")
            {
            }
        }

        [SpawnCounts(6, 6)]
        public class Squad_e23_fld_inf0_1 : SquadBase
        {
            public IAiActorDefinition starting_locations_0 => Squad.StartingLocations[0];
            public IAiActorDefinition starting_locations_1 => Squad.StartingLocations[1];
            public IAiActorDefinition starting_locations_2 => Squad.StartingLocations[2];
            public IAiActorDefinition starting_locations_3 => Squad.StartingLocations[3];
            public IAiActorDefinition starting_locations_4 => Squad.StartingLocations[4];
            public IAiActorDefinition starting_locations_5 => Squad.StartingLocations[5];
            public Squad_e23_fld_inf0_1(ScenarioTag ScenarioTag) : base(ScenarioTag, 149, "e23_fld_inf0")
            {
            }
        }

        [SpawnCounts(4, 4)]
        public class Squad_e24_cov_inf0 : SquadBase
        {
            public Squad_e24_cov_inf0(ScenarioTag ScenarioTag) : base(ScenarioTag, 150, "e24_cov")
            {
            }
        }

        [SpawnCounts(0, 0)]
        public class Squad_e24_fld_inf0 : SquadBase
        {
            public Squad_e24_fld_inf0(ScenarioTag ScenarioTag) : base(ScenarioTag, 151, "e24_fld")
            {
            }
        }

        [SpawnCounts(5, 5)]
        public class Squad_e24_fld_inf1_0 : SquadBase
        {
            public IAiActorDefinition starting_locations_0 => Squad.StartingLocations[0];
            public IAiActorDefinition starting_locations_1 => Squad.StartingLocations[1];
            public IAiActorDefinition starting_locations_2 => Squad.StartingLocations[2];
            public IAiActorDefinition starting_locations_3 => Squad.StartingLocations[3];
            public IAiActorDefinition starting_locations_4 => Squad.StartingLocations[4];
            public Squad_e24_fld_inf1_0(ScenarioTag ScenarioTag) : base(ScenarioTag, 152, "e24_fld_inf1")
            {
            }
        }

        [SpawnCounts(5, 5)]
        public class Squad_e24_fld_inf1_1 : SquadBase
        {
            public IAiActorDefinition starting_locations_0 => Squad.StartingLocations[0];
            public IAiActorDefinition starting_locations_1 => Squad.StartingLocations[1];
            public IAiActorDefinition starting_locations_2 => Squad.StartingLocations[2];
            public IAiActorDefinition starting_locations_3 => Squad.StartingLocations[3];
            public IAiActorDefinition starting_locations_4 => Squad.StartingLocations[4];
            public Squad_e24_fld_inf1_1(ScenarioTag ScenarioTag) : base(ScenarioTag, 153, "e24_fld_inf1")
            {
            }
        }

        [SpawnCounts(8, 8)]
        public class Squad_e24_fld_inf2 : SquadBase
        {
            public IAiActorDefinition starting_locations_0 => Squad.StartingLocations[0];
            public IAiActorDefinition starting_locations_1 => Squad.StartingLocations[1];
            public IAiActorDefinition starting_locations_2 => Squad.StartingLocations[2];
            public IAiActorDefinition starting_locations_3 => Squad.StartingLocations[3];
            public IAiActorDefinition starting_locations_4 => Squad.StartingLocations[4];
            public IAiActorDefinition starting_locations_5 => Squad.StartingLocations[5];
            public IAiActorDefinition starting_locations_6 => Squad.StartingLocations[6];
            public IAiActorDefinition starting_locations_7 => Squad.StartingLocations[7];
            public Squad_e24_fld_inf2(ScenarioTag ScenarioTag) : base(ScenarioTag, 154, "e24_fld")
            {
            }
        }

        [SpawnCounts(4, 4)]
        public class Squad_e25_cov_inf0 : SquadBase
        {
            public Squad_e25_cov_inf0(ScenarioTag ScenarioTag) : base(ScenarioTag, 155, "e25_cov")
            {
            }
        }

        [SpawnCounts(5, 5)]
        public class Squad_e25_fld_inf0_0 : SquadBase
        {
            public IAiActorDefinition starting_locations_0 => Squad.StartingLocations[0];
            public IAiActorDefinition starting_locations_1 => Squad.StartingLocations[1];
            public IAiActorDefinition starting_locations_2 => Squad.StartingLocations[2];
            public IAiActorDefinition starting_locations_3 => Squad.StartingLocations[3];
            public IAiActorDefinition starting_locations_4 => Squad.StartingLocations[4];
            public Squad_e25_fld_inf0_0(ScenarioTag ScenarioTag) : base(ScenarioTag, 156, "e25_fld_inf0")
            {
            }
        }

        [SpawnCounts(5, 5)]
        public class Squad_e25_fld_inf0_1 : SquadBase
        {
            public IAiActorDefinition starting_locations_0 => Squad.StartingLocations[0];
            public IAiActorDefinition starting_locations_1 => Squad.StartingLocations[1];
            public IAiActorDefinition starting_locations_2 => Squad.StartingLocations[2];
            public IAiActorDefinition starting_locations_3 => Squad.StartingLocations[3];
            public IAiActorDefinition starting_locations_4 => Squad.StartingLocations[4];
            public Squad_e25_fld_inf0_1(ScenarioTag ScenarioTag) : base(ScenarioTag, 157, "e25_fld_inf0")
            {
            }
        }

        [SpawnCounts(5, 5)]
        public class Squad_e25_fld_inf0_2 : SquadBase
        {
            public IAiActorDefinition starting_locations_0 => Squad.StartingLocations[0];
            public IAiActorDefinition starting_locations_1 => Squad.StartingLocations[1];
            public IAiActorDefinition starting_locations_2 => Squad.StartingLocations[2];
            public IAiActorDefinition starting_locations_3 => Squad.StartingLocations[3];
            public IAiActorDefinition starting_locations_4 => Squad.StartingLocations[4];
            public Squad_e25_fld_inf0_2(ScenarioTag ScenarioTag) : base(ScenarioTag, 158, "e25_fld_inf0")
            {
            }
        }

        [SpawnCounts(2, 2)]
        public class Squad_e25_fld_inf1_0 : SquadBase
        {
            public IAiActorDefinition starting_locations_0 => Squad.StartingLocations[0];
            public IAiActorDefinition starting_locations_1 => Squad.StartingLocations[1];
            public IAiActorDefinition starting_locations_2 => Squad.StartingLocations[2];
            public IAiActorDefinition starting_locations_3 => Squad.StartingLocations[3];
            public IAiActorDefinition starting_locations_4 => Squad.StartingLocations[4];
            public Squad_e25_fld_inf1_0(ScenarioTag ScenarioTag) : base(ScenarioTag, 159, "e25_fld_inf1")
            {
            }
        }

        [SpawnCounts(4, 4)]
        public class Squad_e25_fld_inf1_1 : SquadBase
        {
            public IAiActorDefinition starting_locations_0 => Squad.StartingLocations[0];
            public IAiActorDefinition starting_locations_1 => Squad.StartingLocations[1];
            public IAiActorDefinition starting_locations_2 => Squad.StartingLocations[2];
            public IAiActorDefinition starting_locations_3 => Squad.StartingLocations[3];
            public IAiActorDefinition starting_locations_4 => Squad.StartingLocations[4];
            public Squad_e25_fld_inf1_1(ScenarioTag ScenarioTag) : base(ScenarioTag, 160, "e25_fld_inf1")
            {
            }
        }

        [SpawnCounts(5, 5)]
        public class Squad_e25_fld_inf1_2 : SquadBase
        {
            public IAiActorDefinition starting_locations_0 => Squad.StartingLocations[0];
            public IAiActorDefinition starting_locations_1 => Squad.StartingLocations[1];
            public IAiActorDefinition starting_locations_2 => Squad.StartingLocations[2];
            public IAiActorDefinition starting_locations_3 => Squad.StartingLocations[3];
            public IAiActorDefinition starting_locations_4 => Squad.StartingLocations[4];
            public Squad_e25_fld_inf1_2(ScenarioTag ScenarioTag) : base(ScenarioTag, 161, "e25_fld_inf1")
            {
            }
        }

        [SpawnCounts(4, 4)]
        public class Squad_e26_fld_infection_forms0 : SquadBase
        {
            public IAiActorDefinition swarm0 => Squad.StartingLocations[0];
            public IAiActorDefinition swarm1 => Squad.StartingLocations[1];
            public IAiActorDefinition swarm2 => Squad.StartingLocations[2];
            public IAiActorDefinition swarm3 => Squad.StartingLocations[3];
            public Squad_e26_fld_infection_forms0(ScenarioTag ScenarioTag) : base(ScenarioTag, 162, "flood")
            {
            }
        }

        [SpawnCounts(1, 1)]
        public class Squad_key_ride_tartarus : SquadBase
        {
            public IAiActorDefinition tartarus => Squad.StartingLocations[0];
            public Squad_key_ride_tartarus(ScenarioTag ScenarioTag) : base(ScenarioTag, 163)
            {
            }
        }

        [SpawnCounts(1, 1)]
        public class Squad_silly : SquadBase
        {
            public IAiActorDefinition starting_locations_0 => Squad.StartingLocations[0];
            public Squad_silly(ScenarioTag ScenarioTag) : base(ScenarioTag, 164)
            {
            }
        }

        [SpawnCounts(0, 0)]
        public class Squad_key_cov_dump : SquadBase
        {
            public IAiActorDefinition starting_locations_0 => Squad.StartingLocations[0];
            public IAiActorDefinition starting_locations_1 => Squad.StartingLocations[1];
            public IAiActorDefinition starting_locations_2 => Squad.StartingLocations[2];
            public IAiActorDefinition starting_locations_3 => Squad.StartingLocations[3];
            public IAiActorDefinition starting_locations_4 => Squad.StartingLocations[4];
            public IAiActorDefinition starting_locations_5 => Squad.StartingLocations[5];
            public IAiActorDefinition starting_locations_6 => Squad.StartingLocations[6];
            public IAiActorDefinition starting_locations_7 => Squad.StartingLocations[7];
            public IAiActorDefinition starting_locations_8 => Squad.StartingLocations[8];
            public IAiActorDefinition starting_locations_9 => Squad.StartingLocations[9];
            public IAiActorDefinition starting_locations_10 => Squad.StartingLocations[10];
            public Squad_key_cov_dump(ScenarioTag ScenarioTag) : base(ScenarioTag, 165, "covenant_infantry")
            {
            }
        }

        [SpawnCounts(0, 0)]
        public class Squad_squads_166 : SquadBase
        {
            public Squad_squads_166(ScenarioTag ScenarioTag) : base(ScenarioTag, 166)
            {
            }
        }

        [SpawnCounts(0, 0)]
        public class Squad_squads_167 : SquadBase
        {
            public Squad_squads_167(ScenarioTag ScenarioTag) : base(ScenarioTag, 167)
            {
            }
        }

        [SpawnCounts(0, 0)]
        public class Squad_squads_168 : SquadBase
        {
            public Squad_squads_168(ScenarioTag ScenarioTag) : base(ScenarioTag, 168)
            {
            }
        }

        [SpawnCounts(0, 0)]
        public class Squad_squads_169 : SquadBase
        {
            public Squad_squads_169(ScenarioTag ScenarioTag) : base(ScenarioTag, 169)
            {
            }
        }
    }
}