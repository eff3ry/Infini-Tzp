using System;
using HarmonyLib;

namespace LethalCompanyTemplate.Patches
{
    [HarmonyPatch(typeof(TetraChemicalItem))]
    public class Patch
    {
        [HarmonyPatch("Update")]
        [HarmonyPostfix]
        public static void Update(ref float _fuel)
        {
            _fuel = 1;
        }
    }
}

