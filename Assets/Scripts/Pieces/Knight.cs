using System.Collections.Generic;
using UnityEngine;

public class Knight : Piece
{
    public override List<Vector2Int> GetAvailableMoves(ref Piece[,] board, int tileCountX, int tileCountY)
    {
        List<Vector2Int> r = new List<Vector2Int>();


        // top right
        if(currentX +1  < tileCountX && currentY + 2< tileCountY)
        {
            if (board[currentX + 1, currentY + 2] == null)
            {
                r.Add(new Vector2Int(currentX + 1, currentY + 2));
            } else
            {
                if (board[currentX + 1, currentY + 2].team != team)
                {
                    r.Add(new Vector2Int(currentX + 1, currentY + 2));
                }
            }
        }

        // top left
        if (currentX - 1 >=0 && currentY + 2 < tileCountY)
        {
            if (board[currentX - 1, currentY + 2] == null)
            {
                r.Add(new Vector2Int(currentX - 1, currentY + 2));
            }
            else
            {
                if (board[currentX - 1, currentY + 2].team != team)
                {
                    r.Add(new Vector2Int(currentX - 1, currentY + 2));
                }
            }
        }
        // bottom right
        if (currentX + 1< tileCountX && currentY - 2 >= 0)
        {
            if (board[currentX + 1, currentY - 2] == null)
            {
                r.Add(new Vector2Int(currentX + 1, currentY - 2));
            }
            else
            {
                if (board[currentX + 1, currentY - 2].team != team)
                {
                    r.Add(new Vector2Int(currentX + 1, currentY - 2));
                }
            }
        }
        // bottom left
        if (currentX - 1 >= 0 && currentY - 2 >= 0)
        {
            if (board[currentX - 1, currentY - 2] == null)
            {
                r.Add(new Vector2Int(currentX - 1, currentY - 2));
            }
            else
            {
                if (board[currentX - 1, currentY - 2].team != team)
                {
                    r.Add(new Vector2Int(currentX - 1, currentY - 2));
                }
            }
        }
        return r;
    }
}
