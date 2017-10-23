using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EndlessRunner
{
    public class ObstacleFacade
    {
        private Pole pole;
        private Tree tree;
        private Cloud cloud;
        private Stone stone;
        private Red red;
        private Green green;
        private Yellow yellow;
        private Grey grey;
        private Blue blue;

        public ObstacleFacade()
        {
            pole = new Pole();
            tree = new Tree();
            cloud = new Cloud();
            stone = new Stone();
            red = new Red();
            green = new Green();
            grey = new Grey();
            blue = new Blue();
        }

        public void drawGreyPole()
        {
            pole.draw();
            grey.fill();
        }

        public void drawGreenTree()
        {
            tree.draw();
            green.fill();
        }

        public void drawBlueCloud()
        {
            cloud.draw();
            blue.fill();
        }

        public void drawYellowStone()
        {
            stone.draw();
            yellow.fill();
        }

        public void drawRedStone()
        {
            stone.draw();
            red.fill();
        }

        public void calculateDIstanceBetweenObstacles() { }

        public void checkPrevObstacle() { }
    }
}
