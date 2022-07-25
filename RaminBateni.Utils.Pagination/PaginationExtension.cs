using System;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using RaminBateni.Utils.Pagination.Models;

namespace RaminBateni.Utils.Pagination
{
    public static class PaginationExtension
    {
        public static async Task<PagedResult<T>> AsPagedToListAsync<T>(
            this IQueryable<T> query,
            int page, int pageSize)
            where T : class
        {
            var result = new PagedResult<T>
            {
                CurrentPage = page,
                PageSize = pageSize,
                RowCount = await query.CountAsync()
            };

            var pageCount = (double)result.RowCount / pageSize;
            result.PageCount = (int)Math.Ceiling(pageCount);

            var skip = (page - 1) * pageSize;
            result.SetItems(await query.Skip(skip).Take(pageSize).ToListAsync());

            return result;
        }
    }
}
