﻿using Qurre.API.Objects;
using System;
using System.Reflection;
namespace Qurre.API
{
    public static class Player
    {
        public static System.Collections.Generic.Dictionary<int, ReferenceHub> IdHubs;
        public static System.Collections.Generic.Dictionary<string, ReferenceHub> StrHubs;
         
        public static MethodInfo SendSpawnMessage { get; }

        public static void AddAHP(this ReferenceHub player, float amount);
        public static void AddHP(this ReferenceHub player, float amount);
        public static void AddItem(this ReferenceHub player, Inventory.SyncItemInfo item);
        public static void AddItem(this ReferenceHub player, ItemType itemType);
        public static void AddItem(this ReferenceHub player, ItemType itemType, float duration = float.NegativeInfinity, int sight = 0, int barrel = 0, int other = 0);
        public static void Ban(this ReferenceHub player, int duration, string reason, string issuer = "API");
        public static void Ban(this global::UnityEngine.GameObject player, int duration, string reason, string issuer = "API");
        public static void BodyDelete(this ReferenceHub player);
        public static void Broadcast(this ReferenceHub player, ushort time, string message, Broadcast.BroadcastFlags flag = 0);
        public static void ChangeModel(this ReferenceHub player, RoleType newModel, System.Collections.Generic.List<ReferenceHub> newList);
        public static void ClearBroadcasts(this ReferenceHub player);
        public static void ClearInventory(this ReferenceHub player);
        public static void Damage(this ReferenceHub player, int amount, DamageTypes.DamageType damageType);
        public static void Disconnect(this ReferenceHub player, string reason = null);
        public static void DropItem(this ReferenceHub player, Inventory.SyncItemInfo item);
        public static ReferenceHub Get(int playerId);
        public static ReferenceHub Get(this global::UnityEngine.GameObject player);
        public static ReferenceHub Get(string args);
        public static float GetAHP(this ReferenceHub player);
        public static System.Collections.Generic.List<Inventory.SyncItemInfo> GetAllItems(this ReferenceHub player);
        public static string GetBadgeName(this ReferenceHub rh);
        public static bool GetBypassMode(this ReferenceHub player);
        public static global::Mirror.NetworkConnection GetConnection(this ReferenceHub player);
        public static int GetCufferId(this ReferenceHub rh);
        public static Inventory.SyncItemInfo GetCurrentItem(this ReferenceHub player);
        public static Room GetCurrentRoom(this ReferenceHub player);
        public static GlobalBadge GetGlobalBadge(this ReferenceHub player);
        public static bool GetGodMode(this ReferenceHub player);
        public static UserGroup GetGroup(this ReferenceHub player);
        public static string GetGroupName(this ReferenceHub player);
        public static bool GetHandCuffer(this ReferenceHub player);
        public static float GetHP(this ReferenceHub player);
        public static System.Collections.Generic.IEnumerable<ReferenceHub> GetHubs();
        public static System.Collections.Generic.IEnumerable<ReferenceHub> GetHubs(this RoleType role);
        public static System.Collections.Generic.IEnumerable<ReferenceHub> GetHubs(this Team team);
        public static string GetIpAddress(this ReferenceHub player);
        public static float GetMaxAHP(this ReferenceHub player);
        public static float GetMaxHP(this ReferenceHub player);
        public static string GetNickname(this ReferenceHub player);
        public static int GetPlayerId(this ReferenceHub player);
        public static global::UnityEngine.Vector3 GetPosition(this ReferenceHub player);
        public static RoleType GetRole(this ReferenceHub player);
        public static global::UnityEngine.Vector2 GetRotations(this ReferenceHub player);
        public static global::UnityEngine.Vector3 GetRotationVector(this ReferenceHub player);
        public static global::UnityEngine.Vector3 GetScale(this ReferenceHub player);
        public static Side GetSide(this ReferenceHub hub);
        public static Side GetSide(this Team team);
        public static Side GetSide(this RoleType type);
        public static Team GetTeam(this RoleType roleType);
        public static Team GetTeam(this ReferenceHub player);
        public static string GetUserId(this ReferenceHub player);
        public static void Handcuff(this ReferenceHub player, ReferenceHub target);
        public static void Heal(this ReferenceHub player);
        public static void Heal(this ReferenceHub player, float amount);
        public static void IntercomMute(this ReferenceHub player);
        public static void IntercomUnmute(this ReferenceHub player);
        public static void InvokeStaticMethod(this Type type, string methodName, object[] param);
        public static bool IsCuffed(this ReferenceHub rh);
        public static bool IsHandCuffed(this ReferenceHub player);
        public static bool IsHost(this ReferenceHub player);
        public static bool IsIntercomMuted(this ReferenceHub player);
        public static bool IsMuted(this ReferenceHub player);
        public static bool IsReloading(this ReferenceHub player);
        public static bool IsZooming(this ReferenceHub player);
        public static bool ItsNTF(this ReferenceHub hub);
        public static bool ItsScp(this ReferenceHub hub);
        public static void Kick(this ReferenceHub player, string reason, string issuer = "API");
        public static void Kick(this global::UnityEngine.GameObject player, string reason, string issuer = "API");
        public static void Kill(this ReferenceHub player, DamageTypes.DamageType damageType = null);
        public static void Mute(this ReferenceHub player);
        public static bool OfflineBan(string ip, string id, string Nick, int duration, string reason, string AdminNick);
        public static bool Overwatch(this ReferenceHub player);
        public static void Overwatch(this ReferenceHub player, bool over);
        public static void PlayReloadAnimation(System.Collections.Generic.List<ReferenceHub> players);
        public static void RAMessage(this CommandSender sender, string message, bool success = true, string pluginName = null);
        public static void RemoveItem(this ReferenceHub player, Inventory.SyncItemInfo item);
        public static void SendConsoleMessage(this ReferenceHub player, string message, string color);
        public static void SetAHP(this ReferenceHub player, float amount);
        public static void SetBypassMode(this ReferenceHub player, bool isEnabled);
        public static void SetCufferId(this ReferenceHub rh, int id);
        public static void SetCurrentItem(this ReferenceHub player, ItemType itemType);
        public static void SetFriendlyFire(this ReferenceHub player, bool value);
        public static void SetGodMode(this ReferenceHub player, bool enable);
        public static void SetGroup(this ReferenceHub player, string name, string color, bool show);
        public static void SetGroup(this ReferenceHub player, string name, string color, bool show, string rankName);
        public static void SetGroup(this ReferenceHub player, UserGroup userGroup);
        public static void SetGroupColor(this ReferenceHub player, string color);
        public static void SetGroupName(this ReferenceHub player, string name);
        public static void SetHP(this ReferenceHub player, float amount);
        public static void SetInventory(this ReferenceHub player, System.Collections.Generic.List<Inventory.SyncItemInfo> items);
        public static float SetMaxAHP(this ReferenceHub player, int amount);
        public static void SetMaxHP(this ReferenceHub player, float amount);
        public static void SetNickname(this ReferenceHub player, string nickname);
        public static void SetPlayerId(this ReferenceHub player, int newId);
        public static void SetPosition(this ReferenceHub player, float x, float y, float z);
        public static void SetPosition(this ReferenceHub player, global::UnityEngine.Vector3 position);
        public static void SetRole(this ReferenceHub player, RoleType newRole, bool keepPosition);
        public static void SetRole(this ReferenceHub player, RoleType newRole);
        public static void SetRotation(this ReferenceHub player, global::UnityEngine.Vector2 rotations);
        public static void SetRotation(this ReferenceHub player, float x, float y);
        public static void SetScale(this ReferenceHub player, global::UnityEngine.Vector3 scale);
        public static void SetScale(this ReferenceHub player, float x, float y, float z);
        public static void SetScale(this ReferenceHub player, float scale);
        public static void SetUserId(this ReferenceHub player, string newId);
        public static void ShowHint(string text, float duration = 1);
        public static void SizeCamera(this ReferenceHub player, global::UnityEngine.Vector3 size);
        public static void SizeModel(this ReferenceHub player, global::UnityEngine.Vector3 size);
        public static Stamina Stamina(this ReferenceHub rh);
        public static void Uncuff(this ReferenceHub player);
        public static void Unmute(this ReferenceHub player);
    }
}