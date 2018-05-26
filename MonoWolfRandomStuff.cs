using Terraria.ModLoader;

namespace MonoWolfRandomStuff
{
	class MonoWolfRandomStuff : Mod
	{
		public MonoWolfRandomStuff()
		{
            Properties = new ModProperties() {
                Autoload = true,
                AutoloadBackgrounds = true,
                AutoloadGores = true,
                AutoloadSounds = true
            };
		}
	}
}
