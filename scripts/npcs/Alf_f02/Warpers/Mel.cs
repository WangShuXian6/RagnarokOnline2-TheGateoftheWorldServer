using System;
using System.Collections.Generic;

using SagaMap;
 
using SagaDB.Actors;
using SagaDB.Items;

namespace Alf_f02
{
    public class Mel : Npc
    {
        public override void OnInit()
        {
            MapName = "Alf_f02";
            Type = 1310;
            Name = "Mel";
            StartX = 3539F;
            StartY = 6718F;
            StartZ = 878;
            Startyaw = 58539;
            SetScript(823);
            AddButton(Functions.EnterShip,new func(OnButton));
        }

        public void OnButton(ActorPC pc)
        {
            NPCChat(pc, 823);
            Warp(pc, 5, 13919F, 75806F, 5094); 
        }

    }
}