using Rust_Interceptor.Data;
using System.Collections.Generic;
using Rust_Interceptor;
using Box.Properties;
using System;

namespace Box {
    public class Box {

        public RustInterceptor Interceptor;
        public bool stopped = true;

        //public abstract void OnPacket(Packet packet);
        //public abstract void OnEntity(Entity entity);
        //public abstract void OnEntityDestroy(EntityDestroy destroyInfo);

        internal void internalOnPacket(Packet packet) {
            Entity entity;
            switch (packet.rustID) {
                case Packet.Rust.Entities:
                    ProtoBuf.Entity entityInfo;
                    uint num = Entity.ParseEntity(packet, out entityInfo);
                    if (entityInfo.autoturret != null) {
                        Entity.CreateOrUpdate(num, entityInfo);
                        return;
                    }
                    if (entityInfo.basePlayer != null) {
                        Entity.CreateOrUpdate(num, entityInfo);
                        return;
                    }
                    if (entityInfo.resource != null) {
                        Entity.CreateOrUpdate(num, entityInfo);
                        return;
                    }
                    if (entityInfo.buildingPrivilege != null) {
                        Entity.CreateOrUpdate(num, entityInfo);
                        return;
                    }
                    if (entityInfo.baseNPC != null) {
                        Entity.CreateOrUpdate(num, entityInfo);
                        return;
                    }
                    if (entityInfo.sleepingBag != null) {
                        Entity.CreateOrUpdate(num, entityInfo);
                        return;
                    }
                    if (entityInfo.miningQuarry != null) {
                        Entity.CreateOrUpdate(num, entityInfo);
                        return;
                    }
                    if (entityInfo.plantEntity != null) {
                        Entity.CreateOrUpdate(num, entityInfo);
                        return;
                    }
                    if (entityInfo.helicopter != null) {
                        Entity.CreateOrUpdate(num, entityInfo);
                        return;
                    }
                    if (entityInfo.landmine != null) {
                        Entity.CreateOrUpdate(num, entityInfo);
                        return;
                    }
                    if (entityInfo.autoturret != null) {
                        Entity.CreateOrUpdate(num, entityInfo);
                        return;
                    }
                    if(Entity.getName(entityInfo.baseNetworkable.prefabID) != "UnKnown") {
                        Entity.CreateOrUpdate(num, entityInfo);
                        return;
                    }
                    //if (entity != null) OnEntity(entity);
                return;
                case Packet.Rust.EntityPosition:
                    List<Entity.EntityUpdate> updates = Entity.ParsePositions(packet);
                    List<Entity> entities = null;
                    if (updates.Count == 1) {
                        entity = Entity.UpdatePosition(updates[0]);
                        if (entity != null) (entities = new List<Entity>()).Add(entity);
                    } else if (updates.Count > 1) {
                        entities = Entity.UpdatePositions(updates);
                    }
                    //if (entities != null) entities.ForEach(item => OnEntity(item));
                    return;
                case Packet.Rust.EntityDestroy:
                    EntityDestroy destroyInfo = new EntityDestroy(packet);
                    Entity.CreateOrUpdate(destroyInfo);
                    //OnEntityDestroy(destroyInfo);
                    return;

            }
            //OnPacket(packet);
        }
        

        public void start() {
            Interceptor = new RustInterceptor(Settings.Default.Server_IP, Settings.Default.Server_PORT);
            Interceptor.AddPacketsToFilter(Packet.Rust.Entities, Packet.Rust.EntityDestroy, Packet.Rust.EntityPosition);
            //Interceptor.RegisterCommandCallback(OnCommand);
            Interceptor.RegisterCallback(internalOnPacket);
            Interceptor.Start();
            stopped = false;
            Console.WriteLine("Started");
        }
    }
}
