// Unity C# reference source
// Copyright (c) Unity Technologies. For terms of use, see
// https://unity3d.com/legal/licenses/Unity_Reference_Only_License

using scm=System.ComponentModel;
using uei=UnityEngine.Internal;
using RequiredByNativeCodeAttribute=UnityEngine.Scripting.RequiredByNativeCodeAttribute;
using UsedByNativeCodeAttribute=UnityEngine.Scripting.UsedByNativeCodeAttribute;


using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnityEngine.Rendering;


namespace UnityEngine.Experimental.Rendering
{



[System.Runtime.InteropServices.StructLayout (System.Runtime.InteropServices.LayoutKind.Sequential)]
public partial struct ShaderPassName
{
        #pragma warning disable 414
            private int nameIndex;
        #pragma warning restore 414
    
            public ShaderPassName(string name)
        {
            nameIndex = Init(name);
        }
    
    
    [UnityEngine.Scripting.GeneratedByOldBindingsGeneratorAttribute] // Temporarily necessary for bindings migration
    [System.Runtime.CompilerServices.MethodImplAttribute((System.Runtime.CompilerServices.MethodImplOptions)0x1000)]
    extern private static  int Init (string name) ;

}

[System.Runtime.InteropServices.StructLayout (System.Runtime.InteropServices.LayoutKind.Sequential)]
public partial struct DrawRendererSettings
{
    
            public DrawRendererSortSettings sorting;
            public ShaderPassName           shaderPassName;
            public InputFilter              inputFilter;
            public RendererConfiguration    rendererConfiguration;
            public DrawRendererFlags        flags;
    
        #pragma warning disable 414
            private IntPtr                  _cullResults;
        #pragma warning restore 414
            public CullResults              cullResults { set { _cullResults = value.cullResults; } }
    
            public DrawRendererSettings(CullResults cullResults, Camera camera, ShaderPassName shaderPassName)
        {
            _cullResults = cullResults.cullResults;

            this.shaderPassName = shaderPassName;
            rendererConfiguration = RendererConfiguration.None;
            flags = DrawRendererFlags.EnableInstancing;

            inputFilter = InputFilter.Default();
            InitializeSortSettings(camera, out sorting);
        }
    
    
    [UnityEngine.Scripting.GeneratedByOldBindingsGeneratorAttribute] // Temporarily necessary for bindings migration
    [System.Runtime.CompilerServices.MethodImplAttribute((System.Runtime.CompilerServices.MethodImplOptions)0x1000)]
    extern private static  void InitializeSortSettings (Camera camera, out DrawRendererSortSettings sortSettings) ;

}

[System.Runtime.InteropServices.StructLayout (System.Runtime.InteropServices.LayoutKind.Sequential)]
public partial struct ScriptableRenderContext
{
    [UnityEngine.Scripting.GeneratedByOldBindingsGeneratorAttribute] // Temporarily necessary for bindings migration
    [System.Runtime.CompilerServices.MethodImplAttribute((System.Runtime.CompilerServices.MethodImplOptions)0x1000)]
    extern private void Submit_Internal () ;

    [UnityEngine.Scripting.GeneratedByOldBindingsGeneratorAttribute] // Temporarily necessary for bindings migration
    [System.Runtime.CompilerServices.MethodImplAttribute((System.Runtime.CompilerServices.MethodImplOptions)0x1000)]
    extern private void DrawRenderers_Internal (ref DrawRendererSettings settings) ;

    [UnityEngine.Scripting.GeneratedByOldBindingsGeneratorAttribute] // Temporarily necessary for bindings migration
    [System.Runtime.CompilerServices.MethodImplAttribute((System.Runtime.CompilerServices.MethodImplOptions)0x1000)]
    extern private static  System.Array ExtractArrayFromList (object list) ;

    
    
    private void DrawRenderersWithState_Internal (ref DrawRendererSettings settings, RenderStateBlock stateBlock) {
        INTERNAL_CALL_DrawRenderersWithState_Internal ( ref this, ref settings, ref stateBlock );
    }

    [UnityEngine.Scripting.GeneratedByOldBindingsGeneratorAttribute] // Temporarily necessary for bindings migration
    [System.Runtime.CompilerServices.MethodImplAttribute((System.Runtime.CompilerServices.MethodImplOptions)0x1000)]
    private extern static void INTERNAL_CALL_DrawRenderersWithState_Internal (ref ScriptableRenderContext self, ref DrawRendererSettings settings, ref RenderStateBlock stateBlock);
    [UnityEngine.Scripting.GeneratedByOldBindingsGeneratorAttribute] // Temporarily necessary for bindings migration
    [System.Runtime.CompilerServices.MethodImplAttribute((System.Runtime.CompilerServices.MethodImplOptions)0x1000)]
    extern private void DrawRenderersWithStateMap_Internal (ref DrawRendererSettings settings, System.Array array, int length) ;

    [UnityEngine.Scripting.GeneratedByOldBindingsGeneratorAttribute] // Temporarily necessary for bindings migration
    [System.Runtime.CompilerServices.MethodImplAttribute((System.Runtime.CompilerServices.MethodImplOptions)0x1000)]
    extern private void DrawShadows_Internal (ref DrawShadowsSettings settings) ;

    [UnityEngine.Scripting.GeneratedByOldBindingsGeneratorAttribute] // Temporarily necessary for bindings migration
    [System.Runtime.CompilerServices.MethodImplAttribute((System.Runtime.CompilerServices.MethodImplOptions)0x1000)]
    extern private void ExecuteCommandBuffer_Internal (CommandBuffer commandBuffer) ;

    [UnityEngine.Scripting.GeneratedByOldBindingsGeneratorAttribute] // Temporarily necessary for bindings migration
    [System.Runtime.CompilerServices.MethodImplAttribute((System.Runtime.CompilerServices.MethodImplOptions)0x1000)]
    extern private void ExecuteCommandBufferAsync_Internal (CommandBuffer commandBuffer, ComputeQueueType queueType) ;

    [UnityEngine.Scripting.GeneratedByOldBindingsGeneratorAttribute] // Temporarily necessary for bindings migration
    [System.Runtime.CompilerServices.MethodImplAttribute((System.Runtime.CompilerServices.MethodImplOptions)0x1000)]
    extern private void SetupCameraProperties_Internal (Camera camera) ;

    [UnityEngine.Scripting.GeneratedByOldBindingsGeneratorAttribute] // Temporarily necessary for bindings migration
    [System.Runtime.CompilerServices.MethodImplAttribute((System.Runtime.CompilerServices.MethodImplOptions)0x1000)]
    extern private void DrawSkybox_Internal (Camera camera) ;

    internal IntPtr Internal_GetPtr()
        {
            return m_Ptr;
        }
    
    
}

[UsedByNativeCode]
[System.Runtime.InteropServices.StructLayout (System.Runtime.InteropServices.LayoutKind.Sequential)]
public partial struct VisibleLight
{
            public LightType            lightType;
            public Color                finalColor;
            public Rect                 screenRect;
            public Matrix4x4            localToWorld;
            public float                range;
            public float                spotAngle;
            private int                 instanceId;
            public VisibleLightFlags    flags;
    
    
    public Light          light { get { return GetLightObject(instanceId); } }
    
    
    [UnityEngine.Scripting.GeneratedByOldBindingsGeneratorAttribute] // Temporarily necessary for bindings migration
    [System.Runtime.CompilerServices.MethodImplAttribute((System.Runtime.CompilerServices.MethodImplOptions)0x1000)]
    extern private static  Light GetLightObject (int instanceId) ;

}

[UsedByNativeCode]
[System.Runtime.InteropServices.StructLayout (System.Runtime.InteropServices.LayoutKind.Sequential)]
public partial struct VisibleReflectionProbe
{
            public Bounds bounds;
            public Matrix4x4 localToWorld;
            public Vector4 hdr;
            public Vector3 center;
            public float blendDistance;
            public int importance;
            public int boxProjection;
            private int instanceId;
            private int textureId;
    public Texture texture { get { return GetTextureObject(textureId); } }
    
    
    [UnityEngine.Scripting.GeneratedByOldBindingsGeneratorAttribute] // Temporarily necessary for bindings migration
    [System.Runtime.CompilerServices.MethodImplAttribute((System.Runtime.CompilerServices.MethodImplOptions)0x1000)]
    extern private static  Texture GetTextureObject (int textureId) ;

    public ReflectionProbe probe { get { return GetReflectionProbeObject(instanceId); } }
    
    
    [UnityEngine.Scripting.GeneratedByOldBindingsGeneratorAttribute] // Temporarily necessary for bindings migration
    [System.Runtime.CompilerServices.MethodImplAttribute((System.Runtime.CompilerServices.MethodImplOptions)0x1000)]
    extern private static  ReflectionProbe GetReflectionProbeObject (int instanceId) ;

}

[UsedByNativeCode]
[System.Runtime.InteropServices.StructLayout (System.Runtime.InteropServices.LayoutKind.Sequential)]
public partial struct CullResults
{
    
            public VisibleLight[]           visibleLights;
            public VisibleLight[]           visibleOffscreenVertexLights;
            public VisibleReflectionProbe[] visibleReflectionProbes;
            internal IntPtr                 cullResults;
    
    
    unsafe public static bool GetCullingParameters(Camera camera, out ScriptableCullingParameters cullingParameters)
        {
            return GetCullingParameters_Internal(camera, out cullingParameters, sizeof(ScriptableCullingParameters));
        }
    
    
    [UnityEngine.Scripting.GeneratedByOldBindingsGeneratorAttribute] // Temporarily necessary for bindings migration
    [System.Runtime.CompilerServices.MethodImplAttribute((System.Runtime.CompilerServices.MethodImplOptions)0x1000)]
    extern private static  bool GetCullingParameters_Internal (Camera camera, out ScriptableCullingParameters cullingParameters, int managedCullingParametersSize) ;

    internal static void Internal_Cull (ref ScriptableCullingParameters parameters, ScriptableRenderContext renderLoop, out CullResults results) {
        INTERNAL_CALL_Internal_Cull ( ref parameters, ref renderLoop, out results );
    }

    [UnityEngine.Scripting.GeneratedByOldBindingsGeneratorAttribute] // Temporarily necessary for bindings migration
    [System.Runtime.CompilerServices.MethodImplAttribute((System.Runtime.CompilerServices.MethodImplOptions)0x1000)]
    private extern static void INTERNAL_CALL_Internal_Cull (ref ScriptableCullingParameters parameters, ref ScriptableRenderContext renderLoop, out CullResults results);
    public static CullResults Cull(ref ScriptableCullingParameters parameters, ScriptableRenderContext renderLoop)
        {
            CullResults res;
            Internal_Cull(ref parameters, renderLoop, out res);
            return res;
        }
    
    
    public static bool Cull(Camera camera, ScriptableRenderContext renderLoop, out CullResults results)
        {
            results.cullResults = IntPtr.Zero;
            results.visibleLights = null;
            results.visibleOffscreenVertexLights = null;
            results.visibleReflectionProbes = null;

            ScriptableCullingParameters cullingParams;
            if (!GetCullingParameters(camera, out cullingParams))
                return false;

            results = Cull(ref cullingParams, renderLoop);
            return true;
        }
    
    
    public bool GetShadowCasterBounds(int lightIndex, out Bounds outBounds) { return GetShadowCasterBounds(cullResults, lightIndex, out outBounds); }
    
    
    [UnityEngine.Scripting.GeneratedByOldBindingsGeneratorAttribute] // Temporarily necessary for bindings migration
    [System.Runtime.CompilerServices.MethodImplAttribute((System.Runtime.CompilerServices.MethodImplOptions)0x1000)]
    extern private static  bool GetShadowCasterBounds (IntPtr cullResults, int lightIndex, out Bounds bounds) ;

    public int GetLightIndicesCount() { return GetLightIndicesCount(cullResults); }
    
    
    [UnityEngine.Scripting.GeneratedByOldBindingsGeneratorAttribute] // Temporarily necessary for bindings migration
    [System.Runtime.CompilerServices.MethodImplAttribute((System.Runtime.CompilerServices.MethodImplOptions)0x1000)]
    extern private static  int GetLightIndicesCount (IntPtr cullResults) ;

    public void FillLightIndices(ComputeBuffer computeBuffer) { FillLightIndices(cullResults, computeBuffer); }
    
    
    [UnityEngine.Scripting.GeneratedByOldBindingsGeneratorAttribute] // Temporarily necessary for bindings migration
    [System.Runtime.CompilerServices.MethodImplAttribute((System.Runtime.CompilerServices.MethodImplOptions)0x1000)]
    extern private static  void FillLightIndices (IntPtr cullResults, ComputeBuffer computeBuffer) ;

    internal int[] GetLightIndexMap()
        {
            return GetLightIndexMap(cullResults);
        }
    
    
    [UnityEngine.Scripting.GeneratedByOldBindingsGeneratorAttribute] // Temporarily necessary for bindings migration
    [System.Runtime.CompilerServices.MethodImplAttribute((System.Runtime.CompilerServices.MethodImplOptions)0x1000)]
    extern private static  int[] GetLightIndexMap (IntPtr cullResults) ;

    internal void SetLightIndexMap(int[] mapping)
        {
            SetLightIndexMap(cullResults, mapping);
        }
    
    
    [UnityEngine.Scripting.GeneratedByOldBindingsGeneratorAttribute] // Temporarily necessary for bindings migration
    [System.Runtime.CompilerServices.MethodImplAttribute((System.Runtime.CompilerServices.MethodImplOptions)0x1000)]
    extern private static  void SetLightIndexMap (IntPtr cullResults, int[] mapping) ;

    public bool ComputeSpotShadowMatricesAndCullingPrimitives(int activeLightIndex,
            out Matrix4x4 viewMatrix, out Matrix4x4 projMatrix, out ShadowSplitData shadowSplitData)
        {
            return ComputeSpotShadowMatricesAndCullingPrimitives(cullResults, activeLightIndex,
                out viewMatrix, out projMatrix, out shadowSplitData);
        }
    
    
    [UnityEngine.Scripting.GeneratedByOldBindingsGeneratorAttribute] // Temporarily necessary for bindings migration
    [System.Runtime.CompilerServices.MethodImplAttribute((System.Runtime.CompilerServices.MethodImplOptions)0x1000)]
    extern private static  bool ComputeSpotShadowMatricesAndCullingPrimitives (IntPtr cullResults, int activeLightIndex,
            out Matrix4x4 viewMatrix, out Matrix4x4 projMatrix, out ShadowSplitData shadowSplitData) ;

    public bool ComputePointShadowMatricesAndCullingPrimitives(int activeLightIndex,
            CubemapFace cubemapFace, float fovBias,
            out Matrix4x4 viewMatrix, out Matrix4x4 projMatrix, out ShadowSplitData shadowSplitData)
        {
            return ComputePointShadowMatricesAndCullingPrimitives(cullResults, activeLightIndex,
                cubemapFace, fovBias,
                out viewMatrix, out projMatrix, out shadowSplitData);
        }
    
    
    [UnityEngine.Scripting.GeneratedByOldBindingsGeneratorAttribute] // Temporarily necessary for bindings migration
    [System.Runtime.CompilerServices.MethodImplAttribute((System.Runtime.CompilerServices.MethodImplOptions)0x1000)]
    extern private static  bool ComputePointShadowMatricesAndCullingPrimitives (IntPtr cullResults, int activeLightIndex,
            CubemapFace cubemapFace, float fovBias,
            out Matrix4x4 viewMatrix, out Matrix4x4 projMatrix, out ShadowSplitData shadowSplitData) ;

    public bool ComputeDirectionalShadowMatricesAndCullingPrimitives(int activeLightIndex,
            int splitIndex, int splitCount, Vector3 splitRatio, int shadowResolution, float shadowNearPlaneOffset,
            out Matrix4x4 viewMatrix, out Matrix4x4 projMatrix, out ShadowSplitData shadowSplitData)
        {
            return ComputeDirectionalShadowMatricesAndCullingPrimitives(cullResults, activeLightIndex,
                splitIndex, splitCount, splitRatio, shadowResolution, shadowNearPlaneOffset,
                out viewMatrix, out projMatrix, out shadowSplitData);
        }
    
    
    private static bool ComputeDirectionalShadowMatricesAndCullingPrimitives (IntPtr cullResults, int activeLightIndex,
            int splitIndex, int splitCount, Vector3 splitRatio, int shadowResolution, float shadowNearPlaneOffset,
            out Matrix4x4 viewMatrix, out Matrix4x4 projMatrix, out ShadowSplitData shadowSplitData) {
        return INTERNAL_CALL_ComputeDirectionalShadowMatricesAndCullingPrimitives ( cullResults, activeLightIndex, splitIndex, splitCount, ref splitRatio, shadowResolution, shadowNearPlaneOffset, out viewMatrix, out projMatrix, out shadowSplitData );
    }

    [UnityEngine.Scripting.GeneratedByOldBindingsGeneratorAttribute] // Temporarily necessary for bindings migration
    [System.Runtime.CompilerServices.MethodImplAttribute((System.Runtime.CompilerServices.MethodImplOptions)0x1000)]
    private extern static bool INTERNAL_CALL_ComputeDirectionalShadowMatricesAndCullingPrimitives (IntPtr cullResults, int activeLightIndex, int splitIndex, int splitCount, ref Vector3 splitRatio, int shadowResolution, float shadowNearPlaneOffset, out Matrix4x4 viewMatrix, out Matrix4x4 projMatrix, out ShadowSplitData shadowSplitData);
}

}