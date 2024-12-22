This is Mix's ThirdPersonPlayground example mod.

## Things to look at
1. `Assets/AssetBundles`
	1. `Assets/AssetBundles/playground`
1. `Assets/Mix`
	1. `Assets/Mix/Editor/CreateAssetBundles.cs`: The script that creates the AssetBundles
1. `Assets/ThirdPersonPlayground`
	1. `Assets/ThirdPersonPlayground/Mod.cs`: The mod's entry point
1. `Assets/StarterAssets`
	1. `Assets/StarterAssets/StarterAssets.asmdef`
		1. Unity.InputSystem is added as a reference
	1. `Assets/StarterAssets/ThirdPersonController/Scenes/Playground`'s AssetBundle is set to `playground`
1. `Library/ScriptAssemblies`: Where Unity generates the DLLs after you create the assembly references
	1. `Library/ScriptAssemblies/ThirdPersonPlayground.dll`
	1. `Library/ScriptAssemblies/Cinemachine.dll`
	1. `Library/ScriptAssemblies/StarterAssets.dll`