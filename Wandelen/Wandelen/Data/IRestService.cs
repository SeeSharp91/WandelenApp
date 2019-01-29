using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Wandelen.Models;

namespace Wandelen.Data
{
    public interface IRestService
    {
        Task<List<Route>> RefreshDataAsync();

        Task SaveRouteAsync(Route route, bool isNewItem);

        Task DeleteRouteAsync(int id);
    }
}
