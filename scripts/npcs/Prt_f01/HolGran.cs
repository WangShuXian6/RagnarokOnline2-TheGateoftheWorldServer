using System;
using System.Collections.Generic;

using SagaMap;
 
using SagaDB.Actors;
using SagaDB.Items;

namespace Prt_f01
{
    public class HolGran : Npc
    {
        public override void OnInit()
        {
            MapName = "Prt_f01";
            Type = 1011;
            Name = "HolGran";
            StartX = 13112F;
            StartY = 74848F;
            StartZ = 5094;
            Startyaw = 13807;
            SetScript(3);
            AddButton(Functions.Smith);
        }

        public void OnButton(ActorPC pc)
        {
            NPCChat(pc, 823);
        }

    }
}