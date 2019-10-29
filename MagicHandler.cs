﻿using System;
using System.Collections.Generic;
using System.Text;

namespace RoR2Cheats
{
    internal static class Lang
    {
        //() denotes a list of specifc choices. : denotes a default. [] denotes a collection, and {} denotes freeform
        internal const string
            ADDPORTAL_ARGS = "Requires 1 argument: add_portal (blue|celestial|gold)",
            CHANGETEAM_ARGS = "Requires 1 argument: change_team {TeamIndex:0/Neutral} ({PlayerID:self}|{Playername})",
            CREATEPICKUP_ARGS = "Requires 1 argument: " + CREATEPICKUP_NAME + "(\"coin\"|{localised_object_name}) (\"item\"|\"equip\")",
            FAMILYEVENT_ARGS = "Requires 0 arguments: family_event",
            FIXEDTIME_ARGS = "Requires 1 argument: fixed_time {NewTime}",
            GIVEEQUIP_ARGS = "Requires 1 argument: give_equip {localised_object_name} ({PlayerID:self}|{Playername})",
            GIVEITEM_ARGS = "Requires 1 argument: give_item {localised_object_name} {Count:1} ({PlayerID:self}|{Playername})",
            GIVELUNAR_ARGS = "Requires 0 arguments: give_lunar {Count:1}",
            GIVEMONEY_ARGS = "Requires 1 argument: give_money {Count} ({PlayerID:self}|{Playername}|\"all\")",
            GOD_ARGS = "Requires 0 arguments: god",
            KILLALL_ARGS = "Requires 0 arguments: kill_all {TeamIndex:2/Monster}",
            NEXTBOSS_ARGS = "Requires 1 argument: next_boss ({localised_object_name}|{DirectorCard}) {(int)Count:1} {EliteIndex:-1/None}",
            NEXTSTAGE_ARGS = "Requires 0 arguments: next_stage {Stage}",
            NOENEMIES_ARGS = "Requires 0 arguments: no_enemies",
            REMOVEITEM_ARGS = "Requires 1 argument: remove_item {localised_object_name} ({Count}|\"all\") ({PlayerID:self}|{Playername})",
            REMOVEEQUIP_ARGS = "Requires 0 arguments: remove_equip ({PlayerID:self}|{Playername})",
            RESPAWN_ARGS = "Requires 0 arguments: respawn ({PlayerID:self}|{Playername})",
            SEED_ARGS = "Requires no or 1 argument: seed [new seed]",
            SPAWNAI_ARGS = "Requires 1 argument: spwan_ai {localised_objectname} [EliteIndex:-1/None] [TeamIndex:0/Neutral] [Braindead:0(0|1)]",
            SPAWNAS_ARGS = "Requires 1 argument: spawn_as {localised_objectname} ({PlayerID:self}|{Playername})",
            SPAWNBODY_ARGS = "Requires 1 argument: spawn_body {localised_objectname}",
            TIMESCALE_ARGS = "Requires 1 argument: time_scale {TimeIncrement}",
            TRUEKILL_ARGS = "Requires 0 arguments: true_kill ({PlayerID:self}|{Playername})"
            ;

        internal const string
            LISTITEM_ARGS = "List all item names and their IDs",
            LISTEQUIP_ARGS = "List all equipment items and their IDs",
            LISTAI_ARGS = "List all Masters and their language invariants",
            LISTBODY_ARGS  = "List all Bodies and their language invariants",
            LISTPLAYER_ARGS = "List all players and their ID"
            ;

        internal const string
            CREATEPICKUP_AMBIGIOUS_2 = "Could not choose between {0} and {1}, please be more precise. Consider using 'equip' or 'item' as the first argument.",
            CREATEPICKUP_NAME = "create_pickup",
            CREATEPICKUP_NOTFOUND = "Could not find any item nor equipment with that name. It's not a coin either.",
            CREATEPICKUP_SUCCES_1 = "Succesfully created the pickup {0}.",
            COUNTISNUMERIC = "Count must be numeric!",
            GIVELUNAR_2 = "{0} {1} lunar coin(s).",
            INTEGER_EXPECTED = "Argument must be a whole number.",
            OBJECT_NOTFOUND = "The requested object could not be found: ",
            OBSOLETEWARNING = "This command has become obsolete and will be removed in the next version. ",
            NETWORKING_OTHERPLAYER_4 = "{0}({1}) issued: {2} {3}",
            NEXTROUND_STAGE = "Invalid Stage. Please choose from the following: ",
            NOMESSAGE = "Yell at the modmakers if you see this message!",
            PARTIALIMPLEMENTATION_WARNING = "WARNING: PARTIAL IMPLEMENTATION. WIP.",
            PLAYER_DEADRESPAWN = "Player is dead and cannot respawn.",
            PLAYER_NOTFOUND = "Specified player does not exist",
            PORTAL_NOTFOUND = "The specified portal could not be found.",
            RUNSETSTAGESCLEARED_HELP = "Sets the amount of stages cleared. This does not change the current stage.",
            SPAWN_ATTEMPT = "Attempting to spawn: ",
            SPAWN_ERROR = "Could not spawn: ",
            ALL = "ALL"
            ;
    }
    internal static class Number
    {

    }
}
