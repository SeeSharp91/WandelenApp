using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Wandelen.Models;


namespace Wandelen.Data
{
    public class RouteItemsManager
    {
        IRestService restService;

        public RouteItemsManager (IRestService service)
        {
            restService = service;
        }

        public Task<List<Route>> GetTaskAsync()
        {
            return restService.RefreshDataAsync();
        }

        public Task SaveTaskAsync(Route route, bool isNewItem = false)
        {
            return restService.SaveRouteAsync(route, isNewItem);
        }

        public Task DeleteTaskAsync(Route route)
        {
            return restService.DeleteRouteAsync(route.route_id);
        }
    }
}
