﻿namespace GrandChessTree.Shared.Helpers;

public static class Constants
{
    public const int WhiteEnpassantOffset = 5 * 8;
    public const int BlackEnpassantOffset = 2 * 8;

    public const ulong BlackKingSideCastleRookPosition = 1UL << 63;
    public const ulong BlackKingSideCastleEmptyPositions = (1UL << 61) | (1UL << 62);
    public const ulong BlackQueenSideCastleRookPosition = 1UL << 56;
    public const ulong BlackQueenSideCastleEmptyPositions = (1UL << 57) | (1UL << 58) | (1UL << 59);

    public const ulong WhiteKingSideCastleRookPosition = 1UL << 7;
    public const ulong WhiteKingSideCastleEmptyPositions = (1UL << 6) | (1UL << 5);
    public const ulong WhiteQueenSideCastleRookPosition = 1UL;
    public const ulong WhiteQueenSideCastleEmptyPositions = (1UL << 1) | (1UL << 2) | (1UL << 3);
    
    
    
    public const ulong NotAFile = 0xFEFEFEFEFEFEFEFE; // All squares except column 'A'
    public const ulong NotHFile = 0x7F7F7F7F7F7F7F7F; // All squares except column 'H'

}