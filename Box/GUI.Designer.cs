using System.Windows.Forms;

namespace Box {
    public partial class GUI {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(GUI));
            this.SettingTabs = new System.Windows.Forms.TabControl();
            this.Setup_TAB = new System.Windows.Forms.TabPage();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.Y = new System.Windows.Forms.GroupBox();
            this.Temp_Text_Box = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.Distance_Text_Box = new System.Windows.Forms.TextBox();
            this.FOVBox = new System.Windows.Forms.GroupBox();
            this.FOV_Text_Box = new System.Windows.Forms.TextBox();
            this.Box_Check = new System.Windows.Forms.CheckBox();
            this.Misc_Check = new System.Windows.Forms.CheckBox();
            this.Deployables_Check = new System.Windows.Forms.CheckBox();
            this.Tracer_Check = new System.Windows.Forms.CheckBox();
            this.Reset = new System.Windows.Forms.Button();
            this.Radar_Check = new System.Windows.Forms.CheckBox();
            this.Barrels_Check = new System.Windows.Forms.CheckBox();
            this.Crosshair_Check = new System.Windows.Forms.CheckBox();
            this.Animals_Check = new System.Windows.Forms.CheckBox();
            this.Resources_Check = new System.Windows.Forms.CheckBox();
            this.Plants_Check = new System.Windows.Forms.CheckBox();
            this.Players_Check = new System.Windows.Forms.CheckBox();
            this.Server_PORT_Box = new System.Windows.Forms.GroupBox();
            this.Server_PORT_Text = new System.Windows.Forms.TextBox();
            this.Server_IP_Box = new System.Windows.Forms.GroupBox();
            this.Server_IP_Text = new System.Windows.Forms.TextBox();
            this.StartButton = new System.Windows.Forms.Button();
            this.Radar_TAB = new System.Windows.Forms.TabPage();
            this.WaypointBox = new System.Windows.Forms.GroupBox();
            this.WaypointGrid = new System.Windows.Forms.DataGridView();
            this.O = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.WaypointName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.X = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Z = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Color = new System.Windows.Forms.DataGridViewButtonColumn();
            this.PlayerData = new System.Data.DataSet();
            this.dataTable1 = new System.Data.DataTable();
            this.dataColumn1 = new System.Data.DataColumn();
            this.dataColumn2 = new System.Data.DataColumn();
            this.dataColumn3 = new System.Data.DataColumn();
            this.dataColumn4 = new System.Data.DataColumn();
            this.ZoomBox = new System.Windows.Forms.GroupBox();
            this.ZoomTrackBar = new System.Windows.Forms.TrackBar();
            this.Crosshair_TAB = new System.Windows.Forms.TabPage();
            this.Type_Box = new System.Windows.Forms.ComboBox();
            this.Crosshair_Thick_Text = new System.Windows.Forms.TextBox();
            this.Crosshair_Size_Text = new System.Windows.Forms.TextBox();
            this.Crosshair_Type_Label = new System.Windows.Forms.Label();
            this.Crosshair_Color = new System.Windows.Forms.Button();
            this.Crosshair_Thick_Label = new System.Windows.Forms.Label();
            this.Crosshair_Size_Label = new System.Windows.Forms.Label();
            this.Crosshair_Color_Label = new System.Windows.Forms.Label();
            this.Players_TAB = new System.Windows.Forms.TabPage();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.button25 = new System.Windows.Forms.Button();
            this.button24 = new System.Windows.Forms.Button();
            this.button21 = new System.Windows.Forms.Button();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.checkBox3 = new System.Windows.Forms.CheckBox();
            this.checkBox5 = new System.Windows.Forms.CheckBox();
            this.checkBox7 = new System.Windows.Forms.CheckBox();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.button15 = new System.Windows.Forms.Button();
            this.button12 = new System.Windows.Forms.Button();
            this.button9 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.label10 = new System.Windows.Forms.Label();
            this.PlayerInvBeltLabel = new System.Windows.Forms.Label();
            this.PlayerInvWearLabel = new System.Windows.Forms.Label();
            this.PlayerHeldItemLabel = new System.Windows.Forms.Label();
            this.PlayerInventoryBeltCheck = new System.Windows.Forms.CheckBox();
            this.PlayerInventoryWearCheck = new System.Windows.Forms.CheckBox();
            this.PlayerHeldItem = new System.Windows.Forms.CheckBox();
            this.checkBox8 = new System.Windows.Forms.CheckBox();
            this.checkBox10 = new System.Windows.Forms.CheckBox();
            this.checkBox12 = new System.Windows.Forms.CheckBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.button18 = new System.Windows.Forms.Button();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.Player_Loot_Corpse_Box_Color = new System.Windows.Forms.Button();
            this.Player_Loot_Corpse_Tracer_Color = new System.Windows.Forms.Button();
            this.Player_Enemy_Box_Color = new System.Windows.Forms.Button();
            this.Player_Enemy_Tracer_Color = new System.Windows.Forms.Button();
            this.Player_Friend_Box_Color = new System.Windows.Forms.Button();
            this.Player_Friend_Tracer_Color = new System.Windows.Forms.Button();
            this.Player_Crouching_Box_Color = new System.Windows.Forms.Button();
            this.Player_Crouching_Tracer_Color = new System.Windows.Forms.Button();
            this.Player_Sprinting_Box_Color = new System.Windows.Forms.Button();
            this.Player_Sprinting_Tracer_Color = new System.Windows.Forms.Button();
            this.Player_Aiming_Box_Color = new System.Windows.Forms.Button();
            this.Player_Aiming_Tracer_Color = new System.Windows.Forms.Button();
            this.Player_Sleeping_Box_Color = new System.Windows.Forms.Button();
            this.Player_Sleeping_Tracer_Color = new System.Windows.Forms.Button();
            this.Player_Crouching_Box_Check = new System.Windows.Forms.CheckBox();
            this.Player_Sleeping_Box_Check = new System.Windows.Forms.CheckBox();
            this.Player_Sprinting_Box_Check = new System.Windows.Forms.CheckBox();
            this.Player_Sleeping_Tracer_Check = new System.Windows.Forms.CheckBox();
            this.PlayerSleepingLabel = new System.Windows.Forms.Label();
            this.Player_Crouching_Tracer_Check = new System.Windows.Forms.CheckBox();
            this.Player_Awake_Radar_Color = new System.Windows.Forms.Button();
            this.Player_Crouching_Radar_Color = new System.Windows.Forms.Button();
            this.Player_Loot_Corpse_Radar_Color = new System.Windows.Forms.Button();
            this.Player_Awake_Box_Check = new System.Windows.Forms.CheckBox();
            this.Player_Enemy_Radar_Color = new System.Windows.Forms.Button();
            this.Player_Sprinting_Radar_Color = new System.Windows.Forms.Button();
            this.Player_Friend_Radar_Color = new System.Windows.Forms.Button();
            this.Player_Aiming_Radar_Color = new System.Windows.Forms.Button();
            this.Player_Crouching_Radar_Check = new System.Windows.Forms.CheckBox();
            this.Player_Awake_Tracer_Check = new System.Windows.Forms.CheckBox();
            this.Player_Sleeping_Radar_Color = new System.Windows.Forms.Button();
            this.Player_Awake_Radar_Check = new System.Windows.Forms.CheckBox();
            this.PlayerAwakeLabel = new System.Windows.Forms.Label();
            this.Player_Awake_Tracer_Color = new System.Windows.Forms.Button();
            this.Player_Sprinting_Radar_Check = new System.Windows.Forms.CheckBox();
            this.Player_Awake_Box_Color = new System.Windows.Forms.Button();
            this.PlayerAimingLabel = new System.Windows.Forms.Label();
            this.Player_Aiming_Radar_Check = new System.Windows.Forms.CheckBox();
            this.Player_Loot_Corpse_Radar_Check = new System.Windows.Forms.CheckBox();
            this.Player_Sleeping_Radar_Check = new System.Windows.Forms.CheckBox();
            this.Player_Enemy_Radar_Check = new System.Windows.Forms.CheckBox();
            this.Player_Friend_Radar_Check = new System.Windows.Forms.CheckBox();
            this.Player_Aiming_Tracer_Check = new System.Windows.Forms.CheckBox();
            this.Player_Aiming_Box_Check = new System.Windows.Forms.CheckBox();
            this.Player_Sprinting_Tracer_Check = new System.Windows.Forms.CheckBox();
            this.PlayerSprintingLabel = new System.Windows.Forms.Label();
            this.PlayerCrouchingLabel = new System.Windows.Forms.Label();
            this.PlayerFriendsLabel = new System.Windows.Forms.Label();
            this.PlayerEnemyLabel = new System.Windows.Forms.Label();
            this.PlayerLootCorpseLabel = new System.Windows.Forms.Label();
            this.Player_Friend_Tracer_Check = new System.Windows.Forms.CheckBox();
            this.Player_Friend_Box_Check = new System.Windows.Forms.CheckBox();
            this.Player_Enemy_Box_Check = new System.Windows.Forms.CheckBox();
            this.Player_Enemy_Tracer_Check = new System.Windows.Forms.CheckBox();
            this.Player_Loot_Corpse_Tracer_Check = new System.Windows.Forms.CheckBox();
            this.Player_Loot_Corpse_Box_Check = new System.Windows.Forms.CheckBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.Animals_TAB = new System.Windows.Forms.TabPage();
            this.tableLayoutPanel4 = new System.Windows.Forms.TableLayoutPanel();
            this.Animals_Wolf_Radar_Color = new System.Windows.Forms.Button();
            this.Animals_Bear_Radar_Color = new System.Windows.Forms.Button();
            this.Animals_Bear_Box_Color = new System.Windows.Forms.Button();
            this.Animals_Wolf_Box_Color = new System.Windows.Forms.Button();
            this.label23 = new System.Windows.Forms.Label();
            this.label24 = new System.Windows.Forms.Label();
            this.label25 = new System.Windows.Forms.Label();
            this.Animals_Bear_Box_Check = new System.Windows.Forms.CheckBox();
            this.Animals_Wolf_Radar_Check = new System.Windows.Forms.CheckBox();
            this.Animals_Bear_Radar_Check = new System.Windows.Forms.CheckBox();
            this.Animals_Wolf_Box_Check = new System.Windows.Forms.CheckBox();
            this.label26 = new System.Windows.Forms.Label();
            this.label27 = new System.Windows.Forms.Label();
            this.label28 = new System.Windows.Forms.Label();
            this.label29 = new System.Windows.Forms.Label();
            this.label30 = new System.Windows.Forms.Label();
            this.Animals_Wolf_Tracer_Color = new System.Windows.Forms.Button();
            this.Animals_Bear_Tracer_Color = new System.Windows.Forms.Button();
            this.Animals_Wolf_Tracer_Check = new System.Windows.Forms.CheckBox();
            this.Animals_Bear_Tracer_Check = new System.Windows.Forms.CheckBox();
            this.label22 = new System.Windows.Forms.Label();
            this.label31 = new System.Windows.Forms.Label();
            this.label32 = new System.Windows.Forms.Label();
            this.label33 = new System.Windows.Forms.Label();
            this.Animals_Deer_Radar_Check = new System.Windows.Forms.CheckBox();
            this.Animals_Chicken_Radar_Check = new System.Windows.Forms.CheckBox();
            this.Animals_Boar_Radar_Check = new System.Windows.Forms.CheckBox();
            this.Animals_Horse_Radar_Check = new System.Windows.Forms.CheckBox();
            this.Animals_Deer_Tracer_Check = new System.Windows.Forms.CheckBox();
            this.Animals_Chicken_Tracer_Check = new System.Windows.Forms.CheckBox();
            this.Animals_Boar_Tracer_Check = new System.Windows.Forms.CheckBox();
            this.Animals_Horse_Tracer_Check = new System.Windows.Forms.CheckBox();
            this.Animals_Deer_Box_Check = new System.Windows.Forms.CheckBox();
            this.Animals_Chicken_Box_Check = new System.Windows.Forms.CheckBox();
            this.Animals_Boar_Box_Check = new System.Windows.Forms.CheckBox();
            this.Animals_Horse_Box_Check = new System.Windows.Forms.CheckBox();
            this.Animals_Deer_Radar_Color = new System.Windows.Forms.Button();
            this.Animals_Chicken_Radar_Color = new System.Windows.Forms.Button();
            this.Animals_Boar_Radar_Color = new System.Windows.Forms.Button();
            this.Animals_Horse_Radar_Color = new System.Windows.Forms.Button();
            this.Animals_Deer_Tracer_Color = new System.Windows.Forms.Button();
            this.Animals_Deer_Box_Color = new System.Windows.Forms.Button();
            this.Animals_Chicken_Tracer_Color = new System.Windows.Forms.Button();
            this.Animals_Boar_Tracer_Color = new System.Windows.Forms.Button();
            this.Animals_Horse_Tracer_Color = new System.Windows.Forms.Button();
            this.Animals_Chicken_Box_Color = new System.Windows.Forms.Button();
            this.Animals_Boar_Box_Color = new System.Windows.Forms.Button();
            this.Animals_Horse_Box_Color = new System.Windows.Forms.Button();
            this.Deployables_TAB = new System.Windows.Forms.TabPage();
            this.tableLayoutPanel5 = new System.Windows.Forms.TableLayoutPanel();
            this.Deployable_Oil_Box_Color = new System.Windows.Forms.Button();
            this.Deployable_Oil_Tracer_Color = new System.Windows.Forms.Button();
            this.Deployable_Fridge_Box_Color = new System.Windows.Forms.Button();
            this.Deployable_Fridge_Tracer_Color = new System.Windows.Forms.Button();
            this.Deployable_Large_Furnace_Box_Color = new System.Windows.Forms.Button();
            this.Deployable_Oil_Radar_Color = new System.Windows.Forms.Button();
            this.Deployable_Large_Furnace_Tracer_Color = new System.Windows.Forms.Button();
            this.Deployable_Oil_Radar_Checked = new System.Windows.Forms.CheckBox();
            this.Deployable_Furnace_Box_Color = new System.Windows.Forms.Button();
            this.Deployable_Furnace_Tracer_Color = new System.Windows.Forms.Button();
            this.Deployable_AutoTurret_Box_Color = new System.Windows.Forms.Button();
            this.Deployable_Fridge_Radar_Color = new System.Windows.Forms.Button();
            this.Deployable_AutoTurret_Tracer_Color = new System.Windows.Forms.Button();
            this.Deployable_Fridge_Radar_Check = new System.Windows.Forms.CheckBox();
            this.Deployable_Sleeping_Bag_Box_Color = new System.Windows.Forms.Button();
            this.Deployable_Sleeping_Bag_Tracer_Color = new System.Windows.Forms.Button();
            this.Deployable_TC_Box_Color = new System.Windows.Forms.Button();
            this.Deployable_TC_Tracer_Color = new System.Windows.Forms.Button();
            this.Deployable_Furnace_Box_Check = new System.Windows.Forms.CheckBox();
            this.Deployable_Large_Furnace_Radar_Color = new System.Windows.Forms.Button();
            this.Deployable_TC_Box_Check = new System.Windows.Forms.CheckBox();
            this.Deployable_Large_Furnace_Radar_Check = new System.Windows.Forms.CheckBox();
            this.Deployable_AutoTurret_Box_Check = new System.Windows.Forms.CheckBox();
            this.Deployable_Furnace_Radar_Color = new System.Windows.Forms.Button();
            this.Deployable_TC_Tracer_Check = new System.Windows.Forms.CheckBox();
            this.Deployable_Furnace_Radar_Check = new System.Windows.Forms.CheckBox();
            this.label34 = new System.Windows.Forms.Label();
            this.Deployable_AutoTurret_Radar_Color = new System.Windows.Forms.Button();
            this.Deployable_Quarry_Radar_Color = new System.Windows.Forms.Button();
            this.Deployable_AutoTurret_Radar_Check = new System.Windows.Forms.CheckBox();
            this.Deployable_Sleeping_Bag_Radar_Color = new System.Windows.Forms.Button();
            this.Deployable_Furnace_Tracer_Check = new System.Windows.Forms.CheckBox();
            this.Deployable_TC_Radar_Color = new System.Windows.Forms.Button();
            this.Deployable_Sleeping_Bag_Radar_Check = new System.Windows.Forms.CheckBox();
            this.Deployable_Quarry_Box_Check = new System.Windows.Forms.CheckBox();
            this.Deployable_Quarry_Tracer_Check = new System.Windows.Forms.CheckBox();
            this.label35 = new System.Windows.Forms.Label();
            this.Deployable_TC_Radar_Check = new System.Windows.Forms.CheckBox();
            this.Deployable_Quarry_Tracer_Color = new System.Windows.Forms.Button();
            this.Deployable_Quarry_Radar_Check = new System.Windows.Forms.CheckBox();
            this.Deployable_Quarry_Box_Color = new System.Windows.Forms.Button();
            this.label36 = new System.Windows.Forms.Label();
            this.Deployable_Sleeping_Bag_Tracer_Check = new System.Windows.Forms.CheckBox();
            this.Deployable_Sleeping_Bag_Box_Check = new System.Windows.Forms.CheckBox();
            this.Deployable_AutoTurret_Tracer_Check = new System.Windows.Forms.CheckBox();
            this.label37 = new System.Windows.Forms.Label();
            this.label38 = new System.Windows.Forms.Label();
            this.label39 = new System.Windows.Forms.Label();
            this.label40 = new System.Windows.Forms.Label();
            this.label41 = new System.Windows.Forms.Label();
            this.Deployable_Large_Furnace_Tracer_Check = new System.Windows.Forms.CheckBox();
            this.Deployable_Large_Furnace_Box_Check = new System.Windows.Forms.CheckBox();
            this.Deployable_Fridge_Box_Check = new System.Windows.Forms.CheckBox();
            this.Deployable_Fridge_Tracer_Check = new System.Windows.Forms.CheckBox();
            this.Deployable_Oil_Tracer_Check = new System.Windows.Forms.CheckBox();
            this.Deployable_Oil_Box_Check = new System.Windows.Forms.CheckBox();
            this.label42 = new System.Windows.Forms.Label();
            this.label44 = new System.Windows.Forms.Label();
            this.label45 = new System.Windows.Forms.Label();
            this.label46 = new System.Windows.Forms.Label();
            this.label47 = new System.Windows.Forms.Label();
            this.label43 = new System.Windows.Forms.Label();
            this.label48 = new System.Windows.Forms.Label();
            this.label52 = new System.Windows.Forms.Label();
            this.label51 = new System.Windows.Forms.Label();
            this.label50 = new System.Windows.Forms.Label();
            this.label49 = new System.Windows.Forms.Label();
            this.Deployable_Landmine_Radar_Check = new System.Windows.Forms.CheckBox();
            this.Deployable_Bear_Trap_Radar_Check = new System.Windows.Forms.CheckBox();
            this.Deployable_Stash_Radar_Check = new System.Windows.Forms.CheckBox();
            this.Deployable_Box_Radar_Check = new System.Windows.Forms.CheckBox();
            this.Deployable_Large_Box_Radar_Check = new System.Windows.Forms.CheckBox();
            this.Deployable_Landmine_Tracer_Check = new System.Windows.Forms.CheckBox();
            this.Deployable_Bear_Trap_Tracer_Check = new System.Windows.Forms.CheckBox();
            this.Deployable_Stash_Tracer_Check = new System.Windows.Forms.CheckBox();
            this.Deployable_Box_Tracer_Check = new System.Windows.Forms.CheckBox();
            this.Deployable_Large_Box_Tracer_Check = new System.Windows.Forms.CheckBox();
            this.Deployable_Landmine_Box_Check = new System.Windows.Forms.CheckBox();
            this.Deployable_Bear_Trap_Box_Check = new System.Windows.Forms.CheckBox();
            this.Deployable_Stash_Box_Check = new System.Windows.Forms.CheckBox();
            this.Deployable_Box_Box_Check = new System.Windows.Forms.CheckBox();
            this.Deployable_Large_Box_Box_Check = new System.Windows.Forms.CheckBox();
            this.Deployable_Landmine_Radar_Color = new System.Windows.Forms.Button();
            this.Deployable_Bear_Trap_Radar_Color = new System.Windows.Forms.Button();
            this.Deployable_Stash_Radar_Color = new System.Windows.Forms.Button();
            this.Deployable_Box_Radar_Color = new System.Windows.Forms.Button();
            this.Deployable_Large_Box_Radar_Color = new System.Windows.Forms.Button();
            this.Deployable_Landmine_Tracer_Color = new System.Windows.Forms.Button();
            this.Deployable_Bear_Trap_Tracer_Color = new System.Windows.Forms.Button();
            this.Deployable_Stash_Tracer_Color = new System.Windows.Forms.Button();
            this.Deployable_Box_Tracer_Color = new System.Windows.Forms.Button();
            this.Deployable_Large_Box_Tracer_Color = new System.Windows.Forms.Button();
            this.Deployable_Landmine_Box_Color = new System.Windows.Forms.Button();
            this.Deployable_Bear_Trap_Box_Color = new System.Windows.Forms.Button();
            this.Deployable_Stash_Box_Color = new System.Windows.Forms.Button();
            this.Deployable_Box_Box_Color = new System.Windows.Forms.Button();
            this.Deployable_Large_Box_Box_Color = new System.Windows.Forms.Button();
            this.Plants_TAB = new System.Windows.Forms.TabPage();
            this.tableLayoutPanel6 = new System.Windows.Forms.TableLayoutPanel();
            this.Plant_Hemp_Box_Color = new System.Windows.Forms.Button();
            this.Plant_Mushroom_Box_Color = new System.Windows.Forms.Button();
            this.Plant_Hemp_Radar_Color = new System.Windows.Forms.Button();
            this.label54 = new System.Windows.Forms.Label();
            this.Plant_Mushroom_Radar_Color = new System.Windows.Forms.Button();
            this.label55 = new System.Windows.Forms.Label();
            this.Plant_Hemp_Radar_Check = new System.Windows.Forms.CheckBox();
            this.label56 = new System.Windows.Forms.Label();
            this.Plant_Hemp_Box_Check = new System.Windows.Forms.CheckBox();
            this.Plant_Mushroom_Box_Check = new System.Windows.Forms.CheckBox();
            this.Plant_Mushroom_Radar_Check = new System.Windows.Forms.CheckBox();
            this.label57 = new System.Windows.Forms.Label();
            this.label58 = new System.Windows.Forms.Label();
            this.label59 = new System.Windows.Forms.Label();
            this.label60 = new System.Windows.Forms.Label();
            this.label61 = new System.Windows.Forms.Label();
            this.Plant_Mushroom_Tracer_Color = new System.Windows.Forms.Button();
            this.Plant_Hemp_Tracer_Color = new System.Windows.Forms.Button();
            this.Plant_Mushroom_Tracer_Check = new System.Windows.Forms.CheckBox();
            this.Plant_Hemp_Tracer_Check = new System.Windows.Forms.CheckBox();
            this.label53 = new System.Windows.Forms.Label();
            this.label62 = new System.Windows.Forms.Label();
            this.Plant_Pumpkin_Radar_Check = new System.Windows.Forms.CheckBox();
            this.Plant_Corn_Radar_Check = new System.Windows.Forms.CheckBox();
            this.Plant_Pumpkin_Tracer_Check = new System.Windows.Forms.CheckBox();
            this.Plant_Corn_Tracer_Check = new System.Windows.Forms.CheckBox();
            this.Plant_Pumpkin_Box_Check = new System.Windows.Forms.CheckBox();
            this.Plant_Corn_Box_Check = new System.Windows.Forms.CheckBox();
            this.Plant_Pumpkin_Radar_Color = new System.Windows.Forms.Button();
            this.Plant_Corn_Radar_Color = new System.Windows.Forms.Button();
            this.Plant_Pumpkin_Tracer_Color = new System.Windows.Forms.Button();
            this.Plant_Corn_Tracer_Color = new System.Windows.Forms.Button();
            this.Plant_Pumpkin_Box_Color = new System.Windows.Forms.Button();
            this.Plant_Corn_Box_Color = new System.Windows.Forms.Button();
            this.Resources_TAB = new System.Windows.Forms.TabPage();
            this.tableLayoutPanel7 = new System.Windows.Forms.TableLayoutPanel();
            this.Resource_Wood_Collectable_Radar_Color = new System.Windows.Forms.Button();
            this.Resource_Rock_Collectable_Radar_Color = new System.Windows.Forms.Button();
            this.Resource_Wood_Collectable_Radar_Check = new System.Windows.Forms.CheckBox();
            this.Resource_Rock_Collectable_Radar_Check = new System.Windows.Forms.CheckBox();
            this.Resource_Wood_Collectable_Box_Color = new System.Windows.Forms.Button();
            this.Resource_Rock_Collectable_Box_Color = new System.Windows.Forms.Button();
            this.label67 = new System.Windows.Forms.Label();
            this.label68 = new System.Windows.Forms.Label();
            this.label69 = new System.Windows.Forms.Label();
            this.Resource_Wood_Collectable_Box_Check = new System.Windows.Forms.CheckBox();
            this.Resource_Rock_Collectable_Box_Check = new System.Windows.Forms.CheckBox();
            this.label70 = new System.Windows.Forms.Label();
            this.label71 = new System.Windows.Forms.Label();
            this.label72 = new System.Windows.Forms.Label();
            this.label73 = new System.Windows.Forms.Label();
            this.label74 = new System.Windows.Forms.Label();
            this.Resource_Rock_Collectable_Tracer_Color = new System.Windows.Forms.Button();
            this.Resource_Wood_Collectable_Tracer_Color = new System.Windows.Forms.Button();
            this.Resource_Rock_Collectable_Tracer_Check = new System.Windows.Forms.CheckBox();
            this.Resource_Wood_Collectable_Tracer_Check = new System.Windows.Forms.CheckBox();
            this.label66 = new System.Windows.Forms.Label();
            this.label65 = new System.Windows.Forms.Label();
            this.label64 = new System.Windows.Forms.Label();
            this.label63 = new System.Windows.Forms.Label();
            this.label75 = new System.Windows.Forms.Label();
            this.Resource_Sulfur_Collectable_Radar_Check = new System.Windows.Forms.CheckBox();
            this.Resource_Metal_Collectable_Radar_Check = new System.Windows.Forms.CheckBox();
            this.Resource_Sulfur_Node_Radar_Check = new System.Windows.Forms.CheckBox();
            this.Resource_Metal_Node_Radar_Check = new System.Windows.Forms.CheckBox();
            this.Resource_Stone_Node_Radar_Check = new System.Windows.Forms.CheckBox();
            this.Resource_Sulfur_Collectable_Tracer_Check = new System.Windows.Forms.CheckBox();
            this.Resource_Sulfur_Collectable_Box_Check = new System.Windows.Forms.CheckBox();
            this.Resource_Metal_Collectable_Box_Check = new System.Windows.Forms.CheckBox();
            this.Resource_Metal_Collectable_Tracer_Check = new System.Windows.Forms.CheckBox();
            this.Resource_Sulfur_Node_Tracer_Check = new System.Windows.Forms.CheckBox();
            this.Resource_Sulfur_Node_Box_Check = new System.Windows.Forms.CheckBox();
            this.Resource_Metal_Node_Tracer_Check = new System.Windows.Forms.CheckBox();
            this.Resource_Metal_Node_Box_Check = new System.Windows.Forms.CheckBox();
            this.Resource_Stone_Node_Tracer_Check = new System.Windows.Forms.CheckBox();
            this.Resource_Stone_Node_Box_Check = new System.Windows.Forms.CheckBox();
            this.Resource_Sulfur_Collectable_Radar_Color = new System.Windows.Forms.Button();
            this.Resource_Metal_Collectable_Radar_Color = new System.Windows.Forms.Button();
            this.Resource_Sulfur_Node_Radar_Color = new System.Windows.Forms.Button();
            this.Resource_Metal_Node_Radar_Color = new System.Windows.Forms.Button();
            this.Resource_Stone_Node_Radar_Color = new System.Windows.Forms.Button();
            this.Resource_Sulfur_Collectable_Tracer_Color = new System.Windows.Forms.Button();
            this.Resource_Sulfur_Collectable_Box_Color = new System.Windows.Forms.Button();
            this.Resource_Metal_Collectable_Box_Color = new System.Windows.Forms.Button();
            this.Resource_Metal_Collectable_Tracer_Color = new System.Windows.Forms.Button();
            this.Resource_Sulfur_Node_Tracer_Color = new System.Windows.Forms.Button();
            this.Resource_Metal_Node_Tracer_Color = new System.Windows.Forms.Button();
            this.Resource_Sulfur_Node_Box_Color = new System.Windows.Forms.Button();
            this.Resource_Metal_Node_Box_Color = new System.Windows.Forms.Button();
            this.Resource_Stone_Node_Tracer_Color = new System.Windows.Forms.Button();
            this.Resource_Stone_Node_Box_Color = new System.Windows.Forms.Button();
            this.Barrels_TAB = new System.Windows.Forms.TabPage();
            this.tableLayoutPanel8 = new System.Windows.Forms.TableLayoutPanel();
            this.label90 = new System.Windows.Forms.Label();
            this.Barrel_Food_Box_Box_Color = new System.Windows.Forms.Button();
            this.Barrel_Tool_Crate_Box_Color = new System.Windows.Forms.Button();
            this.Barrel_Food_Box_Tracer_Color = new System.Windows.Forms.Button();
            this.Barrel_Tool_Crate_Tracer_Color = new System.Windows.Forms.Button();
            this.Barrel_Food_Box_Tracer_Check = new System.Windows.Forms.CheckBox();
            this.Barrel_Food_Box_Box_Check = new System.Windows.Forms.CheckBox();
            this.Barrel_Tool_Crate_Box_Check = new System.Windows.Forms.CheckBox();
            this.Barrel_Food_Box_Radar_Color = new System.Windows.Forms.Button();
            this.Barrel_Food_Box_Radar_Check = new System.Windows.Forms.CheckBox();
            this.Barrel_Oil_Barrel_Radar_Check = new System.Windows.Forms.CheckBox();
            this.Barrel_Tool_Crate_Tracer_Check = new System.Windows.Forms.CheckBox();
            this.Barrel_Tool_Crate_Radar_Check = new System.Windows.Forms.CheckBox();
            this.Barrel_Tool_Crate_Radar_Color = new System.Windows.Forms.Button();
            this.Barrel_Med_Crate_Radar_Check = new System.Windows.Forms.CheckBox();
            this.Barrel_Food_Crate_Radar_Color = new System.Windows.Forms.Button();
            this.Barrel_Food_Crate_Radar_Check = new System.Windows.Forms.CheckBox();
            this.Barrel_Mine_Crate_Radar_Color = new System.Windows.Forms.Button();
            this.Barrel_Mine_Crate_Radar_Check = new System.Windows.Forms.CheckBox();
            this.Barrel_Med_Crate_Radar_Color = new System.Windows.Forms.Button();
            this.Barrel_Crate_Radar_Check = new System.Windows.Forms.CheckBox();
            this.Barrel_Crate_Radar_Color = new System.Windows.Forms.Button();
            this.Barrel_Trash_Pile_Radar_Check = new System.Windows.Forms.CheckBox();
            this.Barrel_Trash_Pile_Radar_Color = new System.Windows.Forms.Button();
            this.Barrel_Oil_Barrel_Radar_Color = new System.Windows.Forms.Button();
            this.Barrel_Loot_Barrel_Radar_Color = new System.Windows.Forms.Button();
            this.Barrel_Loot_Barrel_Radar_Check = new System.Windows.Forms.CheckBox();
            this.Barrel_Oil_Barrel_Box_Color = new System.Windows.Forms.Button();
            this.Barrel_Loot_Barrel_Box_Color = new System.Windows.Forms.Button();
            this.label76 = new System.Windows.Forms.Label();
            this.label77 = new System.Windows.Forms.Label();
            this.label78 = new System.Windows.Forms.Label();
            this.Barrel_Oil_Barrel_Box_Check = new System.Windows.Forms.CheckBox();
            this.Barrel_Loot_Barrel_Box_Check = new System.Windows.Forms.CheckBox();
            this.label79 = new System.Windows.Forms.Label();
            this.label80 = new System.Windows.Forms.Label();
            this.label82 = new System.Windows.Forms.Label();
            this.label83 = new System.Windows.Forms.Label();
            this.Barrel_Loot_Barrel_Tracer_Color = new System.Windows.Forms.Button();
            this.Barrel_Oil_Barrel_Tracer_Color = new System.Windows.Forms.Button();
            this.Barrel_Loot_Barrel_Tracer_Check = new System.Windows.Forms.CheckBox();
            this.Barrel_Oil_Barrel_Tracer_Check = new System.Windows.Forms.CheckBox();
            this.label84 = new System.Windows.Forms.Label();
            this.label85 = new System.Windows.Forms.Label();
            this.label86 = new System.Windows.Forms.Label();
            this.label87 = new System.Windows.Forms.Label();
            this.label88 = new System.Windows.Forms.Label();
            this.Barrel_Trash_Pile_Tracer_Check = new System.Windows.Forms.CheckBox();
            this.Barrel_Trash_Pile_Box_Check = new System.Windows.Forms.CheckBox();
            this.Barrel_Crate_Box_Check = new System.Windows.Forms.CheckBox();
            this.Barrel_Crate_Tracer_Check = new System.Windows.Forms.CheckBox();
            this.Barrel_Mine_Crate_Tracer_Check = new System.Windows.Forms.CheckBox();
            this.Barrel_Mine_Crate_Box_Check = new System.Windows.Forms.CheckBox();
            this.Barrel_Food_Crate_Tracer_Check = new System.Windows.Forms.CheckBox();
            this.Barrel_Food_Crate_Box_Check = new System.Windows.Forms.CheckBox();
            this.Barrel_Med_Crate_Tracer_Check = new System.Windows.Forms.CheckBox();
            this.Barrel_Med_Crate_Box_Check = new System.Windows.Forms.CheckBox();
            this.Barrel_Trash_Pile_Tracer_Color = new System.Windows.Forms.Button();
            this.Barrel_Trash_Pile_Box_Color = new System.Windows.Forms.Button();
            this.Barrel_Crate_Box_Color = new System.Windows.Forms.Button();
            this.Barrel_Crate_Tracer_Color = new System.Windows.Forms.Button();
            this.Barrel_Mine_Crate_Tracer_Color = new System.Windows.Forms.Button();
            this.Barrel_Food_Crate_Tracer_Color = new System.Windows.Forms.Button();
            this.Barrel_Mine_Crate_Box_Color = new System.Windows.Forms.Button();
            this.Barrel_Food_Crate_Box_Color = new System.Windows.Forms.Button();
            this.Barrel_Med_Crate_Tracer_Color = new System.Windows.Forms.Button();
            this.Barrel_Med_Crate_Box_Color = new System.Windows.Forms.Button();
            this.label81 = new System.Windows.Forms.Label();
            this.label89 = new System.Windows.Forms.Label();
            this.Misc_TAB = new System.Windows.Forms.TabPage();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.label18 = new System.Windows.Forms.Label();
            this.Misc_Supply_Drop_Radar_Color = new System.Windows.Forms.Button();
            this.Misc_Supply_Drop_Radar_Check = new System.Windows.Forms.CheckBox();
            this.Misc_Corpse_Radar_Color = new System.Windows.Forms.Button();
            this.Misc_Supply_Drop_Box_Color = new System.Windows.Forms.Button();
            this.Misc_Corpse_Box_Color = new System.Windows.Forms.Button();
            this.label15 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.Misc_Supply_Drop_Box_Check = new System.Windows.Forms.CheckBox();
            this.Misc_Corpse_Box_Check = new System.Windows.Forms.CheckBox();
            this.label19 = new System.Windows.Forms.Label();
            this.label20 = new System.Windows.Forms.Label();
            this.label21 = new System.Windows.Forms.Label();
            this.Misc_Corpse_Radar_Check = new System.Windows.Forms.CheckBox();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.Misc_Corpse_Tracer_Color = new System.Windows.Forms.Button();
            this.Misc_Supply_Drop_Tracer_Color = new System.Windows.Forms.Button();
            this.Misc_Corpse_Tracer_Check = new System.Windows.Forms.CheckBox();
            this.Misc_Supply_Drop_Tracer_Check = new System.Windows.Forms.CheckBox();
            this.Misc_Helicopter_Radar_Check = new System.Windows.Forms.CheckBox();
            this.Misc_Helicopter_Tracer_Check = new System.Windows.Forms.CheckBox();
            this.Misc_Helicopter_Box_Check = new System.Windows.Forms.CheckBox();
            this.Misc_Helicopter_Radar_Color = new System.Windows.Forms.Button();
            this.Misc_Helicopter_Tracer_Color = new System.Windows.Forms.Button();
            this.Misc_Helicopter_Box_Color = new System.Windows.Forms.Button();
            this.Color_Picker = new System.Windows.Forms.ColorDialog();
            this.SettingTabs.SuspendLayout();
            this.Setup_TAB.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.Y.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.FOVBox.SuspendLayout();
            this.Server_PORT_Box.SuspendLayout();
            this.Server_IP_Box.SuspendLayout();
            this.Radar_TAB.SuspendLayout();
            this.WaypointBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.WaypointGrid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PlayerData)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataTable1)).BeginInit();
            this.ZoomBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ZoomTrackBar)).BeginInit();
            this.Crosshair_TAB.SuspendLayout();
            this.Players_TAB.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.Animals_TAB.SuspendLayout();
            this.tableLayoutPanel4.SuspendLayout();
            this.Deployables_TAB.SuspendLayout();
            this.tableLayoutPanel5.SuspendLayout();
            this.Plants_TAB.SuspendLayout();
            this.tableLayoutPanel6.SuspendLayout();
            this.Resources_TAB.SuspendLayout();
            this.tableLayoutPanel7.SuspendLayout();
            this.Barrels_TAB.SuspendLayout();
            this.tableLayoutPanel8.SuspendLayout();
            this.Misc_TAB.SuspendLayout();
            this.tableLayoutPanel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // SettingTabs
            // 
            this.SettingTabs.Controls.Add(this.Setup_TAB);
            this.SettingTabs.Controls.Add(this.Radar_TAB);
            this.SettingTabs.Controls.Add(this.Crosshair_TAB);
            this.SettingTabs.Controls.Add(this.Players_TAB);
            this.SettingTabs.Controls.Add(this.Animals_TAB);
            this.SettingTabs.Controls.Add(this.Deployables_TAB);
            this.SettingTabs.Controls.Add(this.Plants_TAB);
            this.SettingTabs.Controls.Add(this.Resources_TAB);
            this.SettingTabs.Controls.Add(this.Barrels_TAB);
            this.SettingTabs.Controls.Add(this.Misc_TAB);
            this.SettingTabs.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SettingTabs.Location = new System.Drawing.Point(12, 12);
            this.SettingTabs.Name = "SettingTabs";
            this.SettingTabs.SelectedIndex = 0;
            this.SettingTabs.Size = new System.Drawing.Size(576, 578);
            this.SettingTabs.TabIndex = 0;
            // 
            // Setup_TAB
            // 
            this.Setup_TAB.BackColor = System.Drawing.Color.White;
            this.Setup_TAB.Controls.Add(this.groupBox2);
            this.Setup_TAB.Controls.Add(this.Y);
            this.Setup_TAB.Controls.Add(this.groupBox1);
            this.Setup_TAB.Controls.Add(this.FOVBox);
            this.Setup_TAB.Controls.Add(this.Box_Check);
            this.Setup_TAB.Controls.Add(this.Misc_Check);
            this.Setup_TAB.Controls.Add(this.Deployables_Check);
            this.Setup_TAB.Controls.Add(this.Tracer_Check);
            this.Setup_TAB.Controls.Add(this.Reset);
            this.Setup_TAB.Controls.Add(this.Radar_Check);
            this.Setup_TAB.Controls.Add(this.Barrels_Check);
            this.Setup_TAB.Controls.Add(this.Crosshair_Check);
            this.Setup_TAB.Controls.Add(this.Animals_Check);
            this.Setup_TAB.Controls.Add(this.Resources_Check);
            this.Setup_TAB.Controls.Add(this.Plants_Check);
            this.Setup_TAB.Controls.Add(this.Players_Check);
            this.Setup_TAB.Controls.Add(this.Server_PORT_Box);
            this.Setup_TAB.Controls.Add(this.Server_IP_Box);
            this.Setup_TAB.Controls.Add(this.StartButton);
            this.Setup_TAB.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Setup_TAB.Location = new System.Drawing.Point(4, 22);
            this.Setup_TAB.Name = "Setup_TAB";
            this.Setup_TAB.Padding = new System.Windows.Forms.Padding(3);
            this.Setup_TAB.Size = new System.Drawing.Size(568, 552);
            this.Setup_TAB.TabIndex = 6;
            this.Setup_TAB.Text = "Setup";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.textBox1);
            this.groupBox2.Location = new System.Drawing.Point(122, 394);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(147, 73);
            this.groupBox2.TabIndex = 24;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Y POS";
            // 
            // textBox1
            // 
            this.textBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.Location = new System.Drawing.Point(7, 20);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(134, 44);
            this.textBox1.TabIndex = 0;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // Y
            // 
            this.Y.Controls.Add(this.Temp_Text_Box);
            this.Y.Location = new System.Drawing.Point(289, 348);
            this.Y.Name = "Y";
            this.Y.Size = new System.Drawing.Size(147, 73);
            this.Y.TabIndex = 23;
            this.Y.TabStop = false;
            this.Y.Text = "Y";
            // 
            // Temp_Text_Box
            // 
            this.Temp_Text_Box.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Temp_Text_Box.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Temp_Text_Box.Location = new System.Drawing.Point(7, 20);
            this.Temp_Text_Box.Name = "Temp_Text_Box";
            this.Temp_Text_Box.Size = new System.Drawing.Size(134, 44);
            this.Temp_Text_Box.TabIndex = 0;
            this.Temp_Text_Box.TextChanged += new System.EventHandler(this.Temp_Text_Box_TextChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.Distance_Text_Box);
            this.groupBox1.Location = new System.Drawing.Point(395, 231);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(165, 73);
            this.groupBox1.TabIndex = 22;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Max Distance";
            // 
            // Distance_Text_Box
            // 
            this.Distance_Text_Box.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Distance_Text_Box.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Distance_Text_Box.Location = new System.Drawing.Point(7, 20);
            this.Distance_Text_Box.Name = "Distance_Text_Box";
            this.Distance_Text_Box.Size = new System.Drawing.Size(152, 44);
            this.Distance_Text_Box.TabIndex = 0;
            this.Distance_Text_Box.TextChanged += new System.EventHandler(this.Distance_Text_Box_TextChanged);
            this.Distance_Text_Box.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.FOV_Text_Box_KeyPress);
            // 
            // FOVBox
            // 
            this.FOVBox.Controls.Add(this.FOV_Text_Box);
            this.FOVBox.Location = new System.Drawing.Point(289, 424);
            this.FOVBox.Name = "FOVBox";
            this.FOVBox.Size = new System.Drawing.Size(147, 73);
            this.FOVBox.TabIndex = 21;
            this.FOVBox.TabStop = false;
            this.FOVBox.Text = "Field of View X";
            // 
            // FOV_Text_Box
            // 
            this.FOV_Text_Box.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.FOV_Text_Box.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FOV_Text_Box.Location = new System.Drawing.Point(7, 20);
            this.FOV_Text_Box.Name = "FOV_Text_Box";
            this.FOV_Text_Box.Size = new System.Drawing.Size(134, 44);
            this.FOV_Text_Box.TabIndex = 0;
            this.FOV_Text_Box.TextChanged += new System.EventHandler(this.FOV_Text_Box_TextChanged);
            // 
            // Box_Check
            // 
            this.Box_Check.AutoSize = true;
            this.Box_Check.Checked = true;
            this.Box_Check.CheckState = System.Windows.Forms.CheckState.Checked;
            this.Box_Check.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Box_Check.Location = new System.Drawing.Point(12, 503);
            this.Box_Check.Name = "Box_Check";
            this.Box_Check.Size = new System.Drawing.Size(47, 17);
            this.Box_Check.TabIndex = 19;
            this.Box_Check.Text = "Box";
            this.Box_Check.UseVisualStyleBackColor = true;
            this.Box_Check.CheckedChanged += new System.EventHandler(this.Box_Check_CheckedChanged);
            // 
            // Misc_Check
            // 
            this.Misc_Check.AutoSize = true;
            this.Misc_Check.Checked = true;
            this.Misc_Check.CheckState = System.Windows.Forms.CheckState.Checked;
            this.Misc_Check.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Misc_Check.Location = new System.Drawing.Point(12, 394);
            this.Misc_Check.Name = "Misc_Check";
            this.Misc_Check.Size = new System.Drawing.Size(52, 17);
            this.Misc_Check.TabIndex = 18;
            this.Misc_Check.Text = "Misc";
            this.Misc_Check.UseVisualStyleBackColor = true;
            this.Misc_Check.CheckedChanged += new System.EventHandler(this.MiscCheck_CheckedChanged);
            // 
            // Deployables_Check
            // 
            this.Deployables_Check.AutoSize = true;
            this.Deployables_Check.Checked = true;
            this.Deployables_Check.CheckState = System.Windows.Forms.CheckState.Checked;
            this.Deployables_Check.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Deployables_Check.Location = new System.Drawing.Point(12, 371);
            this.Deployables_Check.Name = "Deployables_Check";
            this.Deployables_Check.Size = new System.Drawing.Size(95, 17);
            this.Deployables_Check.TabIndex = 17;
            this.Deployables_Check.Text = "Deployables";
            this.Deployables_Check.UseVisualStyleBackColor = true;
            this.Deployables_Check.CheckedChanged += new System.EventHandler(this.DeployablesCheck_CheckedChanged);
            // 
            // Tracer_Check
            // 
            this.Tracer_Check.AutoSize = true;
            this.Tracer_Check.Checked = true;
            this.Tracer_Check.CheckState = System.Windows.Forms.CheckState.Checked;
            this.Tracer_Check.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Tracer_Check.Location = new System.Drawing.Point(12, 480);
            this.Tracer_Check.Name = "Tracer_Check";
            this.Tracer_Check.Size = new System.Drawing.Size(63, 17);
            this.Tracer_Check.TabIndex = 16;
            this.Tracer_Check.Text = "Tracer";
            this.Tracer_Check.UseVisualStyleBackColor = true;
            this.Tracer_Check.CheckedChanged += new System.EventHandler(this.Tracer_Check_CheckedChanged);
            // 
            // Reset
            // 
            this.Reset.BackColor = System.Drawing.Color.DarkRed;
            this.Reset.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Reset.Location = new System.Drawing.Point(493, 523);
            this.Reset.Name = "Reset";
            this.Reset.Size = new System.Drawing.Size(67, 23);
            this.Reset.TabIndex = 13;
            this.Reset.Text = "RESET";
            this.Reset.UseVisualStyleBackColor = false;
            this.Reset.Click += new System.EventHandler(this.Reset_Click);
            // 
            // Radar_Check
            // 
            this.Radar_Check.AutoSize = true;
            this.Radar_Check.Checked = true;
            this.Radar_Check.CheckState = System.Windows.Forms.CheckState.Checked;
            this.Radar_Check.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Radar_Check.Location = new System.Drawing.Point(12, 457);
            this.Radar_Check.Name = "Radar_Check";
            this.Radar_Check.Size = new System.Drawing.Size(60, 17);
            this.Radar_Check.TabIndex = 12;
            this.Radar_Check.Text = "Radar";
            this.Radar_Check.UseVisualStyleBackColor = true;
            this.Radar_Check.CheckedChanged += new System.EventHandler(this.Radar_Check_CheckedChanged);
            // 
            // Barrels_Check
            // 
            this.Barrels_Check.AutoSize = true;
            this.Barrels_Check.Checked = true;
            this.Barrels_Check.CheckState = System.Windows.Forms.CheckState.Checked;
            this.Barrels_Check.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Barrels_Check.Location = new System.Drawing.Point(12, 348);
            this.Barrels_Check.Name = "Barrels_Check";
            this.Barrels_Check.Size = new System.Drawing.Size(65, 17);
            this.Barrels_Check.TabIndex = 11;
            this.Barrels_Check.Text = "Barrels";
            this.Barrels_Check.UseVisualStyleBackColor = true;
            this.Barrels_Check.CheckedChanged += new System.EventHandler(this.Barrel_Check_CheckedChanged);
            // 
            // Crosshair_Check
            // 
            this.Crosshair_Check.AutoSize = true;
            this.Crosshair_Check.Checked = true;
            this.Crosshair_Check.CheckState = System.Windows.Forms.CheckState.Checked;
            this.Crosshair_Check.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Crosshair_Check.Location = new System.Drawing.Point(12, 434);
            this.Crosshair_Check.Name = "Crosshair_Check";
            this.Crosshair_Check.Size = new System.Drawing.Size(78, 17);
            this.Crosshair_Check.TabIndex = 10;
            this.Crosshair_Check.Text = "Crosshair";
            this.Crosshair_Check.UseVisualStyleBackColor = true;
            this.Crosshair_Check.CheckedChanged += new System.EventHandler(this.Crosshair_Check_CheckedChanged);
            // 
            // Animals_Check
            // 
            this.Animals_Check.AutoSize = true;
            this.Animals_Check.Checked = true;
            this.Animals_Check.CheckState = System.Windows.Forms.CheckState.Checked;
            this.Animals_Check.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Animals_Check.Location = new System.Drawing.Point(12, 325);
            this.Animals_Check.Name = "Animals_Check";
            this.Animals_Check.Size = new System.Drawing.Size(69, 17);
            this.Animals_Check.TabIndex = 9;
            this.Animals_Check.Text = "Animals";
            this.Animals_Check.UseVisualStyleBackColor = true;
            this.Animals_Check.CheckedChanged += new System.EventHandler(this.Animals_Check_CheckedChanged);
            // 
            // Resources_Check
            // 
            this.Resources_Check.AutoSize = true;
            this.Resources_Check.Checked = true;
            this.Resources_Check.CheckState = System.Windows.Forms.CheckState.Checked;
            this.Resources_Check.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Resources_Check.Location = new System.Drawing.Point(12, 302);
            this.Resources_Check.Name = "Resources_Check";
            this.Resources_Check.Size = new System.Drawing.Size(86, 17);
            this.Resources_Check.TabIndex = 8;
            this.Resources_Check.Text = "Resources";
            this.Resources_Check.UseVisualStyleBackColor = true;
            this.Resources_Check.CheckedChanged += new System.EventHandler(this.Resource_Check_CheckedChanged);
            // 
            // Plants_Check
            // 
            this.Plants_Check.AutoSize = true;
            this.Plants_Check.Checked = true;
            this.Plants_Check.CheckState = System.Windows.Forms.CheckState.Checked;
            this.Plants_Check.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Plants_Check.Location = new System.Drawing.Point(12, 279);
            this.Plants_Check.Name = "Plants_Check";
            this.Plants_Check.Size = new System.Drawing.Size(61, 17);
            this.Plants_Check.TabIndex = 7;
            this.Plants_Check.Text = "Plants";
            this.Plants_Check.UseVisualStyleBackColor = true;
            this.Plants_Check.CheckedChanged += new System.EventHandler(this.Plants_Check_CheckedChanged);
            // 
            // Players_Check
            // 
            this.Players_Check.AutoSize = true;
            this.Players_Check.Checked = true;
            this.Players_Check.CheckState = System.Windows.Forms.CheckState.Checked;
            this.Players_Check.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Players_Check.Location = new System.Drawing.Point(12, 256);
            this.Players_Check.Name = "Players_Check";
            this.Players_Check.Size = new System.Drawing.Size(67, 17);
            this.Players_Check.TabIndex = 6;
            this.Players_Check.Text = "Players";
            this.Players_Check.UseVisualStyleBackColor = true;
            this.Players_Check.CheckedChanged += new System.EventHandler(this.Player_Check_CheckedChanged);
            // 
            // Server_PORT_Box
            // 
            this.Server_PORT_Box.Controls.Add(this.Server_PORT_Text);
            this.Server_PORT_Box.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Server_PORT_Box.Location = new System.Drawing.Point(6, 93);
            this.Server_PORT_Box.Name = "Server_PORT_Box";
            this.Server_PORT_Box.Size = new System.Drawing.Size(554, 81);
            this.Server_PORT_Box.TabIndex = 5;
            this.Server_PORT_Box.TabStop = false;
            this.Server_PORT_Box.Text = "Server PORT";
            // 
            // Server_PORT_Text
            // 
            this.Server_PORT_Text.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Server_PORT_Text.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Server_PORT_Text.Location = new System.Drawing.Point(6, 19);
            this.Server_PORT_Text.MaxLength = 5;
            this.Server_PORT_Text.Name = "Server_PORT_Text";
            this.Server_PORT_Text.Size = new System.Drawing.Size(542, 53);
            this.Server_PORT_Text.TabIndex = 3;
            this.Server_PORT_Text.TextChanged += new System.EventHandler(this.Server_PORT_Text_TextChanged);
            this.Server_PORT_Text.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Server_PORT_Text_KeyPress);
            // 
            // Server_IP_Box
            // 
            this.Server_IP_Box.Controls.Add(this.Server_IP_Text);
            this.Server_IP_Box.Location = new System.Drawing.Point(6, 6);
            this.Server_IP_Box.Name = "Server_IP_Box";
            this.Server_IP_Box.Size = new System.Drawing.Size(554, 81);
            this.Server_IP_Box.TabIndex = 4;
            this.Server_IP_Box.TabStop = false;
            this.Server_IP_Box.Text = "Server IP";
            // 
            // Server_IP_Text
            // 
            this.Server_IP_Text.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Server_IP_Text.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Server_IP_Text.Location = new System.Drawing.Point(6, 19);
            this.Server_IP_Text.Name = "Server_IP_Text";
            this.Server_IP_Text.Size = new System.Drawing.Size(542, 53);
            this.Server_IP_Text.TabIndex = 3;
            this.Server_IP_Text.TextChanged += new System.EventHandler(this.Server_IP_Text_TextChanged);
            this.Server_IP_Text.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Server_IP_Text_KeyPress);
            // 
            // StartButton
            // 
            this.StartButton.CausesValidation = false;
            this.StartButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.StartButton.Location = new System.Drawing.Point(6, 180);
            this.StartButton.Name = "StartButton";
            this.StartButton.Size = new System.Drawing.Size(554, 46);
            this.StartButton.TabIndex = 2;
            this.StartButton.Text = "Start";
            this.StartButton.UseVisualStyleBackColor = true;
            this.StartButton.Click += new System.EventHandler(this.StartButton_Click);
            // 
            // Radar_TAB
            // 
            this.Radar_TAB.BackColor = System.Drawing.Color.White;
            this.Radar_TAB.Controls.Add(this.WaypointBox);
            this.Radar_TAB.Controls.Add(this.ZoomBox);
            this.Radar_TAB.Location = new System.Drawing.Point(4, 22);
            this.Radar_TAB.Name = "Radar_TAB";
            this.Radar_TAB.Padding = new System.Windows.Forms.Padding(3);
            this.Radar_TAB.Size = new System.Drawing.Size(568, 552);
            this.Radar_TAB.TabIndex = 7;
            this.Radar_TAB.Text = "Radar";
            // 
            // WaypointBox
            // 
            this.WaypointBox.Controls.Add(this.WaypointGrid);
            this.WaypointBox.Location = new System.Drawing.Point(12, 93);
            this.WaypointBox.Name = "WaypointBox";
            this.WaypointBox.Size = new System.Drawing.Size(548, 453);
            this.WaypointBox.TabIndex = 2;
            this.WaypointBox.TabStop = false;
            this.WaypointBox.Text = "Waypoints";
            // 
            // WaypointGrid
            // 
            this.WaypointGrid.AllowUserToResizeColumns = false;
            this.WaypointGrid.AutoGenerateColumns = false;
            this.WaypointGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.WaypointGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.O,
            this.WaypointName,
            this.X,
            this.Z,
            this.Color});
            this.WaypointGrid.DataSource = this.PlayerData;
            this.WaypointGrid.EditMode = System.Windows.Forms.DataGridViewEditMode.EditOnEnter;
            this.WaypointGrid.Location = new System.Drawing.Point(6, 19);
            this.WaypointGrid.Name = "WaypointGrid";
            this.WaypointGrid.Size = new System.Drawing.Size(536, 428);
            this.WaypointGrid.TabIndex = 0;
            // 
            // O
            // 
            this.O.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.O.HeaderText = "O";
            this.O.Name = "O";
            this.O.Width = 22;
            // 
            // WaypointName
            // 
            this.WaypointName.HeaderText = "WaypointName";
            this.WaypointName.Name = "WaypointName";
            // 
            // X
            // 
            this.X.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.X.HeaderText = "X";
            this.X.Name = "X";
            // 
            // Z
            // 
            this.Z.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Z.DataPropertyName = "Z";
            this.Z.HeaderText = "Z";
            this.Z.Name = "Z";
            // 
            // Color
            // 
            this.Color.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Color.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Color.HeaderText = "Color";
            this.Color.Name = "Color";
            this.Color.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            // 
            // PlayerData
            // 
            this.PlayerData.DataSetName = "PlayerData";
            this.PlayerData.Tables.AddRange(new System.Data.DataTable[] {
            this.dataTable1});
            // 
            // dataTable1
            // 
            this.dataTable1.Columns.AddRange(new System.Data.DataColumn[] {
            this.dataColumn1,
            this.dataColumn2,
            this.dataColumn3,
            this.dataColumn4});
            this.dataTable1.TableName = "PlayerList";
            // 
            // dataColumn1
            // 
            this.dataColumn1.AllowDBNull = false;
            this.dataColumn1.Caption = "Name";
            this.dataColumn1.ColumnName = "Name";
            // 
            // dataColumn2
            // 
            this.dataColumn2.Caption = "X";
            this.dataColumn2.ColumnName = "X";
            // 
            // dataColumn3
            // 
            this.dataColumn3.Caption = "Y";
            this.dataColumn3.ColumnName = "Y";
            // 
            // dataColumn4
            // 
            this.dataColumn4.ColumnName = "Z";
            // 
            // ZoomBox
            // 
            this.ZoomBox.Controls.Add(this.ZoomTrackBar);
            this.ZoomBox.Location = new System.Drawing.Point(6, 6);
            this.ZoomBox.Name = "ZoomBox";
            this.ZoomBox.Size = new System.Drawing.Size(554, 80);
            this.ZoomBox.TabIndex = 1;
            this.ZoomBox.TabStop = false;
            this.ZoomBox.Text = "Zoom";
            // 
            // ZoomTrackBar
            // 
            this.ZoomTrackBar.LargeChange = 2;
            this.ZoomTrackBar.Location = new System.Drawing.Point(6, 19);
            this.ZoomTrackBar.Maximum = 5;
            this.ZoomTrackBar.Minimum = -5;
            this.ZoomTrackBar.Name = "ZoomTrackBar";
            this.ZoomTrackBar.Size = new System.Drawing.Size(542, 45);
            this.ZoomTrackBar.TabIndex = 0;
            this.ZoomTrackBar.TabStop = false;
            this.ZoomTrackBar.TickStyle = System.Windows.Forms.TickStyle.Both;
            this.ZoomTrackBar.Scroll += new System.EventHandler(this.ZoomTrackBar_Scroll);
            // 
            // Crosshair_TAB
            // 
            this.Crosshair_TAB.Controls.Add(this.Type_Box);
            this.Crosshair_TAB.Controls.Add(this.Crosshair_Thick_Text);
            this.Crosshair_TAB.Controls.Add(this.Crosshair_Size_Text);
            this.Crosshair_TAB.Controls.Add(this.Crosshair_Type_Label);
            this.Crosshair_TAB.Controls.Add(this.Crosshair_Color);
            this.Crosshair_TAB.Controls.Add(this.Crosshair_Thick_Label);
            this.Crosshair_TAB.Controls.Add(this.Crosshair_Size_Label);
            this.Crosshair_TAB.Controls.Add(this.Crosshair_Color_Label);
            this.Crosshair_TAB.Location = new System.Drawing.Point(4, 22);
            this.Crosshair_TAB.Name = "Crosshair_TAB";
            this.Crosshair_TAB.Size = new System.Drawing.Size(568, 552);
            this.Crosshair_TAB.TabIndex = 9;
            this.Crosshair_TAB.Text = "Crosshair";
            this.Crosshair_TAB.UseVisualStyleBackColor = true;
            // 
            // Type_Box
            // 
            this.Type_Box.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.Type_Box.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Type_Box.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Type_Box.FormattingEnabled = true;
            this.Type_Box.Items.AddRange(new object[] {
            "Circle",
            "Circle Filled",
            "Square",
            "Square Filled",
            "Coss"});
            this.Type_Box.Location = new System.Drawing.Point(125, 103);
            this.Type_Box.Name = "Type_Box";
            this.Type_Box.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.Type_Box.Size = new System.Drawing.Size(199, 26);
            this.Type_Box.TabIndex = 8;
            this.Type_Box.SelectedIndexChanged += new System.EventHandler(this.Type_Box_SelectedIndexChanged);
            // 
            // Crosshair_Thick_Text
            // 
            this.Crosshair_Thick_Text.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Crosshair_Thick_Text.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Crosshair_Thick_Text.Location = new System.Drawing.Point(125, 71);
            this.Crosshair_Thick_Text.Name = "Crosshair_Thick_Text";
            this.Crosshair_Thick_Text.Size = new System.Drawing.Size(199, 26);
            this.Crosshair_Thick_Text.TabIndex = 7;
            this.Crosshair_Thick_Text.TextChanged += new System.EventHandler(this.Crosshair_Thick_Text_TextChanged);
            this.Crosshair_Thick_Text.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Crosshair_Thick_Text_KeyPress);
            // 
            // Crosshair_Size_Text
            // 
            this.Crosshair_Size_Text.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Crosshair_Size_Text.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Crosshair_Size_Text.Location = new System.Drawing.Point(125, 39);
            this.Crosshair_Size_Text.Name = "Crosshair_Size_Text";
            this.Crosshair_Size_Text.Size = new System.Drawing.Size(199, 26);
            this.Crosshair_Size_Text.TabIndex = 6;
            this.Crosshair_Size_Text.TextChanged += new System.EventHandler(this.Crosshair_Size_Text_TextChanged);
            this.Crosshair_Size_Text.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Crosshair_Size_Text_KeyPress);
            // 
            // Crosshair_Type_Label
            // 
            this.Crosshair_Type_Label.AutoSize = true;
            this.Crosshair_Type_Label.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Crosshair_Type_Label.Location = new System.Drawing.Point(7, 103);
            this.Crosshair_Type_Label.Name = "Crosshair_Type_Label";
            this.Crosshair_Type_Label.Size = new System.Drawing.Size(63, 26);
            this.Crosshair_Type_Label.TabIndex = 4;
            this.Crosshair_Type_Label.Text = "Type";
            // 
            // Crosshair_Color
            // 
            this.Crosshair_Color.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Crosshair_Color.Location = new System.Drawing.Point(125, 7);
            this.Crosshair_Color.Name = "Crosshair_Color";
            this.Crosshair_Color.Size = new System.Drawing.Size(199, 26);
            this.Crosshair_Color.TabIndex = 3;
            this.Crosshair_Color.UseVisualStyleBackColor = true;
            this.Crosshair_Color.Click += new System.EventHandler(this.Crosshair_Color_Click);
            // 
            // Crosshair_Thick_Label
            // 
            this.Crosshair_Thick_Label.AutoSize = true;
            this.Crosshair_Thick_Label.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Crosshair_Thick_Label.Location = new System.Drawing.Point(7, 71);
            this.Crosshair_Thick_Label.Name = "Crosshair_Thick_Label";
            this.Crosshair_Thick_Label.Size = new System.Drawing.Size(118, 26);
            this.Crosshair_Thick_Label.TabIndex = 2;
            this.Crosshair_Thick_Label.Text = "Thickness";
            // 
            // Crosshair_Size_Label
            // 
            this.Crosshair_Size_Label.AutoSize = true;
            this.Crosshair_Size_Label.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Crosshair_Size_Label.Location = new System.Drawing.Point(7, 39);
            this.Crosshair_Size_Label.Name = "Crosshair_Size_Label";
            this.Crosshair_Size_Label.Size = new System.Drawing.Size(59, 26);
            this.Crosshair_Size_Label.TabIndex = 1;
            this.Crosshair_Size_Label.Text = "Size";
            // 
            // Crosshair_Color_Label
            // 
            this.Crosshair_Color_Label.AutoSize = true;
            this.Crosshair_Color_Label.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Crosshair_Color_Label.Location = new System.Drawing.Point(7, 7);
            this.Crosshair_Color_Label.Name = "Crosshair_Color_Label";
            this.Crosshair_Color_Label.Size = new System.Drawing.Size(69, 26);
            this.Crosshair_Color_Label.TabIndex = 0;
            this.Crosshair_Color_Label.Text = "Color";
            // 
            // Players_TAB
            // 
            this.Players_TAB.BackColor = System.Drawing.Color.White;
            this.Players_TAB.Controls.Add(this.tableLayoutPanel2);
            this.Players_TAB.Controls.Add(this.tableLayoutPanel1);
            this.Players_TAB.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Players_TAB.Location = new System.Drawing.Point(4, 22);
            this.Players_TAB.Name = "Players_TAB";
            this.Players_TAB.Padding = new System.Windows.Forms.Padding(3);
            this.Players_TAB.Size = new System.Drawing.Size(568, 552);
            this.Players_TAB.TabIndex = 0;
            this.Players_TAB.Text = "Players";
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 6;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 187F));
            this.tableLayoutPanel2.Controls.Add(this.button25, 4, 5);
            this.tableLayoutPanel2.Controls.Add(this.button24, 3, 5);
            this.tableLayoutPanel2.Controls.Add(this.button21, 3, 4);
            this.tableLayoutPanel2.Controls.Add(this.checkBox1, 2, 5);
            this.tableLayoutPanel2.Controls.Add(this.checkBox3, 2, 4);
            this.tableLayoutPanel2.Controls.Add(this.checkBox5, 1, 5);
            this.tableLayoutPanel2.Controls.Add(this.checkBox7, 1, 4);
            this.tableLayoutPanel2.Controls.Add(this.label12, 0, 5);
            this.tableLayoutPanel2.Controls.Add(this.label11, 0, 4);
            this.tableLayoutPanel2.Controls.Add(this.button15, 4, 3);
            this.tableLayoutPanel2.Controls.Add(this.button12, 3, 3);
            this.tableLayoutPanel2.Controls.Add(this.button9, 4, 2);
            this.tableLayoutPanel2.Controls.Add(this.button6, 3, 2);
            this.tableLayoutPanel2.Controls.Add(this.button2, 4, 1);
            this.tableLayoutPanel2.Controls.Add(this.button1, 3, 1);
            this.tableLayoutPanel2.Controls.Add(this.label10, 4, 0);
            this.tableLayoutPanel2.Controls.Add(this.PlayerInvBeltLabel, 0, 1);
            this.tableLayoutPanel2.Controls.Add(this.PlayerInvWearLabel, 0, 2);
            this.tableLayoutPanel2.Controls.Add(this.PlayerHeldItemLabel, 0, 3);
            this.tableLayoutPanel2.Controls.Add(this.PlayerInventoryBeltCheck, 1, 1);
            this.tableLayoutPanel2.Controls.Add(this.PlayerInventoryWearCheck, 1, 2);
            this.tableLayoutPanel2.Controls.Add(this.PlayerHeldItem, 1, 3);
            this.tableLayoutPanel2.Controls.Add(this.checkBox8, 2, 3);
            this.tableLayoutPanel2.Controls.Add(this.checkBox10, 2, 2);
            this.tableLayoutPanel2.Controls.Add(this.checkBox12, 2, 1);
            this.tableLayoutPanel2.Controls.Add(this.label1, 1, 0);
            this.tableLayoutPanel2.Controls.Add(this.label8, 2, 0);
            this.tableLayoutPanel2.Controls.Add(this.label9, 3, 0);
            this.tableLayoutPanel2.Controls.Add(this.button18, 4, 4);
            this.tableLayoutPanel2.Location = new System.Drawing.Point(6, 311);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 7;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(497, 192);
            this.tableLayoutPanel2.TabIndex = 27;
            // 
            // button25
            // 
            this.button25.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button25.Location = new System.Drawing.Point(232, 114);
            this.button25.Name = "button25";
            this.button25.Size = new System.Drawing.Size(75, 17);
            this.button25.TabIndex = 29;
            this.button25.UseVisualStyleBackColor = false;
            // 
            // button24
            // 
            this.button24.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button24.Location = new System.Drawing.Point(151, 114);
            this.button24.Name = "button24";
            this.button24.Size = new System.Drawing.Size(75, 17);
            this.button24.TabIndex = 29;
            this.button24.UseVisualStyleBackColor = false;
            // 
            // button21
            // 
            this.button21.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button21.Location = new System.Drawing.Point(151, 91);
            this.button21.Name = "button21";
            this.button21.Size = new System.Drawing.Size(75, 17);
            this.button21.TabIndex = 29;
            this.button21.UseVisualStyleBackColor = false;
            // 
            // checkBox1
            // 
            this.checkBox1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.checkBox1.AutoSize = true;
            this.checkBox1.CheckAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.checkBox1.Checked = true;
            this.checkBox1.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBox1.Location = new System.Drawing.Point(125, 117);
            this.checkBox1.Margin = new System.Windows.Forms.Padding(3, 3, 0, 0);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(15, 14);
            this.checkBox1.TabIndex = 28;
            this.checkBox1.UseVisualStyleBackColor = true;
            // 
            // checkBox3
            // 
            this.checkBox3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.checkBox3.AutoSize = true;
            this.checkBox3.CheckAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.checkBox3.Checked = true;
            this.checkBox3.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBox3.Location = new System.Drawing.Point(125, 94);
            this.checkBox3.Margin = new System.Windows.Forms.Padding(3, 3, 0, 0);
            this.checkBox3.Name = "checkBox3";
            this.checkBox3.Size = new System.Drawing.Size(15, 14);
            this.checkBox3.TabIndex = 29;
            this.checkBox3.UseVisualStyleBackColor = true;
            // 
            // checkBox5
            // 
            this.checkBox5.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.checkBox5.AutoSize = true;
            this.checkBox5.CheckAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.checkBox5.Checked = true;
            this.checkBox5.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBox5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBox5.Location = new System.Drawing.Point(84, 117);
            this.checkBox5.Margin = new System.Windows.Forms.Padding(3, 3, 0, 0);
            this.checkBox5.Name = "checkBox5";
            this.checkBox5.Size = new System.Drawing.Size(15, 14);
            this.checkBox5.TabIndex = 30;
            this.checkBox5.UseVisualStyleBackColor = true;
            // 
            // checkBox7
            // 
            this.checkBox7.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.checkBox7.AutoSize = true;
            this.checkBox7.CheckAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.checkBox7.Checked = true;
            this.checkBox7.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBox7.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBox7.Location = new System.Drawing.Point(84, 94);
            this.checkBox7.Margin = new System.Windows.Forms.Padding(3, 3, 0, 0);
            this.checkBox7.Name = "checkBox7";
            this.checkBox7.Size = new System.Drawing.Size(15, 14);
            this.checkBox7.TabIndex = 31;
            this.checkBox7.UseVisualStyleBackColor = true;
            // 
            // label12
            // 
            this.label12.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(3, 114);
            this.label12.Margin = new System.Windows.Forms.Padding(3);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(61, 17);
            this.label12.TabIndex = 47;
            this.label12.Text = "Distance";
            this.label12.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label11
            // 
            this.label11.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(3, 91);
            this.label11.Margin = new System.Windows.Forms.Padding(3);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(61, 17);
            this.label11.TabIndex = 46;
            this.label11.Text = "Health";
            this.label11.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // button15
            // 
            this.button15.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button15.Location = new System.Drawing.Point(232, 68);
            this.button15.Name = "button15";
            this.button15.Size = new System.Drawing.Size(75, 17);
            this.button15.TabIndex = 28;
            this.button15.UseVisualStyleBackColor = false;
            // 
            // button12
            // 
            this.button12.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button12.Location = new System.Drawing.Point(151, 68);
            this.button12.Name = "button12";
            this.button12.Size = new System.Drawing.Size(75, 17);
            this.button12.TabIndex = 28;
            this.button12.UseVisualStyleBackColor = false;
            // 
            // button9
            // 
            this.button9.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button9.Location = new System.Drawing.Point(232, 45);
            this.button9.Name = "button9";
            this.button9.Size = new System.Drawing.Size(75, 17);
            this.button9.TabIndex = 28;
            this.button9.UseVisualStyleBackColor = false;
            // 
            // button6
            // 
            this.button6.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button6.Location = new System.Drawing.Point(151, 45);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(75, 17);
            this.button6.TabIndex = 28;
            this.button6.UseVisualStyleBackColor = false;
            // 
            // button2
            // 
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Location = new System.Drawing.Point(232, 22);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 17);
            this.button2.TabIndex = 28;
            this.button2.UseVisualStyleBackColor = false;
            // 
            // button1
            // 
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Location = new System.Drawing.Point(151, 22);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 17);
            this.button1.TabIndex = 28;
            this.button1.UseVisualStyleBackColor = false;
            // 
            // label10
            // 
            this.label10.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(232, 3);
            this.label10.Margin = new System.Windows.Forms.Padding(3);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(75, 13);
            this.label10.TabIndex = 76;
            this.label10.Text = "Box";
            this.label10.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // PlayerInvBeltLabel
            // 
            this.PlayerInvBeltLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.PlayerInvBeltLabel.AutoSize = true;
            this.PlayerInvBeltLabel.Location = new System.Drawing.Point(3, 22);
            this.PlayerInvBeltLabel.Margin = new System.Windows.Forms.Padding(3);
            this.PlayerInvBeltLabel.Name = "PlayerInvBeltLabel";
            this.PlayerInvBeltLabel.Size = new System.Drawing.Size(61, 17);
            this.PlayerInvBeltLabel.TabIndex = 46;
            this.PlayerInvBeltLabel.Text = "Inv Belt";
            this.PlayerInvBeltLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // PlayerInvWearLabel
            // 
            this.PlayerInvWearLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.PlayerInvWearLabel.AutoSize = true;
            this.PlayerInvWearLabel.Location = new System.Drawing.Point(3, 45);
            this.PlayerInvWearLabel.Margin = new System.Windows.Forms.Padding(3);
            this.PlayerInvWearLabel.Name = "PlayerInvWearLabel";
            this.PlayerInvWearLabel.Size = new System.Drawing.Size(61, 17);
            this.PlayerInvWearLabel.TabIndex = 44;
            this.PlayerInvWearLabel.Text = "Inv Wear";
            this.PlayerInvWearLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // PlayerHeldItemLabel
            // 
            this.PlayerHeldItemLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.PlayerHeldItemLabel.AutoSize = true;
            this.PlayerHeldItemLabel.Location = new System.Drawing.Point(3, 68);
            this.PlayerHeldItemLabel.Margin = new System.Windows.Forms.Padding(3);
            this.PlayerHeldItemLabel.Name = "PlayerHeldItemLabel";
            this.PlayerHeldItemLabel.Size = new System.Drawing.Size(61, 17);
            this.PlayerHeldItemLabel.TabIndex = 45;
            this.PlayerHeldItemLabel.Text = "Held Item";
            this.PlayerHeldItemLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // PlayerInventoryBeltCheck
            // 
            this.PlayerInventoryBeltCheck.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.PlayerInventoryBeltCheck.AutoSize = true;
            this.PlayerInventoryBeltCheck.CheckAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.PlayerInventoryBeltCheck.Checked = true;
            this.PlayerInventoryBeltCheck.CheckState = System.Windows.Forms.CheckState.Checked;
            this.PlayerInventoryBeltCheck.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PlayerInventoryBeltCheck.Location = new System.Drawing.Point(84, 25);
            this.PlayerInventoryBeltCheck.Margin = new System.Windows.Forms.Padding(3, 3, 0, 0);
            this.PlayerInventoryBeltCheck.Name = "PlayerInventoryBeltCheck";
            this.PlayerInventoryBeltCheck.Size = new System.Drawing.Size(15, 14);
            this.PlayerInventoryBeltCheck.TabIndex = 19;
            this.PlayerInventoryBeltCheck.UseVisualStyleBackColor = true;
            this.PlayerInventoryBeltCheck.CheckedChanged += new System.EventHandler(this.Inventory_Belt_Check_CheckedChanged);
            // 
            // PlayerInventoryWearCheck
            // 
            this.PlayerInventoryWearCheck.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.PlayerInventoryWearCheck.AutoSize = true;
            this.PlayerInventoryWearCheck.CheckAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.PlayerInventoryWearCheck.Checked = true;
            this.PlayerInventoryWearCheck.CheckState = System.Windows.Forms.CheckState.Checked;
            this.PlayerInventoryWearCheck.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PlayerInventoryWearCheck.Location = new System.Drawing.Point(84, 48);
            this.PlayerInventoryWearCheck.Margin = new System.Windows.Forms.Padding(3, 3, 0, 0);
            this.PlayerInventoryWearCheck.Name = "PlayerInventoryWearCheck";
            this.PlayerInventoryWearCheck.Size = new System.Drawing.Size(15, 14);
            this.PlayerInventoryWearCheck.TabIndex = 21;
            this.PlayerInventoryWearCheck.UseVisualStyleBackColor = true;
            this.PlayerInventoryWearCheck.CheckedChanged += new System.EventHandler(this.Inventory_Wear_Check_CheckedChanged);
            // 
            // PlayerHeldItem
            // 
            this.PlayerHeldItem.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.PlayerHeldItem.AutoSize = true;
            this.PlayerHeldItem.CheckAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.PlayerHeldItem.Checked = true;
            this.PlayerHeldItem.CheckState = System.Windows.Forms.CheckState.Checked;
            this.PlayerHeldItem.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PlayerHeldItem.Location = new System.Drawing.Point(84, 71);
            this.PlayerHeldItem.Margin = new System.Windows.Forms.Padding(3, 3, 0, 0);
            this.PlayerHeldItem.Name = "PlayerHeldItem";
            this.PlayerHeldItem.Size = new System.Drawing.Size(15, 14);
            this.PlayerHeldItem.TabIndex = 17;
            this.PlayerHeldItem.UseVisualStyleBackColor = true;
            this.PlayerHeldItem.CheckedChanged += new System.EventHandler(this.Held_Item_Check_CheckedChanged);
            // 
            // checkBox8
            // 
            this.checkBox8.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.checkBox8.AutoSize = true;
            this.checkBox8.CheckAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.checkBox8.Checked = true;
            this.checkBox8.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBox8.Location = new System.Drawing.Point(125, 71);
            this.checkBox8.Margin = new System.Windows.Forms.Padding(3, 3, 0, 0);
            this.checkBox8.Name = "checkBox8";
            this.checkBox8.Size = new System.Drawing.Size(15, 14);
            this.checkBox8.TabIndex = 30;
            this.checkBox8.UseVisualStyleBackColor = true;
            // 
            // checkBox10
            // 
            this.checkBox10.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.checkBox10.AutoSize = true;
            this.checkBox10.CheckAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.checkBox10.Checked = true;
            this.checkBox10.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBox10.Location = new System.Drawing.Point(125, 48);
            this.checkBox10.Margin = new System.Windows.Forms.Padding(3, 3, 0, 0);
            this.checkBox10.Name = "checkBox10";
            this.checkBox10.Size = new System.Drawing.Size(15, 14);
            this.checkBox10.TabIndex = 32;
            this.checkBox10.UseVisualStyleBackColor = true;
            // 
            // checkBox12
            // 
            this.checkBox12.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.checkBox12.AutoSize = true;
            this.checkBox12.CheckAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.checkBox12.Checked = true;
            this.checkBox12.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBox12.Location = new System.Drawing.Point(125, 25);
            this.checkBox12.Margin = new System.Windows.Forms.Padding(3, 3, 0, 0);
            this.checkBox12.Name = "checkBox12";
            this.checkBox12.Size = new System.Drawing.Size(15, 14);
            this.checkBox12.TabIndex = 34;
            this.checkBox12.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(70, 3);
            this.label1.Margin = new System.Windows.Forms.Padding(3);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 13);
            this.label1.TabIndex = 76;
            this.label1.Text = "Radar";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label8
            // 
            this.label8.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(117, 3);
            this.label8.Margin = new System.Windows.Forms.Padding(3);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(28, 13);
            this.label8.TabIndex = 77;
            this.label8.Text = "Box";
            this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label9
            // 
            this.label9.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(151, 3);
            this.label9.Margin = new System.Windows.Forms.Padding(3);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(75, 13);
            this.label9.TabIndex = 78;
            this.label9.Text = "Radar";
            this.label9.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // button18
            // 
            this.button18.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button18.Location = new System.Drawing.Point(232, 91);
            this.button18.Name = "button18";
            this.button18.Size = new System.Drawing.Size(75, 17);
            this.button18.TabIndex = 29;
            this.button18.UseVisualStyleBackColor = false;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel1.AutoSize = true;
            this.tableLayoutPanel1.ColumnCount = 8;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 42F));
            this.tableLayoutPanel1.Controls.Add(this.Player_Loot_Corpse_Box_Color, 6, 8);
            this.tableLayoutPanel1.Controls.Add(this.Player_Loot_Corpse_Tracer_Color, 5, 8);
            this.tableLayoutPanel1.Controls.Add(this.Player_Enemy_Box_Color, 6, 7);
            this.tableLayoutPanel1.Controls.Add(this.Player_Enemy_Tracer_Color, 5, 7);
            this.tableLayoutPanel1.Controls.Add(this.Player_Friend_Box_Color, 6, 6);
            this.tableLayoutPanel1.Controls.Add(this.Player_Friend_Tracer_Color, 5, 6);
            this.tableLayoutPanel1.Controls.Add(this.Player_Crouching_Box_Color, 6, 5);
            this.tableLayoutPanel1.Controls.Add(this.Player_Crouching_Tracer_Color, 5, 5);
            this.tableLayoutPanel1.Controls.Add(this.Player_Sprinting_Box_Color, 6, 4);
            this.tableLayoutPanel1.Controls.Add(this.Player_Sprinting_Tracer_Color, 5, 4);
            this.tableLayoutPanel1.Controls.Add(this.Player_Aiming_Box_Color, 6, 3);
            this.tableLayoutPanel1.Controls.Add(this.Player_Aiming_Tracer_Color, 5, 3);
            this.tableLayoutPanel1.Controls.Add(this.Player_Sleeping_Box_Color, 6, 2);
            this.tableLayoutPanel1.Controls.Add(this.Player_Sleeping_Tracer_Color, 5, 2);
            this.tableLayoutPanel1.Controls.Add(this.Player_Crouching_Box_Check, 3, 5);
            this.tableLayoutPanel1.Controls.Add(this.Player_Sleeping_Box_Check, 3, 2);
            this.tableLayoutPanel1.Controls.Add(this.Player_Sprinting_Box_Check, 3, 4);
            this.tableLayoutPanel1.Controls.Add(this.Player_Sleeping_Tracer_Check, 2, 2);
            this.tableLayoutPanel1.Controls.Add(this.PlayerSleepingLabel, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.Player_Crouching_Tracer_Check, 2, 5);
            this.tableLayoutPanel1.Controls.Add(this.Player_Awake_Radar_Color, 4, 1);
            this.tableLayoutPanel1.Controls.Add(this.Player_Crouching_Radar_Color, 4, 5);
            this.tableLayoutPanel1.Controls.Add(this.Player_Loot_Corpse_Radar_Color, 4, 8);
            this.tableLayoutPanel1.Controls.Add(this.Player_Awake_Box_Check, 3, 1);
            this.tableLayoutPanel1.Controls.Add(this.Player_Enemy_Radar_Color, 4, 7);
            this.tableLayoutPanel1.Controls.Add(this.Player_Sprinting_Radar_Color, 4, 4);
            this.tableLayoutPanel1.Controls.Add(this.Player_Friend_Radar_Color, 4, 6);
            this.tableLayoutPanel1.Controls.Add(this.Player_Aiming_Radar_Color, 4, 3);
            this.tableLayoutPanel1.Controls.Add(this.Player_Crouching_Radar_Check, 1, 5);
            this.tableLayoutPanel1.Controls.Add(this.Player_Awake_Tracer_Check, 2, 1);
            this.tableLayoutPanel1.Controls.Add(this.Player_Sleeping_Radar_Color, 4, 2);
            this.tableLayoutPanel1.Controls.Add(this.Player_Awake_Radar_Check, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.PlayerAwakeLabel, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.Player_Awake_Tracer_Color, 5, 1);
            this.tableLayoutPanel1.Controls.Add(this.Player_Sprinting_Radar_Check, 1, 4);
            this.tableLayoutPanel1.Controls.Add(this.Player_Awake_Box_Color, 6, 1);
            this.tableLayoutPanel1.Controls.Add(this.PlayerAimingLabel, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.Player_Aiming_Radar_Check, 1, 3);
            this.tableLayoutPanel1.Controls.Add(this.Player_Loot_Corpse_Radar_Check, 1, 8);
            this.tableLayoutPanel1.Controls.Add(this.Player_Sleeping_Radar_Check, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.Player_Enemy_Radar_Check, 1, 7);
            this.tableLayoutPanel1.Controls.Add(this.Player_Friend_Radar_Check, 1, 6);
            this.tableLayoutPanel1.Controls.Add(this.Player_Aiming_Tracer_Check, 2, 3);
            this.tableLayoutPanel1.Controls.Add(this.Player_Aiming_Box_Check, 3, 3);
            this.tableLayoutPanel1.Controls.Add(this.Player_Sprinting_Tracer_Check, 2, 4);
            this.tableLayoutPanel1.Controls.Add(this.PlayerSprintingLabel, 0, 4);
            this.tableLayoutPanel1.Controls.Add(this.PlayerCrouchingLabel, 0, 5);
            this.tableLayoutPanel1.Controls.Add(this.PlayerFriendsLabel, 0, 6);
            this.tableLayoutPanel1.Controls.Add(this.PlayerEnemyLabel, 0, 7);
            this.tableLayoutPanel1.Controls.Add(this.PlayerLootCorpseLabel, 0, 8);
            this.tableLayoutPanel1.Controls.Add(this.Player_Friend_Tracer_Check, 2, 6);
            this.tableLayoutPanel1.Controls.Add(this.Player_Friend_Box_Check, 3, 6);
            this.tableLayoutPanel1.Controls.Add(this.Player_Enemy_Box_Check, 3, 7);
            this.tableLayoutPanel1.Controls.Add(this.Player_Enemy_Tracer_Check, 2, 7);
            this.tableLayoutPanel1.Controls.Add(this.Player_Loot_Corpse_Tracer_Check, 2, 8);
            this.tableLayoutPanel1.Controls.Add(this.Player_Loot_Corpse_Box_Check, 3, 8);
            this.tableLayoutPanel1.Controls.Add(this.label2, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.label3, 2, 0);
            this.tableLayoutPanel1.Controls.Add(this.label4, 3, 0);
            this.tableLayoutPanel1.Controls.Add(this.label6, 4, 0);
            this.tableLayoutPanel1.Controls.Add(this.label5, 5, 0);
            this.tableLayoutPanel1.Controls.Add(this.label7, 6, 0);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(8, 6);
            this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(3, 3, 0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 10;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(497, 230);
            this.tableLayoutPanel1.TabIndex = 26;
            // 
            // Player_Loot_Corpse_Box_Color
            // 
            this.Player_Loot_Corpse_Box_Color.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Player_Loot_Corpse_Box_Color.Location = new System.Drawing.Point(377, 183);
            this.Player_Loot_Corpse_Box_Color.Name = "Player_Loot_Corpse_Box_Color";
            this.Player_Loot_Corpse_Box_Color.Size = new System.Drawing.Size(75, 17);
            this.Player_Loot_Corpse_Box_Color.TabIndex = 73;
            this.Player_Loot_Corpse_Box_Color.UseVisualStyleBackColor = false;
            this.Player_Loot_Corpse_Box_Color.Click += new System.EventHandler(this.Player_Loot_Corpse_Box_Color_Click);
            // 
            // Player_Loot_Corpse_Tracer_Color
            // 
            this.Player_Loot_Corpse_Tracer_Color.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Player_Loot_Corpse_Tracer_Color.Location = new System.Drawing.Point(296, 183);
            this.Player_Loot_Corpse_Tracer_Color.Name = "Player_Loot_Corpse_Tracer_Color";
            this.Player_Loot_Corpse_Tracer_Color.Size = new System.Drawing.Size(75, 17);
            this.Player_Loot_Corpse_Tracer_Color.TabIndex = 72;
            this.Player_Loot_Corpse_Tracer_Color.UseVisualStyleBackColor = false;
            this.Player_Loot_Corpse_Tracer_Color.Click += new System.EventHandler(this.Player_Loot_Corpse_Tracer_Color_Click);
            // 
            // Player_Enemy_Box_Color
            // 
            this.Player_Enemy_Box_Color.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Player_Enemy_Box_Color.Location = new System.Drawing.Point(377, 160);
            this.Player_Enemy_Box_Color.Name = "Player_Enemy_Box_Color";
            this.Player_Enemy_Box_Color.Size = new System.Drawing.Size(75, 17);
            this.Player_Enemy_Box_Color.TabIndex = 70;
            this.Player_Enemy_Box_Color.UseVisualStyleBackColor = false;
            this.Player_Enemy_Box_Color.Click += new System.EventHandler(this.Player_Enemy_Box_Color_Click);
            // 
            // Player_Enemy_Tracer_Color
            // 
            this.Player_Enemy_Tracer_Color.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Player_Enemy_Tracer_Color.Location = new System.Drawing.Point(296, 160);
            this.Player_Enemy_Tracer_Color.Name = "Player_Enemy_Tracer_Color";
            this.Player_Enemy_Tracer_Color.Size = new System.Drawing.Size(75, 17);
            this.Player_Enemy_Tracer_Color.TabIndex = 69;
            this.Player_Enemy_Tracer_Color.UseVisualStyleBackColor = false;
            this.Player_Enemy_Tracer_Color.Click += new System.EventHandler(this.Player_Enemy_Tracer_Color_Click);
            // 
            // Player_Friend_Box_Color
            // 
            this.Player_Friend_Box_Color.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Player_Friend_Box_Color.Location = new System.Drawing.Point(377, 137);
            this.Player_Friend_Box_Color.Name = "Player_Friend_Box_Color";
            this.Player_Friend_Box_Color.Size = new System.Drawing.Size(75, 17);
            this.Player_Friend_Box_Color.TabIndex = 67;
            this.Player_Friend_Box_Color.UseVisualStyleBackColor = false;
            this.Player_Friend_Box_Color.Click += new System.EventHandler(this.Player_Friend_Box_Color_Click);
            // 
            // Player_Friend_Tracer_Color
            // 
            this.Player_Friend_Tracer_Color.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Player_Friend_Tracer_Color.Location = new System.Drawing.Point(296, 137);
            this.Player_Friend_Tracer_Color.Name = "Player_Friend_Tracer_Color";
            this.Player_Friend_Tracer_Color.Size = new System.Drawing.Size(75, 17);
            this.Player_Friend_Tracer_Color.TabIndex = 66;
            this.Player_Friend_Tracer_Color.UseVisualStyleBackColor = false;
            this.Player_Friend_Tracer_Color.Click += new System.EventHandler(this.Player_Friend_Tracer_Color_Click);
            // 
            // Player_Crouching_Box_Color
            // 
            this.Player_Crouching_Box_Color.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Player_Crouching_Box_Color.Location = new System.Drawing.Point(377, 114);
            this.Player_Crouching_Box_Color.Name = "Player_Crouching_Box_Color";
            this.Player_Crouching_Box_Color.Size = new System.Drawing.Size(75, 17);
            this.Player_Crouching_Box_Color.TabIndex = 64;
            this.Player_Crouching_Box_Color.UseVisualStyleBackColor = false;
            this.Player_Crouching_Box_Color.Click += new System.EventHandler(this.Player_Crouching_Box_Color_Click);
            // 
            // Player_Crouching_Tracer_Color
            // 
            this.Player_Crouching_Tracer_Color.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Player_Crouching_Tracer_Color.Location = new System.Drawing.Point(296, 114);
            this.Player_Crouching_Tracer_Color.Name = "Player_Crouching_Tracer_Color";
            this.Player_Crouching_Tracer_Color.Size = new System.Drawing.Size(75, 17);
            this.Player_Crouching_Tracer_Color.TabIndex = 63;
            this.Player_Crouching_Tracer_Color.UseVisualStyleBackColor = false;
            this.Player_Crouching_Tracer_Color.Click += new System.EventHandler(this.Player_Crouching_Tracer_Color_Click);
            // 
            // Player_Sprinting_Box_Color
            // 
            this.Player_Sprinting_Box_Color.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Player_Sprinting_Box_Color.Location = new System.Drawing.Point(377, 91);
            this.Player_Sprinting_Box_Color.Name = "Player_Sprinting_Box_Color";
            this.Player_Sprinting_Box_Color.Size = new System.Drawing.Size(75, 17);
            this.Player_Sprinting_Box_Color.TabIndex = 61;
            this.Player_Sprinting_Box_Color.UseVisualStyleBackColor = false;
            this.Player_Sprinting_Box_Color.Click += new System.EventHandler(this.Player_Sprinting_Box_Color_Click);
            // 
            // Player_Sprinting_Tracer_Color
            // 
            this.Player_Sprinting_Tracer_Color.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Player_Sprinting_Tracer_Color.Location = new System.Drawing.Point(296, 91);
            this.Player_Sprinting_Tracer_Color.Name = "Player_Sprinting_Tracer_Color";
            this.Player_Sprinting_Tracer_Color.Size = new System.Drawing.Size(75, 17);
            this.Player_Sprinting_Tracer_Color.TabIndex = 60;
            this.Player_Sprinting_Tracer_Color.UseVisualStyleBackColor = false;
            this.Player_Sprinting_Tracer_Color.Click += new System.EventHandler(this.Player_Sprinting_Tracer_Color_Click);
            // 
            // Player_Aiming_Box_Color
            // 
            this.Player_Aiming_Box_Color.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Player_Aiming_Box_Color.Location = new System.Drawing.Point(377, 68);
            this.Player_Aiming_Box_Color.Name = "Player_Aiming_Box_Color";
            this.Player_Aiming_Box_Color.Size = new System.Drawing.Size(75, 17);
            this.Player_Aiming_Box_Color.TabIndex = 58;
            this.Player_Aiming_Box_Color.UseVisualStyleBackColor = false;
            this.Player_Aiming_Box_Color.Click += new System.EventHandler(this.Player_Aiming_Box_Color_Click);
            // 
            // Player_Aiming_Tracer_Color
            // 
            this.Player_Aiming_Tracer_Color.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Player_Aiming_Tracer_Color.Location = new System.Drawing.Point(296, 68);
            this.Player_Aiming_Tracer_Color.Name = "Player_Aiming_Tracer_Color";
            this.Player_Aiming_Tracer_Color.Size = new System.Drawing.Size(75, 17);
            this.Player_Aiming_Tracer_Color.TabIndex = 57;
            this.Player_Aiming_Tracer_Color.UseVisualStyleBackColor = false;
            this.Player_Aiming_Tracer_Color.Click += new System.EventHandler(this.Player_Aiming_Tracer_Color_Click);
            // 
            // Player_Sleeping_Box_Color
            // 
            this.Player_Sleeping_Box_Color.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Player_Sleeping_Box_Color.Location = new System.Drawing.Point(377, 45);
            this.Player_Sleeping_Box_Color.Name = "Player_Sleeping_Box_Color";
            this.Player_Sleeping_Box_Color.Size = new System.Drawing.Size(75, 17);
            this.Player_Sleeping_Box_Color.TabIndex = 55;
            this.Player_Sleeping_Box_Color.UseVisualStyleBackColor = false;
            this.Player_Sleeping_Box_Color.Click += new System.EventHandler(this.Player_Sleeping_Box_Color_Click);
            // 
            // Player_Sleeping_Tracer_Color
            // 
            this.Player_Sleeping_Tracer_Color.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Player_Sleeping_Tracer_Color.Location = new System.Drawing.Point(296, 45);
            this.Player_Sleeping_Tracer_Color.Name = "Player_Sleeping_Tracer_Color";
            this.Player_Sleeping_Tracer_Color.Size = new System.Drawing.Size(75, 17);
            this.Player_Sleeping_Tracer_Color.TabIndex = 54;
            this.Player_Sleeping_Tracer_Color.UseVisualStyleBackColor = false;
            this.Player_Sleeping_Tracer_Color.Click += new System.EventHandler(this.Player_Sleeping_Tracer_Color_Click);
            // 
            // Player_Crouching_Box_Check
            // 
            this.Player_Crouching_Box_Check.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Player_Crouching_Box_Check.AutoSize = true;
            this.Player_Crouching_Box_Check.CheckAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.Player_Crouching_Box_Check.Checked = true;
            this.Player_Crouching_Box_Check.CheckState = System.Windows.Forms.CheckState.Checked;
            this.Player_Crouching_Box_Check.Location = new System.Drawing.Point(189, 117);
            this.Player_Crouching_Box_Check.Margin = new System.Windows.Forms.Padding(3, 3, 0, 0);
            this.Player_Crouching_Box_Check.Name = "Player_Crouching_Box_Check";
            this.Player_Crouching_Box_Check.Size = new System.Drawing.Size(15, 14);
            this.Player_Crouching_Box_Check.TabIndex = 38;
            this.Player_Crouching_Box_Check.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.Player_Crouching_Box_Check.UseVisualStyleBackColor = true;
            this.Player_Crouching_Box_Check.CheckedChanged += new System.EventHandler(this.Player_Crouching_Box_Check_CheckedChanged);
            // 
            // Player_Sleeping_Box_Check
            // 
            this.Player_Sleeping_Box_Check.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Player_Sleeping_Box_Check.AutoSize = true;
            this.Player_Sleeping_Box_Check.CheckAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.Player_Sleeping_Box_Check.Checked = true;
            this.Player_Sleeping_Box_Check.CheckState = System.Windows.Forms.CheckState.Checked;
            this.Player_Sleeping_Box_Check.Location = new System.Drawing.Point(189, 48);
            this.Player_Sleeping_Box_Check.Margin = new System.Windows.Forms.Padding(3, 3, 0, 0);
            this.Player_Sleeping_Box_Check.Name = "Player_Sleeping_Box_Check";
            this.Player_Sleeping_Box_Check.Size = new System.Drawing.Size(15, 14);
            this.Player_Sleeping_Box_Check.TabIndex = 34;
            this.Player_Sleeping_Box_Check.UseVisualStyleBackColor = true;
            this.Player_Sleeping_Box_Check.CheckedChanged += new System.EventHandler(this.Player_Sleeping_Box_Check_CheckedChanged);
            // 
            // Player_Sprinting_Box_Check
            // 
            this.Player_Sprinting_Box_Check.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Player_Sprinting_Box_Check.AutoSize = true;
            this.Player_Sprinting_Box_Check.CheckAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.Player_Sprinting_Box_Check.Checked = true;
            this.Player_Sprinting_Box_Check.CheckState = System.Windows.Forms.CheckState.Checked;
            this.Player_Sprinting_Box_Check.Location = new System.Drawing.Point(189, 94);
            this.Player_Sprinting_Box_Check.Margin = new System.Windows.Forms.Padding(3, 3, 0, 0);
            this.Player_Sprinting_Box_Check.Name = "Player_Sprinting_Box_Check";
            this.Player_Sprinting_Box_Check.Size = new System.Drawing.Size(15, 14);
            this.Player_Sprinting_Box_Check.TabIndex = 37;
            this.Player_Sprinting_Box_Check.UseVisualStyleBackColor = true;
            this.Player_Sprinting_Box_Check.CheckedChanged += new System.EventHandler(this.Player_Sprinting_Box_Check_CheckedChanged);
            // 
            // Player_Sleeping_Tracer_Check
            // 
            this.Player_Sleeping_Tracer_Check.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Player_Sleeping_Tracer_Check.AutoSize = true;
            this.Player_Sleeping_Tracer_Check.CheckAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.Player_Sleeping_Tracer_Check.Checked = true;
            this.Player_Sleeping_Tracer_Check.CheckState = System.Windows.Forms.CheckState.Checked;
            this.Player_Sleeping_Tracer_Check.Location = new System.Drawing.Point(147, 48);
            this.Player_Sleeping_Tracer_Check.Margin = new System.Windows.Forms.Padding(3, 3, 0, 0);
            this.Player_Sleeping_Tracer_Check.Name = "Player_Sleeping_Tracer_Check";
            this.Player_Sleeping_Tracer_Check.Size = new System.Drawing.Size(15, 14);
            this.Player_Sleeping_Tracer_Check.TabIndex = 33;
            this.Player_Sleeping_Tracer_Check.UseVisualStyleBackColor = true;
            this.Player_Sleeping_Tracer_Check.CheckedChanged += new System.EventHandler(this.Player_Sleeping_Tracer_Check_CheckedChanged);
            // 
            // PlayerSleepingLabel
            // 
            this.PlayerSleepingLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.PlayerSleepingLabel.AutoSize = true;
            this.PlayerSleepingLabel.Location = new System.Drawing.Point(3, 45);
            this.PlayerSleepingLabel.Margin = new System.Windows.Forms.Padding(3);
            this.PlayerSleepingLabel.Name = "PlayerSleepingLabel";
            this.PlayerSleepingLabel.Size = new System.Drawing.Size(75, 17);
            this.PlayerSleepingLabel.TabIndex = 31;
            this.PlayerSleepingLabel.Text = "Sleeping";
            this.PlayerSleepingLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Player_Crouching_Tracer_Check
            // 
            this.Player_Crouching_Tracer_Check.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Player_Crouching_Tracer_Check.AutoSize = true;
            this.Player_Crouching_Tracer_Check.CheckAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.Player_Crouching_Tracer_Check.Checked = true;
            this.Player_Crouching_Tracer_Check.CheckState = System.Windows.Forms.CheckState.Checked;
            this.Player_Crouching_Tracer_Check.Location = new System.Drawing.Point(147, 117);
            this.Player_Crouching_Tracer_Check.Margin = new System.Windows.Forms.Padding(3, 3, 0, 0);
            this.Player_Crouching_Tracer_Check.Name = "Player_Crouching_Tracer_Check";
            this.Player_Crouching_Tracer_Check.Size = new System.Drawing.Size(15, 14);
            this.Player_Crouching_Tracer_Check.TabIndex = 35;
            this.Player_Crouching_Tracer_Check.UseVisualStyleBackColor = true;
            this.Player_Crouching_Tracer_Check.CheckedChanged += new System.EventHandler(this.Player_Crouching_Tracer_Check_CheckedChanged);
            // 
            // Player_Awake_Radar_Color
            // 
            this.Player_Awake_Radar_Color.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Player_Awake_Radar_Color.Location = new System.Drawing.Point(215, 22);
            this.Player_Awake_Radar_Color.Name = "Player_Awake_Radar_Color";
            this.Player_Awake_Radar_Color.Size = new System.Drawing.Size(75, 17);
            this.Player_Awake_Radar_Color.TabIndex = 12;
            this.Player_Awake_Radar_Color.UseVisualStyleBackColor = false;
            this.Player_Awake_Radar_Color.Click += new System.EventHandler(this.Awake_Color_Click);
            // 
            // Player_Crouching_Radar_Color
            // 
            this.Player_Crouching_Radar_Color.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Player_Crouching_Radar_Color.Location = new System.Drawing.Point(215, 114);
            this.Player_Crouching_Radar_Color.Name = "Player_Crouching_Radar_Color";
            this.Player_Crouching_Radar_Color.Size = new System.Drawing.Size(75, 17);
            this.Player_Crouching_Radar_Color.TabIndex = 23;
            this.Player_Crouching_Radar_Color.UseVisualStyleBackColor = false;
            this.Player_Crouching_Radar_Color.Click += new System.EventHandler(this.Crouch_Color_Click);
            // 
            // Player_Loot_Corpse_Radar_Color
            // 
            this.Player_Loot_Corpse_Radar_Color.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Player_Loot_Corpse_Radar_Color.Location = new System.Drawing.Point(215, 183);
            this.Player_Loot_Corpse_Radar_Color.Name = "Player_Loot_Corpse_Radar_Color";
            this.Player_Loot_Corpse_Radar_Color.Size = new System.Drawing.Size(75, 17);
            this.Player_Loot_Corpse_Radar_Color.TabIndex = 9;
            this.Player_Loot_Corpse_Radar_Color.UseVisualStyleBackColor = false;
            this.Player_Loot_Corpse_Radar_Color.Click += new System.EventHandler(this.Loot_Corpse_Color_Click);
            // 
            // Player_Awake_Box_Check
            // 
            this.Player_Awake_Box_Check.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Player_Awake_Box_Check.AutoSize = true;
            this.Player_Awake_Box_Check.CheckAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.Player_Awake_Box_Check.Checked = true;
            this.Player_Awake_Box_Check.CheckState = System.Windows.Forms.CheckState.Checked;
            this.Player_Awake_Box_Check.Location = new System.Drawing.Point(189, 25);
            this.Player_Awake_Box_Check.Margin = new System.Windows.Forms.Padding(3, 3, 0, 0);
            this.Player_Awake_Box_Check.Name = "Player_Awake_Box_Check";
            this.Player_Awake_Box_Check.Size = new System.Drawing.Size(15, 14);
            this.Player_Awake_Box_Check.TabIndex = 30;
            this.Player_Awake_Box_Check.UseVisualStyleBackColor = true;
            this.Player_Awake_Box_Check.CheckedChanged += new System.EventHandler(this.Player_Awake_Box_Check_CheckedChanged);
            // 
            // Player_Enemy_Radar_Color
            // 
            this.Player_Enemy_Radar_Color.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Player_Enemy_Radar_Color.Location = new System.Drawing.Point(215, 160);
            this.Player_Enemy_Radar_Color.Name = "Player_Enemy_Radar_Color";
            this.Player_Enemy_Radar_Color.Size = new System.Drawing.Size(75, 17);
            this.Player_Enemy_Radar_Color.TabIndex = 7;
            this.Player_Enemy_Radar_Color.UseVisualStyleBackColor = false;
            this.Player_Enemy_Radar_Color.Click += new System.EventHandler(this.Enemy_Color_Click);
            // 
            // Player_Sprinting_Radar_Color
            // 
            this.Player_Sprinting_Radar_Color.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Player_Sprinting_Radar_Color.Location = new System.Drawing.Point(215, 91);
            this.Player_Sprinting_Radar_Color.Name = "Player_Sprinting_Radar_Color";
            this.Player_Sprinting_Radar_Color.Size = new System.Drawing.Size(75, 17);
            this.Player_Sprinting_Radar_Color.TabIndex = 16;
            this.Player_Sprinting_Radar_Color.UseVisualStyleBackColor = false;
            this.Player_Sprinting_Radar_Color.Click += new System.EventHandler(this.Sprinting_Color_Click);
            // 
            // Player_Friend_Radar_Color
            // 
            this.Player_Friend_Radar_Color.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Player_Friend_Radar_Color.Location = new System.Drawing.Point(215, 137);
            this.Player_Friend_Radar_Color.Name = "Player_Friend_Radar_Color";
            this.Player_Friend_Radar_Color.Size = new System.Drawing.Size(75, 17);
            this.Player_Friend_Radar_Color.TabIndex = 6;
            this.Player_Friend_Radar_Color.UseVisualStyleBackColor = false;
            this.Player_Friend_Radar_Color.Click += new System.EventHandler(this.Friends_Color_Click);
            // 
            // Player_Aiming_Radar_Color
            // 
            this.Player_Aiming_Radar_Color.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Player_Aiming_Radar_Color.Location = new System.Drawing.Point(215, 68);
            this.Player_Aiming_Radar_Color.Name = "Player_Aiming_Radar_Color";
            this.Player_Aiming_Radar_Color.Size = new System.Drawing.Size(75, 17);
            this.Player_Aiming_Radar_Color.TabIndex = 14;
            this.Player_Aiming_Radar_Color.UseVisualStyleBackColor = false;
            this.Player_Aiming_Radar_Color.Click += new System.EventHandler(this.Aiming_Color_Click);
            // 
            // Player_Crouching_Radar_Check
            // 
            this.Player_Crouching_Radar_Check.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Player_Crouching_Radar_Check.AutoSize = true;
            this.Player_Crouching_Radar_Check.CheckAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.Player_Crouching_Radar_Check.Checked = true;
            this.Player_Crouching_Radar_Check.CheckState = System.Windows.Forms.CheckState.Checked;
            this.Player_Crouching_Radar_Check.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Player_Crouching_Radar_Check.Location = new System.Drawing.Point(98, 117);
            this.Player_Crouching_Radar_Check.Margin = new System.Windows.Forms.Padding(3, 3, 0, 0);
            this.Player_Crouching_Radar_Check.Name = "Player_Crouching_Radar_Check";
            this.Player_Crouching_Radar_Check.Size = new System.Drawing.Size(15, 14);
            this.Player_Crouching_Radar_Check.TabIndex = 22;
            this.Player_Crouching_Radar_Check.UseVisualStyleBackColor = true;
            this.Player_Crouching_Radar_Check.CheckedChanged += new System.EventHandler(this.Player_Crouching_Radar_Check_CheckedChanged);
            // 
            // Player_Awake_Tracer_Check
            // 
            this.Player_Awake_Tracer_Check.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Player_Awake_Tracer_Check.AutoSize = true;
            this.Player_Awake_Tracer_Check.CheckAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.Player_Awake_Tracer_Check.Checked = true;
            this.Player_Awake_Tracer_Check.CheckState = System.Windows.Forms.CheckState.Checked;
            this.Player_Awake_Tracer_Check.Location = new System.Drawing.Point(147, 25);
            this.Player_Awake_Tracer_Check.Margin = new System.Windows.Forms.Padding(3, 3, 0, 0);
            this.Player_Awake_Tracer_Check.Name = "Player_Awake_Tracer_Check";
            this.Player_Awake_Tracer_Check.Size = new System.Drawing.Size(15, 14);
            this.Player_Awake_Tracer_Check.TabIndex = 29;
            this.Player_Awake_Tracer_Check.UseVisualStyleBackColor = true;
            this.Player_Awake_Tracer_Check.CheckedChanged += new System.EventHandler(this.Player_Awake_Tracer_Check_CheckedChanged);
            // 
            // Player_Sleeping_Radar_Color
            // 
            this.Player_Sleeping_Radar_Color.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Player_Sleeping_Radar_Color.Location = new System.Drawing.Point(215, 45);
            this.Player_Sleeping_Radar_Color.Name = "Player_Sleeping_Radar_Color";
            this.Player_Sleeping_Radar_Color.Size = new System.Drawing.Size(75, 17);
            this.Player_Sleeping_Radar_Color.TabIndex = 5;
            this.Player_Sleeping_Radar_Color.UseVisualStyleBackColor = false;
            this.Player_Sleeping_Radar_Color.Click += new System.EventHandler(this.Sleeping_Color_Click);
            // 
            // Player_Awake_Radar_Check
            // 
            this.Player_Awake_Radar_Check.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Player_Awake_Radar_Check.AutoSize = true;
            this.Player_Awake_Radar_Check.CheckAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.Player_Awake_Radar_Check.Checked = true;
            this.Player_Awake_Radar_Check.CheckState = System.Windows.Forms.CheckState.Checked;
            this.Player_Awake_Radar_Check.Location = new System.Drawing.Point(98, 25);
            this.Player_Awake_Radar_Check.Margin = new System.Windows.Forms.Padding(3, 3, 0, 0);
            this.Player_Awake_Radar_Check.Name = "Player_Awake_Radar_Check";
            this.Player_Awake_Radar_Check.Size = new System.Drawing.Size(15, 14);
            this.Player_Awake_Radar_Check.TabIndex = 11;
            this.Player_Awake_Radar_Check.UseVisualStyleBackColor = true;
            this.Player_Awake_Radar_Check.CheckedChanged += new System.EventHandler(this.Player_Awake_Radar_Check_CheckedChanged);
            // 
            // PlayerAwakeLabel
            // 
            this.PlayerAwakeLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.PlayerAwakeLabel.AutoSize = true;
            this.PlayerAwakeLabel.Location = new System.Drawing.Point(3, 22);
            this.PlayerAwakeLabel.Margin = new System.Windows.Forms.Padding(3);
            this.PlayerAwakeLabel.Name = "PlayerAwakeLabel";
            this.PlayerAwakeLabel.Size = new System.Drawing.Size(75, 17);
            this.PlayerAwakeLabel.TabIndex = 12;
            this.PlayerAwakeLabel.Text = "Awake";
            this.PlayerAwakeLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Player_Awake_Tracer_Color
            // 
            this.Player_Awake_Tracer_Color.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Player_Awake_Tracer_Color.Location = new System.Drawing.Point(296, 22);
            this.Player_Awake_Tracer_Color.Name = "Player_Awake_Tracer_Color";
            this.Player_Awake_Tracer_Color.Size = new System.Drawing.Size(75, 17);
            this.Player_Awake_Tracer_Color.TabIndex = 27;
            this.Player_Awake_Tracer_Color.UseVisualStyleBackColor = false;
            this.Player_Awake_Tracer_Color.Click += new System.EventHandler(this.Player_Awake_Tracer_Color_Click);
            // 
            // Player_Sprinting_Radar_Check
            // 
            this.Player_Sprinting_Radar_Check.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Player_Sprinting_Radar_Check.AutoSize = true;
            this.Player_Sprinting_Radar_Check.CheckAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.Player_Sprinting_Radar_Check.Checked = true;
            this.Player_Sprinting_Radar_Check.CheckState = System.Windows.Forms.CheckState.Checked;
            this.Player_Sprinting_Radar_Check.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Player_Sprinting_Radar_Check.Location = new System.Drawing.Point(98, 94);
            this.Player_Sprinting_Radar_Check.Margin = new System.Windows.Forms.Padding(3, 3, 0, 0);
            this.Player_Sprinting_Radar_Check.Name = "Player_Sprinting_Radar_Check";
            this.Player_Sprinting_Radar_Check.Size = new System.Drawing.Size(15, 14);
            this.Player_Sprinting_Radar_Check.TabIndex = 15;
            this.Player_Sprinting_Radar_Check.UseVisualStyleBackColor = true;
            this.Player_Sprinting_Radar_Check.CheckedChanged += new System.EventHandler(this.Sprinting_Check_CheckedChanged);
            // 
            // Player_Awake_Box_Color
            // 
            this.Player_Awake_Box_Color.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Player_Awake_Box_Color.Location = new System.Drawing.Point(377, 22);
            this.Player_Awake_Box_Color.Name = "Player_Awake_Box_Color";
            this.Player_Awake_Box_Color.Size = new System.Drawing.Size(75, 17);
            this.Player_Awake_Box_Color.TabIndex = 28;
            this.Player_Awake_Box_Color.UseVisualStyleBackColor = false;
            this.Player_Awake_Box_Color.Click += new System.EventHandler(this.Player_Awake_Box_Color_Click);
            // 
            // PlayerAimingLabel
            // 
            this.PlayerAimingLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.PlayerAimingLabel.AutoSize = true;
            this.PlayerAimingLabel.Location = new System.Drawing.Point(3, 68);
            this.PlayerAimingLabel.Margin = new System.Windows.Forms.Padding(3);
            this.PlayerAimingLabel.Name = "PlayerAimingLabel";
            this.PlayerAimingLabel.Size = new System.Drawing.Size(75, 17);
            this.PlayerAimingLabel.TabIndex = 32;
            this.PlayerAimingLabel.Text = "Aiming";
            this.PlayerAimingLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Player_Aiming_Radar_Check
            // 
            this.Player_Aiming_Radar_Check.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Player_Aiming_Radar_Check.AutoSize = true;
            this.Player_Aiming_Radar_Check.CheckAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.Player_Aiming_Radar_Check.Checked = true;
            this.Player_Aiming_Radar_Check.CheckState = System.Windows.Forms.CheckState.Checked;
            this.Player_Aiming_Radar_Check.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Player_Aiming_Radar_Check.Location = new System.Drawing.Point(98, 71);
            this.Player_Aiming_Radar_Check.Margin = new System.Windows.Forms.Padding(3, 3, 0, 0);
            this.Player_Aiming_Radar_Check.Name = "Player_Aiming_Radar_Check";
            this.Player_Aiming_Radar_Check.Size = new System.Drawing.Size(15, 14);
            this.Player_Aiming_Radar_Check.TabIndex = 13;
            this.Player_Aiming_Radar_Check.UseVisualStyleBackColor = true;
            this.Player_Aiming_Radar_Check.CheckedChanged += new System.EventHandler(this.Aiming_Check_CheckedChanged);
            // 
            // Player_Loot_Corpse_Radar_Check
            // 
            this.Player_Loot_Corpse_Radar_Check.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Player_Loot_Corpse_Radar_Check.AutoSize = true;
            this.Player_Loot_Corpse_Radar_Check.CheckAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.Player_Loot_Corpse_Radar_Check.Checked = true;
            this.Player_Loot_Corpse_Radar_Check.CheckState = System.Windows.Forms.CheckState.Checked;
            this.Player_Loot_Corpse_Radar_Check.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Player_Loot_Corpse_Radar_Check.Location = new System.Drawing.Point(98, 186);
            this.Player_Loot_Corpse_Radar_Check.Margin = new System.Windows.Forms.Padding(3, 3, 0, 0);
            this.Player_Loot_Corpse_Radar_Check.Name = "Player_Loot_Corpse_Radar_Check";
            this.Player_Loot_Corpse_Radar_Check.Size = new System.Drawing.Size(15, 14);
            this.Player_Loot_Corpse_Radar_Check.TabIndex = 4;
            this.Player_Loot_Corpse_Radar_Check.UseVisualStyleBackColor = true;
            this.Player_Loot_Corpse_Radar_Check.CheckedChanged += new System.EventHandler(this.Loot_Corpse_Check_CheckedChanged);
            // 
            // Player_Sleeping_Radar_Check
            // 
            this.Player_Sleeping_Radar_Check.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Player_Sleeping_Radar_Check.AutoSize = true;
            this.Player_Sleeping_Radar_Check.CheckAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.Player_Sleeping_Radar_Check.Checked = true;
            this.Player_Sleeping_Radar_Check.CheckState = System.Windows.Forms.CheckState.Checked;
            this.Player_Sleeping_Radar_Check.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Player_Sleeping_Radar_Check.Location = new System.Drawing.Point(98, 48);
            this.Player_Sleeping_Radar_Check.Margin = new System.Windows.Forms.Padding(3, 3, 0, 0);
            this.Player_Sleeping_Radar_Check.Name = "Player_Sleeping_Radar_Check";
            this.Player_Sleeping_Radar_Check.Size = new System.Drawing.Size(15, 14);
            this.Player_Sleeping_Radar_Check.TabIndex = 0;
            this.Player_Sleeping_Radar_Check.UseVisualStyleBackColor = true;
            this.Player_Sleeping_Radar_Check.CheckedChanged += new System.EventHandler(this.Sleeping_Check_CheckedChanged);
            // 
            // Player_Enemy_Radar_Check
            // 
            this.Player_Enemy_Radar_Check.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Player_Enemy_Radar_Check.AutoSize = true;
            this.Player_Enemy_Radar_Check.CheckAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.Player_Enemy_Radar_Check.Checked = true;
            this.Player_Enemy_Radar_Check.CheckState = System.Windows.Forms.CheckState.Checked;
            this.Player_Enemy_Radar_Check.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Player_Enemy_Radar_Check.Location = new System.Drawing.Point(98, 163);
            this.Player_Enemy_Radar_Check.Margin = new System.Windows.Forms.Padding(3, 3, 0, 0);
            this.Player_Enemy_Radar_Check.Name = "Player_Enemy_Radar_Check";
            this.Player_Enemy_Radar_Check.Size = new System.Drawing.Size(15, 14);
            this.Player_Enemy_Radar_Check.TabIndex = 2;
            this.Player_Enemy_Radar_Check.UseVisualStyleBackColor = true;
            this.Player_Enemy_Radar_Check.CheckedChanged += new System.EventHandler(this.Enemy_Check_CheckedChanged);
            // 
            // Player_Friend_Radar_Check
            // 
            this.Player_Friend_Radar_Check.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Player_Friend_Radar_Check.AutoSize = true;
            this.Player_Friend_Radar_Check.CheckAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.Player_Friend_Radar_Check.Checked = true;
            this.Player_Friend_Radar_Check.CheckState = System.Windows.Forms.CheckState.Checked;
            this.Player_Friend_Radar_Check.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Player_Friend_Radar_Check.Location = new System.Drawing.Point(98, 140);
            this.Player_Friend_Radar_Check.Margin = new System.Windows.Forms.Padding(3, 3, 0, 0);
            this.Player_Friend_Radar_Check.Name = "Player_Friend_Radar_Check";
            this.Player_Friend_Radar_Check.Size = new System.Drawing.Size(15, 14);
            this.Player_Friend_Radar_Check.TabIndex = 1;
            this.Player_Friend_Radar_Check.UseVisualStyleBackColor = true;
            this.Player_Friend_Radar_Check.CheckedChanged += new System.EventHandler(this.Friends_Check_CheckedChanged);
            // 
            // Player_Aiming_Tracer_Check
            // 
            this.Player_Aiming_Tracer_Check.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Player_Aiming_Tracer_Check.AutoSize = true;
            this.Player_Aiming_Tracer_Check.CheckAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.Player_Aiming_Tracer_Check.Checked = true;
            this.Player_Aiming_Tracer_Check.CheckState = System.Windows.Forms.CheckState.Checked;
            this.Player_Aiming_Tracer_Check.Location = new System.Drawing.Point(147, 71);
            this.Player_Aiming_Tracer_Check.Margin = new System.Windows.Forms.Padding(3, 3, 0, 0);
            this.Player_Aiming_Tracer_Check.Name = "Player_Aiming_Tracer_Check";
            this.Player_Aiming_Tracer_Check.Size = new System.Drawing.Size(15, 14);
            this.Player_Aiming_Tracer_Check.TabIndex = 35;
            this.Player_Aiming_Tracer_Check.UseVisualStyleBackColor = true;
            this.Player_Aiming_Tracer_Check.CheckedChanged += new System.EventHandler(this.Player_Aiming_Tracer_Check_CheckedChanged);
            // 
            // Player_Aiming_Box_Check
            // 
            this.Player_Aiming_Box_Check.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Player_Aiming_Box_Check.AutoSize = true;
            this.Player_Aiming_Box_Check.CheckAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.Player_Aiming_Box_Check.Checked = true;
            this.Player_Aiming_Box_Check.CheckState = System.Windows.Forms.CheckState.Checked;
            this.Player_Aiming_Box_Check.Location = new System.Drawing.Point(189, 71);
            this.Player_Aiming_Box_Check.Margin = new System.Windows.Forms.Padding(3, 3, 0, 0);
            this.Player_Aiming_Box_Check.Name = "Player_Aiming_Box_Check";
            this.Player_Aiming_Box_Check.Size = new System.Drawing.Size(15, 14);
            this.Player_Aiming_Box_Check.TabIndex = 36;
            this.Player_Aiming_Box_Check.UseVisualStyleBackColor = true;
            this.Player_Aiming_Box_Check.CheckedChanged += new System.EventHandler(this.Player_Aiming_Box_Check_CheckedChanged);
            // 
            // Player_Sprinting_Tracer_Check
            // 
            this.Player_Sprinting_Tracer_Check.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Player_Sprinting_Tracer_Check.AutoSize = true;
            this.Player_Sprinting_Tracer_Check.CheckAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.Player_Sprinting_Tracer_Check.Checked = true;
            this.Player_Sprinting_Tracer_Check.CheckState = System.Windows.Forms.CheckState.Checked;
            this.Player_Sprinting_Tracer_Check.Location = new System.Drawing.Point(147, 94);
            this.Player_Sprinting_Tracer_Check.Margin = new System.Windows.Forms.Padding(3, 3, 0, 0);
            this.Player_Sprinting_Tracer_Check.Name = "Player_Sprinting_Tracer_Check";
            this.Player_Sprinting_Tracer_Check.Size = new System.Drawing.Size(15, 14);
            this.Player_Sprinting_Tracer_Check.TabIndex = 37;
            this.Player_Sprinting_Tracer_Check.UseVisualStyleBackColor = true;
            this.Player_Sprinting_Tracer_Check.CheckedChanged += new System.EventHandler(this.Player_Sprinting_Tracer_Check_CheckedChanged);
            // 
            // PlayerSprintingLabel
            // 
            this.PlayerSprintingLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.PlayerSprintingLabel.AutoSize = true;
            this.PlayerSprintingLabel.Location = new System.Drawing.Point(3, 91);
            this.PlayerSprintingLabel.Margin = new System.Windows.Forms.Padding(3);
            this.PlayerSprintingLabel.Name = "PlayerSprintingLabel";
            this.PlayerSprintingLabel.Size = new System.Drawing.Size(75, 17);
            this.PlayerSprintingLabel.TabIndex = 39;
            this.PlayerSprintingLabel.Text = "Sprinting";
            this.PlayerSprintingLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // PlayerCrouchingLabel
            // 
            this.PlayerCrouchingLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.PlayerCrouchingLabel.AutoSize = true;
            this.PlayerCrouchingLabel.Location = new System.Drawing.Point(3, 114);
            this.PlayerCrouchingLabel.Margin = new System.Windows.Forms.Padding(3);
            this.PlayerCrouchingLabel.Name = "PlayerCrouchingLabel";
            this.PlayerCrouchingLabel.Size = new System.Drawing.Size(75, 17);
            this.PlayerCrouchingLabel.TabIndex = 40;
            this.PlayerCrouchingLabel.Text = "Crouching";
            this.PlayerCrouchingLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // PlayerFriendsLabel
            // 
            this.PlayerFriendsLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.PlayerFriendsLabel.AutoSize = true;
            this.PlayerFriendsLabel.Location = new System.Drawing.Point(3, 137);
            this.PlayerFriendsLabel.Margin = new System.Windows.Forms.Padding(3);
            this.PlayerFriendsLabel.Name = "PlayerFriendsLabel";
            this.PlayerFriendsLabel.Size = new System.Drawing.Size(75, 17);
            this.PlayerFriendsLabel.TabIndex = 41;
            this.PlayerFriendsLabel.Text = "Friends";
            this.PlayerFriendsLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // PlayerEnemyLabel
            // 
            this.PlayerEnemyLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.PlayerEnemyLabel.AutoSize = true;
            this.PlayerEnemyLabel.Location = new System.Drawing.Point(3, 160);
            this.PlayerEnemyLabel.Margin = new System.Windows.Forms.Padding(3);
            this.PlayerEnemyLabel.Name = "PlayerEnemyLabel";
            this.PlayerEnemyLabel.Size = new System.Drawing.Size(75, 17);
            this.PlayerEnemyLabel.TabIndex = 42;
            this.PlayerEnemyLabel.Text = "Enemy";
            this.PlayerEnemyLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // PlayerLootCorpseLabel
            // 
            this.PlayerLootCorpseLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.PlayerLootCorpseLabel.AutoSize = true;
            this.PlayerLootCorpseLabel.Location = new System.Drawing.Point(3, 183);
            this.PlayerLootCorpseLabel.Margin = new System.Windows.Forms.Padding(3);
            this.PlayerLootCorpseLabel.Name = "PlayerLootCorpseLabel";
            this.PlayerLootCorpseLabel.Size = new System.Drawing.Size(75, 17);
            this.PlayerLootCorpseLabel.TabIndex = 43;
            this.PlayerLootCorpseLabel.Text = "Loot Corpse";
            this.PlayerLootCorpseLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Player_Friend_Tracer_Check
            // 
            this.Player_Friend_Tracer_Check.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Player_Friend_Tracer_Check.AutoSize = true;
            this.Player_Friend_Tracer_Check.CheckAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.Player_Friend_Tracer_Check.Checked = true;
            this.Player_Friend_Tracer_Check.CheckState = System.Windows.Forms.CheckState.Checked;
            this.Player_Friend_Tracer_Check.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Player_Friend_Tracer_Check.Location = new System.Drawing.Point(147, 140);
            this.Player_Friend_Tracer_Check.Margin = new System.Windows.Forms.Padding(3, 3, 0, 0);
            this.Player_Friend_Tracer_Check.Name = "Player_Friend_Tracer_Check";
            this.Player_Friend_Tracer_Check.Size = new System.Drawing.Size(15, 14);
            this.Player_Friend_Tracer_Check.TabIndex = 48;
            this.Player_Friend_Tracer_Check.UseVisualStyleBackColor = true;
            this.Player_Friend_Tracer_Check.CheckedChanged += new System.EventHandler(this.Player_Friends_Tracer_Check_CheckedChanged);
            // 
            // Player_Friend_Box_Check
            // 
            this.Player_Friend_Box_Check.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Player_Friend_Box_Check.AutoSize = true;
            this.Player_Friend_Box_Check.CheckAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.Player_Friend_Box_Check.Checked = true;
            this.Player_Friend_Box_Check.CheckState = System.Windows.Forms.CheckState.Checked;
            this.Player_Friend_Box_Check.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Player_Friend_Box_Check.Location = new System.Drawing.Point(189, 140);
            this.Player_Friend_Box_Check.Margin = new System.Windows.Forms.Padding(3, 3, 0, 0);
            this.Player_Friend_Box_Check.Name = "Player_Friend_Box_Check";
            this.Player_Friend_Box_Check.Size = new System.Drawing.Size(15, 14);
            this.Player_Friend_Box_Check.TabIndex = 49;
            this.Player_Friend_Box_Check.UseVisualStyleBackColor = true;
            this.Player_Friend_Box_Check.CheckedChanged += new System.EventHandler(this.Player_Friend_Box_Check_CheckedChanged);
            // 
            // Player_Enemy_Box_Check
            // 
            this.Player_Enemy_Box_Check.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Player_Enemy_Box_Check.AutoSize = true;
            this.Player_Enemy_Box_Check.CheckAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.Player_Enemy_Box_Check.Checked = true;
            this.Player_Enemy_Box_Check.CheckState = System.Windows.Forms.CheckState.Checked;
            this.Player_Enemy_Box_Check.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Player_Enemy_Box_Check.Location = new System.Drawing.Point(189, 163);
            this.Player_Enemy_Box_Check.Margin = new System.Windows.Forms.Padding(3, 3, 0, 0);
            this.Player_Enemy_Box_Check.Name = "Player_Enemy_Box_Check";
            this.Player_Enemy_Box_Check.Size = new System.Drawing.Size(15, 14);
            this.Player_Enemy_Box_Check.TabIndex = 50;
            this.Player_Enemy_Box_Check.UseVisualStyleBackColor = true;
            this.Player_Enemy_Box_Check.CheckedChanged += new System.EventHandler(this.Player_Enemy_Box_Check_CheckedChanged);
            // 
            // Player_Enemy_Tracer_Check
            // 
            this.Player_Enemy_Tracer_Check.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Player_Enemy_Tracer_Check.AutoSize = true;
            this.Player_Enemy_Tracer_Check.CheckAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.Player_Enemy_Tracer_Check.Checked = true;
            this.Player_Enemy_Tracer_Check.CheckState = System.Windows.Forms.CheckState.Checked;
            this.Player_Enemy_Tracer_Check.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Player_Enemy_Tracer_Check.Location = new System.Drawing.Point(147, 163);
            this.Player_Enemy_Tracer_Check.Margin = new System.Windows.Forms.Padding(3, 3, 0, 0);
            this.Player_Enemy_Tracer_Check.Name = "Player_Enemy_Tracer_Check";
            this.Player_Enemy_Tracer_Check.Size = new System.Drawing.Size(15, 14);
            this.Player_Enemy_Tracer_Check.TabIndex = 51;
            this.Player_Enemy_Tracer_Check.UseVisualStyleBackColor = true;
            this.Player_Enemy_Tracer_Check.CheckedChanged += new System.EventHandler(this.Player_Enemy_Tracer_Check_CheckedChanged);
            // 
            // Player_Loot_Corpse_Tracer_Check
            // 
            this.Player_Loot_Corpse_Tracer_Check.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Player_Loot_Corpse_Tracer_Check.AutoSize = true;
            this.Player_Loot_Corpse_Tracer_Check.CheckAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.Player_Loot_Corpse_Tracer_Check.Checked = true;
            this.Player_Loot_Corpse_Tracer_Check.CheckState = System.Windows.Forms.CheckState.Checked;
            this.Player_Loot_Corpse_Tracer_Check.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Player_Loot_Corpse_Tracer_Check.Location = new System.Drawing.Point(147, 186);
            this.Player_Loot_Corpse_Tracer_Check.Margin = new System.Windows.Forms.Padding(3, 3, 0, 0);
            this.Player_Loot_Corpse_Tracer_Check.Name = "Player_Loot_Corpse_Tracer_Check";
            this.Player_Loot_Corpse_Tracer_Check.Size = new System.Drawing.Size(15, 14);
            this.Player_Loot_Corpse_Tracer_Check.TabIndex = 52;
            this.Player_Loot_Corpse_Tracer_Check.UseVisualStyleBackColor = true;
            this.Player_Loot_Corpse_Tracer_Check.CheckedChanged += new System.EventHandler(this.Player_Loot_Corpse_Tracer_Check_CheckedChanged);
            // 
            // Player_Loot_Corpse_Box_Check
            // 
            this.Player_Loot_Corpse_Box_Check.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Player_Loot_Corpse_Box_Check.AutoSize = true;
            this.Player_Loot_Corpse_Box_Check.CheckAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.Player_Loot_Corpse_Box_Check.Checked = true;
            this.Player_Loot_Corpse_Box_Check.CheckState = System.Windows.Forms.CheckState.Checked;
            this.Player_Loot_Corpse_Box_Check.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Player_Loot_Corpse_Box_Check.Location = new System.Drawing.Point(189, 186);
            this.Player_Loot_Corpse_Box_Check.Margin = new System.Windows.Forms.Padding(3, 3, 0, 0);
            this.Player_Loot_Corpse_Box_Check.Name = "Player_Loot_Corpse_Box_Check";
            this.Player_Loot_Corpse_Box_Check.Size = new System.Drawing.Size(15, 14);
            this.Player_Loot_Corpse_Box_Check.TabIndex = 53;
            this.Player_Loot_Corpse_Box_Check.UseVisualStyleBackColor = true;
            this.Player_Loot_Corpse_Box_Check.CheckedChanged += new System.EventHandler(this.Player_Loot_Corpse_Box_Check_CheckedChanged);
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(84, 3);
            this.label2.Margin = new System.Windows.Forms.Padding(3);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(41, 13);
            this.label2.TabIndex = 75;
            this.label2.Text = "Radar";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(131, 3);
            this.label3.Margin = new System.Windows.Forms.Padding(3);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(44, 13);
            this.label3.TabIndex = 76;
            this.label3.Text = "Tracer";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(181, 3);
            this.label4.Margin = new System.Windows.Forms.Padding(3);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(28, 13);
            this.label4.TabIndex = 77;
            this.label4.Text = "Box";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label6
            // 
            this.label6.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(215, 3);
            this.label6.Margin = new System.Windows.Forms.Padding(3);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(75, 13);
            this.label6.TabIndex = 79;
            this.label6.Text = "Radar";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label5
            // 
            this.label5.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(296, 3);
            this.label5.Margin = new System.Windows.Forms.Padding(3);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(75, 13);
            this.label5.TabIndex = 78;
            this.label5.Text = "Tracer";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label7
            // 
            this.label7.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(377, 3);
            this.label7.Margin = new System.Windows.Forms.Padding(3);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(75, 13);
            this.label7.TabIndex = 80;
            this.label7.Text = "Box";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Animals_TAB
            // 
            this.Animals_TAB.BackColor = System.Drawing.Color.White;
            this.Animals_TAB.Controls.Add(this.tableLayoutPanel4);
            this.Animals_TAB.Location = new System.Drawing.Point(4, 22);
            this.Animals_TAB.Name = "Animals_TAB";
            this.Animals_TAB.Padding = new System.Windows.Forms.Padding(3);
            this.Animals_TAB.Size = new System.Drawing.Size(568, 552);
            this.Animals_TAB.TabIndex = 1;
            this.Animals_TAB.Text = "Animals";
            // 
            // tableLayoutPanel4
            // 
            this.tableLayoutPanel4.ColumnCount = 8;
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 64F));
            this.tableLayoutPanel4.Controls.Add(this.Animals_Wolf_Radar_Color, 4, 1);
            this.tableLayoutPanel4.Controls.Add(this.Animals_Bear_Radar_Color, 4, 2);
            this.tableLayoutPanel4.Controls.Add(this.Animals_Bear_Box_Color, 6, 2);
            this.tableLayoutPanel4.Controls.Add(this.Animals_Wolf_Box_Color, 6, 1);
            this.tableLayoutPanel4.Controls.Add(this.label23, 6, 0);
            this.tableLayoutPanel4.Controls.Add(this.label24, 0, 1);
            this.tableLayoutPanel4.Controls.Add(this.label25, 0, 2);
            this.tableLayoutPanel4.Controls.Add(this.Animals_Bear_Box_Check, 3, 2);
            this.tableLayoutPanel4.Controls.Add(this.Animals_Wolf_Radar_Check, 1, 1);
            this.tableLayoutPanel4.Controls.Add(this.Animals_Bear_Radar_Check, 1, 2);
            this.tableLayoutPanel4.Controls.Add(this.Animals_Wolf_Box_Check, 3, 1);
            this.tableLayoutPanel4.Controls.Add(this.label26, 1, 0);
            this.tableLayoutPanel4.Controls.Add(this.label27, 3, 0);
            this.tableLayoutPanel4.Controls.Add(this.label28, 4, 0);
            this.tableLayoutPanel4.Controls.Add(this.label29, 2, 0);
            this.tableLayoutPanel4.Controls.Add(this.label30, 5, 0);
            this.tableLayoutPanel4.Controls.Add(this.Animals_Wolf_Tracer_Color, 5, 1);
            this.tableLayoutPanel4.Controls.Add(this.Animals_Bear_Tracer_Color, 5, 2);
            this.tableLayoutPanel4.Controls.Add(this.Animals_Wolf_Tracer_Check, 2, 1);
            this.tableLayoutPanel4.Controls.Add(this.Animals_Bear_Tracer_Check, 2, 2);
            this.tableLayoutPanel4.Controls.Add(this.label22, 0, 3);
            this.tableLayoutPanel4.Controls.Add(this.label31, 0, 4);
            this.tableLayoutPanel4.Controls.Add(this.label32, 0, 5);
            this.tableLayoutPanel4.Controls.Add(this.label33, 0, 6);
            this.tableLayoutPanel4.Controls.Add(this.Animals_Deer_Radar_Check, 1, 3);
            this.tableLayoutPanel4.Controls.Add(this.Animals_Chicken_Radar_Check, 1, 4);
            this.tableLayoutPanel4.Controls.Add(this.Animals_Boar_Radar_Check, 1, 5);
            this.tableLayoutPanel4.Controls.Add(this.Animals_Horse_Radar_Check, 1, 6);
            this.tableLayoutPanel4.Controls.Add(this.Animals_Deer_Tracer_Check, 2, 3);
            this.tableLayoutPanel4.Controls.Add(this.Animals_Chicken_Tracer_Check, 2, 4);
            this.tableLayoutPanel4.Controls.Add(this.Animals_Boar_Tracer_Check, 2, 5);
            this.tableLayoutPanel4.Controls.Add(this.Animals_Horse_Tracer_Check, 2, 6);
            this.tableLayoutPanel4.Controls.Add(this.Animals_Deer_Box_Check, 3, 3);
            this.tableLayoutPanel4.Controls.Add(this.Animals_Chicken_Box_Check, 3, 4);
            this.tableLayoutPanel4.Controls.Add(this.Animals_Boar_Box_Check, 3, 5);
            this.tableLayoutPanel4.Controls.Add(this.Animals_Horse_Box_Check, 3, 6);
            this.tableLayoutPanel4.Controls.Add(this.Animals_Deer_Radar_Color, 4, 3);
            this.tableLayoutPanel4.Controls.Add(this.Animals_Chicken_Radar_Color, 4, 4);
            this.tableLayoutPanel4.Controls.Add(this.Animals_Boar_Radar_Color, 4, 5);
            this.tableLayoutPanel4.Controls.Add(this.Animals_Horse_Radar_Color, 4, 6);
            this.tableLayoutPanel4.Controls.Add(this.Animals_Deer_Tracer_Color, 5, 3);
            this.tableLayoutPanel4.Controls.Add(this.Animals_Deer_Box_Color, 6, 3);
            this.tableLayoutPanel4.Controls.Add(this.Animals_Chicken_Tracer_Color, 5, 4);
            this.tableLayoutPanel4.Controls.Add(this.Animals_Boar_Tracer_Color, 5, 5);
            this.tableLayoutPanel4.Controls.Add(this.Animals_Horse_Tracer_Color, 5, 6);
            this.tableLayoutPanel4.Controls.Add(this.Animals_Chicken_Box_Color, 6, 4);
            this.tableLayoutPanel4.Controls.Add(this.Animals_Boar_Box_Color, 6, 5);
            this.tableLayoutPanel4.Controls.Add(this.Animals_Horse_Box_Color, 6, 6);
            this.tableLayoutPanel4.Location = new System.Drawing.Point(6, 6);
            this.tableLayoutPanel4.Name = "tableLayoutPanel4";
            this.tableLayoutPanel4.RowCount = 8;
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel4.Size = new System.Drawing.Size(497, 322);
            this.tableLayoutPanel4.TabIndex = 29;
            // 
            // Animals_Wolf_Radar_Color
            // 
            this.Animals_Wolf_Radar_Color.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Animals_Wolf_Radar_Color.Location = new System.Drawing.Point(193, 22);
            this.Animals_Wolf_Radar_Color.Name = "Animals_Wolf_Radar_Color";
            this.Animals_Wolf_Radar_Color.Size = new System.Drawing.Size(75, 17);
            this.Animals_Wolf_Radar_Color.TabIndex = 9;
            this.Animals_Wolf_Radar_Color.UseVisualStyleBackColor = false;
            this.Animals_Wolf_Radar_Color.Click += new System.EventHandler(this.Wolf_Color_Click);
            // 
            // Animals_Bear_Radar_Color
            // 
            this.Animals_Bear_Radar_Color.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Animals_Bear_Radar_Color.Location = new System.Drawing.Point(193, 45);
            this.Animals_Bear_Radar_Color.Name = "Animals_Bear_Radar_Color";
            this.Animals_Bear_Radar_Color.Size = new System.Drawing.Size(75, 17);
            this.Animals_Bear_Radar_Color.TabIndex = 7;
            this.Animals_Bear_Radar_Color.UseVisualStyleBackColor = false;
            this.Animals_Bear_Radar_Color.Click += new System.EventHandler(this.Bear_Color_Click);
            // 
            // Animals_Bear_Box_Color
            // 
            this.Animals_Bear_Box_Color.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Animals_Bear_Box_Color.Location = new System.Drawing.Point(355, 45);
            this.Animals_Bear_Box_Color.Name = "Animals_Bear_Box_Color";
            this.Animals_Bear_Box_Color.Size = new System.Drawing.Size(75, 17);
            this.Animals_Bear_Box_Color.TabIndex = 28;
            this.Animals_Bear_Box_Color.UseVisualStyleBackColor = false;
            this.Animals_Bear_Box_Color.Click += new System.EventHandler(this.Animals_Bear_Box_Color_Click);
            // 
            // Animals_Wolf_Box_Color
            // 
            this.Animals_Wolf_Box_Color.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Animals_Wolf_Box_Color.Location = new System.Drawing.Point(355, 22);
            this.Animals_Wolf_Box_Color.Name = "Animals_Wolf_Box_Color";
            this.Animals_Wolf_Box_Color.Size = new System.Drawing.Size(75, 17);
            this.Animals_Wolf_Box_Color.TabIndex = 28;
            this.Animals_Wolf_Box_Color.UseVisualStyleBackColor = false;
            this.Animals_Wolf_Box_Color.Click += new System.EventHandler(this.Animals_Wolf_Box_Color_Click);
            // 
            // label23
            // 
            this.label23.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label23.AutoSize = true;
            this.label23.Location = new System.Drawing.Point(355, 3);
            this.label23.Margin = new System.Windows.Forms.Padding(3);
            this.label23.Name = "label23";
            this.label23.Size = new System.Drawing.Size(75, 13);
            this.label23.TabIndex = 76;
            this.label23.Text = "Box";
            this.label23.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label24
            // 
            this.label24.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label24.AutoSize = true;
            this.label24.Location = new System.Drawing.Point(3, 22);
            this.label24.Margin = new System.Windows.Forms.Padding(3);
            this.label24.Name = "label24";
            this.label24.Size = new System.Drawing.Size(53, 17);
            this.label24.TabIndex = 46;
            this.label24.Text = "Wolf";
            this.label24.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label25
            // 
            this.label25.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label25.AutoSize = true;
            this.label25.Location = new System.Drawing.Point(3, 45);
            this.label25.Margin = new System.Windows.Forms.Padding(3);
            this.label25.Name = "label25";
            this.label25.Size = new System.Drawing.Size(53, 17);
            this.label25.TabIndex = 44;
            this.label25.Text = "Bear";
            this.label25.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Animals_Bear_Box_Check
            // 
            this.Animals_Bear_Box_Check.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Animals_Bear_Box_Check.AutoSize = true;
            this.Animals_Bear_Box_Check.CheckAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.Animals_Bear_Box_Check.Checked = true;
            this.Animals_Bear_Box_Check.CheckState = System.Windows.Forms.CheckState.Checked;
            this.Animals_Bear_Box_Check.Location = new System.Drawing.Point(167, 48);
            this.Animals_Bear_Box_Check.Margin = new System.Windows.Forms.Padding(3, 3, 0, 0);
            this.Animals_Bear_Box_Check.Name = "Animals_Bear_Box_Check";
            this.Animals_Bear_Box_Check.Size = new System.Drawing.Size(15, 14);
            this.Animals_Bear_Box_Check.TabIndex = 32;
            this.Animals_Bear_Box_Check.UseVisualStyleBackColor = true;
            this.Animals_Bear_Box_Check.CheckedChanged += new System.EventHandler(this.Animals_Bear_Box_Check_CheckedChanged);
            // 
            // Animals_Wolf_Radar_Check
            // 
            this.Animals_Wolf_Radar_Check.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Animals_Wolf_Radar_Check.AutoSize = true;
            this.Animals_Wolf_Radar_Check.Checked = true;
            this.Animals_Wolf_Radar_Check.CheckState = System.Windows.Forms.CheckState.Checked;
            this.Animals_Wolf_Radar_Check.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Animals_Wolf_Radar_Check.Location = new System.Drawing.Point(76, 25);
            this.Animals_Wolf_Radar_Check.Margin = new System.Windows.Forms.Padding(3, 3, 0, 0);
            this.Animals_Wolf_Radar_Check.Name = "Animals_Wolf_Radar_Check";
            this.Animals_Wolf_Radar_Check.Size = new System.Drawing.Size(15, 14);
            this.Animals_Wolf_Radar_Check.TabIndex = 3;
            this.Animals_Wolf_Radar_Check.UseVisualStyleBackColor = true;
            this.Animals_Wolf_Radar_Check.CheckedChanged += new System.EventHandler(this.Wolf_Check_CheckedChanged);
            // 
            // Animals_Bear_Radar_Check
            // 
            this.Animals_Bear_Radar_Check.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Animals_Bear_Radar_Check.AutoSize = true;
            this.Animals_Bear_Radar_Check.Checked = true;
            this.Animals_Bear_Radar_Check.CheckState = System.Windows.Forms.CheckState.Checked;
            this.Animals_Bear_Radar_Check.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Animals_Bear_Radar_Check.Location = new System.Drawing.Point(76, 48);
            this.Animals_Bear_Radar_Check.Margin = new System.Windows.Forms.Padding(3, 3, 0, 0);
            this.Animals_Bear_Radar_Check.Name = "Animals_Bear_Radar_Check";
            this.Animals_Bear_Radar_Check.Size = new System.Drawing.Size(15, 14);
            this.Animals_Bear_Radar_Check.TabIndex = 1;
            this.Animals_Bear_Radar_Check.UseVisualStyleBackColor = true;
            this.Animals_Bear_Radar_Check.CheckedChanged += new System.EventHandler(this.Bear_Check_CheckedChanged);
            // 
            // Animals_Wolf_Box_Check
            // 
            this.Animals_Wolf_Box_Check.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Animals_Wolf_Box_Check.AutoSize = true;
            this.Animals_Wolf_Box_Check.CheckAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.Animals_Wolf_Box_Check.Checked = true;
            this.Animals_Wolf_Box_Check.CheckState = System.Windows.Forms.CheckState.Checked;
            this.Animals_Wolf_Box_Check.Location = new System.Drawing.Point(167, 25);
            this.Animals_Wolf_Box_Check.Margin = new System.Windows.Forms.Padding(3, 3, 0, 0);
            this.Animals_Wolf_Box_Check.Name = "Animals_Wolf_Box_Check";
            this.Animals_Wolf_Box_Check.Size = new System.Drawing.Size(15, 14);
            this.Animals_Wolf_Box_Check.TabIndex = 34;
            this.Animals_Wolf_Box_Check.UseVisualStyleBackColor = true;
            this.Animals_Wolf_Box_Check.CheckedChanged += new System.EventHandler(this.Animals_Wolf_Box_Check_CheckedChanged);
            // 
            // label26
            // 
            this.label26.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label26.AutoSize = true;
            this.label26.Location = new System.Drawing.Point(62, 3);
            this.label26.Margin = new System.Windows.Forms.Padding(3);
            this.label26.Name = "label26";
            this.label26.Size = new System.Drawing.Size(41, 13);
            this.label26.TabIndex = 76;
            this.label26.Text = "Radar";
            this.label26.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label27
            // 
            this.label27.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label27.AutoSize = true;
            this.label27.Location = new System.Drawing.Point(159, 3);
            this.label27.Margin = new System.Windows.Forms.Padding(3);
            this.label27.Name = "label27";
            this.label27.Size = new System.Drawing.Size(28, 13);
            this.label27.TabIndex = 77;
            this.label27.Text = "Box";
            this.label27.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label28
            // 
            this.label28.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label28.AutoSize = true;
            this.label28.Location = new System.Drawing.Point(193, 3);
            this.label28.Margin = new System.Windows.Forms.Padding(3);
            this.label28.Name = "label28";
            this.label28.Size = new System.Drawing.Size(75, 13);
            this.label28.TabIndex = 78;
            this.label28.Text = "Radar";
            this.label28.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label29
            // 
            this.label29.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label29.AutoSize = true;
            this.label29.Location = new System.Drawing.Point(109, 3);
            this.label29.Margin = new System.Windows.Forms.Padding(3);
            this.label29.Name = "label29";
            this.label29.Size = new System.Drawing.Size(44, 13);
            this.label29.TabIndex = 79;
            this.label29.Text = "Tracer";
            this.label29.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label30
            // 
            this.label30.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label30.AutoSize = true;
            this.label30.Location = new System.Drawing.Point(274, 3);
            this.label30.Margin = new System.Windows.Forms.Padding(3);
            this.label30.Name = "label30";
            this.label30.Size = new System.Drawing.Size(75, 13);
            this.label30.TabIndex = 80;
            this.label30.Text = "Tracer";
            this.label30.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Animals_Wolf_Tracer_Color
            // 
            this.Animals_Wolf_Tracer_Color.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Animals_Wolf_Tracer_Color.Location = new System.Drawing.Point(274, 22);
            this.Animals_Wolf_Tracer_Color.Name = "Animals_Wolf_Tracer_Color";
            this.Animals_Wolf_Tracer_Color.Size = new System.Drawing.Size(75, 17);
            this.Animals_Wolf_Tracer_Color.TabIndex = 81;
            this.Animals_Wolf_Tracer_Color.UseVisualStyleBackColor = false;
            this.Animals_Wolf_Tracer_Color.Click += new System.EventHandler(this.Animals_Wolf_Tracer_Color_Click);
            // 
            // Animals_Bear_Tracer_Color
            // 
            this.Animals_Bear_Tracer_Color.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Animals_Bear_Tracer_Color.Location = new System.Drawing.Point(274, 45);
            this.Animals_Bear_Tracer_Color.Name = "Animals_Bear_Tracer_Color";
            this.Animals_Bear_Tracer_Color.Size = new System.Drawing.Size(75, 17);
            this.Animals_Bear_Tracer_Color.TabIndex = 82;
            this.Animals_Bear_Tracer_Color.UseVisualStyleBackColor = false;
            this.Animals_Bear_Tracer_Color.Click += new System.EventHandler(this.Animals_Bear_Tracer_Color_Click);
            // 
            // Animals_Wolf_Tracer_Check
            // 
            this.Animals_Wolf_Tracer_Check.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Animals_Wolf_Tracer_Check.AutoSize = true;
            this.Animals_Wolf_Tracer_Check.Checked = true;
            this.Animals_Wolf_Tracer_Check.CheckState = System.Windows.Forms.CheckState.Checked;
            this.Animals_Wolf_Tracer_Check.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Animals_Wolf_Tracer_Check.Location = new System.Drawing.Point(125, 25);
            this.Animals_Wolf_Tracer_Check.Margin = new System.Windows.Forms.Padding(3, 3, 0, 0);
            this.Animals_Wolf_Tracer_Check.Name = "Animals_Wolf_Tracer_Check";
            this.Animals_Wolf_Tracer_Check.Size = new System.Drawing.Size(15, 14);
            this.Animals_Wolf_Tracer_Check.TabIndex = 83;
            this.Animals_Wolf_Tracer_Check.UseVisualStyleBackColor = true;
            this.Animals_Wolf_Tracer_Check.CheckedChanged += new System.EventHandler(this.Animals_Wolf_Tracer_Check_CheckedChanged);
            // 
            // Animals_Bear_Tracer_Check
            // 
            this.Animals_Bear_Tracer_Check.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Animals_Bear_Tracer_Check.AutoSize = true;
            this.Animals_Bear_Tracer_Check.Checked = true;
            this.Animals_Bear_Tracer_Check.CheckState = System.Windows.Forms.CheckState.Checked;
            this.Animals_Bear_Tracer_Check.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Animals_Bear_Tracer_Check.Location = new System.Drawing.Point(125, 48);
            this.Animals_Bear_Tracer_Check.Margin = new System.Windows.Forms.Padding(3, 3, 0, 0);
            this.Animals_Bear_Tracer_Check.Name = "Animals_Bear_Tracer_Check";
            this.Animals_Bear_Tracer_Check.Size = new System.Drawing.Size(15, 14);
            this.Animals_Bear_Tracer_Check.TabIndex = 84;
            this.Animals_Bear_Tracer_Check.UseVisualStyleBackColor = true;
            this.Animals_Bear_Tracer_Check.CheckedChanged += new System.EventHandler(this.Animals_Bear_Tracer_Check_CheckedChanged);
            // 
            // label22
            // 
            this.label22.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label22.AutoSize = true;
            this.label22.Location = new System.Drawing.Point(3, 68);
            this.label22.Margin = new System.Windows.Forms.Padding(3);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(53, 17);
            this.label22.TabIndex = 85;
            this.label22.Text = "Deer";
            this.label22.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label31
            // 
            this.label31.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label31.AutoSize = true;
            this.label31.Location = new System.Drawing.Point(3, 91);
            this.label31.Margin = new System.Windows.Forms.Padding(3);
            this.label31.Name = "label31";
            this.label31.Size = new System.Drawing.Size(53, 17);
            this.label31.TabIndex = 47;
            this.label31.Text = "Chicken";
            this.label31.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label32
            // 
            this.label32.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label32.AutoSize = true;
            this.label32.Location = new System.Drawing.Point(3, 114);
            this.label32.Margin = new System.Windows.Forms.Padding(3);
            this.label32.Name = "label32";
            this.label32.Size = new System.Drawing.Size(53, 17);
            this.label32.TabIndex = 47;
            this.label32.Text = "Boar";
            this.label32.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label33
            // 
            this.label33.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label33.AutoSize = true;
            this.label33.Location = new System.Drawing.Point(3, 137);
            this.label33.Margin = new System.Windows.Forms.Padding(3);
            this.label33.Name = "label33";
            this.label33.Size = new System.Drawing.Size(53, 17);
            this.label33.TabIndex = 47;
            this.label33.Text = "Horse";
            this.label33.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Animals_Deer_Radar_Check
            // 
            this.Animals_Deer_Radar_Check.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Animals_Deer_Radar_Check.AutoSize = true;
            this.Animals_Deer_Radar_Check.Checked = true;
            this.Animals_Deer_Radar_Check.CheckState = System.Windows.Forms.CheckState.Checked;
            this.Animals_Deer_Radar_Check.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Animals_Deer_Radar_Check.Location = new System.Drawing.Point(76, 71);
            this.Animals_Deer_Radar_Check.Margin = new System.Windows.Forms.Padding(3, 3, 0, 0);
            this.Animals_Deer_Radar_Check.Name = "Animals_Deer_Radar_Check";
            this.Animals_Deer_Radar_Check.Size = new System.Drawing.Size(15, 14);
            this.Animals_Deer_Radar_Check.TabIndex = 2;
            this.Animals_Deer_Radar_Check.UseVisualStyleBackColor = true;
            this.Animals_Deer_Radar_Check.CheckedChanged += new System.EventHandler(this.Deer_Check_CheckedChanged);
            // 
            // Animals_Chicken_Radar_Check
            // 
            this.Animals_Chicken_Radar_Check.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Animals_Chicken_Radar_Check.AutoSize = true;
            this.Animals_Chicken_Radar_Check.Checked = true;
            this.Animals_Chicken_Radar_Check.CheckState = System.Windows.Forms.CheckState.Checked;
            this.Animals_Chicken_Radar_Check.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Animals_Chicken_Radar_Check.Location = new System.Drawing.Point(76, 94);
            this.Animals_Chicken_Radar_Check.Margin = new System.Windows.Forms.Padding(3, 3, 0, 0);
            this.Animals_Chicken_Radar_Check.Name = "Animals_Chicken_Radar_Check";
            this.Animals_Chicken_Radar_Check.Size = new System.Drawing.Size(15, 14);
            this.Animals_Chicken_Radar_Check.TabIndex = 0;
            this.Animals_Chicken_Radar_Check.UseVisualStyleBackColor = true;
            this.Animals_Chicken_Radar_Check.CheckedChanged += new System.EventHandler(this.Chicken_Check_CheckedChanged);
            // 
            // Animals_Boar_Radar_Check
            // 
            this.Animals_Boar_Radar_Check.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Animals_Boar_Radar_Check.AutoSize = true;
            this.Animals_Boar_Radar_Check.Checked = true;
            this.Animals_Boar_Radar_Check.CheckState = System.Windows.Forms.CheckState.Checked;
            this.Animals_Boar_Radar_Check.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Animals_Boar_Radar_Check.Location = new System.Drawing.Point(76, 117);
            this.Animals_Boar_Radar_Check.Margin = new System.Windows.Forms.Padding(3, 3, 0, 0);
            this.Animals_Boar_Radar_Check.Name = "Animals_Boar_Radar_Check";
            this.Animals_Boar_Radar_Check.Size = new System.Drawing.Size(15, 14);
            this.Animals_Boar_Radar_Check.TabIndex = 4;
            this.Animals_Boar_Radar_Check.UseVisualStyleBackColor = true;
            this.Animals_Boar_Radar_Check.CheckedChanged += new System.EventHandler(this.Boar_Check_CheckedChanged);
            // 
            // Animals_Horse_Radar_Check
            // 
            this.Animals_Horse_Radar_Check.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Animals_Horse_Radar_Check.AutoSize = true;
            this.Animals_Horse_Radar_Check.Checked = true;
            this.Animals_Horse_Radar_Check.CheckState = System.Windows.Forms.CheckState.Checked;
            this.Animals_Horse_Radar_Check.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Animals_Horse_Radar_Check.Location = new System.Drawing.Point(76, 140);
            this.Animals_Horse_Radar_Check.Margin = new System.Windows.Forms.Padding(3, 3, 0, 0);
            this.Animals_Horse_Radar_Check.Name = "Animals_Horse_Radar_Check";
            this.Animals_Horse_Radar_Check.Size = new System.Drawing.Size(15, 14);
            this.Animals_Horse_Radar_Check.TabIndex = 5;
            this.Animals_Horse_Radar_Check.UseVisualStyleBackColor = true;
            this.Animals_Horse_Radar_Check.CheckedChanged += new System.EventHandler(this.Horse_Check_CheckedChanged);
            // 
            // Animals_Deer_Tracer_Check
            // 
            this.Animals_Deer_Tracer_Check.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Animals_Deer_Tracer_Check.AutoSize = true;
            this.Animals_Deer_Tracer_Check.Checked = true;
            this.Animals_Deer_Tracer_Check.CheckState = System.Windows.Forms.CheckState.Checked;
            this.Animals_Deer_Tracer_Check.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Animals_Deer_Tracer_Check.Location = new System.Drawing.Point(125, 71);
            this.Animals_Deer_Tracer_Check.Margin = new System.Windows.Forms.Padding(3, 3, 0, 0);
            this.Animals_Deer_Tracer_Check.Name = "Animals_Deer_Tracer_Check";
            this.Animals_Deer_Tracer_Check.Size = new System.Drawing.Size(15, 14);
            this.Animals_Deer_Tracer_Check.TabIndex = 88;
            this.Animals_Deer_Tracer_Check.UseVisualStyleBackColor = true;
            this.Animals_Deer_Tracer_Check.CheckedChanged += new System.EventHandler(this.Animals_Deer_Tracer_Check_CheckedChanged);
            // 
            // Animals_Chicken_Tracer_Check
            // 
            this.Animals_Chicken_Tracer_Check.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Animals_Chicken_Tracer_Check.AutoSize = true;
            this.Animals_Chicken_Tracer_Check.Checked = true;
            this.Animals_Chicken_Tracer_Check.CheckState = System.Windows.Forms.CheckState.Checked;
            this.Animals_Chicken_Tracer_Check.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Animals_Chicken_Tracer_Check.Location = new System.Drawing.Point(125, 94);
            this.Animals_Chicken_Tracer_Check.Margin = new System.Windows.Forms.Padding(3, 3, 0, 0);
            this.Animals_Chicken_Tracer_Check.Name = "Animals_Chicken_Tracer_Check";
            this.Animals_Chicken_Tracer_Check.Size = new System.Drawing.Size(15, 14);
            this.Animals_Chicken_Tracer_Check.TabIndex = 93;
            this.Animals_Chicken_Tracer_Check.UseVisualStyleBackColor = true;
            this.Animals_Chicken_Tracer_Check.CheckedChanged += new System.EventHandler(this.Animals_Chicken_Tracer_Check_CheckedChanged);
            // 
            // Animals_Boar_Tracer_Check
            // 
            this.Animals_Boar_Tracer_Check.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Animals_Boar_Tracer_Check.AutoSize = true;
            this.Animals_Boar_Tracer_Check.Checked = true;
            this.Animals_Boar_Tracer_Check.CheckState = System.Windows.Forms.CheckState.Checked;
            this.Animals_Boar_Tracer_Check.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Animals_Boar_Tracer_Check.Location = new System.Drawing.Point(125, 117);
            this.Animals_Boar_Tracer_Check.Margin = new System.Windows.Forms.Padding(3, 3, 0, 0);
            this.Animals_Boar_Tracer_Check.Name = "Animals_Boar_Tracer_Check";
            this.Animals_Boar_Tracer_Check.Size = new System.Drawing.Size(15, 14);
            this.Animals_Boar_Tracer_Check.TabIndex = 92;
            this.Animals_Boar_Tracer_Check.UseVisualStyleBackColor = true;
            this.Animals_Boar_Tracer_Check.CheckedChanged += new System.EventHandler(this.Animals_Boar_Tracer_Check_CheckedChanged);
            // 
            // Animals_Horse_Tracer_Check
            // 
            this.Animals_Horse_Tracer_Check.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Animals_Horse_Tracer_Check.AutoSize = true;
            this.Animals_Horse_Tracer_Check.Checked = true;
            this.Animals_Horse_Tracer_Check.CheckState = System.Windows.Forms.CheckState.Checked;
            this.Animals_Horse_Tracer_Check.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Animals_Horse_Tracer_Check.Location = new System.Drawing.Point(125, 140);
            this.Animals_Horse_Tracer_Check.Margin = new System.Windows.Forms.Padding(3, 3, 0, 0);
            this.Animals_Horse_Tracer_Check.Name = "Animals_Horse_Tracer_Check";
            this.Animals_Horse_Tracer_Check.Size = new System.Drawing.Size(15, 14);
            this.Animals_Horse_Tracer_Check.TabIndex = 94;
            this.Animals_Horse_Tracer_Check.UseVisualStyleBackColor = true;
            this.Animals_Horse_Tracer_Check.CheckedChanged += new System.EventHandler(this.Animals_Horse_Tracer_Check_CheckedChanged);
            // 
            // Animals_Deer_Box_Check
            // 
            this.Animals_Deer_Box_Check.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Animals_Deer_Box_Check.AutoSize = true;
            this.Animals_Deer_Box_Check.Checked = true;
            this.Animals_Deer_Box_Check.CheckState = System.Windows.Forms.CheckState.Checked;
            this.Animals_Deer_Box_Check.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Animals_Deer_Box_Check.Location = new System.Drawing.Point(167, 71);
            this.Animals_Deer_Box_Check.Margin = new System.Windows.Forms.Padding(3, 3, 0, 0);
            this.Animals_Deer_Box_Check.Name = "Animals_Deer_Box_Check";
            this.Animals_Deer_Box_Check.Size = new System.Drawing.Size(15, 14);
            this.Animals_Deer_Box_Check.TabIndex = 86;
            this.Animals_Deer_Box_Check.UseVisualStyleBackColor = true;
            this.Animals_Deer_Box_Check.CheckedChanged += new System.EventHandler(this.Animals_Deer_Box_Check_CheckedChanged);
            // 
            // Animals_Chicken_Box_Check
            // 
            this.Animals_Chicken_Box_Check.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Animals_Chicken_Box_Check.AutoSize = true;
            this.Animals_Chicken_Box_Check.Checked = true;
            this.Animals_Chicken_Box_Check.CheckState = System.Windows.Forms.CheckState.Checked;
            this.Animals_Chicken_Box_Check.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Animals_Chicken_Box_Check.Location = new System.Drawing.Point(167, 94);
            this.Animals_Chicken_Box_Check.Margin = new System.Windows.Forms.Padding(3, 3, 0, 0);
            this.Animals_Chicken_Box_Check.Name = "Animals_Chicken_Box_Check";
            this.Animals_Chicken_Box_Check.Size = new System.Drawing.Size(15, 14);
            this.Animals_Chicken_Box_Check.TabIndex = 89;
            this.Animals_Chicken_Box_Check.UseVisualStyleBackColor = true;
            this.Animals_Chicken_Box_Check.CheckedChanged += new System.EventHandler(this.Animals_Chicken_Box_Check_CheckedChanged);
            // 
            // Animals_Boar_Box_Check
            // 
            this.Animals_Boar_Box_Check.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Animals_Boar_Box_Check.AutoSize = true;
            this.Animals_Boar_Box_Check.Checked = true;
            this.Animals_Boar_Box_Check.CheckState = System.Windows.Forms.CheckState.Checked;
            this.Animals_Boar_Box_Check.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Animals_Boar_Box_Check.Location = new System.Drawing.Point(167, 117);
            this.Animals_Boar_Box_Check.Margin = new System.Windows.Forms.Padding(3, 3, 0, 0);
            this.Animals_Boar_Box_Check.Name = "Animals_Boar_Box_Check";
            this.Animals_Boar_Box_Check.Size = new System.Drawing.Size(15, 14);
            this.Animals_Boar_Box_Check.TabIndex = 91;
            this.Animals_Boar_Box_Check.UseVisualStyleBackColor = true;
            this.Animals_Boar_Box_Check.CheckedChanged += new System.EventHandler(this.Animals_Boar_Box_Check_CheckedChanged);
            // 
            // Animals_Horse_Box_Check
            // 
            this.Animals_Horse_Box_Check.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Animals_Horse_Box_Check.AutoSize = true;
            this.Animals_Horse_Box_Check.Checked = true;
            this.Animals_Horse_Box_Check.CheckState = System.Windows.Forms.CheckState.Checked;
            this.Animals_Horse_Box_Check.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Animals_Horse_Box_Check.Location = new System.Drawing.Point(167, 140);
            this.Animals_Horse_Box_Check.Margin = new System.Windows.Forms.Padding(3, 3, 0, 0);
            this.Animals_Horse_Box_Check.Name = "Animals_Horse_Box_Check";
            this.Animals_Horse_Box_Check.Size = new System.Drawing.Size(15, 14);
            this.Animals_Horse_Box_Check.TabIndex = 90;
            this.Animals_Horse_Box_Check.UseVisualStyleBackColor = true;
            this.Animals_Horse_Box_Check.CheckedChanged += new System.EventHandler(this.Animals_Horse_Box_Check_CheckedChanged);
            // 
            // Animals_Deer_Radar_Color
            // 
            this.Animals_Deer_Radar_Color.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Animals_Deer_Radar_Color.Location = new System.Drawing.Point(193, 68);
            this.Animals_Deer_Radar_Color.Name = "Animals_Deer_Radar_Color";
            this.Animals_Deer_Radar_Color.Size = new System.Drawing.Size(75, 17);
            this.Animals_Deer_Radar_Color.TabIndex = 8;
            this.Animals_Deer_Radar_Color.UseVisualStyleBackColor = false;
            this.Animals_Deer_Radar_Color.Click += new System.EventHandler(this.Deer_Color_Click);
            // 
            // Animals_Chicken_Radar_Color
            // 
            this.Animals_Chicken_Radar_Color.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Animals_Chicken_Radar_Color.Location = new System.Drawing.Point(193, 91);
            this.Animals_Chicken_Radar_Color.Name = "Animals_Chicken_Radar_Color";
            this.Animals_Chicken_Radar_Color.Size = new System.Drawing.Size(75, 17);
            this.Animals_Chicken_Radar_Color.TabIndex = 6;
            this.Animals_Chicken_Radar_Color.UseVisualStyleBackColor = false;
            this.Animals_Chicken_Radar_Color.Click += new System.EventHandler(this.Chicken_Color_Click);
            // 
            // Animals_Boar_Radar_Color
            // 
            this.Animals_Boar_Radar_Color.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Animals_Boar_Radar_Color.Location = new System.Drawing.Point(193, 114);
            this.Animals_Boar_Radar_Color.Name = "Animals_Boar_Radar_Color";
            this.Animals_Boar_Radar_Color.Size = new System.Drawing.Size(75, 17);
            this.Animals_Boar_Radar_Color.TabIndex = 10;
            this.Animals_Boar_Radar_Color.UseVisualStyleBackColor = false;
            this.Animals_Boar_Radar_Color.Click += new System.EventHandler(this.Boar_Color_Click);
            // 
            // Animals_Horse_Radar_Color
            // 
            this.Animals_Horse_Radar_Color.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Animals_Horse_Radar_Color.Location = new System.Drawing.Point(193, 137);
            this.Animals_Horse_Radar_Color.Name = "Animals_Horse_Radar_Color";
            this.Animals_Horse_Radar_Color.Size = new System.Drawing.Size(75, 17);
            this.Animals_Horse_Radar_Color.TabIndex = 11;
            this.Animals_Horse_Radar_Color.UseVisualStyleBackColor = false;
            this.Animals_Horse_Radar_Color.Click += new System.EventHandler(this.Horse_Color_Click);
            // 
            // Animals_Deer_Tracer_Color
            // 
            this.Animals_Deer_Tracer_Color.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Animals_Deer_Tracer_Color.Location = new System.Drawing.Point(274, 68);
            this.Animals_Deer_Tracer_Color.Name = "Animals_Deer_Tracer_Color";
            this.Animals_Deer_Tracer_Color.Size = new System.Drawing.Size(75, 17);
            this.Animals_Deer_Tracer_Color.TabIndex = 89;
            this.Animals_Deer_Tracer_Color.UseVisualStyleBackColor = false;
            this.Animals_Deer_Tracer_Color.Click += new System.EventHandler(this.Animals_Deer_Tracer_Color_Click);
            // 
            // Animals_Deer_Box_Color
            // 
            this.Animals_Deer_Box_Color.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Animals_Deer_Box_Color.Location = new System.Drawing.Point(355, 68);
            this.Animals_Deer_Box_Color.Name = "Animals_Deer_Box_Color";
            this.Animals_Deer_Box_Color.Size = new System.Drawing.Size(75, 17);
            this.Animals_Deer_Box_Color.TabIndex = 91;
            this.Animals_Deer_Box_Color.UseVisualStyleBackColor = false;
            this.Animals_Deer_Box_Color.Click += new System.EventHandler(this.Animals_Deer_Box_Color_Click);
            // 
            // Animals_Chicken_Tracer_Color
            // 
            this.Animals_Chicken_Tracer_Color.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Animals_Chicken_Tracer_Color.Location = new System.Drawing.Point(274, 91);
            this.Animals_Chicken_Tracer_Color.Name = "Animals_Chicken_Tracer_Color";
            this.Animals_Chicken_Tracer_Color.Size = new System.Drawing.Size(75, 17);
            this.Animals_Chicken_Tracer_Color.TabIndex = 91;
            this.Animals_Chicken_Tracer_Color.UseVisualStyleBackColor = false;
            this.Animals_Chicken_Tracer_Color.Click += new System.EventHandler(this.Animals_Chicken_Tracer_Color_Click);
            // 
            // Animals_Boar_Tracer_Color
            // 
            this.Animals_Boar_Tracer_Color.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Animals_Boar_Tracer_Color.Location = new System.Drawing.Point(274, 114);
            this.Animals_Boar_Tracer_Color.Name = "Animals_Boar_Tracer_Color";
            this.Animals_Boar_Tracer_Color.Size = new System.Drawing.Size(75, 17);
            this.Animals_Boar_Tracer_Color.TabIndex = 91;
            this.Animals_Boar_Tracer_Color.UseVisualStyleBackColor = false;
            this.Animals_Boar_Tracer_Color.Click += new System.EventHandler(this.Animals_Boar_Tracer_Color_Click);
            // 
            // Animals_Horse_Tracer_Color
            // 
            this.Animals_Horse_Tracer_Color.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Animals_Horse_Tracer_Color.Location = new System.Drawing.Point(274, 137);
            this.Animals_Horse_Tracer_Color.Name = "Animals_Horse_Tracer_Color";
            this.Animals_Horse_Tracer_Color.Size = new System.Drawing.Size(75, 17);
            this.Animals_Horse_Tracer_Color.TabIndex = 31;
            this.Animals_Horse_Tracer_Color.UseVisualStyleBackColor = false;
            this.Animals_Horse_Tracer_Color.Click += new System.EventHandler(this.Animals_Horse_Tracer_Color_Click);
            // 
            // Animals_Chicken_Box_Color
            // 
            this.Animals_Chicken_Box_Color.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Animals_Chicken_Box_Color.Location = new System.Drawing.Point(355, 91);
            this.Animals_Chicken_Box_Color.Name = "Animals_Chicken_Box_Color";
            this.Animals_Chicken_Box_Color.Size = new System.Drawing.Size(75, 17);
            this.Animals_Chicken_Box_Color.TabIndex = 30;
            this.Animals_Chicken_Box_Color.UseVisualStyleBackColor = false;
            this.Animals_Chicken_Box_Color.Click += new System.EventHandler(this.Animals_Chicken_Box_Color_Click);
            // 
            // Animals_Boar_Box_Color
            // 
            this.Animals_Boar_Box_Color.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Animals_Boar_Box_Color.Location = new System.Drawing.Point(355, 114);
            this.Animals_Boar_Box_Color.Name = "Animals_Boar_Box_Color";
            this.Animals_Boar_Box_Color.Size = new System.Drawing.Size(75, 17);
            this.Animals_Boar_Box_Color.TabIndex = 32;
            this.Animals_Boar_Box_Color.UseVisualStyleBackColor = false;
            this.Animals_Boar_Box_Color.Click += new System.EventHandler(this.Animals_Boar_Box_Color_Click);
            // 
            // Animals_Horse_Box_Color
            // 
            this.Animals_Horse_Box_Color.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Animals_Horse_Box_Color.Location = new System.Drawing.Point(355, 137);
            this.Animals_Horse_Box_Color.Name = "Animals_Horse_Box_Color";
            this.Animals_Horse_Box_Color.Size = new System.Drawing.Size(75, 17);
            this.Animals_Horse_Box_Color.TabIndex = 30;
            this.Animals_Horse_Box_Color.UseVisualStyleBackColor = false;
            this.Animals_Horse_Box_Color.Click += new System.EventHandler(this.Animals_Horse_Box_Color_Click);
            // 
            // Deployables_TAB
            // 
            this.Deployables_TAB.BackColor = System.Drawing.Color.White;
            this.Deployables_TAB.Controls.Add(this.tableLayoutPanel5);
            this.Deployables_TAB.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Deployables_TAB.Location = new System.Drawing.Point(4, 22);
            this.Deployables_TAB.Name = "Deployables_TAB";
            this.Deployables_TAB.Padding = new System.Windows.Forms.Padding(3);
            this.Deployables_TAB.Size = new System.Drawing.Size(568, 552);
            this.Deployables_TAB.TabIndex = 2;
            this.Deployables_TAB.Text = "Deployables";
            // 
            // tableLayoutPanel5
            // 
            this.tableLayoutPanel5.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel5.AutoSize = true;
            this.tableLayoutPanel5.ColumnCount = 8;
            this.tableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 61F));
            this.tableLayoutPanel5.Controls.Add(this.Deployable_Oil_Box_Color, 6, 8);
            this.tableLayoutPanel5.Controls.Add(this.Deployable_Oil_Tracer_Color, 5, 8);
            this.tableLayoutPanel5.Controls.Add(this.Deployable_Fridge_Box_Color, 6, 7);
            this.tableLayoutPanel5.Controls.Add(this.Deployable_Fridge_Tracer_Color, 5, 7);
            this.tableLayoutPanel5.Controls.Add(this.Deployable_Large_Furnace_Box_Color, 6, 6);
            this.tableLayoutPanel5.Controls.Add(this.Deployable_Oil_Radar_Color, 4, 8);
            this.tableLayoutPanel5.Controls.Add(this.Deployable_Large_Furnace_Tracer_Color, 5, 6);
            this.tableLayoutPanel5.Controls.Add(this.Deployable_Oil_Radar_Checked, 1, 8);
            this.tableLayoutPanel5.Controls.Add(this.Deployable_Furnace_Box_Color, 6, 5);
            this.tableLayoutPanel5.Controls.Add(this.Deployable_Furnace_Tracer_Color, 5, 5);
            this.tableLayoutPanel5.Controls.Add(this.Deployable_AutoTurret_Box_Color, 6, 4);
            this.tableLayoutPanel5.Controls.Add(this.Deployable_Fridge_Radar_Color, 4, 7);
            this.tableLayoutPanel5.Controls.Add(this.Deployable_AutoTurret_Tracer_Color, 5, 4);
            this.tableLayoutPanel5.Controls.Add(this.Deployable_Fridge_Radar_Check, 1, 7);
            this.tableLayoutPanel5.Controls.Add(this.Deployable_Sleeping_Bag_Box_Color, 6, 3);
            this.tableLayoutPanel5.Controls.Add(this.Deployable_Sleeping_Bag_Tracer_Color, 5, 3);
            this.tableLayoutPanel5.Controls.Add(this.Deployable_TC_Box_Color, 6, 2);
            this.tableLayoutPanel5.Controls.Add(this.Deployable_TC_Tracer_Color, 5, 2);
            this.tableLayoutPanel5.Controls.Add(this.Deployable_Furnace_Box_Check, 3, 5);
            this.tableLayoutPanel5.Controls.Add(this.Deployable_Large_Furnace_Radar_Color, 4, 6);
            this.tableLayoutPanel5.Controls.Add(this.Deployable_TC_Box_Check, 3, 2);
            this.tableLayoutPanel5.Controls.Add(this.Deployable_Large_Furnace_Radar_Check, 1, 6);
            this.tableLayoutPanel5.Controls.Add(this.Deployable_AutoTurret_Box_Check, 3, 4);
            this.tableLayoutPanel5.Controls.Add(this.Deployable_Furnace_Radar_Color, 4, 5);
            this.tableLayoutPanel5.Controls.Add(this.Deployable_TC_Tracer_Check, 2, 2);
            this.tableLayoutPanel5.Controls.Add(this.Deployable_Furnace_Radar_Check, 1, 5);
            this.tableLayoutPanel5.Controls.Add(this.label34, 0, 2);
            this.tableLayoutPanel5.Controls.Add(this.Deployable_AutoTurret_Radar_Color, 4, 4);
            this.tableLayoutPanel5.Controls.Add(this.Deployable_Quarry_Radar_Color, 4, 1);
            this.tableLayoutPanel5.Controls.Add(this.Deployable_AutoTurret_Radar_Check, 1, 4);
            this.tableLayoutPanel5.Controls.Add(this.Deployable_Sleeping_Bag_Radar_Color, 4, 3);
            this.tableLayoutPanel5.Controls.Add(this.Deployable_Furnace_Tracer_Check, 2, 5);
            this.tableLayoutPanel5.Controls.Add(this.Deployable_TC_Radar_Color, 4, 2);
            this.tableLayoutPanel5.Controls.Add(this.Deployable_Sleeping_Bag_Radar_Check, 1, 3);
            this.tableLayoutPanel5.Controls.Add(this.Deployable_Quarry_Box_Check, 3, 1);
            this.tableLayoutPanel5.Controls.Add(this.Deployable_Quarry_Tracer_Check, 2, 1);
            this.tableLayoutPanel5.Controls.Add(this.label35, 0, 1);
            this.tableLayoutPanel5.Controls.Add(this.Deployable_TC_Radar_Check, 1, 2);
            this.tableLayoutPanel5.Controls.Add(this.Deployable_Quarry_Tracer_Color, 5, 1);
            this.tableLayoutPanel5.Controls.Add(this.Deployable_Quarry_Radar_Check, 1, 1);
            this.tableLayoutPanel5.Controls.Add(this.Deployable_Quarry_Box_Color, 6, 1);
            this.tableLayoutPanel5.Controls.Add(this.label36, 0, 3);
            this.tableLayoutPanel5.Controls.Add(this.Deployable_Sleeping_Bag_Tracer_Check, 2, 3);
            this.tableLayoutPanel5.Controls.Add(this.Deployable_Sleeping_Bag_Box_Check, 3, 3);
            this.tableLayoutPanel5.Controls.Add(this.Deployable_AutoTurret_Tracer_Check, 2, 4);
            this.tableLayoutPanel5.Controls.Add(this.label37, 0, 4);
            this.tableLayoutPanel5.Controls.Add(this.label38, 0, 5);
            this.tableLayoutPanel5.Controls.Add(this.label39, 0, 6);
            this.tableLayoutPanel5.Controls.Add(this.label40, 0, 7);
            this.tableLayoutPanel5.Controls.Add(this.label41, 0, 8);
            this.tableLayoutPanel5.Controls.Add(this.Deployable_Large_Furnace_Tracer_Check, 2, 6);
            this.tableLayoutPanel5.Controls.Add(this.Deployable_Large_Furnace_Box_Check, 3, 6);
            this.tableLayoutPanel5.Controls.Add(this.Deployable_Fridge_Box_Check, 3, 7);
            this.tableLayoutPanel5.Controls.Add(this.Deployable_Fridge_Tracer_Check, 2, 7);
            this.tableLayoutPanel5.Controls.Add(this.Deployable_Oil_Tracer_Check, 2, 8);
            this.tableLayoutPanel5.Controls.Add(this.Deployable_Oil_Box_Check, 3, 8);
            this.tableLayoutPanel5.Controls.Add(this.label42, 1, 0);
            this.tableLayoutPanel5.Controls.Add(this.label44, 3, 0);
            this.tableLayoutPanel5.Controls.Add(this.label45, 4, 0);
            this.tableLayoutPanel5.Controls.Add(this.label46, 5, 0);
            this.tableLayoutPanel5.Controls.Add(this.label47, 6, 0);
            this.tableLayoutPanel5.Controls.Add(this.label43, 2, 0);
            this.tableLayoutPanel5.Controls.Add(this.label48, 0, 9);
            this.tableLayoutPanel5.Controls.Add(this.label52, 0, 10);
            this.tableLayoutPanel5.Controls.Add(this.label51, 0, 11);
            this.tableLayoutPanel5.Controls.Add(this.label50, 0, 12);
            this.tableLayoutPanel5.Controls.Add(this.label49, 0, 13);
            this.tableLayoutPanel5.Controls.Add(this.Deployable_Landmine_Radar_Check, 1, 9);
            this.tableLayoutPanel5.Controls.Add(this.Deployable_Bear_Trap_Radar_Check, 1, 10);
            this.tableLayoutPanel5.Controls.Add(this.Deployable_Stash_Radar_Check, 1, 11);
            this.tableLayoutPanel5.Controls.Add(this.Deployable_Box_Radar_Check, 1, 12);
            this.tableLayoutPanel5.Controls.Add(this.Deployable_Large_Box_Radar_Check, 1, 13);
            this.tableLayoutPanel5.Controls.Add(this.Deployable_Landmine_Tracer_Check, 2, 9);
            this.tableLayoutPanel5.Controls.Add(this.Deployable_Bear_Trap_Tracer_Check, 2, 10);
            this.tableLayoutPanel5.Controls.Add(this.Deployable_Stash_Tracer_Check, 2, 11);
            this.tableLayoutPanel5.Controls.Add(this.Deployable_Box_Tracer_Check, 2, 12);
            this.tableLayoutPanel5.Controls.Add(this.Deployable_Large_Box_Tracer_Check, 2, 13);
            this.tableLayoutPanel5.Controls.Add(this.Deployable_Landmine_Box_Check, 3, 9);
            this.tableLayoutPanel5.Controls.Add(this.Deployable_Bear_Trap_Box_Check, 3, 10);
            this.tableLayoutPanel5.Controls.Add(this.Deployable_Stash_Box_Check, 3, 11);
            this.tableLayoutPanel5.Controls.Add(this.Deployable_Box_Box_Check, 3, 12);
            this.tableLayoutPanel5.Controls.Add(this.Deployable_Large_Box_Box_Check, 3, 13);
            this.tableLayoutPanel5.Controls.Add(this.Deployable_Landmine_Radar_Color, 4, 9);
            this.tableLayoutPanel5.Controls.Add(this.Deployable_Bear_Trap_Radar_Color, 4, 10);
            this.tableLayoutPanel5.Controls.Add(this.Deployable_Stash_Radar_Color, 4, 11);
            this.tableLayoutPanel5.Controls.Add(this.Deployable_Box_Radar_Color, 4, 12);
            this.tableLayoutPanel5.Controls.Add(this.Deployable_Large_Box_Radar_Color, 4, 13);
            this.tableLayoutPanel5.Controls.Add(this.Deployable_Landmine_Tracer_Color, 5, 9);
            this.tableLayoutPanel5.Controls.Add(this.Deployable_Bear_Trap_Tracer_Color, 5, 10);
            this.tableLayoutPanel5.Controls.Add(this.Deployable_Stash_Tracer_Color, 5, 11);
            this.tableLayoutPanel5.Controls.Add(this.Deployable_Box_Tracer_Color, 5, 12);
            this.tableLayoutPanel5.Controls.Add(this.Deployable_Large_Box_Tracer_Color, 5, 13);
            this.tableLayoutPanel5.Controls.Add(this.Deployable_Landmine_Box_Color, 6, 9);
            this.tableLayoutPanel5.Controls.Add(this.Deployable_Bear_Trap_Box_Color, 6, 10);
            this.tableLayoutPanel5.Controls.Add(this.Deployable_Stash_Box_Color, 6, 11);
            this.tableLayoutPanel5.Controls.Add(this.Deployable_Box_Box_Color, 6, 12);
            this.tableLayoutPanel5.Controls.Add(this.Deployable_Large_Box_Box_Color, 6, 13);
            this.tableLayoutPanel5.Location = new System.Drawing.Point(6, 6);
            this.tableLayoutPanel5.Margin = new System.Windows.Forms.Padding(3, 3, 0, 0);
            this.tableLayoutPanel5.Name = "tableLayoutPanel5";
            this.tableLayoutPanel5.RowCount = 15;
            this.tableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel5.Size = new System.Drawing.Size(531, 372);
            this.tableLayoutPanel5.TabIndex = 29;
            // 
            // Deployable_Oil_Box_Color
            // 
            this.Deployable_Oil_Box_Color.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Deployable_Oil_Box_Color.Location = new System.Drawing.Point(392, 183);
            this.Deployable_Oil_Box_Color.Name = "Deployable_Oil_Box_Color";
            this.Deployable_Oil_Box_Color.Size = new System.Drawing.Size(75, 17);
            this.Deployable_Oil_Box_Color.TabIndex = 73;
            this.Deployable_Oil_Box_Color.UseVisualStyleBackColor = false;
            this.Deployable_Oil_Box_Color.Click += new System.EventHandler(this.Deployable_Oil_Box_Color_Click);
            // 
            // Deployable_Oil_Tracer_Color
            // 
            this.Deployable_Oil_Tracer_Color.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Deployable_Oil_Tracer_Color.Location = new System.Drawing.Point(311, 183);
            this.Deployable_Oil_Tracer_Color.Name = "Deployable_Oil_Tracer_Color";
            this.Deployable_Oil_Tracer_Color.Size = new System.Drawing.Size(75, 17);
            this.Deployable_Oil_Tracer_Color.TabIndex = 72;
            this.Deployable_Oil_Tracer_Color.UseVisualStyleBackColor = false;
            this.Deployable_Oil_Tracer_Color.Click += new System.EventHandler(this.Deployable_Oil_Tracer_Color_Click);
            // 
            // Deployable_Fridge_Box_Color
            // 
            this.Deployable_Fridge_Box_Color.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Deployable_Fridge_Box_Color.Location = new System.Drawing.Point(392, 160);
            this.Deployable_Fridge_Box_Color.Name = "Deployable_Fridge_Box_Color";
            this.Deployable_Fridge_Box_Color.Size = new System.Drawing.Size(75, 17);
            this.Deployable_Fridge_Box_Color.TabIndex = 70;
            this.Deployable_Fridge_Box_Color.UseVisualStyleBackColor = false;
            this.Deployable_Fridge_Box_Color.Click += new System.EventHandler(this.Deployable_Fridge_Box_Color_Click);
            // 
            // Deployable_Fridge_Tracer_Color
            // 
            this.Deployable_Fridge_Tracer_Color.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Deployable_Fridge_Tracer_Color.Location = new System.Drawing.Point(311, 160);
            this.Deployable_Fridge_Tracer_Color.Name = "Deployable_Fridge_Tracer_Color";
            this.Deployable_Fridge_Tracer_Color.Size = new System.Drawing.Size(75, 17);
            this.Deployable_Fridge_Tracer_Color.TabIndex = 69;
            this.Deployable_Fridge_Tracer_Color.UseVisualStyleBackColor = false;
            this.Deployable_Fridge_Tracer_Color.Click += new System.EventHandler(this.Deployable_Fridge_Tracer_Color_Click);
            // 
            // Deployable_Large_Furnace_Box_Color
            // 
            this.Deployable_Large_Furnace_Box_Color.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Deployable_Large_Furnace_Box_Color.Location = new System.Drawing.Point(392, 137);
            this.Deployable_Large_Furnace_Box_Color.Name = "Deployable_Large_Furnace_Box_Color";
            this.Deployable_Large_Furnace_Box_Color.Size = new System.Drawing.Size(75, 17);
            this.Deployable_Large_Furnace_Box_Color.TabIndex = 67;
            this.Deployable_Large_Furnace_Box_Color.UseVisualStyleBackColor = false;
            this.Deployable_Large_Furnace_Box_Color.Click += new System.EventHandler(this.Deployable_Large_Furnace_Box_Color_Click);
            // 
            // Deployable_Oil_Radar_Color
            // 
            this.Deployable_Oil_Radar_Color.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Deployable_Oil_Radar_Color.Location = new System.Drawing.Point(230, 183);
            this.Deployable_Oil_Radar_Color.Name = "Deployable_Oil_Radar_Color";
            this.Deployable_Oil_Radar_Color.Size = new System.Drawing.Size(75, 17);
            this.Deployable_Oil_Radar_Color.TabIndex = 24;
            this.Deployable_Oil_Radar_Color.UseVisualStyleBackColor = false;
            this.Deployable_Oil_Radar_Color.Click += new System.EventHandler(this.Oil_Color_Click);
            // 
            // Deployable_Large_Furnace_Tracer_Color
            // 
            this.Deployable_Large_Furnace_Tracer_Color.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Deployable_Large_Furnace_Tracer_Color.Location = new System.Drawing.Point(311, 137);
            this.Deployable_Large_Furnace_Tracer_Color.Name = "Deployable_Large_Furnace_Tracer_Color";
            this.Deployable_Large_Furnace_Tracer_Color.Size = new System.Drawing.Size(75, 17);
            this.Deployable_Large_Furnace_Tracer_Color.TabIndex = 66;
            this.Deployable_Large_Furnace_Tracer_Color.UseVisualStyleBackColor = false;
            this.Deployable_Large_Furnace_Tracer_Color.Click += new System.EventHandler(this.Deployable_Large_Furnace_Tracer_Color_Click);
            // 
            // Deployable_Oil_Radar_Checked
            // 
            this.Deployable_Oil_Radar_Checked.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Deployable_Oil_Radar_Checked.AutoSize = true;
            this.Deployable_Oil_Radar_Checked.Checked = true;
            this.Deployable_Oil_Radar_Checked.CheckState = System.Windows.Forms.CheckState.Checked;
            this.Deployable_Oil_Radar_Checked.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Deployable_Oil_Radar_Checked.Location = new System.Drawing.Point(113, 186);
            this.Deployable_Oil_Radar_Checked.Margin = new System.Windows.Forms.Padding(3, 3, 0, 0);
            this.Deployable_Oil_Radar_Checked.Name = "Deployable_Oil_Radar_Checked";
            this.Deployable_Oil_Radar_Checked.Size = new System.Drawing.Size(15, 14);
            this.Deployable_Oil_Radar_Checked.TabIndex = 23;
            this.Deployable_Oil_Radar_Checked.UseVisualStyleBackColor = true;
            this.Deployable_Oil_Radar_Checked.CheckedChanged += new System.EventHandler(this.Oil_Checked_CheckedChanged);
            // 
            // Deployable_Furnace_Box_Color
            // 
            this.Deployable_Furnace_Box_Color.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Deployable_Furnace_Box_Color.Location = new System.Drawing.Point(392, 114);
            this.Deployable_Furnace_Box_Color.Name = "Deployable_Furnace_Box_Color";
            this.Deployable_Furnace_Box_Color.Size = new System.Drawing.Size(75, 17);
            this.Deployable_Furnace_Box_Color.TabIndex = 64;
            this.Deployable_Furnace_Box_Color.UseVisualStyleBackColor = false;
            this.Deployable_Furnace_Box_Color.Click += new System.EventHandler(this.Deployable_Furnace_Box_Color_Click);
            // 
            // Deployable_Furnace_Tracer_Color
            // 
            this.Deployable_Furnace_Tracer_Color.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Deployable_Furnace_Tracer_Color.Location = new System.Drawing.Point(311, 114);
            this.Deployable_Furnace_Tracer_Color.Name = "Deployable_Furnace_Tracer_Color";
            this.Deployable_Furnace_Tracer_Color.Size = new System.Drawing.Size(75, 17);
            this.Deployable_Furnace_Tracer_Color.TabIndex = 63;
            this.Deployable_Furnace_Tracer_Color.UseVisualStyleBackColor = false;
            this.Deployable_Furnace_Tracer_Color.Click += new System.EventHandler(this.Deployable_Furnace_Tracer_Color_Click);
            // 
            // Deployable_AutoTurret_Box_Color
            // 
            this.Deployable_AutoTurret_Box_Color.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Deployable_AutoTurret_Box_Color.Location = new System.Drawing.Point(392, 91);
            this.Deployable_AutoTurret_Box_Color.Name = "Deployable_AutoTurret_Box_Color";
            this.Deployable_AutoTurret_Box_Color.Size = new System.Drawing.Size(75, 17);
            this.Deployable_AutoTurret_Box_Color.TabIndex = 61;
            this.Deployable_AutoTurret_Box_Color.UseVisualStyleBackColor = false;
            this.Deployable_AutoTurret_Box_Color.Click += new System.EventHandler(this.Deployable_AutoTurret_Box_Color_Click);
            // 
            // Deployable_Fridge_Radar_Color
            // 
            this.Deployable_Fridge_Radar_Color.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Deployable_Fridge_Radar_Color.Location = new System.Drawing.Point(230, 160);
            this.Deployable_Fridge_Radar_Color.Name = "Deployable_Fridge_Radar_Color";
            this.Deployable_Fridge_Radar_Color.Size = new System.Drawing.Size(75, 17);
            this.Deployable_Fridge_Radar_Color.TabIndex = 20;
            this.Deployable_Fridge_Radar_Color.UseVisualStyleBackColor = false;
            this.Deployable_Fridge_Radar_Color.Click += new System.EventHandler(this.Fridge_Color_Click);
            // 
            // Deployable_AutoTurret_Tracer_Color
            // 
            this.Deployable_AutoTurret_Tracer_Color.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Deployable_AutoTurret_Tracer_Color.Location = new System.Drawing.Point(311, 91);
            this.Deployable_AutoTurret_Tracer_Color.Name = "Deployable_AutoTurret_Tracer_Color";
            this.Deployable_AutoTurret_Tracer_Color.Size = new System.Drawing.Size(75, 17);
            this.Deployable_AutoTurret_Tracer_Color.TabIndex = 60;
            this.Deployable_AutoTurret_Tracer_Color.UseVisualStyleBackColor = false;
            this.Deployable_AutoTurret_Tracer_Color.Click += new System.EventHandler(this.Deployable_AutoTurret_Tracer_Color_Click);
            // 
            // Deployable_Fridge_Radar_Check
            // 
            this.Deployable_Fridge_Radar_Check.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Deployable_Fridge_Radar_Check.AutoSize = true;
            this.Deployable_Fridge_Radar_Check.Checked = true;
            this.Deployable_Fridge_Radar_Check.CheckState = System.Windows.Forms.CheckState.Checked;
            this.Deployable_Fridge_Radar_Check.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Deployable_Fridge_Radar_Check.Location = new System.Drawing.Point(113, 163);
            this.Deployable_Fridge_Radar_Check.Margin = new System.Windows.Forms.Padding(3, 3, 0, 0);
            this.Deployable_Fridge_Radar_Check.Name = "Deployable_Fridge_Radar_Check";
            this.Deployable_Fridge_Radar_Check.Size = new System.Drawing.Size(15, 14);
            this.Deployable_Fridge_Radar_Check.TabIndex = 19;
            this.Deployable_Fridge_Radar_Check.UseVisualStyleBackColor = true;
            this.Deployable_Fridge_Radar_Check.CheckedChanged += new System.EventHandler(this.Fridge_Check_CheckedChanged);
            // 
            // Deployable_Sleeping_Bag_Box_Color
            // 
            this.Deployable_Sleeping_Bag_Box_Color.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Deployable_Sleeping_Bag_Box_Color.Location = new System.Drawing.Point(392, 68);
            this.Deployable_Sleeping_Bag_Box_Color.Name = "Deployable_Sleeping_Bag_Box_Color";
            this.Deployable_Sleeping_Bag_Box_Color.Size = new System.Drawing.Size(75, 17);
            this.Deployable_Sleeping_Bag_Box_Color.TabIndex = 58;
            this.Deployable_Sleeping_Bag_Box_Color.UseVisualStyleBackColor = false;
            this.Deployable_Sleeping_Bag_Box_Color.Click += new System.EventHandler(this.Deployable_Sleeping_Bag_Box_Color_Click);
            // 
            // Deployable_Sleeping_Bag_Tracer_Color
            // 
            this.Deployable_Sleeping_Bag_Tracer_Color.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Deployable_Sleeping_Bag_Tracer_Color.Location = new System.Drawing.Point(311, 68);
            this.Deployable_Sleeping_Bag_Tracer_Color.Name = "Deployable_Sleeping_Bag_Tracer_Color";
            this.Deployable_Sleeping_Bag_Tracer_Color.Size = new System.Drawing.Size(75, 17);
            this.Deployable_Sleeping_Bag_Tracer_Color.TabIndex = 57;
            this.Deployable_Sleeping_Bag_Tracer_Color.UseVisualStyleBackColor = false;
            this.Deployable_Sleeping_Bag_Tracer_Color.Click += new System.EventHandler(this.Deployable_Sleeping_Bag_Tracer_Color_Click);
            // 
            // Deployable_TC_Box_Color
            // 
            this.Deployable_TC_Box_Color.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Deployable_TC_Box_Color.Location = new System.Drawing.Point(392, 45);
            this.Deployable_TC_Box_Color.Name = "Deployable_TC_Box_Color";
            this.Deployable_TC_Box_Color.Size = new System.Drawing.Size(75, 17);
            this.Deployable_TC_Box_Color.TabIndex = 55;
            this.Deployable_TC_Box_Color.UseVisualStyleBackColor = false;
            this.Deployable_TC_Box_Color.Click += new System.EventHandler(this.Deployable_TC_Box_Color_Click);
            // 
            // Deployable_TC_Tracer_Color
            // 
            this.Deployable_TC_Tracer_Color.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Deployable_TC_Tracer_Color.Location = new System.Drawing.Point(311, 45);
            this.Deployable_TC_Tracer_Color.Name = "Deployable_TC_Tracer_Color";
            this.Deployable_TC_Tracer_Color.Size = new System.Drawing.Size(75, 17);
            this.Deployable_TC_Tracer_Color.TabIndex = 54;
            this.Deployable_TC_Tracer_Color.UseVisualStyleBackColor = false;
            this.Deployable_TC_Tracer_Color.Click += new System.EventHandler(this.Deployable_TC_Tracer_Color_Click);
            // 
            // Deployable_Furnace_Box_Check
            // 
            this.Deployable_Furnace_Box_Check.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Deployable_Furnace_Box_Check.AutoSize = true;
            this.Deployable_Furnace_Box_Check.CheckAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.Deployable_Furnace_Box_Check.Checked = true;
            this.Deployable_Furnace_Box_Check.CheckState = System.Windows.Forms.CheckState.Checked;
            this.Deployable_Furnace_Box_Check.Location = new System.Drawing.Point(204, 117);
            this.Deployable_Furnace_Box_Check.Margin = new System.Windows.Forms.Padding(3, 3, 0, 0);
            this.Deployable_Furnace_Box_Check.Name = "Deployable_Furnace_Box_Check";
            this.Deployable_Furnace_Box_Check.Size = new System.Drawing.Size(15, 14);
            this.Deployable_Furnace_Box_Check.TabIndex = 38;
            this.Deployable_Furnace_Box_Check.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.Deployable_Furnace_Box_Check.UseVisualStyleBackColor = true;
            this.Deployable_Furnace_Box_Check.CheckedChanged += new System.EventHandler(this.Deployable_Furnace_Box_Check_CheckedChanged);
            // 
            // Deployable_Large_Furnace_Radar_Color
            // 
            this.Deployable_Large_Furnace_Radar_Color.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Deployable_Large_Furnace_Radar_Color.Location = new System.Drawing.Point(230, 137);
            this.Deployable_Large_Furnace_Radar_Color.Name = "Deployable_Large_Furnace_Radar_Color";
            this.Deployable_Large_Furnace_Radar_Color.Size = new System.Drawing.Size(75, 17);
            this.Deployable_Large_Furnace_Radar_Color.TabIndex = 13;
            this.Deployable_Large_Furnace_Radar_Color.UseVisualStyleBackColor = false;
            this.Deployable_Large_Furnace_Radar_Color.Click += new System.EventHandler(this.Large_Furnace_Color_Click);
            // 
            // Deployable_TC_Box_Check
            // 
            this.Deployable_TC_Box_Check.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Deployable_TC_Box_Check.AutoSize = true;
            this.Deployable_TC_Box_Check.CheckAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.Deployable_TC_Box_Check.Checked = true;
            this.Deployable_TC_Box_Check.CheckState = System.Windows.Forms.CheckState.Checked;
            this.Deployable_TC_Box_Check.Location = new System.Drawing.Point(204, 48);
            this.Deployable_TC_Box_Check.Margin = new System.Windows.Forms.Padding(3, 3, 0, 0);
            this.Deployable_TC_Box_Check.Name = "Deployable_TC_Box_Check";
            this.Deployable_TC_Box_Check.Size = new System.Drawing.Size(15, 14);
            this.Deployable_TC_Box_Check.TabIndex = 34;
            this.Deployable_TC_Box_Check.UseVisualStyleBackColor = true;
            this.Deployable_TC_Box_Check.CheckedChanged += new System.EventHandler(this.Deployable_TC_Box_Check_CheckedChanged);
            // 
            // Deployable_Large_Furnace_Radar_Check
            // 
            this.Deployable_Large_Furnace_Radar_Check.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Deployable_Large_Furnace_Radar_Check.AutoSize = true;
            this.Deployable_Large_Furnace_Radar_Check.Checked = true;
            this.Deployable_Large_Furnace_Radar_Check.CheckState = System.Windows.Forms.CheckState.Checked;
            this.Deployable_Large_Furnace_Radar_Check.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Deployable_Large_Furnace_Radar_Check.Location = new System.Drawing.Point(113, 140);
            this.Deployable_Large_Furnace_Radar_Check.Margin = new System.Windows.Forms.Padding(3, 3, 0, 0);
            this.Deployable_Large_Furnace_Radar_Check.Name = "Deployable_Large_Furnace_Radar_Check";
            this.Deployable_Large_Furnace_Radar_Check.Size = new System.Drawing.Size(15, 14);
            this.Deployable_Large_Furnace_Radar_Check.TabIndex = 12;
            this.Deployable_Large_Furnace_Radar_Check.UseVisualStyleBackColor = true;
            this.Deployable_Large_Furnace_Radar_Check.CheckedChanged += new System.EventHandler(this.Large_Furnace_Check_CheckedChanged);
            // 
            // Deployable_AutoTurret_Box_Check
            // 
            this.Deployable_AutoTurret_Box_Check.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Deployable_AutoTurret_Box_Check.AutoSize = true;
            this.Deployable_AutoTurret_Box_Check.CheckAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.Deployable_AutoTurret_Box_Check.Checked = true;
            this.Deployable_AutoTurret_Box_Check.CheckState = System.Windows.Forms.CheckState.Checked;
            this.Deployable_AutoTurret_Box_Check.Location = new System.Drawing.Point(204, 94);
            this.Deployable_AutoTurret_Box_Check.Margin = new System.Windows.Forms.Padding(3, 3, 0, 0);
            this.Deployable_AutoTurret_Box_Check.Name = "Deployable_AutoTurret_Box_Check";
            this.Deployable_AutoTurret_Box_Check.Size = new System.Drawing.Size(15, 14);
            this.Deployable_AutoTurret_Box_Check.TabIndex = 37;
            this.Deployable_AutoTurret_Box_Check.UseVisualStyleBackColor = true;
            this.Deployable_AutoTurret_Box_Check.CheckedChanged += new System.EventHandler(this.Deployable_AutoTurret_Box_Check_CheckedChanged);
            // 
            // Deployable_Furnace_Radar_Color
            // 
            this.Deployable_Furnace_Radar_Color.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Deployable_Furnace_Radar_Color.Location = new System.Drawing.Point(230, 114);
            this.Deployable_Furnace_Radar_Color.Name = "Deployable_Furnace_Radar_Color";
            this.Deployable_Furnace_Radar_Color.Size = new System.Drawing.Size(75, 17);
            this.Deployable_Furnace_Radar_Color.TabIndex = 11;
            this.Deployable_Furnace_Radar_Color.UseVisualStyleBackColor = false;
            this.Deployable_Furnace_Radar_Color.Click += new System.EventHandler(this.Furnace_Color_Click);
            // 
            // Deployable_TC_Tracer_Check
            // 
            this.Deployable_TC_Tracer_Check.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Deployable_TC_Tracer_Check.AutoSize = true;
            this.Deployable_TC_Tracer_Check.CheckAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.Deployable_TC_Tracer_Check.Checked = true;
            this.Deployable_TC_Tracer_Check.CheckState = System.Windows.Forms.CheckState.Checked;
            this.Deployable_TC_Tracer_Check.Location = new System.Drawing.Point(162, 48);
            this.Deployable_TC_Tracer_Check.Margin = new System.Windows.Forms.Padding(3, 3, 0, 0);
            this.Deployable_TC_Tracer_Check.Name = "Deployable_TC_Tracer_Check";
            this.Deployable_TC_Tracer_Check.Size = new System.Drawing.Size(15, 14);
            this.Deployable_TC_Tracer_Check.TabIndex = 33;
            this.Deployable_TC_Tracer_Check.UseVisualStyleBackColor = true;
            this.Deployable_TC_Tracer_Check.CheckedChanged += new System.EventHandler(this.Deployable_TC_Tracer_Check_CheckedChanged);
            // 
            // Deployable_Furnace_Radar_Check
            // 
            this.Deployable_Furnace_Radar_Check.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Deployable_Furnace_Radar_Check.AutoSize = true;
            this.Deployable_Furnace_Radar_Check.Checked = true;
            this.Deployable_Furnace_Radar_Check.CheckState = System.Windows.Forms.CheckState.Checked;
            this.Deployable_Furnace_Radar_Check.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Deployable_Furnace_Radar_Check.Location = new System.Drawing.Point(113, 117);
            this.Deployable_Furnace_Radar_Check.Margin = new System.Windows.Forms.Padding(3, 3, 0, 0);
            this.Deployable_Furnace_Radar_Check.Name = "Deployable_Furnace_Radar_Check";
            this.Deployable_Furnace_Radar_Check.Size = new System.Drawing.Size(15, 14);
            this.Deployable_Furnace_Radar_Check.TabIndex = 10;
            this.Deployable_Furnace_Radar_Check.UseVisualStyleBackColor = true;
            this.Deployable_Furnace_Radar_Check.CheckedChanged += new System.EventHandler(this.Furnace_Check_CheckedChanged);
            // 
            // label34
            // 
            this.label34.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label34.AutoSize = true;
            this.label34.Location = new System.Drawing.Point(3, 45);
            this.label34.Margin = new System.Windows.Forms.Padding(3);
            this.label34.Name = "label34";
            this.label34.Size = new System.Drawing.Size(90, 17);
            this.label34.TabIndex = 31;
            this.label34.Text = "Tool Cupboard";
            this.label34.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Deployable_AutoTurret_Radar_Color
            // 
            this.Deployable_AutoTurret_Radar_Color.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Deployable_AutoTurret_Radar_Color.Location = new System.Drawing.Point(230, 91);
            this.Deployable_AutoTurret_Radar_Color.Name = "Deployable_AutoTurret_Radar_Color";
            this.Deployable_AutoTurret_Radar_Color.Size = new System.Drawing.Size(75, 17);
            this.Deployable_AutoTurret_Radar_Color.TabIndex = 8;
            this.Deployable_AutoTurret_Radar_Color.UseVisualStyleBackColor = false;
            this.Deployable_AutoTurret_Radar_Color.Click += new System.EventHandler(this.AutoTurret_Color_Click);
            // 
            // Deployable_Quarry_Radar_Color
            // 
            this.Deployable_Quarry_Radar_Color.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Deployable_Quarry_Radar_Color.Location = new System.Drawing.Point(230, 22);
            this.Deployable_Quarry_Radar_Color.Name = "Deployable_Quarry_Radar_Color";
            this.Deployable_Quarry_Radar_Color.Size = new System.Drawing.Size(75, 17);
            this.Deployable_Quarry_Radar_Color.TabIndex = 9;
            this.Deployable_Quarry_Radar_Color.UseVisualStyleBackColor = false;
            this.Deployable_Quarry_Radar_Color.Click += new System.EventHandler(this.Quarry_Color_Click);
            // 
            // Deployable_AutoTurret_Radar_Check
            // 
            this.Deployable_AutoTurret_Radar_Check.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Deployable_AutoTurret_Radar_Check.AutoSize = true;
            this.Deployable_AutoTurret_Radar_Check.Checked = true;
            this.Deployable_AutoTurret_Radar_Check.CheckState = System.Windows.Forms.CheckState.Checked;
            this.Deployable_AutoTurret_Radar_Check.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Deployable_AutoTurret_Radar_Check.Location = new System.Drawing.Point(113, 94);
            this.Deployable_AutoTurret_Radar_Check.Margin = new System.Windows.Forms.Padding(3, 3, 0, 0);
            this.Deployable_AutoTurret_Radar_Check.Name = "Deployable_AutoTurret_Radar_Check";
            this.Deployable_AutoTurret_Radar_Check.Size = new System.Drawing.Size(15, 14);
            this.Deployable_AutoTurret_Radar_Check.TabIndex = 3;
            this.Deployable_AutoTurret_Radar_Check.UseVisualStyleBackColor = true;
            this.Deployable_AutoTurret_Radar_Check.CheckedChanged += new System.EventHandler(this.AutoTurret_Check_CheckedChanged);
            // 
            // Deployable_Sleeping_Bag_Radar_Color
            // 
            this.Deployable_Sleeping_Bag_Radar_Color.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Deployable_Sleeping_Bag_Radar_Color.Location = new System.Drawing.Point(230, 68);
            this.Deployable_Sleeping_Bag_Radar_Color.Name = "Deployable_Sleeping_Bag_Radar_Color";
            this.Deployable_Sleeping_Bag_Radar_Color.Size = new System.Drawing.Size(75, 17);
            this.Deployable_Sleeping_Bag_Radar_Color.TabIndex = 7;
            this.Deployable_Sleeping_Bag_Radar_Color.UseVisualStyleBackColor = false;
            this.Deployable_Sleeping_Bag_Radar_Color.Click += new System.EventHandler(this.Sleeping_Bag_Color_Click);
            // 
            // Deployable_Furnace_Tracer_Check
            // 
            this.Deployable_Furnace_Tracer_Check.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Deployable_Furnace_Tracer_Check.AutoSize = true;
            this.Deployable_Furnace_Tracer_Check.CheckAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.Deployable_Furnace_Tracer_Check.Checked = true;
            this.Deployable_Furnace_Tracer_Check.CheckState = System.Windows.Forms.CheckState.Checked;
            this.Deployable_Furnace_Tracer_Check.Location = new System.Drawing.Point(162, 117);
            this.Deployable_Furnace_Tracer_Check.Margin = new System.Windows.Forms.Padding(3, 3, 0, 0);
            this.Deployable_Furnace_Tracer_Check.Name = "Deployable_Furnace_Tracer_Check";
            this.Deployable_Furnace_Tracer_Check.Size = new System.Drawing.Size(15, 14);
            this.Deployable_Furnace_Tracer_Check.TabIndex = 35;
            this.Deployable_Furnace_Tracer_Check.UseVisualStyleBackColor = true;
            this.Deployable_Furnace_Tracer_Check.CheckedChanged += new System.EventHandler(this.Deployable_Furnace_Tracer_Check_CheckedChanged);
            // 
            // Deployable_TC_Radar_Color
            // 
            this.Deployable_TC_Radar_Color.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Deployable_TC_Radar_Color.Location = new System.Drawing.Point(230, 45);
            this.Deployable_TC_Radar_Color.Name = "Deployable_TC_Radar_Color";
            this.Deployable_TC_Radar_Color.Size = new System.Drawing.Size(75, 17);
            this.Deployable_TC_Radar_Color.TabIndex = 6;
            this.Deployable_TC_Radar_Color.UseVisualStyleBackColor = false;
            this.Deployable_TC_Radar_Color.Click += new System.EventHandler(this.Tool_Cupboard_Color_Click);
            // 
            // Deployable_Sleeping_Bag_Radar_Check
            // 
            this.Deployable_Sleeping_Bag_Radar_Check.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Deployable_Sleeping_Bag_Radar_Check.AutoSize = true;
            this.Deployable_Sleeping_Bag_Radar_Check.Checked = true;
            this.Deployable_Sleeping_Bag_Radar_Check.CheckState = System.Windows.Forms.CheckState.Checked;
            this.Deployable_Sleeping_Bag_Radar_Check.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Deployable_Sleeping_Bag_Radar_Check.Location = new System.Drawing.Point(113, 71);
            this.Deployable_Sleeping_Bag_Radar_Check.Margin = new System.Windows.Forms.Padding(3, 3, 0, 0);
            this.Deployable_Sleeping_Bag_Radar_Check.Name = "Deployable_Sleeping_Bag_Radar_Check";
            this.Deployable_Sleeping_Bag_Radar_Check.Size = new System.Drawing.Size(15, 14);
            this.Deployable_Sleeping_Bag_Radar_Check.TabIndex = 2;
            this.Deployable_Sleeping_Bag_Radar_Check.UseVisualStyleBackColor = true;
            this.Deployable_Sleeping_Bag_Radar_Check.CheckedChanged += new System.EventHandler(this.Sleeping_Bag_Check_CheckedChanged);
            // 
            // Deployable_Quarry_Box_Check
            // 
            this.Deployable_Quarry_Box_Check.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Deployable_Quarry_Box_Check.AutoSize = true;
            this.Deployable_Quarry_Box_Check.CheckAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.Deployable_Quarry_Box_Check.Checked = true;
            this.Deployable_Quarry_Box_Check.CheckState = System.Windows.Forms.CheckState.Checked;
            this.Deployable_Quarry_Box_Check.Location = new System.Drawing.Point(204, 25);
            this.Deployable_Quarry_Box_Check.Margin = new System.Windows.Forms.Padding(3, 3, 0, 0);
            this.Deployable_Quarry_Box_Check.Name = "Deployable_Quarry_Box_Check";
            this.Deployable_Quarry_Box_Check.Size = new System.Drawing.Size(15, 14);
            this.Deployable_Quarry_Box_Check.TabIndex = 30;
            this.Deployable_Quarry_Box_Check.UseVisualStyleBackColor = true;
            this.Deployable_Quarry_Box_Check.CheckedChanged += new System.EventHandler(this.Deployable_Quarry_Box_Check_CheckedChanged);
            // 
            // Deployable_Quarry_Tracer_Check
            // 
            this.Deployable_Quarry_Tracer_Check.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Deployable_Quarry_Tracer_Check.AutoSize = true;
            this.Deployable_Quarry_Tracer_Check.CheckAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.Deployable_Quarry_Tracer_Check.Checked = true;
            this.Deployable_Quarry_Tracer_Check.CheckState = System.Windows.Forms.CheckState.Checked;
            this.Deployable_Quarry_Tracer_Check.Location = new System.Drawing.Point(162, 25);
            this.Deployable_Quarry_Tracer_Check.Margin = new System.Windows.Forms.Padding(3, 3, 0, 0);
            this.Deployable_Quarry_Tracer_Check.Name = "Deployable_Quarry_Tracer_Check";
            this.Deployable_Quarry_Tracer_Check.Size = new System.Drawing.Size(15, 14);
            this.Deployable_Quarry_Tracer_Check.TabIndex = 29;
            this.Deployable_Quarry_Tracer_Check.UseVisualStyleBackColor = true;
            this.Deployable_Quarry_Tracer_Check.CheckedChanged += new System.EventHandler(this.Deployable_Quarry_Tracer_Check_CheckedChanged);
            // 
            // label35
            // 
            this.label35.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label35.AutoSize = true;
            this.label35.Location = new System.Drawing.Point(3, 22);
            this.label35.Margin = new System.Windows.Forms.Padding(3);
            this.label35.Name = "label35";
            this.label35.Size = new System.Drawing.Size(90, 17);
            this.label35.TabIndex = 12;
            this.label35.Text = "Quarry";
            this.label35.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Deployable_TC_Radar_Check
            // 
            this.Deployable_TC_Radar_Check.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Deployable_TC_Radar_Check.AutoSize = true;
            this.Deployable_TC_Radar_Check.Checked = true;
            this.Deployable_TC_Radar_Check.CheckState = System.Windows.Forms.CheckState.Checked;
            this.Deployable_TC_Radar_Check.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Deployable_TC_Radar_Check.Location = new System.Drawing.Point(113, 48);
            this.Deployable_TC_Radar_Check.Margin = new System.Windows.Forms.Padding(3, 3, 0, 0);
            this.Deployable_TC_Radar_Check.Name = "Deployable_TC_Radar_Check";
            this.Deployable_TC_Radar_Check.Size = new System.Drawing.Size(15, 14);
            this.Deployable_TC_Radar_Check.TabIndex = 1;
            this.Deployable_TC_Radar_Check.UseVisualStyleBackColor = true;
            this.Deployable_TC_Radar_Check.CheckedChanged += new System.EventHandler(this.Tool_Cupboard_Check_CheckedChanged);
            // 
            // Deployable_Quarry_Tracer_Color
            // 
            this.Deployable_Quarry_Tracer_Color.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Deployable_Quarry_Tracer_Color.Location = new System.Drawing.Point(311, 22);
            this.Deployable_Quarry_Tracer_Color.Name = "Deployable_Quarry_Tracer_Color";
            this.Deployable_Quarry_Tracer_Color.Size = new System.Drawing.Size(75, 17);
            this.Deployable_Quarry_Tracer_Color.TabIndex = 27;
            this.Deployable_Quarry_Tracer_Color.UseVisualStyleBackColor = false;
            this.Deployable_Quarry_Tracer_Color.Click += new System.EventHandler(this.Deployable_Quarry_Tracer_Color_Click);
            // 
            // Deployable_Quarry_Radar_Check
            // 
            this.Deployable_Quarry_Radar_Check.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Deployable_Quarry_Radar_Check.AutoSize = true;
            this.Deployable_Quarry_Radar_Check.Checked = true;
            this.Deployable_Quarry_Radar_Check.CheckState = System.Windows.Forms.CheckState.Checked;
            this.Deployable_Quarry_Radar_Check.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Deployable_Quarry_Radar_Check.Location = new System.Drawing.Point(113, 25);
            this.Deployable_Quarry_Radar_Check.Margin = new System.Windows.Forms.Padding(3, 3, 0, 0);
            this.Deployable_Quarry_Radar_Check.Name = "Deployable_Quarry_Radar_Check";
            this.Deployable_Quarry_Radar_Check.Size = new System.Drawing.Size(15, 14);
            this.Deployable_Quarry_Radar_Check.TabIndex = 0;
            this.Deployable_Quarry_Radar_Check.UseVisualStyleBackColor = true;
            this.Deployable_Quarry_Radar_Check.CheckedChanged += new System.EventHandler(this.Quarry_Check_CheckedChanged);
            // 
            // Deployable_Quarry_Box_Color
            // 
            this.Deployable_Quarry_Box_Color.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Deployable_Quarry_Box_Color.Location = new System.Drawing.Point(392, 22);
            this.Deployable_Quarry_Box_Color.Name = "Deployable_Quarry_Box_Color";
            this.Deployable_Quarry_Box_Color.Size = new System.Drawing.Size(75, 17);
            this.Deployable_Quarry_Box_Color.TabIndex = 28;
            this.Deployable_Quarry_Box_Color.UseVisualStyleBackColor = false;
            this.Deployable_Quarry_Box_Color.Click += new System.EventHandler(this.Deployable_Quarry_Box_Color_Click);
            // 
            // label36
            // 
            this.label36.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label36.AutoSize = true;
            this.label36.Location = new System.Drawing.Point(3, 68);
            this.label36.Margin = new System.Windows.Forms.Padding(3);
            this.label36.Name = "label36";
            this.label36.Size = new System.Drawing.Size(90, 17);
            this.label36.TabIndex = 32;
            this.label36.Text = "Sleeping Bag";
            this.label36.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Deployable_Sleeping_Bag_Tracer_Check
            // 
            this.Deployable_Sleeping_Bag_Tracer_Check.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Deployable_Sleeping_Bag_Tracer_Check.AutoSize = true;
            this.Deployable_Sleeping_Bag_Tracer_Check.CheckAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.Deployable_Sleeping_Bag_Tracer_Check.Checked = true;
            this.Deployable_Sleeping_Bag_Tracer_Check.CheckState = System.Windows.Forms.CheckState.Checked;
            this.Deployable_Sleeping_Bag_Tracer_Check.Location = new System.Drawing.Point(162, 71);
            this.Deployable_Sleeping_Bag_Tracer_Check.Margin = new System.Windows.Forms.Padding(3, 3, 0, 0);
            this.Deployable_Sleeping_Bag_Tracer_Check.Name = "Deployable_Sleeping_Bag_Tracer_Check";
            this.Deployable_Sleeping_Bag_Tracer_Check.Size = new System.Drawing.Size(15, 14);
            this.Deployable_Sleeping_Bag_Tracer_Check.TabIndex = 35;
            this.Deployable_Sleeping_Bag_Tracer_Check.UseVisualStyleBackColor = true;
            this.Deployable_Sleeping_Bag_Tracer_Check.CheckedChanged += new System.EventHandler(this.Deployable_Sleeping_Bag_Tracer_Check_CheckedChanged);
            // 
            // Deployable_Sleeping_Bag_Box_Check
            // 
            this.Deployable_Sleeping_Bag_Box_Check.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Deployable_Sleeping_Bag_Box_Check.AutoSize = true;
            this.Deployable_Sleeping_Bag_Box_Check.CheckAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.Deployable_Sleeping_Bag_Box_Check.Checked = true;
            this.Deployable_Sleeping_Bag_Box_Check.CheckState = System.Windows.Forms.CheckState.Checked;
            this.Deployable_Sleeping_Bag_Box_Check.Location = new System.Drawing.Point(204, 71);
            this.Deployable_Sleeping_Bag_Box_Check.Margin = new System.Windows.Forms.Padding(3, 3, 0, 0);
            this.Deployable_Sleeping_Bag_Box_Check.Name = "Deployable_Sleeping_Bag_Box_Check";
            this.Deployable_Sleeping_Bag_Box_Check.Size = new System.Drawing.Size(15, 14);
            this.Deployable_Sleeping_Bag_Box_Check.TabIndex = 36;
            this.Deployable_Sleeping_Bag_Box_Check.UseVisualStyleBackColor = true;
            this.Deployable_Sleeping_Bag_Box_Check.CheckedChanged += new System.EventHandler(this.Deployable_Sleeping_Bag_Box_Check_CheckedChanged);
            // 
            // Deployable_AutoTurret_Tracer_Check
            // 
            this.Deployable_AutoTurret_Tracer_Check.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Deployable_AutoTurret_Tracer_Check.AutoSize = true;
            this.Deployable_AutoTurret_Tracer_Check.CheckAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.Deployable_AutoTurret_Tracer_Check.Checked = true;
            this.Deployable_AutoTurret_Tracer_Check.CheckState = System.Windows.Forms.CheckState.Checked;
            this.Deployable_AutoTurret_Tracer_Check.Location = new System.Drawing.Point(162, 94);
            this.Deployable_AutoTurret_Tracer_Check.Margin = new System.Windows.Forms.Padding(3, 3, 0, 0);
            this.Deployable_AutoTurret_Tracer_Check.Name = "Deployable_AutoTurret_Tracer_Check";
            this.Deployable_AutoTurret_Tracer_Check.Size = new System.Drawing.Size(15, 14);
            this.Deployable_AutoTurret_Tracer_Check.TabIndex = 37;
            this.Deployable_AutoTurret_Tracer_Check.UseVisualStyleBackColor = true;
            this.Deployable_AutoTurret_Tracer_Check.CheckedChanged += new System.EventHandler(this.Deployable_AutoTurret_Tracer_Check_CheckedChanged);
            // 
            // label37
            // 
            this.label37.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label37.AutoSize = true;
            this.label37.Location = new System.Drawing.Point(3, 91);
            this.label37.Margin = new System.Windows.Forms.Padding(3);
            this.label37.Name = "label37";
            this.label37.Size = new System.Drawing.Size(90, 17);
            this.label37.TabIndex = 39;
            this.label37.Text = "AutoTurret";
            this.label37.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label38
            // 
            this.label38.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label38.AutoSize = true;
            this.label38.Location = new System.Drawing.Point(3, 114);
            this.label38.Margin = new System.Windows.Forms.Padding(3);
            this.label38.Name = "label38";
            this.label38.Size = new System.Drawing.Size(90, 17);
            this.label38.TabIndex = 40;
            this.label38.Text = "Furnace";
            this.label38.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label39
            // 
            this.label39.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label39.AutoSize = true;
            this.label39.Location = new System.Drawing.Point(3, 137);
            this.label39.Margin = new System.Windows.Forms.Padding(3);
            this.label39.Name = "label39";
            this.label39.Size = new System.Drawing.Size(90, 17);
            this.label39.TabIndex = 41;
            this.label39.Text = "Large Furnace";
            this.label39.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label40
            // 
            this.label40.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label40.AutoSize = true;
            this.label40.Location = new System.Drawing.Point(3, 160);
            this.label40.Margin = new System.Windows.Forms.Padding(3);
            this.label40.Name = "label40";
            this.label40.Size = new System.Drawing.Size(90, 17);
            this.label40.TabIndex = 42;
            this.label40.Text = "Fridge";
            this.label40.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label41
            // 
            this.label41.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label41.AutoSize = true;
            this.label41.Location = new System.Drawing.Point(3, 183);
            this.label41.Margin = new System.Windows.Forms.Padding(3);
            this.label41.Name = "label41";
            this.label41.Size = new System.Drawing.Size(90, 17);
            this.label41.TabIndex = 43;
            this.label41.Text = "Oil Refinery";
            this.label41.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Deployable_Large_Furnace_Tracer_Check
            // 
            this.Deployable_Large_Furnace_Tracer_Check.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Deployable_Large_Furnace_Tracer_Check.AutoSize = true;
            this.Deployable_Large_Furnace_Tracer_Check.CheckAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.Deployable_Large_Furnace_Tracer_Check.Checked = true;
            this.Deployable_Large_Furnace_Tracer_Check.CheckState = System.Windows.Forms.CheckState.Checked;
            this.Deployable_Large_Furnace_Tracer_Check.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Deployable_Large_Furnace_Tracer_Check.Location = new System.Drawing.Point(162, 140);
            this.Deployable_Large_Furnace_Tracer_Check.Margin = new System.Windows.Forms.Padding(3, 3, 0, 0);
            this.Deployable_Large_Furnace_Tracer_Check.Name = "Deployable_Large_Furnace_Tracer_Check";
            this.Deployable_Large_Furnace_Tracer_Check.Size = new System.Drawing.Size(15, 14);
            this.Deployable_Large_Furnace_Tracer_Check.TabIndex = 48;
            this.Deployable_Large_Furnace_Tracer_Check.UseVisualStyleBackColor = true;
            this.Deployable_Large_Furnace_Tracer_Check.CheckedChanged += new System.EventHandler(this.Deployable_Large_Furnace_Tracer_Check_CheckedChanged);
            // 
            // Deployable_Large_Furnace_Box_Check
            // 
            this.Deployable_Large_Furnace_Box_Check.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Deployable_Large_Furnace_Box_Check.AutoSize = true;
            this.Deployable_Large_Furnace_Box_Check.CheckAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.Deployable_Large_Furnace_Box_Check.Checked = true;
            this.Deployable_Large_Furnace_Box_Check.CheckState = System.Windows.Forms.CheckState.Checked;
            this.Deployable_Large_Furnace_Box_Check.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Deployable_Large_Furnace_Box_Check.Location = new System.Drawing.Point(204, 140);
            this.Deployable_Large_Furnace_Box_Check.Margin = new System.Windows.Forms.Padding(3, 3, 0, 0);
            this.Deployable_Large_Furnace_Box_Check.Name = "Deployable_Large_Furnace_Box_Check";
            this.Deployable_Large_Furnace_Box_Check.Size = new System.Drawing.Size(15, 14);
            this.Deployable_Large_Furnace_Box_Check.TabIndex = 49;
            this.Deployable_Large_Furnace_Box_Check.UseVisualStyleBackColor = true;
            this.Deployable_Large_Furnace_Box_Check.CheckedChanged += new System.EventHandler(this.Deployable_Large_Furnace_Box_Check_CheckedChanged);
            // 
            // Deployable_Fridge_Box_Check
            // 
            this.Deployable_Fridge_Box_Check.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Deployable_Fridge_Box_Check.AutoSize = true;
            this.Deployable_Fridge_Box_Check.CheckAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.Deployable_Fridge_Box_Check.Checked = true;
            this.Deployable_Fridge_Box_Check.CheckState = System.Windows.Forms.CheckState.Checked;
            this.Deployable_Fridge_Box_Check.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Deployable_Fridge_Box_Check.Location = new System.Drawing.Point(204, 163);
            this.Deployable_Fridge_Box_Check.Margin = new System.Windows.Forms.Padding(3, 3, 0, 0);
            this.Deployable_Fridge_Box_Check.Name = "Deployable_Fridge_Box_Check";
            this.Deployable_Fridge_Box_Check.Size = new System.Drawing.Size(15, 14);
            this.Deployable_Fridge_Box_Check.TabIndex = 50;
            this.Deployable_Fridge_Box_Check.UseVisualStyleBackColor = true;
            this.Deployable_Fridge_Box_Check.CheckedChanged += new System.EventHandler(this.Deployable_Fridge_Box_Check_CheckedChanged);
            // 
            // Deployable_Fridge_Tracer_Check
            // 
            this.Deployable_Fridge_Tracer_Check.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Deployable_Fridge_Tracer_Check.AutoSize = true;
            this.Deployable_Fridge_Tracer_Check.CheckAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.Deployable_Fridge_Tracer_Check.Checked = true;
            this.Deployable_Fridge_Tracer_Check.CheckState = System.Windows.Forms.CheckState.Checked;
            this.Deployable_Fridge_Tracer_Check.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Deployable_Fridge_Tracer_Check.Location = new System.Drawing.Point(162, 163);
            this.Deployable_Fridge_Tracer_Check.Margin = new System.Windows.Forms.Padding(3, 3, 0, 0);
            this.Deployable_Fridge_Tracer_Check.Name = "Deployable_Fridge_Tracer_Check";
            this.Deployable_Fridge_Tracer_Check.Size = new System.Drawing.Size(15, 14);
            this.Deployable_Fridge_Tracer_Check.TabIndex = 51;
            this.Deployable_Fridge_Tracer_Check.UseVisualStyleBackColor = true;
            this.Deployable_Fridge_Tracer_Check.CheckedChanged += new System.EventHandler(this.Deployable_Fridge_Tracer_Check_CheckedChanged);
            // 
            // Deployable_Oil_Tracer_Check
            // 
            this.Deployable_Oil_Tracer_Check.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Deployable_Oil_Tracer_Check.AutoSize = true;
            this.Deployable_Oil_Tracer_Check.CheckAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.Deployable_Oil_Tracer_Check.Checked = true;
            this.Deployable_Oil_Tracer_Check.CheckState = System.Windows.Forms.CheckState.Checked;
            this.Deployable_Oil_Tracer_Check.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Deployable_Oil_Tracer_Check.Location = new System.Drawing.Point(162, 186);
            this.Deployable_Oil_Tracer_Check.Margin = new System.Windows.Forms.Padding(3, 3, 0, 0);
            this.Deployable_Oil_Tracer_Check.Name = "Deployable_Oil_Tracer_Check";
            this.Deployable_Oil_Tracer_Check.Size = new System.Drawing.Size(15, 14);
            this.Deployable_Oil_Tracer_Check.TabIndex = 52;
            this.Deployable_Oil_Tracer_Check.UseVisualStyleBackColor = true;
            this.Deployable_Oil_Tracer_Check.CheckedChanged += new System.EventHandler(this.Deployable_Oil_Tracer_Check_CheckedChanged);
            // 
            // Deployable_Oil_Box_Check
            // 
            this.Deployable_Oil_Box_Check.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Deployable_Oil_Box_Check.AutoSize = true;
            this.Deployable_Oil_Box_Check.CheckAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.Deployable_Oil_Box_Check.Checked = true;
            this.Deployable_Oil_Box_Check.CheckState = System.Windows.Forms.CheckState.Checked;
            this.Deployable_Oil_Box_Check.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Deployable_Oil_Box_Check.Location = new System.Drawing.Point(204, 186);
            this.Deployable_Oil_Box_Check.Margin = new System.Windows.Forms.Padding(3, 3, 0, 0);
            this.Deployable_Oil_Box_Check.Name = "Deployable_Oil_Box_Check";
            this.Deployable_Oil_Box_Check.Size = new System.Drawing.Size(15, 14);
            this.Deployable_Oil_Box_Check.TabIndex = 53;
            this.Deployable_Oil_Box_Check.UseVisualStyleBackColor = true;
            this.Deployable_Oil_Box_Check.CheckedChanged += new System.EventHandler(this.Deployable_Oil_Box_Check_CheckedChanged);
            // 
            // label42
            // 
            this.label42.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label42.AutoSize = true;
            this.label42.Location = new System.Drawing.Point(99, 3);
            this.label42.Margin = new System.Windows.Forms.Padding(3);
            this.label42.Name = "label42";
            this.label42.Size = new System.Drawing.Size(41, 13);
            this.label42.TabIndex = 75;
            this.label42.Text = "Radar";
            this.label42.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label44
            // 
            this.label44.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label44.AutoSize = true;
            this.label44.Location = new System.Drawing.Point(196, 3);
            this.label44.Margin = new System.Windows.Forms.Padding(3);
            this.label44.Name = "label44";
            this.label44.Size = new System.Drawing.Size(28, 13);
            this.label44.TabIndex = 77;
            this.label44.Text = "Box";
            this.label44.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label45
            // 
            this.label45.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label45.AutoSize = true;
            this.label45.Location = new System.Drawing.Point(230, 3);
            this.label45.Margin = new System.Windows.Forms.Padding(3);
            this.label45.Name = "label45";
            this.label45.Size = new System.Drawing.Size(75, 13);
            this.label45.TabIndex = 79;
            this.label45.Text = "Radar";
            this.label45.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label46
            // 
            this.label46.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label46.AutoSize = true;
            this.label46.Location = new System.Drawing.Point(311, 3);
            this.label46.Margin = new System.Windows.Forms.Padding(3);
            this.label46.Name = "label46";
            this.label46.Size = new System.Drawing.Size(75, 13);
            this.label46.TabIndex = 78;
            this.label46.Text = "Tracer";
            this.label46.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label47
            // 
            this.label47.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label47.AutoSize = true;
            this.label47.Location = new System.Drawing.Point(392, 3);
            this.label47.Margin = new System.Windows.Forms.Padding(3);
            this.label47.Name = "label47";
            this.label47.Size = new System.Drawing.Size(75, 13);
            this.label47.TabIndex = 80;
            this.label47.Text = "Box";
            this.label47.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label43
            // 
            this.label43.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label43.AutoSize = true;
            this.label43.Location = new System.Drawing.Point(146, 3);
            this.label43.Margin = new System.Windows.Forms.Padding(3);
            this.label43.Name = "label43";
            this.label43.Size = new System.Drawing.Size(44, 13);
            this.label43.TabIndex = 76;
            this.label43.Text = "Tracer";
            this.label43.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label48
            // 
            this.label48.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label48.AutoSize = true;
            this.label48.Location = new System.Drawing.Point(3, 206);
            this.label48.Margin = new System.Windows.Forms.Padding(3);
            this.label48.Name = "label48";
            this.label48.Size = new System.Drawing.Size(90, 17);
            this.label48.TabIndex = 81;
            this.label48.Text = "Landmine";
            this.label48.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label52
            // 
            this.label52.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label52.AutoSize = true;
            this.label52.Location = new System.Drawing.Point(3, 229);
            this.label52.Margin = new System.Windows.Forms.Padding(3);
            this.label52.Name = "label52";
            this.label52.Size = new System.Drawing.Size(90, 17);
            this.label52.TabIndex = 46;
            this.label52.Text = "Bear Trap";
            this.label52.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label51
            // 
            this.label51.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label51.AutoSize = true;
            this.label51.Location = new System.Drawing.Point(3, 252);
            this.label51.Margin = new System.Windows.Forms.Padding(3);
            this.label51.Name = "label51";
            this.label51.Size = new System.Drawing.Size(90, 17);
            this.label51.TabIndex = 45;
            this.label51.Text = "Stash";
            this.label51.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label50
            // 
            this.label50.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label50.AutoSize = true;
            this.label50.Location = new System.Drawing.Point(3, 275);
            this.label50.Margin = new System.Windows.Forms.Padding(3);
            this.label50.Name = "label50";
            this.label50.Size = new System.Drawing.Size(90, 17);
            this.label50.TabIndex = 44;
            this.label50.Text = "Box";
            this.label50.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label49
            // 
            this.label49.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label49.AutoSize = true;
            this.label49.Location = new System.Drawing.Point(3, 298);
            this.label49.Margin = new System.Windows.Forms.Padding(3);
            this.label49.Name = "label49";
            this.label49.Size = new System.Drawing.Size(90, 17);
            this.label49.TabIndex = 43;
            this.label49.Text = "Large Box";
            this.label49.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Deployable_Landmine_Radar_Check
            // 
            this.Deployable_Landmine_Radar_Check.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Deployable_Landmine_Radar_Check.AutoSize = true;
            this.Deployable_Landmine_Radar_Check.Checked = true;
            this.Deployable_Landmine_Radar_Check.CheckState = System.Windows.Forms.CheckState.Checked;
            this.Deployable_Landmine_Radar_Check.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Deployable_Landmine_Radar_Check.Location = new System.Drawing.Point(113, 209);
            this.Deployable_Landmine_Radar_Check.Margin = new System.Windows.Forms.Padding(3, 3, 0, 0);
            this.Deployable_Landmine_Radar_Check.Name = "Deployable_Landmine_Radar_Check";
            this.Deployable_Landmine_Radar_Check.Size = new System.Drawing.Size(15, 14);
            this.Deployable_Landmine_Radar_Check.TabIndex = 14;
            this.Deployable_Landmine_Radar_Check.UseVisualStyleBackColor = true;
            this.Deployable_Landmine_Radar_Check.CheckedChanged += new System.EventHandler(this.Landmine_Check_CheckedChanged);
            // 
            // Deployable_Bear_Trap_Radar_Check
            // 
            this.Deployable_Bear_Trap_Radar_Check.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Deployable_Bear_Trap_Radar_Check.AutoSize = true;
            this.Deployable_Bear_Trap_Radar_Check.Checked = true;
            this.Deployable_Bear_Trap_Radar_Check.CheckState = System.Windows.Forms.CheckState.Checked;
            this.Deployable_Bear_Trap_Radar_Check.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Deployable_Bear_Trap_Radar_Check.Location = new System.Drawing.Point(113, 232);
            this.Deployable_Bear_Trap_Radar_Check.Margin = new System.Windows.Forms.Padding(3, 3, 0, 0);
            this.Deployable_Bear_Trap_Radar_Check.Name = "Deployable_Bear_Trap_Radar_Check";
            this.Deployable_Bear_Trap_Radar_Check.Size = new System.Drawing.Size(15, 14);
            this.Deployable_Bear_Trap_Radar_Check.TabIndex = 15;
            this.Deployable_Bear_Trap_Radar_Check.UseVisualStyleBackColor = true;
            this.Deployable_Bear_Trap_Radar_Check.CheckedChanged += new System.EventHandler(this.Bear_Trap_Check_CheckedChanged);
            // 
            // Deployable_Stash_Radar_Check
            // 
            this.Deployable_Stash_Radar_Check.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Deployable_Stash_Radar_Check.AutoSize = true;
            this.Deployable_Stash_Radar_Check.Checked = true;
            this.Deployable_Stash_Radar_Check.CheckState = System.Windows.Forms.CheckState.Checked;
            this.Deployable_Stash_Radar_Check.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Deployable_Stash_Radar_Check.Location = new System.Drawing.Point(113, 255);
            this.Deployable_Stash_Radar_Check.Margin = new System.Windows.Forms.Padding(3, 3, 0, 0);
            this.Deployable_Stash_Radar_Check.Name = "Deployable_Stash_Radar_Check";
            this.Deployable_Stash_Radar_Check.Size = new System.Drawing.Size(15, 14);
            this.Deployable_Stash_Radar_Check.TabIndex = 21;
            this.Deployable_Stash_Radar_Check.UseVisualStyleBackColor = true;
            this.Deployable_Stash_Radar_Check.CheckedChanged += new System.EventHandler(this.Stash_Check_CheckedChanged);
            // 
            // Deployable_Box_Radar_Check
            // 
            this.Deployable_Box_Radar_Check.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Deployable_Box_Radar_Check.AutoSize = true;
            this.Deployable_Box_Radar_Check.Checked = true;
            this.Deployable_Box_Radar_Check.CheckState = System.Windows.Forms.CheckState.Checked;
            this.Deployable_Box_Radar_Check.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Deployable_Box_Radar_Check.Location = new System.Drawing.Point(113, 278);
            this.Deployable_Box_Radar_Check.Margin = new System.Windows.Forms.Padding(3, 3, 0, 0);
            this.Deployable_Box_Radar_Check.Name = "Deployable_Box_Radar_Check";
            this.Deployable_Box_Radar_Check.Size = new System.Drawing.Size(15, 14);
            this.Deployable_Box_Radar_Check.TabIndex = 25;
            this.Deployable_Box_Radar_Check.UseVisualStyleBackColor = true;
            this.Deployable_Box_Radar_Check.CheckedChanged += new System.EventHandler(this.Box_Check_CheckedChanged);
            // 
            // Deployable_Large_Box_Radar_Check
            // 
            this.Deployable_Large_Box_Radar_Check.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Deployable_Large_Box_Radar_Check.AutoSize = true;
            this.Deployable_Large_Box_Radar_Check.Checked = true;
            this.Deployable_Large_Box_Radar_Check.CheckState = System.Windows.Forms.CheckState.Checked;
            this.Deployable_Large_Box_Radar_Check.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Deployable_Large_Box_Radar_Check.Location = new System.Drawing.Point(113, 301);
            this.Deployable_Large_Box_Radar_Check.Margin = new System.Windows.Forms.Padding(3, 3, 0, 0);
            this.Deployable_Large_Box_Radar_Check.Name = "Deployable_Large_Box_Radar_Check";
            this.Deployable_Large_Box_Radar_Check.Size = new System.Drawing.Size(15, 14);
            this.Deployable_Large_Box_Radar_Check.TabIndex = 27;
            this.Deployable_Large_Box_Radar_Check.UseVisualStyleBackColor = true;
            this.Deployable_Large_Box_Radar_Check.CheckedChanged += new System.EventHandler(this.Large_Box_Check_CheckedChanged);
            // 
            // Deployable_Landmine_Tracer_Check
            // 
            this.Deployable_Landmine_Tracer_Check.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Deployable_Landmine_Tracer_Check.AutoSize = true;
            this.Deployable_Landmine_Tracer_Check.CheckAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.Deployable_Landmine_Tracer_Check.Checked = true;
            this.Deployable_Landmine_Tracer_Check.CheckState = System.Windows.Forms.CheckState.Checked;
            this.Deployable_Landmine_Tracer_Check.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Deployable_Landmine_Tracer_Check.Location = new System.Drawing.Point(162, 209);
            this.Deployable_Landmine_Tracer_Check.Margin = new System.Windows.Forms.Padding(3, 3, 0, 0);
            this.Deployable_Landmine_Tracer_Check.Name = "Deployable_Landmine_Tracer_Check";
            this.Deployable_Landmine_Tracer_Check.Size = new System.Drawing.Size(15, 14);
            this.Deployable_Landmine_Tracer_Check.TabIndex = 56;
            this.Deployable_Landmine_Tracer_Check.UseVisualStyleBackColor = true;
            this.Deployable_Landmine_Tracer_Check.CheckedChanged += new System.EventHandler(this.Deployable_Landmine_Tracer_Check_CheckedChanged);
            // 
            // Deployable_Bear_Trap_Tracer_Check
            // 
            this.Deployable_Bear_Trap_Tracer_Check.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Deployable_Bear_Trap_Tracer_Check.AutoSize = true;
            this.Deployable_Bear_Trap_Tracer_Check.CheckAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.Deployable_Bear_Trap_Tracer_Check.Checked = true;
            this.Deployable_Bear_Trap_Tracer_Check.CheckState = System.Windows.Forms.CheckState.Checked;
            this.Deployable_Bear_Trap_Tracer_Check.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Deployable_Bear_Trap_Tracer_Check.Location = new System.Drawing.Point(162, 232);
            this.Deployable_Bear_Trap_Tracer_Check.Margin = new System.Windows.Forms.Padding(3, 3, 0, 0);
            this.Deployable_Bear_Trap_Tracer_Check.Name = "Deployable_Bear_Trap_Tracer_Check";
            this.Deployable_Bear_Trap_Tracer_Check.Size = new System.Drawing.Size(15, 14);
            this.Deployable_Bear_Trap_Tracer_Check.TabIndex = 58;
            this.Deployable_Bear_Trap_Tracer_Check.UseVisualStyleBackColor = true;
            this.Deployable_Bear_Trap_Tracer_Check.CheckedChanged += new System.EventHandler(this.Deployable_Bear_Trap_Tracer_Check_CheckedChanged);
            // 
            // Deployable_Stash_Tracer_Check
            // 
            this.Deployable_Stash_Tracer_Check.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Deployable_Stash_Tracer_Check.AutoSize = true;
            this.Deployable_Stash_Tracer_Check.CheckAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.Deployable_Stash_Tracer_Check.Checked = true;
            this.Deployable_Stash_Tracer_Check.CheckState = System.Windows.Forms.CheckState.Checked;
            this.Deployable_Stash_Tracer_Check.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Deployable_Stash_Tracer_Check.Location = new System.Drawing.Point(162, 255);
            this.Deployable_Stash_Tracer_Check.Margin = new System.Windows.Forms.Padding(3, 3, 0, 0);
            this.Deployable_Stash_Tracer_Check.Name = "Deployable_Stash_Tracer_Check";
            this.Deployable_Stash_Tracer_Check.Size = new System.Drawing.Size(15, 14);
            this.Deployable_Stash_Tracer_Check.TabIndex = 53;
            this.Deployable_Stash_Tracer_Check.UseVisualStyleBackColor = true;
            this.Deployable_Stash_Tracer_Check.CheckedChanged += new System.EventHandler(this.Deployable_Stash_Tracer_Check_CheckedChanged);
            // 
            // Deployable_Box_Tracer_Check
            // 
            this.Deployable_Box_Tracer_Check.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Deployable_Box_Tracer_Check.AutoSize = true;
            this.Deployable_Box_Tracer_Check.CheckAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.Deployable_Box_Tracer_Check.Checked = true;
            this.Deployable_Box_Tracer_Check.CheckState = System.Windows.Forms.CheckState.Checked;
            this.Deployable_Box_Tracer_Check.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Deployable_Box_Tracer_Check.Location = new System.Drawing.Point(162, 278);
            this.Deployable_Box_Tracer_Check.Margin = new System.Windows.Forms.Padding(3, 3, 0, 0);
            this.Deployable_Box_Tracer_Check.Name = "Deployable_Box_Tracer_Check";
            this.Deployable_Box_Tracer_Check.Size = new System.Drawing.Size(15, 14);
            this.Deployable_Box_Tracer_Check.TabIndex = 59;
            this.Deployable_Box_Tracer_Check.UseVisualStyleBackColor = true;
            this.Deployable_Box_Tracer_Check.CheckedChanged += new System.EventHandler(this.Deployable_Box_Tracer_Check_CheckedChanged);
            // 
            // Deployable_Large_Box_Tracer_Check
            // 
            this.Deployable_Large_Box_Tracer_Check.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Deployable_Large_Box_Tracer_Check.AutoSize = true;
            this.Deployable_Large_Box_Tracer_Check.CheckAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.Deployable_Large_Box_Tracer_Check.Checked = true;
            this.Deployable_Large_Box_Tracer_Check.CheckState = System.Windows.Forms.CheckState.Checked;
            this.Deployable_Large_Box_Tracer_Check.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Deployable_Large_Box_Tracer_Check.Location = new System.Drawing.Point(162, 301);
            this.Deployable_Large_Box_Tracer_Check.Margin = new System.Windows.Forms.Padding(3, 3, 0, 0);
            this.Deployable_Large_Box_Tracer_Check.Name = "Deployable_Large_Box_Tracer_Check";
            this.Deployable_Large_Box_Tracer_Check.Size = new System.Drawing.Size(15, 14);
            this.Deployable_Large_Box_Tracer_Check.TabIndex = 53;
            this.Deployable_Large_Box_Tracer_Check.UseVisualStyleBackColor = true;
            this.Deployable_Large_Box_Tracer_Check.CheckedChanged += new System.EventHandler(this.Deployable_Large_Box_Tracer_Check_CheckedChanged);
            // 
            // Deployable_Landmine_Box_Check
            // 
            this.Deployable_Landmine_Box_Check.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Deployable_Landmine_Box_Check.AutoSize = true;
            this.Deployable_Landmine_Box_Check.CheckAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.Deployable_Landmine_Box_Check.Checked = true;
            this.Deployable_Landmine_Box_Check.CheckState = System.Windows.Forms.CheckState.Checked;
            this.Deployable_Landmine_Box_Check.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Deployable_Landmine_Box_Check.Location = new System.Drawing.Point(204, 209);
            this.Deployable_Landmine_Box_Check.Margin = new System.Windows.Forms.Padding(3, 3, 0, 0);
            this.Deployable_Landmine_Box_Check.Name = "Deployable_Landmine_Box_Check";
            this.Deployable_Landmine_Box_Check.Size = new System.Drawing.Size(15, 14);
            this.Deployable_Landmine_Box_Check.TabIndex = 57;
            this.Deployable_Landmine_Box_Check.UseVisualStyleBackColor = true;
            this.Deployable_Landmine_Box_Check.CheckedChanged += new System.EventHandler(this.Deployable_Landmine_Box_Check_CheckedChanged);
            // 
            // Deployable_Bear_Trap_Box_Check
            // 
            this.Deployable_Bear_Trap_Box_Check.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Deployable_Bear_Trap_Box_Check.AutoSize = true;
            this.Deployable_Bear_Trap_Box_Check.CheckAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.Deployable_Bear_Trap_Box_Check.Checked = true;
            this.Deployable_Bear_Trap_Box_Check.CheckState = System.Windows.Forms.CheckState.Checked;
            this.Deployable_Bear_Trap_Box_Check.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Deployable_Bear_Trap_Box_Check.Location = new System.Drawing.Point(204, 232);
            this.Deployable_Bear_Trap_Box_Check.Margin = new System.Windows.Forms.Padding(3, 3, 0, 0);
            this.Deployable_Bear_Trap_Box_Check.Name = "Deployable_Bear_Trap_Box_Check";
            this.Deployable_Bear_Trap_Box_Check.Size = new System.Drawing.Size(15, 14);
            this.Deployable_Bear_Trap_Box_Check.TabIndex = 55;
            this.Deployable_Bear_Trap_Box_Check.UseVisualStyleBackColor = true;
            this.Deployable_Bear_Trap_Box_Check.CheckedChanged += new System.EventHandler(this.Deployable_Bear_Trap_Box_Check_CheckedChanged);
            // 
            // Deployable_Stash_Box_Check
            // 
            this.Deployable_Stash_Box_Check.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Deployable_Stash_Box_Check.AutoSize = true;
            this.Deployable_Stash_Box_Check.CheckAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.Deployable_Stash_Box_Check.Checked = true;
            this.Deployable_Stash_Box_Check.CheckState = System.Windows.Forms.CheckState.Checked;
            this.Deployable_Stash_Box_Check.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Deployable_Stash_Box_Check.Location = new System.Drawing.Point(204, 255);
            this.Deployable_Stash_Box_Check.Margin = new System.Windows.Forms.Padding(3, 3, 0, 0);
            this.Deployable_Stash_Box_Check.Name = "Deployable_Stash_Box_Check";
            this.Deployable_Stash_Box_Check.Size = new System.Drawing.Size(15, 14);
            this.Deployable_Stash_Box_Check.TabIndex = 54;
            this.Deployable_Stash_Box_Check.UseVisualStyleBackColor = true;
            this.Deployable_Stash_Box_Check.CheckedChanged += new System.EventHandler(this.Deployable_Stash_Box_Check_CheckedChanged);
            // 
            // Deployable_Box_Box_Check
            // 
            this.Deployable_Box_Box_Check.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Deployable_Box_Box_Check.AutoSize = true;
            this.Deployable_Box_Box_Check.CheckAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.Deployable_Box_Box_Check.Checked = true;
            this.Deployable_Box_Box_Check.CheckState = System.Windows.Forms.CheckState.Checked;
            this.Deployable_Box_Box_Check.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Deployable_Box_Box_Check.Location = new System.Drawing.Point(204, 278);
            this.Deployable_Box_Box_Check.Margin = new System.Windows.Forms.Padding(3, 3, 0, 0);
            this.Deployable_Box_Box_Check.Name = "Deployable_Box_Box_Check";
            this.Deployable_Box_Box_Check.Size = new System.Drawing.Size(15, 14);
            this.Deployable_Box_Box_Check.TabIndex = 60;
            this.Deployable_Box_Box_Check.UseVisualStyleBackColor = true;
            this.Deployable_Box_Box_Check.CheckedChanged += new System.EventHandler(this.Deployable_Box_Box_Check_CheckedChanged);
            // 
            // Deployable_Large_Box_Box_Check
            // 
            this.Deployable_Large_Box_Box_Check.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Deployable_Large_Box_Box_Check.AutoSize = true;
            this.Deployable_Large_Box_Box_Check.CheckAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.Deployable_Large_Box_Box_Check.Checked = true;
            this.Deployable_Large_Box_Box_Check.CheckState = System.Windows.Forms.CheckState.Checked;
            this.Deployable_Large_Box_Box_Check.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Deployable_Large_Box_Box_Check.Location = new System.Drawing.Point(204, 301);
            this.Deployable_Large_Box_Box_Check.Margin = new System.Windows.Forms.Padding(3, 3, 0, 0);
            this.Deployable_Large_Box_Box_Check.Name = "Deployable_Large_Box_Box_Check";
            this.Deployable_Large_Box_Box_Check.Size = new System.Drawing.Size(15, 14);
            this.Deployable_Large_Box_Box_Check.TabIndex = 54;
            this.Deployable_Large_Box_Box_Check.UseVisualStyleBackColor = true;
            this.Deployable_Large_Box_Box_Check.CheckedChanged += new System.EventHandler(this.Deployable_Large_Box_Box_Check_CheckedChanged);
            // 
            // Deployable_Landmine_Radar_Color
            // 
            this.Deployable_Landmine_Radar_Color.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Deployable_Landmine_Radar_Color.Location = new System.Drawing.Point(230, 206);
            this.Deployable_Landmine_Radar_Color.Name = "Deployable_Landmine_Radar_Color";
            this.Deployable_Landmine_Radar_Color.Size = new System.Drawing.Size(75, 17);
            this.Deployable_Landmine_Radar_Color.TabIndex = 16;
            this.Deployable_Landmine_Radar_Color.UseVisualStyleBackColor = false;
            this.Deployable_Landmine_Radar_Color.Click += new System.EventHandler(this.Landmine_Color_Click);
            // 
            // Deployable_Bear_Trap_Radar_Color
            // 
            this.Deployable_Bear_Trap_Radar_Color.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Deployable_Bear_Trap_Radar_Color.Location = new System.Drawing.Point(230, 229);
            this.Deployable_Bear_Trap_Radar_Color.Name = "Deployable_Bear_Trap_Radar_Color";
            this.Deployable_Bear_Trap_Radar_Color.Size = new System.Drawing.Size(75, 17);
            this.Deployable_Bear_Trap_Radar_Color.TabIndex = 17;
            this.Deployable_Bear_Trap_Radar_Color.UseVisualStyleBackColor = false;
            this.Deployable_Bear_Trap_Radar_Color.Click += new System.EventHandler(this.Bear_Trap_Color_Click);
            // 
            // Deployable_Stash_Radar_Color
            // 
            this.Deployable_Stash_Radar_Color.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Deployable_Stash_Radar_Color.Location = new System.Drawing.Point(230, 252);
            this.Deployable_Stash_Radar_Color.Name = "Deployable_Stash_Radar_Color";
            this.Deployable_Stash_Radar_Color.Size = new System.Drawing.Size(75, 17);
            this.Deployable_Stash_Radar_Color.TabIndex = 22;
            this.Deployable_Stash_Radar_Color.UseVisualStyleBackColor = false;
            this.Deployable_Stash_Radar_Color.Click += new System.EventHandler(this.Stash_Color_Click);
            // 
            // Deployable_Box_Radar_Color
            // 
            this.Deployable_Box_Radar_Color.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Deployable_Box_Radar_Color.Location = new System.Drawing.Point(230, 275);
            this.Deployable_Box_Radar_Color.Name = "Deployable_Box_Radar_Color";
            this.Deployable_Box_Radar_Color.Size = new System.Drawing.Size(75, 17);
            this.Deployable_Box_Radar_Color.TabIndex = 26;
            this.Deployable_Box_Radar_Color.UseVisualStyleBackColor = false;
            this.Deployable_Box_Radar_Color.Click += new System.EventHandler(this.Box_Color_Click);
            // 
            // Deployable_Large_Box_Radar_Color
            // 
            this.Deployable_Large_Box_Radar_Color.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Deployable_Large_Box_Radar_Color.Location = new System.Drawing.Point(230, 298);
            this.Deployable_Large_Box_Radar_Color.Name = "Deployable_Large_Box_Radar_Color";
            this.Deployable_Large_Box_Radar_Color.Size = new System.Drawing.Size(75, 17);
            this.Deployable_Large_Box_Radar_Color.TabIndex = 28;
            this.Deployable_Large_Box_Radar_Color.UseVisualStyleBackColor = false;
            this.Deployable_Large_Box_Radar_Color.Click += new System.EventHandler(this.Large_Box_Color_Click);
            // 
            // Deployable_Landmine_Tracer_Color
            // 
            this.Deployable_Landmine_Tracer_Color.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Deployable_Landmine_Tracer_Color.Location = new System.Drawing.Point(311, 206);
            this.Deployable_Landmine_Tracer_Color.Name = "Deployable_Landmine_Tracer_Color";
            this.Deployable_Landmine_Tracer_Color.Size = new System.Drawing.Size(75, 17);
            this.Deployable_Landmine_Tracer_Color.TabIndex = 35;
            this.Deployable_Landmine_Tracer_Color.UseVisualStyleBackColor = false;
            this.Deployable_Landmine_Tracer_Color.Click += new System.EventHandler(this.Deployable_Landmine_Tracer_Color_Click);
            // 
            // Deployable_Bear_Trap_Tracer_Color
            // 
            this.Deployable_Bear_Trap_Tracer_Color.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Deployable_Bear_Trap_Tracer_Color.Location = new System.Drawing.Point(311, 229);
            this.Deployable_Bear_Trap_Tracer_Color.Name = "Deployable_Bear_Trap_Tracer_Color";
            this.Deployable_Bear_Trap_Tracer_Color.Size = new System.Drawing.Size(75, 17);
            this.Deployable_Bear_Trap_Tracer_Color.TabIndex = 36;
            this.Deployable_Bear_Trap_Tracer_Color.UseVisualStyleBackColor = false;
            this.Deployable_Bear_Trap_Tracer_Color.Click += new System.EventHandler(this.Deployable_Bear_Trap_Tracer_Color_Click);
            // 
            // Deployable_Stash_Tracer_Color
            // 
            this.Deployable_Stash_Tracer_Color.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Deployable_Stash_Tracer_Color.Location = new System.Drawing.Point(311, 252);
            this.Deployable_Stash_Tracer_Color.Name = "Deployable_Stash_Tracer_Color";
            this.Deployable_Stash_Tracer_Color.Size = new System.Drawing.Size(75, 17);
            this.Deployable_Stash_Tracer_Color.TabIndex = 37;
            this.Deployable_Stash_Tracer_Color.UseVisualStyleBackColor = false;
            this.Deployable_Stash_Tracer_Color.Click += new System.EventHandler(this.Deployable_Stash_Tracer_Color_Click);
            // 
            // Deployable_Box_Tracer_Color
            // 
            this.Deployable_Box_Tracer_Color.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Deployable_Box_Tracer_Color.Location = new System.Drawing.Point(311, 275);
            this.Deployable_Box_Tracer_Color.Name = "Deployable_Box_Tracer_Color";
            this.Deployable_Box_Tracer_Color.Size = new System.Drawing.Size(75, 17);
            this.Deployable_Box_Tracer_Color.TabIndex = 39;
            this.Deployable_Box_Tracer_Color.UseVisualStyleBackColor = false;
            this.Deployable_Box_Tracer_Color.Click += new System.EventHandler(this.Deployable_Box_Tracer_Color_Click);
            // 
            // Deployable_Large_Box_Tracer_Color
            // 
            this.Deployable_Large_Box_Tracer_Color.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Deployable_Large_Box_Tracer_Color.Location = new System.Drawing.Point(311, 298);
            this.Deployable_Large_Box_Tracer_Color.Name = "Deployable_Large_Box_Tracer_Color";
            this.Deployable_Large_Box_Tracer_Color.Size = new System.Drawing.Size(75, 17);
            this.Deployable_Large_Box_Tracer_Color.TabIndex = 38;
            this.Deployable_Large_Box_Tracer_Color.UseVisualStyleBackColor = false;
            this.Deployable_Large_Box_Tracer_Color.Click += new System.EventHandler(this.Deployable_Large_Box_Tracer_Color_Click);
            // 
            // Deployable_Landmine_Box_Color
            // 
            this.Deployable_Landmine_Box_Color.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Deployable_Landmine_Box_Color.Location = new System.Drawing.Point(392, 206);
            this.Deployable_Landmine_Box_Color.Name = "Deployable_Landmine_Box_Color";
            this.Deployable_Landmine_Box_Color.Size = new System.Drawing.Size(75, 17);
            this.Deployable_Landmine_Box_Color.TabIndex = 32;
            this.Deployable_Landmine_Box_Color.UseVisualStyleBackColor = false;
            this.Deployable_Landmine_Box_Color.Click += new System.EventHandler(this.Deployable_Landmine_Box_Color_Click);
            // 
            // Deployable_Bear_Trap_Box_Color
            // 
            this.Deployable_Bear_Trap_Box_Color.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Deployable_Bear_Trap_Box_Color.Location = new System.Drawing.Point(392, 229);
            this.Deployable_Bear_Trap_Box_Color.Name = "Deployable_Bear_Trap_Box_Color";
            this.Deployable_Bear_Trap_Box_Color.Size = new System.Drawing.Size(75, 17);
            this.Deployable_Bear_Trap_Box_Color.TabIndex = 31;
            this.Deployable_Bear_Trap_Box_Color.UseVisualStyleBackColor = false;
            this.Deployable_Bear_Trap_Box_Color.Click += new System.EventHandler(this.Deployable_Bear_Trap_Box_Color_Click);
            // 
            // Deployable_Stash_Box_Color
            // 
            this.Deployable_Stash_Box_Color.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Deployable_Stash_Box_Color.Location = new System.Drawing.Point(392, 252);
            this.Deployable_Stash_Box_Color.Name = "Deployable_Stash_Box_Color";
            this.Deployable_Stash_Box_Color.Size = new System.Drawing.Size(75, 17);
            this.Deployable_Stash_Box_Color.TabIndex = 30;
            this.Deployable_Stash_Box_Color.UseVisualStyleBackColor = false;
            this.Deployable_Stash_Box_Color.Click += new System.EventHandler(this.Deployable_Stash_Box_Color_Click);
            // 
            // Deployable_Box_Box_Color
            // 
            this.Deployable_Box_Box_Color.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Deployable_Box_Box_Color.Location = new System.Drawing.Point(392, 275);
            this.Deployable_Box_Box_Color.Name = "Deployable_Box_Box_Color";
            this.Deployable_Box_Box_Color.Size = new System.Drawing.Size(75, 17);
            this.Deployable_Box_Box_Color.TabIndex = 34;
            this.Deployable_Box_Box_Color.UseVisualStyleBackColor = false;
            this.Deployable_Box_Box_Color.Click += new System.EventHandler(this.Deployable_Box_Box_Color_Click);
            // 
            // Deployable_Large_Box_Box_Color
            // 
            this.Deployable_Large_Box_Box_Color.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Deployable_Large_Box_Box_Color.Location = new System.Drawing.Point(392, 298);
            this.Deployable_Large_Box_Box_Color.Name = "Deployable_Large_Box_Box_Color";
            this.Deployable_Large_Box_Box_Color.Size = new System.Drawing.Size(75, 17);
            this.Deployable_Large_Box_Box_Color.TabIndex = 33;
            this.Deployable_Large_Box_Box_Color.UseVisualStyleBackColor = false;
            this.Deployable_Large_Box_Box_Color.Click += new System.EventHandler(this.Deployable_Large_Box_Box_Color_Click);
            // 
            // Plants_TAB
            // 
            this.Plants_TAB.BackColor = System.Drawing.Color.White;
            this.Plants_TAB.Controls.Add(this.tableLayoutPanel6);
            this.Plants_TAB.Location = new System.Drawing.Point(4, 22);
            this.Plants_TAB.Name = "Plants_TAB";
            this.Plants_TAB.Padding = new System.Windows.Forms.Padding(3);
            this.Plants_TAB.Size = new System.Drawing.Size(568, 552);
            this.Plants_TAB.TabIndex = 3;
            this.Plants_TAB.Text = "Plants";
            // 
            // tableLayoutPanel6
            // 
            this.tableLayoutPanel6.ColumnCount = 8;
            this.tableLayoutPanel6.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel6.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel6.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel6.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel6.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel6.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel6.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel6.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 53F));
            this.tableLayoutPanel6.Controls.Add(this.Plant_Hemp_Box_Color, 6, 2);
            this.tableLayoutPanel6.Controls.Add(this.Plant_Mushroom_Box_Color, 6, 1);
            this.tableLayoutPanel6.Controls.Add(this.Plant_Hemp_Radar_Color, 4, 2);
            this.tableLayoutPanel6.Controls.Add(this.label54, 6, 0);
            this.tableLayoutPanel6.Controls.Add(this.Plant_Mushroom_Radar_Color, 4, 1);
            this.tableLayoutPanel6.Controls.Add(this.label55, 0, 1);
            this.tableLayoutPanel6.Controls.Add(this.Plant_Hemp_Radar_Check, 1, 2);
            this.tableLayoutPanel6.Controls.Add(this.label56, 0, 2);
            this.tableLayoutPanel6.Controls.Add(this.Plant_Hemp_Box_Check, 3, 2);
            this.tableLayoutPanel6.Controls.Add(this.Plant_Mushroom_Box_Check, 3, 1);
            this.tableLayoutPanel6.Controls.Add(this.Plant_Mushroom_Radar_Check, 1, 1);
            this.tableLayoutPanel6.Controls.Add(this.label57, 1, 0);
            this.tableLayoutPanel6.Controls.Add(this.label58, 3, 0);
            this.tableLayoutPanel6.Controls.Add(this.label59, 4, 0);
            this.tableLayoutPanel6.Controls.Add(this.label60, 2, 0);
            this.tableLayoutPanel6.Controls.Add(this.label61, 5, 0);
            this.tableLayoutPanel6.Controls.Add(this.Plant_Mushroom_Tracer_Color, 5, 1);
            this.tableLayoutPanel6.Controls.Add(this.Plant_Hemp_Tracer_Color, 5, 2);
            this.tableLayoutPanel6.Controls.Add(this.Plant_Mushroom_Tracer_Check, 2, 1);
            this.tableLayoutPanel6.Controls.Add(this.Plant_Hemp_Tracer_Check, 2, 2);
            this.tableLayoutPanel6.Controls.Add(this.label53, 0, 3);
            this.tableLayoutPanel6.Controls.Add(this.label62, 0, 4);
            this.tableLayoutPanel6.Controls.Add(this.Plant_Pumpkin_Radar_Check, 1, 3);
            this.tableLayoutPanel6.Controls.Add(this.Plant_Corn_Radar_Check, 1, 4);
            this.tableLayoutPanel6.Controls.Add(this.Plant_Pumpkin_Tracer_Check, 2, 3);
            this.tableLayoutPanel6.Controls.Add(this.Plant_Corn_Tracer_Check, 2, 4);
            this.tableLayoutPanel6.Controls.Add(this.Plant_Pumpkin_Box_Check, 3, 3);
            this.tableLayoutPanel6.Controls.Add(this.Plant_Corn_Box_Check, 3, 4);
            this.tableLayoutPanel6.Controls.Add(this.Plant_Pumpkin_Radar_Color, 4, 3);
            this.tableLayoutPanel6.Controls.Add(this.Plant_Corn_Radar_Color, 4, 4);
            this.tableLayoutPanel6.Controls.Add(this.Plant_Pumpkin_Tracer_Color, 5, 3);
            this.tableLayoutPanel6.Controls.Add(this.Plant_Corn_Tracer_Color, 5, 4);
            this.tableLayoutPanel6.Controls.Add(this.Plant_Pumpkin_Box_Color, 6, 3);
            this.tableLayoutPanel6.Controls.Add(this.Plant_Corn_Box_Color, 6, 4);
            this.tableLayoutPanel6.Location = new System.Drawing.Point(6, 6);
            this.tableLayoutPanel6.Name = "tableLayoutPanel6";
            this.tableLayoutPanel6.RowCount = 6;
            this.tableLayoutPanel6.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel6.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel6.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel6.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel6.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel6.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel6.Size = new System.Drawing.Size(497, 192);
            this.tableLayoutPanel6.TabIndex = 29;
            // 
            // Plant_Hemp_Box_Color
            // 
            this.Plant_Hemp_Box_Color.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Plant_Hemp_Box_Color.Location = new System.Drawing.Point(366, 45);
            this.Plant_Hemp_Box_Color.Name = "Plant_Hemp_Box_Color";
            this.Plant_Hemp_Box_Color.Size = new System.Drawing.Size(75, 17);
            this.Plant_Hemp_Box_Color.TabIndex = 28;
            this.Plant_Hemp_Box_Color.UseVisualStyleBackColor = false;
            this.Plant_Hemp_Box_Color.Click += new System.EventHandler(this.Plant_Hemp_Box_Color_Click);
            // 
            // Plant_Mushroom_Box_Color
            // 
            this.Plant_Mushroom_Box_Color.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Plant_Mushroom_Box_Color.Location = new System.Drawing.Point(366, 22);
            this.Plant_Mushroom_Box_Color.Name = "Plant_Mushroom_Box_Color";
            this.Plant_Mushroom_Box_Color.Size = new System.Drawing.Size(75, 17);
            this.Plant_Mushroom_Box_Color.TabIndex = 28;
            this.Plant_Mushroom_Box_Color.UseVisualStyleBackColor = false;
            this.Plant_Mushroom_Box_Color.Click += new System.EventHandler(this.Plant_Mushroom_Box_Color_Click);
            // 
            // Plant_Hemp_Radar_Color
            // 
            this.Plant_Hemp_Radar_Color.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Plant_Hemp_Radar_Color.Location = new System.Drawing.Point(204, 45);
            this.Plant_Hemp_Radar_Color.Name = "Plant_Hemp_Radar_Color";
            this.Plant_Hemp_Radar_Color.Size = new System.Drawing.Size(75, 17);
            this.Plant_Hemp_Radar_Color.TabIndex = 7;
            this.Plant_Hemp_Radar_Color.UseVisualStyleBackColor = false;
            this.Plant_Hemp_Radar_Color.Click += new System.EventHandler(this.Hemp_Color_Click);
            // 
            // label54
            // 
            this.label54.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label54.AutoSize = true;
            this.label54.Location = new System.Drawing.Point(366, 3);
            this.label54.Margin = new System.Windows.Forms.Padding(3);
            this.label54.Name = "label54";
            this.label54.Size = new System.Drawing.Size(75, 13);
            this.label54.TabIndex = 76;
            this.label54.Text = "Box";
            this.label54.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Plant_Mushroom_Radar_Color
            // 
            this.Plant_Mushroom_Radar_Color.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Plant_Mushroom_Radar_Color.ForeColor = System.Drawing.Color.Black;
            this.Plant_Mushroom_Radar_Color.Location = new System.Drawing.Point(204, 22);
            this.Plant_Mushroom_Radar_Color.Name = "Plant_Mushroom_Radar_Color";
            this.Plant_Mushroom_Radar_Color.Size = new System.Drawing.Size(75, 17);
            this.Plant_Mushroom_Radar_Color.TabIndex = 6;
            this.Plant_Mushroom_Radar_Color.UseVisualStyleBackColor = false;
            this.Plant_Mushroom_Radar_Color.Click += new System.EventHandler(this.Mushroom_Color_Click);
            // 
            // label55
            // 
            this.label55.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label55.AutoSize = true;
            this.label55.Location = new System.Drawing.Point(3, 22);
            this.label55.Margin = new System.Windows.Forms.Padding(3);
            this.label55.Name = "label55";
            this.label55.Size = new System.Drawing.Size(64, 17);
            this.label55.TabIndex = 46;
            this.label55.Text = "Mushroom";
            this.label55.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Plant_Hemp_Radar_Check
            // 
            this.Plant_Hemp_Radar_Check.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Plant_Hemp_Radar_Check.AutoSize = true;
            this.Plant_Hemp_Radar_Check.Checked = true;
            this.Plant_Hemp_Radar_Check.CheckState = System.Windows.Forms.CheckState.Checked;
            this.Plant_Hemp_Radar_Check.Location = new System.Drawing.Point(87, 48);
            this.Plant_Hemp_Radar_Check.Margin = new System.Windows.Forms.Padding(3, 3, 0, 0);
            this.Plant_Hemp_Radar_Check.Name = "Plant_Hemp_Radar_Check";
            this.Plant_Hemp_Radar_Check.Size = new System.Drawing.Size(15, 14);
            this.Plant_Hemp_Radar_Check.TabIndex = 1;
            this.Plant_Hemp_Radar_Check.UseVisualStyleBackColor = true;
            this.Plant_Hemp_Radar_Check.CheckedChanged += new System.EventHandler(this.Hemp_Check_CheckedChanged);
            // 
            // label56
            // 
            this.label56.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label56.AutoSize = true;
            this.label56.Location = new System.Drawing.Point(3, 45);
            this.label56.Margin = new System.Windows.Forms.Padding(3);
            this.label56.Name = "label56";
            this.label56.Size = new System.Drawing.Size(64, 17);
            this.label56.TabIndex = 44;
            this.label56.Text = "Hemp";
            this.label56.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Plant_Hemp_Box_Check
            // 
            this.Plant_Hemp_Box_Check.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Plant_Hemp_Box_Check.AutoSize = true;
            this.Plant_Hemp_Box_Check.CheckAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.Plant_Hemp_Box_Check.Checked = true;
            this.Plant_Hemp_Box_Check.CheckState = System.Windows.Forms.CheckState.Checked;
            this.Plant_Hemp_Box_Check.Location = new System.Drawing.Point(178, 48);
            this.Plant_Hemp_Box_Check.Margin = new System.Windows.Forms.Padding(3, 3, 0, 0);
            this.Plant_Hemp_Box_Check.Name = "Plant_Hemp_Box_Check";
            this.Plant_Hemp_Box_Check.Size = new System.Drawing.Size(15, 14);
            this.Plant_Hemp_Box_Check.TabIndex = 32;
            this.Plant_Hemp_Box_Check.UseVisualStyleBackColor = true;
            this.Plant_Hemp_Box_Check.CheckedChanged += new System.EventHandler(this.Plant_Hemp_Box_Check_CheckedChanged);
            // 
            // Plant_Mushroom_Box_Check
            // 
            this.Plant_Mushroom_Box_Check.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Plant_Mushroom_Box_Check.AutoSize = true;
            this.Plant_Mushroom_Box_Check.CheckAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.Plant_Mushroom_Box_Check.Checked = true;
            this.Plant_Mushroom_Box_Check.CheckState = System.Windows.Forms.CheckState.Checked;
            this.Plant_Mushroom_Box_Check.Location = new System.Drawing.Point(178, 25);
            this.Plant_Mushroom_Box_Check.Margin = new System.Windows.Forms.Padding(3, 3, 0, 0);
            this.Plant_Mushroom_Box_Check.Name = "Plant_Mushroom_Box_Check";
            this.Plant_Mushroom_Box_Check.Size = new System.Drawing.Size(15, 14);
            this.Plant_Mushroom_Box_Check.TabIndex = 34;
            this.Plant_Mushroom_Box_Check.UseVisualStyleBackColor = true;
            this.Plant_Mushroom_Box_Check.CheckedChanged += new System.EventHandler(this.Plant_Mushroom_Box_Check_CheckedChanged);
            // 
            // Plant_Mushroom_Radar_Check
            // 
            this.Plant_Mushroom_Radar_Check.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Plant_Mushroom_Radar_Check.AutoSize = true;
            this.Plant_Mushroom_Radar_Check.Checked = true;
            this.Plant_Mushroom_Radar_Check.CheckState = System.Windows.Forms.CheckState.Checked;
            this.Plant_Mushroom_Radar_Check.Location = new System.Drawing.Point(87, 25);
            this.Plant_Mushroom_Radar_Check.Margin = new System.Windows.Forms.Padding(3, 3, 0, 0);
            this.Plant_Mushroom_Radar_Check.Name = "Plant_Mushroom_Radar_Check";
            this.Plant_Mushroom_Radar_Check.Size = new System.Drawing.Size(15, 14);
            this.Plant_Mushroom_Radar_Check.TabIndex = 0;
            this.Plant_Mushroom_Radar_Check.UseVisualStyleBackColor = true;
            this.Plant_Mushroom_Radar_Check.CheckedChanged += new System.EventHandler(this.Mushroom_Check_CheckedChanged);
            // 
            // label57
            // 
            this.label57.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label57.AutoSize = true;
            this.label57.Location = new System.Drawing.Point(73, 3);
            this.label57.Margin = new System.Windows.Forms.Padding(3);
            this.label57.Name = "label57";
            this.label57.Size = new System.Drawing.Size(41, 13);
            this.label57.TabIndex = 76;
            this.label57.Text = "Radar";
            this.label57.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label58
            // 
            this.label58.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label58.AutoSize = true;
            this.label58.Location = new System.Drawing.Point(170, 3);
            this.label58.Margin = new System.Windows.Forms.Padding(3);
            this.label58.Name = "label58";
            this.label58.Size = new System.Drawing.Size(28, 13);
            this.label58.TabIndex = 77;
            this.label58.Text = "Box";
            this.label58.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label59
            // 
            this.label59.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label59.AutoSize = true;
            this.label59.Location = new System.Drawing.Point(204, 3);
            this.label59.Margin = new System.Windows.Forms.Padding(3);
            this.label59.Name = "label59";
            this.label59.Size = new System.Drawing.Size(75, 13);
            this.label59.TabIndex = 78;
            this.label59.Text = "Radar";
            this.label59.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label60
            // 
            this.label60.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label60.AutoSize = true;
            this.label60.Location = new System.Drawing.Point(120, 3);
            this.label60.Margin = new System.Windows.Forms.Padding(3);
            this.label60.Name = "label60";
            this.label60.Size = new System.Drawing.Size(44, 13);
            this.label60.TabIndex = 79;
            this.label60.Text = "Tracer";
            this.label60.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label61
            // 
            this.label61.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label61.AutoSize = true;
            this.label61.Location = new System.Drawing.Point(285, 3);
            this.label61.Margin = new System.Windows.Forms.Padding(3);
            this.label61.Name = "label61";
            this.label61.Size = new System.Drawing.Size(75, 13);
            this.label61.TabIndex = 80;
            this.label61.Text = "Tracer";
            this.label61.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Plant_Mushroom_Tracer_Color
            // 
            this.Plant_Mushroom_Tracer_Color.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Plant_Mushroom_Tracer_Color.Location = new System.Drawing.Point(285, 22);
            this.Plant_Mushroom_Tracer_Color.Name = "Plant_Mushroom_Tracer_Color";
            this.Plant_Mushroom_Tracer_Color.Size = new System.Drawing.Size(75, 17);
            this.Plant_Mushroom_Tracer_Color.TabIndex = 81;
            this.Plant_Mushroom_Tracer_Color.UseVisualStyleBackColor = false;
            this.Plant_Mushroom_Tracer_Color.Click += new System.EventHandler(this.Plant_Mushroom_Tracer_Color_Click);
            // 
            // Plant_Hemp_Tracer_Color
            // 
            this.Plant_Hemp_Tracer_Color.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Plant_Hemp_Tracer_Color.Location = new System.Drawing.Point(285, 45);
            this.Plant_Hemp_Tracer_Color.Name = "Plant_Hemp_Tracer_Color";
            this.Plant_Hemp_Tracer_Color.Size = new System.Drawing.Size(75, 17);
            this.Plant_Hemp_Tracer_Color.TabIndex = 82;
            this.Plant_Hemp_Tracer_Color.UseVisualStyleBackColor = false;
            this.Plant_Hemp_Tracer_Color.Click += new System.EventHandler(this.Plant_Hemp_Tracer_Color_Click);
            // 
            // Plant_Mushroom_Tracer_Check
            // 
            this.Plant_Mushroom_Tracer_Check.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Plant_Mushroom_Tracer_Check.AutoSize = true;
            this.Plant_Mushroom_Tracer_Check.Checked = true;
            this.Plant_Mushroom_Tracer_Check.CheckState = System.Windows.Forms.CheckState.Checked;
            this.Plant_Mushroom_Tracer_Check.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Plant_Mushroom_Tracer_Check.Location = new System.Drawing.Point(136, 25);
            this.Plant_Mushroom_Tracer_Check.Margin = new System.Windows.Forms.Padding(3, 3, 0, 0);
            this.Plant_Mushroom_Tracer_Check.Name = "Plant_Mushroom_Tracer_Check";
            this.Plant_Mushroom_Tracer_Check.Size = new System.Drawing.Size(15, 14);
            this.Plant_Mushroom_Tracer_Check.TabIndex = 83;
            this.Plant_Mushroom_Tracer_Check.UseVisualStyleBackColor = true;
            this.Plant_Mushroom_Tracer_Check.CheckedChanged += new System.EventHandler(this.Plant_Mushroom_Tracer_Check_CheckedChanged);
            // 
            // Plant_Hemp_Tracer_Check
            // 
            this.Plant_Hemp_Tracer_Check.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Plant_Hemp_Tracer_Check.AutoSize = true;
            this.Plant_Hemp_Tracer_Check.Checked = true;
            this.Plant_Hemp_Tracer_Check.CheckState = System.Windows.Forms.CheckState.Checked;
            this.Plant_Hemp_Tracer_Check.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Plant_Hemp_Tracer_Check.Location = new System.Drawing.Point(136, 48);
            this.Plant_Hemp_Tracer_Check.Margin = new System.Windows.Forms.Padding(3, 3, 0, 0);
            this.Plant_Hemp_Tracer_Check.Name = "Plant_Hemp_Tracer_Check";
            this.Plant_Hemp_Tracer_Check.Size = new System.Drawing.Size(15, 14);
            this.Plant_Hemp_Tracer_Check.TabIndex = 84;
            this.Plant_Hemp_Tracer_Check.UseVisualStyleBackColor = true;
            this.Plant_Hemp_Tracer_Check.CheckedChanged += new System.EventHandler(this.Plant_Hemp_Tracer_Check_CheckedChanged);
            // 
            // label53
            // 
            this.label53.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label53.AutoSize = true;
            this.label53.Location = new System.Drawing.Point(3, 68);
            this.label53.Margin = new System.Windows.Forms.Padding(3);
            this.label53.Name = "label53";
            this.label53.Size = new System.Drawing.Size(64, 17);
            this.label53.TabIndex = 85;
            this.label53.Text = "Pumpkin";
            this.label53.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label62
            // 
            this.label62.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label62.AutoSize = true;
            this.label62.Location = new System.Drawing.Point(3, 91);
            this.label62.Margin = new System.Windows.Forms.Padding(3);
            this.label62.Name = "label62";
            this.label62.Size = new System.Drawing.Size(64, 17);
            this.label62.TabIndex = 92;
            this.label62.Text = "Corn";
            this.label62.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Plant_Pumpkin_Radar_Check
            // 
            this.Plant_Pumpkin_Radar_Check.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Plant_Pumpkin_Radar_Check.AutoSize = true;
            this.Plant_Pumpkin_Radar_Check.Checked = true;
            this.Plant_Pumpkin_Radar_Check.CheckState = System.Windows.Forms.CheckState.Checked;
            this.Plant_Pumpkin_Radar_Check.Location = new System.Drawing.Point(87, 71);
            this.Plant_Pumpkin_Radar_Check.Margin = new System.Windows.Forms.Padding(3, 3, 0, 0);
            this.Plant_Pumpkin_Radar_Check.Name = "Plant_Pumpkin_Radar_Check";
            this.Plant_Pumpkin_Radar_Check.Size = new System.Drawing.Size(15, 14);
            this.Plant_Pumpkin_Radar_Check.TabIndex = 2;
            this.Plant_Pumpkin_Radar_Check.UseVisualStyleBackColor = true;
            this.Plant_Pumpkin_Radar_Check.CheckedChanged += new System.EventHandler(this.Pumpkin_Check_CheckedChanged);
            // 
            // Plant_Corn_Radar_Check
            // 
            this.Plant_Corn_Radar_Check.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Plant_Corn_Radar_Check.AutoSize = true;
            this.Plant_Corn_Radar_Check.Checked = true;
            this.Plant_Corn_Radar_Check.CheckState = System.Windows.Forms.CheckState.Checked;
            this.Plant_Corn_Radar_Check.Location = new System.Drawing.Point(87, 94);
            this.Plant_Corn_Radar_Check.Margin = new System.Windows.Forms.Padding(3, 3, 0, 0);
            this.Plant_Corn_Radar_Check.Name = "Plant_Corn_Radar_Check";
            this.Plant_Corn_Radar_Check.Size = new System.Drawing.Size(15, 14);
            this.Plant_Corn_Radar_Check.TabIndex = 3;
            this.Plant_Corn_Radar_Check.UseVisualStyleBackColor = true;
            this.Plant_Corn_Radar_Check.CheckedChanged += new System.EventHandler(this.Corn_Check_CheckedChanged);
            // 
            // Plant_Pumpkin_Tracer_Check
            // 
            this.Plant_Pumpkin_Tracer_Check.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Plant_Pumpkin_Tracer_Check.AutoSize = true;
            this.Plant_Pumpkin_Tracer_Check.Checked = true;
            this.Plant_Pumpkin_Tracer_Check.CheckState = System.Windows.Forms.CheckState.Checked;
            this.Plant_Pumpkin_Tracer_Check.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Plant_Pumpkin_Tracer_Check.Location = new System.Drawing.Point(136, 71);
            this.Plant_Pumpkin_Tracer_Check.Margin = new System.Windows.Forms.Padding(3, 3, 0, 0);
            this.Plant_Pumpkin_Tracer_Check.Name = "Plant_Pumpkin_Tracer_Check";
            this.Plant_Pumpkin_Tracer_Check.Size = new System.Drawing.Size(15, 14);
            this.Plant_Pumpkin_Tracer_Check.TabIndex = 88;
            this.Plant_Pumpkin_Tracer_Check.UseVisualStyleBackColor = true;
            this.Plant_Pumpkin_Tracer_Check.CheckedChanged += new System.EventHandler(this.Plant_Pumpkin_Tracer_Check_CheckedChanged);
            // 
            // Plant_Corn_Tracer_Check
            // 
            this.Plant_Corn_Tracer_Check.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Plant_Corn_Tracer_Check.AutoSize = true;
            this.Plant_Corn_Tracer_Check.Checked = true;
            this.Plant_Corn_Tracer_Check.CheckState = System.Windows.Forms.CheckState.Checked;
            this.Plant_Corn_Tracer_Check.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Plant_Corn_Tracer_Check.Location = new System.Drawing.Point(136, 94);
            this.Plant_Corn_Tracer_Check.Margin = new System.Windows.Forms.Padding(3, 3, 0, 0);
            this.Plant_Corn_Tracer_Check.Name = "Plant_Corn_Tracer_Check";
            this.Plant_Corn_Tracer_Check.Size = new System.Drawing.Size(15, 14);
            this.Plant_Corn_Tracer_Check.TabIndex = 90;
            this.Plant_Corn_Tracer_Check.UseVisualStyleBackColor = true;
            this.Plant_Corn_Tracer_Check.CheckedChanged += new System.EventHandler(this.Plant_Corn_Tracer_Check_CheckedChanged);
            // 
            // Plant_Pumpkin_Box_Check
            // 
            this.Plant_Pumpkin_Box_Check.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Plant_Pumpkin_Box_Check.AutoSize = true;
            this.Plant_Pumpkin_Box_Check.Checked = true;
            this.Plant_Pumpkin_Box_Check.CheckState = System.Windows.Forms.CheckState.Checked;
            this.Plant_Pumpkin_Box_Check.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Plant_Pumpkin_Box_Check.Location = new System.Drawing.Point(178, 71);
            this.Plant_Pumpkin_Box_Check.Margin = new System.Windows.Forms.Padding(3, 3, 0, 0);
            this.Plant_Pumpkin_Box_Check.Name = "Plant_Pumpkin_Box_Check";
            this.Plant_Pumpkin_Box_Check.Size = new System.Drawing.Size(15, 14);
            this.Plant_Pumpkin_Box_Check.TabIndex = 86;
            this.Plant_Pumpkin_Box_Check.UseVisualStyleBackColor = true;
            this.Plant_Pumpkin_Box_Check.CheckedChanged += new System.EventHandler(this.Plant_Pumpkin_Box_Check_CheckedChanged);
            // 
            // Plant_Corn_Box_Check
            // 
            this.Plant_Corn_Box_Check.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Plant_Corn_Box_Check.AutoSize = true;
            this.Plant_Corn_Box_Check.Checked = true;
            this.Plant_Corn_Box_Check.CheckState = System.Windows.Forms.CheckState.Checked;
            this.Plant_Corn_Box_Check.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Plant_Corn_Box_Check.Location = new System.Drawing.Point(178, 94);
            this.Plant_Corn_Box_Check.Margin = new System.Windows.Forms.Padding(3, 3, 0, 0);
            this.Plant_Corn_Box_Check.Name = "Plant_Corn_Box_Check";
            this.Plant_Corn_Box_Check.Size = new System.Drawing.Size(15, 14);
            this.Plant_Corn_Box_Check.TabIndex = 89;
            this.Plant_Corn_Box_Check.UseVisualStyleBackColor = true;
            this.Plant_Corn_Box_Check.CheckedChanged += new System.EventHandler(this.Plant_Corn_Box_Check_CheckedChanged);
            // 
            // Plant_Pumpkin_Radar_Color
            // 
            this.Plant_Pumpkin_Radar_Color.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Plant_Pumpkin_Radar_Color.Location = new System.Drawing.Point(204, 68);
            this.Plant_Pumpkin_Radar_Color.Name = "Plant_Pumpkin_Radar_Color";
            this.Plant_Pumpkin_Radar_Color.Size = new System.Drawing.Size(75, 17);
            this.Plant_Pumpkin_Radar_Color.TabIndex = 8;
            this.Plant_Pumpkin_Radar_Color.UseVisualStyleBackColor = false;
            this.Plant_Pumpkin_Radar_Color.Click += new System.EventHandler(this.Pumpkin_Color_Click);
            // 
            // Plant_Corn_Radar_Color
            // 
            this.Plant_Corn_Radar_Color.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Plant_Corn_Radar_Color.Location = new System.Drawing.Point(204, 91);
            this.Plant_Corn_Radar_Color.Name = "Plant_Corn_Radar_Color";
            this.Plant_Corn_Radar_Color.Size = new System.Drawing.Size(75, 17);
            this.Plant_Corn_Radar_Color.TabIndex = 9;
            this.Plant_Corn_Radar_Color.UseVisualStyleBackColor = false;
            this.Plant_Corn_Radar_Color.Click += new System.EventHandler(this.Corn_Color_Click);
            // 
            // Plant_Pumpkin_Tracer_Color
            // 
            this.Plant_Pumpkin_Tracer_Color.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Plant_Pumpkin_Tracer_Color.Location = new System.Drawing.Point(285, 68);
            this.Plant_Pumpkin_Tracer_Color.Name = "Plant_Pumpkin_Tracer_Color";
            this.Plant_Pumpkin_Tracer_Color.Size = new System.Drawing.Size(75, 17);
            this.Plant_Pumpkin_Tracer_Color.TabIndex = 89;
            this.Plant_Pumpkin_Tracer_Color.UseVisualStyleBackColor = false;
            this.Plant_Pumpkin_Tracer_Color.Click += new System.EventHandler(this.Plant_Pumpkin_Tracer_Color_Click);
            // 
            // Plant_Corn_Tracer_Color
            // 
            this.Plant_Corn_Tracer_Color.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Plant_Corn_Tracer_Color.Location = new System.Drawing.Point(285, 91);
            this.Plant_Corn_Tracer_Color.Name = "Plant_Corn_Tracer_Color";
            this.Plant_Corn_Tracer_Color.Size = new System.Drawing.Size(75, 17);
            this.Plant_Corn_Tracer_Color.TabIndex = 31;
            this.Plant_Corn_Tracer_Color.UseVisualStyleBackColor = false;
            this.Plant_Corn_Tracer_Color.Click += new System.EventHandler(this.Plant_Corn_Tracer_Color_Click);
            // 
            // Plant_Pumpkin_Box_Color
            // 
            this.Plant_Pumpkin_Box_Color.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Plant_Pumpkin_Box_Color.Location = new System.Drawing.Point(366, 68);
            this.Plant_Pumpkin_Box_Color.Name = "Plant_Pumpkin_Box_Color";
            this.Plant_Pumpkin_Box_Color.Size = new System.Drawing.Size(75, 17);
            this.Plant_Pumpkin_Box_Color.TabIndex = 91;
            this.Plant_Pumpkin_Box_Color.UseVisualStyleBackColor = false;
            this.Plant_Pumpkin_Box_Color.Click += new System.EventHandler(this.Plant_Pumpkin_Box_Color_Click);
            // 
            // Plant_Corn_Box_Color
            // 
            this.Plant_Corn_Box_Color.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Plant_Corn_Box_Color.Location = new System.Drawing.Point(366, 91);
            this.Plant_Corn_Box_Color.Name = "Plant_Corn_Box_Color";
            this.Plant_Corn_Box_Color.Size = new System.Drawing.Size(75, 17);
            this.Plant_Corn_Box_Color.TabIndex = 30;
            this.Plant_Corn_Box_Color.UseVisualStyleBackColor = false;
            this.Plant_Corn_Box_Color.Click += new System.EventHandler(this.Plant_Corn_Box_Color_Click);
            // 
            // Resources_TAB
            // 
            this.Resources_TAB.BackColor = System.Drawing.Color.White;
            this.Resources_TAB.Controls.Add(this.tableLayoutPanel7);
            this.Resources_TAB.Location = new System.Drawing.Point(4, 22);
            this.Resources_TAB.Name = "Resources_TAB";
            this.Resources_TAB.Padding = new System.Windows.Forms.Padding(3);
            this.Resources_TAB.Size = new System.Drawing.Size(568, 552);
            this.Resources_TAB.TabIndex = 4;
            this.Resources_TAB.Text = "Resources";
            // 
            // tableLayoutPanel7
            // 
            this.tableLayoutPanel7.ColumnCount = 8;
            this.tableLayoutPanel7.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel7.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel7.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel7.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel7.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel7.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel7.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel7.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 64F));
            this.tableLayoutPanel7.Controls.Add(this.Resource_Wood_Collectable_Radar_Color, 4, 2);
            this.tableLayoutPanel7.Controls.Add(this.Resource_Rock_Collectable_Radar_Color, 4, 1);
            this.tableLayoutPanel7.Controls.Add(this.Resource_Wood_Collectable_Radar_Check, 1, 2);
            this.tableLayoutPanel7.Controls.Add(this.Resource_Rock_Collectable_Radar_Check, 1, 1);
            this.tableLayoutPanel7.Controls.Add(this.Resource_Wood_Collectable_Box_Color, 6, 2);
            this.tableLayoutPanel7.Controls.Add(this.Resource_Rock_Collectable_Box_Color, 6, 1);
            this.tableLayoutPanel7.Controls.Add(this.label67, 6, 0);
            this.tableLayoutPanel7.Controls.Add(this.label68, 0, 1);
            this.tableLayoutPanel7.Controls.Add(this.label69, 0, 2);
            this.tableLayoutPanel7.Controls.Add(this.Resource_Wood_Collectable_Box_Check, 3, 2);
            this.tableLayoutPanel7.Controls.Add(this.Resource_Rock_Collectable_Box_Check, 3, 1);
            this.tableLayoutPanel7.Controls.Add(this.label70, 1, 0);
            this.tableLayoutPanel7.Controls.Add(this.label71, 3, 0);
            this.tableLayoutPanel7.Controls.Add(this.label72, 4, 0);
            this.tableLayoutPanel7.Controls.Add(this.label73, 2, 0);
            this.tableLayoutPanel7.Controls.Add(this.label74, 5, 0);
            this.tableLayoutPanel7.Controls.Add(this.Resource_Rock_Collectable_Tracer_Color, 5, 1);
            this.tableLayoutPanel7.Controls.Add(this.Resource_Wood_Collectable_Tracer_Color, 5, 2);
            this.tableLayoutPanel7.Controls.Add(this.Resource_Rock_Collectable_Tracer_Check, 2, 1);
            this.tableLayoutPanel7.Controls.Add(this.Resource_Wood_Collectable_Tracer_Check, 2, 2);
            this.tableLayoutPanel7.Controls.Add(this.label66, 0, 3);
            this.tableLayoutPanel7.Controls.Add(this.label65, 0, 4);
            this.tableLayoutPanel7.Controls.Add(this.label64, 0, 5);
            this.tableLayoutPanel7.Controls.Add(this.label63, 0, 6);
            this.tableLayoutPanel7.Controls.Add(this.label75, 0, 7);
            this.tableLayoutPanel7.Controls.Add(this.Resource_Sulfur_Collectable_Radar_Check, 1, 3);
            this.tableLayoutPanel7.Controls.Add(this.Resource_Metal_Collectable_Radar_Check, 1, 4);
            this.tableLayoutPanel7.Controls.Add(this.Resource_Sulfur_Node_Radar_Check, 1, 5);
            this.tableLayoutPanel7.Controls.Add(this.Resource_Metal_Node_Radar_Check, 1, 6);
            this.tableLayoutPanel7.Controls.Add(this.Resource_Stone_Node_Radar_Check, 1, 7);
            this.tableLayoutPanel7.Controls.Add(this.Resource_Sulfur_Collectable_Tracer_Check, 2, 3);
            this.tableLayoutPanel7.Controls.Add(this.Resource_Sulfur_Collectable_Box_Check, 3, 3);
            this.tableLayoutPanel7.Controls.Add(this.Resource_Metal_Collectable_Box_Check, 3, 4);
            this.tableLayoutPanel7.Controls.Add(this.Resource_Metal_Collectable_Tracer_Check, 2, 4);
            this.tableLayoutPanel7.Controls.Add(this.Resource_Sulfur_Node_Tracer_Check, 2, 5);
            this.tableLayoutPanel7.Controls.Add(this.Resource_Sulfur_Node_Box_Check, 3, 5);
            this.tableLayoutPanel7.Controls.Add(this.Resource_Metal_Node_Tracer_Check, 2, 6);
            this.tableLayoutPanel7.Controls.Add(this.Resource_Metal_Node_Box_Check, 3, 6);
            this.tableLayoutPanel7.Controls.Add(this.Resource_Stone_Node_Tracer_Check, 2, 7);
            this.tableLayoutPanel7.Controls.Add(this.Resource_Stone_Node_Box_Check, 3, 7);
            this.tableLayoutPanel7.Controls.Add(this.Resource_Sulfur_Collectable_Radar_Color, 4, 3);
            this.tableLayoutPanel7.Controls.Add(this.Resource_Metal_Collectable_Radar_Color, 4, 4);
            this.tableLayoutPanel7.Controls.Add(this.Resource_Sulfur_Node_Radar_Color, 4, 5);
            this.tableLayoutPanel7.Controls.Add(this.Resource_Metal_Node_Radar_Color, 4, 6);
            this.tableLayoutPanel7.Controls.Add(this.Resource_Stone_Node_Radar_Color, 4, 7);
            this.tableLayoutPanel7.Controls.Add(this.Resource_Sulfur_Collectable_Tracer_Color, 5, 3);
            this.tableLayoutPanel7.Controls.Add(this.Resource_Sulfur_Collectable_Box_Color, 6, 3);
            this.tableLayoutPanel7.Controls.Add(this.Resource_Metal_Collectable_Box_Color, 6, 4);
            this.tableLayoutPanel7.Controls.Add(this.Resource_Metal_Collectable_Tracer_Color, 5, 4);
            this.tableLayoutPanel7.Controls.Add(this.Resource_Sulfur_Node_Tracer_Color, 5, 5);
            this.tableLayoutPanel7.Controls.Add(this.Resource_Metal_Node_Tracer_Color, 5, 6);
            this.tableLayoutPanel7.Controls.Add(this.Resource_Sulfur_Node_Box_Color, 6, 5);
            this.tableLayoutPanel7.Controls.Add(this.Resource_Metal_Node_Box_Color, 6, 6);
            this.tableLayoutPanel7.Controls.Add(this.Resource_Stone_Node_Tracer_Color, 5, 7);
            this.tableLayoutPanel7.Controls.Add(this.Resource_Stone_Node_Box_Color, 6, 7);
            this.tableLayoutPanel7.Location = new System.Drawing.Point(6, 6);
            this.tableLayoutPanel7.Name = "tableLayoutPanel7";
            this.tableLayoutPanel7.RowCount = 9;
            this.tableLayoutPanel7.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel7.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel7.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel7.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel7.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel7.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel7.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel7.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel7.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel7.Size = new System.Drawing.Size(546, 200);
            this.tableLayoutPanel7.TabIndex = 30;
            // 
            // Resource_Wood_Collectable_Radar_Color
            // 
            this.Resource_Wood_Collectable_Radar_Color.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Resource_Wood_Collectable_Radar_Color.Location = new System.Drawing.Point(247, 45);
            this.Resource_Wood_Collectable_Radar_Color.Name = "Resource_Wood_Collectable_Radar_Color";
            this.Resource_Wood_Collectable_Radar_Color.Size = new System.Drawing.Size(75, 17);
            this.Resource_Wood_Collectable_Radar_Color.TabIndex = 16;
            this.Resource_Wood_Collectable_Radar_Color.UseVisualStyleBackColor = false;
            this.Resource_Wood_Collectable_Radar_Color.Click += new System.EventHandler(this.Wood_Color_Click);
            // 
            // Resource_Rock_Collectable_Radar_Color
            // 
            this.Resource_Rock_Collectable_Radar_Color.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Resource_Rock_Collectable_Radar_Color.Location = new System.Drawing.Point(247, 22);
            this.Resource_Rock_Collectable_Radar_Color.Name = "Resource_Rock_Collectable_Radar_Color";
            this.Resource_Rock_Collectable_Radar_Color.Size = new System.Drawing.Size(75, 17);
            this.Resource_Rock_Collectable_Radar_Color.TabIndex = 17;
            this.Resource_Rock_Collectable_Radar_Color.UseVisualStyleBackColor = false;
            this.Resource_Rock_Collectable_Radar_Color.Click += new System.EventHandler(this.Rock_Color_Click);
            // 
            // Resource_Wood_Collectable_Radar_Check
            // 
            this.Resource_Wood_Collectable_Radar_Check.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Resource_Wood_Collectable_Radar_Check.AutoSize = true;
            this.Resource_Wood_Collectable_Radar_Check.Checked = true;
            this.Resource_Wood_Collectable_Radar_Check.CheckState = System.Windows.Forms.CheckState.Checked;
            this.Resource_Wood_Collectable_Radar_Check.Location = new System.Drawing.Point(130, 48);
            this.Resource_Wood_Collectable_Radar_Check.Margin = new System.Windows.Forms.Padding(3, 3, 0, 0);
            this.Resource_Wood_Collectable_Radar_Check.Name = "Resource_Wood_Collectable_Radar_Check";
            this.Resource_Wood_Collectable_Radar_Check.Size = new System.Drawing.Size(15, 14);
            this.Resource_Wood_Collectable_Radar_Check.TabIndex = 1;
            this.Resource_Wood_Collectable_Radar_Check.UseVisualStyleBackColor = true;
            this.Resource_Wood_Collectable_Radar_Check.CheckedChanged += new System.EventHandler(this.Wood_Check_CheckedChanged);
            // 
            // Resource_Rock_Collectable_Radar_Check
            // 
            this.Resource_Rock_Collectable_Radar_Check.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Resource_Rock_Collectable_Radar_Check.AutoSize = true;
            this.Resource_Rock_Collectable_Radar_Check.Checked = true;
            this.Resource_Rock_Collectable_Radar_Check.CheckState = System.Windows.Forms.CheckState.Checked;
            this.Resource_Rock_Collectable_Radar_Check.Location = new System.Drawing.Point(130, 25);
            this.Resource_Rock_Collectable_Radar_Check.Margin = new System.Windows.Forms.Padding(3, 3, 0, 0);
            this.Resource_Rock_Collectable_Radar_Check.Name = "Resource_Rock_Collectable_Radar_Check";
            this.Resource_Rock_Collectable_Radar_Check.Size = new System.Drawing.Size(15, 14);
            this.Resource_Rock_Collectable_Radar_Check.TabIndex = 0;
            this.Resource_Rock_Collectable_Radar_Check.UseVisualStyleBackColor = true;
            this.Resource_Rock_Collectable_Radar_Check.CheckedChanged += new System.EventHandler(this.Rock_Check_CheckedChanged);
            // 
            // Resource_Wood_Collectable_Box_Color
            // 
            this.Resource_Wood_Collectable_Box_Color.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Resource_Wood_Collectable_Box_Color.Location = new System.Drawing.Point(409, 45);
            this.Resource_Wood_Collectable_Box_Color.Name = "Resource_Wood_Collectable_Box_Color";
            this.Resource_Wood_Collectable_Box_Color.Size = new System.Drawing.Size(75, 17);
            this.Resource_Wood_Collectable_Box_Color.TabIndex = 28;
            this.Resource_Wood_Collectable_Box_Color.UseVisualStyleBackColor = false;
            this.Resource_Wood_Collectable_Box_Color.Click += new System.EventHandler(this.Resource_Wood_Collectable_Box_Color_Click);
            // 
            // Resource_Rock_Collectable_Box_Color
            // 
            this.Resource_Rock_Collectable_Box_Color.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Resource_Rock_Collectable_Box_Color.Location = new System.Drawing.Point(409, 22);
            this.Resource_Rock_Collectable_Box_Color.Name = "Resource_Rock_Collectable_Box_Color";
            this.Resource_Rock_Collectable_Box_Color.Size = new System.Drawing.Size(75, 17);
            this.Resource_Rock_Collectable_Box_Color.TabIndex = 28;
            this.Resource_Rock_Collectable_Box_Color.UseVisualStyleBackColor = false;
            this.Resource_Rock_Collectable_Box_Color.Click += new System.EventHandler(this.Resource_Rock_Collectable_Box_Color_Click);
            // 
            // label67
            // 
            this.label67.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label67.AutoSize = true;
            this.label67.Location = new System.Drawing.Point(409, 3);
            this.label67.Margin = new System.Windows.Forms.Padding(3);
            this.label67.Name = "label67";
            this.label67.Size = new System.Drawing.Size(75, 13);
            this.label67.TabIndex = 76;
            this.label67.Text = "Box";
            this.label67.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label68
            // 
            this.label68.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label68.AutoSize = true;
            this.label68.Location = new System.Drawing.Point(3, 22);
            this.label68.Margin = new System.Windows.Forms.Padding(3);
            this.label68.Name = "label68";
            this.label68.Size = new System.Drawing.Size(107, 17);
            this.label68.TabIndex = 46;
            this.label68.Text = "Stone Collectable";
            this.label68.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label69
            // 
            this.label69.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label69.AutoSize = true;
            this.label69.Location = new System.Drawing.Point(3, 45);
            this.label69.Margin = new System.Windows.Forms.Padding(3);
            this.label69.Name = "label69";
            this.label69.Size = new System.Drawing.Size(107, 17);
            this.label69.TabIndex = 44;
            this.label69.Text = "Wood Collectable";
            this.label69.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Resource_Wood_Collectable_Box_Check
            // 
            this.Resource_Wood_Collectable_Box_Check.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Resource_Wood_Collectable_Box_Check.AutoSize = true;
            this.Resource_Wood_Collectable_Box_Check.CheckAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.Resource_Wood_Collectable_Box_Check.Checked = true;
            this.Resource_Wood_Collectable_Box_Check.CheckState = System.Windows.Forms.CheckState.Checked;
            this.Resource_Wood_Collectable_Box_Check.Location = new System.Drawing.Point(221, 48);
            this.Resource_Wood_Collectable_Box_Check.Margin = new System.Windows.Forms.Padding(3, 3, 0, 0);
            this.Resource_Wood_Collectable_Box_Check.Name = "Resource_Wood_Collectable_Box_Check";
            this.Resource_Wood_Collectable_Box_Check.Size = new System.Drawing.Size(15, 14);
            this.Resource_Wood_Collectable_Box_Check.TabIndex = 32;
            this.Resource_Wood_Collectable_Box_Check.UseVisualStyleBackColor = true;
            this.Resource_Wood_Collectable_Box_Check.CheckedChanged += new System.EventHandler(this.Resource_Wood_Collectable_Box_Check_CheckedChanged);
            // 
            // Resource_Rock_Collectable_Box_Check
            // 
            this.Resource_Rock_Collectable_Box_Check.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Resource_Rock_Collectable_Box_Check.AutoSize = true;
            this.Resource_Rock_Collectable_Box_Check.CheckAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.Resource_Rock_Collectable_Box_Check.Checked = true;
            this.Resource_Rock_Collectable_Box_Check.CheckState = System.Windows.Forms.CheckState.Checked;
            this.Resource_Rock_Collectable_Box_Check.Location = new System.Drawing.Point(221, 25);
            this.Resource_Rock_Collectable_Box_Check.Margin = new System.Windows.Forms.Padding(3, 3, 0, 0);
            this.Resource_Rock_Collectable_Box_Check.Name = "Resource_Rock_Collectable_Box_Check";
            this.Resource_Rock_Collectable_Box_Check.Size = new System.Drawing.Size(15, 14);
            this.Resource_Rock_Collectable_Box_Check.TabIndex = 34;
            this.Resource_Rock_Collectable_Box_Check.UseVisualStyleBackColor = true;
            this.Resource_Rock_Collectable_Box_Check.CheckedChanged += new System.EventHandler(this.Resource_Rock_Collectable_Box_Check_CheckedChanged);
            // 
            // label70
            // 
            this.label70.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label70.AutoSize = true;
            this.label70.Location = new System.Drawing.Point(116, 3);
            this.label70.Margin = new System.Windows.Forms.Padding(3);
            this.label70.Name = "label70";
            this.label70.Size = new System.Drawing.Size(41, 13);
            this.label70.TabIndex = 76;
            this.label70.Text = "Radar";
            this.label70.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label71
            // 
            this.label71.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label71.AutoSize = true;
            this.label71.Location = new System.Drawing.Point(213, 3);
            this.label71.Margin = new System.Windows.Forms.Padding(3);
            this.label71.Name = "label71";
            this.label71.Size = new System.Drawing.Size(28, 13);
            this.label71.TabIndex = 77;
            this.label71.Text = "Box";
            this.label71.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label72
            // 
            this.label72.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label72.AutoSize = true;
            this.label72.Location = new System.Drawing.Point(247, 3);
            this.label72.Margin = new System.Windows.Forms.Padding(3);
            this.label72.Name = "label72";
            this.label72.Size = new System.Drawing.Size(75, 13);
            this.label72.TabIndex = 78;
            this.label72.Text = "Radar";
            this.label72.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label73
            // 
            this.label73.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label73.AutoSize = true;
            this.label73.Location = new System.Drawing.Point(163, 3);
            this.label73.Margin = new System.Windows.Forms.Padding(3);
            this.label73.Name = "label73";
            this.label73.Size = new System.Drawing.Size(44, 13);
            this.label73.TabIndex = 79;
            this.label73.Text = "Tracer";
            this.label73.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label74
            // 
            this.label74.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label74.AutoSize = true;
            this.label74.Location = new System.Drawing.Point(328, 3);
            this.label74.Margin = new System.Windows.Forms.Padding(3);
            this.label74.Name = "label74";
            this.label74.Size = new System.Drawing.Size(75, 13);
            this.label74.TabIndex = 80;
            this.label74.Text = "Tracer";
            this.label74.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Resource_Rock_Collectable_Tracer_Color
            // 
            this.Resource_Rock_Collectable_Tracer_Color.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Resource_Rock_Collectable_Tracer_Color.Location = new System.Drawing.Point(328, 22);
            this.Resource_Rock_Collectable_Tracer_Color.Name = "Resource_Rock_Collectable_Tracer_Color";
            this.Resource_Rock_Collectable_Tracer_Color.Size = new System.Drawing.Size(75, 17);
            this.Resource_Rock_Collectable_Tracer_Color.TabIndex = 81;
            this.Resource_Rock_Collectable_Tracer_Color.UseVisualStyleBackColor = false;
            this.Resource_Rock_Collectable_Tracer_Color.Click += new System.EventHandler(this.Resource_Rock_Collectable_Tracer_Color_Click);
            // 
            // Resource_Wood_Collectable_Tracer_Color
            // 
            this.Resource_Wood_Collectable_Tracer_Color.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Resource_Wood_Collectable_Tracer_Color.Location = new System.Drawing.Point(328, 45);
            this.Resource_Wood_Collectable_Tracer_Color.Name = "Resource_Wood_Collectable_Tracer_Color";
            this.Resource_Wood_Collectable_Tracer_Color.Size = new System.Drawing.Size(75, 17);
            this.Resource_Wood_Collectable_Tracer_Color.TabIndex = 82;
            this.Resource_Wood_Collectable_Tracer_Color.UseVisualStyleBackColor = false;
            this.Resource_Wood_Collectable_Tracer_Color.Click += new System.EventHandler(this.Resource_Wood_Collectable_Tracer_Color_Click);
            // 
            // Resource_Rock_Collectable_Tracer_Check
            // 
            this.Resource_Rock_Collectable_Tracer_Check.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Resource_Rock_Collectable_Tracer_Check.AutoSize = true;
            this.Resource_Rock_Collectable_Tracer_Check.Checked = true;
            this.Resource_Rock_Collectable_Tracer_Check.CheckState = System.Windows.Forms.CheckState.Checked;
            this.Resource_Rock_Collectable_Tracer_Check.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Resource_Rock_Collectable_Tracer_Check.Location = new System.Drawing.Point(179, 25);
            this.Resource_Rock_Collectable_Tracer_Check.Margin = new System.Windows.Forms.Padding(3, 3, 0, 0);
            this.Resource_Rock_Collectable_Tracer_Check.Name = "Resource_Rock_Collectable_Tracer_Check";
            this.Resource_Rock_Collectable_Tracer_Check.Size = new System.Drawing.Size(15, 14);
            this.Resource_Rock_Collectable_Tracer_Check.TabIndex = 83;
            this.Resource_Rock_Collectable_Tracer_Check.UseVisualStyleBackColor = true;
            this.Resource_Rock_Collectable_Tracer_Check.CheckedChanged += new System.EventHandler(this.Resource_Rock_Collectable_Tracer_Check_CheckedChanged);
            // 
            // Resource_Wood_Collectable_Tracer_Check
            // 
            this.Resource_Wood_Collectable_Tracer_Check.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Resource_Wood_Collectable_Tracer_Check.AutoSize = true;
            this.Resource_Wood_Collectable_Tracer_Check.Checked = true;
            this.Resource_Wood_Collectable_Tracer_Check.CheckState = System.Windows.Forms.CheckState.Checked;
            this.Resource_Wood_Collectable_Tracer_Check.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Resource_Wood_Collectable_Tracer_Check.Location = new System.Drawing.Point(179, 48);
            this.Resource_Wood_Collectable_Tracer_Check.Margin = new System.Windows.Forms.Padding(3, 3, 0, 0);
            this.Resource_Wood_Collectable_Tracer_Check.Name = "Resource_Wood_Collectable_Tracer_Check";
            this.Resource_Wood_Collectable_Tracer_Check.Size = new System.Drawing.Size(15, 14);
            this.Resource_Wood_Collectable_Tracer_Check.TabIndex = 84;
            this.Resource_Wood_Collectable_Tracer_Check.UseVisualStyleBackColor = true;
            this.Resource_Wood_Collectable_Tracer_Check.CheckedChanged += new System.EventHandler(this.Resource_Wood_Collectable_Tracer_Check_CheckedChanged);
            // 
            // label66
            // 
            this.label66.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label66.AutoSize = true;
            this.label66.Location = new System.Drawing.Point(3, 68);
            this.label66.Margin = new System.Windows.Forms.Padding(3);
            this.label66.Name = "label66";
            this.label66.Size = new System.Drawing.Size(107, 17);
            this.label66.TabIndex = 85;
            this.label66.Text = "Sulfur Collectable";
            this.label66.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label65
            // 
            this.label65.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label65.AutoSize = true;
            this.label65.Location = new System.Drawing.Point(3, 91);
            this.label65.Margin = new System.Windows.Forms.Padding(3);
            this.label65.Name = "label65";
            this.label65.Size = new System.Drawing.Size(107, 17);
            this.label65.TabIndex = 47;
            this.label65.Text = "Metal Collectable";
            this.label65.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label64
            // 
            this.label64.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label64.AutoSize = true;
            this.label64.Location = new System.Drawing.Point(3, 114);
            this.label64.Margin = new System.Windows.Forms.Padding(3);
            this.label64.Name = "label64";
            this.label64.Size = new System.Drawing.Size(107, 17);
            this.label64.TabIndex = 47;
            this.label64.Text = "Sulfur Node";
            this.label64.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label63
            // 
            this.label63.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label63.AutoSize = true;
            this.label63.Location = new System.Drawing.Point(3, 137);
            this.label63.Margin = new System.Windows.Forms.Padding(3);
            this.label63.Name = "label63";
            this.label63.Size = new System.Drawing.Size(107, 17);
            this.label63.TabIndex = 47;
            this.label63.Text = "Metal Node";
            this.label63.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label75
            // 
            this.label75.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label75.AutoSize = true;
            this.label75.Location = new System.Drawing.Point(3, 160);
            this.label75.Margin = new System.Windows.Forms.Padding(3);
            this.label75.Name = "label75";
            this.label75.Size = new System.Drawing.Size(107, 17);
            this.label75.TabIndex = 95;
            this.label75.Text = "Stone Node";
            this.label75.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Resource_Sulfur_Collectable_Radar_Check
            // 
            this.Resource_Sulfur_Collectable_Radar_Check.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Resource_Sulfur_Collectable_Radar_Check.AutoSize = true;
            this.Resource_Sulfur_Collectable_Radar_Check.Checked = true;
            this.Resource_Sulfur_Collectable_Radar_Check.CheckState = System.Windows.Forms.CheckState.Checked;
            this.Resource_Sulfur_Collectable_Radar_Check.Location = new System.Drawing.Point(130, 71);
            this.Resource_Sulfur_Collectable_Radar_Check.Margin = new System.Windows.Forms.Padding(3, 3, 0, 0);
            this.Resource_Sulfur_Collectable_Radar_Check.Name = "Resource_Sulfur_Collectable_Radar_Check";
            this.Resource_Sulfur_Collectable_Radar_Check.Size = new System.Drawing.Size(15, 14);
            this.Resource_Sulfur_Collectable_Radar_Check.TabIndex = 2;
            this.Resource_Sulfur_Collectable_Radar_Check.UseVisualStyleBackColor = true;
            this.Resource_Sulfur_Collectable_Radar_Check.CheckedChanged += new System.EventHandler(this.Sulfur_Ore_Check_CheckedChanged);
            // 
            // Resource_Metal_Collectable_Radar_Check
            // 
            this.Resource_Metal_Collectable_Radar_Check.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Resource_Metal_Collectable_Radar_Check.AutoSize = true;
            this.Resource_Metal_Collectable_Radar_Check.Checked = true;
            this.Resource_Metal_Collectable_Radar_Check.CheckState = System.Windows.Forms.CheckState.Checked;
            this.Resource_Metal_Collectable_Radar_Check.Location = new System.Drawing.Point(130, 94);
            this.Resource_Metal_Collectable_Radar_Check.Margin = new System.Windows.Forms.Padding(3, 3, 0, 0);
            this.Resource_Metal_Collectable_Radar_Check.Name = "Resource_Metal_Collectable_Radar_Check";
            this.Resource_Metal_Collectable_Radar_Check.Size = new System.Drawing.Size(15, 14);
            this.Resource_Metal_Collectable_Radar_Check.TabIndex = 3;
            this.Resource_Metal_Collectable_Radar_Check.UseVisualStyleBackColor = true;
            this.Resource_Metal_Collectable_Radar_Check.CheckedChanged += new System.EventHandler(this.Metal_Ore_Check_CheckedChanged);
            // 
            // Resource_Sulfur_Node_Radar_Check
            // 
            this.Resource_Sulfur_Node_Radar_Check.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Resource_Sulfur_Node_Radar_Check.AutoSize = true;
            this.Resource_Sulfur_Node_Radar_Check.Checked = true;
            this.Resource_Sulfur_Node_Radar_Check.CheckState = System.Windows.Forms.CheckState.Checked;
            this.Resource_Sulfur_Node_Radar_Check.Location = new System.Drawing.Point(130, 117);
            this.Resource_Sulfur_Node_Radar_Check.Margin = new System.Windows.Forms.Padding(3, 3, 0, 0);
            this.Resource_Sulfur_Node_Radar_Check.Name = "Resource_Sulfur_Node_Radar_Check";
            this.Resource_Sulfur_Node_Radar_Check.Size = new System.Drawing.Size(15, 14);
            this.Resource_Sulfur_Node_Radar_Check.TabIndex = 5;
            this.Resource_Sulfur_Node_Radar_Check.UseVisualStyleBackColor = true;
            this.Resource_Sulfur_Node_Radar_Check.CheckedChanged += new System.EventHandler(this.Sulfur_Node_Check_CheckedChanged);
            // 
            // Resource_Metal_Node_Radar_Check
            // 
            this.Resource_Metal_Node_Radar_Check.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Resource_Metal_Node_Radar_Check.AutoSize = true;
            this.Resource_Metal_Node_Radar_Check.Checked = true;
            this.Resource_Metal_Node_Radar_Check.CheckState = System.Windows.Forms.CheckState.Checked;
            this.Resource_Metal_Node_Radar_Check.Location = new System.Drawing.Point(130, 140);
            this.Resource_Metal_Node_Radar_Check.Margin = new System.Windows.Forms.Padding(3, 3, 0, 0);
            this.Resource_Metal_Node_Radar_Check.Name = "Resource_Metal_Node_Radar_Check";
            this.Resource_Metal_Node_Radar_Check.Size = new System.Drawing.Size(15, 14);
            this.Resource_Metal_Node_Radar_Check.TabIndex = 6;
            this.Resource_Metal_Node_Radar_Check.UseVisualStyleBackColor = true;
            this.Resource_Metal_Node_Radar_Check.CheckedChanged += new System.EventHandler(this.Metal_Node_Check_CheckedChanged);
            // 
            // Resource_Stone_Node_Radar_Check
            // 
            this.Resource_Stone_Node_Radar_Check.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Resource_Stone_Node_Radar_Check.AutoSize = true;
            this.Resource_Stone_Node_Radar_Check.Checked = true;
            this.Resource_Stone_Node_Radar_Check.CheckState = System.Windows.Forms.CheckState.Checked;
            this.Resource_Stone_Node_Radar_Check.Location = new System.Drawing.Point(130, 163);
            this.Resource_Stone_Node_Radar_Check.Margin = new System.Windows.Forms.Padding(3, 3, 0, 0);
            this.Resource_Stone_Node_Radar_Check.Name = "Resource_Stone_Node_Radar_Check";
            this.Resource_Stone_Node_Radar_Check.Size = new System.Drawing.Size(15, 14);
            this.Resource_Stone_Node_Radar_Check.TabIndex = 8;
            this.Resource_Stone_Node_Radar_Check.UseVisualStyleBackColor = true;
            this.Resource_Stone_Node_Radar_Check.CheckedChanged += new System.EventHandler(this.Stone_Node_Check_CheckedChanged);
            // 
            // Resource_Sulfur_Collectable_Tracer_Check
            // 
            this.Resource_Sulfur_Collectable_Tracer_Check.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Resource_Sulfur_Collectable_Tracer_Check.AutoSize = true;
            this.Resource_Sulfur_Collectable_Tracer_Check.Checked = true;
            this.Resource_Sulfur_Collectable_Tracer_Check.CheckState = System.Windows.Forms.CheckState.Checked;
            this.Resource_Sulfur_Collectable_Tracer_Check.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Resource_Sulfur_Collectable_Tracer_Check.Location = new System.Drawing.Point(179, 71);
            this.Resource_Sulfur_Collectable_Tracer_Check.Margin = new System.Windows.Forms.Padding(3, 3, 0, 0);
            this.Resource_Sulfur_Collectable_Tracer_Check.Name = "Resource_Sulfur_Collectable_Tracer_Check";
            this.Resource_Sulfur_Collectable_Tracer_Check.Size = new System.Drawing.Size(15, 14);
            this.Resource_Sulfur_Collectable_Tracer_Check.TabIndex = 88;
            this.Resource_Sulfur_Collectable_Tracer_Check.UseVisualStyleBackColor = true;
            this.Resource_Sulfur_Collectable_Tracer_Check.CheckedChanged += new System.EventHandler(this.Resource_Sulfur_Collectable_Tracer_Check_CheckedChanged);
            // 
            // Resource_Sulfur_Collectable_Box_Check
            // 
            this.Resource_Sulfur_Collectable_Box_Check.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Resource_Sulfur_Collectable_Box_Check.AutoSize = true;
            this.Resource_Sulfur_Collectable_Box_Check.Checked = true;
            this.Resource_Sulfur_Collectable_Box_Check.CheckState = System.Windows.Forms.CheckState.Checked;
            this.Resource_Sulfur_Collectable_Box_Check.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Resource_Sulfur_Collectable_Box_Check.Location = new System.Drawing.Point(221, 71);
            this.Resource_Sulfur_Collectable_Box_Check.Margin = new System.Windows.Forms.Padding(3, 3, 0, 0);
            this.Resource_Sulfur_Collectable_Box_Check.Name = "Resource_Sulfur_Collectable_Box_Check";
            this.Resource_Sulfur_Collectable_Box_Check.Size = new System.Drawing.Size(15, 14);
            this.Resource_Sulfur_Collectable_Box_Check.TabIndex = 86;
            this.Resource_Sulfur_Collectable_Box_Check.UseVisualStyleBackColor = true;
            this.Resource_Sulfur_Collectable_Box_Check.CheckedChanged += new System.EventHandler(this.Resource_Sulfur_Collectable_Box_Check_CheckedChanged);
            // 
            // Resource_Metal_Collectable_Box_Check
            // 
            this.Resource_Metal_Collectable_Box_Check.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Resource_Metal_Collectable_Box_Check.AutoSize = true;
            this.Resource_Metal_Collectable_Box_Check.Checked = true;
            this.Resource_Metal_Collectable_Box_Check.CheckState = System.Windows.Forms.CheckState.Checked;
            this.Resource_Metal_Collectable_Box_Check.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Resource_Metal_Collectable_Box_Check.Location = new System.Drawing.Point(221, 94);
            this.Resource_Metal_Collectable_Box_Check.Margin = new System.Windows.Forms.Padding(3, 3, 0, 0);
            this.Resource_Metal_Collectable_Box_Check.Name = "Resource_Metal_Collectable_Box_Check";
            this.Resource_Metal_Collectable_Box_Check.Size = new System.Drawing.Size(15, 14);
            this.Resource_Metal_Collectable_Box_Check.TabIndex = 89;
            this.Resource_Metal_Collectable_Box_Check.UseVisualStyleBackColor = true;
            this.Resource_Metal_Collectable_Box_Check.CheckedChanged += new System.EventHandler(this.Resource_Metal_Collectable_Box_Check_CheckedChanged);
            // 
            // Resource_Metal_Collectable_Tracer_Check
            // 
            this.Resource_Metal_Collectable_Tracer_Check.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Resource_Metal_Collectable_Tracer_Check.AutoSize = true;
            this.Resource_Metal_Collectable_Tracer_Check.Checked = true;
            this.Resource_Metal_Collectable_Tracer_Check.CheckState = System.Windows.Forms.CheckState.Checked;
            this.Resource_Metal_Collectable_Tracer_Check.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Resource_Metal_Collectable_Tracer_Check.Location = new System.Drawing.Point(179, 94);
            this.Resource_Metal_Collectable_Tracer_Check.Margin = new System.Windows.Forms.Padding(3, 3, 0, 0);
            this.Resource_Metal_Collectable_Tracer_Check.Name = "Resource_Metal_Collectable_Tracer_Check";
            this.Resource_Metal_Collectable_Tracer_Check.Size = new System.Drawing.Size(15, 14);
            this.Resource_Metal_Collectable_Tracer_Check.TabIndex = 93;
            this.Resource_Metal_Collectable_Tracer_Check.UseVisualStyleBackColor = true;
            this.Resource_Metal_Collectable_Tracer_Check.CheckedChanged += new System.EventHandler(this.Resource_Metal_Collectable_Tracer_Check_CheckedChanged);
            // 
            // Resource_Sulfur_Node_Tracer_Check
            // 
            this.Resource_Sulfur_Node_Tracer_Check.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Resource_Sulfur_Node_Tracer_Check.AutoSize = true;
            this.Resource_Sulfur_Node_Tracer_Check.Checked = true;
            this.Resource_Sulfur_Node_Tracer_Check.CheckState = System.Windows.Forms.CheckState.Checked;
            this.Resource_Sulfur_Node_Tracer_Check.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Resource_Sulfur_Node_Tracer_Check.Location = new System.Drawing.Point(179, 117);
            this.Resource_Sulfur_Node_Tracer_Check.Margin = new System.Windows.Forms.Padding(3, 3, 0, 0);
            this.Resource_Sulfur_Node_Tracer_Check.Name = "Resource_Sulfur_Node_Tracer_Check";
            this.Resource_Sulfur_Node_Tracer_Check.Size = new System.Drawing.Size(15, 14);
            this.Resource_Sulfur_Node_Tracer_Check.TabIndex = 92;
            this.Resource_Sulfur_Node_Tracer_Check.UseVisualStyleBackColor = true;
            this.Resource_Sulfur_Node_Tracer_Check.CheckedChanged += new System.EventHandler(this.Resource_Sulfur_Node_Tracer_Check_CheckedChanged);
            // 
            // Resource_Sulfur_Node_Box_Check
            // 
            this.Resource_Sulfur_Node_Box_Check.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Resource_Sulfur_Node_Box_Check.AutoSize = true;
            this.Resource_Sulfur_Node_Box_Check.Checked = true;
            this.Resource_Sulfur_Node_Box_Check.CheckState = System.Windows.Forms.CheckState.Checked;
            this.Resource_Sulfur_Node_Box_Check.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Resource_Sulfur_Node_Box_Check.Location = new System.Drawing.Point(221, 117);
            this.Resource_Sulfur_Node_Box_Check.Margin = new System.Windows.Forms.Padding(3, 3, 0, 0);
            this.Resource_Sulfur_Node_Box_Check.Name = "Resource_Sulfur_Node_Box_Check";
            this.Resource_Sulfur_Node_Box_Check.Size = new System.Drawing.Size(15, 14);
            this.Resource_Sulfur_Node_Box_Check.TabIndex = 91;
            this.Resource_Sulfur_Node_Box_Check.UseVisualStyleBackColor = true;
            this.Resource_Sulfur_Node_Box_Check.CheckedChanged += new System.EventHandler(this.Resource_Sulfur_Node_Box_Check_CheckedChanged);
            // 
            // Resource_Metal_Node_Tracer_Check
            // 
            this.Resource_Metal_Node_Tracer_Check.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Resource_Metal_Node_Tracer_Check.AutoSize = true;
            this.Resource_Metal_Node_Tracer_Check.Checked = true;
            this.Resource_Metal_Node_Tracer_Check.CheckState = System.Windows.Forms.CheckState.Checked;
            this.Resource_Metal_Node_Tracer_Check.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Resource_Metal_Node_Tracer_Check.Location = new System.Drawing.Point(179, 140);
            this.Resource_Metal_Node_Tracer_Check.Margin = new System.Windows.Forms.Padding(3, 3, 0, 0);
            this.Resource_Metal_Node_Tracer_Check.Name = "Resource_Metal_Node_Tracer_Check";
            this.Resource_Metal_Node_Tracer_Check.Size = new System.Drawing.Size(15, 14);
            this.Resource_Metal_Node_Tracer_Check.TabIndex = 94;
            this.Resource_Metal_Node_Tracer_Check.UseVisualStyleBackColor = true;
            this.Resource_Metal_Node_Tracer_Check.CheckedChanged += new System.EventHandler(this.Resource_Metal_Node_Tracer_Check_CheckedChanged);
            // 
            // Resource_Metal_Node_Box_Check
            // 
            this.Resource_Metal_Node_Box_Check.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Resource_Metal_Node_Box_Check.AutoSize = true;
            this.Resource_Metal_Node_Box_Check.Checked = true;
            this.Resource_Metal_Node_Box_Check.CheckState = System.Windows.Forms.CheckState.Checked;
            this.Resource_Metal_Node_Box_Check.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Resource_Metal_Node_Box_Check.Location = new System.Drawing.Point(221, 140);
            this.Resource_Metal_Node_Box_Check.Margin = new System.Windows.Forms.Padding(3, 3, 0, 0);
            this.Resource_Metal_Node_Box_Check.Name = "Resource_Metal_Node_Box_Check";
            this.Resource_Metal_Node_Box_Check.Size = new System.Drawing.Size(15, 14);
            this.Resource_Metal_Node_Box_Check.TabIndex = 90;
            this.Resource_Metal_Node_Box_Check.UseVisualStyleBackColor = true;
            this.Resource_Metal_Node_Box_Check.CheckedChanged += new System.EventHandler(this.Resource_Metal_Node_Box_Check_CheckedChanged);
            // 
            // Resource_Stone_Node_Tracer_Check
            // 
            this.Resource_Stone_Node_Tracer_Check.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Resource_Stone_Node_Tracer_Check.AutoSize = true;
            this.Resource_Stone_Node_Tracer_Check.Checked = true;
            this.Resource_Stone_Node_Tracer_Check.CheckState = System.Windows.Forms.CheckState.Checked;
            this.Resource_Stone_Node_Tracer_Check.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Resource_Stone_Node_Tracer_Check.Location = new System.Drawing.Point(179, 163);
            this.Resource_Stone_Node_Tracer_Check.Margin = new System.Windows.Forms.Padding(3, 3, 0, 0);
            this.Resource_Stone_Node_Tracer_Check.Name = "Resource_Stone_Node_Tracer_Check";
            this.Resource_Stone_Node_Tracer_Check.Size = new System.Drawing.Size(15, 14);
            this.Resource_Stone_Node_Tracer_Check.TabIndex = 97;
            this.Resource_Stone_Node_Tracer_Check.UseVisualStyleBackColor = true;
            this.Resource_Stone_Node_Tracer_Check.CheckedChanged += new System.EventHandler(this.Resource_Stone_Node_Tracer_Check_CheckedChanged);
            // 
            // Resource_Stone_Node_Box_Check
            // 
            this.Resource_Stone_Node_Box_Check.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Resource_Stone_Node_Box_Check.AutoSize = true;
            this.Resource_Stone_Node_Box_Check.Checked = true;
            this.Resource_Stone_Node_Box_Check.CheckState = System.Windows.Forms.CheckState.Checked;
            this.Resource_Stone_Node_Box_Check.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Resource_Stone_Node_Box_Check.Location = new System.Drawing.Point(221, 163);
            this.Resource_Stone_Node_Box_Check.Margin = new System.Windows.Forms.Padding(3, 3, 0, 0);
            this.Resource_Stone_Node_Box_Check.Name = "Resource_Stone_Node_Box_Check";
            this.Resource_Stone_Node_Box_Check.Size = new System.Drawing.Size(15, 14);
            this.Resource_Stone_Node_Box_Check.TabIndex = 96;
            this.Resource_Stone_Node_Box_Check.UseVisualStyleBackColor = true;
            this.Resource_Stone_Node_Box_Check.CheckedChanged += new System.EventHandler(this.Resource_Stone_Node_Box_Check_CheckedChanged);
            // 
            // Resource_Sulfur_Collectable_Radar_Color
            // 
            this.Resource_Sulfur_Collectable_Radar_Color.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Resource_Sulfur_Collectable_Radar_Color.Location = new System.Drawing.Point(247, 68);
            this.Resource_Sulfur_Collectable_Radar_Color.Name = "Resource_Sulfur_Collectable_Radar_Color";
            this.Resource_Sulfur_Collectable_Radar_Color.Size = new System.Drawing.Size(75, 17);
            this.Resource_Sulfur_Collectable_Radar_Color.TabIndex = 15;
            this.Resource_Sulfur_Collectable_Radar_Color.UseVisualStyleBackColor = false;
            this.Resource_Sulfur_Collectable_Radar_Color.Click += new System.EventHandler(this.Sulfur_Ore_Color_Click);
            // 
            // Resource_Metal_Collectable_Radar_Color
            // 
            this.Resource_Metal_Collectable_Radar_Color.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Resource_Metal_Collectable_Radar_Color.Location = new System.Drawing.Point(247, 91);
            this.Resource_Metal_Collectable_Radar_Color.Name = "Resource_Metal_Collectable_Radar_Color";
            this.Resource_Metal_Collectable_Radar_Color.Size = new System.Drawing.Size(75, 17);
            this.Resource_Metal_Collectable_Radar_Color.TabIndex = 14;
            this.Resource_Metal_Collectable_Radar_Color.UseVisualStyleBackColor = false;
            this.Resource_Metal_Collectable_Radar_Color.Click += new System.EventHandler(this.Metal_Ore_Color_Click);
            // 
            // Resource_Sulfur_Node_Radar_Color
            // 
            this.Resource_Sulfur_Node_Radar_Color.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Resource_Sulfur_Node_Radar_Color.Location = new System.Drawing.Point(247, 114);
            this.Resource_Sulfur_Node_Radar_Color.Name = "Resource_Sulfur_Node_Radar_Color";
            this.Resource_Sulfur_Node_Radar_Color.Size = new System.Drawing.Size(75, 17);
            this.Resource_Sulfur_Node_Radar_Color.TabIndex = 12;
            this.Resource_Sulfur_Node_Radar_Color.UseVisualStyleBackColor = false;
            this.Resource_Sulfur_Node_Radar_Color.Click += new System.EventHandler(this.Sulfur_Node_Color_Click);
            // 
            // Resource_Metal_Node_Radar_Color
            // 
            this.Resource_Metal_Node_Radar_Color.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Resource_Metal_Node_Radar_Color.Location = new System.Drawing.Point(247, 137);
            this.Resource_Metal_Node_Radar_Color.Name = "Resource_Metal_Node_Radar_Color";
            this.Resource_Metal_Node_Radar_Color.Size = new System.Drawing.Size(75, 17);
            this.Resource_Metal_Node_Radar_Color.TabIndex = 11;
            this.Resource_Metal_Node_Radar_Color.UseVisualStyleBackColor = false;
            this.Resource_Metal_Node_Radar_Color.Click += new System.EventHandler(this.Metal_Node_Color_Click);
            // 
            // Resource_Stone_Node_Radar_Color
            // 
            this.Resource_Stone_Node_Radar_Color.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Resource_Stone_Node_Radar_Color.Location = new System.Drawing.Point(247, 160);
            this.Resource_Stone_Node_Radar_Color.Name = "Resource_Stone_Node_Radar_Color";
            this.Resource_Stone_Node_Radar_Color.Size = new System.Drawing.Size(75, 17);
            this.Resource_Stone_Node_Radar_Color.TabIndex = 9;
            this.Resource_Stone_Node_Radar_Color.UseVisualStyleBackColor = false;
            this.Resource_Stone_Node_Radar_Color.Click += new System.EventHandler(this.Stone_Node_Color_Click);
            // 
            // Resource_Sulfur_Collectable_Tracer_Color
            // 
            this.Resource_Sulfur_Collectable_Tracer_Color.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Resource_Sulfur_Collectable_Tracer_Color.Location = new System.Drawing.Point(328, 68);
            this.Resource_Sulfur_Collectable_Tracer_Color.Name = "Resource_Sulfur_Collectable_Tracer_Color";
            this.Resource_Sulfur_Collectable_Tracer_Color.Size = new System.Drawing.Size(75, 17);
            this.Resource_Sulfur_Collectable_Tracer_Color.TabIndex = 89;
            this.Resource_Sulfur_Collectable_Tracer_Color.UseVisualStyleBackColor = false;
            this.Resource_Sulfur_Collectable_Tracer_Color.Click += new System.EventHandler(this.Resource_Sulfur_Collectable_Tracer_Color_Click);
            // 
            // Resource_Sulfur_Collectable_Box_Color
            // 
            this.Resource_Sulfur_Collectable_Box_Color.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Resource_Sulfur_Collectable_Box_Color.Location = new System.Drawing.Point(409, 68);
            this.Resource_Sulfur_Collectable_Box_Color.Name = "Resource_Sulfur_Collectable_Box_Color";
            this.Resource_Sulfur_Collectable_Box_Color.Size = new System.Drawing.Size(75, 17);
            this.Resource_Sulfur_Collectable_Box_Color.TabIndex = 91;
            this.Resource_Sulfur_Collectable_Box_Color.UseVisualStyleBackColor = false;
            this.Resource_Sulfur_Collectable_Box_Color.Click += new System.EventHandler(this.Resource_Sulfur_Collectable_Box_Color_Click);
            // 
            // Resource_Metal_Collectable_Box_Color
            // 
            this.Resource_Metal_Collectable_Box_Color.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Resource_Metal_Collectable_Box_Color.Location = new System.Drawing.Point(409, 91);
            this.Resource_Metal_Collectable_Box_Color.Name = "Resource_Metal_Collectable_Box_Color";
            this.Resource_Metal_Collectable_Box_Color.Size = new System.Drawing.Size(75, 17);
            this.Resource_Metal_Collectable_Box_Color.TabIndex = 30;
            this.Resource_Metal_Collectable_Box_Color.UseVisualStyleBackColor = false;
            this.Resource_Metal_Collectable_Box_Color.Click += new System.EventHandler(this.Resource_Metal_Collectable_Box_Color_Click);
            // 
            // Resource_Metal_Collectable_Tracer_Color
            // 
            this.Resource_Metal_Collectable_Tracer_Color.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Resource_Metal_Collectable_Tracer_Color.Location = new System.Drawing.Point(328, 91);
            this.Resource_Metal_Collectable_Tracer_Color.Name = "Resource_Metal_Collectable_Tracer_Color";
            this.Resource_Metal_Collectable_Tracer_Color.Size = new System.Drawing.Size(75, 17);
            this.Resource_Metal_Collectable_Tracer_Color.TabIndex = 91;
            this.Resource_Metal_Collectable_Tracer_Color.UseVisualStyleBackColor = false;
            this.Resource_Metal_Collectable_Tracer_Color.Click += new System.EventHandler(this.Resource_Metal_Collectable_Tracer_Color_Click);
            // 
            // Resource_Sulfur_Node_Tracer_Color
            // 
            this.Resource_Sulfur_Node_Tracer_Color.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Resource_Sulfur_Node_Tracer_Color.Location = new System.Drawing.Point(328, 114);
            this.Resource_Sulfur_Node_Tracer_Color.Name = "Resource_Sulfur_Node_Tracer_Color";
            this.Resource_Sulfur_Node_Tracer_Color.Size = new System.Drawing.Size(75, 17);
            this.Resource_Sulfur_Node_Tracer_Color.TabIndex = 91;
            this.Resource_Sulfur_Node_Tracer_Color.UseVisualStyleBackColor = false;
            this.Resource_Sulfur_Node_Tracer_Color.Click += new System.EventHandler(this.Resource_Sulfur_Node_Tracer_Color_Click);
            // 
            // Resource_Metal_Node_Tracer_Color
            // 
            this.Resource_Metal_Node_Tracer_Color.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Resource_Metal_Node_Tracer_Color.Location = new System.Drawing.Point(328, 137);
            this.Resource_Metal_Node_Tracer_Color.Name = "Resource_Metal_Node_Tracer_Color";
            this.Resource_Metal_Node_Tracer_Color.Size = new System.Drawing.Size(75, 17);
            this.Resource_Metal_Node_Tracer_Color.TabIndex = 31;
            this.Resource_Metal_Node_Tracer_Color.UseVisualStyleBackColor = false;
            this.Resource_Metal_Node_Tracer_Color.Click += new System.EventHandler(this.Resource_Metal_Node_Tracer_Color_Click);
            // 
            // Resource_Sulfur_Node_Box_Color
            // 
            this.Resource_Sulfur_Node_Box_Color.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Resource_Sulfur_Node_Box_Color.Location = new System.Drawing.Point(409, 114);
            this.Resource_Sulfur_Node_Box_Color.Name = "Resource_Sulfur_Node_Box_Color";
            this.Resource_Sulfur_Node_Box_Color.Size = new System.Drawing.Size(75, 17);
            this.Resource_Sulfur_Node_Box_Color.TabIndex = 32;
            this.Resource_Sulfur_Node_Box_Color.UseVisualStyleBackColor = false;
            this.Resource_Sulfur_Node_Box_Color.Click += new System.EventHandler(this.Resource_Sulfur_Node_Box_Color_Click);
            // 
            // Resource_Metal_Node_Box_Color
            // 
            this.Resource_Metal_Node_Box_Color.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Resource_Metal_Node_Box_Color.Location = new System.Drawing.Point(409, 137);
            this.Resource_Metal_Node_Box_Color.Name = "Resource_Metal_Node_Box_Color";
            this.Resource_Metal_Node_Box_Color.Size = new System.Drawing.Size(75, 17);
            this.Resource_Metal_Node_Box_Color.TabIndex = 30;
            this.Resource_Metal_Node_Box_Color.UseVisualStyleBackColor = false;
            this.Resource_Metal_Node_Box_Color.Click += new System.EventHandler(this.Resource_Metal_Node_Box_Color_Click);
            // 
            // Resource_Stone_Node_Tracer_Color
            // 
            this.Resource_Stone_Node_Tracer_Color.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Resource_Stone_Node_Tracer_Color.Location = new System.Drawing.Point(328, 160);
            this.Resource_Stone_Node_Tracer_Color.Name = "Resource_Stone_Node_Tracer_Color";
            this.Resource_Stone_Node_Tracer_Color.Size = new System.Drawing.Size(75, 17);
            this.Resource_Stone_Node_Tracer_Color.TabIndex = 33;
            this.Resource_Stone_Node_Tracer_Color.UseVisualStyleBackColor = false;
            this.Resource_Stone_Node_Tracer_Color.Click += new System.EventHandler(this.Resource_Stone_Node_Tracer_Color_Click);
            // 
            // Resource_Stone_Node_Box_Color
            // 
            this.Resource_Stone_Node_Box_Color.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Resource_Stone_Node_Box_Color.Location = new System.Drawing.Point(409, 160);
            this.Resource_Stone_Node_Box_Color.Name = "Resource_Stone_Node_Box_Color";
            this.Resource_Stone_Node_Box_Color.Size = new System.Drawing.Size(75, 17);
            this.Resource_Stone_Node_Box_Color.TabIndex = 32;
            this.Resource_Stone_Node_Box_Color.UseVisualStyleBackColor = false;
            this.Resource_Stone_Node_Box_Color.Click += new System.EventHandler(this.Resource_Stone_Node_Box_Color_Click);
            // 
            // Barrels_TAB
            // 
            this.Barrels_TAB.BackColor = System.Drawing.Color.White;
            this.Barrels_TAB.Controls.Add(this.tableLayoutPanel8);
            this.Barrels_TAB.Location = new System.Drawing.Point(4, 22);
            this.Barrels_TAB.Name = "Barrels_TAB";
            this.Barrels_TAB.Size = new System.Drawing.Size(568, 552);
            this.Barrels_TAB.TabIndex = 8;
            this.Barrels_TAB.Text = "Barrels";
            // 
            // tableLayoutPanel8
            // 
            this.tableLayoutPanel8.ColumnCount = 8;
            this.tableLayoutPanel8.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel8.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel8.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel8.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel8.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel8.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel8.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel8.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 81F));
            this.tableLayoutPanel8.Controls.Add(this.label90, 0, 9);
            this.tableLayoutPanel8.Controls.Add(this.Barrel_Food_Box_Box_Color, 6, 9);
            this.tableLayoutPanel8.Controls.Add(this.Barrel_Tool_Crate_Box_Color, 6, 8);
            this.tableLayoutPanel8.Controls.Add(this.Barrel_Food_Box_Tracer_Color, 5, 9);
            this.tableLayoutPanel8.Controls.Add(this.Barrel_Tool_Crate_Tracer_Color, 5, 8);
            this.tableLayoutPanel8.Controls.Add(this.Barrel_Food_Box_Tracer_Check, 2, 9);
            this.tableLayoutPanel8.Controls.Add(this.Barrel_Food_Box_Box_Check, 3, 9);
            this.tableLayoutPanel8.Controls.Add(this.Barrel_Tool_Crate_Box_Check, 3, 8);
            this.tableLayoutPanel8.Controls.Add(this.Barrel_Food_Box_Radar_Color, 4, 9);
            this.tableLayoutPanel8.Controls.Add(this.Barrel_Food_Box_Radar_Check, 1, 9);
            this.tableLayoutPanel8.Controls.Add(this.Barrel_Oil_Barrel_Radar_Check, 1, 2);
            this.tableLayoutPanel8.Controls.Add(this.Barrel_Tool_Crate_Tracer_Check, 2, 8);
            this.tableLayoutPanel8.Controls.Add(this.Barrel_Tool_Crate_Radar_Check, 1, 8);
            this.tableLayoutPanel8.Controls.Add(this.Barrel_Tool_Crate_Radar_Color, 4, 8);
            this.tableLayoutPanel8.Controls.Add(this.Barrel_Med_Crate_Radar_Check, 1, 7);
            this.tableLayoutPanel8.Controls.Add(this.Barrel_Food_Crate_Radar_Color, 4, 6);
            this.tableLayoutPanel8.Controls.Add(this.Barrel_Food_Crate_Radar_Check, 1, 6);
            this.tableLayoutPanel8.Controls.Add(this.Barrel_Mine_Crate_Radar_Color, 4, 5);
            this.tableLayoutPanel8.Controls.Add(this.Barrel_Mine_Crate_Radar_Check, 1, 5);
            this.tableLayoutPanel8.Controls.Add(this.Barrel_Med_Crate_Radar_Color, 4, 7);
            this.tableLayoutPanel8.Controls.Add(this.Barrel_Crate_Radar_Check, 1, 4);
            this.tableLayoutPanel8.Controls.Add(this.Barrel_Crate_Radar_Color, 4, 4);
            this.tableLayoutPanel8.Controls.Add(this.Barrel_Trash_Pile_Radar_Check, 1, 3);
            this.tableLayoutPanel8.Controls.Add(this.Barrel_Trash_Pile_Radar_Color, 4, 3);
            this.tableLayoutPanel8.Controls.Add(this.Barrel_Oil_Barrel_Radar_Color, 4, 2);
            this.tableLayoutPanel8.Controls.Add(this.Barrel_Loot_Barrel_Radar_Color, 4, 1);
            this.tableLayoutPanel8.Controls.Add(this.Barrel_Loot_Barrel_Radar_Check, 1, 1);
            this.tableLayoutPanel8.Controls.Add(this.Barrel_Oil_Barrel_Box_Color, 6, 2);
            this.tableLayoutPanel8.Controls.Add(this.Barrel_Loot_Barrel_Box_Color, 6, 1);
            this.tableLayoutPanel8.Controls.Add(this.label76, 6, 0);
            this.tableLayoutPanel8.Controls.Add(this.label77, 0, 1);
            this.tableLayoutPanel8.Controls.Add(this.label78, 0, 2);
            this.tableLayoutPanel8.Controls.Add(this.Barrel_Oil_Barrel_Box_Check, 3, 2);
            this.tableLayoutPanel8.Controls.Add(this.Barrel_Loot_Barrel_Box_Check, 3, 1);
            this.tableLayoutPanel8.Controls.Add(this.label79, 1, 0);
            this.tableLayoutPanel8.Controls.Add(this.label80, 3, 0);
            this.tableLayoutPanel8.Controls.Add(this.label82, 2, 0);
            this.tableLayoutPanel8.Controls.Add(this.label83, 5, 0);
            this.tableLayoutPanel8.Controls.Add(this.Barrel_Loot_Barrel_Tracer_Color, 5, 1);
            this.tableLayoutPanel8.Controls.Add(this.Barrel_Oil_Barrel_Tracer_Color, 5, 2);
            this.tableLayoutPanel8.Controls.Add(this.Barrel_Loot_Barrel_Tracer_Check, 2, 1);
            this.tableLayoutPanel8.Controls.Add(this.Barrel_Oil_Barrel_Tracer_Check, 2, 2);
            this.tableLayoutPanel8.Controls.Add(this.label84, 0, 3);
            this.tableLayoutPanel8.Controls.Add(this.label85, 0, 4);
            this.tableLayoutPanel8.Controls.Add(this.label86, 0, 5);
            this.tableLayoutPanel8.Controls.Add(this.label87, 0, 6);
            this.tableLayoutPanel8.Controls.Add(this.label88, 0, 7);
            this.tableLayoutPanel8.Controls.Add(this.Barrel_Trash_Pile_Tracer_Check, 2, 3);
            this.tableLayoutPanel8.Controls.Add(this.Barrel_Trash_Pile_Box_Check, 3, 3);
            this.tableLayoutPanel8.Controls.Add(this.Barrel_Crate_Box_Check, 3, 4);
            this.tableLayoutPanel8.Controls.Add(this.Barrel_Crate_Tracer_Check, 2, 4);
            this.tableLayoutPanel8.Controls.Add(this.Barrel_Mine_Crate_Tracer_Check, 2, 5);
            this.tableLayoutPanel8.Controls.Add(this.Barrel_Mine_Crate_Box_Check, 3, 5);
            this.tableLayoutPanel8.Controls.Add(this.Barrel_Food_Crate_Tracer_Check, 2, 6);
            this.tableLayoutPanel8.Controls.Add(this.Barrel_Food_Crate_Box_Check, 3, 6);
            this.tableLayoutPanel8.Controls.Add(this.Barrel_Med_Crate_Tracer_Check, 2, 7);
            this.tableLayoutPanel8.Controls.Add(this.Barrel_Med_Crate_Box_Check, 3, 7);
            this.tableLayoutPanel8.Controls.Add(this.Barrel_Trash_Pile_Tracer_Color, 5, 3);
            this.tableLayoutPanel8.Controls.Add(this.Barrel_Trash_Pile_Box_Color, 6, 3);
            this.tableLayoutPanel8.Controls.Add(this.Barrel_Crate_Box_Color, 6, 4);
            this.tableLayoutPanel8.Controls.Add(this.Barrel_Crate_Tracer_Color, 5, 4);
            this.tableLayoutPanel8.Controls.Add(this.Barrel_Mine_Crate_Tracer_Color, 5, 5);
            this.tableLayoutPanel8.Controls.Add(this.Barrel_Food_Crate_Tracer_Color, 5, 6);
            this.tableLayoutPanel8.Controls.Add(this.Barrel_Mine_Crate_Box_Color, 6, 5);
            this.tableLayoutPanel8.Controls.Add(this.Barrel_Food_Crate_Box_Color, 6, 6);
            this.tableLayoutPanel8.Controls.Add(this.Barrel_Med_Crate_Tracer_Color, 5, 7);
            this.tableLayoutPanel8.Controls.Add(this.Barrel_Med_Crate_Box_Color, 6, 7);
            this.tableLayoutPanel8.Controls.Add(this.label81, 4, 0);
            this.tableLayoutPanel8.Controls.Add(this.label89, 0, 8);
            this.tableLayoutPanel8.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanel8.Name = "tableLayoutPanel8";
            this.tableLayoutPanel8.RowCount = 11;
            this.tableLayoutPanel8.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel8.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel8.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel8.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel8.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel8.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel8.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel8.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel8.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel8.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel8.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 8F));
            this.tableLayoutPanel8.Size = new System.Drawing.Size(546, 282);
            this.tableLayoutPanel8.TabIndex = 31;
            // 
            // label90
            // 
            this.label90.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label90.AutoSize = true;
            this.label90.Location = new System.Drawing.Point(3, 206);
            this.label90.Margin = new System.Windows.Forms.Padding(3);
            this.label90.Name = "label90";
            this.label90.Size = new System.Drawing.Size(85, 17);
            this.label90.TabIndex = 96;
            this.label90.Text = "Food Box";
            this.label90.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Barrel_Food_Box_Box_Color
            // 
            this.Barrel_Food_Box_Box_Color.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Barrel_Food_Box_Box_Color.Location = new System.Drawing.Point(387, 206);
            this.Barrel_Food_Box_Box_Color.Name = "Barrel_Food_Box_Box_Color";
            this.Barrel_Food_Box_Box_Color.Size = new System.Drawing.Size(75, 17);
            this.Barrel_Food_Box_Box_Color.TabIndex = 32;
            this.Barrel_Food_Box_Box_Color.UseVisualStyleBackColor = false;
            this.Barrel_Food_Box_Box_Color.Click += new System.EventHandler(this.Barrel_Food_Box_Box_Color_Click);
            // 
            // Barrel_Tool_Crate_Box_Color
            // 
            this.Barrel_Tool_Crate_Box_Color.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Barrel_Tool_Crate_Box_Color.Location = new System.Drawing.Point(387, 183);
            this.Barrel_Tool_Crate_Box_Color.Name = "Barrel_Tool_Crate_Box_Color";
            this.Barrel_Tool_Crate_Box_Color.Size = new System.Drawing.Size(75, 17);
            this.Barrel_Tool_Crate_Box_Color.TabIndex = 33;
            this.Barrel_Tool_Crate_Box_Color.UseVisualStyleBackColor = false;
            this.Barrel_Tool_Crate_Box_Color.Click += new System.EventHandler(this.Barrel_Tool_Crate_Box_Color_Click);
            // 
            // Barrel_Food_Box_Tracer_Color
            // 
            this.Barrel_Food_Box_Tracer_Color.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Barrel_Food_Box_Tracer_Color.Location = new System.Drawing.Point(306, 206);
            this.Barrel_Food_Box_Tracer_Color.Name = "Barrel_Food_Box_Tracer_Color";
            this.Barrel_Food_Box_Tracer_Color.Size = new System.Drawing.Size(75, 17);
            this.Barrel_Food_Box_Tracer_Color.TabIndex = 34;
            this.Barrel_Food_Box_Tracer_Color.UseVisualStyleBackColor = false;
            this.Barrel_Food_Box_Tracer_Color.Click += new System.EventHandler(this.Barrel_Food_Box_Tracer_Color_Click);
            // 
            // Barrel_Tool_Crate_Tracer_Color
            // 
            this.Barrel_Tool_Crate_Tracer_Color.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Barrel_Tool_Crate_Tracer_Color.Location = new System.Drawing.Point(306, 183);
            this.Barrel_Tool_Crate_Tracer_Color.Name = "Barrel_Tool_Crate_Tracer_Color";
            this.Barrel_Tool_Crate_Tracer_Color.Size = new System.Drawing.Size(75, 17);
            this.Barrel_Tool_Crate_Tracer_Color.TabIndex = 35;
            this.Barrel_Tool_Crate_Tracer_Color.UseVisualStyleBackColor = false;
            this.Barrel_Tool_Crate_Tracer_Color.Click += new System.EventHandler(this.Barrel_Tool_Crate_Tracer_Color_Click);
            // 
            // Barrel_Food_Box_Tracer_Check
            // 
            this.Barrel_Food_Box_Tracer_Check.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Barrel_Food_Box_Tracer_Check.AutoSize = true;
            this.Barrel_Food_Box_Tracer_Check.Checked = true;
            this.Barrel_Food_Box_Tracer_Check.CheckState = System.Windows.Forms.CheckState.Checked;
            this.Barrel_Food_Box_Tracer_Check.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Barrel_Food_Box_Tracer_Check.Location = new System.Drawing.Point(157, 209);
            this.Barrel_Food_Box_Tracer_Check.Margin = new System.Windows.Forms.Padding(3, 3, 0, 0);
            this.Barrel_Food_Box_Tracer_Check.Name = "Barrel_Food_Box_Tracer_Check";
            this.Barrel_Food_Box_Tracer_Check.Size = new System.Drawing.Size(15, 14);
            this.Barrel_Food_Box_Tracer_Check.TabIndex = 85;
            this.Barrel_Food_Box_Tracer_Check.UseVisualStyleBackColor = true;
            this.Barrel_Food_Box_Tracer_Check.CheckedChanged += new System.EventHandler(this.Barrel_Food_Box_Tracer_Check_CheckedChanged);
            // 
            // Barrel_Food_Box_Box_Check
            // 
            this.Barrel_Food_Box_Box_Check.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Barrel_Food_Box_Box_Check.AutoSize = true;
            this.Barrel_Food_Box_Box_Check.Checked = true;
            this.Barrel_Food_Box_Box_Check.CheckState = System.Windows.Forms.CheckState.Checked;
            this.Barrel_Food_Box_Box_Check.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Barrel_Food_Box_Box_Check.Location = new System.Drawing.Point(199, 209);
            this.Barrel_Food_Box_Box_Check.Margin = new System.Windows.Forms.Padding(3, 3, 0, 0);
            this.Barrel_Food_Box_Box_Check.Name = "Barrel_Food_Box_Box_Check";
            this.Barrel_Food_Box_Box_Check.Size = new System.Drawing.Size(15, 14);
            this.Barrel_Food_Box_Box_Check.TabIndex = 86;
            this.Barrel_Food_Box_Box_Check.UseVisualStyleBackColor = true;
            this.Barrel_Food_Box_Box_Check.CheckedChanged += new System.EventHandler(this.Barrel_Food_Box_Box_Check_CheckedChanged);
            // 
            // Barrel_Tool_Crate_Box_Check
            // 
            this.Barrel_Tool_Crate_Box_Check.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Barrel_Tool_Crate_Box_Check.AutoSize = true;
            this.Barrel_Tool_Crate_Box_Check.Checked = true;
            this.Barrel_Tool_Crate_Box_Check.CheckState = System.Windows.Forms.CheckState.Checked;
            this.Barrel_Tool_Crate_Box_Check.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Barrel_Tool_Crate_Box_Check.Location = new System.Drawing.Point(199, 186);
            this.Barrel_Tool_Crate_Box_Check.Margin = new System.Windows.Forms.Padding(3, 3, 0, 0);
            this.Barrel_Tool_Crate_Box_Check.Name = "Barrel_Tool_Crate_Box_Check";
            this.Barrel_Tool_Crate_Box_Check.Size = new System.Drawing.Size(15, 14);
            this.Barrel_Tool_Crate_Box_Check.TabIndex = 87;
            this.Barrel_Tool_Crate_Box_Check.UseVisualStyleBackColor = true;
            this.Barrel_Tool_Crate_Box_Check.CheckedChanged += new System.EventHandler(this.Barrel_Tool_Crate_Box_Check_CheckedChanged);
            // 
            // Barrel_Food_Box_Radar_Color
            // 
            this.Barrel_Food_Box_Radar_Color.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Barrel_Food_Box_Radar_Color.Location = new System.Drawing.Point(225, 206);
            this.Barrel_Food_Box_Radar_Color.Name = "Barrel_Food_Box_Radar_Color";
            this.Barrel_Food_Box_Radar_Color.Size = new System.Drawing.Size(75, 17);
            this.Barrel_Food_Box_Radar_Color.TabIndex = 19;
            this.Barrel_Food_Box_Radar_Color.UseVisualStyleBackColor = false;
            this.Barrel_Food_Box_Radar_Color.Click += new System.EventHandler(this.Barrel_Food_Box_Color_Click);
            // 
            // Barrel_Food_Box_Radar_Check
            // 
            this.Barrel_Food_Box_Radar_Check.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Barrel_Food_Box_Radar_Check.AutoSize = true;
            this.Barrel_Food_Box_Radar_Check.Checked = true;
            this.Barrel_Food_Box_Radar_Check.CheckState = System.Windows.Forms.CheckState.Checked;
            this.Barrel_Food_Box_Radar_Check.Location = new System.Drawing.Point(108, 209);
            this.Barrel_Food_Box_Radar_Check.Margin = new System.Windows.Forms.Padding(3, 3, 0, 0);
            this.Barrel_Food_Box_Radar_Check.Name = "Barrel_Food_Box_Radar_Check";
            this.Barrel_Food_Box_Radar_Check.Size = new System.Drawing.Size(15, 14);
            this.Barrel_Food_Box_Radar_Check.TabIndex = 7;
            this.Barrel_Food_Box_Radar_Check.UseVisualStyleBackColor = true;
            this.Barrel_Food_Box_Radar_Check.CheckedChanged += new System.EventHandler(this.Barrel_Food_Box_Check_CheckedChanged);
            // 
            // Barrel_Oil_Barrel_Radar_Check
            // 
            this.Barrel_Oil_Barrel_Radar_Check.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Barrel_Oil_Barrel_Radar_Check.AutoSize = true;
            this.Barrel_Oil_Barrel_Radar_Check.Checked = true;
            this.Barrel_Oil_Barrel_Radar_Check.CheckState = System.Windows.Forms.CheckState.Checked;
            this.Barrel_Oil_Barrel_Radar_Check.Location = new System.Drawing.Point(108, 48);
            this.Barrel_Oil_Barrel_Radar_Check.Margin = new System.Windows.Forms.Padding(3, 3, 0, 0);
            this.Barrel_Oil_Barrel_Radar_Check.Name = "Barrel_Oil_Barrel_Radar_Check";
            this.Barrel_Oil_Barrel_Radar_Check.Size = new System.Drawing.Size(15, 14);
            this.Barrel_Oil_Barrel_Radar_Check.TabIndex = 8;
            this.Barrel_Oil_Barrel_Radar_Check.UseVisualStyleBackColor = true;
            this.Barrel_Oil_Barrel_Radar_Check.CheckedChanged += new System.EventHandler(this.Barrel_Oil_Barrel_Check_CheckedChanged);
            // 
            // Barrel_Tool_Crate_Tracer_Check
            // 
            this.Barrel_Tool_Crate_Tracer_Check.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Barrel_Tool_Crate_Tracer_Check.AutoSize = true;
            this.Barrel_Tool_Crate_Tracer_Check.Checked = true;
            this.Barrel_Tool_Crate_Tracer_Check.CheckState = System.Windows.Forms.CheckState.Checked;
            this.Barrel_Tool_Crate_Tracer_Check.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Barrel_Tool_Crate_Tracer_Check.Location = new System.Drawing.Point(157, 186);
            this.Barrel_Tool_Crate_Tracer_Check.Margin = new System.Windows.Forms.Padding(3, 3, 0, 0);
            this.Barrel_Tool_Crate_Tracer_Check.Name = "Barrel_Tool_Crate_Tracer_Check";
            this.Barrel_Tool_Crate_Tracer_Check.Size = new System.Drawing.Size(15, 14);
            this.Barrel_Tool_Crate_Tracer_Check.TabIndex = 84;
            this.Barrel_Tool_Crate_Tracer_Check.UseVisualStyleBackColor = true;
            this.Barrel_Tool_Crate_Tracer_Check.CheckedChanged += new System.EventHandler(this.Barrel_Tool_Crate_Tracer_Check_CheckedChanged);
            // 
            // Barrel_Tool_Crate_Radar_Check
            // 
            this.Barrel_Tool_Crate_Radar_Check.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Barrel_Tool_Crate_Radar_Check.AutoSize = true;
            this.Barrel_Tool_Crate_Radar_Check.Checked = true;
            this.Barrel_Tool_Crate_Radar_Check.CheckState = System.Windows.Forms.CheckState.Checked;
            this.Barrel_Tool_Crate_Radar_Check.Location = new System.Drawing.Point(108, 186);
            this.Barrel_Tool_Crate_Radar_Check.Margin = new System.Windows.Forms.Padding(3, 3, 0, 0);
            this.Barrel_Tool_Crate_Radar_Check.Name = "Barrel_Tool_Crate_Radar_Check";
            this.Barrel_Tool_Crate_Radar_Check.Size = new System.Drawing.Size(15, 14);
            this.Barrel_Tool_Crate_Radar_Check.TabIndex = 6;
            this.Barrel_Tool_Crate_Radar_Check.UseVisualStyleBackColor = true;
            this.Barrel_Tool_Crate_Radar_Check.CheckedChanged += new System.EventHandler(this.Barrel_Tool_Crate_Check_CheckedChanged);
            // 
            // Barrel_Tool_Crate_Radar_Color
            // 
            this.Barrel_Tool_Crate_Radar_Color.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Barrel_Tool_Crate_Radar_Color.Location = new System.Drawing.Point(225, 183);
            this.Barrel_Tool_Crate_Radar_Color.Name = "Barrel_Tool_Crate_Radar_Color";
            this.Barrel_Tool_Crate_Radar_Color.Size = new System.Drawing.Size(75, 17);
            this.Barrel_Tool_Crate_Radar_Color.TabIndex = 20;
            this.Barrel_Tool_Crate_Radar_Color.UseVisualStyleBackColor = false;
            this.Barrel_Tool_Crate_Radar_Color.Click += new System.EventHandler(this.Barrel_Tool_Crate_Color_Click);
            // 
            // Barrel_Med_Crate_Radar_Check
            // 
            this.Barrel_Med_Crate_Radar_Check.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Barrel_Med_Crate_Radar_Check.AutoSize = true;
            this.Barrel_Med_Crate_Radar_Check.Checked = true;
            this.Barrel_Med_Crate_Radar_Check.CheckState = System.Windows.Forms.CheckState.Checked;
            this.Barrel_Med_Crate_Radar_Check.Location = new System.Drawing.Point(108, 163);
            this.Barrel_Med_Crate_Radar_Check.Margin = new System.Windows.Forms.Padding(3, 3, 0, 0);
            this.Barrel_Med_Crate_Radar_Check.Name = "Barrel_Med_Crate_Radar_Check";
            this.Barrel_Med_Crate_Radar_Check.Size = new System.Drawing.Size(15, 14);
            this.Barrel_Med_Crate_Radar_Check.TabIndex = 5;
            this.Barrel_Med_Crate_Radar_Check.UseVisualStyleBackColor = true;
            this.Barrel_Med_Crate_Radar_Check.CheckedChanged += new System.EventHandler(this.Barrel_Med_Crate_Check_CheckedChanged);
            // 
            // Barrel_Food_Crate_Radar_Color
            // 
            this.Barrel_Food_Crate_Radar_Color.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Barrel_Food_Crate_Radar_Color.Location = new System.Drawing.Point(225, 137);
            this.Barrel_Food_Crate_Radar_Color.Name = "Barrel_Food_Crate_Radar_Color";
            this.Barrel_Food_Crate_Radar_Color.Size = new System.Drawing.Size(75, 17);
            this.Barrel_Food_Crate_Radar_Color.TabIndex = 21;
            this.Barrel_Food_Crate_Radar_Color.UseVisualStyleBackColor = false;
            this.Barrel_Food_Crate_Radar_Color.Click += new System.EventHandler(this.Barrel_Food_Crate_Color_Click);
            // 
            // Barrel_Food_Crate_Radar_Check
            // 
            this.Barrel_Food_Crate_Radar_Check.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Barrel_Food_Crate_Radar_Check.AutoSize = true;
            this.Barrel_Food_Crate_Radar_Check.Checked = true;
            this.Barrel_Food_Crate_Radar_Check.CheckState = System.Windows.Forms.CheckState.Checked;
            this.Barrel_Food_Crate_Radar_Check.Location = new System.Drawing.Point(108, 140);
            this.Barrel_Food_Crate_Radar_Check.Margin = new System.Windows.Forms.Padding(3, 3, 0, 0);
            this.Barrel_Food_Crate_Radar_Check.Name = "Barrel_Food_Crate_Radar_Check";
            this.Barrel_Food_Crate_Radar_Check.Size = new System.Drawing.Size(15, 14);
            this.Barrel_Food_Crate_Radar_Check.TabIndex = 4;
            this.Barrel_Food_Crate_Radar_Check.UseVisualStyleBackColor = true;
            this.Barrel_Food_Crate_Radar_Check.CheckedChanged += new System.EventHandler(this.Barrel_Food_Crate_Check_CheckedChanged);
            // 
            // Barrel_Mine_Crate_Radar_Color
            // 
            this.Barrel_Mine_Crate_Radar_Color.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Barrel_Mine_Crate_Radar_Color.Location = new System.Drawing.Point(225, 114);
            this.Barrel_Mine_Crate_Radar_Color.Name = "Barrel_Mine_Crate_Radar_Color";
            this.Barrel_Mine_Crate_Radar_Color.Size = new System.Drawing.Size(75, 17);
            this.Barrel_Mine_Crate_Radar_Color.TabIndex = 22;
            this.Barrel_Mine_Crate_Radar_Color.UseVisualStyleBackColor = false;
            this.Barrel_Mine_Crate_Radar_Color.Click += new System.EventHandler(this.Barrel_Mine_Crate_Color_Click);
            // 
            // Barrel_Mine_Crate_Radar_Check
            // 
            this.Barrel_Mine_Crate_Radar_Check.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Barrel_Mine_Crate_Radar_Check.AutoSize = true;
            this.Barrel_Mine_Crate_Radar_Check.Checked = true;
            this.Barrel_Mine_Crate_Radar_Check.CheckState = System.Windows.Forms.CheckState.Checked;
            this.Barrel_Mine_Crate_Radar_Check.Location = new System.Drawing.Point(108, 117);
            this.Barrel_Mine_Crate_Radar_Check.Margin = new System.Windows.Forms.Padding(3, 3, 0, 0);
            this.Barrel_Mine_Crate_Radar_Check.Name = "Barrel_Mine_Crate_Radar_Check";
            this.Barrel_Mine_Crate_Radar_Check.Size = new System.Drawing.Size(15, 14);
            this.Barrel_Mine_Crate_Radar_Check.TabIndex = 3;
            this.Barrel_Mine_Crate_Radar_Check.UseVisualStyleBackColor = true;
            this.Barrel_Mine_Crate_Radar_Check.CheckedChanged += new System.EventHandler(this.Barrel_Mine_Crate_Check_CheckedChanged);
            // 
            // Barrel_Med_Crate_Radar_Color
            // 
            this.Barrel_Med_Crate_Radar_Color.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Barrel_Med_Crate_Radar_Color.Location = new System.Drawing.Point(225, 160);
            this.Barrel_Med_Crate_Radar_Color.Name = "Barrel_Med_Crate_Radar_Color";
            this.Barrel_Med_Crate_Radar_Color.Size = new System.Drawing.Size(75, 17);
            this.Barrel_Med_Crate_Radar_Color.TabIndex = 18;
            this.Barrel_Med_Crate_Radar_Color.UseVisualStyleBackColor = false;
            this.Barrel_Med_Crate_Radar_Color.Click += new System.EventHandler(this.Barrel_Med_Crate_Color_Click);
            // 
            // Barrel_Crate_Radar_Check
            // 
            this.Barrel_Crate_Radar_Check.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Barrel_Crate_Radar_Check.AutoSize = true;
            this.Barrel_Crate_Radar_Check.Checked = true;
            this.Barrel_Crate_Radar_Check.CheckState = System.Windows.Forms.CheckState.Checked;
            this.Barrel_Crate_Radar_Check.Location = new System.Drawing.Point(108, 94);
            this.Barrel_Crate_Radar_Check.Margin = new System.Windows.Forms.Padding(3, 3, 0, 0);
            this.Barrel_Crate_Radar_Check.Name = "Barrel_Crate_Radar_Check";
            this.Barrel_Crate_Radar_Check.Size = new System.Drawing.Size(15, 14);
            this.Barrel_Crate_Radar_Check.TabIndex = 2;
            this.Barrel_Crate_Radar_Check.UseVisualStyleBackColor = true;
            this.Barrel_Crate_Radar_Check.CheckedChanged += new System.EventHandler(this.Barrel_Crate_Check_CheckedChanged);
            // 
            // Barrel_Crate_Radar_Color
            // 
            this.Barrel_Crate_Radar_Color.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Barrel_Crate_Radar_Color.Location = new System.Drawing.Point(225, 91);
            this.Barrel_Crate_Radar_Color.Name = "Barrel_Crate_Radar_Color";
            this.Barrel_Crate_Radar_Color.Size = new System.Drawing.Size(75, 17);
            this.Barrel_Crate_Radar_Color.TabIndex = 23;
            this.Barrel_Crate_Radar_Color.UseVisualStyleBackColor = false;
            this.Barrel_Crate_Radar_Color.Click += new System.EventHandler(this.Barrel_Crate_Color_Click);
            // 
            // Barrel_Trash_Pile_Radar_Check
            // 
            this.Barrel_Trash_Pile_Radar_Check.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Barrel_Trash_Pile_Radar_Check.AutoSize = true;
            this.Barrel_Trash_Pile_Radar_Check.Checked = true;
            this.Barrel_Trash_Pile_Radar_Check.CheckState = System.Windows.Forms.CheckState.Checked;
            this.Barrel_Trash_Pile_Radar_Check.Location = new System.Drawing.Point(108, 71);
            this.Barrel_Trash_Pile_Radar_Check.Margin = new System.Windows.Forms.Padding(3, 3, 0, 0);
            this.Barrel_Trash_Pile_Radar_Check.Name = "Barrel_Trash_Pile_Radar_Check";
            this.Barrel_Trash_Pile_Radar_Check.Size = new System.Drawing.Size(15, 14);
            this.Barrel_Trash_Pile_Radar_Check.TabIndex = 1;
            this.Barrel_Trash_Pile_Radar_Check.UseVisualStyleBackColor = true;
            this.Barrel_Trash_Pile_Radar_Check.CheckedChanged += new System.EventHandler(this.Barrel_Trash_Pile_Check_CheckedChanged);
            // 
            // Barrel_Trash_Pile_Radar_Color
            // 
            this.Barrel_Trash_Pile_Radar_Color.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Barrel_Trash_Pile_Radar_Color.Location = new System.Drawing.Point(225, 68);
            this.Barrel_Trash_Pile_Radar_Color.Name = "Barrel_Trash_Pile_Radar_Color";
            this.Barrel_Trash_Pile_Radar_Color.Size = new System.Drawing.Size(75, 17);
            this.Barrel_Trash_Pile_Radar_Color.TabIndex = 24;
            this.Barrel_Trash_Pile_Radar_Color.UseVisualStyleBackColor = false;
            this.Barrel_Trash_Pile_Radar_Color.Click += new System.EventHandler(this.Barrel_Trash_Pile_Color_Click);
            // 
            // Barrel_Oil_Barrel_Radar_Color
            // 
            this.Barrel_Oil_Barrel_Radar_Color.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Barrel_Oil_Barrel_Radar_Color.Location = new System.Drawing.Point(225, 45);
            this.Barrel_Oil_Barrel_Radar_Color.Name = "Barrel_Oil_Barrel_Radar_Color";
            this.Barrel_Oil_Barrel_Radar_Color.Size = new System.Drawing.Size(75, 17);
            this.Barrel_Oil_Barrel_Radar_Color.TabIndex = 25;
            this.Barrel_Oil_Barrel_Radar_Color.UseVisualStyleBackColor = false;
            this.Barrel_Oil_Barrel_Radar_Color.Click += new System.EventHandler(this.Barrel_Oil_Barrel_Color_Click);
            // 
            // Barrel_Loot_Barrel_Radar_Color
            // 
            this.Barrel_Loot_Barrel_Radar_Color.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Barrel_Loot_Barrel_Radar_Color.Location = new System.Drawing.Point(225, 22);
            this.Barrel_Loot_Barrel_Radar_Color.Name = "Barrel_Loot_Barrel_Radar_Color";
            this.Barrel_Loot_Barrel_Radar_Color.Size = new System.Drawing.Size(75, 17);
            this.Barrel_Loot_Barrel_Radar_Color.TabIndex = 26;
            this.Barrel_Loot_Barrel_Radar_Color.UseVisualStyleBackColor = false;
            this.Barrel_Loot_Barrel_Radar_Color.Click += new System.EventHandler(this.Barrel_Loot_Barrel_Color_Click);
            // 
            // Barrel_Loot_Barrel_Radar_Check
            // 
            this.Barrel_Loot_Barrel_Radar_Check.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Barrel_Loot_Barrel_Radar_Check.AutoSize = true;
            this.Barrel_Loot_Barrel_Radar_Check.Checked = true;
            this.Barrel_Loot_Barrel_Radar_Check.CheckState = System.Windows.Forms.CheckState.Checked;
            this.Barrel_Loot_Barrel_Radar_Check.Location = new System.Drawing.Point(108, 25);
            this.Barrel_Loot_Barrel_Radar_Check.Margin = new System.Windows.Forms.Padding(3, 3, 0, 0);
            this.Barrel_Loot_Barrel_Radar_Check.Name = "Barrel_Loot_Barrel_Radar_Check";
            this.Barrel_Loot_Barrel_Radar_Check.Size = new System.Drawing.Size(15, 14);
            this.Barrel_Loot_Barrel_Radar_Check.TabIndex = 0;
            this.Barrel_Loot_Barrel_Radar_Check.UseVisualStyleBackColor = true;
            this.Barrel_Loot_Barrel_Radar_Check.CheckedChanged += new System.EventHandler(this.Barrel_Loot_Barrel_Check_CheckedChanged);
            // 
            // Barrel_Oil_Barrel_Box_Color
            // 
            this.Barrel_Oil_Barrel_Box_Color.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Barrel_Oil_Barrel_Box_Color.Location = new System.Drawing.Point(387, 45);
            this.Barrel_Oil_Barrel_Box_Color.Name = "Barrel_Oil_Barrel_Box_Color";
            this.Barrel_Oil_Barrel_Box_Color.Size = new System.Drawing.Size(75, 17);
            this.Barrel_Oil_Barrel_Box_Color.TabIndex = 28;
            this.Barrel_Oil_Barrel_Box_Color.UseVisualStyleBackColor = false;
            this.Barrel_Oil_Barrel_Box_Color.Click += new System.EventHandler(this.Barrel_Oil_Barrel_Box_Color_Click);
            // 
            // Barrel_Loot_Barrel_Box_Color
            // 
            this.Barrel_Loot_Barrel_Box_Color.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Barrel_Loot_Barrel_Box_Color.Location = new System.Drawing.Point(387, 22);
            this.Barrel_Loot_Barrel_Box_Color.Name = "Barrel_Loot_Barrel_Box_Color";
            this.Barrel_Loot_Barrel_Box_Color.Size = new System.Drawing.Size(75, 17);
            this.Barrel_Loot_Barrel_Box_Color.TabIndex = 28;
            this.Barrel_Loot_Barrel_Box_Color.UseVisualStyleBackColor = false;
            this.Barrel_Loot_Barrel_Box_Color.Click += new System.EventHandler(this.Barrel_Loot_Barrel_Box_Color_Click);
            // 
            // label76
            // 
            this.label76.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label76.AutoSize = true;
            this.label76.Location = new System.Drawing.Point(387, 3);
            this.label76.Margin = new System.Windows.Forms.Padding(3);
            this.label76.Name = "label76";
            this.label76.Size = new System.Drawing.Size(75, 13);
            this.label76.TabIndex = 76;
            this.label76.Text = "Box";
            this.label76.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label77
            // 
            this.label77.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label77.AutoSize = true;
            this.label77.Location = new System.Drawing.Point(3, 22);
            this.label77.Margin = new System.Windows.Forms.Padding(3);
            this.label77.Name = "label77";
            this.label77.Size = new System.Drawing.Size(85, 17);
            this.label77.TabIndex = 46;
            this.label77.Text = "Loot Barrel";
            this.label77.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label78
            // 
            this.label78.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label78.AutoSize = true;
            this.label78.Location = new System.Drawing.Point(3, 45);
            this.label78.Margin = new System.Windows.Forms.Padding(3);
            this.label78.Name = "label78";
            this.label78.Size = new System.Drawing.Size(85, 17);
            this.label78.TabIndex = 44;
            this.label78.Text = "Oil Barrel";
            this.label78.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Barrel_Oil_Barrel_Box_Check
            // 
            this.Barrel_Oil_Barrel_Box_Check.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Barrel_Oil_Barrel_Box_Check.AutoSize = true;
            this.Barrel_Oil_Barrel_Box_Check.CheckAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.Barrel_Oil_Barrel_Box_Check.Checked = true;
            this.Barrel_Oil_Barrel_Box_Check.CheckState = System.Windows.Forms.CheckState.Checked;
            this.Barrel_Oil_Barrel_Box_Check.Location = new System.Drawing.Point(199, 48);
            this.Barrel_Oil_Barrel_Box_Check.Margin = new System.Windows.Forms.Padding(3, 3, 0, 0);
            this.Barrel_Oil_Barrel_Box_Check.Name = "Barrel_Oil_Barrel_Box_Check";
            this.Barrel_Oil_Barrel_Box_Check.Size = new System.Drawing.Size(15, 14);
            this.Barrel_Oil_Barrel_Box_Check.TabIndex = 32;
            this.Barrel_Oil_Barrel_Box_Check.UseVisualStyleBackColor = true;
            this.Barrel_Oil_Barrel_Box_Check.CheckedChanged += new System.EventHandler(this.Barrel_Oil_Barrel_Box_Check_CheckedChanged);
            // 
            // Barrel_Loot_Barrel_Box_Check
            // 
            this.Barrel_Loot_Barrel_Box_Check.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Barrel_Loot_Barrel_Box_Check.AutoSize = true;
            this.Barrel_Loot_Barrel_Box_Check.CheckAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.Barrel_Loot_Barrel_Box_Check.Checked = true;
            this.Barrel_Loot_Barrel_Box_Check.CheckState = System.Windows.Forms.CheckState.Checked;
            this.Barrel_Loot_Barrel_Box_Check.Location = new System.Drawing.Point(199, 25);
            this.Barrel_Loot_Barrel_Box_Check.Margin = new System.Windows.Forms.Padding(3, 3, 0, 0);
            this.Barrel_Loot_Barrel_Box_Check.Name = "Barrel_Loot_Barrel_Box_Check";
            this.Barrel_Loot_Barrel_Box_Check.Size = new System.Drawing.Size(15, 14);
            this.Barrel_Loot_Barrel_Box_Check.TabIndex = 34;
            this.Barrel_Loot_Barrel_Box_Check.UseVisualStyleBackColor = true;
            this.Barrel_Loot_Barrel_Box_Check.CheckedChanged += new System.EventHandler(this.Barrel_Loot_Barrel_Box_Check_CheckedChanged);
            // 
            // label79
            // 
            this.label79.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label79.AutoSize = true;
            this.label79.Location = new System.Drawing.Point(94, 3);
            this.label79.Margin = new System.Windows.Forms.Padding(3);
            this.label79.Name = "label79";
            this.label79.Size = new System.Drawing.Size(41, 13);
            this.label79.TabIndex = 76;
            this.label79.Text = "Radar";
            this.label79.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label80
            // 
            this.label80.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label80.AutoSize = true;
            this.label80.Location = new System.Drawing.Point(191, 3);
            this.label80.Margin = new System.Windows.Forms.Padding(3);
            this.label80.Name = "label80";
            this.label80.Size = new System.Drawing.Size(28, 13);
            this.label80.TabIndex = 77;
            this.label80.Text = "Box";
            this.label80.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label82
            // 
            this.label82.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label82.AutoSize = true;
            this.label82.Location = new System.Drawing.Point(141, 3);
            this.label82.Margin = new System.Windows.Forms.Padding(3);
            this.label82.Name = "label82";
            this.label82.Size = new System.Drawing.Size(44, 13);
            this.label82.TabIndex = 79;
            this.label82.Text = "Tracer";
            this.label82.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label83
            // 
            this.label83.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label83.AutoSize = true;
            this.label83.Location = new System.Drawing.Point(306, 3);
            this.label83.Margin = new System.Windows.Forms.Padding(3);
            this.label83.Name = "label83";
            this.label83.Size = new System.Drawing.Size(75, 13);
            this.label83.TabIndex = 80;
            this.label83.Text = "Tracer";
            this.label83.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Barrel_Loot_Barrel_Tracer_Color
            // 
            this.Barrel_Loot_Barrel_Tracer_Color.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Barrel_Loot_Barrel_Tracer_Color.Location = new System.Drawing.Point(306, 22);
            this.Barrel_Loot_Barrel_Tracer_Color.Name = "Barrel_Loot_Barrel_Tracer_Color";
            this.Barrel_Loot_Barrel_Tracer_Color.Size = new System.Drawing.Size(75, 17);
            this.Barrel_Loot_Barrel_Tracer_Color.TabIndex = 81;
            this.Barrel_Loot_Barrel_Tracer_Color.UseVisualStyleBackColor = false;
            this.Barrel_Loot_Barrel_Tracer_Color.Click += new System.EventHandler(this.Barrel_Loot_Barrel_Tracer_Color_Click);
            // 
            // Barrel_Oil_Barrel_Tracer_Color
            // 
            this.Barrel_Oil_Barrel_Tracer_Color.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Barrel_Oil_Barrel_Tracer_Color.Location = new System.Drawing.Point(306, 45);
            this.Barrel_Oil_Barrel_Tracer_Color.Name = "Barrel_Oil_Barrel_Tracer_Color";
            this.Barrel_Oil_Barrel_Tracer_Color.Size = new System.Drawing.Size(75, 17);
            this.Barrel_Oil_Barrel_Tracer_Color.TabIndex = 82;
            this.Barrel_Oil_Barrel_Tracer_Color.UseVisualStyleBackColor = false;
            this.Barrel_Oil_Barrel_Tracer_Color.Click += new System.EventHandler(this.Barrel_Oil_Barrel_Tracer_Color_Click);
            // 
            // Barrel_Loot_Barrel_Tracer_Check
            // 
            this.Barrel_Loot_Barrel_Tracer_Check.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Barrel_Loot_Barrel_Tracer_Check.AutoSize = true;
            this.Barrel_Loot_Barrel_Tracer_Check.Checked = true;
            this.Barrel_Loot_Barrel_Tracer_Check.CheckState = System.Windows.Forms.CheckState.Checked;
            this.Barrel_Loot_Barrel_Tracer_Check.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Barrel_Loot_Barrel_Tracer_Check.Location = new System.Drawing.Point(157, 25);
            this.Barrel_Loot_Barrel_Tracer_Check.Margin = new System.Windows.Forms.Padding(3, 3, 0, 0);
            this.Barrel_Loot_Barrel_Tracer_Check.Name = "Barrel_Loot_Barrel_Tracer_Check";
            this.Barrel_Loot_Barrel_Tracer_Check.Size = new System.Drawing.Size(15, 14);
            this.Barrel_Loot_Barrel_Tracer_Check.TabIndex = 83;
            this.Barrel_Loot_Barrel_Tracer_Check.UseVisualStyleBackColor = true;
            this.Barrel_Loot_Barrel_Tracer_Check.CheckedChanged += new System.EventHandler(this.Barrel_Loot_Barrel_Tracer_Check_CheckedChanged);
            // 
            // Barrel_Oil_Barrel_Tracer_Check
            // 
            this.Barrel_Oil_Barrel_Tracer_Check.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Barrel_Oil_Barrel_Tracer_Check.AutoSize = true;
            this.Barrel_Oil_Barrel_Tracer_Check.Checked = true;
            this.Barrel_Oil_Barrel_Tracer_Check.CheckState = System.Windows.Forms.CheckState.Checked;
            this.Barrel_Oil_Barrel_Tracer_Check.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Barrel_Oil_Barrel_Tracer_Check.Location = new System.Drawing.Point(157, 48);
            this.Barrel_Oil_Barrel_Tracer_Check.Margin = new System.Windows.Forms.Padding(3, 3, 0, 0);
            this.Barrel_Oil_Barrel_Tracer_Check.Name = "Barrel_Oil_Barrel_Tracer_Check";
            this.Barrel_Oil_Barrel_Tracer_Check.Size = new System.Drawing.Size(15, 14);
            this.Barrel_Oil_Barrel_Tracer_Check.TabIndex = 84;
            this.Barrel_Oil_Barrel_Tracer_Check.UseVisualStyleBackColor = true;
            this.Barrel_Oil_Barrel_Tracer_Check.CheckedChanged += new System.EventHandler(this.Barrel_Oil_Barrel_Tracer_Check_CheckedChanged);
            // 
            // label84
            // 
            this.label84.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label84.AutoSize = true;
            this.label84.Location = new System.Drawing.Point(3, 68);
            this.label84.Margin = new System.Windows.Forms.Padding(3);
            this.label84.Name = "label84";
            this.label84.Size = new System.Drawing.Size(85, 17);
            this.label84.TabIndex = 85;
            this.label84.Text = "Trash Pile";
            this.label84.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label85
            // 
            this.label85.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label85.AutoSize = true;
            this.label85.Location = new System.Drawing.Point(3, 91);
            this.label85.Margin = new System.Windows.Forms.Padding(3);
            this.label85.Name = "label85";
            this.label85.Size = new System.Drawing.Size(85, 17);
            this.label85.TabIndex = 47;
            this.label85.Text = "Crate";
            this.label85.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label86
            // 
            this.label86.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label86.AutoSize = true;
            this.label86.Location = new System.Drawing.Point(3, 114);
            this.label86.Margin = new System.Windows.Forms.Padding(3);
            this.label86.Name = "label86";
            this.label86.Size = new System.Drawing.Size(85, 17);
            this.label86.TabIndex = 47;
            this.label86.Text = "Mine Crate";
            this.label86.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label87
            // 
            this.label87.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label87.AutoSize = true;
            this.label87.Location = new System.Drawing.Point(3, 137);
            this.label87.Margin = new System.Windows.Forms.Padding(3);
            this.label87.Name = "label87";
            this.label87.Size = new System.Drawing.Size(85, 17);
            this.label87.TabIndex = 47;
            this.label87.Text = "Food Crate";
            this.label87.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label88
            // 
            this.label88.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label88.AutoSize = true;
            this.label88.Location = new System.Drawing.Point(3, 160);
            this.label88.Margin = new System.Windows.Forms.Padding(3);
            this.label88.Name = "label88";
            this.label88.Size = new System.Drawing.Size(85, 17);
            this.label88.TabIndex = 95;
            this.label88.Text = "Medical Crate";
            this.label88.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Barrel_Trash_Pile_Tracer_Check
            // 
            this.Barrel_Trash_Pile_Tracer_Check.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Barrel_Trash_Pile_Tracer_Check.AutoSize = true;
            this.Barrel_Trash_Pile_Tracer_Check.Checked = true;
            this.Barrel_Trash_Pile_Tracer_Check.CheckState = System.Windows.Forms.CheckState.Checked;
            this.Barrel_Trash_Pile_Tracer_Check.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Barrel_Trash_Pile_Tracer_Check.Location = new System.Drawing.Point(157, 71);
            this.Barrel_Trash_Pile_Tracer_Check.Margin = new System.Windows.Forms.Padding(3, 3, 0, 0);
            this.Barrel_Trash_Pile_Tracer_Check.Name = "Barrel_Trash_Pile_Tracer_Check";
            this.Barrel_Trash_Pile_Tracer_Check.Size = new System.Drawing.Size(15, 14);
            this.Barrel_Trash_Pile_Tracer_Check.TabIndex = 88;
            this.Barrel_Trash_Pile_Tracer_Check.UseVisualStyleBackColor = true;
            this.Barrel_Trash_Pile_Tracer_Check.CheckedChanged += new System.EventHandler(this.Barrel_Trash_Pile_Tracer_Check_CheckedChanged);
            // 
            // Barrel_Trash_Pile_Box_Check
            // 
            this.Barrel_Trash_Pile_Box_Check.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Barrel_Trash_Pile_Box_Check.AutoSize = true;
            this.Barrel_Trash_Pile_Box_Check.Checked = true;
            this.Barrel_Trash_Pile_Box_Check.CheckState = System.Windows.Forms.CheckState.Checked;
            this.Barrel_Trash_Pile_Box_Check.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Barrel_Trash_Pile_Box_Check.Location = new System.Drawing.Point(199, 71);
            this.Barrel_Trash_Pile_Box_Check.Margin = new System.Windows.Forms.Padding(3, 3, 0, 0);
            this.Barrel_Trash_Pile_Box_Check.Name = "Barrel_Trash_Pile_Box_Check";
            this.Barrel_Trash_Pile_Box_Check.Size = new System.Drawing.Size(15, 14);
            this.Barrel_Trash_Pile_Box_Check.TabIndex = 86;
            this.Barrel_Trash_Pile_Box_Check.UseVisualStyleBackColor = true;
            this.Barrel_Trash_Pile_Box_Check.CheckedChanged += new System.EventHandler(this.Barrel_Trash_Pile_Box_Check_CheckedChanged);
            // 
            // Barrel_Crate_Box_Check
            // 
            this.Barrel_Crate_Box_Check.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Barrel_Crate_Box_Check.AutoSize = true;
            this.Barrel_Crate_Box_Check.Checked = true;
            this.Barrel_Crate_Box_Check.CheckState = System.Windows.Forms.CheckState.Checked;
            this.Barrel_Crate_Box_Check.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Barrel_Crate_Box_Check.Location = new System.Drawing.Point(199, 94);
            this.Barrel_Crate_Box_Check.Margin = new System.Windows.Forms.Padding(3, 3, 0, 0);
            this.Barrel_Crate_Box_Check.Name = "Barrel_Crate_Box_Check";
            this.Barrel_Crate_Box_Check.Size = new System.Drawing.Size(15, 14);
            this.Barrel_Crate_Box_Check.TabIndex = 89;
            this.Barrel_Crate_Box_Check.UseVisualStyleBackColor = true;
            this.Barrel_Crate_Box_Check.CheckedChanged += new System.EventHandler(this.Barrel_Crate_Box_Check_CheckedChanged);
            // 
            // Barrel_Crate_Tracer_Check
            // 
            this.Barrel_Crate_Tracer_Check.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Barrel_Crate_Tracer_Check.AutoSize = true;
            this.Barrel_Crate_Tracer_Check.Checked = true;
            this.Barrel_Crate_Tracer_Check.CheckState = System.Windows.Forms.CheckState.Checked;
            this.Barrel_Crate_Tracer_Check.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Barrel_Crate_Tracer_Check.Location = new System.Drawing.Point(157, 94);
            this.Barrel_Crate_Tracer_Check.Margin = new System.Windows.Forms.Padding(3, 3, 0, 0);
            this.Barrel_Crate_Tracer_Check.Name = "Barrel_Crate_Tracer_Check";
            this.Barrel_Crate_Tracer_Check.Size = new System.Drawing.Size(15, 14);
            this.Barrel_Crate_Tracer_Check.TabIndex = 93;
            this.Barrel_Crate_Tracer_Check.UseVisualStyleBackColor = true;
            this.Barrel_Crate_Tracer_Check.CheckedChanged += new System.EventHandler(this.Barrel_Crate_Tracer_Check_CheckedChanged);
            // 
            // Barrel_Mine_Crate_Tracer_Check
            // 
            this.Barrel_Mine_Crate_Tracer_Check.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Barrel_Mine_Crate_Tracer_Check.AutoSize = true;
            this.Barrel_Mine_Crate_Tracer_Check.Checked = true;
            this.Barrel_Mine_Crate_Tracer_Check.CheckState = System.Windows.Forms.CheckState.Checked;
            this.Barrel_Mine_Crate_Tracer_Check.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Barrel_Mine_Crate_Tracer_Check.Location = new System.Drawing.Point(157, 117);
            this.Barrel_Mine_Crate_Tracer_Check.Margin = new System.Windows.Forms.Padding(3, 3, 0, 0);
            this.Barrel_Mine_Crate_Tracer_Check.Name = "Barrel_Mine_Crate_Tracer_Check";
            this.Barrel_Mine_Crate_Tracer_Check.Size = new System.Drawing.Size(15, 14);
            this.Barrel_Mine_Crate_Tracer_Check.TabIndex = 92;
            this.Barrel_Mine_Crate_Tracer_Check.UseVisualStyleBackColor = true;
            this.Barrel_Mine_Crate_Tracer_Check.CheckedChanged += new System.EventHandler(this.Barrel_Mine_Crate_Tracer_Check_CheckedChanged);
            // 
            // Barrel_Mine_Crate_Box_Check
            // 
            this.Barrel_Mine_Crate_Box_Check.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Barrel_Mine_Crate_Box_Check.AutoSize = true;
            this.Barrel_Mine_Crate_Box_Check.Checked = true;
            this.Barrel_Mine_Crate_Box_Check.CheckState = System.Windows.Forms.CheckState.Checked;
            this.Barrel_Mine_Crate_Box_Check.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Barrel_Mine_Crate_Box_Check.Location = new System.Drawing.Point(199, 117);
            this.Barrel_Mine_Crate_Box_Check.Margin = new System.Windows.Forms.Padding(3, 3, 0, 0);
            this.Barrel_Mine_Crate_Box_Check.Name = "Barrel_Mine_Crate_Box_Check";
            this.Barrel_Mine_Crate_Box_Check.Size = new System.Drawing.Size(15, 14);
            this.Barrel_Mine_Crate_Box_Check.TabIndex = 91;
            this.Barrel_Mine_Crate_Box_Check.UseVisualStyleBackColor = true;
            this.Barrel_Mine_Crate_Box_Check.CheckedChanged += new System.EventHandler(this.Barrel_Mine_Crate_Box_Check_CheckedChanged);
            // 
            // Barrel_Food_Crate_Tracer_Check
            // 
            this.Barrel_Food_Crate_Tracer_Check.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Barrel_Food_Crate_Tracer_Check.AutoSize = true;
            this.Barrel_Food_Crate_Tracer_Check.Checked = true;
            this.Barrel_Food_Crate_Tracer_Check.CheckState = System.Windows.Forms.CheckState.Checked;
            this.Barrel_Food_Crate_Tracer_Check.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Barrel_Food_Crate_Tracer_Check.Location = new System.Drawing.Point(157, 140);
            this.Barrel_Food_Crate_Tracer_Check.Margin = new System.Windows.Forms.Padding(3, 3, 0, 0);
            this.Barrel_Food_Crate_Tracer_Check.Name = "Barrel_Food_Crate_Tracer_Check";
            this.Barrel_Food_Crate_Tracer_Check.Size = new System.Drawing.Size(15, 14);
            this.Barrel_Food_Crate_Tracer_Check.TabIndex = 94;
            this.Barrel_Food_Crate_Tracer_Check.UseVisualStyleBackColor = true;
            this.Barrel_Food_Crate_Tracer_Check.CheckedChanged += new System.EventHandler(this.Barrel_Food_Crate_Tracer_Check_CheckedChanged);
            // 
            // Barrel_Food_Crate_Box_Check
            // 
            this.Barrel_Food_Crate_Box_Check.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Barrel_Food_Crate_Box_Check.AutoSize = true;
            this.Barrel_Food_Crate_Box_Check.Checked = true;
            this.Barrel_Food_Crate_Box_Check.CheckState = System.Windows.Forms.CheckState.Checked;
            this.Barrel_Food_Crate_Box_Check.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Barrel_Food_Crate_Box_Check.Location = new System.Drawing.Point(199, 140);
            this.Barrel_Food_Crate_Box_Check.Margin = new System.Windows.Forms.Padding(3, 3, 0, 0);
            this.Barrel_Food_Crate_Box_Check.Name = "Barrel_Food_Crate_Box_Check";
            this.Barrel_Food_Crate_Box_Check.Size = new System.Drawing.Size(15, 14);
            this.Barrel_Food_Crate_Box_Check.TabIndex = 90;
            this.Barrel_Food_Crate_Box_Check.UseVisualStyleBackColor = true;
            this.Barrel_Food_Crate_Box_Check.CheckedChanged += new System.EventHandler(this.Barrel_Food_Crate_Box_Check_CheckedChanged);
            // 
            // Barrel_Med_Crate_Tracer_Check
            // 
            this.Barrel_Med_Crate_Tracer_Check.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Barrel_Med_Crate_Tracer_Check.AutoSize = true;
            this.Barrel_Med_Crate_Tracer_Check.Checked = true;
            this.Barrel_Med_Crate_Tracer_Check.CheckState = System.Windows.Forms.CheckState.Checked;
            this.Barrel_Med_Crate_Tracer_Check.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Barrel_Med_Crate_Tracer_Check.Location = new System.Drawing.Point(157, 163);
            this.Barrel_Med_Crate_Tracer_Check.Margin = new System.Windows.Forms.Padding(3, 3, 0, 0);
            this.Barrel_Med_Crate_Tracer_Check.Name = "Barrel_Med_Crate_Tracer_Check";
            this.Barrel_Med_Crate_Tracer_Check.Size = new System.Drawing.Size(15, 14);
            this.Barrel_Med_Crate_Tracer_Check.TabIndex = 97;
            this.Barrel_Med_Crate_Tracer_Check.UseVisualStyleBackColor = true;
            this.Barrel_Med_Crate_Tracer_Check.CheckedChanged += new System.EventHandler(this.Barrel_Med_Crate_Tracer_Check_CheckedChanged);
            // 
            // Barrel_Med_Crate_Box_Check
            // 
            this.Barrel_Med_Crate_Box_Check.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Barrel_Med_Crate_Box_Check.AutoSize = true;
            this.Barrel_Med_Crate_Box_Check.Checked = true;
            this.Barrel_Med_Crate_Box_Check.CheckState = System.Windows.Forms.CheckState.Checked;
            this.Barrel_Med_Crate_Box_Check.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Barrel_Med_Crate_Box_Check.Location = new System.Drawing.Point(199, 163);
            this.Barrel_Med_Crate_Box_Check.Margin = new System.Windows.Forms.Padding(3, 3, 0, 0);
            this.Barrel_Med_Crate_Box_Check.Name = "Barrel_Med_Crate_Box_Check";
            this.Barrel_Med_Crate_Box_Check.Size = new System.Drawing.Size(15, 14);
            this.Barrel_Med_Crate_Box_Check.TabIndex = 96;
            this.Barrel_Med_Crate_Box_Check.UseVisualStyleBackColor = true;
            this.Barrel_Med_Crate_Box_Check.CheckedChanged += new System.EventHandler(this.Barrel_Med_Crate_Box_Check_CheckedChanged);
            // 
            // Barrel_Trash_Pile_Tracer_Color
            // 
            this.Barrel_Trash_Pile_Tracer_Color.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Barrel_Trash_Pile_Tracer_Color.Location = new System.Drawing.Point(306, 68);
            this.Barrel_Trash_Pile_Tracer_Color.Name = "Barrel_Trash_Pile_Tracer_Color";
            this.Barrel_Trash_Pile_Tracer_Color.Size = new System.Drawing.Size(75, 17);
            this.Barrel_Trash_Pile_Tracer_Color.TabIndex = 89;
            this.Barrel_Trash_Pile_Tracer_Color.UseVisualStyleBackColor = false;
            this.Barrel_Trash_Pile_Tracer_Color.Click += new System.EventHandler(this.Barrel_Trash_Pile_Tracer_Color_Click);
            // 
            // Barrel_Trash_Pile_Box_Color
            // 
            this.Barrel_Trash_Pile_Box_Color.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Barrel_Trash_Pile_Box_Color.Location = new System.Drawing.Point(387, 68);
            this.Barrel_Trash_Pile_Box_Color.Name = "Barrel_Trash_Pile_Box_Color";
            this.Barrel_Trash_Pile_Box_Color.Size = new System.Drawing.Size(75, 17);
            this.Barrel_Trash_Pile_Box_Color.TabIndex = 91;
            this.Barrel_Trash_Pile_Box_Color.UseVisualStyleBackColor = false;
            this.Barrel_Trash_Pile_Box_Color.Click += new System.EventHandler(this.Barrel_Trash_Pile_Box_Color_Click);
            // 
            // Barrel_Crate_Box_Color
            // 
            this.Barrel_Crate_Box_Color.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Barrel_Crate_Box_Color.Location = new System.Drawing.Point(387, 91);
            this.Barrel_Crate_Box_Color.Name = "Barrel_Crate_Box_Color";
            this.Barrel_Crate_Box_Color.Size = new System.Drawing.Size(75, 17);
            this.Barrel_Crate_Box_Color.TabIndex = 30;
            this.Barrel_Crate_Box_Color.UseVisualStyleBackColor = false;
            this.Barrel_Crate_Box_Color.Click += new System.EventHandler(this.Barrel_Crate_Box_Color_Click);
            // 
            // Barrel_Crate_Tracer_Color
            // 
            this.Barrel_Crate_Tracer_Color.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Barrel_Crate_Tracer_Color.Location = new System.Drawing.Point(306, 91);
            this.Barrel_Crate_Tracer_Color.Name = "Barrel_Crate_Tracer_Color";
            this.Barrel_Crate_Tracer_Color.Size = new System.Drawing.Size(75, 17);
            this.Barrel_Crate_Tracer_Color.TabIndex = 91;
            this.Barrel_Crate_Tracer_Color.UseVisualStyleBackColor = false;
            this.Barrel_Crate_Tracer_Color.Click += new System.EventHandler(this.Barrel_Crate_Tracer_Color_Click);
            // 
            // Barrel_Mine_Crate_Tracer_Color
            // 
            this.Barrel_Mine_Crate_Tracer_Color.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Barrel_Mine_Crate_Tracer_Color.Location = new System.Drawing.Point(306, 114);
            this.Barrel_Mine_Crate_Tracer_Color.Name = "Barrel_Mine_Crate_Tracer_Color";
            this.Barrel_Mine_Crate_Tracer_Color.Size = new System.Drawing.Size(75, 17);
            this.Barrel_Mine_Crate_Tracer_Color.TabIndex = 91;
            this.Barrel_Mine_Crate_Tracer_Color.UseVisualStyleBackColor = false;
            this.Barrel_Mine_Crate_Tracer_Color.Click += new System.EventHandler(this.Barrel_Mine_Crate_Tracer_Color_Click);
            // 
            // Barrel_Food_Crate_Tracer_Color
            // 
            this.Barrel_Food_Crate_Tracer_Color.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Barrel_Food_Crate_Tracer_Color.Location = new System.Drawing.Point(306, 137);
            this.Barrel_Food_Crate_Tracer_Color.Name = "Barrel_Food_Crate_Tracer_Color";
            this.Barrel_Food_Crate_Tracer_Color.Size = new System.Drawing.Size(75, 17);
            this.Barrel_Food_Crate_Tracer_Color.TabIndex = 31;
            this.Barrel_Food_Crate_Tracer_Color.UseVisualStyleBackColor = false;
            this.Barrel_Food_Crate_Tracer_Color.Click += new System.EventHandler(this.Barrel_Food_Crate_Tracer_Color_Click);
            // 
            // Barrel_Mine_Crate_Box_Color
            // 
            this.Barrel_Mine_Crate_Box_Color.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Barrel_Mine_Crate_Box_Color.Location = new System.Drawing.Point(387, 114);
            this.Barrel_Mine_Crate_Box_Color.Name = "Barrel_Mine_Crate_Box_Color";
            this.Barrel_Mine_Crate_Box_Color.Size = new System.Drawing.Size(75, 17);
            this.Barrel_Mine_Crate_Box_Color.TabIndex = 32;
            this.Barrel_Mine_Crate_Box_Color.UseVisualStyleBackColor = false;
            this.Barrel_Mine_Crate_Box_Color.Click += new System.EventHandler(this.Barrel_Mine_Crate_Box_Color_Click);
            // 
            // Barrel_Food_Crate_Box_Color
            // 
            this.Barrel_Food_Crate_Box_Color.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Barrel_Food_Crate_Box_Color.Location = new System.Drawing.Point(387, 137);
            this.Barrel_Food_Crate_Box_Color.Name = "Barrel_Food_Crate_Box_Color";
            this.Barrel_Food_Crate_Box_Color.Size = new System.Drawing.Size(75, 17);
            this.Barrel_Food_Crate_Box_Color.TabIndex = 30;
            this.Barrel_Food_Crate_Box_Color.UseVisualStyleBackColor = false;
            this.Barrel_Food_Crate_Box_Color.Click += new System.EventHandler(this.Barrel_Food_Crate_Box_Color_Click);
            // 
            // Barrel_Med_Crate_Tracer_Color
            // 
            this.Barrel_Med_Crate_Tracer_Color.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Barrel_Med_Crate_Tracer_Color.Location = new System.Drawing.Point(306, 160);
            this.Barrel_Med_Crate_Tracer_Color.Name = "Barrel_Med_Crate_Tracer_Color";
            this.Barrel_Med_Crate_Tracer_Color.Size = new System.Drawing.Size(75, 17);
            this.Barrel_Med_Crate_Tracer_Color.TabIndex = 33;
            this.Barrel_Med_Crate_Tracer_Color.UseVisualStyleBackColor = false;
            this.Barrel_Med_Crate_Tracer_Color.Click += new System.EventHandler(this.Barrel_Med_Crate_Tracer_Color_Click);
            // 
            // Barrel_Med_Crate_Box_Color
            // 
            this.Barrel_Med_Crate_Box_Color.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Barrel_Med_Crate_Box_Color.Location = new System.Drawing.Point(387, 160);
            this.Barrel_Med_Crate_Box_Color.Name = "Barrel_Med_Crate_Box_Color";
            this.Barrel_Med_Crate_Box_Color.Size = new System.Drawing.Size(75, 17);
            this.Barrel_Med_Crate_Box_Color.TabIndex = 32;
            this.Barrel_Med_Crate_Box_Color.UseVisualStyleBackColor = false;
            this.Barrel_Med_Crate_Box_Color.Click += new System.EventHandler(this.Barrel_Med_Crate_Box_Color_Click);
            // 
            // label81
            // 
            this.label81.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label81.AutoSize = true;
            this.label81.Location = new System.Drawing.Point(225, 3);
            this.label81.Margin = new System.Windows.Forms.Padding(3);
            this.label81.Name = "label81";
            this.label81.Size = new System.Drawing.Size(75, 13);
            this.label81.TabIndex = 78;
            this.label81.Text = "Radar";
            this.label81.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label89
            // 
            this.label89.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label89.AutoSize = true;
            this.label89.Location = new System.Drawing.Point(3, 183);
            this.label89.Margin = new System.Windows.Forms.Padding(3);
            this.label89.Name = "label89";
            this.label89.Size = new System.Drawing.Size(85, 17);
            this.label89.TabIndex = 98;
            this.label89.Text = "Tool Crate";
            this.label89.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Misc_TAB
            // 
            this.Misc_TAB.BackColor = System.Drawing.Color.White;
            this.Misc_TAB.Controls.Add(this.tableLayoutPanel3);
            this.Misc_TAB.Location = new System.Drawing.Point(4, 22);
            this.Misc_TAB.Name = "Misc_TAB";
            this.Misc_TAB.Padding = new System.Windows.Forms.Padding(3);
            this.Misc_TAB.Size = new System.Drawing.Size(568, 552);
            this.Misc_TAB.TabIndex = 5;
            this.Misc_TAB.Text = "Misc";
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.ColumnCount = 8;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 35F));
            this.tableLayoutPanel3.Controls.Add(this.label18, 0, 6);
            this.tableLayoutPanel3.Controls.Add(this.Misc_Supply_Drop_Radar_Color, 4, 2);
            this.tableLayoutPanel3.Controls.Add(this.Misc_Supply_Drop_Radar_Check, 1, 2);
            this.tableLayoutPanel3.Controls.Add(this.Misc_Corpse_Radar_Color, 4, 1);
            this.tableLayoutPanel3.Controls.Add(this.Misc_Supply_Drop_Box_Color, 6, 2);
            this.tableLayoutPanel3.Controls.Add(this.Misc_Corpse_Box_Color, 6, 1);
            this.tableLayoutPanel3.Controls.Add(this.label15, 6, 0);
            this.tableLayoutPanel3.Controls.Add(this.label16, 0, 1);
            this.tableLayoutPanel3.Controls.Add(this.label17, 0, 2);
            this.tableLayoutPanel3.Controls.Add(this.Misc_Supply_Drop_Box_Check, 3, 2);
            this.tableLayoutPanel3.Controls.Add(this.Misc_Corpse_Box_Check, 3, 1);
            this.tableLayoutPanel3.Controls.Add(this.label19, 1, 0);
            this.tableLayoutPanel3.Controls.Add(this.label20, 3, 0);
            this.tableLayoutPanel3.Controls.Add(this.label21, 4, 0);
            this.tableLayoutPanel3.Controls.Add(this.Misc_Corpse_Radar_Check, 1, 1);
            this.tableLayoutPanel3.Controls.Add(this.label13, 2, 0);
            this.tableLayoutPanel3.Controls.Add(this.label14, 5, 0);
            this.tableLayoutPanel3.Controls.Add(this.Misc_Corpse_Tracer_Color, 5, 1);
            this.tableLayoutPanel3.Controls.Add(this.Misc_Supply_Drop_Tracer_Color, 5, 2);
            this.tableLayoutPanel3.Controls.Add(this.Misc_Corpse_Tracer_Check, 2, 1);
            this.tableLayoutPanel3.Controls.Add(this.Misc_Supply_Drop_Tracer_Check, 2, 2);
            this.tableLayoutPanel3.Controls.Add(this.Misc_Helicopter_Radar_Check, 1, 6);
            this.tableLayoutPanel3.Controls.Add(this.Misc_Helicopter_Tracer_Check, 2, 6);
            this.tableLayoutPanel3.Controls.Add(this.Misc_Helicopter_Box_Check, 3, 6);
            this.tableLayoutPanel3.Controls.Add(this.Misc_Helicopter_Radar_Color, 4, 6);
            this.tableLayoutPanel3.Controls.Add(this.Misc_Helicopter_Tracer_Color, 5, 6);
            this.tableLayoutPanel3.Controls.Add(this.Misc_Helicopter_Box_Color, 6, 6);
            this.tableLayoutPanel3.Location = new System.Drawing.Point(6, 6);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 8;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(497, 192);
            this.tableLayoutPanel3.TabIndex = 28;
            // 
            // label18
            // 
            this.label18.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(3, 68);
            this.label18.Margin = new System.Windows.Forms.Padding(3);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(82, 17);
            this.label18.TabIndex = 85;
            this.label18.Text = "Helicopter";
            this.label18.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Misc_Supply_Drop_Radar_Color
            // 
            this.Misc_Supply_Drop_Radar_Color.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Misc_Supply_Drop_Radar_Color.Location = new System.Drawing.Point(222, 45);
            this.Misc_Supply_Drop_Radar_Color.Name = "Misc_Supply_Drop_Radar_Color";
            this.Misc_Supply_Drop_Radar_Color.Size = new System.Drawing.Size(75, 17);
            this.Misc_Supply_Drop_Radar_Color.TabIndex = 32;
            this.Misc_Supply_Drop_Radar_Color.UseVisualStyleBackColor = false;
            this.Misc_Supply_Drop_Radar_Color.Click += new System.EventHandler(this.Misc_Supply_Drop_Radar_Color_Click);
            // 
            // Misc_Supply_Drop_Radar_Check
            // 
            this.Misc_Supply_Drop_Radar_Check.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Misc_Supply_Drop_Radar_Check.AutoSize = true;
            this.Misc_Supply_Drop_Radar_Check.Checked = true;
            this.Misc_Supply_Drop_Radar_Check.CheckState = System.Windows.Forms.CheckState.Checked;
            this.Misc_Supply_Drop_Radar_Check.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Misc_Supply_Drop_Radar_Check.Location = new System.Drawing.Point(105, 48);
            this.Misc_Supply_Drop_Radar_Check.Margin = new System.Windows.Forms.Padding(3, 3, 0, 0);
            this.Misc_Supply_Drop_Radar_Check.Name = "Misc_Supply_Drop_Radar_Check";
            this.Misc_Supply_Drop_Radar_Check.Size = new System.Drawing.Size(15, 14);
            this.Misc_Supply_Drop_Radar_Check.TabIndex = 31;
            this.Misc_Supply_Drop_Radar_Check.UseVisualStyleBackColor = true;
            this.Misc_Supply_Drop_Radar_Check.CheckedChanged += new System.EventHandler(this.Misc_Supply_Drop_Radar_Check_CheckedChanged);
            // 
            // Misc_Corpse_Radar_Color
            // 
            this.Misc_Corpse_Radar_Color.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Misc_Corpse_Radar_Color.Location = new System.Drawing.Point(222, 22);
            this.Misc_Corpse_Radar_Color.Name = "Misc_Corpse_Radar_Color";
            this.Misc_Corpse_Radar_Color.Size = new System.Drawing.Size(75, 17);
            this.Misc_Corpse_Radar_Color.TabIndex = 30;
            this.Misc_Corpse_Radar_Color.UseVisualStyleBackColor = false;
            this.Misc_Corpse_Radar_Color.Click += new System.EventHandler(this.Misc_Corpse_Radar_Color_Click);
            // 
            // Misc_Supply_Drop_Box_Color
            // 
            this.Misc_Supply_Drop_Box_Color.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Misc_Supply_Drop_Box_Color.Location = new System.Drawing.Point(384, 45);
            this.Misc_Supply_Drop_Box_Color.Name = "Misc_Supply_Drop_Box_Color";
            this.Misc_Supply_Drop_Box_Color.Size = new System.Drawing.Size(75, 17);
            this.Misc_Supply_Drop_Box_Color.TabIndex = 28;
            this.Misc_Supply_Drop_Box_Color.UseVisualStyleBackColor = false;
            this.Misc_Supply_Drop_Box_Color.Click += new System.EventHandler(this.Misc_Supply_Drop_Box_Color_Click);
            // 
            // Misc_Corpse_Box_Color
            // 
            this.Misc_Corpse_Box_Color.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Misc_Corpse_Box_Color.Location = new System.Drawing.Point(384, 22);
            this.Misc_Corpse_Box_Color.Name = "Misc_Corpse_Box_Color";
            this.Misc_Corpse_Box_Color.Size = new System.Drawing.Size(75, 17);
            this.Misc_Corpse_Box_Color.TabIndex = 28;
            this.Misc_Corpse_Box_Color.UseVisualStyleBackColor = false;
            this.Misc_Corpse_Box_Color.Click += new System.EventHandler(this.Misc_Corpse_Box_Color_Click);
            // 
            // label15
            // 
            this.label15.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(384, 3);
            this.label15.Margin = new System.Windows.Forms.Padding(3);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(75, 13);
            this.label15.TabIndex = 76;
            this.label15.Text = "Box";
            this.label15.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label16
            // 
            this.label16.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(3, 22);
            this.label16.Margin = new System.Windows.Forms.Padding(3);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(82, 17);
            this.label16.TabIndex = 46;
            this.label16.Text = "Corpses";
            this.label16.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label17
            // 
            this.label17.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(3, 45);
            this.label17.Margin = new System.Windows.Forms.Padding(3);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(82, 17);
            this.label17.TabIndex = 44;
            this.label17.Text = "Supply Drops";
            this.label17.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Misc_Supply_Drop_Box_Check
            // 
            this.Misc_Supply_Drop_Box_Check.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Misc_Supply_Drop_Box_Check.AutoSize = true;
            this.Misc_Supply_Drop_Box_Check.CheckAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.Misc_Supply_Drop_Box_Check.Checked = true;
            this.Misc_Supply_Drop_Box_Check.CheckState = System.Windows.Forms.CheckState.Checked;
            this.Misc_Supply_Drop_Box_Check.Location = new System.Drawing.Point(196, 48);
            this.Misc_Supply_Drop_Box_Check.Margin = new System.Windows.Forms.Padding(3, 3, 0, 0);
            this.Misc_Supply_Drop_Box_Check.Name = "Misc_Supply_Drop_Box_Check";
            this.Misc_Supply_Drop_Box_Check.Size = new System.Drawing.Size(15, 14);
            this.Misc_Supply_Drop_Box_Check.TabIndex = 32;
            this.Misc_Supply_Drop_Box_Check.UseVisualStyleBackColor = true;
            this.Misc_Supply_Drop_Box_Check.CheckedChanged += new System.EventHandler(this.Misc_Supply_Drop_Box_Check_CheckedChanged);
            // 
            // Misc_Corpse_Box_Check
            // 
            this.Misc_Corpse_Box_Check.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Misc_Corpse_Box_Check.AutoSize = true;
            this.Misc_Corpse_Box_Check.CheckAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.Misc_Corpse_Box_Check.Checked = true;
            this.Misc_Corpse_Box_Check.CheckState = System.Windows.Forms.CheckState.Checked;
            this.Misc_Corpse_Box_Check.Location = new System.Drawing.Point(196, 25);
            this.Misc_Corpse_Box_Check.Margin = new System.Windows.Forms.Padding(3, 3, 0, 0);
            this.Misc_Corpse_Box_Check.Name = "Misc_Corpse_Box_Check";
            this.Misc_Corpse_Box_Check.Size = new System.Drawing.Size(15, 14);
            this.Misc_Corpse_Box_Check.TabIndex = 34;
            this.Misc_Corpse_Box_Check.UseVisualStyleBackColor = true;
            this.Misc_Corpse_Box_Check.CheckedChanged += new System.EventHandler(this.Misc_Corpse_Box_Check_CheckedChanged);
            // 
            // label19
            // 
            this.label19.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label19.AutoSize = true;
            this.label19.Location = new System.Drawing.Point(91, 3);
            this.label19.Margin = new System.Windows.Forms.Padding(3);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(41, 13);
            this.label19.TabIndex = 76;
            this.label19.Text = "Radar";
            this.label19.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label20
            // 
            this.label20.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label20.AutoSize = true;
            this.label20.Location = new System.Drawing.Point(188, 3);
            this.label20.Margin = new System.Windows.Forms.Padding(3);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(28, 13);
            this.label20.TabIndex = 77;
            this.label20.Text = "Box";
            this.label20.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label21
            // 
            this.label21.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label21.AutoSize = true;
            this.label21.Location = new System.Drawing.Point(222, 3);
            this.label21.Margin = new System.Windows.Forms.Padding(3);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(75, 13);
            this.label21.TabIndex = 78;
            this.label21.Text = "Radar";
            this.label21.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Misc_Corpse_Radar_Check
            // 
            this.Misc_Corpse_Radar_Check.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Misc_Corpse_Radar_Check.AutoSize = true;
            this.Misc_Corpse_Radar_Check.Checked = true;
            this.Misc_Corpse_Radar_Check.CheckState = System.Windows.Forms.CheckState.Checked;
            this.Misc_Corpse_Radar_Check.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Misc_Corpse_Radar_Check.Location = new System.Drawing.Point(105, 25);
            this.Misc_Corpse_Radar_Check.Margin = new System.Windows.Forms.Padding(3, 3, 0, 0);
            this.Misc_Corpse_Radar_Check.Name = "Misc_Corpse_Radar_Check";
            this.Misc_Corpse_Radar_Check.Size = new System.Drawing.Size(15, 14);
            this.Misc_Corpse_Radar_Check.TabIndex = 29;
            this.Misc_Corpse_Radar_Check.UseVisualStyleBackColor = true;
            this.Misc_Corpse_Radar_Check.CheckedChanged += new System.EventHandler(this.Misc_Corpse_Radar_Check_CheckedChanged);
            // 
            // label13
            // 
            this.label13.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(138, 3);
            this.label13.Margin = new System.Windows.Forms.Padding(3);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(44, 13);
            this.label13.TabIndex = 79;
            this.label13.Text = "Tracer";
            this.label13.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label14
            // 
            this.label14.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(303, 3);
            this.label14.Margin = new System.Windows.Forms.Padding(3);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(75, 13);
            this.label14.TabIndex = 80;
            this.label14.Text = "Tracer";
            this.label14.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Misc_Corpse_Tracer_Color
            // 
            this.Misc_Corpse_Tracer_Color.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Misc_Corpse_Tracer_Color.Location = new System.Drawing.Point(303, 22);
            this.Misc_Corpse_Tracer_Color.Name = "Misc_Corpse_Tracer_Color";
            this.Misc_Corpse_Tracer_Color.Size = new System.Drawing.Size(75, 17);
            this.Misc_Corpse_Tracer_Color.TabIndex = 81;
            this.Misc_Corpse_Tracer_Color.UseVisualStyleBackColor = false;
            this.Misc_Corpse_Tracer_Color.Click += new System.EventHandler(this.Misc_Corpse_Tracer_Color_Click);
            // 
            // Misc_Supply_Drop_Tracer_Color
            // 
            this.Misc_Supply_Drop_Tracer_Color.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Misc_Supply_Drop_Tracer_Color.Location = new System.Drawing.Point(303, 45);
            this.Misc_Supply_Drop_Tracer_Color.Name = "Misc_Supply_Drop_Tracer_Color";
            this.Misc_Supply_Drop_Tracer_Color.Size = new System.Drawing.Size(75, 17);
            this.Misc_Supply_Drop_Tracer_Color.TabIndex = 82;
            this.Misc_Supply_Drop_Tracer_Color.UseVisualStyleBackColor = false;
            this.Misc_Supply_Drop_Tracer_Color.Click += new System.EventHandler(this.Misc_Supply_Drop_Tracer_Color_Click);
            // 
            // Misc_Corpse_Tracer_Check
            // 
            this.Misc_Corpse_Tracer_Check.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Misc_Corpse_Tracer_Check.AutoSize = true;
            this.Misc_Corpse_Tracer_Check.Checked = true;
            this.Misc_Corpse_Tracer_Check.CheckState = System.Windows.Forms.CheckState.Checked;
            this.Misc_Corpse_Tracer_Check.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Misc_Corpse_Tracer_Check.Location = new System.Drawing.Point(154, 25);
            this.Misc_Corpse_Tracer_Check.Margin = new System.Windows.Forms.Padding(3, 3, 0, 0);
            this.Misc_Corpse_Tracer_Check.Name = "Misc_Corpse_Tracer_Check";
            this.Misc_Corpse_Tracer_Check.Size = new System.Drawing.Size(15, 14);
            this.Misc_Corpse_Tracer_Check.TabIndex = 83;
            this.Misc_Corpse_Tracer_Check.UseVisualStyleBackColor = true;
            this.Misc_Corpse_Tracer_Check.CheckedChanged += new System.EventHandler(this.Misc_Corpse_Tracer_Check_CheckedChanged);
            // 
            // Misc_Supply_Drop_Tracer_Check
            // 
            this.Misc_Supply_Drop_Tracer_Check.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Misc_Supply_Drop_Tracer_Check.AutoSize = true;
            this.Misc_Supply_Drop_Tracer_Check.Checked = true;
            this.Misc_Supply_Drop_Tracer_Check.CheckState = System.Windows.Forms.CheckState.Checked;
            this.Misc_Supply_Drop_Tracer_Check.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Misc_Supply_Drop_Tracer_Check.Location = new System.Drawing.Point(154, 48);
            this.Misc_Supply_Drop_Tracer_Check.Margin = new System.Windows.Forms.Padding(3, 3, 0, 0);
            this.Misc_Supply_Drop_Tracer_Check.Name = "Misc_Supply_Drop_Tracer_Check";
            this.Misc_Supply_Drop_Tracer_Check.Size = new System.Drawing.Size(15, 14);
            this.Misc_Supply_Drop_Tracer_Check.TabIndex = 84;
            this.Misc_Supply_Drop_Tracer_Check.UseVisualStyleBackColor = true;
            this.Misc_Supply_Drop_Tracer_Check.CheckedChanged += new System.EventHandler(this.Misc_Supply_Drop_Tracer_Check_CheckedChanged);
            // 
            // Misc_Helicopter_Radar_Check
            // 
            this.Misc_Helicopter_Radar_Check.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Misc_Helicopter_Radar_Check.AutoSize = true;
            this.Misc_Helicopter_Radar_Check.Checked = true;
            this.Misc_Helicopter_Radar_Check.CheckState = System.Windows.Forms.CheckState.Checked;
            this.Misc_Helicopter_Radar_Check.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Misc_Helicopter_Radar_Check.Location = new System.Drawing.Point(105, 71);
            this.Misc_Helicopter_Radar_Check.Margin = new System.Windows.Forms.Padding(3, 3, 0, 0);
            this.Misc_Helicopter_Radar_Check.Name = "Misc_Helicopter_Radar_Check";
            this.Misc_Helicopter_Radar_Check.Size = new System.Drawing.Size(15, 14);
            this.Misc_Helicopter_Radar_Check.TabIndex = 87;
            this.Misc_Helicopter_Radar_Check.UseVisualStyleBackColor = true;
            this.Misc_Helicopter_Radar_Check.CheckedChanged += new System.EventHandler(this.Misc_Helicopter_Radar_Check_CheckedChanged);
            // 
            // Misc_Helicopter_Tracer_Check
            // 
            this.Misc_Helicopter_Tracer_Check.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Misc_Helicopter_Tracer_Check.AutoSize = true;
            this.Misc_Helicopter_Tracer_Check.Checked = true;
            this.Misc_Helicopter_Tracer_Check.CheckState = System.Windows.Forms.CheckState.Checked;
            this.Misc_Helicopter_Tracer_Check.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Misc_Helicopter_Tracer_Check.Location = new System.Drawing.Point(154, 71);
            this.Misc_Helicopter_Tracer_Check.Margin = new System.Windows.Forms.Padding(3, 3, 0, 0);
            this.Misc_Helicopter_Tracer_Check.Name = "Misc_Helicopter_Tracer_Check";
            this.Misc_Helicopter_Tracer_Check.Size = new System.Drawing.Size(15, 14);
            this.Misc_Helicopter_Tracer_Check.TabIndex = 88;
            this.Misc_Helicopter_Tracer_Check.UseVisualStyleBackColor = true;
            this.Misc_Helicopter_Tracer_Check.CheckedChanged += new System.EventHandler(this.Misc_Helicopter_Tracer_Check_CheckedChanged);
            // 
            // Misc_Helicopter_Box_Check
            // 
            this.Misc_Helicopter_Box_Check.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Misc_Helicopter_Box_Check.AutoSize = true;
            this.Misc_Helicopter_Box_Check.Checked = true;
            this.Misc_Helicopter_Box_Check.CheckState = System.Windows.Forms.CheckState.Checked;
            this.Misc_Helicopter_Box_Check.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Misc_Helicopter_Box_Check.Location = new System.Drawing.Point(196, 71);
            this.Misc_Helicopter_Box_Check.Margin = new System.Windows.Forms.Padding(3, 3, 0, 0);
            this.Misc_Helicopter_Box_Check.Name = "Misc_Helicopter_Box_Check";
            this.Misc_Helicopter_Box_Check.Size = new System.Drawing.Size(15, 14);
            this.Misc_Helicopter_Box_Check.TabIndex = 86;
            this.Misc_Helicopter_Box_Check.UseVisualStyleBackColor = true;
            this.Misc_Helicopter_Box_Check.CheckedChanged += new System.EventHandler(this.Misc_Helicopter_Box_Check_CheckedChanged);
            // 
            // Misc_Helicopter_Radar_Color
            // 
            this.Misc_Helicopter_Radar_Color.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Misc_Helicopter_Radar_Color.Location = new System.Drawing.Point(222, 68);
            this.Misc_Helicopter_Radar_Color.Name = "Misc_Helicopter_Radar_Color";
            this.Misc_Helicopter_Radar_Color.Size = new System.Drawing.Size(75, 17);
            this.Misc_Helicopter_Radar_Color.TabIndex = 90;
            this.Misc_Helicopter_Radar_Color.UseVisualStyleBackColor = false;
            this.Misc_Helicopter_Radar_Color.Click += new System.EventHandler(this.Misc_Helicopter_Radar_Color_Click);
            // 
            // Misc_Helicopter_Tracer_Color
            // 
            this.Misc_Helicopter_Tracer_Color.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Misc_Helicopter_Tracer_Color.Location = new System.Drawing.Point(303, 68);
            this.Misc_Helicopter_Tracer_Color.Name = "Misc_Helicopter_Tracer_Color";
            this.Misc_Helicopter_Tracer_Color.Size = new System.Drawing.Size(75, 17);
            this.Misc_Helicopter_Tracer_Color.TabIndex = 89;
            this.Misc_Helicopter_Tracer_Color.UseVisualStyleBackColor = false;
            this.Misc_Helicopter_Tracer_Color.Click += new System.EventHandler(this.Misc_Helicopter_Tracer_Color_Click);
            // 
            // Misc_Helicopter_Box_Color
            // 
            this.Misc_Helicopter_Box_Color.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Misc_Helicopter_Box_Color.Location = new System.Drawing.Point(384, 68);
            this.Misc_Helicopter_Box_Color.Name = "Misc_Helicopter_Box_Color";
            this.Misc_Helicopter_Box_Color.Size = new System.Drawing.Size(75, 17);
            this.Misc_Helicopter_Box_Color.TabIndex = 91;
            this.Misc_Helicopter_Box_Color.UseVisualStyleBackColor = false;
            this.Misc_Helicopter_Box_Color.Click += new System.EventHandler(this.Misc_Helicopter_Box_Color_Click);
            // 
            // GUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(593, 602);
            this.Controls.Add(this.SettingTabs);
            this.HelpButton = true;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "GUI";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Settings";
            this.SettingTabs.ResumeLayout(false);
            this.Setup_TAB.ResumeLayout(false);
            this.Setup_TAB.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.Y.ResumeLayout(false);
            this.Y.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.FOVBox.ResumeLayout(false);
            this.FOVBox.PerformLayout();
            this.Server_PORT_Box.ResumeLayout(false);
            this.Server_PORT_Box.PerformLayout();
            this.Server_IP_Box.ResumeLayout(false);
            this.Server_IP_Box.PerformLayout();
            this.Radar_TAB.ResumeLayout(false);
            this.WaypointBox.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.WaypointGrid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PlayerData)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataTable1)).EndInit();
            this.ZoomBox.ResumeLayout(false);
            this.ZoomBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ZoomTrackBar)).EndInit();
            this.Crosshair_TAB.ResumeLayout(false);
            this.Crosshair_TAB.PerformLayout();
            this.Players_TAB.ResumeLayout(false);
            this.Players_TAB.PerformLayout();
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.Animals_TAB.ResumeLayout(false);
            this.tableLayoutPanel4.ResumeLayout(false);
            this.tableLayoutPanel4.PerformLayout();
            this.Deployables_TAB.ResumeLayout(false);
            this.Deployables_TAB.PerformLayout();
            this.tableLayoutPanel5.ResumeLayout(false);
            this.tableLayoutPanel5.PerformLayout();
            this.Plants_TAB.ResumeLayout(false);
            this.tableLayoutPanel6.ResumeLayout(false);
            this.tableLayoutPanel6.PerformLayout();
            this.Resources_TAB.ResumeLayout(false);
            this.tableLayoutPanel7.ResumeLayout(false);
            this.tableLayoutPanel7.PerformLayout();
            this.Barrels_TAB.ResumeLayout(false);
            this.tableLayoutPanel8.ResumeLayout(false);
            this.tableLayoutPanel8.PerformLayout();
            this.Misc_TAB.ResumeLayout(false);
            this.tableLayoutPanel3.ResumeLayout(false);
            this.tableLayoutPanel3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private TabControl SettingTabs;
        private TabPage Animals_TAB;
        private TabPage Deployables_TAB;
        private CheckBox Animals_Boar_Radar_Check;
        private CheckBox Animals_Wolf_Radar_Check;
        private CheckBox Animals_Deer_Radar_Check;
        private CheckBox Animals_Bear_Radar_Check;
        private CheckBox Animals_Chicken_Radar_Check;
        private CheckBox Deployable_TC_Radar_Check;
        private CheckBox Deployable_Quarry_Radar_Check;
        private TabPage Plants_TAB;
        private CheckBox Deployable_AutoTurret_Radar_Check;
        private CheckBox Deployable_Sleeping_Bag_Radar_Check;
        private CheckBox Plant_Hemp_Radar_Check;
        private CheckBox Plant_Mushroom_Radar_Check;
        private CheckBox Plant_Corn_Radar_Check;
        private CheckBox Plant_Pumpkin_Radar_Check;
        private TabPage Resources_TAB;
        private CheckBox Resource_Metal_Collectable_Radar_Check;
        private CheckBox Resource_Sulfur_Collectable_Radar_Check;
        private CheckBox Resource_Wood_Collectable_Radar_Check;
        private CheckBox Resource_Rock_Collectable_Radar_Check;
        private TabPage Misc_TAB;
        private ColorDialog Color_Picker;
        private Button Animals_Bear_Radar_Color;
        private Button Animals_Chicken_Radar_Color;
        private CheckBox Animals_Horse_Radar_Check;
        private Button Animals_Horse_Radar_Color;
        private Button Animals_Boar_Radar_Color;
        private Button Animals_Wolf_Radar_Color;
        private Button Animals_Deer_Radar_Color;
        private Button Deployable_Quarry_Radar_Color;
        private Button Deployable_AutoTurret_Radar_Color;
        private Button Deployable_Sleeping_Bag_Radar_Color;
        private Button Deployable_TC_Radar_Color;
        private Button Plant_Corn_Radar_Color;
        private Button Plant_Pumpkin_Radar_Color;
        private Button Plant_Hemp_Radar_Color;
        private Button Plant_Mushroom_Radar_Color;
        private Button Resource_Rock_Collectable_Radar_Color;
        private Button Resource_Wood_Collectable_Radar_Color;
        private Button Resource_Sulfur_Collectable_Radar_Color;
        private Button Resource_Metal_Collectable_Radar_Color;
        private Button Deployable_Large_Furnace_Radar_Color;
        private CheckBox Deployable_Large_Furnace_Radar_Check;
        private Button Deployable_Furnace_Radar_Color;
        private CheckBox Deployable_Furnace_Radar_Check;
        private Button Deployable_Bear_Trap_Radar_Color;
        private Button Deployable_Landmine_Radar_Color;
        private CheckBox Deployable_Bear_Trap_Radar_Check;
        private CheckBox Deployable_Landmine_Radar_Check;
        private TabPage Radar_TAB;
        private TrackBar ZoomTrackBar;
        private GroupBox ZoomBox;
        private System.Data.DataSet PlayerData;
        private System.Data.DataTable dataTable1;
        private System.Data.DataColumn dataColumn1;
        private System.Data.DataColumn dataColumn2;
        private System.Data.DataColumn dataColumn3;
        private System.Data.DataColumn dataColumn4;
        private GroupBox WaypointBox;
        private DataGridView WaypointGrid;
        private Button Deployable_Stash_Radar_Color;
        private CheckBox Deployable_Stash_Radar_Check;
        private Button Deployable_Fridge_Radar_Color;
        private CheckBox Deployable_Fridge_Radar_Check;
        private Button Deployable_Oil_Radar_Color;
        private CheckBox Deployable_Oil_Radar_Checked;
        private Button Deployable_Box_Radar_Color;
        private CheckBox Deployable_Box_Radar_Check;
        private TabPage Barrels_TAB;
        private CheckBox Barrel_Loot_Barrel_Radar_Check;
        private CheckBox Barrel_Tool_Crate_Radar_Check;
        private CheckBox Barrel_Med_Crate_Radar_Check;
        private CheckBox Barrel_Food_Crate_Radar_Check;
        private CheckBox Barrel_Mine_Crate_Radar_Check;
        private CheckBox Barrel_Crate_Radar_Check;
        private CheckBox Barrel_Trash_Pile_Radar_Check;
        private Button Deployable_Large_Box_Radar_Color;
        private CheckBox Deployable_Large_Box_Radar_Check;
        private CheckBox Barrel_Oil_Barrel_Radar_Check;
        private CheckBox Barrel_Food_Box_Radar_Check;
        private Button Barrel_Loot_Barrel_Radar_Color;
        private Button Barrel_Oil_Barrel_Radar_Color;
        private Button Barrel_Trash_Pile_Radar_Color;
        private Button Barrel_Crate_Radar_Color;
        private Button Barrel_Mine_Crate_Radar_Color;
        private Button Barrel_Food_Crate_Radar_Color;
        private Button Barrel_Tool_Crate_Radar_Color;
        private Button Barrel_Food_Box_Radar_Color;
        private Button Barrel_Med_Crate_Radar_Color;
        private DataGridViewCheckBoxColumn O;
        private DataGridViewTextBoxColumn WaypointName;
        private DataGridViewTextBoxColumn X;
        private DataGridViewTextBoxColumn Z;
        private DataGridViewButtonColumn Color;
        private TabPage Crosshair_TAB;
        private TextBox Crosshair_Size_Text;
        private Label Crosshair_Type_Label;
        private Button Crosshair_Color;
        private Label Crosshair_Thick_Label;
        private Label Crosshair_Size_Label;
        private Label Crosshair_Color_Label;
        private TextBox Crosshair_Thick_Text;
        private ComboBox Type_Box;
        private TabPage Players_TAB;
        private TableLayoutPanel tableLayoutPanel1;
        private Button Player_Loot_Corpse_Box_Color;
        private Button Player_Loot_Corpse_Tracer_Color;
        private Button Player_Enemy_Box_Color;
        private Button Player_Enemy_Tracer_Color;
        private Button Player_Friend_Box_Color;
        private Button Player_Friend_Tracer_Color;
        private Button Player_Crouching_Box_Color;
        private Button Player_Crouching_Tracer_Color;
        private Button Player_Sprinting_Box_Color;
        private Button Player_Sprinting_Tracer_Color;
        private Button Player_Aiming_Box_Color;
        private Button Player_Aiming_Tracer_Color;
        private Button Player_Sleeping_Box_Color;
        private Button Player_Sleeping_Tracer_Color;
        private CheckBox Player_Crouching_Box_Check;
        private CheckBox Player_Sleeping_Box_Check;
        private CheckBox Player_Sprinting_Box_Check;
        private CheckBox Player_Sleeping_Tracer_Check;
        private Label PlayerSleepingLabel;
        private CheckBox Player_Crouching_Tracer_Check;
        private Button Player_Awake_Radar_Color;
        private CheckBox checkBox12;
        private Button Player_Crouching_Radar_Color;
        private Button Player_Loot_Corpse_Radar_Color;
        private CheckBox checkBox10;
        private CheckBox Player_Awake_Box_Check;
        private CheckBox checkBox8;
        private Button Player_Enemy_Radar_Color;
        private Button Player_Sprinting_Radar_Color;
        private Button Player_Friend_Radar_Color;
        private CheckBox PlayerHeldItem;
        private Button Player_Aiming_Radar_Color;
        private CheckBox PlayerInventoryWearCheck;
        private CheckBox Player_Crouching_Radar_Check;
        private CheckBox PlayerInventoryBeltCheck;
        private CheckBox Player_Awake_Tracer_Check;
        private Button Player_Sleeping_Radar_Color;
        private CheckBox Player_Awake_Radar_Check;
        private Label PlayerAwakeLabel;
        private Button Player_Awake_Tracer_Color;
        private CheckBox Player_Sprinting_Radar_Check;
        private Button Player_Awake_Box_Color;
        private Label PlayerAimingLabel;
        private CheckBox Player_Aiming_Radar_Check;
        private CheckBox Player_Loot_Corpse_Radar_Check;
        private CheckBox Player_Sleeping_Radar_Check;
        private CheckBox Player_Enemy_Radar_Check;
        private CheckBox Player_Friend_Radar_Check;
        private CheckBox Player_Aiming_Tracer_Check;
        private CheckBox Player_Aiming_Box_Check;
        private CheckBox Player_Sprinting_Tracer_Check;
        private Label PlayerSprintingLabel;
        private Label PlayerCrouchingLabel;
        private Label PlayerFriendsLabel;
        private Label PlayerEnemyLabel;
        private Label PlayerLootCorpseLabel;
        private Label PlayerInvWearLabel;
        private Label PlayerHeldItemLabel;
        private CheckBox Player_Friend_Tracer_Check;
        private CheckBox Player_Friend_Box_Check;
        private CheckBox Player_Enemy_Box_Check;
        private CheckBox Player_Enemy_Tracer_Check;
        private CheckBox Player_Loot_Corpse_Tracer_Check;
        private CheckBox Player_Loot_Corpse_Box_Check;
        private Label PlayerInvBeltLabel;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label6;
        private Label label5;
        private Label label7;
        private TableLayoutPanel tableLayoutPanel2;
        private CheckBox checkBox1;
        private CheckBox checkBox3;
        private CheckBox checkBox5;
        private CheckBox checkBox7;
        private Label label12;
        private Label label11;
        private Button button15;
        private Button button12;
        private Button button9;
        private Button button6;
        private Button button2;
        private Button button1;
        private Label label10;
        private Label label1;
        private Label label8;
        private Label label9;
        private Button button25;
        private Button button24;
        private Button button21;
        private Button button18;
        private TabPage Setup_TAB;
        private CheckBox Tracer_Check;
        private Button Reset;
        private CheckBox Radar_Check;
        private CheckBox Barrels_Check;
        private CheckBox Crosshair_Check;
        private CheckBox Animals_Check;
        private CheckBox Resources_Check;
        private CheckBox Plants_Check;
        private CheckBox Players_Check;
        private GroupBox Server_PORT_Box;
        private TextBox Server_PORT_Text;
        private GroupBox Server_IP_Box;
        private TextBox Server_IP_Text;
        private Button StartButton;
        private TableLayoutPanel tableLayoutPanel3;
        private Button Misc_Supply_Drop_Radar_Color;
        private CheckBox Misc_Supply_Drop_Radar_Check;
        private Button Misc_Corpse_Radar_Color;
        private Button Misc_Supply_Drop_Box_Color;
        private Button Misc_Corpse_Box_Color;
        private Label label15;
        private Label label16;
        private Label label17;
        private CheckBox Misc_Supply_Drop_Box_Check;
        private CheckBox Misc_Corpse_Box_Check;
        private Label label19;
        private Label label20;
        private Label label21;
        private CheckBox Misc_Corpse_Radar_Check;
        private Label label13;
        private Label label14;
        private Button Misc_Corpse_Tracer_Color;
        private Button Misc_Supply_Drop_Tracer_Color;
        private CheckBox Misc_Corpse_Tracer_Check;
        private CheckBox Misc_Supply_Drop_Tracer_Check;
        private CheckBox Misc_Check;
        private CheckBox Deployables_Check;
        private Label label18;
        private CheckBox Misc_Helicopter_Radar_Check;
        private CheckBox Misc_Helicopter_Tracer_Check;
        private CheckBox Misc_Helicopter_Box_Check;
        private Button Misc_Helicopter_Radar_Color;
        private Button Misc_Helicopter_Tracer_Color;
        private Button Misc_Helicopter_Box_Color;
        private TableLayoutPanel tableLayoutPanel4;
        private Label label33;
        private Label label32;
        private Label label31;
        private Button Animals_Horse_Box_Color;
        private Button Animals_Horse_Tracer_Color;
        private Button Animals_Boar_Box_Color;
        private Button Animals_Chicken_Box_Color;
        private CheckBox Animals_Chicken_Tracer_Check;
        private CheckBox Animals_Horse_Tracer_Check;
        private CheckBox Animals_Horse_Box_Check;
        private CheckBox Animals_Boar_Box_Check;
        private CheckBox Animals_Chicken_Box_Check;
        private CheckBox Animals_Boar_Tracer_Check;
        private Button Animals_Boar_Tracer_Color;
        private Button Animals_Chicken_Tracer_Color;
        private Label label22;
        private Button Animals_Bear_Box_Color;
        private Button Animals_Wolf_Box_Color;
        private Label label23;
        private Label label24;
        private Label label25;
        private CheckBox Animals_Bear_Box_Check;
        private CheckBox Animals_Wolf_Box_Check;
        private Label label26;
        private Label label27;
        private Label label28;
        private Label label29;
        private Label label30;
        private Button Animals_Wolf_Tracer_Color;
        private Button Animals_Bear_Tracer_Color;
        private CheckBox Animals_Wolf_Tracer_Check;
        private CheckBox Animals_Bear_Tracer_Check;
        private CheckBox Animals_Deer_Tracer_Check;
        private CheckBox Animals_Deer_Box_Check;
        private Button Animals_Deer_Tracer_Color;
        private Button Animals_Deer_Box_Color;
        private TableLayoutPanel tableLayoutPanel5;
        private Button Deployable_Oil_Box_Color;
        private Button Deployable_Oil_Tracer_Color;
        private Button Deployable_Fridge_Box_Color;
        private Button Deployable_Fridge_Tracer_Color;
        private Button Deployable_Large_Furnace_Box_Color;
        private Button Deployable_Large_Furnace_Tracer_Color;
        private Button Deployable_Furnace_Box_Color;
        private Button Deployable_Furnace_Tracer_Color;
        private Button Deployable_AutoTurret_Box_Color;
        private Button Deployable_AutoTurret_Tracer_Color;
        private Button Deployable_Sleeping_Bag_Box_Color;
        private Button Deployable_Sleeping_Bag_Tracer_Color;
        private Button Deployable_TC_Box_Color;
        private Button Deployable_TC_Tracer_Color;
        private CheckBox Deployable_Furnace_Box_Check;
        private CheckBox Deployable_TC_Box_Check;
        private CheckBox Deployable_AutoTurret_Box_Check;
        private CheckBox Deployable_TC_Tracer_Check;
        private Label label34;
        private CheckBox Deployable_Furnace_Tracer_Check;
        private CheckBox Deployable_Quarry_Box_Check;
        private CheckBox Deployable_Quarry_Tracer_Check;
        private Label label35;
        private Button Deployable_Quarry_Tracer_Color;
        private Button Deployable_Quarry_Box_Color;
        private Label label36;
        private CheckBox Deployable_Sleeping_Bag_Tracer_Check;
        private CheckBox Deployable_Sleeping_Bag_Box_Check;
        private CheckBox Deployable_AutoTurret_Tracer_Check;
        private Label label37;
        private Label label38;
        private Label label39;
        private Label label40;
        private Label label41;
        private CheckBox Deployable_Large_Furnace_Tracer_Check;
        private CheckBox Deployable_Large_Furnace_Box_Check;
        private CheckBox Deployable_Fridge_Box_Check;
        private CheckBox Deployable_Fridge_Tracer_Check;
        private CheckBox Deployable_Oil_Tracer_Check;
        private CheckBox Deployable_Oil_Box_Check;
        private Label label42;
        private Label label44;
        private Label label45;
        private Label label46;
        private Label label47;
        private Label label43;
        private Button Deployable_Large_Box_Box_Color;
        private Button Deployable_Box_Box_Color;
        private Button Deployable_Landmine_Tracer_Color;
        private Button Deployable_Bear_Trap_Tracer_Color;
        private Button Deployable_Stash_Box_Color;
        private Button Deployable_Bear_Trap_Box_Color;
        private Button Deployable_Landmine_Box_Color;
        private Button Deployable_Stash_Tracer_Color;
        private Button Deployable_Large_Box_Tracer_Color;
        private Button Deployable_Box_Tracer_Color;
        private CheckBox Deployable_Large_Box_Tracer_Check;
        private CheckBox Deployable_Large_Box_Box_Check;
        private CheckBox Deployable_Box_Box_Check;
        private Label label49;
        private CheckBox Deployable_Box_Tracer_Check;
        private Label label50;
        private CheckBox Deployable_Bear_Trap_Tracer_Check;
        private Label label51;
        private CheckBox Deployable_Landmine_Box_Check;
        private Label label52;
        private CheckBox Deployable_Bear_Trap_Box_Check;
        private CheckBox Deployable_Landmine_Tracer_Check;
        private CheckBox Deployable_Stash_Box_Check;
        private CheckBox Deployable_Stash_Tracer_Check;
        private Label label48;
        private TableLayoutPanel tableLayoutPanel6;
        private Button Plant_Corn_Box_Color;
        private Button Plant_Corn_Tracer_Color;
        private CheckBox Plant_Corn_Box_Check;
        private CheckBox Plant_Corn_Tracer_Check;
        private Label label53;
        private Button Plant_Hemp_Box_Color;
        private Button Plant_Mushroom_Box_Color;
        private Label label54;
        private Label label55;
        private Label label56;
        private CheckBox Plant_Hemp_Box_Check;
        private CheckBox Plant_Mushroom_Box_Check;
        private Label label57;
        private Label label58;
        private Label label59;
        private Label label60;
        private Label label61;
        private Button Plant_Mushroom_Tracer_Color;
        private Button Plant_Hemp_Tracer_Color;
        private CheckBox Plant_Mushroom_Tracer_Check;
        private CheckBox Plant_Hemp_Tracer_Check;
        private CheckBox Plant_Pumpkin_Tracer_Check;
        private CheckBox Plant_Pumpkin_Box_Check;
        private Button Plant_Pumpkin_Tracer_Color;
        private Button Plant_Pumpkin_Box_Color;
        private Label label62;
        private TableLayoutPanel tableLayoutPanel7;
        private Label label65;
        private Button Resource_Metal_Collectable_Box_Color;
        private CheckBox Resource_Metal_Collectable_Tracer_Check;
        private CheckBox Resource_Metal_Collectable_Box_Check;
        private Button Resource_Metal_Collectable_Tracer_Color;
        private Label label66;
        private Button Resource_Wood_Collectable_Box_Color;
        private Button Resource_Rock_Collectable_Box_Color;
        private Label label67;
        private Label label68;
        private Label label69;
        private CheckBox Resource_Wood_Collectable_Box_Check;
        private CheckBox Resource_Rock_Collectable_Box_Check;
        private Label label70;
        private Label label71;
        private Label label72;
        private Label label73;
        private Label label74;
        private Button Resource_Rock_Collectable_Tracer_Color;
        private Button Resource_Wood_Collectable_Tracer_Color;
        private CheckBox Resource_Rock_Collectable_Tracer_Check;
        private CheckBox Resource_Wood_Collectable_Tracer_Check;
        private CheckBox Resource_Sulfur_Collectable_Tracer_Check;
        private CheckBox Resource_Sulfur_Collectable_Box_Check;
        private Button Resource_Sulfur_Collectable_Tracer_Color;
        private Button Resource_Sulfur_Collectable_Box_Color;
        private Label label64;
        private Label label63;
        private Label label75;
        private CheckBox Resource_Sulfur_Node_Radar_Check;
        private CheckBox Resource_Metal_Node_Radar_Check;
        private CheckBox Resource_Stone_Node_Radar_Check;
        private CheckBox Resource_Sulfur_Node_Box_Check;
        private CheckBox Resource_Metal_Node_Tracer_Check;
        private CheckBox Resource_Metal_Node_Box_Check;
        private CheckBox Resource_Stone_Node_Tracer_Check;
        private CheckBox Resource_Stone_Node_Box_Check;
        private Button Resource_Sulfur_Node_Radar_Color;
        private Button Resource_Metal_Node_Radar_Color;
        private Button Resource_Stone_Node_Radar_Color;
        private Button Resource_Sulfur_Node_Tracer_Color;
        private Button Resource_Metal_Node_Tracer_Color;
        private Button Resource_Sulfur_Node_Box_Color;
        private Button Resource_Metal_Node_Box_Color;
        private Button Resource_Stone_Node_Tracer_Color;
        private Button Resource_Stone_Node_Box_Color;
        private TableLayoutPanel tableLayoutPanel8;
        private Label label90;
        private Button Barrel_Food_Box_Box_Color;
        private Button Barrel_Tool_Crate_Box_Color;
        private Button Barrel_Food_Box_Tracer_Color;
        private Button Barrel_Tool_Crate_Tracer_Color;
        private CheckBox Barrel_Food_Box_Tracer_Check;
        private CheckBox Barrel_Food_Box_Box_Check;
        private CheckBox Barrel_Tool_Crate_Box_Check;
        private CheckBox Barrel_Tool_Crate_Tracer_Check;
        private Button Barrel_Oil_Barrel_Box_Color;
        private Button Barrel_Loot_Barrel_Box_Color;
        private Label label76;
        private Label label77;
        private Label label78;
        private CheckBox Barrel_Oil_Barrel_Box_Check;
        private CheckBox Barrel_Loot_Barrel_Box_Check;
        private Label label79;
        private Label label80;
        private Label label82;
        private Label label83;
        private Button Barrel_Loot_Barrel_Tracer_Color;
        private Button Barrel_Oil_Barrel_Tracer_Color;
        private CheckBox Barrel_Loot_Barrel_Tracer_Check;
        private CheckBox Barrel_Oil_Barrel_Tracer_Check;
        private Label label84;
        private Label label85;
        private Label label86;
        private Label label87;
        private Label label88;
        private CheckBox Barrel_Trash_Pile_Tracer_Check;
        private CheckBox Barrel_Trash_Pile_Box_Check;
        private CheckBox Barrel_Crate_Box_Check;
        private CheckBox Barrel_Crate_Tracer_Check;
        private CheckBox Barrel_Mine_Crate_Tracer_Check;
        private CheckBox Barrel_Mine_Crate_Box_Check;
        private CheckBox Barrel_Food_Crate_Tracer_Check;
        private CheckBox Barrel_Food_Crate_Box_Check;
        private CheckBox Barrel_Med_Crate_Tracer_Check;
        private CheckBox Barrel_Med_Crate_Box_Check;
        private Button Barrel_Trash_Pile_Tracer_Color;
        private Button Barrel_Trash_Pile_Box_Color;
        private Button Barrel_Crate_Box_Color;
        private Button Barrel_Crate_Tracer_Color;
        private Button Barrel_Mine_Crate_Tracer_Color;
        private Button Barrel_Food_Crate_Tracer_Color;
        private Button Barrel_Mine_Crate_Box_Color;
        private Button Barrel_Food_Crate_Box_Color;
        private Button Barrel_Med_Crate_Tracer_Color;
        private Button Barrel_Med_Crate_Box_Color;
        private Label label81;
        private Label label89;
        private CheckBox Box_Check;
        private CheckBox Resource_Sulfur_Node_Tracer_Check;
        private GroupBox groupBox1;
        private TextBox Distance_Text_Box;
        private GroupBox FOVBox;
        private TextBox FOV_Text_Box;
        private GroupBox Y;
        private TextBox Temp_Text_Box;
        private GroupBox groupBox2;
        private TextBox textBox1;
    }
}