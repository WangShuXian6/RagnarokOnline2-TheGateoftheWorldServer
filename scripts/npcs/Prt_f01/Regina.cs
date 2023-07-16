using System;
using System.Collections.Generic;

using SagaMap;
 
using SagaDB.Actors;
using SagaDB.Items;

namespace Prt_f01
{
    public class Regina : Npc
    {
        public override void OnInit()
        {
            MapName = "Prt_f01";
            Type = 1010;
            Name = "Regina Salisbury";
            StartX = 14982F;
            StartY = 77034F;
            StartZ = 5094;
            Startyaw = 44704;
            SetScript(3);

            AddButton(Functions.Supply);
            SupplyMenuID = 3;

//Exchange
// Create Bunny band
AddSupplyProduct(12,3465,1);
AddSupplyMatrial(12,9449,10); // Pearl x10
AddSupplyMatrial(12,9418,20); // Four leaf clover x20
AddSupplyMatrial(12,9410,10); // Tight Jellopy x10
AddSupplyMatrial(12,10475,20); // Rabbit Hair x20
//Add 1200Rufi

// Create Cat Mask
AddSupplyProduct(13,3485,1);
AddSupplyMatrial(13,9428,20); // Cat foot stamp x20
AddSupplyMatrial(13,9429,20); // Cat jewel x20
AddSupplyMatrial(13,9419,10); // Cat Bell x10
//Add 1200 Rufi

// Create Little Flower Headband
AddSupplyProduct(14,3484,1);
AddSupplyMatrial(14,1800000,20); // Black lace x20
AddSupplyMatrial(14,1700096,20); // Elegant fabric x20 -- Unsure on the item, used High Grade Fabric.
//Add 1200 Ruffi

// Create Laboratory Hat
AddSupplyProduct(15,3518,1);
AddSupplyMatrial(15,1700112,10); // Short leather x10
AddSupplyMatrial(15,1700009,10); // Hard Jellopy 10
//Add 1200 Ruffi
}

public void OnButton(ActorPC pc)
{
NPCChat(pc, 823);
}
}
}