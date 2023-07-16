  //////////////////////////////
 /// Npc Script Set by Chii ///
//////////////////////////////

using System;
using System.Collections.Generic;

using SagaMap;
 
using SagaDB.Actors;
using SagaDB.Items;

namespace rag2startzone_01
{
    public class RaulDietrich : Npc
    {
        public override void OnInit()
        {
        MapName = "rag2startzone_01";
        Type = 1270;
        Name = "Raul Dietrich";
        StartX = -17845F;
        StartY = 8848F;
        StartZ = 160F;
        Startyaw = 23547;
        SetScript(5349);
        AddButton(Functions.EnterShip,new func(OnButton));
        }

        public void OnButton(ActorPC pc)
        {
            NPCChat(pc, 823);
            Warp(pc, 3, -4831F, 16721F, 3977);
        }

    }
}