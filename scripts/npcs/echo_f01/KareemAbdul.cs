using System;
using System.Collections.Generic;

using SagaMap;
 
using SagaDB.Actors;
using SagaDB.Items;

namespace echo_f01
{
    public class KareemAbdul : Npc
    {
        public override void OnInit()
        {
            MapName = "echo_f01";
            Type = 1259;
            Name = "Kareem Abdul";
            StartX = 15540F;
            StartY = -45664F;
            StartZ = -23326;
            Startyaw = 14464;
            SetScript(823);
            AddButton(Functions.Shop);

//Goods
AddGoods(2589); AddGoods(2590); AddGoods(51500005); AddGoods(51500006); AddGoods(51500007); AddGoods(51500008); AddGoods(51500009); AddGoods(51500010); AddGoods(51500014); AddGoods(51500015); AddGoods(100099); AddGoods(100100); AddGoods(100101); AddGoods(400089); AddGoods(400090); AddGoods(400091); AddGoods(300139); AddGoods(300140); AddGoods(300141); AddGoods(500119); AddGoods(500120); AddGoods(500121); AddGoods(570282); AddGoods(570283); AddGoods(570284); AddGoods(700129); AddGoods(700130); AddGoods(800113); AddGoods(800114); AddGoods(2010004); AddGoods(2010013); AddGoods(2010022); AddGoods(2010037); AddGoods(2010046); 
AddGoods(200023); AddGoods(200024); AddGoods(200025); AddGoods(200026); AddGoods(200027); AddGoods(530081); AddGoods(530080); AddGoods(530079); AddGoods(400044); AddGoods(100210); AddGoods(7283); AddGoods(7373); AddGoods(7508); AddGoods(100048); AddGoods(7508); AddGoods(100022); AddGoods(16043); AddGoods(16023); AddGoods(7508); AddGoods(16003);
 AddGoods(15993); AddGoods(15983); AddGoods(15963); AddGoods(15953); AddGoods(15943); AddGoods(15923); AddGoods(15913); AddGoods(15903); AddGoods(15923); AddGoods(15923); AddGoods(15863); AddGoods(15873); AddGoods(15883); AddGoods(1200627); AddGoods(1200948); AddGoods(1200930); AddGoods(1200914); AddGoods(1200930); AddGoods(800050); AddGoods(800051);  AddGoods(800052); AddGoods(800053); AddGoods(800054); AddGoods(800055); AddGoods(530059); AddGoods(530060); AddGoods(530061); AddGoods(530062); AddGoods(530063); AddGoods(530064); AddGoods(530065); AddGoods(530066); AddGoods(530067); AddGoods(530068); AddGoods(530069); AddGoods(530070);

        }

        public void OnButton(ActorPC pc)
        {
            NPCChat(pc, 824);
        }

    }
}