﻿using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using senrenbanka.murasame.qqbot.BotImpl.ChineseChess.Chessman;

namespace senrenbanka.murasame.qqbot.BotImpl.ChineseChess
{
    public class Chessboard
    {
        private IChineseChessman[,] _chessboard = new IChineseChessman[9,10];

        private readonly Dictionary<(int x, int y), IChineseChessman> _initChessmanCoordinateDictionary = new Dictionary<(int x, int y), IChineseChessman>
        {
            //Black pieces
            [(0, 0)] = new BlackChariots(), 
            [(1, 0)] = new BlackKnights(), 
            [(2, 0)] = new BlackElephants(),
            [(3, 0)] = new BlackMandarins(), 
            [(4, 0)] = new BlackKing(),
            [(5, 0)] = new BlackMandarins(), 
            [(6, 0)] = new BlackElephants(),
            [(7, 0)] = new BlackKnights(),
            [(8, 0)] = new BlackChariots(),
            [(1, 2)] = new BlackCannons(), 
            [(7, 2)] = new BlackCannons(),
            [(0, 3)] = new BlackPawns(),
            [(2, 3)] = new BlackPawns(),
            [(4, 3)] = new BlackPawns(), 
            [(6, 3)] = new BlackPawns(),
            [(8, 3)] = new BlackPawns(),
            //Red pieces
            [(0, 9)] = new RedChariots(), 
            [(1, 9)] = new RedKnights(), 
            [(2, 9)] = new RedElephants(),
            [(3, 9)] = new RedMandarins(),
            [(4, 9)] = new RedKing(),
            [(5, 9)] = new RedMandarins(),
            [(6, 9)] = new RedElephants(),
            [(7, 9)] = new RedKnights(),
            [(8, 9)] = new RedChariots(),
            [(1, 7)] = new RedCannons(),
            [(7, 7)] = new RedCannons(),
            [(0, 6)] = new RedPawns(),
            [(2, 6)] = new RedPawns(),
            [(4, 6)] = new RedPawns(), 
            [(6, 6)] = new RedPawns(), 
            [(8, 6)] = new RedPawns()
        };

        private void Init()
        {
            for (var i = 0; i < 9; i++)
            {
                for (var j = 0; j < 10; j++)
                {
                    if (_initChessmanCoordinateDictionary.Any(pieces => pieces.Key.x == i && pieces.Key.y == j))
                    {
                        _chessboard[i, j] = _initChessmanCoordinateDictionary[(i, j)];
                    }
                    else
                    {
                        _chessboard[i, j] = new EmptyChessman();
                    }
                }
            }
        }
    }
}