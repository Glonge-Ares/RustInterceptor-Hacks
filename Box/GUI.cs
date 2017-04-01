using System;
using System.Collections.Generic;
using System.Windows.Forms;
using Box.Properties;

namespace Box {
    public partial class GUI: Form {

        internal static List<Waypoint> waypoints = new List<Waypoint>();
        public static List<Waypoint> Waypoints { get { return waypoints; } }
        private Box caler = new Box();

        public GUI() {
            InitializeComponent();
            if(Settings.Default.FirstLoad == true) {
                Settings.Default.Reset();
                Settings.Default.FirstLoad = false;
                Console.WriteLine("RESET SETTINGS");
            } else {
                Settings.Default.Reload();
                Console.WriteLine("Reloaded Settings");
            }
            LoadSettings();
        }

        private void LoadSettings() {

            Server_IP_Text.Text = Settings.Default.Server_IP;
            Server_PORT_Text.Text = Settings.Default.Server_PORT.ToString();         

            Players_Check.Checked = Settings.Default.Player_Check;
            Plants_Check.Checked = Settings.Default.Plants_Check;
            Resources_Check.Checked = Settings.Default.Resources_Check;
            Animals_Check.Checked = Settings.Default.Animals;
            Barrels_Check.Checked = Settings.Default.Barrels;
            Crosshair_Check.Checked = Settings.Default.Crosshair_Check;
            Radar_Check.Checked = Settings.Default.Radar_Check;
            Tracer_Check.Checked = Settings.Default.Tracer_Check;
            Box_Check.Checked = Settings.Default.Box_Check;

            //PLAYERS
            Player_Awake_Radar_Check.Checked = Settings.Default.Player_Awake_Radar_Check;
            Player_Awake_Radar_Color.BackColor = Settings.Default.Player_Awake_Radar_Color;
            Player_Awake_Tracer_Check.Checked = Settings.Default.Player_Awake_Tracer_Check;
            Player_Awake_Tracer_Color.BackColor = Settings.Default.Player_Awake_Tracer_Color;
            Player_Awake_Box_Check.Checked = Settings.Default.Player_Awake_Box_Check;
            Player_Awake_Box_Color.BackColor = Settings.Default.Player_Awake_Box_Color;

            Player_Sleeping_Radar_Check.Checked = Settings.Default.Player_Sleeping_Radar_Check;
            Player_Sleeping_Radar_Color.BackColor = Settings.Default.Player_Sleeping_Radar_Color;
            Player_Sleeping_Tracer_Check.Checked = Settings.Default.Player_Sleeping_Tracer_Check;
            Player_Sleeping_Tracer_Color.BackColor = Settings.Default.Player_Sleeping_Tracer_Color;
            Player_Sleeping_Box_Check.Checked = Settings.Default.Player_Sleeping_Box_Check;
            Player_Sleeping_Box_Color.BackColor = Settings.Default.Player_Sleeping_Box_Color;

            Player_Friend_Radar_Check.Checked = Settings.Default.Player_Friend_Radar_Check;
            Player_Friend_Radar_Color.BackColor = Settings.Default.Player_Friend_Radar_Color;
            Player_Friend_Tracer_Check.Checked = Settings.Default.Player_Friend_Tracer_Check;
            Player_Friend_Tracer_Color.BackColor = Settings.Default.Player_Friend_Tracer_Color;
            Player_Friend_Box_Check.Checked = Settings.Default.Player_Friend_Box_Check;
            Player_Friend_Box_Color.BackColor = Settings.Default.Player_Friend_Box_Color;

            Player_Enemy_Radar_Check.Checked = Settings.Default.Player_Enemy_Radar_Check;
            Player_Enemy_Radar_Color.BackColor = Settings.Default.Player_Enemy_Radar_Color;
            Player_Enemy_Tracer_Check.Checked = Settings.Default.Player_Enemy_Tracer_Check;
            Player_Enemy_Tracer_Color.BackColor = Settings.Default.Player_Enemy_Tracer_Color;
            Player_Enemy_Box_Check.Checked = Settings.Default.Player_Enemy_Box_Check;
            Player_Enemy_Box_Color.BackColor = Settings.Default.Player_Enemy_Box_Color;

            Player_Loot_Corpse_Radar_Check.Checked = Settings.Default.Player_Loot_Corpse_Radar_Check;
            Player_Loot_Corpse_Radar_Color.BackColor = Settings.Default.Player_Loot_Corpse_Radar_Color;
            Player_Loot_Corpse_Tracer_Check.Checked = Settings.Default.Player_Loot_Corpse_Tracer_Check;
            Player_Loot_Corpse_Tracer_Color.BackColor = Settings.Default.Player_Loot_Corpse_Tracer_Color;
            Player_Loot_Corpse_Box_Check.Checked = Settings.Default.Player_Loot_Corpse_Box_Check;
            Player_Loot_Corpse_Box_Color.BackColor = Settings.Default.Player_Loot_Corpse_Box_Color;

            Player_Aiming_Radar_Check.Checked = Settings.Default.Player_Aiming_Radar_Check;
            Player_Aiming_Radar_Color.BackColor = Settings.Default.Player_Aiming_Radar_Color;
            Player_Aiming_Tracer_Check.Checked = Settings.Default.Player_Aiming_Tracer_Check;
            Player_Aiming_Tracer_Color.BackColor = Settings.Default.Player_Aiming_Tracer_Color;
            Player_Aiming_Box_Check.Checked = Settings.Default.Player_Aiming_Box_Check;
            Player_Aiming_Box_Color.BackColor = Settings.Default.Player_Aiming_Box_Color;

            Player_Crouching_Radar_Color.BackColor = Settings.Default.Player_Crouching_Radar_Color;
            Player_Crouching_Radar_Check.Checked = Settings.Default.Player_Crouching_Radar_Check;
            Player_Crouching_Tracer_Color.BackColor = Settings.Default.Player_Crouching_Tracer_Color;
            Player_Crouching_Tracer_Check.Checked = Settings.Default.Player_Crouching_Tracer_Check;
            Player_Crouching_Box_Color.BackColor = Settings.Default.Player_Crouching_Box_Color;
            Player_Crouching_Box_Check.Checked = Settings.Default.Player_Crouching_Box_Check;

            Player_Sprinting_Radar_Check.Checked = Settings.Default.Player_Sprinting_Radar_Check;
            Player_Sprinting_Radar_Color.BackColor = Settings.Default.Player_Sprinting_Radar_Color;
            Player_Sprinting_Tracer_Check.Checked = Settings.Default.Player_Sprinting_Tracer_Check;
            Player_Sprinting_Tracer_Color.BackColor = Settings.Default.Player_Sprinting_Tracer_Color;
            Player_Sprinting_Box_Check.Checked = Settings.Default.Player_Sprinting_Box_Check;
            Player_Sprinting_Box_Color.BackColor = Settings.Default.Player_Sprinting_Box_Color;

            PlayerHeldItem.Checked = Settings.Default.Player_Held_Item_Enable;
            PlayerInventoryWearCheck.Checked = Settings.Default.Player_Inventory_Wear;
            PlayerInventoryBeltCheck.Checked = Settings.Default.Player_Inventory_Belt;

            //ANIMALS
            Animals_Chicken_Radar_Check.Checked = Settings.Default.Animals_Chicken_Radar_Check;
            Animals_Chicken_Radar_Color.BackColor = Settings.Default.Animals_Chicken_Radar_Color;
            Animals_Chicken_Tracer_Check.Checked = Settings.Default.Animals_Chicken_Tracer_Check;
            Animals_Chicken_Tracer_Color.BackColor = Settings.Default.Animals_Chicken_Tracer_Color;
            Animals_Chicken_Box_Check.Checked = Settings.Default.Animals_Chicken_Box_Check;
            Animals_Chicken_Box_Color.BackColor = Settings.Default.Animals_Chicken_Box_Color;

            Animals_Bear_Radar_Check.Checked = Settings.Default.Animals_Horse_Radar_Check;
            Animals_Bear_Radar_Color.BackColor = Settings.Default.Animals_Bear_Radar_Color;
            Animals_Bear_Tracer_Check.Checked = Settings.Default.Animals_Horse_Tracer_Check;
            Animals_Bear_Tracer_Color.BackColor = Settings.Default.Animals_Bear_Tracer_Color;
            Animals_Bear_Box_Check.Checked = Settings.Default.Animals_Horse_Radar_Check;
            Animals_Bear_Box_Color.BackColor = Settings.Default.Animals_Bear_Box_Color;

            Animals_Deer_Radar_Check.Checked = Settings.Default.Animals_Deer_Radar_Check;
            Animals_Deer_Radar_Color.BackColor = Settings.Default.Animals_Deer_Radar_Color;
            Animals_Deer_Tracer_Check.Checked = Settings.Default.Animals_Deer_Tracer_Check;
            Animals_Deer_Tracer_Color.BackColor = Settings.Default.Animals_Deer_Tracer_Color;
            Animals_Deer_Box_Check.Checked = Settings.Default.Animals_Deer_Box_Check;
            Animals_Deer_Box_Color.BackColor = Settings.Default.Animals_Deer_Box_Color;

            Animals_Wolf_Radar_Check.Checked = Settings.Default.Animals_Wolf_Radar_Check;
            Animals_Wolf_Radar_Color.BackColor = Settings.Default.Animals_Wolf_Radar_Color;
            Animals_Wolf_Tracer_Check.Checked = Settings.Default.Animals_Wolf_Tracer_Check;
            Animals_Wolf_Tracer_Color.BackColor = Settings.Default.Animals_Wolf_Tracer_Color;
            Animals_Wolf_Box_Check.Checked = Settings.Default.Animals_Wolf_Box_Check;
            Animals_Wolf_Box_Color.BackColor = Settings.Default.Animals_Wolf_Box_Color;

            Animals_Boar_Radar_Check.Checked = Settings.Default.Animals_Boar_Radar_Check;
            Animals_Boar_Radar_Color.BackColor = Settings.Default.Animals_Boar_Radar_Color;
            Animals_Boar_Tracer_Check.Checked = Settings.Default.Animals_Boar_Tracer_Check;
            Animals_Boar_Tracer_Color.BackColor = Settings.Default.Animals_Boar_Tracer_Color;
            Animals_Boar_Box_Check.Checked = Settings.Default.Animals_Boar_Box_Check;
            Animals_Boar_Box_Color.BackColor = Settings.Default.Animals_Boar_Box_Color;

            Animals_Horse_Radar_Check.Checked = Settings.Default.Animals_Horse_Radar_Check;
            Animals_Horse_Radar_Color.BackColor = Settings.Default.Animals_Horse_Radar_Color;
            Animals_Horse_Tracer_Check.Checked = Settings.Default.Animals_Horse_Tracer_Check;
            Animals_Horse_Tracer_Color.BackColor = Settings.Default.Animals_Horse_Tracer_Color;
            Animals_Horse_Box_Check.Checked = Settings.Default.Animals_Horse_Box_Check;
            Animals_Horse_Box_Color.BackColor = Settings.Default.Animals_Horse_Box_Color;

            //DEPLOYABLES
            Deployable_Quarry_Radar_Check.Checked = Settings.Default.Deployable_Quarry_Radar_Check;
            Deployable_Quarry_Radar_Color.BackColor = Settings.Default.Deployable_Quarry_Radar_Color;
            Deployable_Quarry_Tracer_Check.Checked = Settings.Default.Deployable_Quarry_Tracer_Check;
            Deployable_Quarry_Tracer_Color.BackColor = Settings.Default.Deployable_Quarry_Tracer_Color;
            Deployable_Quarry_Box_Check.Checked = Settings.Default.Deployable_Quarry_Box_Check;
            Deployable_Quarry_Box_Color.BackColor = Settings.Default.Deployable_Quarry_Box_Color;

            Deployable_TC_Radar_Check.Checked = Settings.Default.Deployable_TC_Radar_Check;
            Deployable_TC_Radar_Color.BackColor = Settings.Default.Deployable_TC_Radar_Color;
            Deployable_TC_Tracer_Check.Checked = Settings.Default.Deployable_TC_Tracer_Check;
            Deployable_TC_Tracer_Color.BackColor = Settings.Default.Deployable_TC_Tracer_Color;
            Deployable_TC_Box_Check.Checked = Settings.Default.Deployable_TC_Box_Check;
            Deployable_TC_Box_Color.BackColor = Settings.Default.Deployable_TC_Box_Color;

            Deployable_Sleeping_Bag_Radar_Check.Checked = Settings.Default.Deployable_Sleeping_Bag_Radar_Check;
            Deployable_Sleeping_Bag_Radar_Color.BackColor = Settings.Default.Deployable_Sleeping_Bag_Radar_Color;
            Deployable_Sleeping_Bag_Tracer_Check.Checked = Settings.Default.Deployable_Sleeping_Bag_Tracer_Check;
            Deployable_Sleeping_Bag_Tracer_Color.BackColor = Settings.Default.Deployable_Sleeping_Bag_Tracer_Color;
            Deployable_Sleeping_Bag_Box_Check.Checked = Settings.Default.Deployable_Sleeping_Bag_Box_Check;
            Deployable_Sleeping_Bag_Box_Color.BackColor = Settings.Default.Deployable_Sleeping_Bag_Box_Color;

            Deployable_AutoTurret_Radar_Check.Checked = Settings.Default.Deployable_AutoTurret_Radar_Check;
            Deployable_AutoTurret_Radar_Color.BackColor = Settings.Default.Deployable_AutoTurret_Radar_Color;
            Deployable_AutoTurret_Tracer_Check.Checked = Settings.Default.Deployable_AutoTurret_Tracer_Check;
            Deployable_AutoTurret_Tracer_Color.BackColor = Settings.Default.Deployable_AutoTurret_Tracer_Color;
            Deployable_AutoTurret_Box_Check.Checked = Settings.Default.Deployable_AutoTurret_Box_Check;
            Deployable_AutoTurret_Box_Color.BackColor = Settings.Default.Deployable_AutoTurret_Box_Color;

            Deployable_Furnace_Radar_Check.Checked = Settings.Default.Deployable_Furnace_Radar_heck;
            Deployable_Furnace_Radar_Color.BackColor = Settings.Default.Deployable_Furnace_Radar_Color;
            Deployable_Furnace_Tracer_Check.Checked = Settings.Default.Deployable_Furnace_Tracer_Check;
            Deployable_Furnace_Tracer_Color.BackColor = Settings.Default.Deployable_Furnace_Tracer_Color;
            Deployable_Furnace_Box_Check.Checked = Settings.Default.Deployable_Furnace_Box_Check;
            Deployable_Furnace_Box_Color.BackColor = Settings.Default.Deployable_Furnace_Box_Color;

            Deployable_Large_Furnace_Radar_Check.Checked = Settings.Default.Deployable_Large_Furnace_Radar_Check;
            Deployable_Large_Furnace_Radar_Color.BackColor = Settings.Default.Deployable_Large_Furnace_Radar_Color;
            Deployable_Large_Furnace_Tracer_Check.Checked = Settings.Default.Deployable_Large_Furnace_Tracer_Check;
            Deployable_Large_Furnace_Tracer_Color.BackColor = Settings.Default.Deployable_Large_Furnace_Tracer_Color;
            Deployable_Large_Furnace_Box_Check.Checked = Settings.Default.Deployable_Large_Furnace_Box_Check;
            Deployable_Large_Furnace_Box_Color.BackColor = Settings.Default.Deployable_Large_Furnace_Box_Color;

            Deployable_Landmine_Radar_Check.Checked = Settings.Default.Deployable_Landmine_Radar_Check;
            Deployable_Landmine_Radar_Color.BackColor = Settings.Default.Deployable_Landmine_Radar_Color;
            Deployable_Landmine_Tracer_Check.Checked = Settings.Default.Deployable_Landmine_Tracer_Check;
            Deployable_Landmine_Tracer_Color.BackColor = Settings.Default.Deployable_Landmine_Tracer_Color;
            Deployable_Landmine_Box_Check.Checked = Settings.Default.Deployable_Landmine_Box_Check;
            Deployable_Landmine_Box_Color.BackColor = Settings.Default.Deployable_Landmine_Box_Color;

            Deployable_Bear_Trap_Radar_Check.Checked = Settings.Default.Deployable_Bear_Trap_Radar_Check;
            Deployable_Bear_Trap_Radar_Color.BackColor = Settings.Default.Deployable_Bear_Trap_Radar_Color;
            Deployable_Bear_Trap_Tracer_Check.Checked = Settings.Default.Deployable_Bear_Trap_Tracer_Check;
            Deployable_Bear_Trap_Tracer_Color.BackColor = Settings.Default.Deployable_Bear_Trap_Tracer_Color;
            Deployable_Bear_Trap_Box_Check.Checked = Settings.Default.Deployable_Bear_Trap_Box_Check;
            Deployable_Bear_Trap_Box_Color.BackColor = Settings.Default.Deployable_Bear_Trap_Box_Color;

            Deployable_Fridge_Radar_Check.Checked = Settings.Default.Deployable_Fridge_Radar_Check;
            Deployable_Fridge_Radar_Color.BackColor = Settings.Default.Deployable_Fridge_Radar_Color;
            Deployable_Fridge_Tracer_Check.Checked = Settings.Default.Deployable_Fridge_Tracer_Check;
            Deployable_Fridge_Tracer_Color.BackColor = Settings.Default.Deployable_Fridge_Tracer_Color;
            Deployable_Fridge_Box_Check.Checked = Settings.Default.Deployable_Fridge_Box_Check;
            Deployable_Fridge_Box_Color.BackColor = Settings.Default.Deployable_Fridge_Box_Color;

            Deployable_Stash_Radar_Check.Checked = Settings.Default.Deployable_Stash_Radar_Check;
            Deployable_Stash_Radar_Color.BackColor = Settings.Default.Deployable_Stash_Radar_Color;
            Deployable_Stash_Tracer_Check.Checked = Settings.Default.Deployable_Stash_Tracer_Check;
            Deployable_Stash_Tracer_Color.BackColor = Settings.Default.Deployable_Stash_Tracer_Color;
            Deployable_Stash_Box_Check.Checked = Settings.Default.Deployable_Stash_Box_Check;
            Deployable_Stash_Box_Color.BackColor = Settings.Default.Deployable_Stash_Box_Color;

            Deployable_Oil_Radar_Checked.Checked = Settings.Default.Deployable_Oil_Radar_Check;
            Deployable_Oil_Radar_Color.BackColor = Settings.Default.Deployable_Oil_Radar_Color;
            Deployable_Oil_Tracer_Check.Checked = Settings.Default.Deployable_Oil_Tracer_Check;
            Deployable_Oil_Tracer_Color.BackColor = Settings.Default.Deployable_Oil_Tracer_Color;
            Deployable_Oil_Box_Check.Checked = Settings.Default.Deployable_Oil_Box_Check;
            Deployable_Oil_Box_Color.BackColor = Settings.Default.Deployable_Oil_Box_Color;

            Deployable_Box_Radar_Check.Checked = Settings.Default.Deployable_Box_Radar_Check;
            Deployable_Box_Radar_Color.BackColor = Settings.Default.Deployable_Box_Radar_Color;
            Deployable_Box_Tracer_Check.Checked = Settings.Default.Deployable_Box_Tracer_Check;
            Deployable_Box_Tracer_Color.BackColor = Settings.Default.Deployable_Box_Tracer_Color;
            Deployable_Box_Box_Check.Checked = Settings.Default.Deployable_Box_Box_Check;
            Deployable_Box_Box_Color.BackColor = Settings.Default.Deployable_Box_Box_Color;

            Deployable_Large_Box_Radar_Check.Checked = Settings.Default.Deployable_Large_Box_Radar_Check;
            Deployable_Large_Box_Radar_Color.BackColor = Settings.Default.Deployable_Large_Box_Radar_Color;
            Deployable_Large_Box_Tracer_Check.Checked = Settings.Default.Deployable_Large_Box_Tracer_Check;
            Deployable_Large_Box_Tracer_Color.BackColor = Settings.Default.Deployable_Large_Box_Tracer_Color;
            Deployable_Large_Box_Box_Check.Checked = Settings.Default.Deployable_Large_Box_Box_Check;
            Deployable_Large_Box_Box_Color.BackColor = Settings.Default.Deployable_Large_Box_Box_Color;

            //PLANTS
            Plant_Mushroom_Radar_Check.Checked = Settings.Default.Plant_Mushroom_Radar_Check;
            Plant_Mushroom_Radar_Color.BackColor = Settings.Default.Plant_Mushroom_Radar_Color;
            Plant_Mushroom_Tracer_Check.Checked = Settings.Default.Plant_Mushroom_Tracer_Check;
            Plant_Mushroom_Tracer_Color.BackColor = Settings.Default.Plant_Mushroom_Tracer_Color;
            Plant_Mushroom_Box_Check.Checked = Settings.Default.Plant_Mushroom_Box_Check;
            Plant_Mushroom_Box_Color.BackColor = Settings.Default.Plant_Mushroom_Box_Color;

            Plant_Hemp_Radar_Check.Checked = Settings.Default.Plant_Hemp_Radar_Check;
            Plant_Hemp_Radar_Color.BackColor = Settings.Default.Plant_Hemp_Radar_Color;
            Plant_Hemp_Tracer_Check.Checked = Settings.Default.Plant_Hemp_Tracer_Check;
            Plant_Hemp_Tracer_Color.BackColor = Settings.Default.Plant_Hemp_Tracer_Color;
            Plant_Hemp_Box_Check.Checked = Settings.Default.Plant_Hemp_Box_Check;
            Plant_Hemp_Box_Color.BackColor = Settings.Default.Plant_Hemp_Box_Color;

            Plant_Pumpkin_Radar_Check.Checked = Settings.Default.Plant_Pumpkin_Radar_Check;
            Plant_Pumpkin_Radar_Color.BackColor = Settings.Default.Plant_Pumpkin_Radar_Color;
            Plant_Pumpkin_Tracer_Check.Checked = Settings.Default.Plant_Pumpkin_Tracer_Check;
            Plant_Pumpkin_Tracer_Color.BackColor = Settings.Default.Plant_Pumpkin_Tracer_Color;
            Plant_Pumpkin_Box_Check.Checked = Settings.Default.Plant_Pumpkin_Box_Check;
            Plant_Pumpkin_Box_Color.BackColor = Settings.Default.Plant_Pumpkin_Box_Color;

            Plant_Corn_Radar_Check.Checked = Settings.Default.Plant_Corn_Radar_Check;
            Plant_Corn_Radar_Color.BackColor = Settings.Default.Plant_Corn_Radar_Color;
            Plant_Corn_Tracer_Check.Checked = Settings.Default.Plant_Corn_Tracer_Check;
            Plant_Corn_Tracer_Color.BackColor = Settings.Default.Plant_Corn_Tracer_Color;
            Plant_Corn_Box_Check.Checked = Settings.Default.Plant_Corn_Box_Check;
            Plant_Corn_Box_Color.BackColor = Settings.Default.Plant_Corn_Box_Color;

            //RESOURCES
            Resource_Rock_Collectable_Radar_Check.Checked = Settings.Default.Resource_Rock_Radar_Check;
            Resource_Rock_Collectable_Radar_Color.BackColor = Settings.Default.Resource_Rock_Radar_Color;
            Resource_Rock_Collectable_Tracer_Check.Checked = Settings.Default.Resource_Rock_Collectable_Tracer_Check;
            Resource_Rock_Collectable_Tracer_Color.BackColor = Settings.Default.Resource_Rock_Collectable_Tracer_Color;
            Resource_Rock_Collectable_Box_Check.Checked = Settings.Default.Resource_Rock_Collectable_Box_Check;
            Resource_Rock_Collectable_Box_Color.BackColor = Settings.Default.Resource_Rock_Collectable_Box_Color;

            Resource_Wood_Collectable_Radar_Check.Checked = Settings.Default.Resource_Wood_Radar_Check;
            Resource_Wood_Collectable_Radar_Color.BackColor = Settings.Default.Resource_Wood_Radar_Color;
            Resource_Wood_Collectable_Tracer_Check.Checked = Settings.Default.Resource_Wood_Collectable_Tracer_Check;
            Resource_Wood_Collectable_Tracer_Color.BackColor = Settings.Default.Resource_Wood_Collectable_Tracer_Color;
            Resource_Wood_Collectable_Box_Check.Checked = Settings.Default.Resource_Wood_Collectable_Box_Check;
            Resource_Wood_Collectable_Box_Color.BackColor = Settings.Default.Resource_Wood_Collectable_Box_Color;

            Resource_Sulfur_Collectable_Radar_Check.Checked = Settings.Default.Resource_Sulfur_Ore_Radar_Check;
            Resource_Sulfur_Collectable_Radar_Color.BackColor = Settings.Default.Resource_Sulfur_Ore_Radar_Color;
            Resource_Sulfur_Collectable_Tracer_Check.Checked = Settings.Default.Resource_Sulfur_Collectable_Tracer_Check;
            Resource_Sulfur_Collectable_Tracer_Color.BackColor = Settings.Default.Resource_Sulfur_Collectable_Tracer_Color;
            Resource_Sulfur_Collectable_Box_Check.Checked = Settings.Default.Resource_Sulfur_Collectable_Box_Check;
            Resource_Sulfur_Collectable_Box_Color.BackColor = Settings.Default.Resource_Sulfur_Collectable_Box_Color;

            Resource_Metal_Collectable_Radar_Check.Checked = Settings.Default.Resource_Metal_Ore_Radar_Check;
            Resource_Metal_Collectable_Radar_Color.BackColor = Settings.Default.Resource_Metal_Ore_Radar_Color;
            Resource_Metal_Collectable_Tracer_Check.Checked = Settings.Default.Resource_Metal_Collectable_Tracer_Check;
            Resource_Metal_Collectable_Tracer_Color.BackColor = Settings.Default.Resource_Metal_Collectable_Tracer_Color;
            Resource_Metal_Collectable_Box_Check.Checked = Settings.Default.Resource_Metal_Collectable_Box_Check;
            Resource_Metal_Collectable_Box_Color.BackColor = Settings.Default.Resource_Metal_Collectable_Box_Color;

            Resource_Sulfur_Node_Radar_Check.Checked = Settings.Default.Resource_Sulfur_Node_Radar_Check;
            Resource_Sulfur_Node_Radar_Color.BackColor = Settings.Default.Resource_Sulfur_Node_Radar_Color;
            Resource_Sulfur_Node_Tracer_Check.Checked = Settings.Default.Resource_Sulfur_Node_Tracer_Check;
            Resource_Sulfur_Node_Tracer_Color.BackColor = Settings.Default.Resource_Sulfur_Node_Tracer_Color;
            Resource_Sulfur_Node_Box_Check.Checked = Settings.Default.Resource_Sulfur_Node_Box_Check;
            Resource_Sulfur_Node_Box_Color.BackColor = Settings.Default.Resource_Sulfur_Node_Box_Color;

            Resource_Metal_Node_Radar_Check.Checked = Settings.Default.Resource_Metal_Node_Radar_Check;
            Resource_Metal_Node_Radar_Color.BackColor = Settings.Default.Resource_Metal_Node_Radar_Color;
            Resource_Metal_Node_Tracer_Check.Checked = Settings.Default.Resource_Metal_Node_Tracer_Check;
            Resource_Metal_Node_Tracer_Color.BackColor = Settings.Default.Resource_Metal_Node_Tracer_Color;
            Resource_Metal_Node_Box_Check.Checked = Settings.Default.Resource_Metal_Node_Box_Check;
            Resource_Metal_Node_Box_Color.BackColor = Settings.Default.Resource_Metal_Node_Box_Color;

            Resource_Stone_Node_Radar_Check.Checked = Settings.Default.Resource_Stone_Node_Radar_Check;
            Resource_Stone_Node_Radar_Color.BackColor = Settings.Default.Resource_Stone_Node_Radar_Color;
            Resource_Stone_Node_Tracer_Check.Checked = Settings.Default.Resource_Stone_Node_Tracer_Check;
            Resource_Stone_Node_Tracer_Color.BackColor = Settings.Default.Resource_Stone_Node_Tracer_Color;
            Resource_Stone_Node_Box_Check.Checked = Settings.Default.Resource_Stone_Node_Box_Check;
            Resource_Stone_Node_Box_Color.BackColor = Settings.Default.Resource_Stone_Node_Box_Color;

            //BARRELS
            Barrel_Loot_Barrel_Radar_Check.Checked = Settings.Default.Barrel_Loot_Barrel_Radar_Check;
            Barrel_Loot_Barrel_Radar_Color.BackColor = Settings.Default.Barrel_Loot_Barrel_Radar_Color;
            Barrel_Loot_Barrel_Tracer_Check.Checked = Settings.Default.Barrel_Loot_Barrel_Tracer_Check;
            Barrel_Loot_Barrel_Tracer_Color.BackColor = Settings.Default.Barrel_Loot_Barrel_Tracer_Color;
            Barrel_Loot_Barrel_Box_Check.Checked = Settings.Default.Barrel_Loot_Barrel_Box_Check;
            Barrel_Loot_Barrel_Box_Color.BackColor = Settings.Default.Barrel_Loot_Barrel_Box_Color;

            Barrel_Oil_Barrel_Radar_Check.Checked = Settings.Default.Barrel_Oil_Barrel_Radar_Check;
            Barrel_Oil_Barrel_Radar_Color.BackColor = Settings.Default.Barrel_Oil_Barrel_Radar_Color;
            Barrel_Oil_Barrel_Tracer_Check.Checked = Settings.Default.Barrel_Oil_Barrel_Tracer_Check;
            Barrel_Oil_Barrel_Tracer_Color.BackColor = Settings.Default.Barrel_Oil_Barrel_Tracer_Color;
            Barrel_Oil_Barrel_Box_Check.Checked = Settings.Default.Barrel_Oil_Barrel_Box_Check;
            Barrel_Oil_Barrel_Box_Color.BackColor = Settings.Default.Barrel_Oil_Barrel_Box_Color;

            Barrel_Trash_Pile_Radar_Check.Checked = Settings.Default.Barrel_Trash_Pile_Radar_Check;
            Barrel_Trash_Pile_Radar_Color.BackColor = Settings.Default.Barrel_Trash_Pile_Radar_Color;
            Barrel_Trash_Pile_Tracer_Check.Checked = Settings.Default.Barrel_Trash_Pile_Tracer_Check;
            Barrel_Trash_Pile_Tracer_Color.BackColor = Settings.Default.Barrel_Trash_Pile_Tracer_Color;
            Barrel_Trash_Pile_Box_Check.Checked = Settings.Default.Barrel_Trash_Pile_Box_Check;
            Barrel_Trash_Pile_Box_Color.BackColor = Settings.Default.Barrel_Trash_Pile_Box_Color;

            Barrel_Crate_Radar_Check.Checked = Settings.Default.Barrel_Crate_Radar_Check;
            Barrel_Crate_Radar_Color.BackColor = Settings.Default.Barrel_Crate_Radar_Color;
            Barrel_Crate_Tracer_Check.Checked = Settings.Default.Barrel_Crate_Tracer_Check;
            Barrel_Crate_Tracer_Color.BackColor = Settings.Default.Barrel_Crate_Tracer_Color;
            Barrel_Crate_Box_Check.Checked = Settings.Default.Barrel_Crate_Box_Check;
            Barrel_Crate_Box_Color.BackColor = Settings.Default.Barrel_Crate_Box_Color;

            Barrel_Mine_Crate_Radar_Check.Checked = Settings.Default.Barrel_Mine_Crate_Radar_Check;
            Barrel_Mine_Crate_Radar_Color.BackColor = Settings.Default.Barrel_Mine_Crate_Radar_Color;
            Barrel_Mine_Crate_Tracer_Check.Checked = Settings.Default.Barrel_Mine_Crate_Tracer_Check;
            Barrel_Mine_Crate_Tracer_Color.BackColor = Settings.Default.Barrel_Mine_Crate_Tracer_Color;
            Barrel_Mine_Crate_Box_Check.Checked = Settings.Default.Barrel_Mine_Crate_Box_Check;
            Barrel_Mine_Crate_Box_Color.BackColor = Settings.Default.Barrel_Mine_Crate_Box_Color;

            Barrel_Food_Crate_Radar_Check.Checked = Settings.Default.Barrel_Food_Crate_Radar_Check;
            Barrel_Food_Crate_Radar_Color.BackColor = Settings.Default.Barrel_Food_Crate_Radar_Color;
            Barrel_Food_Crate_Tracer_Check.Checked = Settings.Default.Barrel_Food_Crate_Tracer_Check;
            Barrel_Food_Crate_Tracer_Color.BackColor = Settings.Default.Barrel_Food_Crate_Tracer_Color;
            Barrel_Food_Crate_Box_Check.Checked = Settings.Default.Barrel_Food_Crate_Box_Check;
            Barrel_Food_Crate_Box_Color.BackColor = Settings.Default.Barrel_Food_Crate_Box_Color;

            Barrel_Med_Crate_Radar_Check.Checked = Settings.Default.Barrel_Med_Crate_Radar_Check;
            Barrel_Med_Crate_Radar_Color.BackColor = Settings.Default.Barrel_Med_Crate_Radar_Color;
            Barrel_Med_Crate_Tracer_Check.Checked = Settings.Default.Barrel_Med_Crate_Tracer_Check;
            Barrel_Med_Crate_Tracer_Color.BackColor = Settings.Default.Barrel_Med_Crate_Tracer_Color;
            Barrel_Med_Crate_Box_Check.Checked = Settings.Default.Barrel_Med_Crate_Box_Check;
            Barrel_Med_Crate_Box_Color.BackColor = Settings.Default.Barrel_Med_Crate_Box_Color;

            Barrel_Tool_Crate_Radar_Check.Checked = Settings.Default.Barrel_Tool_Crate_Radar_Check;
            Barrel_Tool_Crate_Radar_Color.BackColor = Settings.Default.Barrel_Tool_Crate_Radar_Color;
            Barrel_Tool_Crate_Tracer_Check.Checked = Settings.Default.Barrel_Tool_Crate_Tracer_Check;
            Barrel_Tool_Crate_Tracer_Color.BackColor = Settings.Default.Barrel_Tool_Crate_Tracer_Color;
            Barrel_Tool_Crate_Box_Check.Checked = Settings.Default.Barrel_Tool_Crate_Box_Check;
            Barrel_Tool_Crate_Box_Color.BackColor = Settings.Default.Barrel_Tool_Crate_Box_Color;

            Barrel_Food_Box_Radar_Check.Checked = Settings.Default.Barrel_Food_Box_Radar_Check;
            Barrel_Food_Box_Radar_Color.BackColor = Settings.Default.Barrel_Food_Box_Radar_Color;
            Barrel_Food_Box_Tracer_Check.Checked = Settings.Default.Barrel_Food_Box_Tracer_Check;
            Barrel_Food_Box_Tracer_Color.BackColor = Settings.Default.Barrel_Food_Box_Tracer_Color;
            Barrel_Food_Box_Box_Check.Checked = Settings.Default.Barrel_Food_Box_Box_Check;
            Barrel_Food_Box_Box_Color.BackColor = Settings.Default.Barrel_Food_Box_Box_Color;

            //MISC
            Misc_Supply_Drop_Radar_Check.Checked = Settings.Default.Misc_Supply_Drop_Radar_Check;
            Misc_Supply_Drop_Radar_Color.BackColor = Settings.Default.Misc_Supply_Drop_Radar_Color;
            Misc_Supply_Drop_Tracer_Check.Checked = Settings.Default.Misc_Supply_Drop_Tracer_Check;
            Misc_Supply_Drop_Tracer_Color.BackColor = Settings.Default.Misc_Supply_Drop_Tracer_Color;
            Misc_Supply_Drop_Box_Check.Checked = Settings.Default.Misc_Supply_Drop_Box_Check;
            Misc_Supply_Drop_Box_Color.BackColor = Settings.Default.Misc_Supply_Drop_Box_Color;

            Misc_Corpse_Radar_Check.Checked = Settings.Default.Misc_Corpse_Radar_Check;
            Misc_Corpse_Radar_Color.BackColor = Settings.Default.Misc_Corpse_Radar_Color;
            Misc_Corpse_Tracer_Check.Checked = Settings.Default.Misc_Corpse_Tracer_Check;
            Misc_Corpse_Tracer_Color.BackColor = Settings.Default.Misc_Corpse_Tracer_Color;
            Misc_Corpse_Box_Check.Checked = Settings.Default.Misc_Corpse_Box_Check;
            Misc_Corpse_Box_Color.BackColor = Settings.Default.Misc_Corpse_Box_Color;

            Misc_Helicopter_Radar_Check.Checked = Settings.Default.Misc_Helicopter_Radar_Check;
            Misc_Helicopter_Radar_Color.BackColor = Settings.Default.Misc_Helicopter_Radar_Color;
            Misc_Helicopter_Tracer_Check.Checked = Settings.Default.Misc_Helicopter_Tracer_Check;
            Misc_Helicopter_Tracer_Color.BackColor = Settings.Default.Misc_Helicopter_Tracer_Color;
            Misc_Helicopter_Box_Check.Checked = Settings.Default.Misc_Helicopter_Box_Check;
            Misc_Helicopter_Box_Color.BackColor = Settings.Default.Misc_Helicopter_Box_Color;

            //CROSSHAIR
            Crosshair_Color.BackColor = Settings.Default.Crosshair_Color;
            Crosshair_Size_Text.Text = Settings.Default.Crosshair_Size.ToString();
            Crosshair_Thick_Text.Text = Settings.Default.Crosshair_Thick.ToString();
            Type_Box.SelectedIndex = Settings.Default.Crosshair_Type;


            Temp_Text_Box.Text = Settings.Default.Temp.ToString();
            textBox1.Text = Settings.Default.Temp1.ToString();
            FOV_Text_Box.Text = Settings.Default.FOV.ToString();

            ZoomTrackBar.Value = Settings.Default.Radar_Zoom;
            if (Settings.Default.Waypoints != null) {
                foreach (var e in Settings.Default.Waypoints) {
                    string[] w = e.Split(',');
                    lock (waypoints) {
                        waypoints.Add(new Waypoint(int.Parse(w[0]), int.Parse(w[1]), int.Parse(w[2]), w[3], System.Drawing.Color.FromArgb(int.Parse(w[4]))));
                    }
                }
            }
        }

        private void Awake_Color_Click(object sender, EventArgs e) {
            if (Color_Picker.ShowDialog() == DialogResult.OK) {
                Player_Awake_Radar_Color.BackColor = Color_Picker.Color;
                Settings.Default.Player_Awake_Radar_Color = Color_Picker.Color;
            }
        }

        private void Sleeping_Color_Click(object sender, EventArgs e) {
            if (Color_Picker.ShowDialog() == DialogResult.OK) {
                Player_Sleeping_Radar_Color.BackColor = Color_Picker.Color;
                Settings.Default.Player_Sleeping_Radar_Color = Color_Picker.Color;
            }
        }

        private void Friends_Color_Click(object sender, EventArgs e) {
            if (Color_Picker.ShowDialog() == DialogResult.OK) {
                Player_Friend_Radar_Color.BackColor = Color_Picker.Color;
                Settings.Default.Player_Friend_Radar_Color = Color_Picker.Color;
            }
        }

        private void Enemy_Color_Click(object sender, EventArgs e) {
            if (Color_Picker.ShowDialog() == DialogResult.OK) {
                Player_Enemy_Radar_Color.BackColor = Color_Picker.Color;
                Settings.Default.Player_Enemy_Radar_Color = Color_Picker.Color;
            }
        }

        private void Loot_Corpse_Color_Click(object sender, EventArgs e) {
            if (Color_Picker.ShowDialog() == DialogResult.OK) {
                Player_Loot_Corpse_Radar_Color.BackColor = Color_Picker.Color;
                Settings.Default.Player_Loot_Corpse_Radar_Color = Color_Picker.Color;
            }
        }

        private void Corpse_Color_Click(object sender, EventArgs e) {
            if (Color_Picker.ShowDialog() == DialogResult.OK) {
                Misc_Corpse_Radar_Color.BackColor = Color_Picker.Color;
                Settings.Default.Misc_Corpse_Radar_Color = Color_Picker.Color;
            }
        }

        /* ANIMALS */
        private void Chicken_Color_Click(object sender, EventArgs e) {
            if (Color_Picker.ShowDialog() == DialogResult.OK) {
                Animals_Chicken_Radar_Color.BackColor = Color_Picker.Color;
                Settings.Default.Animals_Chicken_Radar_Color = Color_Picker.Color;
            }
        }

        private void Bear_Color_Click(object sender, EventArgs e) {
            if (Color_Picker.ShowDialog() == DialogResult.OK) {
                Animals_Bear_Radar_Color.BackColor = Color_Picker.Color;
                Settings.Default.Animals_Bear_Radar_Color = Color_Picker.Color;
            }
        }

        private void Deer_Color_Click(object sender, EventArgs e) {
            if (Color_Picker.ShowDialog() == DialogResult.OK) {
                Animals_Deer_Radar_Color.BackColor = Color_Picker.Color;
                Settings.Default.Animals_Deer_Radar_Color = Color_Picker.Color;
            }
        }

        private void Wolf_Color_Click(object sender, EventArgs e) {
            if (Color_Picker.ShowDialog() == DialogResult.OK) {
                Animals_Wolf_Radar_Color.BackColor = Color_Picker.Color;
                Settings.Default.Animals_Wolf_Radar_Color = Color_Picker.Color;
            }
        }

        private void Boar_Color_Click(object sender, EventArgs e) {
            if (Color_Picker.ShowDialog() == DialogResult.OK) {
                Animals_Boar_Radar_Color.BackColor = Color_Picker.Color;
                Settings.Default.Animals_Boar_Radar_Color = Color_Picker.Color;
            }
        }

        private void Horse_Color_Click(object sender, EventArgs e) {
            if (Color_Picker.ShowDialog() == DialogResult.OK) {
                Animals_Horse_Radar_Color.BackColor = Color_Picker.Color;
                Settings.Default.Animals_Horse_Radar_Color = Color_Picker.Color;
            }
        }

        /* DEPLOYABLES */

        private void Quarry_Color_Click(object sender, EventArgs e) {
            if (Color_Picker.ShowDialog() == DialogResult.OK) {
                Deployable_Quarry_Radar_Color.BackColor = Color_Picker.Color;
                Settings.Default.Deployable_Quarry_Radar_Color = Color_Picker.Color;
            }
        }

        private void Tool_Cupboard_Color_Click(object sender, EventArgs e) {
            if (Color_Picker.ShowDialog() == DialogResult.OK) {
                Deployable_TC_Radar_Color.BackColor = Color_Picker.Color;
                Settings.Default.Deployable_TC_Radar_Color = Color_Picker.Color;
            }
        }

        private void Sleeping_Bag_Color_Click(object sender, EventArgs e) {
            if (Color_Picker.ShowDialog() == DialogResult.OK) {
                Deployable_Sleeping_Bag_Radar_Color.BackColor = Color_Picker.Color;
                Settings.Default.Animals_Deer_Radar_Color = Color_Picker.Color;
            }
        }

        private void AutoTurret_Color_Click(object sender, EventArgs e) {
            if (Color_Picker.ShowDialog() == DialogResult.OK) {
                Deployable_AutoTurret_Radar_Color.BackColor = Color_Picker.Color;
                Settings.Default.Deployable_AutoTurret_Radar_Color = Color_Picker.Color;
            }
        }

        private void Furnace_Color_Click(object sender, EventArgs e) {
            if (Color_Picker.ShowDialog() == DialogResult.OK) {
                Deployable_Furnace_Radar_Color.BackColor = Color_Picker.Color;
                Settings.Default.Deployable_Furnace_Radar_Color = Color_Picker.Color;
            }
        }

        private void Large_Furnace_Color_Click(object sender, EventArgs e) {
            if (Color_Picker.ShowDialog() == DialogResult.OK) {
                Deployable_Large_Furnace_Radar_Color.BackColor = Color_Picker.Color;
                Settings.Default.Deployable_Large_Furnace_Radar_Color = Color_Picker.Color;
            }
        }

        private void Landmine_Color_Click(object sender, EventArgs e) {
            if (Color_Picker.ShowDialog() == DialogResult.OK) {
                Deployable_Landmine_Radar_Color.BackColor = Color_Picker.Color;
                Settings.Default.Deployable_Landmine_Radar_Color = Color_Picker.Color;
            }
        }

        private void Bear_Trap_Color_Click(object sender, EventArgs e) {
            if (Color_Picker.ShowDialog() == DialogResult.OK) {
                Deployable_Bear_Trap_Radar_Color.BackColor = Color_Picker.Color;
                Settings.Default.Deployable_Bear_Trap_Radar_Color = Color_Picker.Color;
            }
        }

        private void Mushroom_Color_Click(object sender, EventArgs e) {
            if (Color_Picker.ShowDialog() == DialogResult.OK) {
                Plant_Mushroom_Radar_Color.BackColor = Color_Picker.Color;
                Settings.Default.Plant_Mushroom_Radar_Color = Color_Picker.Color;
            }
        }

        private void Hemp_Color_Click(object sender, EventArgs e) {
            if (Color_Picker.ShowDialog() == DialogResult.OK) {
                Plant_Hemp_Radar_Color.BackColor = Color_Picker.Color;
                Settings.Default.Plant_Hemp_Radar_Color = Color_Picker.Color;
            }
        }

        private void Pumpkin_Color_Click(object sender, EventArgs e) {
            if (Color_Picker.ShowDialog() == DialogResult.OK) {
                Plant_Pumpkin_Radar_Color.BackColor = Color_Picker.Color;
                Settings.Default.Plant_Pumpkin_Radar_Color = Color_Picker.Color;
            }
        }

        private void Corn_Color_Click(object sender, EventArgs e) {
            if (Color_Picker.ShowDialog() == DialogResult.OK) {
                Plant_Corn_Radar_Color.BackColor = Color_Picker.Color;
                Settings.Default.Plant_Corn_Radar_Color = Color_Picker.Color;
            }
        }

        private void Rock_Color_Click(object sender, EventArgs e) {
            if (Color_Picker.ShowDialog() == DialogResult.OK) {
                Resource_Rock_Collectable_Radar_Color.BackColor = Color_Picker.Color;
                Settings.Default.Resource_Rock_Radar_Color = Color_Picker.Color;
            }
        }

        private void Wood_Color_Click(object sender, EventArgs e) {
            if (Color_Picker.ShowDialog() == DialogResult.OK) {
                Resource_Wood_Collectable_Radar_Color.BackColor = Color_Picker.Color;
                Settings.Default.Resource_Wood_Radar_Color = Color_Picker.Color;
            }
        }

        private void Sulfur_Ore_Color_Click(object sender, EventArgs e) {
            if (Color_Picker.ShowDialog() == DialogResult.OK) {
                Resource_Sulfur_Collectable_Radar_Color.BackColor = Color_Picker.Color;
                Settings.Default.Resource_Sulfur_Ore_Radar_Color = Color_Picker.Color;
            }
        }

        private void Metal_Ore_Color_Click(object sender, EventArgs e) {
            if (Color_Picker.ShowDialog() == DialogResult.OK) {
                Resource_Metal_Collectable_Radar_Color.BackColor = Color_Picker.Color;
                Settings.Default.Resource_Metal_Ore_Radar_Color = Color_Picker.Color;
            }
        }

        private void Sulfur_Node_Color_Click(object sender, EventArgs e) {
            if (Color_Picker.ShowDialog() == DialogResult.OK) {
                Resource_Sulfur_Node_Radar_Color.BackColor = Color_Picker.Color;
                Settings.Default.Resource_Sulfur_Node_Radar_Color = Color_Picker.Color;
            }
        }

        private void Metal_Node_Color_Click(object sender, EventArgs e) {
            if (Color_Picker.ShowDialog() == DialogResult.OK) {
                Resource_Metal_Node_Radar_Color.BackColor = Color_Picker.Color;
                Settings.Default.Resource_Metal_Node_Radar_Color = Color_Picker.Color;
            }
        }

        private void Stone_Node_Color_Click(object sender, EventArgs e) {
            if (Color_Picker.ShowDialog() == DialogResult.OK) {
                Resource_Stone_Node_Radar_Color.BackColor = Color_Picker.Color;
                Settings.Default.Resource_Stone_Node_Radar_Color = Color_Picker.Color;
            }
        }

        private void Oil_Color_Click(object sender, EventArgs e) {
            if (Color_Picker.ShowDialog() == DialogResult.OK) {
                Deployable_Oil_Radar_Color.BackColor = Color_Picker.Color;
                Settings.Default.Deployable_Oil_Radar_Color = Color_Picker.Color;
            }
        }

        private void Stash_Color_Click(object sender, EventArgs e) {
            if (Color_Picker.ShowDialog() == DialogResult.OK) {
                Deployable_Stash_Radar_Color.BackColor = Color_Picker.Color;
                Settings.Default.Deployable_Stash_Radar_Color = Color_Picker.Color;
            }
        }

        private void Fridge_Color_Click(object sender, EventArgs e) {
            if (Color_Picker.ShowDialog() == DialogResult.OK) {
                Deployable_Fridge_Radar_Color.BackColor = Color_Picker.Color;
                Settings.Default.Deployable_Fridge_Radar_Color = Color_Picker.Color;
            }
        }

        private void Box_Color_Click(object sender, EventArgs e) {
            if (Color_Picker.ShowDialog() == DialogResult.OK) {
                Deployable_Box_Radar_Color.BackColor = Color_Picker.Color;
                Settings.Default.Deployable_Box_Radar_Color = Color_Picker.Color;
            }
        }

        private void Large_Box_Color_Click(object sender, EventArgs e) {
            if (Color_Picker.ShowDialog() == DialogResult.OK) {
                Deployable_Large_Box_Radar_Color.BackColor = Color_Picker.Color;
                Settings.Default.Deployable_Large_Box_Radar_Color = Color_Picker.Color;
            }
        }

        private void Barrel_Loot_Barrel_Color_Click(object sender, EventArgs e) {
            if (Color_Picker.ShowDialog() == DialogResult.OK) {
                Barrel_Loot_Barrel_Radar_Color.BackColor = Color_Picker.Color;
                Settings.Default.Barrel_Loot_Barrel_Radar_Color = Color_Picker.Color;
            }
        }

        private void Barrel_Oil_Barrel_Color_Click(object sender, EventArgs e) {
            if (Color_Picker.ShowDialog() == DialogResult.OK) {
                Barrel_Oil_Barrel_Radar_Color.BackColor = Color_Picker.Color;
                Settings.Default.Barrel_Oil_Barrel_Radar_Color = Color_Picker.Color;
            }
        }

        private void Barrel_Trash_Pile_Color_Click(object sender, EventArgs e) {
            if (Color_Picker.ShowDialog() == DialogResult.OK) {
                Barrel_Trash_Pile_Radar_Color.BackColor = Color_Picker.Color;
                Settings.Default.Barrel_Trash_Pile_Radar_Color = Color_Picker.Color;
            }
        }

        private void Barrel_Crate_Color_Click(object sender, EventArgs e) {
            if (Color_Picker.ShowDialog() == DialogResult.OK) {
                Barrel_Crate_Radar_Color.BackColor = Color_Picker.Color;
                Settings.Default.Barrel_Crate_Radar_Color = Color_Picker.Color;
            }
        }

        private void Barrel_Mine_Crate_Color_Click(object sender, EventArgs e) {
            if (Color_Picker.ShowDialog() == DialogResult.OK) {
                Barrel_Mine_Crate_Radar_Color.BackColor = Color_Picker.Color;
                Settings.Default.Barrel_Mine_Crate_Radar_Color = Color_Picker.Color;
            }
        }

        private void Barrel_Food_Crate_Color_Click(object sender, EventArgs e) {
            if (Color_Picker.ShowDialog() == DialogResult.OK) {
                Barrel_Food_Crate_Radar_Color.BackColor = Color_Picker.Color;
                Settings.Default.Barrel_Food_Crate_Radar_Color = Color_Picker.Color;
            }
        }

        private void Barrel_Med_Crate_Color_Click(object sender, EventArgs e) {
            if (Color_Picker.ShowDialog() == DialogResult.OK) {
                Barrel_Med_Crate_Radar_Color.BackColor = Color_Picker.Color;
                Settings.Default.Barrel_Med_Crate_Radar_Color = Color_Picker.Color;
            }
        }

        private void Barrel_Tool_Crate_Color_Click(object sender, EventArgs e) {
            if (Color_Picker.ShowDialog() == DialogResult.OK) {
                Barrel_Tool_Crate_Radar_Color.BackColor = Color_Picker.Color;
                Settings.Default.Barrel_Tool_Crate_Radar_Color = Color_Picker.Color;
            }
        }

        private void Barrel_Food_Box_Color_Click(object sender, EventArgs e) {
            if (Color_Picker.ShowDialog() == DialogResult.OK) {
                Barrel_Food_Box_Radar_Color.BackColor = Color_Picker.Color;
                Settings.Default.Barrel_Food_Box_Radar_Color = Color_Picker.Color;
            }
        }

        private void Sprinting_Color_Click(object sender, EventArgs e) {
            if (Color_Picker.ShowDialog() == DialogResult.OK) {
                Player_Sprinting_Radar_Color.BackColor = Color_Picker.Color;
                Settings.Default.Player_Sprinting_Radar_Color = Color_Picker.Color;
            }
        }

        private void Aiming_Color_Click(object sender, EventArgs e) {
            if (Color_Picker.ShowDialog() == DialogResult.OK) {
                Player_Aiming_Radar_Color.BackColor = Color_Picker.Color;
                Settings.Default.Player_Aiming_Radar_Color = Color_Picker.Color;
            }
        }

        private void Crouch_Color_Click(object sender, EventArgs e) {
            if (Color_Picker.ShowDialog() == DialogResult.OK) {
                Player_Crouching_Radar_Color.BackColor = Color_Picker.Color;
                Settings.Default.Player_Crouching_Radar_Color = Color_Picker.Color;
            }
        }

        private void ZoomTrackBar_Scroll(object sender, EventArgs e) {
            var val = ZoomTrackBar.Value;
            Settings.Default.Radar_Zoom = val;
            if (val > 0) {
                Settings.Default.ZoomAmount = val + 1;
            }
            if (val < 0) {
                Settings.Default.ZoomAmount = val - 1;
            }
        }

        private void StartButton_Click(object sender, EventArgs e) {
            if(caler.stopped) {
                caler.start();
                StartButton.Text = "Connected to " + Settings.Default.Server_IP + ":" + Settings.Default.Server_PORT;
            }
        }

        private void Server_IP_Text_TextChanged(object sender, EventArgs e) {
            Settings.Default.Server_IP = Server_IP_Text.Text;
        }

        private void Server_IP_Text_KeyPress(object sender, KeyPressEventArgs e) {
            if (!(Char.IsDigit(e.KeyChar) || (e.KeyChar == (char)Keys.Back) || (e.KeyChar == '.'))) {
                e.Handled = true;
            }
        }

        private void Server_PORT_Text_TextChanged(object sender, EventArgs e) {
            if (int.TryParse(Server_PORT_Text.Text, out int result)) {
                Settings.Default.Server_PORT = result;
            }
        }

        private void FOV_Text_Box_TextChanged(object sender, EventArgs e) {
            if (float.TryParse(FOV_Text_Box.Text, out float result)) {
                Settings.Default.FOV = result;
            }
        }

        private void FOV_Text_Box_KeyPress(object sender, KeyPressEventArgs e) {
            if (!(Char.IsDigit(e.KeyChar) || (e.KeyChar == (char)Keys.Back))) {
                e.Handled = true;
            }
        }

        private void Server_PORT_Text_KeyPress(object sender, KeyPressEventArgs e) {
            if (!(Char.IsDigit(e.KeyChar) || (e.KeyChar == (char)Keys.Back))) {
                e.Handled = true;
            }
        }

        private void Player_Check_CheckedChanged(object sender, EventArgs e) {
            Settings.Default.Player_Check = Players_Check.Checked;
        }

        private void Plants_Check_CheckedChanged(object sender, EventArgs e) {
            Settings.Default.Plants_Check = Plants_Check.Checked;
        }

        private void Resource_Check_CheckedChanged(object sender, EventArgs e) {
            Settings.Default.Resources_Check = Resources_Check.Checked;
        }

        private void Animals_Check_CheckedChanged(object sender, EventArgs e) {
            Settings.Default.Animals = Animals_Check.Checked;
        }

        private void Quarry_Check_CheckedChanged(object sender, EventArgs e) {
            Settings.Default.Deployable_Quarry_Radar_Check = Deployable_Quarry_Radar_Check.Checked;
        }

        private void Tool_Cupboard_Check_CheckedChanged(object sender, EventArgs e) {
            Settings.Default.Deployable_TC_Radar_Check = Deployable_TC_Radar_Check.Checked;
        }

        private void Sleeping_Bag_Check_CheckedChanged(object sender, EventArgs e) {
            Settings.Default.Deployable_Sleeping_Bag_Radar_Check = Deployable_Sleeping_Bag_Radar_Check.Checked;
        }

        private void AutoTurret_Check_CheckedChanged(object sender, EventArgs e) {
            Settings.Default.Deployable_AutoTurret_Radar_Check = Deployable_AutoTurret_Radar_Check.Checked;
        }

        private void Landmine_Check_CheckedChanged(object sender, EventArgs e) {
            Settings.Default.Deployable_Landmine_Radar_Check = Deployable_Landmine_Radar_Check.Checked;
        }

        private void Sleeping_Check_CheckedChanged(object sender, EventArgs e) {
            Settings.Default.Player_Sleeping_Radar_Check = Player_Sleeping_Radar_Check.Checked;
        }

        private void Friends_Check_CheckedChanged(object sender, EventArgs e) {
            Settings.Default.Player_Friend_Radar_Check = Player_Friend_Radar_Check.Checked;
        }

        private void Enemy_Check_CheckedChanged(object sender, EventArgs e) {
            Settings.Default.Player_Enemy_Radar_Check = Player_Enemy_Radar_Check.Checked;
        }

        private void Corpse_Check_CheckedChanged(object sender, EventArgs e) {
            Settings.Default.Misc_Corpse_Radar_Check = Misc_Corpse_Radar_Check.Checked;
        }

        private void Loot_Corpse_Check_CheckedChanged(object sender, EventArgs e) {
            Settings.Default.Player_Loot_Corpse_Radar_Check = Player_Loot_Corpse_Radar_Check.Checked;
        }

        private void Chicken_Check_CheckedChanged(object sender, EventArgs e) {
            Settings.Default.Animals_Chicken_Radar_Check = Animals_Chicken_Radar_Check.Checked;
        }

        private void Bear_Check_CheckedChanged(object sender, EventArgs e) {
            Settings.Default.Animals_Bear_Radar_Check = Animals_Bear_Radar_Check.Checked;
        }

        private void Deer_Check_CheckedChanged(object sender, EventArgs e) {
            Settings.Default.Animals_Deer_Radar_Check = Animals_Deer_Radar_Check.Checked;
        }

        private void Wolf_Check_CheckedChanged(object sender, EventArgs e) {
            Settings.Default.Animals_Wolf_Radar_Check = Animals_Wolf_Radar_Check.Checked;
        }

        private void Boar_Check_CheckedChanged(object sender, EventArgs e) {
            Settings.Default.Animals_Boar_Radar_Check = Animals_Boar_Radar_Check.Checked;
        }

        private void Horse_Check_CheckedChanged(object sender, EventArgs e) {
            Settings.Default.Animals_Horse_Radar_Check = Animals_Horse_Radar_Check.Checked;
        }

        private void Corn_Check_CheckedChanged(object sender, EventArgs e) {
            Settings.Default.Plant_Corn_Radar_Check = Plant_Corn_Radar_Check.Checked;
        }

        private void Hemp_Check_CheckedChanged(object sender, EventArgs e) {
            Settings.Default.Plant_Hemp_Radar_Check = Plant_Hemp_Radar_Check.Checked;
        }

        private void Pumpkin_Check_CheckedChanged(object sender, EventArgs e) {
            Settings.Default.Plant_Pumpkin_Radar_Check = Plant_Pumpkin_Radar_Check.Checked;
        }

        private void Mushroom_Check_CheckedChanged(object sender, EventArgs e) {
            Settings.Default.Plant_Mushroom_Radar_Check = Plant_Mushroom_Radar_Check.Checked;
        }

        private void Bear_Trap_Check_CheckedChanged(object sender, EventArgs e) {
            Settings.Default.Deployable_Bear_Trap_Radar_Check = Deployable_Bear_Trap_Radar_Check.Checked;
        }

        private void Furnace_Check_CheckedChanged(object sender, EventArgs e) {
            Settings.Default.Deployable_Furnace_Radar_heck = Deployable_Furnace_Radar_Check.Checked;
        }

        private void Large_Furnace_Check_CheckedChanged(object sender, EventArgs e) {
            Settings.Default.Deployable_Large_Furnace_Radar_Check = Deployable_Large_Furnace_Radar_Check.Checked;
        }

        private void Rock_Check_CheckedChanged(object sender, EventArgs e) {
            Settings.Default.Resource_Rock_Radar_Check = Resource_Rock_Collectable_Radar_Check.Checked;
        }

        private void Wood_Check_CheckedChanged(object sender, EventArgs e) {
            Settings.Default.Resource_Wood_Radar_Check = Resource_Wood_Collectable_Radar_Check.Checked;
        }

        private void Barrel_Check_CheckedChanged(object sender, EventArgs e) {
            Settings.Default.Barrels = Barrels_Check.Checked;
        }

        private void Stone_Node_Check_CheckedChanged(object sender, EventArgs e) {
            Settings.Default.Resource_Stone_Node_Radar_Check = Resource_Stone_Node_Radar_Check.Checked;
        }

        private void Metal_Node_Check_CheckedChanged(object sender, EventArgs e) {
            Settings.Default.Resource_Metal_Node_Radar_Check = Resource_Metal_Node_Radar_Check.Checked;
        }

        private void Sulfur_Node_Check_CheckedChanged(object sender, EventArgs e) {
            Settings.Default.Resource_Sulfur_Node_Radar_Check = Resource_Sulfur_Node_Radar_Check.Checked;
        }

        private void Metal_Ore_Check_CheckedChanged(object sender, EventArgs e) {
            Settings.Default.Resource_Metal_Ore_Radar_Check = Resource_Metal_Collectable_Radar_Check.Checked;
        }

        private void Sulfur_Ore_Check_CheckedChanged(object sender, EventArgs e) {
            Settings.Default.Resource_Sulfur_Ore_Radar_Check = Resource_Sulfur_Collectable_Radar_Check.Checked;
        }

        private void Fridge_Check_CheckedChanged(object sender, EventArgs e) {
            Settings.Default.Deployable_Fridge_Radar_Check = Deployable_Fridge_Radar_Check.Checked;
        }

        private void Stash_Check_CheckedChanged(object sender, EventArgs e) {
            Settings.Default.Deployable_Stash_Radar_Check = Deployable_Stash_Radar_Check.Checked;
        }

        private void Oil_Checked_CheckedChanged(object sender, EventArgs e) {
            Settings.Default.Deployable_Oil_Radar_Check = Deployable_Oil_Radar_Checked.Checked;
        }

        private void Deployable_Box_Check_CheckedChanged(object sender, EventArgs e) {
            Settings.Default.Deployable_Box_Radar_Check = Deployable_Box_Radar_Check.Checked;
        }

        private void Crosshair_Check_CheckedChanged(object sender, EventArgs e) {
            Settings.Default.Crosshair_Check = Crosshair_Check.Checked;
        }

        private void Radar_Check_CheckedChanged(object sender, EventArgs e) {
            Settings.Default.Radar_Check = Radar_Check.Checked;
        }

        private void Barrel_Loot_Barrel_Check_CheckedChanged(object sender, EventArgs e) {
            Settings.Default.Barrel_Loot_Barrel_Radar_Check = Barrel_Loot_Barrel_Radar_Check.Checked;
        }

        private void Barrel_Oil_Barrel_Check_CheckedChanged(object sender, EventArgs e) {
            Settings.Default.Barrel_Oil_Barrel_Radar_Check = Barrel_Oil_Barrel_Radar_Check.Checked;
        }

        private void Barrel_Trash_Pile_Check_CheckedChanged(object sender, EventArgs e) {
            Settings.Default.Barrel_Trash_Pile_Radar_Check = Barrel_Trash_Pile_Radar_Check.Checked;
        }

        private void Barrel_Crate_Check_CheckedChanged(object sender, EventArgs e) {
            Settings.Default.Barrel_Crate_Radar_Check = Barrel_Crate_Radar_Check.Checked;
        }

        private void Barrel_Mine_Crate_Check_CheckedChanged(object sender, EventArgs e) {
            Settings.Default.Barrel_Mine_Crate_Radar_Check = Barrel_Mine_Crate_Radar_Check.Checked;
        }

        private void Barrel_Food_Crate_Check_CheckedChanged(object sender, EventArgs e) {
            Settings.Default.Barrel_Food_Crate_Radar_Check = Barrel_Food_Crate_Radar_Check.Checked;
        }

        private void Barrel_Med_Crate_Check_CheckedChanged(object sender, EventArgs e) {
            Settings.Default.Barrel_Med_Crate_Radar_Check = Barrel_Med_Crate_Radar_Check.Checked;
        }

        private void Barrel_Tool_Crate_Check_CheckedChanged(object sender, EventArgs e) {
            Settings.Default.Barrel_Tool_Crate_Radar_Check = Barrel_Tool_Crate_Radar_Check.Checked;
        }

        private void Barrel_Food_Box_Check_CheckedChanged(object sender, EventArgs e) {
            Settings.Default.Barrel_Food_Box_Radar_Check = Barrel_Food_Box_Radar_Check.Checked;
        }

        private void Large_Box_Check_CheckedChanged(object sender, EventArgs e) {
            Settings.Default.Deployable_Large_Box_Radar_Check = Deployable_Large_Box_Radar_Check.Checked;
        }

        private void Aiming_Check_CheckedChanged(object sender, EventArgs e) {
            Settings.Default.Player_Aiming_Radar_Check = Player_Aiming_Radar_Check.Checked;
        }

        private void Sprinting_Check_CheckedChanged(object sender, EventArgs e) {
            Settings.Default.Player_Sprinting_Radar_Check = Player_Sprinting_Radar_Check.Checked;
        }

        private void Held_Item_Check_CheckedChanged(object sender, EventArgs e) {
            Settings.Default.Player_Held_Item_Enable = PlayerHeldItem.Checked;
        }

        private void Reset_Click(object sender, EventArgs e) {
            Settings.Default.Reset();
            Settings.Default.FirstLoad = false;
            Console.WriteLine("RESET SETTINGS");
            LoadSettings();
        }

        private void Inventory_Belt_Check_CheckedChanged(object sender, EventArgs e) {
            Settings.Default.Player_Inventory_Belt = PlayerInventoryBeltCheck.Checked;
        }

        private void Inventory_Wear_Check_CheckedChanged(object sender, EventArgs e) {
            Settings.Default.Player_Inventory_Wear = PlayerInventoryWearCheck.Checked;
        }

        private void Tracer_Check_CheckedChanged(object sender, EventArgs e) {
            Settings.Default.Tracer_Check = Tracer_Check.Checked;
        }

        private void Crosshair_Color_Click(object sender, EventArgs e) {
            if(Color_Picker.ShowDialog() == DialogResult.OK) {
                Crosshair_Color.BackColor = Color_Picker.Color;
                Settings.Default.Crosshair_Color = Color_Picker.Color;
            }
        }

        private void Crosshair_Size_Text_TextChanged(object sender, EventArgs e) {
            if (int.TryParse(Crosshair_Size_Text.Text, out int result)) {
                Settings.Default.Crosshair_Size = result;
            }
        }

        private void Crosshair_Size_Text_KeyPress(object sender, KeyPressEventArgs e) {
            if (!(Char.IsDigit(e.KeyChar) || (e.KeyChar == (char)Keys.Back))) {
                e.Handled = true;
            }
        }

        private void Crosshair_Thick_Text_TextChanged(object sender, EventArgs e) {
            if (float.TryParse(Crosshair_Thick_Text.Text, out float result)) {
                Settings.Default.Crosshair_Thick = result;
            }
        }

        private void Crosshair_Thick_Text_KeyPress(object sender, KeyPressEventArgs e) {
            if (!(Char.IsDigit(e.KeyChar) || (e.KeyChar == (char)Keys.Back) || (e.KeyChar == '.'))) {
                e.Handled = true;
            }
        }

        private void Type_Box_SelectedIndexChanged(object sender, EventArgs e) {
            Settings.Default.Crosshair_Type = Type_Box.SelectedIndex;
        }

        private void SupplyDrop_Check_CheckedChanged(object sender, EventArgs e) {
            Settings.Default.Misc_Supply_Drop_Radar_Check = Misc_Supply_Drop_Radar_Check.Checked;
        }

        private void SupplyDrop_Color_Click(object sender, EventArgs e) {
            if (Color_Picker.ShowDialog() == DialogResult.OK) {
                Misc_Supply_Drop_Radar_Color.BackColor = Color_Picker.Color;
                Settings.Default.Misc_Supply_Drop_Radar_Color = Color_Picker.Color;
            }
        }

        private void Player_Sprinting_Box_Check_CheckedChanged(object sender, EventArgs e) {
            Settings.Default.Player_Sprinting_Box_Check = Player_Sprinting_Box_Check.Checked;
        }

        private void Player_Loot_Corpse_Tracer_Check_CheckedChanged(object sender, EventArgs e) {
            Settings.Default.Player_Loot_Corpse_Tracer_Check = Player_Loot_Corpse_Tracer_Check.Checked;
        }

        private void Player_Enemy_Tracer_Check_CheckedChanged(object sender, EventArgs e) {
            Settings.Default.Player_Enemy_Tracer_Check = Player_Enemy_Tracer_Check.Checked;
        }

        private void Player_Friends_Tracer_Check_CheckedChanged(object sender, EventArgs e) {
            Settings.Default.Player_Friend_Tracer_Check = Player_Friend_Tracer_Check.Checked;
        }

        private void Player_Friend_Box_Check_CheckedChanged(object sender, EventArgs e) {
            Settings.Default.Player_Friend_Box_Check = Player_Friend_Box_Check.Checked;
        }

        private void Player_Enemy_Box_Check_CheckedChanged(object sender, EventArgs e) {
            Settings.Default.Player_Enemy_Box_Check = Player_Enemy_Box_Check.Checked;
        }

        private void Player_Crouching_Box_Check_CheckedChanged(object sender, EventArgs e) {
            Settings.Default.Player_Crouching_Box_Check = Player_Crouching_Box_Check.Checked;
        }

        private void Player_Crouching_Tracer_Check_CheckedChanged(object sender, EventArgs e) {
            Settings.Default.Player_Crouching_Tracer_Check = Player_Crouching_Tracer_Check.Checked;
        }

        private void Player_Sprinting_Tracer_Check_CheckedChanged(object sender, EventArgs e) {
            Settings.Default.Player_Sprinting_Tracer_Check = Player_Sprinting_Tracer_Check.Checked;
        }

        private void Player_Aiming_Tracer_Check_CheckedChanged(object sender, EventArgs e) {
            Settings.Default.Player_Aiming_Tracer_Check = Player_Aiming_Tracer_Check.Checked;
        }

        private void Player_Sleeping_Tracer_Check_CheckedChanged(object sender, EventArgs e) {
            Settings.Default.Player_Sleeping_Tracer_Check = Player_Sleeping_Tracer_Check.Checked;
        }

        private void Player_Awake_Tracer_Check_CheckedChanged(object sender, EventArgs e) {
            Settings.Default.Player_Awake_Tracer_Check = Player_Awake_Tracer_Check.Checked;
        }

        private void Player_Awake_Box_Check_CheckedChanged(object sender, EventArgs e) {
            Settings.Default.Player_Awake_Box_Check = Player_Awake_Box_Check.Checked;
        }

        private void Player_Sleeping_Box_Check_CheckedChanged(object sender, EventArgs e) {
            Settings.Default.Player_Sleeping_Box_Check = Player_Sleeping_Box_Check.Checked;
        }

        private void Player_Aiming_Box_Check_CheckedChanged(object sender, EventArgs e) {
            Settings.Default.Player_Aiming_Box_Check = Player_Aiming_Box_Check.Checked;
        }

        private void Player_Loot_Corpse_Box_Check_CheckedChanged(object sender, EventArgs e) {
            Settings.Default.Player_Loot_Corpse_Box_Check = Player_Loot_Corpse_Box_Check.Checked;
        }

        private void Player_Loot_Corpse_Box_Color_Click(object sender, EventArgs e) {
            if (Color_Picker.ShowDialog() == DialogResult.OK) {
                Player_Loot_Corpse_Box_Color.BackColor = Color_Picker.Color;
                Settings.Default.Player_Loot_Corpse_Box_Color = Color_Picker.Color;
            }
        }

        private void Player_Enemy_Tracer_Color_Click(object sender, EventArgs e) {
            if (Color_Picker.ShowDialog() == DialogResult.OK) {
                Player_Enemy_Tracer_Color.BackColor = Color_Picker.Color;
                Settings.Default.Player_Enemy_Tracer_Color = Color_Picker.Color;
            }
        }

        private void Player_Friend_Tracer_Color_Click(object sender, EventArgs e) {
            if (Color_Picker.ShowDialog() == DialogResult.OK) {
                Player_Friend_Tracer_Color.BackColor = Color_Picker.Color;
                Settings.Default.Player_Friend_Tracer_Color = Color_Picker.Color;
            }
        }

        private void Player_Crouching_Tracer_Color_Click(object sender, EventArgs e) {
            if (Color_Picker.ShowDialog() == DialogResult.OK) {
                Player_Crouching_Tracer_Color.BackColor = Color_Picker.Color;
                Settings.Default.Player_Crouching_Tracer_Color = Color_Picker.Color;
            }
        }
        
        private void Player_Aiming_Tracer_Color_Click(object sender, EventArgs e) {
            if (Color_Picker.ShowDialog() == DialogResult.OK) {
                Player_Aiming_Tracer_Color.BackColor = Color_Picker.Color;
                Settings.Default.Player_Aiming_Tracer_Color = Color_Picker.Color;
            }
        }

        private void Player_Sleeping_Tracer_Color_Click(object sender, EventArgs e) {
            if (Color_Picker.ShowDialog() == DialogResult.OK) {
                Player_Sleeping_Tracer_Color.BackColor = Color_Picker.Color;
                Settings.Default.Player_Sleeping_Tracer_Color = Color_Picker.Color;
            }
        }

        private void Player_Awake_Tracer_Color_Click(object sender, EventArgs e) {
            if (Color_Picker.ShowDialog() == DialogResult.OK) {
                Player_Awake_Tracer_Color.BackColor = Color_Picker.Color;
                Settings.Default.Player_Awake_Tracer_Color = Color_Picker.Color;
            }
        }

        private void Player_Awake_Box_Color_Click(object sender, EventArgs e) {
            if (Color_Picker.ShowDialog() == DialogResult.OK) {
                Player_Awake_Box_Color.BackColor = Color_Picker.Color;
                Settings.Default.Player_Awake_Box_Color = Color_Picker.Color;
            }
        }

        private void Player_Sleeping_Box_Color_Click(object sender, EventArgs e) {
            if (Color_Picker.ShowDialog() == DialogResult.OK) {
                Player_Sleeping_Box_Color.BackColor = Color_Picker.Color;
                Settings.Default.Player_Sleeping_Box_Color = Color_Picker.Color;
            }
        }

        private void Player_Aiming_Box_Color_Click(object sender, EventArgs e) {
            if (Color_Picker.ShowDialog() == DialogResult.OK) {
                Player_Aiming_Box_Color.BackColor = Color_Picker.Color;
                Settings.Default.Player_Aiming_Box_Color = Color_Picker.Color;
            }
        }

        private void Player_Crouching_Box_Color_Click(object sender, EventArgs e) {
            if (Color_Picker.ShowDialog() == DialogResult.OK) {
                Player_Crouching_Box_Color.BackColor = Color_Picker.Color;
                Settings.Default.Player_Crouching_Box_Color = Color_Picker.Color;
            }
        }

        private void Player_Friend_Box_Color_Click(object sender, EventArgs e) {
            if (Color_Picker.ShowDialog() == DialogResult.OK) {
                Player_Friend_Box_Color.BackColor = Color_Picker.Color;
                Settings.Default.Player_Friend_Box_Color = Color_Picker.Color;
            }
        }

        private void Player_Sprinting_Box_Color_Click(object sender, EventArgs e) {
            if (Color_Picker.ShowDialog() == DialogResult.OK) {
                Player_Sprinting_Box_Color.BackColor = Color_Picker.Color;
                Settings.Default.Player_Sprinting_Box_Color = Color_Picker.Color;
            }
        }

        private void Player_Sprinting_Tracer_Color_Click(object sender, EventArgs e) {
            if (Color_Picker.ShowDialog() == DialogResult.OK) {
                Player_Sprinting_Tracer_Color.BackColor = Color_Picker.Color;
                Settings.Default.Player_Sprinting_Tracer_Color = Color_Picker.Color;
            }
        }

        private void Player_Enemy_Box_Color_Click(object sender, EventArgs e) {
            if (Color_Picker.ShowDialog() == DialogResult.OK) {
                Player_Enemy_Box_Color.BackColor = Color_Picker.Color;
                Settings.Default.Player_Enemy_Box_Color = Color_Picker.Color;
            }
        }

        private void Player_Loot_Corpse_Tracer_Color_Click(object sender, EventArgs e) {
            if (Color_Picker.ShowDialog() == DialogResult.OK) {
                Player_Loot_Corpse_Tracer_Color.BackColor = Color_Picker.Color;
                Settings.Default.Player_Loot_Corpse_Tracer_Color = Color_Picker.Color;
            }
        }

        private void Player_Awake_Radar_Check_CheckedChanged(object sender, EventArgs e) {
            Settings.Default.Player_Awake_Radar_Check = Player_Awake_Radar_Check.Checked;
        }

        private void Player_Crouching_Radar_Check_CheckedChanged(object sender, EventArgs e) {
            Settings.Default.Player_Crouching_Radar_Check = Player_Crouching_Radar_Check.Checked;
        }

        private void Misc_Corpse_Radar_Check_CheckedChanged(object sender, EventArgs e) {
            Settings.Default.Misc_Corpse_Radar_Check = Misc_Corpse_Radar_Check.Checked;
        }

        private void Misc_Supply_Drop_Radar_Check_CheckedChanged(object sender, EventArgs e) {
            Settings.Default.Misc_Supply_Drop_Radar_Check = Misc_Supply_Drop_Radar_Check.Checked;
        }

        private void Misc_Helicopter_Radar_Check_CheckedChanged(object sender, EventArgs e) {
            Settings.Default.Misc_Helicopter_Radar_Check = Misc_Helicopter_Radar_Check.Checked;
        }

        private void Misc_Helicopter_Tracer_Check_CheckedChanged(object sender, EventArgs e) {
            Settings.Default.Misc_Helicopter_Tracer_Check = Misc_Helicopter_Tracer_Check.Checked;
        }

        private void Misc_Supply_Drop_Tracer_Check_CheckedChanged(object sender, EventArgs e) {
            Settings.Default.Misc_Supply_Drop_Tracer_Check = Misc_Supply_Drop_Tracer_Check.Checked;
        }

        private void Misc_Corpse_Tracer_Check_CheckedChanged(object sender, EventArgs e) {
            Settings.Default.Misc_Corpse_Tracer_Check = Misc_Corpse_Tracer_Check.Checked;
        }

        private void Misc_Corpse_Box_Check_CheckedChanged(object sender, EventArgs e) {
            Settings.Default.Misc_Corpse_Box_Check = Misc_Corpse_Box_Check.Checked;
        }

        private void Misc_Supply_Drop_Box_Check_CheckedChanged(object sender, EventArgs e) {
            Settings.Default.Misc_Supply_Drop_Box_Check = Misc_Supply_Drop_Box_Check.Checked;
        }

        private void Misc_Helicopter_Box_Check_CheckedChanged(object sender, EventArgs e) {
            Settings.Default.Misc_Helicopter_Box_Check = Misc_Helicopter_Box_Check.Checked;
        }

        private void Misc_Helicopter_Radar_Color_Click(object sender, EventArgs e) {
            if (Color_Picker.ShowDialog() == DialogResult.OK) {
                Misc_Helicopter_Radar_Color.BackColor = Color_Picker.Color;
                Settings.Default.Misc_Helicopter_Radar_Color = Color_Picker.Color;
            }
        }

        private void Misc_Supply_Drop_Radar_Color_Click(object sender, EventArgs e) {
            if (Color_Picker.ShowDialog() == DialogResult.OK) {
                Misc_Supply_Drop_Radar_Color.BackColor = Color_Picker.Color;
                Settings.Default.Misc_Supply_Drop_Radar_Color = Color_Picker.Color;
            }
        }

        private void Misc_Corpse_Radar_Color_Click(object sender, EventArgs e) {
            if (Color_Picker.ShowDialog() == DialogResult.OK) {
                Misc_Corpse_Radar_Color.BackColor = Color_Picker.Color;
                Settings.Default.Misc_Corpse_Radar_Color = Color_Picker.Color;
            }
        }

        private void Misc_Corpse_Tracer_Color_Click(object sender, EventArgs e) {
            if (Color_Picker.ShowDialog() == DialogResult.OK) {
                Misc_Corpse_Tracer_Color.BackColor = Color_Picker.Color;
                Settings.Default.Misc_Corpse_Tracer_Color = Color_Picker.Color;
            }
        }

        private void Misc_Supply_Drop_Tracer_Color_Click(object sender, EventArgs e) {
            if (Color_Picker.ShowDialog() == DialogResult.OK) {
                Misc_Supply_Drop_Tracer_Color.BackColor = Color_Picker.Color;
                Settings.Default.Misc_Supply_Drop_Tracer_Color = Color_Picker.Color;
            }
        }

        private void Misc_Helicopter_Tracer_Color_Click(object sender, EventArgs e) {
            if (Color_Picker.ShowDialog() == DialogResult.OK) {
                Misc_Helicopter_Tracer_Color.BackColor = Color_Picker.Color;
                Settings.Default.Misc_Helicopter_Tracer_Color = Color_Picker.Color;
            }
        }

        private void Misc_Helicopter_Box_Color_Click(object sender, EventArgs e) {
            if (Color_Picker.ShowDialog() == DialogResult.OK) {
                Misc_Helicopter_Box_Color.BackColor = Color_Picker.Color;
                Settings.Default.Misc_Helicopter_Box_Color = Color_Picker.Color;
            }
        }

        private void Misc_Supply_Drop_Box_Color_Click(object sender, EventArgs e) {
            if (Color_Picker.ShowDialog() == DialogResult.OK) {
                Misc_Supply_Drop_Box_Color.BackColor = Color_Picker.Color;
                Settings.Default.Misc_Supply_Drop_Box_Color = Color_Picker.Color;
            }
        }

        private void Misc_Corpse_Box_Color_Click(object sender, EventArgs e) {
            if (Color_Picker.ShowDialog() == DialogResult.OK) {
                Misc_Corpse_Box_Color.BackColor = Color_Picker.Color;
                Settings.Default.Misc_Corpse_Box_Color = Color_Picker.Color;
            }
        }

        private void MiscCheck_CheckedChanged(object sender, EventArgs e) {
            Settings.Default.Misc_Check = Misc_Check.Checked;
        }

        private void DeployablesCheck_CheckedChanged(object sender, EventArgs e) {
            Settings.Default.Deployables = Deployables_Check.Checked;
        }

        private void Animals_Wolf_Box_Color_Click(object sender, EventArgs e) {
            if (Color_Picker.ShowDialog() == DialogResult.OK) {
                Animals_Wolf_Box_Color.BackColor = Color_Picker.Color;
                Settings.Default.Animals_Wolf_Box_Color = Color_Picker.Color;
            }
        }

        private void Animals_Wolf_Tracer_Check_CheckedChanged(object sender, EventArgs e) {
            Settings.Default.Animals_Wolf_Tracer_Check = Animals_Wolf_Tracer_Check.Checked;
        }

        private void Animals_Bear_Tracer_Check_CheckedChanged(object sender, EventArgs e) {
            Settings.Default.Animals_Bear_Tracer_Check = Animals_Bear_Tracer_Check.Checked;
        }

        private void Animals_Deer_Tracer_Check_CheckedChanged(object sender, EventArgs e) {
            Settings.Default.Animals_Deer_Tracer_Check = Animals_Deer_Tracer_Check.Checked;
        }

        private void Animals_Chicken_Tracer_Check_CheckedChanged(object sender, EventArgs e) {
            Settings.Default.Animals_Chicken_Tracer_Check = Animals_Chicken_Tracer_Check.Checked;
        }

        private void Animals_Boar_Tracer_Check_CheckedChanged(object sender, EventArgs e) {
            Settings.Default.Animals_Boar_Tracer_Check = Animals_Boar_Tracer_Check.Checked;
        }

        private void Animals_Horse_Tracer_Check_CheckedChanged(object sender, EventArgs e) {
            Settings.Default.Animals_Horse_Tracer_Check = Animals_Horse_Tracer_Check.Checked;
        }

        private void Animals_Horse_Box_Check_CheckedChanged(object sender, EventArgs e) {
            Settings.Default.Animals_Horse_Box_Check = Animals_Horse_Box_Check.Checked;
        }

        private void Animals_Boar_Box_Check_CheckedChanged(object sender, EventArgs e) {
            Settings.Default.Animals_Boar_Box_Check = Animals_Boar_Box_Check.Checked;
        }

        private void Animals_Chicken_Box_Check_CheckedChanged(object sender, EventArgs e) {
            Settings.Default.Animals_Chicken_Box_Check = Animals_Chicken_Box_Check.Checked;
        }

        private void Animals_Deer_Box_Check_CheckedChanged(object sender, EventArgs e) {
            Settings.Default.Animals_Deer_Box_Check = Animals_Deer_Box_Check.Checked;
        }

        private void Animals_Bear_Box_Check_CheckedChanged(object sender, EventArgs e) {
            Settings.Default.Animals_Bear_Box_Check = Animals_Bear_Box_Check.Checked;
        }

        private void Animals_Wolf_Box_Check_CheckedChanged(object sender, EventArgs e) {
            Settings.Default.Animals_Wolf_Box_Check = Animals_Wolf_Box_Check.Checked;
        }

        private void Animals_Wolf_Tracer_Color_Click(object sender, EventArgs e) {
            if (Color_Picker.ShowDialog() == DialogResult.OK) {
                Animals_Wolf_Tracer_Color.BackColor = Color_Picker.Color;
                Settings.Default.Animals_Wolf_Tracer_Color = Color_Picker.Color;
            }
        }

        private void Animals_Bear_Tracer_Color_Click(object sender, EventArgs e) {
            if (Color_Picker.ShowDialog() == DialogResult.OK) {
                Animals_Bear_Tracer_Color.BackColor = Color_Picker.Color;
                Settings.Default.Animals_Bear_Tracer_Color = Color_Picker.Color;
            }
        }

        private void Animals_Deer_Tracer_Color_Click(object sender, EventArgs e) {
            if (Color_Picker.ShowDialog() == DialogResult.OK) {
                Animals_Deer_Tracer_Color.BackColor = Color_Picker.Color;
                Settings.Default.Animals_Deer_Tracer_Color = Color_Picker.Color;
            }
        }

        private void Animals_Chicken_Tracer_Color_Click(object sender, EventArgs e) {
            if (Color_Picker.ShowDialog() == DialogResult.OK) {
                Animals_Chicken_Tracer_Color.BackColor = Color_Picker.Color;
                Settings.Default.Animals_Chicken_Tracer_Color = Color_Picker.Color;
            }
        }

        private void Animals_Boar_Tracer_Color_Click(object sender, EventArgs e) {
            if (Color_Picker.ShowDialog() == DialogResult.OK) {
                Animals_Boar_Tracer_Color.BackColor = Color_Picker.Color;
                Settings.Default.Animals_Boar_Tracer_Color = Color_Picker.Color;
            }
        }

        private void Animals_Horse_Tracer_Color_Click(object sender, EventArgs e) {
            if (Color_Picker.ShowDialog() == DialogResult.OK) {
                Animals_Horse_Tracer_Color.BackColor = Color_Picker.Color;
                Settings.Default.Animals_Horse_Tracer_Color = Color_Picker.Color;
            }
        }

        private void Animals_Horse_Box_Color_Click(object sender, EventArgs e) {
            if (Color_Picker.ShowDialog() == DialogResult.OK) {
                Animals_Horse_Box_Color.BackColor = Color_Picker.Color;
                Settings.Default.Animals_Horse_Box_Color = Color_Picker.Color;
            }
        }

        private void Animals_Boar_Box_Color_Click(object sender, EventArgs e) {
            if (Color_Picker.ShowDialog() == DialogResult.OK) {
                Animals_Boar_Box_Color.BackColor = Color_Picker.Color;
                Settings.Default.Animals_Boar_Box_Color = Color_Picker.Color;
            }
        }

        private void Animals_Chicken_Box_Color_Click(object sender, EventArgs e) {
            if (Color_Picker.ShowDialog() == DialogResult.OK) {
                Animals_Chicken_Box_Color.BackColor = Color_Picker.Color;
                Settings.Default.Animals_Chicken_Box_Color = Color_Picker.Color;
            }
        }

        private void Animals_Deer_Box_Color_Click(object sender, EventArgs e) {
            if (Color_Picker.ShowDialog() == DialogResult.OK) {
                Animals_Deer_Box_Color.BackColor = Color_Picker.Color;
                Settings.Default.Animals_Deer_Box_Color = Color_Picker.Color;
            }
        }

        private void Animals_Bear_Box_Color_Click(object sender, EventArgs e) {
            if (Color_Picker.ShowDialog() == DialogResult.OK) {
                Animals_Bear_Box_Color.BackColor = Color_Picker.Color;
                Settings.Default.Animals_Bear_Box_Color = Color_Picker.Color;
            }
        }

        private void Deployable_Quarry_Box_Color_Click(object sender, EventArgs e) {
            if (Color_Picker.ShowDialog() == DialogResult.OK) {
                Deployable_Quarry_Box_Color.BackColor = Color_Picker.Color;
                Settings.Default.Deployable_Quarry_Box_Color = Color_Picker.Color;
            }
        }

        private void Deployable_TC_Tracer_Check_CheckedChanged(object sender, EventArgs e) {
            Settings.Default.Deployable_TC_Tracer_Check = Deployable_TC_Tracer_Check.Checked;
        }

        private void Deployable_Sleeping_Bag_Tracer_Check_CheckedChanged(object sender, EventArgs e) {
            Settings.Default.Deployable_Sleeping_Bag_Tracer_Check = Deployable_Sleeping_Bag_Tracer_Check.Checked;
        }

        private void Deployable_AutoTurret_Tracer_Check_CheckedChanged(object sender, EventArgs e) {
            Settings.Default.Deployable_AutoTurret_Tracer_Check = Deployable_AutoTurret_Tracer_Check.Checked;
        }

        private void Deployable_Furnace_Tracer_Check_CheckedChanged(object sender, EventArgs e) {
            Settings.Default.Deployable_Furnace_Tracer_Check = Deployable_Furnace_Tracer_Check.Checked;
        }

        private void Deployable_Large_Furnace_Tracer_Check_CheckedChanged(object sender, EventArgs e) {
            Settings.Default.Deployable_Large_Furnace_Tracer_Check = Deployable_Large_Furnace_Tracer_Check.Checked;
        }

        private void Deployable_Fridge_Tracer_Check_CheckedChanged(object sender, EventArgs e) {
            Settings.Default.Deployable_Fridge_Tracer_Check = Deployable_Fridge_Tracer_Check.Checked;
        }

        private void Deployable_Oil_Tracer_Check_CheckedChanged(object sender, EventArgs e) {
            Settings.Default.Deployable_Oil_Tracer_Check = Deployable_Oil_Tracer_Check.Checked;
        }

        private void Deployable_Landmine_Tracer_Check_CheckedChanged(object sender, EventArgs e) {
            Settings.Default.Deployable_Landmine_Tracer_Check = Deployable_Landmine_Tracer_Check.Checked;
        }

        private void Deployable_Bear_Trap_Tracer_Check_CheckedChanged(object sender, EventArgs e) {
            Settings.Default.Deployable_Bear_Trap_Tracer_Check = Deployable_Bear_Trap_Tracer_Check.Checked;
        }

        private void Deployable_Stash_Tracer_Check_CheckedChanged(object sender, EventArgs e) {
            Settings.Default.Deployable_Stash_Tracer_Check = Deployable_Stash_Tracer_Check.Checked;
        }

        private void Deployable_Box_Tracer_Check_CheckedChanged(object sender, EventArgs e) {
            Settings.Default.Deployable_Box_Tracer_Check = Deployable_Box_Tracer_Check.Checked;
        }

        private void Deployable_Large_Box_Tracer_Check_CheckedChanged(object sender, EventArgs e) {
            Settings.Default.Deployable_Large_Box_Tracer_Check = Deployable_Large_Box_Tracer_Check.Checked;
        }

        private void Deployable_Large_Box_Box_Check_CheckedChanged(object sender, EventArgs e) {
            Settings.Default.Deployable_Large_Box_Box_Check = Deployable_Large_Box_Box_Check.Checked;
        }

        private void Deployable_Box_Box_Check_CheckedChanged(object sender, EventArgs e) {
            Settings.Default.Deployable_Box_Box_Check = Deployable_Box_Box_Check.Checked;
        }

        private void Deployable_Stash_Box_Check_CheckedChanged(object sender, EventArgs e) {
            Settings.Default.Deployable_Stash_Box_Check = Deployable_Stash_Box_Check.Checked;
        }

        private void Deployable_Bear_Trap_Box_Check_CheckedChanged(object sender, EventArgs e) {
            Settings.Default.Deployable_Bear_Trap_Box_Check = Deployable_Bear_Trap_Box_Check.Checked;
        }

        private void Deployable_Landmine_Box_Check_CheckedChanged(object sender, EventArgs e) {
            Settings.Default.Deployable_Landmine_Box_Check = Deployable_Landmine_Box_Check.Checked;
        }

        private void Deployable_Oil_Box_Check_CheckedChanged(object sender, EventArgs e) {
            Settings.Default.Deployable_Oil_Box_Check = Deployable_Oil_Box_Check.Checked;
        }

        private void Deployable_Fridge_Box_Check_CheckedChanged(object sender, EventArgs e) {
            Settings.Default.Deployable_Fridge_Box_Check = Deployable_Fridge_Box_Check.Checked;
        }

        private void Deployable_Large_Furnace_Box_Check_CheckedChanged(object sender, EventArgs e) {
            Settings.Default.Deployable_Large_Furnace_Box_Check = Deployable_Large_Furnace_Box_Check.Checked;
        }

        private void Deployable_Furnace_Box_Check_CheckedChanged(object sender, EventArgs e) {
            Settings.Default.Deployable_Furnace_Box_Check = Deployable_Furnace_Box_Check.Checked;
        }

        private void Deployable_AutoTurret_Box_Check_CheckedChanged(object sender, EventArgs e) {
            Settings.Default.Deployable_AutoTurret_Box_Check = Deployable_AutoTurret_Box_Check.Checked;
        }

        private void Deployable_Sleeping_Bag_Box_Check_CheckedChanged(object sender, EventArgs e) {
            Settings.Default.Deployable_Sleeping_Bag_Box_Check = Deployable_Sleeping_Bag_Box_Check.Checked;
        }

        private void Deployable_TC_Box_Check_CheckedChanged(object sender, EventArgs e) {
            Settings.Default.Deployable_TC_Box_Check = Deployable_TC_Box_Check.Checked;
        }

        private void Deployable_Quarry_Box_Check_CheckedChanged(object sender, EventArgs e) {
            Settings.Default.Deployable_Quarry_Box_Check = Deployable_Quarry_Box_Check.Checked;
        }

        private void Deployable_Quarry_Tracer_Color_Click(object sender, EventArgs e) {
            if (Color_Picker.ShowDialog() == DialogResult.OK) {
                Deployable_Quarry_Tracer_Color.BackColor = Color_Picker.Color;
                Settings.Default.Deployable_Quarry_Tracer_Color = Color_Picker.Color;
            }
        }

        private void Deployable_TC_Tracer_Color_Click(object sender, EventArgs e) {
            if (Color_Picker.ShowDialog() == DialogResult.OK) {
                Deployable_TC_Tracer_Color.BackColor = Color_Picker.Color;
                Settings.Default.Deployable_TC_Tracer_Color = Color_Picker.Color;
            }
        }

        private void Deployable_Sleeping_Bag_Tracer_Color_Click(object sender, EventArgs e) {
            if (Color_Picker.ShowDialog() == DialogResult.OK) {
                Deployable_Sleeping_Bag_Tracer_Color.BackColor = Color_Picker.Color;
                Settings.Default.Deployable_Sleeping_Bag_Tracer_Color = Color_Picker.Color;
            }
        }

        private void Deployable_AutoTurret_Tracer_Color_Click(object sender, EventArgs e) {
            if (Color_Picker.ShowDialog() == DialogResult.OK) {
                Deployable_AutoTurret_Tracer_Color.BackColor = Color_Picker.Color;
                Settings.Default.Deployable_AutoTurret_Tracer_Color = Color_Picker.Color;
            }
        }

        private void Deployable_Furnace_Tracer_Color_Click(object sender, EventArgs e) {
            if (Color_Picker.ShowDialog() == DialogResult.OK) {
                Deployable_Furnace_Tracer_Color.BackColor = Color_Picker.Color;
                Settings.Default.Deployable_Furnace_Tracer_Color = Color_Picker.Color;
            }
        }

        private void Deployable_Large_Furnace_Tracer_Color_Click(object sender, EventArgs e) {
            if (Color_Picker.ShowDialog() == DialogResult.OK) {
                Deployable_Large_Furnace_Tracer_Color.BackColor = Color_Picker.Color;
                Settings.Default.Deployable_Large_Furnace_Tracer_Color = Color_Picker.Color;
            }
        }

        private void Deployable_Fridge_Tracer_Color_Click(object sender, EventArgs e) {
            if (Color_Picker.ShowDialog() == DialogResult.OK) {
                Deployable_Fridge_Tracer_Color.BackColor = Color_Picker.Color;
                Settings.Default.Deployable_Fridge_Tracer_Color = Color_Picker.Color;
            }
        }

        private void Deployable_Oil_Tracer_Color_Click(object sender, EventArgs e) {
            if (Color_Picker.ShowDialog() == DialogResult.OK) {
                Deployable_Oil_Tracer_Color.BackColor = Color_Picker.Color;
                Settings.Default.Deployable_Oil_Tracer_Color = Color_Picker.Color;
            }
        }

        private void Deployable_Landmine_Tracer_Color_Click(object sender, EventArgs e) {
            if (Color_Picker.ShowDialog() == DialogResult.OK) {
                Deployable_Landmine_Tracer_Color.BackColor = Color_Picker.Color;
                Settings.Default.Deployable_Landmine_Tracer_Color = Color_Picker.Color;
            }
        }

        private void Deployable_Bear_Trap_Tracer_Color_Click(object sender, EventArgs e) {
            if (Color_Picker.ShowDialog() == DialogResult.OK) {
                Deployable_Bear_Trap_Tracer_Color.BackColor = Color_Picker.Color;
                Settings.Default.Deployable_Bear_Trap_Tracer_Color = Color_Picker.Color;
            }
        }

        private void Deployable_Stash_Tracer_Color_Click(object sender, EventArgs e) {
            if (Color_Picker.ShowDialog() == DialogResult.OK) {
                Deployable_Stash_Tracer_Color.BackColor = Color_Picker.Color;
                Settings.Default.Deployable_Stash_Tracer_Color = Color_Picker.Color;
            }
        }

        private void Deployable_Box_Tracer_Color_Click(object sender, EventArgs e) {
            if (Color_Picker.ShowDialog() == DialogResult.OK) {
                Deployable_Box_Tracer_Color.BackColor = Color_Picker.Color;
                Settings.Default.Deployable_Box_Tracer_Color = Color_Picker.Color;
            }
        }

        private void Deployable_Large_Box_Tracer_Color_Click(object sender, EventArgs e) {
            if (Color_Picker.ShowDialog() == DialogResult.OK) {
                Deployable_Large_Box_Tracer_Color.BackColor = Color_Picker.Color;
                Settings.Default.Deployable_Large_Box_Tracer_Color = Color_Picker.Color;
            }
        }

        private void Deployable_Large_Box_Box_Color_Click(object sender, EventArgs e) {
            if (Color_Picker.ShowDialog() == DialogResult.OK) {
                Deployable_Large_Box_Box_Color.BackColor = Color_Picker.Color;
                Settings.Default.Deployable_Large_Box_Box_Color = Color_Picker.Color;
            }
        }

        private void Deployable_Box_Box_Color_Click(object sender, EventArgs e) {
            if (Color_Picker.ShowDialog() == DialogResult.OK) {
                Deployable_Box_Box_Color.BackColor = Color_Picker.Color;
                Settings.Default.Deployable_Box_Box_Color = Color_Picker.Color;
            }
        }

        private void Deployable_Stash_Box_Color_Click(object sender, EventArgs e) {
            if (Color_Picker.ShowDialog() == DialogResult.OK) {
                Deployable_Stash_Box_Color.BackColor = Color_Picker.Color;
                Settings.Default.Deployable_Stash_Box_Color = Color_Picker.Color;
            }
        }

        private void Deployable_Bear_Trap_Box_Color_Click(object sender, EventArgs e) {
            if (Color_Picker.ShowDialog() == DialogResult.OK) {
                Deployable_Bear_Trap_Box_Color.BackColor = Color_Picker.Color;
                Settings.Default.Deployable_Bear_Trap_Box_Color = Color_Picker.Color;
            }
        }

        private void Deployable_Landmine_Box_Color_Click(object sender, EventArgs e) {
            if (Color_Picker.ShowDialog() == DialogResult.OK) {
                Deployable_Landmine_Box_Color.BackColor = Color_Picker.Color;
                Settings.Default.Deployable_Landmine_Box_Color = Color_Picker.Color;
            }
        }

        private void Deployable_Oil_Box_Color_Click(object sender, EventArgs e) {
            if (Color_Picker.ShowDialog() == DialogResult.OK) {
                Deployable_Oil_Box_Color.BackColor = Color_Picker.Color;
                Settings.Default.Deployable_Oil_Box_Color = Color_Picker.Color;
            }
        }

        private void Deployable_Fridge_Box_Color_Click(object sender, EventArgs e) {
            if (Color_Picker.ShowDialog() == DialogResult.OK) {
                Deployable_Fridge_Box_Color.BackColor = Color_Picker.Color;
                Settings.Default.Deployable_Fridge_Box_Color = Color_Picker.Color;
            }
        }

        private void Deployable_Large_Furnace_Box_Color_Click(object sender, EventArgs e) {
            if (Color_Picker.ShowDialog() == DialogResult.OK) {
                Deployable_Large_Furnace_Box_Color.BackColor = Color_Picker.Color;
                Settings.Default.Deployable_Large_Furnace_Box_Color = Color_Picker.Color;
            }
        }

        private void Deployable_Furnace_Box_Color_Click(object sender, EventArgs e) {
            if (Color_Picker.ShowDialog() == DialogResult.OK) {
                Deployable_Furnace_Box_Color.BackColor = Color_Picker.Color;
                Settings.Default.Deployable_Furnace_Box_Color = Color_Picker.Color;
            }
        }

        private void Deployable_AutoTurret_Box_Color_Click(object sender, EventArgs e) {
            if (Color_Picker.ShowDialog() == DialogResult.OK) {
                Deployable_AutoTurret_Box_Color.BackColor = Color_Picker.Color;
                Settings.Default.Deployable_AutoTurret_Box_Color = Color_Picker.Color;
            }
        }

        private void Deployable_Sleeping_Bag_Box_Color_Click(object sender, EventArgs e) {
            if (Color_Picker.ShowDialog() == DialogResult.OK) {
                Deployable_Sleeping_Bag_Box_Color.BackColor = Color_Picker.Color;
                Settings.Default.Deployable_Sleeping_Bag_Box_Color = Color_Picker.Color;
            }
        }

        private void Deployable_TC_Box_Color_Click(object sender, EventArgs e) {
            if (Color_Picker.ShowDialog() == DialogResult.OK) {
                Deployable_TC_Box_Color.BackColor = Color_Picker.Color;
                Settings.Default.Deployable_TC_Box_Color = Color_Picker.Color;
            }
        }

        private void Deployable_Quarry_Tracer_Check_CheckedChanged(object sender, EventArgs e) {
            Settings.Default.Deployable_Quarry_Tracer_Check = Deployable_Quarry_Tracer_Check.Checked;
        }

        private void Plant_Corn_Box_Color_Click(object sender, EventArgs e) {
            if (Color_Picker.ShowDialog() == DialogResult.OK) {
                Plant_Corn_Box_Color.BackColor = Color_Picker.Color;
                Settings.Default.Plant_Corn_Box_Color = Color_Picker.Color;
            }
        }

        private void Plant_Pumpkin_Tracer_Check_CheckedChanged(object sender, EventArgs e) {
            Settings.Default.Plant_Pumpkin_Tracer_Check = Plant_Pumpkin_Tracer_Check.Checked;
        }

        private void Plant_Hemp_Tracer_Check_CheckedChanged(object sender, EventArgs e) {
            Settings.Default.Plant_Hemp_Tracer_Check = Plant_Hemp_Tracer_Check.Checked;
        }

        private void Plant_Mushroom_Tracer_Check_CheckedChanged(object sender, EventArgs e) {
            Settings.Default.Plant_Mushroom_Tracer_Check = Plant_Mushroom_Tracer_Check.Checked;
        }

        private void Plant_Mushroom_Box_Check_CheckedChanged(object sender, EventArgs e) {
            Settings.Default.Plant_Mushroom_Box_Check = Plant_Mushroom_Box_Check.Checked;
        }

        private void Plant_Hemp_Box_Check_CheckedChanged(object sender, EventArgs e) {
            Settings.Default.Plant_Hemp_Box_Check = Plant_Hemp_Box_Check.Checked;
        }

        private void Plant_Pumpkin_Box_Check_CheckedChanged(object sender, EventArgs e) {
            Settings.Default.Plant_Pumpkin_Box_Check = Plant_Pumpkin_Box_Check.Checked;
        }

        private void Plant_Corn_Box_Check_CheckedChanged(object sender, EventArgs e) {
            Settings.Default.Plant_Corn_Box_Check = Plant_Corn_Box_Check.Checked;
        }

        private void Plant_Corn_Tracer_Color_Click(object sender, EventArgs e) {
            if (Color_Picker.ShowDialog() == DialogResult.OK) {
                Plant_Corn_Tracer_Color.BackColor = Color_Picker.Color;
                Settings.Default.Plant_Corn_Tracer_Color = Color_Picker.Color;
            }
        }

        private void Plant_Pumpkin_Tracer_Color_Click(object sender, EventArgs e) {
            if (Color_Picker.ShowDialog() == DialogResult.OK) {
                Plant_Pumpkin_Tracer_Color.BackColor = Color_Picker.Color;
                Settings.Default.Plant_Pumpkin_Tracer_Color = Color_Picker.Color;
            }
        }

        private void Plant_Hemp_Tracer_Color_Click(object sender, EventArgs e) {
            if (Color_Picker.ShowDialog() == DialogResult.OK) {
                Plant_Hemp_Tracer_Color.BackColor = Color_Picker.Color;
                Settings.Default.Plant_Hemp_Tracer_Color = Color_Picker.Color;
            }
        }

        private void Plant_Mushroom_Tracer_Color_Click(object sender, EventArgs e) {
            if (Color_Picker.ShowDialog() == DialogResult.OK) {
                Plant_Mushroom_Tracer_Color.BackColor = Color_Picker.Color;
                Settings.Default.Plant_Mushroom_Tracer_Color = Color_Picker.Color;
            }
        }

        private void Plant_Mushroom_Box_Color_Click(object sender, EventArgs e) {
            if (Color_Picker.ShowDialog() == DialogResult.OK) {
                Plant_Mushroom_Box_Color.BackColor = Color_Picker.Color;
                Settings.Default.Plant_Mushroom_Box_Color = Color_Picker.Color;
            }
        }

        private void Plant_Hemp_Box_Color_Click(object sender, EventArgs e) {
            if (Color_Picker.ShowDialog() == DialogResult.OK) {
                Plant_Hemp_Box_Color.BackColor = Color_Picker.Color;
                Settings.Default.Plant_Hemp_Box_Color = Color_Picker.Color;
            }
        }

        private void Plant_Pumpkin_Box_Color_Click(object sender, EventArgs e) {
            if (Color_Picker.ShowDialog() == DialogResult.OK) {
                Plant_Pumpkin_Box_Color.BackColor = Color_Picker.Color;
                Settings.Default.Plant_Pumpkin_Box_Color = Color_Picker.Color;
            }
        }

        private void Plant_Corn_Tracer_Check_CheckedChanged(object sender, EventArgs e) {
            Settings.Default.Plant_Corn_Tracer_Check = Plant_Corn_Tracer_Check.Checked;
        }

        private void Resource_Rock_Collectable_Tracer_Check_CheckedChanged(object sender, EventArgs e) {
            Settings.Default.Resource_Rock_Collectable_Tracer_Check = Resource_Rock_Collectable_Tracer_Check.Checked;
        }

        private void Resource_Wood_Collectable_Tracer_Check_CheckedChanged(object sender, EventArgs e) {
            Settings.Default.Resource_Wood_Collectable_Tracer_Check = Resource_Wood_Collectable_Tracer_Check.Checked;
        }

        private void Resource_Sulfur_Collectable_Tracer_Check_CheckedChanged(object sender, EventArgs e) {
            Settings.Default.Resource_Sulfur_Collectable_Tracer_Check = Resource_Sulfur_Collectable_Tracer_Check.Checked;
        }

        private void Resource_Metal_Collectable_Tracer_Check_CheckedChanged(object sender, EventArgs e) {
            Settings.Default.Resource_Metal_Collectable_Tracer_Check = Resource_Metal_Collectable_Tracer_Check.Checked;
        }

        private void Resource_Sulfur_Node_Tracer_Check_CheckedChanged(object sender, EventArgs e) {
            Settings.Default.Resource_Sulfur_Node_Tracer_Check = Resource_Sulfur_Node_Tracer_Check.Checked;
        }

        private void Resource_Metal_Node_Tracer_Check_CheckedChanged(object sender, EventArgs e) {
            Settings.Default.Resource_Metal_Node_Tracer_Check = Resource_Metal_Node_Tracer_Check.Checked;
        }

        private void Resource_Stone_Node_Tracer_Check_CheckedChanged(object sender, EventArgs e) {
            Settings.Default.Resource_Stone_Node_Tracer_Check = Resource_Stone_Node_Tracer_Check.Checked;
        }

        private void Resource_Stone_Node_Box_Check_CheckedChanged(object sender, EventArgs e) {
            Settings.Default.Resource_Stone_Node_Box_Check = Resource_Stone_Node_Box_Check.Checked;
        }

        private void Resource_Metal_Node_Box_Check_CheckedChanged(object sender, EventArgs e) {
            Settings.Default.Resource_Metal_Node_Box_Check = Resource_Metal_Node_Box_Check.Checked;
        }

        private void Resource_Sulfur_Node_Box_Check_CheckedChanged(object sender, EventArgs e) {
            Settings.Default.Resource_Sulfur_Node_Box_Check = Resource_Sulfur_Node_Box_Check.Checked;
        }

        private void Resource_Metal_Collectable_Box_Check_CheckedChanged(object sender, EventArgs e) {
            Settings.Default.Resource_Metal_Collectable_Box_Check = Resource_Metal_Collectable_Box_Check.Checked;
        }

        private void Resource_Sulfur_Collectable_Box_Check_CheckedChanged(object sender, EventArgs e) {
            Settings.Default.Resource_Sulfur_Collectable_Box_Check = Resource_Sulfur_Collectable_Box_Check.Checked;
        }

        private void Resource_Wood_Collectable_Box_Check_CheckedChanged(object sender, EventArgs e) {
            Settings.Default.Resource_Wood_Collectable_Box_Check = Resource_Wood_Collectable_Box_Check.Checked;
        }

        private void Resource_Rock_Collectable_Box_Check_CheckedChanged(object sender, EventArgs e) {
            Settings.Default.Resource_Rock_Collectable_Box_Check = Resource_Rock_Collectable_Box_Check.Checked;
        }

        private void Resource_Rock_Collectable_Tracer_Color_Click(object sender, EventArgs e) {
            if (Color_Picker.ShowDialog() == DialogResult.OK) {
                Resource_Rock_Collectable_Tracer_Color.BackColor = Color_Picker.Color;
                Settings.Default.Resource_Rock_Collectable_Tracer_Color = Color_Picker.Color;
            }
        }

        private void Resource_Wood_Collectable_Tracer_Color_Click(object sender, EventArgs e) {
            if (Color_Picker.ShowDialog() == DialogResult.OK) {
                Resource_Wood_Collectable_Tracer_Color.BackColor = Color_Picker.Color;
                Settings.Default.Resource_Wood_Collectable_Tracer_Color = Color_Picker.Color;
            }
        }

        private void Resource_Wood_Collectable_Box_Color_Click(object sender, EventArgs e) {
            if (Color_Picker.ShowDialog() == DialogResult.OK) {
                Resource_Wood_Collectable_Box_Color.BackColor = Color_Picker.Color;
                Settings.Default.Resource_Wood_Collectable_Box_Color = Color_Picker.Color;
            }
        }

        private void Resource_Rock_Collectable_Box_Color_Click(object sender, EventArgs e) {
            if (Color_Picker.ShowDialog() == DialogResult.OK) {
                Resource_Rock_Collectable_Box_Color.BackColor = Color_Picker.Color;
                Settings.Default.Resource_Rock_Collectable_Box_Color = Color_Picker.Color;
            }
        }

        private void Resource_Sulfur_Collectable_Box_Color_Click(object sender, EventArgs e) {
            if (Color_Picker.ShowDialog() == DialogResult.OK) {
                Resource_Sulfur_Collectable_Box_Color.BackColor = Color_Picker.Color;
                Settings.Default.Resource_Sulfur_Collectable_Box_Color = Color_Picker.Color;
            }
        }

        private void Resource_Sulfur_Collectable_Tracer_Color_Click(object sender, EventArgs e) {
            if (Color_Picker.ShowDialog() == DialogResult.OK) {
                Resource_Sulfur_Collectable_Tracer_Color.BackColor = Color_Picker.Color;
                Settings.Default.Resource_Sulfur_Collectable_Tracer_Color = Color_Picker.Color;
            }
        }

        private void Resource_Metal_Collectable_Tracer_Color_Click(object sender, EventArgs e) {
            if (Color_Picker.ShowDialog() == DialogResult.OK) {
                Resource_Metal_Collectable_Tracer_Color.BackColor = Color_Picker.Color;
                Settings.Default.Resource_Metal_Collectable_Tracer_Color = Color_Picker.Color;
            }
        }

        private void Resource_Metal_Collectable_Box_Color_Click(object sender, EventArgs e) {
            if (Color_Picker.ShowDialog() == DialogResult.OK) {
                Resource_Metal_Collectable_Box_Color.BackColor = Color_Picker.Color;
                Settings.Default.Resource_Metal_Collectable_Box_Color = Color_Picker.Color;
            }
        }

        private void Resource_Sulfur_Node_Box_Color_Click(object sender, EventArgs e) {
            if (Color_Picker.ShowDialog() == DialogResult.OK) {
                Resource_Sulfur_Node_Box_Color.BackColor = Color_Picker.Color;
                Settings.Default.Resource_Sulfur_Node_Box_Color = Color_Picker.Color;
            }
        }

        private void Resource_Sulfur_Node_Tracer_Color_Click(object sender, EventArgs e) {
            if (Color_Picker.ShowDialog() == DialogResult.OK) {
                Resource_Sulfur_Node_Tracer_Color.BackColor = Color_Picker.Color;
                Settings.Default.Resource_Sulfur_Node_Tracer_Color = Color_Picker.Color;
            }
        }

        private void Resource_Metal_Node_Tracer_Color_Click(object sender, EventArgs e) {
            if (Color_Picker.ShowDialog() == DialogResult.OK) {
                Resource_Metal_Node_Tracer_Color.BackColor = Color_Picker.Color;
                Settings.Default.Resource_Metal_Node_Tracer_Color = Color_Picker.Color;
            }
        }

        private void Resource_Metal_Node_Box_Color_Click(object sender, EventArgs e) {
            if (Color_Picker.ShowDialog() == DialogResult.OK) {
                Resource_Metal_Node_Box_Color.BackColor = Color_Picker.Color;
                Settings.Default.Resource_Metal_Node_Box_Color = Color_Picker.Color;
            }
        }

        private void Resource_Stone_Node_Box_Color_Click(object sender, EventArgs e) {
            if (Color_Picker.ShowDialog() == DialogResult.OK) {
                Resource_Stone_Node_Box_Color.BackColor = Color_Picker.Color;
                Settings.Default.Resource_Stone_Node_Box_Color = Color_Picker.Color;
            }
        }

        private void Resource_Stone_Node_Tracer_Color_Click(object sender, EventArgs e) {
            if (Color_Picker.ShowDialog() == DialogResult.OK) {
                Resource_Stone_Node_Tracer_Color.BackColor = Color_Picker.Color;
                Settings.Default.Resource_Stone_Node_Tracer_Color = Color_Picker.Color;
            }
        }

        private void Barrel_Loot_Barrel_Box_Color_Click(object sender, EventArgs e) {
            if (Color_Picker.ShowDialog() == DialogResult.OK) {
                Barrel_Loot_Barrel_Box_Color.BackColor = Color_Picker.Color;
                Settings.Default.Barrel_Loot_Barrel_Box_Color = Color_Picker.Color;
            }
        }

        private void Barrel_Food_Box_Tracer_Color_Click(object sender, EventArgs e) {
            if (Color_Picker.ShowDialog() == DialogResult.OK) {
                Barrel_Food_Box_Tracer_Color.BackColor = Color_Picker.Color;
                Settings.Default.Barrel_Food_Box_Tracer_Color = Color_Picker.Color;
            }
        }

        private void Barrel_Tool_Crate_Tracer_Color_Click(object sender, EventArgs e) {
            if (Color_Picker.ShowDialog() == DialogResult.OK) {
                Barrel_Tool_Crate_Tracer_Color.BackColor = Color_Picker.Color;
                Settings.Default.Barrel_Tool_Crate_Tracer_Color = Color_Picker.Color;
            }
        }

        private void Barrel_Med_Crate_Tracer_Color_Click(object sender, EventArgs e) {
            if (Color_Picker.ShowDialog() == DialogResult.OK) {
                Barrel_Med_Crate_Tracer_Color.BackColor = Color_Picker.Color;
                Settings.Default.Barrel_Med_Crate_Tracer_Color = Color_Picker.Color;
            }
        }

        private void Barrel_Food_Crate_Tracer_Color_Click(object sender, EventArgs e) {
            if (Color_Picker.ShowDialog() == DialogResult.OK) {
                Barrel_Food_Crate_Tracer_Color.BackColor = Color_Picker.Color;
                Settings.Default.Barrel_Food_Crate_Tracer_Color = Color_Picker.Color;
            }
        }

        private void Barrel_Mine_Crate_Tracer_Color_Click(object sender, EventArgs e) {
            if (Color_Picker.ShowDialog() == DialogResult.OK) {
                Barrel_Mine_Crate_Tracer_Color.BackColor = Color_Picker.Color;
                Settings.Default.Barrel_Mine_Crate_Tracer_Color = Color_Picker.Color;
            }
        }

        private void Barrel_Crate_Tracer_Color_Click(object sender, EventArgs e) {
            if (Color_Picker.ShowDialog() == DialogResult.OK) {
                Barrel_Crate_Tracer_Color.BackColor = Color_Picker.Color;
                Settings.Default.Barrel_Crate_Tracer_Color = Color_Picker.Color;
            }
        }

        private void Barrel_Trash_Pile_Tracer_Color_Click(object sender, EventArgs e) {
            if (Color_Picker.ShowDialog() == DialogResult.OK) {
                Barrel_Trash_Pile_Tracer_Color.BackColor = Color_Picker.Color;
                Settings.Default.Barrel_Trash_Pile_Tracer_Color = Color_Picker.Color;
            }
        }

        private void Barrel_Oil_Barrel_Tracer_Color_Click(object sender, EventArgs e) {
            if (Color_Picker.ShowDialog() == DialogResult.OK) {
                Barrel_Oil_Barrel_Tracer_Color.BackColor = Color_Picker.Color;
                Settings.Default.Barrel_Oil_Barrel_Tracer_Color = Color_Picker.Color;
            }
        }

        private void Barrel_Loot_Barrel_Tracer_Color_Click(object sender, EventArgs e) {
            if (Color_Picker.ShowDialog() == DialogResult.OK) {
                Barrel_Loot_Barrel_Tracer_Color.BackColor = Color_Picker.Color;
                Settings.Default.Barrel_Loot_Barrel_Tracer_Color = Color_Picker.Color;
            }
        }

        private void Barrel_Tool_Crate_Box_Color_Click(object sender, EventArgs e) {
            if (Color_Picker.ShowDialog() == DialogResult.OK) {
                Barrel_Tool_Crate_Box_Color.BackColor = Color_Picker.Color;
                Settings.Default.Barrel_Tool_Crate_Box_Color = Color_Picker.Color;
            }
        }

        private void Barrel_Med_Crate_Box_Color_Click(object sender, EventArgs e) {
            if (Color_Picker.ShowDialog() == DialogResult.OK) {
                Barrel_Med_Crate_Box_Color.BackColor = Color_Picker.Color;
                Settings.Default.Barrel_Med_Crate_Box_Color = Color_Picker.Color;
            }
        }

        private void Barrel_Food_Crate_Box_Color_Click(object sender, EventArgs e) {
            if (Color_Picker.ShowDialog() == DialogResult.OK) {
                Barrel_Food_Crate_Box_Color.BackColor = Color_Picker.Color;
                Settings.Default.Barrel_Food_Crate_Box_Color = Color_Picker.Color;
            }
        }

        private void Barrel_Mine_Crate_Box_Color_Click(object sender, EventArgs e) {
            if (Color_Picker.ShowDialog() == DialogResult.OK) {
                Barrel_Mine_Crate_Box_Color.BackColor = Color_Picker.Color;
                Settings.Default.Barrel_Mine_Crate_Box_Color = Color_Picker.Color;
            }
        }

        private void Barrel_Crate_Box_Color_Click(object sender, EventArgs e) {
            if (Color_Picker.ShowDialog() == DialogResult.OK) {
                Barrel_Crate_Box_Color.BackColor = Color_Picker.Color;
                Settings.Default.Barrel_Crate_Box_Color = Color_Picker.Color;
            }
        }

        private void Barrel_Trash_Pile_Box_Color_Click(object sender, EventArgs e) {
            if (Color_Picker.ShowDialog() == DialogResult.OK) {
                Barrel_Trash_Pile_Box_Color.BackColor = Color_Picker.Color;
                Settings.Default.Barrel_Trash_Pile_Box_Color = Color_Picker.Color;
            }
        }

        private void Barrel_Oil_Barrel_Box_Color_Click(object sender, EventArgs e) {
            if (Color_Picker.ShowDialog() == DialogResult.OK) {
                Barrel_Oil_Barrel_Box_Color.BackColor = Color_Picker.Color;
                Settings.Default.Barrel_Oil_Barrel_Box_Color = Color_Picker.Color;
            }
        }

        private void Barrel_Food_Box_Box_Color_Click(object sender, EventArgs e) {
            if (Color_Picker.ShowDialog() == DialogResult.OK) {
                Barrel_Food_Box_Box_Color.BackColor = Color_Picker.Color;
                Settings.Default.Barrel_Food_Box_Box_Color = Color_Picker.Color;
            }
        }

        private void Barrel_Loot_Barrel_Tracer_Check_CheckedChanged(object sender, EventArgs e) {
            Settings.Default.Barrel_Loot_Barrel_Tracer_Check = Barrel_Loot_Barrel_Tracer_Check.Checked;
        }

        private void Barrel_Oil_Barrel_Tracer_Check_CheckedChanged(object sender, EventArgs e) {
            Settings.Default.Barrel_Oil_Barrel_Tracer_Check = Barrel_Oil_Barrel_Tracer_Check.Checked;
        }

        private void Barrel_Trash_Pile_Tracer_Check_CheckedChanged(object sender, EventArgs e) {
            Settings.Default.Barrel_Trash_Pile_Tracer_Check = Barrel_Trash_Pile_Tracer_Check.Checked;
        }

        private void Barrel_Crate_Tracer_Check_CheckedChanged(object sender, EventArgs e) {
            Settings.Default.Barrel_Crate_Tracer_Check = Barrel_Crate_Tracer_Check.Checked;
        }

        private void Barrel_Mine_Crate_Tracer_Check_CheckedChanged(object sender, EventArgs e) {
            Settings.Default.Barrel_Mine_Crate_Tracer_Check = Barrel_Mine_Crate_Tracer_Check.Checked;
        }

        private void Barrel_Food_Crate_Tracer_Check_CheckedChanged(object sender, EventArgs e) {
            Settings.Default.Barrel_Food_Crate_Tracer_Check = Barrel_Food_Crate_Tracer_Check.Checked;
        }

        private void Barrel_Med_Crate_Tracer_Check_CheckedChanged(object sender, EventArgs e) {
            Settings.Default.Barrel_Med_Crate_Tracer_Check = Barrel_Med_Crate_Tracer_Check.Checked;
        }

        private void Barrel_Tool_Crate_Tracer_Check_CheckedChanged(object sender, EventArgs e) {
            Settings.Default.Barrel_Tool_Crate_Tracer_Check = Barrel_Tool_Crate_Tracer_Check.Checked;
        }

        private void Barrel_Food_Box_Tracer_Check_CheckedChanged(object sender, EventArgs e) {
            Settings.Default.Barrel_Food_Box_Tracer_Check = Barrel_Food_Box_Tracer_Check.Checked;
        }

        private void Barrel_Food_Box_Box_Check_CheckedChanged(object sender, EventArgs e) {
            Settings.Default.Barrel_Food_Box_Box_Check = Barrel_Food_Box_Box_Check.Checked;
        }

        private void Barrel_Tool_Crate_Box_Check_CheckedChanged(object sender, EventArgs e) {
            Settings.Default.Barrel_Tool_Crate_Box_Check = Barrel_Tool_Crate_Box_Check.Checked;
        }

        private void Barrel_Med_Crate_Box_Check_CheckedChanged(object sender, EventArgs e) {
            Settings.Default.Barrel_Med_Crate_Box_Check = Barrel_Med_Crate_Box_Check.Checked;
        }

        private void Barrel_Food_Crate_Box_Check_CheckedChanged(object sender, EventArgs e) {
            Settings.Default.Barrel_Food_Crate_Box_Check = Barrel_Food_Crate_Box_Check.Checked;
        }

        private void Barrel_Mine_Crate_Box_Check_CheckedChanged(object sender, EventArgs e) {
            Settings.Default.Barrel_Mine_Crate_Box_Check = Barrel_Mine_Crate_Box_Check.Checked;
        }

        private void Barrel_Crate_Box_Check_CheckedChanged(object sender, EventArgs e) {
            Settings.Default.Barrel_Crate_Box_Check = Barrel_Crate_Box_Check.Checked;
        }

        private void Barrel_Trash_Pile_Box_Check_CheckedChanged(object sender, EventArgs e) {
            Settings.Default.Barrel_Trash_Pile_Box_Check = Barrel_Trash_Pile_Box_Check.Checked;
        }

        private void Barrel_Oil_Barrel_Box_Check_CheckedChanged(object sender, EventArgs e) {
            Settings.Default.Barrel_Oil_Barrel_Box_Check = Barrel_Oil_Barrel_Box_Check.Checked;
        }

        private void Barrel_Loot_Barrel_Box_Check_CheckedChanged(object sender, EventArgs e) {
            Settings.Default.Barrel_Loot_Barrel_Box_Check = Barrel_Loot_Barrel_Box_Check.Checked;
        }

        private void Box_Check_CheckedChanged(object sender, EventArgs e) {
            Settings.Default.Box_Check = Box_Check.Checked;
        }

        private void Distance_Text_Box_TextChanged(object sender, EventArgs e) {
            if (int.TryParse(Distance_Text_Box.Text, out int result)) {
                Settings.Default.MaxDistance = result;
            }
        }

        private void Temp_Text_Box_TextChanged(object sender, EventArgs e) {
            if (float.TryParse(Temp_Text_Box.Text, out float result)) {
                Settings.Default.Temp = result;
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e) {
            if (float.TryParse(textBox1.Text, out float result)) {
                Settings.Default.Temp1 = result;
            }
        }
    }
}
