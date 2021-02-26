using System.Collections.Generic;
using System.Linq;

namespace Model
{
    public class Cell
    {
        public bool isAlive;
        private bool isAliveNext;

        public readonly List<Cell> neighbors = new List<Cell>();

        public void determineNextLiveState()
        {
            int liveNeighbors = neighbors.Where(x => x.isAlive).Count();

            if (isAlive)
                isAliveNext = liveNeighbors == 2 || liveNeighbors == 3;

            else
                isAliveNext = liveNeighbors == 3;
        }

        public void Advance()
        {
            isAlive = isAliveNext;
        }
    }
}
