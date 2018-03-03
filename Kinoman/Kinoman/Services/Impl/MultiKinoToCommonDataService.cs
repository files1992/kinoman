using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Kinoman.Entities.Common;
using Kinoman.Entities.MultiKino;
using Kinoman.Enums;

namespace Kinoman.Services.Impl
{
    public class MultiKinoToCommonDataService : ICommonDataService
    {
        private readonly IDataProviderService _dataProviderService;

        public MultiKinoToCommonDataService(IDataProviderService dataProviderService)
        {
            _dataProviderService = dataProviderService;
        }
        public async Task<List<Showing>> GetCommonData(Cities city)
        {
            List<Showing> commonShowings = new List<Showing>();
            var data = await _dataProviderService.GetCurrentData<MultiKinoShowing>(city);
            var cinemas = _dataProviderService.GetCityInfo();
            int i = 0;
            foreach (var cinema in cinemas)
            {
                foreach (var film in data[i].Films)
                {
                    
                    var showing = new Showing()
                    {
                        Movie = new Movie()
                        {
                            Description = film.SynopsisShort,
                            Duration = film.InfoRunningtime,
                            Tittle = film.Title
                        },
                        CinemaInfo = new CinemaInfo()
                        {
                            City = city,
                            Company = "MultiKino",
                            Name = cinema.Name
                        },
                        BeginsAt = new DateTime(2018, 03, 03, 20, 20, 00),
                        IsPremeire = false
                    };
                    commonShowings.Add(showing);
                }
            }
            return commonShowings;
        }
    }
}