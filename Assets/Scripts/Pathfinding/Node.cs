using UnityEngine;

public class Node
{
    public bool walkable;
    public Vector3 worldPosition; //Node Position in the world unit
    public int gridX;
    public int gridY;

    public int gCost;
    public int hCost;
    public Node parent;

    public Node(bool _walkable, Vector3 _worldPosition, int gridX, int gridY)
    {
        this.walkable = _walkable;
        this.worldPosition = _worldPosition;
        this.gridX = gridX;
        this.gridY = gridY;
    }

    public int FCost
    {
        get { return gCost + hCost; }
    }
}

