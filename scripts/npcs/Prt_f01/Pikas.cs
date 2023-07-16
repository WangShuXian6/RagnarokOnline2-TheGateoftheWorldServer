using System;
using System.Collections.Generic;

using SagaMap;
 
using SagaDB.Actors;
using SagaDB.Items;

namespace Prt_f01
{
    public class Pikas : Npc
    {
        public override void OnInit()
        {
            MapName = "Alf_f03";
            Type = 1090;
            Name = "Pikas Wibert";
            StartX = -28074F;
            StartY = 7227F;
            StartZ = -462;
            Startyaw = 61307;
            SetScript(3);
            AddButton(Functions.EnterShip,new func(OnButton));
        }

        public void OnButton(ActorPC pc)
        {
            NPCChat(pc, 823);
            Warp(pc, 5, 13919F, 75806F, 5094); 
        }

    }
}