using System;
using System.Collections.Generic;

using SagaMap;
 
using SagaDB.Actors;
using SagaDB.Items;

namespace Prt_f01
{
    public class Irman : Npc
    {
        public override void OnInit()
        {
            MapName = "Prt_f01";
            Type = 1071;
            Name = "Irma Swane";
            StartX = 14477F;
            StartY = 74412F;
            StartZ = 5094;
            Startyaw = 600;
            SetScript(3);
        AddButton(Functions.EnterShip,new func(OnButton));
        }

        public void OnButton(ActorPC pc)
        {
            NPCChat(pc, 823);
            Warp(pc, 23, 25942F, 12946F, -9338);
        }

    }
}