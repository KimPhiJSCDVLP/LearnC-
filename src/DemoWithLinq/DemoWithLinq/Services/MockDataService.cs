using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoWithLinq.Services
{
    //public class MockDataService : IMockDataService<T>
    //{
    //    readonly List<TripLogEntry> items;

    //    public MockDataService()
    //    {
    //        //items = new ObservableCollection<TripLogEntry>()
    //        //{
    //        //    new TripLogEntry
    //        //    {
    //        //        Id = new Guid(),
    //        //        Title = "Washington Monument",
    //        //        Notes = "Amazing!",
    //        //        Rating = 3,
    //        //        Date = new DateTime(2020, 2, 5),
    //        //        Latitude = 38.8895,
    //        //        Longitude = -77.0352
    //        //    },
    //        //    new TripLogEntry
    //        //    {
    //        //        Id = new Guid(),
    //        //        Title = "Statue of Liberty",
    //        //        Notes = "Inspiring!",
    //        //        Rating = 4,
    //        //        Date = new DateTime(2020, 4, 13),
    //        //        Latitude = 40.6892,
    //        //        Longitude = -74.0444
    //        //    },
    //        //    new TripLogEntry
    //        //    {
    //        //        Id = new Guid(),
    //        //        Title = "Golden Gate Bridge",
    //        //        Notes = "Foggy, but beautiful.",
    //        //        Rating = 5,
    //        //        Date = new DateTime(2019, 4, 26),
    //        //        Latitude = 37.8268,
    //        //        Longitude = -122.4798
    //        //    },
    //        //    new TripLogEntry
    //        //    {
    //        //        Id = new Guid(),
    //        //        Title = "P. Tố Hữu",
    //        //        Notes = "My Favorite Workplace",
    //        //        Rating = 1,
    //        //        Date = new DateTime(2020, 9, 25),
    //        //        Latitude = 20.984912,
    //        //        Longitude = 105.7729656
    //        //    },
    //        //    new TripLogEntry
    //        //    {
    //        //        Id = new Guid(),
    //        //        Title = "Mỹ Đình - Nam Từ Liêm",
    //        //        Notes = "My whereabouts",
    //        //        Rating = 2,
    //        //        Date = new DateTime(2020, 9, 20),
    //        //        Latitude = 21.0284776,
    //        //        Longitude = 105.7759394
    //        //    }
    //        //};
    //    }

    //    public async Task<bool> AddItemAsync(TripLogEntry item)
    //    {
    //        try
    //        {
    //            items.Add(item);
    //            return await Task.FromResult(true);
    //        }
    //        catch (Exception)
    //        {
    //            return await Task.FromResult(false);
    //        }
    //    }

    //    public async Task<bool> UpdateItemAsync(TripLogEntry item)
    //    {
    //        var oldItem = items.Where((TripLogEntry arg) => arg.Id == item.Id).FirstOrDefault();
    //        items.Remove(oldItem);
    //        items.Add(item);
    //        return await Task.FromResult(true);
    //    }

    //    public async Task<bool> DeleteItemAsync(Guid id)
    //    {
    //        var oldItem = items.Where((TripLogEntry arg) => arg.Id == id).FirstOrDefault();
    //        items.Remove(oldItem);
    //        return await Task.FromResult(true);
    //    }

    //    public async Task<TripLogEntry> GetItemAsync(Guid id)
    //    {
    //        return await Task.FromResult(items.FirstOrDefault(s => s.Id == id));
    //    }

    //    public async Task<List<T>> GetItemsAsync(bool forceRefresh = false)
    //    {
    //        var resutls = new List<TripLogEntry>();
    //        var tripLogEntrys = items.OrderByDescending(x => x.Rating);
    //        foreach (var item in tripLogEntrys)
    //        {
    //            resutls.Add(item);
    //        }
    //        return await Task.FromResult(resutls);
    //    }
    //}
}
