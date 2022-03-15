using System;
using System.Collections.Generic;

namespace RB444.Models.Model
{
    public class CommonModel
    {
        public int Id { get; set; }
        public string Name { get; set; }
    }
    public class CommonReturnResponse
    {
        public Boolean IsSuccess { get; set; }
        public int Status { get; set; }
        public string Message { get; set; }
        public dynamic Data { get; set; }
    }

    public class SeriesReturnResponse
    {
        public string message { get; set; }
        public int code { get; set; }
        public bool error { get; set; }
        public List<SeriesDataByApi> data { get; set; }
        public long currentTime { get; set; }
    }

    public class MatchesReturnResponse
    {
        public string message { get; set; }
        public int code { get; set; }
        public bool error { get; set; }
        public List<MatchesDataByApi> data { get; set; }
        public long currentTime { get; set; }
    }

    public class PriorityStatus
    {
        public int PriorityId { get; set; }
        public string Priority { get; set; }
        public string PriorityColourCode { get; set; }
    }

    public class SportsData
    {
        public string key { get; set; }
        public string group { get; set; }
        public string title { get; set; }
        public string description { get; set; }
        public bool active { get; set; }
        public bool has_outrights { get; set; }
    }

    public class SportsSettings
    {
        public string sportId { get; set; }
        public string sportName { get; set; }
        public string iconUrl { get; set; }
        public bool highlight { get; set; }
        public int sequence { get; set; }
        public bool popular { get; set; }
        public bool status { get; set; }
        public bool others { get; set; }
    }

    public class SeriesDataByApi
    {
        public long SeriesId { get; set; }
        public string SeriesName { get; set; }
    }

    public class MatchesDataByApi
    {
        public long eventId { get; set; }
        public string eventName { get; set; }
        public DateTime eventDate { get; set; }
        public long SeriesId { get; set; }
        public string SeriesName { get; set; }
        public string marketId { get; set; }
        public string marketName { get; set; }
        public string marketType { get; set; }
        public long selectionId1 { get; set; }
        public long selectionId2 { get; set; }
        public long selectionId3 { get; set; }
        public string runnerName1 { get; set; }
        public string runnerName2 { get; set; }
        public string runnerName3 { get; set; }

    }

    public class Outcome
    {
        public string name { get; set; }
        public double price { get; set; }
    }

    public class Market
    {
        public string key { get; set; }
        public List<Outcome> outcomes { get; set; }
    }

    public class Bookmaker
    {
        public string key { get; set; }
        public string title { get; set; }
        public DateTime last_update { get; set; }
        public List<Market> markets { get; set; }
    }

    public class MatchList
    {
        public string id { get; set; }
        public string sport_key { get; set; }
        public string sport_title { get; set; }
        public DateTime commence_time { get; set; }
        public string home_team { get; set; }
        public string away_team { get; set; }
    }

    public class MatchOdds
    {
        public string id { get; set; }
        public string sport_key { get; set; }
        public string sport_title { get; set; }
        public DateTime commence_time { get; set; }
        public string home_team { get; set; }
        public string away_team { get; set; }
        public List<Bookmaker> bookmakers { get; set; }
    }
}
