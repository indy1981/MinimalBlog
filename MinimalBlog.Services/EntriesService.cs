using MinimalBlog.IRepositories;
using MinimalBlog.Models;
using MinimalBlog.Models.Enums;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace MinimalBlog.Services
{
    public class EntriesService
    {
        private readonly IEntryRepository Repository;

        public EntriesService(IEntryRepository repository)
        {
            Repository = repository;
        }        

        public Entry Create(Entry entry) 
        {
            entry.Created = DateTime.UtcNow;
            
            if (string.IsNullOrEmpty(entry.Summary) || string.IsNullOrEmpty(entry.Content))
            {
                entry.State = EntryStateEnum.Draft;
            }           

            return Repository.Create(entry);
        }

        public virtual async Task<Entry> GetByIdAsync(int id)
        {
            return await Repository.GetByIdAsync(id);
        }

        public async Task DeleteById(int id)
        {
            var entry = await Repository.GetByIdAsync(id);
            Repository.Delete(entry);
        }

        public void Delete(Entry entry)
        {
            Repository.Delete(entry);
        }

        public IEnumerable<Entry> GetAllPublicEntries()
        {
            return Repository.List(x => x.State == EntryStateEnum.Public);
        }

        public IEnumerable<Entry> GetAllMyEntries(int userId)
        {
            return Repository.List(x => x.State == EntryStateEnum.Public || x.UserId == userId);
        }
    }
}
