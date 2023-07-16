using System;
using System.Collections.Generic;

using SagaMap;
 
using SagaDB.Actors;
using SagaDB.Items;

public class Jerad : Npc
{
    public override void OnInit()
    {
        MapName = "cog_f03";
        Type = 1219;
        Name = "Jerad";
        StartX = 693F;
        StartY = 23840F;
        StartZ = -7667.944F;
        Startyaw = 60000;
        SetScript(823);
        AddButton(Functions.Shop);
        AddButton(Functions.Smith);
        AddButton(Functions.EnterShip,new func(OnButton));

//Goods
AddGoods(51500002); AddGoods(51500003); AddGoods(51500004); AddGoods(51500005); AddGoods(51500006); AddGoods(51500007); AddGoods(51500008); AddGoods(51500009); AddGoods(51500010); AddGoods(51500011); AddGoods(51500012); AddGoods(51500013); AddGoods(51500014); AddGoods(51500015);
        }
    public void OnButton(ActorPC pc)
    {
        NPCChat(pc, 823);
        Warp(pc, 5, 13919F, 75806F, 5094); 
    }
}
