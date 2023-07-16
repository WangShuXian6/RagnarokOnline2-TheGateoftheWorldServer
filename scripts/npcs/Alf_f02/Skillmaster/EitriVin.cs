using System;
using System.Collections.Generic;

using SagaMap;
 
using SagaDB.Actors;
using SagaDB.Items;

namespace Alf_f02
{
    public class EitriVin : Npc
    {
        public override void OnInit()
        {
            MapName = "Alf_f02";
            Type = 1248;
            Name = "Eitri Vin";
            StartX = 3416F;
            StartY = 6270F;
            StartZ = -901;
            Startyaw = 0;
            SetScript(824);
            AddButton(Functions.Shop);
            AddButton(Functions.Smith);
    
//Goods
AddGoods(51500002); AddGoods(51500003); AddGoods(51500004); AddGoods(51500005); AddGoods(51500006); AddGoods(51500007); AddGoods(51500008); AddGoods(51500009); AddGoods(51500010); AddGoods(51500011); AddGoods(51500012); AddGoods(51500013); AddGoods(51500014); AddGoods(51500015); 
        }

        public void OnButton(ActorPC pc)
        {
            NPCChat(pc, 823);
        }

    }
}