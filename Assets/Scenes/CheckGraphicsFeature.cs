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
			GUILayout.Label($"graphicsDeviceType: {SystemInfo.graphicsDeviceType}");
			GUILayout.Label($"graphicsShaderLevel: {SystemInfo.graphicsShaderLevel}");


			GUILayout.Label($"supportedRandomWriteTargetCount: {SystemInfo.supportedRandomWriteTargetCount}");
			GUILayout.Label($"supportedRenderTargetCount: {SystemInfo.supportedRenderTargetCount}");

			GUILayout.Label($"supports2DArrayTextures: {SystemInfo.supports2DArrayTextures}");
			GUILayout.Label($"supports32bitsIndexBuffer: {SystemInfo.supports32bitsIndexBuffer}");
			GUILayout.Label($"supports3DRenderTextures: {SystemInfo.supports3DRenderTextures}");
			GUILayout.Label($"supports3DTextures: {SystemInfo.supports3DTextures}");
			
			//GUILayout.Label($"supportsAnisotropicFilter: {SystemInfo.supportsAnisotropicFilter}");
			GUILayout.Label($"supportsAsyncCompute: {SystemInfo.supportsAsyncCompute}");
			GUILayout.Label($"supportsAsyncGPUReadback: {SystemInfo.supportsAsyncGPUReadback}");
			GUILayout.Label($"supportsCompressed3DTextures: {SystemInfo.supportsCompressed3DTextures}");
			GUILayout.Label($"supportsComputeShaders: {SystemInfo.supportsComputeShaders}");
			GUILayout.Label($"supportsConservativeRaster: {SystemInfo.supportsConservativeRaster}");
			GUILayout.Label($"supportsCubemapArrayTextures: {SystemInfo.supportsCubemapArrayTextures}");
			//GUILayout.Label($"supportsDepthFetchInRenderPass: {SystemInfo.supportsDepthFetchInRenderPass}");
			GUILayout.Label($"supportsGeometryShaders: {SystemInfo.supportsGeometryShaders}");
			GUILayout.Label($"supportsGpuRecorder: {SystemInfo.supportsGpuRecorder}");
			GUILayout.Label($"supportsGraphicsFence: {SystemInfo.supportsGraphicsFence}");
			GUILayout.Label($"supportsHardwareQuadTopology: {SystemInfo.supportsHardwareQuadTopology}");
			GUILayout.Label($"supportsIndirectArgumentsBuffer: {SystemInfo.supportsIndirectArgumentsBuffer}");
			//GUILayout.Label($"supportsIndirectDispatchRays: {SystemInfo.supportsIndirectDispatchRays}");
			//GUILayout.Label($"supportsInlineRayTracing: {SystemInfo.supportsInlineRayTracing}");
			GUILayout.Label($"supportsInstancing: {SystemInfo.supportsInstancing}");
			GUILayout.Label($"supportsMipStreaming: {SystemInfo.supportsMipStreaming}");
			GUILayout.Label($"supportsMotionVectors: {SystemInfo.supportsMotionVectors}");
			GUILayout.Label($"supportsMultisampleAutoResolve: {SystemInfo.supportsMultisampleAutoResolve}");
			GUILayout.Label($"supportsMultisampled2DArrayTextures: {SystemInfo.supportsMultisampled2DArrayTextures}");
			GUILayout.Label($"supportsMultisampledTextures: {SystemInfo.supportsMultisampledTextures}");
			GUILayout.Label($"supportsMultisampleResolveDepth: {SystemInfo.supportsMultisampleResolveDepth}");
			GUILayout.Label($"supportsMultisampleResolveStencil: {SystemInfo.supportsMultisampleResolveStencil}");
			GUILayout.Label($"supportsMultiview: {SystemInfo.supportsMultiview}");
		}
	}
}
