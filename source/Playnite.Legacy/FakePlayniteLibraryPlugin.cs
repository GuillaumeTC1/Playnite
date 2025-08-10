using Playnite.SDK.Models;
using Playnite.SDK.Plugins;
using System;
using System.Collections.Generic;

namespace Playnite.Legacy
{
    public class FakePlayniteLibraryPlugin : LibraryPlugin
    {
        public override string Name => "Playnite";

        public override Guid Id => Guid.Empty;

        public FakePlayniteLibraryPlugin() : base(null)
        {
        }

        public override IEnumerable<GameMetadata> GetGames(LibraryGetGamesArgs args)
        {
            throw new NotImplementedException();
        }
    }
}
