using System;
using System.Collections.Generic;

using SagaMap;
 
using SagaDB.Actors;
using SagaDB.Items;

namespace Alf_f03
{
    public class SeahIconium : Npc
    {
        public override void OnInit()
        {
            MapName = "Alf_f03";
            Type = 1249;
            Name = "Seah Iconium";
            StartX = -28029F;
            StartY = 8296F;
            StartZ = -381;
            Startyaw = 53811;
            SetScript(823);
            AddButton(Functions.Shop);
            AddButton(Functions.Smith);

//Goods
AddGoods(2588); AddGoods(51500002); AddGoods(51500003); AddGoods(51500004); AddGoods(51500005); AddGoods(51500006); AddGoods(51500007); AddGoods(51500008); AddGoods(51500009); AddGoods(51500010); AddGoods(51500011); AddGoods(51500012); AddGoods(51500013); AddGoods(51500014); AddGoods(51500015);

        }

        public void OnButton(ActorPC pc)
        {
            NPCChat(pc, 824);
        }

    }
}