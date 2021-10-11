using System.Collections;
using System.Collections.Generic;
using Unity.Entities;
using UnityEngine;

[System.Serializable]
public struct MoveComponent : IComponentData
{
    public Vector3 position;
    public Quaternion rotation;

}
