using System;
using System.Collections.Generic;

using SagaMap;
using SagaDB.Actors;
using SagaDB.Items;

public class WillhelmHowke : Npc
{
    public override void OnInit()
    {
        MapName = "Prt_f01";
        Type = 1282;
        Name = "Willhelm Howke";
        StartX = 14534F;
        StartY = 74875F;
        StartZ = 5094F;
        Startyaw = 17120;
        SetScript(823);
        AddButton(Functions.EnterShip,new func(OnButton));
    }

    public void OnButton(ActorPC pc)
    {
          Warp(pc, 13, 8615f, 1494f, 3988f);
    } 
}