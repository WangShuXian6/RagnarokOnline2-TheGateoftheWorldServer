﻿using System;
using System.Collections.Generic;

using SagaMap;
 
using SagaDB.Actors;
using SagaDB.Items;

namespace Prt_f01
{
    public class Aronos_Dodd : Npc
    {
        public override void OnInit()
        {
            MapName = "Prt_f01";
            Type = 1083;
            Name = "Aronos Dodd";
            StartX = 13645F;
            StartY = 74911F;
            StartZ = 5040;
            Startyaw = 82768;
            SetScript(2443);
            AddButton(Functions.EnterShip,new func(OnButton));
        }

        public void OnButton(ActorPC pc)
        {
            NPCChat(pc, 2444);
            Warp(pc, 1, -11647.87f, -1443.877f, -9272.237f);
        }

    }
}