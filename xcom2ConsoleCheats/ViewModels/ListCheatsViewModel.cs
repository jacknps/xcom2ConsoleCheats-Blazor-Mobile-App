﻿using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using xcom2ConsoleCheats.Models;

namespace xcom2ConsoleCheats.ViewModels
{
    public class ListCheatsViewModel
    {
        public async Task<IReadOnlyList<CheatEntryModel>> GetAllCheatEntriesAsync()
        {
            return await Task.Run(() =>
            {
                return new List<CheatEntryModel> {
                new CheatEntryModel
                {
                    Cheat = "PowerUp", Description = "Godmode, infinite HP, infinite clip, infinite AP."
                },
new CheatEntryModel
                {
                    Cheat = "TakeNoDamage", Description = "Infinite HP only; weapons reload."
                },
new CheatEntryModel
                {
                    Cheat = "ForceCritHits", Description = "Forces Critical Hits(It works for the AI too)"
                },
                new CheatEntryModel
                {
                    Cheat = "GiveActionPoints #", Description = "Adds # amount of action points to the selected Unit. (Note: You need at least 2 AP to shoot with a sniper rifle)"
                },
new CheatEntryModel
                {
                    Cheat = "LevelUpBarracks #", Description = "Level up all soldiers in the Barracks by # of ranks."
                },
new CheatEntryModel
                {
                    Cheat = "HealAllSoldiers", Description = "On ship view, heals all wounded soldiers. (does not heal Shaken)"
                },
new CheatEntryModel
                {
                    Cheat = "Togglefow", Description = "Reveals map; Enemies remain hidden."
                },
new CheatEntryModel
                {
                    Cheat = "ToggleSquadConcealment", Description = "Conceals your squad. (Note: Enemy will still be on alert)"
                },
new CheatEntryModel
                {
                    Cheat = "ToggleUnlimitedActions", Description = "Infinite AP(Note: DISABLE before ending your turn.The AI will use it too.)"
                },
new CheatEntryModel
                {
                    Cheat = "ToggleUnlimitedAmmo", Description = "Infinite Clip & Grenades(Pretty sure AI will use it too)"
                },
new CheatEntryModel
                {
                    Cheat = "RemoveFortressDoom #", Description = "Remove Avatar Project bars by #"
                },
new CheatEntryModel
                {
                    Cheat = "RestartLevel", Description = "Restarts the current mission"
                },
new CheatEntryModel
                {
                    Cheat = "TTC", Description = "Teleport to cursor; use command in battle to teleport the selected unit to your mouse pointer."
                },
new CheatEntryModel
                {
                    Cheat = "TATC", Description = "Teleport all to cursor; use command in battle to teleport all units to your mouse pointer."
                }
}.AsReadOnly();
            });
        }
    }
}
