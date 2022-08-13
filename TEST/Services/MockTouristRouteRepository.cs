using System;
using System.Linq;
using System.Collections.Generic;

using TEST.Models;

namespace TEST.Services
{
    public class MockTouristRouteRepository : ITouristRouteRepository
    {
        private List<TouristRoute> _routes;

        public MockTouristRouteRepository()
        {
            if(_routes == null)
            {
                InitializeTouristRoutes();
            }
        }

        private void InitializeTouristRoutes()
        {
            _routes = new List<TouristRoute>
            {
                new TouristRoute
                {
                    Id = Guid.NewGuid(),
                    Title = "Title",
                    Description = "Description",
                    OriginalPrice = 2333,
                    DiscountPresent = 2.33,
                    CreateTime = new DateTime(),
                    Feature = "Feature",
                    Notes = "Notes",
                },
                new TouristRoute
                {
                    Id = Guid.NewGuid(),
                    Title = "Title 2",
                    Description = "Description 2",
                    OriginalPrice = 2333,
                    DiscountPresent = 2.33,
                    CreateTime = new DateTime(),
                    Feature = "Feature 2",
                    Notes = "Notes 2",
                }
            };
        }

        public TouristRoute GetTouristRoute(Guid touristRouteId)
        {
            // linq
            return _routes.FirstOrDefault(n => n.Id == touristRouteId);
        }

        public IEnumerable<TouristRoute> GetTouristRoutes()
        {
            return _routes;
        }
    }
}

