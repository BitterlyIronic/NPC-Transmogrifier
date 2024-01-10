using Mutagen.Bethesda;
using Mutagen.Bethesda.Synthesis;
using Mutagen.Bethesda.Skyrim;
using Mutagen.Bethesda.Plugins;
using Mutagen.Bethesda.FormKeys.SkyrimSE;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NPCTransmogrifier
{
    internal class TransmogSettings
    {
        public List<ModKey> ModsToPatch = new() {};
        public List<IFormLink<IRaceGetter>> RacesToPatch = new() {};
        public int ScarChance = 15;
        public int HairChance = 90;
        public int EyebrowChance = 90;
        public int FacialHairChance = 50;
        public bool PatchFaceMorph = false;
        public bool PatchFaceParts = false;
        public bool PatchHeadParts = false;
        public bool PatchHairColor = false;
        public bool PatchTextureLighting = false;
    }
}
