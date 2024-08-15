using Sudoku;

namespace SudokuSolver.UI.Data;

public class GridService
{
    public Board? SudokuGrid { get; set; }

    public void ClearGrid()
    {
        SudokuGrid = null;
    }
}