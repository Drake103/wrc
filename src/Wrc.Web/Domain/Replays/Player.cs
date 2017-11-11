﻿namespace Wrc.Web.Domain.Replays
{
    public class Player
    {
        public int Id { get; set; }
        public PlayerUser PlayerUser { get; set; }
        public double PlayerElo { get; set; }
        public int PlayerRank { get; set; }
        public int PlayerLevel { get; set; }
        public string PlayerName { get; set; }
        public string PlayerTeamName { get; set; }
        public string PlayerAvatar { get; set; }
        public string PlayerIALevel { get; set; }
        public bool PlayerReady { get; set; }
        public string PlayerDeckName { get; set; }
        public string PlayerDeckContent { get; set; }
        public int PlayerAlliance { get; set; }
        public bool PlayerIsEnteredInLobby { get; set; }
        public int PlayerScoreLimit { get; set; }
        public int PlayerIncomeRate { get; set; }

        public int PlayerNumber { get; set; }
        public Replay Replay { get; set; }
    }
}