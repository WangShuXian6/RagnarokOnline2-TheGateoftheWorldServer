using System;
using System.Collections.Generic;

using SagaMap;
using SagaDB.Actors;
using SagaDB.Items;

public class MulderLouth : Npc
{
    public override void OnInit()
    {
        MapName = "echo_f01";
        Type = 1304;
        Name = "Mulder Louth";
        StartX = 16122F;
        StartY = -40526F;
        StartZ = -23351F;
        Startyaw = 39073;
        SetScript(823);
        AddButton(Functions.EnterShip,new func(OnButton));

    }
    public void OnButton(ActorPC pc)
    {
        NPCChat(pc, 824);
        Warp(pc, 5, 13919F, 75806F, 5094); 
    }
}