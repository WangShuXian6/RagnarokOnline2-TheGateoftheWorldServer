using System;
using System.Collections.Generic;

using SagaMap;
using SagaDB.Actors;
using SagaDB.Items;

public class GaborKlein : Npc
{
    public override void OnInit()
    {
        MapName = "Prt_f01";
        Type = 1281;
        Name = "Gabor Klein";
        StartX = 13175F;
        StartY = 74270F;
        StartZ = 5094F;
        Startyaw = 33569;
        SetScript(823);
        AddButton(Functions.EnterShip,new func(OnButton));
        AddButton(Functions.Smith);
    }
    public void OnButton(ActorPC pc)
    {
        NPCChat(pc, 824);
        Warp(pc, 13, 8576F, 1419F, -3988); 
    }
}