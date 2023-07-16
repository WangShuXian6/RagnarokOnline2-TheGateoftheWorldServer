using System;
using System.Collections.Generic;

using SagaMap;
 
using SagaDB.Actors;
using SagaDB.Items;

namespace Prt_f01
{
    public class Prado : Npc
    {
        public override void OnInit()
        {
            MapName = "Prt_f01";
            Type = 1094;
            Name = "Prado Alden";
            StartX = 14418F;
            StartY = 73735F;
            StartZ = 5094;
            Startyaw = 58376;
            SetScript(3);
        AddButton(Functions.EnterShip,new func(OnButton));
        }

        public void OnButton(ActorPC pc)
        {
            NPCChat(pc, 823);
            Warp(pc, 21, 3530F, 6554F, -1112); 
        }

    }
}