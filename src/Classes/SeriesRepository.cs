using System.Collections.Generic;
using VideoLibrary.Interfaces;

namespace VideoLibrary
{
    public class SeriesRepository : IRepository<Serie>
    {
        private List<Serie> seriesList = new List<Serie>();

        public List<Serie> List()
        {
            return seriesList;
        }
        public void Insert(Serie entity)
        {
            seriesList.Add(entity);
        }

        public Serie FindById(int id)
        {
            throw new System.NotImplementedException();
        }
        public void Update(int id, Serie entity)
        {
            seriesList[id] = entity;
        }
        public void Delete(int id)
        {
            seriesList[id].Hide();
        }
        public int NextId()
        {
            return seriesList.Count;
        }
        
    }


}