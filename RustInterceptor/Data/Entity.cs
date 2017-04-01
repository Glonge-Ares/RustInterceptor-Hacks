using System;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;

namespace Rust_Interceptor.Data {

	public class Entity {
		uint networkOrder = 0;
		internal ProtoBuf.Entity proto;
		public ProtoBuf.Entity Data {
			get { return proto; }
			private set { proto = value; }
		}

		public bool IsPlayer { get { return proto.basePlayer != null; } }
        public bool HasHeldItem { get { return HeldEntity != null && HeldEntity != 0; } }
        public uint HeldEntity { get { return proto.basePlayer.heldEntity; } private set { proto.basePlayer.heldEntity = value; } }
		public bool IsLocalPlayer { get { return proto.basePlayer.metabolism != null; } }
        public bool IsLandmine { get { return proto.landmine != null; } }
        public bool IsBearTrap { get { return Name == "Bear Trap"; } }
        public bool IsHelicopter { get { return proto.helicopter != null; } }
        public bool IsQuarry { get { return proto.miningQuarry != null; } }
        public bool IsPlant { get { return proto.plantEntity != null; } }
        public bool IsResource { get { return proto.resource != null; } }
        public bool IsSleepingBag { get { return proto.sleepingBag != null; } }
        public bool IsAnimal { get { return proto.baseNPC != null; } }
        public bool IsAutoTurret { get { return proto.autoturret != null; } }
        public bool IsToolCup { get { return proto.buildingPrivilege != null; } }
        public bool IsCorpse { get { return proto.corpse != null; } }
        public bool IsLootCorpse { get { return proto.lootableCorpse != null; } }
        public bool IsFurnace { get { return Name == "Furnace"; } }
        public bool IsLargeFurnace { get { return Name == "Large Furnace"; } }
        public bool IsFridge { get { return Name == "Fridge"; } }
        public bool IsChest { get { return Name == "Chest"; } }
        public bool IsLargeChest { get { return Name == "Large Chest"; } }
        public bool IsStash { get { return Name == "Stash"; } }
        public bool IsOil { get { return Name == "Oil Refinery"; } }
        public bool IsSupplyDrop { get { return Name == "Supply Drop"; } }
        public bool IsCollectable { get { return Name == "Metal" || Name == "Stone" || Name == "Sulfur" || Name == "Wood"; } }
        public bool IsBarrel { get { return Name == "Trash Pile" || Name == "Loot Barrel" || Name == "Mine Crate" || Name == "Crate" || Name == "Food Crate" || Name == "Medical Crate" || Name == "Tool Crate" || Name == "ammo" || Name == "C4" || Name == "Resources" || Name == "Tools" || Name == "Food" || Name == "Medical" || Name == "T1 Box" || Name == "T2 Box" || Name == "T3 Box" || Name == "Food Box" || Name == "Loot Barrel" || Name == "Loot Trash" || Name == "Oil Barrel"; } }

        public UInt32 UID { get { return proto.baseNetworkable.uid; } private set { proto.baseNetworkable.uid = value; } }
		public Vector3 Position { get { return proto.baseEntity.pos; } private set { proto.baseEntity.pos = value; } }
		public Vector3 Rotation { get { return proto.baseEntity.rot; } private set { proto.baseEntity.rot = value; } }
        public String PlayerName { get { return proto.basePlayer.name; } private set { proto.basePlayer.name = value; } }
        public String CorpseName { get { return proto.lootableCorpse.playerName; } private set { proto.lootableCorpse.playerName = value; } }
        public float CombatHealth { get { return proto.baseCombat.health; } private set { proto.baseCombat.health = value; } }
        public int CombatState { get { return proto.baseCombat.state; } private set { proto.baseCombat.state = value; } }
        public String HeldItem { get { return getHeldItem(); } }
        public int ResourceStage { get { return proto.resource.stage; } private set { proto.resource.stage = value; } }
        public bool IsPlayerSleeping { get { return proto.basePlayer.modelState.sleeping; } private set { proto.basePlayer.modelState.sleeping = value; } }
        public bool IsPlayerAiming { get { return proto.basePlayer.modelState.aiming; } private set { proto.basePlayer.modelState.aiming = value; } }
        public bool IsPlayerSprinting { get { return proto.basePlayer.modelState.sprinting; } private set { proto.basePlayer.modelState.sprinting = value; } }
        public bool IsPlayerCrouching { get { return proto.basePlayer.modelState.ducked; } private set { proto.basePlayer.modelState.ducked = value; } }
        public bool IsPlayerFlying { get { return proto.basePlayer.modelState.flying; } private set { proto.basePlayer.modelState.flying = value; } }
        public bool IsPlayerProne { get { return proto.basePlayer.modelState.prone; } private set { proto.basePlayer.modelState.prone = value; } }
        public bool IsPlayerOnLadder { get { return proto.basePlayer.modelState.onLadder; } private set { proto.basePlayer.modelState.onLadder = value; } }
        public bool IsPlayerOnGround { get { return proto.basePlayer.modelState.onground; } private set { proto.basePlayer.modelState.onground = value; } }
        public List<float> HelicopterHealths { get { return proto.helicopter.weakspothealths; } private set { proto.helicopter.weakspothealths = value; } }
        public List<ProtoBuf.Item> InvBelt { get { return proto.basePlayer.inventory.invBelt.contents; } private set { proto.basePlayer.inventory.invBelt.contents = value; } }
        public List<ProtoBuf.Item> InvWear { get { return proto.basePlayer.inventory.invWear.contents; } private set { proto.basePlayer.inventory.invWear.contents = value; } }
        public List<ProtoBuf.PlayerNameID> TCList { get { return proto.buildingPrivilege.users; } private set { proto.buildingPrivilege.users = value; } }
        public String BagName { get { return proto.sleepingBag.name; } private set { proto.sleepingBag.name = value; } }
        private String name = "UnKnown";
        public String Name { get { return name; } }
        static Dictionary<UInt32, Entity> entities = new Dictionary<uint, Entity>();
        
        public static Entity GetLocalPlayer() {
			return First(item => item.Value.IsLocalPlayer);
		}

        public static List<Entity> GetPlayers() {
            return Find(item => { return item.Value.IsPlayer; });
        }
        public static List<Entity> GetLandmines() {
            return Find(item => { return item.Value.IsLandmine; });
        }
        public static List<Entity> GetQuarrys() {
            return Find(item => { return item.Value.IsQuarry; });
        }
        public static List<Entity> GetPlants() {
            return Find(item => { return item.Value.IsPlant; });
        }
        public static List<Entity> GetResources() {
            return Find(item => { return item.Value.IsResource; });
        }
        public static List<Entity> GetSleepingBags() {
            return Find(item => { return item.Value.IsSleepingBag; });
        }
        public static List<Entity> GetAnimals() {
            return Find(item => { return item.Value.IsAnimal; });
        }
        public static List<Entity> GetTurrets() {
            return Find(item => { return item.Value.IsAutoTurret; });
        }
        public static List<Entity> GetCorpses() {
            return Find(item => { return item.Value.IsCorpse; });
        }
        public static List<Entity> GetLootCorpses() {
            return Find(item => { return item.Value.IsLootCorpse; });
        }
        public static List<Entity> GetBearTraps() {
            return Find(item => { return item.Value.IsBearTrap; });
        }
        public static List<Entity> GetChests() {
            return Find(item => { return item.Value.IsChest; });
        }
        public static List<Entity> GetLargeChests() {
            return Find(item => { return item.Value.IsLargeChest; });
        }
        public static List<Entity> GetStashes() {
            return Find(item => { return item.Value.IsStash; });
        }
        public static List<Entity> GetFurnaces() {
            return Find(item => { return item.Value.IsFurnace; });
        }
        public static List<Entity> GetLargeFurnaces() {
            return Find(item => { return item.Value.IsLargeFurnace; });
        }
        public static List<Entity> GetFridges() {
            return Find(item => { return item.Value.IsFridge; });
        }
        public static List<Entity> GetOils() {
            return Find(item => { return item.Value.IsOil; });
        }
        public static List<Entity> GetSupplyDrops() {
            return Find(item => { return item.Value.IsSupplyDrop; });
        }
        public static List<Entity> GetCollectables () {
            return Find(item => { return item.Value.IsCollectable; });
        }
        public static List<Entity> GetToolCups() {
            return Find(item => { return item.Value.IsToolCup; });
        }
        public static List<Entity> GetBarrels() {
            return Find(item => { return item.Value.IsBarrel; });
        }
        public static List<Entity> GetHelicopters() {
            return Find(item => { return item.Value.IsHelicopter; });
        }

        public static bool Has(UInt32 uid) {
			return entities.ContainsKey(uid);
		}

		public static Entity First(Func<KeyValuePair<UInt32, Entity>, bool> predicate) {
            lock (entities) {
                return entities.First(predicate).Value;
            }
        }

		public static List<Entity> Find(Func<KeyValuePair<UInt32, Entity>, bool> predicate) {
            IEnumerable<KeyValuePair<UInt32, Entity>> results;
            lock (entities) {
                results = entities.Where(predicate);
                return (from item in results select item.Value).ToList();
            }
		}

		public static Entity Find(UInt32 uid) {
			Entity ent;
            lock (entities) {
                if (entities.TryGetValue(uid, out ent)) {
                    return ent;
                }
            }
            return null;
		}

		public static Entity CreateOrUpdate(UInt32 networkOrder, ProtoBuf.Entity entityInfo) {
			uint uid = entityInfo.baseNetworkable.uid;
            if (Has(uid)) {
                Entity entity;
                lock (entities) {
                    entity = entities[uid];
                }
                entity.networkOrder = networkOrder;
				entity.proto = entityInfo;
                lock (entities) {
                    entities[uid] = entity;
                }
                return entity;
			} else {
				Entity entity = new Entity();
				entity.networkOrder = networkOrder;
				entity.proto = entityInfo;
                entity.name = getName(entityInfo.baseNetworkable.prefabID);
                lock (entities) {
                    entities.Add(uid, entity);
                }
                return entity;
			}
		}

		public static void CreateOrUpdate(EntityDestroy destroyInfo) {
            lock (entities) {
                if (Has(destroyInfo.UID))
                    entities.Remove(destroyInfo.UID);
                }
        }

		public static Entity UpdatePosition(Data.Entity.EntityUpdate update) {
			if (!Has(update.uid)) return null;
            Entity entity;
            lock (entities) {
                entity = entities[update.uid];
            }
            entity.Position = update.position;
			entity.Rotation = update.rotation;
            lock (entities) {
                entities[update.uid] = entity;
            }
            return entity;
		}

		public static List<Entity> UpdatePositions(List<Data.Entity.EntityUpdate> updates) {
			List<Entity> entities = new List<Entity>();
			foreach (var update in updates) {
				var entity = UpdatePosition(update);
				if (entity != null) entities.Add(entity);
			}
			return entities.Count > 0 ? entities : null;
		}

		public static List<EntityUpdate> ParsePositions(Packet p) {
			List<EntityUpdate> updates = new List<EntityUpdate>();
			/* EntityPosition packets may contain multiple positions */
			while (p.unread >= 28L /* Uint32 = 4bytes, Float = 4bytes. Uint32 + (Float * 6) = 28 */) {
				EntityUpdate update = new EntityUpdate();
				/* Entity UID */
				update.uid = p.UInt32();
				/* Read 2 Vector3, Position and Rotation */
				update.position = p.Vector3();
				update.rotation = p.Vector3();
				updates.Add(update);
			}
			return updates;
		}

		public static uint ParseEntity(Packet p, out ProtoBuf.Entity entity) {
			/* Entity Number/Order */
			var num = p.UInt32();
			entity = global::ProtoBuf.Entity.Deserialize(p);
			return num;
		}

		public class EntityUpdate {
			internal uint uid;
			public uint UID { get { return uid; } }
			internal Vector3 position;
			public Vector3 Position { get { return position; } }
			internal Vector3 rotation;
			public Vector3 Rotation { get { return rotation; } }
		}

        public static String getName(uint ID) {
            switch (StringPool.Get(ID)) {
                //TRAPS
                case "assets/prefabs/deployable/landmine/landmine.prefab":
                return "Landmine";
                break;
                case "assets/prefabs/deployable/bear trap/beartrap.prefab":
                return "Bear Trap";
                break;
                //ANIMALS
                case "assets/bundled/prefabs/autospawn/animals/bear.prefab":
                return "Bear";
                break;
                case "assets/bundled/prefabs/autospawn/animals/boar.prefab":
                return "Boar";
                break;
                case "assets/bundled/prefabs/autospawn/animals/chicken.prefab":
                return "Chicken";
                break;
                case "assets/bundled/prefabs/autospawn/animals/stag.prefab":
                return "Stag";
                break;
                case "assets/bundled/prefabs/autospawn/animals/wolf.prefab":
                return "Wolf";
                break;
                case "assets/bundled/prefabs/autospawn/animals/horse.prefab":
                return "Horse";
                break;
                //ORES
                case "Metal Ore":
                return "Metal Node";
                break;
                case "Sulfur Ore":
                return "Sulfur Node";
                break;
                case "Stone Ore":
                return "Stone Node";
                break;
                //PLANTS
                case "assets/prefabs/plants/corn/corn.entity.prefab":
                return "Corn";
                break;
                case "assets/prefabs/plants/hemp/hemp.entity.prefab":
                return "Hemp";
                break;
                case "assets/prefabs/plants/pumpkin/pumpkin.entity.prefab":
                return "Pumpkin";
                break;
                //COLLECTABLES
                case "assets/bundled/prefabs/autospawn/collectable/corn/corn-collectable.prefab":
                return "Corn";
                break;
                case "assets/bundled/prefabs/autospawn/collectable/hemp/hemp-collectable.prefab":
                return "Hemp";
                break;
                case "assets/bundled/prefabs/autospawn/collectable/mushrooms/mushroom-cluster-5.prefab":
                return "Mushroom";
                break;
                case "assets/bundled/prefabs/autospawn/collectable/mushrooms/mushroom-cluster-6.prefab":
                return "Mushroom";
                break;
                case "assets/bundled/prefabs/autospawn/collectable/pumpkin/pumpkin-collectable.prefab":
                return "Pumpkin";
                break;
                case "assets/bundled/prefabs/autospawn/collectable/stone/metal-collectable.prefab":
                return "Metal";
                break;
                case "assets/bundled/prefabs/autospawn/collectable/stone/stone-collectable.prefab":
                return "Stone";
                break;
                case "assets/bundled/prefabs/autospawn/collectable/stone/sulfur-collectable.prefab":
                return "Sulfur";
                break;
                case "assets/bundled/prefabs/autospawn/collectable/stone/wood-collectable.prefab":
                return "Wood";
                break;

                case "assets/bundled/prefabs/autospawn/resource/loot/trash-pile-1.prefab":
                return "Trash Pile";
                break;
                case "assets/bundled/prefabs/autospawn/resource/loot/loot-barrel-2.prefab":
                return "Loot Barrel";
                break;
                case "assets/bundled/prefabs/autospawn/resource/loot/loot-barrel-1.prefab":
                return "Loot Barrel";
                break;
                case "assets/bundled/prefabs/radtown/crate_mine.prefab":
                return "Mine Crate";
                break;
                case "assets/bundled/prefabs/radtown/crate_normal.prefab":
                return "Crate";
                break;
                case "assets/bundled/prefabs/radtown/crate_normal_2.prefab":
                return "Crate";
                break;
                case "assets/bundled/prefabs/radtown/crate_normal_2_food.prefab":
                return "Food Crate";
                break;
                case "assets/bundled/prefabs/radtown/crate_normal_2_medical.prefab":
                return "Medical Crate";
                break;
                case "assets/bundled/prefabs/radtown/crate_tools.prefab":
                return "Tool Crate";
                break;
                case "assets/bundled/prefabs/radtown/dmloot/dm ammo.prefab":
                return "ammo";
                break;
                case "assets/bundled/prefabs/radtown/dmloot/dm c4.prefab":
                return "C4";
                break;
                case "assets/bundled/prefabs/radtown/dmloot/dm construction resources.prefab":
                return "Resources";
                break;
                case "assets/bundled/prefabs/radtown/dmloot/dm construction tools.prefab":
                return "Tools";
                break;
                case "assets/bundled/prefabs/radtown/dmloot/dm food.prefab":
                return "Food";
                break;
                case "assets/bundled/prefabs/radtown/dmloot/dm medical.prefab":
                return "Medical";
                break;
                case "assets/bundled/prefabs/radtown/dmloot/dm tier1 lootbox.prefab":
                return "T1 Box";
                break;
                case "assets/bundled/prefabs/radtown/dmloot/dm tier2 lootbox.prefab":
                return "T2 Box";
                break;
                case "assets/bundled/prefabs/radtown/dmloot/dm tier3 lootbox.prefab":
                return "T3 Box";
                break;
                case "assets/bundled/prefabs/radtown/foodbox.prefab":
                return "Food Box";
                break;
                case "assets/bundled/prefabs/radtown/loot_barrel_1.prefab":
                return "Loot Barrel";
                break;
                case "assets/bundled/prefabs/radtown/loot_barrel_2.prefab":
                return "Loot Barrel";
                break;
                case "assets/bundled/prefabs/radtown/loot_trash.prefab":
                return "Loot Trash";
                break;
                case "assets/bundled/prefabs/radtown/oil_barrel.prefab":
                return "Oil Barrel";
                break;

                case "assets/prefabs/deployable/small stash/small_stash_deployed.prefab":
                return "Stash";
                break;
                case "assets/prefabs/deployable/woodenbox/woodbox_deployed.prefab":
                return "Chest";
                break;
                case "assets/prefabs/deployable/large wood storage/box.wooden.large.prefab":
                return "Large Chest";
                break;

                case "assets/prefabs/deployable/furnace/furnace.prefab":
                return "Furnace";
                break;

                case "assets/prefabs/deployable/furnace.large/furnace.large.prefab":
                return "Large Furnace";
                break;

                case "assets/prefabs/deployable/oil refinery/refinery_large_deployed.prefab":
                return "Oil Refinery";
                break;

                case "assets/prefabs/deployable/fridge/fridge.deployed.prefab":
                return "Fridge";
                break;

                case "assets/prefabs/misc/supply drop/supply_drop.prefab":
                return "Supply Drop";
                break;

                default:
                return "UnKnown";
                break;
            }
        }

        private string getHeldItem() {
            foreach (var e in proto.basePlayer.inventory.invBelt.contents) {
                if (e.UID == HeldEntity) {
                    return StringPool.GetItem(e.itemid);
                }
            }
            return "Unknown";
        }

        public void getInv() {
            Console.WriteLine(proto.basePlayer.name);
            Console.WriteLine("HeldEntity:{0}", proto.basePlayer.heldEntity);
            Console.WriteLine("InvBelt:");
            foreach (var e in proto.basePlayer.inventory.invBelt.contents) {
                Console.WriteLine("name:{0} | itmid{1} | UID:{2}, hele:{3}", e.name, e.itemid, e.UID, e.heldEntity);
            }
            Console.WriteLine("InvWear:");
            foreach (var e in proto.basePlayer.inventory.invWear.contents) {
                Console.WriteLine("name:{0} | itmid{1} | UID:{2}, hele:{3}", e.name, e.itemid, e.UID, e.heldEntity);
            }
        }
    }
}
