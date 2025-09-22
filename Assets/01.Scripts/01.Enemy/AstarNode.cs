using System;
using UnityEngine;

public struct AstarNode : IComparable<AstarNode>
{
    public int x, y;
    public int distanceFromStart;
    public int remainDistance;

    public Vector3Int prevPosition;
    public Vector3Int currentPosition;

    public int TotalDistance => distanceFromStart + remainDistance;

    public AstarNode(Vector3Int start, Vector3Int end, Vector3Int position, Vector3Int prevNode)
    {
        x = position.x;
        y = position.y;
        currentPosition = new Vector3Int(x, y);
        this.prevPosition = prevNode;

        distanceFromStart = Mathf.Abs(start.x - x);
        distanceFromStart += Mathf.Abs(start.y - y);

        remainDistance = Mathf.Abs(end.x - x);
        remainDistance += Mathf.Abs(end.y - y);
    }

    public int CompareTo(AstarNode other)
    {
        return TotalDistance.CompareTo(other.TotalDistance);
    }
}
