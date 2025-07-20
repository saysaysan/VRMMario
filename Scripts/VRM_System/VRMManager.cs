using UnityEngine;
using VRM;

public class VRMManager : MonoBehaviour
{
    public TextAsset vrmAsset;
    private GameObject currentModel;

    void Start()
    {
        if (vrmAsset != null)
        {
            LoadVRM(vrmAsset);
        }
    }

    public void LoadVRM(TextAsset asset)
    {
        if (currentModel != null)
        {
            Destroy(currentModel);
            currentModel = null;
        }

        if (asset == null) return;

        byte[] bytes = asset.bytes;
        var context = new VRMImporterContext();
        context.ParseGlb(bytes);
        currentModel = context.Load();
        currentModel.transform.SetParent(transform, false);
        context.ShowMeshes();
    }

    public void UnloadVRM()
    {
        if (currentModel != null)
        {
            Destroy(currentModel);
            currentModel = null;
        }
    }
}
