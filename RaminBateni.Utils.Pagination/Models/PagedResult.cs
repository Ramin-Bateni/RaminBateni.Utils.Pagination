using System;
using System.Collections.Generic;

namespace RaminBateni.Utils.Pagination.Models
{
    public class PagedResult<T>
    {
        public int CurrentPage { get; set; }

        public int PageCount { get; set; }

        public int PageSize { get; set; }

        public int RowCount { get; set; }

        public int FirstRowOnPage => (CurrentPage - 1) * PageSize + 1;

        public int LastRowOnPage => Math.Min(CurrentPage * PageSize, RowCount);

        public List<T> Items { get; private set; }

        public PagedResult()
        {
            Items = new List<T>();
        }

        public void SetItems(List<T> items)
        {
            Items = items;
        }
    }
}
