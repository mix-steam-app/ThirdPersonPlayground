using UnityEngine;
using UnityEngine.SceneManagement;

namespace ThirdPersonPlayground
{
	public class Mod : Mix.Mod
	{
		public Mod(string id) : base(id)
		{
			var modPath = Mix.Main.modPathDictionary[id];
			var assetBundle = AssetBundle.LoadFromFile(modPath + "/AssetBundles/playground");
			var scenePaths = assetBundle.GetAllScenePaths();
			SceneManager.LoadScene(scenePaths[0]);
		}
	}
}
