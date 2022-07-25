# RaminBateni.Utils.Pagination

By this simple extension you can **easily** get your **query** result **as paginated** from database or memory.

Just call it like this:

```
var pagedResult = _context.Set<Label>()
      .Include(x => x.Article)
      .Where(x => x.CollectionId == 2)
      .OrderBy(x=> x.Labeld)
      .AsPagedToListAsync(page: 5, pageSize: 20);
```

Now `pagedResult` provide you these info:
```
List<T> Items
int     CurrentPage
int     PageCount
int     PageSize
int     RowCount
int     FirstRowOnPage
int     LastRowOnPage
```

If you have any questions or suggestions please leave a message in the repo of this package in GitHub as issue.
