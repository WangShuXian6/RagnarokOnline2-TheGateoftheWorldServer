   //////////////////////////////////
  ///        Chii 21/11/07       ///
 ///      Cognito Npc-Pack      ///
//////////////////////////////////

using System;
using System.Collections.Generic;

using SagaMap;
 
using SagaDB.Actors;
using SagaDB.Items;

public class Yan : Npc
{
    public override void OnInit()
    {
        MapName = "cog_f01_02";
        Type = 1181;
        Name = "Yan";
        StartX = 8908F;
        StartY = 1295F;
        StartZ = -3988F;
        Startyaw = 25751;
        SetScript(823);
        AddButton(Functions.EnterShip,new func(OnButton));
        AddButton(Functions.Smith);
    }

    public void OnButton(ActorPC pc)
    {
          Warp(pc, 5, 13919f, 75806f, 5094.054f);
    } 
}