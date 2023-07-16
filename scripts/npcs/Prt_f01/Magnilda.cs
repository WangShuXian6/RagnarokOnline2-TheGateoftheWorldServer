using System;
using System.Collections.Generic;

using SagaMap;
 
using SagaDB.Actors;
using SagaDB.Items;

namespace Prt_f01
{
    public class Magnilda : Npc
    {
        public override void OnInit()
        {
            MapName = "Prt_f01";
            Type = 1077;
            Name = "Magnilda Haswell";
            StartX = 13156F;
            StartY = 74568F;
            StartZ = 5094;
            Startyaw = 33797;
            SetScript(3);
            AddButton(Functions.EnterShip,new func(OnButton));
        }

        public void OnButton(ActorPC pc)
        {
            NPCChat(pc, 823);
            Warp(pc, 15, 858F, 23505F, -7797);
        }

    }
}