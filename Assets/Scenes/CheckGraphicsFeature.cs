using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CheckGraphicsFeature : MonoBehaviour
{

	Vector2 scrollPosition;

	private void OnGUI()
	{
		using (new GUILayout.ScrollViewScope(scrollPosition))
		{
			GUILayout.Label($"graphicsDeviceName: {SystemInfo.graphicsDeviceName}");
			GUILayout.Label($"graphicsDeviceVendor: {SystemInfo.graphicsDeviceVendor}");

			GUILayout.Label($"supportsMotionVectors: {SystemInfo.supportsMotionVectors}");
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
			GUILayout.Label($"supportedRandomWriteTargetCount: {SystemInfo.supportedRandomWriteTargetCount}");
			GUILayout.Label($"supports2DArrayTextures: {SystemInfo.supports2DArrayTextures}");
			GUILayout.Label($"supports32bitsIndexBuffer: {SystemInfo.supports32bitsIndexBuffer}");
		}
	}
}
