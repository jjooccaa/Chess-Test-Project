using System.Collections.Generic;
using UnityEngine;

public class King : Piece
{
    public override List<Vector2Int> GetAvailableMoves(ref Piece[,] board, int tileCountX, int tileCountY)
    {
        List<Vector2Int> r = new List<Vector2Int>();

        // front
        if(currentY + 1 < tileCountY)
        {
            if(board[currentX, currentY + 1] == null)
            {
                r.Add(new Vector2Int(currentX,currentY + 1));
            }
            if(board[currentX, currentY + 1] != null)
            {
                if(board[currentX, currentY + 1].team != team)
                {
                    r.Add(new Vector2Int(currentX, currentY + 1));
                }
                
            }
        }

        // bottom
        if (currentY - 1 >= 0)
        {
            if (board[currentX, currentY - 1] == null)
            {
                r.Add(new Vector2Int(currentX, currentY - 1));
            }
            if (board[currentX, currentY - 1] != null)
            {
                if (board[currentX, currentY - 1].team != team)
                {
                    r.Add(new Vector2Int(currentX, currentY - 1));
                }

            }
        }
        // right
        if (currentX + 1 < tileCountX)
        {
            if (board[currentX + 1, currentY] == null)
            {
                r.Add(new Vector2Int(currentX + 1, currentY));
            }
            if (board[currentX + 1, currentY] != null)
            {
                if (board[currentX + 1, currentY].team != team)
                {
                    r.Add(new Vector2Int(currentX + 1, currentY));
                }

            }
        }

        // left
        if (currentX - 1 >= 0)
        {
            if (board[currentX - 1, currentY] == null)
            {
                r.Add(new Vector2Int(currentX - 1, currentY));
            }
            if (board[currentX - 1, currentY] != null)
            {
                if (board[currentX - 1, currentY].team != team)
                {
                    r.Add(new Vector2Int(currentX - 1, currentY));
                }

            }
        }
        return r;
    }
}
