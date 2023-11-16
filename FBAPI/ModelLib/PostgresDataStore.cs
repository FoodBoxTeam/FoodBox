using FBAPI.Data;

namespace FBAPI.ModelLib;

public class PostgresDataStore : IDataStore
{

    private readonly PostgresContext _context;

    public PostgresDataStore(PostgresContext context)
    {
        _context = context;
    }

    public Task<IDataObject> AddData(IDataObject dataObject)
    {
        throw new NotImplementedException();
    }

    public Task DeleteDataObj(int id, DataObjectType type)
    {
        throw new NotImplementedException();
    }

    public Task<IEnumerable<IDataObject>> GetAllDataObjects(DataObjectType type)
    {
        throw new NotImplementedException();
    }

    public Task<IDataObject> GetData(int id, DataObjectType type)
    {
        throw new NotImplementedException();
    }

    public Task<IDataObject> UpdateData(IDataObject dataObject)
    {
        throw new NotImplementedException();
    }

    public async Task<IEnumerable<IDataObject>> GetUserRolesAsync(string id)
    {
        var user = _context.AspNetUserLogins.Single(l => l.ProviderKey == id);

        if (user != null)
        {
            return await _context.AspNetRoles.ToListAsync() as IEnumerable<AspNetRole>;
        }
        else
        {
            throw new Exception("User Token is NOT valid!");
        }
    }
}

