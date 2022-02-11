﻿using Qurre.API.Events;
using Qurre.Events.Modules;
namespace Qurre.Events
{
    public static class Scp049
    {
        public static event Main.AllEvents<StartRecallEvent> StartRecall;
        public static event Main.AllEvents<FinishRecallEvent> FinishRecall;
    }
    public static class Scp079
    {
        public static event Main.AllEvents<GeneratorActivateEvent> GeneratorActivate;
        public static event Main.AllEvents<GetEXPEvent> GetEXP;
        public static event Main.AllEvents<GetLVLEvent> GetLVL;
        public static event Main.AllEvents<ChangeCameraEvent> ChangeCamera;
        public static event Main.AllEvents<Scp079InteractDoorEvent> InteractDoor;
        public static event Main.AllEvents<Scp079LockDoorEvent> LockDoor;
        public static event Main.AllEvents<Scp079SpeakerEvent> Speaker;
        public static event Main.AllEvents<Scp079ElevatorTeleportEvent> ElevatorTeleport;
        public static event Main.AllEvents<Scp079InteractLiftEvent> InteractLift;
        public static event Main.AllEvents<Scp079InteractTeslaEvent> InteractTesla;
        public static event Main.AllEvents<Scp079LockdownEvent> Lockdown;
    }
    public static class Scp096
    {
        public static event Main.AllEvents<EnrageEvent> Enrage;
        public static event Main.AllEvents<WindupEvent> Windup;
        public static event Main.AllEvents<CalmDownEvent> CalmDown;
        public static event Main.AllEvents<AddTargetEvent> AddTarget;
        public static event Main.AllEvents<PreWindupEvent> PreWindup;
        public static event Main.AllEvents<EndPryGateEvent> EndPryGate;
        public static event Main.AllEvents<StartPryGateEvent> StartPryGate;
    }
    public static class Scp106
    {
        public static event Main.AllEvents<PortalUsingEvent> PortalUsing;
        public static event Main.AllEvents<PortalCreateEvent> PortalCreate;
        public static event Main.AllEvents<ContainEvent> Contain;
        public static event Main.AllEvents<FemurBreakerEnterEvent> FemurBreakerEnter;
        public static event Main.AllEvents<PocketEnterEvent> PocketEnter;
        public static event Main.AllEvents<PocketEscapeEvent> PocketEscape;
        public static event Main.AllEvents<PocketFailEscapeEvent> PocketFailEscape;
    }
    public static class Scp173
    {
        public static event Main.AllEvents<BlinkEvent> Blink;
        public static event Main.AllEvents<TantrumPlaceEvent> TantrumPlace;
    }
    public static class Scp914
    {
        public static event Main.AllEvents<ActivatingEvent> Activating;
        public static event Main.AllEvents<KnobChangeEvent> KnobChange;
        public static event Main.AllEvents<UpgradeEvent> Upgrade;
        public static event Main.AllEvents<UpgradePlayerEvent> UpgradePlayer;
        public static event Main.AllEvents<UpgradePickupEvent> UpgradePickup;
        public static event Main.AllEvents<UpgradedItemInventoryEvent> UpgradedItemInventory;
        public static event Main.AllEvents<UpgradedItemPickupEvent> UpgradedItemPickup;
    }
}