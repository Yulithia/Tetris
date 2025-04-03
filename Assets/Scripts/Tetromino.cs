using UnityEngine;
using UnityEngine.Tilemaps;

// Tetromino is a geometric shape composed of four squares, connected orthogonally (i.e. at the edges and not the corners)
// Each letter represents the shape of tetromino
public enum Tetromino
{
    I,
    O,
    T, 
    J,
    L,
    S,
    Z
}

// Data structure for tetrominoes
[System.Serializable]
public struct TetrominoData
{
    public Tetromino tetromino;
    public Tile tile;
    public Vector2Int[] cells { get; private set; }

    public void Initialize()
    {
        this.cells = Data.Cells[this.tetromino];
    }
}

