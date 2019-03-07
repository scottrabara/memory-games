using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Board : MonoBehaviour
{
    public Piece[,] pieces = new Piece[8,8];
    public GameObject whitePiecePrefab;
    public GameObject blackPiecePrefab;
    public Vector3 boardOffSet = new Vector3(-0.01f, -0.01f, 0);

    internal void Start()
    {
        GenerateBoard();
    }

    private void GenerateBoard()
    {
        for (int z = 0; z < 3; z++)
        {
            for (int x = 0; x < 8; x += 2)
            {
                GeneratePiece(x, z, true);
                GeneratePiece(x, z, false);
            }
        }
    }

    private void GeneratePiece(int x, int z, bool isBlack)
    {
        var go = Instantiate(isBlack ? blackPiecePrefab : whitePiecePrefab);
        go.transform.SetParent(transform);
        
        var p = go.GetComponent<Piece>();
        
        pieces[x, z] = p;
        var startX = isBlack ? -3.5f + (z % 2) : -3.5f + (1 - (z % 2));
        var factorX = x * 1.0f;

        var startZ = isBlack ? -3.5f : 3.5f;
        var factorZ = isBlack ? z * 1.0f : z * -1.0f;
        MovePiece(p, startX + factorX, startZ + factorZ);
    }

    private void MovePiece(Piece p, float x, float z)
    {
        p.transform.position =
            new Vector3(
                x,  // x
                0f, // y
                z); // z

        p.transform.rotation = Quaternion.Euler(-90, 0, 0);
    }
}
