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
        for (int y = 0; y < 3; y++)
        {
            for (int x = 0; x < 8; x += 2)
            {
                GeneratePiece(x, y);
            }
        }
    }

    private void GeneratePiece(int x, int y)
    {
        var go = Instantiate(blackPiecePrefab, boardOffSet, Quaternion.identity) as GameObject;

        go.transform.SetParent(transform);
        
        var p = go.GetComponent<Piece>();
        
        pieces[x, y] = p;

        MovePiece(p, x, y);
    }

    private void MovePiece(Piece p, int x, int y)
    {
        // p.transform.position = (Vector3.right * 0) + (Vector3.forward * 0);
        // p.transform.position = boardOffSet;
    }
}
