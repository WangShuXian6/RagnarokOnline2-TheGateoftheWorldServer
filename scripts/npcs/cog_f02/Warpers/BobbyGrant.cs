using System;
using System.Collections.Generic;

using SagaMap;
using SagaDB.Actors;
using SagaDB.Items;


namespace cog_f02
{
public class BobbyGrant : Npc
{
    public override void OnInit()
    {
        MapName = "cog_f02";
        Type = 1298;
        Name = "Bobby Grant";
        StartX = -42931F;
        StartY = -41613F;
        StartZ = -23099F;
        Startyaw = 17392;
        SetScript(823);
        AddButton(Functions.EnterShip,new func(OnButton));
        AddButton(Functions.Smith);
    }

    public void OnButton(ActorPC pc)
    {
          Warp(pc, 15, -46344f, -5472f, -6092f);
    } 
}
}