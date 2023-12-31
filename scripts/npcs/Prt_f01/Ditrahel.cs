using System;
using System.Collections.Generic;

using SagaMap;
 
using SagaDB.Actors;
using SagaDB.Items;

namespace Prt_f01
{
    public class Ditrahel : Npc
    {
        public override void OnInit()
        {
            MapName = "Prt_f01";
            Type = 1159;
            Name = "Ditrahel";
            StartX = 14468F;
            StartY = 74645F;
            StartZ = 5094;
            Startyaw = 65085;
            SetScript(3);
        AddButton(Functions.EnterShip,new func(OnButton));
        }

        public void OnButton(ActorPC pc)
        {
            NPCChat(pc, 823);
            Warp(pc, 24, 15493F, -40653F, -23385);
        }

    }
}