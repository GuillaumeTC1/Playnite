using Playnite.SDK.Database;
using Playnite.SDK.Models;

namespace Playnite.Database.Collections
{
    public class ImportExclusionsCollection : ItemCollection<ImportExclusionItem>
    {
        public ImportExclusionsCollection(GameDatabase database, LiteDB.BsonMapper mapper) : base(mapper, type: GameDatabaseCollection.ImportExclusions)
        {
        }

        public static void MapLiteDbEntities(LiteDB.BsonMapper mapper)
        {
            mapper.Entity<ImportExclusionItem>().Id(a => a.Id, false);
        }
    }
}
