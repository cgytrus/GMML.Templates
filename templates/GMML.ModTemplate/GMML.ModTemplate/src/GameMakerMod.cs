using GmmlPatcher;

using UndertaleModLib;

namespace GMML.ModTemplate;

public class GameMakerMod : IGameMakerMod {
    public void Load(int audioGroup, UndertaleData data, ModData currentMod) {
        if(audioGroup != 0) return;

        // your code
    }
}
