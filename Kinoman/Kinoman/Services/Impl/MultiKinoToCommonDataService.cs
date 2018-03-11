using System;
using System.Collections.Generic;
using System.Linq;
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
            var premieraTag = "PREMIERA";
            List<Showing> commonShowings = new List<Showing>();
            var data = await _dataProviderService.GetCurrentData<MultiKinoShowing>(city);
            var cinemas = _dataProviderService.GetCityInfo();
            int cienamIndex = 0;
            foreach (var cinema in cinemas)
            {
                foreach (var film in data[cienamIndex].Films)
                {
                    foreach (var time in film.Showings.SelectMany(f => f.Times))
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
                                Date = time.Date.ToString("dd MMMM yyyy"),
                                BeginsAt = time.Date.ToString("HH:mm"),
                                ShowingType = film.PromoLabels?.Names.Select(n => n.Name).FirstOrDefault()
                            };
                            commonShowings.Add(showing);
                    }
                }

                cienamIndex++;
            }
            return commonShowings;
        }
    }
}