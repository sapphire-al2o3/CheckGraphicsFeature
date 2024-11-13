using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CheckGraphicsFeature : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

	private void OnGUI()
	{
		GUILayout.Label($"supportsAsyncCompute: {SystemInfo.supportsAsyncCompute}");
		GUILayout.Label($"supportsAsyncGPUReadback: {SystemInfo.supportsAsyncGPUReadback}");
		GUILayout.Label($"supportedRenderTargetCount: {SystemInfo.supportedRenderTargetCount}");
		GUILayout.Label($"supportsGeometryShaders: {SystemInfo.supportsGeometryShaders}");
		GUILayout.Label($"supportsIndirectArgumentsBuffer: {SystemInfo.supportsIndirectArgumentsBuffer}");
		GUILayout.Label($"supportsInstancing: {SystemInfo.supportsInstancing}");
		GUILayout.Label($"supportsMipStreaming: {SystemInfo.supportsMipStreaming}");
		GUILayout.Label($"supportsMultisampleAutoResolve: {SystemInfo.supportsMultisampleAutoResolve}");
		GUILayout.Label($"supportsMultisampled2DArrayTextures: {SystemInfo.supportsMultisampled2DArrayTextures}");
		GUILayout.Label($"supportsMultisampledTextures: {SystemInfo.supportsMultisampledTextures}");
		GUILayout.Label($"supportsMultisampleResolveDepth: {SystemInfo.supportsMultisampleResolveDepth}");
		GUILayout.Label($"supportsMultisampleResolveStencil: {SystemInfo.supportsMultisampleResolveStencil}");

	}
}
