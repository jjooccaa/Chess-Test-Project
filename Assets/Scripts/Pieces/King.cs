using System.Collections.Generic;
using UnityEngine;

public class King : Piece
{
    public override List<Vector2Int> GetAvailableMoves(ref Piece[,] board, int tileCountX, int tileCountY)
    {
        List<Vector2Int> r = new List<Vector2Int>();

        // Right
        if(currentX + 1 <tileCountX)
        {
            //Right
            if(board[currentX + 1, currentY] == null)
            {
                r.Add(new Vector2Int(currentX + 1, currentY));
            } else if(board[currentX + 1, currentY].team != team)
            {
                r.Add(new Vector2Int(currentX + 1, currentY));
            }

            //Top Right
            if(currentY + 1 < tileCountY)
            {
                if (board[currentX + 1, currentY + 1] == null)
                {
                    r.Add(new Vector2Int(currentX + 1, currentY + 1));
                }
                else if (board[currentX + 1, currentY + 1].team != team)
                {
                    r.Add(new Vector2Int(currentX + 1, currentY + 1));
                }
            }
            //Bottom Right
            if (currentY - 1 >= 0 )
            {
                if (board[currentX + 1, currentY - 1] == null)
                {
                    r.Add(new Vector2Int(currentX + 1, currentY - 1));
                }
                else if (board[currentX + 1, currentY - 1].team != team)
                {
                    r.Add(new Vector2Int(currentX + 1, currentY - 1));
                }
            }
        }

        // Left
        if (currentX - 1 >= 0)
        {
            //Left
            if (board[currentX - 1, currentY] == null)
            {
                r.Add(new Vector2Int(currentX - 1, currentY));
            }
            else if (board[currentX - 1, currentY].team != team)
            {
                r.Add(new Vector2Int(currentX - 1, currentY));
            }

            //Top Right
            if (currentY + 1 < tileCountY)
            {
                if (board[currentX - 1, currentY + 1] == null)
                {
                    r.Add(new Vector2Int(currentX - 1, currentY + 1));
                }
                else if (board[currentX - 1, currentY + 1].team != team)
                {
                    r.Add(new Vector2Int(currentX - 1, currentY + 1));
                }
            }
            //Bottom Right
            if (currentY - 1 >= 0)
            {
                if (board[currentX - 1, currentY - 1] == null)
                {
                    r.Add(new Vector2Int(currentX - 1, currentY - 1));
                }
                else if (board[currentX - 1, currentY - 1].team != team)
                {
                    r.Add(new Vector2Int(currentX - 1, currentY - 1));
                }
            }
        }

        // Up
        if(currentY + 1 < tileCountY)
        {
            if(board[currentX, currentY + 1] == null || board[currentX, currentY + 1].team != team)
            {
                r.Add(new Vector2Int(currentX, currentY + 1));
            }
        }

        // Down
        if (currentY - 1 >= 0)
        {
            if (board[currentX, currentY - 1] == null || board[currentX, currentY - 1].team != team)
            {
                r.Add(new Vector2Int(currentX, currentY - 1));
            }
        }

        return r;
    }

    public override SpecialMove GetSpecialMoves(ref Piece[,] board, ref List<Vector2Int[]> moveList, ref List<Vector2Int> availableMoves)
    {
        SpecialMove r = SpecialMove.None;

        int ourY = (team == 0) ? 0 : 7;
        var kingMove = moveList.Find(m => m[0].x == 4 && m[0].y == ourY); // Check if king has ever moved
        var leftRook = moveList.Find(m => m[0].x == 0 && m[0].y == ourY); // Check if rook has ever moved
        var rightRook = moveList.Find(m => m[0].x == 7 && m[0].y == ourY); // -||-

        if(kingMove == null && currentX == 4)
        {
                // Left Rook
                if(leftRook == null)
                {
                    if(board[0,ourY].type == ChessPieceType.Rook)
                    {

                            if(board[3,ourY] == null && board[2,ourY] == null && board[1,ourY] == null)
                            {
                                availableMoves.Add(new Vector2Int(2, ourY));
                                r = SpecialMove.Castling;
                            }
                        
                    }
                }
                // Right Rook
                if (rightRook == null)
                {
                    if (board[7, ourY].type == ChessPieceType.Rook)
                    {

                            if (board[5, ourY] == null && board[6, ourY] == null)
                            {
                                availableMoves.Add(new Vector2Int(6, ourY));
                                r = SpecialMove.Castling;
                            }
                        
                    }
                }
        }


        return r;
    }
}
