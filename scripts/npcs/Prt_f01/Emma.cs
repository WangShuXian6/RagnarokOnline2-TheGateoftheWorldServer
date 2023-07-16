using System;
using System.Collections.Generic;

using SagaMap;
 
using SagaDB.Actors;
using SagaDB.Items;

namespace Prt_f01
{
    public class Emma : Npc
    {
        public override void OnInit()
        {
            MapName = "Prt_f01";
            Type = 1056;
            Name = "Emma Whitlef";
            StartX = 15962F;
            StartY = 75737F;
            StartZ = 5114;
            Startyaw = 32411;
            SetScript(3);
            AddButton(Functions.Regenbogen);
        }

        public void OnButton(ActorPC pc)
        {
            NPCChat(pc, 823);
        }

    }
}