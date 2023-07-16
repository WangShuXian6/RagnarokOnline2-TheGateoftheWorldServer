using System;
using System.Collections.Generic;

using SagaMap;
 
using SagaDB.Actors;
using SagaDB.Items;

namespace Prt_f01
{
    public class Toska : Npc
    {
        public override void OnInit()
        {
            MapName = "Prt_f01";
            Type = 1073;
            Name = "Toska Alden";
            StartX = 13224F;
            StartY = 73967F;
            StartZ = 5094;
            Startyaw = 34426;
            SetScript(3);
            AddButton(Functions.EnterShip,new func(OnButton));
        }

        public void OnButton(ActorPC pc)
        {
            NPCChat(pc, 823);
            Warp(pc, 6, 32352F, 41824F, -4975); 
        }

    }
}