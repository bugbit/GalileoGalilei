using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public enum ETypeMaterials
{
    Normal, mat2k, mat8k
}

public class MaterialsTypes : MonoBehaviour
{
    public Material normal;
    public Material mat2k;
    public Material mat8k;

    public Material GetTypeMaterial(ETypeMaterials type)
    {
        switch (type)
        {
            case ETypeMaterials.mat2k:
                return mat2k ?? normal;
            case ETypeMaterials.mat8k:
                return mat8k ?? mat2k ?? normal;
            default:
                return normal;
        }
    }

    public void ChangeMaterial(GameObject obj, ETypeMaterials type)
    {
        var material = GetTypeMaterial(type);
        var meshRenderer = obj.GetComponent<MeshRenderer>();

        meshRenderer.material = material;
    }
}
