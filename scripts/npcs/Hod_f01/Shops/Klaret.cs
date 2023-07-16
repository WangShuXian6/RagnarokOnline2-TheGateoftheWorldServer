  //////////////////////////////
 /// Npc Script Set by Chii ///
//////////////////////////////

using System;
using System.Collections.Generic;

using SagaMap;
 
using SagaDB.Actors;
using SagaDB.Items;

public class Klaret : Npc//Shop
{
    public override void OnInit()
    {
        MapName = "Hod_f01";
        Type = 1001;
        Name = "Klaret Natali se Pruysenaere";
        StartX = -3680F;
        StartY = -5008F;
        StartZ = -8045F;
        Startyaw = 38000;
        SetScript(500);
        AddButton(Functions.EverydayConversation, new func(OnButton));
        AddButton(Functions.OfficialQuest, new func(OnQuest), true);
        AddButton(Functions.Shop);
        AddButton(Functions.Supply);
        SupplyMenuID = 10;
		
//Exchange
// Create Red Potion I
            AddSupplyProduct(46,51500003,1);
            AddSupplyMatrial(46,9406,1);
            AddSupplyMatrial(46,9500,1);
// Create Red Potion II
            AddSupplyProduct(47,51500004,1);
            AddSupplyMatrial(47,9406,1);
            AddSupplyMatrial(47,9500,1);
            AddSupplyMatrial(47,10490,1);
// Create Red Potion III
            AddSupplyProduct(48,51500005,1);
            AddSupplyMatrial(48,9406,1);
            AddSupplyMatrial(48,1700051,1);
            AddSupplyMatrial(48,9338,1);
// Create Red Potion IV
            AddSupplyProduct(49,51500006,1);
            AddSupplyMatrial(49,1700009,1);
            AddSupplyMatrial(49,1700051,1);
            AddSupplyMatrial(49,9338,1);
// Create Red Potion V
            AddSupplyProduct(50,51500007,1);
            AddSupplyMatrial(50,1700009,1);
            AddSupplyMatrial(50,1700051,1);
            AddSupplyMatrial(50,1700075,1);
// Create Red Potion VI
            AddSupplyProduct(51,51500008,1);
            AddSupplyMatrial(51,1700009,1);
            AddSupplyMatrial(51,1700097,1);
            AddSupplyMatrial(51,1700078,1);
// Create Red Potion VII
            AddSupplyProduct(52,51500009,1);
            AddSupplyMatrial(52,1700009,1);
            AddSupplyMatrial(52,1700097,1);
            AddSupplyMatrial(52,1700079,1);
// Create Red Potion VIII
            AddSupplyProduct(53,51500010,1);
            AddSupplyMatrial(53,1700009,1);
            AddSupplyMatrial(53,1700097,1);
            AddSupplyMatrial(53,1700088,1);
// Create Blue Potion I
            AddSupplyProduct(54,51500013,1);
            AddSupplyMatrial(54,1700009,1);
            AddSupplyMatrial(54,9453,1);
            AddSupplyMatrial(54,10446,1);
            AddSupplyMatrial(54,1700013,1);
// Create Blue Potion II
            AddSupplyProduct(55,51500014,1);
            AddSupplyMatrial(55,1700009,1);
            AddSupplyMatrial(55,2686,1);
            AddSupplyMatrial(55,1700077,1);
            AddSupplyMatrial(55,1700078,1);
			

//Goods
AddGoods(4101); AddGoods(2575); AddGoods(51500002); AddGoods(51500003); AddGoods(51500004); AddGoods(51500005); AddGoods(51500006); AddGoods(51500007); AddGoods(51500008); AddGoods(51500009); AddGoods(51500010); AddGoods(51500011); AddGoods(51500012); AddGoods(5000); AddGoods(5001); AddGoods(5002); 
AddGoods(5003); AddGoods(5004); AddGoods(5005); AddGoods(5006); AddGoods(5007); AddGoods(5008); AddGoods(5009); AddGoods(5010); AddGoods(5011); AddGoods(5012); AddGoods(5013); AddGoods(5014); AddGoods(5015); AddGoods(5016); AddGoods(5017); AddGoods(5018); AddGoods(5019); AddGoods(5020); AddGoods(5021); AddGoods(5022); AddGoods(5023); AddGoods(5024); AddGoods(5025); AddGoods(5026); AddGoods(5027); AddGoods(5028); AddGoods(5029); AddGoods(5030); AddGoods(7536); AddGoods(7537); AddGoods(7538); AddGoods(7539); AddGoods(7539); AddGoods(7540); AddGoods(7541); AddGoods(7542); AddGoods(7543); AddGoods(7544); AddGoods(7545); AddGoods(7546); AddGoods(7547); AddGoods(7548); AddGoods(7549); AddGoods(7550); AddGoods(7551); AddGoods(7552); AddGoods(7553); AddGoods(7554); AddGoods(7555); AddGoods(7556); AddGoods(7557); AddGoods(7558); AddGoods(7559); AddGoods(7560); AddGoods(7561); AddGoods(7562); AddGoods(7563); AddGoods(7564); AddGoods(7565); AddGoods(7566); AddGoods(7567); AddGoods(7568); AddGoods(7569); AddGoods(7570); AddGoods(7571); AddGoods(7572); AddGoods(7573); AddGoods(7618); AddGoods(7619); AddGoods(7620); AddGoods(7621); AddGoods(7622); AddGoods(7623); AddGoods(7624); AddGoods(7625); AddGoods(7626); AddGoods(7627); AddGoods(7628); AddGoods(7629); AddGoods(7630); AddGoods(7631); AddGoods(7632); AddGoods(7633); AddGoods(7634); AddGoods(7635); AddGoods(7636); AddGoods(7637); AddGoods(7638); AddGoods(7639); AddGoods(7640); AddGoods(7641); AddGoods(7642); AddGoods(7643); AddGoods(7644); AddGoods(7645); AddGoods(7646); AddGoods(7647); AddGoods(7648); AddGoods(7649); AddGoods(7650); AddGoods(7651); AddGoods(7652); AddGoods(7653); AddGoods(7654); AddGoods(7655); AddGoods(7656); AddGoods(7716); AddGoods(7717); AddGoods(7718); AddGoods(7719); AddGoods(7720); AddGoods(7721); AddGoods(7722); AddGoods(7723); AddGoods(7724); AddGoods(7725); AddGoods(7726); 
//Quest Steps
AddQuestStep(334, 33402, StepStatus.Active);        
    }

    public void OnButton(ActorPC pc)
    {
        NPCChat(pc, 944);
    }

    public void OnQuest(ActorPC pc)
    {
        if (GetQuestStepStatus(pc, 334, 33402) == StepStatus.Active)
        {
            if (CountItem(pc, 2653) == 0)
            {
                UpdateIcon(pc);
                GiveItem(pc, 2653, 1);
                NPCSpeech(pc, 238);
                NPCChat(pc, 0);
            }
        }
    }
}