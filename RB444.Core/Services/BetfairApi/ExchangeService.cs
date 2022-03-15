using Microsoft.Extensions.Configuration;
using RB444.Core.IServices;
using RB444.Core.IServices.BetfairApi;
using RB444.Core.ServiceHelper;
using RB444.Data.Entities;
using RB444.Data.Repository;
using RB444.Models.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RB444.Core.Services.BetfairApi
{
    public class ExchangeService : IExchangeService
    {
        private readonly IBaseRepository _baseRepository;
        private readonly IRequestServices _requestServices;
        private readonly IConfiguration _configuration;

        public ExchangeService(IBaseRepository baseRepository, IRequestServices requestServices, IConfiguration configuration)
        {
            _baseRepository = baseRepository;
            _requestServices = requestServices;
            _configuration = configuration;
        }

        public async Task<CommonReturnResponse> GetSportsAsync(int type)
        {
            IDictionary<string, object> _keyValues = null;
            var sports = new List<Sports>();
            try
            {
                if (type == 1)
                {
                    sports = await _baseRepository.GetListAsync<Sports>();
                }
                else
                {
                    _keyValues = new Dictionary<string, object> { { "Status", 1 } };
                    sports = (await _baseRepository.SelectAsync<Sports>(_keyValues)).ToList();
                }
                return new CommonReturnResponse
                {
                    Data = sports,
                    Message = sports.Count > 0 ? MessageStatus.Success : MessageStatus.NoRecord,
                    IsSuccess = sports.Count > 0,
                    Status = sports.Count > 0 ? ResponseStatusCode.OK : ResponseStatusCode.NOTFOUND
                };
            }
            catch (Exception ex)
            {
                return new CommonReturnResponse { Data = null, Message = ex.InnerException != null ? ex.InnerException.Message : ex.Message, IsSuccess = false, Status = ResponseStatusCode.EXCEPTION };
            }
        }

        public async Task<CommonReturnResponse> GetSeriesListAsync(int SportId, int type)
        {
            IDictionary<string, object> _keyValues = null;
            var seriesReturnResponse = new SeriesReturnResponse();
            List<SeriesDataByApi> seriesDataByApis = null;
            List<SeriesDataByApi> seriesDistinctDataByApis = new List<SeriesDataByApi>();
            List<Series> serieslistByDatabase = null;
            List<Series> serieslist = new List<Series>();
            try
            {
                seriesReturnResponse = await _requestServices.GetAsync<SeriesReturnResponse>(string.Format("{0}getmatches/{1}", _configuration["ApiKeyUrl"], SportId));
                seriesDataByApis = seriesReturnResponse.data;
                foreach (var itemSeries in seriesDataByApis)
                {
                    if (!seriesDistinctDataByApis.Any(x => x.SeriesId == itemSeries.SeriesId))
                        seriesDistinctDataByApis.Add(itemSeries);
                }
                _keyValues = new Dictionary<string, object> { { "SportId", SportId } };
                serieslistByDatabase = (await _baseRepository.SelectAsync<Series>(_keyValues)).ToList();

                foreach (var item in seriesDistinctDataByApis)
                {
                    var series = new Series
                    {
                        tournamentId = Convert.ToInt64(item.SeriesId),
                        tournamentName = item.SeriesName,
                        SportId = SportId,
                        Status = serieslistByDatabase.Where(x=>x.tournamentId==item.SeriesId).Select(s=>s.Status).FirstOrDefault()

                    };
                    serieslist.Add(series);

                    if (serieslistByDatabase.Count > 0 && type == 1)
                    {
                        foreach (var item2 in serieslistByDatabase)
                        {
                            if (item.SeriesName.Equals(item2.tournamentName) && item2.Status != true)
                            {
                                serieslist.Remove(item2);
                            }
                        }
                    }
                }

                return new CommonReturnResponse
                {
                    Data = serieslist,
                    Message = serieslist.Count > 0 ? MessageStatus.Success : MessageStatus.NoRecord,
                    IsSuccess = serieslist.Count > 0,
                    Status = serieslist.Count > 0 ? ResponseStatusCode.OK : ResponseStatusCode.NOTFOUND
                };
            }
            catch (Exception ex)
            {
                //_logger.LogException("Exception : AircraftService : GetAircarftDetailsAsync()", ex);
                return new CommonReturnResponse { Data = null, Message = ex.InnerException != null ? ex.InnerException.Message : ex.Message, IsSuccess = false, Status = ResponseStatusCode.EXCEPTION };
            }
            finally { if (seriesDataByApis != null) { seriesDataByApis = null; } }
        }

        //public async Task<CommonReturnResponse> GetMatchesListAsync(int SportId, long SeriesId, int type)
        //{
        //    IDictionary<string, object> _keyValues = null;
        //    var matchReturnResponse = new MatchesReturnResponse();
        //    List<MatchesDataByApi> matchDataByApis = null;
        //    List<MatchesDataByApi> matchDistinctDataByApis = new List<MatchesDataByApi>();
        //    List<Matches> matcheslistByDatabase = null;
        //    List<Matches> matcheslist = new List<Matches>();
        //    try
        //    {
        //        matchReturnResponse = await _requestServices.GetAsync<MatchesReturnResponse>(string.Format("{0}getmatches/{1}", _configuration["ApiKeyUrl"], SportId));
        //        matchDataByApis = matchReturnResponse.data;
        //        foreach (var itemSeries in matchDataByApis)
        //        {
        //            if (!matchDistinctDataByApis.Any(x => x.SeriesId == itemSeries.SeriesId))
        //                matchDistinctDataByApis.Add(itemSeries);
        //        }
        //        _keyValues = new Dictionary<string, object> { { "SportId", SportId }, { "SeriesId" , SeriesId } };
        //        matcheslistByDatabase = (await _baseRepository.SelectAsync<Matches>(_keyValues)).ToList();

        //        foreach (var item in matchDistinctDataByApis)
        //        {
        //            var series = new Series
        //            {
        //                tournamentId = Convert.ToInt64(item.SeriesId),
        //                tournamentName = item.SeriesName,
        //                SportId = SportId,
        //                Status = matcheslistByDatabase.Where(x => x.tournamentId == item.SeriesId).Select(s => s.Status).FirstOrDefault()

        //            };
        //            matcheslist.Add(series);

        //            if (matcheslistByDatabase.Count > 0 && type == 1)
        //            {
        //                foreach (var item2 in matcheslistByDatabase)
        //                {
        //                    if (item.SeriesName.Equals(item2.tournamentName) && item2.Status != true)
        //                    {
        //                        matcheslist.Remove(item2);
        //                    }
        //                }
        //            }
        //        }

        //        return new CommonReturnResponse
        //        {
        //            Data = matcheslist,
        //            Message = matcheslist.Count > 0 ? MessageStatus.Success : MessageStatus.NoRecord,
        //            IsSuccess = matcheslist.Count > 0,
        //            Status = matcheslist.Count > 0 ? ResponseStatusCode.OK : ResponseStatusCode.NOTFOUND
        //        };
        //    }
        //    catch (Exception ex)
        //    {
        //        //_logger.LogException("Exception : AircraftService : GetAircarftDetailsAsync()", ex);
        //        return new CommonReturnResponse { Data = null, Message = ex.InnerException != null ? ex.InnerException.Message : ex.Message, IsSuccess = false, Status = ResponseStatusCode.EXCEPTION };
        //    }
        //    finally { if (matchDataByApis != null) { matchDataByApis = null; } }
        //}
    }
}
