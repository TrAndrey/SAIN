﻿using Aki.Reflection.Patching;
using EFT;
using HarmonyLib;
using SAIN_Grenades.Components;
using System.Reflection;

namespace SAIN_Grenades.Patches
{
    public class AddComponentPatch : ModulePatch
    {
        protected override MethodBase GetTargetMethod()
        {
            return AccessTools.Method(typeof(BotOwner), "PreActivate");
        }

        [PatchPostfix]
        public static void PatchPostfix(ref BotOwner __instance)
        {
            __instance.gameObject.AddComponent<TalkComponent>();
        }
    }
}