﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BCA.Network.Packets.Enums
{
    public enum PacketType
    {
        ChatMessage,
        Register,
        Login,
        AddHubPlayer,
        RemoveHubPlayer,
        PlayerList,
        CommandError,
        Kick,
        Ban,
        Banlist,
        EnabledAccount,
        DisabledAccount,
        Mute,
        PrivateMessage,
        Profil,
        UpdateCollection,
        DuelRequest,
        DuelRequestAnswer,
        DuelHost,
        DuelStart,
        DuelJoin,
        PlayRanked,
        StopPlayRanked,
        UpdateRoom,
        AskBooster,
        PurchaseItem,
        Clear,
        MPAll,
        Panel,
        GivePoints,
        DonPoints,
        CardDonation,
        GiveCard,
        GiveAvatar,
        PanelUserlist,
        PanelUpdate,
        PanelAskProfile,
        Ranker,
        TradeRequest,
        TradeRequestAnswer,
        TradeMessage,
        TradeProposition,
        TradeExit,
        TradeAnswer,
        TradeEnd,
        ChangeAvatar,
        ChangeBorder,
        ChangeSleeve,
        GiveBorder,
        GiveSleeve,
        LoadAvatar,
        LoadBorders,
        LoadSleeves,
        LoadBrocante,
        SellBrocanteCard,
        BuyBrocanteCard,
        CloseBrocante,
        AskSelectCard,
        SearchCard,
        Help,
        Unban,
        Unmute,
        SpectatePlayer,
        NeedRoomPassword,
        GetBonus,
        DuelResult,
        AskTitle,
        ChangeTitle,
        GiveTitle,
        Maintenance,
        StopMaintenance,
        OfflineMessages,
        LoadPlayerCustomization,
        ResetStats,
        ChangeUsername,
        UsernameColor,
        BuyPrestigeCustom,
        BuyOwnCustom,
        BuyGreet,
        BuyVIP,
        BuyMonthPack,
        BuyDoubleBP,
        OpenPrestigeShop,
        GetCustomizationAchievement,
        AskPrestigeCustoms
    }
}