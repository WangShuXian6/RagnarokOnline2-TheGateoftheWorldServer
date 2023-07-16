   //////////////////////////////////
  ///        Chii 15/01/08       ///
 ///      Headgear Gambler      ///
//////////////////////////////////

//Chii Note: This is a custom script and calls corresponding custom npcScripts from NpcScripts.pak

using SagaMap;
using SagaDB.Actors;
using SagaDB.Items;
using System;

public class ChiiGambler : Npc
{

int[] items = new int[] {3581,3607,3794,3799,3540,3793,3604,3541,3556,3561,3599,3612,3542,3600,3539,3563,3790,3597,3573,4800000,3559,3587,3557,3583,3570,3555,3550,3553,3568,3562,3565,3537,3791,3796,3605,4800002,4800003,670010,3795,3797,3586,3552,19599,3602,3590,3610,3576,3579,3534,3558,3601,3547,3582,3593,3596,3613,3571,3538,3569,3792,3585,3535,3560,3566,3575,3595,3608,3543,3594,3544,3598,3554,3536,3798,3609,3591,3551,3580,3493,3514,3548,3525,3475,3521,3496,3494,3516,670004,10006,10005,3457,10007,3520,3528,3492,670007,3471,3513,3478,3489,3574,3500,3549,3449,670009,3578,3507,10004,3481,3456,670005,10013,670003,3506,3512,3529,3502,3436,670006,3510,3435,3519,3465,3486,3495,670008,3487,3517,3461,3515,3788,3448,3466,10001,3463,10003,10002,10000,3483,10010,10011,10014,10012,19602,3468,10008,3469,3484,3440,3518,3505,3459,3441,3524,3438,3523,3445,3787,3470,3511,3498,3490,3439,10015,3786,3504,3451,10009,3454,3503,3522,3785,3479,3452,19603,3526,3527,3784,3497,3455,3464,3530,3485,3447};

	public override void OnInit()
	{
	MapName = "Prt_f01";
		Type = 1240;
		Name = "ChiiGambler";
		StartX = 9724F;
		StartY = 74615;
		StartZ = 5188;
		Startyaw = 575;
		SetScript(60000004);
		AddButton(Functions.EverydayConversation, new func(function));
		AddButton(Functions.OfficialQuest, new func(OnButton));
	}

	public void function(ActorPC pc)
	{
		int fare = (int)((pc.cLevel*pc.cLevel)*10);
		NPCChat(pc, 60000005);
//		pc.e.OnSendWhisper(pc.name, "I'll charge you "+fare+" zeny. Deal?", 1);
	}
	public void OnButton(ActorPC pc)
	{
		int fare = (int)((pc.cLevel*pc.cLevel)*10);

		if(pc.cLevel>=30){
		if(pc.zeny>=fare*10000)
		{
			
			TakeZeny(pc,(uint)(fare*10000));
			Random RandomClass = new Random();
			int id = RandomClass.Next(items.Length);
			GiveItem(pc,items[id],1);
			NPCChat(pc, 60000006);
		}

		else
		NPCChat(pc, 60000007);
		}
		else
		NPCChat(pc, 60000008);
	}
}