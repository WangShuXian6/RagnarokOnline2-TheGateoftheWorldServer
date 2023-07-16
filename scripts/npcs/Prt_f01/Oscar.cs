using System;
using System.Collections.Generic;

using SagaMap;
 
using SagaDB.Actors;
using SagaDB.Items;

namespace Prt_f01
{
    public class Oscar : Npc
    {
        public override void OnInit()
        {
            MapName = "Prt_f01";
            Type = 1055;
            Name = "Oscar Eatone";
            StartX = 15953F;
            StartY = 76191F;
            StartZ = 5114;
            Startyaw = 36021;
            SetScript(3);
            AddButton(Functions.Regenbogen);
        }

        public void OnButton(ActorPC pc)
        {
            NPCChat(pc, 823);
        }

    }
}
