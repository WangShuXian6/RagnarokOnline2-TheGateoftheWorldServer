  //////////////////////////////
 /// Npc Script Set by Chii ///
//////////////////////////////

using System;
using System.Collections.Generic;

using SagaMap;
 
using SagaDB.Actors;
using SagaDB.Items;

public class Redick : Npc
{
    public override void OnInit()
    {
        MapName = "Hod_f00";
        Type = 1139;
        Name = "Redick Dass";
        StartX = -4832F;
        StartY = 16992.0F;
        StartZ = 3904F;
        SetScript(1777);
        AddButton(Functions.EnterShip,new func(OnButton));
        AddButton(Functions.Smith);
        AddButton(Functions.Shop);


//Goods
AddGoods(2563); AddGoods(2566); AddGoods(2568); AddGoods(2575); AddGoods(2577); AddGoods(2578); AddGoods(2579); AddGoods(2580); AddGoods(2581); AddGoods(2582); AddGoods(2583); AddGoods(2584); AddGoods(2585); AddGoods(2586); AddGoods(2587); AddGoods(2588); AddGoods(2589); AddGoods(2590); AddGoods(2581);AddGoods(2580); AddGoods(2581); AddGoods(2582); AddGoods(51500002); AddGoods(51500003); AddGoods(51500004); AddGoods(51500005); AddGoods(51500006); AddGoods(51500007); AddGoods(51500008); AddGoods(51500009); AddGoods(51500010); AddGoods(51500011); AddGoods(51500012); AddGoods(51500013); AddGoods(51500014); AddGoods(51500015);


        }

        public void OnButton(ActorPC pc)
        {
            Warp(pc, 5, 13919F, 75806F, 5094); 
        }

    }