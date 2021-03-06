﻿using FFXIVCraftingSimLib.Actions.Buffs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FFXIVCraftingSimLib.Actions.Buffs
{
    public class NameOfTheElementsBuff : CraftingBuff
    {
        public override string Name => "Name of the Elements";

        public override void Step(CraftingSim sim)
        {
            Stack--;
            if (Stack == 0)
                NeedsRemove = true;
        }

        public override void Remove(CraftingSim sim)
        {
            sim.NameOfTheElementsBuff = null;
            base.Remove(sim);
        }

        public override CraftingBuff Clone()
        {
            return new NameOfTheElementsBuff { Stack = Stack, NeedsRemove = NeedsRemove };
        }
    }

    
}
